Public Class frm_readersfee
    Dim conn As New HQ_Connection
    Sub check()
        Dim select_query As String = "select perc from readerfee_tbl"
        Dim dt As New DataTable
        If conn.SelectRec(select_query, dt) = True Then
            If dt.Rows.Count > 0 Then
                txtPerc.Text = dt.Rows(0).Item(0).ToString
            Else
                txtPerc.Text = ""
            End If
        End If
        dt.Dispose()
    End Sub
    Private Sub frm_readersfee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        check()
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        If txtPerc.Text = "" Or txtPerc.Text = " " Then
            MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim select_query As String = "select perc from readerfee_tbl"
            Dim dt As New DataTable
            If conn.SelectRec(select_query, dt) = True Then
                If dt.Rows.Count > 0 Then
                    Dim stradd As String = "update readerfee_tbl set perc = '" & txtPerc.Text & "'"
                    If conn.ModRec(stradd) = True Then
                        MessageBox.Show("Setup Success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    Dim stradd As String = "Insert into readerfee_tbl values(null,'" & txtPerc.Text & "')"
                    If conn.ModRec(stradd) = True Then
                        MessageBox.Show("Setup Success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
            dt.Dispose()
        End If
    End Sub
End Class