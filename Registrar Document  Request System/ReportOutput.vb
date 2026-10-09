Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Drawing.Text

''' <summary>
''' Shared "Print" behaviour for reports: asks the purpose, then previews (printer present)
''' or offers a PDF (no printer). Also draws the purpose line and the signatory block.
''' </summary>
Public Module ReportOutput

    ' Filled in by Run, read by the report's page-drawing code
    Public Property Purpose As String = ""
    Public Property PreparedBy As String = ""
    Public Property PreparedRole As String = ""
    Public Property GeneratedAt As DateTime = DateTime.Now

    ''' <param name="reset">Sets the report's page counters back to the first page.</param>
    ''' <param name="printPage">The report's own PrintPage drawing method.</param>
    Public Sub Run(owner As IWin32Window, reportName As String, landscape As Boolean,
                   reset As Action, printPage As PrintPageEventHandler)

        ' 1. A purpose is required: no purpose, no report
        Dim text As String
        Using dlg As New frmRemarks("Report Purpose", $"Why is the {reportName} being generated?", RemarkReasons.ReportPurpose)
            If dlg.ShowDialog(owner) <> DialogResult.OK Then Return
            text = dlg.FullText
        End Using
        Purpose = text
        PreparedBy = AppSession.FullName
        PreparedRole = AppSession.Role
        GeneratedAt = DateTime.Now

        ' 2. A usable printer: preview. Anything else (no default printer, printer system failure):
        '    warn, then offer a PDF. AndAlso stops the preview from being tried when there is no printer.
        If frmReceipt.HasPrinter() AndAlso ShowPreview(owner, landscape, reset, printPage) Then Return

        MessageBox.Show(owner, "No printer is connected to this computer, so the report cannot be printed.",
                        "No Printer Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        If MessageBox.Show(owner, "Do you want to save the report as a PDF instead?", "Save as PDF",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SavePdf(owner, reportName, landscape, reset, printPage)
        End If
    End Sub

    ''' <returns>True if handled (preview shown, or another error was reported); False if the printer system is unusable.</returns>
    Private Function ShowPreview(owner As IWin32Window, landscape As Boolean, reset As Action, printPage As PrintPageEventHandler) As Boolean
        Try
            Using doc As New PrintDocument()
                doc.DefaultPageSettings.Landscape = landscape
                AddHandler doc.BeginPrint, Sub(s, e) reset()   ' every preview / print run starts at page 1
                AddHandler doc.PrintPage, printPage
                Using preview As New PrintPreviewDialog() With {.Document = doc, .WindowState = FormWindowState.Maximized}
                    preview.ShowDialog(owner)
                End Using
            End Using
            Return True
        Catch ex As InvalidPrinterException
            Return False   ' no usable printer: the caller offers the PDF instead
        Catch ex As Exception
            MessageBox.Show(owner, "Could not open the print preview: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    ' Draws every page onto a bitmap (no printer needed), compresses it, and writes one PDF
    Private Sub SavePdf(owner As IWin32Window, reportName As String, landscape As Boolean,
                        reset As Action, printPage As PrintPageEventHandler)
        Using sfd As New SaveFileDialog() With {
            .Title = "Save report as PDF", .Filter = "PDF file (*.pdf)|*.pdf",
            .FileName = $"{reportName.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmm}.pdf"}
            If sfd.ShowDialog(owner) <> DialogResult.OK Then Return

            Try
                Dim pw As Integer = If(landscape, 1100, 850)    ' Letter paper in 1/100 inch
                Dim ph As Integer = If(landscape, 850, 1100)
                Dim pageRect As New Rectangle(0, 0, pw, ph)
                Dim margins As New Rectangle(50, 50, pw - 100, ph - 100)   ' half-inch margins

                Dim pages As New List(Of Byte())()
                reset()
                Dim more As Boolean
                Do
                    Using bmp As New Bitmap(pw * 2, ph * 2, PixelFormat.Format24bppRgb)   ' 200 pixels per inch
                        bmp.SetResolution(100, 100)
                        Using g As Graphics = Graphics.FromImage(bmp)
                            g.Clear(Color.White)
                            g.SmoothingMode = SmoothingMode.AntiAlias
                            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
                            g.ScaleTransform(2.0F, 2.0F)
                            Dim args As New PrintPageEventArgs(g, margins, pageRect, Nothing)
                            printPage.Invoke(Nothing, args)
                            more = args.HasMorePages
                        End Using
                        pages.Add(SimplePdf.ToJpeg(bmp, 88L))   ' keep only the small JPEG, free the bitmap
                    End Using
                Loop While more AndAlso pages.Count < 1000

                SimplePdf.SaveJpegPages(pages, pw * 2, ph * 2, sfd.FileName, pw * 72 \ 100, ph * 72 \ 100)
            Catch ex As Exception
                MessageBox.Show(owner, "Could not save the PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            If MessageBox.Show(owner, "Report saved as PDF. Open it now?", "Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    Process.Start(New ProcessStartInfo(sfd.FileName) With {.UseShellExecute = True})
                Catch ex As Exception
                    MessageBox.Show(owner, "The PDF was saved but could not be opened automatically:" & vbCrLf & sfd.FileName,
                                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End Using
    End Sub

    ' ---------------------------------------------------------------
    ' Helpers the report pages call
    ' ---------------------------------------------------------------

    ''' <summary>Purpose + "generated by" lines under the report title. Returns the new y.</summary>
    Public Function DrawPurpose(g As Graphics, font As Font, m As Rectangle, y As Single) As Single
        Dim text As String = "Purpose: " & Purpose
        Dim sz As SizeF = g.MeasureString(text, font, m.Width)
        g.DrawString(text, font, Brushes.DimGray, New RectangleF(m.Left, y, m.Width, sz.Height))
        y += sz.Height + 2
        g.DrawString($"Generated by {PreparedBy} ({PreparedRole}) on {GeneratedAt:MMMM dd, yyyy h:mm tt}", font, Brushes.DimGray, m.Left, y)
        Return y + font.GetHeight(g) + 8
    End Function

    ''' <summary>Signature line with the printed name of whoever generated the report. Needs about 90 units of height.</summary>
    Public Function DrawSignature(g As Graphics, fontBold As Font, fontSmall As Font, m As Rectangle, y As Single) As Single
        Dim w As Single = 250.0F
        Dim x As Single = m.Right - w
        g.DrawLine(Pens.Black, x, y + 26, m.Right, y + 26)
        Using fmt As New StringFormat() With {.Alignment = StringAlignment.Center}
            g.DrawString(PreparedBy, fontBold, Brushes.Black, New RectangleF(x, y + 30, w, 20), fmt)
            g.DrawString($"Prepared by ({PreparedRole}) - signature over printed name", fontSmall, Brushes.Black, New RectangleF(x - 20, y + 50, w + 20, 30), fmt)
        End Using
        Return y + 84
    End Function

End Module
