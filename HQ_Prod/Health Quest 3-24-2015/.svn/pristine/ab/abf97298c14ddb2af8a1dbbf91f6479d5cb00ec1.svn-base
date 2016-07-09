Option Explicit Off
Public Class frm_department
    Dim conn As New HQ_Connection

    ''Function
    Sub clear()
        txtDept.Text = ""
        txtDeptID.Text = ""
        btnREMOVE.Enabled = False
    End Sub
    Sub form()
        clear()
        lv_Dept.Clear()
        form_dept_lv()
        Load_dept_lv()
    End Sub
    Private Sub frm_department_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        form()
        Me.CenterToParent()

    End Sub

    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        clear()
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If txtDeptID.Text = "" Then
            edit_query = "insert into department_tbl values(null, '" + txtDept.Text + "', 'Active')"
        Else
            edit_query = "update department_tbl set dept_name = '" + txtDept.Text + "' where dept_id = '" + txtDeptID.Text+"'"
        End If
        If conn.ModRec(edit_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form()
        End If
    End Sub

    Private Sub lv_Dept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Dept.SelectedIndexChanged
        With lv_Dept
            txtDeptID.Text = .SelectedItems(0).SubItems(1).Text
            txtDept.Text = .SelectedItems(0).SubItems(2).Text
            btnREMOVE.Enabled = True
            lv_Dept.Clear()
            form_dept_lv()
            Load_dept_lv()
        End With
    End Sub

    Private Sub btnREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMOVE.Click
        Dim remove_query As String = ""
        If txtDeptID.Text = "" Then

        Else
            remove_query = "update department_tbl set status = 'Inactive' where dept_id = '" + txtDeptID.Text + "'"
        End If
        If conn.ModRec(remove_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form()
        End If
    End Sub
End Class