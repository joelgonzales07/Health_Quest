Option Explicit Off
Public Class frm_setpackage
    Dim conn As New HQ_Connection
    Public count() As String
    Dim id As String
    Public stvar As String
    Sub getcount()
        Dim dt As New DataTable
        Dim select_query As String = "select count(status) from package_tbl where status = 'Active'"
        If conn.SelectRec(select_query, dt) = True Then
            ReDim count(dt.Rows(0).Item(0).ToString())
        End If
    End Sub
    Private Sub cmb_package_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_package.SelectedIndexChanged
        With cmb_package
            stvar = count(.SelectedIndex)
        End With
        form_sap_lv()
        Load_sap_lv()
        Load_total_text()
        Load_total_text3()
    End Sub

    Private Sub frm_setpackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        getcount()
        cmb_pack_type()
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If cmb_package.Text = "" Or txtnet.Text = 0 Then
            MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim strupdate As String = "Update package_tbl set price = '" & txtset.Text & "', vat = '" & txtvat.Text & "',net = '" & txtnet.Text & "' where pack_id = '" & stvar & "'"
            If conn.ModRec(strupdate) = True Then
                MessageBox.Show("Service Package SET", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lv_services.Clear()
                cmb_package.Text = ""
                txttotal.Text = "0.00"
                txtnet.Text = "0.00"
            End If
        End If
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        cmb_package.Text = ""
        lv_services.Clear()
        txttotal.Text = "0.00"
        txtnet.Text = "0.00"
    End Sub

    Sub Load_sap_lv()
        Dim dt As New DataTable
        Dim strrec = "select package_service_tbl.ID, service_type_tbl.stype_name, service_price_tbl.service_gross from package_service_tbl join service_type_tbl on package_service_tbl.stype_id = service_type_tbl.stype_id join service_price_tbl on package_service_tbl.stype_id = service_price_tbl.stype_id where package_service_tbl.pack_id = '" & stvar & "'"

        If conn.SelectRec(strrec, dt) = True Then
            lv_services.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv_services.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_sap_lv()
        With lv_services
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Service Name", 182)
            .Columns.Add("Service Gross", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    Sub cmb_pack_type()
        Dim select_query As String = "Select pack_id, pack_name from package_tbl where status = 'Active' order by pack_name"
        Dim dt As New DataTable

        cmb_package.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                count(i) = dt.Rows(i).Item(0).ToString
                cmb_package.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub

    Private Sub txtnet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnet.TextChanged
        If txtnet.Text <> "" Then
            Dim gross As Double
            Dim vat As Double
            Dim net As Double
            net = Convert.ToDouble(txtnet.Text)
            gross = net / 1.12
            vat = net - gross
            txtvat.Text = vat.ToString("N2")
            txtset.Text = gross.ToString("N2")
        Else
            txtset.Text = "0.00"
            txtvat.Text = "0.00"
        End If
    End Sub
End Class