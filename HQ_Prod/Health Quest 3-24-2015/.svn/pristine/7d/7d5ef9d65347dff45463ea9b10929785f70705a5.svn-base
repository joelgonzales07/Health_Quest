Option Explicit Off
Public Class frm_schedule
    Dim conn As New HQ_Connection
    Public txtMonday As String
    Public txtTuesday As String
    Public txtWednesday As String
    Public txtThursday As String
    Public txtFriday As String
    Public txtSaturday As String
    ''Function
    Sub form()
        txtMonday = ""
        txtTuesday = ""
        txtWednesday = ""
        txtThursday = ""
        txtFriday = ""
        txtSaturday = ""
        txtUID.Text = ""
        txtDname.Text = ""
        form_sdoc_lv()
        Load_sdoc_lv()
        dtfromM.Value = DateTime.Now
        dtfromT.Value = DateTime.Now
        dtfromW.Value = DateTime.Now
        dtFromTh.Value = DateTime.Now
        dtfromF.Value = DateTime.Now
        dtfromS.Value = DateTime.Now
        dttoM.Value = DateTime.Now
        dttoT.Value = DateTime.Now
        dttoW.Value = DateTime.Now
        dttoTh.Value = DateTime.Now
        dttoF.Value = DateTime.Now
        dttoS.Value = DateTime.Now
    End Sub

    Private Sub frm_schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        form()
        Panel1.Location = New Point(2, 12)
        Panel1.Visible = False
        Panel2.Visible = True
        dtfromM.CustomFormat = "hh:mm tt"
        dtfromT.CustomFormat = "hh:mm tt"
        dtfromW.CustomFormat = "hh:mm tt"
        dtFromTh.CustomFormat = "hh:mm tt"
        dtfromF.CustomFormat = "hh:mm tt"
        dtfromS.CustomFormat = "hh:mm tt"
        dttoM.CustomFormat = "hh:mm tt"
        dttoT.CustomFormat = "hh:mm tt"
        dttoW.CustomFormat = "hh:mm tt"
        dttoTh.CustomFormat = "hh:mm tt"
        dttoF.CustomFormat = "hh:mm tt"
        dttoS.CustomFormat = "hh:mm tt"
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        form()
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADD.Click
        If chkMon.Checked Then
            txtMonday = ""
        Else
            txtMonday = dtfromM.Value.ToString("hh:mm tt") & "-" & dttoM.Value.ToString("hh:mm tt")
        End If

        If chkTues.Checked Then
            txtTuesday = ""
        Else
            txtTuesday = dtfromT.Value.ToString("hh:mm tt") & "-" & dttoT.Value.ToString("hh:mm tt")
        End If

        If chkWed.Checked Then
            txtWednesday = ""
        Else
            txtWednesday = dtfromW.Value.ToString("hh:mm tt") & "-" & dttoW.Value.ToString("hh:mm tt")
        End If

        If chkThurs.Checked Then
            txtThursday = ""
        Else
            txtThursday = dtFromTh.Value.ToString("hh:mm tt") & "-" & dttoTh.Value.ToString("hh:mm tt")
        End If

        If chkFri.Checked Then
            txtFriday = ""
        Else
            txtFriday = dtfromF.Value.ToString("hh:mm tt") & "-" & dttoF.Value.ToString("hh:mm tt")
        End If

        If chkSat.Checked Then
            txtSaturday = ""
        Else
            txtSaturday = dtfromS.Value.ToString("hh:mm tt") & "-" & dttoS.Value.ToString("hh:mm tt")
        End If

        Dim select_query As String = "select * from schedule_tbl where doctor_id = '" + txtUID.Text + "'"
        Dim scheddt As New DataTable
        Dim edit_query As String = ""
        If conn.SelectRec(select_query, scheddt) = True Then
            If scheddt.Rows.Count > 0 Then
                edit_query = "Update schedule_tbl set monday ='" & txtMonday & "',tuesday ='" & txtTuesday & "',wednesday ='" & txtWednesday & "',thursday ='" & txtThursday & "',friday ='" & txtFriday & "',saturday ='" & txtSaturday & "' where doctor_id = '" & txtUID.Text & "'"
            Else
                edit_query = "insert into schedule_tbl values(null, '" + txtUID.Text + "', '" + txtMonday + "', '" + txtTuesday + "', '" + txtWednesday + "', '" + txtThursday + "', '" + txtFriday + "', '" + txtSaturday + "')"
            End If
        End If
        If conn.ModRec(edit_query) = True Then
            MessageBox.Show("Schedule Update Successful", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            form()
        End If
        scheddt.Dispose()
    End Sub

    Private Sub lv_doctor_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_doctor.SelectedIndexChanged
        With lv_doctor
            txtUID.Text = .SelectedItems(0).SubItems(0).Text

            Dim select_query As String
            Dim dt As New DataTable
            select_query = "select CONCAT(CONCAT('Dr. '), CONCAT(doc_lname, ', '), CONCAT(doc_fname, ' '), doc_mname) from doctor_tbl where doc_id = '" + txtUID.Text + "'"
            If conn.SelectRec(select_query, dt) = True Then
                txtDname.Text = dt.Rows(0).Item(0).ToString
            End If

            txtDname.Text = .SelectedItems(0).SubItems(2).Text
            select_query = "select schedule_id, monday, tuesday, wednesday, thursday, friday, saturday from schedule_tbl where doctor_id = '" + txtUID.Text + "'"
            Dim scheddt As New DataTable
            If conn.SelectRec(select_query, scheddt) = True Then
                If scheddt.Rows.Count > 0 Then
                    txtMonday = scheddt.Rows(0).Item(1).ToString
                    txtTuesday = scheddt.Rows(0).Item(2).ToString
                    txtWednesday = scheddt.Rows(0).Item(3).ToString
                    txtThursday = scheddt.Rows(0).Item(4).ToString
                    txtFriday = scheddt.Rows(0).Item(5).ToString
                    txtSaturday = scheddt.Rows(0).Item(6).ToString

                    If txtMonday = "" Then
                        chkMon.Checked = True
                    Else
                        Dim splitmon() As String = txtMonday.Split("-")
                        dtfromM.Value = Convert.ToDateTime(splitmon(0))
                        dttoM.Value = Convert.ToDateTime(splitmon(1))
                        txtMonday = ""
                    End If

                    If txtTuesday = "" Then
                        chkTues.Checked = True
                    Else
                        Dim splittues() As String = txtTuesday.Split("-")
                        dtfromT.Value = Convert.ToDateTime(splittues(0))
                        dttoT.Value = Convert.ToDateTime(splittues(1))
                        txtTuesday = ""
                    End If

                    If txtWednesday = "" Then
                        chkWed.Checked = True
                    Else
                        Dim splitwed() As String = txtWednesday.Split("-")
                        dtfromW.Value = Convert.ToDateTime(splitwed(0))
                        dttoW.Value = Convert.ToDateTime(splitwed(1))
                        txtWednesday = ""
                    End If

                    If txtThursday = "" Then
                        chkThurs.Checked = True
                    Else
                        Dim splitthurs() As String = txtThursday.Split("-")
                        dtFromTh.Value = Convert.ToDateTime(splitthurs(0))
                        dttoTh.Value = Convert.ToDateTime(splitthurs(1))
                        txtThursday = ""
                    End If

                    If txtFriday = "" Then
                        chkFri.Checked = True
                    Else
                        Dim splitfri() As String = txtFriday.Split("-")
                        dtfromF.Value = Convert.ToDateTime(splitfri(0))
                        dttoF.Value = Convert.ToDateTime(splitfri(1))
                        txtFriday = ""
                    End If

                    If txtSaturday = "" Then
                        chkSat.Checked = True
                    Else
                        Dim splitsat() As String = txtSaturday.Split("-")
                        dtfromS.Value = Convert.ToDateTime(splitsat(0))
                        dttoS.Value = Convert.ToDateTime(splitsat(1))
                        txtSaturday = ""
                    End If

                Else
                    dtfromM.Value = DateTime.Now
                    dtfromT.Value = DateTime.Now
                    dtfromW.Value = DateTime.Now
                    dtFromTh.Value = DateTime.Now
                    dtfromF.Value = DateTime.Now
                    dtfromS.Value = DateTime.Now
                    dttoM.Value = DateTime.Now
                    dttoT.Value = DateTime.Now
                    dttoW.Value = DateTime.Now
                    dttoTh.Value = DateTime.Now
                    dttoF.Value = DateTime.Now
                    dttoS.Value = DateTime.Now
                End If
            End If

            lv_doctor.Clear()
            form_sdoc_lv()
            Load_sdoc_lv()
            Panel1.Visible = True
            Panel2.Visible = False
        End With
    End Sub

    Private Sub chkMon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMon.CheckedChanged
        If chkMon.Checked Then
            dtfromM.Enabled = False
            dttoM.Enabled = False
        Else
            dtfromM.Enabled = True
            dttoM.Enabled = True
        End If
    End Sub

    Private Sub chkTues_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTues.CheckedChanged
        If chkTues.Checked Then
            dtfromT.Enabled = False
            dttoT.Enabled = False
        Else
            dtfromT.Enabled = True
            dttoT.Enabled = True
        End If
    End Sub

    Private Sub chkWed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWed.CheckedChanged
        If chkWed.Checked Then
            dtfromW.Enabled = False
            dttoW.Enabled = False
        Else
            dtfromW.Enabled = True
            dttoW.Enabled = True
        End If
    End Sub

    Private Sub chkThurs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkThurs.CheckedChanged
        If chkThurs.Checked Then
            dtFromTh.Enabled = False
            dttoTh.Enabled = False
        Else
            dtFromTh.Enabled = True
            dttoTh.Enabled = True
        End If
    End Sub

    Private Sub chkFri_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFri.CheckedChanged
        If chkFri.Checked Then
            dtfromF.Enabled = False
            dttoF.Enabled = False
        Else
            dtfromF.Enabled = True
            dttoF.Enabled = True
        End If
    End Sub

    Private Sub chkSat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSat.CheckedChanged
        If chkSat.Checked Then
            dtfromS.Enabled = False
            dttoS.Enabled = False
        Else
            dtfromS.Enabled = True
            dttoS.Enabled = True
        End If
    End Sub
End Class