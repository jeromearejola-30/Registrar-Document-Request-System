Imports MySql.Data.MySqlClient

Public Class frmCreateDocumentRequest

    ' Connection String - Adjust credentials as needed
    Dim connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Dim conn As New MySqlConnection(connStr)

    ' Property to hold the current logged in user ID (Default set to 1 if not passed)
    Public Property LoggedInUserID As Integer = 1

    Dim selectedStudentID As String = ""
    Dim docFeeMap As New Dictionary(Of String, Decimal)()
    Dim docIdMap As New Dictionary(Of String, Integer)()
    Dim currentUnitFee As Decimal = 0.00

    Private Sub frmCreateDocumentRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DataGridView Visual Setup
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.RowHeadersVisible = False
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.MultiSelect = False
        dgvStudents.ReadOnly = True

        ' Control Initial Values
        dtpRequestDate.Value = DateTime.Now
        numCopies.Minimum = 1
        numCopies.Maximum = 100
        numCopies.Value = 1

        cboPaymentStatus.Items.Clear()
        cboPaymentStatus.Items.AddRange(New String() {"Paid", "Unpaid"})
        cboPaymentStatus.SelectedIndex = 0

        ' Load Database Records
        LoadDocumentTypesAndFees()
        LoadStudents("")
    End Sub

    ' Load active documents and map fees and IDs
    Private Sub LoadDocumentTypesAndFees()
        Try
            cboDocumentType.Items.Clear()
            docFeeMap.Clear()
            docIdMap.Clear()

            conn.Open()
            Dim query As String = "SELECT DocumentID, DocumentName, Fee FROM tbldocuments WHERE Status = 'Active'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim docId As Integer = Convert.ToInt32(reader("DocumentID"))
                Dim docName As String = reader("DocumentName").ToString()
                Dim fee As Decimal = Convert.ToDecimal(reader("Fee"))

                cboDocumentType.Items.Add(docName)
                docFeeMap(docName) = fee
                docIdMap(docName) = docId
            End While

            reader.Close()
            conn.Close()

            If cboDocumentType.Items.Count > 0 Then
                cboDocumentType.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading document types: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Load student list into DataGridView with fixed SQL WHERE clause
    Public Sub LoadStudents(keyword As String)
        Try
            conn.Open()

            Dim query As String = "SELECT StudentID, " &
                                 "CONCAT(FirstName, ' ', IF(MiddleName IS NULL OR MiddleName = '', '', CONCAT(LEFT(MiddleName, 1), '. ')), LastName) AS StudentName, " &
                                 "Course, YearLevel, Section FROM tblstudents"

            If Not String.IsNullOrWhiteSpace(keyword) Then
                query &= " WHERE StudentID LIKE @k " &
                         "OR FirstName LIKE @k " &
                         "OR LastName LIKE @k " &
                         "OR Course LIKE @k " &
                         "OR CONCAT(FirstName, ' ', LastName) LIKE @k"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            If Not String.IsNullOrWhiteSpace(keyword) Then
                cmd.Parameters.AddWithValue("@k", "%" & keyword.Trim() & "%")
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvStudents.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Click row to select student and update display card
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)
            selectedStudentID = row.Cells("StudentID").Value.ToString()

            lblStudentName.Text = row.Cells("StudentName").Value.ToString()
            lblStudentDetails.Text = $"Student No. {selectedStudentID}   {row.Cells("Course").Value} {row.Cells("YearLevel").Value}   {row.Cells("Section").Value}"
        End If
    End Sub

    ' Update fee when document changes
    Private Sub cboDocumentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentType.SelectedIndexChanged
        Dim selectedDoc As String = cboDocumentType.Text
        If docFeeMap.ContainsKey(selectedDoc) Then
            currentUnitFee = docFeeMap(selectedDoc)
        Else
            currentUnitFee = 0.00
        End If
        CalculateAmount()
    End Sub

    ' Update total when copy count changes
    Private Sub numCopies_ValueChanged(sender As Object, e As EventArgs) Handles numCopies.ValueChanged
        CalculateAmount()
    End Sub

    ' Calculate unit price, copies, and total due for single-label display
    Private Sub CalculateAmount()
        Dim qty As Integer = Convert.ToInt32(numCopies.Value)
        Dim totalAmount As Decimal = currentUnitFee * qty

        lblFeePerCopy.Text = "Fee per Copy: " & currentUnitFee.ToString("N2")
        lblQuantity.Text = "Quantity: " & qty.ToString()
        lblAmountDue.Text = "Amount Due: " & totalAmount.ToString("N2")
    End Sub

    ' Live student search filtering
    Private Sub txtSearchStudent_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudent.TextChanged
        LoadStudents(txtSearchStudent.Text.Trim())
    End Sub

    ' Clear search filter input
    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchStudent.Clear()
        LoadStudents("")
    End Sub

    ' Reset current selected student
    Private Sub btnChangeStudent_Click(sender As Object, e As EventArgs) Handles btnChangeStudent.Click
        selectedStudentID = ""
        lblStudentName.Text = "[Select Student Above]"
        lblStudentDetails.Text = ""
    End Sub

    ' Submit request to MySQL database (tblrequest & tblrequestdetails)
    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        If selectedStudentID = "" Then
            MessageBox.Show("Please select a student from the table first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cboDocumentType.SelectedIndex < 0 Then
            MessageBox.Show("Please select a document type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()

            ' Generate unique request number
            Dim reqNo As String = "REQ-" & DateTime.Now.ToString("yyyy") & "-" & DateTime.Now.Ticks.ToString().Substring(12, 5)
            Dim qty As Integer = Convert.ToInt32(numCopies.Value)
            Dim totalAmount As Decimal = currentUnitFee * qty

            ' Insert record into tblrequest using dynamic CreatedBy user ID
            Dim insertReqQuery As String = "INSERT INTO tblrequest (RequestNo, StudentID, RequestDate, TotalAmount, PaymentStatus, Status, CreatedBy) " &
                                           "VALUES (@reqNo, @studentID, @reqDate, @totalAmount, @paymentStatus, 'Pending', @createdBy); " &
                                           "SELECT LAST_INSERT_ID();"

            Dim cmdReq As New MySqlCommand(insertReqQuery, conn)
            cmdReq.Parameters.AddWithValue("@reqNo", reqNo)
            cmdReq.Parameters.AddWithValue("@studentID", selectedStudentID)
            cmdReq.Parameters.AddWithValue("@reqDate", dtpRequestDate.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            cmdReq.Parameters.AddWithValue("@totalAmount", totalAmount)
            cmdReq.Parameters.AddWithValue("@paymentStatus", cboPaymentStatus.Text)
            cmdReq.Parameters.AddWithValue("@createdBy", LoggedInUserID)

            Dim newRequestId As Long = Convert.ToInt64(cmdReq.ExecuteScalar())

            ' Insert record into tblrequestdetails
            Dim selectedDocName As String = cboDocumentType.Text
            Dim docId As Integer = docIdMap(selectedDocName)

            Dim insertDetailsQuery As String = "INSERT INTO tblrequestdetails (RequestID, DocumentID, Quantity, Amount, SubTotal) " &
                                                "VALUES (@reqId, @docId, @qty, @fee, @subTotal)"

            Dim cmdDetails As New MySqlCommand(insertDetailsQuery, conn)
            cmdDetails.Parameters.AddWithValue("@reqId", newRequestId)
            cmdDetails.Parameters.AddWithValue("@docId", docId)
            cmdDetails.Parameters.AddWithValue("@qty", qty)
            cmdDetails.Parameters.AddWithValue("@fee", currentUnitFee)
            cmdDetails.Parameters.AddWithValue("@subTotal", totalAmount)

            cmdDetails.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Document request successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error submitting request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Cancel request and close form dialog
    Private Sub btnCancelRequest_Click(sender As Object, e As EventArgs) Handles btnCancelRequest.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class