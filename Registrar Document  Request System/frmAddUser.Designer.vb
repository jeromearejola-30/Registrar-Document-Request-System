<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddUser
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

        lblSubtitle = New Label()
        lblSecAccount = New Label()
        lblCapFullName = New Label()
        txtFullName = New TextBox()
        lblCapUsername = New Label()
        txtUsername = New TextBox()
        tlpAccount = New TableLayoutPanel()
        lblSecAccess = New Label()
        lblCapRole = New Label()
        cboUserRole = New ComboBox()
        lblCapStatus = New Label()
        cboUserStatus = New ComboBox()
        tlpAccess = New TableLayoutPanel()
        lblSecSecurity = New Label()
        lblCapPassword = New Label()
        txtPassword = New TextBox()
        lblCapConfirm = New Label()
        txtConfirmPassword = New TextBox()
        chkShowPassword = New CheckBox()
        tlpSecurity = New TableLayoutPanel()
        btnCreateUser = New ThemedButton()
        btnClear = New ThemedButton()
        btnCancel = New ThemedButton()
        flpButtons = New FlowLayoutPanel()
        tlpForm = New TableLayoutPanel()
        cardForm = New CardPanel()
        tlpAccount.SuspendLayout()
        tlpAccess.SuspendLayout()
        tlpSecurity.SuspendLayout()
        flpButtons.SuspendLayout()
        tlpForm.SuspendLayout()
        cardForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblSubtitle.Margin = New Padding(0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Text = "Fill in the details below. All fields are required."
        ' 
        ' lblSecAccount
        ' 
        lblSecAccount.AutoSize = True
        lblSecAccount.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecAccount.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecAccount.Margin = New Padding(0, 14, 0, 8)
        lblSecAccount.Name = "lblSecAccount"
        lblSecAccount.Text = "Account Information"
        ' 
        ' lblCapFullName
        ' 
        lblCapFullName.AutoSize = True
        lblCapFullName.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapFullName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapFullName.Margin = New Padding(0, 0, 0, 4)
        lblCapFullName.Name = "lblCapFullName"
        lblCapFullName.Text = "Full Name *"
        ' 
        ' txtFullName
        ' 
        txtFullName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Font = New Font("Segoe UI", 10.5F)
        txtFullName.Margin = New Padding(0, 0, 16, 0)
        txtFullName.MaxLength = 100
        txtFullName.Name = "txtFullName"
        ' 
        ' lblCapUsername
        ' 
        lblCapUsername.AutoSize = True
        lblCapUsername.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapUsername.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapUsername.Margin = New Padding(0, 0, 0, 4)
        lblCapUsername.Name = "lblCapUsername"
        lblCapUsername.Text = "Username *"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.5F)
        txtUsername.Margin = New Padding(0, 0, 0, 0)
        txtUsername.MaxLength = 50
        txtUsername.Name = "txtUsername"
        ' 
        ' tlpAccount
        ' 
        tlpAccount.AutoSize = True
        tlpAccount.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpAccount.ColumnCount = 2
        tlpAccount.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpAccount.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpAccount.Controls.Add(lblCapFullName, 0, 0)
        tlpAccount.Controls.Add(txtFullName, 0, 1)
        tlpAccount.Controls.Add(lblCapUsername, 1, 0)
        tlpAccount.Controls.Add(txtUsername, 1, 1)
        tlpAccount.Dock = DockStyle.Fill
        tlpAccount.Margin = New Padding(0)
        tlpAccount.Name = "tlpAccount"
        tlpAccount.RowCount = 2
        tlpAccount.RowStyles.Add(New RowStyle())
        tlpAccount.RowStyles.Add(New RowStyle())
        ' 
        ' lblSecAccess
        ' 
        lblSecAccess.AutoSize = True
        lblSecAccess.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecAccess.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecAccess.Margin = New Padding(0, 22, 0, 8)
        lblSecAccess.Name = "lblSecAccess"
        lblSecAccess.Text = "Access"
        ' 
        ' lblCapRole
        ' 
        lblCapRole.AutoSize = True
        lblCapRole.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapRole.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapRole.Margin = New Padding(0, 0, 0, 4)
        lblCapRole.Name = "lblCapRole"
        lblCapRole.Text = "User Role *"
        ' 
        ' cboUserRole
        ' 
        cboUserRole.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboUserRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboUserRole.Font = New Font("Segoe UI", 10.5F)
        cboUserRole.FormattingEnabled = True
        cboUserRole.Margin = New Padding(0, 0, 16, 0)
        cboUserRole.Name = "cboUserRole"
        ' 
        ' lblCapStatus
        ' 
        lblCapStatus.AutoSize = True
        lblCapStatus.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapStatus.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapStatus.Margin = New Padding(0, 0, 0, 4)
        lblCapStatus.Name = "lblCapStatus"
        lblCapStatus.Text = "User Status *"
        ' 
        ' cboUserStatus
        ' 
        cboUserStatus.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboUserStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboUserStatus.Font = New Font("Segoe UI", 10.5F)
        cboUserStatus.FormattingEnabled = True
        cboUserStatus.Margin = New Padding(0, 0, 0, 0)
        cboUserStatus.Name = "cboUserStatus"
        ' 
        ' tlpAccess
        ' 
        tlpAccess.AutoSize = True
        tlpAccess.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpAccess.ColumnCount = 2
        tlpAccess.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpAccess.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpAccess.Controls.Add(lblCapRole, 0, 0)
        tlpAccess.Controls.Add(cboUserRole, 0, 1)
        tlpAccess.Controls.Add(lblCapStatus, 1, 0)
        tlpAccess.Controls.Add(cboUserStatus, 1, 1)
        tlpAccess.Dock = DockStyle.Fill
        tlpAccess.Margin = New Padding(0)
        tlpAccess.Name = "tlpAccess"
        tlpAccess.RowCount = 2
        tlpAccess.RowStyles.Add(New RowStyle())
        tlpAccess.RowStyles.Add(New RowStyle())
        ' 
        ' lblSecSecurity
        ' 
        lblSecSecurity.AutoSize = True
        lblSecSecurity.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecSecurity.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecSecurity.Margin = New Padding(0, 22, 0, 8)
        lblSecSecurity.Name = "lblSecSecurity"
        lblSecSecurity.Text = "Security"
        ' 
        ' lblCapPassword
        ' 
        lblCapPassword.AutoSize = True
        lblCapPassword.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapPassword.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapPassword.Margin = New Padding(0, 0, 0, 4)
        lblCapPassword.Name = "lblCapPassword"
        lblCapPassword.Text = "Password *"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.5F)
        txtPassword.Margin = New Padding(0, 0, 16, 0)
        txtPassword.MaxLength = 50
        txtPassword.Name = "txtPassword"
        ' 
        ' lblCapConfirm
        ' 
        lblCapConfirm.AutoSize = True
        lblCapConfirm.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapConfirm.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapConfirm.Margin = New Padding(0, 0, 0, 4)
        lblCapConfirm.Name = "lblCapConfirm"
        lblCapConfirm.Text = "Confirm Password *"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Font = New Font("Segoe UI", 10.5F)
        txtConfirmPassword.Margin = New Padding(0, 0, 0, 0)
        txtConfirmPassword.MaxLength = 50
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Cursor = Cursors.Hand
        chkShowPassword.Font = New Font("Segoe UI", 9.5F)
        chkShowPassword.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        chkShowPassword.Margin = New Padding(0, 10, 0, 0)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' tlpSecurity
        ' 
        tlpSecurity.AutoSize = True
        tlpSecurity.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpSecurity.ColumnCount = 2
        tlpSecurity.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpSecurity.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpSecurity.Controls.Add(lblCapPassword, 0, 0)
        tlpSecurity.Controls.Add(txtPassword, 0, 1)
        tlpSecurity.Controls.Add(lblCapConfirm, 1, 0)
        tlpSecurity.Controls.Add(txtConfirmPassword, 1, 1)
        tlpSecurity.Controls.Add(chkShowPassword, 0, 2)
        tlpSecurity.Dock = DockStyle.Fill
        tlpSecurity.Margin = New Padding(0)
        tlpSecurity.Name = "tlpSecurity"
        tlpSecurity.RowCount = 3
        tlpSecurity.RowStyles.Add(New RowStyle())
        tlpSecurity.RowStyles.Add(New RowStyle())
        tlpSecurity.RowStyles.Add(New RowStyle())
        tlpSecurity.SetColumnSpan(chkShowPassword, 2)
        ' 
        ' btnCreateUser
        ' 
        btnCreateUser.AutoSize = True
        btnCreateUser.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCreateUser.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCreateUser.FlatAppearance.BorderSize = 0
        btnCreateUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCreateUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnCreateUser.ForeColor = Color.White
        btnCreateUser.Kind = ButtonKind.Primary
        btnCreateUser.FlatStyle = FlatStyle.Flat
        btnCreateUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCreateUser.Margin = New Padding(10, 0, 0, 0)
        btnCreateUser.MinimumSize = New Size(120, 40)
        btnCreateUser.Name = "btnCreateUser"
        btnCreateUser.Padding = New Padding(14, 0, 14, 0)
        btnCreateUser.Text = "Create User"
        btnCreateUser.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.AutoSize = True
        btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClear.BackColor = Color.White
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnClear.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClear.Margin = New Padding(10, 0, 0, 0)
        btnClear.MinimumSize = New Size(120, 40)
        btnClear.Name = "btnClear"
        btnClear.Padding = New Padding(14, 0, 14, 0)
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.AutoSize = True
        btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCancel.BackColor = Color.White
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnCancel.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancel.Margin = New Padding(10, 0, 0, 0)
        btnCancel.MinimumSize = New Size(120, 40)
        btnCancel.Name = "btnCancel"
        btnCancel.Padding = New Padding(14, 0, 14, 0)
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' flpButtons
        ' 
        flpButtons.AutoSize = True
        flpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpButtons.Controls.Add(btnCreateUser)
        flpButtons.Controls.Add(btnClear)
        flpButtons.Controls.Add(btnCancel)
        flpButtons.Dock = DockStyle.Fill
        flpButtons.FlowDirection = FlowDirection.RightToLeft
        flpButtons.Margin = New Padding(0, 28, 0, 0)
        flpButtons.Name = "flpButtons"
        flpButtons.WrapContents = False
        ' 
        ' tlpForm
        ' 
        tlpForm.ColumnCount = 1
        tlpForm.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpForm.Controls.Add(lblSubtitle, 0, 0)
        tlpForm.Controls.Add(lblSecAccount, 0, 1)
        tlpForm.Controls.Add(tlpAccount, 0, 2)
        tlpForm.Controls.Add(lblSecAccess, 0, 3)
        tlpForm.Controls.Add(tlpAccess, 0, 4)
        tlpForm.Controls.Add(lblSecSecurity, 0, 5)
        tlpForm.Controls.Add(tlpSecurity, 0, 6)
        tlpForm.Controls.Add(flpButtons, 0, 7)
        tlpForm.Dock = DockStyle.Fill
        tlpForm.Margin = New Padding(0)
        tlpForm.Name = "tlpForm"
        tlpForm.RowCount = 8
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        ' 
        ' cardForm
        ' 
        cardForm.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cardForm.BackColor = Color.White
        cardForm.Controls.Add(tlpForm)
        cardForm.Location = New Point(28, 24)
        cardForm.Name = "cardForm"
        cardForm.Padding = New Padding(32, 28, 32, 32)
        cardForm.Size = New Size(760, 480)
        ' 
        ' frmAddUser
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(cardForm)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAddUser"
        Text = "Add User"
        tlpAccount.ResumeLayout(False)
        tlpAccount.PerformLayout()
        tlpAccess.ResumeLayout(False)
        tlpAccess.PerformLayout()
        tlpSecurity.ResumeLayout(False)
        tlpSecurity.PerformLayout()
        flpButtons.ResumeLayout(False)
        flpButtons.PerformLayout()
        tlpForm.ResumeLayout(False)
        tlpForm.PerformLayout()
        cardForm.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblSecAccount As Label
    Friend WithEvents lblCapFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblCapUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents tlpAccount As TableLayoutPanel
    Friend WithEvents lblSecAccess As Label
    Friend WithEvents lblCapRole As Label
    Friend WithEvents cboUserRole As ComboBox
    Friend WithEvents lblCapStatus As Label
    Friend WithEvents cboUserStatus As ComboBox
    Friend WithEvents tlpAccess As TableLayoutPanel
    Friend WithEvents lblSecSecurity As Label
    Friend WithEvents lblCapPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblCapConfirm As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents tlpSecurity As TableLayoutPanel
    Friend WithEvents btnCreateUser As ThemedButton
    Friend WithEvents btnClear As ThemedButton
    Friend WithEvents btnCancel As ThemedButton
    Friend WithEvents flpButtons As FlowLayoutPanel
    Friend WithEvents tlpForm As TableLayoutPanel
    Friend WithEvents cardForm As CardPanel
End Class
