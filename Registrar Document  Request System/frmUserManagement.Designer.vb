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
        dgvDocuments = New DataGridView()
        ColUserID = New DataGridViewTextBoxColumn()
        ColUsername = New DataGridViewTextBoxColumn()
        ColFullname = New DataGridViewTextBoxColumn()
        ColRole = New DataGridViewTextBoxColumn()
        ColUserStatus = New DataGridViewTextBoxColumn()
        fplSearchbox = New FlowLayoutPanel()
        MaskedTextBox1 = New MaskedTextBox()
        btnClearSearch = New Button()
        fplAllUsers = New FlowLayoutPanel()
        lblAllUsers = New Label()
        fplDataGridView = New FlowLayoutPanel()
        fplInformationStatistics = New FlowLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblUserInformation = New Label()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Label1 = New Label()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        btnViewUser = New Button()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        lblUserStatusSummary = New Label()
        FlowLayoutPanel6 = New FlowLayoutPanel()
        Label2 = New Label()
        FlowLayoutPanel7 = New FlowLayoutPanel()
        Button1 = New Button()
        CType(dgvDocuments, ComponentModel.ISupportInitialize).BeginInit()
        fplSearchbox.SuspendLayout()
        fplAllUsers.SuspendLayout()
        fplDataGridView.SuspendLayout()
        fplInformationStatistics.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvDocuments
        ' 
        dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDocuments.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDocuments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDocuments.Columns.AddRange(New DataGridViewColumn() {ColUserID, ColUsername, ColFullname, ColRole, ColUserStatus})
        dgvDocuments.Location = New Point(30, 20)
        dgvDocuments.Margin = New Padding(30, 20, 3, 2)
        dgvDocuments.Name = "dgvDocuments"
        dgvDocuments.RowHeadersVisible = False
        dgvDocuments.RowHeadersWidth = 51
        dgvDocuments.Size = New Size(870, 266)
        dgvDocuments.TabIndex = 4
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
        fplSearchbox.Controls.Add(MaskedTextBox1)
        fplSearchbox.Controls.Add(btnClearSearch)
        fplSearchbox.Dock = DockStyle.Top
        fplSearchbox.Location = New Point(0, 0)
        fplSearchbox.Name = "fplSearchbox"
        fplSearchbox.Size = New Size(927, 64)
        fplSearchbox.TabIndex = 5
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(165, 20)
        MaskedTextBox1.Margin = New Padding(165, 20, 3, 3)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(488, 27)
        MaskedTextBox1.TabIndex = 0
        MaskedTextBox1.Text = "    Search user..."
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
        fplAllUsers.Location = New Point(0, 64)
        fplAllUsers.Name = "fplAllUsers"
        fplAllUsers.Size = New Size(927, 35)
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
        fplDataGridView.Controls.Add(dgvDocuments)
        fplDataGridView.Dock = DockStyle.Top
        fplDataGridView.Location = New Point(0, 99)
        fplDataGridView.Name = "fplDataGridView"
        fplDataGridView.Size = New Size(927, 303)
        fplDataGridView.TabIndex = 7
        ' 
        ' fplInformationStatistics
        ' 
        fplInformationStatistics.Controls.Add(FlowLayoutPanel1)
        fplInformationStatistics.Controls.Add(FlowLayoutPanel2)
        fplInformationStatistics.Dock = DockStyle.Fill
        fplInformationStatistics.Location = New Point(0, 402)
        fplInformationStatistics.Name = "fplInformationStatistics"
        fplInformationStatistics.Size = New Size(927, 220)
        fplInformationStatistics.TabIndex = 8
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(lblUserInformation)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel3)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel4)
        FlowLayoutPanel1.Controls.Add(btnViewUser)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(25, 3)
        FlowLayoutPanel1.Margin = New Padding(25, 3, 10, 3)
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
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Location = New Point(25, 101)
        FlowLayoutPanel4.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(389, 39)
        FlowLayoutPanel4.TabIndex = 2
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
        FlowLayoutPanel2.Controls.Add(Button1)
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(477, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(428, 202)
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
        FlowLayoutPanel6.Controls.Add(Label2)
        FlowLayoutPanel6.Location = New Point(25, 51)
        FlowLayoutPanel6.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        FlowLayoutPanel6.Size = New Size(389, 39)
        FlowLayoutPanel6.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(10, 8)
        Label2.Margin = New Padding(10, 8, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 23)
        Label2.TabIndex = 0
        Label2.Text = "Username: "
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel7
        ' 
        FlowLayoutPanel7.Location = New Point(25, 101)
        FlowLayoutPanel7.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        FlowLayoutPanel7.Size = New Size(389, 39)
        FlowLayoutPanel7.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(25, 151)
        Button1.Margin = New Padding(25, 3, 3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 28)
        Button1.TabIndex = 5
        Button1.Text = "View User"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmUserManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(fplInformationStatistics)
        Controls.Add(fplDataGridView)
        Controls.Add(fplAllUsers)
        Controls.Add(fplSearchbox)
        Name = "frmUserManagement"
        Text = "UserManagement"
        CType(dgvDocuments, ComponentModel.ISupportInitialize).EndInit()
        fplSearchbox.ResumeLayout(False)
        fplSearchbox.PerformLayout()
        fplAllUsers.ResumeLayout(False)
        fplAllUsers.PerformLayout()
        fplDataGridView.ResumeLayout(False)
        fplInformationStatistics.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel6.ResumeLayout(False)
        FlowLayoutPanel6.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvDocuments As DataGridView
    Friend WithEvents fplSearchbox As FlowLayoutPanel
    Friend WithEvents fplAllUsers As FlowLayoutPanel
    Friend WithEvents fplDataGridView As FlowLayoutPanel
    Friend WithEvents fplInformationStatistics As FlowLayoutPanel
    Friend WithEvents lblAllUsers As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
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
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
End Class
