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

    ' Properties to hold the current user's role and name
    Public Property UserRole As String
    Public Property UserName As String
    ' Timer to update the current date and time every second
    Private WithEvents timer1 As New System.Windows.Forms.Timer()

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ShowChildForm(frmDashboard) ' Display the dashboard form by default when the main menu loads

        ' Set the user profile label with the current user's name and role
        lblUserProfile.Text = $"Welcome, {UserName} - ({UserRole})"

        timer1.Interval = 1000 ' Set the timer interval to 1 second (1000 milliseconds)
        timer1.Start() ' Start the timer to update the time every second

        UpdateTime_Tick() ' Initial call to display the current time immediately
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        UpdateTime_Tick()
    End Sub

    Private Sub UpdateTime_Tick()
        Dim currentTime As DateTime = DateTime.Now
        ' Update the labels with the current date and time
        lblDate.Text = currentTime.ToString("MMMM, dddd dd, yyyy")
        lblTime.Text = currentTime.ToString("hh:mm tt")

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

    Private Sub ShowChildForm(childForm As Form)
        ' Close the current child form if it exists
        If Me.pnlContentArea.Controls.Count > 0 Then
            Me.pnlContentArea.Controls(0).Dispose() ' Safely dispose of the current child form to free resources
        End If
        ' Set the new child form properties and display it
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.pnlContentArea.Controls.Add(childForm)
        Me.pnlContentArea.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowChildForm(frmDashboard)
    End Sub
    Private Sub btnStudentManagement_Click(sender As Object, e As EventArgs) Handles btnStudentManagement.Click
        ShowChildForm(frmStudentManagement)
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        ShowChildForm(frmUserManagement)
    End Sub

    Private Sub btnDocumentManagement_Click(sender As Object, e As EventArgs) Handles btnDocumentManagement.Click
        ShowChildForm(frmDocumentManagement)
    End Sub

    Private Sub btnDocumentRequests_Click(sender As Object, e As EventArgs) Handles btnDocumentRequests.Click
        ShowChildForm(frmDocumentRequest)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ShowChildForm(frmReports)
    End Sub

End Class