Imports MySql.Data.MySqlClient

Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRecentRequests()
        LoadStatistics()

    End Sub

    Private Sub LoadRecentRequests()

        Try

            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            lvRecentRequests.Items.Clear()

            sql = "SELECT 
                    r.RequestID,
                    r.RequestNo,
                    s.LastName,
                    s.FirstName,
                    s.Course,
                    d.DocumentName,
                    r.RequestDate, 
                    r.Status
                   FROM tblrequest AS r
                   INNER JOIN tblrequestdetails AS rd 
                       ON r.RequestID = rd.RequestID
                   INNER JOIN tblstudents AS s 
                       ON r.StudentID = s.StudentID
                   INNER JOIN tbldocuments AS d 
                       ON rd.DocumentID = d.DocumentID
                   ORDER BY r.RequestDate DESC, r.RequestID DESC 
                   LIMIT 7"

            Using cmd As New MySqlCommand(sql, cn)

                Using dr As MySqlDataReader = cmd.ExecuteReader()

                    While dr.Read()
                        ' Start with RequestNo as the main item
                        Dim item As New ListViewItem(dr("RequestNo").ToString())

                        ' Store RequestID in Tag for reference
                        item.Tag = dr("RequestID")

                        item.SubItems.Add(dr("LastName").ToString())
                        item.SubItems.Add(dr("FirstName").ToString())
                        item.SubItems.Add(dr("Course").ToString())
                        item.SubItems.Add(dr("DocumentName").ToString())
                        item.SubItems.Add(Convert.ToDateTime(dr("RequestDate")).ToString("MM/dd/yyyy"))
                        item.SubItems.Add(dr("Status").ToString())

                        lvRecentRequests.Items.Add(item)
                    End While

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading recent requests: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub LoadStatistics()

        Try

            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            ' Total Students
            sql = "SELECT COUNT(*) AS TotalStudents FROM tblstudents"

            Using cmd As New MySqlCommand(sql, cn)

                lblNumberTotalStudents.Text =
                    Convert.ToInt32(cmd.ExecuteScalar()).ToString()

            End Using


            ' Total Requests
            sql = "SELECT COUNT(*) AS TotalRequests FROM tblrequest"

            Using cmd As New MySqlCommand(sql, cn)

                lblNumberTotalRequest.Text =
                    Convert.ToInt32(cmd.ExecuteScalar()).ToString()

            End Using


            ' Requests This Month
            sql = "SELECT COUNT(*) AS RequestThisMonth
                   FROM tblrequest
                   WHERE YEAR(RequestDate) = YEAR(CURDATE())
                   AND MONTH(RequestDate) = MONTH(CURDATE())"

            Using cmd As New MySqlCommand(sql, cn)

                lblNumberRequestThisMonth.Text =
                    Convert.ToInt32(cmd.ExecuteScalar()).ToString()

            End Using


            ' Payments Collected
            sql = "SELECT IFNULL(SUM(TotalAmount), 0) FROM tblrequest WHERE PaymentStatus = 'Paid'" ' Or WHERE Status = 'Paid'

            Using cmd As New MySqlCommand(sql, cn)
                Dim paymentsCollected As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())

                ' Format as currency (e.g., ₱1,250.00 or $1,250.00)
                lblNumberPaymentsCollected.Text = "₱ " & paymentsCollected.ToString("N2") ' or "C2"
            End Using


            ' Pending Requests
            sql = "SELECT COUNT(*) AS PendingRequests
                   FROM tblrequest
                   WHERE Status = 'Pending'"

            Using cmd As New MySqlCommand(sql, cn)

                Dim pendingRequests As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())

                lblNumberPending.Text =
                    pendingRequests.ToString()

            End Using


            ' Processing Requests
            sql = "SELECT COUNT(*) AS ProcessingRequests
                   FROM tblrequest
                   WHERE Status = 'Processing'"

            Using cmd As New MySqlCommand(sql, cn)

                Dim processingRequests As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())

                lblNumberProcessing.Text =
                    processingRequests.ToString()

            End Using


            ' Ready For Release
            sql = "SELECT COUNT(*) AS ReadyForRelease
                   FROM tblrequest
                   WHERE Status = 'Ready For Release'"

            Using cmd As New MySqlCommand(sql, cn)

                Dim readyForReleaseRequests As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())

                lblNumberReadyforRelease.Text =
                    readyForReleaseRequests.ToString()

            End Using


            ' Released
            sql = "SELECT COUNT(*) AS CompletedRequests
                   FROM tblrequest
                   WHERE Status = 'Released'"

            Using cmd As New MySqlCommand(sql, cn)

                Dim completedRequests As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())

                lblNumberReleased.Text =
                    completedRequests.ToString()

            End Using


            ' Cancelled
            sql = "SELECT COUNT(*) AS CancelledRequests
                   FROM tblrequest
                   WHERE Status = 'Cancelled'"

            Using cmd As New MySqlCommand(sql, cn)

                Dim cancelledRequests As Integer =
                    Convert.ToInt32(cmd.ExecuteScalar())

                lblNumberCancelled.Text =
                    cancelledRequests.ToString()

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading statistics: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnSearchRecords_Click(sender As Object, e As EventArgs) Handles btnSearchRecords.Click

    End Sub

    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click

    End Sub

    Private Sub btnPaymentReport_Click(sender As Object, e As EventArgs) Handles btnPaymentReport.Click

    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click

    End Sub

    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click

    End Sub
End Class