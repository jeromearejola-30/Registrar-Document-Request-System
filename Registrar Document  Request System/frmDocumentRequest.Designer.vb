<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocumentRequest
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
        cboFilterByDocType = New ComboBox()
        btnClearSearch = New Button()
        btnViewRequest = New Button()
        btnCreateRequest = New Button()
        tlpToolbar = New TableLayoutPanel()
        cardAll = New StatCard()
        cardPending = New StatCard()
        cardProcessing = New StatCard()
        cardReadyForRelease = New StatCard()
        cardReleased = New StatCard()
        cardCancelled = New StatCard()
        tlpStatus = New TableLayoutPanel()
        lblAllDocRequest = New Label()
        lblDocTypeDate = New Label()
        tlpHead = New TableLayoutPanel()
        dgvRequests = New DataGridView()
        pnlGridBorder = New Panel()
        tlpMain = New TableLayoutPanel()
        tlpToolbar.SuspendLayout()
        tlpStatus.SuspendLayout()
        tlpHead.SuspendLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).BeginInit()
        pnlGridBorder.SuspendLayout()
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
        txtSearch.PlaceholderText = "Search request no., student, document, date..."
        txtSearch.Size = New Size(212, 27)
        txtSearch.TabIndex = 0
        ' 
        ' cboFilterByDocType
        ' 
        cboFilterByDocType.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboFilterByDocType.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterByDocType.Font = New Font("Segoe UI", 10.5F)
        cboFilterByDocType.FormattingEnabled = True
        cboFilterByDocType.Location = New Point(224, 8)
        cboFilterByDocType.Margin = New Padding(12, 0, 0, 0)
        cboFilterByDocType.Name = "cboFilterByDocType"
        cboFilterByDocType.Size = New Size(240, 27)
        cboFilterByDocType.TabIndex = 1
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
        btnClearSearch.Location = New Point(472, 0)
        btnClearSearch.Margin = New Padding(8, 0, 0, 0)
        btnClearSearch.MinimumSize = New Size(0, 40)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Padding = New Padding(14, 0, 14, 0)
        btnClearSearch.Size = New Size(127, 40)
        btnClearSearch.TabIndex = 2
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = False
        ' 
        ' btnViewRequest
        ' 
        btnViewRequest.AutoSize = True
        btnViewRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnViewRequest.BackColor = Color.White
        btnViewRequest.Cursor = Cursors.Hand
        btnViewRequest.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnViewRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnViewRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnViewRequest.FlatStyle = FlatStyle.Flat
        btnViewRequest.Font = New Font("Segoe UI Semibold", 10F)
        btnViewRequest.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnViewRequest.Location = New Point(607, 0)
        btnViewRequest.Margin = New Padding(8, 0, 0, 0)
        btnViewRequest.MinimumSize = New Size(0, 40)
        btnViewRequest.Name = "btnViewRequest"
        btnViewRequest.Padding = New Padding(14, 0, 14, 0)
        btnViewRequest.Size = New Size(139, 40)
        btnViewRequest.TabIndex = 3
        btnViewRequest.Text = "View / Update"
        btnViewRequest.UseVisualStyleBackColor = False
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.AutoSize = True
        btnCreateRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCreateRequest.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCreateRequest.Cursor = Cursors.Hand
        btnCreateRequest.FlatAppearance.BorderSize = 0
        btnCreateRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(36), CByte(90), CByte(65))
        btnCreateRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnCreateRequest.FlatStyle = FlatStyle.Flat
        btnCreateRequest.Font = New Font("Segoe UI Semibold", 10F)
        btnCreateRequest.ForeColor = Color.White
        btnCreateRequest.Location = New Point(754, 0)
        btnCreateRequest.Margin = New Padding(8, 0, 0, 0)
        btnCreateRequest.MinimumSize = New Size(0, 40)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Padding = New Padding(14, 0, 14, 0)
        btnCreateRequest.Size = New Size(210, 40)
        btnCreateRequest.TabIndex = 4
        btnCreateRequest.Text = "Create Document Request"
        btnCreateRequest.UseVisualStyleBackColor = False
        ' 
        ' tlpToolbar
        ' 
        tlpToolbar.AutoSize = True
        tlpToolbar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpToolbar.ColumnCount = 5
        tlpToolbar.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpToolbar.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 252F))
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.Controls.Add(txtSearch, 0, 0)
        tlpToolbar.Controls.Add(cboFilterByDocType, 1, 0)
        tlpToolbar.Controls.Add(btnClearSearch, 2, 0)
        tlpToolbar.Controls.Add(btnViewRequest, 3, 0)
        tlpToolbar.Controls.Add(btnCreateRequest, 4, 0)
        tlpToolbar.Dock = DockStyle.Fill
        tlpToolbar.Location = New Point(28, 20)
        tlpToolbar.Margin = New Padding(0)
        tlpToolbar.Name = "tlpToolbar"
        tlpToolbar.RowCount = 1
        tlpToolbar.RowStyles.Add(New RowStyle())
        tlpToolbar.Size = New Size(964, 40)
        tlpToolbar.TabIndex = 0
        ' 
        ' cardAll
        ' 
        cardAll.AccentColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        cardAll.Cursor = Cursors.Hand
        cardAll.Dock = DockStyle.Fill
        cardAll.Location = New Point(0, 0)
        cardAll.Margin = New Padding(0, 0, 12, 0)
        cardAll.Name = "cardAll"
        cardAll.Size = New Size(148, 92)
        cardAll.TabIndex = 0
        cardAll.Title = "All Requests"
        ' 
        ' cardPending
        ' 
        cardPending.AccentColor = Color.FromArgb(CByte(245), CByte(158), CByte(11))
        cardPending.Cursor = Cursors.Hand
        cardPending.Dock = DockStyle.Fill
        cardPending.Location = New Point(160, 0)
        cardPending.Margin = New Padding(0, 0, 12, 0)
        cardPending.Name = "cardPending"
        cardPending.Size = New Size(148, 92)
        cardPending.TabIndex = 1
        cardPending.Title = "Pending"
        ' 
        ' cardProcessing
        ' 
        cardProcessing.AccentColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        cardProcessing.Cursor = Cursors.Hand
        cardProcessing.Dock = DockStyle.Fill
        cardProcessing.Location = New Point(320, 0)
        cardProcessing.Margin = New Padding(0, 0, 12, 0)
        cardProcessing.Name = "cardProcessing"
        cardProcessing.Size = New Size(148, 92)
        cardProcessing.TabIndex = 2
        cardProcessing.Title = "Processing"
        ' 
        ' cardReadyForRelease
        ' 
        cardReadyForRelease.AccentColor = Color.FromArgb(CByte(13), CByte(148), CByte(136))
        cardReadyForRelease.Cursor = Cursors.Hand
        cardReadyForRelease.Dock = DockStyle.Fill
        cardReadyForRelease.Location = New Point(480, 0)
        cardReadyForRelease.Margin = New Padding(0, 0, 12, 0)
        cardReadyForRelease.Name = "cardReadyForRelease"
        cardReadyForRelease.Size = New Size(148, 92)
        cardReadyForRelease.TabIndex = 3
        cardReadyForRelease.Title = "Ready for Release"
        ' 
        ' cardReleased
        ' 
        cardReleased.AccentColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        cardReleased.Cursor = Cursors.Hand
        cardReleased.Dock = DockStyle.Fill
        cardReleased.Location = New Point(640, 0)
        cardReleased.Margin = New Padding(0, 0, 12, 0)
        cardReleased.Name = "cardReleased"
        cardReleased.Size = New Size(148, 92)
        cardReleased.TabIndex = 4
        cardReleased.Title = "Released"
        ' 
        ' cardCancelled
        ' 
        cardCancelled.AccentColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        cardCancelled.Cursor = Cursors.Hand
        cardCancelled.Dock = DockStyle.Fill
        cardCancelled.Location = New Point(800, 0)
        cardCancelled.Margin = New Padding(0)
        cardCancelled.Name = "cardCancelled"
        cardCancelled.Size = New Size(164, 92)
        cardCancelled.TabIndex = 5
        cardCancelled.Title = "Cancelled"
        ' 
        ' tlpStatus
        ' 
        tlpStatus.ColumnCount = 6
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6667F))
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6667F))
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6667F))
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6667F))
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6667F))
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.6667F))
        tlpStatus.Controls.Add(cardAll, 0, 0)
        tlpStatus.Controls.Add(cardPending, 1, 0)
        tlpStatus.Controls.Add(cardProcessing, 2, 0)
        tlpStatus.Controls.Add(cardReadyForRelease, 3, 0)
        tlpStatus.Controls.Add(cardReleased, 4, 0)
        tlpStatus.Controls.Add(cardCancelled, 5, 0)
        tlpStatus.Dock = DockStyle.Fill
        tlpStatus.Location = New Point(28, 76)
        tlpStatus.Margin = New Padding(0, 16, 0, 0)
        tlpStatus.Name = "tlpStatus"
        tlpStatus.RowCount = 1
        tlpStatus.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpStatus.Size = New Size(964, 92)
        tlpStatus.TabIndex = 1
        ' 
        ' lblAllDocRequest
        ' 
        lblAllDocRequest.Anchor = AnchorStyles.Left
        lblAllDocRequest.AutoSize = True
        lblAllDocRequest.Font = New Font("Segoe UI Semibold", 12F)
        lblAllDocRequest.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblAllDocRequest.Location = New Point(0, 0)
        lblAllDocRequest.Margin = New Padding(0)
        lblAllDocRequest.Name = "lblAllDocRequest"
        lblAllDocRequest.Size = New Size(180, 21)
        lblAllDocRequest.TabIndex = 0
        lblAllDocRequest.Text = "All Document Requests"
        ' 
        ' lblDocTypeDate
        ' 
        lblDocTypeDate.Anchor = AnchorStyles.Right
        lblDocTypeDate.AutoSize = True
        lblDocTypeDate.Font = New Font("Segoe UI", 9.5F)
        lblDocTypeDate.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblDocTypeDate.Location = New Point(834, 2)
        lblDocTypeDate.Margin = New Padding(0)
        lblDocTypeDate.Name = "lblDocTypeDate"
        lblDocTypeDate.Size = New Size(130, 17)
        lblDocTypeDate.TabIndex = 1
        lblDocTypeDate.Text = "[All Document Types]"
        ' 
        ' tlpHead
        ' 
        tlpHead.AutoSize = True
        tlpHead.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpHead.ColumnCount = 2
        tlpHead.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpHead.ColumnStyles.Add(New ColumnStyle())
        tlpHead.Controls.Add(lblAllDocRequest, 0, 0)
        tlpHead.Controls.Add(lblDocTypeDate, 1, 0)
        tlpHead.Dock = DockStyle.Fill
        tlpHead.Location = New Point(28, 184)
        tlpHead.Margin = New Padding(0, 16, 0, 8)
        tlpHead.Name = "tlpHead"
        tlpHead.RowCount = 1
        tlpHead.RowStyles.Add(New RowStyle())
        tlpHead.Size = New Size(964, 21)
        tlpHead.TabIndex = 2
        ' 
        ' dgvRequests
        ' 
        dgvRequests.Dock = DockStyle.Fill
        dgvRequests.Location = New Point(1, 1)
        dgvRequests.Name = "dgvRequests"
        dgvRequests.Size = New Size(962, 401)
        dgvRequests.TabIndex = 0
        ' 
        ' pnlGridBorder
        ' 
        pnlGridBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlGridBorder.Controls.Add(dgvRequests)
        pnlGridBorder.Dock = DockStyle.Fill
        pnlGridBorder.Location = New Point(28, 213)
        pnlGridBorder.Margin = New Padding(0)
        pnlGridBorder.Name = "pnlGridBorder"
        pnlGridBorder.Padding = New Padding(1)
        pnlGridBorder.Size = New Size(964, 403)
        pnlGridBorder.TabIndex = 3
        ' 
        ' tlpMain
        ' 
        tlpMain.ColumnCount = 1
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpMain.Controls.Add(tlpToolbar, 0, 0)
        tlpMain.Controls.Add(tlpStatus, 0, 1)
        tlpMain.Controls.Add(tlpHead, 0, 2)
        tlpMain.Controls.Add(pnlGridBorder, 0, 3)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Location = New Point(0, 0)
        tlpMain.Margin = New Padding(0)
        tlpMain.Name = "tlpMain"
        tlpMain.Padding = New Padding(28, 20, 28, 24)
        tlpMain.RowCount = 4
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 108F))
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMain.Size = New Size(1020, 640)
        tlpMain.TabIndex = 0
        ' 
        ' frmDocumentRequest
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(940, 520)
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(tlpMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDocumentRequest"
        Text = "Document Requests"
        tlpToolbar.ResumeLayout(False)
        tlpToolbar.PerformLayout()
        tlpStatus.ResumeLayout(False)
        tlpHead.ResumeLayout(False)
        tlpHead.PerformLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).EndInit()
        pnlGridBorder.ResumeLayout(False)
        tlpMain.ResumeLayout(False)
        tlpMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboFilterByDocType As ComboBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents btnViewRequest As Button
    Friend WithEvents btnCreateRequest As Button
    Friend WithEvents tlpToolbar As TableLayoutPanel
    Friend WithEvents cardAll As StatCard
    Friend WithEvents cardPending As StatCard
    Friend WithEvents cardProcessing As StatCard
    Friend WithEvents cardReadyForRelease As StatCard
    Friend WithEvents cardReleased As StatCard
    Friend WithEvents cardCancelled As StatCard
    Friend WithEvents tlpStatus As TableLayoutPanel
    Friend WithEvents lblAllDocRequest As Label
    Friend WithEvents lblDocTypeDate As Label
    Friend WithEvents tlpHead As TableLayoutPanel
    Friend WithEvents dgvRequests As DataGridView
    Friend WithEvents pnlGridBorder As Panel
    Friend WithEvents tlpMain As TableLayoutPanel
End Class
