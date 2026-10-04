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
        tlpRoot = New TableLayoutPanel()
        pnlBrand = New Panel()
        tlpBrand = New TableLayoutPanel()
        pbLogo = New PictureBox()
        lblSchool = New Label()
        pnlBrandAccent = New Panel()
        lblSystem = New Label()
        lblBrandFooter = New Label()
        pnlBrandEdge = New Panel()
        pnlRight = New Panel()
        cardLogin = New CardPanel()
        tlpForm = New TableLayoutPanel()
        pbCardLogo = New PictureBox()
        lblWelcome = New Label()
        pnlTitleAccent = New Panel()
        lblSubtitle = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        tlpOptions = New TableLayoutPanel()
        chkShowPassword = New CheckBox()
        lblClearAll = New Label()
        lblError = New Label()
        btnLogin = New ThemedButton()
        tlpRoot.SuspendLayout()
        pnlBrand.SuspendLayout()
        tlpBrand.SuspendLayout()
        CType(pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        pnlRight.SuspendLayout()
        cardLogin.SuspendLayout()
        tlpForm.SuspendLayout()
        CType(pbCardLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        tlpOptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlpRoot  (brand panel | sign-in panel)
        ' 
        tlpRoot.ColumnCount = 2
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 42F))
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 58F))
        tlpRoot.Controls.Add(pnlBrand, 0, 0)
        tlpRoot.Controls.Add(pnlRight, 1, 0)
        tlpRoot.Dock = DockStyle.Fill
        tlpRoot.Location = New Point(0, 0)
        tlpRoot.Margin = New Padding(0)
        tlpRoot.Name = "tlpRoot"
        tlpRoot.RowCount = 1
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpRoot.Size = New Size(1100, 680)
        tlpRoot.TabIndex = 0
        ' 
        ' pnlBrand
        ' 
        pnlBrand.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        pnlBrand.Controls.Add(tlpBrand)
        pnlBrand.Controls.Add(pnlBrandEdge)
        pnlBrand.Dock = DockStyle.Fill
        pnlBrand.Margin = New Padding(0)
        pnlBrand.Name = "pnlBrand"
        pnlBrand.TabIndex = 0
        ' 
        ' tlpBrand
        ' 
        tlpBrand.ColumnCount = 1
        tlpBrand.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpBrand.Controls.Add(pbLogo, 0, 1)
        tlpBrand.Controls.Add(lblSchool, 0, 2)
        tlpBrand.Controls.Add(pnlBrandAccent, 0, 3)
        tlpBrand.Controls.Add(lblSystem, 0, 4)
        tlpBrand.Controls.Add(lblBrandFooter, 0, 6)
        tlpBrand.Dock = DockStyle.Fill
        tlpBrand.Margin = New Padding(0)
        tlpBrand.Name = "tlpBrand"
        tlpBrand.Padding = New Padding(24, 0, 24, 0)
        tlpBrand.RowCount = 7
        tlpBrand.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpBrand.RowStyles.Add(New RowStyle(SizeType.Absolute, 156F))
        tlpBrand.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        tlpBrand.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
        tlpBrand.RowStyles.Add(New RowStyle(SizeType.Absolute, 72F))
        tlpBrand.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpBrand.RowStyles.Add(New RowStyle(SizeType.Absolute, 48F))
        tlpBrand.TabIndex = 0
        ' 
        ' pbLogo
        ' 
        pbLogo.Anchor = AnchorStyles.None
        pbLogo.BackColor = Color.Transparent
        pbLogo.Margin = New Padding(0)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(140, 140)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 0
        pbLogo.TabStop = False
        ' 
        ' lblSchool
        ' 
        lblSchool.Dock = DockStyle.Fill
        lblSchool.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblSchool.ForeColor = Color.White
        lblSchool.Margin = New Padding(0)
        lblSchool.Name = "lblSchool"
        lblSchool.TabIndex = 1
        lblSchool.Text = "Lyceum of Alabang"
        lblSchool.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlBrandAccent
        ' 
        pnlBrandAccent.Anchor = AnchorStyles.None
        pnlBrandAccent.BackColor = Color.FromArgb(CByte(242), CByte(184), CByte(7))
        pnlBrandAccent.Margin = New Padding(0)
        pnlBrandAccent.Name = "pnlBrandAccent"
        pnlBrandAccent.Size = New Size(56, 4)
        pnlBrandAccent.TabIndex = 2
        ' 
        ' lblSystem
        ' 
        lblSystem.Dock = DockStyle.Fill
        lblSystem.Font = New Font("Segoe UI", 13F)
        lblSystem.ForeColor = Color.FromArgb(CByte(220), CByte(235), CByte(226))
        lblSystem.Margin = New Padding(0)
        lblSystem.Name = "lblSystem"
        lblSystem.TabIndex = 3
        lblSystem.Text = "Registrar Document Request System"
        lblSystem.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblBrandFooter
        ' 
        lblBrandFooter.Dock = DockStyle.Fill
        lblBrandFooter.Font = New Font("Segoe UI", 9F)
        lblBrandFooter.ForeColor = Color.FromArgb(CByte(167), CByte(196), CByte(180))
        lblBrandFooter.Margin = New Padding(0)
        lblBrandFooter.Name = "lblBrandFooter"
        lblBrandFooter.TabIndex = 4
        lblBrandFooter.Text = "© 2026 Lyceum of Alabang"
        lblBrandFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlBrandEdge  (thin gold line on the right edge of the brand panel)
        ' 
        pnlBrandEdge.BackColor = Color.FromArgb(CByte(242), CByte(184), CByte(7))
        pnlBrandEdge.Dock = DockStyle.Right
        pnlBrandEdge.Name = "pnlBrandEdge"
        pnlBrandEdge.Size = New Size(4, 680)
        pnlBrandEdge.TabIndex = 1
        ' 
        ' pnlRight  (scrolling host for the centered sign-in card)
        ' 
        pnlRight.AutoScroll = True
        pnlRight.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        pnlRight.Controls.Add(cardLogin)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Margin = New Padding(0)
        pnlRight.Name = "pnlRight"
        pnlRight.TabIndex = 1
        ' 
        ' cardLogin
        ' 
        cardLogin.BackColor = Color.White
        cardLogin.Controls.Add(tlpForm)
        cardLogin.Location = New Point(24, 24)
        cardLogin.Name = "cardLogin"
        cardLogin.Padding = New Padding(32, 32, 32, 32)
        cardLogin.Size = New Size(440, 520)
        cardLogin.TabIndex = 0
        ' 
        ' tlpForm
        ' 
        tlpForm.AutoSize = True
        tlpForm.ColumnCount = 1
        tlpForm.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpForm.Controls.Add(pbCardLogo, 0, 0)
        tlpForm.Controls.Add(lblWelcome, 0, 1)
        tlpForm.Controls.Add(pnlTitleAccent, 0, 2)
        tlpForm.Controls.Add(lblSubtitle, 0, 3)
        tlpForm.Controls.Add(lblUsername, 0, 4)
        tlpForm.Controls.Add(txtUsername, 0, 5)
        tlpForm.Controls.Add(lblPassword, 0, 6)
        tlpForm.Controls.Add(txtPassword, 0, 7)
        tlpForm.Controls.Add(tlpOptions, 0, 8)
        tlpForm.Controls.Add(lblError, 0, 9)
        tlpForm.Controls.Add(btnLogin, 0, 10)
        tlpForm.Dock = DockStyle.Top
        tlpForm.Location = New Point(32, 32)
        tlpForm.Margin = New Padding(0)
        tlpForm.Name = "tlpForm"
        tlpForm.RowCount = 11
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.RowStyles.Add(New RowStyle())
        tlpForm.Size = New Size(376, 456)
        tlpForm.TabIndex = 0
        ' 
        ' pbCardLogo  (only shown when the brand panel is hidden on narrow windows)
        ' 
        pbCardLogo.Anchor = AnchorStyles.None
        pbCardLogo.BackColor = Color.Transparent
        pbCardLogo.Margin = New Padding(0, 0, 0, 14)
        pbCardLogo.Name = "pbCardLogo"
        pbCardLogo.Size = New Size(72, 72)
        pbCardLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbCardLogo.TabIndex = 0
        pbCardLogo.TabStop = False
        pbCardLogo.Visible = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Anchor = AnchorStyles.Left
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblWelcome.Margin = New Padding(0, 0, 0, 6)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome back"
        ' 
        ' pnlTitleAccent
        ' 
        pnlTitleAccent.Anchor = AnchorStyles.Left
        pnlTitleAccent.BackColor = Color.FromArgb(CByte(242), CByte(184), CByte(7))
        pnlTitleAccent.Margin = New Padding(0, 0, 0, 12)
        pnlTitleAccent.Name = "pnlTitleAccent"
        pnlTitleAccent.Size = New Size(56, 4)
        pnlTitleAccent.TabIndex = 2
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.Anchor = AnchorStyles.Left
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblSubtitle.Margin = New Padding(0, 0, 0, 24)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.TabIndex = 3
        lblSubtitle.Text = "Sign in to the Registrar Document Request System."
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.Left
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.5F)
        lblUsername.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblUsername.Margin = New Padding(0, 0, 0, 6)
        lblUsername.Name = "lblUsername"
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11F)
        txtUsername.Margin = New Padding(0, 0, 0, 16)
        txtUsername.MaxLength = 50
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter your username"
        txtUsername.TabIndex = 0
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.Left
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9.5F)
        lblPassword.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblPassword.Margin = New Padding(0, 0, 0, 6)
        lblPassword.Name = "lblPassword"
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.Margin = New Padding(0, 0, 0, 10)
        txtPassword.MaxLength = 100
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter your password"
        txtPassword.TabIndex = 1
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' tlpOptions  (Show password on the left, Clear all on the right)
        ' 
        tlpOptions.AutoSize = True
        tlpOptions.ColumnCount = 2
        tlpOptions.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpOptions.ColumnStyles.Add(New ColumnStyle())
        tlpOptions.Controls.Add(chkShowPassword, 0, 0)
        tlpOptions.Controls.Add(lblClearAll, 1, 0)
        tlpOptions.Dock = DockStyle.Fill
        tlpOptions.Margin = New Padding(0, 0, 0, 6)
        tlpOptions.Name = "tlpOptions"
        tlpOptions.RowCount = 1
        tlpOptions.RowStyles.Add(New RowStyle())
        tlpOptions.TabIndex = 8
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.Anchor = AnchorStyles.Left
        chkShowPassword.AutoSize = True
        chkShowPassword.Cursor = Cursors.Hand
        chkShowPassword.Font = New Font("Segoe UI", 9.5F)
        chkShowPassword.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        chkShowPassword.Margin = New Padding(0)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.TabIndex = 2
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' lblClearAll
        ' 
        lblClearAll.Anchor = AnchorStyles.Right
        lblClearAll.AutoSize = True
        lblClearAll.Cursor = Cursors.Hand
        lblClearAll.Font = New Font("Segoe UI", 9.5F, FontStyle.Underline)
        lblClearAll.ForeColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        lblClearAll.Margin = New Padding(12, 0, 0, 0)
        lblClearAll.Name = "lblClearAll"
        lblClearAll.TabIndex = 9
        lblClearAll.Text = "Clear all"
        ' 
        ' lblError  (always takes up its space so the card never jumps when a message appears)
        ' 
        lblError.AutoSize = False
        lblError.Dock = DockStyle.Fill
        lblError.Font = New Font("Segoe UI", 9.5F)
        lblError.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        lblError.Margin = New Padding(0, 0, 0, 10)
        lblError.MinimumSize = New Size(0, 24)
        lblError.Name = "lblError"
        lblError.Size = New Size(376, 24)
        lblError.TabIndex = 10
        lblError.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnLogin.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Kind = ButtonKind.Primary
        btnLogin.Margin = New Padding(0, 4, 0, 0)
        btnLogin.MinimumSize = New Size(0, 46)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(376, 46)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1100, 680)
        Controls.Add(tlpRoot)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(760, 540)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log In - Registrar Document Request System"
        tlpRoot.ResumeLayout(False)
        pnlBrand.ResumeLayout(False)
        tlpBrand.ResumeLayout(False)
        CType(pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        pnlRight.ResumeLayout(False)
        cardLogin.ResumeLayout(False)
        cardLogin.PerformLayout()
        tlpForm.ResumeLayout(False)
        tlpForm.PerformLayout()
        CType(pbCardLogo, System.ComponentModel.ISupportInitialize).EndInit()
        tlpOptions.ResumeLayout(False)
        tlpOptions.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpRoot As TableLayoutPanel
    Friend WithEvents pnlBrand As Panel
    Friend WithEvents tlpBrand As TableLayoutPanel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblSchool As Label
    Friend WithEvents pnlBrandAccent As Panel
    Friend WithEvents lblSystem As Label
    Friend WithEvents lblBrandFooter As Label
    Friend WithEvents pnlBrandEdge As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents cardLogin As CardPanel
    Friend WithEvents tlpForm As TableLayoutPanel
    Friend WithEvents pbCardLogo As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlTitleAccent As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents tlpOptions As TableLayoutPanel
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblClearAll As Label
    Friend WithEvents lblError As Label
    Friend WithEvents btnLogin As ThemedButton

End Class
