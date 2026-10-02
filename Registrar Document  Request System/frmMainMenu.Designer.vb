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
        btnDashboard = New Button()
        lblSystemTitle1 = New Label()
        lblSystemTitle2 = New Label()
        pbSchoolLogo = New PictureBox()
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
        TableLayoutPanel1 = New TableLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        tlpContentArea = New TableLayoutPanel()
        CType(pbSchoolLogo, ComponentModel.ISupportInitialize).BeginInit()
        fplSystemTitle.SuspendLayout()
        fplSystemLabel.SuspendLayout()
        fplTitle.SuspendLayout()
        CType(pbCelendar, ComponentModel.ISupportInitialize).BeginInit()
        fplDateTime.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
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
        btnReports.Location = New Point(15, 340)
        btnReports.Margin = New Padding(15, 20, 3, 3)
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
        btnDocumentRequests.Location = New Point(15, 267)
        btnDocumentRequests.Margin = New Padding(15, 20, 3, 3)
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
        btnDocumentManagement.Location = New Point(15, 194)
        btnDocumentManagement.Margin = New Padding(15, 20, 3, 3)
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
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.Font = New Font("Tahoma", 14.25F)
        btnLogout.Location = New Point(15, 704)
        btnLogout.Margin = New Padding(15, 25, 20, 15)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(50, 0, 0, 0)
        btnLogout.Size = New Size(305, 42)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnUserManagement
        ' 
        btnUserManagement.Font = New Font("Tahoma", 14.25F)
        btnUserManagement.Location = New Point(15, 413)
        btnUserManagement.Margin = New Padding(15, 20, 3, 3)
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
        btnStudentManagement.Location = New Point(15, 121)
        btnStudentManagement.Margin = New Padding(15, 20, 3, 3)
        btnStudentManagement.Name = "btnStudentManagement"
        btnStudentManagement.Padding = New Padding(50, 0, 0, 0)
        btnStudentManagement.Size = New Size(310, 50)
        btnStudentManagement.TabIndex = 1
        btnStudentManagement.Text = "Student Management"
        btnStudentManagement.TextAlign = ContentAlignment.MiddleLeft
        btnStudentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.Font = New Font("Tahoma", 14.25F)
        btnDashboard.Location = New Point(15, 50)
        btnDashboard.Margin = New Padding(15, 50, 3, 3)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(50, 0, 0, 0)
        btnDashboard.Size = New Size(310, 48)
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
        ' fplSystemTitle
        ' 
        fplSystemTitle.Controls.Add(pbSchoolLogo)
        fplSystemTitle.Controls.Add(fplSystemLabel)
        fplSystemTitle.Dock = DockStyle.Fill
        fplSystemTitle.Location = New Point(0, 0)
        fplSystemTitle.Margin = New Padding(0, 0, 3, 0)
        fplSystemTitle.Name = "fplSystemTitle"
        fplSystemTitle.Size = New Size(337, 100)
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
        fplTitle.Dock = DockStyle.Left
        fplTitle.FlowDirection = FlowDirection.TopDown
        fplTitle.Location = New Point(15, 15)
        fplTitle.Margin = New Padding(15, 15, 3, 3)
        fplTitle.Name = "fplTitle"
        fplTitle.Size = New Size(436, 82)
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
        pbCelendar.Location = New Point(15, 5)
        pbCelendar.Margin = New Padding(15, 5, 3, 20)
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
        fplDateTime.Location = New Point(81, 5)
        fplDateTime.Margin = New Padding(3, 5, 10, 3)
        fplDateTime.Name = "fplDateTime"
        fplDateTime.Size = New Size(304, 60)
        fplDateTime.TabIndex = 11
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(3, 6)
        lblDate.Margin = New Padding(3, 6, 3, 0)
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
        lblTime.Location = New Point(3, 31)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(98, 25)
        lblTime.TabIndex = 3
        lblTime.Text = "09:41 PM"
        lblTime.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 51.3771172F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 48.6228828F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 1, 0)
        TableLayoutPanel1.Controls.Add(fplTitle, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(340, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(944, 100)
        TableLayoutPanel1.TabIndex = 12
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(pbCelendar)
        FlowLayoutPanel1.Controls.Add(fplDateTime)
        FlowLayoutPanel1.Dock = DockStyle.Right
        FlowLayoutPanel1.Location = New Point(544, 15)
        FlowLayoutPanel1.Margin = New Padding(50, 15, 3, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(397, 82)
        FlowLayoutPanel1.TabIndex = 14
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel2, 0, 1)
        TableLayoutPanel2.Controls.Add(fplSystemTitle, 0, 0)
        TableLayoutPanel2.Controls.Add(btnLogout, 0, 2)
        TableLayoutPanel2.Dock = DockStyle.Left
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 13.140604F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 76.0841F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.7752953F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(340, 761)
        TableLayoutPanel2.TabIndex = 13
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(btnDashboard)
        FlowLayoutPanel2.Controls.Add(btnStudentManagement)
        FlowLayoutPanel2.Controls.Add(btnDocumentManagement)
        FlowLayoutPanel2.Controls.Add(btnDocumentRequests)
        FlowLayoutPanel2.Controls.Add(btnReports)
        FlowLayoutPanel2.Controls.Add(btnUserManagement)
        FlowLayoutPanel2.Dock = DockStyle.Fill
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(3, 103)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(334, 573)
        FlowLayoutPanel2.TabIndex = 15
        ' 
        ' tlpContentArea
        ' 
        tlpContentArea.ColumnCount = 1
        tlpContentArea.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpContentArea.Dock = DockStyle.Fill
        tlpContentArea.Location = New Point(340, 100)
        tlpContentArea.Name = "tlpContentArea"
        tlpContentArea.RowCount = 1
        tlpContentArea.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpContentArea.Size = New Size(944, 661)
        tlpContentArea.TabIndex = 14
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1284, 761)
        Controls.Add(tlpContentArea)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel2)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1280, 800)
        Name = "frmMainMenu"
        Text = "Main menu"
        CType(pbSchoolLogo, ComponentModel.ISupportInitialize).EndInit()
        fplSystemTitle.ResumeLayout(False)
        fplSystemLabel.ResumeLayout(False)
        fplSystemLabel.PerformLayout()
        fplTitle.ResumeLayout(False)
        fplTitle.PerformLayout()
        CType(pbCelendar, ComponentModel.ISupportInitialize).EndInit()
        fplDateTime.ResumeLayout(False)
        fplDateTime.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnUserManagement As Button
    Friend WithEvents btnStudentManagement As Button
    Friend WithEvents lblUserProfile As Label
    Friend WithEvents btnReports As Button
    Friend WithEvents btnDocumentRequests As Button
    Friend WithEvents btnDocumentManagement As Button
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
    Friend WithEvents fplSystemTitle As FlowLayoutPanel
    Friend WithEvents fplSystemLabel As FlowLayoutPanel
    Friend WithEvents lblRegistrar As Label
    Friend WithEvents lblDocumentRequestSystem As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents tlpContentArea As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
End Class
