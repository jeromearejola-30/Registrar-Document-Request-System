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
        pnlGridBorder.SuspendLayout()
        tlpLeft.SuspendLayout()
        cardStudents.SuspendLayout()
        tlpStudent.SuspendLayout()
        pnlStudent.SuspendLayout()
        tlpFields.SuspendLayout()
        tlpTotal.SuspendLayout()
        pnlTotal.SuspendLayout()
        flpButtons.SuspendLayout()
        tlpRight.SuspendLayout()
        cardRequest.SuspendLayout()
        tlpMain.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSearchedStudents
        ' 
        lblSearchedStudents.AutoSize = True
        lblSearchedStudents.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSearchedStudents.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSearchedStudents.Margin = New Padding(0, 0, 0, 10)
        lblSearchedStudents.Name = "lblSearchedStudents"
        lblSearchedStudents.Text = "1. Select a Student"
        ' 
        ' txtSearchStudent
        ' 
        txtSearchStudent.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSearchStudent.BorderStyle = BorderStyle.FixedSingle
        txtSearchStudent.Font = New Font("Segoe UI", 11F)
        txtSearchStudent.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        txtSearchStudent.Margin = New Padding(0)
        txtSearchStudent.Name = "txtSearchStudent"
        txtSearchStudent.PlaceholderText = "Search by student number, name or course..."
        txtSearchStudent.Size = New Size(300, 27)
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
        tlpSearchRow.Margin = New Padding(0, 0, 0, 12)
        tlpSearchRow.Name = "tlpSearchRow"
        tlpSearchRow.RowCount = 1
        tlpSearchRow.RowStyles.Add(New RowStyle())
        ' 
        ' dgvStudents
        ' 
        dgvStudents.Dock = DockStyle.Fill
        dgvStudents.Name = "dgvStudents"
        ' 
        ' pnlGridBorder
        ' 
        pnlGridBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlGridBorder.Controls.Add(dgvStudents)
        pnlGridBorder.Dock = DockStyle.Fill
        pnlGridBorder.Margin = New Padding(0)
        pnlGridBorder.Name = "pnlGridBorder"
        pnlGridBorder.Padding = New Padding(1)
        ' 
        ' tlpLeft
        ' 
        tlpLeft.ColumnCount = 1
        tlpLeft.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpLeft.Controls.Add(lblSearchedStudents, 0, 0)
        tlpLeft.Controls.Add(tlpSearchRow, 0, 1)
        tlpLeft.Controls.Add(pnlGridBorder, 0, 2)
        tlpLeft.Dock = DockStyle.Fill
        tlpLeft.Margin = New Padding(0)
        tlpLeft.Name = "tlpLeft"
        tlpLeft.RowCount = 3
        tlpLeft.RowStyles.Add(New RowStyle())
        tlpLeft.RowStyles.Add(New RowStyle())
        tlpLeft.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        ' 
        ' cardStudents
        ' 
        cardStudents.BackColor = Color.White
        cardStudents.Controls.Add(tlpLeft)
        cardStudents.Dock = DockStyle.Fill
        cardStudents.Margin = New Padding(0, 0, 12, 0)
        cardStudents.Name = "cardStudents"
        cardStudents.Padding = New Padding(24, 20, 24, 20)
        ' 
        ' lblSecStudent
        ' 
        lblSecStudent.AutoSize = True
        lblSecStudent.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecStudent.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecStudent.Margin = New Padding(0, 0, 0, 8)
        lblSecStudent.Name = "lblSecStudent"
        lblSecStudent.Text = "2. Selected Student"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.Font = New Font("Segoe UI Semibold", 12F)
        lblStudentName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblStudentName.Margin = New Padding(0)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Text = "[Select Student Above]"
        lblStudentName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblStudentName.AutoEllipsis = True
        lblStudentName.Size = New Size(200, 24)
        ' 
        ' lblStudentDetails
        ' 
        lblStudentDetails.Font = New Font("Segoe UI", 9.5F)
        lblStudentDetails.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblStudentDetails.Margin = New Padding(0)
        lblStudentDetails.Name = "lblStudentDetails"
        lblStudentDetails.Text = ""
        lblStudentDetails.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblStudentDetails.AutoEllipsis = True
        lblStudentDetails.Size = New Size(200, 20)
        ' 
        ' btnChangeStudent
        ' 
        btnChangeStudent.AutoSize = True
        btnChangeStudent.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnChangeStudent.Cursor = Cursors.Hand
        btnChangeStudent.BackColor = Color.White
        btnChangeStudent.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnChangeStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnChangeStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnChangeStudent.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnChangeStudent.FlatStyle = FlatStyle.Flat
        btnChangeStudent.Font = New Font("Segoe UI Semibold", 10F)
        btnChangeStudent.Margin = New Padding(8, 0, 0, 0)
        btnChangeStudent.MinimumSize = New Size(0, 40)
        btnChangeStudent.Name = "btnChangeStudent"
        btnChangeStudent.Padding = New Padding(14, 0, 14, 0)
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
        tlpStudent.Margin = New Padding(0)
        tlpStudent.Name = "tlpStudent"
        tlpStudent.RowCount = 2
        tlpStudent.RowStyles.Add(New RowStyle())
        tlpStudent.RowStyles.Add(New RowStyle())
        tlpStudent.SetRowSpan(btnChangeStudent, 2)
        btnChangeStudent.Anchor = AnchorStyles.Right
        btnChangeStudent.MinimumSize = New Size(0, 34)
        ' 
        ' pnlStudent
        ' 
        pnlStudent.AutoSize = True
        pnlStudent.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlStudent.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        pnlStudent.Controls.Add(tlpStudent)
        pnlStudent.Dock = DockStyle.Fill
        pnlStudent.Margin = New Padding(0)
        pnlStudent.Name = "pnlStudent"
        pnlStudent.Padding = New Padding(14, 12, 14, 12)
        ' 
        ' lblSecRequest
        ' 
        lblSecRequest.AutoSize = True
        lblSecRequest.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecRequest.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecRequest.Margin = New Padding(0, 20, 0, 8)
        lblSecRequest.Name = "lblSecRequest"
        lblSecRequest.Text = "3. Request Details"
        ' 
        ' lblCapDocType
        ' 
        lblCapDocType.AutoSize = True
        lblCapDocType.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapDocType.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapDocType.Margin = New Padding(0, 0, 0, 4)
        lblCapDocType.Name = "lblCapDocType"
        lblCapDocType.Text = "Document Type"
        ' 
        ' cboDocumentType
        ' 
        cboDocumentType.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboDocumentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboDocumentType.Font = New Font("Segoe UI", 10.5F)
        cboDocumentType.FormattingEnabled = True
        cboDocumentType.Margin = New Padding(0, 0, 0, 12)
        cboDocumentType.Name = "cboDocumentType"
        ' 
        ' lblCapCopies
        ' 
        lblCapCopies.AutoSize = True
        lblCapCopies.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapCopies.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapCopies.Margin = New Padding(0, 0, 0, 4)
        lblCapCopies.Name = "lblCapCopies"
        lblCapCopies.Text = "Number of Copies"
        ' 
        ' numCopies
        ' 
        numCopies.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        numCopies.Font = New Font("Segoe UI", 10.5F)
        numCopies.Margin = New Padding(0, 0, 12, 12)
        numCopies.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        numCopies.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numCopies.Name = "numCopies"
        numCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblCapDate
        ' 
        lblCapDate.AutoSize = True
        lblCapDate.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapDate.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapDate.Margin = New Padding(0, 0, 0, 4)
        lblCapDate.Name = "lblCapDate"
        lblCapDate.Text = "Request Date"
        ' 
        ' dtpRequestDate
        ' 
        dtpRequestDate.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpRequestDate.Font = New Font("Segoe UI", 10.5F)
        dtpRequestDate.Format = DateTimePickerFormat.Short
        dtpRequestDate.Margin = New Padding(0, 0, 0, 12)
        dtpRequestDate.Name = "dtpRequestDate"
        ' 
        ' lblCapPayment
        ' 
        lblCapPayment.AutoSize = True
        lblCapPayment.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapPayment.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapPayment.Margin = New Padding(0, 0, 0, 4)
        lblCapPayment.Name = "lblCapPayment"
        lblCapPayment.Text = "Payment Status"
        ' 
        ' cboPaymentStatus
        ' 
        cboPaymentStatus.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboPaymentStatus.Font = New Font("Segoe UI", 10.5F)
        cboPaymentStatus.FormattingEnabled = True
        cboPaymentStatus.Margin = New Padding(0)
        cboPaymentStatus.Name = "cboPaymentStatus"
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
        tlpFields.Margin = New Padding(0)
        tlpFields.Name = "tlpFields"
        tlpFields.RowCount = 6
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.RowStyles.Add(New RowStyle())
        tlpFields.SetColumnSpan(lblCapDocType, 2)
        tlpFields.SetColumnSpan(cboDocumentType, 2)
        tlpFields.SetColumnSpan(lblCapPayment, 2)
        tlpFields.SetColumnSpan(cboPaymentStatus, 2)
        ' 
        ' lblSecTotal
        ' 
        lblSecTotal.AutoSize = True
        lblSecTotal.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecTotal.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecTotal.Margin = New Padding(0, 20, 0, 8)
        lblSecTotal.Name = "lblSecTotal"
        lblSecTotal.Text = "4. Payment Summary"
        ' 
        ' lblCapFee
        ' 
        lblCapFee.AutoSize = True
        lblCapFee.Font = New Font("Segoe UI", 10F)
        lblCapFee.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapFee.Margin = New Padding(0, 3, 0, 3)
        lblCapFee.Name = "lblCapFee"
        lblCapFee.Text = "Fee per copy"
        lblCapFee.Anchor = AnchorStyles.Left
        ' 
        ' lblFeePerCopy
        ' 
        lblFeePerCopy.AutoSize = True
        lblFeePerCopy.Font = New Font("Segoe UI Semibold", 10.5F)
        lblFeePerCopy.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblFeePerCopy.Margin = New Padding(0, 3, 0, 3)
        lblFeePerCopy.Name = "lblFeePerCopy"
        lblFeePerCopy.Text = "-"
        lblFeePerCopy.Anchor = AnchorStyles.Right
        ' 
        ' lblCapQty
        ' 
        lblCapQty.AutoSize = True
        lblCapQty.Font = New Font("Segoe UI", 10F)
        lblCapQty.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapQty.Margin = New Padding(0, 3, 0, 3)
        lblCapQty.Name = "lblCapQty"
        lblCapQty.Text = "Quantity"
        lblCapQty.Anchor = AnchorStyles.Left
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Segoe UI Semibold", 10.5F)
        lblQuantity.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblQuantity.Margin = New Padding(0, 3, 0, 3)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Text = "-"
        lblQuantity.Anchor = AnchorStyles.Right
        ' 
        ' lblCapAmount
        ' 
        lblCapAmount.AutoSize = True
        lblCapAmount.Font = New Font("Segoe UI Semibold", 10.5F)
        lblCapAmount.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapAmount.Margin = New Padding(0, 3, 0, 3)
        lblCapAmount.Name = "lblCapAmount"
        lblCapAmount.Text = "Amount due"
        lblCapAmount.Anchor = AnchorStyles.Left
        ' 
        ' lblAmountDue
        ' 
        lblAmountDue.AutoSize = True
        lblAmountDue.Font = New Font("Segoe UI Semibold", 15F)
        lblAmountDue.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblAmountDue.Margin = New Padding(0, 3, 0, 3)
        lblAmountDue.Name = "lblAmountDue"
        lblAmountDue.Text = "-"
        lblAmountDue.Anchor = AnchorStyles.Right
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
        tlpTotal.Margin = New Padding(0)
        tlpTotal.Name = "tlpTotal"
        tlpTotal.RowCount = 3
        tlpTotal.RowStyles.Add(New RowStyle())
        tlpTotal.RowStyles.Add(New RowStyle())
        tlpTotal.RowStyles.Add(New RowStyle())
        ' 
        ' pnlTotal
        ' 
        pnlTotal.AutoSize = True
        pnlTotal.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlTotal.BackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        pnlTotal.Controls.Add(tlpTotal)
        pnlTotal.Dock = DockStyle.Fill
        pnlTotal.Margin = New Padding(0)
        pnlTotal.Name = "pnlTotal"
        pnlTotal.Padding = New Padding(16, 10, 16, 10)
        ' 
        ' btnSubmitRequest
        ' 
        btnSubmitRequest.AutoSize = True
        btnSubmitRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSubmitRequest.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSubmitRequest.FlatAppearance.BorderSize = 0
        btnSubmitRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSubmitRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnSubmitRequest.ForeColor = Color.White
        btnSubmitRequest.Kind = ButtonKind.Primary
        btnSubmitRequest.FlatStyle = FlatStyle.Flat
        btnSubmitRequest.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSubmitRequest.Margin = New Padding(10, 0, 0, 0)
        btnSubmitRequest.MinimumSize = New Size(120, 40)
        btnSubmitRequest.Name = "btnSubmitRequest"
        btnSubmitRequest.Padding = New Padding(14, 0, 14, 0)
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
        btnCancelRequest.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCancelRequest.FlatStyle = FlatStyle.Flat
        btnCancelRequest.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancelRequest.Margin = New Padding(10, 0, 0, 0)
        btnCancelRequest.MinimumSize = New Size(120, 40)
        btnCancelRequest.Name = "btnCancelRequest"
        btnCancelRequest.Padding = New Padding(14, 0, 14, 0)
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
        flpButtons.Margin = New Padding(0, 20, 0, 0)
        flpButtons.Name = "flpButtons"
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
        ' 
        ' cardRequest
        ' 
        cardRequest.BackColor = Color.White
        cardRequest.Controls.Add(tlpRight)
        cardRequest.Dock = DockStyle.Fill
        cardRequest.Margin = New Padding(12, 0, 0, 0)
        cardRequest.Name = "cardRequest"
        cardRequest.Padding = New Padding(24, 20, 24, 20)
        ' 
        ' tlpMain
        ' 
        tlpMain.ColumnCount = 2
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 57F))
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 43F))
        tlpMain.Controls.Add(cardStudents, 0, 0)
        tlpMain.Controls.Add(cardRequest, 1, 0)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Name = "tlpMain"
        tlpMain.Padding = New Padding(28, 20, 28, 24)
        tlpMain.RowCount = 1
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
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
        pnlGridBorder.ResumeLayout(False)
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        tlpLeft.ResumeLayout(False)
        tlpLeft.PerformLayout()
        cardStudents.ResumeLayout(False)
        tlpStudent.ResumeLayout(False)
        tlpStudent.PerformLayout()
        pnlStudent.ResumeLayout(False)
        tlpFields.ResumeLayout(False)
        tlpFields.PerformLayout()
        tlpTotal.ResumeLayout(False)
        tlpTotal.PerformLayout()
        pnlTotal.ResumeLayout(False)
        flpButtons.ResumeLayout(False)
        flpButtons.PerformLayout()
        tlpRight.ResumeLayout(False)
        tlpRight.PerformLayout()
        cardRequest.ResumeLayout(False)
        tlpMain.ResumeLayout(False)
        tlpMain.PerformLayout()
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
