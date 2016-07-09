Imports System.IO
Public Class frm_queueitem
    Dim conn As New HQ_Connection
    Dim servid As String = frm_queue.servid
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub frm_queueitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt_hmo_pop()
        clearExpBox()
    End Sub

    Sub dt_hmo_pop()
        dt_items.Columns.Clear()
        Dim sra As New StreamReader("IP_CONFIG.txt")
        Dim x As String = sra.ReadToEnd()
        Dim conndt As New Odbc.OdbcConnection("Driver={MySQL ODBC 3.51 Driver};Server=" & x & ";user=root;PWD=123456;Database=hq_db")
        Dim cmd As New Odbc.OdbcCommand("SELECT i.`item_id` AS 'id', i.`item` AS 'Item name', it.`quantity` AS 'Stock level', s.`quantity` AS 'Expected usage', '0' AS 'Actual usage', it.`quantity` AS 'New stock level' FROM service_item_tbl AS s INNER JOIN item_type_tbl AS i ON s.`item_id` = i.`item_id` INNER JOIN item_category_tbl AS ic ON i.`item_cat_id` = ic.`item_cat_id` INNER JOIN inventory_tbl AS it ON it.`item_id` = i.`item_id` WHERE stype_id = '" + servid + "'", conndt)
        Dim da As New Odbc.OdbcDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        dt_items.DataSource = ds.Tables(0)
        dt_items.Columns("id").Visible = False
        dt_items.Columns("Item name").ReadOnly = True
        dt_items.Columns("Stock level").ReadOnly = True
        dt_items.Columns("Expected usage").ReadOnly = True
        dt_items.Columns("New stock level").ReadOnly = True
    End Sub

    Private Sub dt_items_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt_items.CellEndEdit
        clearExpBox()
    End Sub

    Sub clearExpBox()
        For i As Integer = 0 To dt_items.Rows.Count - 1
            If dt_items.Rows(i).Cells("Actual usage").Value.ToString = "" Then
                dt_items.Rows(i).Cells("Actual usage").Value = "0"
            End If
            dt_items.Rows(i).Cells("New stock level").Value = dt_items.Rows(i).Cells("Stock level").Value - dt_items.Rows(i).Cells("Actual usage").Value
        Next
    End Sub

    Private Sub btnPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaid.Click
        For i As Integer = 0 To dt_items.Rows.Count - 1
            Dim mod_query As String = "update inventory_tbl set quantity = '" + dt_items.Rows(i).Cells("New stock level").Value.ToString + "' where item_id = '" + dt_items.Rows(i).Cells("id").Value.ToString + "'"
            If conn.ModRec(mod_query) Then
                MessageBox.Show("Inventory successfully updated.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No changes made for the inventory.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Dispose()
        Next
    End Sub
End Class