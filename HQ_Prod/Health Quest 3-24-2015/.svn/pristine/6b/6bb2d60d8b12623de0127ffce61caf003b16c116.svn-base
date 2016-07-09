Option Explicit Off
Public Class frm_consultation
    Dim conn As New HQ_Connection
    ''Function
    Sub clear()
        txtID.Text = ""
        txtCons.Text = ""
        btnREMOVE.Enabled = False
    End Sub
    Sub form()
        clear()
        lv_Cons.Clear()
        form_cons_lv()
        Load_cons_lv()
    End Sub
    Private Sub frm_consultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        form()
        Me.CenterToParent()
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        clear()
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtID.Text = "" Then
            If txtCons.Text = "" Or txtCons.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stradd As String = "Insert into consultation_tbl(cons_id,cons_name,status)values(null,'" & txtCons.Text & "','Active')"
                If conn.ModRec(stradd) = True Then
                    form()
                    MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If txtCons.Text = "" Or txtCons.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                edit_query = "Update consultation_tbl set cons_name ='" & txtCons.Text & "' where cons_id = '" & txtID.Text & "'"
                If conn.ModRec(edit_query) = True Then
                    form()
                    MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Private Sub lv_Cons_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Cons.SelectedIndexChanged
        With lv_Cons
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            txtCons.Text = .SelectedItems(0).SubItems(2).Text
            btnREMOVE.Enabled = True
            lv_Cons.Clear()
            form_cons_lv()
            Load_cons_lv()
        End With

    End Sub

    Private Sub btnREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMOVE.Click
        If txtID.Text = "" Then
        Else
            remove_query = "Update consultation_tbl set status ='Inactive' where cons_id = '" & txtID.Text & "'"
            If conn.ModRec(remove_query) = True Then
                form()
                MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class