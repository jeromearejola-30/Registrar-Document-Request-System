Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class frmReport

    ' Database Connection String
    Dim connStr As String = "server=localhost;user=root;password=;database=registrar_db"
    Dim conn As New MySqlConnection(connStr)

    Private Sub frmGenerateReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Table Grid
        dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReport.RowHeadersVisible = False
        dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReport.ReadOnly = True

        ' Set Default Date Ranges
        dtpDateFrom.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtpDateTo.Value = DateTime.Now

        ' Populate Status Dropdown
        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(New String() {"All Statuses", "Pending", "Processing", "Ready for Release", "Released", "Cancelled"})
        cboStatus.SelectedIndex = 0

        ' Populate Document Types Dropdown
        LoadDocumentTypes()

        ' Load Report Data
        GenerateReport()
    End Sub

    ' Populate Document Types
    Private Sub LoadDocumentTypes()
        Try
            cboDocumentType.Items.Clear()
            cboDocumentType.Items.Add("All Types")

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DocumentName FROM tbldocuments ORDER BY DocumentName ASC", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cboDocumentType.Items.Add(reader("DocumentName").ToString())
            End While

            reader.Close()
            conn.Close()

            cboDocumentType.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error loading document types: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Click Generate Button
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateReport()
    End Sub

    ' Main Query Generator
    Private Sub GenerateReport()
        Try
            conn.Open()

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

            If cboStatus.Text <> "All Statuses" Then
                query &= " AND r.Status = @status "
            End If

            If cboDocumentType.Text <> "All Types" Then
                query &= " AND d.DocumentName = @docType "
            End If

            query &= " GROUP BY r.RequestID ORDER BY r.RequestDate DESC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@dateFrom", dtpDateFrom.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@dateTo", dtpDateTo.Value.ToString("yyyy-MM-dd"))

            If cboStatus.Text <> "All Statuses" Then cmd.Parameters.AddWithValue("@status", cboStatus.Text)
            If cboDocumentType.Text <> "All Types" Then cmd.Parameters.AddWithValue("@docType", cboDocumentType.Text)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvReport.DataSource = dt
            conn.Close()

            ' Calculate Summary Totals
            CalculateSummaryTotals(dt)

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Update Summary Labels
    Private Sub CalculateSummaryTotals(dt As DataTable)
        Dim subtotal As Decimal = 0.00
        Dim taxFees As Decimal = 0.00

        For Each row As DataRow In dt.Rows
            If Not IsDBNull(row("Amount")) Then
                subtotal += Convert.ToDecimal(row("Amount"))
            End If
        Next

        Dim grandTotal As Decimal = subtotal + taxFees

        lblSubtotal.Text = "Subtotal: " & subtotal.ToString("N2")
        lblTaxFees.Text = "Tax/Fees: " & taxFees.ToString("N2")
        lblTotal.Text = "Total: " & grandTotal.ToString("N2")
    End Sub

    ' Export CSV
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File (*.csv)|*.csv"
        sfd.FileName = "Report_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim sb As New StringBuilder()

            Dim headers = dgvReport.Columns.Cast(Of DataGridViewColumn)().Select(Function(c) """" & c.HeaderText & """")
            sb.AppendLine(String.Join(",", headers))

            For Each row As DataGridViewRow In dgvReport.Rows
                If Not row.IsNewRow Then
                    Dim cells = row.Cells.Cast(Of DataGridViewCell)().Select(Function(c) """" & c.Value.ToString().Replace("""", """""") & """")
                    sb.AppendLine(String.Join(",", cells))
                End If
            Next

            File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)
            MessageBox.Show("CSV Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Export Excel
    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel Workbook (*.xls)|*.xls"
        sfd.FileName = "Report_" & DateTime.Now.ToString("yyyyMMdd") & ".xls"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim sb As New StringBuilder()

            For i As Integer = 0 To dgvReport.Columns.Count - 1
                sb.Append(dgvReport.Columns(i).HeaderText & vbTab)
            Next
            sb.AppendLine()

            For Each row As DataGridViewRow In dgvReport.Rows
                If Not row.IsNewRow Then
                    For i As Integer = 0 To dgvReport.Columns.Count - 1
                        sb.Append(row.Cells(i).Value.ToString() & vbTab)
                    Next
                    sb.AppendLine()
                End If
            Next

            File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)
            MessageBox.Show("Excel File Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Print Button
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim printDoc As New Printing.PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintReportPage

        Dim printPreview As New PrintPreviewDialog()
        printPreview.Document = printDoc
        printPreview.ShowDialog()
    End Sub

    ' Printable Document Layout
    Private Sub PrintReportPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim fontHeader As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSubHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 10, FontStyle.Regular)

        Dim startX As Integer = 50
        Dim startY As Integer = 50

        e.Graphics.DrawString("Document Requests Summary Report", fontHeader, Brushes.Black, startX, startY)
        startY += 35
        e.Graphics.DrawString($"Period: {dtpDateFrom.Value:MM/dd/yyyy} to {dtpDateTo.Value:MM/dd/yyyy}", fontSubHeader, Brushes.Black, startX, startY)
        startY += 30

        ' Column Headers
        e.Graphics.DrawString("Request ID", fontSubHeader, Brushes.Black, startX, startY)
        e.Graphics.DrawString("Student", fontSubHeader, Brushes.Black, startX + 130, startY)
        e.Graphics.DrawString("Document Types", fontSubHeader, Brushes.Black, startX + 300, startY)
        e.Graphics.DrawString("Status", fontSubHeader, Brushes.Black, startX + 500, startY)
        e.Graphics.DrawString("Amount", fontSubHeader, Brushes.Black, startX + 630, startY)

        startY += 20
        e.Graphics.DrawLine(Pens.Black, startX, startY, startX + 700, startY)
        startY += 10

        ' Rows Data
        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then
                e.Graphics.DrawString(row.Cells("Request ID").Value.ToString(), fontBody, Brushes.Black, startX, startY)
                e.Graphics.DrawString(row.Cells("Student").Value.ToString(), fontBody, Brushes.Black, startX + 130, startY)
                e.Graphics.DrawString(row.Cells("Document Types").Value.ToString(), fontBody, Brushes.Black, startX + 300, startY)
                e.Graphics.DrawString(row.Cells("Status").Value.ToString(), fontBody, Brushes.Black, startX + 500, startY)
                e.Graphics.DrawString(Convert.ToDecimal(row.Cells("Amount").Value).ToString("N2"), fontBody, Brushes.Black, startX + 630, startY)
                startY += 25
            End If
        Next

        startY += 10
        e.Graphics.DrawLine(Pens.Black, startX, startY, startX + 700, startY)
        startY += 15

        ' Summary Totals Print Alignment
        e.Graphics.DrawString(lblSubtotal.Text, fontSubHeader, Brushes.Black, startX + 500, startY)
        startY += 20
        e.Graphics.DrawString(lblTaxFees.Text, fontSubHeader, Brushes.Black, startX + 500, startY)
        startY += 20
        e.Graphics.DrawString(lblTotal.Text, fontSubHeader, Brushes.Black, startX + 500, startY)
    End Sub

End Class