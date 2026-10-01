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
        flpSideBar = New FlowLayoutPanel()
        btnDashboard = New Button()
        lblSystemTitle1 = New Label()
        lblSystemTitle2 = New Label()
        pbSchoolLogo = New PictureBox()
        fplHead = New FlowLayoutPanel()
        fplSystemTitle = New FlowLayoutPanel()
        fplSystemLabel = New FlowLayoutPanel()
        lblRegistrar = New Label()
        lblDocumentRequestSystem = New Label()
        fplTitle = New FlowLayoutPanel()
        lblSection = New Label()
        pbCelendar = New PictureBox()
        fplDateTime = New FlowLayoutPanel()
        lblDate = New Label()
        lblTime = New Label()
        pnlContentArea = New Panel()
        flpSideBar.SuspendLayout()
        CType(pbSchoolLogo, ComponentModel.ISupportInitialize).BeginInit()
        fplHead.SuspendLayout()
        fplSystemTitle.SuspendLayout()
        fplSystemLabel.SuspendLayout()
        fplTitle.SuspendLayout()
        CType(pbCelendar, ComponentModel.ISupportInitialize).BeginInit()
        fplDateTime.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblUserProfile
        ' 
        lblUserProfile.AutoSize = True
        lblUserProfile.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUserProfile.Location = New Point(11, 50)
        lblUserProfile.Margin = New Padding(11, 0, 3, 0)
        lblUserProfile.Name = "lblUserProfile"
        lblUserProfile.Size = New Size(179, 14)
        lblUserProfile.TabIndex = 0
        lblUserProfile.Text = "Welcome, Username - UserRole"
        lblUserProfile.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnReports
        ' 
        btnReports.Font = New Font("Tahoma", 14.25F)
        btnReports.Location = New Point(15, 352)
        btnReports.Margin = New Padding(15, 3, 3, 15)
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(50, 0, 0, 0)
        btnReports.Size = New Size(310, 50)
        btnReports.TabIndex = 6
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentRequests
        ' 
        btnDocumentRequests.Font = New Font("Tahoma", 14.25F)
        btnDocumentRequests.Location = New Point(15, 284)
        btnDocumentRequests.Margin = New Padding(15, 3, 3, 15)
        btnDocumentRequests.Name = "btnDocumentRequests"
        btnDocumentRequests.Padding = New Padding(50, 0, 0, 0)
        btnDocumentRequests.Size = New Size(310, 50)
        btnDocumentRequests.TabIndex = 5
        btnDocumentRequests.Text = "Document Requests"
        btnDocumentRequests.TextAlign = ContentAlignment.MiddleLeft
        btnDocumentRequests.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentManagement
        ' 
        btnDocumentManagement.Font = New Font("Tahoma", 14.25F)
        btnDocumentManagement.Location = New Point(15, 216)
        btnDocumentManagement.Margin = New Padding(15, 3, 3, 15)
        btnDocumentManagement.Name = "btnDocumentManagement"
        btnDocumentManagement.Padding = New Padding(50, 0, 0, 0)
        btnDocumentManagement.Size = New Size(310, 50)
        btnDocumentManagement.TabIndex = 4
        btnDocumentManagement.Text = "Document Management"
        btnDocumentManagement.TextAlign = ContentAlignment.MiddleLeft
        btnDocumentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Tahoma", 14.25F)
        btnLogout.Location = New Point(15, 585)
        btnLogout.Margin = New Padding(15, 100, 3, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(50, 0, 0, 0)
        btnLogout.Size = New Size(310, 50)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnUserManagement
        ' 
        btnUserManagement.Font = New Font("Tahoma", 14.25F)
        btnUserManagement.Location = New Point(15, 420)
        btnUserManagement.Margin = New Padding(15, 3, 3, 15)
        btnUserManagement.Name = "btnUserManagement"
        btnUserManagement.Padding = New Padding(50, 0, 0, 0)
        btnUserManagement.Size = New Size(310, 50)
        btnUserManagement.TabIndex = 2
        btnUserManagement.Text = "User Management"
        btnUserManagement.TextAlign = ContentAlignment.MiddleLeft
        btnUserManagement.UseVisualStyleBackColor = True
        ' 
        ' btnStudentManagement
        ' 
        btnStudentManagement.Font = New Font("Tahoma", 14.25F)
        btnStudentManagement.Location = New Point(15, 148)
        btnStudentManagement.Margin = New Padding(15, 3, 3, 15)
        btnStudentManagement.Name = "btnStudentManagement"
        btnStudentManagement.Padding = New Padding(50, 0, 0, 0)
        btnStudentManagement.Size = New Size(310, 50)
        btnStudentManagement.TabIndex = 1
        btnStudentManagement.Text = "Student Management"
        btnStudentManagement.TextAlign = ContentAlignment.MiddleLeft
        btnStudentManagement.UseVisualStyleBackColor = True
        ' 
        ' flpSideBar
        ' 
        flpSideBar.Controls.Add(btnDashboard)
        flpSideBar.Controls.Add(btnStudentManagement)
        flpSideBar.Controls.Add(btnDocumentManagement)
        flpSideBar.Controls.Add(btnDocumentRequests)
        flpSideBar.Controls.Add(btnReports)
        flpSideBar.Controls.Add(btnUserManagement)
        flpSideBar.Controls.Add(btnLogout)
        flpSideBar.Dock = DockStyle.Left
        flpSideBar.FlowDirection = FlowDirection.TopDown
        flpSideBar.Location = New Point(0, 100)
        flpSideBar.Margin = New Padding(0, 3, 3, 3)
        flpSideBar.Name = "flpSideBar"
        flpSideBar.Size = New Size(342, 661)
        flpSideBar.TabIndex = 7
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.Font = New Font("Tahoma", 14.25F)
        btnDashboard.Location = New Point(15, 80)
        btnDashboard.Margin = New Padding(15, 80, 3, 15)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(50, 0, 0, 0)
        btnDashboard.Size = New Size(310, 50)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' lblSystemTitle1
        ' 
        lblSystemTitle1.AutoSize = True
        lblSystemTitle1.Font = New Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSystemTitle1.Location = New Point(3, 6)
        lblSystemTitle1.Margin = New Padding(3, 6, 3, 0)
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
        lblSystemTitle2.Location = New Point(3, 39)
        lblSystemTitle2.Name = "lblSystemTitle2"
        lblSystemTitle2.Size = New Size(236, 23)
        lblSystemTitle2.TabIndex = 10
        lblSystemTitle2.Text = "Document Request System"
        lblSystemTitle2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pbSchoolLogo
        ' 
        pbSchoolLogo.BackColor = Color.Transparent
        pbSchoolLogo.Location = New Point(13, 15)
        pbSchoolLogo.Margin = New Padding(13, 15, 3, 3)
        pbSchoolLogo.Name = "pbSchoolLogo"
        pbSchoolLogo.Size = New Size(70, 70)
        pbSchoolLogo.TabIndex = 9
        pbSchoolLogo.TabStop = False
        ' 
        ' fplHead
        ' 
        fplHead.Controls.Add(fplSystemTitle)
        fplHead.Controls.Add(fplTitle)
        fplHead.Controls.Add(pbCelendar)
        fplHead.Controls.Add(fplDateTime)
        fplHead.Dock = DockStyle.Top
        fplHead.Location = New Point(0, 0)
        fplHead.Name = "fplHead"
        fplHead.Size = New Size(1264, 100)
        fplHead.TabIndex = 2
        ' 
        ' fplSystemTitle
        ' 
        fplSystemTitle.Controls.Add(pbSchoolLogo)
        fplSystemTitle.Controls.Add(fplSystemLabel)
        fplSystemTitle.Location = New Point(0, 0)
        fplSystemTitle.Margin = New Padding(0, 0, 3, 0)
        fplSystemTitle.Name = "fplSystemTitle"
        fplSystemTitle.Size = New Size(342, 100)
        fplSystemTitle.TabIndex = 10
        ' 
        ' fplSystemLabel
        ' 
        fplSystemLabel.Controls.Add(lblRegistrar)
        fplSystemLabel.Controls.Add(lblDocumentRequestSystem)
        fplSystemLabel.FlowDirection = FlowDirection.TopDown
        fplSystemLabel.Location = New Point(91, 15)
        fplSystemLabel.Margin = New Padding(5, 15, 3, 3)
        fplSystemLabel.Name = "fplSystemLabel"
        fplSystemLabel.Size = New Size(234, 70)
        fplSystemLabel.TabIndex = 9
        ' 
        ' lblRegistrar
        ' 
        lblRegistrar.AutoSize = True
        lblRegistrar.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRegistrar.Location = New Point(3, 10)
        lblRegistrar.Margin = New Padding(3, 10, 3, 0)
        lblRegistrar.Name = "lblRegistrar"
        lblRegistrar.Size = New Size(109, 29)
        lblRegistrar.TabIndex = 9
        lblRegistrar.Text = "Registrar"
        ' 
        ' lblDocumentRequestSystem
        ' 
        lblDocumentRequestSystem.AutoSize = True
        lblDocumentRequestSystem.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDocumentRequestSystem.Location = New Point(6, 39)
        lblDocumentRequestSystem.Margin = New Padding(6, 0, 3, 0)
        lblDocumentRequestSystem.Name = "lblDocumentRequestSystem"
        lblDocumentRequestSystem.Size = New Size(206, 18)
        lblDocumentRequestSystem.TabIndex = 10
        lblDocumentRequestSystem.Text = "Document Request System"
        ' 
        ' fplTitle
        ' 
        fplTitle.Controls.Add(lblSection)
        fplTitle.Controls.Add(lblUserProfile)
        fplTitle.FlowDirection = FlowDirection.TopDown
        fplTitle.Location = New Point(365, 15)
        fplTitle.Margin = New Padding(20, 15, 3, 3)
        fplTitle.Name = "fplTitle"
        fplTitle.Size = New Size(478, 70)
        fplTitle.TabIndex = 1
        ' 
        ' lblSection
        ' 
        lblSection.AutoSize = True
        lblSection.Font = New Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSection.Location = New Point(3, 5)
        lblSection.Margin = New Padding(3, 5, 3, 0)
        lblSection.Name = "lblSection"
        lblSection.Size = New Size(194, 45)
        lblSection.TabIndex = 1
        lblSection.Text = "Dashboard"
        lblSection.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pbCelendar
        ' 
        pbCelendar.BackColor = Color.Transparent
        pbCelendar.Location = New Point(881, 20)
        pbCelendar.Margin = New Padding(35, 20, 3, 3)
        pbCelendar.Name = "pbCelendar"
        pbCelendar.Size = New Size(60, 60)
        pbCelendar.TabIndex = 10
        pbCelendar.TabStop = False
        ' 
        ' fplDateTime
        ' 
        fplDateTime.Controls.Add(lblDate)
        fplDateTime.Controls.Add(lblTime)
        fplDateTime.FlowDirection = FlowDirection.TopDown
        fplDateTime.Location = New Point(947, 20)
        fplDateTime.Margin = New Padding(3, 20, 10, 3)
        fplDateTime.Name = "fplDateTime"
        fplDateTime.Size = New Size(304, 60)
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
        pnlContentArea.Dock = DockStyle.Fill
        pnlContentArea.Location = New Point(342, 100)
        pnlContentArea.Margin = New Padding(0, 3, 0, 3)
        pnlContentArea.Name = "pnlContentArea"
        pnlContentArea.RightToLeft = RightToLeft.No
        pnlContentArea.Size = New Size(922, 661)
        pnlContentArea.TabIndex = 1
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 761)
        Controls.Add(pnlContentArea)
        Controls.Add(flpSideBar)
        Controls.Add(fplHead)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1280, 800)
        Name = "frmMainMenu"
        Text = "Main menu"
        flpSideBar.ResumeLayout(False)
        CType(pbSchoolLogo, ComponentModel.ISupportInitialize).EndInit()
        fplHead.ResumeLayout(False)
        fplSystemTitle.ResumeLayout(False)
        fplSystemLabel.ResumeLayout(False)
        fplSystemLabel.PerformLayout()
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
    Friend WithEvents flpSideBar As FlowLayoutPanel
    Friend WithEvents lblSystemTitle1 As Label
    Friend WithEvents pbSchoolLogo As PictureBox
    Friend WithEvents lblSystemTitle2 As Label
    Friend WithEvents lblSection As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents pbCelendar As PictureBox
    Friend WithEvents fplDateTime As FlowLayoutPanel
    Friend WithEvents fplTitle As FlowLayoutPanel
    Friend WithEvents pnlContentArea As Panel
    Friend WithEvents fplHead As FlowLayoutPanel
    Friend WithEvents fplSystemTitle As FlowLayoutPanel
    Friend WithEvents fplSystemLabel As FlowLayoutPanel
    Friend WithEvents lblRegistrar As Label
    Friend WithEvents lblDocumentRequestSystem As Label
End Class
