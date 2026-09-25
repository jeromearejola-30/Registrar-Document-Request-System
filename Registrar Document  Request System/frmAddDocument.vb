Imports MySql.Data.MySqlClient

Public Class frmAddDocument

    ' Connection string
    Dim connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Dim conn As New MySqlConnection(connStr)

    ' Add Document Button
    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        If txtDocName.Text = "" Or txtDocFee.Text = "" Then
            MessageBox.Show("Please fill in Document Name and Fee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO tbldocuments (DocumentName, Fee, Status, Description) VALUES (@name, @fee, @status, @desc)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", txtDocName.Text)
            cmd.Parameters.AddWithValue("@fee", txtDocFee.Text)
            cmd.Parameters.AddWithValue("@status", If(cboDocStatus.Text = "", "Active", cboDocStatus.Text))
            cmd.Parameters.AddWithValue("@desc", txtDocDescription.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Document added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error adding document: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Clear All Button
    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtDocName.Clear()
        txtDocFee.Clear()
        txtDocDescription.Clear()
        cboDocStatus.SelectedIndex = -1
    End Sub

    ' Cancel Button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class