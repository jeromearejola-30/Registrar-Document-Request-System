Imports MySql.Data.MySqlClient

''' <summary>
''' The rules for moving a request between stages, in one place.
''' The Request Manager board uses this; every message and check lives here.
''' </summary>
Public Module RequestWorkflow

    Private ReadOnly Order As String() = {"Pending", "Processing", "Ready for Release", "Released"}

    Public Function NextStage(status As String) As String
        Select Case status
            Case "Pending"
                Return "Processing"
            Case "Processing"
                Return "Ready for Release"
            Case "Ready for Release"
                Return "Released"
            Case Else
                Return ""
        End Select
    End Function

    Private Sub Warn(owner As IWin32Window, text As String)
        MessageBox.Show(owner, text, "Cannot Move Request", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    ''' <summary>Tries to move a request to the target column. Returns True only if the database changed.</summary>
    Public Function MoveTo(owner As IWin32Window, requestId As Integer, target As String) As Boolean
        Dim reqNo As String = ""
        Dim status As String = ""
        Dim pay As String = ""
        Dim total As Decimal = 0D

        Try
            Using c As New MySqlConnection(ConnectionText)
                c.Open()
                Using q As New MySqlCommand("SELECT RequestNo, Status, PaymentStatus, TotalAmount FROM tblrequest WHERE RequestID = @id", c)
                    q.Parameters.AddWithValue("@id", requestId)
                    Using r As MySqlDataReader = q.ExecuteReader()
                        If Not r.Read() Then
                            Warn(owner, "That request no longer exists.")
                            Return False
                        End If
                        reqNo = Convert.ToString(r("RequestNo"))
                        status = Convert.ToString(r("Status"))
                        pay = Convert.ToString(r("PaymentStatus"))
                        total = Convert.ToDecimal(r("TotalAmount"))
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(owner, "Error reading the request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        If status = target Then Return False   ' dropped back in the same column

        If status = "Released" OrElse status = "Cancelled" Then
            Warn(owner, $"{reqNo} is {status}. A finished request cannot be moved.")
            Return False
        End If

        If target = "Cancelled" Then
            If status <> "Pending" Then
                Warn(owner, $"Only Pending requests can be cancelled. {reqNo} is already {status}, so it can no longer be cancelled or refunded.")
                Return False
            End If
            Return CancelRequest(owner, requestId, reqNo, total)
        End If

        Dim nxt As String = NextStage(status)
        If target <> nxt Then
            If Array.IndexOf(Order, target) < Array.IndexOf(Order, status) Then
                Warn(owner, "A request cannot be moved backwards.")
            Else
                Warn(owner, $"A request moves one stage at a time. {reqNo} is {status}; its next stage is {nxt}.")
            End If
            Return False
        End If

        If pay <> "Paid" Then
            Warn(owner, $"{reqNo} is not paid yet. Open the request and record the payment first.")
            Return False
        End If

        Return Advance(owner, requestId, reqNo, status, target)
    End Function

    ' Locks the row and returns {Status, PaymentStatus} as they are right now
    Private Function LockRequest(c As MySqlConnection, tx As MySqlTransaction, requestId As Integer) As String()
        Using q As New MySqlCommand("SELECT Status, PaymentStatus FROM tblrequest WHERE RequestID = @id FOR UPDATE", c, tx)
            q.Parameters.AddWithValue("@id", requestId)
            Using r As MySqlDataReader = q.ExecuteReader()
                If Not r.Read() Then Throw New InvalidOperationException("The request no longer exists.")
                Return New String() {Convert.ToString(r("Status")), Convert.ToString(r("PaymentStatus"))}
            End Using
        End Using
    End Function

    Private Function Advance(owner As IWin32Window, requestId As Integer, reqNo As String, fromStage As String, target As String) As Boolean
        Dim msg As String = $"Move request {reqNo} from {fromStage} to {target}?"
        If target = "Processing" Then
            msg &= vbCrLf & vbCrLf & "Once the request is Processing it can no longer be cancelled or refunded."
        End If
        If MessageBox.Show(owner, msg, "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return False

        ' Fixed names chosen by our own code (never user input), so they are safe inside the SQL text
        Dim dateColumn As String = If(target = "Processing", "ProcessingDate", If(target = "Ready for Release", "ReadyDate", "ReleasedDate"))

        Try
            Using c As New MySqlConnection(ConnectionText)
                c.Open()
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Dim state As String() = LockRequest(c, tx, requestId)
                    If state(0) <> fromStage OrElse state(1) <> "Paid" Then
                        Throw New InvalidOperationException("This request was changed by someone else. Please refresh the board.")
                    End If
                    Using up As New MySqlCommand($"UPDATE tblrequest SET Status = @s, {dateColumn} = NOW() WHERE RequestID = @id", c, tx)
                        up.Parameters.AddWithValue("@s", target)
                        up.Parameters.AddWithValue("@id", requestId)
                        up.ExecuteNonQuery()
                    End Using
                    ActivityLogger.Log(c, tx, ActivityLogger.TypeTransaction, "Status Changed", reqNo,
                                       $"Request {reqNo} moved from {fromStage} to {target}")
                    tx.Commit()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(owner, "Error updating the request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function CancelRequest(owner As IWin32Window, requestId As Integer, reqNo As String, total As Decimal) As Boolean
        Dim msg As String = $"Cancel request {reqNo}?"
        If total > 0D Then
            msg &= vbCrLf & vbCrLf & "If this request was already paid, the payment will be REFUNDED and deducted from the payment report."
        End If
        msg &= vbCrLf & vbCrLf & "This cannot be undone."
        If MessageBox.Show(owner, msg, "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return False

        Dim reason As String
        Dim details As String
        Using dlg As New frmRemarks("Reason for Cancellation", $"Why is request {reqNo} being cancelled?", RemarkReasons.CancelRequest)
            If dlg.ShowDialog(owner) <> DialogResult.OK Then Return False
            reason = dlg.Reason
            details = dlg.Details
        End Using

        Dim refunded As Boolean = False
        Try
            Using c As New MySqlConnection(ConnectionText)
                c.Open()
                Using tx As MySqlTransaction = c.BeginTransaction()
                    Dim state As String() = LockRequest(c, tx, requestId)
                    If state(0) <> "Pending" Then
                        Throw New InvalidOperationException($"Only Pending requests can be cancelled. This request is now {state(0)}.")
                    End If
                    refunded = (state(1) = "Paid")

                    Using up As New MySqlCommand("UPDATE tblrequest SET Status = 'Cancelled', PaymentStatus = @pay, CancelReason = @reason, " &
                                                 "CancelRemarks = @details, CancelledBy = @by, CancelledDate = NOW() WHERE RequestID = @id", c, tx)
                        up.Parameters.AddWithValue("@pay", If(refunded, "Refunded", state(1)))
                        up.Parameters.AddWithValue("@reason", reason)
                        up.Parameters.AddWithValue("@details", details)
                        up.Parameters.AddWithValue("@by", AppSession.UserID)
                        up.Parameters.AddWithValue("@id", requestId)
                        up.ExecuteNonQuery()
                    End Using

                    If refunded Then
                        Using rf As New MySqlCommand("UPDATE tblpayments SET RefundedAt = NOW(), RefundedBy = @by, RefundRemarks = @rr WHERE RequestID = @id", c, tx)
                            rf.Parameters.AddWithValue("@by", AppSession.UserID)
                            rf.Parameters.AddWithValue("@rr", "Refund for cancelled request: " & reason)
                            rf.Parameters.AddWithValue("@id", requestId)
                            rf.ExecuteNonQuery()
                        End Using
                    End If

                    ActivityLogger.Log(c, tx, ActivityLogger.TypeTransaction, "Request Cancelled", reqNo,
                                       $"Cancelled request {reqNo} (was Pending, {If(refunded, "paid", "unpaid")}) - {reason}", reason & ": " & details)
                    If refunded Then
                        ActivityLogger.Log(c, tx, ActivityLogger.TypeTransaction, "Refund Issued", reqNo,
                                           $"Refunded ₱{total:N2} for cancelled request {reqNo}; deducted from payment report",
                                           "Refund for cancelled request: " & reason)
                    End If
                    tx.Commit()
                End Using
            End Using

            MessageBox.Show(owner, If(refunded, $"Request cancelled. Refund of ₱{total:N2} issued.", "Request cancelled."),
                            "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show(owner, "Error cancelling the request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module