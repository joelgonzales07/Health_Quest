Option Explicit Off
Public Class frm_preview2
    Dim conn As New HQ_Connection
    Private Sub frm_preview2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form_sp1_lv()
        Load_sp1_lv()
        Load_total_text2()

    End Sub

    'Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click
    '    Dim gross As Double
    '    DTP.Format = DateTimePickerFormat.Custom
    '    DTP.CustomFormat = "yyyy-MM-dd"

    '    Dim dt2 As New DataTable
    '    Dim strrec2 = "select price from package_tbl where pack_name = '" & frm_receptionist.TextBox3.Text & "'"
    '    If conn.SelectRec(strrec2, dt2) = True Then
    '        For i = 0 To (dt2.Rows.Count - 1)
    '            Dim lv As New ListViewItem
    '            With dt2.Rows(i)
    '                frm_receptionist.lbltotalcost.Text = .Item(0).ToString
    '                gross = .Item(0).ToString
    '            End With
    '        Next
    '        dt2.Dispose()
    '    End If


    '    Dim guid As System.Guid = System.Guid.NewGuid()
    '    Dim stradd2 As String = "Insert into service_information_tbl(record_id,patient_id,service_type,gross,status,tdate)values('" & frm_receptionist.txtServiceID.Text & "','" & frm_receptionist.txtPnumber.Text & "','" & frm_receptionist.TextBox3.Text & "','" & gross & "','unpaid', '" & DTP.Text & "')"
    '    If conn.ModRec(stradd2) = True Then
    '        Dim del As String = "delete from service_information_tbl where service_type = ''"
    '        If conn.ModRec(del) = True Then
    '        End If
    '        form_aser_lv()
    '        Load_aser_lv()
    '    End If



    '    frm_receptionist.btnPROCEED.Enabled = True
    '    frm_receptionist.lv_user.Enabled = False
    '    Me.Hide()
    'End Sub


End Class