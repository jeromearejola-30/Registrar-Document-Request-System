Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the close action was triggered by the user (clicking 'X' or pressing Alt+F4).
        If e.CloseReason = CloseReason.UserClosing Then
            If ExitApp() Then
                ' Environment.Exit(0) closes the whole process cleanly without re-triggering FormClosing events
                Environment.Exit(0)
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' User credentials validation
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter your Username.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter your Password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Return
        End If

        ' Login process
        Try
            ' Database connection
            dbConnect.Connection()

            ' Retrieves username to check if it exists
            dbConnect.sql = "SELECT * FROM tblUsers WHERE Username = @Username"
            dbConnect.cmd = New MySqlCommand(dbConnect.sql, dbConnect.cn)
            dbConnect.cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
            dbConnect.dr = dbConnect.cmd.ExecuteReader()

            ' User exist check
            If dbConnect.dr.Read() = False Then
                dbConnect.dr.Close() ' Safely close DataReader before exiting
                MessageBox.Show("User does not Exist.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
                Return
            End If

            ' Account status checking
            Dim Status As String = dbConnect.dr("Status").ToString()
            If Status = "Inactive" Then
                dbConnect.dr.Close()
                MessageBox.Show("This account is inactive and cannot log in.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Compares the stored password to the entered password
            Dim StoredPassword As String = dbConnect.dr("Password").ToString()
            If txtPassword.Text <> StoredPassword Then
                dbConnect.dr.Close()
                MessageBox.Show("Incorrect Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
                Return
            End If

            ' Retrieves the user role and passes it to the main menu
            Dim LoggedInRole As String = dbConnect.dr("Role").ToString()

            dbConnect.dr.Close()

            Dim result As DialogResult = MessageBox.Show("Logged in Successfully!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If result = DialogResult.OK Then
                Dim mainMenu As New frmMainMenu()
                mainMenu.RoleProfile = LoggedInRole

                Me.Hide()
                mainMenu.Show() ' Use .Show() instead of .ShowDialog() to prevent app termination on logout
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If dbConnect.cn IsNot Nothing AndAlso dbConnect.cn.State = ConnectionState.Open Then
                dbConnect.cn.Close()
            End If
        End Try

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class