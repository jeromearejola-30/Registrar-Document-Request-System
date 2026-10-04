<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchRecords
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
        tlpToolbar = New TableLayoutPanel()
        lblResults = New Label()
        lblResultCount = New Label()
        tlpHead = New TableLayoutPanel()
        dgvResults = New DataGridView()
        pnlGridBorder = New Panel()
        tlpMain = New TableLayoutPanel()
        tlpToolbar.SuspendLayout()
        tlpHead.SuspendLayout()
        pnlGridBorder.SuspendLayout()
        tlpMain.SuspendLayout()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 11F)
        txtSearch.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        txtSearch.Margin = New Padding(0)
        txtSearch.MaximumSize = New Size(620, 0)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search students, requests and documents..."
        txtSearch.Size = New Size(620, 27)
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
        ' tlpToolbar
        ' 
        tlpToolbar.AutoSize = True
        tlpToolbar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpToolbar.ColumnCount = 2
        tlpToolbar.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.Controls.Add(txtSearch, 0, 0)
        tlpToolbar.Controls.Add(btnClearSearch, 1, 0)
        tlpToolbar.Dock = DockStyle.Fill
        tlpToolbar.Margin = New Padding(0)
        tlpToolbar.Name = "tlpToolbar"
        tlpToolbar.RowCount = 1
        tlpToolbar.RowStyles.Add(New RowStyle())
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Font = New Font("Segoe UI Semibold", 12F)
        lblResults.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblResults.Margin = New Padding(0)
        lblResults.Name = "lblResults"
        lblResults.Text = "Results"
        lblResults.Anchor = AnchorStyles.Left
        ' 
        ' lblResultCount
        ' 
        lblResultCount.AutoSize = True
        lblResultCount.Font = New Font("Segoe UI", 9.5F)
        lblResultCount.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblResultCount.Margin = New Padding(0)
        lblResultCount.Name = "lblResultCount"
        lblResultCount.Text = ""
        lblResultCount.Anchor = AnchorStyles.Right
        ' 
        ' tlpHead
        ' 
        tlpHead.AutoSize = True
        tlpHead.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpHead.ColumnCount = 2
        tlpHead.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpHead.ColumnStyles.Add(New ColumnStyle())
        tlpHead.Controls.Add(lblResults, 0, 0)
        tlpHead.Controls.Add(lblResultCount, 1, 0)
        tlpHead.Dock = DockStyle.Fill
        tlpHead.Margin = New Padding(0, 16, 0, 8)
        tlpHead.Name = "tlpHead"
        tlpHead.RowCount = 1
        tlpHead.RowStyles.Add(New RowStyle())
        ' 
        ' dgvResults
        ' 
        dgvResults.Dock = DockStyle.Fill
        dgvResults.Name = "dgvResults"
        ' 
        ' pnlGridBorder
        ' 
        pnlGridBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlGridBorder.Controls.Add(dgvResults)
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
        tlpMain.Controls.Add(tlpHead, 0, 1)
        tlpMain.Controls.Add(pnlGridBorder, 0, 2)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Margin = New Padding(0)
        tlpMain.Name = "tlpMain"
        tlpMain.RowCount = 3
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMain.Padding = New Padding(28, 20, 28, 24)
        ' 
        ' frmSearchRecords
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(760, 420)
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(tlpMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSearchRecords"
        Text = "Search Records"
        tlpToolbar.ResumeLayout(False)
        tlpToolbar.PerformLayout()
        tlpHead.ResumeLayout(False)
        tlpHead.PerformLayout()
        pnlGridBorder.ResumeLayout(False)
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        tlpMain.ResumeLayout(False)
        tlpMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents tlpToolbar As TableLayoutPanel
    Friend WithEvents lblResults As Label
    Friend WithEvents lblResultCount As Label
    Friend WithEvents tlpHead As TableLayoutPanel
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents pnlGridBorder As Panel
    Friend WithEvents tlpMain As TableLayoutPanel
End Class
