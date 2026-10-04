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
        pnlGridBorder.SuspendLayout()
        tlpMain.SuspendLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 11F)
        txtSearch.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        txtSearch.Margin = New Padding(0)
        txtSearch.MaximumSize = New Size(520, 0)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search request no., student, document, date..."
        txtSearch.Size = New Size(520, 27)
        ' 
        ' cboFilterByDocType
        ' 
        cboFilterByDocType.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboFilterByDocType.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterByDocType.Font = New Font("Segoe UI", 10.5F)
        cboFilterByDocType.FormattingEnabled = True
        cboFilterByDocType.Margin = New Padding(12, 0, 0, 0)
        cboFilterByDocType.Name = "cboFilterByDocType"
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
        ' btnViewRequest
        ' 
        btnViewRequest.AutoSize = True
        btnViewRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnViewRequest.Cursor = Cursors.Hand
        btnViewRequest.BackColor = Color.White
        btnViewRequest.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnViewRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnViewRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnViewRequest.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnViewRequest.FlatStyle = FlatStyle.Flat
        btnViewRequest.Font = New Font("Segoe UI Semibold", 10F)
        btnViewRequest.Margin = New Padding(8, 0, 0, 0)
        btnViewRequest.MinimumSize = New Size(0, 40)
        btnViewRequest.Name = "btnViewRequest"
        btnViewRequest.Padding = New Padding(14, 0, 14, 0)
        btnViewRequest.Text = "View / Update"
        btnViewRequest.UseVisualStyleBackColor = False
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.AutoSize = True
        btnCreateRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCreateRequest.Cursor = Cursors.Hand
        btnCreateRequest.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnCreateRequest.FlatAppearance.BorderSize = 0
        btnCreateRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(36), CByte(90), CByte(65))
        btnCreateRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnCreateRequest.ForeColor = Color.White
        btnCreateRequest.FlatStyle = FlatStyle.Flat
        btnCreateRequest.Font = New Font("Segoe UI Semibold", 10F)
        btnCreateRequest.Margin = New Padding(8, 0, 0, 0)
        btnCreateRequest.MinimumSize = New Size(0, 40)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Padding = New Padding(14, 0, 14, 0)
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
        tlpToolbar.Margin = New Padding(0)
        tlpToolbar.Name = "tlpToolbar"
        tlpToolbar.RowCount = 1
        tlpToolbar.RowStyles.Add(New RowStyle())
        ' 
        ' cardAll
        ' 
        cardAll.AccentColor = Color.FromArgb(27, 67, 50)
        cardAll.Cursor = Cursors.Hand
        cardAll.Dock = DockStyle.Fill
        cardAll.Margin = New Padding(0, 0, 12, 0)
        cardAll.Name = "cardAll"
        cardAll.Title = "All Requests"
        cardAll.Value = "0"
        ' 
        ' cardPending
        ' 
        cardPending.AccentColor = Color.FromArgb(245, 158, 11)
        cardPending.Cursor = Cursors.Hand
        cardPending.Dock = DockStyle.Fill
        cardPending.Margin = New Padding(0, 0, 12, 0)
        cardPending.Name = "cardPending"
        cardPending.Title = "Pending"
        cardPending.Value = "0"
        ' 
        ' cardProcessing
        ' 
        cardProcessing.AccentColor = Color.FromArgb(124, 58, 237)
        cardProcessing.Cursor = Cursors.Hand
        cardProcessing.Dock = DockStyle.Fill
        cardProcessing.Margin = New Padding(0, 0, 12, 0)
        cardProcessing.Name = "cardProcessing"
        cardProcessing.Title = "Processing"
        cardProcessing.Value = "0"
        ' 
        ' cardReadyForRelease
        ' 
        cardReadyForRelease.AccentColor = Color.FromArgb(13, 148, 136)
        cardReadyForRelease.Cursor = Cursors.Hand
        cardReadyForRelease.Dock = DockStyle.Fill
        cardReadyForRelease.Margin = New Padding(0, 0, 12, 0)
        cardReadyForRelease.Name = "cardReadyForRelease"
        cardReadyForRelease.Title = "Ready for Release"
        cardReadyForRelease.Value = "0"
        ' 
        ' cardReleased
        ' 
        cardReleased.AccentColor = Color.FromArgb(71, 85, 105)
        cardReleased.Cursor = Cursors.Hand
        cardReleased.Dock = DockStyle.Fill
        cardReleased.Margin = New Padding(0, 0, 12, 0)
        cardReleased.Name = "cardReleased"
        cardReleased.Title = "Released"
        cardReleased.Value = "0"
        ' 
        ' cardCancelled
        ' 
        cardCancelled.AccentColor = Color.FromArgb(220, 38, 38)
        cardCancelled.Cursor = Cursors.Hand
        cardCancelled.Dock = DockStyle.Fill
        cardCancelled.Margin = New Padding(0, 0, 0, 0)
        cardCancelled.Name = "cardCancelled"
        cardCancelled.Title = "Cancelled"
        cardCancelled.Value = "0"
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
        tlpStatus.Margin = New Padding(0, 16, 0, 0)
        tlpStatus.Name = "tlpStatus"
        tlpStatus.RowCount = 1
        tlpStatus.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        ' 
        ' lblAllDocRequest
        ' 
        lblAllDocRequest.AutoSize = True
        lblAllDocRequest.Font = New Font("Segoe UI Semibold", 12F)
        lblAllDocRequest.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblAllDocRequest.Margin = New Padding(0)
        lblAllDocRequest.Name = "lblAllDocRequest"
        lblAllDocRequest.Text = "All Document Requests"
        lblAllDocRequest.Anchor = AnchorStyles.Left
        ' 
        ' lblDocTypeDate
        ' 
        lblDocTypeDate.AutoSize = True
        lblDocTypeDate.Font = New Font("Segoe UI", 9.5F)
        lblDocTypeDate.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblDocTypeDate.Margin = New Padding(0)
        lblDocTypeDate.Name = "lblDocTypeDate"
        lblDocTypeDate.Text = "[All Document Types]"
        lblDocTypeDate.Anchor = AnchorStyles.Right
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
        tlpHead.Margin = New Padding(0, 16, 0, 8)
        tlpHead.Name = "tlpHead"
        tlpHead.RowCount = 1
        tlpHead.RowStyles.Add(New RowStyle())
        ' 
        ' dgvRequests
        ' 
        dgvRequests.Dock = DockStyle.Fill
        dgvRequests.Name = "dgvRequests"
        ' 
        ' pnlGridBorder
        ' 
        pnlGridBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlGridBorder.Controls.Add(dgvRequests)
        pnlGridBorder.Dock = DockStyle.Fill
        pnlGridBorder.Margin = New Padding(0)
        pnlGridBorder.Name = "pnlGridBorder"
        pnlGridBorder.Padding = New Padding(1)
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
        tlpMain.Margin = New Padding(0)
        tlpMain.Name = "tlpMain"
        tlpMain.RowCount = 4
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 108F))
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMain.Padding = New Padding(28, 20, 28, 24)
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
        tlpStatus.PerformLayout()
        tlpHead.ResumeLayout(False)
        tlpHead.PerformLayout()
        pnlGridBorder.ResumeLayout(False)
        CType(dgvRequests, ComponentModel.ISupportInitialize).EndInit()
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
