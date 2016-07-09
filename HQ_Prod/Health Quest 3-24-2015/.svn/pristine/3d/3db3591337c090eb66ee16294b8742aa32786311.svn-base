Imports System.IO

Public Class HQ_Connection
    Dim sra As New StreamReader("IP_CONFIG.txt")
    Dim x As String = sra.ReadToEnd()
    Public conn As New Odbc.OdbcConnection("Driver={MySQL ODBC 3.51 Driver};Server=" & x & ";user=root;PWD=123456;Database=hq_db")
    Dim cmd As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Public Function SelectRec(ByVal strsql As String, ByVal dt As DataTable) As Boolean
        Try
            da = New Odbc.OdbcDataAdapter(strsql, conn)
            da.Fill(dt)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function ModRec(ByVal strsql As String) As Boolean
        Dim blntest As Boolean
        Try
            conn.Open()
            cmd = New Odbc.OdbcCommand(strsql, conn)
            If cmd.ExecuteNonQuery > 0 Then
                blntest = True
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            blntest = False
        End Try
        Return blntest
    End Function
End Class

