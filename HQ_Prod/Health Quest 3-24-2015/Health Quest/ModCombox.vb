Option Explicit Off
Module ModCombox
    Dim conn As New HQ_Connection

    '' --------------------------- DOCTOR ------------------------------''
    Sub cmb_doc_spec()
        Dim select_query As String = "Select spec_id, spec_name from specialization_tbl where status = 'Active' order by spec_name"
        Dim dt As New DataTable

        frm_doctor.cmb_spec.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_doctor.spec(i) = dt.Rows(i).Item(0).ToString
                frm_doctor.cmb_spec.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub
    'Sub cmb_doc_cons()
    '    Dim select_query As String = "Select Cons_id, Cons_name from consultation_tbl where status = 'Active' order by Cons_name"
    '    Dim dt As New DataTable

    '    frm_doctor.cmb_cons.Items.Clear()
    '    If conn.SelectRec(select_query, dt) = True Then
    '        For i = 0 To (dt.Rows.Count - 1)
    '            frm_doctor.cons(i) = dt.Rows(i).Item(0).ToString
    '            frm_doctor.cmb_cons.Items.Add(dt.Rows(i).Item(1).ToString)
    '        Next
    '    End If
    '    dt.Dispose()
    'End Sub
    Sub cmb_doc_dept()
        Dim select_query As String = "Select dept_id, dept_name from department_tbl where status = 'Active' order by dept_name"
        Dim dt As New DataTable

        frm_doctor.cmb_dept.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_doctor.dept(i) = dt.Rows(i).Item(0).ToString
                frm_doctor.cmb_dept.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub

    '' --------------------------- SERVICE CATEGORY ------------------------------''
    Sub cmb_Service_type()
        Dim select_query As String = "Select Scat_id, Scat_name from service_category_tbl where status = 'Active' order by scat_name"
        Dim dt As New DataTable

        frm_serviceType.cmb_Stype.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_serviceType.st(i) = dt.Rows(i).Item(0).ToString
                frm_serviceType.cmb_Stype.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub

    '' --------------------------- RECEPTION HMO ------------------------------''
    Sub cmb_hmo()
        Dim select_query As String = "Select hmo_num from hmo_tbl"
        Dim dt As New DataTable

        'frm_receptionist.cmbHmo.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                'frm_receptionist.cmbHmo.Items.Add(dt.Rows(i).Item(0).ToString)
            Next
        End If
        dt.Dispose()
    End Sub
  

    '' --------------------------- Item CATEGORY ------------------------------''
    Sub cmb_item_type()
        Dim select_query As String = "Select item_cat_id, item_category from item_category_tbl where status = 'Active' order by item_category"
        Dim dt As New DataTable

        frm_item.cmb_itype.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_item.id(i) = dt.Rows(i).Item(0).ToString
                frm_item.cmb_itype.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub

    '' --------------------------- PACKAGE ------------------------------''
    Sub cmb_packge_type()
        Dim select_query As String = "Select pack_id, pack_name from package_tbl where status = 'Active' order by pack_name"
        Dim dt As New DataTable

        frm_package.cmb_package.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_package.count(i) = dt.Rows(i).Item(0).ToString
                frm_package.cmb_package.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub


    '' --------------------------- RECEPTIONIST DOCTOR ------------------------------''
    Sub cmb_R_doc_spec()
        Dim select_query As String = "Select doc_id, CONCAT(CONCAT('Dr. '), CONCAT(doc_lname, ', '), CONCAT(doc_fname, ' '), doc_mname) from doctor_tbl where status = 'Active'"
        Dim dt As New DataTable

        frm_receptionist.cmb_pname1.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_receptionist.doc(i) = dt.Rows(i).Item(0).ToString
                frm_receptionist.cmb_pname1.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
            frm_receptionist.cmb_pname1.Items.Add("None")
        End If
        dt.Dispose()
    End Sub

    '' --------------------------- REFERRAL DOCTOR ------------------------------''
    Sub cmb_refer_doc_spec()
        Dim select_query As String = "Select doc_id, CONCAT(CONCAT('Dr. '), CONCAT(doc_lname, ', '), CONCAT(doc_fname, ' '), doc_mname) from doctor_tbl where status = 'Active'"
        Dim dt As New DataTable

        frm_receptionist.cmb_refer.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_receptionist.ref(i) = dt.Rows(i).Item(0).ToString
                frm_receptionist.cmb_refer.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
            frm_receptionist.cmb_refer.Items.Add("None")
        End If
        dt.Dispose()
    End Sub

    '' --------------------------- SERVICE TYPE ------------------------------''
    Sub cmb_Service_type2()
        Dim select_query As String = "Select stype_name from service_type_tbl"
        Dim dt As New DataTable

        mntr_service.cmb_Stype.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                mntr_service.cmb_Stype.Items.Add(dt.Rows(i).Item(0).ToString)
            Next
        End If
        dt.Dispose()
    End Sub
    '' --------------------------- COMPANY HMO ------------------------------''
    Sub cmb_comp_hmo()
        Dim select_query As String = "select * from hmo_tbl where status = 'Active'"
        Dim dt As New DataTable

        frm_hmo.cmb_comphmo.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_hmo.hmo(i) = dt.Rows(i).Item(0).ToString
                frm_hmo.cmb_comphmo.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub

    '' --------------------------- HMO RECEPTIONIST ------------------------------''
    Sub cmb_recep_hmo()
        Dim select_query As String = "select * from hmo_tbl where status = 'Active'"
        Dim dt As New DataTable

        frm_process.cmb_hmo.Items.Clear()
        frm_process.cmb_hmo.Items.Add("---Add New---")
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_process.hmo(i) = dt.Rows(i).Item(0).ToString
                frm_process.cmb_hmo.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub

    '' --------------------------- RECEP COMPANY ------------------------------''
    Sub cmb_process_comp()
        Dim select_query As String = "select company_id, company_name from company_tbl where status = 'Active'"
        Dim dt As New DataTable

        frm_process.cmb_comp.Items.Clear()
        frm_process.cmb_comp.Items.Add("---Add New---")
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_process.comp(i) = dt.Rows(i).Item(0).ToString
                frm_process.cmb_comp.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
            frm_process.cmb_comp.Items.Add("---None---")
        End If
        dt.Dispose()
    End Sub
    '' --------------------------- QUEUE SERVICE ------------------------------''
    Sub cmb_queue_serv()
        Dim select_query As String = "select stype_id, stype_name from service_type_tbl where status = 'Active' order by stype_name"
        Dim dt As New DataTable

        frm_queue.cmb_service.Items.Clear()
        If conn.SelectRec(select_query, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                frm_queue.serv(i) = dt.Rows(i).Item(0).ToString
                frm_queue.cmb_service.Items.Add(dt.Rows(i).Item(1).ToString)
            Next
        End If
        dt.Dispose()
    End Sub
End Module