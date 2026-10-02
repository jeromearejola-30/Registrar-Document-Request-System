Imports MySql.Data.MySqlClient

Public Class frmUserManagement

    Private ReadOnly PlaceholderText As String = "   Search user..."
    Private selectedUserId As String = String.Empty

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Prevent DataGridView from generating new auto columns on the right
        dgvUsers.AutoGenerateColumns = False

        ' Map database column names to your DataGridView designer columns
        MapGridColumns()

        LoadUsers()
        LoadActiveInactiveUsers()

        lblUsername.Text = String.Empty
        lblRole.Text = String.Empty
        txtSearchBox.Text = PlaceholderText
        txtSearchBox.ForeColor = Color.Gray
    End Sub

    ' Map DataGridView columns to match SQL SELECT fields
    Private Sub MapGridColumns()
        If dgvUsers.Columns.Contains("colUserID") Then dgvUsers.Columns("colUserID").DataPropertyName = "UserID"
        If dgvUsers.Columns.Contains("colUsername") Then dgvUsers.Columns("colUsername").DataPropertyName = "Username"
        If dgvUsers.Columns.Contains("colFullName") Then dgvUsers.Columns("colFullName").DataPropertyName = "FullName"
        If dgvUsers.Columns.Contains("colRole") Then dgvUsers.Columns("colRole").DataPropertyName = "Role"
        If dgvUsers.Columns.Contains("colUserStatus") Then dgvUsers.Columns("colUserStatus").DataPropertyName = "Status"
    End Sub

    ' Load all users into the DataGridView
    Public Sub LoadUsers()
        Try
            If cn.State <> ConnectionState.Open Then cn.Open()

            Dim sql As String = "SELECT UserID, Username, FullName, Role, Status FROM tblUsers"

            Using cmd As New MySqlCommand(sql, cn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvUsers.DataSource = dt
                End Using
            End Using

            ' Clear selection state upon reload
            selectedUserId = String.Empty
            lblUsername.Text = String.Empty
            lblRole.Text = String.Empty

        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub LoadActiveInactiveUsers()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()

            ' Active Users
            Dim sqlActive As String = "SELECT COUNT(*) FROM tblUsers WHERE Status = 'Active'"
            Using cmd As New MySqlCommand(sqlActive, cn)
                lblNumberActiveUsers.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
            End Using

            ' Inactive Users
            Dim sqlInactive As String = "SELECT COUNT(*) FROM tblUsers WHERE Status = 'Inactive'"
            Using cmd As New MySqlCommand(sqlInactive, cn)
                lblNumberInactiveUsers.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading user statistics: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' Filter users dynamically as the user types
    Private Sub SearchUsers(searchTerm As String)
        If String.IsNullOrWhiteSpace(searchTerm) Then
            LoadUsers()
            Return
        End If

        Try
            If cn.State <> ConnectionState.Open Then cn.Open()

            Dim sql As String = "SELECT UserID, Username, FullName, Role, Status FROM tblUsers " &
                               "WHERE Username LIKE @search OR FullName LIKE @search OR Role LIKE @search OR UserID LIKE @search"

            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvUsers.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' Handle cell selection to display labels and store UserID safely
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex < 0 Then Return

        Dim selectedRow As DataGridViewRow = dgvUsers.Rows(e.RowIndex)

        If TypeOf selectedRow.DataBoundItem Is DataRowView Then
            Dim drv = DirectCast(selectedRow.DataBoundItem, DataRowView)

            If drv.Row.Table.Columns.Contains("Username") AndAlso drv("Username") IsNot DBNull.Value Then
                lblUsername.Text = drv("Username").ToString()
            End If

            If drv.Row.Table.Columns.Contains("Role") AndAlso drv("Role") IsNot DBNull.Value Then
                lblRole.Text = drv("Role").ToString()
            End If

            If drv.Row.Table.Columns.Contains("UserID") AndAlso drv("UserID") IsNot DBNull.Value Then
                selectedUserId = drv("UserID").ToString()
            End If
        End If
    End Sub

    ' Open child view user form with selected user ID
    Private Sub btnViewUser_Click(sender As Object, e As EventArgs) Handles btnViewUser.Click
        If String.IsNullOrEmpty(selectedUserId) Then
            MessageBox.Show("Please select a user from the table first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim viewForm As New frmViewUser()
        viewForm.SelectedUserId = selectedUserId

        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(viewForm)
        Else
            viewForm.ShowDialog()
        End If
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmAddUser())
        Else
            Dim addForm As New frmAddUser()
            addForm.ShowDialog()
        End If
    End Sub

    Private Sub txtSearchBox_Enter(sender As Object, e As EventArgs) Handles txtSearchBox.Enter
        If txtSearchBox.Text = PlaceholderText Then
            txtSearchBox.Text = ""
            txtSearchBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchBox_Leave(sender As Object, e As EventArgs) Handles txtSearchBox.Leave
        If String.IsNullOrWhiteSpace(txtSearchBox.Text) Then
            txtSearchBox.Text = PlaceholderText
            txtSearchBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If txtSearchBox.Text <> PlaceholderText Then
            SearchUsers(txtSearchBox.Text.Trim())
        End If
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchBox.Text = PlaceholderText
        txtSearchBox.ForeColor = Color.Gray
        Me.ActiveControl = Nothing
        LoadUsers()
    End Sub

End Class