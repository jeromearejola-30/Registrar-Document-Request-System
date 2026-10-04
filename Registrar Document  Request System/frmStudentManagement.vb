Imports MySql.Data.MySqlClient

Public Class frmStudentManagement

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    Private selectedStudentId As String = String.Empty
    Private showIncompleteOnly As Boolean = False   ' true while the grid is filtered by the Incomplete Records number
    Private ReadOnly tip As New ToolTip()
    Private missingFont As Font   ' created once, so painting thousands of cells does not leak fonts

    ' A record is incomplete when LRN or Contact No. is empty (Middle Name is optional, so it is not checked)
    Private Const MissingValueSql As String = "(LRN IS NULL OR TRIM(LRN) = '' OR ContactNo IS NULL OR TRIM(ContactNo) = '')"

    Private Sub FormStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' "Status" is drawn as a colored pill; every other column is a plain text column
        Theme.StyleGrid(dgvStudents, "Status")

        ' The Incomplete Records number (and its caption) act as a filter button
        For Each lbl As Label In {lblNumberIncompleteRecords, lblCapIncomplete}
            lbl.Cursor = Cursors.Hand
            tip.SetToolTip(lbl, "Click to show only students with a missing LRN or Contact No. Click again to show everyone.")
            AddHandler lbl.Click, AddressOf IncompleteFilter_Click
        Next

        LoadData()
        LoadStatusCounts()
    End Sub

    ' ---------------------------------------------------------------
    ' Loading
    ' ---------------------------------------------------------------
    ' One place that fills the grid, for the first load, Quick Search and Clear
    Sub LoadData(Optional keyword As String = "")
        Try
            Dim sql As String = "SELECT StudentID, LRN, LastName, FirstName, MiddleName, Course, YearLevel, Section, ContactNo, Status FROM tblstudents"
            Dim hasKeyword As Boolean = Not String.IsNullOrWhiteSpace(keyword)
            Dim conditions As New List(Of String)()
            If showIncompleteOnly Then conditions.Add(MissingValueSql)
            If hasKeyword Then conditions.Add("(StudentID LIKE @q OR LRN LIKE @q OR LastName LIKE @q OR FirstName LIKE @q)")
            If conditions.Count > 0 Then sql &= " WHERE " & String.Join(" AND ", conditions)
            sql &= " ORDER BY LastName, FirstName"

            Dim table As New DataTable()
            Using c As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(sql, c)
                    ' @q is a parameter, so whatever is typed can never be run as SQL
                    If hasKeyword Then cmd.Parameters.AddWithValue("@q", "%" & keyword.Trim() & "%")
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End Using
            dgvStudents.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Friendly headers and column widths; runs after every bind so they always survive a reload
    Private Sub dgvStudents_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvStudents.DataBindingComplete
        With dgvStudents
            If Not .Columns.Contains("StudentID") Then Return

            SetColumn("StudentID", "Student No.", 14)
            SetColumn("LRN", "LRN", 16)
            SetColumn("LastName", "Last Name", 15)
            SetColumn("FirstName", "First Name", 15)
            SetColumn("MiddleName", "Middle Name", 14)
            SetColumn("Course", "Course", 9)
            SetColumn("YearLevel", "Year Level", 11)
            SetColumn("Section", "Section", 9)
            SetColumn("ContactNo", "Contact No.", 15)
            SetColumn("Status", "Status", 11)

            .ClearSelection()
        End With
    End Sub

    Private Sub SetColumn(name As String, header As String, weight As Single)
        If Not dgvStudents.Columns.Contains(name) Then Return
        dgvStudents.Columns(name).HeaderText = header
        dgvStudents.Columns(name).FillWeight = weight
    End Sub

    ' An empty LRN or Contact No. shows "Missing" in red so incomplete records stand out
    Private Sub dgvStudents_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvStudents.CellFormatting
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return

        Dim colName As String = dgvStudents.Columns(e.ColumnIndex).Name
        If colName <> "LRN" AndAlso colName <> "ContactNo" Then Return

        If e.Value Is Nothing OrElse IsDBNull(e.Value) OrElse String.IsNullOrWhiteSpace(Convert.ToString(e.Value)) Then
            e.Value = "Missing"
            e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28)
            If missingFont Is Nothing Then missingFont = Theme.UiFont(9.5F, FontStyle.Italic)
            e.CellStyle.Font = missingFont
            e.FormattingApplied = True
        End If
    End Sub

    ' Click the Incomplete Records number: show only incomplete students, click again to go back
    Private Sub IncompleteFilter_Click(sender As Object, e As EventArgs)
        If showIncompleteOnly Then
            SetIncompleteFilter(False)
            Return
        End If

        ' Nothing to show? Say so instead of leaving the grid empty
        If lblNumberIncompleteRecords.Text = "0" Then
            MessageBox.Show("There are no incomplete records. Every student has an LRN and a Contact No.", "Incomplete Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        SetIncompleteFilter(True)
    End Sub

    Private Sub SetIncompleteFilter(enable As Boolean)
        showIncompleteOnly = enable
        ' Red number = the filter is on
        lblNumberIncompleteRecords.ForeColor = If(enable, Color.FromArgb(185, 28, 28), Theme.TextMain)
        LoadData(txtSearch.Text)
    End Sub

    ' Fill the "Student Status Summary" card
    Private Sub LoadStatusCounts()
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                lblNumberActiveStudents.Text = CountWhere(c, "Status = 'Active'")
                lblNumberInactiveStudents.Text = CountWhere(c, "Status = 'Inactive'")
                lblNumberIncompleteRecords.Text = CountWhere(c, MissingValueSql)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student counts: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Only fixed text from this file is ever passed in, never anything typed by the user
    Private Function CountWhere(c As MySqlConnection, condition As String) As String
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tblstudents WHERE " & condition, c)
            Return Convert.ToInt32(cmd.ExecuteScalar()).ToString()
        End Using
    End Function

    ' ---------------------------------------------------------------
    ' Search and selection
    ' ---------------------------------------------------------------
    ' Quick Search (the "Search..." hint is the TextBox's built-in PlaceholderText)
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadData(txtSearch.Text)
    End Sub

    ' View / Select Row
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex < 0 Then Return

        Dim selectedRow As DataGridViewRow = dgvStudents.Rows(e.RowIndex)
        Dim drv As DataRowView = TryCast(selectedRow.DataBoundItem, DataRowView)
        If drv Is Nothing Then Return

        selectedStudentId = Convert.ToString(drv("StudentID"))
        lblStudentNumber.Text = selectedStudentId
        lblLastName.Text = Convert.ToString(drv("LastName"))
        lblFirstName.Text = Convert.ToString(drv("FirstName"))
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()          ' clearing the box reloads the list through txtSearch_TextChanged
        Me.ActiveControl = Nothing
        If showIncompleteOnly Then SetIncompleteFilter(False)   ' Clear also turns the filter off
    End Sub

    Private Sub btnViewStudent_Click(sender As Object, e As EventArgs) Handles btnViewStudent.Click
        ' Fallback check: if variable is empty, try grabbing the ID straight from the selected DataGridView row
        If String.IsNullOrEmpty(selectedStudentId) AndAlso dgvStudents.CurrentRow IsNot Nothing Then
            Dim row = dgvStudents.CurrentRow
            If row.Cells("StudentID").Value IsNot Nothing Then
                selectedStudentId = row.Cells("StudentID").Value.ToString()
            End If
        End If

        ' If still empty, display notice
        If String.IsNullOrEmpty(selectedStudentId) Then
            MessageBox.Show("Please select a student from the table first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Open the edit/view student form
        Dim editForm As New frmEditStudent()
        editForm.selectedStudent = selectedStudentId

        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(editForm)
        Else
            editForm.ShowDialog()
        End If
    End Sub

    Private Sub btnAddStudentRecord_Click(sender As Object, e As EventArgs) Handles btnAddStudentRecord.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmAddStudent())
        Else
            Dim addForm As New frmAddStudent()
            addForm.ShowDialog()
        End If
    End Sub
End Class
