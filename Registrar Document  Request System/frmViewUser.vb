Imports MySql.Data.MySqlClient

Public Class frmViewUser

    Public Property SelectedUserId As String

    Private Sub frmViewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Populate the drop-down options first
        PopulateComboBoxes()

        ' 2. Load the user's details and select their values
        If Not String.IsNullOrEmpty(SelectedUserId) Then
            LoadViewedUser()
        End If
    End Sub

    Private Sub PopulateComboBoxes()
        ' Add Role options
        cboUserRole.Items.Clear()
        cboUserRole.Items.AddRange(New Object() {"Administrator", "Registrar Staff"})

        ' Add Status options
        cboUserStatus.Items.Clear()
        cboUserStatus.Items.AddRange(New Object() {"Active", "Inactive"})
    End Sub

    Private Sub LoadViewedUser()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblUsers WHERE UserID = @user_id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@user_id", SelectedUserId)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtUserFullName.Text = dr("FullName").ToString()
                txtUsername.Text = dr("Username").ToString()

                ' Assign using .Text so it matches even if formatting differs slightly
                cboUserRole.Text = dr("Role").ToString()
                cboUserStatus.Text = dr("Status").ToString()
            Else
                MessageBox.Show("User not found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    ' --- SAVE / UPDATE USER DETAILS ---
    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        ' Basic validation
        If String.IsNullOrWhiteSpace(txtUserFullName.Text) OrElse String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to save changes to this user?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            If cn.State <> ConnectionState.Open Then cn.Open()

            sql = "UPDATE tblUsers SET FullName = @FullName, Username = @Username, Role = @Role, Status = @Status WHERE UserID = @UserID"

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@FullName", txtUserFullName.Text.Trim())
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@Role", If(cboUserRole.SelectedItem IsNot Nothing, cboUserRole.SelectedItem.ToString(), ""))
                cmd.Parameters.AddWithValue("@Status", If(cboUserStatus.SelectedItem IsNot Nothing, cboUserStatus.SelectedItem.ToString(), ""))
                cmd.Parameters.AddWithValue("@UserID", SelectedUserId)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ReturnToUserManagement()
                Else
                    MessageBox.Show("Failed to update user details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' --- DELETE USER ---
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If String.IsNullOrEmpty(SelectedUserId) Then Return

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to permanently delete this user? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result <> DialogResult.Yes Then Return

        Try
            If cn.State <> ConnectionState.Open Then cn.Open()

            sql = "DELETE FROM tblUsers WHERE UserID = @UserID"

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@UserID", SelectedUserId)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ReturnToUserManagement()
                Else
                    MessageBox.Show("Could not delete user record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' --- CANCEL BUTTON ---
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ReturnToUserManagement()
    End Sub

    ' --- HELPER TO GO BACK TO USER MANAGEMENT ---
    Private Sub ReturnToUserManagement()
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            ' Reloads frmUserManagement in the main container panel
            parentMainForm.ShowChildForm(New frmUserManagement())
        Else
            ' Fallback if opened as modal dialog
            Me.Close()
        End If
    End Sub

End Class