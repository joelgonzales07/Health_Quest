Option Explicit Off
Public Class frm_hmoitem
    Dim conn As New HQ_Connection
    Dim bool As Boolean
    Public count() As String
    Dim id As String
    Public stvar As String
    Sub clear()
        id = ""
        txtService.Text = ""
        txtnet.Text = "0.00"
        txtVat.Text = "0.00"
        txtGross.Text = "0.00"
        txtSearch.Text = ""
        txtnet.Enabled = False
        btnSet.Enabled = False
        btnCLEAR.Enabled = False
        btnImport.Enabled = False
    End Sub
    Sub form()
        clear()
        lv_regular.Clear()
        form_with_price()
        Load_with_price()
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

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        If txtnet.Text = "" Or txtnet.Text = "0" Then
            MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim edit_query As String = "Update hmo_serv_tbl set gross ='" & txtGross.Text & "', vat ='" & txtVat.Text & "', net ='" & txtnet.Text & "' where hmo_id = '" & stvar & "' and serv_id = '" & id & "'"
            If conn.ModRec(edit_query) = True Then
                form()
                MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        clear()
        cboHMO.Text = ""
    End Sub

    Private Sub frm_hmoitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form()
        getcount()
        cmb_hmo()
    End Sub

    Sub Load_with_price()
        Dim dt As New DataTable
        Dim strrec = "select hmo_serv_tbl.id, service_type_tbl.stype_id, service_type_tbl.stype_name, hmo_serv_tbl.gross, hmo_serv_tbl.vat, hmo_serv_tbl.net from hmo_serv_tbl join service_type_tbl on hmo_serv_tbl.serv_id = service_type_tbl.stype_id where service_type_tbl.status = 'Active' and hmo_serv_tbl.hmo_id = '" & stvar & "'"

        If conn.SelectRec(strrec, dt) = True Then
            lv_regular.Items.Clear()
            For i As Integer = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv_regular.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_with_price()
        With lv_regular
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("hmoID", 0)
            .Columns.Add("servID", 0)
            .Columns.Add("Service Name", 350)
            .Columns.Add("Gross", 75)
            .Columns.Add("Vat", 75)
            .Columns.Add("Net", 75)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    Sub cmb_hmo()
        Dim select_query As String = "Select record_id, hmo_card from hmo_tbl where status = 'Active' order by hmo_card"
        Dim dt As New DataTable

        cboHMO.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i As Integer = 0 To (dt.Rows.Count - 1)
                count(i) = dt.Rows(i).Item(0).ToString
                cboHMO.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub

    Sub getcount()
        Dim dt As New DataTable
        Dim select_query As String = "select count(status) from hmo_tbl where status = 'Active'"
        If conn.SelectRec(select_query, dt) = True Then
            ReDim count(dt.Rows(0).Item(0).ToString())
        End If
    End Sub

    Private Sub cboHMO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHMO.SelectedIndexChanged
        With cboHMO
            stvar = count(.SelectedIndex)
        End With
        form()
        btnImport.Enabled = True
    End Sub

    Sub search_services()
        Dim dt As New DataTable
        Dim strrec = "select hmo_serv_tbl.id, service_type_tbl.stype_id, service_type_tbl.stype_name, hmo_serv_tbl.gross, hmo_serv_tbl.vat, hmo_serv_tbl.net from hmo_serv_tbl join service_type_tbl on hmo_serv_tbl.serv_id = service_type_tbl.stype_id where service_type_tbl.status = 'Active' and hmo_serv_tbl.hmo_id = '" & stvar & "' and service_type_tbl.stype_name like '" & txtSearch.Text & "%'"
        If conn.SelectRec(strrec, dt) = True Then
            lv_regular.Items.Clear()
            For i As Integer = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv_regular.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub search_load()
        With lv_regular
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("hmoID", 0)
            .Columns.Add("servID", 0)
            .Columns.Add("Service Name", 350)
            .Columns.Add("Gross", 75)
            .Columns.Add("Vat", 75)
            .Columns.Add("Net", 75)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        lv_regular.Clear()
        search_services()
        search_load()
    End Sub

    Private Sub lv_regular_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_regular.SelectedIndexChanged
        With lv_regular
            id = .SelectedItems(0).SubItems(2).Text
            txtService.Text = .SelectedItems(0).SubItems(3).Text
            txtnet.Enabled = True
            txtnet.Focus()
            btnSet.Enabled = True
            btnCLEAR.Enabled = True
            btnImport.Enabled = True

            Dim dt As New DataTable
            Dim select_query As String = "select gross, vat, net from hmo_serv_tbl where hmo_id = '" & stvar & "' and serv_id = '" & id & "'"
            If conn.SelectRec(select_query, dt) = True Then
                txtGross.Text = dt.Rows(0).Item(0).ToString()
                txtVat.Text = dt.Rows(0).Item(1).ToString()
                txtnet.Text = dt.Rows(0).Item(2).ToString()
            End If

            lv_regular.Clear()
            form_with_price()
            Load_with_price()
        End With
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        userchoice = MsgBox("This button will import the Gross, Vat and Net from the original price you set. However, it will replace any changes you made." & vbCrLf & vbCrLf & "Do you wish to import?", MsgBoxStyle.YesNo, "Notification")

        If userchoice = DialogResult.Yes Then

            Dim dt As New DataTable
            Dim select_query As String = "select stype_id, service_gross, service_vat, service_net from service_price_tbl"
            If conn.SelectRec(select_query, dt) = True Then
                If dt.Rows.Count > 0 Then
                    For i = 0 To 3
                        stype_id = dt.Rows(i).Item(0).ToString()
                        serv_gross = dt.Rows(i).Item(1).ToString()
                        serv_vat = dt.Rows(i).Item(2).ToString()
                        serv_net = dt.Rows(i).Item(3).ToString()

                        Dim edit As String = "Update hmo_serv_tbl set gross ='" & serv_gross & "', vat ='" & serv_vat & "', net ='" & serv_net & "' where hmo_id = '" & stvar & "' and serv_id = '" & stype_id & "'"
                        If conn.ModRec(edit) = True Then

                        End If
                    Next
                    form()
                    btnImport.Enabled = True
                    MessageBox.Show("Import Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub
End Class