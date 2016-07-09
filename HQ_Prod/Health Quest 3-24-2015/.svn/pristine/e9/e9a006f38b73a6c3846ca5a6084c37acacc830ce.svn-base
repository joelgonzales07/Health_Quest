Option Explicit Off
Public Class frm_addpackage
    Dim conn As New HQ_Connection

    Sub form()
        lv_ap.Clear()
        form_ap_lv()
        Load_ap_lv()
    End Sub
    Private Sub frm_addpackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        form()
        Me.CenterToParent()
    End Sub

    Private Sub lv_ap_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_ap.SelectedIndexChanged

        Dim guid As System.Guid = System.Guid.NewGuid()
        With lv_ap
            On Error Resume Next
            txtservice.Text = .SelectedItems(0).SubItems(2).Text
            txtgross.Text = .SelectedItems(0).SubItems(3).Text
        End With

        Dim stradd As String = "Insert into package_service_tbl(ID,package_name,service_type,gross)values('" & guid.ToString & "','" & frm_setpackage.cmb_package.Text & "','" & txtservice.Text & "','" & txtgross.Text & "')"
        If conn.ModRec(stradd) = True Then
            MessageBox.Show("Service Package added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


    End Sub

    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        Me.Hide()
        frm_setpackage.Show()
    End Sub
End Class