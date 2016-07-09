Option Explicit Off
Module mod_search
    Dim cnt As Integer
    Dim conn As New HQ_Connection
    '' ------------------------- INVENTORY W/O ITEM SEARCH--------------------------------------''
    Sub Load_sri_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_type_tbl.item_id, item_type_tbl.item, item_category_tbl.item_category from item_type_tbl join item_category_tbl on item_type_tbl.item_cat_id = item_category_tbl.item_cat_id where item_type_tbl.status = 'Active' and not exists (select inventory_tbl.item_id from inventory_tbl where inventory_tbl.item_id = item_type_tbl.item_id) and item_type_tbl.item like '" & frm_SetItem.txtSearch.Text & "%'"
        If conn.SelectRec(strrec, dt) = True Then
            frm_SetItem.lv_ri.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_SetItem.lv_ri.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_sri_lv()
        With frm_SetItem.lv_ri
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Item Name", 182)
            .Columns.Add("Item Category", 115)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub


    '' ------------------------- INVENTORY W/O ITEM SEARCH--------------------------------------''
    Sub Load_sii_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_type_tbl.item_id, item_type_tbl.item, item_category_tbl.item_category, inventory_tbl.quantity from item_type_tbl join item_category_tbl on item_type_tbl.item_cat_id = item_category_tbl.item_cat_id join inventory_tbl on item_type_tbl.item_id = inventory_tbl.item_id where item_type_tbl.status = 'Active' and inventory_tbl.quantity <> 0 and item_type_tbl.item LIKE '" & frm_SetItem.txtSearch2.Text & "%'"
        If conn.SelectRec(strrec, dt) = True Then
            frm_SetItem.lv_ii.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    frm_SetItem.lv_ii.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_sii_lv()
        With frm_SetItem.lv_ii
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Item Name", 182)
            .Columns.Add("Item Category", 115)
            .Columns.Add("Quantity", 100)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- MONITORING INVENTORY W/O ITEM SEARCH--------------------------------------''
    Sub Load_siii_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_type_tbl.item_id, item_type_tbl.item, item_category_tbl.item_category, inventory_tbl.description, inventory_tbl.quantity from item_type_tbl join item_category_tbl on item_type_tbl.item_cat_id = item_category_tbl.item_cat_id join inventory_tbl on item_type_tbl.item_id = inventory_tbl.item_id where item_type_tbl.status = 'Active' and item_type_tbl.item like '" & mntr_inventory.txtname.Text & "%'"

        If conn.SelectRec(strrec, dt) = True Then
            mntr_inventory.lv_item.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    mntr_inventory.lv_item.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_siii_lv()
        With mntr_inventory.lv_item
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Item", 182)
            .Columns.Add("Item Category", 115)
            .Columns.Add("Description", 115)
            .Columns.Add("Quantity", 115)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- RECEPTIONIST ITEM SEARCH--------------------------------------''
    Sub Load_service_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT stype_id, (SELECT stype_name FROM service_type_tbl WHERE stype_id = service_price_tbl.stype_id) AS `stype_name`, service_gross, service_vat, service_net FROM service_price_tbl WHERE (SELECT stype_name FROM service_type_tbl WHERE stype_id = service_price_tbl.stype_id) LIKE '" & frm_receptionist.TextBox2.Text & "%'"
        If conn.SelectRec(strrec, dt) = True Then
            frm_receptionist.lv_Diagnose.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    frm_receptionist.lv_Diagnose.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_service_lv()
        With frm_receptionist.lv_Diagnose
            .Clear()
            .Columns.Add("ID", 0)
            .Columns.Add("Service Name", 200)
            .Columns.Add("gross", 0)
            .Columns.Add("vat", 0)
            .Columns.Add("Net Pay", 131)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub


    '' ------------------------- SERVICE MONITORING--------------------------------------''
    Sub Load_sri2_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from patient_tbl as a, patient_service_tbl2 as b where a.patient_number = b.patient_id and b.stat = '9' and service_type = '" & mntr_service.cmb_Stype.Text & "'"
        If conn.SelectRec(strrec, dt) = True Then
            mntr_service.lv_service.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(i + 1)
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString + "," + .Item(2).ToString + .Item(3).ToString + ".")
                    lv.SubItems.Add(.Item(19).ToString)
                    lv.SubItems.Add(.Item(22).ToString)
                    lv.SubItems.Add(.Item(21).ToString)
                    mntr_service.lv_service.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_sri2_lv()
        With mntr_service.lv_service
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("NO.", 35)
            .Columns.Add("Patient Id", 90)
            .Columns.Add("Patient Name", 200)
            .Columns.Add("Gross", 70)
            .Columns.Add("Promo", 100)
            .Columns.Add("Date", 100)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub
End Module
