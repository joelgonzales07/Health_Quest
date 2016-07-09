Option Explicit Off
Module ModListview
    Dim cnt As Integer
    Dim conn As New HQ_Connection

    '' ------------------------- DEPARTMENT --------------------------------------''
    Sub Load_dept_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from department_tbl where status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_department.lv_Dept.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    frm_department.lv_Dept.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_dept_lv()
        With frm_department.lv_Dept
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Department Name", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- SPECIALIZATION --------------------------------------''
    Sub Load_spec_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from specialization_tbl where status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_specialization.lv_Spec.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    frm_specialization.lv_Spec.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_spec_lv()
        With frm_specialization.lv_Spec
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Specialization Name", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub
    '' ------------------------- CONSULTATION --------------------------------------''
    Sub Load_cons_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from consultation_tbl where status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_consultation.lv_Cons.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    frm_consultation.lv_Cons.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_cons_lv()
        With frm_consultation.lv_Cons
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Consultation Name", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- DOCTOR --------------------------------------''
    Sub Load_doc_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT doc_id, CONCAT(CONCAT('Dr. '), CONCAT(doc_lname, ', '), CONCAT(doc_fname, ' '), doc_mname), (SELECT spec_name FROM specialization_tbl WHERE spec_id = doctor_tbl.spec_id) AS 'spec', (SELECT cons_name FROM consultation_tbl WHERE cons_id = doctor_tbl.cons_id) AS 'cons', (SELECT dept_name FROM department_tbl WHERE dept_id = doctor_tbl.dept_id) AS 'dept', consfee FROM doctor_tbl WHERE STATUS = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_doctor.lv_doc.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    frm_doctor.lv_doc.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_doc_lv()
        With frm_doctor.lv_doc
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Doctor's Name", 182)
            .Columns.Add("Specialization", 100)
            .Columns.Add("Consultation", 0)
            .Columns.Add("Department", 100)
            .Columns.Add("Consultation Fee", 100)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- SERVICE CATEGORY --------------------------------------''
    Sub Load_Scat_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from Service_category_tbl where status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_serviceType.lv_Scat.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    frm_serviceType.lv_Scat.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_scat_lv()
        With frm_serviceType.lv_Scat
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Service Category Name", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub
    '' ------------------------- SERVICE TYPE --------------------------------------''
    Sub Load_Stype_lv()
        Dim dt As New DataTable
        Dim strrec = "Select stype_id, stype_name, (select Scat_name from service_category_tbl where Scat_id = service_type_tbl.scat_id) as 'Service Category' from service_type_tbl where status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_serviceType.lv_Stype.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_serviceType.lv_Stype.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_stype_lv()
        With frm_serviceType.lv_Stype
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Service Type Name", 182)
            .Columns.Add("Service Category", 170)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- PACKAGE --------------------------------------''
    Sub Load_pack_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from package_tbl where status = 'Active'"
        If conn.SelectRec(strrec, dt) = True Then
            frm_package.lv_pack.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    frm_package.lv_pack.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_pack_lv()
        With frm_package.lv_pack
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Package Name", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- USERACCOUNT --------------------------------------''
    Sub Load_user_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from user_tbl where position <> 'Administrator' and status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_user.lv_User.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    frm_user.lv_User.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_user_lv()
        With frm_user.lv_User
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Name", 182)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- CHANGEPASSWORD --------------------------------------''
    Sub Load_pass_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from user_tbl where position <> 'Administrator'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_changepassword.lv_User.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(i + 1)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    frm_changepassword.lv_user.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_pass_lv()
        With frm_changepassword.lv_user
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("NO.", 35)
            .Columns.Add("Name", 182)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .Columns.Add("", 0)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- SCHEDULE'S DOCTOR --------------------------------------''
    Sub Load_sdoc_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT doc_id, CONCAT(CONCAT('Dr. '), CONCAT(doc_lname, ', '), CONCAT(doc_fname, ' '), doc_mname), doc_contact, (SELECT spec_name FROM specialization_tbl WHERE spec_id = doctor_tbl.spec_id) AS 'spec', (SELECT cons_name FROM consultation_tbl WHERE cons_id = doctor_tbl.cons_id) AS 'cons', (SELECT dept_name FROM department_tbl WHERE dept_id = doctor_tbl.dept_id) AS 'dept' FROM doctor_tbl WHERE STATUS = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_schedule.lv_doctor.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    frm_schedule.lv_doctor.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_sdoc_lv()
        With frm_schedule.lv_doctor
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Name", 182)
            .Columns.Add("Contact", 100)
            .Columns.Add("Specialization", 100)
            .Columns.Add("Consultation", 0)
            .Columns.Add("Department", 100)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- SERVICE REGULAR w/o PRICE--------------------------------------''
    Sub Load_rserv_lv()
        Dim dt As New DataTable
        Dim strrec = "select service_type_tbl.stype_id, service_type_tbl.stype_name, service_category_tbl.scat_name from service_type_tbl join service_category_tbl on service_type_tbl.scat_id = service_category_tbl.scat_id where service_type_tbl.status = 'Active' and not exists (select service_price_tbl.stype_id from service_price_tbl where service_price_tbl.stype_id = service_type_tbl.stype_id)"

        If conn.SelectRec(strrec, dt) = True Then
            frm_price.lv_regular.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_price.lv_regular.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_rserv_lv()
        With frm_price.lv_regular
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Service Name", 178)
            .Columns.Add("Service Category", 115)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub
    '' ------------------------- SERVICE REGULAR w/o PRICE  SEARCHING--------------------------------------''
    Sub Load_srserv_lv()
        Dim dt As New DataTable
        Dim strrec = "select service_type_tbl.stype_id, service_type_tbl.stype_name, service_category_tbl.scat_name from service_type_tbl join service_category_tbl on service_type_tbl.scat_id = service_category_tbl.scat_id where service_type_tbl.status = 'Active' and not exists (select service_price_tbl.stype_id from service_price_tbl where service_price_tbl.stype_id = service_type_tbl.stype_id) and service_type_tbl.stype_name like '" & frm_price.txtSearch.Text & "%'"
        If conn.SelectRec(strrec, dt) = True Then
            frm_price.lv_regular.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_price.lv_regular.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_srserv_lv()
        With frm_price.lv_regular
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Service Name", 178)
            .Columns.Add("Service Category", 115)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- SERVICE REGULAR w PRICE--------------------------------------''
    Sub Load_wserv_lv()
        Dim dt As New DataTable
        Dim strrec = "select service_type_tbl.stype_id, service_type_tbl.stype_name, service_category_tbl.scat_name from service_type_tbl join service_category_tbl on service_type_tbl.scat_id = service_category_tbl.scat_id join service_price_tbl on service_type_tbl.stype_id = service_price_tbl.stype_id where service_type_tbl.status = 'Active' and service_price_tbl.service_gross <> 0"

        If conn.SelectRec(strrec, dt) = True Then
            frm_price.lv_wreg.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_price.lv_wreg.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_wserv_lv()
        With frm_price.lv_wreg
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Service Name", 178)
            .Columns.Add("Service Category", 115)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- SERVICE REGULAR w PRICE  SEARCHING--------------------------------------''
    Sub Load_swserv_lv()
        Dim dt As New DataTable
        Dim strrec = "select service_type_tbl.stype_id, service_type_tbl.stype_name, service_category_tbl.scat_name from service_type_tbl join service_category_tbl on service_type_tbl.scat_id = service_category_tbl.scat_id join service_price_tbl on service_type_tbl.stype_id = service_price_tbl.stype_id where service_type_tbl.status = 'Active' and service_price_tbl.service_gross <> 0 and service_type_tbl.stype_name like '" & frm_price.txtSearch2.Text & "%'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_price.lv_wreg.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_price.lv_wreg.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_swserv_lv()
        With frm_price.lv_wreg
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Service Name", 178)
            .Columns.Add("Service Category", 115)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub


    '' ------------------------- CLIENT--------------------------------------''
    Sub Load_cl_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from patient_tbl where lname LIKE '" & frm_receptionist.TextBox1.Text & "%' order by lname"

        If conn.SelectRec(strrec, dt) = True Then
            frm_receptionist.lv_Client.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString + "," + .Item(2).ToString + " " + .Item(3).ToString)
                    frm_receptionist.lv_Client.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub Load_cl1_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from patient_tbl order by lname"

        If conn.SelectRec(strrec, dt) = True Then
            frm_receptionist.lv_Client.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString + "," + .Item(2).ToString + " " + .Item(3).ToString)
                    frm_receptionist.lv_Client.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_cl_lv()
        With frm_receptionist.lv_Client
            .Clear()
            .Columns.Add("Patient Number", 100)
            .Columns.Add("Name", 175)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
        End With
    End Sub

    '' ------------------------- ITEM --------------------------------------''
    Sub Load_item_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from item_category_tbl where status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_item.lv_item.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    frm_item.lv_item.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_item_lv()
        With frm_item.lv_item
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Item Category", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- item TYPE --------------------------------------''
    Sub Load_itype_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_type_tbl.item_id, item_category_tbl.item_category, item_type_tbl.item from item_type_tbl join item_category_tbl on item_type_tbl.item_cat_id = item_category_tbl.item_cat_id where item_type_tbl.status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_item.lv_itype.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_item.lv_itype.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_itype_lv()
        With frm_item.lv_itype
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Item Category", 182)
            .Columns.Add("Item Type Name", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- HMO --------------------------------------''
    Sub Load_hmo_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from hmo_tbl where status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_hmo.lv_hmo.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_hmo.lv_hmo.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_hmo_lv()
        With frm_hmo.lv_hmo
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("HMO Card Name", 100)
            .Columns.Add("HMO Number", 100)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    Sub load_comp_lv()
        Dim dt As New DataTable
        Dim strrec = "Select company_id, company_name, (select hmo_card from hmo_tbl where Record_ID = company_tbl.hmo_id) as hmo_card from company_tbl where status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_hmo.lv_comp.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_hmo.lv_comp.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_comp_lv()
        With frm_hmo.lv_comp
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Company Name", 100)
            .Columns.Add("HMO Card", 100)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' -------------------------Item Ri --------------------------------------''
    Sub Load_ri_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_type_tbl.item_id, item_type_tbl.item, item_category_tbl.item_category from item_type_tbl join item_category_tbl on item_type_tbl.item_cat_id = item_category_tbl.item_cat_id where item_type_tbl.status = 'Active' and not exists (select inventory_tbl.item_id from inventory_tbl where inventory_tbl.item_id = item_type_tbl.item_id)"

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

    Sub form_ri_lv()
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

    '' -------------------------Item ii --------------------------------------''
    Sub Load_ii_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_type_tbl.item_id, item_type_tbl.item, item_category_tbl.item_category, inventory_tbl.quantity from item_type_tbl join item_category_tbl on item_type_tbl.item_cat_id = item_category_tbl.item_cat_id join inventory_tbl on item_type_tbl.item_id = inventory_tbl.item_id where item_type_tbl.status = 'Active' and inventory_tbl.quantity <> 0"

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

    Sub form_ii_lv()
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

    '' ------------------------- SET PACKAGE --------------------------------------''
    Sub Load_sp_lv()
        Dim dt As New DataTable
        Dim strrec = "select package_service_tbl.ID, service_type_tbl.stype_id, service_type_tbl.stype_name, service_price_tbl.service_gross from package_service_tbl join service_type_tbl on package_service_tbl.stype_id = service_type_tbl.stype_id join service_price_tbl on package_service_tbl.stype_id = service_price_tbl.stype_id where package_service_tbl.pack_id = '" & frm_package.stvar & "'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_package.ListView1.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    frm_package.ListView1.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_sp_lv()
        With frm_package.ListView1
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Service ID", 0)
            .Columns.Add("Service Name", 182)
            .Columns.Add("Service Gross", 115)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- TOTAL PACKAGE--------------------------------------''
    Sub Load_total_text()
        Dim dt As New DataTable
        Dim strrec = "select sum(service_price_tbl.service_gross) from package_service_tbl join service_price_tbl on package_service_tbl.stype_id = service_price_tbl.stype_id where package_service_tbl.pack_id = '" & frm_setpackage.stvar & "'"

        If conn.SelectRec(strrec, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)

                With dt.Rows(i)
                    frm_setpackage.txttotal.Text = .Item(0).ToString
                End With
            Next
            If frm_setpackage.txttotal.Text = "" Then
                frm_setpackage.txttotal.Text = "0.00"
            End If
            dt.Dispose()
        End If
    End Sub

    '' ------------------------- TOTAL SET PACKAGE--------------------------------------''
    Sub Load_total_text3()
        Dim dt As New DataTable
        Dim strrec = "select price from package_tbl where pack_id = '" & frm_setpackage.stvar & "' "

        If conn.SelectRec(strrec, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)

                With dt.Rows(i)
                    frm_setpackage.txtnet.Text = .Item(0).ToString

                End With
            Next
            If frm_setpackage.txtnet.Text = "" Then
                frm_setpackage.txtnet.Text = "0.00"
            End If
            dt.Dispose()
        End If
    End Sub

    '' ------------------------- ADD PACKAGE --------------------------------------''
    Sub Load_ap_lv()
        Dim dt As New DataTable
        Dim strrec = "select service_type_tbl.stype_id, service_type_tbl.stype_name, service_price_tbl.service_gross from service_type_tbl join service_price_tbl on service_type_tbl.stype_id = service_price_tbl.stype_id where service_type_tbl.status = 'Active' and service_price_tbl.service_gross <> 0 and not exists (select package_service_tbl.stype_id from package_service_tbl where package_service_tbl.stype_id = service_type_tbl.stype_id and package_service_tbl.pack_id = '" & frm_package.stvar & "')"

        If conn.SelectRec(strrec, dt) = True Then
            frm_package.lv_services.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    frm_package.lv_services.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_ap_lv()
        With frm_package.lv_services
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



    ' -------------------------  SERVICE --------------------------------------''
    Sub Load_d_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT stype_id, (SELECT stype_name FROM service_type_tbl WHERE stype_id = service_price_tbl.stype_id), service_gross, service_vat, service_net FROM service_price_tbl"

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

    Sub form_d_lv()
        With frm_receptionist.lv_Diagnose
            .Clear()
            .Columns.Add("ID", 0)
            .Columns.Add("Service Name", 200)
            .Columns.Add("net", 0)
            .Columns.Add("vat", 0)
            .Columns.Add("Gross", 131)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
        End With
    End Sub


    '' ------------------------- LOAD CLIENT --------------------------------------''
    Sub Load_text_lv()
        Dim dt As New DataTable
        Dim strrec = "Select patient_number, lname, fname, mname, bday, age, gender, address, tel, mob, email, (select CONCAT(CONCAT('Dr. '), CONCAT(doc_lname, ', '), CONCAT(doc_fname, ' '), doc_mname) from doctor_tbl where doc_id = patient_tbl.referred_by) from patient_tbl where patient_number = '" & frm_receptionist.txtPnumber.Text & "'"

        If conn.SelectRec(strrec, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                With dt.Rows(i)
                    frm_receptionist.txtLname.Text = .Item(1).ToString
                    frm_receptionist.txtFname.Text = .Item(2).ToString
                    frm_receptionist.txtmname.Text = .Item(3).ToString
                    frm_receptionist.DTP1.Text = .Item(4).ToString
                    frm_receptionist.txtage.Text = .Item(5).ToString
                    frm_receptionist.cmbgender.Text = .Item(6).ToString
                    frm_receptionist.txtaddress.Text = .Item(7).ToString
                    frm_receptionist.txtTel.Text = .Item(8).ToString
                    frm_receptionist.txtmob.Text = .Item(9).ToString
                    frm_receptionist.txtemail.Text = .Item(10).ToString
                    frm_receptionist.cmb_refer.Text = .Item(11).ToString
                End With
            Next
            dt.Dispose()
        End If
    End Sub
    ' '' ------------------------- AVAIL SERVICE --------------------------------------''
    'Sub Load_aser_lv()
    '    Dim dt As New DataTable
    '    Dim strrec = "select * from service_information_tbl where patient_id = '" & frm_receptionist.txtPnumber.Text & "' and record_id = '" & frm_receptionist.txtServiceID.Text & "'"

    '    If conn.SelectRec(strrec, dt) = True Then
    '        frm_receptionist.lv_user.Items.Clear()
    '        For i = 0 To (dt.Rows.Count - 1)
    '            Dim lv As New ListViewItem
    '            With dt.Rows(i)
    '                lv.Text = .Item(0).ToString
    '                lv.SubItems.Add(i + 1)
    '                lv.SubItems.Add(.Item(2).ToString)
    '                lv.SubItems.Add(.Item(3).ToString)
    '                lv.SubItems.Add(.Item(5).ToString)
    '                frm_receptionist.lv_user.Items.Add(lv)
    '            End With
    '        Next
    '        dt.Dispose()
    '    End If
    'End Sub

    'Sub form_aser_lv()
    '    With frm_receptionist.lv_user
    '        .Clear()
    '        .Columns.Add("", 0)
    '        .Columns.Add("NO.", 35)
    '        .Columns.Add("Service Name", 182)
    '        .Columns.Add("Service Price", 112)
    '        .Columns.Add("Date", 112)
    '        .View = View.Details
    '        .FullRowSelect = True
    '        .GridLines = True
    '    End With
    'End Sub

    '' ------------------------- CASHIER SERVICE --------------------------------------''
    Sub Load_cd_lv()
        Dim dt As New DataTable
        Dim strrec = ""

        If conn.SelectRec(strrec, dt) = True Then
            frm_cashier.lv_service.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(i + 1)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    frm_cashier.lv_service.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_cd_lv()
        With frm_cashier.lv_service
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("NO.", 35)
            .Columns.Add("Service Name", 178)
            .Columns.Add("Gross", 150)
            .Columns.Add("Date", 150)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
        End With
    End Sub

   
    '' ------------------------- PATIENT MONITORING --------------------------------------''
    Sub Load_patSearch_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from patient_tbl where patient_number = '" + mntr_patient.txtpatientid.Text + "'"

        If conn.SelectRec(strrec, dt) = True Then
            mntr_patient.lv_monitoring.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(i + 1)
                    lv.SubItems.Add(.Item(1).ToString + "," + .Item(2).ToString + " " + .Item(3).ToString + ".")
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    lv.SubItems.Add(.Item(7).ToString)
                    lv.SubItems.Add(.Item(8).ToString)
                    lv.SubItems.Add(.Item(9).ToString)
                    mntr_patient.lv_monitoring.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_patSearch_lv()
        With mntr_patient.lv_monitoring
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("NO.", 35)
            .Columns.Add(" Name", 150)
            .Columns.Add(" Birthday", 80)
            .Columns.Add(" Age", 50)
            .Columns.Add(" Gender", 80)
            .Columns.Add(" Address", 100)
            .Columns.Add(" TEL", 80)
            .Columns.Add(" MOB", 80)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- PATIENT MONITORING --------------------------------------''
    Sub Load_pat_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from patient_tbl"

        If conn.SelectRec(strrec, dt) = True Then
            mntr_patient.lv_monitoring.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(i + 1)
                    lv.SubItems.Add(.Item(1).ToString + "," + .Item(2).ToString + " " + .Item(3).ToString + ".")
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    lv.SubItems.Add(.Item(7).ToString)
                    lv.SubItems.Add(.Item(8).ToString)
                    lv.SubItems.Add(.Item(9).ToString)
                    mntr_patient.lv_monitoring.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_pat_lv()
        With mntr_patient.lv_monitoring
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("NO.", 35)
            .Columns.Add(" Name", 150)
            .Columns.Add(" Birthday", 80)
            .Columns.Add(" Age", 50)
            .Columns.Add(" Gender", 80)
            .Columns.Add(" Address", 100)
            .Columns.Add(" TEL", 80)
            .Columns.Add(" MOB", 80)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- DOCTOR MONITORING --------------------------------------''
    Sub Load_dmSearch_lv()
        Dim dt As New DataTable
        Dim strrec = "select doctor_tbl.doc_id, CONCAT(CONCAT('Dr. '), CONCAT(doctor_tbl.doc_lname, ', '), CONCAT(doctor_tbl.doc_fname, ' '), doctor_tbl.doc_mname), doctor_tbl.doc_contact, department_tbl.dept_name, specialization_tbl.spec_name, schedule_tbl.monday, schedule_tbl.tuesday, schedule_tbl.wednesday, schedule_tbl.thursday, schedule_tbl.friday, schedule_tbl.saturday from doctor_tbl join department_tbl on doctor_tbl.dept_id = department_tbl.dept_id join specialization_tbl on doctor_tbl.spec_id = specialization_tbl.spec_id join schedule_tbl on doctor_tbl.doc_id = schedule_tbl.doctor_id where CONCAT(CONCAT(doctor_tbl.doc_lname, ', '), CONCAT(doctor_tbl.doc_fname, ' '), doctor_tbl.doc_mname) LIKE  '" + mntr_doctor.txtDocName.Text + "%'"

        If conn.SelectRec(strrec, dt) = True Then
            mntr_doctor.lv_monitoring.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    lv.SubItems.Add(.Item(7).ToString)
                    lv.SubItems.Add(.Item(8).ToString)
                    lv.SubItems.Add(.Item(9).ToString)
                    lv.SubItems.Add(.Item(10).ToString)
                    mntr_doctor.lv_monitoring.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_dmSearch_lv()
        With mntr_doctor.lv_monitoring
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Name", 150)
            .Columns.Add("Contact", 100)
            .Columns.Add("Department", 100)
            .Columns.Add("Specialization", 100)
            .Columns.Add("Monday", 110)
            .Columns.Add("Tuestday", 110)
            .Columns.Add("Wednesday", 110)
            .Columns.Add("Thursday", 110)
            .Columns.Add("Friday", 110)
            .Columns.Add("Saturday", 110)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub
    '' ------------------------- DOCTOR MONITORING --------------------------------------''
    Sub Load_dm_lv()
        Dim dt As New DataTable
        Dim strrec = "select doctor_tbl.doc_id, CONCAT(CONCAT('Dr. '), CONCAT(doctor_tbl.doc_lname, ', '), CONCAT(doctor_tbl.doc_fname, ' '), doctor_tbl.doc_mname), doctor_tbl.doc_contact, department_tbl.dept_name, specialization_tbl.spec_name, schedule_tbl.monday, schedule_tbl.tuesday, schedule_tbl.wednesday, schedule_tbl.thursday, schedule_tbl.friday, schedule_tbl.saturday from doctor_tbl join department_tbl on doctor_tbl.dept_id = department_tbl.dept_id join specialization_tbl on doctor_tbl.spec_id = specialization_tbl.spec_id join schedule_tbl on doctor_tbl.doc_id = schedule_tbl.doctor_id"

        If conn.SelectRec(strrec, dt) = True Then
            mntr_doctor.lv_monitoring.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    lv.SubItems.Add(.Item(7).ToString)
                    lv.SubItems.Add(.Item(8).ToString)
                    lv.SubItems.Add(.Item(9).ToString)
                    lv.SubItems.Add(.Item(10).ToString)
                    mntr_doctor.lv_monitoring.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_dm_lv()
        With mntr_doctor.lv_monitoring
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID", 35)
            .Columns.Add("Name", 150)
            .Columns.Add("Contact", 100)
            .Columns.Add("Department", 100)
            .Columns.Add("Specialization", 100)
            .Columns.Add("Monday", 110)
            .Columns.Add("Tuestday", 110)
            .Columns.Add("Wednesday", 110)
            .Columns.Add("Thursday", 110)
            .Columns.Add("Friday", 110)
            .Columns.Add("Saturday", 110)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub
    '' ------------------------- Staff --------------------------------------''
    Sub Load_staff_lv()
        Dim dt As New DataTable
        Dim strrec = "Select * from staff_tbl where status = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_Staff.lv_staff.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    frm_Staff.lv_staff.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_staff_lv()
        With frm_Staff.lv_staff
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("ID.", 35)
            .Columns.Add("Staff Name", 182)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' -------------------------Item ii --------------------------------------''
    Sub Load_Citem_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_type_tbl.item_id, item_type_tbl.item, item_category_tbl.item_category, inventory_tbl.description, inventory_tbl.quantity from item_type_tbl join item_category_tbl on item_type_tbl.item_cat_id = item_category_tbl.item_cat_id join inventory_tbl on item_type_tbl.item_id = inventory_tbl.item_id where item_type_tbl.status = 'Active' and inventory_tbl.quantity <> 0"

        If conn.SelectRec(strrec, dt) = True Then
            frm_request_item.lv_item.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    frm_request_item.lv_item.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_Citem_lv()
        With frm_request_item.lv_item
            .Clear()
            .Columns.Add("ID.", 35)
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

    ' '' -------------------------Item ii --------------------------------------''
    'Sub Load_req_lv()
    '    Dim dt As New DataTable
    '    Dim strrec = "Select * from request_tbl where stat = '0'"

    '    If conn.SelectRec(strrec, dt) = True Then
    '        frm_request_item.lv_Request.Items.Clear()
    '        For i = 0 To (dt.Rows.Count - 1)
    '            Dim lv As New ListViewItem
    '            With dt.Rows(i)
    '                lv.Text = .Item(0).ToString
    '                lv.SubItems.Add(i + 1)
    '                lv.SubItems.Add(.Item(1).ToString)
    '                lv.SubItems.Add(.Item(2).ToString)
    '                frm_request_item.lv_Request.Items.Add(lv)
    '            End With
    '        Next
    '        dt.Dispose()
    '    End If

    'End Sub

    'Sub form_req_lv()
    '    With frm_request_item.lv_Request
    '        .Clear()
    '        .Columns.Add("", 0)
    '        .Columns.Add("NO.", 35)
    '        .Columns.Add("Item Name", 182)
    '        .Columns.Add("Quantity", 115)
    '        .View = View.Details
    '        .FullRowSelect = True
    '        .GridLines = True
    '        .BackColor = Color.DarkGray
    '    End With
    'End Sub

    '' ------------------------- LOAD CLIENT --------------------------------------''
    Sub Load_cashier_patient_text()
        Dim dt As New DataTable
        Dim strrec = ""

        If conn.SelectRec(strrec, dt) = True Then
            For i = 0 To (dt.Rows.Count - 1)
                With dt.Rows(i)
                    frm_cashier.lblNService.Text = .Item(0).ToString
                    frm_cashier.lblGross.Text = .Item(1).ToString
                End With
            Next
            dt.Dispose()
        End If

    End Sub


    ' -------------------------  SERVICE PROMO --------------------------------------''
    Sub Load_pd_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT pack_id, pack_name, price, vat, net FROM package_tbl WHERE STATUS = 'Active'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_receptionist.lv_promo.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    frm_receptionist.lv_promo.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub form_pd_lv()
        With frm_receptionist.lv_promo
            .Clear()
            .Columns.Add("ID", 0)
            .Columns.Add("Package Name", 200)
            .Columns.Add("net", 0)
            .Columns.Add("vat", 0)
            .Columns.Add("Gross", 131)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
        End With
    End Sub



    '' ------------------------- CASHIER SERVICE 2--------------------------------------''
    Sub Load_cd2_lv()
        Dim dt As New DataTable
        Dim strrec = ""

        If conn.SelectRec(strrec, dt) = True Then
            frm_cashier.lv_service.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(i + 1)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    frm_cashier.lv_service.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_cd2_lv()
        With frm_cashier.lv_service
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("NO.", 35)
            .Columns.Add("Service Name", 178)
            .Columns.Add("Gross", 150)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
        End With
    End Sub

   

    '' -------------------------Item ii --------------------------------------''
    Sub Load_Citem2_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_type_tbl.item_id, item_type_tbl.item, item_category_tbl.item_category, inventory_tbl.description, inventory_tbl.quantity from item_type_tbl join item_category_tbl on item_type_tbl.item_cat_id = item_category_tbl.item_cat_id join inventory_tbl on item_type_tbl.item_id = inventory_tbl.item_id where item_type_tbl.status = 'Active'"

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

    Sub form_Citem2_lv()
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
    '' ------------------------- DEPARTMENT --------------------------------------''
    Sub Load_balance_lv()
        Dim dt As New DataTable
        Dim strrec = "select transaction_id, test_id, orno, patient_id, amount_due, amount_paid, discount, constat, otherstat from transaction_tbl"
        If conn.SelectRec(strrec, dt) = True Then
            frm_Balance.lv_Adjust.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    lv.SubItems.Add(.Item(7).ToString)
                    lv.SubItems.Add(.Item(8).ToString)
                    frm_Balance.lv_Adjust.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub

    Sub Load_balance2_lv()
        Dim dt As New DataTable
        Dim strrec = "select transaction_id, test_id, orno, patient_id, amount_due, amount_paid, discount,  constat, otherstat from transaction_tbl where test_id like '" & frm_Balance.txtTransID.Text & "%'"
        If conn.SelectRec(strrec, dt) = True Then
            frm_Balance.lv_Adjust.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    lv.SubItems.Add(.Item(7).ToString)
                    lv.SubItems.Add(.Item(8).ToString)
                    frm_Balance.lv_Adjust.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If

    End Sub
    Sub form_balance_lv()
        With frm_Balance.lv_Adjust
            .Clear()
            .Columns.Add("", 0)
            .Columns.Add("TI", 0)
            .Columns.Add("Transaction ID", 90)
            .Columns.Add("OR Number", 70)
            .Columns.Add("Patient ID", 80)
            .Columns.Add("Amount Due", 80)
            .Columns.Add("Amount Paid", 80)
            .Columns.Add("Discount", 0)
            .Columns.Add("constat", 0)
            .Columns.Add("otherstat", 0)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- test request reception --------------------------------------''

    Sub load_tr_lv()
        Dim dt As New DataTable
        Dim strrec = "select id, (select CONCAT(CONCAT('Dr. '), CONCAT(doc_lname, ', '), CONCAT(doc_fname, ' '), doc_mname) from doctor_tbl where doc_id = patient_test_tbl.doc_id), c_fee, t_r, med_information, t_date, payment_status, locked from patient_test_tbl where patient_number = '" + frm_receptionist.txtPnumber.Text + "'"
        If conn.SelectRec(strrec, dt) = True Then
            frm_receptionist.lv_tr.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    lv.SubItems.Add(.Item(7).ToString)
                    frm_receptionist.lv_tr.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_tr_lv()
        With frm_receptionist.lv_tr
            .Clear()
            .Columns.Add("ID", 0)
            .Columns.Add("Physician", 125)
            .Columns.Add("Fee", 50)
            .Columns.Add("Test Requested", 175)
            .Columns.Add("Medical Info", 175)
            .Columns.Add("Date", 75)
            .Columns.Add("pstatus", 0)
            .Columns.Add("locked", 0)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- reception service acquisition --------------------------------------''

    Sub load_userrep_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT testservice_id, IF (service_table = 'service_type_tbl', (SELECT stype_name FROM service_type_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT pack_name FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `service`, IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `net`, payment_status FROM testservice_tbl WHERE test_id = '" + frm_receptionist.trID + "'"
        If conn.SelectRec(strrec, dt) = True Then
            frm_receptionist.lv_user.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    frm_receptionist.lv_user.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_userrep_lv()
        With frm_receptionist.lv_user
            .Clear()
            .Columns.Add("ID", 0)
            .Columns.Add("Service/Pkg", 213)
            .Columns.Add("Gross", 131)
            .Columns.Add("pstatus", 0)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- service proceed reception --------------------------------------''

    Sub load_serviceproceed_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT testservice_id, IF (service_table = 'service_type_tbl', (SELECT stype_name FROM service_type_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT pack_name FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `service`, IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `net`, payment_status FROM testservice_tbl WHERE test_id = '" + frm_receptionist.trID + "' and hmo_status = 'cash'"
        If conn.SelectRec(strrec, dt) = True Then
            frm_process.lv_serviceproceed.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    frm_process.lv_serviceproceed.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_serviceproceed_lv()
        With frm_process.lv_serviceproceed
            .Clear()
            .Columns.Add("ID", 0)
            .Columns.Add("Service/Pkg", 213)
            .Columns.Add("Gross", 131)
            .Columns.Add("pStatus", 0)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- hmo proceed reception --------------------------------------''
    Sub load_hmoproceed_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT testservice_id, IF (service_table = 'service_type_tbl', (SELECT stype_name FROM service_type_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT pack_name FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `service`, IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `net`, payment_status FROM testservice_tbl WHERE test_id = '" + frm_receptionist.trID + "' and hmo_status = 'hmo'"
        If conn.SelectRec(strrec, dt) = True Then
            If dt.Rows.Count > 0 Then
                frm_process.txthmonum.Enabled = True
                frm_process.cmb_hmo.Enabled = True
                frm_process.cmb_comp.Enabled = True
                frm_process.hmotrue = True
                frm_process.txtapproveby.Enabled = True
                frm_process.txtapprovenum.Enabled = True
                frm_process.txtreqby.Enabled = True
            Else
                frm_process.txthmonum.Enabled = False
                frm_process.cmb_hmo.Enabled = False
                frm_process.cmb_comp.Enabled = False
                frm_process.hmotrue = False
                frm_process.txtapproveby.Enabled = False
                frm_process.txtapprovenum.Enabled = False
                frm_process.txtreqby.Enabled = False
            End If
            frm_process.lv_hmoproceed.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    frm_process.lv_hmoproceed.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_hmoproceed_lv()
        With frm_process.lv_hmoproceed
            .Clear()
            .Columns.Add("ID", 0)
            .Columns.Add("Service/Pkg", 213)
            .Columns.Add("Gross", 131)
            .Columns.Add("pStatus", 0)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- cashier service acquisition --------------------------------------''

    Sub load_userrep2_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT testservice_id, service_table, IF (service_table = 'service_type_tbl', (SELECT stype_name FROM service_type_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT pack_name FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `service`, IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) AS `net`, disc_perc, IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) - IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) * (disc_perc / 100) as 'Discounted Value', IF (service_table = 'service_type_tbl', (SELECT service_net FROM service_price_tbl WHERE stype_id = testservice_tbl.service_id), (SELECT net FROM package_tbl WHERE pack_id = testservice_tbl.service_id)) * (disc_perc / 100) as 'Less', service_id FROM testservice_tbl WHERE test_id = '" & frm_cashier.txtTestID.Text & "' and payment_status = 'unpaid' and hmo_status = 'cash' order by service_table desc"
        If conn.SelectRec(strrec, dt) = True Then
            frm_cashier.lv_service.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.SubItems.Add(.Item(0).ToString)
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    lv.SubItems.Add(.Item(7).ToString)
                    frm_cashier.lv_service.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_userrep2_lv()
        With frm_cashier.lv_service
            .Clear()
            .View = View.Details
            .Columns.Add("", 0)
            .Columns.Add("ID", 0)
            .Columns.Add("ST", 0)
            .Columns.Add("Service/Pkg", 150, HorizontalAlignment.Left)
            .Columns.Add("Gross Pay", 65, HorizontalAlignment.Right)
            .Columns.Add("Discount(%)", 70, HorizontalAlignment.Right)
            .Columns.Add("Disc. Value", 70, HorizontalAlignment.Right)
            .Columns.Add("Less", 0)
            .Columns.Add("SI", 0)
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- queue lv --------------------------------------''

    Sub load_queue_lv()
        Dim dt As New DataTable
        Dim strrec = "SELECT queue_id, (SELECT test_id FROM testservice_tbl WHERE testservice_id = queue_tbl.testservice_id) AS `testid`, (SELECT patient_number FROM patient_test_tbl WHERE id = `testid`) AS `pnum`, (SELECT CONCAT(lname, ', ', fname, ' ', mname) FROM patient_tbl WHERE patient_number = `pnum`), (SELECT stype_name FROM service_type_tbl WHERE stype_id = queue_tbl.service_id), `status`, (SELECT priority FROM patient_test_tbl WHERE id = `testid`) AS `priority?` FROM queue_tbl WHERE STATUS IN ('Queued', 'Serving', 'Next') ORDER BY queue_id"
        If conn.SelectRec(strrec, dt) = True Then
            frm_queue.lv_queue.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(i + 1)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    lv.SubItems.Add(.Item(5).ToString)
                    lv.SubItems.Add(.Item(6).ToString)
                    frm_queue.lv_queue.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_queue_lv()
        With frm_queue.lv_queue
            .Clear()
            .Columns.Add("id", 0)
            .Columns.Add("testid", 0)
            .Columns.Add("order", 50)
            .Columns.Add("Patient Number", 92)
            .Columns.Add("Patient Name", 140)
            .Columns.Add("Service", 100)
            .Columns.Add("Status", 70)
            .Columns.Add("Priority?", 60)
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .BackColor = Color.White
        End With
    End Sub

    '' ------------------------- REQUESTING INVENTORY W/O ITEM SEARCH--------------------------------------''
    Sub Load_siiii_lv()
        Dim dt As New DataTable
        Dim strrec = "select item_type_tbl.item_id, item_type_tbl.item, item_category_tbl.item_category, inventory_tbl.description, inventory_tbl.quantity from item_type_tbl join item_category_tbl on item_type_tbl.item_cat_id = item_category_tbl.item_cat_id join inventory_tbl on item_type_tbl.item_id = inventory_tbl.item_id where item_type_tbl.status = 'Active' and inventory_tbl.quantity <> 0 and item_type_tbl.item like '" & frm_request_item.txtSearch.Text & "%'"

        If conn.SelectRec(strrec, dt) = True Then
            frm_request_item.lv_item.Items.Clear()
            For i = 0 To (dt.Rows.Count - 1)
                Dim lv As New ListViewItem
                With dt.Rows(i)
                    lv.Text = .Item(0).ToString
                    lv.SubItems.Add(.Item(1).ToString)
                    lv.SubItems.Add(.Item(2).ToString)
                    lv.SubItems.Add(.Item(3).ToString)
                    lv.SubItems.Add(.Item(4).ToString)
                    frm_request_item.lv_item.Items.Add(lv)
                End With
            Next
            dt.Dispose()
        End If
    End Sub

    Sub form_siiii_lv()
        With frm_request_item.lv_item
            .Clear()
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
End Module
