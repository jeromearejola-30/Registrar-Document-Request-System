<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDocument
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
        TableLayoutPanel11 = New TableLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblTitle = New Label()
        TableLayoutPanel10 = New TableLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        btnCancel = New Button()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        btnAddDocument = New Button()
        btnClearAll = New Button()
        TableLayoutPanel9 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtDocName = New TextBox()
        lblDocName = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        lblDocFee = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        txtDocFee = New TextBox()
        TableLayoutPanel6 = New TableLayoutPanel()
        lblDocStatus = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        cboDocStatus = New ComboBox()
        TableLayoutPanel7 = New TableLayoutPanel()
        lblDescTitle = New Label()
        TableLayoutPanel8 = New TableLayoutPanel()
        txtDocDescription = New TextBox()
        TableLayoutPanel11.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel10.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel11
        ' 
        TableLayoutPanel11.ColumnCount = 1
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel11.Controls.Add(FlowLayoutPanel1, 0, 0)
        TableLayoutPanel11.Controls.Add(TableLayoutPanel10, 0, 4)
        TableLayoutPanel11.Controls.Add(TableLayoutPanel9, 0, 2)
        TableLayoutPanel11.Controls.Add(TableLayoutPanel7, 0, 3)
        TableLayoutPanel11.Dock = DockStyle.Fill
        TableLayoutPanel11.Location = New Point(0, 0)
        TableLayoutPanel11.Name = "TableLayoutPanel11"
        TableLayoutPanel11.RowCount = 5
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 85.71429F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Absolute, 119F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Absolute, 297F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Absolute, 81F))
        TableLayoutPanel11.Size = New Size(927, 622)
        TableLayoutPanel11.TabIndex = 36
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(lblTitle)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(5, 5)
        FlowLayoutPanel1.Margin = New Padding(5)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(917, 97)
        FlowLayoutPanel1.TabIndex = 22
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(10, 10)
        lblTitle.Margin = New Padding(10, 10, 3, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(167, 29)
        lblTitle.TabIndex = 10
        lblTitle.Text = "Edit Document"
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.ColumnCount = 2
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Controls.Add(FlowLayoutPanel3, 1, 0)
        TableLayoutPanel10.Controls.Add(FlowLayoutPanel2, 0, 0)
        TableLayoutPanel10.Dock = DockStyle.Fill
        TableLayoutPanel10.Location = New Point(5, 545)
        TableLayoutPanel10.Margin = New Padding(5)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 1
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Size = New Size(917, 72)
        TableLayoutPanel10.TabIndex = 34
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Controls.Add(btnCancel)
        FlowLayoutPanel3.Dock = DockStyle.Right
        FlowLayoutPanel3.Location = New Point(721, 10)
        FlowLayoutPanel3.Margin = New Padding(10)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(186, 52)
        FlowLayoutPanel3.TabIndex = 36
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Tahoma", 11.25F, FontStyle.Bold)
        btnCancel.Location = New Point(10, 10)
        btnCancel.Margin = New Padding(10)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(161, 32)
        btnCancel.TabIndex = 21
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(btnAddDocument)
        FlowLayoutPanel2.Controls.Add(btnClearAll)
        FlowLayoutPanel2.Dock = DockStyle.Left
        FlowLayoutPanel2.Location = New Point(10, 10)
        FlowLayoutPanel2.Margin = New Padding(10)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(345, 52)
        FlowLayoutPanel2.TabIndex = 35
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.Font = New Font("Tahoma", 11.25F, FontStyle.Bold)
        btnAddDocument.Location = New Point(10, 10)
        btnAddDocument.Margin = New Padding(10)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(151, 32)
        btnAddDocument.TabIndex = 11
        btnAddDocument.Text = "Add Document"
        btnAddDocument.UseVisualStyleBackColor = True
        ' 
        ' btnClearAll
        ' 
        btnClearAll.Font = New Font("Tahoma", 11.25F, FontStyle.Bold)
        btnClearAll.Location = New Point(181, 10)
        btnClearAll.Margin = New Padding(10)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(151, 32)
        btnClearAll.TabIndex = 18
        btnClearAll.Text = "Clear All"
        btnClearAll.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.ColumnCount = 3
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 47.83237F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 52.16763F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 316F))
        TableLayoutPanel9.Controls.Add(TableLayoutPanel4, 0, 0)
        TableLayoutPanel9.Controls.Add(TableLayoutPanel5, 1, 0)
        TableLayoutPanel9.Controls.Add(TableLayoutPanel6, 2, 0)
        TableLayoutPanel9.Dock = DockStyle.Fill
        TableLayoutPanel9.Location = New Point(5, 129)
        TableLayoutPanel9.Margin = New Padding(5)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 1
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Size = New Size(917, 109)
        TableLayoutPanel9.TabIndex = 33
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(TableLayoutPanel1, 0, 1)
        TableLayoutPanel4.Controls.Add(lblDocName, 0, 0)
        TableLayoutPanel4.Location = New Point(10, 10)
        TableLayoutPanel4.Margin = New Padding(10)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 54F))
        TableLayoutPanel4.Size = New Size(267, 89)
        TableLayoutPanel4.TabIndex = 29
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(txtDocName, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 38)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(261, 48)
        TableLayoutPanel1.TabIndex = 26
        ' 
        ' txtDocName
        ' 
        txtDocName.Dock = DockStyle.Fill
        txtDocName.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        txtDocName.Location = New Point(10, 10)
        txtDocName.Margin = New Padding(10)
        txtDocName.Multiline = True
        txtDocName.Name = "txtDocName"
        txtDocName.Size = New Size(241, 28)
        txtDocName.TabIndex = 12
        ' 
        ' lblDocName
        ' 
        lblDocName.AutoSize = True
        lblDocName.Dock = DockStyle.Bottom
        lblDocName.Font = New Font("Tahoma", 14.25F)
        lblDocName.Location = New Point(10, 10)
        lblDocName.Margin = New Padding(10, 10, 10, 3)
        lblDocName.Name = "lblDocName"
        lblDocName.Size = New Size(247, 22)
        lblDocName.TabIndex = 13
        lblDocName.Text = "Document Name "
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(lblDocFee, 0, 0)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel5.Location = New Point(297, 10)
        TableLayoutPanel5.Margin = New Padding(10)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 54F))
        TableLayoutPanel5.Size = New Size(293, 89)
        TableLayoutPanel5.TabIndex = 30
        ' 
        ' lblDocFee
        ' 
        lblDocFee.AutoSize = True
        lblDocFee.Dock = DockStyle.Bottom
        lblDocFee.Font = New Font("Tahoma", 14.25F)
        lblDocFee.Location = New Point(10, 10)
        lblDocFee.Margin = New Padding(10, 10, 10, 3)
        lblDocFee.Name = "lblDocFee"
        lblDocFee.Size = New Size(273, 22)
        lblDocFee.TabIndex = 16
        lblDocFee.Text = "Document Fee "
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(txtDocFee, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 38)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(287, 48)
        TableLayoutPanel2.TabIndex = 27
        ' 
        ' txtDocFee
        ' 
        txtDocFee.Dock = DockStyle.Fill
        txtDocFee.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        txtDocFee.Location = New Point(10, 10)
        txtDocFee.Margin = New Padding(10)
        txtDocFee.Multiline = True
        txtDocFee.Name = "txtDocFee"
        txtDocFee.Size = New Size(267, 28)
        txtDocFee.TabIndex = 15
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Controls.Add(lblDocStatus, 0, 0)
        TableLayoutPanel6.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel6.Location = New Point(610, 10)
        TableLayoutPanel6.Margin = New Padding(10)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Absolute, 54F))
        TableLayoutPanel6.Size = New Size(297, 89)
        TableLayoutPanel6.TabIndex = 31
        ' 
        ' lblDocStatus
        ' 
        lblDocStatus.AutoSize = True
        lblDocStatus.Dock = DockStyle.Bottom
        lblDocStatus.Font = New Font("Tahoma", 14.25F)
        lblDocStatus.Location = New Point(10, 10)
        lblDocStatus.Margin = New Padding(10, 10, 10, 3)
        lblDocStatus.Name = "lblDocStatus"
        lblDocStatus.Size = New Size(277, 22)
        lblDocStatus.TabIndex = 14
        lblDocStatus.Text = "Document Status "
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(cboDocStatus, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 38)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(291, 48)
        TableLayoutPanel3.TabIndex = 28
        ' 
        ' cboDocStatus
        ' 
        cboDocStatus.Dock = DockStyle.Fill
        cboDocStatus.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        cboDocStatus.FormattingEnabled = True
        cboDocStatus.Location = New Point(10, 10)
        cboDocStatus.Margin = New Padding(10)
        cboDocStatus.Name = "cboDocStatus"
        cboDocStatus.Size = New Size(271, 27)
        cboDocStatus.TabIndex = 17
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 1
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Controls.Add(lblDescTitle, 0, 0)
        TableLayoutPanel7.Controls.Add(TableLayoutPanel8, 0, 1)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(5, 248)
        TableLayoutPanel7.Margin = New Padding(5)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 249F))
        TableLayoutPanel7.Size = New Size(917, 287)
        TableLayoutPanel7.TabIndex = 32
        ' 
        ' lblDescTitle
        ' 
        lblDescTitle.AutoSize = True
        lblDescTitle.Dock = DockStyle.Fill
        lblDescTitle.Font = New Font("Tahoma", 14.25F)
        lblDescTitle.Location = New Point(10, 10)
        lblDescTitle.Margin = New Padding(10, 10, 3, 0)
        lblDescTitle.Name = "lblDescTitle"
        lblDescTitle.Size = New Size(904, 28)
        lblDescTitle.TabIndex = 19
        lblDescTitle.Text = "Document Description"
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 1
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Controls.Add(txtDocDescription, 0, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(3, 41)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Size = New Size(911, 243)
        TableLayoutPanel8.TabIndex = 28
        ' 
        ' txtDocDescription
        ' 
        txtDocDescription.Dock = DockStyle.Fill
        txtDocDescription.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDocDescription.Location = New Point(10, 10)
        txtDocDescription.Margin = New Padding(10)
        txtDocDescription.Multiline = True
        txtDocDescription.Name = "txtDocDescription"
        txtDocDescription.Size = New Size(891, 223)
        txtDocDescription.TabIndex = 20
        ' 
        ' frmAddDocument
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(TableLayoutPanel11)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmAddDocument"
        Text = "frmAddDocument"
        TableLayoutPanel11.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        TableLayoutPanel10.ResumeLayout(False)
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtDocName As TextBox
    Friend WithEvents lblDocName As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblDocFee As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtDocFee As TextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lblDocStatus As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents cboDocStatus As ComboBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents lblDescTitle As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents txtDocDescription As TextBox
End Class
