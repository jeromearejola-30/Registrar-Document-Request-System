<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddDocument
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
        lblSecDetails = New Label()
        lblCapDocName = New Label()
        txtDocName = New TextBox()
        lblCapDocFee = New Label()
        txtDocFee = New TextBox()
        lblCapDocStatus = New Label()
        cboDocStatus = New ComboBox()
        tlpDetails = New TableLayoutPanel()
        lblSecDescription = New Label()
        txtDocDescription = New TextBox()
        btnAddDocument = New ThemedButton()
        btnClearAll = New ThemedButton()
        btnCancel = New ThemedButton()
        flpButtons = New FlowLayoutPanel()
        tlpForm = New TableLayoutPanel()
        cardForm = New CardPanel()
        tlpDetails.SuspendLayout()
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
        lblSubtitle.Size = New Size(344, 17)
        lblSubtitle.TabIndex = 0
        lblSubtitle.Text = "Fill in the details below. Fields marked with * are required."
        ' 
        ' lblSecDetails
        ' 
        lblSecDetails.AutoSize = True
        lblSecDetails.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecDetails.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecDetails.Location = New Point(0, 31)
        lblSecDetails.Margin = New Padding(0, 14, 0, 8)
        lblSecDetails.Name = "lblSecDetails"
        lblSecDetails.Size = New Size(139, 21)
        lblSecDetails.TabIndex = 1
        lblSecDetails.Text = "Document Details"
        ' 
        ' lblCapDocName
        ' 
        lblCapDocName.AutoSize = True
        lblCapDocName.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapDocName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapDocName.Location = New Point(0, 0)
        lblCapDocName.Margin = New Padding(0, 0, 0, 4)
        lblCapDocName.Name = "lblCapDocName"
        lblCapDocName.Size = New Size(121, 17)
        lblCapDocName.TabIndex = 0
        lblCapDocName.Text = "Document Name *"
        ' 
        ' txtDocName
        ' 
        txtDocName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDocName.BorderStyle = BorderStyle.FixedSingle
        txtDocName.Font = New Font("Segoe UI", 10.5F)
        txtDocName.Location = New Point(0, 21)
        txtDocName.Margin = New Padding(0, 0, 16, 0)
        txtDocName.MaxLength = 100
        txtDocName.Name = "txtDocName"
        txtDocName.Size = New Size(382, 26)
        txtDocName.TabIndex = 1
        ' 
        ' lblCapDocFee
        ' 
        lblCapDocFee.AutoSize = True
        lblCapDocFee.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapDocFee.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapDocFee.Location = New Point(398, 0)
        lblCapDocFee.Margin = New Padding(0, 0, 0, 4)
        lblCapDocFee.Name = "lblCapDocFee"
        lblCapDocFee.Size = New Size(59, 17)
        lblCapDocFee.TabIndex = 2
        lblCapDocFee.Text = "Fee (₱) *"
        ' 
        ' txtDocFee
        ' 
        txtDocFee.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDocFee.BorderStyle = BorderStyle.FixedSingle
        txtDocFee.Font = New Font("Segoe UI", 10.5F)
        txtDocFee.Location = New Point(398, 21)
        txtDocFee.Margin = New Padding(0, 0, 16, 0)
        txtDocFee.MaxLength = 12
        txtDocFee.Name = "txtDocFee"
        txtDocFee.Size = New Size(183, 26)
        txtDocFee.TabIndex = 3
        ' 
        ' lblCapDocStatus
        ' 
        lblCapDocStatus.AutoSize = True
        lblCapDocStatus.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapDocStatus.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapDocStatus.Location = New Point(597, 0)
        lblCapDocStatus.Margin = New Padding(0, 0, 0, 4)
        lblCapDocStatus.Name = "lblCapDocStatus"
        lblCapDocStatus.Size = New Size(46, 17)
        lblCapDocStatus.TabIndex = 4
        lblCapDocStatus.Text = "Status"
        ' 
        ' cboDocStatus
        ' 
        cboDocStatus.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboDocStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboDocStatus.Font = New Font("Segoe UI", 10.5F)
        cboDocStatus.FormattingEnabled = True
        cboDocStatus.Location = New Point(597, 22)
        cboDocStatus.Margin = New Padding(0)
        cboDocStatus.Name = "cboDocStatus"
        cboDocStatus.Size = New Size(199, 27)
        cboDocStatus.TabIndex = 5
        ' 
        ' tlpDetails
        ' 
        tlpDetails.AutoSize = True
        tlpDetails.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpDetails.ColumnCount = 3
        tlpDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpDetails.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpDetails.Controls.Add(lblCapDocName, 0, 0)
        tlpDetails.Controls.Add(txtDocName, 0, 1)
        tlpDetails.Controls.Add(lblCapDocFee, 1, 0)
        tlpDetails.Controls.Add(txtDocFee, 1, 1)
        tlpDetails.Controls.Add(lblCapDocStatus, 2, 0)
        tlpDetails.Controls.Add(cboDocStatus, 2, 1)
        tlpDetails.Dock = DockStyle.Fill
        tlpDetails.Location = New Point(0, 60)
        tlpDetails.Margin = New Padding(0)
        tlpDetails.Name = "tlpDetails"
        tlpDetails.RowCount = 2
        tlpDetails.RowStyles.Add(New RowStyle())
        tlpDetails.RowStyles.Add(New RowStyle())
        tlpDetails.Size = New Size(796, 47)
        tlpDetails.TabIndex = 2
        ' 
        ' lblSecDescription
        ' 
        lblSecDescription.AutoSize = True
        lblSecDescription.Font = New Font("Segoe UI Semibold", 11.5F)
        lblSecDescription.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblSecDescription.Location = New Point(0, 129)
        lblSecDescription.Margin = New Padding(0, 22, 0, 8)
        lblSecDescription.Name = "lblSecDescription"
        lblSecDescription.Size = New Size(169, 21)
        lblSecDescription.TabIndex = 3
        lblSecDescription.Text = "Description (optional)"
        ' 
        ' txtDocDescription
        ' 
        txtDocDescription.BorderStyle = BorderStyle.FixedSingle
        txtDocDescription.Dock = DockStyle.Fill
        txtDocDescription.Font = New Font("Segoe UI", 10.5F)
        txtDocDescription.Location = New Point(0, 158)
        txtDocDescription.Margin = New Padding(0)
        txtDocDescription.MaxLength = 500
        txtDocDescription.MinimumSize = New Size(0, 130)
        txtDocDescription.Multiline = True
        txtDocDescription.Name = "txtDocDescription"
        txtDocDescription.PlaceholderText = "What is this document used for? Requirements, processing notes, etc."
        txtDocDescription.ScrollBars = ScrollBars.Vertical
        txtDocDescription.Size = New Size(796, 130)
        txtDocDescription.TabIndex = 4
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.AutoSize = True
        btnAddDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddDocument.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnAddDocument.FlatAppearance.BorderSize = 0
        btnAddDocument.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnAddDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnAddDocument.FlatStyle = FlatStyle.Flat
        btnAddDocument.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnAddDocument.ForeColor = Color.White
        btnAddDocument.Kind = ButtonKind.Primary
        btnAddDocument.Location = New Point(649, 0)
        btnAddDocument.Margin = New Padding(10, 0, 0, 0)
        btnAddDocument.MinimumSize = New Size(120, 40)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Padding = New Padding(14, 0, 14, 0)
        btnAddDocument.Size = New Size(147, 40)
        btnAddDocument.TabIndex = 0
        btnAddDocument.Text = "Add Document"
        btnAddDocument.UseVisualStyleBackColor = False
        ' 
        ' btnClearAll
        ' 
        btnClearAll.AutoSize = True
        btnClearAll.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClearAll.BackColor = Color.White
        btnClearAll.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClearAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnClearAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnClearAll.FlatStyle = FlatStyle.Flat
        btnClearAll.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClearAll.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClearAll.Location = New Point(519, 0)
        btnClearAll.Margin = New Padding(10, 0, 0, 0)
        btnClearAll.MinimumSize = New Size(120, 40)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Padding = New Padding(14, 0, 14, 0)
        btnClearAll.Size = New Size(120, 40)
        btnClearAll.TabIndex = 1
        btnClearAll.Text = "Clear All"
        btnClearAll.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.AutoSize = True
        btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCancel.BackColor = Color.White
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCancel.Location = New Point(389, 0)
        btnCancel.Margin = New Padding(10, 0, 0, 0)
        btnCancel.MinimumSize = New Size(120, 40)
        btnCancel.Name = "btnCancel"
        btnCancel.Padding = New Padding(14, 0, 14, 0)
        btnCancel.Size = New Size(120, 40)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' flpButtons
        ' 
        flpButtons.AutoSize = True
        flpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpButtons.Controls.Add(btnAddDocument)
        flpButtons.Controls.Add(btnClearAll)
        flpButtons.Controls.Add(btnCancel)
        flpButtons.Dock = DockStyle.Fill
        flpButtons.FlowDirection = FlowDirection.RightToLeft
        flpButtons.Location = New Point(0, 316)
        flpButtons.Margin = New Padding(0, 28, 0, 0)
        flpButtons.Name = "flpButtons"
        flpButtons.Size = New Size(796, 104)
        flpButtons.TabIndex = 5
        flpButtons.WrapContents = False
        ' 
        ' tlpForm
        ' 
        tlpForm.ColumnCount = 1
        tlpForm.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpForm.Controls.Add(lblSubtitle, 0, 0)
        tlpForm.Controls.Add(lblSecDetails, 0, 1)
        tlpForm.Controls.Add(tlpDetails, 0, 2)
        tlpForm.Controls.Add(lblSecDescription, 0, 3)
        tlpForm.Controls.Add(txtDocDescription, 0, 4)
        tlpForm.Controls.Add(flpButtons, 0, 5)
        tlpForm.Dock = DockStyle.Fill
        tlpForm.Location = New Point(32, 28)
        tlpForm.Margin = New Padding(0)
        tlpForm.Name = "tlpForm"
        tlpForm.RowCount = 6
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.Size = New Size(796, 420)
        tlpForm.TabIndex = 0
        ' 
        ' cardForm
        ' 
        cardForm.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cardForm.BackColor = Color.White
        cardForm.Controls.Add(tlpForm)
        cardForm.Location = New Point(28, 24)
        cardForm.Name = "cardForm"
        cardForm.Padding = New Padding(32, 28, 32, 32)
        cardForm.Size = New Size(860, 480)
        cardForm.TabIndex = 0
        ' 
        ' frmAddDocument
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(cardForm)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAddDocument"
        Text = "Add Document"
        tlpDetails.ResumeLayout(False)
        tlpDetails.PerformLayout()
        flpButtons.ResumeLayout(False)
        flpButtons.PerformLayout()
        tlpForm.ResumeLayout(False)
        tlpForm.PerformLayout()
        cardForm.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblSecDetails As Label
    Friend WithEvents lblCapDocName As Label
    Friend WithEvents txtDocName As TextBox
    Friend WithEvents lblCapDocFee As Label
    Friend WithEvents txtDocFee As TextBox
    Friend WithEvents lblCapDocStatus As Label
    Friend WithEvents cboDocStatus As ComboBox
    Friend WithEvents tlpDetails As TableLayoutPanel
    Friend WithEvents lblSecDescription As Label
    Friend WithEvents txtDocDescription As TextBox
    Friend WithEvents btnAddDocument As ThemedButton
    Friend WithEvents btnClearAll As ThemedButton
    Friend WithEvents btnCancel As ThemedButton
    Friend WithEvents flpButtons As FlowLayoutPanel
    Friend WithEvents tlpForm As TableLayoutPanel
    Friend WithEvents cardForm As CardPanel
End Class
