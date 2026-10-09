Imports MySql.Data.MySqlClient

Public Class frmRequestDetails

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    ' Set by frmDocumentRequest before the page is shown
    Public Property RequestID As String = ""


    ' What the database held when the page loaded (used to detect changes and to protect an issued OR number)
    Private originalStatus As String = ""
    Private originalPayment As String = ""
    Private currentOrNo As String = ""
    Private currentTotal As Decimal = 0D
    Private currentStudentName As String = ""
    Private btnRecordPayment As ThemedButton
    Private btnAdvance As ThemedButton
    Private btnCancelRequest As ThemedButton
    Private btnViewReceipt As ThemedButton
    Private Const MaxVisibleItemRows As Integer = 8


    ' Names of the documents on this request that are not Active right now ("" = all available)
    Private Function InactiveDocuments(c As MySqlConnection, tx As MySqlTransaction) As String
        Dim names As New List(Of String)()
        Using q As New MySqlCommand("SELECT d.DocumentName FROM tblrequestdetails rd " &
                                    "JOIN tbldocuments d ON d.DocumentID = rd.DocumentID " &
                                    "WHERE rd.RequestID = @id AND d.Status <> 'Active'", c, tx)
            q.Parameters.AddWithValue("@id", RequestID)
            Using r As MySqlDataReader = q.ExecuteReader()
                While r.Read()
                    names.Add(Convert.ToString(r("DocumentName")))
                End While
            End Using
        End Using
        Return String.Join(", ", names)
    End Function


    ' Which button is visible depends only on the request's current status and payment
    Private Sub ConfigureActions()
        Dim isPending As Boolean = (originalStatus = "Pending")
        Dim isPaid As Boolean = RequestHelper.IsPaid(originalPayment)
        Dim nextStage As String = NextStageName()

        ' The dropdowns are now display-only; changes happen through the buttons
        cboStatus.Enabled = False
        cboPaymentStatus.Enabled = False
        btnSave.Visible = False

        btnRecordPayment.Visible = isPending AndAlso Not isPaid
        btnAdvance.Visible = isPaid AndAlso nextStage <> ""
        btnAdvance.Text = If(nextStage = "", "", "Move to " & nextStage)
        btnCancelRequest.Visible = isPending   ' the only status that can be cancelled
        btnViewReceipt.Visible = (currentOrNo <> "")   ' an OR number exists once the request was paid (also when refunded)
        Select Case originalStatus
            Case "Pending"
                lblStatusHint.Text = If(isPaid,
                    "Paid. While the request is Pending it can still be cancelled, and the payment will be refunded.",
                    "Record the payment before processing. An unpaid Pending request can be cancelled.")
            Case "Cancelled"
                lblStatusHint.Text = "This request was cancelled" & If(originalPayment = "Refunded", " and its payment was refunded.", ".")
            Case Else
                lblStatusHint.Text = $"This request is {originalStatus}, so it can no longer be cancelled or refunded."
        End Select
    End Sub

    Private Function NextStageName() As String
        Select Case originalStatus
            Case "Pending"
                Return "Processing"
            Case "Processing"
                Return "Ready for Release"
            Case "Ready for Release"
                Return "Released"
            Case Else
                Return ""
        End Select
    End Function

    ' Locks the request row and returns {Status, PaymentStatus} as they are right now in the database
    Private Function LockRequest(c As MySqlConnection, tx As MySqlTransaction) As String()
        Using cmd As New MySqlCommand("SELECT Status, PaymentStatus FROM tblrequest WHERE RequestID = @id FOR UPDATE", c, tx)
            cmd.Parameters.AddWithValue("@id", RequestID)
            Using r As MySqlDataReader = cmd.ExecuteReader()
                If Not r.Read() Then Throw New InvalidOperationException("The request no longer exists.")
                Return New String() {Convert.ToString(r("Status")), Convert.ToString(r("PaymentStatus"))}
            End Using
        End Using
    End Function

    ' ---------------------------------------------------------------
    ' Advance one stage: Pending -> Processing -> Ready for Release -> Released
    ' ---------------------------------------------------------------
    Private Sub btnAdvance_Click(sender As Object, e As EventArgs)
        Dim target As String = NextStageName()
        If target = "" Then Return

        Dim msg As String = $"Move request {lblRequestNo.Text} from {originalStatus} to {target}?"
        If target = "Processing" Then
            msg &= vbCrLf & vbCrLf & "Once the request is Processing it can no longer be cancelled or refunded."
        End If
        If MessageBox.Show(msg, "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return

        ' Fixed names from our own code (never user input), so it is safe to place in the SQL text
        Dim dateColumn As String = If(target = "Processing", "ProcessingDate", If(target = "Ready for Release", "ReadyDate", "ReleasedDate"))
        Dim fromStage As String = originalStatus

        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Dim state As String() = LockRequest(c, tx)
                    If state(0) <> fromStage OrElse state(1) <> "Paid" Then
                        Throw New InvalidOperationException("This request was changed by someone else. Please reopen it.")
                    End If

                    Using cmd As New MySqlCommand($"UPDATE tblrequest SET Status = @s, {dateColumn} = NOW() WHERE RequestID = @id", c, tx)
                        cmd.Parameters.AddWithValue("@s", target)
                        cmd.Parameters.AddWithValue("@id", RequestID)
                        cmd.ExecuteNonQuery()
                    End Using

                    ActivityLogger.Log(c, tx, ActivityLogger.TypeTransaction, "Status Changed", lblRequestNo.Text,
                                       $"Request {lblRequestNo.Text} moved from {fromStage} to {target}")
                    tx.Commit()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating the request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        If LoadRequest() Then LoadItems()
    End Sub

    ' ---------------------------------------------------------------
    ' Cancel: Pending only. A paid request is refunded and deducted from the payment report.
    ' ---------------------------------------------------------------
    Private Sub btnCancelRequest_Click(sender As Object, e As EventArgs)
        Dim msg As String = $"Cancel request {lblRequestNo.Text}?"
        If RequestHelper.IsPaid(originalPayment) Then
            msg &= vbCrLf & vbCrLf & $"This request is already paid (₱{currentTotal:N2}). Cancelling it will REFUND the payment and deduct it from the payment report."
        End If
        msg &= vbCrLf & vbCrLf & "This cannot be undone."
        If MessageBox.Show(msg, "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return

        Dim reason As String
        Dim details As String
        Using dlg As New frmRemarks("Reason for Cancellation", $"Why is request {lblRequestNo.Text} being cancelled?", RemarkReasons.CancelRequest)
            If dlg.ShowDialog(Me) <> DialogResult.OK Then Return
            reason = dlg.Reason
            details = dlg.Details
        End Using

        Dim refunded As Boolean = False
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using tx As MySqlTransaction = c.BeginTransaction()
                    ' Decide from what the database says right now, not from what this page showed earlier
                    Dim state As String() = LockRequest(c, tx)
                    If state(0) <> "Pending" Then
                        Throw New InvalidOperationException($"Only Pending requests can be cancelled. This request is now {state(0)}.")
                    End If
                    refunded = (state(1) = "Paid")

                    Using up As New MySqlCommand("UPDATE tblrequest SET Status = 'Cancelled', PaymentStatus = @pay, CancelReason = @reason, " &
                                                 "CancelRemarks = @details, CancelledBy = @by, CancelledDate = NOW() WHERE RequestID = @id", c, tx)
                        up.Parameters.AddWithValue("@pay", If(refunded, "Refunded", state(1)))
                        up.Parameters.AddWithValue("@reason", reason)
                        up.Parameters.AddWithValue("@details", details)
                        up.Parameters.AddWithValue("@by", AppSession.UserID)
                        up.Parameters.AddWithValue("@id", RequestID)
                        up.ExecuteNonQuery()
                    End Using

                    If refunded Then
                        Using rf As New MySqlCommand("UPDATE tblpayments SET RefundedAt = NOW(), RefundedBy = @by, RefundRemarks = @rr WHERE RequestID = @id", c, tx)
                            rf.Parameters.AddWithValue("@by", AppSession.UserID)
                            rf.Parameters.AddWithValue("@rr", "Refund for cancelled request: " & reason)
                            rf.Parameters.AddWithValue("@id", RequestID)
                            rf.ExecuteNonQuery()
                        End Using
                    End If

                    ActivityLogger.Log(c, tx, ActivityLogger.TypeTransaction, "Request Cancelled", lblRequestNo.Text,
                                       $"Cancelled request {lblRequestNo.Text} (was Pending, {If(refunded, "paid", "unpaid")}) - {reason}", reason & ": " & details)
                    If refunded Then
                        ActivityLogger.Log(c, tx, ActivityLogger.TypeTransaction, "Refund Issued", lblRequestNo.Text,
                                           $"Refunded ₱{currentTotal:N2} for cancelled request {lblRequestNo.Text}; deducted from payment report",
                                           "Refund for cancelled request: " & reason)
                    End If
                    tx.Commit()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error cancelling the request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        MessageBox.Show(If(refunded, $"Request cancelled. Refund of ₱{currentTotal:N2} issued.", "Request cancelled."),
                        "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If LoadRequest() Then LoadItems()
    End Sub

    Private Sub frmRequestDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 860)
        Theme.StyleGrid(dgvItems)

        ' Payment is recorded with its own button (created here so no Designer work is needed)
        btnRecordPayment = New ThemedButton() With {
            .Text = "Record Payment", .Kind = ButtonKind.Primary, .AutoSize = True,
            .MinimumSize = New Size(150, 40), .Margin = New Padding(10, 0, 0, 0), .Visible = False}
        AddHandler btnRecordPayment.Click, AddressOf btnRecordPayment_Click
        flpButtons.Controls.Add(btnRecordPayment)
        flpButtons.Controls.SetChildIndex(btnRecordPayment, 0)   ' rightmost button

        btnAdvance = New ThemedButton() With {
            .Text = "Advance", .Kind = ButtonKind.Primary, .AutoSize = True,
            .MinimumSize = New Size(180, 40), .Margin = New Padding(10, 0, 0, 0), .Visible = False}
        AddHandler btnAdvance.Click, AddressOf btnAdvance_Click
        flpButtons.Controls.Add(btnAdvance)

        btnCancelRequest = New ThemedButton() With {
            .Text = "Cancel Request", .Kind = ButtonKind.Secondary, .AutoSize = True,
            .MinimumSize = New Size(150, 40), .Margin = New Padding(10, 0, 0, 0), .Visible = False}
        AddHandler btnCancelRequest.Click, AddressOf btnCancelRequest_Click
        flpButtons.Controls.Add(btnCancelRequest)

        ' Rightmost first: Record Payment / Advance, then Cancel Request, then Back
        flpButtons.Controls.SetChildIndex(btnCancelRequest, 0)
        flpButtons.Controls.SetChildIndex(btnAdvance, 0)
        flpButtons.Controls.SetChildIndex(btnRecordPayment, 0)

        btnViewReceipt = New ThemedButton() With {
            .Text = "View Receipt", .Kind = ButtonKind.Secondary, .AutoSize = True,
            .MinimumSize = New Size(140, 40), .Margin = New Padding(10, 0, 0, 0), .Visible = False}
        AddHandler btnViewReceipt.Click, Sub(s, ev) frmReceipt.ShowFor(Me, Convert.ToInt32(RequestID))
        flpButtons.Controls.Add(btnViewReceipt)
        flpButtons.Controls.SetChildIndex(btnViewReceipt, 3)   ' after Cancel Request, before Back

        lblStatusHint.Text = "Payment is recorded with the Record Payment button, which issues the OR number."

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

                        lblStudentNo.Text = TextOrDash(r("StudentID"))
                        lblStudentName.Text = TextOrDash(r("StudentName"))
                        lblCreatedBy.Text = TextOrDash(r("CreatedBy"))
                        lblRequestDate.Text = If(IsDBNull(r("RequestDate")), "-", Convert.ToDateTime(r("RequestDate")).ToString("MMMM dd, yyyy"))
                        lblTotalAmount.Text = "₱ " & If(IsDBNull(r("TotalAmount")), 0D, Convert.ToDecimal(r("TotalAmount"))).ToString("N2")

                        currentTotal = If(IsDBNull(r("TotalAmount")), 0D, Convert.ToDecimal(r("TotalAmount")))
                        currentStudentName = lblStudentName.Text

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
            ConfigureActions()
            ApplyBadge(originalStatus)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error loading the request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
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


    Private Sub btnRecordPayment_Click(sender As Object, e As EventArgs)

        ' Do not take money for a document the office cannot issue right now
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Dim unavailable As String = InactiveDocuments(c, Nothing)
                If unavailable <> "" Then
                    MessageBox.Show($"'{unavailable}' is currently Inactive (not available), so the payment cannot be recorded for this request." &
                                    vbCrLf & vbCrLf &
                                    "You can cancel this request (no refund is needed because it is unpaid), or wait until the document is set to Active again.",
                                    "Document Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking the document: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try


        Using dlg As New frmPayment(lblRequestNo.Text, currentStudentName, currentTotal)
            If dlg.ShowDialog(Me) <> DialogResult.OK Then Return
            Dim p As PaymentResult = dlg.Result
            Dim orNo As String

            Try
                Using c As New MySqlConnection(connStr)
                    c.Open()
                    Using tx As MySqlTransaction = c.BeginTransaction()
                        ' Lock the row and make sure nobody paid or changed it since this page was opened
                        Using chk As New MySqlCommand("SELECT Status, PaymentStatus FROM tblrequest WHERE RequestID = @id FOR UPDATE", c, tx)
                            chk.Parameters.AddWithValue("@id", RequestID)
                            Using r As MySqlDataReader = chk.ExecuteReader()
                                If Not r.Read() Then Throw New InvalidOperationException("The request no longer exists.")
                                If Convert.ToString(r("Status")) <> "Pending" OrElse Convert.ToString(r("PaymentStatus")) <> "Unpaid" Then
                                    Throw New InvalidOperationException("This request was already updated. Please reopen it.")
                                End If
                            End Using
                        End Using

                        Dim unavailable As String = InactiveDocuments(c, tx)
                        If unavailable <> "" Then
                            Throw New InvalidOperationException($"'{unavailable}' became unavailable (Inactive). Payment was not recorded.")
                        End If

                        orNo = RequestHelper.NewORNumber(c, tx)

                        Using up As New MySqlCommand("UPDATE tblrequest SET PaymentStatus = 'Paid', ORNo = @or, ORDate = CURDATE(), " &
                                                     "IsRush = @rush, RushFee = @rf, TotalAmount = @total WHERE RequestID = @id", c, tx)
                            up.Parameters.AddWithValue("@or", orNo)
                            up.Parameters.AddWithValue("@rush", p.IsRush)
                            up.Parameters.AddWithValue("@rf", If(p.IsRush, RequestHelper.RushFee, 0D))
                            up.Parameters.AddWithValue("@total", p.AmountDue)
                            up.Parameters.AddWithValue("@id", RequestID)
                            up.ExecuteNonQuery()
                        End Using

                        Using ins As New MySqlCommand("INSERT INTO tblpayments (RequestID, ORNo, PaymentMode, AmountDue, AmountTendered, ChangeAmount, ReferenceNo, PaymentDate, ReceivedBy) " &
                                                      "VALUES (@id, @or, @mode, @due, @tend, @chg, @ref, NOW(), @by)", c, tx)
                            ins.Parameters.AddWithValue("@id", RequestID)
                            ins.Parameters.AddWithValue("@or", orNo)
                            ins.Parameters.AddWithValue("@mode", p.Mode)
                            ins.Parameters.AddWithValue("@due", p.AmountDue)
                            ins.Parameters.AddWithValue("@tend", p.AmountTendered)
                            ins.Parameters.AddWithValue("@chg", p.Change)
                            ins.Parameters.AddWithValue("@ref", If(String.IsNullOrWhiteSpace(p.ReferenceNo), CType(DBNull.Value, Object), p.ReferenceNo))
                            ins.Parameters.AddWithValue("@by", AppSession.UserID)
                            ins.ExecuteNonQuery()
                        End Using

                        ActivityLogger.Log(c, tx, ActivityLogger.TypeTransaction, "Payment Recorded", lblRequestNo.Text,
                            $"Recorded payment {orNo} of ₱{p.AmountDue:N2} via {p.Mode} for {lblRequestNo.Text} (tendered ₱{p.AmountTendered:N2}, change ₱{p.Change:N2})" &
                            If(p.IsRush, " - rush/expedite fee included", ""))
                        tx.Commit()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error recording the payment: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            If MessageBox.Show($"Payment recorded. OR Number: {orNo}" & vbCrLf & $"Change to give: ₱{p.Change:N2}" & vbCrLf & vbCrLf & "Open the receipt now?",
                               "Payment Recorded", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                frmReceipt.ShowFor(Me, Convert.ToInt32(RequestID))
            End If

        End Using

        If LoadRequest() Then LoadItems()   ' refresh the page: now Paid, still Pending
    End Sub



End Class
