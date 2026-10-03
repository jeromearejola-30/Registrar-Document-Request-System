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

    Private Sub DrawStatusPill(g As Graphics, cell As Rectangle, text As String, f As Font)
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

End Module
