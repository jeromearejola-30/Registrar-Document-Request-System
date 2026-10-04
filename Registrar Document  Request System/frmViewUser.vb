Imports MySql.Data.MySqlClient

Public Class frmViewUser

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    Public Property SelectedUserId As String

    Private Sub frmViewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 760)

        PopulateComboBoxes()
        If Not String.IsNullOrEmpty(SelectedUserId) Then LoadViewedUser()
    End Sub

    Private Sub PopulateComboBoxes()
        cboUserRole.Items.Clear()
        cboUserRole.Items.AddRange(New Object() {"Administrator", "Registrar Staff"})

        cboUserStatus.Items.Clear()
        cboUserStatus.Items.AddRange(New Object() {"Active", "Inactive"})
    End Sub

    Private Sub LoadViewedUser()
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("SELECT FullName, Username, Role, Status FROM tblUsers WHERE UserID = @user_id", c)
                    cmd.Parameters.AddWithValue("@user_id", SelectedUserId)
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        If rd.Read() Then
                            txtUserFullName.Text = rd("FullName").ToString()
                            txtUsername.Text = rd("Username").ToString()
                            cboUserRole.SelectedIndex = cboUserRole.FindStringExact(rd("Role").ToString())
                            cboUserStatus.SelectedIndex = cboUserStatus.FindStringExact(rd("Status").ToString())
                        Else
                            MessageBox.Show("User not found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ReturnToUserManagement()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- SAVE / UPDATE USER DETAILS ---
    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        If String.IsNullOrWhiteSpace(txtUserFullName.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           cboUserRole.SelectedIndex = -1 OrElse
           cboUserStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to save changes to this user?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            Using c As New MySqlConnection(connStr)
                c.Open()

                ' Another account must not already use this username
                Using check As New MySqlCommand("SELECT COUNT(*) FROM tblUsers WHERE Username = @Username AND UserID <> @UserID", c)
                    check.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    check.Parameters.AddWithValue("@UserID", SelectedUserId)
                    If Convert.ToInt32(check.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Another account already uses this username.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtUsername.Focus()
                        Return
                    End If
                End Using

                Dim sql As String = "UPDATE tblUsers SET FullName = @FullName, Username = @Username, Role = @Role, Status = @Status WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(sql, c)
                    cmd.Parameters.AddWithValue("@FullName", txtUserFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@Role", cboUserRole.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Status", cboUserStatus.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@UserID", SelectedUserId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToUserManagement()
        Catch ex As Exception
            MessageBox.Show("Error updating user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- DELETE USER ---
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If String.IsNullOrEmpty(SelectedUserId) Then Return

        ' Nobody can delete the account they are logged in with
        Dim mainMenu = TryCast(Me.ParentForm, frmMainMenu)
        If mainMenu IsNot Nothing AndAlso
           String.Equals(txtUsername.Text.Trim(), mainMenu.UserName, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("You cannot delete the account you are currently logged in with.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to permanently delete this user? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result <> DialogResult.Yes Then Return

        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("DELETE FROM tblUsers WHERE UserID = @UserID", c)
                    cmd.Parameters.AddWithValue("@UserID", SelectedUserId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToUserManagement()
        Catch ex As MySqlException When ex.Number = 1451
            ' 1451 = a foreign key blocks the delete (this user created requests)
            MessageBox.Show("This user has created document requests and cannot be deleted." & vbCrLf &
                            "Set the account's Status to Inactive instead.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ReturnToUserManagement()
    End Sub

    Private Sub ReturnToUserManagement()
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmUserManagement())
        Else
            Me.Close()
        End If
    End Sub

End Class
