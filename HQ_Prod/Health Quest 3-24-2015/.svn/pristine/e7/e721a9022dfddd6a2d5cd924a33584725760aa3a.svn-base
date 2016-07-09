Public Class rpt_statement
    Dim conn As New HQ_Connection
    Public uname As String = ""

    Private Sub rpt_statement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New CrystalReport2
        Dim cfee As Double = 0
        Dim select_query As String = "select c_fee, payment_status from patient_test_tbl where id = '" + frm_receptionist.trID + "'"
        Dim dt As New DataTable
        If conn.SelectRec(select_query, dt) Then
            If dt.Rows(0).Item(1).ToString = "paid" Then
                cfee = 0
            Else
                cfee = Convert.ToDouble(dt.Rows(0).Item(0).ToString)
            End If
        End If

        Dim otherfee As Double = 0
        If frm_process.txths.Text = "" Then
        Else
            otherfee = Convert.ToDouble(frm_process.txths.Text)
        End If

        Dim total As Double = Convert.ToDouble(frm_process.lbltotfees.Text) + cfee
        rpt.SetParameterValue("otherfee", otherfee)
        rpt.SetParameterValue("txtPatientNo", frm_receptionist.txtPnumber.Text)
        rpt.SetParameterValue("txtPatientName", frm_receptionist.txtLname.Text & ", " & frm_receptionist.txtFname.Text & " " & frm_receptionist.txtmname.Text)
        rpt.SetParameterValue("txtDate", DateTime.Now.ToLongDateString)
        rpt.SetParameterValue("txtTestID", frm_receptionist.trID)
        rpt.SetParameterValue("total", total)
        rpt.SetParameterValue("txtReception", uname)
        rpt.SetParameterValue("test_id", frm_receptionist.trID)
        rpt.SetParameterValue("txtcfee", cfee)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class