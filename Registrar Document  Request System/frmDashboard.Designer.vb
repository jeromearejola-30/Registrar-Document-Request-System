<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tlpDashboard = New TableLayoutPanel()
        lblOverall = New Label()
        tlpOverall = New TableLayoutPanel()
        cardTotalStudents = New StatCard()
        cardTotalRequests = New StatCard()
        cardRequestsThisMonth = New StatCard()
        cardPaymentsCollected = New StatCard()
        lblRequestStatus = New Label()
        tlpRequestStatus = New TableLayoutPanel()
        cardPending = New StatCard()
        cardProcessing = New StatCard()
        cardReadyForRelease = New StatCard()
        cardReleased = New StatCard()
        cardCancelled = New StatCard()
        tlpRecentHeader = New TableLayoutPanel()
        lblRecentRequests = New Label()
        cboFilterRecentRequests = New ComboBox()
        pnlRecentBorder = New Panel()
        lvRecentRequests = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        lblQuickActions = New Label()
        tlpQuickAction = New TableLayoutPanel()
        btnSearchRecords = New TileButton()
        btnCreateRequest = New TileButton()
        btnPaymentReport = New TileButton()
        btnAddStudent = New TileButton()
        btnAddDocument = New TileButton()
        tlpDashboard.SuspendLayout()
        tlpOverall.SuspendLayout()
        tlpRequestStatus.SuspendLayout()
        tlpRecentHeader.SuspendLayout()
        pnlRecentBorder.SuspendLayout()
        tlpQuickAction.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlpDashboard
        ' 
        tlpDashboard.ColumnCount = 1
        tlpDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlpDashboard.Controls.Add(lblOverall, 0, 0)
        tlpDashboard.Controls.Add(tlpOverall, 0, 1)
        tlpDashboard.Controls.Add(lblRequestStatus, 0, 2)
        tlpDashboard.Controls.Add(tlpRequestStatus, 0, 3)
        tlpDashboard.Controls.Add(tlpRecentHeader, 0, 4)
        tlpDashboard.Controls.Add(pnlRecentBorder, 0, 5)
        tlpDashboard.Controls.Add(lblQuickActions, 0, 6)
        tlpDashboard.Controls.Add(tlpQuickAction, 0, 7)
        tlpDashboard.Dock = DockStyle.Fill
        tlpDashboard.Location = New Point(0, 0)
        tlpDashboard.Name = "tlpDashboard"
        tlpDashboard.Padding = New Padding(28, 20, 28, 24)
        tlpDashboard.RowCount = 8
        tlpDashboard.RowStyles.Add(New RowStyle())
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Absolute, 92.0F))
        tlpDashboard.RowStyles.Add(New RowStyle())
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Absolute, 92.0F))
        tlpDashboard.RowStyles.Add(New RowStyle())
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpDashboard.RowStyles.Add(New RowStyle())
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Absolute, 92.0F))
        tlpDashboard.Size = New Size(1020, 700)
        tlpDashboard.TabIndex = 0
        ' 
        ' lblOverall
        ' 
        lblOverall.AutoSize = True
        lblOverall.Font = New Font("Segoe UI Semibold", 12.0F)
        lblOverall.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblOverall.Location = New Point(28, 20)
        lblOverall.Margin = New Padding(0, 0, 0, 8)
        lblOverall.Name = "lblOverall"
        lblOverall.Size = New Size(61, 21)
        lblOverall.TabIndex = 1
        lblOverall.Text = "Overall"
        ' 
        ' tlpOverall
        ' 
        tlpOverall.ColumnCount = 4
        tlpOverall.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tlpOverall.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tlpOverall.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tlpOverall.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        tlpOverall.Controls.Add(cardTotalStudents, 0, 0)
        tlpOverall.Controls.Add(cardTotalRequests, 1, 0)
        tlpOverall.Controls.Add(cardRequestsThisMonth, 2, 0)
        tlpOverall.Controls.Add(cardPaymentsCollected, 3, 0)
        tlpOverall.Dock = DockStyle.Fill
        tlpOverall.Location = New Point(28, 49)
        tlpOverall.Margin = New Padding(0)
        tlpOverall.Name = "tlpOverall"
        tlpOverall.RowCount = 1
        tlpOverall.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpOverall.Size = New Size(964, 92)
        tlpOverall.TabIndex = 2
        ' 
        ' cardTotalStudents
        ' 
        cardTotalStudents.AccentColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        cardTotalStudents.Dock = DockStyle.Fill
        cardTotalStudents.Location = New Point(0, 0)
        cardTotalStudents.Margin = New Padding(0, 0, 16, 0)
        cardTotalStudents.Name = "cardTotalStudents"
        cardTotalStudents.Size = New Size(225, 92)
        cardTotalStudents.TabIndex = 0
        cardTotalStudents.Title = "Total Students"
        ' 
        ' cardTotalRequests
        ' 
        cardTotalRequests.AccentColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        cardTotalRequests.Dock = DockStyle.Fill
        cardTotalRequests.Location = New Point(241, 0)
        cardTotalRequests.Margin = New Padding(0, 0, 16, 0)
        cardTotalRequests.Name = "cardTotalRequests"
        cardTotalRequests.Size = New Size(225, 92)
        cardTotalRequests.TabIndex = 1
        cardTotalRequests.Title = "Total Requests"
        ' 
        ' cardRequestsThisMonth
        ' 
        cardRequestsThisMonth.AccentColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        cardRequestsThisMonth.Dock = DockStyle.Fill
        cardRequestsThisMonth.Location = New Point(482, 0)
        cardRequestsThisMonth.Margin = New Padding(0, 0, 16, 0)
        cardRequestsThisMonth.Name = "cardRequestsThisMonth"
        cardRequestsThisMonth.Size = New Size(225, 92)
        cardRequestsThisMonth.TabIndex = 2
        cardRequestsThisMonth.Title = "Requests This Month"
        ' 
        ' cardPaymentsCollected
        ' 
        cardPaymentsCollected.AccentColor = Color.FromArgb(CByte(242), CByte(184), CByte(7))
        cardPaymentsCollected.Dock = DockStyle.Fill
        cardPaymentsCollected.Location = New Point(723, 0)
        cardPaymentsCollected.Margin = New Padding(0)
        cardPaymentsCollected.Name = "cardPaymentsCollected"
        cardPaymentsCollected.Size = New Size(241, 92)
        cardPaymentsCollected.TabIndex = 3
        cardPaymentsCollected.Title = "Payments Collected"
        ' 
        ' lblRequestStatus
        ' 
        lblRequestStatus.AutoSize = True
        lblRequestStatus.Font = New Font("Segoe UI Semibold", 12.0F)
        lblRequestStatus.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblRequestStatus.Location = New Point(28, 159)
        lblRequestStatus.Margin = New Padding(0, 18, 0, 8)
        lblRequestStatus.Name = "lblRequestStatus"
        lblRequestStatus.Size = New Size(119, 21)
        lblRequestStatus.TabIndex = 3
        lblRequestStatus.Text = "Request Status"
        ' 
        ' tlpRequestStatus
        ' 
        tlpRequestStatus.ColumnCount = 5
        tlpRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpRequestStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpRequestStatus.Controls.Add(cardPending, 0, 0)
        tlpRequestStatus.Controls.Add(cardProcessing, 1, 0)
        tlpRequestStatus.Controls.Add(cardReadyForRelease, 2, 0)
        tlpRequestStatus.Controls.Add(cardReleased, 3, 0)
        tlpRequestStatus.Controls.Add(cardCancelled, 4, 0)
        tlpRequestStatus.Dock = DockStyle.Fill
        tlpRequestStatus.Location = New Point(28, 188)
        tlpRequestStatus.Margin = New Padding(0)
        tlpRequestStatus.Name = "tlpRequestStatus"
        tlpRequestStatus.RowCount = 1
        tlpRequestStatus.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpRequestStatus.Size = New Size(964, 92)
        tlpRequestStatus.TabIndex = 4
        ' 
        ' cardPending
        ' 
        cardPending.AccentColor = Color.FromArgb(CByte(245), CByte(158), CByte(11))
        cardPending.Dock = DockStyle.Fill
        cardPending.Location = New Point(0, 0)
        cardPending.Margin = New Padding(0, 0, 16, 0)
        cardPending.Name = "cardPending"
        cardPending.Size = New Size(176, 92)
        cardPending.TabIndex = 0
        cardPending.Title = "Pending"
        ' 
        ' cardProcessing
        ' 
        cardProcessing.AccentColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        cardProcessing.Dock = DockStyle.Fill
        cardProcessing.Location = New Point(192, 0)
        cardProcessing.Margin = New Padding(0, 0, 16, 0)
        cardProcessing.Name = "cardProcessing"
        cardProcessing.Size = New Size(176, 92)
        cardProcessing.TabIndex = 1
        cardProcessing.Title = "Processing"
        ' 
        ' cardReadyForRelease
        ' 
        cardReadyForRelease.AccentColor = Color.FromArgb(CByte(13), CByte(148), CByte(136))
        cardReadyForRelease.Dock = DockStyle.Fill
        cardReadyForRelease.Location = New Point(384, 0)
        cardReadyForRelease.Margin = New Padding(0, 0, 16, 0)
        cardReadyForRelease.Name = "cardReadyForRelease"
        cardReadyForRelease.Size = New Size(176, 92)
        cardReadyForRelease.TabIndex = 2
        cardReadyForRelease.Title = "Ready for Release"
        ' 
        ' cardReleased
        ' 
        cardReleased.AccentColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        cardReleased.Dock = DockStyle.Fill
        cardReleased.Location = New Point(576, 0)
        cardReleased.Margin = New Padding(0, 0, 16, 0)
        cardReleased.Name = "cardReleased"
        cardReleased.Size = New Size(176, 92)
        cardReleased.TabIndex = 3
        cardReleased.Title = "Released"
        ' 
        ' cardCancelled
        ' 
        cardCancelled.AccentColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        cardCancelled.Dock = DockStyle.Fill
        cardCancelled.Location = New Point(768, 0)
        cardCancelled.Margin = New Padding(0)
        cardCancelled.Name = "cardCancelled"
        cardCancelled.Size = New Size(196, 92)
        cardCancelled.TabIndex = 4
        cardCancelled.Title = "Cancelled"
        ' 
        ' tlpRecentHeader
        ' 
        tlpRecentHeader.ColumnCount = 2
        tlpRecentHeader.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlpRecentHeader.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 240.0F))
        tlpRecentHeader.Controls.Add(lblRecentRequests, 0, 0)
        tlpRecentHeader.Controls.Add(cboFilterRecentRequests, 1, 0)
        tlpRecentHeader.Dock = DockStyle.Fill
        tlpRecentHeader.Location = New Point(28, 288)
        tlpRecentHeader.Margin = New Padding(0, 8, 0, 0)
        tlpRecentHeader.Name = "tlpRecentHeader"
        tlpRecentHeader.RowCount = 1
        tlpRecentHeader.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpRecentHeader.Size = New Size(964, 30)
        tlpRecentHeader.TabIndex = 5
        ' 
        ' lblRecentRequests
        ' 
        lblRecentRequests.AutoSize = True
        lblRecentRequests.Font = New Font("Segoe UI Semibold", 12.0F)
        lblRecentRequests.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblRecentRequests.Location = New Point(0, 0)
        lblRecentRequests.Margin = New Padding(0, 0, 0, 4)
        lblRecentRequests.Name = "lblRecentRequests"
        lblRecentRequests.Size = New Size(132, 21)
        lblRecentRequests.TabIndex = 0
        lblRecentRequests.Text = "Recent Requests"
        ' 
        ' cboFilterRecentRequests
        ' 
        cboFilterRecentRequests.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboFilterRecentRequests.DropDownStyle = ComboBoxStyle.DropDownList
        cboFilterRecentRequests.FormattingEnabled = True
        cboFilterRecentRequests.Location = New Point(744, 0)
        cboFilterRecentRequests.Margin = New Padding(0, 0, 0, 4)
        cboFilterRecentRequests.Name = "cboFilterRecentRequests"
        cboFilterRecentRequests.Size = New Size(220, 23)
        cboFilterRecentRequests.TabIndex = 1
        ' 
        ' pnlRecentBorder
        ' 
        pnlRecentBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlRecentBorder.Controls.Add(lvRecentRequests)
        pnlRecentBorder.Dock = DockStyle.Fill
        pnlRecentBorder.Location = New Point(28, 318)
        pnlRecentBorder.Margin = New Padding(0)
        pnlRecentBorder.Name = "pnlRecentBorder"
        pnlRecentBorder.Padding = New Padding(1)
        pnlRecentBorder.Size = New Size(964, 219)
        pnlRecentBorder.TabIndex = 6
        ' 
        ' lvRecentRequests
        ' 
        lvRecentRequests.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        lvRecentRequests.Dock = DockStyle.Fill
        lvRecentRequests.Location = New Point(1, 1)
        lvRecentRequests.Name = "lvRecentRequests"
        lvRecentRequests.Size = New Size(962, 217)
        lvRecentRequests.TabIndex = 0
        lvRecentRequests.UseCompatibleStateImageBehavior = False
        lvRecentRequests.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Request Number"
        ColumnHeader1.Width = 120
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Last Name"
        ColumnHeader2.Width = 120
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "First Name"
        ColumnHeader3.Width = 120
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Course"
        ColumnHeader4.Width = 120
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Document Type"
        ColumnHeader5.Width = 120
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Date of Request"
        ColumnHeader6.Width = 120
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Status"
        ColumnHeader7.Width = 120
        ' 
        ' lblQuickActions
        ' 
        lblQuickActions.AutoSize = True
        lblQuickActions.Font = New Font("Segoe UI Semibold", 12.0F)
        lblQuickActions.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblQuickActions.Location = New Point(28, 555)
        lblQuickActions.Margin = New Padding(0, 18, 0, 8)
        lblQuickActions.Name = "lblQuickActions"
        lblQuickActions.Size = New Size(110, 21)
        lblQuickActions.TabIndex = 7
        lblQuickActions.Text = "Quick Actions"
        ' 
        ' tlpQuickAction
        ' 
        tlpQuickAction.ColumnCount = 5
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpQuickAction.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tlpQuickAction.Controls.Add(btnSearchRecords, 0, 0)
        tlpQuickAction.Controls.Add(btnCreateRequest, 1, 0)
        tlpQuickAction.Controls.Add(btnPaymentReport, 2, 0)
        tlpQuickAction.Controls.Add(btnAddStudent, 3, 0)
        tlpQuickAction.Controls.Add(btnAddDocument, 4, 0)
        tlpQuickAction.Dock = DockStyle.Fill
        tlpQuickAction.Location = New Point(28, 584)
        tlpQuickAction.Margin = New Padding(0)
        tlpQuickAction.Name = "tlpQuickAction"
        tlpQuickAction.RowCount = 1
        tlpQuickAction.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpQuickAction.Size = New Size(964, 92)
        tlpQuickAction.TabIndex = 8
        ' 
        ' btnSearchRecords
        ' 
        btnSearchRecords.Dock = DockStyle.Fill
        btnSearchRecords.FlatStyle = FlatStyle.Flat
        btnSearchRecords.Glyph = ""
        btnSearchRecords.Location = New Point(0, 0)
        btnSearchRecords.Margin = New Padding(0, 0, 16, 0)
        btnSearchRecords.Name = "btnSearchRecords"
        btnSearchRecords.Size = New Size(176, 92)
        btnSearchRecords.TabIndex = 0
        btnSearchRecords.Text = "Search Records"
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.Dock = DockStyle.Fill
        btnCreateRequest.FlatStyle = FlatStyle.Flat
        btnCreateRequest.Glyph = ""
        btnCreateRequest.Location = New Point(192, 0)
        btnCreateRequest.Margin = New Padding(0, 0, 16, 0)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Size = New Size(176, 92)
        btnCreateRequest.TabIndex = 1
        btnCreateRequest.Text = "Create Request"
        ' 
        ' btnPaymentReport
        ' 
        btnPaymentReport.Dock = DockStyle.Fill
        btnPaymentReport.FlatStyle = FlatStyle.Flat
        btnPaymentReport.Glyph = ""
        btnPaymentReport.Location = New Point(384, 0)
        btnPaymentReport.Margin = New Padding(0, 0, 16, 0)
        btnPaymentReport.Name = "btnPaymentReport"
        btnPaymentReport.Size = New Size(176, 92)
        btnPaymentReport.TabIndex = 2
        btnPaymentReport.Text = "Payment Report"
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Dock = DockStyle.Fill
        btnAddStudent.FlatStyle = FlatStyle.Flat
        btnAddStudent.Glyph = ""
        btnAddStudent.Location = New Point(576, 0)
        btnAddStudent.Margin = New Padding(0, 0, 16, 0)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(176, 92)
        btnAddStudent.TabIndex = 3
        btnAddStudent.Text = "Add Student"
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.Dock = DockStyle.Fill
        btnAddDocument.FlatStyle = FlatStyle.Flat
        btnAddDocument.Glyph = ""
        btnAddDocument.Location = New Point(768, 0)
        btnAddDocument.Margin = New Padding(0)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(196, 92)
        btnAddDocument.TabIndex = 4
        btnAddDocument.Text = "Add Document"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(860, 700)
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 700)
        Controls.Add(tlpDashboard)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDashboard"
        Text = "Dashboard"
        tlpDashboard.ResumeLayout(False)
        tlpDashboard.PerformLayout()
        tlpOverall.ResumeLayout(False)
        tlpRequestStatus.ResumeLayout(False)
        tlpRecentHeader.ResumeLayout(False)
        tlpRecentHeader.PerformLayout()
        pnlRecentBorder.ResumeLayout(False)
        tlpQuickAction.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpDashboard As TableLayoutPanel
    Friend WithEvents lblOverall As Label
    Friend WithEvents tlpOverall As TableLayoutPanel
    Friend WithEvents cardTotalStudents As StatCard
    Friend WithEvents cardTotalRequests As StatCard
    Friend WithEvents cardRequestsThisMonth As StatCard
    Friend WithEvents cardPaymentsCollected As StatCard
    Friend WithEvents lblRequestStatus As Label
    Friend WithEvents tlpRequestStatus As TableLayoutPanel
    Friend WithEvents cardPending As StatCard
    Friend WithEvents cardProcessing As StatCard
    Friend WithEvents cardReadyForRelease As StatCard
    Friend WithEvents cardReleased As StatCard
    Friend WithEvents cardCancelled As StatCard
    Friend WithEvents lblRecentRequests As Label
    Friend WithEvents tlpRecentHeader As TableLayoutPanel
    Friend WithEvents cboFilterRecentRequests As ComboBox
    Friend WithEvents pnlRecentBorder As Panel
    Friend WithEvents lvRecentRequests As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents lblQuickActions As Label
    Friend WithEvents tlpQuickAction As TableLayoutPanel
    Friend WithEvents btnSearchRecords As TileButton
    Friend WithEvents btnCreateRequest As TileButton
    Friend WithEvents btnPaymentReport As TileButton
    Friend WithEvents btnAddStudent As TileButton
    Friend WithEvents btnAddDocument As TileButton
End Class
