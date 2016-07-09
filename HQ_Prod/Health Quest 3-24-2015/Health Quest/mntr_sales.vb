Public Class mntr_sales

    Private Sub mntr_sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim array() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        For b As Integer = 0 To array.Length - 1
            cboMonth.Items.Add(array(b))
        Next
        cboMonth.SelectedIndex = 0


        Dim i As Integer = DateTime.Now.Year
        Do While i >= DateTime.Now.Year - 50
            cboYear.Items.Add(i)
            i = i - 1
        Loop
        cboYear.SelectedIndex = 0

        dtTo.MaxDate = Date.Today
        dtFrom.MaxDate = dtTo.Value.AddDays(-1)
        dtFrom.Value = dtTo.Value.AddDays(-7)
        dtDate.MaxDate = Date.Today
    End Sub

    Private Sub rdbtnMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnMonth.CheckedChanged
        If rdbtnMonth.Checked Then
            panelMonthly.Visible = True
            panelWeekly.Visible = False
            panelSpecDate.Visible = False
        End If
    End Sub

    Private Sub rdbtnWeek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnWeek.CheckedChanged
        If rdbtnWeek.Checked Then
            panelMonthly.Visible = False
            panelWeekly.Visible = True
            panelSpecDate.Visible = False
        End If
    End Sub

    Private Sub rdbtnSpecDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnSpecDate.CheckedChanged
        If rdbtnSpecDate.Checked Then
            panelMonthly.Visible = False
            panelWeekly.Visible = False
            panelSpecDate.Visible = True
        End If
    End Sub
    Private Sub dtTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTo.ValueChanged
        If dtTo.Value = dtFrom.Value Then
            dtFrom.Value = dtTo.Value.AddDays(-1)
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If rdbtnMonth.Checked Then
        ElseIf rdbtnWeek.Checked Then
        ElseIf rdbtnSpecDate.Checked Then
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        rdbtnMonth.Checked = True
        cboMonth.SelectedIndex = 0
        cboYear.SelectedIndex = 0
        dtTo.Value = DateTime.Now.Date
        dtFrom.Value = dtTo.Value.AddDays(-7)
        dtDate.Value = DateTime.Now.Date
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class