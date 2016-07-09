Option Explicit Off
Public Class frm_package
    Dim conn As New HQ_Connection
    Public count() As String
    Dim id As String
    Public stvar As String
    Dim usercount As Integer = 0
    Dim usercount2 As Integer = 0
    ''Function
    Sub getcount()
        Dim dt As New DataTable
        Dim select_query As String = "select count(status) from package_tbl where status = 'Active'"
        If conn.SelectRec(select_query, dt) = True Then
            ReDim count(dt.Rows(0).Item(0).ToString())
        End If
    End Sub
    Sub clear()
        txtID.Text = ""
        txtPack.Text = ""
        btnREMOVE.Enabled = False
    End Sub
    Sub form()
        clear()
        lv_Pack.Clear()
        form_pack_lv()
        Load_pack_lv()
    End Sub

    Private Sub frm_package_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        form()
        Me.CenterToParent()
        getcount()
        cmb_packge_type()
    End Sub


    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        clear()
    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtID.Text = "" Then
            If txtPack.Text = "" Or txtPack.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stradd As String = "Insert into package_tbl(pack_id,pack_name,status)values(null,'" & txtPack.Text & "','Active')"
                If conn.ModRec(stradd) = True Then
                    form()
                    cmb_packge_type()
                    MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If txtPack.Text = "" Or txtPack.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                edit_query = "Update package_tbl set pack_name ='" & txtPack.Text & "' where pack_id = '" & txtID.Text & "'"
                If conn.ModRec(edit_query) = True Then
                    form()
                    cmb_packge_type()
                    MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMOVE.Click
        If txtID.Text = "" Then
        Else
            remove_query = "Update package_tbl set status ='Inactive' where pack_id = '" & txtID.Text & "'"
            If conn.ModRec(remove_query) = True Then
                form()
                cmb_packge_type()
                MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub lv_Dept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Pack.SelectedIndexChanged
        With lv_Pack
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            txtPack.Text = .SelectedItems(0).SubItems(2).Text
            btnREMOVE.Enabled = True
            lv_Pack.Clear()
            form_pack_lv()
            Load_pack_lv()
        End With
    End Sub

    Private Sub cmb_package_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_package.SelectedIndexChanged
        With cmb_package
            stvar = count(.SelectedIndex)
        End With
        ListView1.Clear()
        lv_services.Clear()
        form_ap_lv()
        Load_ap_lv()
        form_sp_lv()
        Load_sp_lv()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If usercount = 0 Then
            If ListView1.SelectedIndices.Count = 0 Then
            ElseIf ListView1.SelectedItems.Count > 0 Then
                If MessageBox.Show("Do you want to remove this service in the Package of " & cmb_package.Text, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    With ListView1
                        On Error Resume Next
                        id = .SelectedItems(0).SubItems(1).Text
                        Dim stradd As String = "Delete from package_service_tbl where ID = '" & id & "'"
                        If conn.ModRec(stradd) = True Then
                            MessageBox.Show("Service removed from the package", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ListView1.Clear()
                            lv_services.Clear()
                            form_ap_lv()
                            Load_ap_lv()
                            form_sp_lv()
                            Load_sp_lv()
                        End If
                    End With
                    usercount = 1
                End If
            End If
        Else
            usercount = 0
        End If
    End Sub

    Private Sub lv_services_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_services.SelectedIndexChanged
        If cmb_package.Text = "" Then
            MessageBox.Show("Select a package first in the combo box", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmb_package.Focus()
        Else
            If usercount2 = 0 Then
                If lv_services.SelectedIndices.Count = 0 Then
                ElseIf lv_services.SelectedItems.Count > 0 Then
                    With lv_services
                        On Error Resume Next
                        Service = .SelectedItems(0).SubItems(1).Text
                    End With
                    If MessageBox.Show("Do you want to add this service in the Package of " & cmb_package.Text, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim stradd As String = "Insert into package_service_tbl values(null,'" & stvar & "','" & Service & "')"
                        If conn.ModRec(stradd) = True Then
                            MessageBox.Show("Service Package added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            form_ap_lv()
                            Load_ap_lv()
                            form_sp_lv()
                            Load_sp_lv()
                        End If
                        usercount2 = 1
                    End If
                End If
            Else
                usercount2 = 0
            End If
        End If
    End Sub
End Class