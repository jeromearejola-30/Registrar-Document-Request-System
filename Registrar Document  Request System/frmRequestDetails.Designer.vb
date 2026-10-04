<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequestDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblRequestNo = New Label()
        lblStatusBadge = New Label()
        tlpHeadRow = New TableLayoutPanel()
        lblSubtitle = New Label()
        lblSecInfo = New Label()
        lblCapStudentNo = New Label()
        lblStudentNo = New Label()
        lblCapStudentName = New Label()
        lblStudentName = New Label()
        lblCapRequestDate = New Label()
        lblRequestDate = New Label()
        lblCapCreatedBy = New Label()
        lblCreatedBy = New Label()
        tlpInfo = New TableLayoutPanel()
        lblSecDocs = New Label()
        dgvItems = New DataGridView()
        pnlItemsBorder = New Panel()
        lblSecPayment = New Label()
        lblCapTotal = New Label()
        lblTotalAmount = New Label()
        lblCapPayment = New Label()
        cboPaymentStatus = New ComboBox()
        lblCapOrNo = New Label()
        lblOrNo = New Label()
        lblCapOrDate = New Label()
        lblOrDate = New Label()
        tlpPayment = New TableLayoutPanel()
        lblSecStatus = New Label()
        lblCapStatus = New Label()
        cboStatus = New ComboBox()
        tlpStatus = New TableLayoutPanel()
        lblStatusHint = New Label()
        btnSave = New ThemedButton()
        btnBack = New ThemedButton()
        flpButtons = New FlowLayoutPanel()
        tlpForm = New TableLayoutPanel()
        cardForm = New CardPanel()
        tlpHeadRow.SuspendLayout()
        tlpInfo.SuspendLayout()
        pnlItemsBorder.SuspendLayout()
        tlpPayment.SuspendLayout()
        tlpStatus.SuspendLayout()
        flpButtons.SuspendLayout()
        tlpForm.SuspendLayout()
        cardForm.SuspendLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblRequestNo
        ' 
        lblRequestNo.Anchor = AnchorStyles.Left
        lblRequestNo.AutoSize = True
        lblRequestNo.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblRequestNo.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblRequestNo.Margin = New Padding(0)
        lblRequestNo.Name = "lblRequestNo"
        lblRequestNo.Text = "Request"
        ' 
        ' lblStatusBadge
        ' 
        lblStatusBadge.Anchor = AnchorStyles.Right
        lblStatusBadge.AutoSize = True
        lblStatusBadge.BackColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblStatusBadge.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblStatusBadge.ForeColor = Color.White
        lblStatusBadge.Margin = New Padding(12, 0, 0, 0)
        lblStatusBadge.Name = "lblStatusBadge"
        lblStatusBadge.Padding = New Padding(14, 5, 14, 5)
        lblStatusBadge.Text = "Status"
        ' 
        ' tlpHeadRow
        ' 
        tlpHeadRow.AutoSize = True
        tlpHeadRow.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpHeadRow.ColumnCount = 2
        tlpHeadRow.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpHeadRow.ColumnStyles.Add(New ColumnStyle())
        tlpHeadRow.Controls.Add(lblRequestNo, 0, 0)
        tlpHeadRow.Controls.Add(lblStatusBadge, 1, 0)
        tlpHeadRow.Dock = DockStyle.Fill
        tlpHeadRow.Margin = New Padding(0, 0, 0, 4)
        tlpHeadRow.Name = "tlpHeadRow"
        tlpHeadRow.RowCount = 1
        tlpHeadRow.RowStyles.Add(New RowStyle())
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblSubtitle.Margin = New Padding(0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Text = "Review this request and update its payment and status."
        ' 
        ' lblSecInfo
        ' 
        lblSecInfo.AutoSize = True
        lblSecInfo.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecInfo.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecInfo.Margin = New Padding(0, 14, 0, 8)
        lblSecInfo.Name = "lblSecInfo"
        lblSecInfo.Text = "Request Information"
        ' 
        ' lblCapStudentNo
        ' 
        lblCapStudentNo.AutoSize = True
        lblCapStudentNo.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapStudentNo.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapStudentNo.Margin = New Padding(0, 0, 0, 4)
        lblCapStudentNo.Name = "lblCapStudentNo"
        lblCapStudentNo.Text = "Student No."
        ' 
        ' lblStudentNo
        ' 
        lblStudentNo.AutoEllipsis = True
        lblStudentNo.AutoSize = False
        lblStudentNo.Dock = DockStyle.Fill
        lblStudentNo.Font = New Font("Segoe UI", 10.5F)
        lblStudentNo.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblStudentNo.Margin = New Padding(0, 0, 16, 0)
        lblStudentNo.Name = "lblStudentNo"
        lblStudentNo.Size = New Size(0, 26)
        lblStudentNo.Text = "-"
        lblStudentNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCapStudentName
        ' 
        lblCapStudentName.AutoSize = True
        lblCapStudentName.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapStudentName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapStudentName.Margin = New Padding(0, 0, 0, 4)
        lblCapStudentName.Name = "lblCapStudentName"
        lblCapStudentName.Text = "Student"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoEllipsis = True
        lblStudentName.AutoSize = False
        lblStudentName.Dock = DockStyle.Fill
        lblStudentName.Font = New Font("Segoe UI", 10.5F)
        lblStudentName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblStudentName.Margin = New Padding(0, 0, 0, 0)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(0, 26)
        lblStudentName.Text = "-"
        lblStudentName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCapRequestDate
        ' 
        lblCapRequestDate.AutoSize = True
        lblCapRequestDate.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapRequestDate.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapRequestDate.Margin = New Padding(0, 8, 0, 4)
        lblCapRequestDate.Name = "lblCapRequestDate"
        lblCapRequestDate.Text = "Request Date"
        ' 
        ' lblRequestDate
        ' 
        lblRequestDate.AutoEllipsis = True
        lblRequestDate.AutoSize = False
        lblRequestDate.Dock = DockStyle.Fill
        lblRequestDate.Font = New Font("Segoe UI", 10.5F)
        lblRequestDate.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblRequestDate.Margin = New Padding(0, 0, 16, 0)
        lblRequestDate.Name = "lblRequestDate"
        lblRequestDate.Size = New Size(0, 26)
        lblRequestDate.Text = "-"
        lblRequestDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCapCreatedBy
        ' 
        lblCapCreatedBy.AutoSize = True
        lblCapCreatedBy.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapCreatedBy.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapCreatedBy.Margin = New Padding(0, 8, 0, 4)
        lblCapCreatedBy.Name = "lblCapCreatedBy"
        lblCapCreatedBy.Text = "Created By"
        ' 
        ' lblCreatedBy
        ' 
        lblCreatedBy.AutoEllipsis = True
        lblCreatedBy.AutoSize = False
        lblCreatedBy.Dock = DockStyle.Fill
        lblCreatedBy.Font = New Font("Segoe UI", 10.5F)
        lblCreatedBy.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCreatedBy.Margin = New Padding(0, 0, 0, 0)
        lblCreatedBy.Name = "lblCreatedBy"
        lblCreatedBy.Size = New Size(0, 26)
        lblCreatedBy.Text = "-"
        lblCreatedBy.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tlpInfo
        ' 
        tlpInfo.AutoSize = True
        tlpInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpInfo.ColumnCount = 2
        tlpInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpInfo.Controls.Add(lblCapStudentNo, 0, 0)
        tlpInfo.Controls.Add(lblStudentNo, 0, 1)
        tlpInfo.Controls.Add(lblCapStudentName, 1, 0)
        tlpInfo.Controls.Add(lblStudentName, 1, 1)
        tlpInfo.Controls.Add(lblCapRequestDate, 0, 2)
        tlpInfo.Controls.Add(lblRequestDate, 0, 3)
        tlpInfo.Controls.Add(lblCapCreatedBy, 1, 2)
        tlpInfo.Controls.Add(lblCreatedBy, 1, 3)
        tlpInfo.Dock = DockStyle.Fill
        tlpInfo.Margin = New Padding(0)
        tlpInfo.Name = "tlpInfo"
        tlpInfo.RowCount = 4
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        ' 
        ' lblSecDocs
        ' 
        lblSecDocs.AutoSize = True
        lblSecDocs.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecDocs.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecDocs.Margin = New Padding(0, 22, 0, 8)
        lblSecDocs.Name = "lblSecDocs"
        lblSecDocs.Text = "Requested Documents"
        ' 
        ' dgvItems
        ' 
        dgvItems.Dock = DockStyle.Fill
        dgvItems.Name = "dgvItems"
        ' 
        ' pnlItemsBorder
        ' 
        pnlItemsBorder.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        pnlItemsBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlItemsBorder.Controls.Add(dgvItems)
        pnlItemsBorder.Margin = New Padding(0)
        pnlItemsBorder.Name = "pnlItemsBorder"
        pnlItemsBorder.Padding = New Padding(1)
        pnlItemsBorder.Size = New Size(400, 120)
        ' 
        ' lblSecPayment
        ' 
        lblSecPayment.AutoSize = True
        lblSecPayment.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecPayment.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecPayment.Margin = New Padding(0, 22, 0, 8)
        lblSecPayment.Name = "lblSecPayment"
        lblSecPayment.Text = "Payment"
        ' 
        ' lblCapTotal
        ' 
        lblCapTotal.AutoSize = True
        lblCapTotal.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapTotal.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapTotal.Margin = New Padding(0, 0, 0, 4)
        lblCapTotal.Name = "lblCapTotal"
        lblCapTotal.Text = "Total Amount"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = False
        lblTotalAmount.Dock = DockStyle.Fill
        lblTotalAmount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTotalAmount.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblTotalAmount.Margin = New Padding(0, 0, 16, 0)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(0, 34)
        lblTotalAmount.Text = "-"
        lblTotalAmount.TextAlign = ContentAlignment.MiddleLeft
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
        cboPaymentStatus.Margin = New Padding(0, 0, 0, 0)
        cboPaymentStatus.Name = "cboPaymentStatus"
        ' 
        ' lblCapOrNo
        ' 
        lblCapOrNo.AutoSize = True
        lblCapOrNo.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapOrNo.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapOrNo.Margin = New Padding(0, 14, 0, 4)
        lblCapOrNo.Name = "lblCapOrNo"
        lblCapOrNo.Text = "OR Number"
        ' 
        ' lblOrNo
        ' 
        lblOrNo.AutoEllipsis = True
        lblOrNo.AutoSize = False
        lblOrNo.Dock = DockStyle.Fill
        lblOrNo.Font = New Font("Segoe UI", 10.5F)
        lblOrNo.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblOrNo.Margin = New Padding(0, 0, 16, 0)
        lblOrNo.Name = "lblOrNo"
        lblOrNo.Size = New Size(0, 26)
        lblOrNo.Text = "-"
        lblOrNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCapOrDate
        ' 
        lblCapOrDate.AutoSize = True
        lblCapOrDate.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapOrDate.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapOrDate.Margin = New Padding(0, 14, 0, 4)
        lblCapOrDate.Name = "lblCapOrDate"
        lblCapOrDate.Text = "OR Date"
        ' 
        ' lblOrDate
        ' 
        lblOrDate.AutoEllipsis = True
        lblOrDate.AutoSize = False
        lblOrDate.Dock = DockStyle.Fill
        lblOrDate.Font = New Font("Segoe UI", 10.5F)
        lblOrDate.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblOrDate.Margin = New Padding(0, 0, 0, 0)
        lblOrDate.Name = "lblOrDate"
        lblOrDate.Size = New Size(0, 26)
        lblOrDate.Text = "-"
        lblOrDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tlpPayment
        ' 
        tlpPayment.AutoSize = True
        tlpPayment.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpPayment.ColumnCount = 2
        tlpPayment.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpPayment.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpPayment.Controls.Add(lblCapTotal, 0, 0)
        tlpPayment.Controls.Add(lblTotalAmount, 0, 1)
        tlpPayment.Controls.Add(lblCapPayment, 1, 0)
        tlpPayment.Controls.Add(cboPaymentStatus, 1, 1)
        tlpPayment.Controls.Add(lblCapOrNo, 0, 2)
        tlpPayment.Controls.Add(lblOrNo, 0, 3)
        tlpPayment.Controls.Add(lblCapOrDate, 1, 2)
        tlpPayment.Controls.Add(lblOrDate, 1, 3)
        tlpPayment.Dock = DockStyle.Fill
        tlpPayment.Margin = New Padding(0)
        tlpPayment.Name = "tlpPayment"
        tlpPayment.RowCount = 4
        tlpPayment.RowStyles.Add(New RowStyle())
        tlpPayment.RowStyles.Add(New RowStyle())
        tlpPayment.RowStyles.Add(New RowStyle())
        tlpPayment.RowStyles.Add(New RowStyle())
        ' 
        ' lblSecStatus
        ' 
        lblSecStatus.AutoSize = True
        lblSecStatus.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecStatus.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecStatus.Margin = New Padding(0, 22, 0, 8)
        lblSecStatus.Name = "lblSecStatus"
        lblSecStatus.Text = "Request Status"
        ' 
        ' lblCapStatus
        ' 
        lblCapStatus.AutoSize = True
        lblCapStatus.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapStatus.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapStatus.Margin = New Padding(0, 0, 0, 4)
        lblCapStatus.Name = "lblCapStatus"
        lblCapStatus.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Font = New Font("Segoe UI", 10.5F)
        cboStatus.FormattingEnabled = True
        cboStatus.Margin = New Padding(0, 0, 16, 0)
        cboStatus.Name = "cboStatus"
        ' 
        ' tlpStatus
        ' 
        tlpStatus.AutoSize = True
        tlpStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpStatus.ColumnCount = 2
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpStatus.Controls.Add(lblCapStatus, 0, 0)
        tlpStatus.Controls.Add(cboStatus, 0, 1)
        tlpStatus.Dock = DockStyle.Fill
        tlpStatus.Margin = New Padding(0)
        tlpStatus.Name = "tlpStatus"
        tlpStatus.RowCount = 2
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle())
        ' 
        ' lblStatusHint
        ' 
        lblStatusHint.AutoSize = False
        lblStatusHint.Dock = DockStyle.Fill
        lblStatusHint.Font = New Font("Segoe UI", 9.5F)
        lblStatusHint.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblStatusHint.Margin = New Padding(0, 10, 0, 0)
        lblStatusHint.Name = "lblStatusHint"
        lblStatusHint.Size = New Size(0, 44)
        lblStatusHint.Text = "Ready for Release and Released require a Paid request. Marking a request as Paid issues its OR number automatically."
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = True
        btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSave.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnSave.ForeColor = Color.White
        btnSave.Kind = ButtonKind.Primary
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSave.Margin = New Padding(10, 0, 0, 0)
        btnSave.MinimumSize = New Size(120, 40)
        btnSave.Name = "btnSave"
        btnSave.Padding = New Padding(14, 0, 14, 0)
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.AutoSize = True
        btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnBack.BackColor = Color.White
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnBack.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBack.Margin = New Padding(10, 0, 0, 0)
        btnBack.MinimumSize = New Size(120, 40)
        btnBack.Name = "btnBack"
        btnBack.Padding = New Padding(14, 0, 14, 0)
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' flpButtons
        ' 
        flpButtons.AutoSize = True
        flpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpButtons.Controls.Add(btnSave)
        flpButtons.Controls.Add(btnBack)
        flpButtons.Dock = DockStyle.Fill
        flpButtons.FlowDirection = FlowDirection.RightToLeft
        flpButtons.Margin = New Padding(0, 28, 0, 0)
        flpButtons.Name = "flpButtons"
        flpButtons.WrapContents = False
        ' 
        ' tlpForm
        ' 
        tlpForm.ColumnCount = 1
        tlpForm.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpForm.Controls.Add(tlpHeadRow, 0, 0)
        tlpForm.Controls.Add(lblSubtitle, 0, 1)
        tlpForm.Controls.Add(lblSecInfo, 0, 2)
        tlpForm.Controls.Add(tlpInfo, 0, 3)
        tlpForm.Controls.Add(lblSecDocs, 0, 4)
        tlpForm.Controls.Add(pnlItemsBorder, 0, 5)
        tlpForm.Controls.Add(lblSecPayment, 0, 6)
        tlpForm.Controls.Add(tlpPayment, 0, 7)
        tlpForm.Controls.Add(lblSecStatus, 0, 8)
        tlpForm.Controls.Add(tlpStatus, 0, 9)
        tlpForm.Controls.Add(lblStatusHint, 0, 10)
        tlpForm.Controls.Add(flpButtons, 0, 11)
        tlpForm.Dock = DockStyle.Fill
        tlpForm.Name = "tlpForm"
        tlpForm.RowCount = 12
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
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        ' 
        ' cardForm
        ' 
        cardForm.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cardForm.BackColor = Color.White
        cardForm.Controls.Add(tlpForm)
        cardForm.Location = New Point(28, 24)
        cardForm.Name = "cardForm"
        cardForm.Padding = New Padding(32, 28, 32, 32)
        cardForm.Size = New Size(860, 640)
        ' 
        ' frmRequestDetails
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 700)
        Controls.Add(cardForm)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmRequestDetails"
        Text = "Request Details"
        tlpHeadRow.ResumeLayout(False)
        tlpHeadRow.PerformLayout()
        tlpInfo.ResumeLayout(False)
        tlpInfo.PerformLayout()
        pnlItemsBorder.ResumeLayout(False)
        tlpPayment.ResumeLayout(False)
        tlpPayment.PerformLayout()
        tlpStatus.ResumeLayout(False)
        tlpStatus.PerformLayout()
        flpButtons.ResumeLayout(False)
        flpButtons.PerformLayout()
        tlpForm.ResumeLayout(False)
        tlpForm.PerformLayout()
        cardForm.ResumeLayout(False)
        cardForm.PerformLayout()
        CType(dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblRequestNo As Label
    Friend WithEvents lblStatusBadge As Label
    Friend WithEvents tlpHeadRow As TableLayoutPanel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblSecInfo As Label
    Friend WithEvents lblCapStudentNo As Label
    Friend WithEvents lblStudentNo As Label
    Friend WithEvents lblCapStudentName As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblCapRequestDate As Label
    Friend WithEvents lblRequestDate As Label
    Friend WithEvents lblCapCreatedBy As Label
    Friend WithEvents lblCreatedBy As Label
    Friend WithEvents tlpInfo As TableLayoutPanel
    Friend WithEvents lblSecDocs As Label
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents pnlItemsBorder As Panel
    Friend WithEvents lblSecPayment As Label
    Friend WithEvents lblCapTotal As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblCapPayment As Label
    Friend WithEvents cboPaymentStatus As ComboBox
    Friend WithEvents lblCapOrNo As Label
    Friend WithEvents lblOrNo As Label
    Friend WithEvents lblCapOrDate As Label
    Friend WithEvents lblOrDate As Label
    Friend WithEvents tlpPayment As TableLayoutPanel
    Friend WithEvents lblSecStatus As Label
    Friend WithEvents lblCapStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents tlpStatus As TableLayoutPanel
    Friend WithEvents lblStatusHint As Label
    Friend WithEvents btnSave As ThemedButton
    Friend WithEvents btnBack As ThemedButton
    Friend WithEvents flpButtons As FlowLayoutPanel
    Friend WithEvents tlpForm As TableLayoutPanel
    Friend WithEvents cardForm As CardPanel

End Class
