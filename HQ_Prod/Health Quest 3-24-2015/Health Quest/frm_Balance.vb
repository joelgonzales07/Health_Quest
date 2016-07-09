Public Class frm_Balance
    Dim conn As New HQ_Connection
    Public id As Integer = 0
    Public discount As Double = 0
    Public gross As Double = 0
    Public consfee As Double = 0
    Public otherfee As Double = 0
    Public patientid As String = ""
    Sub form()
        form_balance_lv()
        Load_balance_lv()
        txtTransID.Text = ""
        txtPatientID.Text = ""
        txtOR.Text = ""
        txtPatientName.Text = ""
        txtAmountDue.Text = "0.00"
        txtPayment.Text = "0.00"
        txtChange.Text = "0.00"
        txtPayment.Enabled = False
        btnClear.Enabled = False
        btnPrint.Enabled = False
        btnAdjust.Enabled = False
    End Sub
    Private Sub frmBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        form()
        txtTransID.Focus()
        form_balance_lv()
        Load_balance_lv()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtpatientid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransID.TextChanged
        Load_balance2_lv()
    End Sub

    Private Sub lv_Balance_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Adjust.SelectedIndexChanged
        On Error Resume Next
        With lv_Adjust
            id = .SelectedItems(0).SubItems(1).Text
            txtPatientID.Text = .SelectedItems(0).SubItems(4).Text
            txtOR.Text = .SelectedItems(0).SubItems(3).Text
            patientid = .SelectedItems(0).SubItems(4).Text

            Dim dt1 As New DataTable
            Dim select_query1 As String = "select CONCAT(CONCAT(LName, ', '), CONCAT(FName, ' '), MName) from patient_tbl where patient_number = '" & patientid & "'"
            If conn.SelectRec(select_query1, dt1) = True Then
                If dt1.Rows.Count > 0 Then
                    txtPatientName.Text = dt1.Rows(0).Item(0).ToString
                End If
            End If
            dt1.Dispose()

            txtAmountDue.Text = .SelectedItems(0).SubItems(5).Text
            Dim payment As Double = Convert.ToDouble(.SelectedItems(0).SubItems(6).Text)
            discount = Convert.ToDouble(.SelectedItems(0).SubItems(7).Text)
            txtPayment.Text = payment.ToString("N2")
            gross = discount + Convert.ToDouble(txtAmountDue.Text)

            Dim constat As String = .SelectedItems(0).SubItems(8).Text
            Dim otherstast As String = .SelectedItems(0).SubItems(9).Text

            If constat = "Yes" Then
                Dim dt As New DataTable
                Dim select_query As String = "select patient_test_tbl.c_fee from patient_test_tbl join transaction_tbl on patient_test_tbl.id = transaction_tbl.test_id where transaction_tbl.orno = '" & txtOR.Text & "' and transaction_tbl.transaction_id = '" & id & "'"
                If conn.SelectRec(select_query, dt) = True Then
                    If dt.Rows.Count > 0 Then
                        consfee = Convert.ToDouble(dt.Rows(0).Item(0).ToString())
                    Else
                        consfee = 0
                    End If
                Else
                    consfee = 0
                End If
                dt.Dispose()
            Else
                consfee = 0
            End If

            If otherstast = "Yes" Then
                Dim dt As New DataTable
                Dim select_query As String = "select patient_test_tbl.otherfee from patient_test_tbl join transaction_tbl on patient_test_tbl.id = transaction_tbl.test_id where transaction_tbl.orno = '" & txtOR.Text & "' and transaction_tbl.transaction_id = '" & id & "'"
                If conn.SelectRec(select_query, dt) = True Then
                    If dt.Rows.Count > 0 Then
                        otherfee = Convert.ToDouble(dt.Rows(0).Item(0).ToString())
                    Else
                        otherfee = 0
                    End If
                Else
                    otherfee = 0
                End If
                dt.Dispose()
            Else
                otherfee = 0
            End If

            txtPayment.Enabled = True
            btnClear.Enabled = True
            btnPrint.Enabled = True
            btnAdjust.Enabled = True
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjust.Click
        If lv_Adjust.SelectedItems.Count > 0 Then
            Dim amountdue As Double = Convert.ToDouble(txtAmountDue.Text)
            Dim amountpaid As Double = Convert.ToDouble(txtPayment.Text)
            If amountdue <= amountpaid Then
                Dim edit_query = "update transaction_tbl set amount_paid = '" & txtPayment.Text & "', `change` = '" & txtChange.Text & "' where transaction_id = '" & id & "'"
                If conn.ModRec(edit_query) = True Then
                    form()
                    MessageBox.Show("Amount paid is successfully adjusted.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("The amount due is greater than the amount pay.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Please select an item in the List.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If lv_Adjust.SelectedItems.Count > 0 Then
            rpt_or.prntfrm = False
            rpt_or.Show()
        Else
            MessageBox.Show("Please select an item in the List.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        form()
    End Sub

    Private Sub txtPayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayment.TextChanged
        If txtPayment.Text <> "" Or txtPayment.Text <> " " Then
            Dim amountdue As Double = Convert.ToDouble(txtAmountDue.Text)
            Dim amountpaid As Double = Convert.ToDouble(txtPayment.Text)
            Dim change As Double = amountpaid - amountdue
            txtChange.Text = change.ToString("N2")
        End If
    End Sub
End Class