Option Explicit Off
Public Class frm_price
    Dim conn As New HQ_Connection
    Dim bool As Boolean
    Sub clear()
        txtID.Text = ""
        txtService.Text = ""
        txtnet.Text = "0.00"
        txtVat.Text = "0.00"
        txtGross.Text = "0.00"
        txtnet.Enabled = False
        btnSet.Enabled = False
        btnCLEAR.Enabled = False
    End Sub
    Sub form()
        clear()
        lv_regular.Clear()
        lv_wreg.Clear()
        form_rserv_lv()
        Load_rserv_lv()
        form_wserv_lv()
        Load_wserv_lv()
    End Sub

    Private Sub frm_price_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form()
    End Sub
    Private Sub lv_regular_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_regular.SelectedIndexChanged
        With lv_regular
            bool = True
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            txtService.Text = .SelectedItems(0).SubItems(2).Text
            txtnet.Enabled = True
            txtnet.Focus()
            btnSet.Enabled = True
            btnCLEAR.Enabled = True
            lv_regular.Clear()
            form_rserv_lv()
            Load_rserv_lv()
        End With
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        clear()
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        If bool = True Then
            If txtnet.Text = "" Or txtnet.Text = "0" Then
                MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stradd As String = "Insert into service_price_tbl values(null,'" & txtID.Text & "','" & txtGross.Text & "','" & txtVat.Text & "','" & txtnet.Text & "')"
                If conn.ModRec(stradd) = True Then
                    form()
                    MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        ElseIf bool = False Then
            If txtnet.Text = "" Or txtnet.Text = "0" Then
                remove_query = "delete from service_price_tbl where stype_id = '" & txtID.Text & "'"
                If conn.ModRec(remove_query) = True Then
                    form()
                    MessageBox.Show("Record(s) Remove Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                edit_query = "Update service_price_tbl set service_gross ='" & txtGross.Text & "', service_vat ='" & txtVat.Text & "', service_net ='" & txtnet.Text & "' where stype_id = '" & txtID.Text & "'"
                If conn.ModRec(edit_query) = True Then
                    form()
                    MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        lv_regular.Clear()
        form_srserv_lv()
        Load_srserv_lv()
    End Sub

    Private Sub txtSearch2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch2.TextChanged
        lv_wreg.Clear()
        form_swserv_lv()
        Load_swserv_lv()
    End Sub

    Private Sub lv_wreg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_wreg.SelectedIndexChanged
        On Error Resume Next
        With lv_wreg
            bool = False
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            txtService.Text = .SelectedItems(0).SubItems(2).Text
            txtnet.Enabled = True
            txtnet.Focus()
            btnSet.Enabled = True
            btnCLEAR.Enabled = True

            Dim dt As New DataTable
            Dim select_query As String = "select service_gross, service_vat, service_net from service_price_tbl where stype_id = '" & txtID.Text & "'"
            If conn.SelectRec(select_query, dt) = True Then
                txtGross.Text = dt.Rows(0).Item(0).ToString()
                txtVat.Text = dt.Rows(0).Item(1).ToString()
                txtnet.Text = dt.Rows(0).Item(2).ToString()
            End If

            lv_wreg.Clear()
            form_wserv_lv()
            Load_wserv_lv()
        End With
    End Sub

    Private Sub txtnet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnet.TextChanged
        If txtnet.Text <> "" Then
            Dim gross As Double
            Dim vat As Double
            Dim net As Double
            net = Convert.ToDouble(txtnet.Text)
            gross = net / 1.12
            vat = net - gross
            txtVat.Text = vat.ToString("N2")
            txtGross.Text = gross.ToString("N2")
        Else
            txtGross.Text = "0.00"
            txtVat.Text = "0.00"
        End If
    End Sub
End Class