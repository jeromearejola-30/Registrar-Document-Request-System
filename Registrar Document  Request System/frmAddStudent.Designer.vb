<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
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
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        btnCancel = New Button()
        btnClear = New Button()
        btnSaveEdit = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        FlowLayoutPanel9 = New FlowLayoutPanel()
        Label7 = New Label()
        cboYearLevel = New ComboBox()
        FlowLayoutPanel10 = New FlowLayoutPanel()
        Label9 = New Label()
        txtSection = New TextBox()
        FlowLayoutPanel11 = New FlowLayoutPanel()
        Label8 = New Label()
        cboCourse = New ComboBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Label10 = New Label()
        Label12 = New Label()
        txtContactNumber = New TextBox()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        Label11 = New Label()
        txtLRN = New TextBox()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        Label6 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        FlowLayoutPanel6 = New FlowLayoutPanel()
        Label4 = New Label()
        txtLastName = New TextBox()
        FlowLayoutPanel8 = New FlowLayoutPanel()
        Label3 = New Label()
        txtFirstName = New TextBox()
        FlowLayoutPanel7 = New FlowLayoutPanel()
        Label5 = New Label()
        txtMiddleName = New TextBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label2 = New Label()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        FlowLayoutPanel9.SuspendLayout()
        FlowLayoutPanel10.SuspendLayout()
        FlowLayoutPanel11.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel5.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        FlowLayoutPanel6.SuspendLayout()
        FlowLayoutPanel8.SuspendLayout()
        FlowLayoutPanel7.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(TableLayoutPanel5, 0, 6)
        TableLayoutPanel4.Controls.Add(FlowLayoutPanel1, 0, 0)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel2, 0, 4)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel3, 0, 5)
        TableLayoutPanel4.Controls.Add(FlowLayoutPanel5, 0, 3)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel1, 0, 2)
        TableLayoutPanel4.Controls.Add(FlowLayoutPanel2, 0, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(0, 0)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 7
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 54.6391754F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 45.3608246F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 118F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 127F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 155F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 74F))
        TableLayoutPanel4.Size = New Size(927, 622)
        TableLayoutPanel4.TabIndex = 33
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 3
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.55703F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 79.44297F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 156F))
        TableLayoutPanel5.Controls.Add(btnCancel, 2, 0)
        TableLayoutPanel5.Controls.Add(btnClear, 1, 0)
        TableLayoutPanel5.Controls.Add(btnSaveEdit, 0, 0)
        TableLayoutPanel5.Location = New Point(3, 550)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(921, 69)
        TableLayoutPanel5.TabIndex = 34
        ' 
        ' btnCancel
        ' 
        btnCancel.Dock = DockStyle.Right
        btnCancel.Font = New Font("Tahoma", 14.25F)
        btnCancel.Location = New Point(774, 15)
        btnCancel.Margin = New Padding(10, 15, 10, 10)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(137, 44)
        btnCancel.TabIndex = 35
        btnCancel.Text = "Cancel Edit"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Dock = DockStyle.Left
        btnClear.Font = New Font("Tahoma", 14.25F)
        btnClear.Location = New Point(167, 15)
        btnClear.Margin = New Padding(10, 15, 3, 10)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(141, 44)
        btnClear.TabIndex = 34
        btnClear.Text = "Clear All"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.Dock = DockStyle.Left
        btnSaveEdit.Font = New Font("Tahoma", 14.25F)
        btnSaveEdit.Location = New Point(10, 15)
        btnSaveEdit.Margin = New Padding(10, 15, 3, 10)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(141, 44)
        btnSaveEdit.TabIndex = 33
        btnSaveEdit.Text = "Save Edit"
        btnSaveEdit.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label1)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(3, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(921, 50)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 5)
        Label1.Margin = New Padding(15, 5, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 29)
        Label1.TabIndex = 0
        Label1.Text = "Add Student Record"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel9, 0, 0)
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel10, 1, 0)
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel11, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 268)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(921, 121)
        TableLayoutPanel2.TabIndex = 30
        ' 
        ' FlowLayoutPanel9
        ' 
        FlowLayoutPanel9.Controls.Add(Label7)
        FlowLayoutPanel9.Controls.Add(cboYearLevel)
        FlowLayoutPanel9.Dock = DockStyle.Fill
        FlowLayoutPanel9.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel9.Location = New Point(10, 10)
        FlowLayoutPanel9.Margin = New Padding(10)
        FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        FlowLayoutPanel9.Size = New Size(286, 101)
        FlowLayoutPanel9.TabIndex = 27
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label7.Location = New Point(15, 20)
        Label7.Margin = New Padding(15, 20, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 19)
        Label7.TabIndex = 6
        Label7.Text = "Year Level:"
        ' 
        ' cboYearLevel
        ' 
        cboYearLevel.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboYearLevel.FormattingEnabled = True
        cboYearLevel.Location = New Point(20, 49)
        cboYearLevel.Margin = New Padding(20, 10, 3, 0)
        cboYearLevel.Name = "cboYearLevel"
        cboYearLevel.Size = New Size(249, 27)
        cboYearLevel.TabIndex = 20
        ' 
        ' FlowLayoutPanel10
        ' 
        FlowLayoutPanel10.Controls.Add(Label9)
        FlowLayoutPanel10.Controls.Add(txtSection)
        FlowLayoutPanel10.Dock = DockStyle.Fill
        FlowLayoutPanel10.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel10.Location = New Point(316, 10)
        FlowLayoutPanel10.Margin = New Padding(10)
        FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        FlowLayoutPanel10.Size = New Size(286, 101)
        FlowLayoutPanel10.TabIndex = 28
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label9.Location = New Point(15, 20)
        Label9.Margin = New Padding(15, 20, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 19)
        Label9.TabIndex = 8
        Label9.Text = "Section:"
        ' 
        ' txtSection
        ' 
        txtSection.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSection.Location = New Point(20, 49)
        txtSection.Margin = New Padding(20, 10, 3, 0)
        txtSection.Name = "txtSection"
        txtSection.Size = New Size(249, 27)
        txtSection.TabIndex = 23
        ' 
        ' FlowLayoutPanel11
        ' 
        FlowLayoutPanel11.Controls.Add(Label8)
        FlowLayoutPanel11.Controls.Add(cboCourse)
        FlowLayoutPanel11.Dock = DockStyle.Fill
        FlowLayoutPanel11.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel11.Location = New Point(622, 10)
        FlowLayoutPanel11.Margin = New Padding(10)
        FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        FlowLayoutPanel11.Size = New Size(289, 101)
        FlowLayoutPanel11.TabIndex = 28
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label8.Location = New Point(15, 20)
        Label8.Margin = New Padding(15, 20, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 19)
        Label8.TabIndex = 7
        Label8.Text = "Course:"
        ' 
        ' cboCourse
        ' 
        cboCourse.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(20, 49)
        cboCourse.Margin = New Padding(20, 10, 3, 0)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(249, 27)
        cboCourse.TabIndex = 21
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(FlowLayoutPanel3, 0, 0)
        TableLayoutPanel3.Controls.Add(FlowLayoutPanel4, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(3, 395)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(921, 149)
        TableLayoutPanel3.TabIndex = 31
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Controls.Add(Label10)
        FlowLayoutPanel3.Controls.Add(Label12)
        FlowLayoutPanel3.Controls.Add(txtContactNumber)
        FlowLayoutPanel3.Dock = DockStyle.Fill
        FlowLayoutPanel3.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel3.Location = New Point(20, 15)
        FlowLayoutPanel3.Margin = New Padding(20, 15, 15, 15)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(425, 119)
        FlowLayoutPanel3.TabIndex = 14
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 15.75F)
        Label10.Location = New Point(15, 10)
        Label10.Margin = New Padding(15, 10, 3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(200, 25)
        Label10.TabIndex = 9
        Label10.Text = "Contact Information"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(20, 50)
        Label12.Margin = New Padding(20, 15, 3, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(116, 16)
        Label12.TabIndex = 11
        Label12.Text = "Contact Number:"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Font = New Font("Tahoma", 14.25F)
        txtContactNumber.Location = New Point(20, 76)
        txtContactNumber.Margin = New Padding(20, 10, 3, 0)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(308, 30)
        txtContactNumber.TabIndex = 16
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Controls.Add(Label11)
        FlowLayoutPanel4.Controls.Add(txtLRN)
        FlowLayoutPanel4.Dock = DockStyle.Fill
        FlowLayoutPanel4.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel4.Location = New Point(480, 15)
        FlowLayoutPanel4.Margin = New Padding(20, 15, 15, 15)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(426, 119)
        FlowLayoutPanel4.TabIndex = 15
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 15.75F)
        Label11.Location = New Point(15, 10)
        Label11.Margin = New Padding(15, 10, 3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(266, 25)
        Label11.TabIndex = 10
        Label11.Text = "Learner Reference Number"
        ' 
        ' txtLRN
        ' 
        txtLRN.Font = New Font("Tahoma", 14.25F)
        txtLRN.Location = New Point(20, 75)
        txtLRN.Margin = New Padding(20, 40, 3, 0)
        txtLRN.Name = "txtLRN"
        txtLRN.Size = New Size(308, 30)
        txtLRN.TabIndex = 17
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Controls.Add(Label6)
        FlowLayoutPanel5.Dock = DockStyle.Bottom
        FlowLayoutPanel5.Location = New Point(3, 223)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Size = New Size(921, 39)
        FlowLayoutPanel5.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 15.75F)
        Label6.Location = New Point(15, 10)
        Label6.Margin = New Padding(15, 10, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(302, 25)
        Label6.TabIndex = 5
        Label6.Text = "Year Level, Course and Section"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel6, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel8, 1, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel7, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 105)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(921, 112)
        TableLayoutPanel1.TabIndex = 29
        ' 
        ' FlowLayoutPanel6
        ' 
        FlowLayoutPanel6.Controls.Add(Label4)
        FlowLayoutPanel6.Controls.Add(txtLastName)
        FlowLayoutPanel6.Dock = DockStyle.Fill
        FlowLayoutPanel6.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel6.Location = New Point(10, 10)
        FlowLayoutPanel6.Margin = New Padding(10)
        FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        FlowLayoutPanel6.Size = New Size(286, 92)
        FlowLayoutPanel6.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label4.Location = New Point(15, 20)
        Label4.Margin = New Padding(15, 20, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 19)
        Label4.TabIndex = 3
        Label4.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.Location = New Point(20, 49)
        txtLastName.Margin = New Padding(20, 10, 3, 0)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(249, 27)
        txtLastName.TabIndex = 22
        ' 
        ' FlowLayoutPanel8
        ' 
        FlowLayoutPanel8.Controls.Add(Label3)
        FlowLayoutPanel8.Controls.Add(txtFirstName)
        FlowLayoutPanel8.Dock = DockStyle.Fill
        FlowLayoutPanel8.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel8.Location = New Point(316, 10)
        FlowLayoutPanel8.Margin = New Padding(10)
        FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        FlowLayoutPanel8.Size = New Size(286, 92)
        FlowLayoutPanel8.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label3.Location = New Point(15, 20)
        Label3.Margin = New Padding(15, 20, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 19)
        Label3.TabIndex = 2
        Label3.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstName.Location = New Point(20, 49)
        txtFirstName.Margin = New Padding(20, 10, 3, 0)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(249, 27)
        txtFirstName.TabIndex = 18
        ' 
        ' FlowLayoutPanel7
        ' 
        FlowLayoutPanel7.Controls.Add(Label5)
        FlowLayoutPanel7.Controls.Add(txtMiddleName)
        FlowLayoutPanel7.Dock = DockStyle.Fill
        FlowLayoutPanel7.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel7.Location = New Point(622, 10)
        FlowLayoutPanel7.Margin = New Padding(10)
        FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        FlowLayoutPanel7.Size = New Size(289, 92)
        FlowLayoutPanel7.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label5.Location = New Point(15, 20)
        Label5.Margin = New Padding(15, 20, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 19)
        Label5.TabIndex = 4
        Label5.Text = "Middle Name"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMiddleName.Location = New Point(20, 49)
        txtMiddleName.Margin = New Padding(20, 10, 3, 0)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(249, 27)
        txtMiddleName.TabIndex = 19
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label2)
        FlowLayoutPanel2.Dock = DockStyle.Bottom
        FlowLayoutPanel2.Location = New Point(3, 59)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(921, 40)
        FlowLayoutPanel2.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 15.75F)
        Label2.Location = New Point(15, 10)
        Label2.Margin = New Padding(15, 10, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 25)
        Label2.TabIndex = 1
        Label2.Text = "Student Full Name"
        ' 
        ' frmAddStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(TableLayoutPanel4)
        Name = "frmAddStudent"
        Text = "frmAddStudent"
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel9.ResumeLayout(False)
        FlowLayoutPanel9.PerformLayout()
        FlowLayoutPanel10.ResumeLayout(False)
        FlowLayoutPanel10.PerformLayout()
        FlowLayoutPanel11.ResumeLayout(False)
        FlowLayoutPanel11.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        FlowLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel5.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel6.ResumeLayout(False)
        FlowLayoutPanel6.PerformLayout()
        FlowLayoutPanel8.ResumeLayout(False)
        FlowLayoutPanel8.PerformLayout()
        FlowLayoutPanel7.ResumeLayout(False)
        FlowLayoutPanel7.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSection As TextBox
    Friend WithEvents FlowLayoutPanel11 As FlowLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLRN As TextBox
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
