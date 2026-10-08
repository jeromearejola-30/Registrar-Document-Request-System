''' <summary>
''' Holds the currently logged-in user for the whole app.
''' A Module is shared by every form, so no form needs to ask another form who is logged in.
''' </summary>
Public Module AppSession

    Public Property UserID As Integer
    Public Property Username As String = ""
    Public Property FullName As String = ""
    Public Property Role As String = ""

    Public ReadOnly Property IsLoggedIn As Boolean
        Get
            Return UserID > 0
        End Get
    End Property

    Public ReadOnly Property IsAdmin As Boolean
        Get
            Return String.Equals(Role, "Administrator", StringComparison.OrdinalIgnoreCase)
        End Get
    End Property

    Public Sub SignIn(id As Integer, user As String, name As String, userRole As String)
        UserID = id
        Username = user
        FullName = name
        Role = userRole
    End Sub

    Public Sub SignOut()
        UserID = 0
        Username = ""
        FullName = ""
        Role = ""
    End Sub

End Module