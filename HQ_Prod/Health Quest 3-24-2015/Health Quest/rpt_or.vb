Public Class rpt_or
    Public prntfrm As Boolean = True
    Private Sub rpt_or_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If prntfrm = True Then
            Dim rpt As New CrystalReport1
            rpt.SetParameterValue("txtPatientNo", frm_cashier.txtPatientID.Text)
            rpt.SetParameterValue("txtPatientName", frm_cashier.txtName.Text)
            rpt.SetParameterValue("txtDate", frm_cashier.DTP.Value.ToLongDateString())
            rpt.SetParameterValue("consfee", frm_cashier.lblConsFee.Text)
            rpt.SetParameterValue("txtOR", frm_cashier.orno)
            rpt.SetParameterValue("net", frm_cashier.lblNet.Text)
            rpt.SetParameterValue("less", frm_cashier.lblLess.Text)
            rpt.SetParameterValue("gross", frm_cashier.lblGross.Text)
            rpt.SetParameterValue("payment", frm_cashier.txtPayment.Text)
            rpt.SetParameterValue("change", frm_cashier.lblChange.Text)
            rpt.SetParameterValue("otherfee", frm_cashier.lblOtherFee.Text)
            rpt.SetParameterValue("test_id", frm_cashier.txtTestID.Text)
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
        ElseIf prntfrm = False Then
            Dim rpt As New CrystalReport1
            rpt.SetParameterValue("txtPatientNo", frm_Balance.patientid)
            rpt.SetParameterValue("txtPatientName", frm_Balance.txtPatientName.Text)
            rpt.SetParameterValue("txtDate", DateTime.Now.ToLongDateString())
            rpt.SetParameterValue("consfee", frm_Balance.consfee)
            rpt.SetParameterValue("txtOR", frm_Balance.txtOR.Text)
            rpt.SetParameterValue("net", frm_Balance.txtAmountDue.Text)
            rpt.SetParameterValue("less", frm_Balance.discount)
            rpt.SetParameterValue("gross", frm_Balance.gross)
            rpt.SetParameterValue("payment", frm_Balance.txtPayment.Text)
            rpt.SetParameterValue("change", frm_Balance.txtChange.Text)
            rpt.SetParameterValue("otherfee", frm_Balance.otherfee)
            rpt.SetParameterValue("test_id", frm_Balance.txtPatientID.Text)
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
        End If
    End Sub
End Class