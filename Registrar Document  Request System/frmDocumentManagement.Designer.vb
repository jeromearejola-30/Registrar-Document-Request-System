<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentManagement
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblGridTitle = New Label()
        txtSearch = New TextBox()
        btnClearSearch = New Button()
        dgvDocuments = New DataGridView()
        rtbDescription = New RichTextBox()
        lblDescTitle = New Label()
        btnAddDocument = New Button()
        lblInactiveCount = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lblDocInfo = New Label()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Label1 = New Label()
        lblDocName = New Label()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        Label3 = New Label()
        lblDocStatus = New Label()
        FlowLayoutPanel5 = New FlowLayoutPanel()
        Label2 = New Label()
        lblDocFee = New Label()
        btnEditDocument = New Button()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label6 = New Label()
        FlowLayoutPanel6 = New FlowLayoutPanel()
        Label7 = New Label()
        lblActiveCount = New Label()
        FlowLayoutPanel7 = New FlowLayoutPanel()
        Label9 = New Label()
        FlowLayoutPanel8 = New FlowLayoutPanel()
        FlowLayoutPanel9 = New FlowLayoutPanel()
        FlowLayoutPanel10 = New FlowLayoutPanel()
        FlowLayoutPanel11 = New FlowLayoutPanel()
        FlowLayoutPanel12 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        CType(dgvDocuments, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel5.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel6.SuspendLayout()
        FlowLayoutPanel7.SuspendLayout()
        FlowLayoutPanel8.SuspendLayout()
        FlowLayoutPanel9.SuspendLayout()
        FlowLayoutPanel10.SuspendLayout()
        FlowLayoutPanel11.SuspendLayout()
        FlowLayoutPanel12.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblGridTitle
        ' 
        lblGridTitle.AutoSize = True
        lblGridTitle.Font = New Font("Tahoma", 15.75F)
        lblGridTitle.Location = New Point(15, 10)
        lblGridTitle.Margin = New Padding(15, 10, 3, 0)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Size = New Size(146, 25)
        lblGridTitle.TabIndex = 2
        lblGridTitle.Text = "All Documents"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(150, 20)
        txtSearch.Margin = New Padding(150, 20, 3, 2)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(474, 26)
        txtSearch.TabIndex = 1
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearSearch.Location = New Point(630, 20)
        btnClearSearch.Margin = New Padding(3, 20, 3, 2)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(117, 26)
        btnClearSearch.TabIndex = 2
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = True
        ' 
        ' dgvDocuments
        ' 
        dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDocuments.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDocuments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDocuments.Location = New Point(10, 59)
        dgvDocuments.Margin = New Padding(10, 2, 3, 2)
        dgvDocuments.Name = "dgvDocuments"
        dgvDocuments.RowHeadersVisible = False
        dgvDocuments.RowHeadersWidth = 51
        dgvDocuments.Size = New Size(481, 191)
        dgvDocuments.TabIndex = 3
        ' 
        ' rtbDescription
        ' 
        rtbDescription.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbDescription.Location = New Point(10, 59)
        rtbDescription.Margin = New Padding(10, 2, 10, 2)
        rtbDescription.Name = "rtbDescription"
        rtbDescription.Size = New Size(384, 192)
        rtbDescription.TabIndex = 5
        rtbDescription.Text = ""
        ' 
        ' lblDescTitle
        ' 
        lblDescTitle.AutoSize = True
        lblDescTitle.Font = New Font("Tahoma", 15.75F)
        lblDescTitle.Location = New Point(15, 10)
        lblDescTitle.Margin = New Padding(15, 10, 3, 0)
        lblDescTitle.Name = "lblDescTitle"
        lblDescTitle.Size = New Size(218, 25)
        lblDescTitle.TabIndex = 4
        lblDescTitle.Text = "Document Description"
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        btnAddDocument.Location = New Point(25, 178)
        btnAddDocument.Margin = New Padding(25, 3, 3, 3)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(152, 31)
        btnAddDocument.TabIndex = 10
        btnAddDocument.Text = "Add New Document"
        btnAddDocument.UseVisualStyleBackColor = True
        ' 
        ' lblInactiveCount
        ' 
        lblInactiveCount.AutoSize = True
        lblInactiveCount.Font = New Font("Tahoma", 14.25F)
        lblInactiveCount.Location = New Point(326, 8)
        lblInactiveCount.Margin = New Padding(130, 8, 3, 0)
        lblInactiveCount.Name = "lblInactiveCount"
        lblInactiveCount.Size = New Size(30, 23)
        lblInactiveCount.TabIndex = 6
        lblInactiveCount.Text = "00"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(lblDocInfo)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel3)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel4)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel5)
        FlowLayoutPanel1.Controls.Add(btnEditDocument)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(13, 10)
        FlowLayoutPanel1.Margin = New Padding(13, 10, 15, 10)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(432, 241)
        FlowLayoutPanel1.TabIndex = 25
        ' 
        ' lblDocInfo
        ' 
        lblDocInfo.AutoSize = True
        lblDocInfo.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDocInfo.Location = New Point(25, 15)
        lblDocInfo.Margin = New Padding(25, 15, 3, 8)
        lblDocInfo.Name = "lblDocInfo"
        lblDocInfo.Size = New Size(224, 25)
        lblDocInfo.TabIndex = 0
        lblDocInfo.Text = "Document Information"
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Controls.Add(Label1)
        FlowLayoutPanel3.Controls.Add(lblDocName)
        FlowLayoutPanel3.Location = New Point(25, 51)
        FlowLayoutPanel3.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(389, 39)
        FlowLayoutPanel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 8)
        Label1.Margin = New Padding(10, 8, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 23)
        Label1.TabIndex = 0
        Label1.Text = "Document Name:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDocName
        ' 
        lblDocName.AutoSize = True
        lblDocName.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDocName.Location = New Point(201, 8)
        lblDocName.Margin = New Padding(30, 8, 3, 0)
        lblDocName.Name = "lblDocName"
        lblDocName.Size = New Size(159, 23)
        lblDocName.TabIndex = 1
        lblDocName.Text = "[DocumentName]"
        lblDocName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Controls.Add(Label3)
        FlowLayoutPanel4.Controls.Add(lblDocStatus)
        FlowLayoutPanel4.Location = New Point(25, 101)
        FlowLayoutPanel4.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(389, 39)
        FlowLayoutPanel4.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(10, 8)
        Label3.Margin = New Padding(10, 8, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 23)
        Label3.TabIndex = 1
        Label3.Text = "Document Status:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDocStatus
        ' 
        lblDocStatus.AutoSize = True
        lblDocStatus.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDocStatus.Location = New Point(204, 8)
        lblDocStatus.Margin = New Padding(30, 8, 3, 0)
        lblDocStatus.Name = "lblDocStatus"
        lblDocStatus.Size = New Size(76, 23)
        lblDocStatus.TabIndex = 2
        lblDocStatus.Text = "[Status]"
        lblDocStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel5
        ' 
        FlowLayoutPanel5.Controls.Add(Label2)
        FlowLayoutPanel5.Controls.Add(lblDocFee)
        FlowLayoutPanel5.Location = New Point(25, 151)
        FlowLayoutPanel5.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Size = New Size(389, 39)
        FlowLayoutPanel5.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(10, 8)
        Label2.Margin = New Padding(10, 8, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 23)
        Label2.TabIndex = 1
        Label2.Text = "Document Fee:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDocFee
        ' 
        lblDocFee.AutoSize = True
        lblDocFee.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDocFee.Location = New Point(207, 8)
        lblDocFee.Margin = New Padding(55, 8, 3, 0)
        lblDocFee.Name = "lblDocFee"
        lblDocFee.Size = New Size(70, 23)
        lblDocFee.TabIndex = 2
        lblDocFee.Text = "[00.00]"
        lblDocFee.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnEditDocument
        ' 
        btnEditDocument.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditDocument.Location = New Point(25, 201)
        btnEditDocument.Margin = New Padding(25, 3, 3, 3)
        btnEditDocument.Name = "btnEditDocument"
        btnEditDocument.Size = New Size(117, 28)
        btnEditDocument.TabIndex = 4
        btnEditDocument.Text = "Edit Document"
        btnEditDocument.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label6)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel6)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel7)
        FlowLayoutPanel2.Controls.Add(btnAddDocument)
        FlowLayoutPanel2.Dock = DockStyle.Fill
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(473, 10)
        FlowLayoutPanel2.Margin = New Padding(13, 10, 15, 10)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(433, 241)
        FlowLayoutPanel2.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(25, 15)
        Label6.Margin = New Padding(25, 15, 3, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(268, 25)
        Label6.TabIndex = 0
        Label6.Text = "Document Status Summary"
        ' 
        ' FlowLayoutPanel6
        ' 
        FlowLayoutPanel6.Controls.Add(Label7)
        FlowLayoutPanel6.Controls.Add(lblActiveCount)
        FlowLayoutPanel6.Location = New Point(25, 78)
        FlowLayoutPanel6.Margin = New Padding(25, 30, 3, 8)
        FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        FlowLayoutPanel6.Size = New Size(389, 39)
        FlowLayoutPanel6.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(10, 8)
        Label7.Margin = New Padding(10, 8, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(166, 23)
        Label7.TabIndex = 0
        Label7.Text = "Active Documents:"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblActiveCount
        ' 
        lblActiveCount.AutoSize = True
        lblActiveCount.Font = New Font("Tahoma", 14.25F)
        lblActiveCount.Location = New Point(329, 8)
        lblActiveCount.Margin = New Padding(150, 8, 3, 0)
        lblActiveCount.Name = "lblActiveCount"
        lblActiveCount.Size = New Size(30, 23)
        lblActiveCount.TabIndex = 5
        lblActiveCount.Text = "00"
        ' 
        ' FlowLayoutPanel7
        ' 
        FlowLayoutPanel7.Controls.Add(Label9)
        FlowLayoutPanel7.Controls.Add(lblInactiveCount)
        FlowLayoutPanel7.Location = New Point(25, 128)
        FlowLayoutPanel7.Margin = New Padding(25, 3, 3, 8)
        FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        FlowLayoutPanel7.Size = New Size(389, 39)
        FlowLayoutPanel7.TabIndex = 2
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(10, 8)
        Label9.Margin = New Padding(10, 8, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(183, 23)
        Label9.TabIndex = 1
        Label9.Text = "Inactive Documents:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel8
        ' 
        FlowLayoutPanel8.Controls.Add(txtSearch)
        FlowLayoutPanel8.Controls.Add(btnClearSearch)
        FlowLayoutPanel8.Dock = DockStyle.Fill
        FlowLayoutPanel8.Location = New Point(3, 3)
        FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        FlowLayoutPanel8.Size = New Size(921, 58)
        FlowLayoutPanel8.TabIndex = 27
        ' 
        ' FlowLayoutPanel9
        ' 
        FlowLayoutPanel9.Controls.Add(lblDescTitle)
        FlowLayoutPanel9.Location = New Point(10, 10)
        FlowLayoutPanel9.Margin = New Padding(10, 10, 3, 3)
        FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        FlowLayoutPanel9.Size = New Size(278, 44)
        FlowLayoutPanel9.TabIndex = 28
        ' 
        ' FlowLayoutPanel10
        ' 
        FlowLayoutPanel10.Controls.Add(lblGridTitle)
        FlowLayoutPanel10.Location = New Point(10, 10)
        FlowLayoutPanel10.Margin = New Padding(10, 10, 3, 3)
        FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        FlowLayoutPanel10.Size = New Size(278, 44)
        FlowLayoutPanel10.TabIndex = 29
        ' 
        ' FlowLayoutPanel11
        ' 
        FlowLayoutPanel11.Controls.Add(FlowLayoutPanel9)
        FlowLayoutPanel11.Controls.Add(rtbDescription)
        FlowLayoutPanel11.Dock = DockStyle.Fill
        FlowLayoutPanel11.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel11.Location = New Point(511, 3)
        FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        FlowLayoutPanel11.Size = New Size(407, 279)
        FlowLayoutPanel11.TabIndex = 30
        ' 
        ' FlowLayoutPanel12
        ' 
        FlowLayoutPanel12.Controls.Add(FlowLayoutPanel10)
        FlowLayoutPanel12.Controls.Add(dgvDocuments)
        FlowLayoutPanel12.Dock = DockStyle.Fill
        FlowLayoutPanel12.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel12.Location = New Point(3, 3)
        FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        FlowLayoutPanel12.Size = New Size(502, 279)
        FlowLayoutPanel12.TabIndex = 31
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel2, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 358)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(921, 261)
        TableLayoutPanel1.TabIndex = 32
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 55.2546043F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 44.7453957F))
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel12, 0, 0)
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel11, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 67)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(921, 285)
        TableLayoutPanel2.TabIndex = 33
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(FlowLayoutPanel8, 0, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel1, 0, 2)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 18.1318684F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 81.86813F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 266F))
        TableLayoutPanel3.Size = New Size(927, 622)
        TableLayoutPanel3.TabIndex = 34
        ' 
        ' frmDocumentManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(TableLayoutPanel3)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmDocumentManagement"
        Text = "DocumentManager"
        CType(dgvDocuments, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        FlowLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel5.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel6.ResumeLayout(False)
        FlowLayoutPanel6.PerformLayout()
        FlowLayoutPanel7.ResumeLayout(False)
        FlowLayoutPanel7.PerformLayout()
        FlowLayoutPanel8.ResumeLayout(False)
        FlowLayoutPanel8.PerformLayout()
        FlowLayoutPanel9.ResumeLayout(False)
        FlowLayoutPanel9.PerformLayout()
        FlowLayoutPanel10.ResumeLayout(False)
        FlowLayoutPanel10.PerformLayout()
        FlowLayoutPanel11.ResumeLayout(False)
        FlowLayoutPanel12.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents lblGridTitle As Label
    Friend WithEvents dgvDocuments As DataGridView
    Friend WithEvents rtbDescription As RichTextBox
    Friend WithEvents lblDescTitle As Label
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents lblInactiveCount As Label
    Friend WithEvents lblDocInfo As Label
    Friend WithEvents lblDocFee As Label
    Friend WithEvents lblDocStatus As Label
    Friend WithEvents lblDocName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents btnEditDocument As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel11 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel12 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
End Class
