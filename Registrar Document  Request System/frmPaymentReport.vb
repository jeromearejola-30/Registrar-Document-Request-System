Imports System.IO
Imports System.Text
Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

''' <summary>
''' Finance-style payment report. Lists Paid requests by Official Receipt (OR) date.
''' Requests that were paid and later cancelled are shown as negative amounts and deducted from the net total.
''' </summary>
Public Class frmPaymentReport

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    ' Totals of the last generated report (used by the labels, Excel and Print)
    Private reportGross As Decimal = 0D
    Private reportCancelled As Decimal = 0D
    Private reportNet As Decimal = 0D
    Private reportUnpaid As Decimal = 0D

    ' Dates the report was actually generated for (the pickers may change afterwards)
    Private reportFrom As DateTime
    Private reportTo As DateTime

    ' Print state
    Private printRowIndex As Integer = 0
    Private printPageNumber As Integer = 0

    Private Sub frmPaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.StyleGrid(dgvReport, "Status")

        ' Default period: January 1 of this year up to today
        dtpDateFrom.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtpDateTo.Value = DateTime.Now

        GenerateReport()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateReport()
    End Sub

    ' ---------------------------------------------------------------
    ' Report
    ' ---------------------------------------------------------------
    Private Sub GenerateReport()
        If dtpDateFrom.Value.Date > dtpDateTo.Value.Date Then
            MessageBox.Show("'Payment Date From' cannot be later than 'Payment Date To'.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Payment date = OR date (older rows without one fall back to the request date).
            ' A cancelled request that was paid keeps its row, but its amount is negative.
            Dim query As String =
                "SELECT r.ORNo AS ORNo, COALESCE(r.ORDate, DATE(r.RequestDate)) AS PaidOn, r.RequestNo AS RequestNo, " &
                "       CONCAT(s.FirstName, ' ', s.LastName) AS Student, " &
                "       (SELECT GROUP_CONCAT(d.DocumentName SEPARATOR ', ') FROM tblrequestdetails rd " &
                "        JOIN tbldocuments d ON d.DocumentID = rd.DocumentID WHERE rd.RequestID = r.RequestID) AS Document, " &
                "       r.Status AS Status, " &
                "       IF(r.Status = 'Cancelled', -r.TotalAmount, r.TotalAmount) AS Amount " &
                "FROM tblrequest r LEFT JOIN tblstudents s ON s.StudentID = r.StudentID " &
                "WHERE r.PaymentStatus = 'Paid' AND COALESCE(r.ORDate, DATE(r.RequestDate)) BETWEEN @dateFrom AND @dateTo " &
                "ORDER BY PaidOn DESC, r.ORNo DESC"

            Dim unpaidQuery As String =
                "SELECT COALESCE(SUM(TotalAmount), 0) FROM tblrequest " &
                "WHERE PaymentStatus = 'Unpaid' AND Status <> 'Cancelled' AND DATE(RequestDate) BETWEEN @dateFrom AND @dateTo"

            Dim dt As New DataTable()
            Dim unpaid As Decimal
            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@dateFrom", dtpDateFrom.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@dateTo", dtpDateTo.Value.ToString("yyyy-MM-dd"))
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
                Using cmd As New MySqlCommand(unpaidQuery, c)
                    cmd.Parameters.AddWithValue("@dateFrom", dtpDateFrom.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@dateTo", dtpDateTo.Value.ToString("yyyy-MM-dd"))
                    unpaid = Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using

            reportFrom = dtpDateFrom.Value.Date
            reportTo = dtpDateTo.Value.Date

            dgvReport.DataSource = dt
            CalculateTotals(dt, unpaid)
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Friendly headers and widths; runs after every bind so they always survive a reload
    Private Sub dgvReport_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvReport.DataBindingComplete
        With dgvReport
            If Not .Columns.Contains("ORNo") Then Return

            SetColumn("ORNo", "OR No.", 14)
            SetColumn("PaidOn", "OR Date", 12)
            SetColumn("RequestNo", "Request No.", 16)
            SetColumn("Student", "Student", 17)
            SetColumn("Document", "Document", 19)
            SetColumn("Status", "Status", 14)
            SetColumn("Amount", "Amount (₱)", 14)

            .Columns("PaidOn").DefaultCellStyle.Format = "MM/dd/yyyy"
            .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Money is written as 1,200.00 and cancelled (deducted) amounts as (1,200.00)
            .Columns("Amount").DefaultCellStyle.Format = MoneyFormat
            .Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Amount").DefaultCellStyle.Padding = New Padding(0, 0, 16, 0)
            .Columns("Amount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Amount").HeaderCell.Style.Padding = New Padding(0, 0, 16, 0)

            .ClearSelection()
        End With
    End Sub

    Private Const MoneyFormat As String = "#,##0.00;(#,##0.00)"

    Private Sub SetColumn(name As String, header As String, weight As Single)
        If Not dgvReport.Columns.Contains(name) Then Return
        dgvReport.Columns(name).HeaderText = header
        dgvReport.Columns(name).FillWeight = weight
    End Sub

    ' Deducted (cancelled) rows are red
    Private Sub dgvReport_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvReport.CellFormatting
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
        If dgvReport.Columns(e.ColumnIndex).Name <> "Amount" Then Return
        If e.Value IsNot Nothing AndAlso Not IsDBNull(e.Value) AndAlso Convert.ToDecimal(e.Value) < 0D Then
            e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28)
        End If
    End Sub

    Private Sub CalculateTotals(dt As DataTable, unpaid As Decimal)
        Dim kept As Decimal = 0D        ' paid and still valid
        Dim deducted As Decimal = 0D    ' paid, then cancelled

        For Each row As DataRow In dt.Rows
            If IsDBNull(row("Amount")) Then Continue For
            Dim amount As Decimal = Convert.ToDecimal(row("Amount"))
            If amount < 0D Then deducted += -amount Else kept += amount
        Next

        reportGross = kept + deducted
        reportCancelled = deducted
        reportNet = reportGross - reportCancelled
        reportUnpaid = unpaid

        lblGross.Text = "₱ " & reportGross.ToString("N2")
        lblCancelled.Text = If(reportCancelled > 0D, "- ₱ ", "₱ ") & reportCancelled.ToString("N2")
        lblNet.Text = "₱ " & reportNet.ToString("N2")
        lblUnpaid.Text = "₱ " & reportUnpaid.ToString("N2")
    End Sub

    Private Function PeriodText() As String
        Return $"Period: {reportFrom:MM/dd/yyyy} to {reportTo:MM/dd/yyyy}"
    End Function

    Private Shared Function Money(value As Decimal) As String
        Return value.ToString(MoneyFormat)
    End Function

    ' ---------------------------------------------------------------
    ' Export CSV
    ' ---------------------------------------------------------------
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV File (*.csv)|*.csv"
            sfd.FileName = "PaymentReport_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"
            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Try
                Dim sb As New StringBuilder()
                sb.AppendLine(String.Join(",", dgvReport.Columns.Cast(Of DataGridViewColumn)().Select(Function(c) """" & c.HeaderText & """")))

                For Each row As DataGridViewRow In dgvReport.Rows
                    If row.IsNewRow Then Continue For
                    Dim cells As New List(Of String)()
                    For Each cell As DataGridViewCell In row.Cells
                        Dim text As String
                        Select Case dgvReport.Columns(cell.ColumnIndex).Name
                            Case "PaidOn" : text = Convert.ToDateTime(cell.Value).ToString("yyyy-MM-dd")
                            Case "Amount" : text = Convert.ToDecimal(cell.Value).ToString("0.00")   ' plain number, negative when deducted
                            Case Else : text = Convert.ToString(cell.Value)
                        End Select
                        cells.Add("""" & text.Replace("""", """""") & """")
                    Next
                    sb.AppendLine(String.Join(",", cells))
                Next

                File.WriteAllText(sfd.FileName, sb.ToString(), New UTF8Encoding(True))
                MessageBox.Show("CSV exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Could not save the file: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ---------------------------------------------------------------
    ' Export Excel
    ' ---------------------------------------------------------------
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            sfd.FileName = "PaymentReport_" & DateTime.Now.ToString("yyyyMMdd") & ".xlsx"
            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Try
                Using wb As New XLWorkbook()
                    Dim ws As IXLWorksheet = wb.Worksheets.Add("Payment Report")
                    Dim lastCol As Integer = 7

                    ws.Cell(1, 1).Value = "Lyceum of Alabang - Payment Report"
                    ws.Cell(1, 1).Style.Font.Bold = True
                    ws.Cell(1, 1).Style.Font.FontSize = 14
                    ws.Cell(2, 1).Value = PeriodText() & "   |   Based on Official Receipt date"
                    ws.Cell(2, 1).Style.Font.FontColor = XLColor.FromHtml("#6B7280")

                    Dim headerRow As Integer = 4
                    For i As Integer = 0 To lastCol - 1
                        ws.Cell(headerRow, i + 1).Value = dgvReport.Columns(i).HeaderText
                    Next
                    Dim head As IXLRange = ws.Range(headerRow, 1, headerRow, lastCol)
                    head.Style.Fill.BackgroundColor = XLColor.FromHtml("#1B4332")
                    head.Style.Font.FontColor = XLColor.White
                    head.Style.Font.Bold = True
                    ws.Cell(headerRow, lastCol).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right

                    Dim r As Integer = headerRow
                    For Each row As DataGridViewRow In dgvReport.Rows
                        If row.IsNewRow Then Continue For
                        r += 1
                        ws.Cell(r, 1).Value = Convert.ToString(row.Cells("ORNo").Value)
                        ws.Cell(r, 2).Value = Convert.ToDateTime(row.Cells("PaidOn").Value)
                        ws.Cell(r, 2).Style.DateFormat.Format = "mm/dd/yyyy"
                        ws.Cell(r, 3).Value = Convert.ToString(row.Cells("RequestNo").Value)
                        ws.Cell(r, 4).Value = Convert.ToString(row.Cells("Student").Value)
                        ws.Cell(r, 5).Value = Convert.ToString(row.Cells("Document").Value)
                        ws.Cell(r, 6).Value = Convert.ToString(row.Cells("Status").Value)
                        Dim amount As Decimal = Convert.ToDecimal(row.Cells("Amount").Value)
                        ws.Cell(r, 7).Value = CDbl(amount)
                        If amount < 0D Then ws.Range(r, 1, r, lastCol).Style.Font.FontColor = XLColor.FromHtml("#B91C1C")
                    Next
                    Dim lastData As Integer = r
                    ws.Range(headerRow + 1, lastCol, lastData, lastCol).Style.NumberFormat.Format = "#,##0.00;(#,##0.00)"

                    ' Totals
                    r += 2
                    ws.Cell(r, 6).Value = "Gross collections"
                    ws.Cell(r, 7).Value = CDbl(reportGross)
                    ws.Cell(r + 1, 6).Value = "Less: cancelled (paid)"
                    ws.Cell(r + 1, 7).Value = -CDbl(reportCancelled)
                    ws.Cell(r + 2, 6).Value = "Net collections"
                    ws.Cell(r + 2, 7).Value = CDbl(reportNet)
                    ws.Cell(r + 3, 6).Value = "Unpaid (not yet collected)"
                    ws.Cell(r + 3, 7).Value = CDbl(reportUnpaid)
                    ws.Range(r, 7, r + 3, 7).Style.NumberFormat.Format = "#,##0.00;(#,##0.00)"
                    ws.Range(r + 2, 6, r + 2, 7).Style.Font.Bold = True

                    ws.Columns(1, lastCol).AdjustToContents(headerRow, lastData)
                    ws.SheetView.FreezeRows(headerRow)

                    wb.SaveAs(sfd.FileName)
                End Using
                MessageBox.Show("Excel file exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As IOException
                MessageBox.Show("Could not save the file. If it is open in Excel, close it and try again." & vbCrLf & vbCrLf & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Could not save the file: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ---------------------------------------------------------------
    ' Print
    ' ---------------------------------------------------------------
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        printRowIndex = 0
        printPageNumber = 0

        Using printDoc As New Printing.PrintDocument()
            printDoc.DefaultPageSettings.Landscape = True
            AddHandler printDoc.PrintPage, AddressOf PrintReportPage
            Using preview As New PrintPreviewDialog()
                preview.Document = printDoc
                preview.WindowState = FormWindowState.Maximized
                preview.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub PrintReportPage(sender As Object, e As Printing.PrintPageEventArgs)
        printPageNumber += 1

        Using fontTitle As New Font("Segoe UI", 16, FontStyle.Bold),
              fontHead As New Font("Segoe UI", 10, FontStyle.Bold),
              fontBody As New Font("Segoe UI", 10, FontStyle.Regular),
              fontSmall As New Font("Segoe UI", 8.5F, FontStyle.Regular)

            Dim m As Rectangle = e.MarginBounds
            Dim y As Single = m.Top
            Dim rowH As Single = fontBody.GetHeight(e.Graphics) + 8

            e.Graphics.DrawString("Lyceum of Alabang - Payment Report", fontTitle, Brushes.Black, m.Left, y)
            y += fontTitle.GetHeight(e.Graphics) + 4
            e.Graphics.DrawString(PeriodText() & "   |   Based on Official Receipt date", fontSmall, Brushes.DimGray, m.Left, y)
            y += fontSmall.GetHeight(e.Graphics) + 12

            ' Column x-positions as fractions of the printable width (the last column is right-aligned)
            Dim fr As Single() = {0, 0.11, 0.2, 0.34, 0.52, 0.76, 0.86, 1.0}
            Dim titles As String() = {"OR No.", "OR Date", "Request No.", "Student", "Document", "Status", "Amount"}
            For i As Integer = 0 To 6
                DrawCell(e.Graphics, titles(i), fontHead, Brushes.Black, m, fr, i, y, rowH)
            Next
            y += rowH
            e.Graphics.DrawLine(Pens.Black, m.Left, y - 3, m.Right, y - 3)

            Dim footerReserve As Single = rowH * 6
            While printRowIndex < dgvReport.Rows.Count
                Dim row As DataGridViewRow = dgvReport.Rows(printRowIndex)
                If Not row.IsNewRow Then
                    If y + rowH > m.Bottom - rowH Then Exit While   ' page is full

                    Dim amount As Decimal = Convert.ToDecimal(row.Cells("Amount").Value)
                    Dim texts As String() = {
                        Convert.ToString(row.Cells("ORNo").Value),
                        Convert.ToDateTime(row.Cells("PaidOn").Value).ToString("MM/dd/yyyy"),
                        Convert.ToString(row.Cells("RequestNo").Value),
                        Convert.ToString(row.Cells("Student").Value),
                        Convert.ToString(row.Cells("Document").Value),
                        Convert.ToString(row.Cells("Status").Value),
                        Money(amount)}
                    Dim brush As Brush = If(amount < 0D, Brushes.Firebrick, Brushes.Black)
                    For i As Integer = 0 To 6
                        DrawCell(e.Graphics, texts(i), fontBody, brush, m, fr, i, y, rowH)
                    Next
                    y += rowH
                End If
                printRowIndex += 1
            End While

            e.Graphics.DrawString("Page " & printPageNumber, fontSmall, Brushes.DimGray, m.Right - 50, m.Bottom)

            If printRowIndex < dgvReport.Rows.Count Then
                e.HasMorePages = True
                Return
            End If

            If y + footerReserve > m.Bottom Then
                e.HasMorePages = True   ' totals do not fit here; put them on a fresh page
                printRowIndex = dgvReport.Rows.Count
                Return
            End If

            y += 6
            e.Graphics.DrawLine(Pens.Black, m.Left, y, m.Right, y)
            y += 8
            Dim tx As Single = m.Left + m.Width * 0.62F
            e.Graphics.DrawString("Gross collections: ₱ " & reportGross.ToString("N2"), fontHead, Brushes.Black, tx, y)
            y += rowH
            e.Graphics.DrawString("Less: cancelled (paid): - ₱ " & reportCancelled.ToString("N2"), fontHead, Brushes.Firebrick, tx, y)
            y += rowH
            e.Graphics.DrawString("Net collections: ₱ " & reportNet.ToString("N2"), fontHead, Brushes.Black, tx, y)
            y += rowH
            e.Graphics.DrawString("Unpaid (not yet collected): ₱ " & reportUnpaid.ToString("N2"), fontBody, Brushes.DimGray, tx, y)
            e.HasMorePages = False
        End Using
    End Sub

    Private Shared Sub DrawCell(g As Graphics, text As String, font As Font, brush As Brush, m As Rectangle, fr As Single(), i As Integer, y As Single, rowH As Single)
        Dim x As Single = m.Left + m.Width * fr(i)
        Dim w As Single = m.Width * (fr(i + 1) - fr(i)) - If(i = 6, 0, 6)
        Using fmt As New StringFormat() With {.Trimming = StringTrimming.EllipsisCharacter, .FormatFlags = StringFormatFlags.NoWrap}
            If i = 6 Then fmt.Alignment = StringAlignment.Far   ' amounts line up on the right
            g.DrawString(text, font, brush, New RectangleF(x, y, w, rowH), fmt)
        End Using
    End Sub

End Class
