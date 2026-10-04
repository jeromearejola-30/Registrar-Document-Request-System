Imports MySql.Data.MySqlClient

Public Class frmUserManagement

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Private selectedUserId As String = String.Empty
    Private _loading As Boolean = False

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' "Status" is drawn as a colored pill; every other column is plain text
        Theme.StyleGrid(dgvUsers, "Status")

        LoadUsers()
        LoadActiveInactiveUsers()
    End Sub

    ' Load (or search) the user list. The password column is never selected.
    Public Sub LoadUsers(Optional searchTerm As String = "")
        Try
            Dim sql As String = "SELECT UserID, Username, FullName, Role, Status FROM tblUsers"
            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                sql &= " WHERE Username LIKE @search OR FullName LIKE @search OR Role LIKE @search OR UserID LIKE @search"
            End If
            sql &= " ORDER BY UserID"

            Dim dt As New DataTable()
            Using c As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(sql, c)
                    If Not String.IsNullOrWhiteSpace(searchTerm) Then
                        cmd.Parameters.AddWithValue("@search", "%" & searchTerm.Trim() & "%")
                    End If
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            _loading = True
            dgvUsers.DataSource = dt
            FormatColumns()
            _loading = False
            ShowSelected()
        Catch ex As Exception
            _loading = False
            MessageBox.Show("Error loading users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatColumns()
        With dgvUsers
            If Not .Columns.Contains("UserID") Then Return
            .Columns("UserID").HeaderText = "ID"
            .Columns("UserID").FillWeight = 10
            .Columns("Username").HeaderText = "Username"
            .Columns("Username").FillWeight = 25
            .Columns("FullName").HeaderText = "Full Name"
            .Columns("FullName").FillWeight = 33
            .Columns("Role").HeaderText = "Role"
            .Columns("Role").FillWeight = 20
            .Columns("Status").FillWeight = 14
            .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub LoadActiveInactiveUsers()
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                lblNumberActiveUsers.Text = CountByStatus(c, "Active")
                lblNumberInactiveUsers.Text = CountByStatus(c, "Inactive")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user statistics: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CountByStatus(c As MySqlConnection, status As String) As String
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tblUsers WHERE Status = @status", c)
            cmd.Parameters.AddWithValue("@status", status)
            Return Convert.ToInt32(cmd.ExecuteScalar()).ToString()
        End Using
    End Function

    ' Fill the "User Information" card from the selected row (mouse or arrow keys)
    Private Sub ShowSelected()
        Dim row As DataGridViewRow = dgvUsers.CurrentRow
        If row Is Nothing OrElse Not dgvUsers.Columns.Contains("UserID") Then
            selectedUserId = String.Empty
            lblUsername.Text = "-"
            lblRole.Text = "-"
            Return
        End If

        selectedUserId = Convert.ToString(row.Cells("UserID").Value)
        lblUsername.Text = Convert.ToString(row.Cells("Username").Value)
        lblRole.Text = Convert.ToString(row.Cells("Role").Value)
    End Sub

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        If _loading Then Return
        ShowSelected()
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        LoadUsers(txtSearchBox.Text.Trim())
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchBox.Clear()   ' reloads the full list through txtSearchBox_TextChanged
        Me.ActiveControl = Nothing
    End Sub

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

End Class
