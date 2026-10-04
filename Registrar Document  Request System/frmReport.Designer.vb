<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
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

        lblCapFrom = New Label()
        dtpDateFrom = New DateTimePicker()
        lblCapTo = New Label()
        dtpDateTo = New DateTimePicker()
        lblCapStatus = New Label()
        cboStatus = New ComboBox()
        lblCapDocType = New Label()
        cboDocumentType = New ComboBox()
        btnGenerate = New ThemedButton()
        tlpFilter = New TableLayoutPanel()
        cardFilter = New CardPanel()
        lblResultsTitle = New Label()
        dgvReport = New DataGridView()
        pnlGridBorder = New Panel()
        btnExportCSV = New Button()
        btnExportExcel = New Button()
        btnPrint = New Button()
        flpExport = New FlowLayoutPanel()
        lblCapSubtotal = New Label()
        lblSubtotal = New Label()
        lblCapTax = New Label()
        lblTaxFees = New Label()
        lblCapTotal = New Label()
        lblTotal = New Label()
        tlpTotals = New TableLayoutPanel()
        cardTotals = New CardPanel()
        tlpFooter = New TableLayoutPanel()
        tlpMain = New TableLayoutPanel()
        tlpFilter.SuspendLayout()
        cardFilter.SuspendLayout()
        pnlGridBorder.SuspendLayout()
        flpExport.SuspendLayout()
        tlpTotals.SuspendLayout()
        cardTotals.SuspendLayout()
        tlpFooter.SuspendLayout()
        tlpMain.SuspendLayout()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCapFrom
        ' 
        lblCapFrom.AutoSize = True
        lblCapFrom.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapFrom.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapFrom.Margin = New Padding(0, 0, 0, 4)
        lblCapFrom.Name = "lblCapFrom"
        lblCapFrom.Text = "Date From"
        ' 
        ' dtpDateFrom
        ' 
        dtpDateFrom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpDateFrom.Font = New Font("Segoe UI", 10.5F)
        dtpDateFrom.Format = DateTimePickerFormat.Short
        dtpDateFrom.Margin = New Padding(0, 0, 16, 0)
        dtpDateFrom.Name = "dtpDateFrom"
        ' 
        ' lblCapTo
        ' 
        lblCapTo.AutoSize = True
        lblCapTo.Font = New Font("Segoe UI Semibold", 9.5F)
        lblCapTo.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapTo.Margin = New Padding(0, 0, 0, 4)
        lblCapTo.Name = "lblCapTo"
        lblCapTo.Text = "Date To"
        ' 
        ' dtpDateTo
        ' 
        dtpDateTo.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpDateTo.Font = New Font("Segoe UI", 10.5F)
        dtpDateTo.Format = DateTimePickerFormat.Short
        dtpDateTo.Margin = New Padding(0, 0, 16, 0)
        dtpDateTo.Name = "dtpDateTo"
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
        cboDocumentType.Margin = New Padding(0, 0, 16, 0)
        cboDocumentType.Name = "cboDocumentType"
        ' 
        ' btnGenerate
        ' 
        btnGenerate.AutoSize = True
        btnGenerate.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnGenerate.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnGenerate.FlatAppearance.BorderSize = 0
        btnGenerate.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnGenerate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnGenerate.ForeColor = Color.White
        btnGenerate.Kind = ButtonKind.Primary
        btnGenerate.FlatStyle = FlatStyle.Flat
        btnGenerate.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnGenerate.Margin = New Padding(10, 0, 0, 0)
        btnGenerate.MinimumSize = New Size(120, 40)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Padding = New Padding(14, 0, 14, 0)
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        btnGenerate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnGenerate.Margin = New Padding(0)
        ' 
        ' tlpFilter
        ' 
        tlpFilter.AutoSize = True
        tlpFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpFilter.ColumnCount = 5
        tlpFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22F))
        tlpFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22F))
        tlpFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 26F))
        tlpFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        tlpFilter.ColumnStyles.Add(New ColumnStyle())
        tlpFilter.Controls.Add(lblCapFrom, 0, 0)
        tlpFilter.Controls.Add(dtpDateFrom, 0, 1)
        tlpFilter.Controls.Add(lblCapTo, 1, 0)
        tlpFilter.Controls.Add(dtpDateTo, 1, 1)
        tlpFilter.Controls.Add(lblCapStatus, 2, 0)
        tlpFilter.Controls.Add(cboStatus, 2, 1)
        tlpFilter.Controls.Add(lblCapDocType, 3, 0)
        tlpFilter.Controls.Add(cboDocumentType, 3, 1)
        tlpFilter.Controls.Add(btnGenerate, 4, 1)
        tlpFilter.Dock = DockStyle.Fill
        tlpFilter.Margin = New Padding(0)
        tlpFilter.Name = "tlpFilter"
        tlpFilter.RowCount = 2
        tlpFilter.RowStyles.Add(New RowStyle())
        tlpFilter.RowStyles.Add(New RowStyle())
        ' 
        ' cardFilter
        ' 
        cardFilter.AutoSize = True
        cardFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink
        cardFilter.BackColor = Color.White
        cardFilter.Controls.Add(tlpFilter)
        cardFilter.Dock = DockStyle.Fill
        cardFilter.Margin = New Padding(0)
        cardFilter.Name = "cardFilter"
        cardFilter.Padding = New Padding(20, 16, 20, 18)
        ' 
        ' lblResultsTitle
        ' 
        lblResultsTitle.AutoSize = True
        lblResultsTitle.Font = New Font("Segoe UI Semibold", 12F)
        lblResultsTitle.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblResultsTitle.Margin = New Padding(0, 16, 0, 8)
        lblResultsTitle.Name = "lblResultsTitle"
        lblResultsTitle.Text = "Report Results"
        ' 
        ' dgvReport
        ' 
        dgvReport.Dock = DockStyle.Fill
        dgvReport.Name = "dgvReport"
        ' 
        ' pnlGridBorder
        ' 
        pnlGridBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlGridBorder.Controls.Add(dgvReport)
        pnlGridBorder.Dock = DockStyle.Fill
        pnlGridBorder.Margin = New Padding(0)
        pnlGridBorder.Name = "pnlGridBorder"
        pnlGridBorder.Padding = New Padding(1)
        ' 
        ' btnExportCSV
        ' 
        btnExportCSV.AutoSize = True
        btnExportCSV.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnExportCSV.Cursor = Cursors.Hand
        btnExportCSV.BackColor = Color.White
        btnExportCSV.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnExportCSV.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnExportCSV.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnExportCSV.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnExportCSV.FlatStyle = FlatStyle.Flat
        btnExportCSV.Font = New Font("Segoe UI Semibold", 10F)
        btnExportCSV.Margin = New Padding(0, 0, 8, 0)
        btnExportCSV.MinimumSize = New Size(0, 40)
        btnExportCSV.Name = "btnExportCSV"
        btnExportCSV.Padding = New Padding(14, 0, 14, 0)
        btnExportCSV.Text = "Export CSV"
        btnExportCSV.UseVisualStyleBackColor = False
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.AutoSize = True
        btnExportExcel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnExportExcel.Cursor = Cursors.Hand
        btnExportExcel.BackColor = Color.White
        btnExportExcel.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnExportExcel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnExportExcel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnExportExcel.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.Font = New Font("Segoe UI Semibold", 10F)
        btnExportExcel.Margin = New Padding(0, 0, 8, 0)
        btnExportExcel.MinimumSize = New Size(0, 40)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Padding = New Padding(14, 0, 14, 0)
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.AutoSize = True
        btnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnPrint.Cursor = Cursors.Hand
        btnPrint.BackColor = Color.White
        btnPrint.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnPrint.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI Semibold", 10F)
        btnPrint.Margin = New Padding(0)
        btnPrint.MinimumSize = New Size(0, 40)
        btnPrint.Name = "btnPrint"
        btnPrint.Padding = New Padding(14, 0, 14, 0)
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' flpExport
        ' 
        flpExport.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        flpExport.AutoSize = True
        flpExport.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpExport.Controls.Add(btnExportCSV)
        flpExport.Controls.Add(btnExportExcel)
        flpExport.Controls.Add(btnPrint)
        flpExport.Margin = New Padding(0)
        flpExport.Name = "flpExport"
        flpExport.WrapContents = False
        ' 
        ' lblCapSubtotal
        ' 
        lblCapSubtotal.AutoSize = True
        lblCapSubtotal.Font = New Font("Segoe UI", 10F)
        lblCapSubtotal.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapSubtotal.Margin = New Padding(0, 3, 24, 3)
        lblCapSubtotal.Name = "lblCapSubtotal"
        lblCapSubtotal.Text = "Subtotal"
        lblCapSubtotal.Anchor = AnchorStyles.Left
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Segoe UI Semibold", 10.5F)
        lblSubtotal.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblSubtotal.Margin = New Padding(0, 3, 0, 3)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Text = "-"
        lblSubtotal.Anchor = AnchorStyles.Right
        ' 
        ' lblCapTax
        ' 
        lblCapTax.AutoSize = True
        lblCapTax.Font = New Font("Segoe UI", 10F)
        lblCapTax.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapTax.Margin = New Padding(0, 3, 24, 3)
        lblCapTax.Name = "lblCapTax"
        lblCapTax.Text = "Tax / Fees"
        lblCapTax.Anchor = AnchorStyles.Left
        ' 
        ' lblTaxFees
        ' 
        lblTaxFees.AutoSize = True
        lblTaxFees.Font = New Font("Segoe UI Semibold", 10.5F)
        lblTaxFees.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblTaxFees.Margin = New Padding(0, 3, 0, 3)
        lblTaxFees.Name = "lblTaxFees"
        lblTaxFees.Text = "-"
        lblTaxFees.Anchor = AnchorStyles.Right
        ' 
        ' lblCapTotal
        ' 
        lblCapTotal.AutoSize = True
        lblCapTotal.Font = New Font("Segoe UI Semibold", 10.5F)
        lblCapTotal.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapTotal.Margin = New Padding(0, 3, 24, 3)
        lblCapTotal.Name = "lblCapTotal"
        lblCapTotal.Text = "Total"
        lblCapTotal.Anchor = AnchorStyles.Left
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Semibold", 15F)
        lblTotal.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblTotal.Margin = New Padding(0, 3, 0, 3)
        lblTotal.Name = "lblTotal"
        lblTotal.Text = "-"
        lblTotal.Anchor = AnchorStyles.Right
        ' 
        ' tlpTotals
        ' 
        tlpTotals.AutoSize = True
        tlpTotals.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpTotals.ColumnCount = 2
        tlpTotals.ColumnStyles.Add(New ColumnStyle())
        tlpTotals.ColumnStyles.Add(New ColumnStyle())
        tlpTotals.Controls.Add(lblCapSubtotal, 0, 0)
        tlpTotals.Controls.Add(lblSubtotal, 1, 0)
        tlpTotals.Controls.Add(lblCapTax, 0, 1)
        tlpTotals.Controls.Add(lblTaxFees, 1, 1)
        tlpTotals.Controls.Add(lblCapTotal, 0, 2)
        tlpTotals.Controls.Add(lblTotal, 1, 2)
        tlpTotals.Dock = DockStyle.Fill
        tlpTotals.Margin = New Padding(0)
        tlpTotals.Name = "tlpTotals"
        tlpTotals.RowCount = 3
        tlpTotals.RowStyles.Add(New RowStyle())
        tlpTotals.RowStyles.Add(New RowStyle())
        tlpTotals.RowStyles.Add(New RowStyle())
        ' 
        ' cardTotals
        ' 
        cardTotals.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cardTotals.AutoSize = True
        cardTotals.AutoSizeMode = AutoSizeMode.GrowAndShrink
        cardTotals.BackColor = Color.White
        cardTotals.Controls.Add(tlpTotals)
        cardTotals.Margin = New Padding(0)
        cardTotals.Name = "cardTotals"
        cardTotals.Padding = New Padding(18, 10, 18, 10)
        ' 
        ' tlpFooter
        ' 
        tlpFooter.AutoSize = True
        tlpFooter.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpFooter.ColumnCount = 2
        tlpFooter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpFooter.ColumnStyles.Add(New ColumnStyle())
        tlpFooter.Controls.Add(flpExport, 0, 0)
        tlpFooter.Controls.Add(cardTotals, 1, 0)
        tlpFooter.Dock = DockStyle.Fill
        tlpFooter.Margin = New Padding(0, 16, 0, 0)
        tlpFooter.Name = "tlpFooter"
        tlpFooter.RowCount = 1
        tlpFooter.RowStyles.Add(New RowStyle())
        ' 
        ' tlpMain
        ' 
        tlpMain.ColumnCount = 1
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpMain.Controls.Add(cardFilter, 0, 0)
        tlpMain.Controls.Add(lblResultsTitle, 0, 1)
        tlpMain.Controls.Add(pnlGridBorder, 0, 2)
        tlpMain.Controls.Add(tlpFooter, 0, 3)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Margin = New Padding(0)
        tlpMain.Name = "tlpMain"
        tlpMain.RowCount = 4
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.Padding = New Padding(28, 20, 28, 24)
        ' 
        ' frmReport
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(900, 560)
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(tlpMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmReport"
        Text = "Reports"
        tlpFilter.ResumeLayout(False)
        tlpFilter.PerformLayout()
        cardFilter.ResumeLayout(False)
        pnlGridBorder.ResumeLayout(False)
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        flpExport.ResumeLayout(False)
        flpExport.PerformLayout()
        tlpTotals.ResumeLayout(False)
        tlpTotals.PerformLayout()
        cardTotals.ResumeLayout(False)
        tlpFooter.ResumeLayout(False)
        tlpFooter.PerformLayout()
        tlpMain.ResumeLayout(False)
        tlpMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblCapFrom As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents lblCapTo As Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents lblCapStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lblCapDocType As Label
    Friend WithEvents cboDocumentType As ComboBox
    Friend WithEvents btnGenerate As ThemedButton
    Friend WithEvents tlpFilter As TableLayoutPanel
    Friend WithEvents cardFilter As CardPanel
    Friend WithEvents lblResultsTitle As Label
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents pnlGridBorder As Panel
    Friend WithEvents btnExportCSV As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents flpExport As FlowLayoutPanel
    Friend WithEvents lblCapSubtotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblCapTax As Label
    Friend WithEvents lblTaxFees As Label
    Friend WithEvents lblCapTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents tlpTotals As TableLayoutPanel
    Friend WithEvents cardTotals As CardPanel
    Friend WithEvents tlpFooter As TableLayoutPanel
    Friend WithEvents tlpMain As TableLayoutPanel
End Class
