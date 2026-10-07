<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateDocumentRequest
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
        lblSearchedStudents = New Label()
        txtSearchStudent = New TextBox()
        btnClearSearch = New Button()
        tlpSearchRow = New TableLayoutPanel()
        dgvStudents = New DataGridView()
        pnlGridBorder = New Panel()
        tlpLeft = New TableLayoutPanel()
        cardStudents = New CardPanel()
        lblSecStudent = New Label()
        lblStudentName = New Label()
        lblStudentDetails = New Label()
        btnChangeStudent = New Button()
        tlpStudent = New TableLayoutPanel()
        pnlStudent = New Panel()
        lblSecRequest = New Label()
        lblCapDocType = New Label()
        cboDocumentType = New ComboBox()
        lblCapCopies = New Label()
        numCopies = New NumericUpDown()
        lblCapDate = New Label()
        dtpRequestDate = New DateTimePicker()
        lblCapPayment = New Label()
        cboPaymentStatus = New ComboBox()
        tlpFields = New TableLayoutPanel()
        lblSecTotal = New Label()
        lblCapFee = New Label()
        lblFeePerCopy = New Label()
        lblCapQty = New Label()
        lblQuantity = New Label()
        lblCapAmount = New Label()
        lblAmountDue = New Label()
        tlpTotal = New TableLayoutPanel()
        pnlTotal = New Panel()
        btnSubmitRequest = New ThemedButton()
        btnCancelRequest = New ThemedButton()
        flpButtons = New FlowLayoutPanel()
        tlpRight = New TableLayoutPanel()
        cardRequest = New CardPanel()
        tlpMain = New TableLayoutPanel()
        tlpSearchRow.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlGridBorder.SuspendLayout()
        tlpLeft.SuspendLayout()
        cardStudents.SuspendLayout()
        tlpStudent.SuspendLayout()
        pnlStudent.SuspendLayout()
        CType(numCopies, ComponentModel.ISupportInitialize).BeginInit()
        tlpFields.SuspendLayout()
        tlpTotal.SuspendLayout()
        pnlTotal.SuspendLayout()
        flpButtons.SuspendLayout()
        tlpRight.SuspendLayout()
        cardRequest.SuspendLayout()
        tlpMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblSearchedStudents
        ' 
        lblSearchedStudents.AutoSize = True
        lblSearchedStudents.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSearchedStudents.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSearchedStudents.Location = New Point(0, 0)
        lblSearchedStudents.Margin = New Padding(0, 0, 0, 10)
        lblSearchedStudents.Name = "lblSearchedStudents"
        lblSearchedStudents.Size = New Size(143, 21)
        lblSearchedStudents.TabIndex = 0
        lblSearchedStudents.Text = "1. Select a Student"
        ' 
        ' txtSearchStudent
        ' 
        txtSearchStudent.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSearchStudent.BorderStyle = BorderStyle.FixedSingle
        txtSearchStudent.Font = New Font("Segoe UI", 11F)
        txtSearchStudent.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        txtSearchStudent.Location = New Point(0, 6)
        txtSearchStudent.Margin = New Padding(0)
        txtSearchStudent.Name = "txtSearchStudent"
        txtSearchStudent.PlaceholderText = "Search by student number, name or course..."
        txtSearchStudent.Size = New Size(344, 27)
        txtSearchStudent.TabIndex = 0
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.AutoSize = True
        btnClearSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClearSearch.BackColor = Color.White
        btnClearSearch.Cursor = Cursors.Hand
        btnClearSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClearSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnClearSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnClearSearch.FlatStyle = FlatStyle.Flat
        btnClearSearch.Font = New Font("Segoe UI Semibold", 10F)
        btnClearSearch.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClearSearch.Location = New Point(352, 0)
        btnClearSearch.Margin = New Padding(8, 0, 0, 0)
        btnClearSearch.MinimumSize = New Size(0, 40)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Padding = New Padding(14, 0, 14, 0)
        btnClearSearch.Size = New Size(127, 40)
        btnClearSearch.TabIndex = 1
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = False
        ' 
        ' tlpSearchRow
        ' 
        tlpSearchRow.AutoSize = True
        tlpSearchRow.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpSearchRow.ColumnCount = 2
        tlpSearchRow.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpSearchRow.ColumnStyles.Add(New ColumnStyle())
        tlpSearchRow.Controls.Add(txtSearchStudent, 0, 0)
        tlpSearchRow.Controls.Add(btnClearSearch, 1, 0)
        tlpSearchRow.Dock = DockStyle.Fill
        tlpSearchRow.Location = New Point(0, 31)
        tlpSearchRow.Margin = New Padding(0, 0, 0, 12)
        tlpSearchRow.Name = "tlpSearchRow"
        tlpSearchRow.RowCount = 1
        tlpSearchRow.RowStyles.Add(New RowStyle())
        tlpSearchRow.Size = New Size(479, 40)
        tlpSearchRow.TabIndex = 1
        ' 
        ' dgvStudents
        ' 
        dgvStudents.Dock = DockStyle.Fill
        dgvStudents.Location = New Point(1, 1)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.Size = New Size(477, 591)
        dgvStudents.TabIndex = 0
        ' 
        ' pnlGridBorder
        ' 
        pnlGridBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlGridBorder.Controls.Add(dgvStudents)
        pnlGridBorder.Dock = DockStyle.Fill
        pnlGridBorder.Location = New Point(0, 83)
        pnlGridBorder.Margin = New Padding(0)
        pnlGridBorder.Name = "pnlGridBorder"
        pnlGridBorder.Padding = New Padding(1)
        pnlGridBorder.Size = New Size(479, 593)
        pnlGridBorder.TabIndex = 2
        ' 
        ' tlpLeft
        ' 
        tlpLeft.ColumnCount = 1
        tlpLeft.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpLeft.Controls.Add(lblSearchedStudents, 0, 0)
        tlpLeft.Controls.Add(tlpSearchRow, 0, 1)
        tlpLeft.Controls.Add(pnlGridBorder, 0, 2)
        tlpLeft.Dock = DockStyle.Fill
        tlpLeft.Location = New Point(24, 20)
        tlpLeft.Margin = New Padding(0)
        tlpLeft.Name = "tlpLeft"
        tlpLeft.RowCount = 3
        tlpLeft.RowStyles.Add(New RowStyle())
        tlpLeft.RowStyles.Add(New RowStyle())
        tlpLeft.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpLeft.Size = New Size(479, 676)
        tlpLeft.TabIndex = 0
        ' 
        ' cardStudents
        ' 
        cardStudents.BackColor = Color.White
        cardStudents.Controls.Add(tlpLeft)
        cardStudents.Dock = DockStyle.Fill
        cardStudents.Location = New Point(28, 20)
        cardStudents.Margin = New Padding(0, 0, 12, 0)
        cardStudents.Name = "cardStudents"
        cardStudents.Padding = New Padding(24, 20, 24, 20)
        cardStudents.Size = New Size(527, 716)
        cardStudents.TabIndex = 0
        ' 
        ' lblSecStudent
        ' 
        lblSecStudent.AutoSize = True
        lblSecStudent.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecStudent.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecStudent.Location = New Point(0, 0)
        lblSecStudent.Margin = New Padding(0, 0, 0, 8)
        lblSecStudent.Name = "lblSecStudent"
        lblSecStudent.Size = New Size(153, 21)
        lblSecStudent.TabIndex = 0
        lblSecStudent.Text = "2. Selected Student"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblStudentName.AutoEllipsis = True
        lblStudentName.Font = New Font("Segoe UI Semibold", 12F)
        lblStudentName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblStudentName.Location = New Point(0, 0)
        lblStudentName.Margin = New Padding(0)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(231, 24)
        lblStudentName.TabIndex = 0
        lblStudentName.Text = "[Select Student Above]"
        ' 
        ' lblStudentDetails
        ' 
        lblStudentDetails.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblStudentDetails.AutoEllipsis = True
        lblStudentDetails.Font = New Font("Segoe UI", 9.5F)
        lblStudentDetails.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblStudentDetails.Location = New Point(0, 24)
        lblStudentDetails.Margin = New Padding(0)
        lblStudentDetails.Name = "lblStudentDetails"
        lblStudentDetails.Size = New Size(231, 20)
        lblStudentDetails.TabIndex = 1
        ' 
        ' btnChangeStudent
        ' 
        btnChangeStudent.Anchor = AnchorStyles.Right
        btnChangeStudent.AutoSize = True
        btnChangeStudent.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnChangeStudent.BackColor = Color.White
        btnChangeStudent.Cursor = Cursors.Hand
        btnChangeStudent.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnChangeStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnChangeStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnChangeStudent.FlatStyle = FlatStyle.Flat
        btnChangeStudent.Font = New Font("Segoe UI Semibold", 10F)
        btnChangeStudent.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnChangeStudent.Location = New Point(239, 5)
        btnChangeStudent.Margin = New Padding(8, 0, 0, 0)
        btnChangeStudent.MinimumSize = New Size(0, 34)
        btnChangeStudent.Name = "btnChangeStudent"
        btnChangeStudent.Padding = New Padding(14, 0, 14, 0)
        tlpStudent.SetRowSpan(btnChangeStudent, 2)
        btnChangeStudent.Size = New Size(81, 34)
        btnChangeStudent.TabIndex = 2
        btnChangeStudent.Text = "Clear"
        btnChangeStudent.UseVisualStyleBackColor = False
        ' 
        ' tlpStudent
        ' 
        tlpStudent.AutoSize = True
        tlpStudent.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpStudent.ColumnCount = 2
        tlpStudent.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpStudent.ColumnStyles.Add(New ColumnStyle())
        tlpStudent.Controls.Add(lblStudentName, 0, 0)
        tlpStudent.Controls.Add(lblStudentDetails, 0, 1)
        tlpStudent.Controls.Add(btnChangeStudent, 1, 0)
        tlpStudent.Dock = DockStyle.Fill
        tlpStudent.Location = New Point(14, 12)
        tlpStudent.Margin = New Padding(0)
        tlpStudent.Name = "tlpStudent"
        tlpStudent.RowCount = 2
        tlpStudent.RowStyles.Add(New RowStyle())
        tlpStudent.RowStyles.Add(New RowStyle())
        tlpStudent.Size = New Size(320, 44)
        tlpStudent.TabIndex = 0
        ' 
        ' pnlStudent
        ' 
        pnlStudent.AutoSize = True
        pnlStudent.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlStudent.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        pnlStudent.Controls.Add(tlpStudent)
        pnlStudent.Dock = DockStyle.Fill
        pnlStudent.Location = New Point(0, 29)
        pnlStudent.Margin = New Padding(0)
        pnlStudent.Name = "pnlStudent"
        pnlStudent.Padding = New Padding(14, 12, 14, 12)
        pnlStudent.Size = New Size(348, 68)
        pnlStudent.TabIndex = 1
        ' 
        ' lblSecRequest
        ' 
        lblSecRequest.AutoSize = True
        lblSecRequest.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecRequest.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecRequest.Location = New Point(0, 117)
        lblSecRequest.Margin = New Padding(0, 20, 0, 8)
        lblSecRequest.Name = "lblSecRequest"
        lblSecRequest.Size = New Size(140, 21)
        lblSecRequest.TabIndex = 2
        lblSecRequest.Text = "3. Request Details"
        ' 
        ' lblCapDocType
        ' 
        lblCapDocType.AutoSize = True
        tlpFields.SetColumnSpan(lblCapDocType, 2)
        lblCapDocType.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapDocType.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapDocType.Location = New Point(0, 0)
        lblCapDocType.Margin = New Padding(0, 0, 0, 4)
        lblCapDocType.Name = "lblCapDocType"
        lblCapDocType.Size = New Size(103, 17)
        lblCapDocType.TabIndex = 0
        lblCapDocType.Text = "Document Type"
        ' 
        ' cboDocumentType
        ' 
        cboDocumentType.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        tlpFields.SetColumnSpan(cboDocumentType, 2)
        cboDocumentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboDocumentType.Font = New Font("Segoe UI", 10.5F)
        cboDocumentType.FormattingEnabled = True
        cboDocumentType.Location = New Point(0, 21)
        cboDocumentType.Margin = New Padding(0, 0, 0, 12)
        cboDocumentType.Name = "cboDocumentType"
        cboDocumentType.Size = New Size(348, 27)
        cboDocumentType.TabIndex = 1
        ' 
        ' lblCapCopies
        ' 
        lblCapCopies.AutoSize = True
        lblCapCopies.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapCopies.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapCopies.Location = New Point(0, 56)
        lblCapCopies.Margin = New Padding(0, 0, 0, 4)
        lblCapCopies.Name = "lblCapCopies"
        lblCapCopies.Size = New Size(118, 17)
        lblCapCopies.TabIndex = 2
        lblCapCopies.Text = "Number of Copies"
        ' 
        ' numCopies
        ' 
        numCopies.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        numCopies.Font = New Font("Segoe UI", 10.5F)
        numCopies.Location = New Point(0, 77)
        numCopies.Margin = New Padding(0, 0, 12, 12)
        numCopies.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numCopies.Name = "numCopies"
        numCopies.Size = New Size(162, 26)
        numCopies.TabIndex = 3
        numCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblCapDate
        ' 
        lblCapDate.AutoSize = True
        lblCapDate.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapDate.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapDate.Location = New Point(174, 56)
        lblCapDate.Margin = New Padding(0, 0, 0, 4)
        lblCapDate.Name = "lblCapDate"
        lblCapDate.Size = New Size(89, 17)
        lblCapDate.TabIndex = 4
        lblCapDate.Text = "Request Date"
        ' 
        ' dtpRequestDate
        ' 
        dtpRequestDate.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpRequestDate.Font = New Font("Segoe UI", 10.5F)
        dtpRequestDate.Format = DateTimePickerFormat.Short
        dtpRequestDate.Location = New Point(174, 77)
        dtpRequestDate.Margin = New Padding(0, 0, 0, 12)
        dtpRequestDate.Name = "dtpRequestDate"
        dtpRequestDate.Size = New Size(174, 26)
        dtpRequestDate.TabIndex = 5
        ' 
        ' lblCapPayment
        ' 
        lblCapPayment.AutoSize = True
        tlpFields.SetColumnSpan(lblCapPayment, 2)
        lblCapPayment.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapPayment.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapPayment.Location = New Point(0, 115)
        lblCapPayment.Margin = New Padding(0, 0, 0, 4)
        lblCapPayment.Name = "lblCapPayment"
        lblCapPayment.Size = New Size(104, 17)
        lblCapPayment.TabIndex = 6
        lblCapPayment.Text = "Payment Status"
        ' 
        ' cboPaymentStatus
        ' 
        cboPaymentStatus.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        tlpFields.SetColumnSpan(cboPaymentStatus, 2)
        cboPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentStatus.Font = New Font("Segoe UI", 10.5F)
        cboPaymentStatus.FormattingEnabled = True
        cboPaymentStatus.Location = New Point(0, 144)
        cboPaymentStatus.Margin = New Padding(0)
        cboPaymentStatus.Name = "cboPaymentStatus"
        cboPaymentStatus.Size = New Size(348, 27)
        cboPaymentStatus.TabIndex = 7
        ' 
        ' tlpFields
        ' 
        tlpFields.AutoSize = True
        tlpFields.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpFields.ColumnCount = 2
        tlpFields.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpFields.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpFields.Controls.Add(lblCapDocType, 0, 0)
        tlpFields.Controls.Add(cboDocumentType, 0, 1)
        tlpFields.Controls.Add(lblCapCopies, 0, 2)
        tlpFields.Controls.Add(numCopies, 0, 3)
        tlpFields.Controls.Add(lblCapDate, 1, 2)
        tlpFields.Controls.Add(dtpRequestDate, 1, 3)
        tlpFields.Controls.Add(lblCapPayment, 0, 4)
        tlpFields.Controls.Add(cboPaymentStatus, 0, 5)
        tlpFields.Dock = DockStyle.Fill
        tlpFields.Location = New Point(0, 146)
        tlpFields.Margin = New Padding(0)
        tlpFields.Name = "tlpFields"
        tlpFields.RowCount = 6
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.Size = New Size(348, 176)
        tlpFields.TabIndex = 3
        ' 
        ' lblSecTotal
        ' 
        lblSecTotal.AutoSize = True
        lblSecTotal.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecTotal.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecTotal.Location = New Point(0, 342)
        lblSecTotal.Margin = New Padding(0, 20, 0, 8)
        lblSecTotal.Name = "lblSecTotal"
        lblSecTotal.Size = New Size(163, 21)
        lblSecTotal.TabIndex = 4
        lblSecTotal.Text = "4. Payment Summary"
        ' 
        ' lblCapFee
        ' 
        lblCapFee.Anchor = AnchorStyles.Left
        lblCapFee.AutoSize = True
        lblCapFee.Font = New Font("Segoe UI", 10F)
        lblCapFee.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapFee.Location = New Point(0, 3)
        lblCapFee.Margin = New Padding(0, 3, 0, 3)
        lblCapFee.Name = "lblCapFee"
        lblCapFee.Size = New Size(87, 19)
        lblCapFee.TabIndex = 0
        lblCapFee.Text = "Fee per copy"
        ' 
        ' lblFeePerCopy
        ' 
        lblFeePerCopy.Anchor = AnchorStyles.Right
        lblFeePerCopy.AutoSize = True
        lblFeePerCopy.Font = New Font("Segoe UI Semibold", 10.5F)
        lblFeePerCopy.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblFeePerCopy.Location = New Point(301, 3)
        lblFeePerCopy.Margin = New Padding(0, 3, 0, 3)
        lblFeePerCopy.Name = "lblFeePerCopy"
        lblFeePerCopy.Size = New Size(15, 19)
        lblFeePerCopy.TabIndex = 1
        lblFeePerCopy.Text = "-"
        ' 
        ' lblCapQty
        ' 
        lblCapQty.Anchor = AnchorStyles.Left
        lblCapQty.AutoSize = True
        lblCapQty.Font = New Font("Segoe UI", 10F)
        lblCapQty.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapQty.Location = New Point(0, 28)
        lblCapQty.Margin = New Padding(0, 3, 0, 3)
        lblCapQty.Name = "lblCapQty"
        lblCapQty.Size = New Size(63, 19)
        lblCapQty.TabIndex = 2
        lblCapQty.Text = "Quantity"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.Anchor = AnchorStyles.Right
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Segoe UI Semibold", 10.5F)
        lblQuantity.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblQuantity.Location = New Point(301, 28)
        lblQuantity.Margin = New Padding(0, 3, 0, 3)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(15, 19)
        lblQuantity.TabIndex = 3
        lblQuantity.Text = "-"
        ' 
        ' lblCapAmount
        ' 
        lblCapAmount.Anchor = AnchorStyles.Left
        lblCapAmount.AutoSize = True
        lblCapAmount.Font = New Font("Segoe UI Semibold", 10.5F)
        lblCapAmount.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapAmount.Location = New Point(0, 57)
        lblCapAmount.Margin = New Padding(0, 3, 0, 3)
        lblCapAmount.Name = "lblCapAmount"
        lblCapAmount.Size = New Size(86, 19)
        lblCapAmount.TabIndex = 4
        lblCapAmount.Text = "Amount due"
        ' 
        ' lblAmountDue
        ' 
        lblAmountDue.Anchor = AnchorStyles.Right
        lblAmountDue.AutoSize = True
        lblAmountDue.Font = New Font("Segoe UI Semibold", 15F)
        lblAmountDue.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblAmountDue.Location = New Point(296, 53)
        lblAmountDue.Margin = New Padding(0, 3, 0, 3)
        lblAmountDue.Name = "lblAmountDue"
        lblAmountDue.Size = New Size(20, 28)
        lblAmountDue.TabIndex = 5
        lblAmountDue.Text = "-"
        ' 
        ' tlpTotal
        ' 
        tlpTotal.AutoSize = True
        tlpTotal.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpTotal.ColumnCount = 2
        tlpTotal.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpTotal.ColumnStyles.Add(New ColumnStyle())
        tlpTotal.Controls.Add(lblCapFee, 0, 0)
        tlpTotal.Controls.Add(lblFeePerCopy, 1, 0)
        tlpTotal.Controls.Add(lblCapQty, 0, 1)
        tlpTotal.Controls.Add(lblQuantity, 1, 1)
        tlpTotal.Controls.Add(lblCapAmount, 0, 2)
        tlpTotal.Controls.Add(lblAmountDue, 1, 2)
        tlpTotal.Dock = DockStyle.Fill
        tlpTotal.Location = New Point(16, 10)
        tlpTotal.Margin = New Padding(0)
        tlpTotal.Name = "tlpTotal"
        tlpTotal.RowCount = 3
        tlpTotal.RowStyles.Add(New RowStyle())
        tlpTotal.RowStyles.Add(New RowStyle())
        tlpTotal.RowStyles.Add(New RowStyle())
        tlpTotal.Size = New Size(316, 84)
        tlpTotal.TabIndex = 0
        ' 
        ' pnlTotal
        ' 
        pnlTotal.AutoSize = True
        pnlTotal.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlTotal.BackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        pnlTotal.Controls.Add(tlpTotal)
        pnlTotal.Dock = DockStyle.Fill
        pnlTotal.Location = New Point(0, 371)
        pnlTotal.Margin = New Padding(0)
        pnlTotal.Name = "pnlTotal"
        pnlTotal.Padding = New Padding(16, 10, 16, 10)
        pnlTotal.Size = New Size(348, 104)
        pnlTotal.TabIndex = 5
        ' 
        ' btnSubmitRequest
        ' 
        btnSubmitRequest.AutoSize = True
        btnSubmitRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSubmitRequest.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSubmitRequest.FlatAppearance.BorderSize = 0
        btnSubmitRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSubmitRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnSubmitRequest.FlatStyle = FlatStyle.Flat
        btnSubmitRequest.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSubmitRequest.ForeColor = Color.White
        btnSubmitRequest.Kind = ButtonKind.Primary
        btnSubmitRequest.Location = New Point(140, 0)
        btnSubmitRequest.Margin = New Padding(10, 0, 0, 0)
        btnSubmitRequest.MinimumSize = New Size(120, 40)
        btnSubmitRequest.Name = "btnSubmitRequest"
        btnSubmitRequest.Padding = New Padding(14, 0, 14, 0)
        btnSubmitRequest.Size = New Size(151, 40)
        btnSubmitRequest.TabIndex = 0
        btnSubmitRequest.Text = "Submit Request"
        btnSubmitRequest.UseVisualStyleBackColor = False
        ' 
        ' btnCancelRequest
        ' 
        btnCancelRequest.AutoSize = True
        btnCancelRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCancelRequest.BackColor = Color.White
        btnCancelRequest.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCancelRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnCancelRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnCancelRequest.FlatStyle = FlatStyle.Flat
        btnCancelRequest.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancelRequest.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCancelRequest.Location = New Point(10, 0)
        btnCancelRequest.Margin = New Padding(10, 0, 0, 0)
        btnCancelRequest.MinimumSize = New Size(120, 40)
        btnCancelRequest.Name = "btnCancelRequest"
        btnCancelRequest.Padding = New Padding(14, 0, 14, 0)
        btnCancelRequest.Size = New Size(120, 40)
        btnCancelRequest.TabIndex = 1
        btnCancelRequest.Text = "Cancel"
        btnCancelRequest.UseVisualStyleBackColor = False
        ' 
        ' flpButtons
        ' 
        flpButtons.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        flpButtons.AutoSize = True
        flpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpButtons.Controls.Add(btnSubmitRequest)
        flpButtons.Controls.Add(btnCancelRequest)
        flpButtons.FlowDirection = FlowDirection.RightToLeft
        flpButtons.Location = New Point(57, 636)
        flpButtons.Margin = New Padding(0, 20, 0, 0)
        flpButtons.Name = "flpButtons"
        flpButtons.Size = New Size(291, 40)
        flpButtons.TabIndex = 6
        flpButtons.WrapContents = False
        ' 
        ' tlpRight
        ' 
        tlpRight.ColumnCount = 1
        tlpRight.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpRight.Controls.Add(lblSecStudent, 0, 0)
        tlpRight.Controls.Add(pnlStudent, 0, 1)
        tlpRight.Controls.Add(lblSecRequest, 0, 2)
        tlpRight.Controls.Add(tlpFields, 0, 3)
        tlpRight.Controls.Add(lblSecTotal, 0, 4)
        tlpRight.Controls.Add(pnlTotal, 0, 5)
        tlpRight.Controls.Add(flpButtons, 0, 6)
        tlpRight.Dock = DockStyle.Fill
        tlpRight.Location = New Point(24, 20)
        tlpRight.Margin = New Padding(0)
        tlpRight.Name = "tlpRight"
        tlpRight.RowCount = 7
        tlpRight.RowStyles.Add(New RowStyle())
        tlpRight.RowStyles.Add(New RowStyle())
        tlpRight.RowStyles.Add(New RowStyle())
        tlpRight.RowStyles.Add(New RowStyle())
        tlpRight.RowStyles.Add(New RowStyle())
        tlpRight.RowStyles.Add(New RowStyle())
        tlpRight.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpRight.Size = New Size(348, 676)
        tlpRight.TabIndex = 0
        ' 
        ' cardRequest
        ' 
        cardRequest.BackColor = Color.White
        cardRequest.Controls.Add(tlpRight)
        cardRequest.Dock = DockStyle.Fill
        cardRequest.Location = New Point(579, 20)
        cardRequest.Margin = New Padding(12, 0, 0, 0)
        cardRequest.Name = "cardRequest"
        cardRequest.Padding = New Padding(24, 20, 24, 20)
        cardRequest.Size = New Size(396, 716)
        cardRequest.TabIndex = 1
        ' 
        ' tlpMain
        ' 
        tlpMain.ColumnCount = 2
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 57F))
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 43F))
        tlpMain.Controls.Add(cardStudents, 0, 0)
        tlpMain.Controls.Add(cardRequest, 1, 0)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Location = New Point(0, 0)
        tlpMain.Name = "tlpMain"
        tlpMain.Padding = New Padding(28, 20, 28, 24)
        tlpMain.RowCount = 1
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMain.Size = New Size(1003, 760)
        tlpMain.TabIndex = 0
        ' 
        ' frmCreateDocumentRequest
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(980, 760)
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(tlpMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmCreateDocumentRequest"
        Text = "Create Document Request"
        tlpSearchRow.ResumeLayout(False)
        tlpSearchRow.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlGridBorder.ResumeLayout(False)
        tlpLeft.ResumeLayout(False)
        tlpLeft.PerformLayout()
        cardStudents.ResumeLayout(False)
        tlpStudent.ResumeLayout(False)
        tlpStudent.PerformLayout()
        pnlStudent.ResumeLayout(False)
        pnlStudent.PerformLayout()
        CType(numCopies, ComponentModel.ISupportInitialize).EndInit()
        tlpFields.ResumeLayout(False)
        tlpFields.PerformLayout()
        tlpTotal.ResumeLayout(False)
        tlpTotal.PerformLayout()
        pnlTotal.ResumeLayout(False)
        pnlTotal.PerformLayout()
        flpButtons.ResumeLayout(False)
        flpButtons.PerformLayout()
        tlpRight.ResumeLayout(False)
        tlpRight.PerformLayout()
        cardRequest.ResumeLayout(False)
        tlpMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblSearchedStudents As Label
    Friend WithEvents txtSearchStudent As TextBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents tlpSearchRow As TableLayoutPanel
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents pnlGridBorder As Panel
    Friend WithEvents tlpLeft As TableLayoutPanel
    Friend WithEvents cardStudents As CardPanel
    Friend WithEvents lblSecStudent As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStudentDetails As Label
    Friend WithEvents btnChangeStudent As Button
    Friend WithEvents tlpStudent As TableLayoutPanel
    Friend WithEvents pnlStudent As Panel
    Friend WithEvents lblSecRequest As Label
    Friend WithEvents lblCapDocType As Label
    Friend WithEvents cboDocumentType As ComboBox
    Friend WithEvents lblCapCopies As Label
    Friend WithEvents numCopies As NumericUpDown
    Friend WithEvents lblCapDate As Label
    Friend WithEvents dtpRequestDate As DateTimePicker
    Friend WithEvents lblCapPayment As Label
    Friend WithEvents cboPaymentStatus As ComboBox
    Friend WithEvents tlpFields As TableLayoutPanel
    Friend WithEvents lblSecTotal As Label
    Friend WithEvents lblCapFee As Label
    Friend WithEvents lblFeePerCopy As Label
    Friend WithEvents lblCapQty As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblCapAmount As Label
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents tlpTotal As TableLayoutPanel
    Friend WithEvents pnlTotal As Panel
    Friend WithEvents btnSubmitRequest As ThemedButton
    Friend WithEvents btnCancelRequest As ThemedButton
    Friend WithEvents flpButtons As FlowLayoutPanel
    Friend WithEvents tlpRight As TableLayoutPanel
    Friend WithEvents cardRequest As CardPanel
    Friend WithEvents tlpMain As TableLayoutPanel
End Class
