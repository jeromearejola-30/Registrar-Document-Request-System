<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateDocumentRequest
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
        txtSearchStudent = New TextBox()
        pnlGridContainer = New Panel()
        dgvStudents = New DataGridView()
        lblSearchedStudents = New Label()
        picStudentAvatar = New PictureBox()
        lblStudentName = New Label()
        lblStudentDetails = New Label()
        btnChangeStudent = New Button()
        cboDocumentType = New ComboBox()
        numCopies = New NumericUpDown()
        dtpRequestDate = New DateTimePicker()
        cboPaymentStatus = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        btnSubmitRequest = New Button()
        btnCancelRequest = New Button()
        lblFeePerCopy = New Label()
        lblQuantity = New Label()
        lblAmountDue = New Label()
        pnlSearch.SuspendLayout()
        pnlGridContainer.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        CType(picStudentAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCopies, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSearch
        ' 
        pnlSearch.Controls.Add(btnClearSearch)
        pnlSearch.Controls.Add(txtSearchStudent)
        pnlSearch.Location = New Point(63, 12)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(774, 71)
        pnlSearch.TabIndex = 4
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
        ' txtSearchStudent
        ' 
        txtSearchStudent.Location = New Point(21, 17)
        txtSearchStudent.Multiline = True
        txtSearchStudent.Name = "txtSearchStudent"
        txtSearchStudent.Size = New Size(541, 33)
        txtSearchStudent.TabIndex = 1
        ' 
        ' pnlGridContainer
        ' 
        pnlGridContainer.Controls.Add(dgvStudents)
        pnlGridContainer.Controls.Add(lblSearchedStudents)
        pnlGridContainer.Location = New Point(36, 89)
        pnlGridContainer.Name = "pnlGridContainer"
        pnlGridContainer.Size = New Size(846, 218)
        pnlGridContainer.TabIndex = 5
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.BackgroundColor = SystemColors.Control
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(21, 40)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.Size = New Size(806, 152)
        dgvStudents.TabIndex = 3
        ' 
        ' lblSearchedStudents
        ' 
        lblSearchedStudents.AutoSize = True
        lblSearchedStudents.Location = New Point(29, 17)
        lblSearchedStudents.Name = "lblSearchedStudents"
        lblSearchedStudents.Size = New Size(131, 20)
        lblSearchedStudents.TabIndex = 2
        lblSearchedStudents.Text = "Searched Students"
        ' 
        ' picStudentAvatar
        ' 
        picStudentAvatar.Location = New Point(173, 313)
        picStudentAvatar.Name = "picStudentAvatar"
        picStudentAvatar.Size = New Size(125, 62)
        picStudentAvatar.TabIndex = 6
        picStudentAvatar.TabStop = False
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Location = New Point(313, 326)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(174, 20)
        lblStudentName.TabIndex = 5
        lblStudentName.Text = "Juan Miguel Q. Dela Cruz"
        ' 
        ' lblStudentDetails
        ' 
        lblStudentDetails.AutoSize = True
        lblStudentDetails.Location = New Point(313, 355)
        lblStudentDetails.Name = "lblStudentDetails"
        lblStudentDetails.Size = New Size(309, 20)
        lblStudentDetails.TabIndex = 7
        lblStudentDetails.Text = "Student No. 2940-25  BSIT 3rd Year  BSIT31E1"
        ' 
        ' btnChangeStudent
        ' 
        btnChangeStudent.Location = New Point(655, 326)
        btnChangeStudent.Name = "btnChangeStudent"
        btnChangeStudent.Size = New Size(101, 49)
        btnChangeStudent.TabIndex = 3
        btnChangeStudent.Text = "Change Student"
        btnChangeStudent.UseVisualStyleBackColor = True
        ' 
        ' cboDocumentType
        ' 
        cboDocumentType.FormattingEnabled = True
        cboDocumentType.Location = New Point(15, 54)
        cboDocumentType.Name = "cboDocumentType"
        cboDocumentType.Size = New Size(151, 28)
        cboDocumentType.TabIndex = 8
        ' 
        ' numCopies
        ' 
        numCopies.Location = New Point(15, 54)
        numCopies.Name = "numCopies"
        numCopies.Size = New Size(150, 27)
        numCopies.TabIndex = 9
        numCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' dtpRequestDate
        ' 
        dtpRequestDate.Location = New Point(13, 55)
        dtpRequestDate.Name = "dtpRequestDate"
        dtpRequestDate.Size = New Size(245, 27)
        dtpRequestDate.TabIndex = 10
        ' 
        ' cboPaymentStatus
        ' 
        cboPaymentStatus.FormattingEnabled = True
        cboPaymentStatus.Location = New Point(17, 53)
        cboPaymentStatus.Name = "cboPaymentStatus"
        cboPaymentStatus.Size = New Size(151, 28)
        cboPaymentStatus.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 20)
        Label2.TabIndex = 12
        Label2.Text = "Number of Copies"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 13
        Label3.Text = "Request Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 20)
        Label4.TabIndex = 14
        Label4.Text = "Payment Status"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cboDocumentType)
        Panel1.Location = New Point(42, 392)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(182, 113)
        Panel1.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 20)
        Label1.TabIndex = 4
        Label1.Text = "Document Type"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(numCopies)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(230, 392)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(182, 113)
        Panel2.TabIndex = 16
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(dtpRequestDate)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(418, 392)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(271, 113)
        Panel3.TabIndex = 17
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(cboPaymentStatus)
        Panel4.Location = New Point(695, 392)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(182, 113)
        Panel4.TabIndex = 18
        ' 
        ' btnSubmitRequest
        ' 
        btnSubmitRequest.Location = New Point(42, 580)
        btnSubmitRequest.Name = "btnSubmitRequest"
        btnSubmitRequest.Size = New Size(146, 31)
        btnSubmitRequest.TabIndex = 19
        btnSubmitRequest.Text = "Submit Request"
        btnSubmitRequest.UseVisualStyleBackColor = True
        ' 
        ' btnCancelRequest
        ' 
        btnCancelRequest.Location = New Point(194, 580)
        btnCancelRequest.Name = "btnCancelRequest"
        btnCancelRequest.Size = New Size(120, 31)
        btnCancelRequest.TabIndex = 20
        btnCancelRequest.Text = "Cancel Request"
        btnCancelRequest.UseVisualStyleBackColor = True
        ' 
        ' lblFeePerCopy
        ' 
        lblFeePerCopy.AutoSize = True
        lblFeePerCopy.Location = New Point(695, 508)
        lblFeePerCopy.Name = "lblFeePerCopy"
        lblFeePerCopy.Size = New Size(134, 20)
        lblFeePerCopy.TabIndex = 4
        lblFeePerCopy.Text = "Fee per Copy:  0.00"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(695, 543)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(84, 20)
        lblQuantity.TabIndex = 21
        lblQuantity.Text = "Quantity:  1"
        ' 
        ' lblAmountDue
        ' 
        lblAmountDue.AutoSize = True
        lblAmountDue.Location = New Point(695, 585)
        lblAmountDue.Name = "lblAmountDue"
        lblAmountDue.Size = New Size(131, 20)
        lblAmountDue.TabIndex = 22
        lblAmountDue.Text = "Amount Due:  0.00"
        ' 
        ' frmCreateDocumentRequest
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(925, 614)
        Controls.Add(lblAmountDue)
        Controls.Add(lblQuantity)
        Controls.Add(lblFeePerCopy)
        Controls.Add(btnCancelRequest)
        Controls.Add(btnSubmitRequest)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnChangeStudent)
        Controls.Add(lblStudentDetails)
        Controls.Add(lblStudentName)
        Controls.Add(picStudentAvatar)
        Controls.Add(pnlGridContainer)
        Controls.Add(pnlSearch)
        Name = "frmCreateDocumentRequest"
        Text = "frmCreateDocumentRequest"
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        pnlGridContainer.ResumeLayout(False)
        pnlGridContainer.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        CType(picStudentAvatar, ComponentModel.ISupportInitialize).EndInit()
        CType(numCopies, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlSearch As Panel
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents txtSearchStudent As TextBox
    Friend WithEvents pnlGridContainer As Panel
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents lblSearchedStudents As Label
    Friend WithEvents picStudentAvatar As PictureBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStudentDetails As Label
    Friend WithEvents btnChangeStudent As Button
    Friend WithEvents cboDocumentType As ComboBox
    Friend WithEvents numCopies As NumericUpDown
    Friend WithEvents dtpRequestDate As DateTimePicker
    Friend WithEvents cboPaymentStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSubmitRequest As Button
    Friend WithEvents btnCancelRequest As Button
    Friend WithEvents lblFeePerCopy As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblAmountDue As Label
End Class
