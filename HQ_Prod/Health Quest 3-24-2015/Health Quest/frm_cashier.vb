Option Explicit Off

Imports System.IO

Public Class frm_cashier
    Dim conn As New HQ_Connection
    Dim boolbool As Boolean = False
    Dim usercount As Integer = 0
    Public orno As String = ""

    Sub clear()
        txtPatientID.Text = ""
        txtName.Text = ""
        txtDiscType.Text = ""
        txtID.Text = ""
        lv_service.Clear()
        lblConsFee.Text = "0.00"
        lblNService.Text = "(0)"
        lblNPackage.Text = "(0)"
        lblServiceFee.Text = "0.00"
        lblPackageFee.Text = "0.00"
        lblOtherFee.Text = "0.00"
        lblGross.Text = "0.00"
        lblLess.Text = "0.00"
        lblNet.Text = "0.00"
        txtPayment.Text = "0.00"
        lblChange.Text = "0.00"
        txtPayment.Enabled = False
        btnCLEAR.Enabled = False
        btnPaid.Enabled = False
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
        frm_login.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        txtTestID.Text = ""
        txtTestID.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_request_item.Show()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frm_Balance.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        mntr_sales.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub
    Private Sub btnPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaid.Click
        Dim dtselect As New DataTable
        Dim currentTime As Integer = DateTime.Now.Year
        Dim year As String = currentTime.ToString().Substring(2, 2)

        select_query = "SELECT COUNT(orno) FROM transaction_tbl WHERE orno LIKE '" + year + "%'"
        If conn.SelectRec(select_query, dtselect) = True Then
            '---generating OR number
            Dim count As Integer = dtselect.Rows(0).Item(0)
            Dim decLength As Integer = count.ToString("D").Length + 4
            Dim stringcount As String = ""
            orno = ""

            count = count + 1
            stringcount = count.ToString("D" + decLength.ToString)
            orno = year & "-" & stringcount

            Dim net As Double
            Dim pay As Double
            Dim chg As Double

            net = Convert.ToDouble(lblNet.Text)
            pay = Convert.ToDouble(txtPayment.Text)
            Dim edit_query As String = ""
            Dim add_query As String = ""
            If pay >= net Then
                If boolbool = True Then
                    edit_query = "update patient_test_tbl set payment_status = 'paid' where id = '" & txtTestID.Text & "' and payment_status = 'unpaid'"
                    If conn.ModRec(edit_query) = True Then
                    End If

                    add_query = "insert into consqueue_tbl values(null,'" & txtTestID.Text & "','Queued')"
                    If conn.ModRec(add_query) = True Then
                    End If
                End If

                If lv_service.Items.Count > 0 Then

                    For a As Integer = 0 To lv_service.Items.Count - 1
                        Dim id As Integer = lv_service.Items(a).SubItems(1).Text
                        Dim st As String = lv_service.Items(a).SubItems(2).Text
                        Dim si As Integer = lv_service.Items(a).SubItems(8).Text

                        edit_query = "update testservice_tbl set payment_status = 'paid' where test_id = '" & txtTestID.Text & "' and payment_status = 'unpaid' and testservice_id = '" & id & "'"
                        If conn.ModRec(edit_query) = True Then
                        End If

                        If st = "service_type_tbl" Then
                            add_query = "insert into queue_tbl values(null,'" & id & "','" & si & "','Queued')"
                            If conn.ModRec(add_query) = True Then
                                Dim strsql As String = "select service_item_tbl.item_id as 'Item ID', (inventory_tbl.quantity - service_item_tbl.quantity) as 'New Quantity' from service_item_tbl join inventory_tbl on service_item_tbl.item_id = inventory_tbl.item_id where service_item_tbl.stype_id = '" & si & "'"
                                Dim dt As New DataTable
                                If conn.SelectRec(strsql, dt) = True Then
                                    If dt.Rows.Count > 0 Then
                                        For i = 0 To (dt.Rows.Count - 1)
                                            Dim item_id As Integer = Convert.ToInt32(dt.Rows(i).Item(0))
                                            Dim quantity As Integer = Convert.ToInt32(dt.Rows(i).Item(1))
                                            edit_query = "update inventory_tbl set quantity = '" & quantity & "' where item_id = '" & item_id & "'"
                                            If conn.ModRec(edit_query) = True Then
                                            End If
                                        Next
                                    End If
                                End If
                                dt.Dispose()
                            End If
                        Else
                            Dim strsql As String = "select stype_id from package_service_tbl where pack_id = '" & si & "'"
                            Dim dt As New DataTable
                            If conn.SelectRec(strsql, dt) = True Then
                                If dt.Rows.Count > 0 Then
                                    For i = 0 To (dt.Rows.Count - 1)
                                        Dim stype_id As Integer = Convert.ToInt32(dt.Rows(i).Item(0))
                                        add_query = "insert into queue_tbl values(null,'" & id & "','" & stype_id & "','Queued')"
                                        If conn.ModRec(add_query) = True Then
                                            Dim sql As String = "select service_item_tbl.item_id, (inventory_tbl.quantity - service_item_tbl.quantity) from service_item_tbl join inventory_tbl on service_item_tbl.item_id = inventory_tbl.item_id where service_item_tbl.stype_id = '" & stype_id & "'"
                                            Dim datatable As New DataTable
                                            If conn.SelectRec(sql, datatable) = True Then
                                                If datatable.Rows.Count > 0 Then
                                                    For z = 0 To (datatable.Rows.Count - 1)
                                                        Dim item_id As Integer = Convert.ToInt32(datatable.Rows(z).Item(0))
                                                        Dim quantity As Integer = Convert.ToInt32(datatable.Rows(z).Item(1))
                                                        edit_query = "update inventory_tbl set quantity = '" & quantity & "' where item_id = '" & item_id & "'"
                                                        If conn.ModRec(edit_query) = True Then
                                                        End If
                                                    Next
                                                End If
                                            End If
                                            datatable.Dispose()
                                        End If
                                    Next
                                End If
                            End If
                            dt.Dispose()
                        End If
                    Next
                End If

                Dim constat As String = ""
                Dim otherstat As String = ""

                If lblConsFee.Text = "0" Or lblConsFee.Text = "0.00" Then
                    constat = "No"
                Else
                    constat = "Yes"
                End If

                If lblOtherFee.Text = "0" Or lblOtherFee.Text = "0.00" Then
                    otherstat = "No"
                Else
                    otherstat = "Yes"
                End If

                chg = pay - net
                lblChange.Text = chg.ToString("N2")
                Dim stradd As String = "Insert into transaction_tbl values(null,'" & orno & "','" & txtPatientID.Text & "','" & txtTestID.Text & "','" & lblLess.Text & "','" & lblNet.Text & "','" & txtPayment.Text & "','" & lblChange.Text & "','" & DTP.Value.Date & "','" & DateTime.Now.ToShortTimeString() & "','" & constat & "','" & otherstat & "')"
                If conn.ModRec(stradd) = True Then
                    MessageBox.Show("Transaction Processed!", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Dim dt1 As New DataTable
                Dim select_query1 As String = "select payment_status from testservice_tbl where test_id = '" & txtTestID.Text & "' and payment_status = 'unpaid' and hmo_status = 'cash'"
                If conn.SelectRec(select_query1, dt1) = True Then
                    If dt1.Rows.Count > 0 Then
                    Else
                        edit_query = "update patient_test_tbl set locked = 'Yes' where id = '" & txtTestID.Text & "'"
                        If conn.ModRec(edit_query) = True Then
                        End If
                    End If
                End If
                dt1.Dispose()

                txtTestID.Enabled = False
                txtPayment.Enabled = False
                btnPaid.Enabled = False

                rpt_or.prntfrm = True
                rpt_or.Show()

            Else
                MessageBox.Show("Insufficient funds!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        txtTestID.Text = ""
        txtTestID.Focus()
        txtTestID.Enabled = True
        clear()
    End Sub

    Private Sub txtTestID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTestID.TextChanged
        Dim datatable As New DataTable
        Dim query As String = "select patient_test_tbl.patient_number, CONCAT(CONCAT(patient_tbl.LName, ', '), CONCAT(patient_tbl.FName, ' '), patient_tbl.MName), patient_test_tbl.disc_type, patient_test_tbl.disc_id from patient_test_tbl join patient_tbl on patient_test_tbl.patient_number = patient_tbl.patient_number where patient_test_tbl.id = '" & txtTestID.Text & "' and patient_test_tbl.locked = 'No'"
        If conn.SelectRec(query, datatable) = True Then
            If datatable.Rows.Count > 0 Then

                txtPatientID.Text = datatable.Rows(0).Item(0).ToString()
                txtName.Text = datatable.Rows(0).Item(1).ToString()
                txtDiscType.Text = datatable.Rows(0).Item(2).ToString()
                txtID.Text = datatable.Rows(0).Item(3).ToString()

                form_userrep2_lv()
                load_userrep2_lv()

                Dim cons As Double = 0
                Dim serv As Double = 0
                Dim pack As Double = 0
                Dim other As Double = 0

                Dim dt1 As New DataTable
                Dim select_query1 As String = "SELECT c_fee, otherfee FROM patient_test_tbl WHERE id = '" & txtTestID.Text & "' AND patient_number = '" & txtPatientID.Text & "' AND payment_status = 'unpaid'"
                If conn.SelectRec(select_query1, dt1) = True Then
                    If dt1.Rows.Count > 0 Then
                        cons = Convert.ToDouble(dt1.Rows(0).Item(0))
                        other = Convert.ToDouble(dt1.Rows(0).Item(1))
                        lblConsFee.Text = cons.ToString("N2")
                        lblOtherFee.Text = other.ToString("N2")
                        boolbool = True
                    Else
                        cons = 0
                        other = 0
                        lblConsFee.Text = "0.00"
                        lblOtherFee.Text = "0.00"
                        boolbool = False
                    End If
                Else
                    cons = 0
                    other = 0
                    lblConsFee.Text = "0.00"
                    lblOtherFee.Text = "0.00"
                End If

                Dim nserv As Integer = 0
                Dim npack As Integer = 0
                Dim less As Double = 0

                If lv_service.Items.Count > 0 Then
                    For i As Integer = 0 To lv_service.Items.Count - 1
                        If lv_service.Items(i).SubItems(2).Text = "service_type_tbl" Then
                            nserv = nserv + 1
                            serv = serv + (Convert.ToDouble(lv_service.Items(i).SubItems(4).Text))
                        Else
                            npack = npack + 1
                            pack = pack + (Convert.ToDouble(lv_service.Items(i).SubItems(4).Text))
                        End If
                        less = less + (Convert.ToDouble(lv_service.Items(i).SubItems(7).Text))
                    Next

                    lblNService.Text = "(" & nserv & ")"
                    lblNPackage.Text = "(" & npack & ")"
                    lblServiceFee.Text = serv.ToString("N2")
                    lblPackageFee.Text = pack.ToString("N2")
                    lblLess.Text = less.ToString("N2")
                Else
                    lblNService.Text = "(0)"
                    lblNPackage.Text = "(0)"
                    lblServiceFee.Text = "0.00"
                    lblPackageFee.Text = "0.00"
                    lblLess.Text = "0.00"
                End If

                Dim Gross As Double = cons + serv + pack + other
                lblGross.Text = Gross.ToString("N2")
                Dim Net As Double = Gross - less
                lblNet.Text = Net.ToString("N2")

                txtPayment.Enabled = True
                btnCLEAR.Enabled = True
                btnPaid.Enabled = True
            Else
                clear()
            End If
        Else
            clear()
        End If
    End Sub
End Class