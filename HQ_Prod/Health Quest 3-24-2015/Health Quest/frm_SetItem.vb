Option Explicit Off
Public Class frm_SetItem
    Dim conn As New HQ_Connection
    Dim bool As Boolean
    Sub clear()
        txtID.Text = ""
        txtname.Text = ""
        txtdescription.Text = ""
        txtQuantity.Text = "0.00"
        txtname.Enabled = False
        txtdescription.Enabled = False
        txtQuantity.Enabled = False
        btnSet.Enabled = False
        btnCLEAR.Enabled = False
    End Sub
    Sub form()
        clear()
        lv_ri.Clear()
        lv_ii.Clear()
        form_ii_lv()
        Load_ii_lv()
        form_ri_lv()
        Load_ri_lv()
    End Sub

    Private Sub frm_inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form()
    End Sub
    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        If bool = True Then
            If txtQuantity.Text = "" Or txtQuantity.Text = 0 Then
                MessageBox.Show("Item Quantity is a required field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stradd As String = "Insert into inventory_tbl values(null,'" & txtID.Text & "','" & txtdescription.Text & "','" & txtQuantity.Text & "')"
                If conn.ModRec(stradd) = True Then
                    form()
                    MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        ElseIf bool = False Then
            If txtQuantity.Text = "" Or txtQuantity.Text = "0" Then
                remove_query = "delete from inventory_tbl where item_id = '" & txtID.Text & "'"
                If conn.ModRec(remove_query) = True Then
                    form()
                    MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                edit_query = "Update inventory_tbl set description ='" & txtdescription.Text & "', quantity ='" & txtQuantity.Text & "' where item_id = '" & txtID.Text & "'"
                If conn.ModRec(edit_query) = True Then
                    form()
                    MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        clear()
    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        lv_ri.Clear()
        form_sri_lv()
        Load_sri_lv()
    End Sub

    Private Sub txtSearch2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch2.TextChanged
        lv_ii.Clear()
        form_sii_lv()
        Load_sii_lv()
    End Sub

    Private Sub lv_ri_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_ri.SelectedIndexChanged
        With lv_ri
            bool = True
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            txtname.Text = .SelectedItems(0).SubItems(2).Text
            txtdescription.Enabled = True
            txtQuantity.Enabled = True
            txtdescription.Focus()
            btnSet.Enabled = True
            btnCLEAR.Enabled = True
            lv_ri.Clear()
            form_ri_lv()
            Load_ri_lv()
        End With
    End Sub

    Private Sub lv_ii_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_ii.SelectedIndexChanged
        With lv_ii
            bool = False
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            txtname.Text = .SelectedItems(0).SubItems(2).Text
            txtdescription.Enabled = True
            txtQuantity.Enabled = True
            txtdescription.Focus()
            btnSet.Enabled = True
            btnCLEAR.Enabled = True

            Dim dt As New DataTable
            Dim select_query As String = "select description, quantity from inventory_tbl where item_id = '" & txtID.Text & "'"
            If conn.SelectRec(select_query, dt) = True Then
                txtdescription.Text = dt.Rows(0).Item(0).ToString()
                txtQuantity.Text = dt.Rows(0).Item(1).ToString()
            End If

            lv_ii.Clear()
            form_ii_lv()
            Load_ii_lv()
        End With
    End Sub
End Class