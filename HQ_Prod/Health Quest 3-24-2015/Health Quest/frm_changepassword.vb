Option Explicit Off
Public Class frm_changepassword
    Dim conn As New HQ_Connection
    Dim years As String
    Dim months As Integer

    ''Function
    Sub form()
        txtCpass.Text = ""
        txtNpass.Text = ""
        txtCNpass.Text = ""

        txtCpass.Enabled = False
        txtNpass.Enabled = False
        txtCNpass.Enabled = False
        btnEDIT.Enabled = False
        btnEDIT.Text = "EDIT"
        btnCLOSE.Text = "CLOSE"
        lv_User.Clear()
        form_pass_lv()
        Load_pass_lv()

    End Sub

    Private Sub frm_changepassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        form()
        Me.CenterToParent()

    End Sub


    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        If btnCLOSE.Text = "CLOSE" Then
            Me.Hide()
        Else
            form()

        End If
    End Sub

  

    Private Sub btnEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDIT.Click
        If btnEDIT.Text = "UPDATE" Then
            btnEDIT.Text = "SAVE"
            txtCpass.Focus()
        Else
            If txtCpass.Text = "" Or txtCpass.Text = " " Or txtNpass.Text = "" Or txtNpass.Text = " " Or txtCNpass.Text = "" Or txtCNpass.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If txtNpass.Text <> txtCNpass.Text Then
                    MessageBox.Show("Password Mismatch", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If dtp1.Value.Month > 6 Then
                        months = dtp1.Value.Month
                        months = 12 - months
                        months = 6 - months
                        years = Convert.ToString(dtp1.Value.Year + 1) + "-" + Convert.ToString(months) + "-" + Convert.ToString(dtp1.Value.Day)
                    Else
                        months = dtp1.Value.Month
                        months = months + 6
                        years = Convert.ToString(dtp1.Value.Year) + "-" + Convert.ToString(months) + "-" + Convert.ToString(dtp1.Value.Day)
                    End If
                    edit_query = "Update user_tbl set passwords ='" & txtNpass.Text & "',xpr_date = '" & years & "' where user_id = '" & txtUID.Text & "'"
                    If conn.ModRec(edit_query) = True Then
                        MessageBox.Show("Change Password Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Call form()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub lv_user_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_user.SelectedIndexChanged
        With lv_User
            txtUID.Text = .SelectedItems(0).SubItems(0).Text
            txtCpass.Text = .SelectedItems(0).SubItems(4).Text
            txtCpass.Enabled = True
            txtNpass.Enabled = True
            txtCNpass.Enabled = True
            btnEDIT.Enabled = True
            btnCLOSE.Text = "CANCEL"
            lv_User.Clear()
            form_pass_lv()
            Load_pass_lv()
        End With
    End Sub
End Class