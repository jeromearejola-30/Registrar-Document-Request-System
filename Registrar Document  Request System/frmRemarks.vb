''' <summary>
''' Reusable "Are you sure?" dialog that forces a reason and written details.
''' Usage:
'''   Using dlg As New frmRemarks("Confirm Changes", "Save changes to this student?", RemarkReasons.StudentEdit)
'''       If dlg.ShowDialog(Me) = DialogResult.OK Then ... dlg.Reason / dlg.Details / dlg.FullText
'''   End Using
''' </summary>
Public Class frmRemarks
    Inherits Form

    Private ReadOnly lblPrompt As New Label()
    Private ReadOnly lblReason As New Label()
    Private ReadOnly cboReason As New ComboBox()
    Private ReadOnly lblDetails As New Label()
    Private ReadOnly txtDetails As New TextBox()
    Private ReadOnly lblCount As New Label()
    Private ReadOnly btnConfirm As New Button()
    Private ReadOnly btnCancel As New Button()
    Private ReadOnly _minLength As Integer

    Private _reason As String = ""
    Private _details As String = ""

    Public ReadOnly Property Reason As String
        Get
            Return _reason
        End Get
    End Property

    Public ReadOnly Property Details As String
        Get
            Return _details
        End Get
    End Property

    ''' <summary>Reason and details together, e.g. for the activity log's Remarks column.</summary>
    Public ReadOnly Property FullText As String
        Get
            Return $"{_reason}: {_details}"
        End Get
    End Property

    Public Sub New(title As String, prompt As String, reasons As IEnumerable(Of String),
                   Optional minLength As Integer = 10)
        _minLength = minLength

        Text = title
        FormBorderStyle = FormBorderStyle.FixedDialog
        StartPosition = FormStartPosition.CenterParent
        MaximizeBox = False
        MinimizeBox = False
        ShowInTaskbar = False
        ClientSize = New Size(460, 340)
        BackColor = Theme.Background
        Font = Theme.UiFont(10)

        lblPrompt.SetBounds(20, 16, 420, 48)
        lblPrompt.Text = prompt
        lblPrompt.Font = Theme.UiFont(10, FontStyle.Bold)
        lblPrompt.ForeColor = Theme.TextMain

        lblReason.SetBounds(20, 72, 420, 20)
        lblReason.Text = "Reason"
        lblReason.ForeColor = Theme.TextMuted

        cboReason.SetBounds(20, 94, 420, 28)
        cboReason.DropDownStyle = ComboBoxStyle.DropDownList
        For Each r As String In reasons
            cboReason.Items.Add(r)
        Next

        lblDetails.SetBounds(20, 134, 420, 20)
        lblDetails.Text = "Details (required)"
        lblDetails.ForeColor = Theme.TextMuted

        txtDetails.SetBounds(20, 156, 420, 100)
        txtDetails.Multiline = True
        txtDetails.ScrollBars = ScrollBars.Vertical
        txtDetails.MaxLength = 500
        AddHandler txtDetails.TextChanged, AddressOf UpdateCount

        lblCount.SetBounds(20, 260, 420, 20)
        lblCount.TextAlign = ContentAlignment.MiddleRight

        btnConfirm.SetBounds(230, 292, 100, 34)
        btnConfirm.Text = "Confirm"
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.FlatAppearance.BorderSize = 0
        btnConfirm.BackColor = Theme.Primary
        btnConfirm.ForeColor = Color.White
        AddHandler btnConfirm.Click, AddressOf Confirm_Click

        btnCancel.SetBounds(340, 292, 100, 34)
        btnCancel.Text = "Cancel"
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.BorderColor = Theme.Border
        btnCancel.BackColor = Theme.Surface
        btnCancel.ForeColor = Theme.TextMain
        btnCancel.DialogResult = DialogResult.Cancel

        CancelButton = btnCancel   ' Esc closes the dialog
        Controls.AddRange(New Control() {lblPrompt, lblReason, cboReason, lblDetails, txtDetails, lblCount, btnConfirm, btnCancel})
        UpdateCount(Nothing, EventArgs.Empty)
    End Sub

    Private Sub UpdateCount(sender As Object, e As EventArgs)
        Dim n As Integer = txtDetails.Text.Trim().Length
        lblCount.Text = $"{n} characters (minimum {_minLength})"
        lblCount.ForeColor = If(n >= _minLength, Theme.TextMuted, Color.Firebrick)
    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs)
        If cboReason.SelectedIndex = -1 Then
            MessageBox.Show(Me, "Please select a reason.", "Reason required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboReason.Focus()
            Return
        End If

        Dim d As String = txtDetails.Text.Trim()
        If d.Length < _minLength Then
            MessageBox.Show(Me, $"Please describe the reason in at least {_minLength} characters.",
                            "Details required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDetails.Focus()
            Return
        End If

        _reason = cboReason.SelectedItem.ToString()
        _details = d
        DialogResult = DialogResult.OK   ' this also closes the dialog
    End Sub

End Class

''' <summary>Preset reasons for each place a remark is required. Every list ends with "Other".</summary>
Public Module RemarkReasons
    Public ReadOnly StudentEdit As String() = {
        "Typographical error correction", "Updated contact information per student request",
        "Section transfer approved", "Program shift approved", "Corrected per supporting document", "Other"}

    Public ReadOnly StudentStatus As String() = {
        "Transferred to another school", "Dropped out", "On leave of absence",
        "Returned from leave of absence", "Other"}

    Public ReadOnly DocumentStatus As String() = {
        "Template under revision", "Fee or policy under review", "Service temporarily suspended",
        "Revision completed; service resumed", "Other"}

    Public ReadOnly CancelRequest As String() = {
        "Student no longer needs the document", "Wrong document selected", "Duplicate request",
        "Student did not proceed with payment", "Other"}

    Public ReadOnly RequestPurpose As String() = {
    "Employment", "Transfer to Another School", "Scholarship Application", "Further Studies",
    "Board Exam / Licensure", "Personal Copy", "Other"}

    Public ReadOnly UserChange As String() = {
    "Account deactivated: staff left or transferred", "Account reactivated",
    "Role change approved", "Name or username corrected", "Other"}
End Module