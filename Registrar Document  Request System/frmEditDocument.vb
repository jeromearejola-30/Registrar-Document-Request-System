Imports MySql.Data.MySqlClient

Public Class frmEditDocument

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    ' Set by frmDocumentManagement before the page is shown
    Public Property DocumentID As String = ""

    Private Sub frmEditDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 860)

        cboDocStatus.Items.Clear()
        cboDocStatus.Items.AddRange(New Object() {"Active", "Inactive"}) ' matches tbldocuments.Status

        If String.IsNullOrEmpty(DocumentID) Then
            MessageBox.Show("No document was selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToDocumentManagement()
            Return
        End If
        LoadDocument()
    End Sub

    Private Sub LoadDocument()
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("SELECT DocumentName, Fee, Status, Description FROM tbldocuments WHERE DocumentID = @id", c)
                    cmd.Parameters.AddWithValue("@id", DocumentID)
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        If rd.Read() Then
                            txtDocName.Text = rd("DocumentName").ToString()
                            txtDocFee.Text = Convert.ToDecimal(rd("Fee")).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)
                            cboDocStatus.SelectedIndex = Math.Max(0, cboDocStatus.FindStringExact(rd("Status").ToString()))
                            txtDocDescription.Text = rd("Description").ToString()
                        Else
                            MessageBox.Show("Document not found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ReturnToDocumentManagement()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading document details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Accepts "150", "150.00", "1,500.50" or "₱150"; rejects negatives and text
    Private Function TryParseFee(text As String, ByRef fee As Decimal) As Boolean
        Dim cleaned As String = text.Replace("₱", "").Replace(",", "").Trim()
        If Not Decimal.TryParse(cleaned, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, fee) Then Return False
        If fee < 0 Then Return False
        fee = Math.Round(fee, 2)
        Return True
    End Function

    ' Only digits, one decimal point, commas, the peso sign and Backspace can be typed in the Fee box
    Private Sub txtDocFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocFee.KeyPress
        If Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = ","c OrElse e.KeyChar = "₱"c Then Return
        e.Handled = True
    End Sub

    ' Save Changes button
    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        If String.IsNullOrWhiteSpace(txtDocName.Text) OrElse String.IsNullOrWhiteSpace(txtDocFee.Text) Then
            MessageBox.Show("Please fill in Document Name and Fee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim fee As Decimal
        If Not TryParseFee(txtDocFee.Text, fee) Then
            MessageBox.Show("Fee must be a valid amount, for example 150 or 150.00.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDocFee.Focus()
            Return
        End If

        Try
            Using c As New MySqlConnection(connStr)
                c.Open()

                ' Another document must not already use this name
                Using check As New MySqlCommand("SELECT COUNT(*) FROM tbldocuments WHERE DocumentName = @name AND DocumentID <> @id", c)
                    check.Parameters.AddWithValue("@name", txtDocName.Text.Trim())
                    check.Parameters.AddWithValue("@id", DocumentID)
                    If Convert.ToInt32(check.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Another document already uses this name.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtDocName.Focus()
                        Return
                    End If
                End Using

                Dim query As String = "UPDATE tbldocuments SET DocumentName=@name, Fee=@fee, Status=@status, Description=@desc WHERE DocumentID=@id"
                Using cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@id", DocumentID)
                    cmd.Parameters.AddWithValue("@name", txtDocName.Text.Trim())
                    cmd.Parameters.AddWithValue("@fee", fee)
                    cmd.Parameters.AddWithValue("@status", cboDocStatus.Text)
                    cmd.Parameters.AddWithValue("@desc", txtDocDescription.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Document updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToDocumentManagement()
        Catch ex As Exception
            MessageBox.Show("Error updating document: " & ex.Message)
        End Try
    End Sub

    ' Delete Document button
    Private Sub btnDeleteDocument_Click(sender As Object, e As EventArgs) Handles btnDeleteDocument.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this document?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("DELETE FROM tbldocuments WHERE DocumentID=@id", c)
                    cmd.Parameters.AddWithValue("@id", DocumentID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Document deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToDocumentManagement()
        Catch ex As MySqlException When ex.Number = 1451
            ' 1451 = a foreign key blocks the delete (the document is used by existing requests)
            MessageBox.Show("This document is already used by existing requests and cannot be deleted." & vbCrLf &
                            "Set its Status to Inactive instead.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error deleting document: " & ex.Message)
        End Try
    End Sub

    ' Cancel button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ReturnToDocumentManagement()
    End Sub

    Private Sub ReturnToDocumentManagement()
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmDocumentManagement())
        Else
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class
