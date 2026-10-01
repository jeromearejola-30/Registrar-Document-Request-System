Imports MySql.Data.MySqlClient

Public Class frmDocumentRequest

    Dim connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Dim conn As New MySqlConnection(connStr)

    Dim currentStatusFilter As String = "All"

    Private Sub frmDocumentRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRequests.RowHeadersVisible = False

        ' Populate Document Type ComboBox directly from tbldocuments
        LoadDocumentTypes()

        UpdateHeaderLabel()
        ApplyFilters()
        UpdateStatusSummary()
    End Sub

    ' Populate dropdown with active documents from database
    Private Sub LoadDocumentTypes()
        Try
            cboFilterByDocType.Items.Clear()
            cboFilterByDocType.Items.Add("[All Document Types]")

            conn.Open()
            Dim query As String = "SELECT DocumentName FROM tbldocuments WHERE Status = 'Active'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cboFilterByDocType.Items.Add(reader("DocumentName").ToString())
            End While

            reader.Close()
            conn.Close()

            cboFilterByDocType.SelectedIndex = 0
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub UpdateHeaderLabel()
        Dim docText As String = If(cboFilterByDocType.SelectedIndex > 0, $"[{cboFilterByDocType.SelectedItem}]", "[All Document Types]")
        lblDocTypeDate.Text = docText
    End Sub

    ' Filter Query using SQL JOINs to include Username from tblusers
    Public Sub ApplyFilters()
        Try
            conn.Open()

            ' Joined tblusers to fetch u.Username instead of raw r.CreatedBy ID
            Dim query As String = "SELECT DISTINCT r.RequestID, r.RequestNo, r.StudentID, r.RequestDate, r.TotalAmount, " &
                                  "r.PaymentStatus, r.ORNo, r.ORDate, r.Status, u.Username AS CreatedBy " &
                                  "FROM tblrequest r " &
                                  "LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID " &
                                  "LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                                  "LEFT JOIN tblusers u ON r.CreatedBy = u.UserID WHERE 1=1"

            ' Filter by Status Button
            If currentStatusFilter <> "All" Then
                query &= " AND r.Status = @status"
            End If

            ' Filter by Document Type Selected in cboFilterByDocType
            If cboFilterByDocType.SelectedIndex > 0 Then
                query &= " AND d.DocumentName = @docType"
            End If

            ' Search Box logic: matches RequestNo, StudentID, DocumentName, Username, Month Names, and Dates
            If txtSearch.Text.Trim() <> "" Then
                query &= " AND (r.RequestNo LIKE @search " &
                         " OR r.StudentID LIKE @search " &
                         " OR d.DocumentName LIKE @search " &
                         " OR u.Username LIKE @search " &
                         " OR DATE_FORMAT(r.RequestDate, '%M') LIKE @search " &   ' e.g. "September"
                         " OR DATE_FORMAT(r.RequestDate, '%b') LIKE @search " &   ' e.g. "Sep"
                         " OR DATE_FORMAT(r.RequestDate, '%m') LIKE @search " &   ' e.g. "09"
                         " OR DATE_FORMAT(r.RequestDate, '%c') LIKE @search " &   ' e.g. "9"
                         " OR DATE_FORMAT(r.RequestDate, '%Y-%m-%d') LIKE @search " &
                         " OR DATE_FORMAT(r.RequestDate, '%m/%d/%Y') LIKE @search)"
            End If

            Dim cmd As New MySqlCommand(query, conn)

            If currentStatusFilter <> "All" Then
                cmd.Parameters.AddWithValue("@status", currentStatusFilter)
            End If

            If cboFilterByDocType.SelectedIndex > 0 Then
                cmd.Parameters.AddWithValue("@docType", cboFilterByDocType.SelectedItem.ToString())
            End If

            If txtSearch.Text.Trim() <> "" Then
                cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvRequests.DataSource = dt
            conn.Close()

            lblAllDocRequest.Text = If(currentStatusFilter = "All", "All Document Requests", currentStatusFilter & " Requests")

        Catch ex As Exception
            MessageBox.Show("Error filtering requests: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Status Summary Counter
    Public Sub UpdateStatusSummary()
        Try
            conn.Open()
            Dim query As String = "SELECT Status, COUNT(*) AS Total FROM tblrequest GROUP BY Status"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim countPending As Integer = 0
            Dim countReady As Integer = 0
            Dim countProcess As Integer = 0
            Dim countReleased As Integer = 0
            Dim countCancelled As Integer = 0

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
            reader.Close()
            conn.Close()

            lblPendingCount.Text = "Pending : " & countPending
            lblReadyCount.Text = "Ready for release : " & countReady
            lblProcessCount.Text = "Process : " & countProcess
            lblReleasedCount.Text = "Released : " & countReleased
            lblCancelledCount.Text = "Cancelled : " & countCancelled

        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Controls & Event Handlers
    Private Sub cboFilterByDocType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterByDocType.SelectedIndexChanged
        UpdateHeaderLabel()
        ApplyFilters()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilters()
    End Sub

    ' Status Filter Buttons
    Private Sub btnAllRequests_Click(sender As Object, e As EventArgs) Handles btnAllRequests.Click
        currentStatusFilter = "All"
        UpdateHeaderLabel()
        ApplyFilters()
    End Sub

    Private Sub btnPendingRequests_Click(sender As Object, e As EventArgs) Handles btnPendingRequests.Click
        currentStatusFilter = "Pending"
        UpdateHeaderLabel()
        ApplyFilters()
    End Sub

    Private Sub btnProcessingRequests_Click(sender As Object, e As EventArgs) Handles btnProcessingRequests.Click
        currentStatusFilter = "Processing"
        UpdateHeaderLabel()
        ApplyFilters()
    End Sub

    Private Sub btnReadyForRelease_Click(sender As Object, e As EventArgs) Handles btnReadyForRelease.Click
        currentStatusFilter = "Ready for Release"
        UpdateHeaderLabel()
        ApplyFilters()
    End Sub

    Private Sub btnReleasedRequests_Click(sender As Object, e As EventArgs) Handles btnReleasedRequests.Click
        currentStatusFilter = "Released"
        UpdateHeaderLabel()
        ApplyFilters()
    End Sub

    Private Sub btnCancelledRequests_Click(sender As Object, e As EventArgs) Handles btnCancelledRequests.Click
        currentStatusFilter = "Cancelled"
        UpdateHeaderLabel()
        ApplyFilters()
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        currentStatusFilter = "All"
        If cboFilterByDocType.Items.Count > 0 Then cboFilterByDocType.SelectedIndex = 0
        UpdateHeaderLabel()
        ApplyFilters()
        UpdateStatusSummary()
    End Sub

    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click
        Dim createForm As New frmCreateDocumentRequest()
        If createForm.ShowDialog() = DialogResult.OK Then
            ApplyFilters()
            UpdateStatusSummary()
        End If
    End Sub

End Class