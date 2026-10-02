<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentManagement
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
        dgvStudents = New DataGridView()
        txtSearch = New TextBox()
        btnClearSearch = New Button()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        lblUserStatusSummary = New Label()
        FlowLayoutPanel6 = New FlowLayoutPanel()
        lblActiveUsers = New Label()
        lblNumberActiveStudents = New Label()
        FlowLayoutPanel7 = New FlowLayoutPanel()
        lblInactiveUsers = New Label()
        lblNumberInactiveStudents = New Label()
        FlowLayoutPanel8 = New FlowLayoutPanel()
        Label5 = New Label()
        lblNumberIncompleteRecords = New Label()
        btnAddStudentRecord = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblUserInformation = New Label()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Label1 = New Label()
        lblStudentNumber = New Label()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        Label3 = New Label()
        lblLastName = New Label()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        Label2 = New Label()
        lblFirstName = New Label()
        btnViewStudent = New Button()
        Label7 = New Label()
        FlowLayoutPanel9 = New FlowLayoutPanel()
        tplContentArea = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        FlowLayoutPanel10 = New FlowLayoutPanel()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel6.SuspendLayout()
        FlowLayoutPanel7.SuspendLayout()
        FlowLayoutPanel8.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel5.SuspendLayout()
        FlowLayoutPanel9.SuspendLayout()
        tplContentArea.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        FlowLayoutPanel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.BackgroundColor = SystemColors.Control
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvStudents.DefaultCellStyle = DataGridViewCellStyle1
        dgvStudents.Dock = DockStyle.Fill
        dgvStudents.Location = New Point(15, 156)
        dgvStudents.Margin = New Padding(15)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.Size = New Size(897, 178)
        dgvStudents.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(100, 30)
        txtSearch.Margin = New Padding(100, 30, 3, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(480, 27)
        txtSearch.TabIndex = 22
        txtSearch.Text = "   Search student..."
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearSearch.Location = New Point(586, 30)
        btnClearSearch.Margin = New Padding(3, 30, 3, 3)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(115, 27)
        btnClearSearch.TabIndex = 23
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(lblUserStatusSummary)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel6)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel7)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel8)
        FlowLayoutPanel2.Controls.Add(btnAddStudentRecord)
        FlowLayoutPanel2.Dock = DockStyle.Fill
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(473, 10)
        FlowLayoutPanel2.Margin = New Padding(13, 10, 15, 10)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(433, 247)
        FlowLayoutPanel2.TabIndex = 25
        ' 
        ' lblUserStatusSummary
        ' 
        lblUserStatusSummary.AutoSize = True
        lblUserStatusSummary.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUserStatusSummary.Location = New Point(25, 15)
        lblUserStatusSummary.Margin = New Padding(25, 15, 3, 8)
        lblUserStatusSummary.Name = "lblUserStatusSummary"
        lblUserStatusSummary.Size = New Size(246, 25)
        lblUserStatusSummary.TabIndex = 1
        lblUserStatusSummary.Text = "Student Status Summary"
        ' 
        ' FlowLayoutPanel6
        ' 
        FlowLayoutPanel6.Controls.Add(lblActiveUsers)
        FlowLayoutPanel6.Controls.Add(lblNumberActiveStudents)
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
        lblActiveUsers.Size = New Size(152, 23)
        lblActiveUsers.TabIndex = 0
        lblActiveUsers.Text = "Active Students: "
        lblActiveUsers.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNumberActiveStudents
        ' 
        lblNumberActiveStudents.AutoSize = True
        lblNumberActiveStudents.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumberActiveStudents.Location = New Point(325, 8)
        lblNumberActiveStudents.Margin = New Padding(160, 8, 3, 0)
        lblNumberActiveStudents.Name = "lblNumberActiveStudents"
        lblNumberActiveStudents.Size = New Size(30, 23)
        lblNumberActiveStudents.TabIndex = 2
        lblNumberActiveStudents.Text = "00"
        lblNumberActiveStudents.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel7
        ' 
        FlowLayoutPanel7.Controls.Add(lblInactiveUsers)
        FlowLayoutPanel7.Controls.Add(lblNumberInactiveStudents)
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
        lblInactiveUsers.Size = New Size(169, 23)
        lblInactiveUsers.TabIndex = 1
        lblInactiveUsers.Text = "Inactive Students: "
        lblInactiveUsers.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNumberInactiveStudents
        ' 
        lblNumberInactiveStudents.AutoSize = True
        lblNumberInactiveStudents.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumberInactiveStudents.Location = New Point(327, 8)
        lblNumberInactiveStudents.Margin = New Padding(145, 8, 3, 0)
        lblNumberInactiveStudents.Name = "lblNumberInactiveStudents"
        lblNumberInactiveStudents.Size = New Size(30, 23)
        lblNumberInactiveStudents.TabIndex = 3
        lblNumberInactiveStudents.Text = "00"
        lblNumberInactiveStudents.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel8
        ' 
        FlowLayoutPanel8.Controls.Add(Label5)
        FlowLayoutPanel8.Controls.Add(lblNumberIncompleteRecords)
        FlowLayoutPanel8.Location = New Point(25, 151)
        FlowLayoutPanel8.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        FlowLayoutPanel8.Size = New Size(389, 39)
        FlowLayoutPanel8.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(10, 8)
        Label5.Margin = New Padding(10, 8, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(184, 23)
        Label5.TabIndex = 1
        Label5.Text = "Incomplete Records:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNumberIncompleteRecords
        ' 
        lblNumberIncompleteRecords.AutoSize = True
        lblNumberIncompleteRecords.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumberIncompleteRecords.Location = New Point(327, 8)
        lblNumberIncompleteRecords.Margin = New Padding(130, 8, 3, 0)
        lblNumberIncompleteRecords.Name = "lblNumberIncompleteRecords"
        lblNumberIncompleteRecords.Size = New Size(30, 23)
        lblNumberIncompleteRecords.TabIndex = 3
        lblNumberIncompleteRecords.Text = "00"
        lblNumberIncompleteRecords.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnAddStudentRecord
        ' 
        btnAddStudentRecord.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddStudentRecord.Location = New Point(25, 201)
        btnAddStudentRecord.Margin = New Padding(25, 3, 3, 3)
        btnAddStudentRecord.Name = "btnAddStudentRecord"
        btnAddStudentRecord.Size = New Size(162, 28)
        btnAddStudentRecord.TabIndex = 5
        btnAddStudentRecord.Text = "Add Student Record"
        btnAddStudentRecord.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(lblUserInformation)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel3)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel4)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel5)
        FlowLayoutPanel1.Controls.Add(btnViewStudent)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(13, 10)
        FlowLayoutPanel1.Margin = New Padding(13, 10, 15, 10)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(432, 247)
        FlowLayoutPanel1.TabIndex = 24
        ' 
        ' lblUserInformation
        ' 
        lblUserInformation.AutoSize = True
        lblUserInformation.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUserInformation.Location = New Point(25, 15)
        lblUserInformation.Margin = New Padding(25, 15, 3, 8)
        lblUserInformation.Name = "lblUserInformation"
        lblUserInformation.Size = New Size(298, 25)
        lblUserInformation.TabIndex = 0
        lblUserInformation.Text = "Student Information Summary"
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Controls.Add(Label1)
        FlowLayoutPanel3.Controls.Add(lblStudentNumber)
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
        Label1.Size = New Size(157, 23)
        Label1.TabIndex = 0
        Label1.Text = "Student Number:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStudentNumber
        ' 
        lblStudentNumber.AutoSize = True
        lblStudentNumber.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStudentNumber.Location = New Point(180, 8)
        lblStudentNumber.Margin = New Padding(10, 8, 3, 0)
        lblStudentNumber.Name = "lblStudentNumber"
        lblStudentNumber.Size = New Size(77, 23)
        lblStudentNumber.TabIndex = 1
        lblStudentNumber.Text = "0000-00"
        lblStudentNumber.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Controls.Add(Label3)
        FlowLayoutPanel4.Controls.Add(lblLastName)
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
        Label3.Size = New Size(105, 23)
        Label3.TabIndex = 1
        Label3.Text = "Last Name:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLastName.Location = New Point(178, 8)
        lblLastName.Margin = New Padding(60, 8, 3, 0)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(67, 23)
        lblLastName.TabIndex = 2
        lblLastName.Text = "Arejola"
        lblLastName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Controls.Add(Label2)
        FlowLayoutPanel5.Controls.Add(lblFirstName)
        FlowLayoutPanel5.Location = New Point(25, 151)
        FlowLayoutPanel5.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Size = New Size(389, 39)
        FlowLayoutPanel5.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(10, 8)
        Label2.Margin = New Padding(10, 8, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 23)
        Label2.TabIndex = 1
        Label2.Text = "First Name:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFirstName.Location = New Point(180, 8)
        lblFirstName.Margin = New Padding(60, 8, 3, 0)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(71, 23)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "Jerome"
        lblFirstName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnViewStudent
        ' 
        btnViewStudent.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewStudent.Location = New Point(25, 201)
        btnViewStudent.Margin = New Padding(25, 3, 3, 3)
        btnViewStudent.Name = "btnViewStudent"
        btnViewStudent.Size = New Size(117, 28)
        btnViewStudent.TabIndex = 4
        btnViewStudent.Text = "View Student"
        btnViewStudent.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(25, 15)
        Label7.Margin = New Padding(25, 15, 3, 8)
        Label7.Name = "Label7"
        Label7.Size = New Size(196, 25)
        Label7.TabIndex = 26
        Label7.Text = "All Student Records"
        ' 
        ' FlowLayoutPanel9
        ' 
        FlowLayoutPanel9.Controls.Add(txtSearch)
        FlowLayoutPanel9.Controls.Add(btnClearSearch)
        FlowLayoutPanel9.Dock = DockStyle.Fill
        FlowLayoutPanel9.Location = New Point(3, 3)
        FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        FlowLayoutPanel9.Size = New Size(921, 82)
        FlowLayoutPanel9.TabIndex = 27
        ' 
        ' tplContentArea
        ' 
        tplContentArea.ColumnCount = 1
        tplContentArea.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tplContentArea.Controls.Add(TableLayoutPanel2, 0, 3)
        tplContentArea.Controls.Add(FlowLayoutPanel10, 0, 1)
        tplContentArea.Controls.Add(FlowLayoutPanel9, 0, 0)
        tplContentArea.Controls.Add(dgvStudents, 0, 2)
        tplContentArea.Dock = DockStyle.Fill
        tplContentArea.Location = New Point(0, 0)
        tplContentArea.Name = "tplContentArea"
        tplContentArea.RowCount = 4
        tplContentArea.RowStyles.Add(New RowStyle(SizeType.Percent, 62.5F))
        tplContentArea.RowStyles.Add(New RowStyle(SizeType.Percent, 37.5F))
        tplContentArea.RowStyles.Add(New RowStyle(SizeType.Absolute, 208F))
        tplContentArea.RowStyles.Add(New RowStyle(SizeType.Absolute, 272F))
        tplContentArea.Size = New Size(927, 622)
        tplContentArea.TabIndex = 28
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel1, 0, 0)
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel2, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Bottom
        TableLayoutPanel2.Location = New Point(3, 352)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(921, 267)
        TableLayoutPanel2.TabIndex = 29
        ' 
        ' FlowLayoutPanel10
        ' 
        FlowLayoutPanel10.Controls.Add(Label7)
        FlowLayoutPanel10.Dock = DockStyle.Bottom
        FlowLayoutPanel10.Location = New Point(3, 92)
        FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        FlowLayoutPanel10.Size = New Size(921, 46)
        FlowLayoutPanel10.TabIndex = 30
        ' 
        ' frmStudentManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(tplContentArea)
        Name = "frmStudentManagement"
        Text = "StudentRecords"
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel6.ResumeLayout(False)
        FlowLayoutPanel6.PerformLayout()
        FlowLayoutPanel7.ResumeLayout(False)
        FlowLayoutPanel7.PerformLayout()
        FlowLayoutPanel8.ResumeLayout(False)
        FlowLayoutPanel8.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        FlowLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel5.PerformLayout()
        FlowLayoutPanel9.ResumeLayout(False)
        FlowLayoutPanel9.PerformLayout()
        tplContentArea.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel10.ResumeLayout(False)
        FlowLayoutPanel10.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblUserStatusSummary As Label
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents lblActiveUsers As Label
    Friend WithEvents lblNumberActiveStudents As Label
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents lblInactiveUsers As Label
    Friend WithEvents lblNumberInactiveStudents As Label
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNumberIncompleteRecords As Label
    Friend WithEvents btnAddStudentRecord As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblUserInformation As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnViewStudent As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents tplContentArea As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
End Class
