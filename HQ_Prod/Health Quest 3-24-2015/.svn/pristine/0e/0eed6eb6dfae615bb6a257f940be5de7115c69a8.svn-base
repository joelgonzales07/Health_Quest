Option Explicit Off
Public Class frm_adminAuthenticate
    Dim conn As New HQ_Connection
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim dt As New DataTable
        Dim strrec = "Select * from user_tbl where position = 'ADMINISTRATOR' and passwords = '" & txtpassword.Text & "'"
        If conn.SelectRec(strrec, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)

                MessageBox.Show("Revoke Granted, Click the certain Services that you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                frm_receptionist.lv_user.Enabled = True
                Me.Hide()
                frm_receptionist.Show()
                Exit Sub
            Next
        End If
        dt.Dispose()
        MessageBox.Show("Revoke Granted Fail, you have input wrong password ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub frm_adminAuthenticate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        txtpassword.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub
End Class