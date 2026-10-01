<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvUsers = New DataGridView()
        ColUserID = New DataGridViewTextBoxColumn()
        ColUsername = New DataGridViewTextBoxColumn()
        ColFullname = New DataGridViewTextBoxColumn()
        ColRole = New DataGridViewTextBoxColumn()
        ColUserStatus = New DataGridViewTextBoxColumn()
        fplSearchbox = New FlowLayoutPanel()
        txtSearchBox = New TextBox()
        btnClearSearch = New Button()
        fplAllUsers = New FlowLayoutPanel()
        lblAllUsers = New Label()
        fplDataGridView = New FlowLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblUserInformation = New Label()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Label1 = New Label()
        lblUsername = New Label()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        Label3 = New Label()
        lblRole = New Label()
        btnViewUser = New Button()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        lblUserStatusSummary = New Label()
        FlowLayoutPanel6 = New FlowLayoutPanel()
        lblActiveUsers = New Label()
        lblNumberActiveUsers = New Label()
        FlowLayoutPanel7 = New FlowLayoutPanel()
        lblInactiveUsers = New Label()
        lblNumberInactiveUsers = New Label()
        btnAddUser = New Button()
        fplContentArea = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        fplSearchbox.SuspendLayout()
        fplAllUsers.SuspendLayout()
        fplDataGridView.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel6.SuspendLayout()
        FlowLayoutPanel7.SuspendLayout()
        fplContentArea.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Columns.AddRange(New DataGridViewColumn() {ColUserID, ColUsername, ColFullname, ColRole, ColUserStatus})
        dgvUsers.Location = New Point(30, 20)
        dgvUsers.Margin = New Padding(30, 20, 3, 2)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.RowHeadersVisible = False
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.Size = New Size(870, 180)
        dgvUsers.TabIndex = 4
        ' 
        ' ColUserID
        ' 
        ColUserID.HeaderText = "User ID"
        ColUserID.Name = "ColUserID"
        ' 
        ' ColUsername
        ' 
        ColUsername.HeaderText = "Username"
        ColUsername.Name = "ColUsername"
        ' 
        ' ColFullname
        ' 
        ColFullname.HeaderText = "Full Name"
        ColFullname.Name = "ColFullname"
        ' 
        ' ColRole
        ' 
        ColRole.HeaderText = "User Role"
        ColRole.Name = "ColRole"
        ' 
        ' ColUserStatus
        ' 
        ColUserStatus.HeaderText = "User Status"
        ColUserStatus.Name = "ColUserStatus"
        ' 
        ' fplSearchbox
        ' 
        fplSearchbox.Controls.Add(txtSearchBox)
        fplSearchbox.Controls.Add(btnClearSearch)
        fplSearchbox.Dock = DockStyle.Top
        fplSearchbox.Location = New Point(3, 3)
        fplSearchbox.Name = "fplSearchbox"
        fplSearchbox.Size = New Size(925, 64)
        fplSearchbox.TabIndex = 5
        ' 
        ' txtSearchBox
        ' 
        txtSearchBox.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchBox.Location = New Point(165, 20)
        txtSearchBox.Margin = New Padding(165, 20, 3, 3)
        txtSearchBox.Name = "txtSearchBox"
        txtSearchBox.Size = New Size(488, 27)
        txtSearchBox.TabIndex = 2
        txtSearchBox.Text = "   Search user..."
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearSearch.Location = New Point(659, 20)
        btnClearSearch.Margin = New Padding(3, 20, 3, 3)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(115, 27)
        btnClearSearch.TabIndex = 1
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = True
        ' 
        ' fplAllUsers
        ' 
        fplAllUsers.Controls.Add(lblAllUsers)
        fplAllUsers.Dock = DockStyle.Top
        fplAllUsers.Location = New Point(3, 73)
        fplAllUsers.Name = "fplAllUsers"
        fplAllUsers.Size = New Size(925, 35)
        fplAllUsers.TabIndex = 6
        ' 
        ' lblAllUsers
        ' 
        lblAllUsers.AutoSize = True
        lblAllUsers.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAllUsers.Location = New Point(20, 5)
        lblAllUsers.Margin = New Padding(20, 5, 3, 0)
        lblAllUsers.Name = "lblAllUsers"
        lblAllUsers.Size = New Size(93, 25)
        lblAllUsers.TabIndex = 0
        lblAllUsers.Text = "All Users"
        ' 
        ' fplDataGridView
        ' 
        fplDataGridView.Controls.Add(dgvUsers)
        fplDataGridView.Location = New Point(3, 114)
        fplDataGridView.Name = "fplDataGridView"
        fplDataGridView.Size = New Size(925, 259)
        fplDataGridView.TabIndex = 7
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(lblUserInformation)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel3)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel4)
        FlowLayoutPanel1.Controls.Add(btnViewUser)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(10, 15)
        FlowLayoutPanel1.Margin = New Padding(10, 15, 10, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(439, 202)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' lblUserInformation
        ' 
        lblUserInformation.AutoSize = True
        lblUserInformation.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUserInformation.Location = New Point(25, 15)
        lblUserInformation.Margin = New Padding(25, 15, 3, 8)
        lblUserInformation.Name = "lblUserInformation"
        lblUserInformation.Size = New Size(171, 25)
        lblUserInformation.TabIndex = 0
        lblUserInformation.Text = "User Information"
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Controls.Add(Label1)
        FlowLayoutPanel3.Controls.Add(lblUsername)
        FlowLayoutPanel3.Location = New Point(25, 51)
        FlowLayoutPanel3.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(389, 39)
        FlowLayoutPanel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 8)
        Label1.Margin = New Padding(10, 8, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 23)
        Label1.TabIndex = 0
        Label1.Text = "Username: "
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(215, 8)
        lblUsername.Margin = New Padding(95, 8, 3, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(87, 23)
        lblUsername.TabIndex = 1
        lblUsername.Text = "User1234"
        lblUsername.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Controls.Add(Label3)
        FlowLayoutPanel4.Controls.Add(lblRole)
        FlowLayoutPanel4.Location = New Point(25, 101)
        FlowLayoutPanel4.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(389, 39)
        FlowLayoutPanel4.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(10, 8)
        Label3.Margin = New Padding(10, 8, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 23)
        Label3.TabIndex = 1
        Label3.Text = "Role: "
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(217, 8)
        lblRole.Margin = New Padding(145, 8, 3, 0)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(121, 23)
        lblRole.TabIndex = 2
        lblRole.Text = "Administrator"
        lblRole.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnViewUser
        ' 
        btnViewUser.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewUser.Location = New Point(25, 151)
        btnViewUser.Margin = New Padding(25, 3, 3, 3)
        btnViewUser.Name = "btnViewUser"
        btnViewUser.Size = New Size(117, 28)
        btnViewUser.TabIndex = 4
        btnViewUser.Text = "View User"
        btnViewUser.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(lblUserStatusSummary)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel6)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel7)
        FlowLayoutPanel2.Controls.Add(btnAddUser)
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(477, 15)
        FlowLayoutPanel2.Margin = New Padding(15, 15, 3, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(437, 202)
        FlowLayoutPanel2.TabIndex = 1
        ' 
        ' lblUserStatusSummary
        ' 
        lblUserStatusSummary.AutoSize = True
        lblUserStatusSummary.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUserStatusSummary.Location = New Point(25, 15)
        lblUserStatusSummary.Margin = New Padding(25, 15, 3, 8)
        lblUserStatusSummary.Name = "lblUserStatusSummary"
        lblUserStatusSummary.Size = New Size(215, 25)
        lblUserStatusSummary.TabIndex = 1
        lblUserStatusSummary.Text = "User Status Summary"
        ' 
        ' FlowLayoutPanel6
        ' 
        FlowLayoutPanel6.Controls.Add(lblActiveUsers)
        FlowLayoutPanel6.Controls.Add(lblNumberActiveUsers)
        FlowLayoutPanel6.Location = New Point(25, 51)
        FlowLayoutPanel6.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        FlowLayoutPanel6.Size = New Size(389, 39)
        FlowLayoutPanel6.TabIndex = 2
        ' 
        ' lblActiveUsers
        ' 
        lblActiveUsers.AutoSize = True
        lblActiveUsers.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblActiveUsers.Location = New Point(10, 8)
        lblActiveUsers.Margin = New Padding(10, 8, 3, 0)
        lblActiveUsers.Name = "lblActiveUsers"
        lblActiveUsers.Size = New Size(123, 23)
        lblActiveUsers.TabIndex = 0
        lblActiveUsers.Text = "Active Users: "
        lblActiveUsers.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNumberActiveUsers
        ' 
        lblNumberActiveUsers.AutoSize = True
        lblNumberActiveUsers.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumberActiveUsers.Location = New Point(336, 8)
        lblNumberActiveUsers.Margin = New Padding(200, 8, 3, 0)
        lblNumberActiveUsers.Name = "lblNumberActiveUsers"
        lblNumberActiveUsers.Size = New Size(30, 23)
        lblNumberActiveUsers.TabIndex = 2
        lblNumberActiveUsers.Text = "00"
        lblNumberActiveUsers.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel7
        ' 
        FlowLayoutPanel7.Controls.Add(lblInactiveUsers)
        FlowLayoutPanel7.Controls.Add(lblNumberInactiveUsers)
        FlowLayoutPanel7.Location = New Point(25, 101)
        FlowLayoutPanel7.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        FlowLayoutPanel7.Size = New Size(389, 39)
        FlowLayoutPanel7.TabIndex = 3
        ' 
        ' lblInactiveUsers
        ' 
        lblInactiveUsers.AutoSize = True
        lblInactiveUsers.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInactiveUsers.Location = New Point(10, 8)
        lblInactiveUsers.Margin = New Padding(10, 8, 3, 0)
        lblInactiveUsers.Name = "lblInactiveUsers"
        lblInactiveUsers.Size = New Size(140, 23)
        lblInactiveUsers.TabIndex = 1
        lblInactiveUsers.Text = "Inactive Users: "
        lblInactiveUsers.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNumberInactiveUsers
        ' 
        lblNumberInactiveUsers.AutoSize = True
        lblNumberInactiveUsers.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumberInactiveUsers.Location = New Point(338, 8)
        lblNumberInactiveUsers.Margin = New Padding(185, 8, 3, 0)
        lblNumberInactiveUsers.Name = "lblNumberInactiveUsers"
        lblNumberInactiveUsers.Size = New Size(30, 23)
        lblNumberInactiveUsers.TabIndex = 3
        lblNumberInactiveUsers.Text = "00"
        lblNumberInactiveUsers.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnAddUser
        ' 
        btnAddUser.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddUser.Location = New Point(25, 151)
        btnAddUser.Margin = New Padding(25, 3, 3, 3)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(117, 28)
        btnAddUser.TabIndex = 5
        btnAddUser.Text = "Add User"
        btnAddUser.UseVisualStyleBackColor = True
        ' 
        ' fplContentArea
        ' 
        fplContentArea.Controls.Add(fplSearchbox)
        fplContentArea.Controls.Add(fplAllUsers)
        fplContentArea.Controls.Add(fplDataGridView)
        fplContentArea.Controls.Add(TableLayoutPanel1)
        fplContentArea.Dock = DockStyle.Fill
        fplContentArea.FlowDirection = FlowDirection.TopDown
        fplContentArea.Location = New Point(0, 0)
        fplContentArea.Name = "fplContentArea"
        fplContentArea.Size = New Size(927, 622)
        fplContentArea.TabIndex = 9
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.9459457F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0540543F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel2, 1, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 0)
        TableLayoutPanel1.Location = New Point(3, 379)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(925, 237)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' frmUserManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(fplContentArea)
        Name = "frmUserManagement"
        Text = "UserManagement"
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        fplSearchbox.ResumeLayout(False)
        fplSearchbox.PerformLayout()
        fplAllUsers.ResumeLayout(False)
        fplAllUsers.PerformLayout()
        fplDataGridView.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel6.ResumeLayout(False)
        FlowLayoutPanel6.PerformLayout()
        FlowLayoutPanel7.ResumeLayout(False)
        FlowLayoutPanel7.PerformLayout()
        fplContentArea.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents fplSearchbox As FlowLayoutPanel
    Friend WithEvents fplAllUsers As FlowLayoutPanel
    Friend WithEvents fplDataGridView As FlowLayoutPanel
    Friend WithEvents lblAllUsers As Label
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents ColUserID As DataGridViewTextBoxColumn
    Friend WithEvents ColUsername As DataGridViewTextBoxColumn
    Friend WithEvents ColFullname As DataGridViewTextBoxColumn
    Friend WithEvents ColRole As DataGridViewTextBoxColumn
    Friend WithEvents ColUserStatus As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblUserInformation As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserStatusSummary As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents btnViewUser As Button
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents lblActiveUsers As Label
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents btnAddUser As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblInactiveUsers As Label
    Friend WithEvents lblNumberActiveUsers As Label
    Friend WithEvents lblNumberInactiveUsers As Label
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents fplContentArea As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
