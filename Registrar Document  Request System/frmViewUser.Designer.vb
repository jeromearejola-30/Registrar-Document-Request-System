<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewUser
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
        lblEditUserInformation = New Label()
        lblUserFullName = New Label()
        lblUsername = New Label()
        lbUserRole = New Label()
        lblUserStatus = New Label()
        btnSaveEdit = New Button()
        btnCancel = New Button()
        btnDeleteUser = New Button()
        txtUserFullName = New TextBox()
        txtUsername = New TextBox()
        cboUserRole = New ComboBox()
        cboUserStatus = New ComboBox()
        SuspendLayout()
        ' 
        ' lblEditUserInformation
        ' 
        lblEditUserInformation.AutoSize = True
        lblEditUserInformation.Font = New Font("Tahoma", 15.75F)
        lblEditUserInformation.Location = New Point(12, 9)
        lblEditUserInformation.Name = "lblEditUserInformation"
        lblEditUserInformation.Size = New Size(214, 25)
        lblEditUserInformation.TabIndex = 0
        lblEditUserInformation.Text = "Edit User Information"
        ' 
        ' lblUserFullName
        ' 
        lblUserFullName.AutoSize = True
        lblUserFullName.Font = New Font("Tahoma", 15.75F)
        lblUserFullName.Location = New Point(12, 98)
        lblUserFullName.Name = "lblUserFullName"
        lblUserFullName.Size = New Size(155, 25)
        lblUserFullName.TabIndex = 1
        lblUserFullName.Text = "User Full Name"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Tahoma", 15.75F)
        lblUsername.Location = New Point(12, 208)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(106, 25)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' lbUserRole
        ' 
        lbUserRole.AutoSize = True
        lbUserRole.Font = New Font("Tahoma", 15.75F)
        lbUserRole.Location = New Point(12, 381)
        lbUserRole.Name = "lbUserRole"
        lbUserRole.Size = New Size(101, 25)
        lbUserRole.TabIndex = 3
        lbUserRole.Text = "User Role"
        ' 
        ' lblUserStatus
        ' 
        lblUserStatus.AutoSize = True
        lblUserStatus.Font = New Font("Tahoma", 15.75F)
        lblUserStatus.Location = New Point(459, 381)
        lblUserStatus.Name = "lblUserStatus"
        lblUserStatus.Size = New Size(119, 25)
        lblUserStatus.TabIndex = 4
        lblUserStatus.Text = "User Status"
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.Font = New Font("Tahoma", 14.25F)
        btnSaveEdit.Location = New Point(12, 572)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(124, 38)
        btnSaveEdit.TabIndex = 5
        btnSaveEdit.Text = "Save Edit"
        btnSaveEdit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Tahoma", 14.25F)
        btnCancel.Location = New Point(143, 572)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(124, 38)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.Font = New Font("Tahoma", 14.25F)
        btnDeleteUser.Location = New Point(791, 572)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.Size = New Size(124, 38)
        btnDeleteUser.TabIndex = 7
        btnDeleteUser.Text = "Delete User"
        btnDeleteUser.UseVisualStyleBackColor = True
        ' 
        ' txtUserFullName
        ' 
        txtUserFullName.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUserFullName.Location = New Point(12, 146)
        txtUserFullName.Name = "txtUserFullName"
        txtUserFullName.Size = New Size(446, 30)
        txtUserFullName.TabIndex = 8
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(12, 263)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(446, 30)
        txtUsername.TabIndex = 9
        ' 
        ' cboUserRole
        ' 
        cboUserRole.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboUserRole.FormattingEnabled = True
        cboUserRole.Location = New Point(12, 436)
        cboUserRole.Name = "cboUserRole"
        cboUserRole.Size = New Size(255, 31)
        cboUserRole.TabIndex = 10
        ' 
        ' cboUserStatus
        ' 
        cboUserStatus.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboUserStatus.FormattingEnabled = True
        cboUserStatus.Location = New Point(459, 436)
        cboUserStatus.Name = "cboUserStatus"
        cboUserStatus.Size = New Size(255, 31)
        cboUserStatus.TabIndex = 11
        ' 
        ' frmViewUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(cboUserStatus)
        Controls.Add(cboUserRole)
        Controls.Add(txtUsername)
        Controls.Add(txtUserFullName)
        Controls.Add(btnDeleteUser)
        Controls.Add(btnCancel)
        Controls.Add(btnSaveEdit)
        Controls.Add(lblUserStatus)
        Controls.Add(lbUserRole)
        Controls.Add(lblUsername)
        Controls.Add(lblUserFullName)
        Controls.Add(lblEditUserInformation)
        Name = "frmViewUser"
        Text = "frmViewUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEditUserInformation As Label
    Friend WithEvents lblUserFullName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lbUserRole As Label
    Friend WithEvents lblUserStatus As Label
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents txtUserFullName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cboUserRole As ComboBox
    Friend WithEvents cboUserStatus As ComboBox
End Class
