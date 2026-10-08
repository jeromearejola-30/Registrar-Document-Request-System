Imports MySql.Data.MySqlClient

Public Class frmDocumentRequest

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    Private currentStatusFilter As String = "All"
    Private _loading As Boolean = False

    Private Sub frmDocumentRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' "Status" and "PaymentStatus" are drawn as colored pills; every other column is plain text
        Theme.StyleGrid(dgvRequests, "Status,PaymentStatus")
        HighlightFilterCard()

        LoadDocumentTypes()
        UpdateHeaderLabel()
        ApplyFilters()
        UpdateStatusSummary()

        ' "Request Manager" button after Create Request (added in code: the toolbar gets one more column)
        Dim btnManager As New ThemedButton() With {
            .Text = "Request Manager", .Kind = ButtonKind.Secondary, .AutoSize = True,
            .MinimumSize = New Size(0, 40), .Margin = btnViewRequest.Margin}
        AddHandler btnManager.Click, Sub(s, ev)
                                         Dim host = TryCast(ParentForm, frmMainMenu)
                                         If host IsNot Nothing Then host.ShowChildForm(New frmRequestManager())
                                     End Sub
        tlpToolbar.ColumnCount += 1
        tlpToolbar.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        tlpToolbar.Controls.Add(btnManager, tlpToolbar.ColumnCount - 1, 0)

    End Sub

    ' Populate dropdown with active documents from database
    Private Sub LoadDocumentTypes()
        _loading = True
        Try
            cboFilterByDocType.Items.Clear()
            cboFilterByDocType.Items.Add("[All Document Types]")

            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("SELECT DocumentName FROM tbldocuments WHERE Status = 'Active' ORDER BY DocumentName", c)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cboFilterByDocType.Items.Add(reader("DocumentName").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' The list simply keeps "[All Document Types]" if the database is unreachable
        Finally
            cboFilterByDocType.SelectedIndex = 0
            _loading = False
        End Try
    End Sub

    Private Sub UpdateHeaderLabel()
        Dim docText As String = If(cboFilterByDocType.SelectedIndex > 0, $"[{cboFilterByDocType.SelectedItem}]", "[All Document Types]")
        lblDocTypeDate.Text = docText
    End Sub

    ' Filter query: JOINs fetch the student name and the username into the grid
    Public Sub ApplyFilters()
        Try
            Dim query As String = "SELECT DISTINCT r.RequestID, r.RequestNo, r.StudentID, " &
                                  "CONCAT(s.FirstName, ' ', IF(s.MiddleName IS NULL OR s.MiddleName = '', '', CONCAT(LEFT(s.MiddleName, 1), '. ')), s.LastName) AS StudentName, " &
                                  "r.RequestDate, r.TotalAmount, r.PaymentStatus, r.ORNo, r.ORDate, r.Status, u.Username AS CreatedBy " &
                                  "FROM tblrequest r " &
                                  "LEFT JOIN tblstudents s ON r.StudentID = s.StudentID " &
                                  "LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID " &
                                  "LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                                  "LEFT JOIN tblusers u ON r.CreatedBy = u.UserID WHERE 1=1"

            If currentStatusFilter <> "All" Then query &= " AND r.Status = @status"
            If cboFilterByDocType.SelectedIndex > 0 Then query &= " AND d.DocumentName = @docType"

            Dim keyword As String = txtSearch.Text.Trim()
            If keyword <> "" Then
                query &= " AND (r.RequestNo LIKE @search " &
                         " OR r.StudentID LIKE @search " &
                         " OR s.FirstName LIKE @search " &
                         " OR s.LastName LIKE @search " &
                         " OR CONCAT(s.FirstName, ' ', s.LastName) LIKE @search " &
                         " OR d.DocumentName LIKE @search " &
                         " OR u.Username LIKE @search " &
                         " OR DATE_FORMAT(r.RequestDate, '%M') LIKE @search " &
                         " OR DATE_FORMAT(r.RequestDate, '%b') LIKE @search " &
                         " OR DATE_FORMAT(r.RequestDate, '%m') LIKE @search " &
                         " OR DATE_FORMAT(r.RequestDate, '%c') LIKE @search " &
                         " OR DATE_FORMAT(r.RequestDate, '%Y-%m-%d') LIKE @search " &
                         " OR DATE_FORMAT(r.RequestDate, '%m/%d/%Y') LIKE @search)"
            End If
            query &= " ORDER BY r.RequestDate DESC, r.RequestID DESC"

            Dim dt As New DataTable()
            Using c As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(query, c)
                    If currentStatusFilter <> "All" Then cmd.Parameters.AddWithValue("@status", currentStatusFilter)
                    If cboFilterByDocType.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@docType", cboFilterByDocType.SelectedItem.ToString())
                    If keyword <> "" Then cmd.Parameters.AddWithValue("@search", "%" & keyword & "%")
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgvRequests.DataSource = dt
            FormatColumns()

            lblAllDocRequest.Text = If(currentStatusFilter = "All", "All Document Requests", currentStatusFilter & " Requests")
        Catch ex As Exception
            MessageBox.Show("Error filtering requests: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Friendly headers + how the columns share the width (weights add up to about 100)
    Private Sub FormatColumns()
        With dgvRequests
            If Not .Columns.Contains("RequestNo") Then Return

            .Columns("RequestID").Visible = False

            SetColumn("RequestNo", "Request No.", 15)
            SetColumn("StudentID", "Student No.", 11)
            SetColumn("StudentName", "Student", 19)
            SetColumn("RequestDate", "Date", 10)
            SetColumn("TotalAmount", "Amount (₱)", 10)
            SetColumn("PaymentStatus", "Payment", 10)
            SetColumn("ORNo", "OR No.", 8)
            SetColumn("ORDate", "OR Date", 10)
            SetColumn("Status", "Status", 13)
            SetColumn("CreatedBy", "Created By", 10)

            .Columns("RequestDate").DefaultCellStyle.Format = "MM/dd/yyyy"
            .Columns("ORDate").DefaultCellStyle.Format = "MM/dd/yyyy"

            .Columns("TotalAmount").DefaultCellStyle.Format = "N2"
            .Columns("TotalAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("TotalAmount").DefaultCellStyle.Padding = New Padding(0, 0, 16, 0)
            .Columns("TotalAmount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("TotalAmount").HeaderCell.Style.Padding = New Padding(0, 0, 16, 0)

            .Columns("PaymentStatus").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub SetColumn(name As String, header As String, weight As Single)
        If Not dgvRequests.Columns.Contains(name) Then Return
        dgvRequests.Columns(name).HeaderText = header
        dgvRequests.Columns(name).FillWeight = weight
    End Sub

    ' Status counters (shown on the filter cards)
    Public Sub UpdateStatusSummary()
        Try
            Dim countPending, countReady, countProcess, countReleased, countCancelled As Integer

            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("SELECT Status, COUNT(*) AS Total FROM tblrequest GROUP BY Status", c)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim st As String = reader("Status").ToString().Trim().ToLower()
                            Dim total As Integer = Convert.ToInt32(reader("Total"))

                            Select Case st
                                Case "pending" : countPending = total
                                Case "ready for release", "ready" : countReady = total
                                Case "processing", "process" : countProcess = total
                                Case "released" : countReleased = total
                                Case "cancelled", "canceled" : countCancelled = total
                            End Select
                        End While
                    End Using
                End Using
            End Using

            cardAll.Value = (countPending + countReady + countProcess + countReleased + countCancelled).ToString()
            cardPending.Value = countPending.ToString()
            cardProcessing.Value = countProcess.ToString()
            cardReadyForRelease.Value = countReady.ToString()
            cardReleased.Value = countReleased.ToString()
            cardCancelled.Value = countCancelled.ToString()
        Catch ex As Exception
            ' Counters keep their last value if the database is unreachable
        End Try
    End Sub

    ' Highlights the active filter card
    Private Sub HighlightFilterCard()
        cardAll.Selected = (currentStatusFilter = "All")
        cardPending.Selected = (currentStatusFilter = "Pending")
        cardProcessing.Selected = (currentStatusFilter = "Processing")
        cardReadyForRelease.Selected = (currentStatusFilter = "Ready for Release")
        cardReleased.Selected = (currentStatusFilter = "Released")
        cardCancelled.Selected = (currentStatusFilter = "Cancelled")
    End Sub

    Private Sub SetStatusFilter(status As String)
        currentStatusFilter = status
        HighlightFilterCard()
        UpdateHeaderLabel()
        ApplyFilters()
    End Sub

    ' ---- Controls & event handlers ----
    Private Sub cboFilterByDocType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterByDocType.SelectedIndexChanged
        If _loading Then Return
        UpdateHeaderLabel()
        ApplyFilters()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilters()
    End Sub

    ' Clicking a card filters the list by that status
    Private Sub cardAll_Click(sender As Object, e As EventArgs) Handles cardAll.Click
        SetStatusFilter("All")
    End Sub

    Private Sub cardPending_Click(sender As Object, e As EventArgs) Handles cardPending.Click
        SetStatusFilter("Pending")
    End Sub

    Private Sub cardProcessing_Click(sender As Object, e As EventArgs) Handles cardProcessing.Click
        SetStatusFilter("Processing")
    End Sub

    Private Sub cardReadyForRelease_Click(sender As Object, e As EventArgs) Handles cardReadyForRelease.Click
        SetStatusFilter("Ready for Release")
    End Sub

    Private Sub cardReleased_Click(sender As Object, e As EventArgs) Handles cardReleased.Click
        SetStatusFilter("Released")
    End Sub

    Private Sub cardCancelled_Click(sender As Object, e As EventArgs) Handles cardCancelled.Click
        SetStatusFilter("Cancelled")
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        _loading = True
        txtSearch.Clear()
        If cboFilterByDocType.Items.Count > 0 Then cboFilterByDocType.SelectedIndex = 0
        _loading = False
        Me.ActiveControl = Nothing
        currentStatusFilter = "All"
        HighlightFilterCard()
        UpdateHeaderLabel()
        ApplyFilters()
        UpdateStatusSummary()
    End Sub

    ' ---- Open the Request Details page for the selected request ----
    Private Sub btnViewRequest_Click(sender As Object, e As EventArgs) Handles btnViewRequest.Click
        If dgvRequests.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a request from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        OpenRequest(dgvRequests.CurrentRow.Index)
    End Sub

    Private Sub dgvRequests_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequests.CellDoubleClick
        If e.RowIndex >= 0 Then OpenRequest(e.RowIndex)
    End Sub

    Private Sub OpenRequest(rowIndex As Integer)
        If rowIndex < 0 OrElse rowIndex >= dgvRequests.Rows.Count Then Return
        Dim idValue As Object = dgvRequests.Rows(rowIndex).Cells("RequestID").Value
        If idValue Is Nothing OrElse IsDBNull(idValue) Then Return

        Dim details As New frmRequestDetails()
        details.RequestID = Convert.ToString(idValue)

        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(details)
        Else
            If details.ShowDialog() = DialogResult.OK Then
                ApplyFilters()
                UpdateStatusSummary()
            End If
        End If
    End Sub

    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmCreateDocumentRequest())
        Else
            Dim createForm As New frmCreateDocumentRequest()
            If createForm.ShowDialog() = DialogResult.OK Then
                ApplyFilters()
                UpdateStatusSummary()
            End If
        End If
    End Sub

End Class
