Option Explicit Off
Public Class frm_hmo
    Dim conn As New HQ_Connection
    Public hmo() As String
    Dim hmovar As String
    Public called As Boolean = False

    ''Function
    Sub count()
        Dim select_query As String
        Dim dt As New DataTable
        select_query = "select count(status) from hmo_tbl where status = 'Active'"
        If conn.SelectRec(select_query, dt) = True Then
            ReDim hmo(dt.Rows(0).Item(0).ToString)
        End If
        dt.Dispose()
    End Sub
    Sub clear()
        txtID.Text = ""
        txtHmoNumber.Text = ""
        txtContact.Text = ""
        btnREMOVE.Enabled = False
    End Sub

    Sub clearComp()
        txtCompID.Text = ""
        txtCompName.Text = ""
        cmb_comphmo.Text = ""
        btnREMOVECOMP.Enabled = False
    End Sub

    Sub form()
        clear()
        count()
        clearComp()
        lv_hmo.Clear()
        form_hmo_lv()
        Load_hmo_lv()
        cmb_comp_hmo()
        lv_comp.Clear()
        form_comp_lv()
        load_comp_lv()
    End Sub
    Private Sub frm_hmo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        form()
        If called = True Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        clear()
    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtID.Text = "" Then
            If txtHmoNumber.Text = "" Or txtHmoNumber.Text = " " Or txtContact.Text = "" Or txtContact.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stradd As String = "Insert into hmo_tbl values(null,'" & txtHmoNumber.Text & "','" & txtContact.Text & "','Active')"
                If conn.ModRec(stradd) = True Then
                    form()
                    MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If txtHmoNumber.Text = "" Or txtHmoNumber.Text = " " Or txtContact.Text = "" Or txtContact.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                edit_query = "Update hmo_tbl set hmo_card = '" & txtHmoNumber.Text & "', contact = '" & txtContact.Text & "' where record_id = '" & txtID.Text & "'"
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
            remove_query = "Update hmo_tbl set status ='Inactive' where record_id = '" & txtID.Text & "'"
            If conn.ModRec(remove_query) = True Then
                form()
                MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub lv_hmo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_hmo.SelectedIndexChanged
        With lv_hmo
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            txtHmoNumber.Text = .SelectedItems(0).SubItems(2).Text
            txtContact.Text = .SelectedItems(0).SubItems(3).Text
            btnREMOVE.Enabled = True
            lv_hmo.Clear()
            form_hmo_lv()
            Load_hmo_lv()
        End With
    End Sub

    Private Sub cmb_comphmo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_comphmo.SelectedIndexChanged
        With cmb_comphmo
            hmovar = hmo(.SelectedIndex)
        End With
    End Sub

    Private Sub lv_comp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_comp.SelectedIndexChanged
        With lv_comp
            txtCompID.Text = .SelectedItems(0).SubItems(1).Text
            txtCompName.Text = .SelectedItems(0).SubItems(2).Text
            cmb_comphmo.Text = .SelectedItems(0).SubItems(3).Text
            btnREMOVECOMP.Enabled = True
            lv_comp.Clear()
            form_comp_lv()
            load_comp_lv()
        End With
    End Sub

    Private Sub btnSAVECOMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVECOMP.Click
        If txtCompID.Text = "" Then
            If txtCompName.Text = "" Or txtCompName.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stradd As String = "insert into company_tbl values(null, '" + txtCompName.Text + "', '" + hmovar + "', 'Active')"
                If conn.ModRec(stradd) = True Then
                    form()
                    MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If txtCompName.Text = "" Or txtCompName.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                edit_query = "update company_tbl set company_name = '" + txtCompName.Text + "', hmo_id = '" + hmovar + "' where company_id = '" + txtCompID.Text +"'"
                If conn.ModRec(edit_query) = True Then
                    form()
                    MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnREMOVECOMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMOVECOMP.Click
        If txtCompID.Text = "" Then
        Else
            remove_query = "Update company_tbl set status ='Inactive' where company_id = '" & txtCompID.Text & "'"
            If conn.ModRec(remove_query) = True Then
                form()
                MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCANCELCOMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCELCOMP.Click
        clearComp()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        called = False
        frm_process.counthmo()
        cmb_recep_hmo()
        cmb_process_comp()
        Me.Dispose()
    End Sub
End Class