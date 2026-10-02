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
        btnSearchRecords = New Button()
        btnCreateRequest = New Button()
        btnPaymentReport = New Button()
        btnAddStudent = New Button()
        btnAddDocument = New Button()
        fplRecentRequests = New FlowLayoutPanel()
        lblRecentRequests = New Label()
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
        tlpQuickAction = New TableLayoutPanel()
        tlpDashboard = New TableLayoutPanel()
        tplRequestStatus = New TableLayoutPanel()
        tlpOverall = New TableLayoutPanel()
        fplQuickActions.SuspendLayout()
        fplRecentRequests.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        fplRequestStatus.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        fplOverall.SuspendLayout()
        tlpQuickAction.SuspendLayout()
        tlpDashboard.SuspendLayout()
        tplRequestStatus.SuspendLayout()
        tlpOverall.SuspendLayout()
        SuspendLayout()
        ' 
        ' lvRecentRequests
        ' 
        lvRecentRequests.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        lvRecentRequests.Dock = DockStyle.Fill
        lvRecentRequests.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lvRecentRequests.FullRowSelect = True
        lvRecentRequests.GridLines = True
        lvRecentRequests.Location = New Point(20, 325)
        lvRecentRequests.Margin = New Padding(20, 8, 20, 8)
        lvRecentRequests.Name = "lvRecentRequests"
        lvRecentRequests.Size = New Size(887, 123)
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
        ColumnHeader2.Width = 120
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "First Name"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 120
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Course"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 70
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
        fplQuickActions.Location = New Point(3, 459)
        fplQuickActions.Name = "fplQuickActions"
        fplQuickActions.Size = New Size(921, 43)
        fplQuickActions.TabIndex = 26
        ' 
        ' lblQuickActions
        ' 
        lblQuickActions.AutoSize = True
        lblQuickActions.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuickActions.Location = New Point(20, 15)
        lblQuickActions.Margin = New Padding(20, 15, 3, 0)
        lblQuickActions.Name = "lblQuickActions"
        lblQuickActions.Size = New Size(138, 25)
        lblQuickActions.TabIndex = 4
        lblQuickActions.Text = "Quick Actions"
        ' 
        ' btnSearchRecords
        ' 
        btnSearchRecords.Dock = DockStyle.Fill
        btnSearchRecords.Location = New Point(10, 5)
        btnSearchRecords.Margin = New Padding(10, 5, 10, 15)
        btnSearchRecords.Name = "btnSearchRecords"
        btnSearchRecords.Size = New Size(164, 91)
        btnSearchRecords.TabIndex = 13
        btnSearchRecords.Text = "Search Records"
        btnSearchRecords.TextAlign = ContentAlignment.BottomCenter
        btnSearchRecords.UseVisualStyleBackColor = True
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.Dock = DockStyle.Fill
        btnCreateRequest.Location = New Point(194, 5)
        btnCreateRequest.Margin = New Padding(10, 5, 10, 15)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Size = New Size(164, 91)
        btnCreateRequest.TabIndex = 14
        btnCreateRequest.Text = "Create Request"
        btnCreateRequest.TextAlign = ContentAlignment.BottomCenter
        btnCreateRequest.UseVisualStyleBackColor = True
        ' 
        ' btnPaymentReport
        ' 
        btnPaymentReport.Dock = DockStyle.Fill
        btnPaymentReport.Location = New Point(378, 5)
        btnPaymentReport.Margin = New Padding(10, 5, 10, 15)
        btnPaymentReport.Name = "btnPaymentReport"
        btnPaymentReport.Size = New Size(164, 91)
        btnPaymentReport.TabIndex = 17
        btnPaymentReport.Text = "Payment Report"
        btnPaymentReport.TextAlign = ContentAlignment.BottomCenter
        btnPaymentReport.UseVisualStyleBackColor = True
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Dock = DockStyle.Fill
        btnAddStudent.Location = New Point(562, 5)
        btnAddStudent.Margin = New Padding(10, 5, 10, 15)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(164, 91)
        btnAddStudent.TabIndex = 15
        btnAddStudent.Text = "Add Student"
        btnAddStudent.TextAlign = ContentAlignment.BottomCenter
        btnAddStudent.UseVisualStyleBackColor = True
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.Dock = DockStyle.Fill
        btnAddDocument.Location = New Point(746, 5)
        btnAddDocument.Margin = New Padding(10, 5, 10, 15)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(165, 91)
        btnAddDocument.TabIndex = 18
        btnAddDocument.Text = "Add Document"
        btnAddDocument.TextAlign = ContentAlignment.BottomCenter
        btnAddDocument.UseVisualStyleBackColor = True
        ' 
        ' fplRecentRequests
        ' 
        fplRecentRequests.Controls.Add(lblRecentRequests)
        fplRecentRequests.Dock = DockStyle.Bottom
        fplRecentRequests.Location = New Point(3, 280)
        fplRecentRequests.Name = "fplRecentRequests"
        fplRecentRequests.Size = New Size(921, 34)
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
        ' Panel7
        ' 
        Panel7.Controls.Add(lblNumberPending)
        Panel7.Controls.Add(lblPending)
        Panel7.Location = New Point(15, 5)
        Panel7.Margin = New Padding(15, 5, 0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(148, 82)
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
        Panel8.Location = New Point(194, 5)
        Panel8.Margin = New Padding(10, 5, 3, 3)
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
        Panel9.Location = New Point(374, 5)
        Panel9.Margin = New Padding(6, 5, 3, 3)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(175, 82)
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
        Panel10.Location = New Point(562, 5)
        Panel10.Margin = New Padding(10, 5, 3, 3)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(162, 82)
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
        Panel11.Location = New Point(746, 5)
        Panel11.Margin = New Padding(10, 5, 3, 3)
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
        fplRequestStatus.Dock = DockStyle.Bottom
        fplRequestStatus.Location = New Point(3, 139)
        fplRequestStatus.Name = "fplRequestStatus"
        fplRequestStatus.Size = New Size(921, 34)
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
        ' Panel3
        ' 
        Panel3.Controls.Add(lblNumberTotalStudents)
        Panel3.Controls.Add(lblTotalStudent)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(15, 5)
        Panel3.Margin = New Padding(15, 5, 15, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 82)
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
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(245, 5)
        Panel6.Margin = New Padding(15, 5, 15, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(200, 82)
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
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(475, 5)
        Panel4.Margin = New Padding(15, 5, 15, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 82)
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
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(705, 5)
        Panel5.Margin = New Padding(15, 5, 15, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(201, 82)
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
        fplOverall.Dock = DockStyle.Bottom
        fplOverall.Location = New Point(3, 3)
        fplOverall.Name = "fplOverall"
        fplOverall.Size = New Size(921, 32)
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
        ' tlpQuickAction
        ' 
        tlpQuickAction.ColumnCount = 5
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tlpQuickAction.Controls.Add(btnAddDocument, 4, 0)
        tlpQuickAction.Controls.Add(btnAddStudent, 3, 0)
        tlpQuickAction.Controls.Add(btnPaymentReport, 2, 0)
        tlpQuickAction.Controls.Add(btnSearchRecords, 0, 0)
        tlpQuickAction.Controls.Add(btnCreateRequest, 1, 0)
        tlpQuickAction.Dock = DockStyle.Fill
        tlpQuickAction.Location = New Point(3, 508)
        tlpQuickAction.Name = "tlpQuickAction"
        tlpQuickAction.RowCount = 1
        tlpQuickAction.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpQuickAction.Size = New Size(921, 111)
        tlpQuickAction.TabIndex = 28
        ' 
        ' tlpDashboard
        ' 
        tlpDashboard.ColumnCount = 1
        tlpDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        tlpDashboard.Controls.Add(lvRecentRequests, 0, 5)
        tlpDashboard.Controls.Add(tlpQuickAction, 0, 7)
        tlpDashboard.Controls.Add(tplRequestStatus, 0, 3)
        tlpDashboard.Controls.Add(fplQuickActions, 0, 6)
        tlpDashboard.Controls.Add(fplOverall, 0, 0)
        tlpDashboard.Controls.Add(tlpOverall, 0, 1)
        tlpDashboard.Controls.Add(fplRequestStatus, 0, 2)
        tlpDashboard.Controls.Add(fplRecentRequests, 0, 4)
        tlpDashboard.Dock = DockStyle.Fill
        tlpDashboard.Location = New Point(0, 0)
        tlpDashboard.Name = "tlpDashboard"
        tlpDashboard.RowCount = 8
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 6.109325F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 15.4340839F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 6.75241137F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 16.0771713F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 6.59164F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 22.3472672F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 7.87781334F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 18.167202F))
        tlpDashboard.Size = New Size(927, 622)
        tlpDashboard.TabIndex = 29
        ' 
        ' tplRequestStatus
        ' 
        tplRequestStatus.ColumnCount = 5
        tplRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tplRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tplRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tplRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tplRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tplRequestStatus.Controls.Add(Panel11, 4, 0)
        tplRequestStatus.Controls.Add(Panel10, 3, 0)
        tplRequestStatus.Controls.Add(Panel9, 2, 0)
        tplRequestStatus.Controls.Add(Panel8, 1, 0)
        tplRequestStatus.Controls.Add(Panel7, 0, 0)
        tplRequestStatus.Dock = DockStyle.Fill
        tplRequestStatus.Location = New Point(3, 179)
        tplRequestStatus.Name = "tplRequestStatus"
        tplRequestStatus.RowCount = 1
        tplRequestStatus.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tplRequestStatus.Size = New Size(921, 94)
        tplRequestStatus.TabIndex = 31
        ' 
        ' tlpOverall
        ' 
        tlpOverall.ColumnCount = 4
        tlpOverall.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpOverall.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpOverall.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpOverall.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tlpOverall.Controls.Add(Panel5, 3, 0)
        tlpOverall.Controls.Add(Panel4, 2, 0)
        tlpOverall.Controls.Add(Panel6, 1, 0)
        tlpOverall.Controls.Add(Panel3, 0, 0)
        tlpOverall.Dock = DockStyle.Fill
        tlpOverall.Location = New Point(3, 41)
        tlpOverall.Name = "tlpOverall"
        tlpOverall.RowCount = 1
        tlpOverall.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpOverall.Size = New Size(921, 90)
        tlpOverall.TabIndex = 30
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 622)
        Controls.Add(tlpDashboard)
        MinimumSize = New Size(943, 661)
        Name = "frmDashboard"
        Text = "frmDashboard"
        fplQuickActions.ResumeLayout(False)
        fplQuickActions.PerformLayout()
        fplRecentRequests.ResumeLayout(False)
        fplRecentRequests.PerformLayout()
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
        tlpQuickAction.ResumeLayout(False)
        tlpDashboard.ResumeLayout(False)
        tplRequestStatus.ResumeLayout(False)
        tlpOverall.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents lvRecentRequests As ListView
    Friend WithEvents fplQuickActions As FlowLayoutPanel
    Friend WithEvents lblQuickActions As Label
    Friend WithEvents fplRecentRequests As FlowLayoutPanel
    Friend WithEvents lblRecentRequests As Label
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNumberTotalStudents As Label
    Friend WithEvents lblTotalStudent As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblNumberTotalRequest As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblNumberRequestThisMonth As Label
    Friend WithEvents lblRequestThisMonth As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblNumberPaymentsCollected As Label
    Friend WithEvents lblPaymentsCollected As Label
    Friend WithEvents fplOverall As FlowLayoutPanel
    Friend WithEvents lblOverall As Label
    Friend WithEvents btnSearchRecords As Button
    Friend WithEvents btnCreateRequest As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnPaymentReport As Button
    Friend WithEvents btnAddDocument As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents tlpQuickAction As TableLayoutPanel
    Friend WithEvents tlpDashboard As TableLayoutPanel
    Friend WithEvents tlpOverall As TableLayoutPanel
    Friend WithEvents tplRequestStatus As TableLayoutPanel
    Friend WithEvents lblTotalRequest As Label
End Class
