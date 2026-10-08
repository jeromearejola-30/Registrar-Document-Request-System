Imports MySql.Data.MySqlClient

Public Class frmAddUser

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 760)

        PopulateComboBoxes()
    End Sub

    Private Sub PopulateComboBoxes()
        cboUserRole.Items.Clear()
        cboUserRole.Items.AddRange(New Object() {"Administrator", "Registrar Staff"})
        cboUserRole.SelectedIndex = -1   ' the role must be chosen on purpose

        cboUserStatus.Items.Clear()
        cboUserStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboUserStatus.SelectedIndex = 0  ' new accounts start as Active
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' --- CREATE USER ---
    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmPassword.Text) OrElse
           cboUserRole.SelectedIndex = -1 OrElse
           cboUserStatus.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match. Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtConfirmPassword.Clear()
            txtConfirmPassword.Focus()
            Return
        End If

        Try
            Using c As New MySqlConnection(connStr)
                c.Open()

                ' Usernames must be unique
                Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tblUsers WHERE Username = @Username", c)
                    checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtUsername.Focus()
                        Return
                    End If
                End Using

                Dim sql As String = "INSERT INTO tblUsers (FullName, Username, Password, Role, Status) " &
                                    "VALUES (@FullName, @Username, @Password, @Role, @Status)"
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Using cmd As New MySqlCommand(sql, c, tx)
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                        cmd.Parameters.AddWithValue("@Role", cboUserRole.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@Status", cboUserStatus.SelectedItem.ToString())
                        cmd.ExecuteNonQuery()
                    End Using
                    ' The password is never written to the log
                    ActivityLogger.Log(c, tx, ActivityLogger.TypeUser, "User Added", txtUsername.Text.Trim(),
                        $"Added user account '{txtUsername.Text.Trim()}' ({txtFullName.Text.Trim()}) with role {cboUserRole.SelectedItem} and status {cboUserStatus.SelectedItem}")
                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToUserManagement()
        Catch ex As Exception
            MessageBox.Show("Error creating user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ReturnToUserManagement()
    End Sub

    Private Sub ClearFields()
        txtFullName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        chkShowPassword.Checked = False
        cboUserRole.SelectedIndex = -1
        cboUserStatus.SelectedIndex = 0
        txtFullName.Focus()
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
