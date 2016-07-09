Public Class Report_RequestForm1

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New CrystalReport1
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub Report_RequestForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class