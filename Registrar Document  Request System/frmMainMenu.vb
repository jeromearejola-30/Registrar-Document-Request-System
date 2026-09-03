Public Class frmMainMenu

    Private Sub frmMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

    Public Property RoleProfile As String

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRole.Text = RoleProfile
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to log out?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            RoleProfile = String.Empty

            Dim loginForm As New frmLogin()
            loginForm.Show()

            Me.Dispose() ' Safely destroys frmMainMenu without closing the new login screen
        End If
    End Sub

End Class