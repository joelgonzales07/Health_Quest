Imports System.IO

Public Class frm_readings
    Dim conn As New HQ_Connection
    Dim servtid(99) As String
    Dim serv1(99) As String
    Dim servid1(99) As String
    Dim ref(99) As String
    Dim testservid As String = ""
    Dim tstid As String = ""
    Dim sid As String = ""
    Dim docid As String = ""
    Dim perc As Double = 0

    Sub cmb_serv_pop()
        cmb_serv.Items.Clear()
        Dim sel_q As String = "select testservice_id, service_id, (select stype_name from service_type_tbl where stype_id = testservice_tbl.service_id), service_table from testservice_tbl where test_id = '" + txttrid.Text + "'"
        Dim dtcmb As New DataTable
        Dim servcount As Integer = 0
        If conn.SelectRec(sel_q, dtcmb) Then
            For i As Integer = 0 To dtcmb.Rows.Count - 1
                If dtcmb.Rows(i).Item(3).ToString = "package_tbl" Then
                    Dim select_q As String = "select stype_id, (select stype_name from service_type_tbl where stype_id = package_service_tbl.stype_id) from package_service_tbl where pack_id = '" + dtcmb.Rows(i).Item(1).ToString + "'"
                    Dim newdt As New DataTable
                    If conn.SelectRec(select_q, newdt) Then
                        For x As Integer = 0 To newdt.Rows.Count - 1
                            servtid(servcount) = dtcmb.Rows(i).Item(0).ToString
                            servid1(servcount) = newdt.Rows(x).Item(0).ToString
                            cmb_serv.Items.Add(newdt.Rows(x).Item(1).ToString)
                            servcount = servcount + 1
                        Next
                    End If
                    newdt.Dispose()
                Else
                    servtid(servcount) = dtcmb.Rows(i).Item(0).ToString
                    servid1(servcount) = dtcmb.Rows(i).Item(1).ToString
                    cmb_serv.Items.Add(dtcmb.Rows(i).Item(2).ToString)
                    servcount = servcount + 1
                End If
            Next
        End If
        dtcmb.Dispose()
    End Sub

    Sub cmb_doc()
        Dim select_query As String = "Select doc_id, CONCAT(CONCAT('Dr. '), CONCAT(doc_lname, ', '), CONCAT(doc_fname, ' '), doc_mname) from doctor_tbl where status = 'Active'"
        Dim dt As New DataTable
        If conn.SelectRec(select_query, dt) = True Then
            For i As Integer = 0 To (dt.Rows.Count - 1)
                ref(i) = dt.Rows(i).Item(0).ToString
                cbodocname.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub

    Sub pop_info()
        Dim sel_q As String = "select patient_number, (select concat(lname, ', ', fname, ' ', mname) from patient_tbl where patient_number = patient_test_tbl.patient_number) from patient_test_tbl where id = '" + txttrid.Text + "' "
        Dim dtsel As New DataTable
        If conn.SelectRec(sel_q, dtsel) Then
            If dtsel.Rows.Count > 0 Then
                txtpnum.Text = dtsel.Rows(0).Item(0).ToString
                txtpname.Text = dtsel.Rows(0).Item(1).ToString
            End If
        End If
        '(select doc_name from doctor_tbl where doc_id = patient_test_tbl.doc_id)
    End Sub

    Sub compute_cost_and_fee()
        Dim sel_q As String = "select amount_due from transaction_tbl where test_id = '" + txttrid.Text + "'"
        Dim dtsel As New DataTable
        If conn.SelectRec(sel_q, dtsel) Then
            If dtsel.Rows.Count > 0 Then
                txttotalcost.Text = dtsel.Rows(0).Item(0).ToString
                Dim totalcost As Double = Convert.ToDouble(txttotalcost.Text)
                perc = 0

                Dim select_query As String = "select perc from readerfee_tbl"
                Dim dt As New DataTable
                If conn.SelectRec(select_query, dt) Then
                    If dt.Rows.Count > 0 Then
                        perc = Convert.ToDouble(dt.Rows(0).Item(0))
                    Else
                        perc = 0
                    End If
                End If

                Dim readersfee As Double = totalcost * perc
                txtreadersfee.Text = readersfee.ToString("N2")
            Else
                txttotalcost.Text = "0.00"
                txtreadersfee.Text = "0.00"
            End If
        End If
    End Sub

    Sub get_perc()
        Dim select_query As String = "select perc from readerfee_tbl"
        Dim dt As New DataTable
        If conn.SelectRec(select_query, dt) Then
            If dt.Rows.Count > 0 Then
                perc = Convert.ToDouble(dt.Rows(0).Item(0))
            Else
                perc = 0
            End If
        End If
    End Sub

    Private Sub frm_readings_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_receptionist.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub frm_readings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pop_info()
        cmb_serv_pop()
        'compute_cost_and_fee()
        get_perc()
        cmb_doc()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.Dispose()
    End Sub

    Private Sub cmb_serv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_serv.SelectedIndexChanged
        If cmb_serv.Text = "" Then
        Else
            tstid = servtid(cmb_serv.SelectedIndex)
            sid = servid1(cmb_serv.SelectedIndex)

            Dim sel_q As String = "SELECT IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) - IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) * (disc_perc / 100) as 'Discounted Value', (count(testservice_id) * 10) FROM testservice_tbl WHERE test_id = '" & txttrid.Text & "' and homeservice = 'Yes' and payment_status = 'unpaid' and service_id = '" & sid & "' group by test_id, testservice_id"
            Dim dtsel As New DataTable
            If conn.SelectRec(sel_q, dtsel) Then
                If dtsel.Rows.Count > 0 Then
                    Dim value As Double = dtsel.Rows(0).Item(0).ToString
                    Dim totalcost As Double = value + Convert.ToDouble(dtsel.Rows(0).Item(1))
                    txttotalcost.Text = totalcost.ToString("N2")
                    Dim readersfee As Double = totalcost * (perc / 100)
                    txtreadersfee.Text = readersfee.ToString("N2")
                End If
            End If

            Dim select_query As String = "select readings from readservice_tbl where testservice_id = '" & tstid & "' and service_id = '" & sid & "'"
            Dim dt As New DataTable
            If conn.SelectRec(select_query, dt) Then
                If dt.Rows.Count > 0 Then
                    rtxtreading.Text = dt.Rows(0).Item(0).ToString
                Else
                    rtxtreading.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cbodocname.Text = "" Or cmb_serv.Text = "" Or rtxtreading.Text = "" Then
            MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim select_query As String = "select * from readservice_tbl where testservice_id = '" & tstid & "' and service_id = '" & sid & "'"
            Dim dt As New DataTable
            If conn.SelectRec(select_query, dt) Then
                If dt.Rows.Count > 0 Then
                    Dim edit_query As String = "Update readservice_tbl set doc_id ='" & docid & "' and readings = '" & rtxtreading.Text & "' where testservice_id = '" & tstid & "' and service_id = '" & sid & "'"
                    If conn.ModRec(edit_query) = True Then
                        MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    Dim insert_query As String = "Insert into readservice_tbl values (null, '" & tstid & "', '" & sid & "','" & docid & "', '" & rtxtreading.Text & "')"
                    If conn.ModRec(insert_query) = True Then
                        MessageBox.Show("Record(s) Insert Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cbodocname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodocname.SelectedIndexChanged
        If cbodocname.Text = "" Then
        Else
            docid = ref(cbodocname.SelectedIndex)
            MsgBox(docid)
        End If
    End Sub
End Class