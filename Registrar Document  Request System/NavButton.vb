Imports System.ComponentModel

''' <summary>
''' Sidebar menu button: icon glyph + label, gold strip when active,
''' and an icon-only "Compact" mode for narrow windows.
''' </summary>
Public Class NavButton
    Inherits Button

    Private _glyph As String = ""
    Private _active As Boolean = False
    Private _compact As Boolean = False
    Private _hover As Boolean = False
    Private ReadOnly _glyphFont As New Font(Theme.IconFontName, 13.0F, FontStyle.Regular, GraphicsUnit.Point)

    Public Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        Cursor = Cursors.Hand
    End Sub

    ''' <summary>One Segoe MDL2 Assets character, e.g. ChrW(&HE80F) for Home.</summary>
    <Category("Appearance"), DefaultValue("")>
    Public Property Glyph As String
        Get
            Return _glyph
        End Get
        Set(value As String)
            _glyph = value
            Invalidate()
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Active As Boolean
        Get
            Return _active
        End Get
        Set(value As Boolean)
            If _active <> value Then
                _active = value
                Invalidate()
            End If
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Compact As Boolean
        Get
            Return _compact
        End Get
        Set(value As Boolean)
            If _compact <> value Then
                _compact = value
                Invalidate()
            End If
        End Set
    End Property

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        _hover = True
        Invalidate()
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        _hover = False
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        Invalidate()
        MyBase.OnGotFocus(e)
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        Invalidate()
        MyBase.OnLostFocus(e)
    End Sub

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim g As Graphics = pevent.Graphics

        ' 1) Background
        Dim back As Color = Theme.Primary
        If _active Then
            back = Theme.PrimaryHover
        ElseIf _hover Then
            back = Theme.SidebarHover
        End If
        Using b As New SolidBrush(back)
            g.FillRectangle(b, ClientRectangle)
        End Using

        ' 2) Gold strip on the left edge of the active item
        If _active Then
            Using b As New SolidBrush(Theme.Accent)
                g.FillRectangle(b, 0, 0, LogicalToDeviceUnits(4), Height)
            End Using
        End If

        ' 3) Icon: centered in the whole button when compact, otherwise in a fixed left column
        Dim iconColumn As Integer = LogicalToDeviceUnits(64)
        Dim glyphRect As Rectangle = If(_compact, ClientRectangle, New Rectangle(0, 0, iconColumn, Height))
        Dim flags As TextFormatFlags = TextFormatFlags.NoPrefix Or TextFormatFlags.VerticalCenter
        TextRenderer.DrawText(g, _glyph, _glyphFont, glyphRect, Color.White,
                              flags Or TextFormatFlags.HorizontalCenter)

        ' 4) Label (hidden in compact mode)
        If Not _compact Then
            Dim textRect As New Rectangle(iconColumn, 0, Width - iconColumn - LogicalToDeviceUnits(8), Height)
            TextRenderer.DrawText(g, Text, Font, textRect, Color.White,
                                  flags Or TextFormatFlags.Left Or TextFormatFlags.EndEllipsis)
        End If

        ' 5) Keyboard focus cue
        If Focused AndAlso ShowFocusCues Then
            Dim r As Rectangle = ClientRectangle
            r.Inflate(-2, -2)
            ControlPaint.DrawFocusRectangle(g, r, Color.White, back)
        End If
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then _glyphFont.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class
