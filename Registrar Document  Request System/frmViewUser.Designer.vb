<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewUser
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
        txtUserFullName = New TextBox()
        lblCapUsername = New Label()
        txtUsername = New TextBox()
        tlpAccount = New TableLayoutPanel()
        lblSecAccess = New Label()
        lblCapRole = New Label()
        cboUserRole = New ComboBox()
        lblCapStatus = New Label()
        cboUserStatus = New ComboBox()
        tlpAccess = New TableLayoutPanel()
        btnSaveEdit = New ThemedButton()
        btnCancel = New ThemedButton()
        btnDeleteUser = New ThemedButton()
        flpButtons = New FlowLayoutPanel()
        tlpButtons = New TableLayoutPanel()
        tlpForm = New TableLayoutPanel()
        cardForm = New CardPanel()
        tlpAccount.SuspendLayout()
        tlpAccess.SuspendLayout()
        flpButtons.SuspendLayout()
        tlpButtons.SuspendLayout()
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
        lblSubtitle.Text = "Update this account's details. The password cannot be viewed or changed here."
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
        ' txtUserFullName
        ' 
        txtUserFullName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUserFullName.BorderStyle = BorderStyle.FixedSingle
        txtUserFullName.Font = New Font("Segoe UI", 10.5F)
        txtUserFullName.Margin = New Padding(0, 0, 16, 0)
        txtUserFullName.MaxLength = 100
        txtUserFullName.Name = "txtUserFullName"
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
        tlpAccount.Controls.Add(txtUserFullName, 0, 1)
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
        ' btnSaveEdit
        ' 
        btnSaveEdit.AutoSize = True
        btnSaveEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSaveEdit.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSaveEdit.FlatAppearance.BorderSize = 0
        btnSaveEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSaveEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnSaveEdit.ForeColor = Color.White
        btnSaveEdit.Kind = ButtonKind.Primary
        btnSaveEdit.FlatStyle = FlatStyle.Flat
        btnSaveEdit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSaveEdit.Margin = New Padding(10, 0, 0, 0)
        btnSaveEdit.MinimumSize = New Size(120, 40)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Padding = New Padding(14, 0, 14, 0)
        btnSaveEdit.Text = "Save Changes"
        btnSaveEdit.UseVisualStyleBackColor = False
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
        ' btnDeleteUser
        ' 
        btnDeleteUser.AutoSize = True
        btnDeleteUser.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDeleteUser.BackColor = Color.White
        btnDeleteUser.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnDeleteUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(254), CByte(202), CByte(202))
        btnDeleteUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(254), CByte(226), CByte(226))
        btnDeleteUser.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnDeleteUser.FlatStyle = FlatStyle.Flat
        btnDeleteUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnDeleteUser.Margin = New Padding(10, 0, 0, 0)
        btnDeleteUser.MinimumSize = New Size(120, 40)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.Padding = New Padding(14, 0, 14, 0)
        btnDeleteUser.Text = "Delete User"
        btnDeleteUser.UseVisualStyleBackColor = False
        ' 
        ' flpButtons
        ' 
        flpButtons.AutoSize = True
        flpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpButtons.Controls.Add(btnSaveEdit)
        flpButtons.Controls.Add(btnCancel)
        flpButtons.Dock = DockStyle.Fill
        flpButtons.FlowDirection = FlowDirection.RightToLeft
        flpButtons.Margin = New Padding(0)
        flpButtons.Name = "flpButtons"
        flpButtons.WrapContents = False
        ' 
        ' tlpButtons
        ' 
        tlpButtons.AutoSize = True
        tlpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpButtons.ColumnCount = 2
        tlpButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpButtons.ColumnStyles.Add(New ColumnStyle())
        tlpButtons.Controls.Add(btnDeleteUser, 0, 0)
        tlpButtons.Controls.Add(flpButtons, 1, 0)
        tlpButtons.Dock = DockStyle.Fill
        tlpButtons.Margin = New Padding(0, 28, 0, 0)
        tlpButtons.Name = "tlpButtons"
        tlpButtons.RowCount = 1
        tlpButtons.RowStyles.Add(New RowStyle())
        btnDeleteUser.Anchor = AnchorStyles.Left
        btnDeleteUser.Margin = New Padding(0)
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
        tlpForm.Controls.Add(tlpButtons, 0, 5)
        tlpForm.Dock = DockStyle.Fill
        tlpForm.Margin = New Padding(0)
        tlpForm.Name = "tlpForm"
        tlpForm.RowCount = 6
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
        ' frmViewUser
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(cardForm)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmViewUser"
        Text = "Edit User"
        tlpAccount.ResumeLayout(False)
        tlpAccount.PerformLayout()
        tlpAccess.ResumeLayout(False)
        tlpAccess.PerformLayout()
        flpButtons.ResumeLayout(False)
        flpButtons.PerformLayout()
        tlpButtons.ResumeLayout(False)
        tlpButtons.PerformLayout()
        tlpForm.ResumeLayout(False)
        tlpForm.PerformLayout()
        cardForm.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblSecAccount As Label
    Friend WithEvents lblCapFullName As Label
    Friend WithEvents txtUserFullName As TextBox
    Friend WithEvents lblCapUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents tlpAccount As TableLayoutPanel
    Friend WithEvents lblSecAccess As Label
    Friend WithEvents lblCapRole As Label
    Friend WithEvents cboUserRole As ComboBox
    Friend WithEvents lblCapStatus As Label
    Friend WithEvents cboUserStatus As ComboBox
    Friend WithEvents tlpAccess As TableLayoutPanel
    Friend WithEvents btnSaveEdit As ThemedButton
    Friend WithEvents btnCancel As ThemedButton
    Friend WithEvents btnDeleteUser As ThemedButton
    Friend WithEvents flpButtons As FlowLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents tlpForm As TableLayoutPanel
    Friend WithEvents cardForm As CardPanel
End Class
