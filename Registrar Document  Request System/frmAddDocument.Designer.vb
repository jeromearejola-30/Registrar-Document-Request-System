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
        btnCancel = New Button()
        btnAddDocument = New Button()
        cboDocStatus = New ComboBox()
        lblDocFee = New Label()
        txtDocFee = New TextBox()
        lblDocStatus = New Label()
        lblDocName = New Label()
        txtDocName = New TextBox()
        lblTitle = New Label()
        btnClearAll = New Button()
        txtDocDescription = New TextBox()
        lblDescTitle = New Label()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(396, 320)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(122, 29)
        btnCancel.TabIndex = 27
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.Location = New Point(268, 320)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(122, 29)
        btnAddDocument.TabIndex = 20
        btnAddDocument.Text = "Add Document"
        btnAddDocument.UseVisualStyleBackColor = True
        ' 
        ' cboDocStatus
        ' 
        cboDocStatus.FormattingEnabled = True
        cboDocStatus.Location = New Point(935, 185)
        cboDocStatus.Name = "cboDocStatus"
        cboDocStatus.Size = New Size(374, 28)
        cboDocStatus.TabIndex = 26
        ' 
        ' lblDocFee
        ' 
        lblDocFee.AutoSize = True
        lblDocFee.Location = New Point(541, 156)
        lblDocFee.Name = "lblDocFee"
        lblDocFee.Size = New Size(112, 20)
        lblDocFee.TabIndex = 25
        lblDocFee.Text = "Document Fee :"
        ' 
        ' txtDocFee
        ' 
        txtDocFee.Location = New Point(541, 185)
        txtDocFee.Multiline = True
        txtDocFee.Name = "txtDocFee"
        txtDocFee.Size = New Size(374, 34)
        txtDocFee.TabIndex = 24
        ' 
        ' lblDocStatus
        ' 
        lblDocStatus.AutoSize = True
        lblDocStatus.Location = New Point(935, 156)
        lblDocStatus.Name = "lblDocStatus"
        lblDocStatus.Size = New Size(129, 20)
        lblDocStatus.TabIndex = 23
        lblDocStatus.Text = "Document Status :"
        ' 
        ' lblDocName
        ' 
        lblDocName.AutoSize = True
        lblDocName.Location = New Point(144, 156)
        lblDocName.Name = "lblDocName"
        lblDocName.Size = New Size(129, 20)
        lblDocName.TabIndex = 22
        lblDocName.Text = "Document Name :"
        ' 
        ' txtDocName
        ' 
        txtDocName.Location = New Point(144, 185)
        txtDocName.Multiline = True
        txtDocName.Name = "txtDocName"
        txtDocName.Size = New Size(374, 34)
        txtDocName.TabIndex = 21
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(144, 86)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(110, 20)
        lblTitle.TabIndex = 19
        lblTitle.Text = "Add Document"
        ' 
        ' btnClearAll
        ' 
        btnClearAll.Location = New Point(140, 320)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(122, 29)
        btnClearAll.TabIndex = 28
        btnClearAll.Text = "Clear All"
        btnClearAll.UseVisualStyleBackColor = True
        ' 
        ' txtDocDescription
        ' 
        txtDocDescription.Location = New Point(144, 256)
        txtDocDescription.Multiline = True
        txtDocDescription.Name = "txtDocDescription"
        txtDocDescription.Size = New Size(1165, 34)
        txtDocDescription.TabIndex = 30
        ' 
        ' lblDescTitle
        ' 
        lblDescTitle.AutoSize = True
        lblDescTitle.Location = New Point(144, 233)
        lblDescTitle.Name = "lblDescTitle"
        lblDescTitle.Size = New Size(158, 20)
        lblDescTitle.TabIndex = 29
        lblDescTitle.Text = "Document Description"
        ' 
        ' frmAddDocument
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1445, 1015)
        Controls.Add(txtDocDescription)
        Controls.Add(lblDescTitle)
        Controls.Add(btnClearAll)
        Controls.Add(btnCancel)
        Controls.Add(btnAddDocument)
        Controls.Add(cboDocStatus)
        Controls.Add(lblDocFee)
        Controls.Add(txtDocFee)
        Controls.Add(lblDocStatus)
        Controls.Add(lblDocName)
        Controls.Add(txtDocName)
        Controls.Add(lblTitle)
        Name = "frmAddDocument"
        Text = "frmAddDocument"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents cboDocStatus As ComboBox
    Friend WithEvents lblDocFee As Label
    Friend WithEvents txtDocFee As TextBox
    Friend WithEvents lblDocStatus As Label
    Friend WithEvents lblDocName As Label
    Friend WithEvents txtDocName As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClearAll As Button
    Friend WithEvents txtDocDescription As TextBox
    Friend WithEvents lblDescTitle As Label
End Class
