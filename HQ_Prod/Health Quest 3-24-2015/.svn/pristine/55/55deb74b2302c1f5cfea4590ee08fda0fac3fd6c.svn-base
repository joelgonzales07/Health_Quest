Public Class Report_InventoryForm
    Public u_name As String
    Private Sub Report_InventoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New CrystalReport5
        rpt.SetParameterValue("txtDateTime", DateTime.Now.ToShortDateString() & " - " & DateTime.Now.ToLongTimeString())
        rpt.SetParameterValue("txtPrintedBy", u_name)
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class