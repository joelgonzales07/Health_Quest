Option Explicit Off
Public Class frm_request_item
    Dim conn As New HQ_Connection
    Dim ID As Integer
    Dim quantity As Integer
    Sub form()
        lv_item.Clear()
        form_Citem_lv()
        Load_Citem_lv()
    End Sub
    Private Sub frm_request_item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub btnSaves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaves.Click
        quantity = quantity - Convert.ToDouble(txtq.Text)
        edit_query = "Update inventory_tbl set quantity = '" & quantity & "' where item_id = '" & ID & "' "
        If conn.ModRec(edit_query) = True Then
            MessageBox.Show("Request item Granted", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSearch.Text = ""
            txtq.Text = ""
            form()
        End If
    End Sub

    Private Sub lv_item_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_item.SelectedIndexChanged
        With lv_item
            ID = .SelectedItems(0).SubItems(0).Text
            txtq.Text = .SelectedItems(0).SubItems(4).Text
            quantity = .SelectedItems(0).SubItems(4).Text
            lv_item.Clear()
            form_Citem_lv()
            Load_Citem_lv()
        End With
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        lv_item.Clear()
        form_siiii_lv()
        Load_siiii_lv()
    End Sub
End Class