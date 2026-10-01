Imports MySql.Data.MySqlClient

Public Class frmUserManagement

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadUsers()
        LoadActiveInactiveUsers()

    End Sub


    Private Sub LoadUsers()

        Try

            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            dgvUsers.Rows.Clear()

            sql = "SELECT UserID, Username, FullName, Role, Status
                   FROM tblUsers"

            Using cmd As New MySqlCommand(sql, cn)

                Using dr As MySqlDataReader = cmd.ExecuteReader()

                    While dr.Read()

                        dgvUsers.Rows.Add(
                            dr("UserID").ToString(),
                            dr("Username").ToString(),
                            dr("FullName").ToString(),
                            dr("Role").ToString(),
                            dr("Status").ToString()
                        )

                    End While

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading users: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub LoadActiveInactiveUsers()

        Try

            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If


            ' Active Users
            sql = "SELECT COUNT(*)
                   FROM tblUsers
                   WHERE Status = 'Active'"

            Using cmd As New MySqlCommand(sql, cn)

                Dim ActiveUsers As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())

                lblNumberActiveUsers.Text =
                    ActiveUsers.ToString()

            End Using


            ' Inactive Users
            sql = "SELECT COUNT(*)
                   FROM tblUsers
                   WHERE Status = 'Inactive'"

            Using cmd As New MySqlCommand(sql, cn)

                Dim InactiveUsers As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())

                lblNumberInactiveUsers.Text =
                    InactiveUsers.ToString()

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading user statistics: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub btnViewUser_Click(sender As Object, e As EventArgs) Handles btnViewUser.Click

        ShowChildForm(New frmViewUser())

    End Sub


    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

    End Sub


    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click

    End Sub


    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged

    End Sub


    Private Sub ShowChildForm(childForm As Form)

        ' Close the current child form if it exists
        If Me.fplContentArea.Controls.Count > 0 Then

            Me.fplContentArea.Controls(0).Dispose()

        End If

        ' Set the new child form properties and display it
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        Me.fplContentArea.Controls.Add(childForm)
        Me.fplContentArea.Tag = childForm

        childForm.BringToFront()
        childForm.Show()

    End Sub


    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        If e.RowIndex < 0 Then Return

        Dim dataItem = dgvUsers.Rows(e.RowIndex).DataBoundItem

        If dataItem Is Nothing Then

            ' Fallback: try the cell by name if the column exists
            If dgvUsers.Columns.Cast(Of DataGridViewColumn)().
                Any(Function(c) c.Name = "UserID") Then

                Dim val = dgvUsers.Rows(e.RowIndex).Cells("UserID").Value

                If val IsNot Nothing Then
                    frmViewUser.SelectedUserId = val.ToString()
                End If

            End If

            Return

        End If


        If TypeOf dataItem Is DataRowView Then

            Dim drv = DirectCast(dataItem, DataRowView)

            If drv.Row.Table.Columns.Contains("UserID") AndAlso
               drv("UserID") IsNot DBNull.Value Then

                frmViewUser.SelectedUserId =
                    drv("UserID").ToString()

            End If

        Else

            ' For a bound POCO/class object
            ' reflect to get UserID property safely
            Dim prop = dataItem.GetType().GetProperty("UserID")

            If prop IsNot Nothing Then

                Dim val = prop.GetValue(dataItem)

                If val IsNot Nothing Then
                    frmViewUser.SelectedUserId =
                        val.ToString()
                End If

            End If

        End If



    End Sub

End Class