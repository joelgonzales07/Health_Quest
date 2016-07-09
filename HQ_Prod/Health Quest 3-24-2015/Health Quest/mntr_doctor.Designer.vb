<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mntr_doctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPRINT = New System.Windows.Forms.Button
        Me.gp_p_monitoring = New System.Windows.Forms.GroupBox
        Me.lv_monitoring = New System.Windows.Forms.ListView
        Me.Label47 = New System.Windows.Forms.Label
        Me.txtDocName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.gp_p_monitoring.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPRINT
        '
        Me.btnPRINT.BackColor = System.Drawing.Color.Transparent
        Me.btnPRINT.Font = New System.Drawing.Font("Sylfaen", 11.25!)
        Me.btnPRINT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPRINT.Location = New System.Drawing.Point(950, 426)
        Me.btnPRINT.Name = "btnPRINT"
        Me.btnPRINT.Size = New System.Drawing.Size(153, 39)
        Me.btnPRINT.TabIndex = 73
        Me.btnPRINT.Text = "PRINT"
        Me.btnPRINT.UseVisualStyleBackColor = False
        '
        'gp_p_monitoring
        '
        Me.gp_p_monitoring.BackColor = System.Drawing.Color.Transparent
        Me.gp_p_monitoring.Controls.Add(Me.lv_monitoring)
        Me.gp_p_monitoring.Location = New System.Drawing.Point(12, 63)
        Me.gp_p_monitoring.Name = "gp_p_monitoring"
        Me.gp_p_monitoring.Size = New System.Drawing.Size(1097, 357)
        Me.gp_p_monitoring.TabIndex = 72
        Me.gp_p_monitoring.TabStop = False
        '
        'lv_monitoring
        '
        Me.lv_monitoring.Location = New System.Drawing.Point(6, 18)
        Me.lv_monitoring.Name = "lv_monitoring"
        Me.lv_monitoring.Size = New System.Drawing.Size(1085, 333)
        Me.lv_monitoring.TabIndex = 0
        Me.lv_monitoring.UseCompatibleStateImageBehavior = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(6, 4)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(176, 24)
        Me.Label47.TabIndex = 74
        Me.Label47.Text = "Doctor Monitoring"
        '
        'txtDocName
        '
        Me.txtDocName.Location = New System.Drawing.Point(242, 39)
        Me.txtDocName.Name = "txtDocName"
        Me.txtDocName.Size = New System.Drawing.Size(234, 20)
        Me.txtDocName.TabIndex = 221
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(64, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 18)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "Search Doctor Name:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Sylfaen", 11.25!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(791, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 39)
        Me.Button1.TabIndex = 222
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mntr_doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(1118, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDocName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.btnPRINT)
        Me.Controls.Add(Me.gp_p_monitoring)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "mntr_doctor"
        Me.gp_p_monitoring.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPRINT As System.Windows.Forms.Button
    Friend WithEvents gp_p_monitoring As System.Windows.Forms.GroupBox
    Friend WithEvents lv_monitoring As System.Windows.Forms.ListView
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtDocName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
