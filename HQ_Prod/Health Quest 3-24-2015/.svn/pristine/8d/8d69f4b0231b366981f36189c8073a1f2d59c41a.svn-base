Option Explicit Off
Module mod_authenticate
    Dim conn As New HQ_Connection
    Dim pos As Integer
    Dim years As Integer
    Dim counts As Integer = 0
    '' LOGIN
    Sub Authenticate_Administrator()
        Dim dt As New DataTable
        Dim strrec = "Select count(*) from user_tbl where position = 'ADMINISTRATOR' and status = 'Active'"
        If conn.SelectRec(strrec, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                With dt.Rows(i)
                    pos = Convert.ToInt64(.Item(0).ToString)
                    If pos = 0 Then
                        MessageBox.Show("There is no Set administrator in the System, Kindly Click Authenticate button to add One!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        frm_login.btnAu.Visible = True
                        frm_login.btnLogin.Visible = False
                        frm_login.btnEXIT.Visible = False
                    End If
                End With
            Next
        End If
        dt.Dispose()
    End Sub
    Sub Authenticate_user()
        If counts < 3 Then
            Dim dt As New DataTable
            Dim strrec = "Select * from user_tbl where Username = '" & frm_login.txtUser.Text & "' and Passwords = '" & frm_login.txtPass.Text & "' and status = 'Active'"
            If conn.SelectRec(strrec, dt) = True Then
                If dt.Rows.Count <> 0 Then
                    Report_InventoryForm.u_name = dt.Rows(0).Item(1).ToString
                    rpt_statement.uname = dt.Rows(0).Item(1).ToString
                    stat = dt.Rows(0).Item(4).ToString
                    Select Case stat
                        Case "ADMINISTRATOR"
                            MessageBox.Show("Successfully Log-in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            frm_login.txtUser.Text = "USERNAME"
                            frm_login.txtPass.Text = "PASSWORD"
                            MDI_Administrator.Show()
                            frm_login.Hide()
                            Exit Select
                        Case "Receptionist"
                            MessageBox.Show("Successfully Log-in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            frm_login.txtUser.Text = "USERNAME"
                            frm_login.txtPass.Text = "PASSWORD"
                            frm_receptionist.Show()
                            frm_login.Hide()
                            Exit Select
                        Case "Cashier"
                            MessageBox.Show("Successfully Log-in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            frm_login.txtUser.Text = "USERNAME"
                            frm_login.txtPass.Text = "PASSWORD"
                            frm_cashier.Show()
                            frm_login.Hide()
                            Exit Select
                        Case "Queue"
                            MessageBox.Show("Successfully Log-in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            frm_login.txtUser.Text = "USERNAME"
                            frm_login.txtPass.Text = "PASSWORD"
                            frm_queue.Show()
                            frm_login.Hide()
                            Exit Select
                    End Select
                Else
                    MessageBox.Show("Your password and username do not match, Please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    counts = counts + 1
                    frm_login.txtUser.Focus()
                    dt.Dispose()
                End If
            End If
        Else
        MessageBox.Show("You have exceeded the number of allowed attempts, The System is Closing", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        frm_login.Close()
        End If
    End Sub
End Module
