Option Explicit Off
Public Class frm_receptionist
    Dim conn As New HQ_Connection
    Dim ID As String
    Public trID As String = ""
    Dim total As Double = 0
    Dim dID As String = ""
    Public doc() As String
    Dim docid As String = ""
    Dim usercount As Integer = 0
    Dim paystat As Integer = 0
    Public ref() As String
    Dim refid As String = ""

    Private Sub frm_receptionist_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_login.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        countdoc()
        form_cl_lv()
        form_d_lv()
        form_pd_lv()
        Load_pd_lv()
        Load_cl1_lv()
        Load_d_lv()
        btnPROCEED.Enabled = False
        cmb_R_doc_spec()
        cmb_refer_doc_spec()
        DTP1.Format = DateTimePickerFormat.Custom
        DTP1.CustomFormat = "MMMM dd, yyyy"
        form_tr_lv()
        load_tr_lv()
        form_userrep_lv()
        load_userrep_lv()
        delete_ser()
    End Sub

    Sub delete_ser()
        Dim del_q As String = "delete from testservice_tbl where test_id = '0'"
        If conn.ModRec(del_q) Then

        End If
    End Sub

    Sub countdoc()
        Dim select_query As String = ""
        Dim docdt As New DataTable
        select_query = "select count(status) from doctor_tbl where status = 'Active'"
        If conn.SelectRec(select_query, docdt) = True Then
            ReDim doc(docdt.Rows(0).Item(0).ToString)
            ReDim ref(docdt.Rows(0).Item(0).ToString)
        End If
    End Sub

    Sub computetotal()
        Dim tot As Double = 0.0
        With lv_user
            For i = 0 To .Items.Count - 1
                tot = tot + .Items(i).subitems(2).Text
            Next
            If tot > 0 Then
                total = tot
            Else
                total = 0.0
            End If
            lbltotalcost.Text = total
        End With
    End Sub

    Sub lock()

        DTP1.Enabled = False
        txtPnumber.Enabled = False
        txtLname.Enabled = False
        txtFname.Enabled = False
        txtmname.Enabled = False
        txtaddress.Enabled = False
        txtage.Enabled = False
        cmbgender.Enabled = False
        txtemail.Enabled = False
        txtcfee1.Enabled = False
        cmb_pname1.Enabled = False
    End Sub

    Sub unlock()
        DTP1.Enabled = True
        txtPnumber.Enabled = True
        txtLname.Enabled = True
        txtFname.Enabled = True
        txtmname.Enabled = True
        txtaddress.Enabled = True
        txtage.Enabled = False
        cmbgender.Enabled = True
        txtemail.Enabled = True
        txtcfee1.Enabled = True
        cmb_pname1.Enabled = True
    End Sub

    Sub clear()
        txtPnumber.Text = ""
        txtLname.Text = ""
        txtFname.Text = ""
        txtmname.Text = ""
        txtaddress.Text = ""
        txttel.Text = ""
        txtmob.Text = ""
        txtage.Text = "0"
        cmbgender.Text = ""
        txtemail.Text = ""
        txtcfee1.Text = "0.00"
        cmb_pname1.Text = ""
        cmb_refer.Text = ""
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        Dim edit_query = "", select_query As String
        Dim dtselect As New DataTable

        If txtPnumber.Text = "" Then
            Dim currentTime As System.DateTime = DTP.Text
            Dim year As String = currentTime.Year.ToString
            select_query = "SELECT COUNT(patient_number) FROM patient_tbl WHERE patient_number LIKE '" + year + "%'"
            If conn.SelectRec(select_query, dtselect) = True Then
                '---generating patient number
                Dim count As Integer = dtselect.Rows(0).Item(0)
                Dim decLength As Integer = count.ToString("D").Length + 4
                Dim stringcount As String = ""
                Dim patnum As String = ""
                count = count + 1
                stringcount = count.ToString("D" + decLength.ToString)
                patnum = year & "-" & stringcount

                edit_query = "insert into patient_tbl values('" + patnum + "', '" + txtLname.Text + "', '" + txtFname.Text + "', '" + txtmname.Text + "', '" + DTP1.Text + "', '" + txtage.Text + "', '" + cmbgender.Text + "', '" + txtaddress.Text + "', '" + txttel.Text + "', '" + txtmob.Text + "', '" + txtemail.Text + "', '" + refid + "')"
                txtPnumber.Text = patnum
            End If
        Else
            edit_query = "update patient_tbl set lname = '" + txtLname.Text + "', fname = '" + txtFname.Text + "', mname = '" + txtmname.Text + "', bday = '" + DTP1.Text + "', age = '" + txtage.Text + "', gender = '" + cmbgender.Text + "', address = '" + txtaddress.Text + "', tel = '" + txttel.Text + "', mob = '" + txtmob.Text + "', email = '" + txtemail.Text + "', referred_by = '" + refid + "' where patient_number = '" + txtPnumber.Text + "'"
        End If
        If conn.ModRec(edit_query) = True Then
            form_cl_lv()
            Load_cl1_lv()
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'DTP1.Format = DateTimePickerFormat.Custom
        'DTP1.CustomFormat = "yyyy-MM-dd"
        'DTP.Format = DateTimePickerFormat.Custom
        'DTP.CustomFormat = "yyyy-MM-dd 00:00:00"
        'If btnADD.Text = "ADD CLIENT" Then

        '    unlock()
        '    btnADD.Text = "SAVE"
        '    TextBox1.Enabled = False
        'ElseIf btnADD.Text = "SAVE" Then
        '    'SETTING TIME
        '    If txtLname.Text = "" Or txtFname.Text = "" Or txtmname.Text = "" Then
        '        MessageBox.Show("Required field(s) missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        txtLname.Focus()
        '    Else
        '        Dim stradd As String = "Insert into patient_tbl values('" & txtPnumber.Text & "','" & txtLname.Text & "','" & txtFname.Text & "','" & txtmname.Text & "','" & DTP1.Text & "','" & txtage.Text & "','" & cmbgender.Text & "','" & txtaddress.Text & "','" & txtTel.Text & "','" & txtmob.Text & "','" & cmb_pname1.Text & "','" & txtemail.Text & "','" & txtcfee1.Text & "','" & txtt_r.Text & "','" & txtmi.Text & "','" & DTP.Text & "')"
        '        If conn.ModRec(stradd) = True Then
        '            MessageBox.Show("One record save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            clear()
        '            btnADD.Text = "ADD CLIENT"
        '            TextBox1.Enabled = True
        '            lock()
        '        End If
        '    End If
        'Else
        '    '-----------------------UPDATE AREA
        '    Dim del As String = "delete from patient_tbl where patient_number = '" & txtPnumber.Text & " '"
        '    If conn.ModRec(del) = True Then
        '    End If
        '    Dim stradd As String = "Insert into patient_tbl(patient_number,lname,fname,mname,bday,age,gender,address,tel,mob,p_name,email,c_fee,t_r,med_information,tdate)values('" & txtPnumber.Text & "','" & txtLname.Text & "','" & txtFname.Text & "','" & txtmname.Text & "','" & DTP1.Text & "','" & txtage.Text & "','" & cmbgender.Text & "','" & txtaddress.Text & "','" & txtTel.Text & "','" & txtmob.Text & "','" & cmb_pname1.Text & "','" & txtemail.Text & "','" & txtcfee1.Text & "','" & txtt_r.Text & "','" & txtmi.Text & "','" & DTP.Text & "')"
        '    If conn.ModRec(stradd) = True Then
        '        MessageBox.Show("Record Update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    End If

        'End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        clear()
        lv_Client.Clear()
        form_cl_lv()
        Load_cl1_lv()
        btnPROCEED.Enabled = True
        TextBox1.Text = ""
        TextBox1.Enabled = True
        trID = ""
        lv_promo.Enabled = False
        lv_Diagnose.Enabled = False
        form_userrep_lv()
        load_userrep_lv()
        computetotal()
    End Sub

    Private Sub DTP1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP1.ValueChanged
        txtage.Text = DTP.Text
        txtage.Text = DTP.Value.Year - DTP1.Value.Year
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        lv_Client.Clear()
        form_cl_lv()
        Load_cl_lv()
        lv_Client.Enabled = True
    End Sub

    Private Sub lv_Client_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Client.SelectedIndexChanged
        With lv_Client
            On Error Resume Next
            txtPnumber.Text = .SelectedItems(0).SubItems(0).Text
            trID = ""
            form_userrep_lv()
            load_userrep_lv()
            computetotal()
            Load_text_lv()
        End With
    End Sub

    'Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim guid As System.Guid = System.Guid.NewGuid()
    '    ID = guid.ToString()
    '    txtServiceID.Text = ID.ToString()
    '    If txtPnumber.Text = "" Then
    '        MessageBox.Show("Please Select a User First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        txtLname.Focus()
    '    Else
    '        MessageBox.Show("You can now click on the list of services, NOTE: Do not update user information until the transaction not finish", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        lv_Diagnose.Enabled = True
    '        lv_promo.Enabled = True
    '    End If
    'End Sub



    Private Sub lv_user_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_user.SelectedIndexChanged
        With lv_user
            If usercount = 0 Then
                If .SelectedItems.Count > 0 Then
                    If .SelectedItems(0).SubItems(3).Text = "unpaid" Then
                        Dim result1 As DialogResult = MessageBox.Show("Remove selected service to acquisition?", "Important Question", MessageBoxButtons.YesNo)
                        If result1 = Windows.Forms.DialogResult.Yes Then
                            Dim del_query As String = "delete from testservice_tbl where testservice_id = '" + .SelectedItems(0).SubItems(0).Text + "'"
                            If conn.ModRec(del_query) = True Then
                                form_userrep_lv()
                                load_userrep_lv()
                                computetotal()
                            End If
                        End If
                        usercount = 1
                    Else
                        MessageBox.Show("Service already paid or approved by HMO Company. Cannot be altered anymore.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Else
                usercount = 0
            End If
        End With
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frm_login.txtUser.Text = "Username"
        frm_login.txtPass.Text = "Password"
        frm_login.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_adminAuthenticate.Show()
        frm_adminAuthenticate.txtpassword.Text = ""
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPROCEED.Click
        If paystat = 1 Then
            frm_process.Show()
        ElseIf paystat = 2 Then
            frm_process.Show()
        ElseIf paystat = 3 Then
            frm_process.Show()
            frm_process.lv_hmoproceed.Enabled = False
            frm_process.lv_serviceproceed.Enabled = False
            frm_process.txthmonum.Enabled = False
            frm_process.cmb_hmo.Enabled = False
            frm_process.hmotrue = False
            frm_process.txtapproveby.Enabled = False
            frm_process.txtapprovenum.Enabled = False
            frm_process.txtreqby.Enabled = False
            frm_process.txttr.Enabled = False
            frm_process.txtmi.Enabled = False
            frm_process.cmb_comp.Enabled = False
            frm_process.btnPROCEED.Enabled = False
        ElseIf paystat = 4 Then
            frm_process.Show()
            frm_process.lv_hmoproceed.Enabled = False
            frm_process.lv_serviceproceed.Enabled = False
            frm_process.txthmonum.Enabled = False
            frm_process.cmb_hmo.Enabled = False
            frm_process.hmotrue = False
            frm_process.txtapproveby.Enabled = False
            frm_process.txtapprovenum.Enabled = False
            frm_process.txtreqby.Enabled = False
            frm_process.txttr.Enabled = False
            frm_process.txtmi.Enabled = False
            frm_process.cmb_comp.Enabled = False
            frm_process.btnPROCEED.Enabled = False
        ElseIf paystat = 0 Then
            If lv_user.Items.Count > 0 Then
                frm_process.Show()
            End If
        End If
        'Dim guid2 As System.Guid = System.Guid.NewGuid()
        'Dim stradd3 As String = "Insert into service_payment_tbl(record_id2,record_id,Total_Gross,hmo_status,service_status)values('" & guid2.ToString() & "','" & ID.ToString() & "','" & lbltotalcost.Text & "', 'FALSE','Normal')"
        'If conn.ModRec(stradd3) = True Then
        '    MessageBox.Show("Service Avail! Proceed to cashier for payment!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    clear()
        '    lock()
        '    lv_user.Clear()
        '    form_aser_lv()
        '    TextBox1.Text = ""
        '    lv_user.Enabled = False
        '    lbltotalcost.Text = "0.00"
        '    lv_Diagnose.Enabled = False
        'End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        On Error Resume Next
        form_service_lv()
        Load_service_lv()

    End Sub

    Private Sub lv_Diagnose_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_Diagnose.SelectedIndexChanged
        If lv_Diagnose.SelectedItems.Count > 0 Then
            Dim edit_query As String = ""
            If Not txtPnumber.Text = "" Then
                Dim result1 As DialogResult = MessageBox.Show("Add service to acquisition?", "Important Question", MessageBoxButtons.YesNo)
                If result1 = Windows.Forms.DialogResult.Yes Then
                    Dim sname As String = ""
                    Dim sgross As String = ""
                    Dim svat As String = ""
                    Dim snet As String = ""
                    With lv_Diagnose
                        dID = .SelectedItems(0).SubItems(0).Text
                        sname = .SelectedItems(0).SubItems(1).Text
                        sgross = .SelectedItems(0).SubItems(2).Text
                        svat = .SelectedItems(0).SubItems(3).Text
                        snet = .SelectedItems(0).SubItems(4).Text
                    End With

                    If trID = "" Then
                        trID = "0"
                    End If
                    edit_query = "insert into testservice_tbl values(null, '" + trID + "', '" + dID + "', 'service_type_tbl', 'unpaid', 'cash', '0', 'No')"
                    If conn.ModRec(edit_query) = True Then
                        form_userrep_lv()
                        load_userrep_lv()
                        computetotal()
                        btnPROCEED.Enabled = True
                    End If
                End If
            Else
                MessageBox.Show("Please select patient and test request to select service", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        'Dim service_name As String
        'Dim gross As Double
        'DTP.Format = DateTimePickerFormat.Custom
        'DTP.CustomFormat = "yyyy-MM-dd"
        'With lv_Diagnose
        '    On Error Resume Next
        '    service_name = .SelectedItems(0).SubItems(0).Text
        '    gross = .SelectedItems(0).SubItems(3).Text
        'End With
        'Dim stradd22 As String = "Insert into service_information_tbl(record_id,patient_id,service_type,gross,status,tdate)values('" & ID.ToString() & "','" & txtPnumber.Text & "','" & service_name & "','" & gross & "','unpaid', '" & DTP.Text & "')"
        'If conn.ModRec(stradd22) = True Then
        '    Dim del As String = "delete from service_information_tbl where service_type = ''"
        '    If conn.ModRec(del) = True Then
        '    End If
        '    form_aser_lv()
        '    Load_aser_lv()
        'End If
        'Dim dt2 As New DataTable
        'Dim strrec2 = "select sum(gross) from service_information_tbl where patient_id = '" & txtPnumber.Text & "' and status = 'unpaid'"
        'If conn.SelectRec(strrec2, dt2) = True Then
        '    For i = 0 To (dt2.Rows.Count - 1)
        '        Dim lv As New ListViewItem
        '        With dt2.Rows(i)
        '            lbltotalcost.Text = .Item(0).ToString
        '        End With
        '    Next
        '    dt2.Dispose()
        'End If
        'Button8.Enabled = True
        'lv_user.Enabled = True
        'form_aser_lv()
        'Load_aser_lv()
    End Sub

    Private Sub lv_promo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_promo.SelectedIndexChanged
        If lv_promo.SelectedItems.Count > 0 Then
            Dim edit_query As String = ""
            If Not txtPnumber.Text = "" Then
                Dim result1 As DialogResult = MessageBox.Show("Add service to acquisition?", "Important Question", MessageBoxButtons.YesNo)
                If result1 = Windows.Forms.DialogResult.Yes Then
                    Dim sname As String = ""
                    Dim sgross As String = ""
                    Dim svat As String = ""
                    Dim snet As String = ""
                    With lv_promo
                        dID = .SelectedItems(0).SubItems(0).Text
                        sname = .SelectedItems(0).SubItems(1).Text
                        sgross = .SelectedItems(0).SubItems(2).Text
                        svat = .SelectedItems(0).SubItems(3).Text
                        snet = .SelectedItems(0).SubItems(4).Text
                    End With

                    If trID = "" Then
                        trID = "0"
                    End If
                    edit_query = "insert into testservice_tbl values(null, '" + trID + "', '" + dID + "', 'package_tbl', 'unpaid', 'cash', '0', 'No')"
                    If conn.ModRec(edit_query) = True Then
                        form_userrep_lv()
                        load_userrep_lv()
                        computetotal()
                        btnPROCEED.Enabled = True
                    End If
                End If
            Else
                MessageBox.Show("Please select patient and test request to select service", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        'If lv_promo.SelectedItems.Count > 0 Then
        '    Dim edit_query As String
        '    If Not trID = "" And Not txtPnumber.Text = "" Then
        '        Dim result1 As DialogResult = MessageBox.Show("Add package to acquisition?", "Important Question", MessageBoxButtons.YesNo)
        '        If result1 = Windows.Forms.DialogResult.Yes Then
        '            Dim sname As String = ""
        '            Dim sgross As String = ""
        '            Dim svat As String = ""
        '            Dim snet As String = ""
        '            With lv_promo
        '                dID = .SelectedItems(0).SubItems(0).Text
        '                sname = .SelectedItems(0).SubItems(1).Text
        '                sgross = .SelectedItems(0).SubItems(2).Text
        '                svat = .SelectedItems(0).SubItems(3).Text
        '                snet = .SelectedItems(0).SubItems(4).Text
        '            End With
        '            edit_query = "insert into testservice_tbl values(null, '" + trID + "', '" + dID + "', 'package_tbl', 'unpaid', 'cash')"
        '            If conn.ModRec(edit_query) = True Then
        '                form_userrep_lv()
        '                load_userrep_lv()
        '                computetotal()
        '                btnPROCEED.Enabled = True
        '            End If
        '        End If
        '    Else
        '        MessageBox.Show("Please select patient and test request to select package", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    End If
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mntr_doctor.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mntr_patient.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frm_queue.Show()
    End Sub

    'Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtPnumber.Text = "" Then
    '        MsgBox("Please Select Patient First")
    '    Else
    '        Dim guid As System.Guid = System.Guid.NewGuid()
    '        ID = guid.ToString()
    '        txtServiceID.Text = ID.ToString()

    '        MessageBox.Show("You can now click on the list of services, NOTE: Do not update user information until the transaction not finish", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        btnPROCEED.Visible = False
    '        btnPROCEED.Enabled = False
    '        lv_Diagnose.Enabled = True
    '        lv_promo.Enabled = True
    '    End If

    'End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim guid2 As System.Guid = System.Guid.NewGuid()
        Dim stradd3 As String = "Insert into service_payment_tbl(record_id2,record_id,Total_Gross,hmo_status,hmo_number)values('" & guid2.ToString() & "','" & ID.ToString() & "','" & lbltotalcost.Text & "','HMO')"
        If conn.ModRec(stradd3) = True Then
            MessageBox.Show("Service Avail! Proceed to cashier for payment!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()
            lock()
            lv_user.Clear()
            TextBox1.Text = ""
            lv_user.Enabled = False
            lbltotalcost.Text = "0.00"
            lv_Diagnose.Enabled = False
            btnPROCEED.Visible = True
        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim edit_query As String = ""
        Dim edit As Boolean = False
        If trID = "" Then
            Dim tdate As Date = DTP.Text
            Dim newdate As String = tdate.ToString("MM/dd/yy")
            edit_query = "insert into patient_test_tbl values(null, '" + txtPnumber.Text + "', '" + docid + "','" + txtcfee1.Text + "',null, null, '" + newdate + "', 'unpaid','No')"
        Else
            edit_query = "update patient_test_tbl set doc_id = '" + docid + "', c_fee = '" + txtcfee1.Text + "' where id = '" + trID + "'"
            edit = True
        End If
        If conn.ModRec(edit_query) = True Then
            form_tr_lv()
            load_tr_lv()
            form_userrep_lv()
            load_userrep_lv()
            MessageBox.Show("Pay the fee to the cashier to proceed queueing.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If edit = False Then
                Dim select_query As String = ""
                select_query = "SELECT id FROM patient_test_tbl WHERE patient_number = '" + txtPnumber.Text + "' ORDER BY id DESC LIMIT 1"
                Dim dtsel As New DataTable
                If conn.SelectRec(select_query, dtsel) = True Then
                    trID = dtsel.Rows(0).Item(0).ToString
                    txttrid.Text = trID
                End If
                dtsel.Dispose()
            End If
            rpt_statement.Show()
        End If

        'Dim edit_query As String = ""
        'Dim accepted As Boolean = True
        'Dim edit As Boolean = False
        'If trID = "" And txttr.Text = "" Then
        '    MessageBox.Show("Required field(s) necessary to save the record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    accepted = False
        'ElseIf trID = "" And Not txttr.Text = "" Then
        '    Dim tdate As Date = DTP.Text
        '    Dim newdate As String = tdate.ToString("MM/dd/yy")
        '    edit_query = "insert into patient_test_tbl values(null, '" + txtPnumber.Text + "', '" + docid + "','" + txtcfee1.Text + "','" + txttr.Text + "', '" + txtmi.Text + "', '" + newdate + "', 'unpaid','No')"
        '    lv_Diagnose.Enabled = True
        '    paystat = 2
        'ElseIf Not trID = "" And txttr.Text = "" Then
        '    MessageBox.Show("Required field(s) necessary to save the record.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    accepted = False
        'ElseIf Not trID = "" And Not txttr.Text = "" Then
        '    edit_query = "update patient_test_tbl set doc_id = '" + docid + "', c_fee = '" + txtcfee1.Text + "', t_r = '" + txttr.Text + "', med_information = '" + txtmi.Text + "' where id = '" + trID + "'"
        '    edit = True
        '    paystat = 2
        'End If
        'If accepted Then
        '    If conn.ModRec(edit_query) = True Then
        '        form_tr_lv()
        '        load_tr_lv()
        '        form_userrep_lv()
        '        load_userrep_lv()
        '        MessageBox.Show("Pay the fee to the cashier to proceed queueing.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        If edit = False Then
        '            Dim select_query As String = ""
        '            select_query = "SELECT id FROM patient_test_tbl WHERE patient_number = '" + txtPnumber.Text + "' ORDER BY id DESC LIMIT 1"
        '            Dim dtsel As New DataTable
        '            If conn.SelectRec(select_query, dtsel) = True Then
        '                trID = dtsel.Rows(0).Item(0).ToString
        '                dtsel.Dispose()
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub lv_tr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_tr.SelectedIndexChanged
        With lv_tr
            If lv_tr.SelectedItems.Count > 0 Then
                Dim ps As String = ""
                Dim lock As String = ""
                trID = .SelectedItems(0).SubItems(0).Text
                txttrid.Text = .SelectedItems(0).SubItems(0).Text
                cmb_pname1.Text = .SelectedItems(0).SubItems(1).Text
                txtcfee1.Text = .SelectedItems(0).SubItems(2).Text
                ps = .SelectedItems(0).SubItems(6).Text
                lock = .SelectedItems(0).SubItems(7).Text
                form_tr_lv()
                load_tr_lv()
                form_userrep_lv()
                load_userrep_lv()
                computetotal()
                delete_ser()
                btnPROCEED.Enabled = True
                If ps = "paid" And lock = "No" Then
                    lv_user.Enabled = True
                    lv_Diagnose.Enabled = True
                    lv_promo.Enabled = True
                    cmb_pname1.Enabled = False
                    txtcfee1.Enabled = False
                    paystat = 1
                ElseIf ps = "unpaid" And lock = "No" Then
                    lv_user.Enabled = True
                    lv_Diagnose.Enabled = True
                    lv_promo.Enabled = True
                    cmb_pname1.Enabled = True
                    txtcfee1.Enabled = True
                    paystat = 2
                ElseIf ps = "paid" And lock = "Yes" Then
                    lv_user.Enabled = False
                    lv_Diagnose.Enabled = False
                    lv_promo.Enabled = False
                    cmb_pname1.Enabled = False
                    txtcfee1.Enabled = False
                    paystat = 3
                ElseIf ps = "unpaid" And lock = "Yes" Then
                    lv_user.Enabled = False
                    lv_Diagnose.Enabled = False
                    lv_promo.Enabled = False
                    cmb_pname1.Enabled = True
                    txtcfee1.Enabled = True
                    paystat = 4
                End If
            End If
        End With
    End Sub

    Private Sub txtPnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPnumber.TextChanged
        form_tr_lv()
        load_tr_lv()
        cmb_pname1.Text = ""
        txtcfee1.Text = ""
        txttrid.Text = ""
        trID = ""
        lv_Diagnose.Enabled = False
        lv_user.Enabled = False
        lv_promo.Enabled = False
        paystat = 0
        If txtPnumber.Text = "" Then
            cmb_pname1.Enabled = False
            txtcfee1.Enabled = False
            lv_user.Enabled = False
            lv_Diagnose.Enabled = False
            lv_promo.Enabled = False
        Else
            cmb_pname1.Enabled = True
            txtcfee1.Enabled = True
            lv_user.Enabled = True
            lv_Diagnose.Enabled = True
            lv_promo.Enabled = True
        End If
        delete_ser()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        trID = ""
        form_tr_lv()
        load_tr_lv()
        form_userrep_lv()
        load_userrep_lv()
        delete_ser()
        cmb_pname1.Text = ""
        txtcfee1.Text = ""
        txttrid.Text = ""
        lv_Diagnose.Enabled = True
        lv_promo.Enabled = True
        lv_user.Enabled = True
        cmb_pname1.Enabled = True
        txtcfee1.Enabled = True
        paystat = 0
    End Sub

    Private Sub cmb_pname1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_pname1.SelectedIndexChanged
        If cmb_pname1.Text = "None" Then
            docid = ""
            txtcfee1.Text = "0.0"
        Else
            docid = doc(cmb_pname1.SelectedIndex)
            Dim sel_q As String = "select consfee from doctor_tbl where doc_id = '" + docid + "'"
            Dim dtsel As New DataTable
            If conn.SelectRec(sel_q, dtsel) Then
                txtcfee1.Text = dtsel.Rows(0).Item(0).ToString
            End If
            dtsel.Dispose()
        End If
    End Sub

    Private Sub txtcfee1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcfee1.TextChanged
        If txtcfee1.Text = "" Then
            txtcfee1.Text = "0.00"
        End If
    End Sub

    Private Sub cmb_refer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_refer.SelectedIndexChanged
        If cmb_refer.Text = "None" Then
            refid = ""
        Else
            refid = ref(cmb_refer.SelectedIndex)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreadings.Click
        Me.Enabled = False
        frm_readings.txttrid.Text = trID
        frm_readings.Show()
    End Sub

    Private Sub txttrid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttrid.TextChanged
        If txttrid.Text = "" Then
            btnreadings.Enabled = False
        Else
            btnreadings.Enabled = True
        End If
    End Sub
End Class