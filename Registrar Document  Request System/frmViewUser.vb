Imports MySql.Data.MySqlClient

Public Class frmViewUser


    Private Sub frmViewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically load details when the form opens
        If Not String.IsNullOrEmpty(SelectedUserId) Then
            LoadViewedUser()
        End If
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click

    End Sub

    Public Property SelectedUserId As String

    Private Sub LoadViewedUser()
        Try
            ' Ensure the connection is open
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT * FROM tblUsers WHERE UserID = @user_id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@user_id", SelectedUserId)

            ' Execute the reader to populate dr
            dr = cmd.ExecuteReader()

            ' Read the returned row before pulling field values
            If dr.Read() Then
                txtUserFullName.Text = dr("FullName").ToString()
                txtUsername.Text = dr("Username").ToString()
                cboUserRole.SelectedItem = dr("role").ToString()
                cboUserStatus.SelectedItem = dr("status").ToString()
            Else
                MessageBox.Show("User not found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close the DataReader and Connection
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

End Class