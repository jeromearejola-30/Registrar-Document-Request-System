<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddStudent
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
        lblSecId = New Label()
        tlpId = New TableLayoutPanel()
        lblCapStudentID = New Label()
        txtStudentID = New TextBox()
        lblCapLRN = New Label()
        txtLRN = New TextBox()
        lblSecName = New Label()
        tlpName = New TableLayoutPanel()
        lblCapLastName = New Label()
        txtLastName = New TextBox()
        lblCapFirstName = New Label()
        txtFirstName = New TextBox()
        lblCapMiddleName = New Label()
        txtMiddleName = New TextBox()
        lblSecAcademic = New Label()
        tlpAcademic = New TableLayoutPanel()
        lblCapYearLevel = New Label()
        cboYearLevel = New ComboBox()
        lblCapCourse = New Label()
        cboCourse = New ComboBox()
        lblCapSection = New Label()
        txtSection = New TextBox()
        lblSecContact = New Label()
        tlpContact = New TableLayoutPanel()
        lblCapContact = New Label()
        txtContactNumber = New TextBox()
        btnSaveEdit = New ThemedButton()
        btnClear = New ThemedButton()
        btnCancel = New ThemedButton()
        flpButtons = New FlowLayoutPanel()
        tlpForm = New TableLayoutPanel()
        cardForm = New CardPanel()
        tlpId.SuspendLayout()
        tlpName.SuspendLayout()
        tlpAcademic.SuspendLayout()
        tlpContact.SuspendLayout()
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
        lblSubtitle.Location = New Point(0, 0)
        lblSubtitle.Margin = New Padding(0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(178, 17)
        lblSubtitle.TabIndex = 0
        lblSubtitle.Text = "Fields marked * are required."
        ' 
        ' lblSecId
        ' 
        lblSecId.AutoSize = True
        lblSecId.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecId.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecId.Location = New Point(0, 31)
        lblSecId.Margin = New Padding(0, 14, 0, 8)
        lblSecId.Name = "lblSecId"
        lblSecId.Size = New Size(170, 21)
        lblSecId.TabIndex = 1
        lblSecId.Text = "Student Identification"
        ' 
        ' tlpId
        ' 
        tlpId.AutoSize = True
        tlpId.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpId.ColumnCount = 2
        tlpId.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpId.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpId.Controls.Add(lblCapStudentID, 0, 0)
        tlpId.Controls.Add(txtStudentID, 0, 1)
        tlpId.Controls.Add(lblCapLRN, 1, 0)
        tlpId.Controls.Add(txtLRN, 1, 1)
        tlpId.Dock = DockStyle.Fill
        tlpId.Location = New Point(0, 60)
        tlpId.Margin = New Padding(0)
        tlpId.Name = "tlpId"
        tlpId.RowCount = 2
        tlpId.RowStyles.Add(New RowStyle())
        tlpId.RowStyles.Add(New RowStyle())
        tlpId.Size = New Size(896, 47)
        tlpId.TabIndex = 2
        ' 
        ' lblCapStudentID
        ' 
        lblCapStudentID.AutoSize = True
        lblCapStudentID.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapStudentID.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapStudentID.Location = New Point(0, 0)
        lblCapStudentID.Margin = New Padding(0, 0, 0, 4)
        lblCapStudentID.Name = "lblCapStudentID"
        lblCapStudentID.Size = New Size(120, 17)
        lblCapStudentID.TabIndex = 3
        lblCapStudentID.Text = "Student Number *"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtStudentID.BorderStyle = BorderStyle.FixedSingle
        txtStudentID.Font = New Font("Segoe UI", 10.5F)
        txtStudentID.Location = New Point(0, 21)
        txtStudentID.Margin = New Padding(0, 0, 16, 0)
        txtStudentID.MaxLength = 20
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(432, 26)
        txtStudentID.TabIndex = 4
        ' 
        ' lblCapLRN
        ' 
        lblCapLRN.AutoSize = True
        lblCapLRN.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapLRN.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapLRN.Location = New Point(448, 0)
        lblCapLRN.Margin = New Padding(0, 0, 0, 4)
        lblCapLRN.Name = "lblCapLRN"
        lblCapLRN.Size = New Size(42, 17)
        lblCapLRN.TabIndex = 5
        lblCapLRN.Text = "LRN *"
        ' 
        ' txtLRN
        ' 
        txtLRN.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtLRN.BorderStyle = BorderStyle.FixedSingle
        txtLRN.Font = New Font("Segoe UI", 10.5F)
        txtLRN.Location = New Point(448, 21)
        txtLRN.Margin = New Padding(0)
        txtLRN.MaxLength = 12
        txtLRN.Name = "txtLRN"
        txtLRN.Size = New Size(448, 26)
        txtLRN.TabIndex = 6
        ' 
        ' lblSecName
        ' 
        lblSecName.AutoSize = True
        lblSecName.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecName.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecName.Location = New Point(0, 129)
        lblSecName.Margin = New Padding(0, 22, 0, 8)
        lblSecName.Name = "lblSecName"
        lblSecName.Size = New Size(82, 21)
        lblSecName.TabIndex = 7
        lblSecName.Text = "Full Name"
        ' 
        ' tlpName
        ' 
        tlpName.AutoSize = True
        tlpName.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpName.ColumnCount = 3
        tlpName.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333F))
        tlpName.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333F))
        tlpName.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333F))
        tlpName.Controls.Add(lblCapLastName, 0, 0)
        tlpName.Controls.Add(txtLastName, 0, 1)
        tlpName.Controls.Add(lblCapFirstName, 1, 0)
        tlpName.Controls.Add(txtFirstName, 1, 1)
        tlpName.Controls.Add(lblCapMiddleName, 2, 0)
        tlpName.Controls.Add(txtMiddleName, 2, 1)
        tlpName.Dock = DockStyle.Fill
        tlpName.Location = New Point(0, 158)
        tlpName.Margin = New Padding(0)
        tlpName.Name = "tlpName"
        tlpName.RowCount = 2
        tlpName.RowStyles.Add(New RowStyle())
        tlpName.RowStyles.Add(New RowStyle())
        tlpName.Size = New Size(896, 47)
        tlpName.TabIndex = 8
        ' 
        ' lblCapLastName
        ' 
        lblCapLastName.AutoSize = True
        lblCapLastName.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapLastName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapLastName.Location = New Point(0, 0)
        lblCapLastName.Margin = New Padding(0, 0, 0, 4)
        lblCapLastName.Name = "lblCapLastName"
        lblCapLastName.Size = New Size(82, 17)
        lblCapLastName.TabIndex = 9
        lblCapLastName.Text = "Last Name *"
        ' 
        ' txtLastName
        ' 
        txtLastName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Font = New Font("Segoe UI", 10.5F)
        txtLastName.Location = New Point(0, 21)
        txtLastName.Margin = New Padding(0, 0, 16, 0)
        txtLastName.MaxLength = 50
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(282, 26)
        txtLastName.TabIndex = 10
        ' 
        ' lblCapFirstName
        ' 
        lblCapFirstName.AutoSize = True
        lblCapFirstName.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapFirstName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapFirstName.Location = New Point(298, 0)
        lblCapFirstName.Margin = New Padding(0, 0, 0, 4)
        lblCapFirstName.Name = "lblCapFirstName"
        lblCapFirstName.Size = New Size(84, 17)
        lblCapFirstName.TabIndex = 11
        lblCapFirstName.Text = "First Name *"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Font = New Font("Segoe UI", 10.5F)
        txtFirstName.Location = New Point(298, 21)
        txtFirstName.Margin = New Padding(0, 0, 16, 0)
        txtFirstName.MaxLength = 50
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(282, 26)
        txtFirstName.TabIndex = 12
        ' 
        ' lblCapMiddleName
        ' 
        lblCapMiddleName.AutoSize = True
        lblCapMiddleName.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapMiddleName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapMiddleName.Location = New Point(596, 0)
        lblCapMiddleName.Margin = New Padding(0, 0, 0, 4)
        lblCapMiddleName.Name = "lblCapMiddleName"
        lblCapMiddleName.Size = New Size(89, 17)
        lblCapMiddleName.TabIndex = 13
        lblCapMiddleName.Text = "Middle Name"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtMiddleName.BorderStyle = BorderStyle.FixedSingle
        txtMiddleName.Font = New Font("Segoe UI", 10.5F)
        txtMiddleName.Location = New Point(596, 21)
        txtMiddleName.Margin = New Padding(0)
        txtMiddleName.MaxLength = 50
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(300, 26)
        txtMiddleName.TabIndex = 14
        ' 
        ' lblSecAcademic
        ' 
        lblSecAcademic.AutoSize = True
        lblSecAcademic.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecAcademic.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecAcademic.Location = New Point(0, 227)
        lblSecAcademic.Margin = New Padding(0, 22, 0, 8)
        lblSecAcademic.Name = "lblSecAcademic"
        lblSecAcademic.Size = New Size(173, 21)
        lblSecAcademic.TabIndex = 15
        lblSecAcademic.Text = "Academic Information"
        ' 
        ' tlpAcademic
        ' 
        tlpAcademic.AutoSize = True
        tlpAcademic.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpAcademic.ColumnCount = 3
        tlpAcademic.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333F))
        tlpAcademic.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333F))
        tlpAcademic.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333F))
        tlpAcademic.Controls.Add(lblCapYearLevel, 0, 0)
        tlpAcademic.Controls.Add(cboYearLevel, 0, 1)
        tlpAcademic.Controls.Add(lblCapCourse, 1, 0)
        tlpAcademic.Controls.Add(cboCourse, 1, 1)
        tlpAcademic.Controls.Add(lblCapSection, 2, 0)
        tlpAcademic.Controls.Add(txtSection, 2, 1)
        tlpAcademic.Dock = DockStyle.Fill
        tlpAcademic.Location = New Point(0, 256)
        tlpAcademic.Margin = New Padding(0)
        tlpAcademic.Name = "tlpAcademic"
        tlpAcademic.RowCount = 2
        tlpAcademic.RowStyles.Add(New RowStyle())
        tlpAcademic.RowStyles.Add(New RowStyle())
        tlpAcademic.Size = New Size(896, 47)
        tlpAcademic.TabIndex = 16
        ' 
        ' lblCapYearLevel
        ' 
        lblCapYearLevel.AutoSize = True
        lblCapYearLevel.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapYearLevel.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapYearLevel.Location = New Point(0, 0)
        lblCapYearLevel.Margin = New Padding(0, 0, 0, 4)
        lblCapYearLevel.Name = "lblCapYearLevel"
        lblCapYearLevel.Size = New Size(78, 17)
        lblCapYearLevel.TabIndex = 17
        lblCapYearLevel.Text = "Year Level *"
        ' 
        ' cboYearLevel
        ' 
        cboYearLevel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboYearLevel.Font = New Font("Segoe UI", 10.5F)
        cboYearLevel.FormattingEnabled = True
        cboYearLevel.Location = New Point(0, 22)
        cboYearLevel.Margin = New Padding(0, 0, 16, 0)
        cboYearLevel.Name = "cboYearLevel"
        cboYearLevel.Size = New Size(282, 27)
        cboYearLevel.TabIndex = 18
        ' 
        ' lblCapCourse
        ' 
        lblCapCourse.AutoSize = True
        lblCapCourse.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapCourse.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapCourse.Location = New Point(298, 0)
        lblCapCourse.Margin = New Padding(0, 0, 0, 4)
        lblCapCourse.Name = "lblCapCourse"
        lblCapCourse.Size = New Size(60, 17)
        lblCapCourse.TabIndex = 19
        lblCapCourse.Text = "Course *"
        ' 
        ' cboCourse
        ' 
        cboCourse.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourse.Font = New Font("Segoe UI", 10.5F)
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(298, 22)
        cboCourse.Margin = New Padding(0, 0, 16, 0)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(282, 27)
        cboCourse.TabIndex = 20
        ' 
        ' lblCapSection
        ' 
        lblCapSection.AutoSize = True
        lblCapSection.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapSection.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapSection.Location = New Point(596, 0)
        lblCapSection.Margin = New Padding(0, 0, 0, 4)
        lblCapSection.Name = "lblCapSection"
        lblCapSection.Size = New Size(52, 17)
        lblCapSection.TabIndex = 21
        lblCapSection.Text = "Section"
        ' 
        ' txtSection
        ' 
        txtSection.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSection.BorderStyle = BorderStyle.FixedSingle
        txtSection.Font = New Font("Segoe UI", 10.5F)
        txtSection.Location = New Point(596, 21)
        txtSection.Margin = New Padding(0)
        txtSection.MaxLength = 20
        txtSection.Name = "txtSection"
        txtSection.Size = New Size(300, 26)
        txtSection.TabIndex = 22
        ' 
        ' lblSecContact
        ' 
        lblSecContact.AutoSize = True
        lblSecContact.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecContact.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecContact.Location = New Point(0, 325)
        lblSecContact.Margin = New Padding(0, 22, 0, 8)
        lblSecContact.Name = "lblSecContact"
        lblSecContact.Size = New Size(158, 21)
        lblSecContact.TabIndex = 23
        lblSecContact.Text = "Contact Information"
        ' 
        ' tlpContact
        ' 
        tlpContact.AutoSize = True
        tlpContact.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpContact.ColumnCount = 2
        tlpContact.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpContact.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpContact.Controls.Add(lblCapContact, 0, 0)
        tlpContact.Controls.Add(txtContactNumber, 0, 1)
        tlpContact.Dock = DockStyle.Fill
        tlpContact.Location = New Point(0, 354)
        tlpContact.Margin = New Padding(0)
        tlpContact.Name = "tlpContact"
        tlpContact.RowCount = 2
        tlpContact.RowStyles.Add(New RowStyle())
        tlpContact.RowStyles.Add(New RowStyle())
        tlpContact.Size = New Size(896, 47)
        tlpContact.TabIndex = 24
        ' 
        ' lblCapContact
        ' 
        lblCapContact.AutoSize = True
        lblCapContact.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapContact.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapContact.Location = New Point(0, 0)
        lblCapContact.Margin = New Padding(0, 0, 0, 4)
        lblCapContact.Name = "lblCapContact"
        lblCapContact.Size = New Size(109, 17)
        lblCapContact.TabIndex = 25
        lblCapContact.Text = "Contact Number"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtContactNumber.BorderStyle = BorderStyle.FixedSingle
        txtContactNumber.Font = New Font("Segoe UI", 10.5F)
        txtContactNumber.Location = New Point(0, 21)
        txtContactNumber.Margin = New Padding(0, 0, 16, 0)
        txtContactNumber.MaxLength = 15
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(432, 26)
        txtContactNumber.TabIndex = 26
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.AutoSize = True
        btnSaveEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSaveEdit.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSaveEdit.FlatAppearance.BorderSize = 0
        btnSaveEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSaveEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnSaveEdit.FlatStyle = FlatStyle.Flat
        btnSaveEdit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSaveEdit.ForeColor = Color.White
        btnSaveEdit.Kind = ButtonKind.Primary
        btnSaveEdit.Location = New Point(762, 0)
        btnSaveEdit.Margin = New Padding(10, 0, 0, 0)
        btnSaveEdit.MinimumSize = New Size(120, 40)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Padding = New Padding(14, 0, 14, 0)
        btnSaveEdit.Size = New Size(134, 40)
        btnSaveEdit.TabIndex = 27
        btnSaveEdit.Text = "Save Student"
        btnSaveEdit.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.AutoSize = True
        btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClear.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClear.Location = New Point(632, 0)
        btnClear.Margin = New Padding(10, 0, 0, 0)
        btnClear.MinimumSize = New Size(120, 40)
        btnClear.Name = "btnClear"
        btnClear.Padding = New Padding(14, 0, 14, 0)
        btnClear.Size = New Size(120, 40)
        btnClear.TabIndex = 28
        btnClear.Text = "Clear All"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.AutoSize = True
        btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCancel.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCancel.Location = New Point(502, 0)
        btnCancel.Margin = New Padding(10, 0, 0, 0)
        btnCancel.MinimumSize = New Size(120, 40)
        btnCancel.Name = "btnCancel"
        btnCancel.Padding = New Padding(14, 0, 14, 0)
        btnCancel.Size = New Size(120, 40)
        btnCancel.TabIndex = 29
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' flpButtons
        ' 
        flpButtons.AutoSize = True
        flpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpButtons.Controls.Add(btnSaveEdit)
        flpButtons.Controls.Add(btnClear)
        flpButtons.Controls.Add(btnCancel)
        flpButtons.Dock = DockStyle.Fill
        flpButtons.FlowDirection = FlowDirection.RightToLeft
        flpButtons.Location = New Point(0, 429)
        flpButtons.Margin = New Padding(0, 28, 0, 0)
        flpButtons.Name = "flpButtons"
        flpButtons.Size = New Size(896, 71)
        flpButtons.TabIndex = 30
        flpButtons.WrapContents = False
        ' 
        ' tlpForm
        ' 
        tlpForm.ColumnCount = 1
        tlpForm.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpForm.Controls.Add(lblSubtitle, 0, 0)
        tlpForm.Controls.Add(lblSecId, 0, 1)
        tlpForm.Controls.Add(tlpId, 0, 2)
        tlpForm.Controls.Add(lblSecName, 0, 3)
        tlpForm.Controls.Add(tlpName, 0, 4)
        tlpForm.Controls.Add(lblSecAcademic, 0, 5)
        tlpForm.Controls.Add(tlpAcademic, 0, 6)
        tlpForm.Controls.Add(lblSecContact, 0, 7)
        tlpForm.Controls.Add(tlpContact, 0, 8)
        tlpForm.Controls.Add(flpButtons, 0, 9)
        tlpForm.Dock = DockStyle.Fill
        tlpForm.Location = New Point(32, 28)
        tlpForm.Margin = New Padding(0)
        tlpForm.Name = "tlpForm"
        tlpForm.RowCount = 10
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.Size = New Size(896, 500)
        tlpForm.TabIndex = 31
        ' 
        ' cardForm
        ' 
        cardForm.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cardForm.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cardForm.Controls.Add(tlpForm)
        cardForm.Location = New Point(28, 24)
        cardForm.Name = "cardForm"
        cardForm.Padding = New Padding(32, 28, 32, 32)
        cardForm.Size = New Size(960, 560)
        cardForm.TabIndex = 32
        ' 
        ' frmAddStudent
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 700)
        Controls.Add(cardForm)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAddStudent"
        Text = "Add Student"
        tlpId.ResumeLayout(False)
        tlpId.PerformLayout()
        tlpName.ResumeLayout(False)
        tlpName.PerformLayout()
        tlpAcademic.ResumeLayout(False)
        tlpAcademic.PerformLayout()
        tlpContact.ResumeLayout(False)
        tlpContact.PerformLayout()
        flpButtons.ResumeLayout(False)
        flpButtons.PerformLayout()
        tlpForm.ResumeLayout(False)
        tlpForm.PerformLayout()
        cardForm.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblSecId As Label
    Friend WithEvents tlpId As TableLayoutPanel
    Friend WithEvents lblCapStudentID As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents lblCapLRN As Label
    Friend WithEvents txtLRN As TextBox
    Friend WithEvents lblSecName As Label
    Friend WithEvents tlpName As TableLayoutPanel
    Friend WithEvents lblCapLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblCapFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblCapMiddleName As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents lblSecAcademic As Label
    Friend WithEvents tlpAcademic As TableLayoutPanel
    Friend WithEvents lblCapYearLevel As Label
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents lblCapCourse As Label
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents lblCapSection As Label
    Friend WithEvents txtSection As TextBox
    Friend WithEvents lblSecContact As Label
    Friend WithEvents tlpContact As TableLayoutPanel
    Friend WithEvents lblCapContact As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents btnSaveEdit As ThemedButton
    Friend WithEvents btnClear As ThemedButton
    Friend WithEvents btnCancel As ThemedButton
    Friend WithEvents flpButtons As FlowLayoutPanel
    Friend WithEvents tlpForm As TableLayoutPanel
    Friend WithEvents cardForm As CardPanel
End Class
