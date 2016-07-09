Option Explicit Off
Public Class frm_item
    Dim conn As New HQ_Connection
    Public id() As String
    Dim stvar As String
    ''Function
    Sub clear()
        txtID.Text = ""
        cmb_itype.Text = ""
        txtitem.Text = ""
        btnREMOVE.Enabled = False
    End Sub
    Sub getcount()
        Dim dt As New DataTable
        Dim select_query As String = "select count(status) from item_category_tbl where status = 'Active'"
        If conn.SelectRec(select_query, dt) = True Then
            ReDim id(dt.Rows(0).Item(0).ToString())
        End If
    End Sub
    Sub form()
        clear()
        getcount()
        cmb_item_type()
        lv_itype.Clear()
        form_itype_lv()
        Load_itype_lv()
    End Sub
    Sub clear2()
        TextBox1.Text = ""
        txticat.Text = ""
        Button1.Enabled = False
    End Sub
    Sub form2()
        clear2()
        lv_item.Clear()
        form_item_lv()
        Load_item_lv()
    End Sub
    Private Sub frm_item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form()
        form2()
    End Sub
    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        clear()
    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtID.Text = "" Then
            If txtitem.Text = "" Or txtitem.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stradd As String = "Insert into item_type_tbl(item_id,item_cat_id,item,status)values(null,'" & stvar & "','" & txtitem.Text & "','Active')"
                If conn.ModRec(stradd) = True Then
                    form()
                    MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If txtitem.Text = "" Or txtitem.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                edit_query = "Update item_type_tbl set item_cat_id = '" & stvar & "', item ='" & txtitem.Text & "' where item_id = '" & txtID.Text & "'"
                If conn.ModRec(edit_query) = True Then
                    form()
                    MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMOVE.Click
        If txtID.Text = "" Then
        Else
            remove_query = "Update item_type_tbl set status ='Inactive' where item_id = '" & txtID.Text & "'"
            If conn.ModRec(remove_query) = True Then
                form()
                MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub lv_itype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_itype.SelectedIndexChanged
        With lv_itype
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            cmb_itype.Text = .SelectedItems(0).SubItems(2).Text
            txtitem.Text = .SelectedItems(0).SubItems(3).Text
            btnREMOVE.Enabled = True
            lv_itype.Clear()
            form_itype_lv()
            Load_itype_lv()
        End With
    End Sub

    Private Sub cmb_itype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_itype.SelectedIndexChanged
        With cmb_itype
            stvar = id(.SelectedIndex)
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            If txticat.Text = "" Or txticat.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stradd As String = "Insert into item_category_tbl(item_cat_id,item_category,status)values(null,'" & txticat.Text & "','Active')"
                If conn.ModRec(stradd) = True Then
                    form2()
                    cmb_item_type()
                    MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If txticat.Text = "" Or txticat.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                edit_query = "Update item_category_tbl set item_category ='" & txticat.Text & "' where item_cat_id = '" & TextBox1.Text & "'"
                If conn.ModRec(edit_query) = True Then
                    form2()
                    cmb_item_type()
                    MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
        Else
            remove_query = "Update item_category_tbl set status ='Inactive' where item_cat_id = '" & TextBox1.Text & "'"
            If conn.ModRec(remove_query) = True Then
                form2()
                cmb_item_type()
                MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear2()
    End Sub

    Private Sub lv_item_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_item.SelectedIndexChanged
        With lv_item
            TextBox1.Text = .SelectedItems(0).SubItems(1).Text
            txticat.Text = .SelectedItems(0).SubItems(2).Text
            Button1.Enabled = True
            lv_item.Clear()
            form_item_lv()
            Load_item_lv()
        End With
    End Sub
End Class