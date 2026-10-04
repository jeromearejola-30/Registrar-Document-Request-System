Imports System.ComponentModel

Public Enum ButtonKind
    Primary     ' filled forest green  - the main action on a page
    Secondary   ' white with green outline - everything else
End Enum

''' <summary>Flat, theme-colored button. Set Kind in the designer; it styles itself.</summary>
Public Class ThemedButton
    Inherits Button

    Private _kind As ButtonKind = ButtonKind.Secondary

    Public Sub New()
        FlatStyle = FlatStyle.Flat
        UseVisualStyleBackColor = False
        Cursor = Cursors.Hand
        Font = Theme.UiFont(10.0F, FontStyle.Bold)
        ApplyKind()
    End Sub

    <Category("Appearance"), DefaultValue(ButtonKind.Secondary)>
    Public Property Kind As ButtonKind
        Get
            Return _kind
        End Get
        Set(value As ButtonKind)
            _kind = value
            ApplyKind()
        End Set
    End Property

    Private Sub ApplyKind()
        If _kind = ButtonKind.Primary Then
            BackColor = Theme.Primary
            ForeColor = Color.White
            FlatAppearance.BorderSize = 0
            FlatAppearance.MouseOverBackColor = Theme.PrimaryHover
            FlatAppearance.MouseDownBackColor = Theme.Primary
        Else
            BackColor = Theme.Surface
            ForeColor = Theme.Primary
            FlatAppearance.BorderSize = 1
            FlatAppearance.BorderColor = Theme.Primary
            FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#EAF2ED")
            FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#CFE3D6")
        End If
    End Sub

End Class
