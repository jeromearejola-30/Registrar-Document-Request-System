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
        numCopies.Maximum = 2
        numCopies.Value = 1

        cboPaymentStatus.Items.Clear()
        ' Payment is no longer taken here: the request starts Unpaid and is paid from the request details (Step 4B)
        cboPaymentStatus.Visible = False


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
                                  "Course, YearLevel, Section FROM tblstudents WHERE Status = 'Active'"

            If Not String.IsNullOrWhiteSpace(keyword) Then
                query &= " AND (StudentID LIKE @k OR FirstName LIKE @k OR LastName LIKE @k OR Course LIKE @k " &
                         "OR CONCAT(FirstName, ' ', LastName) LIKE @k)"
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

    ' Builds the next REQ-yyyy-##### in sequence (same idea as NewORNumber)
    Private Function NewRequestNumber(c As MySqlConnection, tx As MySqlTransaction) As String
        Dim prefix As String = "REQ-" & DateTime.Now.ToString("yyyy") & "-"
        Dim sql As String = "SELECT COALESCE(MAX(CAST(SUBSTRING(RequestNo, @start) AS UNSIGNED)), 0) FROM tblrequest WHERE RequestNo LIKE @like"
        Using cmd As New MySqlCommand(sql, c, tx)
            cmd.Parameters.AddWithValue("@start", prefix.Length + 1)
            cmd.Parameters.AddWithValue("@like", prefix & "%")
            Dim last As Long = Convert.ToInt64(cmd.ExecuteScalar())
            Return prefix & (last + 1).ToString("00000")
        End Using
    End Function

    ' Save the request (tblrequest + tblrequestdetails + activity log) in one transaction
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
        If qty < 1 OrElse qty > 2 Then   ' safety net: the box already stops at 2
            MessageBox.Show("A request can have at most 2 copies.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim totalAmount As Decimal = currentUnitFee * qty
        Dim docId As Integer = docIdMap(cboDocumentType.Text)

        ' Mandatory reason: the request is not saved without one
        Dim purpose As String
        Dim remarks As String
        Using dlg As New frmRemarks("Reason for Request",
                                    $"Why is {lblStudentName.Text} requesting {cboDocumentType.Text}?",
                                    RemarkReasons.RequestPurpose)
            If dlg.ShowDialog(Me) <> DialogResult.OK Then Return
            purpose = dlg.Reason
            remarks = dlg.Details
        End Using

        Try
            Dim reqNo As String
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Try
                        reqNo = NewRequestNumber(c, tx)

                        Dim insertReq As String = "INSERT INTO tblrequest (RequestNo, StudentID, RequestDate, Purpose, RequestRemarks, IsRush, RushFee, TotalAmount, PaymentStatus, Status, CreatedBy) " &
                                                  "VALUES (@reqNo, @studentID, @reqDate, @purpose, @remarks, 0, 0, @totalAmount, 'Unpaid', 'Pending', @createdBy); " &
                                                  "SELECT LAST_INSERT_ID();"
                        Dim newRequestId As Long
                        Using cmdReq As New MySqlCommand(insertReq, c, tx)
                            cmdReq.Parameters.AddWithValue("@reqNo", reqNo)
                            cmdReq.Parameters.AddWithValue("@studentID", selectedStudentID)
                            cmdReq.Parameters.AddWithValue("@reqDate", dtpRequestDate.Value)
                            cmdReq.Parameters.AddWithValue("@purpose", purpose)
                            cmdReq.Parameters.AddWithValue("@remarks", remarks)
                            cmdReq.Parameters.AddWithValue("@totalAmount", totalAmount)
                            cmdReq.Parameters.AddWithValue("@createdBy", AppSession.UserID)
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

                        ActivityLogger.Log(c, tx, ActivityLogger.TypeTransaction, "Request Created", reqNo,
                            $"Created request {reqNo} for student {selectedStudentID} ({cboDocumentType.Text} x{qty}, total ₱{totalAmount:N2})",
                            $"{purpose}: {remarks}")

                        tx.Commit()
                    Catch
                        tx.Rollback()   ' never leave a request without its details or its log
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show($"Document request {reqNo} successfully submitted!" & vbCrLf & vbCrLf &
                            "Status: Pending, Unpaid. Open the request with View / Update to record the payment.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
