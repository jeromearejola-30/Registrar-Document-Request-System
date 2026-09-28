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

    Public Property UserRole As String
    Public Property UserName As String

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserProfile.Text = $"Welcome, {UserName} - ({UserRole})"

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to log out?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            UserRole = String.Empty
            UserName = String.Empty
            Dim loginForm As New frmLogin()
            loginForm.Show()

            Me.Dispose() ' Safely destroys frmMainMenu without closing the new login screen
        End If
    End Sub

    Private Sub btnStudentManagement_Click(sender As Object, e As EventArgs) Handles btnStudentManagement.Click
        frmStudentManagement.Show()
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        frmUserManagement.Show()
    End Sub

    Private Sub btnDocumentManagement_Click(sender As Object, e As EventArgs) Handles btnDocumentManagement.Click
        frmDocumentManagement.Show()
    End Sub

    Private Sub btnDocumentRequests_Click(sender As Object, e As EventArgs) Handles btnDocumentRequests.Click
        frmDocumentRequest.Show()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        frmReports.Show()
    End Sub

    Private Sub lblUserProfile_Click(sender As Object, e As EventArgs) Handles lblUserProfile.Click

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class