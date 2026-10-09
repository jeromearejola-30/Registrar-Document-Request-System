Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text

''' <summary>
''' Writes PDF files made of pictures (one picture per page). No printer and no extra package needed.
''' A PDF is a text file of numbered objects plus a table (xref) saying where each object starts.
''' </summary>
Public Module SimplePdf

    ''' <summary>One-page PDF (used by the receipt).</summary>
    Public Sub SaveImage(img As Bitmap, filePath As String, pageWidthPt As Integer, pageHeightPt As Integer)
        SaveJpegPages(New List(Of Byte())() From {ToJpeg(img, 90L)}, img.Width, img.Height, filePath, pageWidthPt, pageHeightPt)
    End Sub

    ''' <summary>Compresses a bitmap to JPEG bytes (so a long report never keeps many big bitmaps in memory).</summary>
    Public Function ToJpeg(img As Bitmap, quality As Long) As Byte()
        Dim codec As ImageCodecInfo = Nothing
        For Each c As ImageCodecInfo In ImageCodecInfo.GetImageEncoders()
            If c.FormatID = ImageFormat.Jpeg.Guid Then codec = c
        Next
        Using ms As New MemoryStream()
            Using ep As New EncoderParameters(1)
                ep.Param(0) = New EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality)
                img.Save(ms, codec, ep)
            End Using
            Return ms.ToArray()
        End Using
    End Function

    ''' <summary>Multi-page PDF: every JPEG is stretched over a page of the given size in points (72 = 1 inch).</summary>
    Public Sub SaveJpegPages(jpegPages As List(Of Byte()), pixelWidth As Integer, pixelHeight As Integer,
                             filePath As String, pageWidthPt As Integer, pageHeightPt As Integer)
        Dim n As Integer = jpegPages.Count
        Dim totalObjects As Integer = 3 + 3 * n          ' objects 1..2 + (page, image, content) per page
        Dim offsets(totalObjects - 1) As Long

        Using ms As New MemoryStream()
            Dim put As Action(Of String) = Sub(s As String)
                                               Dim b As Byte() = Encoding.ASCII.GetBytes(s)
                                               ms.Write(b, 0, b.Length)
                                           End Sub

            put("%PDF-1.4" & vbLf)

            offsets(1) = ms.Position
            put("1 0 obj" & vbLf & "<< /Type /Catalog /Pages 2 0 R >>" & vbLf & "endobj" & vbLf)

            Dim kids As New StringBuilder()
            For i As Integer = 0 To n - 1
                kids.Append(3 + 3 * i).Append(" 0 R ")
            Next
            offsets(2) = ms.Position
            put($"2 0 obj{vbLf}<< /Type /Pages /Kids [{kids.ToString().Trim()}] /Count {n} >>{vbLf}endobj{vbLf}")

            For i As Integer = 0 To n - 1
                Dim pageObj As Integer = 3 + 3 * i
                Dim imageObj As Integer = pageObj + 1
                Dim contentObj As Integer = pageObj + 2
                Dim jpeg As Byte() = jpegPages(i)

                offsets(pageObj) = ms.Position
                put($"{pageObj} 0 obj{vbLf}<< /Type /Page /Parent 2 0 R /MediaBox [0 0 {pageWidthPt} {pageHeightPt}] " &
                    $"/Resources << /XObject << /Im{i} {imageObj} 0 R >> >> /Contents {contentObj} 0 R >>{vbLf}endobj{vbLf}")

                offsets(imageObj) = ms.Position
                put($"{imageObj} 0 obj{vbLf}<< /Type /XObject /Subtype /Image /Width {pixelWidth} /Height {pixelHeight} " &
                    $"/ColorSpace /DeviceRGB /BitsPerComponent 8 /Filter /DCTDecode /Length {jpeg.Length} >>{vbLf}stream{vbLf}")
                ms.Write(jpeg, 0, jpeg.Length)
                put($"{vbLf}endstream{vbLf}endobj{vbLf}")

                offsets(contentObj) = ms.Position
                Dim content As String = $"q {pageWidthPt} 0 0 {pageHeightPt} 0 0 cm /Im{i} Do Q"
                put($"{contentObj} 0 obj{vbLf}<< /Length {content.Length} >>{vbLf}stream{vbLf}{content}{vbLf}endstream{vbLf}endobj{vbLf}")
            Next

            ' Cross-reference table: every entry is exactly 20 bytes
            Dim xrefPos As Long = ms.Position
            put($"xref{vbLf}0 {totalObjects}{vbLf}")
            put("0000000000 65535 f " & vbLf)
            For k As Integer = 1 To totalObjects - 1
                put(offsets(k).ToString("0000000000") & " 00000 n " & vbLf)
            Next
            put($"trailer{vbLf}<< /Size {totalObjects} /Root 1 0 R >>{vbLf}startxref{vbLf}{xrefPos}{vbLf}%%EOF{vbLf}")

            File.WriteAllBytes(filePath, ms.ToArray())
        End Using
    End Sub

End Module