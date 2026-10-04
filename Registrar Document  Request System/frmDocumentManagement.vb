Imports MySql.Data.MySqlClient

Public Class frmDocumentManagement

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Private selectedDocID As String = ""
    Private _loading As Boolean = False

    Private Sub FormDocumentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' "Status" is drawn as a colored pill; every other column is plain text
        Theme.StyleGrid(dgvDocuments, "Status")
        LoadData()
    End Sub

    ' Load (or search) the document list
    Sub LoadData(Optional keyword As String = "")
        Try
            Dim table As New DataTable()
            Using c As New MySqlConnection(connStr)
                Dim sql As String = "SELECT DocumentID, DocumentName, Fee, Status, Description FROM tbldocuments " &
                                    "WHERE DocumentName LIKE @kw ORDER BY DocumentID"
                Using cmd As New MySqlCommand(sql, c)
                    cmd.Parameters.AddWithValue("@kw", "%" & keyword.Trim() & "%")
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End Using

            _loading = True
            dgvDocuments.DataSource = table
            FormatColumns()
            _loading = False

            UpdateSummaryCounters()
            ShowSelected()
        Catch ex As Exception
            _loading = False
            MessageBox.Show("Error loading documents: " & ex.Message)
        End Try
    End Sub

    ' Friendly headers + how the columns share the width (weights add up to 100)
    Private Sub FormatColumns()
        With dgvDocuments
            If Not .Columns.Contains("DocumentID") Then Return

            .Columns("Description").Visible = False

            .Columns("DocumentID").HeaderText = "ID"
            .Columns("DocumentID").FillWeight = 10
            .Columns("DocumentName").HeaderText = "Document Name"
            .Columns("DocumentName").FillWeight = 50

            .Columns("Fee").HeaderText = "Fee (₱)"
            .Columns("Fee").FillWeight = 20
            .Columns("Fee").DefaultCellStyle.Format = "N2"
            .Columns("Fee").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Fee").DefaultCellStyle.Padding = New Padding(0, 0, 16, 0)
            .Columns("Fee").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Fee").HeaderCell.Style.Padding = New Padding(0, 0, 16, 0)

            .Columns("Status").FillWeight = 20
            .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Sub UpdateSummaryCounters()
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                lblActiveCount.Text = CountByStatus(c, "Active")
                lblInactiveCount.Text = CountByStatus(c, "Inactive")
            End Using
        Catch ex As Exception
            lblActiveCount.Text = "-"
            lblInactiveCount.Text = "-"
        End Try
    End Sub

    Private Function CountByStatus(c As MySqlConnection, status As String) As String
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbldocuments WHERE Status = @status", c)
            cmd.Parameters.AddWithValue("@status", status)
            Return Convert.ToInt32(cmd.ExecuteScalar()).ToString()
        End Using
    End Function

    Sub ClearFields()
        selectedDocID = ""
        lblDocName.Text = "-"
        lblDocStatus.Text = "-"
        lblDocFee.Text = "-"
        rtbDescription.Clear()
    End Sub

    ' Fill the "Document Information" card and the description box from the selected row
    Private Sub ShowSelected()
        Dim row As DataGridViewRow = dgvDocuments.CurrentRow
        If row Is Nothing OrElse Not dgvDocuments.Columns.Contains("DocumentID") Then
            ClearFields()
            Return
        End If

        selectedDocID = Convert.ToString(row.Cells("DocumentID").Value)
        lblDocName.Text = Convert.ToString(row.Cells("DocumentName").Value)
        lblDocStatus.Text = Convert.ToString(row.Cells("Status").Value)

        Dim feeValue As Object = row.Cells("Fee").Value
        lblDocFee.Text = If(feeValue Is Nothing OrElse IsDBNull(feeValue), "-", "₱ " & Convert.ToDecimal(feeValue).ToString("N2"))

        rtbDescription.Text = Convert.ToString(row.Cells("Description").Value)
    End Sub

    Private Sub dgvDocuments_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDocuments.SelectionChanged
        If _loading Then Return
        ShowSelected()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadData(txtSearch.Text)
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()   ' clearing the box triggers the reload through txtSearch_TextChanged
        Me.ActiveControl = Nothing
    End Sub

    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmAddDocument())
        Else
            Dim addForm As New frmAddDocument()
            If addForm.ShowDialog() = DialogResult.OK Then LoadData()
        End If
    End Sub

    Private Sub btnEditDocument_Click(sender As Object, e As EventArgs) Handles btnEditDocument.Click
        If selectedDocID = "" Then
            MessageBox.Show("Please select a document from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' The edit page loads everything (including the description) from the database by ID
        Dim editForm As New frmEditDocument()
        editForm.DocumentID = selectedDocID

        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(editForm)
        Else
            If editForm.ShowDialog() = DialogResult.OK Then LoadData()
        End If
    End Sub

End Class
