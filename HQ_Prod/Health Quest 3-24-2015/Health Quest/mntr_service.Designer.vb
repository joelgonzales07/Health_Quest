<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mntr_service
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
        Me.btnSaves = New System.Windows.Forms.Button
        Me.Label45 = New System.Windows.Forms.Label
        Me.lv_service = New System.Windows.Forms.ListView
        Me.cmb_Stype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnSaves
        '
        Me.btnSaves.BackColor = System.Drawing.Color.Transparent
        Me.btnSaves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaves.Location = New System.Drawing.Point(321, 336)
        Me.btnSaves.Name = "btnSaves"
        Me.btnSaves.Size = New System.Drawing.Size(295, 39)
        Me.btnSaves.TabIndex = 75
        Me.btnSaves.Text = "CLOSE"
        Me.btnSaves.UseVisualStyleBackColor = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(12, 32)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(235, 24)
        Me.Label45.TabIndex = 74
        Me.Label45.Text = "SERVICE MONITORING"
        '
        'lv_service
        '
        Me.lv_service.Location = New System.Drawing.Point(12, 65)
        Me.lv_service.Name = "lv_service"
        Me.lv_service.Size = New System.Drawing.Size(604, 265)
        Me.lv_service.TabIndex = 73
        Me.lv_service.UseCompatibleStateImageBehavior = False
        '
        'cmb_Stype
        '
        Me.cmb_Stype.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Stype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cmb_Stype.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_Stype.FormattingEnabled = True
        Me.cmb_Stype.Location = New System.Drawing.Point(424, 33)
        Me.cmb_Stype.Name = "cmb_Stype"
        Me.cmb_Stype.Size = New System.Drawing.Size(192, 26)
        Me.cmb_Stype.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(306, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Service Name: "
        '
        'mntr_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(632, 403)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmb_Stype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSaves)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.lv_service)
        Me.Name = "mntr_service"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaves As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents lv_service As System.Windows.Forms.ListView
    Friend WithEvents cmb_Stype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
