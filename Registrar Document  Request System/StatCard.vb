Imports System.ComponentModel

''' <summary>
''' A dashboard summary card: colored top strip, small title, big number.
''' The number shrinks automatically if the card is too narrow for it.
''' </summary>
Public Class StatCard
    Inherits Control

    Private _title As String = ""
    Private _value As String = "0"
    Private _accent As Color = Theme.Primary
    Private _selected As Boolean = False

    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
    End Sub

    <Category("Appearance"), DefaultValue("")>
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            Invalidate()
        End Set
    End Property

    <Category("Appearance"), DefaultValue("0")>
    Public Property Value As String
        Get
            Return _value
        End Get
        Set(value As String)
            _value = value
            Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property AccentColor As Color
        Get
            Return _accent
        End Get
        Set(value As Color)
            _accent = value
            Invalidate()
        End Set
    End Property

    ''' <summary>When True the card is outlined in its accent color (used by clickable filter cards).</summary>
    <Category("Appearance"), DefaultValue(False)>
    Public Property Selected As Boolean
        Get
            Return _selected
        End Get
        Set(value As Boolean)
            _selected = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.Clear(Theme.Surface)

        If _selected Then
            Using p As New Pen(_accent, 2.0F)
                g.DrawRectangle(p, 1, 1, Width - 3, Height - 3)
            End Using
        Else
            Using p As New Pen(Theme.Border)
                g.DrawRectangle(p, 0, 0, Width - 1, Height - 1)
            End Using
        End If

        Dim stripH As Integer = LogicalToDeviceUnits(4)
        Using b As New SolidBrush(_accent)
            g.FillRectangle(b, 0, 0, Width, stripH)
        End Using

        Dim pad As Integer = LogicalToDeviceUnits(16)
        Dim innerW As Integer = Math.Max(Width - pad * 2, 10)

        ' Title
        Dim titleRect As New Rectangle(pad, stripH + LogicalToDeviceUnits(10), innerW, LogicalToDeviceUnits(22))
        Using f As Font = Theme.UiFont(9.5F)
            TextRenderer.DrawText(g, _title, f, titleRect, Theme.TextMuted,
                                  TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or
                                  TextFormatFlags.EndEllipsis Or TextFormatFlags.NoPrefix)
        End Using

        ' Value: start big, shrink until it fits the card width
        Dim valueRect As New Rectangle(pad, titleRect.Bottom, innerW, Math.Max(Height - titleRect.Bottom - LogicalToDeviceUnits(6), 10))
        Dim size As Single = 24.0F
        Dim vf As Font = Nothing
        Try
            Do
                If vf IsNot Nothing Then vf.Dispose()
                vf = New Font(Theme.UiFontSemibold, size, FontStyle.Regular, GraphicsUnit.Point)
                If TextRenderer.MeasureText(g, _value, vf).Width <= innerW OrElse size <= 11.0F Then Exit Do
                size -= 1.0F
            Loop
            TextRenderer.DrawText(g, _value, vf, valueRect, Theme.TextMain,
                                  TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPrefix)
        Finally
            If vf IsNot Nothing Then vf.Dispose()
        End Try
    End Sub

End Class
