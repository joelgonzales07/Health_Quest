Imports System.Windows.Forms

Public Class MDI_Administrator

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        frm_department.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        frm_specialization.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'frm_ServiceCategory.Show()
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub FileMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub HelpMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub ConsultationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_consultation.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_doctor.Show()
    End Sub

    Private Sub ServiceTypeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_serviceType.Show()
    End Sub

    Private Sub PackageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_package.Show()
    End Sub

    Private Sub CreateUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_user.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_changepassword.Show()
    End Sub

    Private Sub DoctorScheduluToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_schedule.Show()
    End Sub

    Private Sub PriceSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_price.Show()
    End Sub

    Private Sub ItemCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frm_itemcategory.Show()
    End Sub


    Private Sub ItemTypeToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_item.Show()
    End Sub

    Private Sub ItemSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_SetItem.Show()
    End Sub

    Private Sub PackageSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_setpackage.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Staff.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_department.MdiParent = Me
        frm_department.Show()
        frm_department.Location = New Point(216, 133)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_specialization.MdiParent = Me
        frm_specialization.Show()
        frm_specialization.Location = New Point(216, 133)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    'Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
    '    For Each ChildForm As Form In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    '    frm_consultation.MdiParent = Me
    '    frm_consultation.Show()
    '    frm_consultation.Location = New Point(216, 133)
    'End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_doctor.MdiParent = Me
        frm_doctor.Show()
        frm_doctor.Location = New Point(216, 133)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        PanelMaintenance.Location = New Point(12, 133)
        PanelMaintenance.Visible = True
        PanelMonitoring.Visible = False
        PanelMonitoringRequest.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        PanelMonitoringRequest.Location = New Point(12, 133)
        PanelMonitoringRequest.Visible = True
        PanelMaintenance.Visible = False
        PanelMonitoring.Visible = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_serviceType.MdiParent = Me
        frm_serviceType.Show()
        frm_serviceType.Location = New Point(216, 133)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_item.MdiParent = Me
        frm_item.Show()
        frm_item.Location = New Point(216, 133)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_package.MdiParent = Me
        frm_package.Show()
        frm_package.Location = New Point(216, 133)
    End Sub

    'Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
    '    For Each ChildForm As Form In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    '    frm_Staff.MdiParent = Me
    '    frm_Staff.Show()
    '    frm_Staff.Location = New Point(216, 133)
    'End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_user.MdiParent = Me
        frm_user.Show()
        frm_user.Location = New Point(216, 133)
    End Sub


    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_SCHEDULE.MdiParent = Me
        frm_schedule.Show()
        frm_schedule.Location = New Point(216, 133)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_price.MdiParent = Me
        frm_price.Show()
        frm_price.Location = New Point(216, 133)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_setpackage.MdiParent = Me
        frm_setpackage.Show()
        frm_setpackage.Location = New Point(216, 133)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        PanelMonitoring.Location = New Point(12, 133)
        PanelMonitoring.Visible = True
        PanelMaintenance.Visible = False
        PanelMonitoringRequest.Visible = False
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_SetItem.MdiParent = Me
        frm_SetItem.Show()
        frm_SetItem.Location = New Point(216, 133)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        mntr_doctor.MdiParent = Me
        mntr_doctor.Show()
        mntr_doctor.Location = New Point(216, 133)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        mntr_patient.MdiParent = Me
        mntr_patient.Show()
        mntr_patient.Location = New Point(216, 133)
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        mntr_inventory.MdiParent = Me
        mntr_inventory.Show()
        mntr_inventory.Location = New Point(216, 133)
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        mntr_service.MdiParent = Me
        mntr_service.Show()
        mntr_service.Location = New Point(216, 133)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        rpt_Sales.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Report_InventoryForm.Show()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_uploadexcel.MdiParent = Me
        frm_uploadexcel.Show()
        frm_uploadexcel.Location = New Point(216, 133)
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_hmo.MdiParent = Me
        frm_hmo.Show()
        frm_hmo.Location = New Point(216, 133)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_services.MdiParent = Me
        frm_services.Show()
        frm_services.Location = New Point(216, 133)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        frm_readersfee.MdiParent = Me
        frm_readersfee.Show()
        frm_readersfee.Location = New Point(216, 133)
    End Sub
End Class
