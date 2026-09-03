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
        btnLogout = New Button()
        btnUserManagement = New Button()
        btnStudentRecords = New Button()
        lblRole = New Label()
        pnlContent = New Panel()
        btnDocumentManagement = New Button()
        btnDocumentRequests = New Button()
        btnReports = New Button()
        pnlSidebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.Controls.Add(btnReports)
        pnlSidebar.Controls.Add(btnDocumentRequests)
        pnlSidebar.Controls.Add(btnDocumentManagement)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnUserManagement)
        pnlSidebar.Controls.Add(btnStudentRecords)
        pnlSidebar.Controls.Add(lblRole)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(162, 450)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(12, 216)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 29)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnUserManagement
        ' 
        btnUserManagement.Location = New Point(12, 76)
        btnUserManagement.Name = "btnUserManagement"
        btnUserManagement.Size = New Size(141, 29)
        btnUserManagement.TabIndex = 2
        btnUserManagement.Text = "UserManagement"
        btnUserManagement.UseVisualStyleBackColor = True
        ' 
        ' btnStudentRecords
        ' 
        btnStudentRecords.Location = New Point(12, 41)
        btnStudentRecords.Name = "btnStudentRecords"
        btnStudentRecords.Size = New Size(141, 29)
        btnStudentRecords.TabIndex = 1
        btnStudentRecords.Text = "StudentRecords"
        btnStudentRecords.UseVisualStyleBackColor = True
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(12, 9)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(53, 20)
        lblRole.TabIndex = 0
        lblRole.Text = "Label1"
        ' 
        ' pnlContent
        ' 
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(162, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(638, 450)
        pnlContent.TabIndex = 1
        ' 
        ' btnDocumentManagement
        ' 
        btnDocumentManagement.Location = New Point(12, 111)
        btnDocumentManagement.Name = "btnDocumentManagement"
        btnDocumentManagement.Size = New Size(141, 29)
        btnDocumentManagement.TabIndex = 4
        btnDocumentManagement.Text = "DocumentManagement"
        btnDocumentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnDocumentRequests
        ' 
        btnDocumentRequests.Location = New Point(12, 146)
        btnDocumentRequests.Name = "btnDocumentRequests"
        btnDocumentRequests.Size = New Size(141, 29)
        btnDocumentRequests.TabIndex = 5
        btnDocumentRequests.Text = "DocumentRequests"
        btnDocumentRequests.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(12, 181)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(94, 29)
        btnReports.TabIndex = 6
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Name = "frmMainMenu"
        Text = "frmMainMenu"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnUserManagement As Button
    Friend WithEvents btnStudentRecords As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnReports As Button
    Friend WithEvents btnDocumentRequests As Button
    Friend WithEvents btnDocumentManagement As Button
End Class
