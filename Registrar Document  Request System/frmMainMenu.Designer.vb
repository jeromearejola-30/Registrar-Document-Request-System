<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        ttNav = New ToolTip(components)
        tlpRoot = New TableLayoutPanel()
        pnlSidebar = New Panel()
        pnlNav = New Panel()
        btnUserManagement = New NavButton()
        btnReports = New NavButton()
        btnDocumentRequests = New NavButton()
        btnDocumentManagement = New NavButton()
        btnStudentManagement = New NavButton()
        btnDashboard = New NavButton()
        pnlBottom = New Panel()
        btnLogout = New NavButton()
        pnlBottomLine = New Panel()
        pnlBrand = New Panel()
        tlpBrand = New TableLayoutPanel()
        pbSchoolLogo = New PictureBox()
        tlpBrandText = New TableLayoutPanel()
        lblRegistrar = New Label()
        lblDocumentRequestSystem = New Label()
        pnlBrandLine = New Panel()
        pnlMain = New Panel()
        pnlContent = New Panel()
        pnlHeader = New Panel()
        tlpHeader = New TableLayoutPanel()
        flpTitle = New FlowLayoutPanel()
        lblSection = New Label()
        pnlTitleAccent = New Panel()
        lblUserProfile = New Label()
        tlpDateTime = New TableLayoutPanel()
        lblDate = New Label()
        lblTime = New Label()
        lblCalendarIcon = New Label()
        pnlHeaderLine = New Panel()
        tlpRoot.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlNav.SuspendLayout()
        pnlBottom.SuspendLayout()
        pnlBrand.SuspendLayout()
        tlpBrand.SuspendLayout()
        CType(pbSchoolLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        tlpBrandText.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlHeader.SuspendLayout()
        tlpHeader.SuspendLayout()
        flpTitle.SuspendLayout()
        tlpDateTime.SuspendLayout()
        SuspendLayout()
        '
        ' tlpRoot  (sidebar | main area)
        '
        tlpRoot.ColumnCount = 2
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 260.0F))
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlpRoot.Controls.Add(pnlSidebar, 0, 0)
        tlpRoot.Controls.Add(pnlMain, 1, 0)
        tlpRoot.Dock = DockStyle.Fill
        tlpRoot.Location = New Point(0, 0)
        tlpRoot.Margin = New Padding(0)
        tlpRoot.Name = "tlpRoot"
        tlpRoot.RowCount = 1
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpRoot.Size = New Size(1280, 760)
        tlpRoot.TabIndex = 0
        '
        ' pnlSidebar
        '
        pnlSidebar.BackColor = Color.FromArgb(27, 67, 50)
        pnlSidebar.Controls.Add(pnlNav)
        pnlSidebar.Controls.Add(pnlBottom)
        pnlSidebar.Controls.Add(pnlBrand)
        pnlSidebar.Dock = DockStyle.Fill
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(260, 760)
        pnlSidebar.TabIndex = 0
        '
        ' pnlNav  (menu buttons, docked top, added in reverse visual order)
        '
        pnlNav.Controls.Add(btnUserManagement)
        pnlNav.Controls.Add(btnReports)
        pnlNav.Controls.Add(btnDocumentRequests)
        pnlNav.Controls.Add(btnDocumentManagement)
        pnlNav.Controls.Add(btnStudentManagement)
        pnlNav.Controls.Add(btnDashboard)
        pnlNav.Dock = DockStyle.Fill
        pnlNav.Location = New Point(0, 96)
        pnlNav.Name = "pnlNav"
        pnlNav.Padding = New Padding(0, 12, 0, 0)
        pnlNav.Size = New Size(260, 592)
        pnlNav.TabIndex = 1
        '
        ' btnDashboard
        '
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnDashboard.Glyph = ChrW(&HE80F)
        btnDashboard.Margin = New Padding(0)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(260, 52)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        '
        ' btnStudentManagement
        '
        btnStudentManagement.Dock = DockStyle.Top
        btnStudentManagement.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnStudentManagement.Glyph = ChrW(&HE716)
        btnStudentManagement.Margin = New Padding(0)
        btnStudentManagement.Name = "btnStudentManagement"
        btnStudentManagement.Size = New Size(260, 52)
        btnStudentManagement.TabIndex = 1
        btnStudentManagement.Text = "Student Management"
        '
        ' btnDocumentManagement
        '
        btnDocumentManagement.Dock = DockStyle.Top
        btnDocumentManagement.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnDocumentManagement.Glyph = ChrW(&HE8A5)
        btnDocumentManagement.Margin = New Padding(0)
        btnDocumentManagement.Name = "btnDocumentManagement"
        btnDocumentManagement.Size = New Size(260, 52)
        btnDocumentManagement.TabIndex = 2
        btnDocumentManagement.Text = "Document Management"
        '
        ' btnDocumentRequests
        '
        btnDocumentRequests.Dock = DockStyle.Top
        btnDocumentRequests.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnDocumentRequests.Glyph = ChrW(&HE8FD)
        btnDocumentRequests.Margin = New Padding(0)
        btnDocumentRequests.Name = "btnDocumentRequests"
        btnDocumentRequests.Size = New Size(260, 52)
        btnDocumentRequests.TabIndex = 3
        btnDocumentRequests.Text = "Document Requests"
        '
        ' btnReports
        '
        btnReports.Dock = DockStyle.Top
        btnReports.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnReports.Glyph = ChrW(&HE9D9)
        btnReports.Margin = New Padding(0)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(260, 52)
        btnReports.TabIndex = 4
        btnReports.Text = "Reports"
        '
        ' btnUserManagement
        '
        btnUserManagement.Dock = DockStyle.Top
        btnUserManagement.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnUserManagement.Glyph = ChrW(&HE77B)
        btnUserManagement.Margin = New Padding(0)
        btnUserManagement.Name = "btnUserManagement"
        btnUserManagement.Size = New Size(260, 52)
        btnUserManagement.TabIndex = 5
        btnUserManagement.Text = "User Management"
        '
        ' pnlBottom  (logout)
        '
        pnlBottom.Controls.Add(btnLogout)
        pnlBottom.Controls.Add(pnlBottomLine)
        pnlBottom.Dock = DockStyle.Bottom
        pnlBottom.Location = New Point(0, 688)
        pnlBottom.Name = "pnlBottom"
        pnlBottom.Padding = New Padding(0, 8, 0, 8)
        pnlBottom.Size = New Size(260, 72)
        pnlBottom.TabIndex = 2
        '
        ' btnLogout
        '
        btnLogout.Dock = DockStyle.Fill
        btnLogout.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogout.Glyph = ChrW(&HE7E8)
        btnLogout.Margin = New Padding(0)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(260, 55)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Log Out"
        '
        ' pnlBottomLine
        '
        pnlBottomLine.BackColor = Color.FromArgb(45, 106, 79)
        pnlBottomLine.Dock = DockStyle.Top
        pnlBottomLine.Name = "pnlBottomLine"
        pnlBottomLine.Size = New Size(260, 1)
        pnlBottomLine.TabIndex = 1
        '
        ' pnlBrand  (logo + system name)
        '
        pnlBrand.Controls.Add(tlpBrand)
        pnlBrand.Controls.Add(pnlBrandLine)
        pnlBrand.Dock = DockStyle.Top
        pnlBrand.Location = New Point(0, 0)
        pnlBrand.Name = "pnlBrand"
        pnlBrand.Size = New Size(260, 96)
        pnlBrand.TabIndex = 0
        '
        ' tlpBrand
        '
        tlpBrand.ColumnCount = 2
        tlpBrand.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 80.0F))
        tlpBrand.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlpBrand.Controls.Add(pbSchoolLogo, 0, 0)
        tlpBrand.Controls.Add(tlpBrandText, 1, 0)
        tlpBrand.Dock = DockStyle.Fill
        tlpBrand.Margin = New Padding(0)
        tlpBrand.Name = "tlpBrand"
        tlpBrand.RowCount = 1
        tlpBrand.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpBrand.Size = New Size(260, 95)
        tlpBrand.TabIndex = 0
        '
        ' pbSchoolLogo
        '
        pbSchoolLogo.Anchor = AnchorStyles.None
        pbSchoolLogo.BackColor = Color.Transparent
        pbSchoolLogo.Margin = New Padding(0)
        pbSchoolLogo.Name = "pbSchoolLogo"
        pbSchoolLogo.Size = New Size(56, 56)
        pbSchoolLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbSchoolLogo.TabIndex = 0
        pbSchoolLogo.TabStop = False
        '
        ' tlpBrandText
        '
        tlpBrandText.ColumnCount = 1
        tlpBrandText.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlpBrandText.Controls.Add(lblRegistrar, 0, 0)
        tlpBrandText.Controls.Add(lblDocumentRequestSystem, 0, 1)
        tlpBrandText.Dock = DockStyle.Fill
        tlpBrandText.Margin = New Padding(0)
        tlpBrandText.Name = "tlpBrandText"
        tlpBrandText.RowCount = 2
        tlpBrandText.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tlpBrandText.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tlpBrandText.Size = New Size(180, 95)
        tlpBrandText.TabIndex = 1
        '
        ' lblRegistrar
        '
        lblRegistrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblRegistrar.AutoSize = True
        lblRegistrar.Font = New Font("Segoe UI Semibold", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblRegistrar.ForeColor = Color.White
        lblRegistrar.Margin = New Padding(0)
        lblRegistrar.Name = "lblRegistrar"
        lblRegistrar.Size = New Size(87, 28)
        lblRegistrar.TabIndex = 0
        lblRegistrar.Text = "Registrar"
        '
        ' lblDocumentRequestSystem
        '
        lblDocumentRequestSystem.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblDocumentRequestSystem.AutoSize = True
        lblDocumentRequestSystem.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblDocumentRequestSystem.ForeColor = Color.FromArgb(191, 214, 201)
        lblDocumentRequestSystem.Margin = New Padding(0)
        lblDocumentRequestSystem.Name = "lblDocumentRequestSystem"
        lblDocumentRequestSystem.Size = New Size(131, 15)
        lblDocumentRequestSystem.TabIndex = 1
        lblDocumentRequestSystem.Text = "Document Request System"
        '
        ' pnlBrandLine
        '
        pnlBrandLine.BackColor = Color.FromArgb(45, 106, 79)
        pnlBrandLine.Dock = DockStyle.Bottom
        pnlBrandLine.Name = "pnlBrandLine"
        pnlBrandLine.Size = New Size(260, 1)
        pnlBrandLine.TabIndex = 1
        '
        ' pnlMain  (header + page content)
        '
        pnlMain.BackColor = Color.FromArgb(245, 247, 244)
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Margin = New Padding(0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1020, 760)
        pnlMain.TabIndex = 1
        '
        ' pnlContent  (child forms are embedded here)
        '
        pnlContent.BackColor = Color.FromArgb(245, 247, 244)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 96)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1020, 664)
        pnlContent.TabIndex = 1
        '
        ' pnlHeader
        '
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(tlpHeader)
        pnlHeader.Controls.Add(pnlHeaderLine)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1020, 96)
        pnlHeader.TabIndex = 0
        '
        ' tlpHeader
        '
        tlpHeader.ColumnCount = 2
        tlpHeader.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlpHeader.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        tlpHeader.Controls.Add(flpTitle, 0, 0)
        tlpHeader.Controls.Add(tlpDateTime, 1, 0)
        tlpHeader.Dock = DockStyle.Fill
        tlpHeader.Margin = New Padding(0)
        tlpHeader.Name = "tlpHeader"
        tlpHeader.Padding = New Padding(28, 0, 28, 0)
        tlpHeader.RowCount = 1
        tlpHeader.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpHeader.Size = New Size(1020, 95)
        tlpHeader.TabIndex = 0
        '
        ' flpTitle
        '
        flpTitle.Anchor = AnchorStyles.Left
        flpTitle.AutoSize = True
        flpTitle.Controls.Add(lblSection)
        flpTitle.Controls.Add(pnlTitleAccent)
        flpTitle.Controls.Add(lblUserProfile)
        flpTitle.FlowDirection = FlowDirection.TopDown
        flpTitle.Margin = New Padding(0)
        flpTitle.Name = "flpTitle"
        flpTitle.Size = New Size(260, 70)
        flpTitle.TabIndex = 0
        flpTitle.WrapContents = False
        '
        ' lblSection
        '
        lblSection.AutoSize = True
        lblSection.Font = New Font("Segoe UI Semibold", 20.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblSection.ForeColor = Color.FromArgb(27, 67, 50)
        lblSection.Margin = New Padding(0)
        lblSection.Name = "lblSection"
        lblSection.Size = New Size(140, 37)
        lblSection.TabIndex = 0
        lblSection.Text = "Dashboard"
        '
        ' pnlTitleAccent  (gold underline)
        '
        pnlTitleAccent.BackColor = Color.FromArgb(242, 184, 7)
        pnlTitleAccent.Margin = New Padding(2, 2, 0, 6)
        pnlTitleAccent.Name = "pnlTitleAccent"
        pnlTitleAccent.Size = New Size(56, 4)
        pnlTitleAccent.TabIndex = 1
        '
        ' lblUserProfile
        '
        lblUserProfile.AutoSize = True
        lblUserProfile.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblUserProfile.ForeColor = Color.FromArgb(107, 114, 128)
        lblUserProfile.Margin = New Padding(2, 0, 0, 0)
        lblUserProfile.Name = "lblUserProfile"
        lblUserProfile.Size = New Size(179, 15)
        lblUserProfile.TabIndex = 2
        lblUserProfile.Text = "Welcome, Username - UserRole"
        '
        ' tlpDateTime  (date/time text + calendar icon)
        '
        tlpDateTime.Anchor = AnchorStyles.Right
        tlpDateTime.AutoSize = True
        tlpDateTime.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpDateTime.ColumnCount = 2
        tlpDateTime.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        tlpDateTime.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        tlpDateTime.Controls.Add(lblDate, 0, 0)
        tlpDateTime.Controls.Add(lblTime, 0, 1)
        tlpDateTime.Controls.Add(lblCalendarIcon, 1, 0)
        tlpDateTime.Margin = New Padding(0)
        tlpDateTime.Name = "tlpDateTime"
        tlpDateTime.RowCount = 2
        tlpDateTime.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpDateTime.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpDateTime.Size = New Size(260, 48)
        tlpDateTime.TabIndex = 1
        tlpDateTime.SetRowSpan(lblCalendarIcon, 2)
        '
        ' lblDate
        '
        lblDate.Anchor = AnchorStyles.Right
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDate.ForeColor = Color.FromArgb(31, 41, 55)
        lblDate.Margin = New Padding(0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(190, 20)
        lblDate.TabIndex = 0
        lblDate.Text = "Sunday, October 04, 2026"
        '
        ' lblTime
        '
        lblTime.Anchor = AnchorStyles.Right
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblTime.ForeColor = Color.FromArgb(107, 114, 128)
        lblTime.Margin = New Padding(0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(64, 19)
        lblTime.TabIndex = 1
        lblTime.Text = "09:41 PM"
        '
        ' lblCalendarIcon
        '
        lblCalendarIcon.Anchor = AnchorStyles.None
        lblCalendarIcon.BackColor = Color.FromArgb(229, 231, 235)
        lblCalendarIcon.Font = New Font("Segoe MDL2 Assets", 16.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblCalendarIcon.ForeColor = Color.FromArgb(27, 67, 50)
        lblCalendarIcon.Margin = New Padding(14, 0, 0, 0)
        lblCalendarIcon.Name = "lblCalendarIcon"
        lblCalendarIcon.Size = New Size(46, 46)
        lblCalendarIcon.TabIndex = 2
        lblCalendarIcon.Text = ChrW(&HE787)
        lblCalendarIcon.TextAlign = ContentAlignment.MiddleCenter
        '
        ' pnlHeaderLine
        '
        pnlHeaderLine.BackColor = Color.FromArgb(229, 231, 235)
        pnlHeaderLine.Dock = DockStyle.Bottom
        pnlHeaderLine.Name = "pnlHeaderLine"
        pnlHeaderLine.Size = New Size(1020, 1)
        pnlHeaderLine.TabIndex = 1
        '
        ' frmMainMenu
        '
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(245, 247, 244)
        ClientSize = New Size(1280, 760)
        Controls.Add(tlpRoot)
        MinimumSize = New Size(1000, 600)
        Name = "frmMainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lyceum of Alabang - Registrar Document Request System"
        WindowState = FormWindowState.Maximized
        tlpRoot.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        pnlNav.ResumeLayout(False)
        pnlBottom.ResumeLayout(False)
        pnlBrand.ResumeLayout(False)
        tlpBrand.ResumeLayout(False)
        CType(pbSchoolLogo, System.ComponentModel.ISupportInitialize).EndInit()
        tlpBrandText.ResumeLayout(False)
        tlpBrandText.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        tlpHeader.ResumeLayout(False)
        tlpHeader.PerformLayout()
        flpTitle.ResumeLayout(False)
        flpTitle.PerformLayout()
        tlpDateTime.ResumeLayout(False)
        tlpDateTime.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ttNav As ToolTip
    Friend WithEvents tlpRoot As TableLayoutPanel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlNav As Panel
    Friend WithEvents btnDashboard As NavButton
    Friend WithEvents btnStudentManagement As NavButton
    Friend WithEvents btnDocumentManagement As NavButton
    Friend WithEvents btnDocumentRequests As NavButton
    Friend WithEvents btnReports As NavButton
    Friend WithEvents btnUserManagement As NavButton
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents btnLogout As NavButton
    Friend WithEvents pnlBottomLine As Panel
    Friend WithEvents pnlBrand As Panel
    Friend WithEvents tlpBrand As TableLayoutPanel
    Friend WithEvents pbSchoolLogo As PictureBox
    Friend WithEvents tlpBrandText As TableLayoutPanel
    Friend WithEvents lblRegistrar As Label
    Friend WithEvents lblDocumentRequestSystem As Label
    Friend WithEvents pnlBrandLine As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents tlpHeader As TableLayoutPanel
    Friend WithEvents flpTitle As FlowLayoutPanel
    Friend WithEvents lblSection As Label
    Friend WithEvents pnlTitleAccent As Panel
    Friend WithEvents lblUserProfile As Label
    Friend WithEvents tlpDateTime As TableLayoutPanel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblCalendarIcon As Label
    Friend WithEvents pnlHeaderLine As Panel
End Class
