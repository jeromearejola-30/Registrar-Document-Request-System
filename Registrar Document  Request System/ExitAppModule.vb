Imports Mysqlx.XDevAPI.Common
Module ExitAppModule
    Public Function ExitApp() As Boolean
        Dim result As DialogResult

        result = MessageBox.Show(
            "Do you want to close the system?",
            "System",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning
        )
        'Return True if OK is clicked, False if Cancel is clicked.
        Return (result = DialogResult.OK)

    End Function
End Module