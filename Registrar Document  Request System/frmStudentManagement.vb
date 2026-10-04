Imports MySql.Data.MySqlClient

Public Class frmStudentManagement

    Dim connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Dim conn As New MySqlConnection(connStr)

    Private selectedStudentId As String = String.Empty

    Private Sub FormStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' "Status" is drawn as a colored pill; every other column is a plain text column
        Theme.StyleGrid(dgvStudents, "Status")

        LoadData()
        LoadStatusCounts()
    End Sub

    ' Load student list
    Sub LoadData()
        Try
            Dim adapter As New MySqlDataAdapter("SELECT * FROM tblstudents", conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvStudents.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' Fill the "Student Status Summary" card
    Private Sub LoadStatusCounts()
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                lblNumberActiveStudents.Text = CountByStatus(c, "Active")
                lblNumberInactiveStudents.Text = CountByStatus(c, "Inactive")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student counts: " & ex.Message)
        End Try
    End Sub

    Private Function CountByStatus(c As MySqlConnection, status As String) As String
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tblstudents WHERE Status = @status", c)
            cmd.Parameters.AddWithValue("@status", status)
            Return Convert.ToInt32(cmd.ExecuteScalar()).ToString()
        End Using
    End Function

    ' Quick Search (the "Search..." hint is now the TextBox's built-in PlaceholderText)
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            ' @q is a parameter, so whatever is typed can never be run as SQL
            Dim query As String = "SELECT * FROM tblstudents WHERE StudentID LIKE @q OR LastName LIKE @q OR FirstName LIKE @q"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@q", "%" & txtSearch.Text.Trim() & "%")
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvStudents.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' View / Select Row
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex < 0 Then Return

        Dim selectedRow As DataGridViewRow = dgvStudents.Rows(e.RowIndex)

        ' 1. Store the Student ID variable safely
        If selectedRow.Cells("StudentID").Value IsNot Nothing Then
            selectedStudentId = selectedRow.Cells("StudentID").Value.ToString()
        ElseIf TypeOf selectedRow.DataBoundItem Is DataRowView Then
            Dim drv = DirectCast(selectedRow.DataBoundItem, DataRowView)
            selectedStudentId = drv("StudentID").ToString()
        End If

        ' 2. Update the Summary Labels
        If TypeOf selectedRow.DataBoundItem Is DataRowView Then
            Dim drv = DirectCast(selectedRow.DataBoundItem, DataRowView)
            lblStudentNumber.Text = drv("StudentID").ToString()
            lblLastName.Text = drv("LastName").ToString()
            lblFirstName.Text = drv("FirstName").ToString()
        Else
            lblStudentNumber.Text = selectedRow.Cells("StudentID").Value.ToString()
            lblLastName.Text = selectedRow.Cells("LastName").Value.ToString()
            lblFirstName.Text = selectedRow.Cells("FirstName").Value.ToString()
        End If
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        Me.ActiveControl = Nothing
        LoadData()
    End Sub

    Private Sub btnViewStudent_Click(sender As Object, e As EventArgs) Handles btnViewStudent.Click
        ' Fallback check: if variable is empty, try grabbing the ID straight from the selected DataGridView row
        If String.IsNullOrEmpty(selectedStudentId) AndAlso dgvStudents.CurrentRow IsNot Nothing Then
            Dim row = dgvStudents.CurrentRow
            If row.Cells("StudentID").Value IsNot Nothing Then
                selectedStudentId = row.Cells("StudentID").Value.ToString()
            End If
        End If

        ' If still empty, display notice
        If String.IsNullOrEmpty(selectedStudentId) Then
            MessageBox.Show("Please select a student from the table first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Open the edit/view student form
        Dim editForm As New frmEditStudent()
        editForm.selectedStudent = selectedStudentId

        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(editForm)
        Else
            editForm.ShowDialog()
        End If
    End Sub

    Private Sub btnAddStudentRecord_Click(sender As Object, e As EventArgs) Handles btnAddStudentRecord.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmAddStudent())
        Else
            Dim addForm As New frmAddStudent()
            addForm.ShowDialog()
        End If
    End Sub
End Class
