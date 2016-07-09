Public Class mntr_doctor

    Private Sub mntr_doctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form_dm_lv()
        Load_dm_lv()
    End Sub

    Private Sub txtDocName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocName.TextChanged
        form_dmSearch_lv()
        Load_dmSearch_lv()
    End Sub

    Private Sub btnPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRINT.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class