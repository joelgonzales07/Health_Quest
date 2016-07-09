Public Class frm_uploadexcel
    Dim conn As New HQ_Connection

    Private Sub frm_uploadexcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnSaves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaves.Click

        On Error Resume Next
        Dim QryInsert As String = "", QryCreate As String = ""
        Dim i As Integer = 0
        Dim Fnm As String = TextBox1.Text
        Dim s1 As String
        Dim s2(5) As String
        Dim freader As New IO.StreamReader(Fnm, False)
       
        While (freader.EndOfStream = False)
            s1 = freader.ReadLine
            s2 = s1.Split(",")
            If i >= 1 Then
                QryInsert = "Insert Into patient_tbl Values ('" & s2(0) & "','" & s2(1) & "','" & s2(2) & "','" & s2(3) & "','" & s2(4) & "','" & s2(5) & "','" & s2(6) & "','" & s2(7) & "','" & s2(8) & "','" & s2(9) & "','" & s2(10) & "','" & s2(11) & "','" & s2(12) & "','" & s2(13) & "','" & s2(14) & "','" & s2(15) & "')"
                conn.ModRec(QryInsert)
            End If
            i += 1
        End While
        MsgBox("Data Imported Successfully")
    End Sub
End Class