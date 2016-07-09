Imports System.IO
Public Class frm_process
    Dim conn As New HQ_Connection
    Dim total As Double = 0
    Public hmo() As String
    Dim hmoid As String
    Public hmotrue As Boolean = False
    Public comp() As String
    Dim compid As String = ""
    Dim celledit As Boolean = True
    Dim prio As String = "No"
    Dim hmo_id As String

    Sub hmo_populated()
        If dt_hmo.RowCount = 0 Then
            txtapproveby.Enabled = False
            txtapprovenum.Enabled = False
            txtreqby.Enabled = False
            txttr.Enabled = False
            txtmi.Enabled = False
            cmb_comp.Enabled = False
            txthmonum.Enabled = False
            cmb_hmo.Enabled = False
            hmotrue = False
        Else
            txtapproveby.Enabled = True
            txtapprovenum.Enabled = True
            txtreqby.Enabled = True
            txttr.Enabled = True
            txtmi.Enabled = True
            cmb_comp.Enabled = True
            txthmonum.Enabled = True
            cmb_hmo.Enabled = True
            hmotrue = True
        End If
    End Sub

    Sub dt_cash_pop()
        dt_cash.Columns.Clear()
        Dim sra As New StreamReader("IP_CONFIG.txt")
        Dim x As String = sra.ReadToEnd()
        Dim conndt As New Odbc.OdbcConnection("Driver={MySQL ODBC 3.51 Driver};Server=" & x & ";user=root;PWD=123456;Database=hq_db")
        Dim cmd As New Odbc.OdbcCommand("SELECT testservice_id, IF (service_table = 'service_type_tbl', (SELECT stype_name FROM service_type_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT pack_name FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `Service`, IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `Gross Pay`, disc_perc as `Discount %`, payment_status, homeservice FROM testservice_tbl WHERE test_id = '" + frm_receptionist.trID + "' and hmo_status = 'cash'", conndt)
        Dim da As New Odbc.OdbcDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        dt_cash.DataSource = ds.Tables(0)
        dt_cash.Columns("payment_status").Visible = False
        dt_cash.Columns("testservice_id").Visible = False
        dt_cash.Columns("homeservice").Visible = False
        dt_cash.Columns("Service").ReadOnly = True
        dt_cash.Columns("Gross Pay").ReadOnly = True
        Dim dttbox As New DataGridViewTextBoxColumn
        dttbox.HeaderText = "New Value"
        dttbox.Name = "newval"
        dttbox.Width = 30
        dt_cash.Columns.Add(dttbox)
        dt_cash.Columns("newval").ReadOnly = True
        'Dim dtcheck As New DataGridViewCheckBoxColumn
        'dtcheck.HeaderText = "Home Service?"
        'dtcheck.Name = "hserv"
        'dtcheck.Width = 30
        'dt_cash.Columns.Add(dtcheck)
        Dim totgross As Double = 0
        Dim hstot As Double = 0
        For i As Integer = 0 To dt_cash.Rows.Count - 1
            If dt_cash.Rows(i).Cells("Discount %").Value.ToString = "" Then
                dt_cash.Rows(i).Cells("Discount %").Value = "0"
            End If
            Dim disc As Double = Convert.ToDouble(dt_cash.Rows(i).Cells("Discount %").Value) / 100
            Dim less As Double = Convert.ToDouble(dt_cash.Rows(i).Cells("Gross Pay").Value) * disc
            Dim total As Double = Convert.ToDouble(dt_cash.Rows(i).Cells("Gross Pay").Value) - less
            dt_cash.Rows(i).Cells("newval").Value = total
            totgross = totgross + total
            'If dt_cash.Rows(i).Cells("homeservice").Value.ToString = "No" Then
            '    dt_cash.Rows(i).Cells("hserv").Value = 0
            'Else
            '    dt_cash.Rows(i).Cells("hserv").Value = 1
            '    hstot = hstot + 10
            'End If
        Next
        lbltotalcost.Text = totgross.ToString("N2")
        txths.Text = hstot.ToString("N2")
        lbltotfees.Text = Convert.ToDouble(lbltotalcost.Text.ToString) + Convert.ToDouble(txths.Text.ToString)
    End Sub

    Sub dt_hmo_pop()
        dt_hmo.Columns.Clear()
        Dim sra As New StreamReader("IP_CONFIG.txt")
        Dim x As String = sra.ReadToEnd()
        Dim conndt As New Odbc.OdbcConnection("Driver={MySQL ODBC 3.51 Driver};Server=" & x & ";user=root;PWD=123456;Database=hq_db")
        Dim cmd As New Odbc.OdbcCommand("SELECT testservice_id, IF (service_table = 'service_type_tbl', (SELECT stype_name FROM service_type_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT pack_name FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `Service`, IF (service_table = 'service_type_tbl', (SELECT gross FROM hmo_serv_tbl WHERE serv_id = testservice_tbl.service_id AND hmo_id = '" + hmo_id + "'), '0') AS `Gross Pay`, disc_perc AS `Discount %`, payment_status FROM testservice_tbl WHERE test_id = '" + frm_receptionist.trID + "' AND hmo_status = 'hmo'", conndt)
        Dim da As New Odbc.OdbcDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        dt_hmo.DataSource = ds.Tables(0)
        dt_hmo.Columns("payment_status").Visible = False
        dt_hmo.Columns("testservice_id").Visible = False
        dt_hmo.Columns("Service").ReadOnly = True
        dt_hmo.Columns("Gross Pay").ReadOnly = True
        dt_hmo.Columns("Discount %").Visible = False
    End Sub

    Public Sub counthmo()
        Dim select_query As String = ""
        Dim docdt As New DataTable
        select_query = "select count(status) from hmo_tbl where status = 'Active'"
        If conn.SelectRec(select_query, docdt) = True Then
            ReDim hmo(docdt.Rows(0).Item(0).ToString)
            docdt.Dispose()
        End If
        select_query = "select count(status) from company_tbl where status = 'Active'"
        Dim compdt As New DataTable
        If conn.SelectRec(select_query, compdt) = True Then
            ReDim comp(compdt.Rows(0).Item(0).ToString)
            compdt.Dispose()
        End If
    End Sub

    Sub hmopatient()
        Dim select_query As String = ""
        select_query = "select hmo_id, (select hmo_card from hmo_tbl where Record_ID = hmopatient_tbl.hmo_id), hmo_number,(select company_name from company_tbl where company_id = hmopatient_tbl.company_id), approved_by, requested_by, approval_num from hmopatient_tbl where test_id = '" + frm_receptionist.trID + "'"
        Dim dtsel As New DataTable
        If conn.SelectRec(select_query, dtsel) Then
            If dtsel.Rows.Count > 0 Then
                hmo_id = dtsel.Rows(0).Item(0).ToString
                cmb_hmo.Text = dtsel.Rows(0).Item(1).ToString
                txthmonum.Text = dtsel.Rows(0).Item(2).ToString
                cmb_comp.Text = dtsel.Rows(0).Item(3).ToString
                txtapproveby.Text = dtsel.Rows(0).Item(4).ToString
                txtreqby.Text = dtsel.Rows(0).Item(5).ToString
                txtapprovenum.Text = dtsel.Rows(0).Item(6).ToString
                dtsel.Dispose()
            End If
        End If
        select_query = "select t_r, med_information from patient_test_tbl where id = '" + frm_receptionist.trID + "'"
        Dim dts As New DataTable
        If conn.SelectRec(select_query, dts) Then
            If dts.Rows.Count > 0 Then
                txttr.Text = dts.Rows(0).Item(0).ToString
                txtmi.Text = dts.Rows(0).Item(1).ToString
                dts.Dispose()
            End If
        End If
    End Sub

    Sub computetotal()
        Dim tot As Double = 0.0
        With lv_serviceproceed
            For i As Integer = 0 To .Items.Count - 1
                tot = tot + .Items(i).SubItems(2).Text
            Next
            If tot > 0 Then
                lbltotalcost.Text = tot
            Else
                lbltotalcost.Text = "0.00"
            End If
        End With
    End Sub
    Private Sub frm_process_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_receptionist.Enabled = True
    End Sub
    Private Sub frm_process_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hmopatient()
        frm_receptionist.Enabled = False
        form_serviceproceed_lv()
        load_serviceproceed_lv()
        form_hmoproceed_lv()
        load_hmoproceed_lv()
        computetotal()
        counthmo()
        cmb_recep_hmo()
        cmb_process_comp()
        dt_cash_pop()
        dt_hmo_pop()
        txttrid.Text = frm_receptionist.trID
        If frm_receptionist.trID = "0" Then
            txttrid.Text = ""
        End If
        Dim sel_q As String = "select priority, disc_type, disc_id, otherfee from patient_test_tbl where id = '" + frm_receptionist.trID + "'"
        Dim seldt As New DataTable
        If conn.SelectRec(sel_q, seldt) Then
            If seldt.Rows.Count > 0 Then
                If seldt.Rows(0).Item(0).ToString = "Yes" Then
                    radreg.Checked = False
                    radpri.Checked = True
                Else
                    radpri.Checked = False
                    radreg.Checked = True
                End If
                cmbdtype.Text = seldt.Rows(0).Item(1).ToString
                txtdid.Text = seldt.Rows(0).Item(2).ToString
            End If
        End If
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        frm_receptionist.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub lv_serviceproceed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_serviceproceed.SelectedIndexChanged
        If lv_serviceproceed.SelectedItems.Count > 0 Then
            If lv_serviceproceed.SelectedItems(0).SubItems(3).Text = "unpaid" Then
                Dim edit_query As String = ""
                edit_query = "update testservice_tbl set hmo_status = 'hmo' where testservice_id = '" + lv_serviceproceed.SelectedItems(0).SubItems(0).Text + "'"
                If conn.ModRec(edit_query) = True Then
                    form_serviceproceed_lv()
                    load_serviceproceed_lv()
                    form_hmoproceed_lv()
                    load_hmoproceed_lv()
                    computetotal()
                End If
            Else
                MessageBox.Show("Service already paid. Cannot be altered anymore.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub lv_hmoproceed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_hmoproceed.SelectedIndexChanged
        If lv_hmoproceed.SelectedItems.Count > 0 Then
            If lv_hmoproceed.SelectedItems(0).SubItems(3).Text = "unpaid" Then
                Dim edit_query As String = ""
                edit_query = "update testservice_tbl set hmo_status = 'cash' where testservice_id = '" + lv_hmoproceed.SelectedItems(0).SubItems(0).Text + "'"
                If conn.ModRec(edit_query) = True Then
                    form_serviceproceed_lv()
                    load_serviceproceed_lv()
                    form_hmoproceed_lv()
                    load_hmoproceed_lv()
                    computetotal()
                End If
            Else
                MessageBox.Show("Service already approved by the HMO Company. Cannot be altered anymore", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub cmb_hmo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_hmo.SelectedIndexChanged
        If cmb_hmo.Text = "---Add New---" Then
            frm_hmo.called = True
            frm_hmo.Show()
        Else
            hmoid = hmo(cmb_hmo.SelectedIndex - 1)
            hmo_id = hmoid
            dt_hmo_pop()
            Dim select_query As String = "select contact from hmo_tbl where Record_ID = '" + hmoid + "'"
            Dim dtsel As New DataTable
            If conn.SelectRec(select_query, dtsel) = True Then
                txthmocont.Text = dtsel.Rows(0).Item(0).ToString
            End If
        End If
    End Sub

    Private Sub btnPROCEED_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPROCEED.Click
        Dim result1 As DialogResult = MessageBox.Show("Be sure that all HMO request have been validated and approved by given HMO company. Press Yes to continue.", "Important Question", MessageBoxButtons.YesNo)
        If result1 = Windows.Forms.DialogResult.Yes Then
            Dim edit_tr As String = ""
            Dim insert As Boolean = False
            If frm_receptionist.trID = "0" Then
                Dim tdate As Date = frm_receptionist.DTP.Text
                Dim newdate As String = tdate.ToString("MM/dd/yy")
                edit_tr = "insert into patient_test_tbl values(null, '" + frm_receptionist.txtPnumber.Text + "', null,'0.0','" + txttr.Text + "', '" + txtmi.Text + "', '" + newdate + "', 'unpaid','No','" & prio & "','" & cmbdtype.Text & "','" & txtdid.Text & "','" & txths.Text & "')"
                insert = True
            Else
                edit_tr = "update patient_test_tbl set t_r = '" + txttr.Text + "', med_information = '" + txtmi.Text + "' where id = '" + frm_receptionist.trID + "'"
            End If

            If conn.ModRec(edit_tr) = True Then
                If insert = True Then
                    Dim sel_q As String = "SELECT id FROM patient_test_tbl WHERE patient_number = '" + frm_receptionist.txtPnumber.Text + "' ORDER BY id DESC LIMIT 1"
                    Dim dtq As New DataTable
                    If conn.SelectRec(sel_q, dtq) Then
                        frm_receptionist.trID = dtq.Rows(0).Item(0).ToString
                        dtq.Dispose()
                        Dim edit_test As String = "update testservice_tbl set test_id = '" + frm_receptionist.trID + "' where test_id = '0'"
                        If conn.ModRec(edit_test) Then

                        End If
                    End If
                End If
            End If
            If hmotrue = True Then
                Dim select_query As String = "select * from hmopatient_tbl where test_id = '" + frm_receptionist.trID + "'"
                Dim dtsel As New DataTable
                Dim edit_query As String = ""
                If conn.SelectRec(select_query, dtsel) = True Then
                    If dtsel.Rows.Count > 0 Then
                        edit_query = "update hmopatient_tbl set company_id = '" + compid + "', hmo_id = '" + hmoid + "', hmo_number = '" + txthmonum.Text + "', approved_by = '" + txtapproveby.Text + "', requested_by = '" + txtreqby.Text + "', approval_num = '" + txtapprovenum.Text + "' where test_id = '" + frm_receptionist.trID + "'"
                    Else
                        edit_query = "insert into hmopatient_tbl values(null, '" + frm_receptionist.trID + "', '" + hmoid + "', '" + txthmonum.Text + "', '" + compid + "','" + txtapproveby.Text + "', '" + txtreqby.Text + "', '" + txtapprovenum.Text + "')"
                    End If
                End If
                If conn.ModRec(edit_query) = True Then
                    For i As Integer = 0 To lv_hmoproceed.Items.Count - 1
                        Dim tservid As String = lv_hmoproceed.Items(i).SubItems(0).Text
                        edit_query = "update testservice_tbl set payment_status = 'paid' where testservice_id = '" + tservid + "'"
                        If conn.ModRec(edit_query) = True Then
                            Dim sel_q As String = "select * from testservice_tbl where testservice_id = '" + tservid + "'"
                            Dim seldt As New DataTable
                            If conn.SelectRec(sel_q, seldt) Then
                                If seldt.Rows(0).Item(3).ToString = "service_type_tbl" Then
                                    edit_query = "insert into queue_tbl values(null, '" + tservid + "', '" + seldt.Rows(0).Item(2).ToString + "','Queued')"
                                    If conn.ModRec(edit_query) = True Then

                                    End If
                                Else
                                    sel_q = "select stype_id from package_service_tbl where pack_id = '" + seldt.Rows(0).Item(2).ToString + "'"
                                    Dim dtdtdt As New DataTable
                                    If conn.SelectRec(sel_q, dtdtdt) Then
                                        For joel As Integer = 0 To dtdtdt.Rows.Count - 1
                                            edit_query = "insert into queue_tbl values(null, '" + tservid + "', '" + dtdtdt.Rows(joel).Item(0).ToString + "','Queued')"
                                            If conn.ModRec(edit_query) = True Then

                                            End If
                                        Next
                                    End If
                                    dtdtdt.Dispose()
                                End If
                            End If
                            seldt.Dispose()
                        End If
                    Next
                End If
                dtsel.Dispose()
            End If
            Dim pripri As String = "No"
            If radpri.Checked Then
                pripri = "Yes"
            End If
            Dim modmod As String = "update patient_test_tbl set priority = '" + pripri + "', disc_type = '" + cmbdtype.Text + "', disc_id = '" + txtdid.Text + "', otherfee = '" + txths.Text + "' where id = '" + frm_receptionist.trID + "'"
            If conn.ModRec(modmod) Then

            End If

            MessageBox.Show("Service Acquisition done. Proceed to cashier for payment", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            rpt_statement.Show()
            Me.Dispose()
            frm_receptionist.Enabled = True
        End If
    End Sub

    Private Sub cmb_comp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_comp.SelectedIndexChanged
        If cmb_comp.Text = "---None---" Then
            compid = ""
        ElseIf cmb_comp.Text = "---Add New---" Then
            frm_hmo.called = True
            frm_hmo.Show()
        Else
            compid = comp(cmb_comp.SelectedIndex - 1)
        End If
    End Sub

    'Private Sub dt_cash_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt_cash.CellContentClick
    '    If e.ColumnIndex = 7 Then
    '        Dim sel_q As String = "select payment_status from testservice_tbl where testservice_id = '" + dt_cash.SelectedRows(0).Cells("testservice_id").Value.ToString + "'"
    '        Dim dtsel As New DataTable
    '        If conn.SelectRec(sel_q, dtsel) Then
    '            If dtsel.Rows(0).Item(0).ToString = "unpaid" Then
    '                Dim mod_query As String = ""
    '                If dt_cash.SelectedRows(0).Cells("hserv").Value = 0 Then
    '                    mod_query = "update testservice_tbl set homeservice = 'Yes' where testservice_id = '" + dt_cash.SelectedRows(0).Cells("testservice_id").Value.ToString + "'"
    '                Else
    '                    mod_query = "update testservice_tbl set homeservice = 'No' where testservice_id = '" + dt_cash.SelectedRows(0).Cells("testservice_id").Value.ToString + "'"
    '                End If
    '                If conn.ModRec(mod_query) Then

    '                End If
    '            Else
    '                MessageBox.Show("Service already paid. Cannot be altered anymore", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            End If
    '        End If
    '        dtsel.Dispose()
    '        dt_cash_pop()
    '    End If
    'End Sub

    Private Sub dt_cash_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt_cash.CellEndEdit
        If e.ColumnIndex = 3 Then
            Dim sel_q As String = "select payment_status from testservice_tbl where testservice_id = '" + dt_cash.SelectedRows(0).Cells("testservice_id").Value.ToString + "'"
            Dim dtsel As New DataTable
            If conn.SelectRec(sel_q, dtsel) Then
                If dtsel.Rows(0).Item(0).ToString = "unpaid" Then
                    Dim mod_query As String = "update testservice_tbl set disc_perc = '" + dt_cash.SelectedRows(0).Cells("Discount %").Value.ToString + "' where testservice_id = '" + dt_cash.SelectedRows(0).Cells("testservice_id").Value.ToString + "'"
                    If conn.ModRec(mod_query) Then

                    End If
                Else
                    MessageBox.Show("Service already paid. Cannot be altered anymore", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
            dtsel.Dispose()
            dt_cash_pop()
        End If
    End Sub

    Private Sub dt_hmo_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt_hmo.CellEndEdit
        Dim sel_q As String = "select payment_status from testservice_tbl where testservice_id = '" + dt_hmo.SelectedRows(0).Cells("testservice_id").Value.ToString + "'"
        Dim dtsel As New DataTable
        If conn.SelectRec(sel_q, dtsel) Then
            If dtsel.Rows(0).Item(0).ToString = "unpaid" Then
                Dim mod_query As String = "update testservice_tbl set disc_perc = '" + dt_hmo.SelectedRows(0).Cells("Discount %").Value.ToString + "' where testservice_id = '" + dt_hmo.SelectedRows(0).Cells("testservice_id").Value.ToString + "'"
                If conn.ModRec(mod_query) Then

                End If
            Else
                MessageBox.Show("Service already approved by the HMO Company. Cannot be altered anymore", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        dtsel.Dispose()
        dt_hmo_pop()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If dt_cash.SelectedRows.Count > 0 Then
            Dim mod_query As String = "update testservice_tbl set hmo_status = 'hmo', homeservice = 'No' where testservice_id = '" + dt_cash.SelectedRows(0).Cells("testservice_id").Value.ToString + "'"
            If conn.ModRec(mod_query) Then
                dt_hmo_pop()
                dt_cash_pop()
            End If
        End If
        hmo_populated()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dt_hmo.SelectedRows.Count > 0 Then
            Dim mod_query As String = "update testservice_tbl set hmo_status = 'cash' where testservice_id = '" + dt_hmo.SelectedRows(0).Cells("testservice_id").Value.ToString + "'"
            If conn.ModRec(mod_query) Then
                dt_hmo_pop()
                dt_cash_pop()
            End If
        End If
        hmo_populated()
    End Sub

    Private Sub txths_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txths.TextChanged
        If txths.Text = "" Then
            txths.Text = 0
        End If
        lbltotfees.Text = Convert.ToDouble(lbltotalcost.text.ToString) + Convert.ToDouble(txths.Text.ToString)
    End Sub

    Private Sub chkHome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHome.CheckedChanged
        If chkHome.Checked Then
            Dim hsvalue As Double = dt_cash.Rows.Count * 10
            txths.Text = hsvalue.ToString("N2")

            Dim sel_q As String = "select testservice_id from testservice_tbl where test_id = '" + txttrid.Text + "' and payment_status = 'unpaid'"
            Dim dtsel As New DataTable
            If conn.SelectRec(sel_q, dtsel) Then
                For i As Integer = 0 To (dtsel.Rows.Count - 1)
                    Dim mod_query As String = ""
                    mod_query = "update testservice_tbl set homeservice = 'Yes' where testservice_id = '" + dtsel.Rows(i).Item(0).ToString + "'"
                    If conn.ModRec(mod_query) Then
                    End If
                Next
            Else
                MessageBox.Show("Service already paid. Cannot be altered anymore", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            dtsel.Dispose()
            'dt_cash_pop()
        Else
            txths.Text = "0.00"
            Dim sel_q As String = "select payment_status, testservice_id from testservice_tbl where test_id = '" + txttrid.Text + "'"
            Dim dtsel As New DataTable
            If conn.SelectRec(sel_q, dtsel) Then
                For i As Integer = 0 To (dtsel.Rows.Count - 1)
                    If dtsel.Rows(i).Item(0).ToString = "unpaid" Then
                        Dim mod_query As String = ""
                        mod_query = "update testservice_tbl set homeservice = 'No' where testservice_id = '" + dtsel.Rows(i).Item(1).ToString + "'"
                        If conn.ModRec(mod_query) Then
                        End If
                    Else
                        MessageBox.Show("Service already paid. Cannot be altered anymore", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Next
            End If
            dtsel.Dispose()
            'dt_cash_pop()
        End If
    End Sub

    Private Sub radreg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radreg.CheckedChanged
        If radreg.Checked Then
            prio = "No"
        End If
    End Sub

    Private Sub radpri_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radpri.CheckedChanged
        If radpri.Checked Then
            prio = "Yes"
        End If
    End Sub
End Class