<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mntr_patient
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
        Me.gp_p_monitoring = New System.Windows.Forms.GroupBox
        Me.lv_monitoring = New System.Windows.Forms.ListView
        Me.btnSaves = New System.Windows.Forms.Button
        Me.Label47 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.txtpatientid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.gp_p_monitoring.SuspendLayout()
        Me.SuspendLayout()
        '
        'gp_p_monitoring
        '
        Me.gp_p_monitoring.BackColor = System.Drawing.Color.Transparent
        Me.gp_p_monitoring.Controls.Add(Me.lv_monitoring)
        Me.gp_p_monitoring.Location = New System.Drawing.Point(16, 68)
        Me.gp_p_monitoring.Name = "gp_p_monitoring"
        Me.gp_p_monitoring.Size = New System.Drawing.Size(709, 347)
        Me.gp_p_monitoring.TabIndex = 70
        Me.gp_p_monitoring.TabStop = False
        '
        'lv_monitoring
        '
        Me.lv_monitoring.Location = New System.Drawing.Point(14, 18)
        Me.lv_monitoring.Name = "lv_monitoring"
        Me.lv_monitoring.Size = New System.Drawing.Size(685, 323)
        Me.lv_monitoring.TabIndex = 0
        Me.lv_monitoring.UseCompatibleStateImageBehavior = False
        '
        'btnSaves
        '
        Me.btnSaves.BackColor = System.Drawing.Color.Transparent
        Me.btnSaves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaves.Location = New System.Drawing.Point(430, 430)
        Me.btnSaves.Name = "btnSaves"
        Me.btnSaves.Size = New System.Drawing.Size(295, 39)
        Me.btnSaves.TabIndex = 71
        Me.btnSaves.Text = "CLOSE"
        Me.btnSaves.UseVisualStyleBackColor = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(-1, 6)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(178, 24)
        Me.Label47.TabIndex = 72
        Me.Label47.Text = "Patient Monitoring"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(443, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 50)
        Me.Button4.TabIndex = 214
        Me.Button4.Text = "SEARCH"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtpatientid
        '
        Me.txtpatientid.Location = New System.Drawing.Point(114, 44)
        Me.txtpatientid.Name = "txtpatientid"
        Me.txtpatientid.Size = New System.Drawing.Size(234, 20)
        Me.txtpatientid.TabIndex = 213
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 212
        Me.Label2.Text = "PATIENT ID:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(362, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 49)
        Me.Button5.TabIndex = 219
        Me.Button5.Text = "CLEAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'mntr_patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(737, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtpatientid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.btnSaves)
        Me.Controls.Add(Me.gp_p_monitoring)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "mntr_patient"
        Me.gp_p_monitoring.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gp_p_monitoring As System.Windows.Forms.GroupBox
    Friend WithEvents lv_monitoring As System.Windows.Forms.ListView
    Friend WithEvents btnSaves As System.Windows.Forms.Button
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtpatientid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
