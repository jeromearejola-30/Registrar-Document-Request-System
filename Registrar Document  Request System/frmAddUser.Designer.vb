<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        cboUserStatus = New ComboBox()
        cboUserRole = New ComboBox()
        txtFullName = New TextBox()
        txtConfirmPassword = New TextBox()
        btnClear = New Button()
        btnCancel = New Button()
        btnCreateUser = New Button()
        lblUserStatus = New Label()
        lbUserRole = New Label()
        lblFullName = New Label()
        lblConfirmPassword = New Label()
        lblAddUser = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        txtPassword = New TextBox()
        lblPassword = New Label()
        SuspendLayout()
        ' 
        ' cboUserStatus
        ' 
        cboUserStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboUserStatus.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboUserStatus.FormattingEnabled = True
        cboUserStatus.Location = New Point(112, 223)
        cboUserStatus.Name = "cboUserStatus"
        cboUserStatus.Size = New Size(255, 31)
        cboUserStatus.TabIndex = 23
        ' 
        ' cboUserRole
        ' 
        cboUserRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboUserRole.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboUserRole.FormattingEnabled = True
        cboUserRole.Location = New Point(478, 223)
        cboUserRole.Name = "cboUserRole"
        cboUserRole.Size = New Size(255, 31)
        cboUserRole.TabIndex = 22
        ' 
        ' txtFullName
        ' 
        txtFullName.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFullName.Location = New Point(112, 136)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(621, 30)
        txtFullName.TabIndex = 21
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmPassword.Location = New Point(112, 451)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(621, 30)
        txtConfirmPassword.TabIndex = 20
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Tahoma", 14.25F)
        btnClear.Location = New Point(791, 574)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(124, 38)
        btnClear.TabIndex = 19
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Tahoma", 14.25F)
        btnCancel.Location = New Point(143, 574)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(124, 38)
        btnCancel.TabIndex = 18
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnCreateUser
        ' 
        btnCreateUser.Font = New Font("Tahoma", 14.25F)
        btnCreateUser.Location = New Point(12, 574)
        btnCreateUser.Name = "btnCreateUser"
        btnCreateUser.Size = New Size(124, 38)
        btnCreateUser.TabIndex = 17
        btnCreateUser.Text = "Create User"
        btnCreateUser.UseVisualStyleBackColor = True
        ' 
        ' lblUserStatus
        ' 
        lblUserStatus.AutoSize = True
        lblUserStatus.Font = New Font("Tahoma", 15.75F)
        lblUserStatus.Location = New Point(112, 195)
        lblUserStatus.Name = "lblUserStatus"
        lblUserStatus.Size = New Size(119, 25)
        lblUserStatus.TabIndex = 16
        lblUserStatus.Text = "User Status"
        ' 
        ' lbUserRole
        ' 
        lbUserRole.AutoSize = True
        lbUserRole.Font = New Font("Tahoma", 15.75F)
        lbUserRole.Location = New Point(478, 195)
        lbUserRole.Name = "lbUserRole"
        lbUserRole.Size = New Size(101, 25)
        lbUserRole.TabIndex = 15
        lbUserRole.Text = "User Role"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Tahoma", 15.75F)
        lblFullName.Location = New Point(112, 108)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(155, 25)
        lblFullName.TabIndex = 14
        lblFullName.Text = "User Full Name"
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Tahoma", 15.75F)
        lblConfirmPassword.Location = New Point(112, 423)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(181, 25)
        lblConfirmPassword.TabIndex = 13
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' lblAddUser
        ' 
        lblAddUser.AutoSize = True
        lblAddUser.Font = New Font("Tahoma", 15.75F)
        lblAddUser.Location = New Point(12, 11)
        lblAddUser.Name = "lblAddUser"
        lblAddUser.Size = New Size(180, 25)
        lblAddUser.TabIndex = 12
        lblAddUser.Text = "Add User Account"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(112, 298)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(621, 30)
        txtUsername.TabIndex = 25
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Tahoma", 15.75F)
        lblUsername.Location = New Point(112, 270)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(197, 25)
        lblUsername.TabIndex = 24
        lblUsername.Text = "Account User Name"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(112, 372)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(621, 30)
        txtPassword.TabIndex = 27
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Tahoma", 15.75F)
        lblPassword.Location = New Point(112, 344)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(100, 25)
        lblPassword.TabIndex = 26
        lblPassword.Text = "Password"
        ' 
        ' frmAddUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(cboUserStatus)
        Controls.Add(cboUserRole)
        Controls.Add(txtFullName)
        Controls.Add(txtConfirmPassword)
        Controls.Add(btnClear)
        Controls.Add(btnCancel)
        Controls.Add(btnCreateUser)
        Controls.Add(lblUserStatus)
        Controls.Add(lbUserRole)
        Controls.Add(lblFullName)
        Controls.Add(lblConfirmPassword)
        Controls.Add(lblAddUser)
        Name = "frmAddUser"
        Text = "frmAddUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboUserStatus As ComboBox
    Friend WithEvents cboUserRole As ComboBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents lblUserStatus As Label
    Friend WithEvents lbUserRole As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblAddUser As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
End Class
