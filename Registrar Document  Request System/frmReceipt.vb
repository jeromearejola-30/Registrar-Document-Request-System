Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

''' <summary>
''' Official receipt. With a printer: preview window with Print and Save as PDF.
''' Without a printer: a warning, then an offer to save the receipt as a PDF.
''' </summary>
Public Class frmReceipt
    Inherits Form

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Private ReadOnly _requestId As Integer

    Private Class ReceiptData
        Public OrNo, RequestNo, StudentNo, StudentName, CourseYear, Mode, Reference, ReceivedBy As String
        Public PaymentDate As DateTime
        Public RefundedAt As DateTime?
        Public IsRush As Boolean
        Public RushFee, Total, Tendered, Change As Decimal
        Public Items As New DataTable()
    End Class

    Private _d As ReceiptData
    Private _bitmap As Bitmap
    Private ReadOnly picture As New PictureBox()
    Private ReadOnly btnPrint As New Button()
    Private ReadOnly btnPdf As New Button()
    Private ReadOnly btnClose As New Button()

    Private Sub New(requestId As Integer)
        _requestId = requestId
        Text = "Official Receipt"
        StartPosition = FormStartPosition.CenterParent
        ClientSize = New Size(760, 760)
        BackColor = Theme.Background
        Font = Theme.UiFont(10)

        Dim bar As New Panel() With {.Dock = DockStyle.Top, .Height = 52, .BackColor = Theme.Surface}
        For Each b As Button In New Button() {btnPrint, btnPdf, btnClose}
            b.FlatStyle = FlatStyle.Flat
            b.Size = New Size(130, 34)
            b.Top = 9
        Next
        btnPrint.Text = "Print" : btnPrint.Left = 16
        btnPdf.Text = "Save as PDF" : btnPdf.Left = 156
        btnClose.Text = "Close" : btnClose.Left = 296
        For Each b As Button In New Button() {btnPrint, btnPdf}
            b.BackColor = Theme.Primary
            b.ForeColor = Color.White
            b.FlatAppearance.BorderSize = 0
        Next
        btnClose.BackColor = Theme.Surface
        btnClose.ForeColor = Theme.TextMain
        btnClose.FlatAppearance.BorderColor = Theme.Border
        bar.Controls.AddRange(New Control() {btnPrint, btnPdf, btnClose})

        picture.Dock = DockStyle.Fill
        picture.SizeMode = PictureBoxSizeMode.Zoom
        picture.BackColor = Color.FromArgb(120, 120, 120)

        Controls.Add(picture)   ' fill first, then the bar on top
        Controls.Add(bar)

        AddHandler btnPrint.Click, AddressOf Print_Click
        AddHandler btnPdf.Click, Sub(s, e) SavePdf(Me)
        AddHandler btnClose.Click, Sub(s, e) Close()
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        MyBase.OnFormClosed(e)
        picture.Image = Nothing
        If _bitmap IsNot Nothing Then _bitmap.Dispose()
    End Sub

    ' ---------------------------------------------------------------
    ' Entry point used by Record Payment and View Receipt
    ' ---------------------------------------------------------------
    Public Shared Function HasPrinter() As Boolean
        Try
            ' IsValid is False when Windows has no usable default printer
            Dim ps As New PrinterSettings()
            Return ps.IsValid
        Catch
            Return False
        End Try
    End Function

    Public Shared Sub ShowFor(owner As IWin32Window, requestId As Integer)
        Dim f As New frmReceipt(requestId)
        Try
            If Not f.LoadData() Then Return

            If HasPrinter() Then
                f.ShowDialog(owner)
            Else
                MessageBox.Show(owner, "No printer is connected to this computer, so the receipt cannot be printed.",
                                "No Printer Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show(owner, "Do you want to save the receipt as a PDF so you can view it?",
                                   "Save as PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    f.SavePdf(owner)
                End If
            End If
        Finally
            f.Dispose()
        End Try
    End Sub

    ' ---------------------------------------------------------------
    ' Data
    ' ---------------------------------------------------------------
    Private Function LoadData() As Boolean
        Try
            Dim sql As String =
                "SELECT r.RequestNo, r.IsRush, r.RushFee, r.TotalAmount, s.StudentID, " &
                "CONCAT(s.FirstName, ' ', IF(s.MiddleName IS NULL OR s.MiddleName = '', '', CONCAT(LEFT(s.MiddleName, 1), '. ')), s.LastName) AS StudentName, " &
                "CONCAT(s.Course, ' ', s.YearLevel) AS CourseYear, " &
                "p.ORNo, p.PaymentMode, p.AmountTendered, p.ChangeAmount, p.ReferenceNo, p.PaymentDate, p.RefundedAt, u.FullName AS ReceivedBy " &
                "FROM tblrequest r " &
                "JOIN tblstudents s ON s.StudentID = r.StudentID " &
                "JOIN tblpayments p ON p.RequestID = r.RequestID " &
                "JOIN tblusers u ON u.UserID = p.ReceivedBy " &
                "WHERE r.RequestID = @id"
            Dim d As New ReceiptData()
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand(sql, c)
                    cmd.Parameters.AddWithValue("@id", _requestId)
                    Using r As MySqlDataReader = cmd.ExecuteReader()
                        If Not r.Read() Then
                            MessageBox.Show("This request has no payment yet, so there is no receipt.", "No Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return False
                        End If
                        d.OrNo = Convert.ToString(r("ORNo"))
                        d.RequestNo = Convert.ToString(r("RequestNo"))
                        d.StudentNo = Convert.ToString(r("StudentID"))
                        d.StudentName = Convert.ToString(r("StudentName"))
                        d.CourseYear = Convert.ToString(r("CourseYear"))
                        d.Mode = Convert.ToString(r("PaymentMode"))
                        d.Reference = If(IsDBNull(r("ReferenceNo")), "", Convert.ToString(r("ReferenceNo")))
                        d.ReceivedBy = Convert.ToString(r("ReceivedBy"))
                        d.PaymentDate = Convert.ToDateTime(r("PaymentDate"))
                        If Not IsDBNull(r("RefundedAt")) Then d.RefundedAt = Convert.ToDateTime(r("RefundedAt"))
                        d.IsRush = Convert.ToBoolean(r("IsRush"))
                        d.RushFee = Convert.ToDecimal(r("RushFee"))
                        d.Total = Convert.ToDecimal(r("TotalAmount"))
                        d.Tendered = Convert.ToDecimal(r("AmountTendered"))
                        d.Change = Convert.ToDecimal(r("ChangeAmount"))
                    End Using
                End Using
                Using cmd As New MySqlCommand("SELECT dc.DocumentName AS Document, rd.Quantity AS Qty, rd.Amount AS UnitFee, rd.SubTotal " &
                                              "FROM tblrequestdetails rd JOIN tbldocuments dc ON dc.DocumentID = rd.DocumentID WHERE rd.RequestID = @id", c)
                    cmd.Parameters.AddWithValue("@id", _requestId)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(d.Items)
                    End Using
                End Using
            End Using
            _d = d
            _bitmap = RenderBitmap()      ' a picture of the receipt: used for the preview and the PDF
            picture.Image = _bitmap
            Return True
        Catch ex As Exception
            MessageBox.Show("Error loading the receipt: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ---------------------------------------------------------------
    ' Drawing (layout units are 1/100 inch)
    ' ---------------------------------------------------------------
    Private Shared Function Peso(v As Decimal) As String
        Return "₱" & v.ToString("N2")
    End Function

    ''' <summary>Draws the receipt on a 6 x 8 inch page at 200 pixels per inch (no printer involved).</summary>
    Private Function RenderBitmap() As Bitmap
        Dim bmp As New Bitmap(1200, 1600, PixelFormat.Format24bppRgb)
        bmp.SetResolution(100, 100)   ' so that font sizes in points convert like they do for a printer
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
            g.ScaleTransform(2.0F, 2.0F)   ' 1 layout unit (1/100 inch) = 2 pixels
            DrawReceipt(g, New Rectangle(40, 40, 520, 720))
        End Using
        Return bmp
    End Function

    Private Sub DrawReceipt(g As Graphics, bounds As Rectangle)
        If _d Is Nothing Then Return
        Const W As Single = 520.0F
        Dim left As Single = bounds.Left + (bounds.Width - W) / 2.0F
        Dim right As Single = left + W
        Dim y As Single = bounds.Top

        Using fTitle As New Font("Segoe UI", 15, FontStyle.Bold),
              fHead As New Font("Segoe UI", 11, FontStyle.Bold),
              fBody As New Font("Segoe UI", 10),
              fBold As New Font("Segoe UI", 10, FontStyle.Bold),
              fSmall As New Font("Segoe UI", 8.5F),
              pen As New Pen(Color.Black, 1),
              center As New StringFormat() With {.Alignment = StringAlignment.Center},
              far As New StringFormat() With {.Alignment = StringAlignment.Far}

            ' Header
            g.DrawString("LYCEUM OF ALABANG", fTitle, Brushes.Black, New RectangleF(left, y, W, 28), center) : y += 28
            g.DrawString("Registrar's Office", fBody, Brushes.Black, New RectangleF(left, y, W, 20), center) : y += 24
            g.DrawString("OFFICIAL RECEIPT", fHead, Brushes.Black, New RectangleF(left, y, W, 22), center) : y += 28
            If _d.RefundedAt.HasValue Then
                g.DrawString($"REFUNDED on {_d.RefundedAt.Value:MMMM dd, yyyy}", fBold, Brushes.Firebrick, New RectangleF(left, y, W, 22), center) : y += 24
            End If
            g.DrawLine(pen, left, y, right, y) : y += 8

            ' Receipt and student information
            Dim info As String(,) = {
                {"OR No.", _d.OrNo},
                {"Date", _d.PaymentDate.ToString("MMMM dd, yyyy  h:mm tt")},
                {"Request No.", _d.RequestNo},
                {"Student", _d.StudentName},
                {"Student No.", _d.StudentNo},
                {"Course / Year", _d.CourseYear}}
            For i As Integer = 0 To info.GetLength(0) - 1
                g.DrawString(info(i, 0), fBody, Brushes.Black, left, y)
                g.DrawString(info(i, 1), fBold, Brushes.Black, New RectangleF(left + 130, y, W - 130, 20), far)
                y += 22
            Next
            y += 4
            g.DrawLine(pen, left, y, right, y) : y += 6

            ' Items table
            g.DrawString("Document", fBold, Brushes.Black, left, y)
            g.DrawString("Qty", fBold, Brushes.Black, New RectangleF(left + 260, y, 40, 20), far)
            g.DrawString("Unit Fee", fBold, Brushes.Black, New RectangleF(left + 300, y, 100, 20), far)
            g.DrawString("Subtotal", fBold, Brushes.Black, New RectangleF(left + 400, y, 120, 20), far)
            y += 22
            For Each row As DataRow In _d.Items.Rows
                g.DrawString(Convert.ToString(row("Document")), fBody, Brushes.Black, New RectangleF(left, y, 255, 20))
                g.DrawString(Convert.ToString(row("Qty")), fBody, Brushes.Black, New RectangleF(left + 260, y, 40, 20), far)
                g.DrawString(Peso(Convert.ToDecimal(row("UnitFee"))), fBody, Brushes.Black, New RectangleF(left + 300, y, 100, 20), far)
                g.DrawString(Peso(Convert.ToDecimal(row("SubTotal"))), fBody, Brushes.Black, New RectangleF(left + 400, y, 120, 20), far)
                y += 22
            Next
            If _d.IsRush Then
                g.DrawString("Rush / expedite fee", fBody, Brushes.Black, left, y)
                g.DrawString(Peso(_d.RushFee), fBody, Brushes.Black, New RectangleF(left + 400, y, 120, 20), far)
                y += 22
            End If
            g.DrawLine(pen, left, y, right, y) : y += 6
            g.DrawString("TOTAL", fHead, Brushes.Black, left, y)
            g.DrawString(Peso(_d.Total), fHead, Brushes.Black, New RectangleF(left + 300, y, 220, 22), far)
            y += 30

            ' Payment details
            Dim pay As New List(Of String())
            pay.Add(New String() {"Mode of payment", _d.Mode})
            If _d.Reference <> "" Then pay.Add(New String() {"Reference No.", _d.Reference})
            pay.Add(New String() {"Amount given", Peso(_d.Tendered)})
            pay.Add(New String() {"Change", Peso(_d.Change)})
            For Each p As String() In pay
                g.DrawString(p(0), fBody, Brushes.Black, left, y)
                g.DrawString(p(1), fBold, Brushes.Black, New RectangleF(left + 130, y, W - 130, 20), far)
                y += 22
            Next
            y += 24

            ' Staff signatory: the staff member who recorded the payment
            Dim sigW As Single = 230.0F
            Dim sigX As Single = right - sigW
            g.DrawLine(pen, sigX, y + 24, right, y + 24)
            g.DrawString(_d.ReceivedBy, fBold, Brushes.Black, New RectangleF(sigX, y + 28, sigW, 20), center)
            g.DrawString("Processed by (Registrar Staff signature over printed name)", fSmall, Brushes.Black, New RectangleF(sigX - 40, y + 48, sigW + 40, 32), center)
            y += 92

            ' Refund policy note
            Dim policy As String = "REFUND POLICY: After payment, your request stays Pending for 2 to 3 days. This is your time window to cancel and request a refund. " &
                                   "Once the request is Processing, Ready for Release or Released, it can no longer be cancelled or refunded. Please keep this receipt."
            Dim sz As SizeF = g.MeasureString(policy, fSmall, CInt(W - 20))
            g.DrawRectangle(pen, left, y, W, sz.Height + 16)
            g.DrawString(policy, fSmall, Brushes.Black, New RectangleF(left + 10, y + 8, W - 20, sz.Height))
            y += sz.Height + 26

            g.DrawString("This receipt was generated by the Registrar Document Request System.", fSmall, Brushes.Gray, New RectangleF(left, y, W, 18), center)
        End Using
    End Sub

    ' ---------------------------------------------------------------
    ' Print (only touches the printer system when you press the button)
    ' ---------------------------------------------------------------
    Private Sub Print_Click(sender As Object, e As EventArgs)
        If Not HasPrinter() Then
            MessageBox.Show(Me, "No printer is connected to this computer. Use Save as PDF instead.",
                            "No Printer Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            Using doc As New PrintDocument()
                doc.DocumentName = "Receipt " & _d.OrNo
                doc.DefaultPageSettings.Margins = New Margins(50, 50, 50, 50)
                AddHandler doc.PrintPage, Sub(s, pe)
                                              DrawReceipt(pe.Graphics, pe.MarginBounds)
                                              pe.HasMorePages = False
                                          End Sub
                Using dlg As New PrintDialog() With {.Document = doc}
                    If dlg.ShowDialog(Me) = DialogResult.OK Then doc.Print()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(Me, "Could not print: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------------------------------------------------------
    ' Save as PDF (works with or without a printer)
    ' ---------------------------------------------------------------
    Private Sub SavePdf(owner As IWin32Window)
        Using sfd As New SaveFileDialog() With {
            .Title = "Save receipt as PDF", .Filter = "PDF file (*.pdf)|*.pdf", .FileName = $"Receipt_{_d.OrNo}.pdf"}
            If sfd.ShowDialog(owner) <> DialogResult.OK Then Return
            Try
                SimplePdf.SaveImage(_bitmap, sfd.FileName, 432, 576)   ' 6 x 8 inch page
            Catch ex As Exception
                MessageBox.Show(owner, "Could not save the PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            If MessageBox.Show(owner, "Receipt saved as PDF. Open it now?", "Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    Process.Start(New ProcessStartInfo(sfd.FileName) With {.UseShellExecute = True})
                Catch ex As Exception
                    MessageBox.Show(owner, "The PDF was saved but could not be opened automatically:" & vbCrLf & sfd.FileName,
                                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End Using
    End Sub

End Class