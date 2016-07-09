<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_services
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lv_nitem = New System.Windows.Forms.ListView
        Me.cmb_services = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lv_sitem = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lv_nitem
        '
        Me.lv_nitem.Location = New System.Drawing.Point(359, 114)
        Me.lv_nitem.MultiSelect = False
        Me.lv_nitem.Name = "lv_nitem"
        Me.lv_nitem.Size = New System.Drawing.Size(311, 273)
        Me.lv_nitem.TabIndex = 50
        Me.lv_nitem.UseCompatibleStateImageBehavior = False
        '
        'cmb_services
        '
        Me.cmb_services.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_services.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cmb_services.ForeColor = System.Drawing.Color.Black
        Me.cmb_services.FormattingEnabled = True
        Me.cmb_services.Location = New System.Drawing.Point(147, 82)
        Me.cmb_services.Name = "cmb_services"
        Me.cmb_services.Size = New System.Drawing.Size(204, 26)
        Me.cmb_services.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(36, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 18)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Service Name:"
        '
        'lv_sitem
        '
        Me.lv_sitem.Location = New System.Drawing.Point(39, 114)
        Me.lv_sitem.MultiSelect = False
        Me.lv_sitem.Name = "lv_sitem"
        Me.lv_sitem.Size = New System.Drawing.Size(314, 273)
        Me.lv_sitem.TabIndex = 47
        Me.lv_sitem.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(102, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 29)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Set Items to Service"
        '
        'frm_services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(687, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lv_nitem)
        Me.Controls.Add(Me.cmb_services)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lv_sitem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_services"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_nitem As System.Windows.Forms.ListView
    Friend WithEvents cmb_services As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lv_sitem As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
