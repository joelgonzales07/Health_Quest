Public Class mntr_service

    Private Sub mntr_service_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Service_type2()
    End Sub

    Private Sub cmb_Stype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Stype.SelectedIndexChanged
        form_sri2_lv()
        Load_sri2_lv()
    End Sub

    Private Sub btnSaves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaves.Click
        Me.Hide()
    End Sub
End Class