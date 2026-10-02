Imports MySql.Data.MySqlClient

Public Class frmAddUser

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBoxes()

    End Sub

    ' Populate dropdown options on load
    Private Sub PopulateComboBoxes()
        cboUserRole.Items.Clear()
        cboUserRole.Items.AddRange(New Object() {"Administrator", "Registrar Staff"})
        cboUserRole.SelectedIndex = -1

        cboUserStatus.Items.Clear()
        cboUserStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboUserStatus.SelectedIndex = -1
    End Sub

    ' --- CREATE USER ---
    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        ' 1. Validate required fields
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmPassword.Text) OrElse
           cboUserRole.SelectedIndex = -1 OrElse
           cboUserStatus.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Check if Passwords match
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match. Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtConfirmPassword.Clear()
            txtConfirmPassword.Focus()
            Return
        End If

        Try
            If cn.State <> ConnectionState.Open Then cn.Open()

            ' 3. Check for existing duplicate Username
            Dim checkSql As String = "SELECT COUNT(*) FROM tblUsers WHERE Username = @Username"
            Using checkCmd As New MySqlCommand(checkSql, cn)
                checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If userExists > 0 Then
                    MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUsername.Focus()
                    Return
                End If
            End Using

            ' 4. Insert new user into database
            ' Note: Replace 'Password' column name if your DB uses another column like 'password_hash'
            Dim sql As String = "INSERT INTO tblUsers (FullName, Username, Password, Role, Status) " &
                               "VALUES (@FullName, @Username, @Password, @Role, @Status)"

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@Role", cboUserRole.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Status", cboUserStatus.SelectedItem.ToString())

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ReturnToUserManagement()
                Else
                    MessageBox.Show("Failed to create user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error creating user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' --- CLEAR INPUTS ---
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' --- CANCEL ---
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ReturnToUserManagement()
    End Sub

    Private Sub ClearFields()
        txtFullName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        If cboUserRole.Items.Count > 0 Then cboUserRole.SelectedIndex = 0
        If cboUserStatus.Items.Count > 0 Then cboUserStatus.SelectedIndex = 0

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