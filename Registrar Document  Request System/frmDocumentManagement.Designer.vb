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
        lblGridTitle.Location = New Point(29, 17)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Size = New Size(106, 20)
        lblGridTitle.TabIndex = 2
        lblGridTitle.Text = "All Documents"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(14, 18)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(541, 34)
        txtSearch.TabIndex = 1
        ' 
        ' pnlSearch
        ' 
        pnlSearch.Controls.Add(btnClearSearch)
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.Location = New Point(315, 109)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(762, 68)
        pnlSearch.TabIndex = 2
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.Location = New Point(644, 23)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(101, 29)
        btnClearSearch.TabIndex = 2
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = True
        ' 
        ' pnlGridContainer
        ' 
        pnlGridContainer.Controls.Add(dgvDocuments)
        pnlGridContainer.Controls.Add(lblGridTitle)
        pnlGridContainer.Location = New Point(26, 211)
        pnlGridContainer.Name = "pnlGridContainer"
        pnlGridContainer.Size = New Size(774, 330)
        pnlGridContainer.TabIndex = 3
        ' 
        ' dgvDocuments
        ' 
        dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDocuments.BackgroundColor = SystemColors.Control
        dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDocuments.Location = New Point(17, 54)
        dgvDocuments.Name = "dgvDocuments"
        dgvDocuments.RowHeadersVisible = False
        dgvDocuments.RowHeadersWidth = 51
        dgvDocuments.Size = New Size(736, 255)
        dgvDocuments.TabIndex = 3
        ' 
        ' pnlDescriptionContainer
        ' 
        pnlDescriptionContainer.Controls.Add(rtbDescription)
        pnlDescriptionContainer.Controls.Add(lblDescTitle)
        pnlDescriptionContainer.Location = New Point(822, 211)
        pnlDescriptionContainer.Name = "pnlDescriptionContainer"
        pnlDescriptionContainer.Size = New Size(599, 330)
        pnlDescriptionContainer.TabIndex = 4
        ' 
        ' rtbDescription
        ' 
        rtbDescription.Location = New Point(16, 54)
        rtbDescription.Name = "rtbDescription"
        rtbDescription.Size = New Size(568, 255)
        rtbDescription.TabIndex = 5
        rtbDescription.Text = ""
        ' 
        ' lblDescTitle
        ' 
        lblDescTitle.AutoSize = True
        lblDescTitle.Location = New Point(16, 17)
        lblDescTitle.Name = "lblDescTitle"
        lblDescTitle.Size = New Size(158, 20)
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
        pnlDocInformation.Location = New Point(26, 582)
        pnlDocInformation.Name = "pnlDocInformation"
        pnlDocInformation.Size = New Size(774, 330)
        pnlDocInformation.TabIndex = 4
        ' 
        ' btnEditDocument
        ' 
        btnEditDocument.Location = New Point(17, 262)
        btnEditDocument.Name = "btnEditDocument"
        btnEditDocument.Size = New Size(122, 29)
        btnEditDocument.TabIndex = 3
        btnEditDocument.Text = "Edit Document"
        btnEditDocument.UseVisualStyleBackColor = True
        ' 
        ' cboDocStatus
        ' 
        cboDocStatus.FormattingEnabled = True
        cboDocStatus.Location = New Point(183, 152)
        cboDocStatus.Name = "cboDocStatus"
        cboDocStatus.Size = New Size(541, 28)
        cboDocStatus.TabIndex = 9
        ' 
        ' lblDocFee
        ' 
        lblDocFee.AutoSize = True
        lblDocFee.Location = New Point(17, 194)
        lblDocFee.Name = "lblDocFee"
        lblDocFee.Size = New Size(112, 20)
        lblDocFee.TabIndex = 8
        lblDocFee.Text = "Document Fee :"
        ' 
        ' txtDocFee
        ' 
        txtDocFee.Location = New Point(183, 188)
        txtDocFee.Multiline = True
        txtDocFee.Name = "txtDocFee"
        txtDocFee.Size = New Size(541, 34)
        txtDocFee.TabIndex = 7
        ' 
        ' lblDocStatus
        ' 
        lblDocStatus.AutoSize = True
        lblDocStatus.Location = New Point(17, 154)
        lblDocStatus.Name = "lblDocStatus"
        lblDocStatus.Size = New Size(129, 20)
        lblDocStatus.TabIndex = 6
        lblDocStatus.Text = "Document Status :"
        ' 
        ' lblDocName
        ' 
        lblDocName.AutoSize = True
        lblDocName.Location = New Point(17, 114)
        lblDocName.Name = "lblDocName"
        lblDocName.Size = New Size(129, 20)
        lblDocName.TabIndex = 4
        lblDocName.Text = "Document Name :"
        ' 
        ' txtDocName
        ' 
        txtDocName.Location = New Point(183, 108)
        txtDocName.Multiline = True
        txtDocName.Name = "txtDocName"
        txtDocName.Size = New Size(541, 34)
        txtDocName.TabIndex = 3
        ' 
        ' lblDocInfoTitle
        ' 
        lblDocInfoTitle.AutoSize = True
        lblDocInfoTitle.Location = New Point(17, 34)
        lblDocInfoTitle.Name = "lblDocInfoTitle"
        lblDocInfoTitle.Size = New Size(160, 20)
        lblDocInfoTitle.TabIndex = 2
        lblDocInfoTitle.Text = "Document Information"
        ' 
        ' pnlDocSummary
        ' 
        pnlDocSummary.Controls.Add(btnAddDocument)
        pnlDocSummary.Controls.Add(lblInactiveCount)
        pnlDocSummary.Controls.Add(lblActiveCount)
        pnlDocSummary.Controls.Add(lblSummaryTitle)
        pnlDocSummary.Location = New Point(822, 582)
        pnlDocSummary.Name = "pnlDocSummary"
        pnlDocSummary.Size = New Size(599, 330)
        pnlDocSummary.TabIndex = 6
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.Location = New Point(25, 262)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(122, 29)
        btnAddDocument.TabIndex = 10
        btnAddDocument.Text = "Add Document"
        btnAddDocument.UseVisualStyleBackColor = True
        ' 
        ' lblInactiveCount
        ' 
        lblInactiveCount.AutoSize = True
        lblInactiveCount.Location = New Point(16, 154)
        lblInactiveCount.Name = "lblInactiveCount"
        lblInactiveCount.Size = New Size(154, 20)
        lblInactiveCount.TabIndex = 6
        lblInactiveCount.Text = "Inactive Documents: 0"
        ' 
        ' lblActiveCount
        ' 
        lblActiveCount.AutoSize = True
        lblActiveCount.Location = New Point(16, 111)
        lblActiveCount.Name = "lblActiveCount"
        lblActiveCount.Size = New Size(144, 20)
        lblActiveCount.TabIndex = 5
        lblActiveCount.Text = "Active Documents: 0"
        ' 
        ' lblSummaryTitle
        ' 
        lblSummaryTitle.AutoSize = True
        lblSummaryTitle.Location = New Point(16, 17)
        lblSummaryTitle.Name = "lblSummaryTitle"
        lblSummaryTitle.Size = New Size(188, 20)
        lblSummaryTitle.TabIndex = 4
        lblSummaryTitle.Text = "Document Status Summary"
        ' 
        ' frmDocumentManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1445, 1015)
        Controls.Add(pnlDocSummary)
        Controls.Add(pnlDocInformation)
        Controls.Add(pnlDescriptionContainer)
        Controls.Add(pnlGridContainer)
        Controls.Add(pnlSearch)
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
