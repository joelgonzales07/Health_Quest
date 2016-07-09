Option Explicit Off
Public Class frm_services
    Dim conn As New HQ_Connection
    Public count() As String
    Dim id As String
    Public stvar As String
    Dim usercount As Integer = 0
    Dim usercount2 As Integer = 0
    Sub getcount()
        Dim dt As New DataTable
        Dim select_query As String = "select count(status) from service_type_tbl where status = 'Active'"
        If conn.SelectRec(select_query, dt) = True Then
            ReDim count(dt.Rows(0).Item(0).ToString())
        End If
    End Sub
    Private Sub cmb_services_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_services.SelectedIndexChanged
        With cmb_services
            stvar = count(.SelectedIndex)
        End With
        lv_sitem.Clear()
        lv_nitem.Clear()
        form_sip_lv()
        Load_sip_lv()
        form_nip_lv()
        Load_nip_lv()
    End Sub

    Private Sub lv_sitem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_sitem.SelectedIndexChanged
        If usercount = 0 Then
            If lv_sitem.SelectedIndices.Count = 0 Then
            ElseIf lv_sitem.SelectedItems.Count > 0 Then
                If MessageBox.Show("Do you want to remove this item in the Service of " & cmb_services.Text, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    With lv_sitem
                        On Error Resume Next
                        id = .SelectedItems(0).SubItems(0).Text
                        Dim stradd As String = "Delete from service_item_tbl where ID = '" & id & "'"
                        If conn.ModRec(stradd) = True Then
                            MessageBox.Show("Item removed from the service", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lv_sitem.Clear()
                            lv_nitem.Clear()
                            form_sip_lv()
                            Load_sip_lv()
                            form_nip_lv()
                            Load_nip_lv()
                        End If
                    End With
                    usercount = 1
                End If
            End If
        Else
            usercount = 0
        End If
    End Sub

    Private Sub lv_nitem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_nitem.SelectedIndexChanged
        If cmb_services.Text = "" Then
            MessageBox.Show("Select a service first in the combo box", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmb_services.Focus()
        Else
            If usercount2 = 0 Then
                If lv_nitem.SelectedIndices.Count = 0 Then
                ElseIf lv_nitem.SelectedItems.Count > 0 Then
                    With lv_nitem
                        On Error Resume Next
                        Service = .SelectedItems(0).SubItems(1).Text
                        Name = .SelectedItems(0).SubItems(2).Text
                    End With

                    Dim input As String = InputBox("How many " & Name & " needed?", "Input", "1", 600, 300)
                    If input > 0 Then
                        Dim stradd As String = "Insert into service_item_tbl values(null,'" & stvar & "','" & Service & "','" & input & "')"
                        If conn.ModRec(stradd) = True Then
                            MessageBox.Show("Item added in the service", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            form_sip_lv()
                            Load_sip_lv()
                            form_nip_lv()
                            Load_nip_lv()
                        End If
                    End If
                    usercount2 = 1
                End If
            Else
                usercount2 = 0
            End If
        End If
    End Sub

    Private Sub frm_services_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        getcount()
        cmb_services_type()
    End Sub

    Sub Load_sip_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_id, item from item_type_tbl where status = 'Active' and not exists (select service_item_tbl.item_id from service_item_tbl where service_item_tbl.item_id = item_type_tbl.item_id and service_item_tbl.stype_id = '" & stvar & "')"

        If conn.SelectRec(strrec, dt) = True Then
            lv_nitem.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv_nitem.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_sip_lv()
        With lv_nitem
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Item Name", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    Sub Load_nip_lv()
        Dim dt As New DataTable
        Dim strrec = "select service_item_tbl.ID, item_type_tbl.item_id, item_type_tbl.item, service_item_tbl.quantity from service_item_tbl join item_type_tbl on service_item_tbl.item_id = item_type_tbl.item_id where service_item_tbl.stype_id = '" & stvar & "'"

        If conn.SelectRec(strrec, dt) = True Then
            lv_sitem.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv_sitem.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_nip_lv()
        With lv_sitem
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Item ID", 0)
            .Columns.Add("Item Name", 182)
            .Columns.Add("Quantity Needed", 100)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    Sub cmb_services_type()
        Dim select_query As String = "Select stype_id, stype_name from service_type_tbl where status = 'Active' order by stype_name"
        Dim dt As New DataTable

        cmb_services.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                count(i) = dt.Rows(i).Item(0).ToString
                cmb_services.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub
End Class