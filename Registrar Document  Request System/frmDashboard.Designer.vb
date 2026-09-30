<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlDashboard = New Panel()
        fplListViewRecent = New FlowLayoutPanel()
        lvRecentRequests = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        fplQuickActions = New FlowLayoutPanel()
        lblQuickActions = New Label()
        fplQuickLinks = New FlowLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button6 = New Button()
        Button4 = New Button()
        fplRecentRequests = New FlowLayoutPanel()
        lblRecentRequests = New Label()
        fplStatus = New FlowLayoutPanel()
        Panel7 = New Panel()
        lblNumberPending = New Label()
        lblPending = New Label()
        Panel8 = New Panel()
        lblNumberProcessing = New Label()
        lblProcessing = New Label()
        Panel9 = New Panel()
        lblNumberReadyforRelease = New Label()
        lblReadyforRelease = New Label()
        Panel10 = New Panel()
        lblNumberReleased = New Label()
        lblReleased = New Label()
        Panel11 = New Panel()
        lblNumberCancelled = New Label()
        lblCancelled = New Label()
        fplRequestStatus = New FlowLayoutPanel()
        lblRequestStatus = New Label()
        fplTotals = New FlowLayoutPanel()
        Panel3 = New Panel()
        lblNumberTotalStudents = New Label()
        lblTotalStudent = New Label()
        Panel6 = New Panel()
        lblNumberTotalRequest = New Label()
        lblTotalRequest = New Label()
        Panel4 = New Panel()
        lblNumberRequestThisMonth = New Label()
        lblRequestThisMonth = New Label()
        Panel5 = New Panel()
        lblNumberPaymentsCollected = New Label()
        lblPaymentsCollected = New Label()
        fplOverall = New FlowLayoutPanel()
        lblOverall = New Label()
        pnlDashboard.SuspendLayout()
        fplListViewRecent.SuspendLayout()
        fplQuickActions.SuspendLayout()
        fplQuickLinks.SuspendLayout()
        fplRecentRequests.SuspendLayout()
        fplStatus.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        fplRequestStatus.SuspendLayout()
        fplTotals.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        fplOverall.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.Controls.Add(fplListViewRecent)
        pnlDashboard.Controls.Add(fplQuickActions)
        pnlDashboard.Controls.Add(fplQuickLinks)
        pnlDashboard.Controls.Add(fplRecentRequests)
        pnlDashboard.Controls.Add(fplStatus)
        pnlDashboard.Controls.Add(fplRequestStatus)
        pnlDashboard.Controls.Add(fplTotals)
        pnlDashboard.Controls.Add(fplOverall)
        pnlDashboard.Dock = DockStyle.Fill
        pnlDashboard.Location = New Point(0, 0)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(927, 622)
        pnlDashboard.TabIndex = 2
        ' 
        ' fplListViewRecent
        ' 
        fplListViewRecent.Controls.Add(lvRecentRequests)
        fplListViewRecent.Dock = DockStyle.Top
        fplListViewRecent.Location = New Point(0, 304)
        fplListViewRecent.Name = "fplListViewRecent"
        fplListViewRecent.Size = New Size(927, 168)
        fplListViewRecent.TabIndex = 27
        ' 
        ' lvRecentRequests
        ' 
        lvRecentRequests.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        lvRecentRequests.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lvRecentRequests.FullRowSelect = True
        lvRecentRequests.GridLines = True
        lvRecentRequests.Location = New Point(20, 5)
        lvRecentRequests.Margin = New Padding(20, 5, 3, 3)
        lvRecentRequests.Name = "lvRecentRequests"
        lvRecentRequests.Size = New Size(887, 160)
        lvRecentRequests.TabIndex = 0
        lvRecentRequests.UseCompatibleStateImageBehavior = False
        lvRecentRequests.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Request Number"
        ColumnHeader1.Width = 130
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Last Name"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 135
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "First Name"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 135
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Course"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 80
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Document Type"
        ColumnHeader5.TextAlign = HorizontalAlignment.Center
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Date of Request"
        ColumnHeader6.TextAlign = HorizontalAlignment.Center
        ColumnHeader6.Width = 150
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Status"
        ColumnHeader7.TextAlign = HorizontalAlignment.Center
        ColumnHeader7.Width = 96
        ' 
        ' fplQuickActions
        ' 
        fplQuickActions.Controls.Add(lblQuickActions)
        fplQuickActions.Dock = DockStyle.Bottom
        fplQuickActions.Location = New Point(0, 475)
        fplQuickActions.Name = "fplQuickActions"
        fplQuickActions.Size = New Size(927, 38)
        fplQuickActions.TabIndex = 26
        ' 
        ' lblQuickActions
        ' 
        lblQuickActions.AutoSize = True
        lblQuickActions.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuickActions.Location = New Point(20, 10)
        lblQuickActions.Margin = New Padding(20, 10, 3, 0)
        lblQuickActions.Name = "lblQuickActions"
        lblQuickActions.Size = New Size(138, 25)
        lblQuickActions.TabIndex = 4
        lblQuickActions.Text = "Quick Actions"
        ' 
        ' fplQuickLinks
        ' 
        fplQuickLinks.Controls.Add(Button1)
        fplQuickLinks.Controls.Add(Button2)
        fplQuickLinks.Controls.Add(Button5)
        fplQuickLinks.Controls.Add(Button3)
        fplQuickLinks.Controls.Add(Button6)
        fplQuickLinks.Controls.Add(Button4)
        fplQuickLinks.Dock = DockStyle.Bottom
        fplQuickLinks.Location = New Point(0, 513)
        fplQuickLinks.Name = "fplQuickLinks"
        fplQuickLinks.Size = New Size(927, 109)
        fplQuickLinks.TabIndex = 25
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(25, 3)
        Button1.Margin = New Padding(25, 3, 3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 90)
        Button1.TabIndex = 13
        Button1.Text = "Search Records"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(171, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 90)
        Button2.TabIndex = 14
        Button2.Text = "Create Request"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(317, 3)
        Button5.Name = "Button5"
        Button5.Size = New Size(140, 90)
        Button5.TabIndex = 17
        Button5.Text = "Payment Report"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(463, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(140, 90)
        Button3.TabIndex = 15
        Button3.Text = "Add Student"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(609, 3)
        Button6.Name = "Button6"
        Button6.Size = New Size(140, 90)
        Button6.TabIndex = 18
        Button6.Text = "Add Document"
        Button6.TextAlign = ContentAlignment.BottomCenter
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(755, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(140, 90)
        Button4.TabIndex = 16
        Button4.Text = "Requests by Date"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.UseVisualStyleBackColor = True
        ' 
        ' fplRecentRequests
        ' 
        fplRecentRequests.Controls.Add(lblRecentRequests)
        fplRecentRequests.Dock = DockStyle.Top
        fplRecentRequests.Location = New Point(0, 270)
        fplRecentRequests.Name = "fplRecentRequests"
        fplRecentRequests.Size = New Size(927, 34)
        fplRecentRequests.TabIndex = 24
        ' 
        ' lblRecentRequests
        ' 
        lblRecentRequests.AutoSize = True
        lblRecentRequests.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRecentRequests.Location = New Point(20, 5)
        lblRecentRequests.Margin = New Padding(20, 5, 3, 0)
        lblRecentRequests.Name = "lblRecentRequests"
        lblRecentRequests.Size = New Size(167, 25)
        lblRecentRequests.TabIndex = 3
        lblRecentRequests.Text = "Recent Requests"
        ' 
        ' fplStatus
        ' 
        fplStatus.Controls.Add(Panel7)
        fplStatus.Controls.Add(Panel8)
        fplStatus.Controls.Add(Panel9)
        fplStatus.Controls.Add(Panel10)
        fplStatus.Controls.Add(Panel11)
        fplStatus.Dock = DockStyle.Top
        fplStatus.Location = New Point(0, 174)
        fplStatus.Name = "fplStatus"
        fplStatus.Size = New Size(927, 96)
        fplStatus.TabIndex = 23
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(lblNumberPending)
        Panel7.Controls.Add(lblPending)
        Panel7.Location = New Point(20, 10)
        Panel7.Margin = New Padding(20, 10, 0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(154, 82)
        Panel7.TabIndex = 2
        ' 
        ' lblNumberPending
        ' 
        lblNumberPending.AutoSize = True
        lblNumberPending.Font = New Font("Tahoma", 15.75F)
        lblNumberPending.Location = New Point(12, 47)
        lblNumberPending.Name = "lblNumberPending"
        lblNumberPending.Size = New Size(34, 25)
        lblNumberPending.TabIndex = 10
        lblNumberPending.Text = "00"
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPending.Location = New Point(12, 13)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(75, 19)
        lblPending.TabIndex = 9
        lblPending.Text = "Pending"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(lblNumberProcessing)
        Panel8.Controls.Add(lblProcessing)
        Panel8.Location = New Point(189, 10)
        Panel8.Margin = New Padding(15, 10, 3, 3)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(154, 82)
        Panel8.TabIndex = 15
        ' 
        ' lblNumberProcessing
        ' 
        lblNumberProcessing.AutoSize = True
        lblNumberProcessing.Font = New Font("Tahoma", 15.75F)
        lblNumberProcessing.Location = New Point(12, 47)
        lblNumberProcessing.Name = "lblNumberProcessing"
        lblNumberProcessing.Size = New Size(34, 25)
        lblNumberProcessing.TabIndex = 11
        lblNumberProcessing.Text = "00"
        ' 
        ' lblProcessing
        ' 
        lblProcessing.AutoSize = True
        lblProcessing.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProcessing.Location = New Point(12, 13)
        lblProcessing.Name = "lblProcessing"
        lblProcessing.Size = New Size(96, 19)
        lblProcessing.TabIndex = 10
        lblProcessing.Text = "Processing"
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(lblNumberReadyforRelease)
        Panel9.Controls.Add(lblReadyforRelease)
        Panel9.Location = New Point(361, 10)
        Panel9.Margin = New Padding(15, 10, 3, 3)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(202, 82)
        Panel9.TabIndex = 16
        ' 
        ' lblNumberReadyforRelease
        ' 
        lblNumberReadyforRelease.AutoSize = True
        lblNumberReadyforRelease.Font = New Font("Tahoma", 15.75F)
        lblNumberReadyforRelease.Location = New Point(13, 47)
        lblNumberReadyforRelease.Name = "lblNumberReadyforRelease"
        lblNumberReadyforRelease.Size = New Size(34, 25)
        lblNumberReadyforRelease.TabIndex = 12
        lblNumberReadyforRelease.Text = "00"
        ' 
        ' lblReadyforRelease
        ' 
        lblReadyforRelease.AutoSize = True
        lblReadyforRelease.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReadyforRelease.Location = New Point(13, 13)
        lblReadyforRelease.Name = "lblReadyforRelease"
        lblReadyforRelease.Size = New Size(158, 19)
        lblReadyforRelease.TabIndex = 11
        lblReadyforRelease.Text = "Ready for Release"
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(lblNumberReleased)
        Panel10.Controls.Add(lblReleased)
        Panel10.Location = New Point(581, 10)
        Panel10.Margin = New Padding(15, 10, 3, 3)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(154, 82)
        Panel10.TabIndex = 17
        ' 
        ' lblNumberReleased
        ' 
        lblNumberReleased.AutoSize = True
        lblNumberReleased.Font = New Font("Tahoma", 15.75F)
        lblNumberReleased.Location = New Point(12, 47)
        lblNumberReleased.Name = "lblNumberReleased"
        lblNumberReleased.Size = New Size(34, 25)
        lblNumberReleased.TabIndex = 13
        lblNumberReleased.Text = "00"
        ' 
        ' lblReleased
        ' 
        lblReleased.AutoSize = True
        lblReleased.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReleased.Location = New Point(12, 13)
        lblReleased.Name = "lblReleased"
        lblReleased.Size = New Size(84, 19)
        lblReleased.TabIndex = 12
        lblReleased.Text = "Released"
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(lblNumberCancelled)
        Panel11.Controls.Add(lblCancelled)
        Panel11.Location = New Point(753, 10)
        Panel11.Margin = New Padding(15, 10, 3, 3)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(154, 82)
        Panel11.TabIndex = 18
        ' 
        ' lblNumberCancelled
        ' 
        lblNumberCancelled.AutoSize = True
        lblNumberCancelled.Font = New Font("Tahoma", 15.75F)
        lblNumberCancelled.Location = New Point(12, 47)
        lblNumberCancelled.Name = "lblNumberCancelled"
        lblNumberCancelled.Size = New Size(34, 25)
        lblNumberCancelled.TabIndex = 14
        lblNumberCancelled.Text = "00"
        ' 
        ' lblCancelled
        ' 
        lblCancelled.AutoSize = True
        lblCancelled.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCancelled.Location = New Point(12, 13)
        lblCancelled.Name = "lblCancelled"
        lblCancelled.Size = New Size(88, 19)
        lblCancelled.TabIndex = 13
        lblCancelled.Text = "Cancelled"
        ' 
        ' fplRequestStatus
        ' 
        fplRequestStatus.Controls.Add(lblRequestStatus)
        fplRequestStatus.Dock = DockStyle.Top
        fplRequestStatus.Location = New Point(0, 137)
        fplRequestStatus.Name = "fplRequestStatus"
        fplRequestStatus.Size = New Size(927, 37)
        fplRequestStatus.TabIndex = 22
        ' 
        ' lblRequestStatus
        ' 
        lblRequestStatus.AutoSize = True
        lblRequestStatus.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRequestStatus.Location = New Point(20, 5)
        lblRequestStatus.Margin = New Padding(20, 5, 3, 0)
        lblRequestStatus.Name = "lblRequestStatus"
        lblRequestStatus.Size = New Size(152, 25)
        lblRequestStatus.TabIndex = 2
        lblRequestStatus.Text = "Request Status"
        ' 
        ' fplTotals
        ' 
        fplTotals.Controls.Add(Panel3)
        fplTotals.Controls.Add(Panel6)
        fplTotals.Controls.Add(Panel4)
        fplTotals.Controls.Add(Panel5)
        fplTotals.Dock = DockStyle.Top
        fplTotals.Location = New Point(0, 35)
        fplTotals.Name = "fplTotals"
        fplTotals.Size = New Size(927, 102)
        fplTotals.TabIndex = 21
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblNumberTotalStudents)
        Panel3.Controls.Add(lblTotalStudent)
        Panel3.Location = New Point(15, 10)
        Panel3.Margin = New Padding(15, 10, 3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 87)
        Panel3.TabIndex = 0
        ' 
        ' lblNumberTotalStudents
        ' 
        lblNumberTotalStudents.AutoSize = True
        lblNumberTotalStudents.Font = New Font("Tahoma", 15.75F)
        lblNumberTotalStudents.Location = New Point(10, 48)
        lblNumberTotalStudents.Name = "lblNumberTotalStudents"
        lblNumberTotalStudents.Size = New Size(34, 25)
        lblNumberTotalStudents.TabIndex = 6
        lblNumberTotalStudents.Text = "00"
        ' 
        ' lblTotalStudent
        ' 
        lblTotalStudent.AutoSize = True
        lblTotalStudent.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalStudent.Location = New Point(12, 14)
        lblTotalStudent.Name = "lblTotalStudent"
        lblTotalStudent.Size = New Size(123, 23)
        lblTotalStudent.TabIndex = 5
        lblTotalStudent.Text = "Total Student"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(lblNumberTotalRequest)
        Panel6.Controls.Add(lblTotalRequest)
        Panel6.Location = New Point(228, 10)
        Panel6.Margin = New Padding(10, 10, 3, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(200, 87)
        Panel6.TabIndex = 14
        ' 
        ' lblNumberTotalRequest
        ' 
        lblNumberTotalRequest.AutoSize = True
        lblNumberTotalRequest.Font = New Font("Tahoma", 15.75F)
        lblNumberTotalRequest.Location = New Point(12, 48)
        lblNumberTotalRequest.Name = "lblNumberTotalRequest"
        lblNumberTotalRequest.Size = New Size(34, 25)
        lblNumberTotalRequest.TabIndex = 7
        lblNumberTotalRequest.Text = "00"
        ' 
        ' lblTotalRequest
        ' 
        lblTotalRequest.AutoSize = True
        lblTotalRequest.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalRequest.Location = New Point(12, 14)
        lblTotalRequest.Name = "lblTotalRequest"
        lblTotalRequest.Size = New Size(125, 23)
        lblTotalRequest.TabIndex = 6
        lblTotalRequest.Text = "Total Request"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(lblNumberRequestThisMonth)
        Panel4.Controls.Add(lblRequestThisMonth)
        Panel4.Location = New Point(441, 10)
        Panel4.Margin = New Padding(10, 10, 3, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(228, 87)
        Panel4.TabIndex = 1
        ' 
        ' lblNumberRequestThisMonth
        ' 
        lblNumberRequestThisMonth.AutoSize = True
        lblNumberRequestThisMonth.Font = New Font("Tahoma", 15.75F)
        lblNumberRequestThisMonth.Location = New Point(12, 48)
        lblNumberRequestThisMonth.Name = "lblNumberRequestThisMonth"
        lblNumberRequestThisMonth.Size = New Size(34, 25)
        lblNumberRequestThisMonth.TabIndex = 8
        lblNumberRequestThisMonth.Text = "00"
        ' 
        ' lblRequestThisMonth
        ' 
        lblRequestThisMonth.AutoSize = True
        lblRequestThisMonth.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRequestThisMonth.Location = New Point(12, 14)
        lblRequestThisMonth.Name = "lblRequestThisMonth"
        lblRequestThisMonth.Size = New Size(177, 23)
        lblRequestThisMonth.TabIndex = 7
        lblRequestThisMonth.Text = "Request This Month"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(lblNumberPaymentsCollected)
        Panel5.Controls.Add(lblPaymentsCollected)
        Panel5.Location = New Point(682, 10)
        Panel5.Margin = New Padding(10, 10, 3, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(228, 87)
        Panel5.TabIndex = 2
        ' 
        ' lblNumberPaymentsCollected
        ' 
        lblNumberPaymentsCollected.AutoSize = True
        lblNumberPaymentsCollected.Font = New Font("Tahoma", 15.75F)
        lblNumberPaymentsCollected.Location = New Point(12, 48)
        lblNumberPaymentsCollected.Name = "lblNumberPaymentsCollected"
        lblNumberPaymentsCollected.Size = New Size(34, 25)
        lblNumberPaymentsCollected.TabIndex = 9
        lblNumberPaymentsCollected.Text = "00"
        ' 
        ' lblPaymentsCollected
        ' 
        lblPaymentsCollected.AutoSize = True
        lblPaymentsCollected.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaymentsCollected.Location = New Point(12, 14)
        lblPaymentsCollected.Name = "lblPaymentsCollected"
        lblPaymentsCollected.Size = New Size(171, 23)
        lblPaymentsCollected.TabIndex = 8
        lblPaymentsCollected.Text = "Payments Collected"
        ' 
        ' fplOverall
        ' 
        fplOverall.Controls.Add(lblOverall)
        fplOverall.Dock = DockStyle.Top
        fplOverall.Location = New Point(0, 0)
        fplOverall.Name = "fplOverall"
        fplOverall.Size = New Size(927, 35)
        fplOverall.TabIndex = 20
        ' 
        ' lblOverall
        ' 
        lblOverall.AutoSize = True
        lblOverall.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOverall.Location = New Point(20, 5)
        lblOverall.Margin = New Padding(20, 5, 3, 0)
        lblOverall.Name = "lblOverall"
        lblOverall.Size = New Size(77, 25)
        lblOverall.TabIndex = 1
        lblOverall.Text = "Overall"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(pnlDashboard)
        MinimumSize = New Size(943, 661)
        Name = "frmDashboard"
        Text = "frmDashboard"
        pnlDashboard.ResumeLayout(False)
        fplListViewRecent.ResumeLayout(False)
        fplQuickActions.ResumeLayout(False)
        fplQuickActions.PerformLayout()
        fplQuickLinks.ResumeLayout(False)
        fplRecentRequests.ResumeLayout(False)
        fplRecentRequests.PerformLayout()
        fplStatus.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        fplRequestStatus.ResumeLayout(False)
        fplRequestStatus.PerformLayout()
        fplTotals.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        fplOverall.ResumeLayout(False)
        fplOverall.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents fplListViewRecent As FlowLayoutPanel
    Friend WithEvents lvRecentRequests As ListView
    Friend WithEvents fplQuickActions As FlowLayoutPanel
    Friend WithEvents lblQuickActions As Label
    Friend WithEvents fplQuickLinks As FlowLayoutPanel
    Friend WithEvents fplRecentRequests As FlowLayoutPanel
    Friend WithEvents lblRecentRequests As Label
    Friend WithEvents fplStatus As FlowLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblNumberPending As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblNumberProcessing As Label
    Friend WithEvents lblProcessing As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblNumberReadyforRelease As Label
    Friend WithEvents lblReadyforRelease As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblNumberReleased As Label
    Friend WithEvents lblReleased As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblNumberCancelled As Label
    Friend WithEvents lblCancelled As Label
    Friend WithEvents fplRequestStatus As FlowLayoutPanel
    Friend WithEvents lblRequestStatus As Label
    Friend WithEvents fplTotals As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNumberTotalStudents As Label
    Friend WithEvents lblTotalStudent As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblNumberTotalRequest As Label
    Friend WithEvents lblTotalRequest As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblNumberRequestThisMonth As Label
    Friend WithEvents lblRequestThisMonth As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblNumberPaymentsCollected As Label
    Friend WithEvents lblPaymentsCollected As Label
    Friend WithEvents fplOverall As FlowLayoutPanel
    Friend WithEvents lblOverall As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
