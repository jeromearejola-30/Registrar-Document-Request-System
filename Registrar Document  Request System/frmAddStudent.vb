Imports MySql.Data.MySqlClient

Public Class frmAddStudent

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 980)

        PopulateComboBoxes()
        ClearFields()
    End Sub

    Private Sub PopulateComboBoxes()
        cboYearLevel.Items.Clear()
        cboYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})

        cboCourse.Items.Clear()
        cboCourse.Items.AddRange(New Object() {"BSIT", "BSCS", "BSIS", "BSEd"})
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        ' Validation
        If String.IsNullOrWhiteSpace(txtStudentID.Text) OrElse
           String.IsNullOrWhiteSpace(txtLRN.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           cboCourse.SelectedIndex = -1 OrElse
           cboYearLevel.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all required fields (Student Number, LRN, First Name, Last Name, Course, Year Level).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saved As Boolean = False
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()

                ' Check for an existing duplicate Student Number or LRN
                Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tblstudents WHERE StudentID = @StudentID OR LRN = @LRN", c)
                    checkCmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@LRN", txtLRN.Text.Trim())
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("A student with this Student Number or LRN already exists.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtStudentID.Focus()
                        Return
                    End If
                End Using

                ' Insert record into tblstudents (and log it) in one transaction
                Dim sql As String = "INSERT INTO tblstudents (StudentID, LRN, LastName, FirstName, MiddleName, YearLevel, Section, Course, ContactNo, Status) " &
                                    "VALUES (@StudentID, @LRN, @LastName, @FirstName, @MiddleName, @YearLevel, @Section, @Course, @ContactNumber, 'Active')"
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Using cmd As New MySqlCommand(sql, c, tx)
                        cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text.Trim())
                        cmd.Parameters.AddWithValue("@LRN", txtLRN.Text.Trim())
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                        cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim())
                        cmd.Parameters.AddWithValue("@YearLevel", cboYearLevel.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@Section", txtSection.Text.Trim())
                        cmd.Parameters.AddWithValue("@Course", cboCourse.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim())
                        saved = cmd.ExecuteNonQuery() > 0
                    End Using
                    If saved Then
                        ActivityLogger.Log(c, tx, ActivityLogger.TypeStudent, "Student Added", txtStudentID.Text.Trim(),
                            $"Added student {txtStudentID.Text.Trim()} - {txtLastName.Text.Trim()}, {txtFirstName.Text.Trim()} ({cboCourse.SelectedItem} {cboYearLevel.SelectedItem})")
                        tx.Commit()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Leave the page only after the connection is closed
        If saved Then
            MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToStudentManagement()
        Else
            MessageBox.Show("Failed to register student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' Cancel button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ReturnToStudentManagement()
    End Sub

    Private Sub ClearFields()
        txtStudentID.Clear()
        txtLRN.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtSection.Clear()
        txtContactNumber.Clear()

        cboYearLevel.SelectedIndex = -1
        cboCourse.SelectedIndex = -1

        txtStudentID.Focus()
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