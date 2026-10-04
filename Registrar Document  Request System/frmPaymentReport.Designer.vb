<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaymentReport
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
        btnGenerate = New ThemedButton()
        tlpFilter = New TableLayoutPanel()
        cardFilter = New CardPanel()
        lblResultsTitle = New Label()
        lblNote = New Label()
        dgvReport = New DataGridView()
        pnlGridBorder = New Panel()
        btnExportCSV = New Button()
        btnExportExcel = New Button()
        btnPrint = New Button()
        flpExport = New FlowLayoutPanel()
        lblCapGross = New Label()
        lblGross = New Label()
        lblCapCancelled = New Label()
        lblCancelled = New Label()
        lblCapNet = New Label()
        lblNet = New Label()
        lblCapUnpaid = New Label()
        lblUnpaid = New Label()
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
        lblCapFrom.Text = "Payment Date From"
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
        lblCapTo.Text = "Payment Date To"
        ' 
        ' dtpDateTo
        ' 
        dtpDateTo.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpDateTo.Font = New Font("Segoe UI", 10.5F)
        dtpDateTo.Format = DateTimePickerFormat.Short
        dtpDateTo.Margin = New Padding(0, 0, 16, 0)
        dtpDateTo.Name = "dtpDateTo"
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
        tlpFilter.ColumnCount = 4
        tlpFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpFilter.ColumnStyles.Add(New ColumnStyle())
        tlpFilter.Controls.Add(lblCapFrom, 0, 0)
        tlpFilter.Controls.Add(dtpDateFrom, 0, 1)
        tlpFilter.Controls.Add(lblCapTo, 1, 0)
        tlpFilter.Controls.Add(dtpDateTo, 1, 1)
        tlpFilter.Controls.Add(btnGenerate, 3, 1)
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
        lblResultsTitle.Margin = New Padding(0, 16, 0, 2)
        lblResultsTitle.Name = "lblResultsTitle"
        lblResultsTitle.Text = "Payment Report"
        ' 
        ' lblNote
        ' 
        lblNote.AutoSize = True
        lblNote.Font = New Font("Segoe UI", 9F)
        lblNote.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblNote.Margin = New Padding(0, 0, 0, 8)
        lblNote.Name = "lblNote"
        lblNote.Text = "Paid requests by Official Receipt date. Requests that were paid and later cancelled are shown in red and deducted from the net total."
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
        ' lblCapGross
        ' 
        lblCapGross.AutoSize = True
        lblCapGross.Font = New Font("Segoe UI", 10F)
        lblCapGross.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapGross.Margin = New Padding(0, 3, 24, 3)
        lblCapGross.Name = "lblCapGross"
        lblCapGross.Text = "Gross collections"
        lblCapGross.Anchor = AnchorStyles.Left
        ' 
        ' lblGross
        ' 
        lblGross.AutoSize = True
        lblGross.Font = New Font("Segoe UI Semibold", 10.5F)
        lblGross.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblGross.Margin = New Padding(0, 3, 0, 3)
        lblGross.Name = "lblGross"
        lblGross.Text = "-"
        lblGross.Anchor = AnchorStyles.Right
        ' 
        ' lblCapCancelled
        ' 
        lblCapCancelled.AutoSize = True
        lblCapCancelled.Font = New Font("Segoe UI", 10F)
        lblCapCancelled.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapCancelled.Margin = New Padding(0, 3, 24, 3)
        lblCapCancelled.Name = "lblCapCancelled"
        lblCapCancelled.Text = "Less: cancelled (paid)"
        lblCapCancelled.Anchor = AnchorStyles.Left
        ' 
        ' lblCancelled
        ' 
        lblCancelled.AutoSize = True
        lblCancelled.Font = New Font("Segoe UI Semibold", 10.5F)
        lblCancelled.ForeColor = Color.FromArgb(CByte(185), CByte(28), CByte(28))
        lblCancelled.Margin = New Padding(0, 3, 0, 3)
        lblCancelled.Name = "lblCancelled"
        lblCancelled.Text = "-"
        lblCancelled.Anchor = AnchorStyles.Right
        ' 
        ' lblCapNet
        ' 
        lblCapNet.AutoSize = True
        lblCapNet.Font = New Font("Segoe UI Semibold", 10.5F)
        lblCapNet.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblCapNet.Margin = New Padding(0, 3, 24, 3)
        lblCapNet.Name = "lblCapNet"
        lblCapNet.Text = "Net collections"
        lblCapNet.Anchor = AnchorStyles.Left
        ' 
        ' lblNet
        ' 
        lblNet.AutoSize = True
        lblNet.Font = New Font("Segoe UI Semibold", 15F)
        lblNet.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblNet.Margin = New Padding(0, 3, 0, 3)
        lblNet.Name = "lblNet"
        lblNet.Text = "-"
        lblNet.Anchor = AnchorStyles.Right
        ' 
        ' lblCapUnpaid
        ' 
        lblCapUnpaid.AutoSize = True
        lblCapUnpaid.Font = New Font("Segoe UI", 10F)
        lblCapUnpaid.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapUnpaid.Margin = New Padding(0, 3, 24, 3)
        lblCapUnpaid.Name = "lblCapUnpaid"
        lblCapUnpaid.Text = "Unpaid (not yet collected)"
        lblCapUnpaid.Anchor = AnchorStyles.Left
        ' 
        ' lblUnpaid
        ' 
        lblUnpaid.AutoSize = True
        lblUnpaid.Font = New Font("Segoe UI Semibold", 10F)
        lblUnpaid.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblUnpaid.Margin = New Padding(0, 3, 0, 3)
        lblUnpaid.Name = "lblUnpaid"
        lblUnpaid.Text = "-"
        lblUnpaid.Anchor = AnchorStyles.Right
        ' 
        ' tlpTotals
        ' 
        tlpTotals.AutoSize = True
        tlpTotals.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpTotals.ColumnCount = 2
        tlpTotals.ColumnStyles.Add(New ColumnStyle())
        tlpTotals.ColumnStyles.Add(New ColumnStyle())
        tlpTotals.Controls.Add(lblCapGross, 0, 0)
        tlpTotals.Controls.Add(lblGross, 1, 0)
        tlpTotals.Controls.Add(lblCapCancelled, 0, 1)
        tlpTotals.Controls.Add(lblCancelled, 1, 1)
        tlpTotals.Controls.Add(lblCapNet, 0, 2)
        tlpTotals.Controls.Add(lblNet, 1, 2)
        tlpTotals.Controls.Add(lblCapUnpaid, 0, 3)
        tlpTotals.Controls.Add(lblUnpaid, 1, 3)
        tlpTotals.Dock = DockStyle.Fill
        tlpTotals.Margin = New Padding(0)
        tlpTotals.Name = "tlpTotals"
        tlpTotals.RowCount = 4
        tlpTotals.RowStyles.Add(New RowStyle())
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
        tlpMain.Controls.Add(lblNote, 0, 2)
        tlpMain.Controls.Add(pnlGridBorder, 0, 3)
        tlpMain.Controls.Add(tlpFooter, 0, 4)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Margin = New Padding(0)
        tlpMain.Name = "tlpMain"
        tlpMain.RowCount = 5
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.Padding = New Padding(28, 20, 28, 24)
        ' 
        ' frmPaymentReport
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(900, 560)
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(tlpMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPaymentReport"
        Text = "Payment Report"
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
    Friend WithEvents btnGenerate As ThemedButton
    Friend WithEvents tlpFilter As TableLayoutPanel
    Friend WithEvents cardFilter As CardPanel
    Friend WithEvents lblResultsTitle As Label
    Friend WithEvents lblNote As Label
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents pnlGridBorder As Panel
    Friend WithEvents btnExportCSV As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents flpExport As FlowLayoutPanel
    Friend WithEvents lblCapGross As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents lblCapCancelled As Label
    Friend WithEvents lblCancelled As Label
    Friend WithEvents lblCapNet As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblCapUnpaid As Label
    Friend WithEvents lblUnpaid As Label
    Friend WithEvents tlpTotals As TableLayoutPanel
    Friend WithEvents cardTotals As CardPanel
    Friend WithEvents tlpFooter As TableLayoutPanel
    Friend WithEvents tlpMain As TableLayoutPanel
End Class
