<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserManagement
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

        txtSearchBox = New TextBox()
        btnClearSearch = New Button()
        btnAddUser = New Button()
        tlpToolbar = New TableLayoutPanel()
        lblAllUsers = New Label()
        dgvUsers = New DataGridView()
        pnlGridBorder = New Panel()
        lblUserInformation = New Label()
        lblCapUsername = New Label()
        lblUsername = New Label()
        lblCapRole = New Label()
        lblRole = New Label()
        btnViewUser = New Button()
        tlpInfo = New TableLayoutPanel()
        cardInfo = New CardPanel()
        lblUserStatusSummary = New Label()
        lblActiveUsers = New Label()
        lblNumberActiveUsers = New Label()
        lblInactiveUsers = New Label()
        lblNumberInactiveUsers = New Label()
        tlpStatus = New TableLayoutPanel()
        cardStatus = New CardPanel()
        tlpSummary = New TableLayoutPanel()
        tlpMain = New TableLayoutPanel()
        tlpToolbar.SuspendLayout()
        pnlGridBorder.SuspendLayout()
        tlpInfo.SuspendLayout()
        cardInfo.SuspendLayout()
        tlpStatus.SuspendLayout()
        cardStatus.SuspendLayout()
        tlpSummary.SuspendLayout()
        tlpMain.SuspendLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearchBox
        ' 
        txtSearchBox.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSearchBox.BorderStyle = BorderStyle.FixedSingle
        txtSearchBox.Font = New Font("Segoe UI", 11F)
        txtSearchBox.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        txtSearchBox.Margin = New Padding(0)
        txtSearchBox.MaximumSize = New Size(520, 0)
        txtSearchBox.Name = "txtSearchBox"
        txtSearchBox.PlaceholderText = "Search by username, name or role..."
        txtSearchBox.Size = New Size(520, 27)
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.AutoSize = True
        btnClearSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClearSearch.Cursor = Cursors.Hand
        btnClearSearch.BackColor = Color.White
        btnClearSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClearSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnClearSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnClearSearch.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClearSearch.FlatStyle = FlatStyle.Flat
        btnClearSearch.Font = New Font("Segoe UI Semibold", 10F)
        btnClearSearch.Margin = New Padding(8, 0, 0, 0)
        btnClearSearch.MinimumSize = New Size(0, 40)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Padding = New Padding(14, 0, 14, 0)
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = False
        ' 
        ' btnAddUser
        ' 
        btnAddUser.AutoSize = True
        btnAddUser.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddUser.Cursor = Cursors.Hand
        btnAddUser.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnAddUser.FlatAppearance.BorderSize = 0
        btnAddUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(36), CByte(90), CByte(65))
        btnAddUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnAddUser.ForeColor = Color.White
        btnAddUser.FlatStyle = FlatStyle.Flat
        btnAddUser.Font = New Font("Segoe UI Semibold", 10F)
        btnAddUser.Margin = New Padding(8, 0, 0, 0)
        btnAddUser.MinimumSize = New Size(0, 40)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Padding = New Padding(14, 0, 14, 0)
        btnAddUser.Text = "Add User"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' tlpToolbar
        ' 
        tlpToolbar.AutoSize = True
        tlpToolbar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpToolbar.ColumnCount = 3
        tlpToolbar.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.Controls.Add(txtSearchBox, 0, 0)
        tlpToolbar.Controls.Add(btnClearSearch, 1, 0)
        tlpToolbar.Controls.Add(btnAddUser, 2, 0)
        tlpToolbar.Dock = DockStyle.Fill
        tlpToolbar.Margin = New Padding(0)
        tlpToolbar.Name = "tlpToolbar"
        tlpToolbar.RowCount = 1
        tlpToolbar.RowStyles.Add(New RowStyle())
        ' 
        ' lblAllUsers
        ' 
        lblAllUsers.AutoSize = True
        lblAllUsers.Font = New Font("Segoe UI Semibold", 12F)
        lblAllUsers.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblAllUsers.Margin = New Padding(0, 16, 0, 8)
        lblAllUsers.Name = "lblAllUsers"
        lblAllUsers.Text = "All Users"
        ' 
        ' dgvUsers
        ' 
        dgvUsers.Dock = DockStyle.Fill
        dgvUsers.Name = "dgvUsers"
        ' 
        ' pnlGridBorder
        ' 
        pnlGridBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlGridBorder.Controls.Add(dgvUsers)
        pnlGridBorder.Dock = DockStyle.Fill
        pnlGridBorder.Margin = New Padding(0)
        pnlGridBorder.Name = "pnlGridBorder"
        pnlGridBorder.Padding = New Padding(1)
        ' 
        ' lblUserInformation
        ' 
        lblUserInformation.AutoSize = True
        lblUserInformation.Font = New Font("Segoe UI Semibold", 11F)
        lblUserInformation.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblUserInformation.Margin = New Padding(0, 0, 0, 8)
        lblUserInformation.Name = "lblUserInformation"
        lblUserInformation.Text = "User Information"
        ' 
        ' lblCapUsername
        ' 
        lblCapUsername.AutoSize = True
        lblCapUsername.Font = New Font("Segoe UI", 10F)
        lblCapUsername.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapUsername.Margin = New Padding(0, 3, 0, 3)
        lblCapUsername.Name = "lblCapUsername"
        lblCapUsername.Text = "Username"
        ' 
        ' lblUsername
        ' 
        lblUsername.Font = New Font("Segoe UI Semibold", 10.5F)
        lblUsername.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblUsername.Margin = New Padding(0, 3, 0, 3)
        lblUsername.Name = "lblUsername"
        lblUsername.Text = "-"
        lblUsername.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblUsername.AutoEllipsis = True
        lblUsername.Size = New Size(200, 22)
        ' 
        ' lblCapRole
        ' 
        lblCapRole.AutoSize = True
        lblCapRole.Font = New Font("Segoe UI", 10F)
        lblCapRole.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapRole.Margin = New Padding(0, 3, 0, 3)
        lblCapRole.Name = "lblCapRole"
        lblCapRole.Text = "Role"
        ' 
        ' lblRole
        ' 
        lblRole.Font = New Font("Segoe UI Semibold", 10.5F)
        lblRole.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblRole.Margin = New Padding(0, 3, 0, 3)
        lblRole.Name = "lblRole"
        lblRole.Text = "-"
        lblRole.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblRole.AutoEllipsis = True
        lblRole.Size = New Size(200, 22)
        ' 
        ' btnViewUser
        ' 
        btnViewUser.AutoSize = True
        btnViewUser.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnViewUser.Cursor = Cursors.Hand
        btnViewUser.BackColor = Color.White
        btnViewUser.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnViewUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnViewUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnViewUser.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnViewUser.FlatStyle = FlatStyle.Flat
        btnViewUser.Font = New Font("Segoe UI Semibold", 10F)
        btnViewUser.Margin = New Padding(8, 0, 0, 0)
        btnViewUser.MinimumSize = New Size(0, 40)
        btnViewUser.Name = "btnViewUser"
        btnViewUser.Padding = New Padding(14, 0, 14, 0)
        btnViewUser.Text = "View / Edit User"
        btnViewUser.UseVisualStyleBackColor = False
        ' 
        ' tlpInfo
        ' 
        tlpInfo.ColumnCount = 2
        tlpInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 130F))
        tlpInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpInfo.Controls.Add(lblUserInformation, 0, 0)
        tlpInfo.Controls.Add(lblCapUsername, 0, 1)
        tlpInfo.Controls.Add(lblUsername, 1, 1)
        tlpInfo.Controls.Add(lblCapRole, 0, 2)
        tlpInfo.Controls.Add(lblRole, 1, 2)
        tlpInfo.Controls.Add(btnViewUser, 0, 3)
        tlpInfo.Dock = DockStyle.Fill
        tlpInfo.Margin = New Padding(0)
        tlpInfo.Name = "tlpInfo"
        tlpInfo.RowCount = 4
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpInfo.SetColumnSpan(lblUserInformation, 2)
        tlpInfo.SetColumnSpan(btnViewUser, 2)
        btnViewUser.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnViewUser.Margin = New Padding(0, 8, 0, 0)
        ' 
        ' cardInfo
        ' 
        cardInfo.BackColor = Color.White
        cardInfo.Controls.Add(tlpInfo)
        cardInfo.Dock = DockStyle.Fill
        cardInfo.Margin = New Padding(0, 0, 8, 0)
        cardInfo.Name = "cardInfo"
        cardInfo.Padding = New Padding(20, 14, 20, 14)
        ' 
        ' lblUserStatusSummary
        ' 
        lblUserStatusSummary.AutoSize = True
        lblUserStatusSummary.Font = New Font("Segoe UI Semibold", 11F)
        lblUserStatusSummary.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblUserStatusSummary.Margin = New Padding(0, 0, 0, 8)
        lblUserStatusSummary.Name = "lblUserStatusSummary"
        lblUserStatusSummary.Text = "User Status Summary"
        ' 
        ' lblActiveUsers
        ' 
        lblActiveUsers.AutoSize = True
        lblActiveUsers.Font = New Font("Segoe UI", 10F)
        lblActiveUsers.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblActiveUsers.Margin = New Padding(0, 3, 0, 3)
        lblActiveUsers.Name = "lblActiveUsers"
        lblActiveUsers.Text = "Active Users"
        ' 
        ' lblNumberActiveUsers
        ' 
        lblNumberActiveUsers.AutoSize = True
        lblNumberActiveUsers.Font = New Font("Segoe UI Semibold", 10.5F)
        lblNumberActiveUsers.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblNumberActiveUsers.Margin = New Padding(0, 3, 0, 3)
        lblNumberActiveUsers.Name = "lblNumberActiveUsers"
        lblNumberActiveUsers.Text = "0"
        lblNumberActiveUsers.Anchor = AnchorStyles.Right
        ' 
        ' lblInactiveUsers
        ' 
        lblInactiveUsers.AutoSize = True
        lblInactiveUsers.Font = New Font("Segoe UI", 10F)
        lblInactiveUsers.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblInactiveUsers.Margin = New Padding(0, 3, 0, 3)
        lblInactiveUsers.Name = "lblInactiveUsers"
        lblInactiveUsers.Text = "Inactive Users"
        ' 
        ' lblNumberInactiveUsers
        ' 
        lblNumberInactiveUsers.AutoSize = True
        lblNumberInactiveUsers.Font = New Font("Segoe UI Semibold", 10.5F)
        lblNumberInactiveUsers.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblNumberInactiveUsers.Margin = New Padding(0, 3, 0, 3)
        lblNumberInactiveUsers.Name = "lblNumberInactiveUsers"
        lblNumberInactiveUsers.Text = "0"
        lblNumberInactiveUsers.Anchor = AnchorStyles.Right
        ' 
        ' tlpStatus
        ' 
        tlpStatus.ColumnCount = 2
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpStatus.ColumnStyles.Add(New ColumnStyle())
        tlpStatus.Controls.Add(lblUserStatusSummary, 0, 0)
        tlpStatus.Controls.Add(lblActiveUsers, 0, 1)
        tlpStatus.Controls.Add(lblNumberActiveUsers, 1, 1)
        tlpStatus.Controls.Add(lblInactiveUsers, 0, 2)
        tlpStatus.Controls.Add(lblNumberInactiveUsers, 1, 2)
        tlpStatus.Dock = DockStyle.Fill
        tlpStatus.Margin = New Padding(0)
        tlpStatus.Name = "tlpStatus"
        tlpStatus.RowCount = 4
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpStatus.SetColumnSpan(lblUserStatusSummary, 2)
        ' 
        ' cardStatus
        ' 
        cardStatus.BackColor = Color.White
        cardStatus.Controls.Add(tlpStatus)
        cardStatus.Dock = DockStyle.Fill
        cardStatus.Margin = New Padding(8, 0, 0, 0)
        cardStatus.Name = "cardStatus"
        cardStatus.Padding = New Padding(20, 14, 20, 14)
        ' 
        ' tlpSummary
        ' 
        tlpSummary.ColumnCount = 2
        tlpSummary.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpSummary.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpSummary.Controls.Add(cardInfo, 0, 0)
        tlpSummary.Controls.Add(cardStatus, 1, 0)
        tlpSummary.Dock = DockStyle.Fill
        tlpSummary.Margin = New Padding(0, 16, 0, 0)
        tlpSummary.Name = "tlpSummary"
        tlpSummary.RowCount = 1
        tlpSummary.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        ' 
        ' tlpMain
        ' 
        tlpMain.ColumnCount = 1
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpMain.Controls.Add(tlpToolbar, 0, 0)
        tlpMain.Controls.Add(lblAllUsers, 0, 1)
        tlpMain.Controls.Add(pnlGridBorder, 0, 2)
        tlpMain.Controls.Add(tlpSummary, 0, 3)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Margin = New Padding(0)
        tlpMain.Name = "tlpMain"
        tlpMain.RowCount = 4
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 180F))
        tlpMain.Padding = New Padding(28, 20, 28, 24)
        ' 
        ' frmUserManagement
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(760, 600)
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(tlpMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmUserManagement"
        Text = "User Management"
        tlpToolbar.ResumeLayout(False)
        tlpToolbar.PerformLayout()
        pnlGridBorder.ResumeLayout(False)
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        tlpInfo.ResumeLayout(False)
        tlpInfo.PerformLayout()
        cardInfo.ResumeLayout(False)
        tlpStatus.ResumeLayout(False)
        tlpStatus.PerformLayout()
        cardStatus.ResumeLayout(False)
        tlpSummary.ResumeLayout(False)
        tlpMain.ResumeLayout(False)
        tlpMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents tlpToolbar As TableLayoutPanel
    Friend WithEvents lblAllUsers As Label
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents pnlGridBorder As Panel
    Friend WithEvents lblUserInformation As Label
    Friend WithEvents lblCapUsername As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblCapRole As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents btnViewUser As Button
    Friend WithEvents tlpInfo As TableLayoutPanel
    Friend WithEvents cardInfo As CardPanel
    Friend WithEvents lblUserStatusSummary As Label
    Friend WithEvents lblActiveUsers As Label
    Friend WithEvents lblNumberActiveUsers As Label
    Friend WithEvents lblInactiveUsers As Label
    Friend WithEvents lblNumberInactiveUsers As Label
    Friend WithEvents tlpStatus As TableLayoutPanel
    Friend WithEvents cardStatus As CardPanel
    Friend WithEvents tlpSummary As TableLayoutPanel
    Friend WithEvents tlpMain As TableLayoutPanel
End Class
