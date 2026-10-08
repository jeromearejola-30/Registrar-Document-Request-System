Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text

''' <summary>
''' Writes a one-page PDF that contains a picture. It needs no printer and no extra package.
''' A PDF is a text file of numbered objects plus a table (xref) that says where each object starts.
''' </summary>
Public Module SimplePdf

    ''' <param name="pageWidthPt">Page width in points (72 points = 1 inch)</param>
    Public Sub SaveImage(img As Bitmap, filePath As String, pageWidthPt As Integer, pageHeightPt As Integer)
        Dim jpeg As Byte() = ToJpeg(img, 90L)

        Using ms As New MemoryStream()
            Dim offsets(5) As Long   ' where objects 1..5 start
            Dim put As Action(Of String) = Sub(s As String)
                                               Dim b As Byte() = Encoding.ASCII.GetBytes(s)
                                               ms.Write(b, 0, b.Length)
                                           End Sub

            put("%PDF-1.4" & vbLf)

            offsets(1) = ms.Position
            put("1 0 obj" & vbLf & "<< /Type /Catalog /Pages 2 0 R >>" & vbLf & "endobj" & vbLf)

            offsets(2) = ms.Position
            put("2 0 obj" & vbLf & "<< /Type /Pages /Kids [3 0 R] /Count 1 >>" & vbLf & "endobj" & vbLf)

            offsets(3) = ms.Position
            put($"3 0 obj{vbLf}<< /Type /Page /Parent 2 0 R /MediaBox [0 0 {pageWidthPt} {pageHeightPt}] " &
                $"/Resources << /XObject << /Im0 4 0 R >> >> /Contents 5 0 R >>{vbLf}endobj{vbLf}")

            offsets(4) = ms.Position
            put($"4 0 obj{vbLf}<< /Type /XObject /Subtype /Image /Width {img.Width} /Height {img.Height} " &
                $"/ColorSpace /DeviceRGB /BitsPerComponent 8 /Filter /DCTDecode /Length {jpeg.Length} >>{vbLf}stream{vbLf}")
            ms.Write(jpeg, 0, jpeg.Length)
            put($"{vbLf}endstream{vbLf}endobj{vbLf}")

            ' Page content: stretch the picture over the whole page
            offsets(5) = ms.Position
            Dim content As String = $"q {pageWidthPt} 0 0 {pageHeightPt} 0 0 cm /Im0 Do Q"
            put($"5 0 obj{vbLf}<< /Length {content.Length} >>{vbLf}stream{vbLf}{content}{vbLf}endstream{vbLf}endobj{vbLf}")

            ' Cross-reference table: every entry is exactly 20 bytes
            Dim xrefPos As Long = ms.Position
            put($"xref{vbLf}0 6{vbLf}")
            put("0000000000 65535 f " & vbLf)
            For i As Integer = 1 To 5
                put(offsets(i).ToString("0000000000") & " 00000 n " & vbLf)
            Next
            put($"trailer{vbLf}<< /Size 6 /Root 1 0 R >>{vbLf}startxref{vbLf}{xrefPos}{vbLf}%%EOF{vbLf}")

            File.WriteAllBytes(filePath, ms.ToArray())
        End Using
    End Sub

    Private Function ToJpeg(img As Bitmap, quality As Long) As Byte()
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

End Module
