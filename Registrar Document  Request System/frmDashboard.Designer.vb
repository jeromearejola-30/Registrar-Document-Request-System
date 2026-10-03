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
        lblRecentRequests = New Label()
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
        pnlRecentBorder.SuspendLayout()
        tlpQuickAction.SuspendLayout()
        SuspendLayout()
        '
        ' tlpDashboard  (one column; rows = section label / content, alternating)
        '
        tlpDashboard.ColumnCount = 1
        tlpDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlpDashboard.Controls.Add(lblOverall, 0, 0)
        tlpDashboard.Controls.Add(tlpOverall, 0, 1)
        tlpDashboard.Controls.Add(lblRequestStatus, 0, 2)
        tlpDashboard.Controls.Add(tlpRequestStatus, 0, 3)
        tlpDashboard.Controls.Add(lblRecentRequests, 0, 4)
        tlpDashboard.Controls.Add(pnlRecentBorder, 0, 5)
        tlpDashboard.Controls.Add(lblQuickActions, 0, 6)
        tlpDashboard.Controls.Add(tlpQuickAction, 0, 7)
        tlpDashboard.Dock = DockStyle.Fill
        tlpDashboard.Location = New Point(0, 0)
        tlpDashboard.Name = "tlpDashboard"
        tlpDashboard.Padding = New Padding(28, 20, 28, 24)
        tlpDashboard.RowCount = 8
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Absolute, 92.0F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Absolute, 92.0F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpDashboard.RowStyles.Add(New RowStyle(SizeType.Absolute, 92.0F))
        tlpDashboard.Size = New Size(1020, 700)
        tlpDashboard.TabIndex = 0
        '
        ' lblOverall
        '
        lblOverall.AutoSize = True
        lblOverall.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblOverall.ForeColor = Color.FromArgb(31, 41, 55)
        lblOverall.Margin = New Padding(0, 0, 0, 8)
        lblOverall.Name = "lblOverall"
        lblOverall.TabIndex = 1
        lblOverall.Text = "Overall"
        '
        ' tlpOverall  (4 equal cards)
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
        tlpOverall.Margin = New Padding(0)
        tlpOverall.Name = "tlpOverall"
        tlpOverall.RowCount = 1
        tlpOverall.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpOverall.TabIndex = 2
        '
        ' cardTotalStudents
        '
        cardTotalStudents.AccentColor = Color.FromArgb(27, 67, 50)
        cardTotalStudents.Dock = DockStyle.Fill
        cardTotalStudents.Margin = New Padding(0, 0, 16, 0)
        cardTotalStudents.Name = "cardTotalStudents"
        cardTotalStudents.TabIndex = 0
        cardTotalStudents.Title = "Total Students"
        cardTotalStudents.Value = "0"
        '
        ' cardTotalRequests
        '
        cardTotalRequests.AccentColor = Color.FromArgb(27, 67, 50)
        cardTotalRequests.Dock = DockStyle.Fill
        cardTotalRequests.Margin = New Padding(0, 0, 16, 0)
        cardTotalRequests.Name = "cardTotalRequests"
        cardTotalRequests.TabIndex = 1
        cardTotalRequests.Title = "Total Requests"
        cardTotalRequests.Value = "0"
        '
        ' cardRequestsThisMonth
        '
        cardRequestsThisMonth.AccentColor = Color.FromArgb(27, 67, 50)
        cardRequestsThisMonth.Dock = DockStyle.Fill
        cardRequestsThisMonth.Margin = New Padding(0, 0, 16, 0)
        cardRequestsThisMonth.Name = "cardRequestsThisMonth"
        cardRequestsThisMonth.TabIndex = 2
        cardRequestsThisMonth.Title = "Requests This Month"
        cardRequestsThisMonth.Value = "0"
        '
        ' cardPaymentsCollected
        '
        cardPaymentsCollected.AccentColor = Color.FromArgb(242, 184, 7)
        cardPaymentsCollected.Dock = DockStyle.Fill
        cardPaymentsCollected.Margin = New Padding(0)
        cardPaymentsCollected.Name = "cardPaymentsCollected"
        cardPaymentsCollected.TabIndex = 3
        cardPaymentsCollected.Title = "Payments Collected"
        cardPaymentsCollected.Value = "0"
        '
        ' lblRequestStatus
        '
        lblRequestStatus.AutoSize = True
        lblRequestStatus.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblRequestStatus.ForeColor = Color.FromArgb(31, 41, 55)
        lblRequestStatus.Margin = New Padding(0, 18, 0, 8)
        lblRequestStatus.Name = "lblRequestStatus"
        lblRequestStatus.TabIndex = 3
        lblRequestStatus.Text = "Request Status"
        '
        ' tlpRequestStatus  (5 equal cards)
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
        tlpRequestStatus.Margin = New Padding(0)
        tlpRequestStatus.Name = "tlpRequestStatus"
        tlpRequestStatus.RowCount = 1
        tlpRequestStatus.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpRequestStatus.TabIndex = 4
        '
        ' cardPending
        '
        cardPending.AccentColor = Color.FromArgb(245, 158, 11)
        cardPending.Dock = DockStyle.Fill
        cardPending.Margin = New Padding(0, 0, 16, 0)
        cardPending.Name = "cardPending"
        cardPending.TabIndex = 0
        cardPending.Title = "Pending"
        cardPending.Value = "0"
        '
        ' cardProcessing
        '
        cardProcessing.AccentColor = Color.FromArgb(124, 58, 237)
        cardProcessing.Dock = DockStyle.Fill
        cardProcessing.Margin = New Padding(0, 0, 16, 0)
        cardProcessing.Name = "cardProcessing"
        cardProcessing.TabIndex = 1
        cardProcessing.Title = "Processing"
        cardProcessing.Value = "0"
        '
        ' cardReadyForRelease
        '
        cardReadyForRelease.AccentColor = Color.FromArgb(13, 148, 136)
        cardReadyForRelease.Dock = DockStyle.Fill
        cardReadyForRelease.Margin = New Padding(0, 0, 16, 0)
        cardReadyForRelease.Name = "cardReadyForRelease"
        cardReadyForRelease.TabIndex = 2
        cardReadyForRelease.Title = "Ready for Release"
        cardReadyForRelease.Value = "0"
        '
        ' cardReleased
        '
        cardReleased.AccentColor = Color.FromArgb(71, 85, 105)
        cardReleased.Dock = DockStyle.Fill
        cardReleased.Margin = New Padding(0, 0, 16, 0)
        cardReleased.Name = "cardReleased"
        cardReleased.TabIndex = 3
        cardReleased.Title = "Released"
        cardReleased.Value = "0"
        '
        ' cardCancelled
        '
        cardCancelled.AccentColor = Color.FromArgb(220, 38, 38)
        cardCancelled.Dock = DockStyle.Fill
        cardCancelled.Margin = New Padding(0)
        cardCancelled.Name = "cardCancelled"
        cardCancelled.TabIndex = 4
        cardCancelled.Title = "Cancelled"
        cardCancelled.Value = "0"
        '
        ' lblRecentRequests
        '
        lblRecentRequests.AutoSize = True
        lblRecentRequests.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecentRequests.ForeColor = Color.FromArgb(31, 41, 55)
        lblRecentRequests.Margin = New Padding(0, 18, 0, 8)
        lblRecentRequests.Name = "lblRecentRequests"
        lblRecentRequests.TabIndex = 5
        lblRecentRequests.Text = "Recent Requests"
        '
        ' pnlRecentBorder  (1px outline around the list)
        '
        pnlRecentBorder.BackColor = Color.FromArgb(229, 231, 235)
        pnlRecentBorder.Controls.Add(lvRecentRequests)
        pnlRecentBorder.Dock = DockStyle.Fill
        pnlRecentBorder.Margin = New Padding(0)
        pnlRecentBorder.Name = "pnlRecentBorder"
        pnlRecentBorder.Padding = New Padding(1)
        pnlRecentBorder.TabIndex = 6
        '
        ' lvRecentRequests  (styled at runtime by Theme.StyleListView)
        '
        lvRecentRequests.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        lvRecentRequests.Dock = DockStyle.Fill
        lvRecentRequests.Name = "lvRecentRequests"
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
        lblQuickActions.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblQuickActions.ForeColor = Color.FromArgb(31, 41, 55)
        lblQuickActions.Margin = New Padding(0, 18, 0, 8)
        lblQuickActions.Name = "lblQuickActions"
        lblQuickActions.TabIndex = 7
        lblQuickActions.Text = "Quick Actions"
        '
        ' tlpQuickAction  (5 equal tiles)
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
        tlpQuickAction.Margin = New Padding(0)
        tlpQuickAction.Name = "tlpQuickAction"
        tlpQuickAction.RowCount = 1
        tlpQuickAction.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tlpQuickAction.TabIndex = 8
        '
        ' btnSearchRecords
        '
        btnSearchRecords.Dock = DockStyle.Fill
        btnSearchRecords.Glyph = ChrW(&HE721)
        btnSearchRecords.Margin = New Padding(0, 0, 16, 0)
        btnSearchRecords.Name = "btnSearchRecords"
        btnSearchRecords.TabIndex = 0
        btnSearchRecords.Text = "Search Records"
        '
        ' btnCreateRequest
        '
        btnCreateRequest.Dock = DockStyle.Fill
        btnCreateRequest.Glyph = ChrW(&HE710)
        btnCreateRequest.Margin = New Padding(0, 0, 16, 0)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.TabIndex = 1
        btnCreateRequest.Text = "Create Request"
        '
        ' btnPaymentReport
        '
        btnPaymentReport.Dock = DockStyle.Fill
        btnPaymentReport.Glyph = ChrW(&HE9D9)
        btnPaymentReport.Margin = New Padding(0, 0, 16, 0)
        btnPaymentReport.Name = "btnPaymentReport"
        btnPaymentReport.TabIndex = 2
        btnPaymentReport.Text = "Payment Report"
        '
        ' btnAddStudent
        '
        btnAddStudent.Dock = DockStyle.Fill
        btnAddStudent.Glyph = ChrW(&HE8FA)
        btnAddStudent.Margin = New Padding(0, 0, 16, 0)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.TabIndex = 3
        btnAddStudent.Text = "Add Student"
        '
        ' btnAddDocument
        '
        btnAddDocument.Dock = DockStyle.Fill
        btnAddDocument.Glyph = ChrW(&HE8A5)
        btnAddDocument.Margin = New Padding(0)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.TabIndex = 4
        btnAddDocument.Text = "Add Document"
        '
        ' frmDashboard
        '
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(860, 700)
        BackColor = Color.FromArgb(245, 247, 244)
        ClientSize = New Size(1020, 700)
        Controls.Add(tlpDashboard)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDashboard"
        Text = "Dashboard"
        tlpDashboard.ResumeLayout(False)
        tlpDashboard.PerformLayout()
        tlpOverall.ResumeLayout(False)
        tlpRequestStatus.ResumeLayout(False)
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
