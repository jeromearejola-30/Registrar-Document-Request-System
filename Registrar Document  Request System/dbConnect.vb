Imports MySql.Data.MySqlClient

Module dbConnect
    Public cn As New MySql.Data.MySqlClient.MySqlConnection
    Public cmd As MySql.Data.MySqlClient.MySqlCommand
    Public dr As MySql.Data.MySqlClient.MySqlDataReader
    Public sql As String

    Public Sub Connection()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.ConnectionString = "server=localhost;user=root;password=;port=3306;database=registrar_db"
        cn.Open()
        MessageBox.Show("Database Connected Successfully.", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module