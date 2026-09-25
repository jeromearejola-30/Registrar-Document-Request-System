<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        rdoShowPassword = New RadioButton()
        lblShowPassword = New Label()
        lblClearAll = New Label()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Cursor = Cursors.SizeAll
        btnLogin.Location = New Point(135, 604)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(320, 39)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(135, 415)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(75, 20)
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(135, 473)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(70, 20)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(135, 437)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(319, 27)
        txtUsername.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(135, 496)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(319, 27)
        txtPassword.TabIndex = 7
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' rdoShowPassword
        ' 
        rdoShowPassword.AutoSize = True
        rdoShowPassword.Location = New Point(238, 553)
        rdoShowPassword.Margin = New Padding(3, 4, 3, 4)
        rdoShowPassword.Name = "rdoShowPassword"
        rdoShowPassword.Size = New Size(17, 16)
        rdoShowPassword.TabIndex = 8
        rdoShowPassword.TabStop = True
        rdoShowPassword.UseVisualStyleBackColor = True
        ' 
        ' lblShowPassword
        ' 
        lblShowPassword.AutoSize = True
        lblShowPassword.Location = New Point(133, 552)
        lblShowPassword.Name = "lblShowPassword"
        lblShowPassword.Size = New Size(106, 20)
        lblShowPassword.TabIndex = 9
        lblShowPassword.Text = "ShowPassword"
        ' 
        ' lblClearAll
        ' 
        lblClearAll.AutoSize = True
        lblClearAll.Location = New Point(397, 552)
        lblClearAll.Name = "lblClearAll"
        lblClearAll.Size = New Size(65, 20)
        lblClearAll.TabIndex = 10
        lblClearAll.Text = "Clear All"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(153, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(540, 81)
        Label1.TabIndex = 11
        Label1.Text = "Lyceum of Alabang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(163, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(442, 37)
        Label2.TabIndex = 12
        Label2.Text = "Registrar Document Request System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(26, 109)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 147)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1445, 1015)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblClearAll)
        Controls.Add(lblShowPassword)
        Controls.Add(rdoShowPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(btnLogin)
        MinimumSize = New Size(1460, 1051)
        Name = "frmLogin"
        Text = "frmLogin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents rdoShowPassword As RadioButton
    Friend WithEvents lblShowPassword As Label
    Friend WithEvents lblClearAll As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
