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
        pnlSidebar = New Panel()
        btnReports = New Button()
        btnDocumentRequests = New Button()
        btnDocumentManagement = New Button()
        btnLogout = New Button()
        btnUserManagement = New Button()
        btnStudentManagement = New Button()
        lblRole = New Label()
        pnlContent = New Panel()
        Label1 = New Label()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.Controls.Add(btnReports)
        pnlSidebar.Controls.Add(btnDocumentRequests)
        pnlSidebar.Controls.Add(btnDocumentManagement)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnUserManagement)
        pnlSidebar.Controls.Add(btnStudentManagement)
        pnlSidebar.Controls.Add(lblRole)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(3, 2, 3, 2)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(320, 761)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(30, 377)
        btnReports.Margin = New Padding(3, 2, 3, 2)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(252, 28)
        btnReports.TabIndex = 6
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentRequests
        ' 
        btnDocumentRequests.Location = New Point(30, 349)
        btnDocumentRequests.Margin = New Padding(3, 2, 3, 2)
        btnDocumentRequests.Name = "btnDocumentRequests"
        btnDocumentRequests.Size = New Size(252, 28)
        btnDocumentRequests.TabIndex = 5
        btnDocumentRequests.Text = "DocumentRequests"
        btnDocumentRequests.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentManagement
        ' 
        btnDocumentManagement.Location = New Point(30, 321)
        btnDocumentManagement.Margin = New Padding(3, 2, 3, 2)
        btnDocumentManagement.Name = "btnDocumentManagement"
        btnDocumentManagement.Size = New Size(252, 28)
        btnDocumentManagement.TabIndex = 4
        btnDocumentManagement.Text = "DocumentManagement"
        btnDocumentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(30, 405)
        btnLogout.Margin = New Padding(3, 2, 3, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(252, 28)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnUserManagement
        ' 
        btnUserManagement.Location = New Point(30, 293)
        btnUserManagement.Margin = New Padding(3, 2, 3, 2)
        btnUserManagement.Name = "btnUserManagement"
        btnUserManagement.Size = New Size(252, 28)
        btnUserManagement.TabIndex = 2
        btnUserManagement.Text = "UserManagement"
        btnUserManagement.UseVisualStyleBackColor = True
        ' 
        ' btnStudentManagement
        ' 
        btnStudentManagement.Location = New Point(30, 265)
        btnStudentManagement.Margin = New Padding(3, 2, 3, 2)
        btnStudentManagement.Name = "btnStudentManagement"
        btnStudentManagement.Size = New Size(252, 28)
        btnStudentManagement.TabIndex = 1
        btnStudentManagement.Text = "Student Management"
        btnStudentManagement.UseVisualStyleBackColor = True
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(117, 113)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(41, 15)
        lblRole.TabIndex = 0
        lblRole.Text = "Label1"
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(Label1)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(320, 0)
        pnlContent.Margin = New Padding(3, 2, 3, 2)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(944, 761)
        pnlContent.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(128, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 761)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1280, 800)
        Name = "frmMainMenu"
        Text = "frmMainMenu"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnUserManagement As Button
    Friend WithEvents btnStudentManagement As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnReports As Button
    Friend WithEvents btnDocumentRequests As Button
    Friend WithEvents btnDocumentManagement As Button
    Friend WithEvents Label1 As Label
End Class
