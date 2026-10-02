Imports MySql.Data.MySqlClient

Public Class frmEditStudent

    Public Property selectedStudent As String

    Private Sub frmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBoxes()

        If Not String.IsNullOrEmpty(selectedStudent) Then
            LoadStudentData()
        End If
    End Sub

    Private Sub PopulateComboBoxes()
        cboYearLevel.Items.Clear()
        cboYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})

        cboCourse.Items.Clear()
        cboCourse.Items.AddRange(New Object() {"BSIT", "BSCS", "BSIS", "BSEd"})

        cboStudentStatus.Items.Clear()
        cboStudentStatus.Items.AddRange(New Object() {"Active", "Inactive", "Graduated"})
    End Sub

    Private Sub LoadStudentData()
        Try
            If cn.State <> ConnectionState.Open Then cn.Open()

            Dim sql As String = "SELECT * FROM tblstudents WHERE StudentID = @StudentID"

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@StudentID", selectedStudent)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        txtLastName.Text = dr("LastName").ToString()
                        txtFirstName.Text = dr("FirstName").ToString()
                        txtMiddleName.Text = dr("MiddleName").ToString()
                        cboYearLevel.Text = dr("YearLevel").ToString()
                        txtSection.Text = dr("Section").ToString()
                        cboCourse.Text = dr("Course").ToString()
                        txtContactNumber.Text = dr("ContactNo").ToString()
                        cboStudentStatus.Text = dr("Status").ToString()
                    Else
                        MessageBox.Show("Student not found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading student details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        ' Validation
        If String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           cboCourse.SelectedIndex = -1 OrElse
           cboYearLevel.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all required student details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to save changes?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            If cn.State <> ConnectionState.Open Then cn.Open()

            Dim sql As String = "UPDATE tblstudents SET " &
                               "LastName = @LastName, " &
                               "FirstName = @FirstName, " &
                               "MiddleName = @MiddleName, " &
                               "YearLevel = @YearLevel, " &
                               "Section = @Section, " &
                               "Course = @Course, " &
                               "ContactNo = @ContactNumber, " &
                               "Status = @Status " &
                               "WHERE StudentID = @StudentID"

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim())
                cmd.Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
                cmd.Parameters.AddWithValue("@Section", txtSection.Text.Trim())
                cmd.Parameters.AddWithValue("@Course", cboCourse.Text)
                cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim())
                cmd.Parameters.AddWithValue("@Status", cboStudentStatus.Text)
                cmd.Parameters.AddWithValue("@StudentID", selectedStudent)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Student information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ReturnToStudentManagement()
                Else
                    MessageBox.Show("Failed to update student information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error saving student information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ReturnToStudentManagement()
    End Sub

    Private Sub ReturnToStudentManagement()
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmStudentManagement())
        Else
            Me.Close()
        End If
    End Sub


End Class