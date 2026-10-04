Imports System.ComponentModel

''' <summary>White card with a 1px border. Use it for form sections and summary boxes.</summary>
Public Class CardPanel
    Inherits Panel

    Public Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw, True)
        BackColor = Theme.Surface
        Padding = New Padding(16)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Using p As New Pen(Theme.Border)
            e.Graphics.DrawRectangle(p, 0, 0, Width - 1, Height - 1)
        End Using
    End Sub

End Class
