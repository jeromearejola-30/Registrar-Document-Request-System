<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditStudent
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        txtContactNumber = New TextBox()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        cboStudentStatus = New ComboBox()
        txtFirstName = New TextBox()
        txtMiddleName = New TextBox()
        cboYearLevel = New ComboBox()
        cboCourse = New ComboBox()
        txtLastName = New TextBox()
        txtSection = New TextBox()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        FlowLayoutPanel6 = New FlowLayoutPanel()
        FlowLayoutPanel7 = New FlowLayoutPanel()
        FlowLayoutPanel8 = New FlowLayoutPanel()
        FlowLayoutPanel9 = New FlowLayoutPanel()
        FlowLayoutPanel10 = New FlowLayoutPanel()
        FlowLayoutPanel11 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        FlowLayoutPanel12 = New FlowLayoutPanel()
        btnSaveEdit = New Button()
        btnCancel = New Button()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel5.SuspendLayout()
        FlowLayoutPanel6.SuspendLayout()
        FlowLayoutPanel7.SuspendLayout()
        FlowLayoutPanel8.SuspendLayout()
        FlowLayoutPanel9.SuspendLayout()
        FlowLayoutPanel10.SuspendLayout()
        FlowLayoutPanel11.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        FlowLayoutPanel12.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 5)
        Label1.Margin = New Padding(15, 5, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(273, 29)
        Label1.TabIndex = 0
        Label1.Text = "Edit Student Information"
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
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 15.75F)
        Label11.Location = New Point(15, 10)
        Label11.Margin = New Padding(15, 10, 3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(222, 25)
        Label11.TabIndex = 10
        Label11.Text = "Student Record Status"
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label1)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(3, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(921, 41)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label2)
        FlowLayoutPanel2.Dock = DockStyle.Bottom
        FlowLayoutPanel2.Location = New Point(3, 61)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(921, 38)
        FlowLayoutPanel2.TabIndex = 13
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
        FlowLayoutPanel3.Size = New Size(425, 124)
        FlowLayoutPanel3.TabIndex = 14
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
        FlowLayoutPanel4.Controls.Add(cboStudentStatus)
        FlowLayoutPanel4.Dock = DockStyle.Fill
        FlowLayoutPanel4.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel4.Location = New Point(480, 15)
        FlowLayoutPanel4.Margin = New Padding(20, 15, 15, 15)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(426, 124)
        FlowLayoutPanel4.TabIndex = 15
        ' 
        ' cboStudentStatus
        ' 
        cboStudentStatus.Font = New Font("Tahoma", 14.25F)
        cboStudentStatus.FormattingEnabled = True
        cboStudentStatus.Location = New Point(20, 75)
        cboStudentStatus.Margin = New Padding(20, 40, 3, 0)
        cboStudentStatus.Name = "cboStudentStatus"
        cboStudentStatus.Size = New Size(308, 31)
        cboStudentStatus.TabIndex = 24
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
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMiddleName.Location = New Point(20, 49)
        txtMiddleName.Margin = New Padding(20, 10, 3, 0)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(249, 27)
        txtMiddleName.TabIndex = 19
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
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.Location = New Point(20, 49)
        txtLastName.Margin = New Padding(20, 10, 3, 0)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(249, 27)
        txtLastName.TabIndex = 22
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
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Controls.Add(Label6)
        FlowLayoutPanel5.Dock = DockStyle.Bottom
        FlowLayoutPanel5.Location = New Point(3, 224)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Size = New Size(921, 44)
        FlowLayoutPanel5.TabIndex = 14
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
        FlowLayoutPanel6.Size = New Size(286, 93)
        FlowLayoutPanel6.TabIndex = 24
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
        FlowLayoutPanel7.Size = New Size(289, 93)
        FlowLayoutPanel7.TabIndex = 25
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
        FlowLayoutPanel8.Size = New Size(286, 93)
        FlowLayoutPanel8.TabIndex = 26
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
        FlowLayoutPanel9.Size = New Size(286, 103)
        FlowLayoutPanel9.TabIndex = 27
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
        FlowLayoutPanel10.Size = New Size(286, 103)
        FlowLayoutPanel10.TabIndex = 28
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
        FlowLayoutPanel11.Size = New Size(289, 103)
        FlowLayoutPanel11.TabIndex = 28
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
        TableLayoutPanel1.Size = New Size(921, 113)
        TableLayoutPanel1.TabIndex = 29
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
        TableLayoutPanel2.Location = New Point(3, 274)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(921, 123)
        TableLayoutPanel2.TabIndex = 30
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(FlowLayoutPanel3, 0, 0)
        TableLayoutPanel3.Controls.Add(FlowLayoutPanel4, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(3, 403)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(921, 154)
        TableLayoutPanel3.TabIndex = 31
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(FlowLayoutPanel12, 0, 6)
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
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 56.8627434F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 43.1372566F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 119F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 129F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 160F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 62F))
        TableLayoutPanel4.Size = New Size(927, 622)
        TableLayoutPanel4.TabIndex = 32
        ' 
        ' FlowLayoutPanel12
        ' 
        FlowLayoutPanel12.Controls.Add(btnSaveEdit)
        FlowLayoutPanel12.Controls.Add(btnCancel)
        FlowLayoutPanel12.Dock = DockStyle.Bottom
        FlowLayoutPanel12.Location = New Point(3, 563)
        FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        FlowLayoutPanel12.Size = New Size(921, 56)
        FlowLayoutPanel12.TabIndex = 35
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.Font = New Font("Tahoma", 14.25F)
        btnSaveEdit.Location = New Point(10, 10)
        btnSaveEdit.Margin = New Padding(10, 10, 3, 10)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(141, 44)
        btnSaveEdit.TabIndex = 33
        btnSaveEdit.Text = "Save Edit"
        btnSaveEdit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Tahoma", 14.25F)
        btnCancel.Location = New Point(164, 10)
        btnCancel.Margin = New Padding(10, 10, 3, 10)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(141, 44)
        btnCancel.TabIndex = 34
        btnCancel.Text = "Cancel Edit"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmEditStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(TableLayoutPanel4)
        Name = "frmEditStudent"
        Text = "frmEditStudent"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        FlowLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel5.PerformLayout()
        FlowLayoutPanel6.ResumeLayout(False)
        FlowLayoutPanel6.PerformLayout()
        FlowLayoutPanel7.ResumeLayout(False)
        FlowLayoutPanel7.PerformLayout()
        FlowLayoutPanel8.ResumeLayout(False)
        FlowLayoutPanel8.PerformLayout()
        FlowLayoutPanel9.ResumeLayout(False)
        FlowLayoutPanel9.PerformLayout()
        FlowLayoutPanel10.ResumeLayout(False)
        FlowLayoutPanel10.PerformLayout()
        FlowLayoutPanel11.ResumeLayout(False)
        FlowLayoutPanel11.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel12.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtSection As TextBox
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel11 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents cboStudentStatus As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents FlowLayoutPanel12 As FlowLayoutPanel
End Class
