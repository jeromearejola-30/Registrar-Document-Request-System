Imports MySql.Data.MySqlClient

Public Class frmViewUser


    Private Sub frmViewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadViewedUser()

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
            Dim UserId As String = SelectedUserId


            sql = "SELECT * FROM tbl_users WHERE user_id = @user_id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@user_id", UserId)

            txtUserFullName.Text = dr("FullName").ToString()
            txtUsername.Text = dr("Username").ToString()

            cboUserRole.SelectedItem = dr("role").ToString()
            cboUserStatus.SelectedItem = dr("status").ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
        End Try


    End Sub

End Class