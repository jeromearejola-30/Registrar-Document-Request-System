<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblUserProfile = New Label()
        btnReports = New Button()
        btnDocumentRequests = New Button()
        btnDocumentManagement = New Button()
        btnLogout = New Button()
        btnUserManagement = New Button()
        btnStudentManagement = New Button()
        flpNavigation = New FlowLayoutPanel()
        Panel2 = New Panel()
        btnDashboard = New Button()
        pbDashboard = New PictureBox()
        pnlStudentManagement = New Panel()
        pbStudentManagement = New PictureBox()
        pnlDocumentManagement = New Panel()
        pbDocumentManagement = New PictureBox()
        pnlDocumentRequests = New Panel()
        pbDocumentRequests = New PictureBox()
        pnlReports = New Panel()
        pbReports = New PictureBox()
        pnlUserManagement = New Panel()
        pbUserManagement = New PictureBox()
        pnlLogout = New Panel()
        pbLogout = New PictureBox()
        pnlTitle = New Panel()
        fplSystemTitle = New FlowLayoutPanel()
        lblSystemTitle1 = New Label()
        lblSystemTitle2 = New Label()
        pbSchoolLogo = New PictureBox()
        pnlSidebar = New Panel()
        pnlSidebarNav = New Panel()
        pnlBottomSidebar = New Panel()
        pnlWorkSpace = New Panel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        fplTitle = New FlowLayoutPanel()
        lblDashboard = New Label()
        pbCelendar = New PictureBox()
        fplDateTime = New FlowLayoutPanel()
        lblDate = New Label()
        lblTime = New Label()
        pnlContentArea = New Panel()
        flpNavigation.SuspendLayout()
        Panel2.SuspendLayout()
        CType(pbDashboard, ComponentModel.ISupportInitialize).BeginInit()
        pnlStudentManagement.SuspendLayout()
        CType(pbStudentManagement, ComponentModel.ISupportInitialize).BeginInit()
        pnlDocumentManagement.SuspendLayout()
        CType(pbDocumentManagement, ComponentModel.ISupportInitialize).BeginInit()
        pnlDocumentRequests.SuspendLayout()
        CType(pbDocumentRequests, ComponentModel.ISupportInitialize).BeginInit()
        pnlReports.SuspendLayout()
        CType(pbReports, ComponentModel.ISupportInitialize).BeginInit()
        pnlUserManagement.SuspendLayout()
        CType(pbUserManagement, ComponentModel.ISupportInitialize).BeginInit()
        pnlLogout.SuspendLayout()
        CType(pbLogout, ComponentModel.ISupportInitialize).BeginInit()
        pnlTitle.SuspendLayout()
        fplSystemTitle.SuspendLayout()
        CType(pbSchoolLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlSidebar.SuspendLayout()
        pnlSidebarNav.SuspendLayout()
        pnlWorkSpace.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        fplTitle.SuspendLayout()
        CType(pbCelendar, ComponentModel.ISupportInitialize).BeginInit()
        fplDateTime.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblUserProfile
        ' 
        lblUserProfile.AutoSize = True
        lblUserProfile.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUserProfile.Location = New Point(3, 45)
        lblUserProfile.Name = "lblUserProfile"
        lblUserProfile.Size = New Size(179, 14)
        lblUserProfile.TabIndex = 0
        lblUserProfile.Text = "Welcome, Username - UserRole"
        lblUserProfile.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnReports
        ' 
        btnReports.Font = New Font("Tahoma", 14.25F)
        btnReports.Location = New Point(58, 3)
        btnReports.Margin = New Padding(3, 2, 3, 2)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(269, 50)
        btnReports.TabIndex = 6
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentRequests
        ' 
        btnDocumentRequests.Font = New Font("Tahoma", 14.25F)
        btnDocumentRequests.Location = New Point(58, 4)
        btnDocumentRequests.Margin = New Padding(3, 2, 3, 2)
        btnDocumentRequests.Name = "btnDocumentRequests"
        btnDocumentRequests.Size = New Size(269, 50)
        btnDocumentRequests.TabIndex = 5
        btnDocumentRequests.Text = "Document Requests"
        btnDocumentRequests.TextAlign = ContentAlignment.MiddleLeft
        btnDocumentRequests.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentManagement
        ' 
        btnDocumentManagement.Font = New Font("Tahoma", 14.25F)
        btnDocumentManagement.Location = New Point(58, 4)
        btnDocumentManagement.Margin = New Padding(3, 2, 3, 2)
        btnDocumentManagement.Name = "btnDocumentManagement"
        btnDocumentManagement.Size = New Size(269, 50)
        btnDocumentManagement.TabIndex = 4
        btnDocumentManagement.Text = "Document Management"
        btnDocumentManagement.TextAlign = ContentAlignment.MiddleLeft
        btnDocumentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Tahoma", 14.25F)
        btnLogout.Location = New Point(58, 3)
        btnLogout.Margin = New Padding(3, 2, 3, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(269, 50)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnUserManagement
        ' 
        btnUserManagement.Font = New Font("Tahoma", 14.25F)
        btnUserManagement.Location = New Point(58, 4)
        btnUserManagement.Margin = New Padding(3, 2, 3, 2)
        btnUserManagement.Name = "btnUserManagement"
        btnUserManagement.Size = New Size(269, 50)
        btnUserManagement.TabIndex = 2
        btnUserManagement.Text = "User Management"
        btnUserManagement.TextAlign = ContentAlignment.MiddleLeft
        btnUserManagement.UseVisualStyleBackColor = True
        ' 
        ' btnStudentManagement
        ' 
        btnStudentManagement.Font = New Font("Tahoma", 14.25F)
        btnStudentManagement.Location = New Point(58, 4)
        btnStudentManagement.Margin = New Padding(3, 2, 3, 2)
        btnStudentManagement.Name = "btnStudentManagement"
        btnStudentManagement.Size = New Size(269, 50)
        btnStudentManagement.TabIndex = 1
        btnStudentManagement.Text = "Student Management"
        btnStudentManagement.TextAlign = ContentAlignment.MiddleLeft
        btnStudentManagement.UseVisualStyleBackColor = True
        ' 
        ' flpNavigation
        ' 
        flpNavigation.Controls.Add(Panel2)
        flpNavigation.Controls.Add(pnlStudentManagement)
        flpNavigation.Controls.Add(pnlDocumentManagement)
        flpNavigation.Controls.Add(pnlDocumentRequests)
        flpNavigation.Controls.Add(pnlReports)
        flpNavigation.Controls.Add(pnlUserManagement)
        flpNavigation.Controls.Add(pnlLogout)
        flpNavigation.Dock = DockStyle.Left
        flpNavigation.FlowDirection = FlowDirection.TopDown
        flpNavigation.Location = New Point(0, 0)
        flpNavigation.Name = "flpNavigation"
        flpNavigation.Size = New Size(339, 598)
        flpNavigation.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnDashboard)
        Panel2.Controls.Add(pbDashboard)
        Panel2.Location = New Point(3, 80)
        Panel2.Margin = New Padding(3, 80, 3, 15)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(331, 57)
        Panel2.TabIndex = 2
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.Font = New Font("Tahoma", 14.25F)
        btnDashboard.Location = New Point(58, 4)
        btnDashboard.Margin = New Padding(3, 2, 3, 2)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(269, 50)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' pbDashboard
        ' 
        pbDashboard.BackColor = Color.Transparent
        pbDashboard.Location = New Point(3, 4)
        pbDashboard.Name = "pbDashboard"
        pbDashboard.Size = New Size(50, 50)
        pbDashboard.TabIndex = 10
        pbDashboard.TabStop = False
        ' 
        ' pnlStudentManagement
        ' 
        pnlStudentManagement.Controls.Add(pbStudentManagement)
        pnlStudentManagement.Controls.Add(btnStudentManagement)
        pnlStudentManagement.Location = New Point(3, 155)
        pnlStudentManagement.Margin = New Padding(3, 3, 3, 15)
        pnlStudentManagement.Name = "pnlStudentManagement"
        pnlStudentManagement.Size = New Size(331, 57)
        pnlStudentManagement.TabIndex = 15
        ' 
        ' pbStudentManagement
        ' 
        pbStudentManagement.BackColor = Color.Transparent
        pbStudentManagement.Location = New Point(3, 4)
        pbStudentManagement.Name = "pbStudentManagement"
        pbStudentManagement.Size = New Size(50, 50)
        pbStudentManagement.TabIndex = 9
        pbStudentManagement.TabStop = False
        ' 
        ' pnlDocumentManagement
        ' 
        pnlDocumentManagement.Controls.Add(pbDocumentManagement)
        pnlDocumentManagement.Controls.Add(btnDocumentManagement)
        pnlDocumentManagement.Location = New Point(3, 230)
        pnlDocumentManagement.Margin = New Padding(3, 3, 3, 15)
        pnlDocumentManagement.Name = "pnlDocumentManagement"
        pnlDocumentManagement.Size = New Size(331, 57)
        pnlDocumentManagement.TabIndex = 16
        ' 
        ' pbDocumentManagement
        ' 
        pbDocumentManagement.BackColor = Color.Transparent
        pbDocumentManagement.Location = New Point(3, 4)
        pbDocumentManagement.Name = "pbDocumentManagement"
        pbDocumentManagement.Size = New Size(50, 50)
        pbDocumentManagement.TabIndex = 10
        pbDocumentManagement.TabStop = False
        ' 
        ' pnlDocumentRequests
        ' 
        pnlDocumentRequests.Controls.Add(pbDocumentRequests)
        pnlDocumentRequests.Controls.Add(btnDocumentRequests)
        pnlDocumentRequests.Location = New Point(3, 305)
        pnlDocumentRequests.Margin = New Padding(3, 3, 3, 15)
        pnlDocumentRequests.Name = "pnlDocumentRequests"
        pnlDocumentRequests.Size = New Size(331, 57)
        pnlDocumentRequests.TabIndex = 17
        ' 
        ' pbDocumentRequests
        ' 
        pbDocumentRequests.BackColor = Color.Transparent
        pbDocumentRequests.Location = New Point(3, 4)
        pbDocumentRequests.Name = "pbDocumentRequests"
        pbDocumentRequests.Size = New Size(50, 50)
        pbDocumentRequests.TabIndex = 11
        pbDocumentRequests.TabStop = False
        ' 
        ' pnlReports
        ' 
        pnlReports.Controls.Add(pbReports)
        pnlReports.Controls.Add(btnReports)
        pnlReports.Location = New Point(3, 380)
        pnlReports.Margin = New Padding(3, 3, 3, 15)
        pnlReports.Name = "pnlReports"
        pnlReports.Size = New Size(331, 57)
        pnlReports.TabIndex = 18
        ' 
        ' pbReports
        ' 
        pbReports.BackColor = Color.Transparent
        pbReports.Location = New Point(3, 3)
        pbReports.Name = "pbReports"
        pbReports.Size = New Size(50, 50)
        pbReports.TabIndex = 12
        pbReports.TabStop = False
        ' 
        ' pnlUserManagement
        ' 
        pnlUserManagement.Controls.Add(pbUserManagement)
        pnlUserManagement.Controls.Add(btnUserManagement)
        pnlUserManagement.Location = New Point(3, 455)
        pnlUserManagement.Margin = New Padding(3, 3, 3, 15)
        pnlUserManagement.Name = "pnlUserManagement"
        pnlUserManagement.Size = New Size(331, 57)
        pnlUserManagement.TabIndex = 18
        ' 
        ' pbUserManagement
        ' 
        pbUserManagement.BackColor = Color.Transparent
        pbUserManagement.Location = New Point(3, 4)
        pbUserManagement.Name = "pbUserManagement"
        pbUserManagement.Size = New Size(50, 50)
        pbUserManagement.TabIndex = 13
        pbUserManagement.TabStop = False
        ' 
        ' pnlLogout
        ' 
        pnlLogout.Controls.Add(btnLogout)
        pnlLogout.Controls.Add(pbLogout)
        pnlLogout.Location = New Point(3, 530)
        pnlLogout.Name = "pnlLogout"
        pnlLogout.Size = New Size(331, 57)
        pnlLogout.TabIndex = 18
        ' 
        ' pbLogout
        ' 
        pbLogout.BackColor = Color.Transparent
        pbLogout.Location = New Point(3, 3)
        pbLogout.Name = "pbLogout"
        pbLogout.Size = New Size(50, 50)
        pbLogout.TabIndex = 14
        pbLogout.TabStop = False
        ' 
        ' pnlTitle
        ' 
        pnlTitle.Controls.Add(fplSystemTitle)
        pnlTitle.Controls.Add(pbSchoolLogo)
        pnlTitle.Dock = DockStyle.Top
        pnlTitle.Location = New Point(0, 0)
        pnlTitle.Name = "pnlTitle"
        pnlTitle.Size = New Size(1264, 100)
        pnlTitle.TabIndex = 8
        ' 
        ' fplSystemTitle
        ' 
        fplSystemTitle.Controls.Add(lblSystemTitle1)
        fplSystemTitle.Controls.Add(lblSystemTitle2)
        fplSystemTitle.Location = New Point(88, 12)
        fplSystemTitle.Name = "fplSystemTitle"
        fplSystemTitle.Size = New Size(242, 70)
        fplSystemTitle.TabIndex = 1
        ' 
        ' lblSystemTitle1
        ' 
        lblSystemTitle1.AutoSize = True
        lblSystemTitle1.Font = New Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSystemTitle1.Location = New Point(3, 0)
        lblSystemTitle1.Name = "lblSystemTitle1"
        lblSystemTitle1.Size = New Size(122, 33)
        lblSystemTitle1.TabIndex = 9
        lblSystemTitle1.Text = "Registrar"
        lblSystemTitle1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSystemTitle2
        ' 
        lblSystemTitle2.AutoSize = True
        lblSystemTitle2.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSystemTitle2.Location = New Point(3, 33)
        lblSystemTitle2.Name = "lblSystemTitle2"
        lblSystemTitle2.Size = New Size(236, 23)
        lblSystemTitle2.TabIndex = 10
        lblSystemTitle2.Text = "Document Request System"
        lblSystemTitle2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pbSchoolLogo
        ' 
        pbSchoolLogo.BackColor = Color.Transparent
        pbSchoolLogo.Location = New Point(12, 12)
        pbSchoolLogo.Name = "pbSchoolLogo"
        pbSchoolLogo.Size = New Size(70, 70)
        pbSchoolLogo.TabIndex = 9
        pbSchoolLogo.TabStop = False
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.Controls.Add(pnlSidebarNav)
        pnlSidebar.Controls.Add(pnlTitle)
        pnlSidebar.Controls.Add(pnlBottomSidebar)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(1264, 761)
        pnlSidebar.TabIndex = 8
        ' 
        ' pnlSidebarNav
        ' 
        pnlSidebarNav.Controls.Add(flpNavigation)
        pnlSidebarNav.Dock = DockStyle.Fill
        pnlSidebarNav.Location = New Point(0, 100)
        pnlSidebarNav.Name = "pnlSidebarNav"
        pnlSidebarNav.Size = New Size(1264, 598)
        pnlSidebarNav.TabIndex = 9
        ' 
        ' pnlBottomSidebar
        ' 
        pnlBottomSidebar.Dock = DockStyle.Bottom
        pnlBottomSidebar.Location = New Point(0, 698)
        pnlBottomSidebar.Name = "pnlBottomSidebar"
        pnlBottomSidebar.Size = New Size(1264, 63)
        pnlBottomSidebar.TabIndex = 9
        ' 
        ' pnlWorkSpace
        ' 
        pnlWorkSpace.Controls.Add(FlowLayoutPanel2)
        pnlWorkSpace.Controls.Add(pnlContentArea)
        pnlWorkSpace.Dock = DockStyle.Right
        pnlWorkSpace.Location = New Point(337, 0)
        pnlWorkSpace.Name = "pnlWorkSpace"
        pnlWorkSpace.Size = New Size(927, 761)
        pnlWorkSpace.TabIndex = 9
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(fplTitle)
        FlowLayoutPanel2.Controls.Add(pbCelendar)
        FlowLayoutPanel2.Controls.Add(fplDateTime)
        FlowLayoutPanel2.Dock = DockStyle.Top
        FlowLayoutPanel2.Location = New Point(0, 0)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(927, 100)
        FlowLayoutPanel2.TabIndex = 2
        ' 
        ' fplTitle
        ' 
        fplTitle.Controls.Add(lblDashboard)
        fplTitle.Controls.Add(lblUserProfile)
        fplTitle.FlowDirection = FlowDirection.TopDown
        fplTitle.Location = New Point(20, 15)
        fplTitle.Margin = New Padding(20, 15, 3, 3)
        fplTitle.Name = "fplTitle"
        fplTitle.Size = New Size(216, 70)
        fplTitle.TabIndex = 1
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDashboard.Location = New Point(3, 0)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(194, 45)
        lblDashboard.TabIndex = 1
        lblDashboard.Text = "Dashboard"
        lblDashboard.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pbCelendar
        ' 
        pbCelendar.BackColor = Color.Transparent
        pbCelendar.Location = New Point(539, 15)
        pbCelendar.Margin = New Padding(300, 15, 3, 3)
        pbCelendar.Name = "pbCelendar"
        pbCelendar.Size = New Size(70, 70)
        pbCelendar.TabIndex = 10
        pbCelendar.TabStop = False
        ' 
        ' fplDateTime
        ' 
        fplDateTime.Controls.Add(lblDate)
        fplDateTime.Controls.Add(lblTime)
        fplDateTime.FlowDirection = FlowDirection.TopDown
        fplDateTime.Location = New Point(615, 15)
        fplDateTime.Margin = New Padding(3, 15, 3, 3)
        fplDateTime.Name = "fplDateTime"
        fplDateTime.Size = New Size(304, 70)
        fplDateTime.TabIndex = 11
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(3, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(293, 25)
        lblDate.TabIndex = 2
        lblDate.Text = "September Thursday, 31 2026"
        lblDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(3, 25)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(98, 25)
        lblTime.TabIndex = 3
        lblTime.Text = "09:41 PM"
        lblTime.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlContentArea
        ' 
        pnlContentArea.Dock = DockStyle.Bottom
        pnlContentArea.Location = New Point(0, 100)
        pnlContentArea.Name = "pnlContentArea"
        pnlContentArea.Size = New Size(927, 661)
        pnlContentArea.TabIndex = 1
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 761)
        Controls.Add(pnlWorkSpace)
        Controls.Add(pnlSidebar)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1280, 800)
        Name = "frmMainMenu"
        Text = "frmMainMenu"
        flpNavigation.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(pbDashboard, ComponentModel.ISupportInitialize).EndInit()
        pnlStudentManagement.ResumeLayout(False)
        CType(pbStudentManagement, ComponentModel.ISupportInitialize).EndInit()
        pnlDocumentManagement.ResumeLayout(False)
        CType(pbDocumentManagement, ComponentModel.ISupportInitialize).EndInit()
        pnlDocumentRequests.ResumeLayout(False)
        CType(pbDocumentRequests, ComponentModel.ISupportInitialize).EndInit()
        pnlReports.ResumeLayout(False)
        CType(pbReports, ComponentModel.ISupportInitialize).EndInit()
        pnlUserManagement.ResumeLayout(False)
        CType(pbUserManagement, ComponentModel.ISupportInitialize).EndInit()
        pnlLogout.ResumeLayout(False)
        CType(pbLogout, ComponentModel.ISupportInitialize).EndInit()
        pnlTitle.ResumeLayout(False)
        fplSystemTitle.ResumeLayout(False)
        fplSystemTitle.PerformLayout()
        CType(pbSchoolLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlSidebar.ResumeLayout(False)
        pnlSidebarNav.ResumeLayout(False)
        pnlWorkSpace.ResumeLayout(False)
        FlowLayoutPanel2.ResumeLayout(False)
        fplTitle.ResumeLayout(False)
        fplTitle.PerformLayout()
        CType(pbCelendar, ComponentModel.ISupportInitialize).EndInit()
        fplDateTime.ResumeLayout(False)
        fplDateTime.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnUserManagement As Button
    Friend WithEvents btnStudentManagement As Button
    Friend WithEvents lblUserProfile As Label
    Friend WithEvents btnReports As Button
    Friend WithEvents btnDocumentRequests As Button
    Friend WithEvents btnDocumentManagement As Button
    Friend WithEvents flpNavigation As FlowLayoutPanel
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblSystemTitle1 As Label
    Friend WithEvents pbSchoolLogo As PictureBox
    Friend WithEvents lblSystemTitle2 As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlBottomSidebar As Panel
    Friend WithEvents pnlSidebarNav As Panel
    Friend WithEvents pbStudentManagement As PictureBox
    Friend WithEvents pbDocumentManagement As PictureBox
    Friend WithEvents pbDocumentRequests As PictureBox
    Friend WithEvents pbReports As PictureBox
    Friend WithEvents pbUserManagement As PictureBox
    Friend WithEvents pbLogout As PictureBox
    Friend WithEvents pnlStudentManagement As Panel
    Friend WithEvents pnlDocumentManagement As Panel
    Friend WithEvents pnlDocumentRequests As Panel
    Friend WithEvents pnlReports As Panel
    Friend WithEvents pnlUserManagement As Panel
    Friend WithEvents pnlLogout As Panel
    Friend WithEvents pnlWorkSpace As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pbDashboard As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents pbCelendar As PictureBox
    Friend WithEvents fplDateTime As FlowLayoutPanel
    Friend WithEvents fplSystemTitle As FlowLayoutPanel
    Friend WithEvents fplTitle As FlowLayoutPanel
    Friend WithEvents pnlContentArea As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
End Class
