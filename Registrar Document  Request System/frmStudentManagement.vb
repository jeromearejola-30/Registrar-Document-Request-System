Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
Public Class frmStudentManagement

    Dim connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Dim conn As New MySqlConnection(connStr)

    Private ReadOnly PlaceholderText As String = "   Search student..."
    Private selectedStudentId As String = String.Empty


    Private Sub FormStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        txtSearch.Text = PlaceholderText
        txtSearch.ForeColor = Color.Gray
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

    Private Sub ShowChildForm(childForm As Form)
        If Me.tplContentArea.Controls.Count > 0 Then
            Me.tplContentArea.Controls(0).Dispose()
        End If

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        Me.tplContentArea.Controls.Add(childForm)
        Me.tplContentArea.Tag = childForm

        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub txtSearchBox_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = PlaceholderText Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchBox_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = PlaceholderText
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub


    ' Quick Search
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim query As String = "SELECT * FROM tblstudents WHERE StudentID LIKE '%" & txtSearch.Text & "%' OR LastName LIKE '%" & txtSearch.Text & "%' OR FirstName LIKE '%" & txtSearch.Text & "%'"
            Dim adapter As New MySqlDataAdapter(query, conn)
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
        txtSearch.Text = PlaceholderText
        txtSearch.ForeColor = Color.Gray
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