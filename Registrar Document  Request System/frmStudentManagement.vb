Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
Public Class frmStudentManagement

    Dim connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Dim conn As New MySqlConnection(connStr)

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

    ' Clear textboxes
    Sub ClearFields()
        txtStudentID.Clear()
        txtLRN.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtCourse.Clear()
        txtYearLevel.Clear()
        txtSection.Clear()
        txtContactNo.Clear()
        cboStatus.SelectedIndex = -1
    End Sub

    Private Sub FormStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
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

    ' Add Student
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO tblstudents (StudentID, LRN, LastName, FirstName, MiddleName, Course, YearLevel, Section, ContactNo, Status) " &
                                  "VALUES (@id, @lrn, @lname, @fname, @mname, @course, @yrlvl, @sec, @contact, 'Active')"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
            cmd.Parameters.AddWithValue("@lrn", txtLRN.Text)
            cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
            cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@mname", txtMiddleName.Text)
            cmd.Parameters.AddWithValue("@course", txtCourse.Text)
            cmd.Parameters.AddWithValue("@yrlvl", txtYearLevel.Text)
            cmd.Parameters.AddWithValue("@sec", txtSection.Text)
            cmd.Parameters.AddWithValue("@contact", txtContactNo.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Student added successfully!")

            conn.Close()
            LoadData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding student: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Edit Student
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            conn.Open()
            ' Added Status=@status to the UPDATE query
            Dim query As String = "UPDATE tblstudents SET LRN=@lrn, LastName=@lname, FirstName=@fname, MiddleName=@mname, Course=@course, YearLevel=@yrlvl, Section=@sec, ContactNo=@contact, Status=@status WHERE StudentID=@id"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", txtStudentID.Text)
            cmd.Parameters.AddWithValue("@lrn", txtLRN.Text)
            cmd.Parameters.AddWithValue("@lname", txtLastName.Text)
            cmd.Parameters.AddWithValue("@fname", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@mname", txtMiddleName.Text)
            cmd.Parameters.AddWithValue("@course", txtCourse.Text)
            cmd.Parameters.AddWithValue("@yrlvl", txtYearLevel.Text)
            cmd.Parameters.AddWithValue("@sec", txtSection.Text)
            cmd.Parameters.AddWithValue("@contact", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@status", cboStatus.Text) ' Saves selected status (Active/Inactive)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Student updated successfully!")

            conn.Close()
            LoadData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating student: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Deactivate Student
    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        If txtStudentID.Text = "" Then
            MessageBox.Show("Please select a student from the grid first.")
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "UPDATE tblstudents SET Status='Inactive' WHERE StudentID=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", txtStudentID.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Student marked as Inactive!")

            conn.Close()
            LoadData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error deactivating student: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Delete Student
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtStudentID.Text = "" Then
            MessageBox.Show("Please select a student from the grid first.")
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo)

        If confirm = DialogResult.Yes Then
            Try
                conn.Open()
                Dim query As String = "DELETE FROM tblstudents WHERE StudentID=@id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtStudentID.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Student deleted successfully!")

                conn.Close()
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error deleting student: " & ex.Message)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
    End Sub

    ' View / Select Row
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)

            txtStudentID.Text = row.Cells("StudentID").Value.ToString()
            txtLRN.Text = row.Cells("LRN").Value.ToString()
            txtLastName.Text = row.Cells("LastName").Value.ToString()
            txtFirstName.Text = row.Cells("FirstName").Value.ToString()
            txtMiddleName.Text = row.Cells("MiddleName").Value.ToString()
            txtCourse.Text = row.Cells("Course").Value.ToString()
            txtYearLevel.Text = row.Cells("YearLevel").Value.ToString()
            txtSection.Text = row.Cells("Section").Value.ToString()
            txtContactNo.Text = row.Cells("ContactNo").Value.ToString()
            cboStatus.Text = row.Cells("Status").Value.ToString()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
End Class