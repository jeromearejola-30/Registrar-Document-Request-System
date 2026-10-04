Imports MySql.Data.MySqlClient

Public Class frmRequestDetails

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    ' Set by frmDocumentRequest before the page is shown
    Public Property RequestID As String = ""

    ' What the database held when the page loaded (used to detect changes and to protect an issued OR number)
    Private originalStatus As String = ""
    Private originalPayment As String = ""
    Private currentOrNo As String = ""

    Private Const MaxVisibleItemRows As Integer = 8

    ' A request can only be cancelled within this many days of its request date; after that it is past due
    Private Const CancelWindowDays As Integer = 7
    Private requestDate As DateTime = DateTime.Today
    Private ReadOnly tip As New ToolTip()

    Private Sub frmRequestDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 860)
        Theme.StyleGrid(dgvItems)

        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(New Object() {"Pending", "Processing", "Ready for Release", "Released", "Cancelled"})
        cboPaymentStatus.Items.Clear()
        cboPaymentStatus.Items.AddRange(New Object() {"Unpaid", "Paid"})

        If String.IsNullOrEmpty(RequestID) Then
            MessageBox.Show("No request was selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToDocumentRequests()
            Return
        End If

        If Not LoadRequest() Then
            ReturnToDocumentRequests()
            Return
        End If
        LoadItems()
    End Sub

    ' ---------------------------------------------------------------
    ' Loading
    ' ---------------------------------------------------------------
    Private Function LoadRequest() As Boolean
        Try
            Dim sql As String = "SELECT r.RequestNo, r.StudentID, " &
                                "CONCAT(s.FirstName, ' ', IF(s.MiddleName IS NULL OR s.MiddleName = '', '', CONCAT(LEFT(s.MiddleName, 1), '. ')), s.LastName) AS StudentName, " &
                                "r.RequestDate, r.TotalAmount, r.PaymentStatus, r.ORNo, r.ORDate, r.Status, u.Username AS CreatedBy " &
                                "FROM tblrequest r " &
                                "LEFT JOIN tblstudents s ON r.StudentID = s.StudentID " &
                                "LEFT JOIN tblusers u ON r.CreatedBy = u.UserID " &
                                "WHERE r.RequestID = @id"
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand(sql, c)
                    cmd.Parameters.AddWithValue("@id", RequestID)
                    Using r As MySqlDataReader = cmd.ExecuteReader()
                        If Not r.Read() Then
                            MessageBox.Show("That request could not be found. It may have been removed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return False
                        End If

                        lblRequestNo.Text = Convert.ToString(r("RequestNo"))
                        If Not IsDBNull(r("RequestDate")) Then requestDate = Convert.ToDateTime(r("RequestDate"))
                        lblStudentNo.Text = TextOrDash(r("StudentID"))
                        lblStudentName.Text = TextOrDash(r("StudentName"))
                        lblCreatedBy.Text = TextOrDash(r("CreatedBy"))
                        lblRequestDate.Text = If(IsDBNull(r("RequestDate")), "-", Convert.ToDateTime(r("RequestDate")).ToString("MMMM dd, yyyy"))
                        lblTotalAmount.Text = "₱ " & If(IsDBNull(r("TotalAmount")), 0D, Convert.ToDecimal(r("TotalAmount"))).ToString("N2")

                        originalStatus = Convert.ToString(r("Status")).Trim()
                        originalPayment = Convert.ToString(r("PaymentStatus")).Trim()
                        currentOrNo = Convert.ToString(r("ORNo")).Trim()

                        lblOrNo.Text = If(currentOrNo = "", "Not issued yet", currentOrNo)
                        lblOrDate.Text = If(IsDBNull(r("ORDate")), "-", Convert.ToDateTime(r("ORDate")).ToString("MMMM dd, yyyy"))
                    End Using
                End Using
            End Using

            SelectItem(cboStatus, originalStatus)
            SelectItem(cboPaymentStatus, originalPayment)

            ' Once an OR number has been issued, the payment can no longer be switched back to Unpaid
            cboPaymentStatus.Enabled = (currentOrNo = "")

            ' Cancelled is only offered while the request can still be cancelled (see CancelBlockedReason)
            If Not String.Equals(originalStatus, "Cancelled", StringComparison.OrdinalIgnoreCase) Then
                Dim reason As String = CancelBlockedReason()
                If reason <> "" Then
                    cboStatus.Items.Remove("Cancelled")
                    tip.SetToolTip(cboStatus, reason)
                Else
                    tip.SetToolTip(cboStatus, $"This request can be cancelled until {CancelDeadline():MMMM dd, yyyy} ({CancelWindowDays} days after the request date).")
                End If
            End If

            ApplyBadge(originalStatus)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error loading the request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Last day on which this request may still be cancelled
    Private Function CancelDeadline() As DateTime
        Return requestDate.Date.AddDays(CancelWindowDays)
    End Function

    Private Function IsPastCancelWindow() As Boolean
        Return DateTime.Today > CancelDeadline()
    End Function

    ' Empty text = the request can be cancelled. Otherwise the text says why it cannot.
    ' Ready for Release can still be cancelled (inside the window); Released cannot, the document has been handed over.
    Private Function CancelBlockedReason() As String
        If String.Equals(originalStatus, "Released", StringComparison.OrdinalIgnoreCase) Then
            Return "This request has already been Released, so it can no longer be cancelled."
        End If
        If IsPastCancelWindow() Then
            Return $"Past due: this request can no longer be cancelled. It was requested on {requestDate:MMMM dd, yyyy}, so the last day to cancel was {CancelDeadline():MMMM dd, yyyy} ({CancelWindowDays} days after the request date)."
        End If
        Return ""
    End Function

    Private Sub LoadItems()
        Try
            Dim sql As String = "SELECT d.DocumentName AS Document, rd.Quantity AS Qty, rd.Amount AS UnitFee, rd.SubTotal " &
                                "FROM tblrequestdetails rd " &
                                "INNER JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                                "WHERE rd.RequestID = @id"
            Dim dt As New DataTable()
            Using c As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(sql, c)
                    cmd.Parameters.AddWithValue("@id", RequestID)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgvItems.DataSource = dt
            FormatItemColumns()

            ' The table is exactly as tall as its rows (up to 8), so the page itself does the scrolling
            Dim rows As Integer = Math.Max(1, Math.Min(dt.Rows.Count, MaxVisibleItemRows))
            Dim h As Integer = dgvItems.ColumnHeadersHeight + dgvItems.RowTemplate.Height * rows + LogicalToDeviceUnits(2)
            pnlItemsBorder.Height = h
            dgvItems.ScrollBars = If(dt.Rows.Count > MaxVisibleItemRows, ScrollBars.Vertical, ScrollBars.None)

            ' Tell Theme.FitFormCard that the card's content height changed
            OnSizeChanged(EventArgs.Empty)
        Catch ex As Exception
            MessageBox.Show("Error loading the requested documents: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatItemColumns()
        With dgvItems
            If Not .Columns.Contains("Document") Then Return
            .Columns("Document").FillWeight = 46
            .Columns("Qty").FillWeight = 10
            .Columns("UnitFee").FillWeight = 22
            .Columns("SubTotal").FillWeight = 22

            .Columns("UnitFee").HeaderText = "Unit Fee (₱)"
            .Columns("SubTotal").HeaderText = "Subtotal (₱)"

            For Each name As String In {"UnitFee", "SubTotal"}
                .Columns(name).DefaultCellStyle.Format = "N2"
                .Columns(name).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(name).DefaultCellStyle.Padding = New Padding(0, 0, 16, 0)
                .Columns(name).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(name).HeaderCell.Style.Padding = New Padding(0, 0, 16, 0)
            Next
            .Columns("Qty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Qty").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ClearSelection()
        End With
    End Sub

    ' ---------------------------------------------------------------
    ' Small helpers
    ' ---------------------------------------------------------------
    Private Shared Function TextOrDash(value As Object) As String
        Dim s As String = If(value Is Nothing OrElse IsDBNull(value), "", Convert.ToString(value).Trim())
        Return If(s = "", "-", s)
    End Function

    ' Selects the matching item; if the database holds a value that is not in the list, it is added so nothing is lost
    Private Shared Sub SelectItem(cbo As ComboBox, value As String)
        For i As Integer = 0 To cbo.Items.Count - 1
            If String.Equals(Convert.ToString(cbo.Items(i)), value, StringComparison.OrdinalIgnoreCase) Then
                cbo.SelectedIndex = i
                Return
            End If
        Next
        If value <> "" Then cbo.SelectedIndex = cbo.Items.Add(value)
    End Sub

    Private Sub ApplyBadge(status As String)
        lblStatusBadge.Text = status
        lblStatusBadge.BackColor = Theme.StatusColor(status)
        ' Amber (Pending) needs dark text; every other status color takes white
        lblStatusBadge.ForeColor = If(String.Equals(status, "Pending", StringComparison.OrdinalIgnoreCase), Theme.TextMain, Color.White)
    End Sub

    ' ---------------------------------------------------------------
    ' Save
    ' ---------------------------------------------------------------
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newStatus As String = cboStatus.Text.Trim()
        Dim newPayment As String = cboPaymentStatus.Text.Trim()

        If newStatus = "" OrElse newPayment = "" Then
            MessageBox.Show("Please choose both a payment status and a request status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim statusChanged As Boolean = Not String.Equals(newStatus, originalStatus, StringComparison.OrdinalIgnoreCase)
        Dim paymentChanged As Boolean = Not String.Equals(newPayment, originalPayment, StringComparison.OrdinalIgnoreCase)
        If Not statusChanged AndAlso Not paymentChanged Then
            MessageBox.Show("Nothing has changed.", "Request Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' A document can only be made ready or handed over once it is paid for
        Dim needsPayment As Boolean = String.Equals(newStatus, "Ready for Release", StringComparison.OrdinalIgnoreCase) OrElse
                                      String.Equals(newStatus, "Released", StringComparison.OrdinalIgnoreCase)
        If needsPayment AndAlso Not RequestHelper.IsPaid(newPayment) Then
            MessageBox.Show("Set the payment status to Paid before moving this request to Ready for Release or Released.",
                            "Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboPaymentStatus.Focus()
            Return
        End If

        ' The combo already hides "Cancelled" when it is not allowed; this is the safety net
        If statusChanged AndAlso String.Equals(newStatus, "Cancelled", StringComparison.OrdinalIgnoreCase) AndAlso CancelBlockedReason() <> "" Then
            MessageBox.Show(CancelBlockedReason(), "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Released and Cancelled are easy to click by accident, so ask first
        If statusChanged AndAlso (String.Equals(newStatus, "Released", StringComparison.OrdinalIgnoreCase) OrElse
                                  String.Equals(newStatus, "Cancelled", StringComparison.OrdinalIgnoreCase)) Then
            Dim confirmText As String = $"Mark request {lblRequestNo.Text} as {newStatus}?"
            ' A paid request that is cancelled is deducted from the Payment Report
            If String.Equals(newStatus, "Cancelled", StringComparison.OrdinalIgnoreCase) AndAlso RequestHelper.IsPaid(originalPayment) Then
                confirmText &= vbCrLf & vbCrLf & $"This request is already Paid ({lblTotalAmount.Text}). The amount will be deducted from the Payment Report."
            End If
            If MessageBox.Show(confirmText, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        End If

        Dim issuedOrNo As String = Nothing
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Try
                        ' Paid for the first time: issue the OR number now, in the same transaction as the update
                        Dim issuing As Boolean = RequestHelper.IsPaid(newPayment) AndAlso currentOrNo = ""
                        If issuing Then issuedOrNo = RequestHelper.NewORNumber(c, tx)

                        Dim sql As String = "UPDATE tblrequest SET Status = @status, PaymentStatus = @pay" &
                                            If(issuing, ", ORNo = @orNo, ORDate = @orDate", "") &
                                            " WHERE RequestID = @id"
                        Using cmd As New MySqlCommand(sql, c, tx)
                            cmd.Parameters.AddWithValue("@status", newStatus)
                            cmd.Parameters.AddWithValue("@pay", newPayment)
                            If issuing Then
                                cmd.Parameters.AddWithValue("@orNo", issuedOrNo)
                                cmd.Parameters.AddWithValue("@orDate", DateTime.Now.Date)
                            End If
                            cmd.Parameters.AddWithValue("@id", RequestID)
                            If cmd.ExecuteNonQuery() = 0 Then Throw New InvalidOperationException("The request no longer exists.")
                        End Using
                        tx.Commit()
                    Catch
                        tx.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            Dim message As String = "Request updated successfully!"
            If issuedOrNo IsNot Nothing Then message &= vbCrLf & vbCrLf & "OR Number issued: " & issuedOrNo
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToDocumentRequests()
        Catch ex As Exception
            MessageBox.Show("Error updating the request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ReturnToDocumentRequests()
    End Sub

    Private Sub ReturnToDocumentRequests()
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmDocumentRequest())
        Else
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class
