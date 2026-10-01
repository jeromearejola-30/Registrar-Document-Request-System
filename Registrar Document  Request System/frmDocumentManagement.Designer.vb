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
        lblGridTitle = New Label()
        txtSearch = New TextBox()
        pnlSearch = New Panel()
        btnClearSearch = New Button()
        pnlGridContainer = New Panel()
        dgvDocuments = New DataGridView()
        pnlDescriptionContainer = New Panel()
        rtbDescription = New RichTextBox()
        lblDescTitle = New Label()
        pnlDocInformation = New Panel()
        btnEditDocument = New Button()
        cboDocStatus = New ComboBox()
        lblDocFee = New Label()
        txtDocFee = New TextBox()
        lblDocStatus = New Label()
        lblDocName = New Label()
        txtDocName = New TextBox()
        lblDocInfoTitle = New Label()
        pnlDocSummary = New Panel()
        btnAddDocument = New Button()
        lblInactiveCount = New Label()
        lblActiveCount = New Label()
        lblSummaryTitle = New Label()
        pnlSearch.SuspendLayout()
        pnlGridContainer.SuspendLayout()
        CType(dgvDocuments, ComponentModel.ISupportInitialize).BeginInit()
        pnlDescriptionContainer.SuspendLayout()
        pnlDocInformation.SuspendLayout()
        pnlDocSummary.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblGridTitle
        ' 
        lblGridTitle.AutoSize = True
        lblGridTitle.Location = New Point(25, 13)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Size = New Size(85, 15)
        lblGridTitle.TabIndex = 2
        lblGridTitle.Text = "All Documents"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(18, 13)
        txtSearch.Margin = New Padding(3, 2, 3, 2)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(474, 26)
        txtSearch.TabIndex = 1
        ' 
        ' pnlSearch
        ' 
        pnlSearch.Controls.Add(btnClearSearch)
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.Location = New Point(276, 82)
        pnlSearch.Margin = New Padding(3, 2, 3, 2)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(667, 51)
        pnlSearch.TabIndex = 2
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.Location = New Point(564, 17)
        btnClearSearch.Margin = New Padding(3, 2, 3, 2)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(88, 22)
        btnClearSearch.TabIndex = 2
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = True
        ' 
        ' pnlGridContainer
        ' 
        pnlGridContainer.Controls.Add(dgvDocuments)
        pnlGridContainer.Controls.Add(lblGridTitle)
        pnlGridContainer.Location = New Point(23, 158)
        pnlGridContainer.Margin = New Padding(3, 2, 3, 2)
        pnlGridContainer.Name = "pnlGridContainer"
        pnlGridContainer.Size = New Size(677, 248)
        pnlGridContainer.TabIndex = 3
        ' 
        ' dgvDocuments
        ' 
        dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDocuments.BackgroundColor = SystemColors.Control
        dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDocuments.Location = New Point(15, 40)
        dgvDocuments.Margin = New Padding(3, 2, 3, 2)
        dgvDocuments.Name = "dgvDocuments"
        dgvDocuments.RowHeadersVisible = False
        dgvDocuments.RowHeadersWidth = 51
        dgvDocuments.Size = New Size(644, 191)
        dgvDocuments.TabIndex = 3
        ' 
        ' pnlDescriptionContainer
        ' 
        pnlDescriptionContainer.Controls.Add(rtbDescription)
        pnlDescriptionContainer.Controls.Add(lblDescTitle)
        pnlDescriptionContainer.Location = New Point(719, 158)
        pnlDescriptionContainer.Margin = New Padding(3, 2, 3, 2)
        pnlDescriptionContainer.Name = "pnlDescriptionContainer"
        pnlDescriptionContainer.Size = New Size(524, 248)
        pnlDescriptionContainer.TabIndex = 4
        ' 
        ' rtbDescription
        ' 
        rtbDescription.Location = New Point(14, 40)
        rtbDescription.Margin = New Padding(3, 2, 3, 2)
        rtbDescription.Name = "rtbDescription"
        rtbDescription.Size = New Size(498, 192)
        rtbDescription.TabIndex = 5
        rtbDescription.Text = ""
        ' 
        ' lblDescTitle
        ' 
        lblDescTitle.AutoSize = True
        lblDescTitle.Location = New Point(14, 13)
        lblDescTitle.Name = "lblDescTitle"
        lblDescTitle.Size = New Size(126, 15)
        lblDescTitle.TabIndex = 4
        lblDescTitle.Text = "Document Description"
        ' 
        ' pnlDocInformation
        ' 
        pnlDocInformation.Controls.Add(btnEditDocument)
        pnlDocInformation.Controls.Add(cboDocStatus)
        pnlDocInformation.Controls.Add(lblDocFee)
        pnlDocInformation.Controls.Add(txtDocFee)
        pnlDocInformation.Controls.Add(lblDocStatus)
        pnlDocInformation.Controls.Add(lblDocName)
        pnlDocInformation.Controls.Add(txtDocName)
        pnlDocInformation.Controls.Add(lblDocInfoTitle)
        pnlDocInformation.Location = New Point(23, 436)
        pnlDocInformation.Margin = New Padding(3, 2, 3, 2)
        pnlDocInformation.Name = "pnlDocInformation"
        pnlDocInformation.Size = New Size(677, 248)
        pnlDocInformation.TabIndex = 4
        ' 
        ' btnEditDocument
        ' 
        btnEditDocument.Location = New Point(15, 196)
        btnEditDocument.Margin = New Padding(3, 2, 3, 2)
        btnEditDocument.Name = "btnEditDocument"
        btnEditDocument.Size = New Size(107, 22)
        btnEditDocument.TabIndex = 3
        btnEditDocument.Text = "Edit Document"
        btnEditDocument.UseVisualStyleBackColor = True
        ' 
        ' cboDocStatus
        ' 
        cboDocStatus.FormattingEnabled = True
        cboDocStatus.Location = New Point(160, 114)
        cboDocStatus.Margin = New Padding(3, 2, 3, 2)
        cboDocStatus.Name = "cboDocStatus"
        cboDocStatus.Size = New Size(474, 23)
        cboDocStatus.TabIndex = 9
        ' 
        ' lblDocFee
        ' 
        lblDocFee.AutoSize = True
        lblDocFee.Location = New Point(15, 146)
        lblDocFee.Name = "lblDocFee"
        lblDocFee.Size = New Size(90, 15)
        lblDocFee.TabIndex = 8
        lblDocFee.Text = "Document Fee :"
        ' 
        ' txtDocFee
        ' 
        txtDocFee.Location = New Point(160, 141)
        txtDocFee.Margin = New Padding(3, 2, 3, 2)
        txtDocFee.Multiline = True
        txtDocFee.Name = "txtDocFee"
        txtDocFee.Size = New Size(474, 26)
        txtDocFee.TabIndex = 7
        ' 
        ' lblDocStatus
        ' 
        lblDocStatus.AutoSize = True
        lblDocStatus.Location = New Point(15, 116)
        lblDocStatus.Name = "lblDocStatus"
        lblDocStatus.Size = New Size(104, 15)
        lblDocStatus.TabIndex = 6
        lblDocStatus.Text = "Document Status :"
        ' 
        ' lblDocName
        ' 
        lblDocName.AutoSize = True
        lblDocName.Location = New Point(15, 86)
        lblDocName.Name = "lblDocName"
        lblDocName.Size = New Size(104, 15)
        lblDocName.TabIndex = 4
        lblDocName.Text = "Document Name :"
        ' 
        ' txtDocName
        ' 
        txtDocName.Location = New Point(160, 81)
        txtDocName.Margin = New Padding(3, 2, 3, 2)
        txtDocName.Multiline = True
        txtDocName.Name = "txtDocName"
        txtDocName.Size = New Size(474, 26)
        txtDocName.TabIndex = 3
        ' 
        ' lblDocInfoTitle
        ' 
        lblDocInfoTitle.AutoSize = True
        lblDocInfoTitle.Location = New Point(15, 26)
        lblDocInfoTitle.Name = "lblDocInfoTitle"
        lblDocInfoTitle.Size = New Size(129, 15)
        lblDocInfoTitle.TabIndex = 2
        lblDocInfoTitle.Text = "Document Information"
        ' 
        ' pnlDocSummary
        ' 
        pnlDocSummary.Controls.Add(btnAddDocument)
        pnlDocSummary.Controls.Add(lblInactiveCount)
        pnlDocSummary.Controls.Add(lblActiveCount)
        pnlDocSummary.Controls.Add(lblSummaryTitle)
        pnlDocSummary.Location = New Point(719, 436)
        pnlDocSummary.Margin = New Padding(3, 2, 3, 2)
        pnlDocSummary.Name = "pnlDocSummary"
        pnlDocSummary.Size = New Size(524, 248)
        pnlDocSummary.TabIndex = 6
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.Location = New Point(22, 196)
        btnAddDocument.Margin = New Padding(3, 2, 3, 2)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(107, 22)
        btnAddDocument.TabIndex = 10
        btnAddDocument.Text = "Add Document"
        btnAddDocument.UseVisualStyleBackColor = True
        ' 
        ' lblInactiveCount
        ' 
        lblInactiveCount.AutoSize = True
        lblInactiveCount.Location = New Point(14, 116)
        lblInactiveCount.Name = "lblInactiveCount"
        lblInactiveCount.Size = New Size(124, 15)
        lblInactiveCount.TabIndex = 6
        lblInactiveCount.Text = "Inactive Documents: 0"
        ' 
        ' lblActiveCount
        ' 
        lblActiveCount.AutoSize = True
        lblActiveCount.Location = New Point(14, 83)
        lblActiveCount.Name = "lblActiveCount"
        lblActiveCount.Size = New Size(116, 15)
        lblActiveCount.TabIndex = 5
        lblActiveCount.Text = "Active Documents: 0"
        ' 
        ' lblSummaryTitle
        ' 
        lblSummaryTitle.AutoSize = True
        lblSummaryTitle.Location = New Point(14, 13)
        lblSummaryTitle.Name = "lblSummaryTitle"
        lblSummaryTitle.Size = New Size(152, 15)
        lblSummaryTitle.TabIndex = 4
        lblSummaryTitle.Text = "Document Status Summary"
        ' 
        ' frmDocumentManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 761)
        Controls.Add(pnlDocSummary)
        Controls.Add(pnlDocInformation)
        Controls.Add(pnlDescriptionContainer)
        Controls.Add(pnlGridContainer)
        Controls.Add(pnlSearch)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmDocumentManagement"
        Text = "DocumentManager"
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        pnlGridContainer.ResumeLayout(False)
        pnlGridContainer.PerformLayout()
        CType(dgvDocuments, ComponentModel.ISupportInitialize).EndInit()
        pnlDescriptionContainer.ResumeLayout(False)
        pnlDescriptionContainer.PerformLayout()
        pnlDocInformation.ResumeLayout(False)
        pnlDocInformation.PerformLayout()
        pnlDocSummary.ResumeLayout(False)
        pnlDocSummary.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents pnlGridContainer As Panel
    Friend WithEvents pnlDescriptionContainer As Panel
    Friend WithEvents lblGridTitle As Label
    Friend WithEvents dgvDocuments As DataGridView
    Friend WithEvents rtbDescription As RichTextBox
    Friend WithEvents lblDescTitle As Label
    Friend WithEvents pnlDocInformation As Panel
    Friend WithEvents lblDocInfoTitle As Label
    Friend WithEvents btnEditDocument As Button
    Friend WithEvents cboDocStatus As ComboBox
    Friend WithEvents lblDocFee As Label
    Friend WithEvents txtDocFee As TextBox
    Friend WithEvents lblDocStatus As Label
    Friend WithEvents lblDocName As Label
    Friend WithEvents txtDocName As TextBox
    Friend WithEvents pnlDocSummary As Panel
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents lblInactiveCount As Label
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents lblSummaryTitle As Label
End Class
