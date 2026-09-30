Imports MySql.Data.MySqlClient
Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRecentRequests()
        LoadStatistics()

    End Sub

    Private Sub LoadRecentRequests()
        ' Load recent requests into the ListView
        Try
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
                    ORDER BY r.RequestDate DESC, r.requestID DESC LIMIT 7
                   "
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("RequestNo").ToString())
                item.SubItems.Add(dr("LastName").ToString())
                item.SubItems.Add(dr("FirstName").ToString())
                item.SubItems.Add(dr("Course").ToString())
                item.SubItems.Add(dr("DocumentName").ToString())
                item.SubItems.Add(dr("RequestDate").ToString())
                item.SubItems.Add(dr("Status").ToString())
                lvRecentRequests.Items.Add(item)
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading recent requests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
        End Try
    End Sub

    Private Sub LoadStatistics()
        Try

            ' Load statistics into labels

            sql = "SELECT COUNT(*) AS TotalStudents FROM tblstudents"
            cmd = New MySqlCommand(sql, cn)
            Dim totalStudents As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblNumberTotalStudents.Text = totalStudents.ToString()

            sql = "SELECT COUNT(*) AS TotalRequests FROM tblrequest"
            cmd = New MySqlCommand(sql, cn)
            Dim totalRequests As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblNumberTotalRequest.Text = totalRequests.ToString()

            sql = "SELECT COUNT(*) AS RequestThisMonth FROM tblrequest WHERE YEAR(RequestDate) = YEAR(CURDATE()) AND MONTH(RequestDate) = MONTH(CURDATE())"
            cmd = New MySqlCommand(sql, cn)
            Dim requestsThisMonth As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblNumberRequestThisMonth.Text = requestsThisMonth.ToString()

            sql = "SELECT COUNT(*) AS PaymentsCollected FROM tblrequest WHERE Status = 'Paid'"
            cmd = New MySqlCommand(sql, cn)
            Dim paymentsCollected As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblNumberPaymentsCollected.Text = paymentsCollected.ToString()

            sql = "SELECT COUNT(*) AS PendingRequests FROM tblrequest WHERE Status = 'Pending'"
            cmd = New MySqlCommand(sql, cn)
            Dim pendingRequests As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblNumberPending.Text = pendingRequests.ToString()

            sql = "SELECT COUNT(*) AS ProcessingRequests FROM tblrequest WHERE Status = 'Processing'"
            cmd = New MySqlCommand(sql, cn)
            Dim processingRequests As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblNumberProcessing.Text = processingRequests.ToString()

            sql = "SELECT COUNT(*) AS ReadyForRelease FROM tblrequest WHERE Status = 'Ready For Release'"
            cmd = New MySqlCommand(sql, cn)
            Dim readyForReleaseRequests As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblNumberReadyforRelease.Text = readyForReleaseRequests.ToString()

            sql = "SELECT COUNT(*) AS CompletedRequests FROM tblrequest WHERE Status = 'Released'"
            cmd = New MySqlCommand(sql, cn)
            Dim completedRequests As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblNumberReleased.Text = completedRequests.ToString()

            sql = "SELECT COUNT(*) AS CancelledRequests FROM tblrequest WHERE Status = 'Cancelled'"
            cmd = New MySqlCommand(sql, cn)
            Dim cancelledRequests As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            lblNumberCancelled.Text = cancelledRequests.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading statistics: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
        End Try
    End Sub


End Class