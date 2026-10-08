Imports MySql.Data.MySqlClient

Public Class frmViewUser

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    Public Property SelectedUserId As String

    ' Values as loaded, to detect exactly what changed
    Private original As Dictionary(Of String, String)

    Private Function CurrentValues() As Dictionary(Of String, String)
        Return New Dictionary(Of String, String) From {
            {"FullName", txtUserFullName.Text.Trim()},
            {"Username", txtUsername.Text.Trim()},
            {"Role", cboUserRole.Text},
            {"Status", cboUserStatus.Text}
        }
    End Function

    Private Sub frmViewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 760)

        PopulateComboBoxes()
        btnDeleteUser.Visible = False   ' accounts are never deleted: use Status = Inactive
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
                            original = CurrentValues()
                            ' You cannot change your own role or status: that could lock you out of the system
                            If SelectedUserId = AppSession.UserID.ToString() Then
                                cboUserRole.Enabled = False
                                cboUserStatus.Enabled = False
                            End If
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
        Dim current As Dictionary(Of String, String) = CurrentValues()

        For Each kv In current
            If String.IsNullOrWhiteSpace(kv.Value) Then
                MessageBox.Show($"{kv.Key} cannot be empty.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        Dim changes As New List(Of String)
        For Each kv In current
            If kv.Value <> original(kv.Key) Then changes.Add($"{kv.Key}: '{original(kv.Key)}' -> '{kv.Value}'")
        Next
        If changes.Count = 0 Then
            MessageBox.Show("No changes were made.", "Nothing to Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show($"You are about to change the account '{original("Username")}':" & vbCrLf & vbCrLf &
                           String.Join(vbCrLf, changes) & vbCrLf & vbCrLf & "Are you sure?",
                           "Confirm User Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return

        Dim remarks As String
        Using dlg As New frmRemarks("Reason for Change", $"Why is the account '{original("Username")}' being changed?", RemarkReasons.UserChange)
            If dlg.ShowDialog(Me) <> DialogResult.OK Then Return
            remarks = dlg.FullText
        End Using

        Try
            Using c As New MySqlConnection(connStr)
                c.Open()

                ' Another account must not already use this username
                Using check As New MySqlCommand("SELECT COUNT(*) FROM tblUsers WHERE Username = @Username AND UserID <> @UserID", c)
                    check.Parameters.AddWithValue("@Username", current("Username"))
                    check.Parameters.AddWithValue("@UserID", SelectedUserId)
                    If Convert.ToInt32(check.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Another account already uses this username.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtUsername.Focus()
                        Return
                    End If
                End Using

                Using tx As MySqlTransaction = c.BeginTransaction()
                    Dim sql As String = "UPDATE tblUsers SET FullName = @FullName, Username = @Username, Role = @Role, Status = @Status WHERE UserID = @UserID"
                    Using cmd As New MySqlCommand(sql, c, tx)
                        cmd.Parameters.AddWithValue("@FullName", current("FullName"))
                        cmd.Parameters.AddWithValue("@Username", current("Username"))
                        cmd.Parameters.AddWithValue("@Role", current("Role"))
                        cmd.Parameters.AddWithValue("@Status", current("Status"))
                        cmd.Parameters.AddWithValue("@UserID", SelectedUserId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim action As String = "User Edited"
                    If changes.Count = 1 AndAlso current("Status") <> original("Status") Then
                        action = If(current("Status") = "Inactive", "User Deactivated", "User Reactivated")
                    End If
                    ActivityLogger.Log(c, tx, ActivityLogger.TypeUser, action, original("Username"),
                                       $"Edited user '{original("Username")}': " & String.Join("; ", changes), remarks)
                    tx.Commit()
                End Using
            End Using

            ' If you edited your own name or username, keep the session in step with the database
            If SelectedUserId = AppSession.UserID.ToString() Then
                AppSession.SignIn(AppSession.UserID, current("Username"), current("FullName"), AppSession.Role)
            End If

            MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToUserManagement()
        Catch ex As Exception
            MessageBox.Show("Error updating user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
