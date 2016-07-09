Option Explicit Off
Public Class frm_Staff

    Private Sub frm_Staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form()
    End Sub

    Dim conn As New HQ_Connection
    ''Function
    Sub clear()
        txtID.Text = ""
        txtstaff.Text = ""
        btnREMOVE.Enabled = False
    End Sub
    Sub form()
        clear()
        lv_staff.Clear()
        form_staff_lv()
        Load_staff_lv()
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        clear()
    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtID.Text = "" Then
            If txtstaff.Text = "" Or txtstaff.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stradd As String = "Insert into staff_tbl(record_id,name,status)values(null,'" & txtstaff.Text & "','Active')"
                If conn.ModRec(stradd) = True Then
                    form()
                    MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            If txtstaff.Text = "" Or txtstaff.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                edit_query = "Update staff_tbl set name ='" & txtstaff.Text & "' where record_id = '" & txtID.Text & "'"
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
            remove_query = "Update staff_tbl set status ='Inactive' where record_id = '" & txtID.Text & "'"
            If conn.ModRec(remove_query) = True Then
                form()
                MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub lv_staff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_staff.SelectedIndexChanged
        With lv_staff
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            txtstaff.Text = .SelectedItems(0).SubItems(2).Text
            btnREMOVE.Enabled = True
            lv_staff.Clear()
            form_staff_lv()
            Load_staff_lv()
        End With
    End Sub
End Class