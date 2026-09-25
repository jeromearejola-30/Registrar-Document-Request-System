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
        pnlSideBar = New Panel()
        btnDashBoard = New Button()
        btnDocumentManagement = New Button()
        btnUserManagement = New Button()
        btnLogout = New Button()
        btnDocumentRequests = New Button()
        btnReports = New Button()
        btnStudentManagement = New Button()
        lblWelcome = New Label()
        pnlContent = New Panel()
        lblTime = New Label()
        lblMonth = New Label()
        lblDate = New Label()
        pnlTimeDateMonth = New Panel()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        pnlTopBar = New Panel()
        pnlWindowLabel = New Panel()
        pnlSideBar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlTimeDateMonth.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlTopBar.SuspendLayout()
        pnlWindowLabel.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSideBar
        ' 
        pnlSideBar.Controls.Add(btnDashBoard)
        pnlSideBar.Controls.Add(btnDocumentManagement)
        pnlSideBar.Controls.Add(btnUserManagement)
        pnlSideBar.Controls.Add(btnLogout)
        pnlSideBar.Controls.Add(btnDocumentRequests)
        pnlSideBar.Controls.Add(btnReports)
        pnlSideBar.Controls.Add(btnStudentManagement)
        pnlSideBar.Dock = DockStyle.Left
        pnlSideBar.Location = New Point(0, 0)
        pnlSideBar.Margin = New Padding(3, 2, 3, 2)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(299, 761)
        pnlSideBar.TabIndex = 0
        ' 
        ' btnDashBoard
        ' 
        btnDashBoard.Font = New Font("Tahoma", 9F)
        btnDashBoard.Location = New Point(24, 410)
        btnDashBoard.Margin = New Padding(3, 2, 3, 2)
        btnDashBoard.Name = "btnDashBoard"
        btnDashBoard.Size = New Size(252, 28)
        btnDashBoard.TabIndex = 8
        btnDashBoard.Text = "Dashboard"
        btnDashBoard.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentManagement
        ' 
        btnDocumentManagement.Font = New Font("Tahoma", 9F)
        btnDocumentManagement.Location = New Point(24, 474)
        btnDocumentManagement.Margin = New Padding(3, 2, 3, 2)
        btnDocumentManagement.Name = "btnDocumentManagement"
        btnDocumentManagement.Size = New Size(252, 28)
        btnDocumentManagement.TabIndex = 4
        btnDocumentManagement.Text = "Document Management"
        btnDocumentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnUserManagement
        ' 
        btnUserManagement.Font = New Font("Tahoma", 9F)
        btnUserManagement.Location = New Point(24, 570)
        btnUserManagement.Margin = New Padding(3, 2, 3, 2)
        btnUserManagement.Name = "btnUserManagement"
        btnUserManagement.Size = New Size(252, 28)
        btnUserManagement.TabIndex = 2
        btnUserManagement.Text = "User Management"
        btnUserManagement.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Tahoma", 9F)
        btnLogout.Location = New Point(24, 602)
        btnLogout.Margin = New Padding(3, 2, 3, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(252, 28)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentRequests
        ' 
        btnDocumentRequests.Font = New Font("Tahoma", 9F)
        btnDocumentRequests.Location = New Point(24, 506)
        btnDocumentRequests.Margin = New Padding(3, 2, 3, 2)
        btnDocumentRequests.Name = "btnDocumentRequests"
        btnDocumentRequests.Size = New Size(252, 28)
        btnDocumentRequests.TabIndex = 5
        btnDocumentRequests.Text = "Document Request"
        btnDocumentRequests.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Font = New Font("Tahoma", 9F)
        btnReports.Location = New Point(24, 538)
        btnReports.Margin = New Padding(3, 2, 3, 2)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(252, 28)
        btnReports.TabIndex = 6
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnStudentManagement
        ' 
        btnStudentManagement.Font = New Font("Tahoma", 9F)
        btnStudentManagement.Location = New Point(24, 442)
        btnStudentManagement.Margin = New Padding(3, 2, 3, 2)
        btnStudentManagement.Name = "btnStudentManagement"
        btnStudentManagement.Size = New Size(252, 28)
        btnStudentManagement.TabIndex = 1
        btnStudentManagement.Text = "Student Management"
        btnStudentManagement.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Tahoma", 8.25F, FontStyle.Bold)
        lblWelcome.Location = New Point(20, 77)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Padding = New Padding(0, 0, 60, 0)
        lblWelcome.Size = New Size(223, 13)
        lblWelcome.TabIndex = 7
        lblWelcome.Text = "[Welcome, User - UserRole]"
        lblWelcome.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(pnlTopBar)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(299, 0)
        pnlContent.Margin = New Padding(3, 2, 3, 2)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(965, 761)
        pnlContent.TabIndex = 1
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(106, 80)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(100, 19)
        lblTime.TabIndex = 13
        lblTime.Text = "[00:00 AM]"
        lblTime.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonth.Location = New Point(107, 17)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(74, 19)
        lblMonth.TabIndex = 0
        lblMonth.Text = "[Month]"
        lblMonth.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(103, 44)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(186, 25)
        lblDate.TabIndex = 12
        lblDate.Text = "[Monday, 31 0000]"
        lblDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlTimeDateMonth
        ' 
        pnlTimeDateMonth.Controls.Add(lblMonth)
        pnlTimeDateMonth.Controls.Add(PictureBox1)
        pnlTimeDateMonth.Controls.Add(lblTime)
        pnlTimeDateMonth.Controls.Add(lblDate)
        pnlTimeDateMonth.Dock = DockStyle.Right
        pnlTimeDateMonth.Location = New Point(593, 0)
        pnlTimeDateMonth.Name = "pnlTimeDateMonth"
        pnlTimeDateMonth.Size = New Size(372, 114)
        pnlTimeDateMonth.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(15, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(82, 82)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(6, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(253, 58)
        lblTitle.TabIndex = 8
        lblTitle.Text = "Dashboard"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.Controls.Add(pnlTimeDateMonth)
        pnlTopBar.Controls.Add(pnlWindowLabel)
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(965, 114)
        pnlTopBar.TabIndex = 2
        ' 
        ' pnlWindowLabel
        ' 
        pnlWindowLabel.Controls.Add(lblTitle)
        pnlWindowLabel.Controls.Add(lblWelcome)
        pnlWindowLabel.Dock = DockStyle.Left
        pnlWindowLabel.Location = New Point(0, 0)
        pnlWindowLabel.Name = "pnlWindowLabel"
        pnlWindowLabel.Size = New Size(281, 114)
        pnlWindowLabel.TabIndex = 14
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 761)
        Controls.Add(pnlContent)
        Controls.Add(pnlSideBar)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1280, 800)
        Name = "frmMainMenu"
        Text = "frmMainMenu"
        pnlSideBar.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlTimeDateMonth.ResumeLayout(False)
        pnlTimeDateMonth.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlTopBar.ResumeLayout(False)
        pnlWindowLabel.ResumeLayout(False)
        pnlWindowLabel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnUserManagement As Button
    Friend WithEvents btnStudentManagement As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnReports As Button
    Friend WithEvents btnDocumentRequests As Button
    Friend WithEvents btnDocumentManagement As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnDashBoard As Button
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents pnlWindowLabel As Panel
    Friend WithEvents pnlTimeDateMonth As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
