<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dtpDateFrom = New DateTimePicker()
        dtpDateTo = New DateTimePicker()
        cboStatus = New ComboBox()
        cboDocumentType = New ComboBox()
        btnGenerate = New Button()
        Panel1 = New Panel()
        dgvReport = New DataGridView()
        lblTotal = New Label()
        lblTaxFees = New Label()
        lblSubtotal = New Label()
        btnExportCSV = New Button()
        btnExportExcel = New Button()
        btnPrint = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpDateFrom
        ' 
        dtpDateFrom.Location = New Point(268, 41)
        dtpDateFrom.Name = "dtpDateFrom"
        dtpDateFrom.Size = New Size(250, 27)
        dtpDateFrom.TabIndex = 0
        ' 
        ' dtpDateTo
        ' 
        dtpDateTo.Location = New Point(12, 41)
        dtpDateTo.Name = "dtpDateTo"
        dtpDateTo.Size = New Size(250, 27)
        dtpDateTo.TabIndex = 1
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Location = New Point(681, 40)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(151, 28)
        cboStatus.TabIndex = 2
        ' 
        ' cboDocumentType
        ' 
        cboDocumentType.FormattingEnabled = True
        cboDocumentType.Location = New Point(524, 40)
        cboDocumentType.Name = "cboDocumentType"
        cboDocumentType.Size = New Size(151, 28)
        cboDocumentType.TabIndex = 3
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(838, 40)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(94, 29)
        btnGenerate.TabIndex = 4
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnGenerate)
        Panel1.Controls.Add(cboDocumentType)
        Panel1.Controls.Add(cboStatus)
        Panel1.Controls.Add(dtpDateFrom)
        Panel1.Controls.Add(dtpDateTo)
        Panel1.Location = New Point(7, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(943, 90)
        Panel1.TabIndex = 5
        ' 
        ' dgvReport
        ' 
        dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReport.Location = New Point(7, 166)
        dgvReport.Name = "dgvReport"
        dgvReport.RowHeadersWidth = 51
        dgvReport.Size = New Size(943, 292)
        dgvReport.TabIndex = 6
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(813, 563)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(80, 20)
        lblTotal.TabIndex = 25
        lblTotal.Text = "Total:  0.00"
        ' 
        ' lblTaxFees
        ' 
        lblTaxFees.AutoSize = True
        lblTaxFees.Location = New Point(813, 526)
        lblTaxFees.Name = "lblTaxFees"
        lblTaxFees.Size = New Size(103, 20)
        lblTaxFees.TabIndex = 24
        lblTaxFees.Text = "Tax/Fees:  0.00"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(813, 491)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(103, 20)
        lblSubtotal.TabIndex = 23
        lblSubtotal.Text = "Subtotal:  0.00"
        ' 
        ' btnExportCSV
        ' 
        btnExportCSV.Location = New Point(34, 554)
        btnExportCSV.Name = "btnExportCSV"
        btnExportCSV.Size = New Size(94, 29)
        btnExportCSV.TabIndex = 5
        btnExportCSV.Text = "Export CSV"
        btnExportCSV.UseVisualStyleBackColor = True
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Location = New Point(134, 554)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(103, 29)
        btnExportExcel.TabIndex = 26
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(243, 554)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 29)
        btnPrint.TabIndex = 27
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 28
        Label1.Text = "Date From:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(268, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 20)
        Label2.TabIndex = 29
        Label2.Text = "Date to:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(524, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 30
        Label3.Text = "Status:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(681, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 20)
        Label4.TabIndex = 30
        Label4.Text = "Document Type:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 20)
        Label5.TabIndex = 31
        Label5.Text = "Generate Report"
        ' 
        ' frmReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(962, 614)
        Controls.Add(Label5)
        Controls.Add(btnPrint)
        Controls.Add(btnExportExcel)
        Controls.Add(btnExportCSV)
        Controls.Add(lblTotal)
        Controls.Add(lblTaxFees)
        Controls.Add(lblSubtotal)
        Controls.Add(dgvReport)
        Controls.Add(Panel1)
        Name = "frmReport"
        Text = "frmReport"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboDocumentType As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTaxFees As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents btnExportCSV As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
