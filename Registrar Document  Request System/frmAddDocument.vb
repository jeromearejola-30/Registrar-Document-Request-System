Imports MySql.Data.MySqlClient

Public Class frmAddDocument

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    Private Sub frmAddDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Keep the form card centered and sized to its content whenever the window is resized
        Theme.FitFormCard(Me, cardForm, tlpForm, 860)

        cboDocStatus.Items.Clear()
        cboDocStatus.Items.AddRange(New Object() {"Active", "Inactive"}) ' matches tbldocuments.Status
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtDocName.Clear()
        txtDocFee.Clear()
        txtDocDescription.Clear()
        cboDocStatus.SelectedIndex = 0   ' new documents start as Active
        txtDocName.Focus()
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

    ' Add Document button
    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
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

                ' Do not allow two documents with the same name
                Using check As New MySqlCommand("SELECT COUNT(*) FROM tbldocuments WHERE DocumentName = @name", c)
                    check.Parameters.AddWithValue("@name", txtDocName.Text.Trim())
                    If Convert.ToInt32(check.ExecuteScalar()) > 0 Then
                        MessageBox.Show("A document with this name already exists.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtDocName.Focus()
                        Return
                    End If
                End Using

                Dim query As String = "INSERT INTO tbldocuments (DocumentName, Fee, Status, Description) VALUES (@name, @fee, @status, @desc)"
                Using cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@name", txtDocName.Text.Trim())
                    cmd.Parameters.AddWithValue("@fee", fee)
                    cmd.Parameters.AddWithValue("@status", If(cboDocStatus.Text = "", "Active", cboDocStatus.Text))
                    cmd.Parameters.AddWithValue("@desc", txtDocDescription.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Document added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToDocumentManagement()
        Catch ex As Exception
            MessageBox.Show("Error adding document: " & ex.Message)
        End Try
    End Sub

    ' Clear All button
    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        ClearFields()
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
