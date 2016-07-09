Public Class frm_login
    Dim conn As New HQ_Connection
    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        'Authenticate_Administrator(s)

        Dim select_query As String = "select * from hmo_tbl"
    End Sub
    Private Sub txtUser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Leave
        If txtUser.Text = "" Then
            txtUser.Text = "USERNAME"
        End If
    End Sub
    Private Sub txtPass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.Leave
        If txtPass.Text = "" Then
            txtPass.Text = "PASSWORD"
        End If
    End Sub
    Private Sub txtUser_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtUser.MouseClick
        txtUser.Text = ""
    End Sub
    Private Sub txtPass_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPass.MouseClick
        txtPass.Text = ""
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub txtLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Authenticate_user()
    End Sub

    Private Sub btnAu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAu.Click
        frm_user.txtret = "A"
        frm_user.btnSAVE.Text = "SAVE"
        frm_user.btnCANCEL.Enabled = False
        frm_user.btnREMOVE.Enabled = False
        frm_user.txtName.Enabled = True
        frm_user.txtContact.Enabled = True
        frm_user.cmb_pos.Enabled = False
        frm_user.cmb_pos.Text = "ADMINISTRATOR"
        frm_user.txtUser.Enabled = True
        frm_user.txtPass.Enabled = True
        frm_user.txtRpass.Enabled = True
        frm_user.txtName.Focus()
        frm_user.Show()
        Me.Hide()
    End Sub

End Class
