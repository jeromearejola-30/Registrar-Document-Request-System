Imports MySql.Data.MySqlClient

''' <summary>
''' The only place that writes to tblactivitylogs.
''' The logged-in user's name and role come from AppSession, so a form can never log
''' an action "as" somebody else.
''' </summary>
Public Module ActivityLogger

    ' These must match the ENUM values in tblactivitylogs.ActivityType exactly
    Public Const TypeTransaction As String = "Transaction"
    Public Const TypeStudent As String = "Student Management"
    Public Const TypeDocument As String = "Document Management"
    Public Const TypeUser As String = "User Management"

    ''' <summary>
    ''' Writes a log row using the caller's connection and transaction, so the change
    ''' and its log row are saved together or not at all.
    ''' </summary>
    Public Sub Log(c As MySqlConnection, tx As MySqlTransaction,
                   activityType As String, action As String, referenceNo As String,
                   description As String, Optional remarks As String = Nothing)

        If Not AppSession.IsLoggedIn Then
            Throw New InvalidOperationException("Cannot write an activity log without a logged-in user.")
        End If

        Const SqlText As String =
            "INSERT INTO tblactivitylogs (LogDate, UserID, Username, FullName, Role, ActivityType, Action, ReferenceNo, Description, Remarks) " &
            "VALUES (NOW(), @uid, @un, @fn, @role, @type, @action, @ref, @desc, @rem)"

        Using cmd As New MySqlCommand(SqlText, c, tx)
            cmd.Parameters.AddWithValue("@uid", AppSession.UserID)
            cmd.Parameters.AddWithValue("@un", AppSession.Username)
            cmd.Parameters.AddWithValue("@fn", AppSession.FullName)
            cmd.Parameters.AddWithValue("@role", AppSession.Role)
            cmd.Parameters.AddWithValue("@type", activityType)
            cmd.Parameters.AddWithValue("@action", action)
            cmd.Parameters.AddWithValue("@ref", NullIfBlank(referenceNo))
            cmd.Parameters.AddWithValue("@desc", description)
            cmd.Parameters.AddWithValue("@rem", NullIfBlank(remarks))
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ''' <summary>Convenience version for a standalone log that is not part of a larger transaction.</summary>
    Public Sub Log(activityType As String, action As String, referenceNo As String,
                   description As String, Optional remarks As String = Nothing)
        Using c As New MySqlConnection(ConnectionText)
            c.Open()
            Log(c, Nothing, activityType, action, referenceNo, description, remarks)
        End Using
    End Sub

    Private Function NullIfBlank(value As String) As Object
        If String.IsNullOrWhiteSpace(value) Then Return DBNull.Value
        Return value.Trim()
    End Function

End Module