Public Class frm_queue
    Dim conn As New HQ_Connection
    Public serv() As String
    Public servid As String = ""
    Dim countdt As Integer
    Dim status As String = ""
    Dim id As String = ""
    Dim consid As String = ""

    Sub identifynext_cons()
        Dim select_query As String = "select distinct(select doc_id from patient_test_tbl where id = consqueue_tbl.test_id) from consqueue_tbl order by consqueue_id"
        Dim dtsel As New DataTable
        If conn.SelectRec(select_query, dtsel) Then
            For i As Integer = 0 To dtsel.Rows.Count - 1
                With dtsel.Rows(i)
                    select_query = "select consqueue_id, test_id, status from consqueue_tbl where (select doc_id from patient_test_tbl where id = consqueue_tbl.test_id) = '" + .Item(0).ToString + "' and status = 'Next' order by consqueue_id limit 1"
                    Dim dtsel2 As New DataTable
                    If conn.SelectRec(select_query, dtsel2) Then
                        If dtsel2.Rows.Count = 0 Then
                            select_query = "select consqueue_id, test_id, status from consqueue_tbl where (select doc_id from patient_test_tbl where id = consqueue_tbl.test_id) = '" + .Item(0).ToString + "' and status = 'Queued' order by consqueue_id limit 1"
                            Dim dtsel1 As New DataTable
                            If conn.SelectRec(select_query, dtsel1) Then
                                If dtsel1.Rows.Count > 0 Then
                                    If dtsel1.Rows(0).Item(2).ToString = "Queued" Then
                                        Dim mod_query As String = "update consqueue_tbl set status = 'Next' where consqueue_id = '" + dtsel1.Rows(0).Item(0).ToString + "'"
                                        If conn.ModRec(mod_query) Then
                                            cons_data()
                                        End If
                                    End If
                                End If
                            End If
                            dtsel1.Dispose()
                        End If
                    End If
                    dtsel2.Dispose()
                End With
            Next
        End If
        dtsel.Dispose()
    End Sub

    Sub identifynext_serv()
        Dim select_query As String = "select distinct(service_id) from queue_tbl order by queue_id"
        Dim dtsel As New DataTable
        If conn.SelectRec(select_query, dtsel) Then
            For i As Integer = 0 To dtsel.Rows.Count - 1
                With dtsel.Rows(i)
                    select_query = "select queue_id, testservice_id, status from queue_tbl where service_id = '" + .Item(0).ToString + "' and status = 'Next' order by queue_id limit 1"
                    Dim dtsel2 As New DataTable
                    If conn.SelectRec(select_query, dtsel2) Then
                        If dtsel2.Rows.Count = 0 Then
                            select_query = "select queue_id, testservice_id, status from queue_tbl where service_id = '" + .Item(0).ToString + "' and status = 'Queued' order by queue_id limit 1"
                            Dim dtsel1 As New DataTable
                            If conn.SelectRec(select_query, dtsel1) Then
                                If dtsel1.Rows.Count > 0 Then
                                    If dtsel1.Rows(0).Item(2).ToString = "Queued" Then
                                        Dim mod_query As String = "update queue_tbl set status = 'Next' where queue_id = '" + dtsel1.Rows(0).Item(0).ToString + "'"
                                        If conn.ModRec(mod_query) Then
                                            search_lv_serv()
                                        End If
                                    End If
                                End If
                            End If
                            dtsel1.Dispose()
                        End If
                    End If
                    dtsel2.Dispose()
                End With
            Next
        End If
        dtsel.Dispose()
    End Sub

    Sub countserv()
        Dim select_query As String = ""
        Dim docdt As New DataTable
        select_query = "select count(status) from service_type_tbl where status = 'Active'"
        If conn.SelectRec(select_query, docdt) = True Then
            ReDim serv(docdt.Rows(0).Item(0).ToString)
        End If
    End Sub

    Sub cons_col()
        With lv_cons
            .Clear()
            .Columns.Add("consid", 0)
            .Columns.Add("Patient Number", 120)
            .Columns.Add("Patient's Name", 156)
            .Columns.Add("Doctor's Name", 156)
            .Columns.Add("Status", 80)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    Sub cons_data()
        consid = ""
        Dim select_query As String = "SELECT consqueue_id, (SELECT patient_number FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) AS `pnum`, (SELECT CONCAT(lname, ', ', fname, ' ', mname) FROM patient_tbl WHERE patient_number = `pnum`), (SELECT doc_id FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) AS `docid`, (SELECT CONCAT(doc_fname, ' ', doc_mname, ' ', doc_lname) AS doc_name FROM doctor_tbl WHERE doc_id = `docid`), status FROM consqueue_tbl WHERE (SELECT patient_number FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) LIKE '" + txtpnumcons.Text + "%' AND STATUS in ('Queued', 'Serving', 'Next') ORDER BY consqueue_id"
        Dim dtcons As New DataTable
        If conn.SelectRec(select_query, dtcons) Then
            lv_cons.Items.Clear()
            For i As Integer = 0 To dtcons.Rows.Count - 1
                Dim lv As New ListViewItem
                consid = dtcons.Rows(0).Item(0).ToString
                lv.Text = dtcons.Rows(i).Item(0).ToString
                lv.SubItems.Add(dtcons.Rows(i).Item(1).ToString)
                txtpnamecons.Text = dtcons.Rows(i).Item(2).ToString
                lv.SubItems.Add(dtcons.Rows(i).Item(2).ToString)
                txtdoc.Text = dtcons.Rows(i).Item(4).ToString
                lv.SubItems.Add(dtcons.Rows(i).Item(4).ToString)
                lv.SubItems.Add(dtcons.Rows(i).Item(5).ToString)
                lv_cons.Items.Add(lv)
            Next
            dtcons.Dispose()
        End If
    End Sub

    Sub search_lv_serv()
        Dim dt As New DataTable
        Dim strrec = "SELECT queue_id, (SELECT test_id FROM testservice_tbl WHERE testservice_id = queue_tbl.testservice_id) AS `testid`,(SELECT patient_number FROM patient_test_tbl WHERE id = `testid`) AS `pnum`,(SELECT CONCAT(lname, ', ', fname, ' ', mname) FROM patient_tbl WHERE patient_number = `pnum`),(SELECT stype_name FROM service_type_tbl WHERE stype_id = queue_tbl.service_id),`status`, (SELECT priority FROM patient_test_tbl WHERE id = `testid`) AS `priority?` FROM queue_tbl WHERE (SELECT patient_number FROM patient_test_tbl WHERE id = (SELECT test_id FROM testservice_tbl WHERE testservice_id = queue_tbl.testservice_id)) like '" + txtpnum.Text + "%' AND service_id like '" + servid + "%' and STATUS in ('Queued', 'Serving', 'Next') ORDER BY queue_id"
        If conn.SelectRec(strrec, dt) = True Then
            lv_queue.Items.Clear()
            txtpname.Text = ""
            countdt = dt.Rows.Count
            For i As Integer = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = dt.Rows(0).Item(0).ToString
                    id = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(i + 1)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    txtpname.Text = dt.Rows(0).Item(3).ToString
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    status = dt.Rows(0).Item(5).ToString
                    lv.SubItems.Add(.Item(6).ToString)
                    lv_queue.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
        If txtpnum.Text = "" And cmb_service.Text = "" Then
            txtpname.Text = ""
        End If
    End Sub

    Private Sub frm_queue_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_login.Show()
    End Sub

    Private Sub frm_queue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        countserv()
        cmb_queue_serv()
        form_queue_lv()
        load_queue_lv()
        cons_col()
        cons_data()
        txtpnamecons.Text = ""
        txtdoc.Text = ""
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If countdt = 1 Then
            Dim result1 As DialogResult = MessageBox.Show("Patient Served?", "Important Question", MessageBoxButtons.YesNo)
            If result1 = Windows.Forms.DialogResult.Yes Then
                Dim edit_query As String = "update queue_tbl set status = 'Served' where queue_id = '" + id + "'"
                If conn.ModRec(edit_query) = True Then
                    Dim select_query As String = "select * from queue_tbl where status = 'Delayed'"
                    Dim dtdt As New DataTable
                    If conn.SelectRec(select_query, dtdt) Then
                        For i As Integer = 0 To dtdt.Rows.Count - 1
                            select_query = "SELECT (SELECT patient_number FROM patient_test_tbl WHERE id = testservice_tbl.test_id) FROM testservice_tbl WHERE testservice_id = '" + dtdt.Rows(i).Item(1).ToString + "'"
                            Dim dtsel As New DataTable
                            If conn.SelectRec(select_query, dtsel) Then
                                If dtsel.Rows(0).Item(0).ToString = txtpnum.Text Then
                                    edit_query = "update queue_tbl set status = 'Queued' where queue_id = '" + dtdt.Rows(i).Item(0).ToString + "'"
                                    If conn.ModRec(edit_query) Then

                                    End If
                                End If
                            End If
                            dtsel.Dispose()
                        Next
                        dtdt.Dispose()
                    End If
                    MessageBox.Show("Patient queue status successfully changed.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frm_queueitem.Show()
                    txtpnum.Text = ""
                    cmb_service.Text = ""
                    txtpname.Text = ""
                End If
            End If
            identifynext_serv()
        End If
    End Sub

    Private Sub btnDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDept.Click
        If countdt = 1 Then
            Dim result1 As DialogResult = MessageBox.Show("Delay patient queueing?", "Important Question", MessageBoxButtons.YesNo)
            If result1 = Windows.Forms.DialogResult.Yes Then
                Dim edit_query As String = "update queue_tbl set status = 'Delayed' where queue_id = '" + id + "'"
                If conn.ModRec(edit_query) = True Then
                    MessageBox.Show("Patient queue status successfully changed.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpnum.Text = ""
                    cmb_service.Text = ""
                    txtpname.Text = ""
                End If
            End If
            identifynext_serv()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub cmb_service_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_service.SelectedIndexChanged
        servid = serv(cmb_service.SelectedIndex)
        search_lv_serv()
    End Sub

    Private Sub cmb_service_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_service.TextChanged
        If cmb_service.Text = "" Then
            form_queue_lv()
            load_queue_lv()
            servid = ""
            search_lv_serv()
        End If
    End Sub

    Private Sub txtpnum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpnum.TextChanged
        search_lv_serv()
    End Sub

    Private Sub btnq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnq.Click
        mntr_que.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result1 As DialogResult = MessageBox.Show("Queue patient?", "Important Question", MessageBoxButtons.YesNo)
        If result1 = Windows.Forms.DialogResult.Yes Then
            Dim select_query As String = "select * from queue_tbl where status = 'Delayed'"
            Dim dtdt As New DataTable
            If conn.SelectRec(select_query, dtdt) Then
                For i As Integer = 0 To dtdt.Rows.Count - 1
                    select_query = "SELECT (SELECT patient_number FROM patient_test_tbl WHERE id = testservice_tbl.test_id) FROM testservice_tbl WHERE testservice_id = '" + dtdt.Rows(i).Item(1).ToString + "'"
                    Dim dtsel As New DataTable
                    If conn.SelectRec(select_query, dtsel) Then
                        If dtsel.Rows(0).Item(0).ToString = txtpnum.Text Then
                            Dim edit_query As String = "update queue_tbl set status = 'Queued' where queue_id = '" + dtdt.Rows(i).Item(0).ToString + "'"
                            If conn.ModRec(edit_query) Then

                            End If
                        End If
                    End If
                    dtsel.Dispose()
                Next
                dtdt.Dispose()
            End If
            MessageBox.Show("Patient queue status successfully changed.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpnum.Text = ""
            cmb_service.Text = ""
            txtpname.Text = ""
            identifynext_serv()
        End If
    End Sub

    Private Sub lv_queue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_queue.SelectedIndexChanged
        With lv_queue
            If .SelectedItems.Count > 0 Then
                Dim select_query As String = "select queue_id, testservice_id, (select stype_name from service_type_tbl where stype_id = queue_tbl.service_id), status from queue_tbl where queue_id = '" + .SelectedItems(0).SubItems(0).Text + "'"
                Dim ddt As New DataTable
                If conn.SelectRec(select_query, ddt) Then
                    select_query = "SELECT test_id, (SELECT patient_number FROM patient_test_tbl WHERE id = testservice_tbl.test_id) AS `pnum`, (SELECT CONCAT(lname, ', ', fname, ' ', mname) FROM patient_tbl WHERE patient_number = `pnum`), service_id, (SELECT stype_name FROM service_type_tbl WHERE stype_id = testservice_tbl.service_id) FROM testservice_tbl WHERE testservice_id = '" + ddt.Rows(0).Item(1).ToString + "'"
                    Dim dtd As New DataTable
                    If conn.SelectRec(select_query, dtd) Then
                        txtpnum.Text = dtd.Rows(0).Item(1).ToString
                        txtpname.Text = dtd.Rows(0).Item(2).ToString
                        cmb_service.Text = ddt.Rows(0).Item(2).ToString
                        dtd.Dispose()
                    End If
                End If
                ddt.Dispose()
            End If
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        identifynext_serv()
        txtpnum.Text = ""
        txtpname.Text = ""
        cmb_service.Text = ""
        countserv()
        cmb_queue_serv()
        form_queue_lv()
        load_queue_lv()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            lv_cons.Visible = True
            lv_queue.Visible = False
        Else
            lv_cons.Visible = False
            lv_queue.Visible = True
        End If
        txtpnum.Text = ""
        txtpname.Text = ""
        cmb_service.Text = ""
        countserv()
        cmb_queue_serv()
        form_queue_lv()
        load_queue_lv()
    End Sub

    Private Sub txtpnumcons_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpnumcons.TextChanged
        cons_data()
        If txtpnumcons.Text = "" Then
            txtpnamecons.Text = ""
            txtdoc.Text = ""
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If consid = "" Then
            MessageBox.Show("No patient detected on the queue.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim result1 As DialogResult = MessageBox.Show("Patient Served?", "Important Question", MessageBoxButtons.YesNo)
            If result1 = Windows.Forms.DialogResult.Yes Then
                Dim edit_query As String = "update consqueue_tbl set status = 'Served' where consqueue_id = '" + consid + "'"
                If conn.ModRec(edit_query) = True Then
                    MessageBox.Show("Patient queue status successfully changed.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpnumcons.Text = ""
                    txtpnamecons.Text = ""
                    txtdoc.Text = ""
                End If
            End If
            identifynext_cons()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If consid = "" Then
            MessageBox.Show("No patient detected on the queue.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim result1 As DialogResult = MessageBox.Show("Delay patient queueing?", "Important Question", MessageBoxButtons.YesNo)
            If result1 = Windows.Forms.DialogResult.Yes Then
                Dim edit_query As String = "update consqueue_tbl set status = 'Delayed' where consqueue_id = '" + consid + "'"
                If conn.ModRec(edit_query) = True Then
                    MessageBox.Show("Patient queue status successfully changed.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpnumcons.Text = ""
                    txtpnamecons.Text = ""
                    txtdoc.Text = ""
                End If
            End If
            identifynext_cons()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim select_query As String = "SELECT consqueue_id, (SELECT patient_number FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) FROM consqueue_tbl WHERE (SELECT patient_number FROM patient_test_tbl WHERE id = consqueue_tbl.test_id) = '" + txtpnumcons.Text + "' ORDER BY consqueue_id"
        Dim consdt As New DataTable
        If conn.SelectRec(select_query, consdt) Then
            Dim result1 As DialogResult = MessageBox.Show("Queue patient?", "Important Question", MessageBoxButtons.YesNo)
            If result1 = Windows.Forms.DialogResult.Yes Then
                consid = consdt.Rows(0).Item(0).ToString
                Dim edit_query As String = "update consqueue_tbl set status = 'Queued' where consqueue_id = '" + consid + "'"
                If conn.ModRec(edit_query) = True Then
                    MessageBox.Show("Patient queue status successfully changed.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpnumcons.Text = ""
                    txtpnamecons.Text = ""
                    txtdoc.Text = ""
                End If
            End If
            identifynext_cons()
        Else
            MessageBox.Show("No patient detected on the queue.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        consdt.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        identifynext_cons()
        txtpnumcons.Text = ""
        txtpnamecons.Text = ""
        txtdoc.Text = ""
        cons_data()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If countdt = 1 Then
            Dim result1 As DialogResult = MessageBox.Show("Patient currently being served?", "Important Question", MessageBoxButtons.YesNo)
            If result1 = Windows.Forms.DialogResult.Yes Then
                Dim edit_query As String = "update queue_tbl set status = 'Serving' where queue_id = '" + id + "'"
                If conn.ModRec(edit_query) = True Then
                    Dim select_query As String = "select * from queue_tbl where status = 'Queued' or status = 'Next'"
                    Dim dtdt As New DataTable
                    If conn.SelectRec(select_query, dtdt) Then
                        For i As Integer = 0 To dtdt.Rows.Count - 1
                            select_query = "SELECT (SELECT patient_number FROM patient_test_tbl WHERE id = testservice_tbl.test_id) FROM testservice_tbl WHERE testservice_id = '" + dtdt.Rows(i).Item(1).ToString + "'"
                            Dim dtsel As New DataTable
                            If conn.SelectRec(select_query, dtsel) Then
                                If dtsel.Rows(0).Item(0).ToString = txtpnum.Text Then
                                    edit_query = "update queue_tbl set status = 'Delayed' where queue_id = '" + dtdt.Rows(i).Item(0).ToString + "'"
                                    If conn.ModRec(edit_query) Then

                                    End If
                                End If
                            End If
                            dtsel.Dispose()
                        Next
                        dtdt.Dispose()
                    End If
                    MessageBox.Show("Patient queue status successfully changed.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpnum.Text = ""
                    cmb_service.Text = ""
                    txtpname.Text = ""
                End If
            End If
            identifynext_serv()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If consid = "" Then
            MessageBox.Show("No patient detected on the queue.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim result1 As DialogResult = MessageBox.Show("Patient currently being served?", "Important Question", MessageBoxButtons.YesNo)
            If result1 = Windows.Forms.DialogResult.Yes Then
                Dim edit_query As String = "update consqueue_tbl set status = 'Serving' where consqueue_id = '" + consid + "'"
                If conn.ModRec(edit_query) = True Then
                    MessageBox.Show("Patient queue status successfully changed.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtpnumcons.Text = ""
                    txtpnamecons.Text = ""
                    txtdoc.Text = ""
                End If
            End If
            identifynext_cons()
        End If
    End Sub

    Private Sub lv_cons_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_cons.SelectedIndexChanged
        With lv_cons
            If .SelectedItems.Count > 0 Then
                txtpnumcons.Text = .SelectedItems(0).SubItems(1).Text
            End If
        End With
    End Sub
End Class