Public Class frm_playlist
    Dim conn As New HQ_Connection

    Sub marq_ms()
        Dim select_query As String = "select * from marquee"
        Dim dt As New DataTable
        If conn.SelectRec(select_query, dt) Then
            txtmarq.Text = dt.Rows(0).Item(1).ToString
        End If
    End Sub

    Sub lv_pl_data()
        With lv_pl
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("Path file", 513)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
        End With
    End Sub

    Sub lv_pl_rows()
        Dim dt As New DataTable
        Dim strrec = "select * from playlist_tbl"
        If conn.SelectRec(strrec, dt) = True Then
            lv_pl.Items.Clear()
            For i As Integer = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv_pl.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub frm_playlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lv_pl_data()
        lv_pl_rows()
        marq_ms()
    End Sub

    Private Sub lv_pl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_pl.SelectedIndexChanged
        With lv_pl
            If .SelectedItems.Count > 0 Then
                Dim select_query As String = "delete from playlist_tbl where playlist_id = '" + .SelectedItems(0).SubItems(0).Text + "'"
                If conn.ModRec(select_query) Then
                    lv_pl_rows()
                End If
            End If
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'mntr_que.playlist()
        mntr_que.marqueemsg()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim select_query As String = "update marquee set marq_msg = '" + txtmarq.Text + "' where id = '1'"
        If conn.ModRec(select_query) Then
            marq_ms()
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim file As String = Replace$(OpenFileDialog1.FileName.ToString, "\", "\\")
        Dim edit_query As String = "insert into playlist_tbl values(null, '" + file + "')"
        If conn.ModRec(edit_query) Then
            lv_pl_rows()
        End If
    End Sub
End Class