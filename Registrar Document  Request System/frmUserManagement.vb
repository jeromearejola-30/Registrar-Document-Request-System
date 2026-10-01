Imports MySql.Data.MySqlClient

Public Class frmUserManagement
    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        LoadActiveInactiveUsers()
    End Sub

    Private Sub LoadUsers()
        ' Load users into the DataGridView

        Try


            dgvUsers.Rows.Clear()

            sql = "SELECT * FROM tblUsers"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()


            While dr.Read()
                dgvUsers.Rows.Add(dr("UserID"), dr("Username"), dr("FullName"), dr("Role"), dr("Status"))
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading recent requests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
        End Try
    End Sub

    Private Sub LoadActiveInactiveUsers()
        ' Load the count of active and inactive users into the label
        Try

            sql = "SELECT COUNT(*) FROM tblUsers WHERE status = 'Active'"
            cmd = New MySqlCommand(sql, cn)
            Dim ActiveUsers As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblActiveUsers.Text = ActiveUsers.ToString()

            sql = "SELECT COUNT(*) FROM tblUsers WHERE status = 'Inactive'"
            cmd = New MySqlCommand(sql, cn)
            Dim InactiveUsers As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblInactiveUsers.Text = InactiveUsers.ToString()
        Catch ex As Exception
            MessageBox.Show("Error loading user statistics: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
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
            Me.fplContentArea.Controls(0).Dispose() ' Safely dispose of the current child form to free resources
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
        If e.RowIndex >= 0 Then
            ' Get the selected user ID from the DataGridView
            frmViewUser.SelectedUserId = dgvUsers.Rows(e.RowIndex).Cells("UserID").Value.ToString()
        End If
    End Sub
End Class