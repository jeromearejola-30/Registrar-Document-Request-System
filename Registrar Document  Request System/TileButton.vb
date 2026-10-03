Imports System.ComponentModel

''' <summary>
''' Quick-action tile: outlined card with an icon above a label. Fills green-tinted on hover.
''' </summary>
Public Class TileButton
    Inherits Button

    Private _glyph As String = ""
    Private _hover As Boolean = False
    Private _down As Boolean = False
    Private ReadOnly _glyphFont As New Font(Theme.IconFontName, 20.0F, FontStyle.Regular, GraphicsUnit.Point)

    Public Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        Cursor = Cursors.Hand
    End Sub

    ''' <summary>One Segoe MDL2 Assets character, e.g. ChrW(&HE721) for Search.</summary>
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

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        _hover = True
        Invalidate()
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        _hover = False
        _down = False
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        _down = True
        Invalidate()
        MyBase.OnMouseDown(mevent)
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        _down = False
        Invalidate()
        MyBase.OnMouseUp(mevent)
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

        Dim back As Color = Theme.Surface
        If _down Then
            back = ColorTranslator.FromHtml("#CFE3D6")
        ElseIf _hover Then
            back = ColorTranslator.FromHtml("#EAF2ED")
        End If
        Using b As New SolidBrush(back)
            g.FillRectangle(b, ClientRectangle)
        End Using

        Dim borderColor As Color = If(_hover, Theme.PrimaryHover, Theme.Primary)
        Using p As New Pen(borderColor, 2.0F)
            g.DrawRectangle(p, 1, 1, Width - 3, Height - 3)
        End Using

        ' Icon + label are stacked and centered vertically as one block
        Dim glyphH As Integer = LogicalToDeviceUnits(30)
        Dim gap As Integer = LogicalToDeviceUnits(4)
        Dim textH As Integer = LogicalToDeviceUnits(20)
        Dim top As Integer = Math.Max((Height - (glyphH + gap + textH)) \ 2, 2)

        Dim glyphRect As New Rectangle(0, top, Width, glyphH)
        TextRenderer.DrawText(g, _glyph, _glyphFont, glyphRect, Theme.Primary,
                              TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPrefix)

        Dim textRect As New Rectangle(LogicalToDeviceUnits(4), top + glyphH + gap, Width - LogicalToDeviceUnits(8), textH)
        Using f As Font = Theme.UiFont(9.5F, FontStyle.Bold)
            TextRenderer.DrawText(g, Text, f, textRect, Theme.TextMain,
                                  TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or
                                  TextFormatFlags.EndEllipsis Or TextFormatFlags.NoPrefix)
        End Using

        If Focused AndAlso ShowFocusCues Then
            Dim r As Rectangle = ClientRectangle
            r.Inflate(-5, -5)
            ControlPaint.DrawFocusRectangle(g, r, Theme.Primary, back)
        End If
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then _glyphFont.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class
