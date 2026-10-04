<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentManagement
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
        tlpMain = New TableLayoutPanel()
        tlpToolbar = New TableLayoutPanel()
        txtSearch = New TextBox()
        btnClearSearch = New Button()
        btnAddStudentRecord = New Button()
        lblAllStudents = New Label()
        pnlGridBorder = New Panel()
        dgvStudents = New DataGridView()
        tlpSummary = New TableLayoutPanel()
        cardInfo = New CardPanel()
        tlpInfo = New TableLayoutPanel()
        lblUserInformation = New Label()
        lblCapStudentNumber = New Label()
        lblStudentNumber = New Label()
        lblCapLastName = New Label()
        lblLastName = New Label()
        lblCapFirstName = New Label()
        lblFirstName = New Label()
        btnViewStudent = New Button()
        cardStatus = New CardPanel()
        tlpStatus = New TableLayoutPanel()
        lblUserStatusSummary = New Label()
        lblCapActive = New Label()
        lblNumberActiveStudents = New Label()
        lblCapInactive = New Label()
        lblNumberInactiveStudents = New Label()
        lblCapIncomplete = New Label()
        lblNumberIncompleteRecords = New Label()
        tlpMain.SuspendLayout()
        tlpToolbar.SuspendLayout()
        pnlGridBorder.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        tlpSummary.SuspendLayout()
        cardInfo.SuspendLayout()
        tlpInfo.SuspendLayout()
        cardStatus.SuspendLayout()
        tlpStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlpMain
        ' 
        tlpMain.ColumnCount = 1
        tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpMain.Controls.Add(tlpToolbar, 0, 0)
        tlpMain.Controls.Add(lblAllStudents, 0, 1)
        tlpMain.Controls.Add(pnlGridBorder, 0, 2)
        tlpMain.Controls.Add(tlpSummary, 0, 3)
        tlpMain.Dock = DockStyle.Fill
        tlpMain.Location = New Point(0, 0)
        tlpMain.Name = "tlpMain"
        tlpMain.Padding = New Padding(28, 20, 28, 24)
        tlpMain.RowCount = 4
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle())
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 196F))
        tlpMain.Size = New Size(1020, 640)
        tlpMain.TabIndex = 0
        ' 
        ' tlpToolbar
        ' 
        tlpToolbar.AutoSize = True
        tlpToolbar.ColumnCount = 3
        tlpToolbar.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.ColumnStyles.Add(New ColumnStyle())
        tlpToolbar.Controls.Add(txtSearch, 0, 0)
        tlpToolbar.Controls.Add(btnClearSearch, 1, 0)
        tlpToolbar.Controls.Add(btnAddStudentRecord, 2, 0)
        tlpToolbar.Dock = DockStyle.Fill
        tlpToolbar.Location = New Point(28, 20)
        tlpToolbar.Margin = New Padding(0)
        tlpToolbar.Name = "tlpToolbar"
        tlpToolbar.RowCount = 1
        tlpToolbar.RowStyles.Add(New RowStyle())
        tlpToolbar.Size = New Size(964, 40)
        tlpToolbar.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 11F)
        txtSearch.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        txtSearch.Location = New Point(0, 6)
        txtSearch.Margin = New Padding(0)
        txtSearch.MaximumSize = New Size(520, 0)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by student number or name..."
        txtSearch.Size = New Size(520, 27)
        txtSearch.TabIndex = 0
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.AutoSize = True
        btnClearSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnClearSearch.BackColor = Color.White
        btnClearSearch.Cursor = Cursors.Hand
        btnClearSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClearSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnClearSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnClearSearch.FlatStyle = FlatStyle.Flat
        btnClearSearch.Font = New Font("Segoe UI Semibold", 10F)
        btnClearSearch.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnClearSearch.Location = New Point(704, 0)
        btnClearSearch.Margin = New Padding(8, 0, 0, 0)
        btnClearSearch.MinimumSize = New Size(0, 40)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Padding = New Padding(14, 0, 14, 0)
        btnClearSearch.Size = New Size(127, 40)
        btnClearSearch.TabIndex = 1
        btnClearSearch.Text = "Clear Search"
        btnClearSearch.UseVisualStyleBackColor = False
        ' 
        ' btnAddStudentRecord
        ' 
        btnAddStudentRecord.AutoSize = True
        btnAddStudentRecord.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddStudentRecord.BackColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnAddStudentRecord.Cursor = Cursors.Hand
        btnAddStudentRecord.FlatAppearance.BorderSize = 0
        btnAddStudentRecord.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(36), CByte(90), CByte(65))
        btnAddStudentRecord.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(45), CByte(106), CByte(79))
        btnAddStudentRecord.FlatStyle = FlatStyle.Flat
        btnAddStudentRecord.Font = New Font("Segoe UI Semibold", 10F)
        btnAddStudentRecord.ForeColor = Color.White
        btnAddStudentRecord.Location = New Point(839, 0)
        btnAddStudentRecord.Margin = New Padding(8, 0, 0, 0)
        btnAddStudentRecord.MinimumSize = New Size(0, 40)
        btnAddStudentRecord.Name = "btnAddStudentRecord"
        btnAddStudentRecord.Padding = New Padding(14, 0, 14, 0)
        btnAddStudentRecord.Size = New Size(125, 40)
        btnAddStudentRecord.TabIndex = 2
        btnAddStudentRecord.Text = "Add Student"
        btnAddStudentRecord.UseVisualStyleBackColor = False
        ' 
        ' lblAllStudents
        ' 
        lblAllStudents.AutoSize = True
        lblAllStudents.Font = New Font("Segoe UI Semibold", 12F)
        lblAllStudents.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblAllStudents.Location = New Point(28, 76)
        lblAllStudents.Margin = New Padding(0, 16, 0, 8)
        lblAllStudents.Name = "lblAllStudents"
        lblAllStudents.Size = New Size(155, 21)
        lblAllStudents.TabIndex = 1
        lblAllStudents.Text = "All Student Records"
        ' 
        ' pnlGridBorder
        ' 
        pnlGridBorder.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        pnlGridBorder.Controls.Add(dgvStudents)
        pnlGridBorder.Dock = DockStyle.Fill
        pnlGridBorder.Location = New Point(28, 105)
        pnlGridBorder.Margin = New Padding(0)
        pnlGridBorder.Name = "pnlGridBorder"
        pnlGridBorder.Padding = New Padding(1)
        pnlGridBorder.Size = New Size(964, 315)
        pnlGridBorder.TabIndex = 2
        ' 
        ' dgvStudents
        ' 
        dgvStudents.Dock = DockStyle.Fill
        dgvStudents.Location = New Point(1, 1)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.Size = New Size(962, 313)
        dgvStudents.TabIndex = 0
        ' 
        ' tlpSummary
        ' 
        tlpSummary.ColumnCount = 2
        tlpSummary.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpSummary.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpSummary.Controls.Add(cardInfo, 0, 0)
        tlpSummary.Controls.Add(cardStatus, 1, 0)
        tlpSummary.Dock = DockStyle.Fill
        tlpSummary.Location = New Point(28, 436)
        tlpSummary.Margin = New Padding(0, 16, 0, 0)
        tlpSummary.Name = "tlpSummary"
        tlpSummary.RowCount = 1
        tlpSummary.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpSummary.Size = New Size(964, 180)
        tlpSummary.TabIndex = 3
        ' 
        ' cardInfo
        ' 
        cardInfo.BackColor = Color.White
        cardInfo.Controls.Add(tlpInfo)
        cardInfo.Dock = DockStyle.Fill
        cardInfo.Location = New Point(0, 0)
        cardInfo.Margin = New Padding(0, 0, 8, 0)
        cardInfo.Name = "cardInfo"
        cardInfo.Padding = New Padding(20, 14, 20, 14)
        cardInfo.Size = New Size(474, 180)
        cardInfo.TabIndex = 0
        ' 
        ' tlpInfo
        ' 
        tlpInfo.ColumnCount = 2
        tlpInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 130F))
        tlpInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpInfo.Controls.Add(lblUserInformation, 0, 0)
        tlpInfo.Controls.Add(lblCapStudentNumber, 0, 1)
        tlpInfo.Controls.Add(lblStudentNumber, 1, 1)
        tlpInfo.Controls.Add(lblCapLastName, 0, 2)
        tlpInfo.Controls.Add(lblLastName, 1, 2)
        tlpInfo.Controls.Add(lblCapFirstName, 0, 3)
        tlpInfo.Controls.Add(lblFirstName, 1, 3)
        tlpInfo.Controls.Add(btnViewStudent, 0, 4)
        tlpInfo.Dock = DockStyle.Fill
        tlpInfo.Location = New Point(20, 14)
        tlpInfo.Name = "tlpInfo"
        tlpInfo.RowCount = 5
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle())
        tlpInfo.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpInfo.Size = New Size(434, 152)
        tlpInfo.TabIndex = 0
        ' 
        ' lblUserInformation
        ' 
        lblUserInformation.AutoSize = True
        tlpInfo.SetColumnSpan(lblUserInformation, 2)
        lblUserInformation.Font = New Font("Segoe UI Semibold", 11F)
        lblUserInformation.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblUserInformation.Location = New Point(0, 0)
        lblUserInformation.Margin = New Padding(0, 0, 0, 8)
        lblUserInformation.Name = "lblUserInformation"
        lblUserInformation.Size = New Size(217, 20)
        lblUserInformation.TabIndex = 0
        lblUserInformation.Text = "Student Information Summary"
        ' 
        ' lblCapStudentNumber
        ' 
        lblCapStudentNumber.AutoSize = True
        lblCapStudentNumber.Font = New Font("Segoe UI", 10F)
        lblCapStudentNumber.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapStudentNumber.Location = New Point(0, 31)
        lblCapStudentNumber.Margin = New Padding(0, 3, 0, 3)
        lblCapStudentNumber.Name = "lblCapStudentNumber"
        lblCapStudentNumber.Size = New Size(111, 19)
        lblCapStudentNumber.TabIndex = 1
        lblCapStudentNumber.Text = "Student Number"
        ' 
        ' lblStudentNumber
        ' 
        lblStudentNumber.AutoSize = True
        lblStudentNumber.Font = New Font("Segoe UI Semibold", 10.5F)
        lblStudentNumber.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblStudentNumber.Location = New Point(130, 31)
        lblStudentNumber.Margin = New Padding(0, 3, 0, 3)
        lblStudentNumber.Name = "lblStudentNumber"
        lblStudentNumber.Size = New Size(15, 19)
        lblStudentNumber.TabIndex = 2
        lblStudentNumber.Text = "-"
        ' 
        ' lblCapLastName
        ' 
        lblCapLastName.AutoSize = True
        lblCapLastName.Font = New Font("Segoe UI", 10F)
        lblCapLastName.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapLastName.Location = New Point(0, 56)
        lblCapLastName.Margin = New Padding(0, 3, 0, 3)
        lblCapLastName.Name = "lblCapLastName"
        lblCapLastName.Size = New Size(74, 19)
        lblCapLastName.TabIndex = 3
        lblCapLastName.Text = "Last Name"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI Semibold", 10.5F)
        lblLastName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblLastName.Location = New Point(130, 56)
        lblLastName.Margin = New Padding(0, 3, 0, 3)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(15, 19)
        lblLastName.TabIndex = 4
        lblLastName.Text = "-"
        ' 
        ' lblCapFirstName
        ' 
        lblCapFirstName.AutoSize = True
        lblCapFirstName.Font = New Font("Segoe UI", 10F)
        lblCapFirstName.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapFirstName.Location = New Point(0, 81)
        lblCapFirstName.Margin = New Padding(0, 3, 0, 3)
        lblCapFirstName.Name = "lblCapFirstName"
        lblCapFirstName.Size = New Size(75, 19)
        lblCapFirstName.TabIndex = 5
        lblCapFirstName.Text = "First Name"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI Semibold", 10.5F)
        lblFirstName.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblFirstName.Location = New Point(130, 81)
        lblFirstName.Margin = New Padding(0, 3, 0, 3)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(15, 19)
        lblFirstName.TabIndex = 6
        lblFirstName.Text = "-"
        ' 
        ' btnViewStudent
        ' 
        btnViewStudent.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnViewStudent.AutoSize = True
        btnViewStudent.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnViewStudent.BackColor = Color.White
        tlpInfo.SetColumnSpan(btnViewStudent, 2)
        btnViewStudent.Cursor = Cursors.Hand
        btnViewStudent.FlatAppearance.BorderColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnViewStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(207), CByte(227), CByte(214))
        btnViewStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(234), CByte(242), CByte(237))
        btnViewStudent.FlatStyle = FlatStyle.Flat
        btnViewStudent.Font = New Font("Segoe UI Semibold", 10F)
        btnViewStudent.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        btnViewStudent.Location = New Point(0, 112)
        btnViewStudent.Margin = New Padding(0, 8, 0, 0)
        btnViewStudent.MinimumSize = New Size(0, 40)
        btnViewStudent.Name = "btnViewStudent"
        btnViewStudent.Padding = New Padding(14, 0, 14, 0)
        btnViewStudent.Size = New Size(133, 40)
        btnViewStudent.TabIndex = 7
        btnViewStudent.Text = "View Student"
        btnViewStudent.UseVisualStyleBackColor = False
        ' 
        ' cardStatus
        ' 
        cardStatus.BackColor = Color.White
        cardStatus.Controls.Add(tlpStatus)
        cardStatus.Dock = DockStyle.Fill
        cardStatus.Location = New Point(490, 0)
        cardStatus.Margin = New Padding(8, 0, 0, 0)
        cardStatus.Name = "cardStatus"
        cardStatus.Padding = New Padding(20, 14, 20, 14)
        cardStatus.Size = New Size(474, 180)
        cardStatus.TabIndex = 1
        ' 
        ' tlpStatus
        ' 
        tlpStatus.ColumnCount = 2
        tlpStatus.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpStatus.ColumnStyles.Add(New ColumnStyle())
        tlpStatus.Controls.Add(lblUserStatusSummary, 0, 0)
        tlpStatus.Controls.Add(lblCapActive, 0, 1)
        tlpStatus.Controls.Add(lblNumberActiveStudents, 1, 1)
        tlpStatus.Controls.Add(lblCapInactive, 0, 2)
        tlpStatus.Controls.Add(lblNumberInactiveStudents, 1, 2)
        tlpStatus.Controls.Add(lblCapIncomplete, 0, 3)
        tlpStatus.Controls.Add(lblNumberIncompleteRecords, 1, 3)
        tlpStatus.Dock = DockStyle.Fill
        tlpStatus.Location = New Point(20, 14)
        tlpStatus.Name = "tlpStatus"
        tlpStatus.RowCount = 5
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle())
        tlpStatus.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpStatus.Size = New Size(434, 152)
        tlpStatus.TabIndex = 0
        ' 
        ' lblUserStatusSummary
        ' 
        lblUserStatusSummary.AutoSize = True
        tlpStatus.SetColumnSpan(lblUserStatusSummary, 2)
        lblUserStatusSummary.Font = New Font("Segoe UI Semibold", 11F)
        lblUserStatusSummary.ForeColor = Color.FromArgb(CByte(27), CByte(67), CByte(50))
        lblUserStatusSummary.Location = New Point(0, 0)
        lblUserStatusSummary.Margin = New Padding(0, 0, 0, 8)
        lblUserStatusSummary.Name = "lblUserStatusSummary"
        lblUserStatusSummary.Size = New Size(177, 20)
        lblUserStatusSummary.TabIndex = 0
        lblUserStatusSummary.Text = "Student Status Summary"
        ' 
        ' lblCapActive
        ' 
        lblCapActive.AutoSize = True
        lblCapActive.Font = New Font("Segoe UI", 10F)
        lblCapActive.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapActive.Location = New Point(0, 31)
        lblCapActive.Margin = New Padding(0, 3, 0, 3)
        lblCapActive.Name = "lblCapActive"
        lblCapActive.Size = New Size(104, 19)
        lblCapActive.TabIndex = 1
        lblCapActive.Text = "Active Students"
        ' 
        ' lblNumberActiveStudents
        ' 
        lblNumberActiveStudents.Anchor = AnchorStyles.Right
        lblNumberActiveStudents.AutoSize = True
        lblNumberActiveStudents.Font = New Font("Segoe UI Semibold", 10.5F)
        lblNumberActiveStudents.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblNumberActiveStudents.Location = New Point(417, 31)
        lblNumberActiveStudents.Margin = New Padding(0, 3, 0, 3)
        lblNumberActiveStudents.Name = "lblNumberActiveStudents"
        lblNumberActiveStudents.Size = New Size(17, 19)
        lblNumberActiveStudents.TabIndex = 2
        lblNumberActiveStudents.Text = "0"
        ' 
        ' lblCapInactive
        ' 
        lblCapInactive.AutoSize = True
        lblCapInactive.Font = New Font("Segoe UI", 10F)
        lblCapInactive.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapInactive.Location = New Point(0, 56)
        lblCapInactive.Margin = New Padding(0, 3, 0, 3)
        lblCapInactive.Name = "lblCapInactive"
        lblCapInactive.Size = New Size(114, 19)
        lblCapInactive.TabIndex = 3
        lblCapInactive.Text = "Inactive Students"
        ' 
        ' lblNumberInactiveStudents
        ' 
        lblNumberInactiveStudents.Anchor = AnchorStyles.Right
        lblNumberInactiveStudents.AutoSize = True
        lblNumberInactiveStudents.Font = New Font("Segoe UI Semibold", 10.5F)
        lblNumberInactiveStudents.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblNumberInactiveStudents.Location = New Point(417, 56)
        lblNumberInactiveStudents.Margin = New Padding(0, 3, 0, 3)
        lblNumberInactiveStudents.Name = "lblNumberInactiveStudents"
        lblNumberInactiveStudents.Size = New Size(17, 19)
        lblNumberInactiveStudents.TabIndex = 4
        lblNumberInactiveStudents.Text = "0"
        ' 
        ' lblCapIncomplete
        ' 
        lblCapIncomplete.AutoSize = True
        lblCapIncomplete.Font = New Font("Segoe UI", 10F)
        lblCapIncomplete.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblCapIncomplete.Location = New Point(0, 81)
        lblCapIncomplete.Margin = New Padding(0, 3, 0, 3)
        lblCapIncomplete.Name = "lblCapIncomplete"
        lblCapIncomplete.Size = New Size(129, 19)
        lblCapIncomplete.TabIndex = 5
        lblCapIncomplete.Text = "Incomplete Records"
        ' 
        ' lblNumberIncompleteRecords
        ' 
        lblNumberIncompleteRecords.Anchor = AnchorStyles.Right
        lblNumberIncompleteRecords.AutoSize = True
        lblNumberIncompleteRecords.Font = New Font("Segoe UI Semibold", 10.5F)
        lblNumberIncompleteRecords.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblNumberIncompleteRecords.Location = New Point(419, 81)
        lblNumberIncompleteRecords.Margin = New Padding(0, 3, 0, 3)
        lblNumberIncompleteRecords.Name = "lblNumberIncompleteRecords"
        lblNumberIncompleteRecords.Size = New Size(15, 19)
        lblNumberIncompleteRecords.TabIndex = 6
        lblNumberIncompleteRecords.Text = "-"
        ' 
        ' frmStudentManagement
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoScroll = True
        AutoScrollMinSize = New Size(860, 640)
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(244))
        ClientSize = New Size(1020, 640)
        Controls.Add(tlpMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmStudentManagement"
        Text = "Student Management"
        tlpMain.ResumeLayout(False)
        tlpMain.PerformLayout()
        tlpToolbar.ResumeLayout(False)
        tlpToolbar.PerformLayout()
        pnlGridBorder.ResumeLayout(False)
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        tlpSummary.ResumeLayout(False)
        cardInfo.ResumeLayout(False)
        tlpInfo.ResumeLayout(False)
        tlpInfo.PerformLayout()
        cardStatus.ResumeLayout(False)
        tlpStatus.ResumeLayout(False)
        tlpStatus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpToolbar As TableLayoutPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents btnAddStudentRecord As Button
    Friend WithEvents lblAllStudents As Label
    Friend WithEvents pnlGridBorder As Panel
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents tlpSummary As TableLayoutPanel
    Friend WithEvents cardInfo As CardPanel
    Friend WithEvents tlpInfo As TableLayoutPanel
    Friend WithEvents lblUserInformation As Label
    Friend WithEvents lblCapStudentNumber As Label
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents lblCapLastName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblCapFirstName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnViewStudent As Button
    Friend WithEvents cardStatus As CardPanel
    Friend WithEvents tlpStatus As TableLayoutPanel
    Friend WithEvents lblUserStatusSummary As Label
    Friend WithEvents lblCapActive As Label
    Friend WithEvents lblNumberActiveStudents As Label
    Friend WithEvents lblCapInactive As Label
    Friend WithEvents lblNumberInactiveStudents As Label
    Friend WithEvents lblCapIncomplete As Label
    Friend WithEvents lblNumberIncompleteRecords As Label
End Class
