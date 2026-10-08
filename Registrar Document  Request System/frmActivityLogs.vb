Imports MySql.Data.MySqlClient

''' <summary>Admin-only audit trail: every logged action, with filters and search.</summary>
Public Class frmActivityLogs
    Inherits Form

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    Private ReadOnly pnlFilters As New Panel()
    Private ReadOnly dtpFrom As New DateTimePicker()
    Private ReadOnly dtpTo As New DateTimePicker()
    Private ReadOnly cboType As New ComboBox()
    Private ReadOnly cboRole As New ComboBox()
    Private ReadOnly txtSearch As New TextBox()
    Private ReadOnly btnReset As New Button()
    Private ReadOnly btnAllTime As New Button()
    Private ReadOnly lblCount As New Label()
    Private ReadOnly dgv As New DataGridView()
    Private ReadOnly txtDetail As New TextBox()
    Private ReadOnly searchTimer As New System.Windows.Forms.Timer()
    Private _loading As Boolean = True

    Public Sub New()
        Text = "Activity Logs"
        BackColor = Theme.Background
        Font = Theme.UiFont(10)

        ' ---- filter panel ----
        pnlFilters.Dock = DockStyle.Top
        pnlFilters.Height = 132
        pnlFilters.BackColor = Theme.Surface

        AddCaption("From", 16, 10)
        AddCaption("To", 240, 10)
        AddCaption("Activity type", 464, 10)
        AddCaption("Role", 672, 10)
        AddCaption("Search (activity, user name, username, reference)", 16, 68)

        For Each d As DateTimePicker In New DateTimePicker() {dtpFrom, dtpTo}
            d.Format = DateTimePickerFormat.Custom
            d.CustomFormat = "MMM dd, yyyy  hh:mm tt"
        Next
        dtpFrom.SetBounds(16, 32, 210, 28)
        dtpTo.SetBounds(240, 32, 210, 28)

        cboType.SetBounds(464, 32, 192, 28)
        cboType.DropDownStyle = ComboBoxStyle.DropDownList
        cboType.Items.AddRange(New Object() {"All activities", "Transaction", "Student Management", "Document Management", "User Management"})

        cboRole.SetBounds(672, 32, 170, 28)
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboRole.Items.AddRange(New Object() {"All roles", "Administrator", "Registrar Staff"})

        txtSearch.SetBounds(16, 90, 434, 28)

        For Each b As Button In New Button() {btnReset, btnAllTime}
            b.FlatStyle = FlatStyle.Flat
            b.BackColor = Theme.Surface
            b.ForeColor = Theme.TextMain
            b.FlatAppearance.BorderColor = Theme.Border
            b.Size = New Size(110, 30)
            b.Top = 89
        Next
        btnReset.Text = "Reset / Refresh" : btnReset.Left = 464 : btnReset.Width = 130
        btnAllTime.Text = "All time" : btnAllTime.Left = 604

        lblCount.SetBounds(724, 92, 300, 24)
        lblCount.ForeColor = Theme.TextMuted

        pnlFilters.Controls.AddRange(New Control() {dtpFrom, dtpTo, cboType, cboRole, txtSearch, btnReset, btnAllTime, lblCount})

        ' ---- grid ----
        Theme.StyleGrid(dgv)
        dgv.Dock = DockStyle.Fill
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.RowHeadersVisible = False
        dgv.MultiSelect = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' ---- detail box (long descriptions do not fit in a grid cell) ----
        txtDetail.Dock = DockStyle.Bottom
        txtDetail.Height = 92
        txtDetail.Multiline = True
        txtDetail.ReadOnly = True
        txtDetail.ScrollBars = ScrollBars.Vertical
        txtDetail.BackColor = Theme.Surface

        Controls.Add(dgv)          ' fill first, then bottom, then top
        Controls.Add(txtDetail)
        Controls.Add(pnlFilters)

        searchTimer.Interval = 350   ' wait until the user stops typing before querying
        AddHandler searchTimer.Tick, AddressOf SearchTimer_Tick
        AddHandler txtSearch.TextChanged, Sub(s, e)
                                              searchTimer.Stop()
                                              searchTimer.Start()
                                          End Sub
        AddHandler dtpFrom.ValueChanged, AddressOf FilterChanged
        AddHandler dtpTo.ValueChanged, AddressOf FilterChanged
        AddHandler cboType.SelectedIndexChanged, AddressOf FilterChanged
        AddHandler cboRole.SelectedIndexChanged, AddressOf FilterChanged
        AddHandler btnReset.Click, AddressOf Reset_Click
        AddHandler btnAllTime.Click, AddressOf AllTime_Click
        AddHandler dgv.SelectionChanged, AddressOf Grid_SelectionChanged
    End Sub

    Private Sub AddCaption(text As String, x As Integer, y As Integer)
        Dim l As New Label() With {.Text = text, .Left = x, .Top = y, .AutoSize = True, .ForeColor = Theme.TextMuted}
        pnlFilters.Controls.Add(l)
    End Sub

    Private Sub frmActivityLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The sidebar already hides this page from staff; this is the second lock on the door
        If Not AppSession.IsAdmin Then
            Controls.Clear()
            Controls.Add(New Label() With {.Text = "Only administrators can view the activity logs.",
                                           .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter})
            Return
        End If
        SetDefaults()
        _loading = False
        LoadLogs()
    End Sub

    Private Sub SetDefaults()
        dtpFrom.Value = DateTime.Today.AddDays(-30)
        dtpTo.Value = DateTime.Today.AddDays(1).AddSeconds(-1)   ' today, 11:59:59 PM
        cboType.SelectedIndex = 0
        cboRole.SelectedIndex = 0
        txtSearch.Clear()
    End Sub

    ' ---------------------------------------------------------------
    ' Filter events
    ' ---------------------------------------------------------------
    Private Sub FilterChanged(sender As Object, e As EventArgs)
        LoadLogs()
    End Sub

    Private Sub SearchTimer_Tick(sender As Object, e As EventArgs)
        searchTimer.Stop()
        LoadLogs()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs)
        _loading = True          ' change all filters first, then query once
        SetDefaults()
        _loading = False
        LoadLogs()
    End Sub

    Private Sub AllTime_Click(sender As Object, e As EventArgs)
        _loading = True
        dtpFrom.Value = New DateTime(2024, 1, 1)
        dtpTo.Value = DateTime.Today.AddDays(1).AddSeconds(-1)
        _loading = False
        LoadLogs()
    End Sub

    ' ---------------------------------------------------------------
    ' Query
    ' ---------------------------------------------------------------
    Private Sub LoadLogs()
        If _loading Then Return
        If dtpFrom.Value > dtpTo.Value Then
            MessageBox.Show("The 'From' date and time must not be later than 'To'.", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim sql As New System.Text.StringBuilder(
            "SELECT LogID, LogDate, FullName, Username, Role, ActivityType, Action, ReferenceNo, Description, Remarks " &
            "FROM tblactivitylogs WHERE LogDate BETWEEN @from AND @to")
        If cboType.SelectedIndex > 0 Then sql.Append(" AND ActivityType = @type")
        If cboRole.SelectedIndex > 0 Then sql.Append(" AND Role = @role")
        Dim keyword As String = txtSearch.Text.Trim()
        If keyword <> "" Then
            sql.Append(" AND (Action LIKE @k OR ActivityType LIKE @k OR FullName LIKE @k OR Username LIKE @k " &
                       "OR ReferenceNo LIKE @k OR Description LIKE @k OR Remarks LIKE @k)")
        End If
        sql.Append(" ORDER BY LogDate DESC, LogID DESC")

        Try
            Dim dt As New DataTable()
            Using c As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(sql.ToString(), c)
                    cmd.Parameters.AddWithValue("@from", dtpFrom.Value)
                    cmd.Parameters.AddWithValue("@to", dtpTo.Value)
                    If cboType.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@type", cboType.Text)
                    If cboRole.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@role", cboRole.Text)
                    If keyword <> "" Then cmd.Parameters.AddWithValue("@k", "%" & keyword & "%")
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgv.DataSource = dt
            FormatColumns()
            lblCount.Text = $"{dt.Rows.Count:N0} activities found"
            Grid_SelectionChanged(Nothing, EventArgs.Empty)
        Catch ex As Exception
            MessageBox.Show("Error loading the activity logs: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatColumns()
        With dgv
            If Not .Columns.Contains("LogID") Then Return
            .Columns("LogID").Visible = False
            SetCol("LogDate", "Date & Time", 15)
            SetCol("FullName", "User", 12)
            SetCol("Username", "Username", 9)
            SetCol("Role", "Role", 11)
            SetCol("ActivityType", "Type", 12)
            SetCol("Action", "Action", 12)
            SetCol("ReferenceNo", "Reference", 11)
            SetCol("Description", "Description", 32)
            SetCol("Remarks", "Remarks", 22)
            .Columns("LogDate").DefaultCellStyle.Format = "MMM dd, yyyy  hh:mm tt"
            .ClearSelection()
        End With
    End Sub

    Private Sub SetCol(name As String, header As String, weight As Single)
        dgv.Columns(name).HeaderText = header
        dgv.Columns(name).FillWeight = weight
        dgv.Columns(name).MinimumWidth = 80
    End Sub

    Private Sub Grid_SelectionChanged(sender As Object, e As EventArgs)
        If dgv.CurrentRow Is Nothing OrElse Not dgv.Columns.Contains("Description") Then
            txtDetail.Clear()
            Return
        End If
        Dim r As DataGridViewRow = dgv.CurrentRow
        txtDetail.Text = Convert.ToString(r.Cells("Description").Value) & vbCrLf & vbCrLf &
                         "Remarks: " & Convert.ToString(r.Cells("Remarks").Value)
    End Sub

End Class
