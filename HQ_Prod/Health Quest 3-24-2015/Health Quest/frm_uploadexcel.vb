Imports System.IO

Public Class frm_uploadexcel
    Dim conn As New HQ_Connection
    Dim query As New Dictionary(Of String, String)

    Private Sub frm_uploadexcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getQuery()
        TextBox1.Enabled = False
        btnSaves.Enabled = False
        btnUpload.Enabled = False
        OpenFileDialog1.Multiselect = False
        Dim tablearr(1) As String
        Dim tablename(1) As String

        tablearr(0) = "patient_tbl"
        tablename(0) = "Patient Master List"

        popList(tablearr, tablename)
    End Sub

    Sub getQuery()
        query.Add("patient_tbl", "SELECT patient_number as 'Patient number', lname as 'Last Name', fname as 'First name', mname as 'Middle name', bday as 'Birth date', age as 'Age', gender as 'Gender', address as 'Address', tel as 'Telephone', mob as 'Mobile #', email as 'Email add' from patient_tbl limit 0")
    End Sub

    Sub popList(ByVal tablearr() As String, ByVal tablename() As String)
        lv_options.Items.Clear()
        With lv_options
            .Columns.Add("table", 0)
            .Columns.Add("List", 185)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White

            For i As Integer = 0 To tablearr.Length - 1
                Dim lv As New ListViewItem
                lv.Text = tablearr(i)
                lv.SubItems.Add(tablename(i))
                .Items.Add(lv)
            Next
        End With
    End Sub

    Private Sub btnSaves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaves.Click
        OpenFileDialog1.ShowDialog()

        'On Error Resume Next
        'Dim QryInsert As String = "", QryCreate As String = ""
        'Dim i As Integer = 0
        'Dim Fnm As String = TextBox1.Text
        'Dim s1 As String
        'Dim s2(5) As String
        'Dim freader As New IO.StreamReader(Fnm, False)

        'While (freader.EndOfStream = False)
        '    s1 = freader.ReadLine
        '    s2 = s1.Split(",")
        '    If i >= 1 Then
        '        QryInsert = "Insert Into patient_tbl Values ('" & s2(0) & "','" & s2(1) & "','" & s2(2) & "','" & s2(3) & "','" & s2(4) & "','" & s2(5) & "','" & s2(6) & "','" & s2(7) & "','" & s2(8) & "','" & s2(9) & "','" & s2(10) & "','" & s2(11) & "','" & s2(12) & "','" & s2(13) & "','" & s2(14) & "','" & s2(15) & "')"
        '        conn.ModRec(QryInsert)
        '    End If
        '    i += 1
        'End While
        'MsgBox("Data Imported Successfully")
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim file As String = OpenFileDialog1.FileName.ToString
        TextBox1.Text = file
        populateGrid(file)
        btnUpload.Enabled = True
    End Sub

    Sub populateGrid(ByVal file As String)

    End Sub

    Private Sub lv_options_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_options.SelectedIndexChanged
        If lv_options.SelectedItems.Count > 0 Then
            TextBox1.Enabled = True
            btnSaves.Enabled = True
            Dim tblname = lv_options.SelectedItems(0).SubItems(0).Text
            dt_tbl.Columns.Clear()
            Dim sra As New StreamReader("IP_CONFIG.txt")
            Dim x As String = sra.ReadToEnd()
            Dim conndt As New Odbc.OdbcConnection("Driver={MySQL ODBC 3.51 Driver};Server=" & x & ";user=root;PWD=123456;Database=hq_db")
            Dim cmd As New Odbc.OdbcCommand(query(tblname), conndt)
            Dim da As New Odbc.OdbcDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            dt_tbl.DataSource = ds.Tables(0)
        End If
    End Sub
End Class