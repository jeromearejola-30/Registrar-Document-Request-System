Imports MySql.Data.MySqlClient

''' <summary>Kanban board of document requests: drag a card between columns to move it.</summary>
Public Class frmRequestManager
    Inherits Form

    Private Shared ReadOnly Stages As String() = {"Pending", "Processing", "Ready for Release", "Released", "Cancelled"}
    Private Const MaxCardsPerColumn As Integer = 60
    Private ReadOnly LaneColor As Color = Color.FromArgb(238, 241, 239)
    Private ReadOnly LaneHover As Color = Color.FromArgb(214, 230, 221)

    ' What each card remembers about its request
    Private Class CardInfo
        Public Id As Integer
        Public RequestNo As String
        Public Status As String
        Public PaymentStatus As String
    End Class

    Private ReadOnly lanes As New Dictionary(Of String, FlowLayoutPanel)()
    Private ReadOnly laneTitles As New Dictionary(Of String, Label)()
    Private ReadOnly txtSearch As New TextBox()
    Private ReadOnly cboRange As New ComboBox()
    Private ReadOnly btnRefresh As New Button()
    Private ReadOnly btnBack As New Button()
    Private ReadOnly searchTimer As New System.Windows.Forms.Timer()

    Private ReadOnly ctx As New ContextMenuStrip()
    Private ReadOnly mnuOpen As New ToolStripMenuItem("Open details")
    Private ReadOnly mnuMove As New ToolStripMenuItem("Move to next stage")
    Private ReadOnly mnuCancel As New ToolStripMenuItem("Cancel request")
    Private _ctxInfo As CardInfo

    Private dragOrigin As Point
    Private _ready As Boolean = False

    Public Sub New()
        Text = "Request Manager"
        BackColor = Theme.Background
        Font = Theme.UiFont(10)

        ' ---- top bar ----
        Dim bar As New Panel() With {.Dock = DockStyle.Top, .Height = 86, .BackColor = Theme.Surface}
        Dim hint As New Label() With {
            .Text = "Drag a card to the next column, or right-click it. Double-click opens the request.",
            .Left = 16, .Top = 10, .AutoSize = True, .ForeColor = Theme.TextMuted}
        txtSearch.SetBounds(16, 42, 300, 28)
        cboRange.SetBounds(330, 42, 250, 28)
        cboRange.DropDownStyle = ComboBoxStyle.DropDownList
        cboRange.Items.AddRange(New Object() {"Released / Cancelled: last 7 days", "Released / Cancelled: last 30 days", "Released / Cancelled: last 90 days"})
        cboRange.SelectedIndex = 1
        For Each b As Button In New Button() {btnRefresh, btnBack}
            b.FlatStyle = FlatStyle.Flat
            b.Size = New Size(130, 30)
            b.Top = 41
            b.BackColor = Theme.Surface
            b.ForeColor = Theme.TextMain
            b.FlatAppearance.BorderColor = Theme.Border
        Next
        btnRefresh.Text = "Refresh" : btnRefresh.Left = 594
        btnBack.Text = "Back to Requests" : btnBack.Left = 734 : btnBack.Width = 150
        bar.Controls.AddRange(New Control() {hint, txtSearch, cboRange, btnRefresh, btnBack})

        ' ---- the board: five equal columns ----
        Dim board As New TableLayoutPanel() With {.Dock = DockStyle.Fill, .ColumnCount = Stages.Length, .RowCount = 1, .Padding = New Padding(10)}
        board.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        For i As Integer = 0 To Stages.Length - 1
            board.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F / Stages.Length))
            Dim stage As String = Stages(i)

            Dim lane As New Panel() With {.Dock = DockStyle.Fill, .Margin = New Padding(6), .BackColor = LaneColor}
            Dim title As New Label() With {
                .Dock = DockStyle.Top, .Height = 40, .TextAlign = ContentAlignment.MiddleLeft, .Padding = New Padding(12, 0, 0, 0),
                .Font = Theme.UiFont(10, FontStyle.Bold), .BackColor = Theme.StatusColor(stage),
                .ForeColor = If(stage = "Pending", Theme.TextMain, Color.White), .Text = stage}
            Dim flow As New FlowLayoutPanel() With {
                .Dock = DockStyle.Fill, .FlowDirection = FlowDirection.TopDown, .WrapContents = False,
                .AutoScroll = True, .Padding = New Padding(8), .AllowDrop = True, .Tag = stage, .BackColor = LaneColor}

            lane.Controls.Add(flow)    ' fill first, then the title docked on top
            lane.Controls.Add(title)
            board.Controls.Add(lane, i, 0)
            lanes(stage) = flow
            laneTitles(stage) = title

            AddHandler flow.DragEnter, AddressOf Lane_DragEnter
            AddHandler flow.DragLeave, AddressOf Lane_DragLeave
            AddHandler flow.DragDrop, AddressOf Lane_DragDrop
            AddHandler flow.Resize, AddressOf Lane_Resize
        Next

        Controls.Add(board)
        Controls.Add(bar)

        ' ---- right-click menu (the non-drag fallback) ----
        ctx.Items.AddRange(New ToolStripItem() {mnuOpen, mnuMove, mnuCancel})
        AddHandler ctx.Opening, AddressOf Ctx_Opening
        AddHandler mnuOpen.Click, Sub(s, e) If _ctxInfo IsNot Nothing Then OpenRequest(_ctxInfo.Id)
        AddHandler mnuMove.Click, AddressOf Menu_Move
        AddHandler mnuCancel.Click, AddressOf Menu_Cancel

        searchTimer.Interval = 350
        AddHandler searchTimer.Tick, Sub(s, e)
                                         searchTimer.Stop()
                                         LoadBoard()
                                     End Sub
        AddHandler txtSearch.TextChanged, Sub(s, e)
                                              searchTimer.Stop()
                                              searchTimer.Start()
                                          End Sub
        AddHandler cboRange.SelectedIndexChanged, Sub(s, e) LoadBoard()
        AddHandler btnRefresh.Click, Sub(s, e) LoadBoard()
        AddHandler btnBack.Click, AddressOf Back_Click
    End Sub

    Private Sub frmRequestManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ready = True
        LoadBoard()
    End Sub

    ' ---------------------------------------------------------------
    ' Loading the board
    ' ---------------------------------------------------------------
    Private Sub LoadBoard()
        If Not _ready Then Return
        Dim days As Integer = New Integer() {7, 30, 90}(cboRange.SelectedIndex)

        Dim sql As New System.Text.StringBuilder(
            "SELECT r.RequestID, r.RequestNo, r.Status, r.PaymentStatus, r.IsRush, r.RequestDate, r.ProcessingDate, r.ReadyDate, " &
            "r.ReleasedDate, r.CancelledDate, CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, d.DocumentName, rd.Quantity " &
            "FROM tblrequest r " &
            "JOIN tblstudents s ON s.StudentID = r.StudentID " &
            "JOIN tblrequestdetails rd ON rd.RequestID = r.RequestID " &
            "JOIN tbldocuments d ON d.DocumentID = rd.DocumentID " &
            "WHERE (r.Status IN ('Pending', 'Processing', 'Ready for Release') " &
            "OR (r.Status = 'Released' AND r.ReleasedDate >= @since) " &
            "OR (r.Status = 'Cancelled' AND r.CancelledDate >= @since))")
        Dim keyword As String = txtSearch.Text.Trim()
        If keyword <> "" Then
            sql.Append(" AND (r.RequestNo LIKE @k OR s.StudentID LIKE @k OR s.FirstName LIKE @k OR s.LastName LIKE @k " &
                       "OR CONCAT(s.FirstName, ' ', s.LastName) LIKE @k OR d.DocumentName LIKE @k)")
        End If
        sql.Append(" ORDER BY r.RequestDate ASC, r.RequestID ASC")

        Dim dt As New DataTable()
        Try
            Using c As New MySqlConnection(ConnectionText)
                Using q As New MySqlCommand(sql.ToString(), c)
                    q.Parameters.AddWithValue("@since", DateTime.Today.AddDays(-days))
                    If keyword <> "" Then q.Parameters.AddWithValue("@k", "%" & keyword & "%")
                    Using adapter As New MySqlDataAdapter(q)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading the board: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        For Each stage As String In Stages
            Dim flow As FlowLayoutPanel = lanes(stage)
            flow.SuspendLayout()
            For i As Integer = flow.Controls.Count - 1 To 0 Step -1
                Dim old As Control = flow.Controls(i)
                flow.Controls.RemoveAt(i)
                old.Dispose()
            Next

            Dim rows As New List(Of DataRow)()
            For Each r As DataRow In dt.Rows
                If Convert.ToString(r("Status")) = stage Then rows.Add(r)
            Next
            ' Active work: oldest first. Finished columns: newest first.
            If stage = "Released" OrElse stage = "Cancelled" Then rows.Reverse()

            Dim shown As Integer = Math.Min(rows.Count, MaxCardsPerColumn)
            For i As Integer = 0 To shown - 1
                flow.Controls.Add(BuildCard(rows(i), stage))
            Next
            If rows.Count > shown Then
                flow.Controls.Add(New Label() With {.Text = $"+ {rows.Count - shown} more. Use search to narrow.", .AutoSize = True,
                                                    .ForeColor = Theme.TextMuted, .Margin = New Padding(4)})
            End If

            laneTitles(stage).Text = If(rows.Count > shown, $"{stage}  ({shown} of {rows.Count})", $"{stage}  ({rows.Count})")
            ResizeCards(flow)
            flow.ResumeLayout()
        Next
    End Sub

    Private Function BuildCard(row As DataRow, stage As String) As Panel
        Dim info As New CardInfo() With {
            .Id = Convert.ToInt32(row("RequestID")), .RequestNo = Convert.ToString(row("RequestNo")),
            .Status = stage, .PaymentStatus = Convert.ToString(row("PaymentStatus"))}

        ' The date shown is when the request entered its current column
        Dim stampColumn As String = "RequestDate"
        Select Case stage
            Case "Processing" : stampColumn = "ProcessingDate"
            Case "Ready for Release" : stampColumn = "ReadyDate"
            Case "Released" : stampColumn = "ReleasedDate"
            Case "Cancelled" : stampColumn = "CancelledDate"
        End Select
        Dim stamp As DateTime = Convert.ToDateTime(If(IsDBNull(row(stampColumn)), row("RequestDate"), row(stampColumn)))

        Dim card As New Panel() With {.Height = 98, .Width = 200, .Margin = New Padding(0, 0, 0, 8), .BackColor = Color.White, .Tag = info, .Cursor = Cursors.Hand}
        Dim stripe As New Panel() With {.Dock = DockStyle.Left, .Width = 5, .BackColor = Theme.StatusColor(stage)}

        Dim lblNo As New Label() With {.Left = 14, .Top = 8, .Width = 130, .Height = 20, .Font = Theme.UiFont(10, FontStyle.Bold), .Text = info.RequestNo, .AutoEllipsis = True}
        Dim lblRush As New Label() With {.Top = 9, .Width = 44, .Height = 18, .Left = 150, .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
                                         .Text = "RUSH", .Font = Theme.UiFont(8, FontStyle.Bold), .ForeColor = Color.OrangeRed,
                                         .Visible = Convert.ToBoolean(row("IsRush"))}
        Dim lblStudent As New Label() With {.Left = 14, .Top = 30, .Width = 176, .Height = 18, .Text = Convert.ToString(row("StudentName")),
                                            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right, .AutoEllipsis = True}
        Dim lblDoc As New Label() With {.Left = 14, .Top = 50, .Width = 176, .Height = 18, .Text = $"{row("DocumentName")} x{row("Quantity")}",
                                        .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right, .AutoEllipsis = True, .ForeColor = Theme.TextMuted}
        Dim lblMeta As New Label() With {.Left = 14, .Top = 72, .Width = 176, .Height = 18, .Text = $"{info.PaymentStatus}  |  {stamp:MMM dd, yyyy}",
                                         .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right,
                                         .ForeColor = Theme.StatusColor(info.PaymentStatus), .Font = Theme.UiFont(9, FontStyle.Bold)}
        card.Controls.AddRange(New Control() {lblNo, lblRush, lblStudent, lblDoc, lblMeta, stripe})

        ' Every part of the card must react, otherwise a drag started on a label would do nothing
        For Each ctl As Control In New Control() {card, stripe, lblNo, lblRush, lblStudent, lblDoc, lblMeta}
            ctl.ContextMenuStrip = ctx
            ctl.AllowDrop = True
            AddHandler ctl.MouseDown, AddressOf Card_MouseDown
            AddHandler ctl.MouseMove, AddressOf Card_MouseMove
            AddHandler ctl.DoubleClick, AddressOf Card_DoubleClick
            AddHandler ctl.DragEnter, AddressOf Lane_DragEnter
            AddHandler ctl.DragLeave, AddressOf Lane_DragLeave
            AddHandler ctl.DragDrop, AddressOf Lane_DragDrop
        Next
        Return card
    End Function

    Private Sub Lane_Resize(sender As Object, e As EventArgs)
        ResizeCards(DirectCast(sender, FlowLayoutPanel))
    End Sub

    Private Sub ResizeCards(flow As FlowLayoutPanel)
        Dim w As Integer = Math.Max(140, flow.ClientSize.Width - flow.Padding.Horizontal - 2)
        For Each c As Control In flow.Controls
            c.Width = w
        Next
    End Sub

    ' ---------------------------------------------------------------
    ' Finding things from whichever control raised the event
    ' ---------------------------------------------------------------
    Private Function CardOf(ctl As Control) As Panel
        While ctl IsNot Nothing
            If TypeOf ctl.Tag Is CardInfo Then Return TryCast(ctl, Panel)
            ctl = ctl.Parent
        End While
        Return Nothing
    End Function

    Private Function LaneOf(ctl As Control) As FlowLayoutPanel
        While ctl IsNot Nothing
            If TypeOf ctl Is FlowLayoutPanel Then Return DirectCast(ctl, FlowLayoutPanel)
            ctl = ctl.Parent
        End While
        Return Nothing
    End Function

    ' ---------------------------------------------------------------
    ' Drag and drop
    ' ---------------------------------------------------------------
    Private Sub Card_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then dragOrigin = Control.MousePosition
    End Sub

    Private Sub Card_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button <> MouseButtons.Left Then Return
        ' Only start dragging after the mouse really moved, so a plain click or double-click still works
        Dim dx As Integer = Math.Abs(Control.MousePosition.X - dragOrigin.X)
        Dim dy As Integer = Math.Abs(Control.MousePosition.Y - dragOrigin.Y)
        If dx < SystemInformation.DragSize.Width AndAlso dy < SystemInformation.DragSize.Height Then Return

        Dim card As Panel = CardOf(DirectCast(sender, Control))
        If card Is Nothing Then Return
        Dim info As CardInfo = DirectCast(card.Tag, CardInfo)
        card.DoDragDrop(info.Id.ToString(), DragDropEffects.Move)
    End Sub

    Private Sub Lane_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(GetType(String)) Then
            e.Effect = DragDropEffects.Move
            Dim lane As FlowLayoutPanel = LaneOf(DirectCast(sender, Control))
            If lane IsNot Nothing Then lane.BackColor = LaneHover
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Lane_DragLeave(sender As Object, e As EventArgs)
        Dim lane As FlowLayoutPanel = LaneOf(DirectCast(sender, Control))
        If lane IsNot Nothing Then lane.BackColor = LaneColor
    End Sub

    Private Sub Lane_DragDrop(sender As Object, e As DragEventArgs)
        Dim lane As FlowLayoutPanel = LaneOf(DirectCast(sender, Control))
        If lane Is Nothing Then Return
        lane.BackColor = LaneColor

        Dim id As Integer
        If Not Integer.TryParse(Convert.ToString(e.Data.GetData(GetType(String))), id) Then Return
        Dim target As String = Convert.ToString(lane.Tag)

        ' Message boxes inside a drag-and-drop callback can hang; run the move after the drag has finished
        BeginInvoke(Sub()
                        If RequestWorkflow.MoveTo(Me, id, target) Then LoadBoard()
                    End Sub)
    End Sub

    ' ---------------------------------------------------------------
    ' Double-click, right-click menu and navigation
    ' ---------------------------------------------------------------
    Private Sub Card_DoubleClick(sender As Object, e As EventArgs)
        Dim card As Panel = CardOf(DirectCast(sender, Control))
        If card IsNot Nothing Then OpenRequest(DirectCast(card.Tag, CardInfo).Id)
    End Sub

    Private Sub Ctx_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Dim card As Panel = CardOf(ctx.SourceControl)
        If card Is Nothing Then
            e.Cancel = True
            Return
        End If
        _ctxInfo = DirectCast(card.Tag, CardInfo)
        Dim nxt As String = RequestWorkflow.NextStage(_ctxInfo.Status)
        mnuMove.Visible = (nxt <> "")
        mnuMove.Text = "Move to " & nxt
        mnuCancel.Visible = (_ctxInfo.Status = "Pending")
    End Sub

    Private Sub Menu_Move(sender As Object, e As EventArgs)
        If _ctxInfo Is Nothing Then Return
        If RequestWorkflow.MoveTo(Me, _ctxInfo.Id, RequestWorkflow.NextStage(_ctxInfo.Status)) Then LoadBoard()
    End Sub

    Private Sub Menu_Cancel(sender As Object, e As EventArgs)
        If _ctxInfo Is Nothing Then Return
        If RequestWorkflow.MoveTo(Me, _ctxInfo.Id, "Cancelled") Then LoadBoard()
    End Sub

    Private Sub OpenRequest(id As Integer)
        Dim host As frmMainMenu = TryCast(ParentForm, frmMainMenu)
        If host Is Nothing Then Return
        host.ShowChildForm(New frmRequestDetails() With {.RequestID = id.ToString()})
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs)
        Dim host As frmMainMenu = TryCast(ParentForm, frmMainMenu)
        If host IsNot Nothing Then host.ShowChildForm(New frmDocumentRequest())
    End Sub

End Class
