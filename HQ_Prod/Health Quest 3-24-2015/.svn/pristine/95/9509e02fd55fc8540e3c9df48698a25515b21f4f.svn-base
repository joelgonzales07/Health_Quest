Imports Microsoft.DirectX.AudioVideoPlayback
Public Class mntr_que
    Dim conn As New HQ_Connection
    Dim queuelistcont As Integer = 1
    Dim servicename As String = ""
    Dim serviceid(0) As String
    Dim labid(0) As String
    Dim docid() As String
    Dim servicecont As Integer = 0
    Dim queuescroll As Integer = 0
    Dim queuelvcount As Integer = 0
    Dim labscroll As Integer = 0
    Dim lablvcount As Integer = 0
    Dim conslvcount As Integer = 0
    Dim consscroll As Integer = 0
    Dim audioFile As Video
    Dim playlistarr(0) As String
    Dim playlistcount As Integer = 0
    Dim duration As Integer = 0
    Dim durcont As Integer = 0
    Dim countpl As Integer = 0

    Public Sub marqueemsg()
        Dim select_query As String = "select marq_msg from marquee"
        Dim dt As New DataTable
        If conn.SelectRec(select_query, dt) Then
            lblmarkee.Text = "    " & dt.Rows(0).Item(0).ToString & "    "
            Dim msize As Integer = lblmarkee.Width

        End If
    End Sub

    Public Sub playlist()
        playlistcount = 0
        durcont = 0
        countpl = 0
        duration = 0
        Dim select_query As String = "select playlist_path from playlist_tbl order by playlist_id"
        Dim dt As New DataTable
        If conn.SelectRec(select_query, dt) Then
            If dt.Rows.Count >= 1 Then
                countpl = dt.Rows.Count
                ReDim playlistarr(dt.Rows.Count - 1)
                For i As Integer = 0 To dt.Rows.Count - 1
                    playlistarr(i) = dt.Rows(i).Item(0).ToString
                Next
                audioFile = New Video(playlistarr(playlistcount))
                audioFile.Owner = Panel2
                Panel2.Size = New Point(712, 540)
                audioFile.Size = New Point(712, 540)
                audioFile.Play()
                duration = audioFile.Duration
            End If
        End If
    End Sub

    'Sub onqueue()
    '    servicecont = 0
    '    Dim select_query As String = "SELECT DISTINCT(SELECT service_id FROM testservice_tbl WHERE testservice_id = queue_tbl.testservice_id) AS `sid` FROM queue_tbl where status = 'Next' ORDER BY queue_id"
    '    Dim dtserv As New DataTable
    '    If conn.SelectRec(select_query, dtserv) Then
    '        ReDim serviceid(dtserv.Rows.Count - 1)
    '        For i As Integer = 0 To dtserv.Rows.Count - 1
    '            serviceid(i) = dtserv.Rows(i).Item(0).ToString
    '        Next
    '        dtserv.Dispose()
    '    End If
    'End Sub

    Sub imagingqueue()
        Dim select_query As String = "select distinct(service_id) from queue_tbl where status in ('Serving', 'Next') and (select stype_class from service_type_tbl where stype_id = queue_tbl.service_id) = 'Imaging' order by queue_id"
        Dim dtserv As New DataTable
        If conn.SelectRec(select_query, dtserv) Then
            ReDim serviceid(dtserv.Rows.Count)
            For i As Integer = 0 To dtserv.Rows.Count - 1
                serviceid(i) = dtserv.Rows(i).Item(0).ToString
            Next
            dtserv.Dispose()
            queue_lv_row()
        End If
    End Sub

    Sub queue_lv_data()
        With queue_lv
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("Now Serving", 272)
            .Columns.Add("Service", 272)
            .Columns(5).TextAlign = HorizontalAlignment.Center
            .Columns(4).TextAlign = HorizontalAlignment.Center
            .View = View.Details
            .FullRowSelect = True
            .GridLines = False
        End With
    End Sub

    Sub cons_lv_data()
        With cons_lv
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("Now Serving", 272)
            .Columns.Add("", 0)
            .Columns.Add("Physician", 272)
            .Columns(4).TextAlign = HorizontalAlignment.Center
            .Columns(2).TextAlign = HorizontalAlignment.Center
            .View = View.Details
            .FullRowSelect = True
            .GridLines = False
        End With
    End Sub

    Sub lab_lv_data()
        With lab_lv
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("Now Serving", 272)
            .Columns.Add("Service", 272)
            .Columns(5).TextAlign = HorizontalAlignment.Center
            .Columns(4).TextAlign = HorizontalAlignment.Center
            .View = View.Details
            .FullRowSelect = True
            .GridLines = False
        End With
    End Sub

    Sub lab_lv_row()
        Try
            Dim select_query As String = "select distinct(service_id) from queue_tbl where status in ('Serving', 'Next') and (select stype_class from service_type_tbl where stype_id = queue_tbl.service_id) = 'Laboratory' order by queue_id"
            Dim dtserv As New DataTable
            If conn.SelectRec(select_query, dtserv) Then
                ReDim labid(dtserv.Rows.Count)
                For i As Integer = 0 To dtserv.Rows.Count - 1
                    labid(i) = dtserv.Rows(i).Item(0).ToString
                Next
                dtserv.Dispose()
                lab_lv.Items.Clear()
                For x As Integer = 0 To labid.Length - 1
                    Dim serving = True
                    Dim dtservtbl As New DataTable
                    select_query = "SELECT queue_id, testservice_id, (SELECT test_id FROM testservice_tbl WHERE testservice_id = queue_tbl.testservice_id) AS `testid`, (SELECT patient_number FROM patient_test_tbl WHERE id = `testid`) AS `pnum`, (SELECT CONCAT(lname, ', ', left(fname, 1), '. ', left(mname, 1), '.') FROM patient_tbl WHERE patient_number = `pnum`) AS `name`, (SELECT stype_name FROM service_type_tbl WHERE stype_id = queue_tbl.service_id) as `sname` FROM queue_tbl WHERE service_id = '" + labid(x) + "' and status = 'Serving' ORDER BY queue_id limit 1"
                    If conn.SelectRec(select_query, dtservtbl) = True Then
                        If dtservtbl.Rows.Count = 0 Then
                            serving = False
                            dtservtbl.Dispose()
                            select_query = "SELECT queue_id, testservice_id, (SELECT test_id FROM testservice_tbl WHERE testservice_id = queue_tbl.testservice_id) AS `testid`, (SELECT patient_number FROM patient_test_tbl WHERE id = `testid`) AS `pnum`, (SELECT CONCAT(lname, ', ', left(fname, 1), '. ', left(mname, 1), '.') FROM patient_tbl WHERE patient_number = `pnum`) AS `name`, (SELECT stype_name FROM service_type_tbl WHERE stype_id = queue_tbl.service_id) as `sname` FROM queue_tbl WHERE service_id = '" + labid(x) + "' and status = 'Next' ORDER BY queue_id limit 1"
                            If conn.SelectRec(select_query, dtservtbl) = True Then

                            End If
                        End If
                        Dim lv As New ListViewItem
                        With dtservtbl.Rows(0)
                            lv.Text = .Item(0).ToString
                            lv.SubItems.Add(.Item(1).ToString)
                            lv.SubItems.Add(.Item(2).ToString)
                            lv.SubItems.Add(.Item(3).ToString)
                            If Convert.ToInt32(.Item(0).ToString) < 0 Then
                                lv.SubItems.Add("(P)" & .Item(4).ToString)
                            Else
                                lv.SubItems.Add(.Item(4).ToString)
                            End If
                            lv.SubItems.Add(.Item(5).ToString)
                        End With
                        If serving Then
                            lv.BackColor = Color.LightSteelBlue
                        Else
                            lv.BackColor = Color.Green
                        End If
                        lab_lv.Items.Add(lv)
                        dtservtbl.Dispose()
                    End If
                Next
                lablvcount = lab_lv.Items.Count - 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub cons_lv_row()
        Dim doccont As Integer = 0
        Dim select_query As String = "SELECT DISTINCT(SELECT doc_id FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) AS `docid` FROM consqueue_tbl WHERE STATUS in ('Serving', 'Next') AND (SELECT doc_id FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) != '' ORDER BY consqueue_id"
        Dim dtserv As New DataTable
        If conn.SelectRec(select_query, dtserv) Then
            ReDim docid(dtserv.Rows.Count)
            doccont = dtserv.Rows.Count - 1
            For i As Integer = 0 To dtserv.Rows.Count - 1
                docid(i) = dtserv.Rows(i).Item(0).ToString
            Next
            dtserv.Dispose()
            cons_lv.Items.Clear()
            For i As Integer = 0 To doccont
                Dim serving As Boolean = True
                Dim dtcons As New DataTable
                select_query = "SELECT consqueue_id, (SELECT patient_number FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) AS `pnum`, (SELECT CONCAT(lname, ', ', left(fname, 1), '. ', left(mname, 1), '.') FROM patient_tbl WHERE patient_number = `pnum`), (SELECT doc_id FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) AS `docid`, (SELECT doc_name FROM doctor_tbl WHERE doc_id = `docid`) AS `docname` FROM consqueue_tbl WHERE STATUS = 'Serving' AND (SELECT doc_id FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) = '" + docid(i) + "' ORDER BY consqueue_id LIMIT 1"
                Dim lv As New ListViewItem
                If conn.SelectRec(select_query, dtcons) Then
                    If dtcons.Rows.Count = 0 Then
                        serving = False
                        select_query = "SELECT consqueue_id, (SELECT patient_number FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) AS `pnum`, (SELECT CONCAT(lname, ', ', left(fname, 1), '. ', left(mname, 1), '.') FROM patient_tbl WHERE patient_number = `pnum`), (SELECT doc_id FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) AS `docid`, (SELECT doc_name FROM doctor_tbl WHERE doc_id = `docid`) AS `docname` FROM consqueue_tbl WHERE STATUS = 'Next' AND (SELECT doc_id FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) = '" + docid(i) + "' ORDER BY consqueue_id LIMIT 1"
                        dtcons.Dispose()
                        If conn.SelectRec(select_query, dtcons) Then

                        End If
                    End If
                    lv.Text = dtcons.Rows(0).Item(0).ToString
                    lv.SubItems.Add(dtcons.Rows(0).Item(1).ToString)
                    If Convert.ToInt32(dtcons.Rows(0).Item(0).ToString) < 0 Then
                        lv.SubItems.Add("(P)" & dtcons.Rows(0).Item(2).ToString)
                    Else
                        lv.SubItems.Add(dtcons.Rows(0).Item(2).ToString)
                    End If
                    lv.SubItems.Add(dtcons.Rows(0).Item(3).ToString)
                    lv.SubItems.Add(dtcons.Rows(0).Item(4).ToString)
                    If serving Then
                        lv.BackColor = Color.LightSteelBlue
                    Else
                        lv.BackColor = Color.Green
                    End If
                    cons_lv.Items.Add(lv)
                    dtcons.Dispose()
                End If
            Next
            conslvcount = cons_lv.Items.Count - 1
        End If
    End Sub

    Sub queue_lv_row()
        Try
            'Dim select_query As String = "SELECT stype_name FROM service_type_tbl WHERE stype_id = '" + serviceid(servicecont) + "'"
            'Dim dtserv As New DataTable
            'If conn.SelectRec(select_query, dtserv) Then
            '    lblservice.Text = dtserv.Rows(0).Item(0).ToString
            '    dtserv.Dispose()
            'End If
            'select_query = "SELECT COUNT(testservice_id) FROM queue_tbl WHERE (SELECT service_id FROM testservice_tbl WHERE testservice_id = queue_tbl.testservice_id) = '" + serviceid(servicecont) + "' and status = 'Queued' ORDER BY queue_id"
            'Dim dtservcount As New DataTable
            'If conn.SelectRec(select_query, dtservcount) Then
            '    lv_noti.Text = dtservcount.Rows(0).Item(0).ToString
            '    dtservcount.Dispose()
            'End If
            queue_lv.Items.Clear()
            For x As Integer = 0 To serviceid.Length - 1
                Dim serving As Boolean = True
                Dim dtservtbl As New DataTable
                Dim select_query As String = "SELECT queue_id, testservice_id, (SELECT test_id FROM testservice_tbl WHERE testservice_id = queue_tbl.testservice_id) AS `testid`, (SELECT patient_number FROM patient_test_tbl WHERE id = `testid`) AS `pnum`, (SELECT CONCAT(lname, ', ', left(fname, 1), '. ', left(mname, 1), '.') FROM patient_tbl WHERE patient_number = `pnum`) AS `name`, (SELECT stype_name FROM service_type_tbl WHERE stype_id = queue_tbl.service_id) as `sname` FROM queue_tbl WHERE service_id = '" + serviceid(x) + "' and status = 'Serving' ORDER BY queue_id limit 1"
                If conn.SelectRec(select_query, dtservtbl) = True Then
                    If dtservtbl.Rows.Count = 0 Then
                        serving = False
                        select_query = "SELECT queue_id, testservice_id, (SELECT test_id FROM testservice_tbl WHERE testservice_id = queue_tbl.testservice_id) AS `testid`, (SELECT patient_number FROM patient_test_tbl WHERE id = `testid`) AS `pnum`, (SELECT CONCAT(lname, ', ', left(fname, 1), '. ', left(mname, 1), '.') FROM patient_tbl WHERE patient_number = `pnum`) AS `name`, (SELECT stype_name FROM service_type_tbl WHERE stype_id = queue_tbl.service_id) as `sname` FROM queue_tbl WHERE service_id = '" + serviceid(x) + "' and status = 'Next' ORDER BY queue_id limit 1"
                        dtservtbl.Dispose()
                        If conn.SelectRec(select_query, dtservtbl) = True Then

                        End If
                    End If
                    Dim lv As New ListViewItem
                    With dtservtbl.Rows(0)
                        lv.Text = .Item(0).ToString
                        lv.SubItems.Add(.Item(1).ToString)
                        lv.SubItems.Add(.Item(2).ToString)
                        lv.SubItems.Add(.Item(3).ToString)
                        If Convert.ToInt32(.Item(0).ToString) < 0 Then
                            lv.SubItems.Add("(P)" & .Item(4).ToString)
                        Else
                            lv.SubItems.Add(.Item(4).ToString)
                        End If
                        lv.SubItems.Add(.Item(5).ToString)
                    End With
                    If serving Then
                        lv.BackColor = Color.LightSteelBlue
                    Else
                        lv.BackColor = Color.Green
                    End If
                    queue_lv.Items.Add(lv)
                    dtservtbl.Dispose()
                End If
            Next
            queuelvcount = queue_lv.Items.Count - 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mntr_que_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        audioFile.Stop()
        Me.Dispose()
    End Sub

    Private Sub mntr_que_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'playlist()
        marqueemsg()
        imagingqueue()
        cons_lv_data()
        queue_lv_data()
        cons_lv_row()
        lab_lv_data()
        lab_lv_row()
        tmrqueuelistscroll.Start()
        tmrcons.Start()
        tmrlab.Start()
        tmrqueue.Start()
        lbldate.Text = DateTime.Now.ToLongDateString
        lbltime.Text = DateTime.Now.ToLongTimeString
        lblmarkee.Location = New Point(1254, 0)
        tmrmarkee.Start()
    End Sub

    Private Sub tmrqueue_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrqueue.Tick
        lbltime.Text = DateTime.Now.ToLongTimeString

        If countpl >= 1 Then
            If duration + 2 < durcont Then
                durcont = 0
                playlistcount = playlistcount + 1
                If playlistcount > playlistarr.Length - 1 Then
                    playlistcount = 0
                End If
                audioFile.Stop()
                audioFile.Dispose()
                Panel2.Update()
                audioFile = New Video(playlistarr(playlistcount))
                audioFile.Owner = Panel2
                Panel2.Size = New Point(712, 540)
                audioFile.Size = New Point(712, 540)
                audioFile.Play()
                duration = audioFile.Duration
            Else
                durcont = durcont + 1
            End If
        End If
    End Sub

    Private Sub Tmrqueuelistscroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrqueuelistscroll.Tick
        If queuelvcount > 0 Then
            If queuescroll <= queuelvcount Then
                queue_lv.EnsureVisible(queuescroll)
                queue_lv.Update()
                queuescroll = queuescroll + 1
            Else
                tmrqueuelistscroll.Stop()
                imagingqueue()
                queuescroll = 0
                queue_lv.EnsureVisible(queuescroll)
                queue_lv.Update()
                tmrqueuelistscroll.Start()
            End If
        Else
            imagingqueue()
        End If
    End Sub

    Private Sub tmrcons_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrcons.Tick
        If conslvcount > 0 Then
            If consscroll <= conslvcount Then
                cons_lv.EnsureVisible(consscroll)
                cons_lv.Update()
                consscroll = consscroll + 1
            Else
                tmrcons.Stop()
                cons_lv_row()
                consscroll = 0
                cons_lv.EnsureVisible(consscroll)
                cons_lv.Update()
                tmrcons.Start()
            End If
        Else
            cons_lv_row()
        End If

    End Sub

    Private Sub tmrmarkee_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrmarkee.Tick
        If lblmarkee.Location.X < Panel1.Location.X - lblmarkee.Width Then
            lblmarkee.Location = New Point(Panel1.Location.X + Panel1.Width, 0)
        End If
        lblmarkee.Location = New Point(lblmarkee.Location.X - 2, 0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub tmrlab_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrlab.Tick
        If lablvcount > 0 Then
            If labscroll <= lablvcount Then
                lab_lv.EnsureVisible(labscroll)
                lab_lv.Update()
                labscroll = labscroll + 1
            Else
                tmrlab.Stop()
                lab_lv_row()
                labscroll = 0
                lab_lv.EnsureVisible(labscroll)
                lab_lv.Update()
                tmrlab.Start()
            End If
        Else
            lab_lv_row()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            frm_playlist.Show()
            audioFile.Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class