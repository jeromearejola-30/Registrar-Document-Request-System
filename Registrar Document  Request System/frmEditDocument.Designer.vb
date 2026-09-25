<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditDocument
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
        btnSaveEdit = New Button()
        cboDocStatus = New ComboBox()
        lblDocFee = New Label()
        txtDocFee = New TextBox()
        lblDocStatus = New Label()
        lblDocName = New Label()
        txtDocName = New TextBox()
        lblTitle = New Label()
        btnCancel = New Button()
        lblDescTitle = New Label()
        txtDocDescription = New TextBox()
        btnDeleteDocument = New Button()
        SuspendLayout()
        ' 
        ' btnSaveEdit
        ' 
        btnSaveEdit.Location = New Point(140, 312)
        btnSaveEdit.Name = "btnSaveEdit"
        btnSaveEdit.Size = New Size(122, 29)
        btnSaveEdit.TabIndex = 11
        btnSaveEdit.Text = "Save Edit"
        btnSaveEdit.UseVisualStyleBackColor = True
        ' 
        ' cboDocStatus
        ' 
        cboDocStatus.FormattingEnabled = True
        cboDocStatus.Location = New Point(931, 175)
        cboDocStatus.Name = "cboDocStatus"
        cboDocStatus.Size = New Size(374, 28)
        cboDocStatus.TabIndex = 17
        ' 
        ' lblDocFee
        ' 
        lblDocFee.AutoSize = True
        lblDocFee.Location = New Point(537, 146)
        lblDocFee.Name = "lblDocFee"
        lblDocFee.Size = New Size(112, 20)
        lblDocFee.TabIndex = 16
        lblDocFee.Text = "Document Fee :"
        ' 
        ' txtDocFee
        ' 
        txtDocFee.Location = New Point(537, 175)
        txtDocFee.Multiline = True
        txtDocFee.Name = "txtDocFee"
        txtDocFee.Size = New Size(374, 34)
        txtDocFee.TabIndex = 15
        ' 
        ' lblDocStatus
        ' 
        lblDocStatus.AutoSize = True
        lblDocStatus.Location = New Point(931, 146)
        lblDocStatus.Name = "lblDocStatus"
        lblDocStatus.Size = New Size(129, 20)
        lblDocStatus.TabIndex = 14
        lblDocStatus.Text = "Document Status :"
        ' 
        ' lblDocName
        ' 
        lblDocName.AutoSize = True
        lblDocName.Location = New Point(140, 146)
        lblDocName.Name = "lblDocName"
        lblDocName.Size = New Size(129, 20)
        lblDocName.TabIndex = 13
        lblDocName.Text = "Document Name :"
        ' 
        ' txtDocName
        ' 
        txtDocName.Location = New Point(140, 175)
        txtDocName.Multiline = True
        txtDocName.Name = "txtDocName"
        txtDocName.Size = New Size(374, 34)
        txtDocName.TabIndex = 12
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(140, 76)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(108, 20)
        lblTitle.TabIndex = 10
        lblTitle.Text = "Edit Document"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(268, 312)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(122, 29)
        btnCancel.TabIndex = 18
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lblDescTitle
        ' 
        lblDescTitle.AutoSize = True
        lblDescTitle.Location = New Point(140, 224)
        lblDescTitle.Name = "lblDescTitle"
        lblDescTitle.Size = New Size(158, 20)
        lblDescTitle.TabIndex = 19
        lblDescTitle.Text = "Document Description"
        ' 
        ' txtDocDescription
        ' 
        txtDocDescription.Location = New Point(140, 247)
        txtDocDescription.Multiline = True
        txtDocDescription.Name = "txtDocDescription"
        txtDocDescription.Size = New Size(1165, 34)
        txtDocDescription.TabIndex = 20
        ' 
        ' btnDeleteDocument
        ' 
        btnDeleteDocument.Location = New Point(396, 312)
        btnDeleteDocument.Name = "btnDeleteDocument"
        btnDeleteDocument.Size = New Size(134, 29)
        btnDeleteDocument.TabIndex = 21
        btnDeleteDocument.Text = "Delete Document"
        btnDeleteDocument.UseVisualStyleBackColor = True
        ' 
        ' frmEditDocument
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1445, 1015)
        Controls.Add(btnDeleteDocument)
        Controls.Add(txtDocDescription)
        Controls.Add(lblDescTitle)
        Controls.Add(btnCancel)
        Controls.Add(btnSaveEdit)
        Controls.Add(cboDocStatus)
        Controls.Add(lblDocFee)
        Controls.Add(txtDocFee)
        Controls.Add(lblDocStatus)
        Controls.Add(lblDocName)
        Controls.Add(txtDocName)
        Controls.Add(lblTitle)
        Name = "frmEditDocument"
        Text = "frmEditDocument"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents cboDocStatus As ComboBox
    Friend WithEvents lblDocFee As Label
    Friend WithEvents txtDocFee As TextBox
    Friend WithEvents lblDocStatus As Label
    Friend WithEvents lblDocName As Label
    Friend WithEvents txtDocName As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblDescTitle As Label
    Friend WithEvents txtDocDescription As TextBox
    Friend WithEvents btnDeleteDocument As Button
End Class
