Option Explicit Off
Public Class frm_serviceType
    Dim conn As New HQ_Connection
    Public st() As String
    Dim stvar As String
    Dim service_class As String = "Imaging"

    ''Function
    Sub countVal()
        Dim select_query As String
        Dim dt As New DataTable
        select_query = "select count(status) from service_category_tbl where status = 'Active'"
        If conn.SelectRec(select_query, dt) = True Then
            ReDim st(dt.Rows(0).Item(0).ToString)
        End If
    End Sub
    Sub clear()
        txtSname.Text = ""
        txtSID.Text = ""
        rdbtnImaging.Checked = True
        btnREMOVE.Enabled = False
        cmb_Stype.Text = ""
    End Sub
    Sub form()
        clear()
        countVal()
        cmb_Service_type()
        lv_Stype.Clear()
        form_stype_lv()
        Load_Stype_lv()
    End Sub
    Sub clear2()
        txtScatID.Text = ""
        txtScat.Text = ""
        Button1.Enabled = False
    End Sub
    Sub form2()
        clear2()
        lv_Scat.Clear()
        form_scat_lv()
        Load_Scat_lv()
    End Sub
    Private Sub frm_serviceType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form()
        form2()
    End Sub

    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        clear()
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If txtSID.Text = "" Then
            edit_query = "insert into service_type_tbl values(null,'" & service_class & "', '" + txtSname.Text + "', '" + stvar + "', 'Active')"
        Else
            edit_query = "update service_type_tbl set stype_class = '" & service_class & "', stype_name = '" + txtSname.Text + "', scat_id = '" + stvar + "' where stype_id = '" + txtSID.Text + "'"
        End If
        If conn.ModRec(edit_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form()
        End If
    End Sub

    Private Sub btnREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMOVE.Click
        Dim remove_query As String = ""
        If txtSID.Text = "" Then

        Else
            remove_query = "update service_type_tbl set status = 'Inactive' where stype_id = '" + txtSID.Text + "'"
        End If
        If conn.ModRec(remove_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form()
        End If
    End Sub
    Private Sub lv_stype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Stype.SelectedIndexChanged
        With lv_Stype
            txtSID.Text = .SelectedItems(0).SubItems(1).Text
            txtSname.Text = .SelectedItems(0).SubItems(2).Text
            cmb_Stype.Text = .SelectedItems(0).SubItems(3).Text

            Dim select_query As String
            Dim dt As New DataTable
            select_query = "select stype_class from service_type_tbl where stype_id = '" + txtSID.Text + "'"
            If conn.SelectRec(select_query, dt) = True Then
                service_class = dt.Rows(0).Item(0).ToString
                If service_class = "Imaging" Then
                    rdbtnImaging.Checked = True
                Else
                    rdbtnLab.Checked = True
                End If
            End If

            btnREMOVE.Enabled = True
            lv_Stype.Clear()
            form_stype_lv()
            Load_Stype_lv()
        End With
    End Sub

    Private Sub cmb_Stype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Stype.SelectedIndexChanged
        With cmb_Stype
            stvar = st(.SelectedIndex)
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtScatID.Text = "" Then
            edit_query = "insert into service_category_tbl values(null, '" + txtScat.Text + "', 'Active')"
        Else
            edit_query = "Update service_category_tbl set scat_name ='" & txtScat.Text & "' where scat_id = '" & txtScatID.Text & "'"
        End If
        If conn.ModRec(edit_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form2()
            cmb_Service_type()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim remove_query As String = ""
        If txtScatID.Text = "" Then

        Else
            remove_query = "Update service_category_tbl set status ='Inactive' where scat_id = '" & txtScatID.Text & "'"
        End If
        If conn.ModRec(remove_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form2()
            cmb_Service_type()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear2()
    End Sub

    Private Sub lv_Scat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Scat.SelectedIndexChanged
        With lv_Scat
            txtScatID.Text = .SelectedItems(0).SubItems(1).Text
            txtScat.Text = .SelectedItems(0).SubItems(2).Text
            Button1.Enabled = True
            lv_Scat.Clear()
            form_scat_lv()
            Load_Scat_lv()
        End With
    End Sub

    Private Sub rdbtnImaging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnImaging.CheckedChanged
        If rdbtnImaging.Checked = True Then
            service_class = "Imaging"
        End If
    End Sub

    Private Sub rdbtnLab_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnLab.CheckedChanged
        If rdbtnLab.Checked = True Then
            service_class = "Laboratory"
        End If
    End Sub
End Class