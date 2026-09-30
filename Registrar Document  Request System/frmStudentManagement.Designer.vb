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
        dgvStudents = New DataGridView()
        cboStatus = New ComboBox()
        txtContactNo = New TextBox()
        txtStudentID = New TextBox()
        txtLRN = New TextBox()
        txtCourse = New TextBox()
        txtSection = New TextBox()
        txtYearLevel = New TextBox()
        txtMiddleName = New TextBox()
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        lblStudentID = New Label()
        lblLRN = New Label()
        lblLastName = New Label()
        lblFirstName = New Label()
        lblMiddleName = New Label()
        lblCourse = New Label()
        lblYearLevel = New Label()
        lblSection = New Label()
        lblContactNo = New Label()
        lblStatus = New Label()
        LblStudentInformation = New Label()
        txtSearch = New TextBox()
        lblSearch = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDeactivate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.BackgroundColor = SystemColors.Control
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(24, 94)
        dgvStudents.Margin = New Padding(3, 2, 3, 2)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.Size = New Size(865, 275)
        dgvStudents.TabIndex = 0
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboStatus.Location = New Point(657, 664)
        cboStatus.Margin = New Padding(3, 2, 3, 2)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(110, 23)
        cboStatus.TabIndex = 1
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(657, 639)
        txtContactNo.Margin = New Padding(3, 2, 3, 2)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(110, 23)
        txtContactNo.TabIndex = 2
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(657, 440)
        txtStudentID.Margin = New Padding(3, 2, 3, 2)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(110, 23)
        txtStudentID.TabIndex = 3
        ' 
        ' txtLRN
        ' 
        txtLRN.Location = New Point(657, 466)
        txtLRN.Margin = New Padding(3, 2, 3, 2)
        txtLRN.Name = "txtLRN"
        txtLRN.Size = New Size(110, 23)
        txtLRN.TabIndex = 4
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(657, 565)
        txtCourse.Margin = New Padding(3, 2, 3, 2)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(110, 23)
        txtCourse.TabIndex = 5
        ' 
        ' txtSection
        ' 
        txtSection.Location = New Point(657, 614)
        txtSection.Margin = New Padding(3, 2, 3, 2)
        txtSection.Name = "txtSection"
        txtSection.Size = New Size(110, 23)
        txtSection.TabIndex = 6
        ' 
        ' txtYearLevel
        ' 
        txtYearLevel.Location = New Point(657, 590)
        txtYearLevel.Margin = New Padding(3, 2, 3, 2)
        txtYearLevel.Name = "txtYearLevel"
        txtYearLevel.Size = New Size(110, 23)
        txtYearLevel.TabIndex = 7
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(657, 540)
        txtMiddleName.Margin = New Padding(3, 2, 3, 2)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(110, 23)
        txtMiddleName.TabIndex = 8
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(657, 491)
        txtLastName.Margin = New Padding(3, 2, 3, 2)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(110, 23)
        txtLastName.TabIndex = 9
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(657, 516)
        txtFirstName.Margin = New Padding(3, 2, 3, 2)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(110, 23)
        txtFirstName.TabIndex = 10
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Location = New Point(567, 443)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(62, 15)
        lblStudentID.TabIndex = 11
        lblStudentID.Text = "Student ID"
        ' 
        ' lblLRN
        ' 
        lblLRN.AutoSize = True
        lblLRN.Location = New Point(567, 468)
        lblLRN.Name = "lblLRN"
        lblLRN.Size = New Size(29, 15)
        lblLRN.TabIndex = 12
        lblLRN.Text = "LRN"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(567, 493)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(60, 15)
        lblLastName.TabIndex = 13
        lblLastName.Text = "LastName"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(567, 518)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(61, 15)
        lblFirstName.TabIndex = 14
        lblFirstName.Text = "FirstName"
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Location = New Point(567, 542)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(76, 15)
        lblMiddleName.TabIndex = 15
        lblMiddleName.Text = "MiddleName"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(567, 567)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(44, 15)
        lblCourse.TabIndex = 16
        lblCourse.Text = "Course"
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.AutoSize = True
        lblYearLevel.Location = New Point(567, 592)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(56, 15)
        lblYearLevel.TabIndex = 17
        lblYearLevel.Text = "YearLevel"
        ' 
        ' lblSection
        ' 
        lblSection.AutoSize = True
        lblSection.Location = New Point(567, 617)
        lblSection.Name = "lblSection"
        lblSection.Size = New Size(46, 15)
        lblSection.TabIndex = 18
        lblSection.Text = "Section"
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.Location = New Point(567, 642)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(65, 15)
        lblContactNo.TabIndex = 19
        lblContactNo.Text = "ContactNo"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(567, 666)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 15)
        lblStatus.TabIndex = 20
        lblStatus.Text = "Status"
        ' 
        ' LblStudentInformation
        ' 
        LblStudentInformation.AutoSize = True
        LblStudentInformation.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblStudentInformation.Location = New Point(567, 410)
        LblStudentInformation.Name = "LblStudentInformation"
        LblStudentInformation.Size = New Size(199, 21)
        LblStudentInformation.TabIndex = 21
        LblStudentInformation.Text = "STUDENT INFORMATION"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(197, 55)
        txtSearch.Margin = New Padding(3, 2, 3, 2)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(142, 23)
        txtSearch.TabIndex = 22
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(115, 63)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(42, 15)
        lblSearch.TabIndex = 23
        lblSearch.Text = "Search"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(59, 411)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(83, 22)
        btnAdd.TabIndex = 24
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(169, 411)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(83, 22)
        btnUpdate.TabIndex = 25
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDeactivate
        ' 
        btnDeactivate.Location = New Point(286, 411)
        btnDeactivate.Margin = New Padding(3, 2, 3, 2)
        btnDeactivate.Name = "btnDeactivate"
        btnDeactivate.Size = New Size(83, 22)
        btnDeactivate.TabIndex = 26
        btnDeactivate.Text = "Deactivate"
        btnDeactivate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(413, 411)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(83, 22)
        btnDelete.TabIndex = 27
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(684, 704)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(83, 22)
        btnClear.TabIndex = 28
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' frmStudentManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1189, 784)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnDeactivate)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(lblSearch)
        Controls.Add(txtSearch)
        Controls.Add(LblStudentInformation)
        Controls.Add(lblStatus)
        Controls.Add(lblContactNo)
        Controls.Add(lblSection)
        Controls.Add(lblYearLevel)
        Controls.Add(lblCourse)
        Controls.Add(lblMiddleName)
        Controls.Add(lblFirstName)
        Controls.Add(lblLastName)
        Controls.Add(lblLRN)
        Controls.Add(lblStudentID)
        Controls.Add(txtFirstName)
        Controls.Add(txtLastName)
        Controls.Add(txtMiddleName)
        Controls.Add(txtYearLevel)
        Controls.Add(txtSection)
        Controls.Add(txtCourse)
        Controls.Add(txtLRN)
        Controls.Add(txtStudentID)
        Controls.Add(txtContactNo)
        Controls.Add(cboStatus)
        Controls.Add(dgvStudents)
        Name = "frmStudentManagement"
        Text = "StudentRecords"
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtLRN As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtSection As TextBox
    Friend WithEvents txtYearLevel As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblLRN As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblYearLevel As Label
    Friend WithEvents lblSection As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents LblStudentInformation As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDeactivate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
End Class
