Imports System.IO
Imports System.Text
Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

Public Class frmReport

    Private ReadOnly connStr As String = "server=localhost;user=root;password=;database=registrar_db"

    ' Totals of the last generated report (used by the labels and by Print)
    Private reportSubtotal As Decimal = 0D
    Private reportTaxFees As Decimal = 0D
    Private reportTotal As Decimal = 0D

    ' Print state
    Private printRowIndex As Integer = 0
    Private printPageNumber As Integer = 0

    Private Sub frmGenerateReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.StyleGrid(dgvReport, "Status")

        ' Default date range: January 1 of this year up to today
        dtpDateFrom.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtpDateTo.Value = DateTime.Now

        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(New String() {"All Statuses", "Pending", "Processing", "Ready for Release", "Released", "Cancelled"})
        cboStatus.SelectedIndex = 0

        LoadDocumentTypes()
        GenerateReport()
    End Sub

    Private Sub LoadDocumentTypes()
        Try
            cboDocumentType.Items.Clear()
            cboDocumentType.Items.Add("All Types")

            Using c As New MySqlConnection(connStr)
                c.Open()
                Using cmd As New MySqlCommand("SELECT DocumentName FROM tbldocuments ORDER BY DocumentName ASC", c)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cboDocumentType.Items.Add(reader("DocumentName").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading document types: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cboDocumentType.SelectedIndex = 0
        End Try
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateReport()
    End Sub

    Private Sub GenerateReport()
        If dtpDateFrom.Value.Date > dtpDateTo.Value.Date Then
            MessageBox.Show("'Date From' cannot be later than 'Date To'.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query As String = "SELECT r.RequestNo AS `Request ID`, " &
                                  "CONCAT(s.FirstName, ' ', s.LastName) AS `Student`, " &
                                  "GROUP_CONCAT(d.DocumentName SEPARATOR ', ') AS `Document Types`, " &
                                  "r.Status AS `Status`, " &
                                  "r.TotalAmount AS `Amount` " &
                                  "FROM tblrequest r " &
                                  "INNER JOIN tblstudents s ON r.StudentID = s.StudentID " &
                                  "INNER JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID " &
                                  "INNER JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                                  "WHERE DATE(r.RequestDate) BETWEEN @dateFrom AND @dateTo "

            If cboStatus.Text <> "All Statuses" Then query &= " AND r.Status = @status "
            If cboDocumentType.Text <> "All Types" Then query &= " AND d.DocumentName = @docType "

            query &= " GROUP BY r.RequestID ORDER BY r.RequestDate DESC"

            Dim dt As New DataTable()
            Using c As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@dateFrom", dtpDateFrom.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@dateTo", dtpDateTo.Value.ToString("yyyy-MM-dd"))
                    If cboStatus.Text <> "All Statuses" Then cmd.Parameters.AddWithValue("@status", cboStatus.Text)
                    If cboDocumentType.Text <> "All Types" Then cmd.Parameters.AddWithValue("@docType", cboDocumentType.Text)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            dgvReport.DataSource = dt
            FormatColumns()
            CalculateSummaryTotals(dt)
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatColumns()
        With dgvReport
            If Not .Columns.Contains("Request ID") Then Return
            .Columns("Request ID").FillWeight = 22
            .Columns("Student").FillWeight = 24
            .Columns("Document Types").FillWeight = 28
            .Columns("Status").FillWeight = 14
            .Columns("Amount").FillWeight = 14
            .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Amount").HeaderText = "Amount (₱)"
            .Columns("Amount").DefaultCellStyle.Format = "N2"
            .Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Amount").DefaultCellStyle.Padding = New Padding(0, 0, 16, 0)
            .Columns("Amount").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Amount").HeaderCell.Style.Padding = New Padding(0, 0, 16, 0)
        End With
    End Sub

    Private Sub CalculateSummaryTotals(dt As DataTable)
        reportSubtotal = 0D
        reportTaxFees = 0D

        For Each row As DataRow In dt.Rows
            If Not IsDBNull(row("Amount")) Then reportSubtotal += Convert.ToDecimal(row("Amount"))
        Next
        reportTotal = reportSubtotal + reportTaxFees

        lblSubtotal.Text = "₱ " & reportSubtotal.ToString("N2")
        lblTaxFees.Text = "₱ " & reportTaxFees.ToString("N2")
        lblTotal.Text = "₱ " & reportTotal.ToString("N2")
    End Sub

    ' ---- Export CSV ----
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV File (*.csv)|*.csv"
            sfd.FileName = "Report_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"
            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Try
                Dim sb As New StringBuilder()
                Dim headers = dgvReport.Columns.Cast(Of DataGridViewColumn)().Select(Function(c) """" & c.HeaderText & """")
                sb.AppendLine(String.Join(",", headers))

                For Each row As DataGridViewRow In dgvReport.Rows
                    If Not row.IsNewRow Then
                        Dim cells = row.Cells.Cast(Of DataGridViewCell)().Select(Function(c) """" & Convert.ToString(c.Value).Replace("""", """""") & """")
                        sb.AppendLine(String.Join(",", cells))
                    End If
                Next

                File.WriteAllText(sfd.FileName, sb.ToString(), New UTF8Encoding(True))
                MessageBox.Show("CSV exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Could not save the file: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ---- Export Excel (a real .xlsx workbook, made with ClosedXML) ----
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            sfd.FileName = "Report_" & DateTime.Now.ToString("yyyyMMdd") & ".xlsx"
            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Try
                Using wb As New XLWorkbook()
                    Dim ws As IXLWorksheet = wb.Worksheets.Add("Requests Report")
                    Dim lastCol As Integer = 5

                    ws.Cell(1, 1).Value = "Lyceum of Alabang - Document Requests Report"
                    ws.Cell(1, 1).Style.Font.Bold = True
                    ws.Cell(1, 1).Style.Font.FontSize = 14
                    ws.Cell(2, 1).Value = $"Period: {dtpDateFrom.Value:MM/dd/yyyy} to {dtpDateTo.Value:MM/dd/yyyy}   |   Status: {cboStatus.Text}   |   Document: {cboDocumentType.Text}"
                    ws.Cell(2, 1).Style.Font.FontColor = XLColor.FromHtml("#6B7280")

                    ' Header row: forest green with white text, like the grid
                    Dim headerRow As Integer = 4
                    For i As Integer = 0 To lastCol - 1
                        ws.Cell(headerRow, i + 1).Value = dgvReport.Columns(i).HeaderText
                    Next
                    Dim head As IXLRange = ws.Range(headerRow, 1, headerRow, lastCol)
                    head.Style.Fill.BackgroundColor = XLColor.FromHtml("#1B4332")
                    head.Style.Font.FontColor = XLColor.White
                    head.Style.Font.Bold = True
                    ws.Cell(headerRow, lastCol).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right

                    ' Data rows: Amount is written as a number, so Excel can add it up
                    Dim r As Integer = headerRow
                    For Each row As DataGridViewRow In dgvReport.Rows
                        If row.IsNewRow Then Continue For
                        r += 1
                        ws.Cell(r, 1).Value = Convert.ToString(row.Cells("Request ID").Value)
                        ws.Cell(r, 2).Value = Convert.ToString(row.Cells("Student").Value)
                        ws.Cell(r, 3).Value = Convert.ToString(row.Cells("Document Types").Value)
                        ws.Cell(r, 4).Value = Convert.ToString(row.Cells("Status").Value)
                        Dim amount As Decimal = 0D
                        If row.Cells("Amount").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("Amount").Value) Then
                            amount = Convert.ToDecimal(row.Cells("Amount").Value)
                        End If
                        ws.Cell(r, 5).Value = CDbl(amount)
                    Next
                    Dim lastData As Integer = r
                    ws.Range(headerRow + 1, lastCol, lastData, lastCol).Style.NumberFormat.Format = "#,##0.00"

                    ' Totals
                    r += 2
                    ws.Cell(r, 4).Value = "Subtotal"
                    ws.Cell(r, 5).Value = CDbl(reportSubtotal)
                    ws.Cell(r + 1, 4).Value = "Tax / Fees"
                    ws.Cell(r + 1, 5).Value = CDbl(reportTaxFees)
                    ws.Cell(r + 2, 4).Value = "Total"
                    ws.Cell(r + 2, 5).Value = CDbl(reportTotal)
                    ws.Range(r, 4, r + 2, 4).Style.Font.Bold = True
                    ws.Cell(r + 2, 5).Style.Font.Bold = True
                    ws.Range(r, 5, r + 2, 5).Style.NumberFormat.Format = "#,##0.00"

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

    ' ---- Print ----
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        printRowIndex = 0
        printPageNumber = 0

        Using printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintReportPage
            Using preview As New PrintPreviewDialog()
                preview.Document = printDoc
                preview.WindowState = FormWindowState.Maximized
                preview.ShowDialog()

            End Using
        End Using
    End Sub

    ' Prints as many rows as fit on the page, then asks for another page; columns scale to the page width
    Private Sub PrintReportPage(sender As Object, e As Printing.PrintPageEventArgs)
        printPageNumber += 1

        Using fontTitle As New Font("Segoe UI", 16, FontStyle.Bold),
              fontHead As New Font("Segoe UI", 10, FontStyle.Bold),
              fontBody As New Font("Segoe UI", 10, FontStyle.Regular),
              fontSmall As New Font("Segoe UI", 8.5F, FontStyle.Regular)

            Dim m As Rectangle = e.MarginBounds
            Dim y As Single = m.Top
            Dim rowH As Single = fontBody.GetHeight(e.Graphics) + 8

            e.Graphics.DrawString("Lyceum of Alabang - Document Requests Report", fontTitle, Brushes.Black, m.Left, y)
            y += fontTitle.GetHeight(e.Graphics) + 4
            e.Graphics.DrawString($"Period: {dtpDateFrom.Value:MM/dd/yyyy} to {dtpDateTo.Value:MM/dd/yyyy}   |   Status: {cboStatus.Text}   |   Document: {cboDocumentType.Text}",
                                  fontSmall, Brushes.DimGray, m.Left, y)
            y += fontSmall.GetHeight(e.Graphics) + 12

            ' Column x-positions as fractions of the printable width
            Dim fr As Single() = {0, 0.2, 0.42, 0.7, 0.84}
            Dim titles As String() = {"Request ID", "Student", "Document Types", "Status", "Amount"}
            For i As Integer = 0 To 4
                e.Graphics.DrawString(titles(i), fontHead, Brushes.Black, m.Left + m.Width * fr(i), y)
            Next
            y += rowH
            e.Graphics.DrawLine(Pens.Black, m.Left, y - 3, m.Right, y - 3)

            Dim footerReserve As Single = rowH * 5   ' room for the totals on the last page
            While printRowIndex < dgvReport.Rows.Count
                Dim row As DataGridViewRow = dgvReport.Rows(printRowIndex)
                If Not row.IsNewRow Then
                    If y + rowH > m.Bottom - rowH Then Exit While   ' page is full

                    Dim texts As String() = {
                        Convert.ToString(row.Cells("Request ID").Value),
                        Convert.ToString(row.Cells("Student").Value),
                        Convert.ToString(row.Cells("Document Types").Value),
                        Convert.ToString(row.Cells("Status").Value),
                        Convert.ToDecimal(row.Cells("Amount").Value).ToString("N2")}
                    For i As Integer = 0 To 4
                        Dim w As Single = If(i = 4, m.Width * (1 - fr(4)), m.Width * (fr(i + 1) - fr(i)) - 6)
                        Dim cell As New RectangleF(m.Left + m.Width * fr(i), y, w, rowH)
                        Using fmt As New StringFormat() With {.Trimming = StringTrimming.EllipsisCharacter, .FormatFlags = StringFormatFlags.NoWrap}
                            e.Graphics.DrawString(texts(i), fontBody, Brushes.Black, cell, fmt)
                        End Using
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

            ' Last page: totals
            If y + footerReserve > m.Bottom Then
                e.HasMorePages = True   ' totals do not fit here; put them on a fresh page
                printRowIndex = dgvReport.Rows.Count
                Return
            End If
            y += 6
            e.Graphics.DrawLine(Pens.Black, m.Left, y, m.Right, y)
            y += 8
            Dim tx As Single = m.Left + m.Width * 0.6F
            e.Graphics.DrawString("Subtotal: ₱ " & reportSubtotal.ToString("N2"), fontHead, Brushes.Black, tx, y)
            y += rowH
            e.Graphics.DrawString("Tax / Fees: ₱ " & reportTaxFees.ToString("N2"), fontHead, Brushes.Black, tx, y)
            y += rowH
            e.Graphics.DrawString("Total: ₱ " & reportTotal.ToString("N2"), fontHead, Brushes.Black, tx, y)
            e.HasMorePages = False
        End Using
    End Sub

End Class
