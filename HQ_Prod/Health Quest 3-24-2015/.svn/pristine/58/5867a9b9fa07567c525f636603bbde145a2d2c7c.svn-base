Option Explicit Off
Public Class frm_user
    Dim conn As New HQ_Connection
    Public txtret As String
    Dim usercount As Integer = 0

    ''Function
    Sub clear()
        txtID.Text = ""
        txtName.Text = ""
        txtContact.Text = ""
        cmb_pos.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        txtRpass.Text = ""
        btnREMOVE.Enabled = False
    End Sub
    Sub form()
        clear()
        lv_User.Clear()
        form_user_lv()
        Load_user_lv()
    End Sub
    Private Sub frm_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtret = "" Then
            form()
            Me.CenterToParent()
        Else
            Me.CenterToParent()
        End If

    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        clear()
    End Sub

    Private Sub btnSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAVE.Click
        If txtID.Text = "" Then
            If txtUser.Text = "" Or txtUser.Text = " " Or txtPass.Text = "" Or txtPass.Text = " " Or txtRpass.Text = "" Or txtRpass.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If txtPass.Text <> txtRpass.Text Then
                    MessageBox.Show("Password did not match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim stradd As String = "Insert into user_tbl(user_id,u_name,username,passwords,position,contact,status)values(null,'" & txtName.Text & "','" & txtUser.Text & "','" & txtPass.Text & "','" & cmb_pos.Text & "','" & txtContact.Text & "','Active')"
                    If conn.ModRec(stradd) = True Then
                        If txtret <> "" Then
                            MessageBox.Show("Adminstrator account save!, ReOpen the System", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                            frm_login.Show()
                        Else
                            form()
                            MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        Else
            If txtUser.Text = "" Or txtUser.Text = " " Or txtPass.Text = "" Or txtPass.Text = " " Or txtRpass.Text = "" Or txtRpass.Text = " " Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If txtPass.Text <> txtRpass.Text Then
                    MessageBox.Show("Password did not match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    edit_query = "Update user_tbl set u_name ='" & txtName.Text & "',username = '" & txtUser.Text & "', passwords = '" & txtPass.Text & "',position = '" & cmb_pos.Text & "', contact = '" & txtContact.Text & "' where user_id = '" & txtID.Text & "'"
                    If conn.ModRec(edit_query) = True Then
                        form()
                        MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMOVE.Click
        If txtID.Text = "" Then
        Else
            remove_query = "Update user_tbl set status ='Inactive' where user_id = '" & txtID.Text & "'"
            If conn.ModRec(remove_query) = True Then
                form()
                MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub lv_user_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_User.SelectedIndexChanged
        If usercount = 0 Then
            If lv_User.SelectedItems.Count = 0 Then
            ElseIf lv_User.SelectedItems.Count > 0 Then
                With lv_User
                    Dim input As String
                    Dim id As String
                    Dim uname As String
                    Dim pw As String

                    id = .SelectedItems(0).SubItems(1).Text
                    Dim dt As New DataTable
                    Dim select_query As String = "select u_name, passwords from user_tbl where user_id = '" & id & "' and status = 'Active'"
                    If conn.SelectRec(select_query, dt) = True Then
                        uname = (dt.Rows(0).Item(0).ToString())
                        pw = (dt.Rows(0).Item(1).ToString())

                        input = InputBox("In order to view, update or remove the selected user, you need to input its current password: ", "Verification for user " + uname, "", 600, 300)
                        If input = pw Then
                            MessageBox.Show("Access Granted.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtID.Text = .SelectedItems(0).SubItems(1).Text
                            txtName.Text = .SelectedItems(0).SubItems(2).Text
                            txtUser.Text = .SelectedItems(0).SubItems(3).Text
                            cmb_pos.Text = .SelectedItems(0).SubItems(5).Text
                            txtContact.Text = .SelectedItems(0).SubItems(6).Text
                            txtPass.Text = .SelectedItems(0).SubItems(4).Text
                            txtRpass.Text = .SelectedItems(0).SubItems(4).Text
                            btnREMOVE.Enabled = True
                        ElseIf input = "" Then
                        Else
                            MessageBox.Show("Access Denied.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End With
                usercount = 1
            End If
        Else
            usercount = 0
        End If
    End Sub
End Class