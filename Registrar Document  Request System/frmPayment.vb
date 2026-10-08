''' <summary>What the payment dialog collected.</summary>
Public Class PaymentResult
    Public Property Mode As String
    Public Property AmountDue As Decimal
    Public Property AmountTendered As Decimal
    Public Property ReferenceNo As String
    Public Property IsRush As Boolean

    Public ReadOnly Property Change As Decimal
        Get
            Return AmountTendered - AmountDue
        End Get
    End Property
End Class

''' <summary>Payment dialog: rush option, payment mode, amount given and change.</summary>
Public Class frmPayment
    Inherits Form

    Private ReadOnly _subtotal As Decimal
    Private ReadOnly lblRequest As New Label()
    Private ReadOnly lblSubCap As New Label()
    Private ReadOnly lblSub As New Label()
    Private ReadOnly chkRush As New CheckBox()
    Private ReadOnly lblTotalCap As New Label()
    Private ReadOnly lblTotal As New Label()
    Private ReadOnly lblModeCap As New Label()
    Private ReadOnly cboMode As New ComboBox()
    Private ReadOnly lblTenderedCap As New Label()
    Private ReadOnly nudTendered As New NumericUpDown()
    Private ReadOnly lblRefCap As New Label()
    Private ReadOnly txtRef As New TextBox()
    Private ReadOnly lblChange As New Label()
    Private ReadOnly btnConfirm As New Button()
    Private ReadOnly btnCancel As New Button()

    Private _result As PaymentResult

    Public ReadOnly Property Result As PaymentResult
        Get
            Return _result
        End Get
    End Property

    Private Shared Function Peso(value As Decimal) As String
        Return "₱" & value.ToString("N2")
    End Function

    Public Sub New(requestNo As String, studentName As String, subtotal As Decimal)
        _subtotal = subtotal

        Text = "Record Payment"
        FormBorderStyle = FormBorderStyle.FixedDialog
        StartPosition = FormStartPosition.CenterParent
        MaximizeBox = False
        MinimizeBox = False
        ShowInTaskbar = False
        ClientSize = New Size(460, 470)
        BackColor = Theme.Background
        Font = Theme.UiFont(10)

        lblRequest.SetBounds(20, 16, 420, 40)
        lblRequest.Text = $"{requestNo}  -  {studentName}"
        lblRequest.Font = Theme.UiFont(10, FontStyle.Bold)

        lblSubCap.SetBounds(20, 68, 200, 22)
        lblSubCap.Text = "Documents subtotal"
        lblSubCap.ForeColor = Theme.TextMuted
        lblSub.SetBounds(240, 68, 200, 22)
        lblSub.TextAlign = ContentAlignment.MiddleRight
        lblSub.Text = Peso(_subtotal)

        chkRush.SetBounds(20, 98, 420, 26)
        chkRush.Text = $"Rush / expedite processing  (+ {Peso(RequestHelper.RushFee)})"

        lblTotalCap.SetBounds(20, 138, 150, 30)
        lblTotalCap.Text = "TOTAL DUE"
        lblTotalCap.Font = Theme.UiFont(10, FontStyle.Bold)
        lblTotalCap.TextAlign = ContentAlignment.MiddleLeft
        lblTotal.SetBounds(170, 134, 270, 36)
        lblTotal.Font = Theme.UiFont(16, FontStyle.Bold)
        lblTotal.TextAlign = ContentAlignment.MiddleRight

        lblModeCap.SetBounds(20, 184, 420, 20)
        lblModeCap.Text = "Mode of payment"
        lblModeCap.ForeColor = Theme.TextMuted
        cboMode.SetBounds(20, 206, 420, 28)
        cboMode.DropDownStyle = ComboBoxStyle.DropDownList
        cboMode.Items.AddRange(New Object() {"Cash", "E-Wallet", "Bank Transfer"})
        cboMode.SelectedIndex = 0

        lblTenderedCap.SetBounds(20, 246, 420, 20)
        lblTenderedCap.Text = "Amount given by the student"
        lblTenderedCap.ForeColor = Theme.TextMuted
        nudTendered.SetBounds(20, 268, 420, 28)
        nudTendered.DecimalPlaces = 2
        nudTendered.ThousandsSeparator = True
        nudTendered.Minimum = 0D
        nudTendered.Maximum = 1000000D
        nudTendered.Increment = 50D

        lblRefCap.SetBounds(20, 308, 420, 20)
        lblRefCap.Text = "Reference no. (required for E-Wallet / Bank Transfer)"
        lblRefCap.ForeColor = Theme.TextMuted
        txtRef.SetBounds(20, 330, 420, 28)
        txtRef.MaxLength = 50

        lblChange.SetBounds(20, 372, 420, 32)
        lblChange.Font = Theme.UiFont(12, FontStyle.Bold)
        lblChange.TextAlign = ContentAlignment.MiddleLeft

        btnConfirm.SetBounds(230, 418, 100, 36)
        btnConfirm.Text = "Confirm"
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.FlatAppearance.BorderSize = 0
        btnConfirm.BackColor = Theme.Primary
        btnConfirm.ForeColor = Color.White

        btnCancel.SetBounds(340, 418, 100, 36)
        btnCancel.Text = "Cancel"
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.BorderColor = Theme.Border
        btnCancel.BackColor = Theme.Surface
        btnCancel.ForeColor = Theme.TextMain
        btnCancel.DialogResult = DialogResult.Cancel
        CancelButton = btnCancel

        Controls.AddRange(New Control() {lblRequest, lblSubCap, lblSub, chkRush, lblTotalCap, lblTotal,
                                         lblModeCap, cboMode, lblTenderedCap, nudTendered, lblRefCap, txtRef,
                                         lblChange, btnConfirm, btnCancel})

        AddHandler chkRush.CheckedChanged, AddressOf Recalculate
        AddHandler cboMode.SelectedIndexChanged, AddressOf Recalculate
        AddHandler nudTendered.ValueChanged, AddressOf UpdateChange
        AddHandler btnConfirm.Click, AddressOf Confirm_Click
        Recalculate(Nothing, EventArgs.Empty)
    End Sub

    Private Function TotalDue() As Decimal
        Return _subtotal + If(chkRush.Checked, RequestHelper.RushFee, 0D)
    End Function

    ' Total, input state and change all depend on the rush box and the payment mode
    Private Sub Recalculate(sender As Object, e As EventArgs)
        Dim total As Decimal = TotalDue()
        lblTotal.Text = Peso(total)

        Dim wasCash As Boolean = nudTendered.Enabled
        Dim isCash As Boolean = (cboMode.Text = "Cash")
        nudTendered.Enabled = isCash
        txtRef.Enabled = Not isCash

        If isCash Then
            If Not wasCash Then nudTendered.Value = 0D   ' coming back from a non-cash mode: staff re-enters the cash given
            txtRef.Clear()
        Else
            nudTendered.Value = total                    ' e-wallet / bank transfer pay the exact amount
        End If
        UpdateChange(Nothing, EventArgs.Empty)
    End Sub

    Private Sub UpdateChange(sender As Object, e As EventArgs)
        Dim diff As Decimal = nudTendered.Value - TotalDue()
        If diff < 0D Then
            lblChange.Text = $"Short by {Peso(-diff)}"
            lblChange.ForeColor = Color.Firebrick
        Else
            lblChange.Text = $"Change: {Peso(diff)}"
            lblChange.ForeColor = Theme.TextMain
        End If
    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs)
        Dim total As Decimal = TotalDue()
        Dim tendered As Decimal = nudTendered.Value
        Dim mode As String = cboMode.Text
        Dim refNo As String = txtRef.Text.Trim()

        If tendered < total Then
            MessageBox.Show(Me, "The amount given is less than the total due.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nudTendered.Focus()
            Return
        End If
        If mode <> "Cash" AndAlso refNo.Length < 4 Then
            MessageBox.Show(Me, $"Please enter the {mode} reference number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRef.Focus()
            Return
        End If

        Dim msg As String = $"Are you sure the student really paid {Peso(tendered)} via {mode}?" & vbCrLf & vbCrLf &
                            $"Total due: {Peso(total)}" & If(chkRush.Checked, "  (includes rush fee)", "") & vbCrLf &
                            $"Change to give: {Peso(tendered - total)}"
        If MessageBox.Show(Me, msg, "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return

        _result = New PaymentResult With {
            .Mode = mode, .AmountDue = total, .AmountTendered = tendered,
            .ReferenceNo = refNo, .IsRush = chkRush.Checked}
        DialogResult = DialogResult.OK
    End Sub

End Class
