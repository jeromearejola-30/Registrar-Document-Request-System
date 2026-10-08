<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditDocument
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
        btnSaveEdit = New ThemedButton()
        btnCancel = New ThemedButton()
        btnDeleteDocument = New ThemedButton()
        flpButtons = New FlowLayoutPanel()
        tlpButtons = New TableLayoutPanel()
        tlpForm = New TableLayoutPanel()
        cardForm = New CardPanel()
        tlpDetails.SuspendLayout()
        flpButtons.SuspendLayout()
        tlpButtons.SuspendLayout()
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
        lblSubtitle.Size = New Size(449, 17)
        lblSubtitle.TabIndex = 0
        lblSubtitle.Text = "Update the details of this document. Changes apply to future requests only."
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
        btnSaveEdit.Location = New Point(140, 0)
        btnSaveEdit.Margin = New Padding(10, 0, 0, 0)
        btnSaveEdit.MinimumSize = New Size(120, 40)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Padding = New Padding(14, 0, 14, 0)
        btnSaveEdit.Size = New Size(139, 40)
        btnSaveEdit.TabIndex = 0
        btnSaveEdit.Text = "Save Changes"
        btnSaveEdit.UseVisualStyleBackColor = False
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
        btnCancel.Location = New Point(10, 0)
        btnCancel.Margin = New Padding(10, 0, 0, 0)
        btnCancel.MinimumSize = New Size(120, 40)
        btnCancel.Name = "btnCancel"
        btnCancel.Padding = New Padding(14, 0, 14, 0)
        btnCancel.Size = New Size(120, 40)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteDocument
        ' 
        btnDeleteDocument.Anchor = AnchorStyles.Left
        btnDeleteDocument.AutoSize = True
        btnDeleteDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnDeleteDocument.BackColor = Color.White
        btnDeleteDocument.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnDeleteDocument.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(254), CByte(202), CByte(202))
        btnDeleteDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(254), CByte(226), CByte(226))
        btnDeleteDocument.FlatStyle = FlatStyle.Flat
        btnDeleteDocument.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnDeleteDocument.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnDeleteDocument.Location = New Point(0, 32)
        btnDeleteDocument.Margin = New Padding(0)
        btnDeleteDocument.MinimumSize = New Size(120, 40)
        btnDeleteDocument.Name = "btnDeleteDocument"
        btnDeleteDocument.Padding = New Padding(14, 0, 14, 0)
        btnDeleteDocument.Size = New Size(164, 40)
        btnDeleteDocument.TabIndex = 0
        btnDeleteDocument.Text = "Delete Document"
        btnDeleteDocument.UseVisualStyleBackColor = False
        ' 
        ' flpButtons
        ' 
        flpButtons.AutoSize = True
        flpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpButtons.Controls.Add(btnSaveEdit)
        flpButtons.Controls.Add(btnCancel)
        flpButtons.Dock = DockStyle.Fill
        flpButtons.FlowDirection = FlowDirection.RightToLeft
        flpButtons.Location = New Point(517, 0)
        flpButtons.Margin = New Padding(0)
        flpButtons.Name = "flpButtons"
        flpButtons.Size = New Size(279, 104)
        flpButtons.TabIndex = 1
        flpButtons.WrapContents = False
        ' 
        ' tlpButtons
        ' 
        tlpButtons.AutoSize = True
        tlpButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpButtons.ColumnCount = 2
        tlpButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpButtons.ColumnStyles.Add(New ColumnStyle())
        tlpButtons.Controls.Add(btnDeleteDocument, 0, 0)
        tlpButtons.Controls.Add(flpButtons, 1, 0)
        tlpButtons.Dock = DockStyle.Fill
        tlpButtons.Location = New Point(0, 316)
        tlpButtons.Margin = New Padding(0, 28, 0, 0)
        tlpButtons.Name = "tlpButtons"
        tlpButtons.RowCount = 1
        tlpButtons.RowStyles.Add(New RowStyle())
        tlpButtons.Size = New Size(796, 104)
        tlpButtons.TabIndex = 5
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
        tlpForm.Controls.Add(tlpButtons, 0, 5)
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
        ' frmEditDocument
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(cardForm)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEditDocument"
        Text = "Edit Document"
        tlpDetails.ResumeLayout(False)
        tlpDetails.PerformLayout()
        flpButtons.ResumeLayout(False)
        flpButtons.PerformLayout()
        tlpButtons.ResumeLayout(False)
        tlpButtons.PerformLayout()
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
    Friend WithEvents btnSaveEdit As ThemedButton
    Friend WithEvents btnCancel As ThemedButton
    Friend WithEvents btnDeleteDocument As ThemedButton
    Friend WithEvents flpButtons As FlowLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents tlpForm As TableLayoutPanel
    Friend WithEvents cardForm As CardPanel
End Class
