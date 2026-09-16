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
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(28, 125)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.Size = New Size(989, 367)
        dgvStudents.TabIndex = 0
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cboStatus.Location = New Point(1148, 464)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(125, 28)
        cboStatus.TabIndex = 1
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(1148, 431)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(125, 27)
        txtContactNo.TabIndex = 2
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(1148, 166)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(125, 27)
        txtStudentID.TabIndex = 3
        ' 
        ' txtLRN
        ' 
        txtLRN.Location = New Point(1148, 200)
        txtLRN.Name = "txtLRN"
        txtLRN.Size = New Size(125, 27)
        txtLRN.TabIndex = 4
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(1148, 332)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(125, 27)
        txtCourse.TabIndex = 5
        ' 
        ' txtSection
        ' 
        txtSection.Location = New Point(1148, 398)
        txtSection.Name = "txtSection"
        txtSection.Size = New Size(125, 27)
        txtSection.TabIndex = 6
        ' 
        ' txtYearLevel
        ' 
        txtYearLevel.Location = New Point(1148, 365)
        txtYearLevel.Name = "txtYearLevel"
        txtYearLevel.Size = New Size(125, 27)
        txtYearLevel.TabIndex = 7
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(1148, 299)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(125, 27)
        txtMiddleName.TabIndex = 8
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(1148, 233)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(125, 27)
        txtLastName.TabIndex = 9
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(1148, 266)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(125, 27)
        txtFirstName.TabIndex = 10
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Location = New Point(1045, 169)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(79, 20)
        lblStudentID.TabIndex = 11
        lblStudentID.Text = "Student ID"
        ' 
        ' lblLRN
        ' 
        lblLRN.AutoSize = True
        lblLRN.Location = New Point(1045, 203)
        lblLRN.Name = "lblLRN"
        lblLRN.Size = New Size(36, 20)
        lblLRN.TabIndex = 12
        lblLRN.Text = "LRN"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(1045, 236)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(75, 20)
        lblLastName.TabIndex = 13
        lblLastName.Text = "LastName"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(1045, 269)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(76, 20)
        lblFirstName.TabIndex = 14
        lblFirstName.Text = "FirstName"
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Location = New Point(1045, 302)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(96, 20)
        lblMiddleName.TabIndex = 15
        lblMiddleName.Text = "MiddleName"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(1045, 335)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(54, 20)
        lblCourse.TabIndex = 16
        lblCourse.Text = "Course"
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.AutoSize = True
        lblYearLevel.Location = New Point(1045, 368)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(71, 20)
        lblYearLevel.TabIndex = 17
        lblYearLevel.Text = "YearLevel"
        ' 
        ' lblSection
        ' 
        lblSection.AutoSize = True
        lblSection.Location = New Point(1045, 401)
        lblSection.Name = "lblSection"
        lblSection.Size = New Size(58, 20)
        lblSection.TabIndex = 18
        lblSection.Text = "Section"
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.Location = New Point(1045, 434)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(80, 20)
        lblContactNo.TabIndex = 19
        lblContactNo.Text = "ContactNo"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(1045, 467)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(49, 20)
        lblStatus.TabIndex = 20
        lblStatus.Text = "Status"
        ' 
        ' LblStudentInformation
        ' 
        LblStudentInformation.AutoSize = True
        LblStudentInformation.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblStudentInformation.Location = New Point(1045, 125)
        LblStudentInformation.Name = "LblStudentInformation"
        LblStudentInformation.Size = New Size(250, 28)
        LblStudentInformation.TabIndex = 21
        LblStudentInformation.Text = "STUDENT INFORMATION"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(91, 92)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(162, 27)
        txtSearch.TabIndex = 22
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(32, 95)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(53, 20)
        lblSearch.TabIndex = 23
        lblSearch.Text = "Search"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(26, 518)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(95, 30)
        btnAdd.TabIndex = 24
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(152, 518)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(95, 30)
        btnUpdate.TabIndex = 25
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDeactivate
        ' 
        btnDeactivate.Location = New Point(286, 518)
        btnDeactivate.Name = "btnDeactivate"
        btnDeactivate.Size = New Size(95, 30)
        btnDeactivate.TabIndex = 26
        btnDeactivate.Text = "Deactivate"
        btnDeactivate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(431, 518)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(95, 30)
        btnDelete.TabIndex = 27
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1178, 518)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(95, 30)
        btnClear.TabIndex = 28
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' frmStudentManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1445, 1015)
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
        Margin = New Padding(3, 4, 3, 4)
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
