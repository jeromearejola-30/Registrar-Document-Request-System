Imports MySql.Data.MySqlClient

''' <summary>Search students, document requests and documents from one box.</summary>
Public Class frmSearchRecords

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Private Const HintText As String = "Type at least 2 characters to search students, requests and documents. Double-click a result to open it."

    Private Sub frmSearchRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.StyleGrid(dgvResults, "Status")
        lblResultCount.Text = HintText
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RunSearch(txtSearch.Text.Trim())
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()   ' triggers txtSearch_TextChanged, which clears the results
        txtSearch.Focus()
    End Sub

    Private Sub RunSearch(keyword As String)
        If keyword.Length < 2 Then
            dgvResults.DataSource = Nothing
            lblResultCount.Text = HintText
            Return
        End If

        Try
            Dim sql As String =
                "SELECT 'Student' AS Type, s.StudentID AS Reference, " &
                "       CONCAT(s.LastName, ', ', s.FirstName) AS Name, " &
                "       CONCAT_WS(' ', s.Course, s.YearLevel, s.Section) AS Details, s.Status AS Status " &
                "FROM tblstudents s " &
                "WHERE s.StudentID LIKE @k OR s.LRN LIKE @k OR s.FirstName LIKE @k OR s.LastName LIKE @k " &
                "   OR CONCAT(s.FirstName, ' ', s.LastName) LIKE @k OR s.Course LIKE @k " &
                "UNION ALL " &
                "SELECT 'Request', r.RequestNo, CONCAT(s.LastName, ', ', s.FirstName), " &
                "       (SELECT GROUP_CONCAT(d.DocumentName SEPARATOR ', ') FROM tblrequestdetails rd " &
                "        JOIN tbldocuments d ON d.DocumentID = rd.DocumentID WHERE rd.RequestID = r.RequestID), r.Status " &
                "FROM tblrequest r LEFT JOIN tblstudents s ON s.StudentID = r.StudentID " &
                "WHERE r.RequestNo LIKE @k OR r.StudentID LIKE @k OR s.FirstName LIKE @k OR s.LastName LIKE @k " &
                "   OR CONCAT(s.FirstName, ' ', s.LastName) LIKE @k " &
                "UNION ALL " &
                "SELECT 'Document', CAST(d.DocumentID AS CHAR), d.DocumentName, CONCAT('₱ ', FORMAT(d.Fee, 2)), d.Status " &
                "FROM tbldocuments d WHERE d.DocumentName LIKE @k " &
                "ORDER BY 1, 3 LIMIT 200"

            Dim dt As New DataTable()
            Using c As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(sql, c)
                    cmd.Parameters.AddWithValue("@k", "%" & keyword & "%")
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgvResults.DataSource = dt
            FormatColumns()
            dgvResults.ClearSelection()

            lblResultCount.Text = If(dt.Rows.Count = 0, "No matching records.",
                                     $"{dt.Rows.Count} result(s). Double-click a row to open it.")
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatColumns()
        With dgvResults
            If Not .Columns.Contains("Type") Then Return
            .Columns("Type").FillWeight = 12
            .Columns("Reference").FillWeight = 20
            .Columns("Name").FillWeight = 26
            .Columns("Details").FillWeight = 28
            .Columns("Status").FillWeight = 14
            .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    ' Double-click a result to open the matching page
    Private Sub dgvResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellDoubleClick
        If e.RowIndex < 0 Then Return
        Dim mainMenu = TryCast(Me.ParentForm, frmMainMenu)
        If mainMenu Is Nothing Then Return

        Dim row As DataGridViewRow = dgvResults.Rows(e.RowIndex)
        Dim kind As String = Convert.ToString(row.Cells("Type").Value)
        Dim reference As String = Convert.ToString(row.Cells("Reference").Value)

        Select Case kind
            Case "Student"
                Dim page As New frmEditStudent()
                page.selectedStudent = reference
                mainMenu.ShowChildForm(page)
            Case "Document"
                Dim page As New frmEditDocument()
                page.DocumentID = reference
                mainMenu.ShowChildForm(page)
            Case "Request"
                OpenRequestDetails(mainMenu, reference)
        End Select
    End Sub

    ' The result row holds the request number (REQ-...), so look up its RequestID before opening the page
    Private Sub OpenRequestDetails(mainMenu As frmMainMenu, requestNo As String)
        Try
            Dim requestId As Object
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("SELECT RequestID FROM tblrequest WHERE RequestNo = @n LIMIT 1", c)
                    cmd.Parameters.AddWithValue("@n", requestNo)
                    requestId = cmd.ExecuteScalar()
                End Using
            End Using

            If requestId Is Nothing OrElse IsDBNull(requestId) Then
                MessageBox.Show("That request could not be found. It may have been removed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RunSearch(txtSearch.Text.Trim())
                Return
            End If

            Dim page As New frmRequestDetails()
            page.RequestID = Convert.ToString(requestId)
            mainMenu.ShowChildForm(page)
        Catch ex As Exception
            MessageBox.Show("Error opening the request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
