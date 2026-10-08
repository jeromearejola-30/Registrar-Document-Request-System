Imports MySql.Data.MySqlClient

Public Class frmEditStudent

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    Public Property selectedStudent As String

    ' Values as they were loaded, so we can tell exactly what the user changed
    Private original As Dictionary(Of String, String)

    Private Function CurrentValues() As Dictionary(Of String, String)
        Return New Dictionary(Of String, String) From {
            {"LastName", txtLastName.Text.Trim()},
            {"FirstName", txtFirstName.Text.Trim()},
            {"MiddleName", txtMiddleName.Text.Trim()},
            {"YearLevel", cboYearLevel.Text},
            {"Section", txtSection.Text.Trim()},
            {"Course", cboCourse.Text},
            {"ContactNo", txtContactNumber.Text.Trim()},
            {"Status", cboStudentStatus.Text}
        }
    End Function

    Private Sub frmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 980)

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
        cboStudentStatus.Items.AddRange(New Object() {"Active", "Inactive"}) ' matches tblstudents.Status (enum Active/Inactive)
    End Sub

    Private Sub LoadStudentData()
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("SELECT * FROM tblstudents WHERE StudentID = @StudentID", c)
                    cmd.Parameters.AddWithValue("@StudentID", selectedStudent)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtStudentID.Text = selectedStudent
                            txtLRN.Text = dr("LRN").ToString()
                            txtLastName.Text = dr("LastName").ToString()
                            txtFirstName.Text = dr("FirstName").ToString()
                            txtMiddleName.Text = dr("MiddleName").ToString()
                            cboYearLevel.Text = dr("YearLevel").ToString()
                            txtSection.Text = dr("Section").ToString()
                            cboCourse.Text = dr("Course").ToString()
                            txtContactNumber.Text = dr("ContactNo").ToString()
                            cboStudentStatus.Text = dr("Status").ToString()
                            original = CurrentValues()
                        Else
                            MessageBox.Show("Student not found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        Dim current As Dictionary(Of String, String) = CurrentValues()

        ' 1. Every field must be filled in
        For Each kv In current
            If String.IsNullOrWhiteSpace(kv.Value) Then
                MessageBox.Show($"{kv.Key} cannot be empty. If a student has no middle name, enter N/A.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        ' 2. What actually changed?
        Dim changes As New List(Of String)
        For Each kv In current
            If kv.Value <> original(kv.Key) Then
                changes.Add($"{kv.Key}: '{original(kv.Key)}' -> '{kv.Value}'")
            End If
        Next
        If changes.Count = 0 Then
            MessageBox.Show("No changes were made.", "Nothing to Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' 3. Warning message box that lists the changes
        Dim warning As DialogResult = MessageBox.Show(
            $"You are about to change the record of student {selectedStudent}:" & vbCrLf & vbCrLf &
            String.Join(vbCrLf, changes) & vbCrLf & vbCrLf &
            "Student records are official. Are you sure about these changes?",
            "Confirm Student Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If warning <> DialogResult.Yes Then Return

        ' 4. Mandatory reason + details (a different reason list when the status is what changed)
        Dim statusChanged As Boolean = current("Status") <> original("Status")
        Dim reasons As String() = If(statusChanged, RemarkReasons.StudentStatus, RemarkReasons.StudentEdit)
        Dim remarks As String
        Using dlg As New frmRemarks("Reason for Change", $"Why is student {selectedStudent} being changed?", reasons)
            If dlg.ShowDialog(Me) <> DialogResult.OK Then Return
            remarks = dlg.FullText
        End Using

        ' 5. Update + log in ONE transaction
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Dim sql As String = "UPDATE tblstudents SET LastName = @LastName, FirstName = @FirstName, " &
                                        "MiddleName = @MiddleName, YearLevel = @YearLevel, Section = @Section, " &
                                        "Course = @Course, ContactNo = @ContactNumber, Status = @Status " &
                                        "WHERE StudentID = @StudentID"
                    Using cmd As New MySqlCommand(sql, c, tx)
                        cmd.Parameters.AddWithValue("@LastName", current("LastName"))
                        cmd.Parameters.AddWithValue("@FirstName", current("FirstName"))
                        cmd.Parameters.AddWithValue("@MiddleName", current("MiddleName"))
                        cmd.Parameters.AddWithValue("@YearLevel", current("YearLevel"))
                        cmd.Parameters.AddWithValue("@Section", current("Section"))
                        cmd.Parameters.AddWithValue("@Course", current("Course"))
                        cmd.Parameters.AddWithValue("@ContactNumber", current("ContactNo"))
                        cmd.Parameters.AddWithValue("@Status", current("Status"))
                        cmd.Parameters.AddWithValue("@StudentID", selectedStudent)
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim action As String = "Student Edited"
                    If statusChanged AndAlso changes.Count = 1 Then
                        action = If(current("Status") = "Inactive", "Student Deactivated", "Student Reactivated")
                    End If
                    ActivityLogger.Log(c, tx, ActivityLogger.TypeStudent, action, selectedStudent,
                                       $"Edited student {selectedStudent}: " & String.Join("; ", changes), remarks)
                    tx.Commit()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving student information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        MessageBox.Show("Student information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ReturnToStudentManagement()
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