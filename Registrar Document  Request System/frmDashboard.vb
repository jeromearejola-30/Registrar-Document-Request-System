Imports MySql.Data.MySqlClient

Public Class frmDashboard

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Private ReadOnly recentTip As New ToolTip()

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Column weights = how the table's width is shared; the last number is the Status (pill) column
        Theme.StyleListView(lvRecentRequests, {18, 14, 14, 8, 20, 12, 16}, 6)

        recentTip.SetToolTip(lvRecentRequests, "Double-click a request to open its details.")


        ' Populate the status filter combo box and load items
        cboFilterRecentRequests.Items.Clear()
        cboFilterRecentRequests.Items.AddRange(New String() {"All", "Pending", "Processing", "Ready for Release", "Released", "Cancelled"})
        cboFilterRecentRequests.SelectedIndex = 0

        LoadRecentRequests()
        LoadStatistics()

    End Sub



    ' Double-click a recent request to open Request Details (the RequestID is stored in each row's Tag)
    Private Sub lvRecentRequests_DoubleClick(sender As Object, e As EventArgs) Handles lvRecentRequests.DoubleClick
        If lvRecentRequests.SelectedItems.Count = 0 Then Return
        Dim idValue As Object = lvRecentRequests.SelectedItems(0).Tag
        If idValue Is Nothing OrElse IsDBNull(idValue) Then Return

        Dim page As New frmRequestDetails()
        page.RequestID = Convert.ToString(idValue)
        TryCast(Me.ParentForm, frmMainMenu)?.ShowChildForm(page)
    End Sub

    Private Sub LoadRecentRequests()
        Try
            lvRecentRequests.Items.Clear()

            Dim sql As String = "SELECT r.RequestID, r.RequestNo, s.LastName, s.FirstName, s.Course, d.DocumentName, r.RequestDate, r.Status " &
                                "FROM tblrequest AS r " &
                                "INNER JOIN tblrequestdetails AS rd ON r.RequestID = rd.RequestID " &
                                "INNER JOIN tblstudents AS s ON r.StudentID = s.StudentID " &
                                "INNER JOIN tbldocuments AS d ON rd.DocumentID = d.DocumentID " &
                                "ORDER BY r.RequestDate DESC, r.RequestID DESC LIMIT 7"

            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand(sql, c)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim item As New ListViewItem(dr("RequestNo").ToString())

                            ' The RequestID is kept in Tag so a double-click can open the request
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
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading recent requests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadStatistics()
        Try
            Using c As New MySqlConnection(connStr)
                c.Open()

                cardTotalStudents.Value = CountOf(c, "SELECT COUNT(*) FROM tblstudents")
                cardTotalRequests.Value = CountOf(c, "SELECT COUNT(*) FROM tblrequest")
                cardRequestsThisMonth.Value = CountOf(c, "SELECT COUNT(*) FROM tblrequest WHERE YEAR(RequestDate) = YEAR(CURDATE()) AND MONTH(RequestDate) = MONTH(CURDATE())")

                cardPending.Value = CountOf(c, "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Pending'")
                cardProcessing.Value = CountOf(c, "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Processing'")
                cardReadyForRelease.Value = CountOf(c, "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Ready for Release'")
                cardReleased.Value = CountOf(c, "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Released'")
                cardCancelled.Value = CountOf(c, "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Cancelled'")

                ' Net payments: paid requests that were later cancelled are deducted (same rule as the Payment Report)
                Using cmd As New MySqlCommand("SELECT IFNULL(SUM(TotalAmount), 0) FROM tblrequest WHERE PaymentStatus = 'Paid' AND Status <> 'Cancelled'", c)
                    Dim paymentsCollected As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                    cardPaymentsCollected.Value = "₱ " & paymentsCollected.ToString("N2")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading statistics: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadFilteredRecentRequests(status As String)
        Try
            lvRecentRequests.Items.Clear()
            Dim sql As String = "SELECT r.RequestID, r.RequestNo, s.LastName, s.FirstName, s.Course, d.DocumentName, r.RequestDate, r.Status " &
                                "FROM tblrequest AS r " &
                                "INNER JOIN tblrequestdetails AS rd ON r.RequestID = rd.RequestID " &
                                "INNER JOIN tblstudents AS s ON r.StudentID = s.StudentID " &
                                "INNER JOIN tbldocuments AS d ON rd.DocumentID = d.DocumentID " &
                                "WHERE r.Status = @Status " &
                                "ORDER BY r.RequestDate DESC, r.RequestID DESC LIMIT 7"
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand(sql, c)
                    cmd.Parameters.AddWithValue("@Status", status)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim item As New ListViewItem(dr("RequestNo").ToString())
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
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading filtered recent requests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboFilterRecentRequests_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterRecentRequests.SelectedIndexChanged
        ' Filter the recent requests based on the selected status
        Dim selectedStatus As String = cboFilterRecentRequests.SelectedItem?.ToString()
        If String.IsNullOrEmpty(selectedStatus) OrElse selectedStatus = "All" Then
            LoadRecentRequests() ' Load all recent requests
        Else
            LoadFilteredRecentRequests(selectedStatus)
        End If
    End Sub

    ' Runs one COUNT query and returns the number as text for a card
    Private Shared Function CountOf(c As MySqlConnection, sql As String) As String
        Using cmd As New MySqlCommand(sql, c)
            Return Convert.ToInt32(cmd.ExecuteScalar()).ToString()
        End Using
    End Function

    ' ---- Quick actions ----

    Private Sub btnSearchRecords_Click(sender As Object, e As EventArgs) Handles btnSearchRecords.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmSearchRecords())
        End If
    End Sub

    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmCreateDocumentRequest())
        End If
    End Sub

    Private Sub btnPaymentReport_Click(sender As Object, e As EventArgs) Handles btnPaymentReport.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmPaymentReport())
        End If
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmAddStudent())
        End If
    End Sub

    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        Dim parentMainForm = TryCast(Me.ParentForm, frmMainMenu)
        If parentMainForm IsNot Nothing Then
            parentMainForm.ShowChildForm(New frmAddDocument())
        End If
    End Sub
End Class
