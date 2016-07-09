Option Explicit Off
Public Class frm_specialization
    Dim conn As New HQ_Connection
    ''' FUNTION
    Sub clear()
        btnREMOVE.Enabled = False
        txtSpec.Text = ""
        txtSpecID.Text = ""
    End Sub
    Sub form()
        clear()
        lv_Spec.Clear()
        form_spec_lv()
        Load_spec_lv()
    End Sub

    Private Sub frm_specialization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        form()
        Me.CenterToParent()
    End Sub

    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        clear()
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If txtSpecID.Text = "" Then
            edit_query = "insert into specialization_tbl values(null, '" + txtSpec.Text + "', 'Active')"
        Else
            edit_query = "Update specialization_tbl set spec_name ='" & txtSpec.Text & "' where spec_id = '" + txtSpecID.Text +"'"
        End If
        If conn.ModRec(edit_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form()
        End If
    End Sub

    Private Sub btnREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMOVE.Click
        Dim remove_query As String = ""
        If txtSpecID.Text = "" Then

        Else
            remove_query = "Update specialization_tbl set status = 'Inactive' where spec_id = '" + txtSpecID.Text + "'"
        End If
        If conn.ModRec(remove_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form()
        End If
    End Sub

    Private Sub lv_Dept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Spec.SelectedIndexChanged
        With lv_Spec
            txtSpecID.Text = .SelectedItems(0).SubItems(1).Text
            txtSpec.Text = .SelectedItems(0).SubItems(2).Text
            btnREMOVE.Enabled = True
            lv_Spec.Clear()
            form_spec_lv()
            Load_spec_lv()
        End With

    End Sub
End Class