Imports MySql.Data.MySqlClient

Module dbConnect
    Public Const ConnectionText As String = "server=localhost;user=root;password=;port=3306;database=registrar_db"

    ' The shared connection already knows where the database is. frmDashboard, frmAddStudent and
    ' frmEditStudent use it directly, so it must never depend on the login form having opened it first.
    Public cn As New MySqlConnection(ConnectionText)
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    ''' <summary>Makes sure the shared connection is open. Silent: no pop-up on success.</summary>
    Public Sub Connection()
        If cn.State = ConnectionState.Open Then Return
        If String.IsNullOrEmpty(cn.ConnectionString) Then cn.ConnectionString = ConnectionText
        cn.Open()
    End Sub
End Module
