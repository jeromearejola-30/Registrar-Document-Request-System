<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentRequest
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
        pnlSearch = New Panel()
        btnClearSearch = New Button()
        txtSearch = New TextBox()
        pnlGridContainer = New Panel()
        lblDocTypeDate = New Label()
        dgvRequests = New DataGridView()
        lblAllDocRequest = New Label()
        pnlDocSummary = New Panel()
        btnAllRequests = New Button()
        Label1 = New Label()
        btnCancelledRequests = New Button()
        btnAddDocument = New Button()
        btnReleasedRequests = New Button()
        btnReadyForRelease = New Button()
        btnPendingRequests = New Button()
        btnProcessingRequests = New Button()
        Panel1 = New Panel()
        lblCancelledCount = New Label()
        lblReleasedCount = New Label()
        lblProcessCount = New Label()
        lblReadyCount = New Label()
        lblPendingCount = New Label()
        lblRequestStatus = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        cboFilterByDocType = New ComboBox()
        btnCreateRequest = New Button()
        lblFilterRequest = New Label()
        Button2 = New Button()
        pnlSearch.SuspendLayout()
        pnlGridContainer.SuspendLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).BeginInit()
        pnlDocSummary.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSearch
        ' 
        pnlSearch.Controls.Add(btnClearSearch)
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.Location = New Point(67, 44)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(774, 71)
        pnlSearch.TabIndex = 3
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.Location = New Point(645, 23)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(101, 29)
        btnClearSearch.TabIndex = 2
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(21, 17)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(541, 33)
        txtSearch.TabIndex = 1
        ' 
        ' pnlGridContainer
        ' 
        pnlGridContainer.Controls.Add(lblDocTypeDate)
        pnlGridContainer.Controls.Add(dgvRequests)
        pnlGridContainer.Controls.Add(lblAllDocRequest)
        pnlGridContainer.Location = New Point(41, 121)
        pnlGridContainer.Name = "pnlGridContainer"
        pnlGridContainer.Size = New Size(846, 234)
        pnlGridContainer.TabIndex = 4
        ' 
        ' lblDocTypeDate
        ' 
        lblDocTypeDate.AutoSize = True
        lblDocTypeDate.Location = New Point(625, 17)
        lblDocTypeDate.Name = "lblDocTypeDate"
        lblDocTypeDate.Size = New Size(172, 20)
        lblDocTypeDate.TabIndex = 4
        lblDocTypeDate.Text = "document type and date"
        ' 
        ' dgvRequests
        ' 
        dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRequests.BackgroundColor = SystemColors.Control
        dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRequests.Location = New Point(21, 53)
        dgvRequests.Name = "dgvRequests"
        dgvRequests.RowHeadersVisible = False
        dgvRequests.RowHeadersWidth = 51
        dgvRequests.Size = New Size(806, 159)
        dgvRequests.TabIndex = 3
        ' 
        ' lblAllDocRequest
        ' 
        lblAllDocRequest.AutoSize = True
        lblAllDocRequest.Location = New Point(29, 17)
        lblAllDocRequest.Name = "lblAllDocRequest"
        lblAllDocRequest.Size = New Size(163, 20)
        lblAllDocRequest.TabIndex = 2
        lblAllDocRequest.Text = "All Documents Request"
        ' 
        ' pnlDocSummary
        ' 
        pnlDocSummary.Controls.Add(btnAllRequests)
        pnlDocSummary.Controls.Add(Label1)
        pnlDocSummary.Controls.Add(btnCancelledRequests)
        pnlDocSummary.Controls.Add(btnAddDocument)
        pnlDocSummary.Controls.Add(btnReleasedRequests)
        pnlDocSummary.Controls.Add(btnReadyForRelease)
        pnlDocSummary.Controls.Add(btnPendingRequests)
        pnlDocSummary.Controls.Add(btnProcessingRequests)
        pnlDocSummary.Location = New Point(366, 361)
        pnlDocSummary.Name = "pnlDocSummary"
        pnlDocSummary.Size = New Size(269, 241)
        pnlDocSummary.TabIndex = 7
        ' 
        ' btnAllRequests
        ' 
        btnAllRequests.Location = New Point(25, 201)
        btnAllRequests.Name = "btnAllRequests"
        btnAllRequests.Size = New Size(213, 26)
        btnAllRequests.TabIndex = 16
        btnAllRequests.Text = "All Requests"
        btnAllRequests.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 20)
        Label1.TabIndex = 11
        Label1.Text = " Request Status Summary"
        ' 
        ' btnCancelledRequests
        ' 
        btnCancelledRequests.Location = New Point(25, 169)
        btnCancelledRequests.Name = "btnCancelledRequests"
        btnCancelledRequests.Size = New Size(213, 26)
        btnCancelledRequests.TabIndex = 15
        btnCancelledRequests.Text = "Cancelled Requests"
        btnCancelledRequests.UseVisualStyleBackColor = True
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.Location = New Point(25, 261)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(122, 29)
        btnAddDocument.TabIndex = 10
        btnAddDocument.Text = "Add Document"
        btnAddDocument.UseVisualStyleBackColor = True
        ' 
        ' btnReleasedRequests
        ' 
        btnReleasedRequests.Location = New Point(25, 137)
        btnReleasedRequests.Name = "btnReleasedRequests"
        btnReleasedRequests.Size = New Size(213, 26)
        btnReleasedRequests.TabIndex = 14
        btnReleasedRequests.Text = "Released Requests"
        btnReleasedRequests.UseVisualStyleBackColor = True
        ' 
        ' btnReadyForRelease
        ' 
        btnReadyForRelease.Location = New Point(25, 105)
        btnReadyForRelease.Name = "btnReadyForRelease"
        btnReadyForRelease.Size = New Size(213, 26)
        btnReadyForRelease.TabIndex = 13
        btnReadyForRelease.Text = "Ready for Release"
        btnReadyForRelease.UseVisualStyleBackColor = True
        ' 
        ' btnPendingRequests
        ' 
        btnPendingRequests.Location = New Point(25, 41)
        btnPendingRequests.Name = "btnPendingRequests"
        btnPendingRequests.Size = New Size(213, 26)
        btnPendingRequests.TabIndex = 11
        btnPendingRequests.Text = "Pending Requests"
        btnPendingRequests.UseVisualStyleBackColor = True
        ' 
        ' btnProcessingRequests
        ' 
        btnProcessingRequests.Location = New Point(25, 73)
        btnProcessingRequests.Name = "btnProcessingRequests"
        btnProcessingRequests.Size = New Size(213, 26)
        btnProcessingRequests.TabIndex = 12
        btnProcessingRequests.Text = "Processing Requests"
        btnProcessingRequests.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblCancelledCount)
        Panel1.Controls.Add(lblReleasedCount)
        Panel1.Controls.Add(lblProcessCount)
        Panel1.Controls.Add(lblReadyCount)
        Panel1.Controls.Add(lblPendingCount)
        Panel1.Controls.Add(lblRequestStatus)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(41, 361)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(319, 241)
        Panel1.TabIndex = 11
        ' 
        ' lblCancelledCount
        ' 
        lblCancelledCount.AutoSize = True
        lblCancelledCount.Location = New Point(25, 196)
        lblCancelledCount.Name = "lblCancelledCount"
        lblCancelledCount.Size = New Size(93, 20)
        lblCancelledCount.TabIndex = 15
        lblCancelledCount.Text = "Cancelled : 0"
        ' 
        ' lblReleasedCount
        ' 
        lblReleasedCount.AutoSize = True
        lblReleasedCount.Location = New Point(25, 164)
        lblReleasedCount.Name = "lblReleasedCount"
        lblReleasedCount.Size = New Size(88, 20)
        lblReleasedCount.TabIndex = 14
        lblReleasedCount.Text = "Released : 0"
        ' 
        ' lblProcessCount
        ' 
        lblProcessCount.AutoSize = True
        lblProcessCount.Location = New Point(25, 132)
        lblProcessCount.Name = "lblProcessCount"
        lblProcessCount.Size = New Size(77, 20)
        lblProcessCount.TabIndex = 13
        lblProcessCount.Text = "Process : 0"
        ' 
        ' lblReadyCount
        ' 
        lblReadyCount.AutoSize = True
        lblReadyCount.Location = New Point(25, 100)
        lblReadyCount.Name = "lblReadyCount"
        lblReadyCount.Size = New Size(143, 20)
        lblReadyCount.TabIndex = 12
        lblReadyCount.Text = "Ready for release : 0"
        ' 
        ' lblPendingCount
        ' 
        lblPendingCount.AutoSize = True
        lblPendingCount.Location = New Point(25, 62)
        lblPendingCount.Name = "lblPendingCount"
        lblPendingCount.Size = New Size(81, 20)
        lblPendingCount.TabIndex = 11
        lblPendingCount.Text = "Pending : 0"
        ' 
        ' lblRequestStatus
        ' 
        lblRequestStatus.AutoSize = True
        lblRequestStatus.Location = New Point(21, 14)
        lblRequestStatus.Name = "lblRequestStatus"
        lblRequestStatus.Size = New Size(176, 20)
        lblRequestStatus.TabIndex = 5
        lblRequestStatus.Text = " Request Status Summary"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(25, 261)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 29)
        Button1.TabIndex = 10
        Button1.Text = "Add Document"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cboFilterByDocType)
        Panel2.Controls.Add(btnCreateRequest)
        Panel2.Controls.Add(lblFilterRequest)
        Panel2.Controls.Add(Button2)
        Panel2.Location = New Point(641, 361)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(246, 241)
        Panel2.TabIndex = 12
        ' 
        ' cboFilterByDocType
        ' 
        cboFilterByDocType.FormattingEnabled = True
        cboFilterByDocType.Location = New Point(18, 54)
        cboFilterByDocType.Name = "cboFilterByDocType"
        cboFilterByDocType.Size = New Size(213, 28)
        cboFilterByDocType.TabIndex = 20
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.Location = New Point(18, 97)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Size = New Size(213, 26)
        btnCreateRequest.TabIndex = 18
        btnCreateRequest.Text = "Create a Document Request"
        btnCreateRequest.UseVisualStyleBackColor = True
        ' 
        ' lblFilterRequest
        ' 
        lblFilterRequest.AutoSize = True
        lblFilterRequest.Location = New Point(18, 14)
        lblFilterRequest.Name = "lblFilterRequest"
        lblFilterRequest.Size = New Size(176, 20)
        lblFilterRequest.TabIndex = 16
        lblFilterRequest.Text = " Request Status Summary"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(25, 261)
        Button2.Name = "Button2"
        Button2.Size = New Size(122, 29)
        Button2.TabIndex = 10
        Button2.Text = "Add Document"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' frmDocumentRequest
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(925, 614)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(pnlDocSummary)
        Controls.Add(pnlGridContainer)
        Controls.Add(pnlSearch)
        Name = "frmDocumentRequest"
        Text = "DocumentRequest"
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        pnlGridContainer.ResumeLayout(False)
        pnlGridContainer.PerformLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).EndInit()
        pnlDocSummary.ResumeLayout(False)
        pnlDocSummary.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSearch As Panel
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlGridContainer As Panel
    Friend WithEvents dgvRequests As DataGridView
    Friend WithEvents lblAllDocRequest As Label
    Friend WithEvents pnlDocSummary As Panel
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents lblDocTypeDate As Label
    Friend WithEvents btnPendingRequests As Button
    Friend WithEvents lblRequestStatus As Label
    Friend WithEvents btnCancelledRequests As Button
    Friend WithEvents btnReleasedRequests As Button
    Friend WithEvents btnReadyForRelease As Button
    Friend WithEvents btnProcessingRequests As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCancelledCount As Label
    Friend WithEvents lblReleasedCount As Label
    Friend WithEvents lblProcessCount As Label
    Friend WithEvents lblReadyCount As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents lblFilterRequest As Label
    Friend WithEvents btnCreateRequest As Button
    Friend WithEvents cboFilterByDocType As ComboBox
    Friend WithEvents btnAllRequests As Button
End Class
