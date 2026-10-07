<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocumentManagement
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
        txtSearch = New TextBox()
        btnClearSearch = New Button()
        btnAddDocument = New Button()
        tlpToolbar = New TableLayoutPanel()
        lblGridTitle = New Label()
        dgvDocuments = New DataGridView()
        pnlGridBorder = New Panel()
        lblDescTitle = New Label()
        rtbDescription = New RichTextBox()
        tlpDesc = New TableLayoutPanel()
        cardDesc = New CardPanel()
        tlpCenter = New TableLayoutPanel()
        lblDocInfo = New Label()
        lblCapDocName = New Label()
        lblDocName = New Label()
        lblCapDocStatus = New Label()
        lblDocStatus = New Label()
        lblCapDocFee = New Label()
        lblDocFee = New Label()
        btnEditDocument = New Button()
        tlpInfo = New TableLayoutPanel()
        cardInfo = New CardPanel()
        lblDocStatusSummary = New Label()
        lblCapActive = New Label()
        lblActiveCount = New Label()
        lblCapInactive = New Label()
        lblInactiveCount = New Label()
        tlpStatus = New TableLayoutPanel()
        cardStatus = New CardPanel()
        tlpSummary = New TableLayoutPanel()
        tlpMain = New TableLayoutPanel()
        tlpToolbar.SuspendLayout()
        CType(dgvDocuments, ComponentModel.ISupportInitialize).BeginInit()
        pnlGridBorder.SuspendLayout()
        tlpDesc.SuspendLayout()
        cardDesc.SuspendLayout()
        tlpCenter.SuspendLayout()
        tlpInfo.SuspendLayout()
        cardInfo.SuspendLayout()
        tlpStatus.SuspendLayout()
        cardStatus.SuspendLayout()
        tlpSummary.SuspendLayout()
        tlpMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 11F)
        txtSearch.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        txtSearch.Location = New Point(0, 6)
        txtSearch.Margin = New Padding(0)
        txtSearch.MaximumSize = New Size(520, 0)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by document name..."
        txtSearch.Size = New Size(520, 27)
        txtSearch.TabIndex = 0
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
        btnClearSearch.Location = New Point(671, 0)
        btnClearSearch.Margin = New Padding(8, 0, 0, 0)
        btnClearSearch.MinimumSize = New Size(0, 40)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Padding = New Padding(14, 0, 14, 0)
        btnClearSearch.Size = New Size(127, 40)
        btnClearSearch.TabIndex = 1
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = False
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.AutoSize = True
        btnAddDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddDocument.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnAddDocument.Cursor = Cursors.Hand
        btnAddDocument.FlatAppearance.BorderSize = 0
        btnAddDocument.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(36), CByte(90), CByte(65))
        btnAddDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnAddDocument.FlatStyle = FlatStyle.Flat
        btnAddDocument.Font = New Font("Segoe UI Semibold", 10F)
        btnAddDocument.ForeColor = Color.White
        btnAddDocument.Location = New Point(806, 0)
        btnAddDocument.Margin = New Padding(8, 0, 0, 0)
        btnAddDocument.MinimumSize = New Size(0, 40)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Padding = New Padding(14, 0, 14, 0)
        btnAddDocument.Size = New Size(141, 40)
        btnAddDocument.TabIndex = 2
        btnAddDocument.Text = "Add Document"
        btnAddDocument.UseVisualStyleBackColor = False
        ' 
        ' tlpToolbar
        ' 
        tlpToolbar.AutoSize = True
        tlpToolbar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpToolbar.ColumnCount = 3
        tlpToolbar.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.Controls.Add(txtSearch, 0, 0)
        tlpToolbar.Controls.Add(btnClearSearch, 1, 0)
        tlpToolbar.Controls.Add(btnAddDocument, 2, 0)
        tlpToolbar.Dock = DockStyle.Fill
        tlpToolbar.Location = New Point(28, 20)
        tlpToolbar.Margin = New Padding(0)
        tlpToolbar.Name = "tlpToolbar"
        tlpToolbar.RowCount = 1
        tlpToolbar.RowStyles.Add(New RowStyle())
        tlpToolbar.Size = New Size(947, 40)
        tlpToolbar.TabIndex = 0
        ' 
        ' lblGridTitle
        ' 
        lblGridTitle.AutoSize = True
        lblGridTitle.Font = New Font("Segoe UI Semibold", 12F)
        lblGridTitle.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblGridTitle.Location = New Point(28, 76)
        lblGridTitle.Margin = New Padding(0, 16, 0, 8)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Size = New Size(116, 21)
        lblGridTitle.TabIndex = 1
        lblGridTitle.Text = "All Documents"
        ' 
        ' dgvDocuments
        ' 
        dgvDocuments.Dock = DockStyle.Fill
        dgvDocuments.Location = New Point(1, 1)
        dgvDocuments.Name = "dgvDocuments"
        dgvDocuments.Size = New Size(585, 353)
        dgvDocuments.TabIndex = 0
        ' 
        ' pnlGridBorder
        ' 
        pnlGridBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlGridBorder.Controls.Add(dgvDocuments)
        pnlGridBorder.Dock = DockStyle.Fill
        pnlGridBorder.Location = New Point(0, 0)
        pnlGridBorder.Margin = New Padding(0)
        pnlGridBorder.Name = "pnlGridBorder"
        pnlGridBorder.Padding = New Padding(1)
        pnlGridBorder.Size = New Size(587, 355)
        pnlGridBorder.TabIndex = 0
        ' 
        ' lblDescTitle
        ' 
        lblDescTitle.AutoSize = True
        lblDescTitle.Font = New Font("Segoe UI Semibold", 11F)
        lblDescTitle.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblDescTitle.Location = New Point(0, 0)
        lblDescTitle.Margin = New Padding(0, 0, 0, 8)
        lblDescTitle.Name = "lblDescTitle"
        lblDescTitle.Size = New Size(162, 20)
        lblDescTitle.TabIndex = 0
        lblDescTitle.Text = "Document Description"
        ' 
        ' rtbDescription
        ' 
        rtbDescription.BackColor = Color.White
        rtbDescription.BorderStyle = BorderStyle.None
        rtbDescription.Dock = DockStyle.Fill
        rtbDescription.Font = New Font("Segoe UI", 10.5F)
        rtbDescription.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        rtbDescription.Location = New Point(0, 28)
        rtbDescription.Margin = New Padding(0)
        rtbDescription.Name = "rtbDescription"
        rtbDescription.ReadOnly = True
        rtbDescription.Size = New Size(304, 299)
        rtbDescription.TabIndex = 1
        rtbDescription.TabStop = False
        rtbDescription.Text = ""
        ' 
        ' tlpDesc
        ' 
        tlpDesc.ColumnCount = 1
        tlpDesc.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpDesc.Controls.Add(lblDescTitle, 0, 0)
        tlpDesc.Controls.Add(rtbDescription, 0, 1)
        tlpDesc.Dock = DockStyle.Fill
        tlpDesc.Location = New Point(20, 14)
        tlpDesc.Margin = New Padding(0)
        tlpDesc.Name = "tlpDesc"
        tlpDesc.RowCount = 2
        tlpDesc.RowStyles.Add(New RowStyle())
        tlpDesc.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpDesc.Size = New Size(304, 327)
        tlpDesc.TabIndex = 0
        ' 
        ' cardDesc
        ' 
        cardDesc.BackColor = Color.White
        cardDesc.Controls.Add(tlpDesc)
        cardDesc.Dock = DockStyle.Fill
        cardDesc.Location = New Point(603, 0)
        cardDesc.Margin = New Padding(16, 0, 0, 0)
        cardDesc.Name = "cardDesc"
        cardDesc.Padding = New Padding(20, 14, 20, 14)
        cardDesc.Size = New Size(344, 355)
        cardDesc.TabIndex = 1
        ' 
        ' tlpCenter
        ' 
        tlpCenter.ColumnCount = 2
        tlpCenter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 62F))
        tlpCenter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38F))
        tlpCenter.Controls.Add(pnlGridBorder, 0, 0)
        tlpCenter.Controls.Add(cardDesc, 1, 0)
        tlpCenter.Dock = DockStyle.Fill
        tlpCenter.Location = New Point(28, 105)
        tlpCenter.Margin = New Padding(0)
        tlpCenter.Name = "tlpCenter"
        tlpCenter.RowCount = 1
        tlpCenter.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpCenter.Size = New Size(947, 355)
        tlpCenter.TabIndex = 2
        ' 
        ' lblDocInfo
        ' 
        lblDocInfo.AutoSize = True
        tlpInfo.SetColumnSpan(lblDocInfo, 2)
        lblDocInfo.Font = New Font("Segoe UI Semibold", 11F)
        lblDocInfo.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblDocInfo.Location = New Point(0, 0)
        lblDocInfo.Margin = New Padding(0, 0, 0, 8)
        lblDocInfo.Name = "lblDocInfo"
        lblDocInfo.Size = New Size(165, 20)
        lblDocInfo.TabIndex = 0
        lblDocInfo.Text = "Document Information"
        ' 
        ' lblCapDocName
        ' 
        lblCapDocName.AutoSize = True
        lblCapDocName.Font = New Font("Segoe UI", 10F)
        lblCapDocName.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapDocName.Location = New Point(0, 31)
        lblCapDocName.Margin = New Padding(0, 3, 0, 3)
        lblCapDocName.Name = "lblCapDocName"
        lblCapDocName.Size = New Size(113, 19)
        lblCapDocName.TabIndex = 1
        lblCapDocName.Text = "Document Name"
        ' 
        ' lblDocName
        ' 
        lblDocName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDocName.AutoEllipsis = True
        lblDocName.Font = New Font("Segoe UI Semibold", 10.5F)
        lblDocName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblDocName.Location = New Point(130, 31)
        lblDocName.Margin = New Padding(0, 3, 0, 3)
        lblDocName.Name = "lblDocName"
        lblDocName.Size = New Size(295, 22)
        lblDocName.TabIndex = 2
        lblDocName.Text = "-"
        ' 
        ' lblCapDocStatus
        ' 
        lblCapDocStatus.AutoSize = True
        lblCapDocStatus.Font = New Font("Segoe UI", 10F)
        lblCapDocStatus.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapDocStatus.Location = New Point(0, 59)
        lblCapDocStatus.Margin = New Padding(0, 3, 0, 3)
        lblCapDocStatus.Name = "lblCapDocStatus"
        lblCapDocStatus.Size = New Size(47, 19)
        lblCapDocStatus.TabIndex = 3
        lblCapDocStatus.Text = "Status"
        ' 
        ' lblDocStatus
        ' 
        lblDocStatus.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDocStatus.AutoEllipsis = True
        lblDocStatus.Font = New Font("Segoe UI Semibold", 10.5F)
        lblDocStatus.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblDocStatus.Location = New Point(130, 59)
        lblDocStatus.Margin = New Padding(0, 3, 0, 3)
        lblDocStatus.Name = "lblDocStatus"
        lblDocStatus.Size = New Size(295, 22)
        lblDocStatus.TabIndex = 4
        lblDocStatus.Text = "-"
        ' 
        ' lblCapDocFee
        ' 
        lblCapDocFee.AutoSize = True
        lblCapDocFee.Font = New Font("Segoe UI", 10F)
        lblCapDocFee.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapDocFee.Location = New Point(0, 87)
        lblCapDocFee.Margin = New Padding(0, 3, 0, 3)
        lblCapDocFee.Name = "lblCapDocFee"
        lblCapDocFee.Size = New Size(30, 19)
        lblCapDocFee.TabIndex = 5
        lblCapDocFee.Text = "Fee"
        ' 
        ' lblDocFee
        ' 
        lblDocFee.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblDocFee.AutoEllipsis = True
        lblDocFee.Font = New Font("Segoe UI Semibold", 10.5F)
        lblDocFee.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblDocFee.Location = New Point(130, 87)
        lblDocFee.Margin = New Padding(0, 3, 0, 3)
        lblDocFee.Name = "lblDocFee"
        lblDocFee.Size = New Size(295, 22)
        lblDocFee.TabIndex = 6
        lblDocFee.Text = "-"
        ' 
        ' btnEditDocument
        ' 
        btnEditDocument.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnEditDocument.AutoSize = True
        btnEditDocument.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEditDocument.BackColor = Color.White
        tlpInfo.SetColumnSpan(btnEditDocument, 2)
        btnEditDocument.Cursor = Cursors.Hand
        btnEditDocument.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnEditDocument.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnEditDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnEditDocument.FlatStyle = FlatStyle.Flat
        btnEditDocument.Font = New Font("Segoe UI Semibold", 10F)
        btnEditDocument.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnEditDocument.Location = New Point(0, 121)
        btnEditDocument.Margin = New Padding(0, 8, 0, 0)
        btnEditDocument.MinimumSize = New Size(0, 15)
        btnEditDocument.Name = "btnEditDocument"
        btnEditDocument.Padding = New Padding(14, 0, 14, 0)
        btnEditDocument.Size = New Size(142, 31)
        btnEditDocument.TabIndex = 7
        btnEditDocument.Text = "Edit Document"
        btnEditDocument.UseVisualStyleBackColor = False
        ' 
        ' tlpInfo
        ' 
        tlpInfo.ColumnCount = 2
        tlpInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 130F))
        tlpInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpInfo.Controls.Add(lblDocInfo, 0, 0)
        tlpInfo.Controls.Add(lblCapDocName, 0, 1)
        tlpInfo.Controls.Add(lblDocName, 1, 1)
        tlpInfo.Controls.Add(lblCapDocStatus, 0, 2)
        tlpInfo.Controls.Add(lblDocStatus, 1, 2)
        tlpInfo.Controls.Add(lblCapDocFee, 0, 3)
        tlpInfo.Controls.Add(lblDocFee, 1, 3)
        tlpInfo.Controls.Add(btnEditDocument, 0, 4)
        tlpInfo.Dock = DockStyle.Fill
        tlpInfo.Location = New Point(20, 14)
        tlpInfo.Margin = New Padding(0)
        tlpInfo.Name = "tlpInfo"
        tlpInfo.RowCount = 5
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpInfo.Size = New Size(425, 152)
        tlpInfo.TabIndex = 0
        ' 
        ' cardInfo
        ' 
        cardInfo.BackColor = Color.White
        cardInfo.Controls.Add(tlpInfo)
        cardInfo.Dock = DockStyle.Fill
        cardInfo.Location = New Point(0, 0)
        cardInfo.Margin = New Padding(0, 0, 8, 0)
        cardInfo.Name = "cardInfo"
        cardInfo.Padding = New Padding(20, 14, 20, 14)
        cardInfo.Size = New Size(465, 180)
        cardInfo.TabIndex = 0
        ' 
        ' lblDocStatusSummary
        ' 
        lblDocStatusSummary.AutoSize = True
        tlpStatus.SetColumnSpan(lblDocStatusSummary, 2)
        lblDocStatusSummary.Font = New Font("Segoe UI Semibold", 11F)
        lblDocStatusSummary.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblDocStatusSummary.Location = New Point(0, 0)
        lblDocStatusSummary.Margin = New Padding(0, 0, 0, 8)
        lblDocStatusSummary.Name = "lblDocStatusSummary"
        lblDocStatusSummary.Size = New Size(195, 20)
        lblDocStatusSummary.TabIndex = 0
        lblDocStatusSummary.Text = "Document Status Summary"
        ' 
        ' lblCapActive
        ' 
        lblCapActive.AutoSize = True
        lblCapActive.Font = New Font("Segoe UI", 10F)
        lblCapActive.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapActive.Location = New Point(0, 31)
        lblCapActive.Margin = New Padding(0, 3, 0, 3)
        lblCapActive.Name = "lblCapActive"
        lblCapActive.Size = New Size(120, 19)
        lblCapActive.TabIndex = 1
        lblCapActive.Text = "Active Documents"
        ' 
        ' lblActiveCount
        ' 
        lblActiveCount.Anchor = AnchorStyles.Right
        lblActiveCount.AutoSize = True
        lblActiveCount.Font = New Font("Segoe UI Semibold", 10.5F)
        lblActiveCount.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblActiveCount.Location = New Point(409, 31)
        lblActiveCount.Margin = New Padding(0, 3, 0, 3)
        lblActiveCount.Name = "lblActiveCount"
        lblActiveCount.Size = New Size(17, 19)
        lblActiveCount.TabIndex = 2
        lblActiveCount.Text = "0"
        ' 
        ' lblCapInactive
        ' 
        lblCapInactive.AutoSize = True
        lblCapInactive.Font = New Font("Segoe UI", 10F)
        lblCapInactive.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapInactive.Location = New Point(0, 56)
        lblCapInactive.Margin = New Padding(0, 3, 0, 3)
        lblCapInactive.Name = "lblCapInactive"
        lblCapInactive.Size = New Size(130, 19)
        lblCapInactive.TabIndex = 3
        lblCapInactive.Text = "Inactive Documents"
        ' 
        ' lblInactiveCount
        ' 
        lblInactiveCount.Anchor = AnchorStyles.Right
        lblInactiveCount.AutoSize = True
        lblInactiveCount.Font = New Font("Segoe UI Semibold", 10.5F)
        lblInactiveCount.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblInactiveCount.Location = New Point(409, 56)
        lblInactiveCount.Margin = New Padding(0, 3, 0, 3)
        lblInactiveCount.Name = "lblInactiveCount"
        lblInactiveCount.Size = New Size(17, 19)
        lblInactiveCount.TabIndex = 4
        lblInactiveCount.Text = "0"
        ' 
        ' tlpStatus
        ' 
        tlpStatus.ColumnCount = 2
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpStatus.ColumnStyles.Add(New ColumnStyle())
        tlpStatus.Controls.Add(lblDocStatusSummary, 0, 0)
        tlpStatus.Controls.Add(lblCapActive, 0, 1)
        tlpStatus.Controls.Add(lblActiveCount, 1, 1)
        tlpStatus.Controls.Add(lblCapInactive, 0, 2)
        tlpStatus.Controls.Add(lblInactiveCount, 1, 2)
        tlpStatus.Dock = DockStyle.Fill
        tlpStatus.Location = New Point(20, 14)
        tlpStatus.Margin = New Padding(0)
        tlpStatus.Name = "tlpStatus"
        tlpStatus.RowCount = 4
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpStatus.Size = New Size(426, 152)
        tlpStatus.TabIndex = 0
        ' 
        ' cardStatus
        ' 
        cardStatus.BackColor = Color.White
        cardStatus.Controls.Add(tlpStatus)
        cardStatus.Dock = DockStyle.Fill
        cardStatus.Location = New Point(481, 0)
        cardStatus.Margin = New Padding(8, 0, 0, 0)
        cardStatus.Name = "cardStatus"
        cardStatus.Padding = New Padding(20, 14, 20, 14)
        cardStatus.Size = New Size(466, 180)
        cardStatus.TabIndex = 1
        ' 
        ' tlpSummary
        ' 
        tlpSummary.ColumnCount = 2
        tlpSummary.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpSummary.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpSummary.Controls.Add(cardInfo, 0, 0)
        tlpSummary.Controls.Add(cardStatus, 1, 0)
        tlpSummary.Dock = DockStyle.Fill
        tlpSummary.Location = New Point(28, 476)
        tlpSummary.Margin = New Padding(0, 16, 0, 0)
        tlpSummary.Name = "tlpSummary"
        tlpSummary.RowCount = 1
        tlpSummary.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpSummary.Size = New Size(947, 180)
        tlpSummary.TabIndex = 3
        ' 
        ' tlpMain
        ' 
        tlpMain.ColumnCount = 1
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpMain.Controls.Add(tlpToolbar, 0, 0)
        tlpMain.Controls.Add(lblGridTitle, 0, 1)
        tlpMain.Controls.Add(tlpCenter, 0, 2)
        tlpMain.Controls.Add(tlpSummary, 0, 3)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Location = New Point(0, 0)
        tlpMain.Name = "tlpMain"
        tlpMain.Padding = New Padding(28, 20, 28, 24)
        tlpMain.RowCount = 4
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 196F))
        tlpMain.Size = New Size(1003, 680)
        tlpMain.TabIndex = 0
        ' 
        ' frmDocumentManagement
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(860, 680)
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(tlpMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDocumentManagement"
        Text = "Document Management"
        tlpToolbar.ResumeLayout(False)
        tlpToolbar.PerformLayout()
        CType(dgvDocuments, ComponentModel.ISupportInitialize).EndInit()
        pnlGridBorder.ResumeLayout(False)
        tlpDesc.ResumeLayout(False)
        tlpDesc.PerformLayout()
        cardDesc.ResumeLayout(False)
        tlpCenter.ResumeLayout(False)
        tlpInfo.ResumeLayout(False)
        tlpInfo.PerformLayout()
        cardInfo.ResumeLayout(False)
        tlpStatus.ResumeLayout(False)
        tlpStatus.PerformLayout()
        cardStatus.ResumeLayout(False)
        tlpSummary.ResumeLayout(False)
        tlpMain.ResumeLayout(False)
        tlpMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents tlpToolbar As TableLayoutPanel
    Friend WithEvents lblGridTitle As Label
    Friend WithEvents dgvDocuments As DataGridView
    Friend WithEvents pnlGridBorder As Panel
    Friend WithEvents lblDescTitle As Label
    Friend WithEvents rtbDescription As RichTextBox
    Friend WithEvents tlpDesc As TableLayoutPanel
    Friend WithEvents cardDesc As CardPanel
    Friend WithEvents tlpCenter As TableLayoutPanel
    Friend WithEvents lblDocInfo As Label
    Friend WithEvents lblCapDocName As Label
    Friend WithEvents lblDocName As Label
    Friend WithEvents lblCapDocStatus As Label
    Friend WithEvents lblDocStatus As Label
    Friend WithEvents lblCapDocFee As Label
    Friend WithEvents lblDocFee As Label
    Friend WithEvents btnEditDocument As Button
    Friend WithEvents tlpInfo As TableLayoutPanel
    Friend WithEvents cardInfo As CardPanel
    Friend WithEvents lblDocStatusSummary As Label
    Friend WithEvents lblCapActive As Label
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents lblCapInactive As Label
    Friend WithEvents lblInactiveCount As Label
    Friend WithEvents tlpStatus As TableLayoutPanel
    Friend WithEvents cardStatus As CardPanel
    Friend WithEvents tlpSummary As TableLayoutPanel
    Friend WithEvents tlpMain As TableLayoutPanel
End Class
