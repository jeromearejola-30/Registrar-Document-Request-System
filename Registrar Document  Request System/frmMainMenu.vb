Public Class frmMainMenu

    ' ---- Current user (set by frmLogin before Show) ----
    Public Property UserRole As String
    Public Property UserName As String

    ' Timer that refreshes the date/time label every second
    Private WithEvents timer1 As New System.Windows.Forms.Timer()

    ' Nothing = layout not applied yet; True = icon-only sidebar; False = full sidebar
    Private _compact As Boolean? = Nothing

    Private Sub frmMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If ExitApp() Then
                Environment.Exit(0)
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbSchoolLogo.Image = Theme.LoadLogo()
        lblUserProfile.Text = $"Welcome, {UserName} - ({UserRole})"

        ApplyResponsiveLayout()
        ShowChildForm(New frmDashboard()) ' default page

        timer1.Interval = 1000
        timer1.Start()
        UpdateDateTime()
    End Sub

    ' ---------------------------------------------------------------
    ' Responsive sidebar: full (260) on wide windows, icon-only (80) on narrow ones
    ' ---------------------------------------------------------------
    Private Sub frmMainMenu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ApplyResponsiveLayout()
    End Sub

    Private Sub ApplyResponsiveLayout()
        ' SizeChanged can fire before the controls exist (during InitializeComponent)
        If tlpRoot Is Nothing OrElse Not IsHandleCreated Then Return

        Dim wantCompact As Boolean = (ClientSize.Width < LogicalToDeviceUnits(1100))
        If _compact.HasValue AndAlso _compact.Value = wantCompact Then Return
        _compact = wantCompact

        SuspendLayout()
        CType(tlpRoot.ColumnStyles(0), ColumnStyle).Width = LogicalToDeviceUnits(If(wantCompact, 80, 260))
        tlpBrandText.Visible = Not wantCompact

        For Each btn As NavButton In {btnDashboard, btnStudentManagement, btnDocumentManagement,
                                      btnDocumentRequests, btnReports, btnUserManagement, btnLogout}
            btn.Compact = wantCompact
            ' In icon-only mode the tooltip tells the user what each icon is
            ttNav.SetToolTip(btn, If(wantCompact, btn.Text, String.Empty))
        Next
        ResumeLayout(True)
    End Sub

    ' ---------------------------------------------------------------
    ' Date / time
    ' ---------------------------------------------------------------
    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        UpdateDateTime()
    End Sub

    Private Sub UpdateDateTime()
        Dim current As DateTime = DateTime.Now
        lblDate.Text = current.ToString("dddd, MMMM dd, yyyy")
        lblTime.Text = current.ToString("hh:mm tt")
    End Sub

    ' ---------------------------------------------------------------
    ' Logout
    ' ---------------------------------------------------------------
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to log out?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UserRole = String.Empty
            UserName = String.Empty
            timer1.Stop()
            Dim loginForm As New frmLogin()
            loginForm.Show()

            Me.Dispose() ' Safely destroys frmMainMenu without closing the new login screen
        End If
    End Sub

    ' ---------------------------------------------------------------
    ' Page hosting (called by the sidebar AND by child forms such as frmAddStudent)
    ' ---------------------------------------------------------------
    Public Sub ShowChildForm(childForm As Form)
        ' Work out which header title / sidebar item belongs to this page
        Dim title As String = Nothing
        Dim nav As NavButton = Nothing
        ResolvePage(childForm, title, nav)

        If Not String.IsNullOrEmpty(title) Then lblSection.Text = title
        If nav IsNot Nothing Then SetActiveNav(nav)

        ' Remember the old page, add the new one first, then dispose the old one (no flicker)
        Dim oldPage As Control = If(pnlContent.Controls.Count > 0, pnlContent.Controls(0), Nothing)

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        childForm.BackColor = Theme.Background

        pnlContent.Controls.Add(childForm)
        childForm.BringToFront()
        childForm.Show()

        If oldPage IsNot Nothing Then oldPage.Dispose()
    End Sub

    ''' <summary>Maps a page (including add/edit/view pages) to its header title and sidebar item.</summary>
    Private Sub ResolvePage(page As Form, ByRef title As String, ByRef nav As NavButton)
        Select Case True
            Case TypeOf page Is frmDashboard
                title = "Dashboard" : nav = btnDashboard

            Case TypeOf page Is frmStudentManagement
                title = "Student Management" : nav = btnStudentManagement
            Case TypeOf page Is frmAddStudent
                title = "Add Student" : nav = btnStudentManagement
            Case TypeOf page Is frmEditStudent
                title = "Edit Student" : nav = btnStudentManagement

            Case TypeOf page Is frmDocumentManagement
                title = "Document Management" : nav = btnDocumentManagement
            Case TypeOf page Is frmAddDocument
                title = "Add Document" : nav = btnDocumentManagement
            Case TypeOf page Is frmEditDocument
                title = "Edit Document" : nav = btnDocumentManagement

            Case TypeOf page Is frmDocumentRequest
                title = "Document Requests" : nav = btnDocumentRequests
            Case TypeOf page Is frmCreateDocumentRequest, TypeOf page Is frmCreateRequest
                title = "Create Document Request" : nav = btnDocumentRequests

            Case TypeOf page Is frmReport
                title = "Reports" : nav = btnReports
            Case TypeOf page Is frmPaymentReport
                title = "Payment Report" : nav = btnReports

            Case TypeOf page Is frmUserManagement
                title = "User Management" : nav = btnUserManagement
            Case TypeOf page Is frmAddUser
                title = "Add User" : nav = btnUserManagement
            Case TypeOf page Is frmViewUser
                title = "View User" : nav = btnUserManagement

            Case Else
                title = page.Text ' any other page: use the form's own Text
        End Select
    End Sub

    Private Sub SetActiveNav(active As NavButton)
        For Each btn As NavButton In {btnDashboard, btnStudentManagement, btnDocumentManagement,
                                      btnDocumentRequests, btnReports, btnUserManagement}
            btn.Active = (btn Is active)
        Next
    End Sub

    ' ---------------------------------------------------------------
    ' Sidebar clicks
    ' ---------------------------------------------------------------
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowChildForm(New frmDashboard())
    End Sub

    Private Sub btnStudentManagement_Click(sender As Object, e As EventArgs) Handles btnStudentManagement.Click
        ShowChildForm(New frmStudentManagement())
    End Sub

    Private Sub btnDocumentManagement_Click(sender As Object, e As EventArgs) Handles btnDocumentManagement.Click
        ShowChildForm(New frmDocumentManagement())
    End Sub

    Private Sub btnDocumentRequests_Click(sender As Object, e As EventArgs) Handles btnDocumentRequests.Click
        ShowChildForm(New frmDocumentRequest())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ShowChildForm(New frmReport())
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        ShowChildForm(New frmUserManagement())
    End Sub

End Class
