Imports MySql.Data.MySqlClient

''' <summary>Helpers shared by Create Request and Request Details.</summary>
Public Module RequestHelper

    ''' <summary>Fixed rush (expedite) fee per request.</summary>
    Public Const RushFee As Decimal = 200D

    ''' <summary>
    ''' Builds the next Official Receipt number as OR-yyyy-00001, OR-yyyy-00002, ... (restarts each year).
    ''' Call it inside the same transaction that saves the OR number so two users cannot get the same one.
    ''' </summary>

    Public Function NewORNumber(c As MySqlConnection, tx As MySqlTransaction) As String
        Dim prefix As String = "OR-" & DateTime.Now.ToString("yyyy") & "-"
        Dim sql As String = "SELECT COALESCE(MAX(CAST(SUBSTRING(ORNo, @start) AS UNSIGNED)), 0) FROM tblrequest WHERE ORNo LIKE @like"
        Using cmd As New MySqlCommand(sql, c, tx)
            cmd.Parameters.AddWithValue("@start", prefix.Length + 1)
            cmd.Parameters.AddWithValue("@like", prefix & "%")
            Dim last As Long = Convert.ToInt64(cmd.ExecuteScalar())
            Return prefix & (last + 1).ToString("00000")
        End Using
    End Function

    Public Function IsPaid(paymentStatus As String) As Boolean
        Return String.Equals(If(paymentStatus, "").Trim(), "Paid", StringComparison.OrdinalIgnoreCase)
    End Function

End Module
