Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;port=3306;database=registrar_db"

    ' Below this window width the green brand panel is hidden and the logo moves into the card
    Private Const BrandBreakpoint As Integer = 900

    ' Nothing = layout not applied yet; True = brand panel hidden; False = brand panel shown
    Private _compact As Boolean? = Nothing
    Private _placing As Boolean = False

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the close action was triggered by the user (clicking 'X' or pressing Alt+F4).
        If e.CloseReason = CloseReason.UserClosing Then
            If ExitApp() Then
                ' Environment.Exit(0) closes the whole process cleanly without re-triggering FormClosing events
                Environment.Exit(0)
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logo As Image = Theme.LoadLogo()
        pbLogo.Image = logo
        pbCardLogo.Image = logo

        ApplyResponsiveLayout()
        PlaceCard()
        ActiveControl = txtUsername
    End Sub

    ' ---------------------------------------------------------------
    ' Responsive layout
    ' ---------------------------------------------------------------
    Private Sub frmLogin_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ApplyResponsiveLayout()
    End Sub

    Private Sub pnlRight_SizeChanged(sender As Object, e As EventArgs) Handles pnlRight.SizeChanged
        PlaceCard()
    End Sub

    ''' <summary>Wide windows: brand panel (42%) + sign-in panel (58%). Narrow windows: sign-in only.</summary>
    Private Sub ApplyResponsiveLayout()
        ' SizeChanged can fire before the controls exist (during InitializeComponent)
        If tlpRoot Is Nothing OrElse Not IsHandleCreated Then Return

        Dim wantCompact As Boolean = (ClientSize.Width < LogicalToDeviceUnits(BrandBreakpoint))
        If _compact.HasValue AndAlso _compact.Value = wantCompact Then Return
        _compact = wantCompact

        SuspendLayout()
        Dim brandCol As ColumnStyle = CType(tlpRoot.ColumnStyles(0), ColumnStyle)
        Dim formCol As ColumnStyle = CType(tlpRoot.ColumnStyles(1), ColumnStyle)
        If wantCompact Then
            brandCol.SizeType = SizeType.Absolute
            brandCol.Width = 0
        Else
            brandCol.SizeType = SizeType.Percent
            brandCol.Width = 42
        End If
        formCol.SizeType = SizeType.Percent
        formCol.Width = 58

        pnlBrand.Visible = Not wantCompact
        pbCardLogo.Visible = wantCompact   ' the school logo must always be on screen
        ResumeLayout(True)

        PlaceCard()
    End Sub

    ''' <summary>
    ''' Keeps the sign-in card centered (horizontally and vertically), at most 440 wide and exactly as
    ''' tall as its content. Same idea as Theme.FitFormCard, plus vertical centering.
    ''' If the window is too short, the right-hand panel scrolls.
    ''' </summary>
    Private Sub PlaceCard()
        If _placing OrElse pnlRight Is Nothing OrElse pnlRight.ClientSize.Width <= 0 Then Return
        _placing = True
        Try
            Dim pad As Integer = pnlRight.LogicalToDeviceUnits(24)
            Dim w As Integer = Math.Min(pnlRight.LogicalToDeviceUnits(440), pnlRight.ClientSize.Width - pad * 2)
            w = Math.Max(w, pnlRight.LogicalToDeviceUnits(300))

            ' Let the subtitle wrap instead of running off the card on very narrow panels
            Dim innerWidth As Integer = w - cardLogin.Padding.Horizontal
            lblSubtitle.MaximumSize = New Size(innerWidth, 0)

            Dim h As Integer = tlpForm.GetPreferredSize(New Size(innerWidth, 0)).Height + cardLogin.Padding.Vertical
            Dim x As Integer = Math.Max(pad, (pnlRight.ClientSize.Width - w) \ 2) + pnlRight.AutoScrollPosition.X
            Dim y As Integer = Math.Max(pad, (pnlRight.ClientSize.Height - h) \ 2) + pnlRight.AutoScrollPosition.Y
            cardLogin.SetBounds(x, y, w, h)
        Finally
            _placing = False
        End Try
    End Sub

    ' ---------------------------------------------------------------
    ' Login
    ' ---------------------------------------------------------------
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ClearError()

        Dim username As String = txtUsername.Text.Trim()
        If username.Length = 0 Then
            ShowError("Please enter your username.")
            txtUsername.Focus()
            Return
        End If

        If txtPassword.Text.Length = 0 Then
            ShowError("Please enter your password.")
            txtPassword.Focus()
            Return
        End If

        btnLogin.Enabled = False
        Cursor = Cursors.WaitCursor
        Try
            Dim found As Boolean = False
            Dim dbUsername As String = String.Empty
            Dim dbPassword As String = String.Empty
            Dim dbRole As String = String.Empty
            Dim dbStatus As String = String.Empty

            Dim dbUserId As Integer = 0
            Dim dbFullName As String = String.Empty
            ' The connection lives only inside this Using block, so it can never be left open
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("SELECT UserID, Username, Password, FullName, Role, Status FROM tblUsers WHERE Username = @u LIMIT 1", c)
                    cmd.Parameters.AddWithValue("@u", username)
                    Using r As MySqlDataReader = cmd.ExecuteReader()
                        If r.Read() Then
                            found = True
                            dbUserId = Convert.ToInt32(r("UserID"))
                            dbFullName = Convert.ToString(r("FullName"))
                            dbUsername = Convert.ToString(r("Username"))
                            dbPassword = Convert.ToString(r("Password"))
                            dbRole = Convert.ToString(r("Role"))
                            dbStatus = Convert.ToString(r("Status"))
                        End If
                    End Using
                End Using
            End Using

            ' One message for "no such user" and "wrong password", so the form never reveals which usernames exist
            If Not found OrElse Not PasswordMatches(txtPassword.Text, dbPassword) Then
                ShowError("Invalid username or password.")
                txtPassword.SelectAll()
                txtPassword.Focus()
                Return
            End If

            If String.Equals(dbStatus, "Inactive", StringComparison.OrdinalIgnoreCase) Then
                ShowError("This account is inactive. Please contact an administrator.")
                Return
            End If

            AppSession.SignIn(dbUserId, dbUsername, dbFullName, dbRole)

            ' Success: hand the user over to the main window
            Dim mainMenu As New frmMainMenu()
            mainMenu.UserRole = dbRole
            mainMenu.UserName = dbUsername

            ResetForm()
            Me.Hide()
            mainMenu.Show() ' Use .Show() instead of .ShowDialog() to prevent app termination on logout

        Catch ex As MySqlException
            MessageBox.Show("Could not reach the database. Make sure MySQL is running and try again." & vbCrLf & vbCrLf & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
            btnLogin.Enabled = True
        End Try
    End Sub

    ''' <summary>
    ''' The only place passwords are compared. Passwords are stored as plain text today;
    ''' if they are hashed later, this one function (plus Add User / View User) is what changes.
    ''' </summary>
    Private Function PasswordMatches(entered As String, stored As String) As Boolean
        Return String.Equals(entered, stored, StringComparison.Ordinal)
    End Function

    ' ---------------------------------------------------------------
    ' Small helpers
    ' ---------------------------------------------------------------
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub lblClearAll_Click(sender As Object, e As EventArgs) Handles lblClearAll.Click
        ResetForm()
        txtUsername.Focus()
    End Sub

    ' The red message disappears as soon as the person starts correcting it
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        ClearError()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ClearError()
    End Sub

    Private Sub ShowError(message As String)
        lblError.Text = message
    End Sub

    Private Sub ClearError()
        lblError.Text = String.Empty
    End Sub

    ''' <summary>Empties both boxes and hides the password again. Used by Clear all and after a successful login.</summary>
    Private Sub ResetForm()
        txtUsername.Clear()
        txtPassword.Clear()
        chkShowPassword.Checked = False
        ClearError()
    End Sub

End Class
