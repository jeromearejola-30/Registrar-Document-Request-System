Imports MySql.Data.MySqlClient

Public Class frmDocumentManagement


    Dim connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Dim conn As New MySqlConnection(connStr)
    Dim selectedDocID As String = ""

    Sub LoadData()
        Try
            Dim adapter As New MySqlDataAdapter("SELECT DocumentID, DocumentName, Fee, Status, Description FROM tbldocuments", conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvDocuments.DataSource = table


            If dgvDocuments.Columns.Contains("Description") Then
                dgvDocuments.Columns("Description").Visible = False
            End If

            UpdateSummaryCounters()
        Catch ex As Exception
            MessageBox.Show("Error loading documents: " & ex.Message)
        End Try
    End Sub

    Sub UpdateSummaryCounters()
        Try
            conn.Open()


            Dim cmdActive As New MySqlCommand("SELECT COUNT(*) FROM tbldocuments WHERE Status='Active'", conn)
            lblActiveCount.Text = "Active Documents: " & cmdActive.ExecuteScalar().ToString()


            Dim cmdInactive As New MySqlCommand("SELECT COUNT(*) FROM tbldocuments WHERE Status='Inactive'", conn)
            lblInactiveCount.Text = "Inactive Documents: " & cmdInactive.ExecuteScalar().ToString()

            conn.Close()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Sub ClearFields()
        selectedDocID = ""
        txtDocName.Clear()
        cboDocStatus.SelectedIndex = -1
        txtDocFee.Clear()
        rtbDescription.Clear()
    End Sub

    Private Sub FormDocumentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim query As String = "SELECT DocumentID, DocumentName, Fee, Status, Description FROM tbldocuments WHERE DocumentName LIKE '%" & txtSearch.Text & "%'"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvDocuments.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        LoadData()
    End Sub

    Private Sub dgvDocuments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocuments.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDocuments.Rows(e.RowIndex)

            selectedDocID = row.Cells("DocumentID").Value.ToString()
            txtDocName.Text = row.Cells("DocumentName").Value.ToString()
            txtDocFee.Text = row.Cells("Fee").Value.ToString()
            cboDocStatus.Text = row.Cells("Status").Value.ToString()
            rtbDescription.Text = row.Cells("Description").Value.ToString()
        End If
    End Sub

    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        Dim addForm As New frmAddDocument()

        If addForm.ShowDialog() = DialogResult.OK Then
            LoadData()
        End If
    End Sub

    Private Sub btnEditDocument_Click(sender As Object, e As EventArgs) Handles btnEditDocument.Click
        If selectedDocID = "" Then
            MessageBox.Show("Please select a document from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim editForm As New frmEditDocument()

        editForm.DocumentID = selectedDocID
        editForm.DocumentName = txtDocName.Text
        editForm.DocumentFee = txtDocFee.Text
        editForm.DocumentStatus = cboDocStatus.Text

        If editForm.ShowDialog() = DialogResult.OK Then
            LoadData()
        End If
    End Sub

End Class