Option Explicit Off
Public Class frm_doctor
    Dim conn As New HQ_Connection
    Public spec() As String
    'Public cons() As String
    Public dept() As String
    Dim specvar As String
    'Dim consvar As String
    Dim deptvar As String
    Dim doctype As String = "Active"

    ''Function
    Sub count()
        Dim select_query As String
        Dim specdt As New DataTable
        Dim consdt As New DataTable
        Dim deptdt As New DataTable
        select_query = "select count(status) from specialization_tbl where status = 'Active'"
        If conn.SelectRec(select_query, specdt) = True Then
            ReDim spec(specdt.Rows(0).Item(0).ToString)
        End If
        specdt.Dispose()
        'select_query = "select count(status) from consultation_tbl where status = 'Active'"
        'If conn.SelectRec(select_query, consdt) = True Then
        '    ReDim cons(consdt.Rows(0).Item(0).ToString)
        'End If
        'consdt.Dispose()
        select_query = "select count(status) from department_tbl where status = 'Active'"
        If conn.SelectRec(select_query, deptdt) = True Then
            ReDim dept(deptdt.Rows(0).Item(0).ToString)
        End If
        deptdt.Dispose()
    End Sub

    Sub clear()
        btnREMOVE.Enabled = False
        txtID.Text = ""
        txtfname.Text = ""
        txtmname.Text = ""
        txtlname.Text = ""
        txtContact.Text = ""
        txtAddress.Text = ""
        cmb_spec.Text = ""
        'cmb_cons.Text = ""
        cmb_dept.Text = ""
        txtFee.Text = "0.00"
        rdbtnActive.Checked = True
    End Sub

    Sub form()
        clear()
        count()
        cmb_doc_dept()
        cmb_doc_spec()
        'cmb_doc_cons()
        lv_doc.Clear()
        form_doc_lv()
        Load_doc_lv()
    End Sub

    Private Sub frm_doctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Form()
    End Sub
    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        If btnCLOSE.Text = "CLOSE" Then
            Me.Hide()
        Else
            form()
        End If
    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If txtID.Text = "" Then
            edit_query = "insert into doctor_tbl values(null, '" + txtfname.Text + "','" & txtmname.Text & "','" & txtlname.Text & "', '" + txtContact.Text + "', '" + txtAddress.Text + "', '" + specvar + "', '', '" + deptvar + "','" & txtFee.Text & "','" & doctype & "', 'Active')"
        Else
            edit_query = "Update doctor_tbl set doc_fname ='" & txtfname.Text & "', doc_mname ='" & txtmname.Text & "', doc_lname ='" & txtlname.Text & "', doc_contact ='" & txtContact.Text & "',doc_address ='" & txtAddress.Text & "',spec_id ='" & specvar & "',dept_id ='" & deptvar & "',consfee = '" & txtFee.Text & "', doc_type = '" & doctype & "' where doc_id = '" & txtID.Text & "'"
        End If
        If conn.ModRec(edit_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form()
        End If
    End Sub

    Private Sub btnREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMOVE.Click
        Dim remove_query As String = ""
        If txtID.Text = "" Then

        Else
            remove_query = "Update doctor_tbl set status = 'Inactive' where doc_id = '" & txtID.Text & "'"
        End If
        If conn.ModRec(remove_query) = True Then
            MessageBox.Show("Record(s) Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call form()
        End If
    End Sub

    Private Sub lv_doc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_doc.SelectedIndexChanged
        With lv_doc
            txtID.Text = .SelectedItems(0).SubItems(1).Text
            cmb_spec.Text = .SelectedItems(0).SubItems(3).Text
            'cmb_cons.Text = .SelectedItems(0).SubItems(4).Text
            cmb_dept.Text = .SelectedItems(0).SubItems(5).Text
            txtFee.Text = .SelectedItems(0).SubItems(6).Text
            Dim select_query As String
            Dim dt As New DataTable
            select_query = "select doc_contact, doc_address, doc_type, doc_fname, doc_mname, doc_lname from doctor_tbl where doc_id = '" + txtID.Text + "'"
            If conn.SelectRec(select_query, dt) = True Then
                txtContact.Text = dt.Rows(0).Item(0).ToString
                txtAddress.Text = dt.Rows(0).Item(1).ToString
                doctype = dt.Rows(0).Item(2).ToString
                txtfname.Text = dt.Rows(0).Item(3).ToString
                txtmname.Text = dt.Rows(0).Item(4).ToString
                txtlname.Text = dt.Rows(0).Item(5).ToString
                If doctype = "Active" Then
                    rdbtnActive.Checked = True
                Else
                    rdbtnRef.Checked = True
                End If
            End If

            btnREMOVE.Enabled = True
            lv_doc.Clear()
            form_doc_lv()
            Load_doc_lv()
        End With
    End Sub

    Private Sub cmb_spec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_spec.SelectedIndexChanged
        With cmb_spec
            specvar = spec(.SelectedIndex)
        End With
    End Sub

    'Private Sub cmb_cons_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cons.SelectedIndexChanged
    '    With cmb_cons
    '        consvar = cons(.SelectedIndex)
    '    End With
    'End Sub

    Private Sub cmb_dept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_dept.SelectedIndexChanged
        With cmb_dept
            deptvar = dept(.SelectedIndex)
        End With
    End Sub

    Private Sub rdbtnActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnActive.CheckedChanged
        If rdbtnActive.Checked = True Then
            doctype = "Active"
        End If
    End Sub

    Private Sub rdbtnRef_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnRef.CheckedChanged
        If rdbtnRef.Checked = True Then
            doctype = "Referring"
        End If
    End Sub
End Class