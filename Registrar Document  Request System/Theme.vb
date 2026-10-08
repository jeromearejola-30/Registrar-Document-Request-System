Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Reflection

''' <summary>
''' Single source of truth for the forest green + gold palette, fonts and shared styling helpers.
''' Every form/control reads from here so a future change is made once.
''' </summary>
Public Module Theme

    ' ---- Palette ----
    Public ReadOnly Primary As Color = ColorTranslator.FromHtml("#1B4332")       ' sidebar, table headers, filled buttons
    Public ReadOnly PrimaryHover As Color = ColorTranslator.FromHtml("#2D6A4F")  ' active menu item, button hover
    Public ReadOnly SidebarHover As Color = ColorTranslator.FromHtml("#245A41")  ' hover on an inactive menu item
    Public ReadOnly Accent As Color = ColorTranslator.FromHtml("#F2B807")        ' gold strip, title underline
    Public ReadOnly Background As Color = ColorTranslator.FromHtml("#F5F7F4")    ' form background
    Public ReadOnly Surface As Color = ColorTranslator.FromHtml("#FFFFFF")       ' cards, grid rows
    Public ReadOnly SurfaceAlt As Color = ColorTranslator.FromHtml("#F9FAFB")    ' alternate table row
    Public ReadOnly SelectionBack As Color = ColorTranslator.FromHtml("#DCEBE2") ' selected table row
    Public ReadOnly TextMain As Color = ColorTranslator.FromHtml("#1F2937")
    Public ReadOnly TextMuted As Color = ColorTranslator.FromHtml("#6B7280")
    Public ReadOnly Border As Color = ColorTranslator.FromHtml("#E5E7EB")

    ' ---- Fonts ----
    Public Const UiFontName As String = "Segoe UI"
    Public Const UiFontSemibold As String = "Segoe UI Semibold"
    Public Const IconFontName As String = "Segoe MDL2 Assets"   ' built into Windows 10/11

    Public Function UiFont(size As Single, Optional style As FontStyle = FontStyle.Regular) As Font
        Return New Font(UiFontName, size, style, GraphicsUnit.Point)
    End Function

    ' ---- Request status colors (used by cards and table "pills") ----
    Public Function StatusColor(status As String) As Color
        Select Case If(status, "").Trim().ToLowerInvariant()
            Case "pending" : Return ColorTranslator.FromHtml("#F59E0B")
            Case "processing" : Return ColorTranslator.FromHtml("#7C3AED")
            Case "ready for release" : Return ColorTranslator.FromHtml("#0D9488")
            Case "released" : Return ColorTranslator.FromHtml("#475569")
            Case "cancelled" : Return ColorTranslator.FromHtml("#DC2626")
            Case "paid" : Return PrimaryHover
            Case "refunded" : Return ColorTranslator.FromHtml("#2563EB")
            Case "unpaid" : Return ColorTranslator.FromHtml("#B45309")
            Case "active" : Return PrimaryHover
            Case "inactive" : Return ColorTranslator.FromHtml("#9CA3AF")
            Case Else : Return TextMuted
        End Select
    End Function

    Private Function StatusTextColor(status As String) As Color
        ' Amber needs dark text to stay readable; every other pill color takes white.
        Return If(String.Equals(If(status, "").Trim(), "Pending", StringComparison.OrdinalIgnoreCase), TextMain, Color.White)
    End Function

    ' ---- Logo ----
    ''' <summary>Loads Assets\loa_logo.png from the output folder. Returns Nothing if missing.</summary>
    Public Function LoadLogo() As Image
        Try
            Dim path As String = System.IO.Path.Combine(Application.StartupPath, "Assets", "loa_logo.png")
            If File.Exists(path) Then
                ' Copy into a new Bitmap so the file is not locked while the app runs.
                Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
                    Using img As Image = Image.FromStream(fs)
                        Return New Bitmap(img)
                    End Using
                End Using
            End If
        Catch
            ' A missing logo must never stop the app from starting.
        End Try
        Return Nothing
    End Function

    ' ---- Rounded rectangle path (for pills) ----
    Public Function RoundedRect(r As Rectangle, radius As Integer) As GraphicsPath
        Dim d As Integer = radius * 2
        Dim path As New GraphicsPath()
        path.AddArc(r.X, r.Y, d, d, 180, 90)
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90)
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
        path.CloseAllFigures()
        Return path
    End Function

    ' ---- ListView styling ----
    ''' <summary>
    ''' Gives a details-view ListView the green header, zebra rows, selection color, optional status
    ''' "pill" column, and makes its columns share the available width using the given weights
    ''' (one weight per column). Re-fits automatically whenever the control is resized.
    ''' </summary>
    Public Sub StyleListView(lv As ListView, weights As Integer(), Optional statusColumn As Integer = -1)
        lv.View = View.Details
        lv.FullRowSelect = True
        lv.GridLines = False
        lv.HideSelection = False
        lv.MultiSelect = False
        lv.BorderStyle = BorderStyle.None
        lv.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lv.BackColor = Surface
        lv.ForeColor = TextMain
        lv.Font = UiFont(9.5F)
        lv.OwnerDraw = True

        ' A 1px-wide image list is the standard trick to make ListView rows taller
        lv.SmallImageList = New ImageList() With {.ImageSize = New Size(1, lv.LogicalToDeviceUnits(36))}

        ' Stop the flicker that owner-drawn ListViews have by default
        GetType(Control).GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic).
            SetValue(lv, True, Nothing)

        Dim headerFont As Font = UiFont(9.5F, FontStyle.Bold)
        Dim pillFont As Font = UiFont(8.5F, FontStyle.Bold)
        AddHandler lv.Disposed, Sub(s, e)
                                    headerFont.Dispose()
                                    pillFont.Dispose()
                                End Sub

        Dim cellFlags As TextFormatFlags = TextFormatFlags.VerticalCenter Or TextFormatFlags.EndEllipsis Or TextFormatFlags.NoPrefix

        AddHandler lv.DrawColumnHeader, Sub(s, e)
                                            Using b As New SolidBrush(Primary)
                                                e.Graphics.FillRectangle(b, e.Bounds)
                                            End Using
                                            Dim r As Rectangle = e.Bounds
                                            r.Inflate(-10, 0)
                                            Dim align As TextFormatFlags = If(e.ColumnIndex = statusColumn, TextFormatFlags.HorizontalCenter, TextFormatFlags.Left)
                                            TextRenderer.DrawText(e.Graphics, e.Header.Text, headerFont, r, Color.White, cellFlags Or align)
                                        End Sub

        ' Rows are painted cell by cell in DrawSubItem, so DrawItem has nothing to do
        AddHandler lv.DrawItem, Sub(s, e)
                                End Sub

        AddHandler lv.DrawSubItem, Sub(s, e)
                                       Dim back As Color = If(e.Item.Selected, SelectionBack, If(e.ItemIndex Mod 2 = 1, SurfaceAlt, Surface))
                                       Using b As New SolidBrush(back)
                                           e.Graphics.FillRectangle(b, e.Bounds)
                                       End Using
                                       Using p As New Pen(Border)
                                           e.Graphics.DrawLine(p, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1)
                                       End Using

                                       If e.ColumnIndex = statusColumn Then
                                           DrawStatusPill(e.Graphics, e.Bounds, e.SubItem.Text, pillFont)
                                       Else
                                           Dim r As Rectangle = e.Bounds
                                           r.Inflate(-10, 0)
                                           TextRenderer.DrawText(e.Graphics, e.SubItem.Text, lv.Font, r, TextMain, cellFlags Or TextFormatFlags.Left)
                                       End If
                                   End Sub

        Dim fitColumns As Action = Sub()
                                       Dim count As Integer = Math.Min(lv.Columns.Count, weights.Length)
                                       Dim total As Integer = 0
                                       For i As Integer = 0 To count - 1
                                           total += weights(i)
                                       Next
                                       Dim avail As Integer = lv.ClientSize.Width
                                       If total <= 0 OrElse avail <= 0 Then Return
                                       Dim used As Integer = 0
                                       For i As Integer = 0 To count - 1
                                           Dim w As Integer = If(i = count - 1, avail - used, CInt(avail * weights(i) / total))
                                           lv.Columns(i).Width = Math.Max(w, 40)
                                           used += w
                                       Next
                                   End Sub
        AddHandler lv.SizeChanged, Sub(s, e) fitColumns()
        fitColumns()
    End Sub

    Public Sub DrawStatusPill(g As Graphics, cell As Rectangle, text As String, f As Font)
        If String.IsNullOrWhiteSpace(text) Then Return
        Dim k As Single = g.DpiX / 96.0F
        Dim h As Integer = CInt(22 * k)
        Dim w As Integer = TextRenderer.MeasureText(g, text, f).Width + CInt(20 * k)
        w = Math.Min(w, cell.Width - CInt(8 * k))
        Dim rect As New Rectangle(cell.X + (cell.Width - w) \ 2, cell.Y + (cell.Height - h) \ 2, w, h)

        Dim oldMode As SmoothingMode = g.SmoothingMode
        g.SmoothingMode = SmoothingMode.AntiAlias
        Using path As GraphicsPath = RoundedRect(rect, h \ 2)
            Using b As New SolidBrush(StatusColor(text))
                g.FillPath(b, path)
            End Using
        End Using
        g.SmoothingMode = oldMode

        TextRenderer.DrawText(g, text, f, rect, StatusTextColor(text),
                              TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or
                              TextFormatFlags.EndEllipsis Or TextFormatFlags.NoPrefix)
    End Sub

    ' ---- DataGridView styling ----
    ''' <summary>
    ''' Green header, zebra rows, soft selection, no row header, read-only, columns share the width.
    ''' Pass the name of a status column (e.g. "Status") to draw it as a colored pill.
    ''' Call this BEFORE binding data so the row height applies.
    ''' </summary>
    Public Sub StyleGrid(dgv As DataGridView, Optional statusColumn As String = Nothing)
        dgv.BorderStyle = BorderStyle.None
        dgv.BackgroundColor = Surface
        dgv.GridColor = Border
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.EnableHeadersVisualStyles = False
        dgv.RowHeadersVisible = False
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False
        dgv.ReadOnly = True
        dgv.MultiSelect = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgv.ColumnHeadersHeight = dgv.LogicalToDeviceUnits(40)
        dgv.RowTemplate.Height = dgv.LogicalToDeviceUnits(36)

        Dim header As New DataGridViewCellStyle()
        header.BackColor = Primary
        header.ForeColor = Color.White
        header.SelectionBackColor = Primary      ' header must not change color when clicked
        header.SelectionForeColor = Color.White
        header.Font = UiFont(9.5F, FontStyle.Bold)
        header.Alignment = DataGridViewContentAlignment.MiddleLeft
        header.Padding = New Padding(8, 0, 0, 0)
        dgv.ColumnHeadersDefaultCellStyle = header

        Dim cell As New DataGridViewCellStyle()
        cell.BackColor = Surface
        cell.ForeColor = TextMain
        cell.SelectionBackColor = SelectionBack
        cell.SelectionForeColor = TextMain
        cell.Font = UiFont(9.5F)
        cell.Alignment = DataGridViewContentAlignment.MiddleLeft
        cell.Padding = New Padding(8, 0, 0, 0)
        dgv.DefaultCellStyle = cell

        ' Only the colors are set here. If Alignment/Padding were copied from the cell style, every other row would
        ' ignore a column's own alignment (alternating-row style outranks the column style), e.g. a right-aligned Amount.
        Dim alt As New DataGridViewCellStyle()
        alt.BackColor = SurfaceAlt
        alt.SelectionBackColor = SelectionBack
        alt.SelectionForeColor = TextMain
        dgv.AlternatingRowsDefaultCellStyle = alt

        ' When there are many columns, scroll sideways instead of crushing them
        AddHandler dgv.DataBindingComplete, Sub(s, e)
                                                For Each col As DataGridViewColumn In dgv.Columns
                                                    col.MinimumWidth = dgv.LogicalToDeviceUnits(80)
                                                Next
                                            End Sub

        If Not String.IsNullOrEmpty(statusColumn) Then
            ' statusColumn may list several columns separated by commas, e.g. "Status,PaymentStatus"
            Dim pillColumns As String() = statusColumn.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
            For i As Integer = 0 To pillColumns.Length - 1
                pillColumns(i) = pillColumns(i).Trim()
            Next
            Dim pillFont As Font = UiFont(8.5F, FontStyle.Bold)
            AddHandler dgv.Disposed, Sub(s, e) pillFont.Dispose()
            AddHandler dgv.CellPainting, Sub(s, e)
                                             If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
                                             If Array.IndexOf(pillColumns, dgv.Columns(e.ColumnIndex).Name) < 0 Then Return
                                             ' Paint everything except the text, then draw the pill on top
                                             e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentForeground)
                                             DrawStatusPill(e.Graphics, e.CellBounds, Convert.ToString(e.FormattedValue), pillFont)
                                             e.Handled = True
                                         End Sub
        End If
    End Sub

    ' ---- Centered form card ----
    ''' <summary>
    ''' Keeps a "form card" centered, at most maxWidth wide, and exactly as tall as its content.
    ''' host = the scrolling page, card = the CardPanel, inner = the layout panel inside the card.
    ''' Re-runs on every resize; the page scrolls vertically if the window is too short.
    ''' </summary>
    Public Sub FitFormCard(host As ScrollableControl, card As Control, inner As Control, maxWidth As Integer)
        Dim place As Action = Sub()
                                  If host.ClientSize.Width <= 0 Then Return
                                  Dim sidePad As Integer = host.LogicalToDeviceUnits(28)
                                  Dim w As Integer = Math.Min(host.LogicalToDeviceUnits(maxWidth), host.ClientSize.Width - sidePad * 2)
                                  w = Math.Max(w, host.LogicalToDeviceUnits(520))
                                  Dim h As Integer = inner.GetPreferredSize(New Size(w - card.Padding.Horizontal, 0)).Height + card.Padding.Vertical
                                  Dim x As Integer = Math.Max(sidePad, (host.ClientSize.Width - w) \ 2) + host.AutoScrollPosition.X
                                  card.SetBounds(x, card.Top, w, h, BoundsSpecified.X Or BoundsSpecified.Width Or BoundsSpecified.Height)
                              End Sub
        AddHandler host.SizeChanged, Sub(s, e) place()
        place()
    End Sub

End Module
