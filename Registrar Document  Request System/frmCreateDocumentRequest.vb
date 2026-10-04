Imports MySql.Data.MySqlClient

Public Class frmCreateDocumentRequest

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    ' Only used when the page is opened as a stand-alone dialog; inside the main window the
    ' logged-in user is looked up by username (see GetCurrentUserId)
    Public Property LoggedInUserID As Integer = 1

    Private selectedStudentID As String = ""
    Private ReadOnly docFeeMap As New Dictionary(Of String, Decimal)()
    Private ReadOnly docIdMap As New Dictionary(Of String, Integer)()
    Private currentUnitFee As Decimal = 0D

    Private Sub frmCreateDocumentRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.StyleGrid(dgvStudents)

        ' Control initial values
        dtpRequestDate.Value = DateTime.Now
        numCopies.Minimum = 1
        numCopies.Maximum = 100
        numCopies.Value = 1

        cboPaymentStatus.Items.Clear()
        ' Unpaid is the default: staff only switches to Paid after the student has paid at the counter
        cboPaymentStatus.Items.AddRange(New String() {"Unpaid", "Paid"})
        cboPaymentStatus.SelectedIndex = 0

        ResetStudentCard()
        LoadDocumentTypesAndFees()
        LoadStudents("")
    End Sub

    ' Load active documents and map fees and IDs
    Private Sub LoadDocumentTypesAndFees()
        Try
            cboDocumentType.Items.Clear()
            docFeeMap.Clear()
            docIdMap.Clear()

            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("SELECT DocumentID, DocumentName, Fee FROM tbldocuments WHERE Status = 'Active' ORDER BY DocumentName", c)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim docName As String = reader("DocumentName").ToString()
                            cboDocumentType.Items.Add(docName)
                            docFeeMap(docName) = Convert.ToDecimal(reader("Fee"))
                            docIdMap(docName) = Convert.ToInt32(reader("DocumentID"))
                        End While
                    End Using
                End Using
            End Using

            If cboDocumentType.Items.Count > 0 Then
                cboDocumentType.SelectedIndex = 0
            Else
                CalculateAmount()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading document types: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load the student list into the grid
    Public Sub LoadStudents(keyword As String)
        Try
            Dim query As String = "SELECT StudentID, " &
                                  "CONCAT(FirstName, ' ', IF(MiddleName IS NULL OR MiddleName = '', '', CONCAT(LEFT(MiddleName, 1), '. ')), LastName) AS StudentName, " &
                                  "Course, YearLevel, Section FROM tblstudents"

            If Not String.IsNullOrWhiteSpace(keyword) Then
                query &= " WHERE StudentID LIKE @k OR FirstName LIKE @k OR LastName LIKE @k OR Course LIKE @k " &
                         "OR CONCAT(FirstName, ' ', LastName) LIKE @k"
            End If
            query &= " ORDER BY LastName, FirstName"

            Dim dt As New DataTable()
            Using c As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(query, c)
                    If Not String.IsNullOrWhiteSpace(keyword) Then
                        cmd.Parameters.AddWithValue("@k", "%" & keyword.Trim() & "%")
                    End If
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgvStudents.DataSource = dt
            FormatStudentColumns()

            ' Nothing is pre-selected: a request must never go to a student the user did not pick
            dgvStudents.ClearSelection()
            dgvStudents.CurrentCell = Nothing
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatStudentColumns()
        With dgvStudents
            If Not .Columns.Contains("StudentID") Then Return
            .Columns("StudentID").HeaderText = "Student No."
            .Columns("StudentID").FillWeight = 17
            .Columns("StudentName").HeaderText = "Name"
            .Columns("StudentName").FillWeight = 35
            .Columns("Course").FillWeight = 14
            .Columns("YearLevel").HeaderText = "Year Level"
            .Columns("YearLevel").FillWeight = 17
            .Columns("Section").FillWeight = 17
        End With
    End Sub

    ' Click a row to choose the student
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)
        selectedStudentID = Convert.ToString(row.Cells("StudentID").Value)

        lblStudentName.Text = Convert.ToString(row.Cells("StudentName").Value)
        lblStudentDetails.Text = $"Student No. {selectedStudentID}   {row.Cells("Course").Value} {row.Cells("YearLevel").Value}   {row.Cells("Section").Value}"
    End Sub

    Private Sub ResetStudentCard()
        selectedStudentID = ""
        lblStudentName.Text = "[Select Student Above]"
        lblStudentDetails.Text = "Click a row in the table to choose a student."
    End Sub

    ' Update fee when the document changes
    Private Sub cboDocumentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentType.SelectedIndexChanged
        Dim selectedDoc As String = cboDocumentType.Text
        currentUnitFee = If(docFeeMap.ContainsKey(selectedDoc), docFeeMap(selectedDoc), 0D)
        CalculateAmount()
    End Sub

    Private Sub numCopies_ValueChanged(sender As Object, e As EventArgs) Handles numCopies.ValueChanged
        CalculateAmount()
    End Sub

    ' Fee per copy, quantity and total due
    Private Sub CalculateAmount()
        Dim qty As Integer = Convert.ToInt32(numCopies.Value)
        Dim totalAmount As Decimal = currentUnitFee * qty

        lblFeePerCopy.Text = "₱ " & currentUnitFee.ToString("N2")
        lblQuantity.Text = qty.ToString()
        lblAmountDue.Text = "₱ " & totalAmount.ToString("N2")
    End Sub

    Private Sub txtSearchStudent_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudent.TextChanged
        LoadStudents(txtSearchStudent.Text.Trim())
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchStudent.Clear()   ' clearing the box reloads the list through txtSearchStudent_TextChanged
        Me.ActiveControl = Nothing
    End Sub

    ' Forget the chosen student
    Private Sub btnChangeStudent_Click(sender As Object, e As EventArgs) Handles btnChangeStudent.Click
        ResetStudentCard()
        dgvStudents.ClearSelection()
        dgvStudents.CurrentCell = Nothing
    End Sub

    ' The logged-in user's ID, so "Created By" shows who really made the request
    Private Function GetCurrentUserId(c As MySqlConnection, tx As MySqlTransaction) As Integer
        Dim mainMenu = TryCast(Me.ParentForm, frmMainMenu)
        If mainMenu IsNot Nothing AndAlso Not String.IsNullOrEmpty(mainMenu.UserName) Then
            Using cmd As New MySqlCommand("SELECT UserID FROM tblusers WHERE Username = @u", c, tx)
                cmd.Parameters.AddWithValue("@u", mainMenu.UserName)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then Return Convert.ToInt32(result)
            End Using
        End If
        Return LoggedInUserID
    End Function

    ' Builds REQ-yyyy-##### and makes sure no other request already uses it
    Private Function NewRequestNumber(c As MySqlConnection, tx As MySqlTransaction) As String
        Dim rnd As New Random()
        For attempt As Integer = 1 To 50
            Dim candidate As String = "REQ-" & DateTime.Now.ToString("yyyy") & "-" & rnd.Next(1, 100000).ToString("00000")
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tblrequest WHERE RequestNo = @n", c, tx)
                cmd.Parameters.AddWithValue("@n", candidate)
                If Convert.ToInt32(cmd.ExecuteScalar()) = 0 Then Return candidate
            End Using
        Next
        Throw New InvalidOperationException("Could not generate a unique request number. Please try again.")
    End Function

    ' Save the request (tblrequest + tblrequestdetails) in one transaction
    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        If selectedStudentID = "" Then
            MessageBox.Show("Please select a student from the table first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboDocumentType.SelectedIndex < 0 Then
            MessageBox.Show("Please select a document type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qty As Integer = Convert.ToInt32(numCopies.Value)
        Dim totalAmount As Decimal = currentUnitFee * qty
        Dim docId As Integer = docIdMap(cboDocumentType.Text)
        Dim generatedOrNo As String = Nothing

        ' Paid issues an OR number, so make sure the payment was really received at the counter
        If RequestHelper.IsPaid(cboPaymentStatus.Text) Then
            If MessageBox.Show($"Confirm that the student has paid {totalAmount.ToString("N2")} pesos at the counter?" & vbCrLf & vbCrLf &
                               "An OR number will be issued for this request.", "Confirm Payment",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        End If

        Try
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Try
                        Dim reqNo As String = NewRequestNumber(c, tx)
                        Dim createdBy As Integer = GetCurrentUserId(c, tx)

                        ' An OR number is generated only when the request is created as "Paid"
                        Dim orNo As String = Nothing
                        If RequestHelper.IsPaid(cboPaymentStatus.Text) Then orNo = RequestHelper.NewORNumber(c, tx)
                        generatedOrNo = orNo

                        Dim insertReq As String = "INSERT INTO tblrequest (RequestNo, StudentID, RequestDate, TotalAmount, PaymentStatus, ORNo, ORDate, Status, CreatedBy) " &
                                                  "VALUES (@reqNo, @studentID, @reqDate, @totalAmount, @paymentStatus, @orNo, @orDate, 'Pending', @createdBy); " &
                                                  "SELECT LAST_INSERT_ID();"
                        Dim newRequestId As Long
                        Using cmdReq As New MySqlCommand(insertReq, c, tx)
                            cmdReq.Parameters.AddWithValue("@reqNo", reqNo)
                            cmdReq.Parameters.AddWithValue("@studentID", selectedStudentID)
                            cmdReq.Parameters.AddWithValue("@reqDate", dtpRequestDate.Value)
                            cmdReq.Parameters.AddWithValue("@totalAmount", totalAmount)
                            cmdReq.Parameters.AddWithValue("@paymentStatus", cboPaymentStatus.Text)
                            cmdReq.Parameters.AddWithValue("@orNo", If(orNo Is Nothing, CType(DBNull.Value, Object), orNo))
                            cmdReq.Parameters.AddWithValue("@orDate", If(orNo Is Nothing, CType(DBNull.Value, Object), DateTime.Now.Date))
                            cmdReq.Parameters.AddWithValue("@createdBy", createdBy)
                            newRequestId = Convert.ToInt64(cmdReq.ExecuteScalar())
                        End Using

                        Dim insertDetails As String = "INSERT INTO tblrequestdetails (RequestID, DocumentID, Quantity, Amount, SubTotal) " &
                                                      "VALUES (@reqId, @docId, @qty, @fee, @subTotal)"
                        Using cmdDetails As New MySqlCommand(insertDetails, c, tx)
                            cmdDetails.Parameters.AddWithValue("@reqId", newRequestId)
                            cmdDetails.Parameters.AddWithValue("@docId", docId)
                            cmdDetails.Parameters.AddWithValue("@qty", qty)
                            cmdDetails.Parameters.AddWithValue("@fee", currentUnitFee)
                            cmdDetails.Parameters.AddWithValue("@subTotal", totalAmount)
                            cmdDetails.ExecuteNonQuery()
                        End Using

                        tx.Commit()
                    Catch
                        tx.Rollback()   ' never leave a request without its details
                        Throw
                    End Try
                End Using
            End Using

            Dim doneMessage As String = "Document request successfully submitted!"
            If generatedOrNo IsNot Nothing Then
                doneMessage &= vbCrLf & vbCrLf & "OR Number: " & generatedOrNo
            Else
                doneMessage &= vbCrLf & vbCrLf & "Payment status: Unpaid. Open the request with View / Update once the student pays."
            End If
            MessageBox.Show(doneMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReturnToDocumentRequests()
        Catch ex As Exception
            MessageBox.Show("Error submitting request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelRequest_Click(sender As Object, e As EventArgs) Handles btnCancelRequest.Click
        ReturnToDocumentRequests()
    End Sub

    Private Sub ReturnToDocumentRequests()
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmDocumentRequest())
        Else
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class
