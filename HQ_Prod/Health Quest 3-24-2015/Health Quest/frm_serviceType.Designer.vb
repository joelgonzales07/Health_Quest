<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_serviceType
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtScatID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lv_Scat = New System.Windows.Forms.ListView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtScat = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_Stype = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lv_Stype = New System.Windows.Forms.ListView
        Me.btnREMOVE = New System.Windows.Forms.Button
        Me.btnCLOSE = New System.Windows.Forms.Button
        Me.btnADD = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.rdbtnImaging = New System.Windows.Forms.RadioButton
        Me.rdbtnLab = New System.Windows.Forms.RadioButton
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.rdbtnLab)
        Me.Panel1.Controls.Add(Me.rdbtnImaging)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtScatID)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lv_Scat)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.txtScat)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtSID)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmb_Stype)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lv_Stype)
        Me.Panel1.Controls.Add(Me.btnREMOVE)
        Me.Panel1.Controls.Add(Me.btnCLOSE)
        Me.Panel1.Controls.Add(Me.btnADD)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1112, 399)
        Me.Panel1.TabIndex = 2
        '
        'txtScatID
        '
        Me.txtScatID.BackColor = System.Drawing.SystemColors.Window
        Me.txtScatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScatID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtScatID.Enabled = False
        Me.txtScatID.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScatID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtScatID.Location = New System.Drawing.Point(16, 69)
        Me.txtScatID.Name = "txtScatID"
        Me.txtScatID.ReadOnly = True
        Me.txtScatID.Size = New System.Drawing.Size(192, 25)
        Me.txtScatID.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Service Category ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(13, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Service Category Name: "
        '
        'lv_Scat
        '
        Me.lv_Scat.Location = New System.Drawing.Point(214, 69)
        Me.lv_Scat.Name = "lv_Scat"
        Me.lv_Scat.Size = New System.Drawing.Size(250, 248)
        Me.lv_Scat.TabIndex = 39
        Me.lv_Scat.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(43, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 39)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "REMOVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(43, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 39)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(43, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 39)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtScat
        '
        Me.txtScat.BackColor = System.Drawing.SystemColors.Window
        Me.txtScat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtScat.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtScat.Location = New System.Drawing.Point(16, 131)
        Me.txtScat.Name = "txtScat"
        Me.txtScat.Size = New System.Drawing.Size(192, 25)
        Me.txtScat.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(33, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(374, 29)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Service Category Maintenance"
        '
        'txtSID
        '
        Me.txtSID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSID.Enabled = False
        Me.txtSID.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSID.Location = New System.Drawing.Point(496, 69)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.ReadOnly = True
        Me.txtSID.Size = New System.Drawing.Size(192, 25)
        Me.txtSID.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(493, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Service ID:"
        '
        'cmb_Stype
        '
        Me.cmb_Stype.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Stype.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cmb_Stype.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_Stype.FormattingEnabled = True
        Me.cmb_Stype.Location = New System.Drawing.Point(496, 228)
        Me.cmb_Stype.Name = "cmb_Stype"
        Me.cmb_Stype.Size = New System.Drawing.Size(192, 25)
        Me.cmb_Stype.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(493, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Service Name: "
        '
        'txtSname
        '
        Me.txtSname.BackColor = System.Drawing.SystemColors.Window
        Me.txtSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSname.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSname.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSname.Location = New System.Drawing.Point(496, 180)
        Me.txtSname.Name = "txtSname"
        Me.txtSname.Size = New System.Drawing.Size(192, 25)
        Me.txtSname.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(493, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Service Category: "
        '
        'lv_Stype
        '
        Me.lv_Stype.Location = New System.Drawing.Point(705, 69)
        Me.lv_Stype.Name = "lv_Stype"
        Me.lv_Stype.Size = New System.Drawing.Size(400, 256)
        Me.lv_Stype.TabIndex = 27
        Me.lv_Stype.UseCompatibleStateImageBehavior = False
        '
        'btnREMOVE
        '
        Me.btnREMOVE.BackColor = System.Drawing.Color.Transparent
        Me.btnREMOVE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnREMOVE.Location = New System.Drawing.Point(524, 304)
        Me.btnREMOVE.Name = "btnREMOVE"
        Me.btnREMOVE.Size = New System.Drawing.Size(135, 39)
        Me.btnREMOVE.TabIndex = 26
        Me.btnREMOVE.Text = "REMOVE"
        Me.btnREMOVE.UseVisualStyleBackColor = False
        '
        'btnCLOSE
        '
        Me.btnCLOSE.BackColor = System.Drawing.Color.Transparent
        Me.btnCLOSE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCLOSE.Location = New System.Drawing.Point(524, 349)
        Me.btnCLOSE.Name = "btnCLOSE"
        Me.btnCLOSE.Size = New System.Drawing.Size(135, 39)
        Me.btnCLOSE.TabIndex = 25
        Me.btnCLOSE.Text = "CANCEL"
        Me.btnCLOSE.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.Transparent
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnADD.Location = New System.Drawing.Point(524, 259)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(135, 39)
        Me.btnADD.TabIndex = 24
        Me.btnADD.Text = "SAVE"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(491, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Service Type Maintenance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(493, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 17)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Service Classification:"
        '
        'rdbtnImaging
        '
        Me.rdbtnImaging.AutoSize = True
        Me.rdbtnImaging.Checked = True
        Me.rdbtnImaging.Font = New System.Drawing.Font("Lucida Bright", 11.25!)
        Me.rdbtnImaging.Location = New System.Drawing.Point(496, 131)
        Me.rdbtnImaging.Name = "rdbtnImaging"
        Me.rdbtnImaging.Size = New System.Drawing.Size(84, 21)
        Me.rdbtnImaging.TabIndex = 44
        Me.rdbtnImaging.TabStop = True
        Me.rdbtnImaging.Text = "Imaging"
        Me.rdbtnImaging.UseVisualStyleBackColor = True
        '
        'rdbtnLab
        '
        Me.rdbtnLab.AutoSize = True
        Me.rdbtnLab.Font = New System.Drawing.Font("Lucida Bright", 11.25!)
        Me.rdbtnLab.Location = New System.Drawing.Point(583, 131)
        Me.rdbtnLab.Name = "rdbtnLab"
        Me.rdbtnLab.Size = New System.Drawing.Size(105, 21)
        Me.rdbtnLab.TabIndex = 45
        Me.rdbtnLab.Text = "Laboratory"
        Me.rdbtnLab.UseVisualStyleBackColor = True
        '
        'frm_serviceType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(1116, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_serviceType"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lv_Stype As System.Windows.Forms.ListView
    Friend WithEvents btnREMOVE As System.Windows.Forms.Button
    Friend WithEvents btnCLOSE As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Stype As System.Windows.Forms.ComboBox
    Friend WithEvents txtSID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtScatID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lv_Scat As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtScat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rdbtnLab As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnImaging As System.Windows.Forms.RadioButton
End Class
