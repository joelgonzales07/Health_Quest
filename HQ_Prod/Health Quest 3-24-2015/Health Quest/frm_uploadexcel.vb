Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel


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
        query.Add("patient_tbl", "SELECT patient_number as 'Patient number', lname as 'Last name', fname as 'First name', mname as 'Middle name', bday as 'Birth date', age as 'Age', gender as 'Gender', address as 'Address', tel as 'Telephone', mob as 'Mobile #', email as 'Email add' from patient_tbl limit 0")
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
        cmb_sheet.Enabled = True
        populateCmb(file)
        btnUpload.Enabled = True
    End Sub

    Sub populateGrid(ByVal file As String, ByVal sheet As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Open(file)
        xlWorkSheet = xlWorkBook.Worksheets(sheet)

        'xlWorkSheet.Cells(row, column).value()
        Dim rows As Long = xlWorkSheet.UsedRange.Rows.Count
        Dim cols As Long = xlWorkSheet.UsedRange.Columns.Count

        Dim dt As System.Data.DataTable = New System.Data.DataTable
        For Each col As DataGridViewColumn In dt_tbl.Columns
            dt.Columns.Add(col.HeaderText)
        Next

        For temprows As Integer = 1 To rows - 1
            dt.Rows.Add()
        Next
        dt_tbl.DataSource = dt

        For i As Integer = 1 To cols - 1
            Dim columnName As String = xlWorkSheet.Cells(1, i).value
            For Each col As DataGridViewColumn In dt_tbl.Columns
                If col.HeaderText = columnName Then
                    For j As Integer = 2 To rows
                        Dim data As String = xlWorkSheet.Cells(j, i).value()
                        dt_tbl.Rows(j - 2).Cells(i - 1).Value = data
                    Next
                    GoTo end_loop_2
                End If
            Next
end_loop_2:
        Next

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
    End Sub

    Sub populateCmb(ByVal file As String)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook

        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Open(file)

        Dim listSheet As New List(Of String)
        For Each sht As Worksheet In xlWorkBook.Worksheets
            cmb_sheet.Items.Add(sht.Name)
        Next

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim file As String = TextBox1.Text
        Dim sheet As String = cmb_sheet.SelectedItem.ToString
        populateGrid(file, sheet)
    End Sub
End Class