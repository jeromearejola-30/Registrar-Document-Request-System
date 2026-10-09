Imports MySql.Data.MySqlClient

Public Class frmEditDocument

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    ' Set by frmDocumentManagement before the page is shown
    Public Property DocumentID As String = ""

    Private originalStatus As String = ""

    Private Sub frmEditDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 860)

        cboDocStatus.Items.Clear()
        cboDocStatus.Items.AddRange(New Object() {"Active", "Inactive"}) ' matches tbldocuments.Status

        ' Name, fee and description are locked: only the Status may change
        For Each t As TextBox In New TextBox() {txtDocName, txtDocFee, txtDocDescription}
            t.ReadOnly = True
            t.BackColor = Color.FromArgb(243, 244, 246)
        Next
        btnDeleteDocument.Visible = False   ' documents are never deleted

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
                            originalStatus = cboDocStatus.Text
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
        Dim newStatus As String = cboDocStatus.Text
        If newStatus = originalStatus Then
            MessageBox.Show("Nothing to save. The document name, fee and description are locked; only the Status can be changed.",
                            "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim effect As String = If(newStatus = "Inactive",
                                  "An Inactive document cannot be selected for new requests.",
                                  "An Active document can be selected for new requests again.")
        Dim warning As DialogResult = MessageBox.Show(
            $"You are about to change '{txtDocName.Text}' from {originalStatus} to {newStatus}." & vbCrLf & vbCrLf &
            effect & vbCrLf & vbCrLf & "Are you sure?",
            "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If warning <> DialogResult.Yes Then Return

        Dim remarks As String
        Using dlg As New frmRemarks("Reason for Status Change", $"Why is '{txtDocName.Text}' being set to {newStatus}?",
        If(newStatus = "Inactive", RemarkReasons.DocumentDeactivate, RemarkReasons.DocumentActivate))
            If dlg.ShowDialog(Me) <> DialogResult.OK Then Return   ' <- this line was missing
            remarks = dlg.FullText
        End Using

        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Using cmd As New MySqlCommand("UPDATE tbldocuments SET Status = @status WHERE DocumentID = @id", c, tx)
                        cmd.Parameters.AddWithValue("@status", newStatus)
                        cmd.Parameters.AddWithValue("@id", DocumentID)
                        cmd.ExecuteNonQuery()
                    End Using
                    ActivityLogger.Log(c, tx, ActivityLogger.TypeDocument, "Document Status Changed", txtDocName.Text,
                                       $"Changed status of '{txtDocName.Text}' from {originalStatus} to {newStatus}", remarks)
                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Document status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToDocumentManagement()
        Catch ex As Exception
            MessageBox.Show("Error updating document: " & ex.Message)
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
