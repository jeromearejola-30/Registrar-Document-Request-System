Imports MySql.Data.MySqlClient

Public Class frmEditDocument

    ' Connection string
    Dim connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Dim conn As New MySqlConnection(connStr)

    ' Public properties to receive data from FormDocumentManagement
    Public Property DocumentID As String = ""
    Public Property DocumentName As String = ""
    Public Property DocumentFee As String = ""
    Public Property DocumentStatus As String = ""
    Public Property DocumentDescription As String = ""

    Private Sub frmEditDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load selected record values into controls
        txtDocName.Text = DocumentName
        txtDocFee.Text = DocumentFee
        cboDocStatus.Text = DocumentStatus
        txtDocDescription.Text = DocumentDescription
    End Sub

    ' Save Edit Button
    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        If txtDocName.Text = "" Or txtDocFee.Text = "" Then
            MessageBox.Show("Please fill in required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "UPDATE tbldocuments SET DocumentName=@name, Fee=@fee, Status=@status, Description=@desc WHERE DocumentID=@id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", DocumentID)
            cmd.Parameters.AddWithValue("@name", txtDocName.Text)
            cmd.Parameters.AddWithValue("@fee", txtDocFee.Text)
            cmd.Parameters.AddWithValue("@status", cboDocStatus.Text)
            cmd.Parameters.AddWithValue("@desc", txtDocDescription.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Document updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating document: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Delete Document Button
    Private Sub btnDeleteDocument_Click(sender As Object, e As EventArgs) Handles btnDeleteDocument.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this document?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Try
                conn.Open()
                Dim query As String = "DELETE FROM tbldocuments WHERE DocumentID=@id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", DocumentID)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Document deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error deleting document: " & ex.Message)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
    End Sub

    ' Cancel Button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class