<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_package
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
        Me.lv_services = New System.Windows.Forms.ListView
        Me.cmb_package = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lv_Pack = New System.Windows.Forms.ListView
        Me.btnREMOVE = New System.Windows.Forms.Button
        Me.btnCANCEL = New System.Windows.Forms.Button
        Me.btnSAVE = New System.Windows.Forms.Button
        Me.txtPack = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lv_services)
        Me.Panel1.Controls.Add(Me.cmb_package)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lv_Pack)
        Me.Panel1.Controls.Add(Me.btnREMOVE)
        Me.Panel1.Controls.Add(Me.btnCANCEL)
        Me.Panel1.Controls.Add(Me.btnSAVE)
        Me.Panel1.Controls.Add(Me.txtPack)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1113, 332)
        Me.Panel1.TabIndex = 2
        '
        'lv_services
        '
        Me.lv_services.Location = New System.Drawing.Point(799, 103)
        Me.lv_services.MultiSelect = False
        Me.lv_services.Name = "lv_services"
        Me.lv_services.Size = New System.Drawing.Size(311, 216)
        Me.lv_services.TabIndex = 36
        Me.lv_services.UseCompatibleStateImageBehavior = False
        '
        'cmb_package
        '
        Me.cmb_package.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_package.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cmb_package.ForeColor = System.Drawing.Color.Black
        Me.cmb_package.FormattingEnabled = True
        Me.cmb_package.Location = New System.Drawing.Point(600, 71)
        Me.cmb_package.Name = "cmb_package"
        Me.cmb_package.Size = New System.Drawing.Size(193, 26)
        Me.cmb_package.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(476, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Package Name: "
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(479, 103)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(314, 216)
        Me.ListView1.TabIndex = 33
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtID.Location = New System.Drawing.Point(19, 95)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(192, 24)
        Me.txtID.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Package Name: "
        '
        'lv_Pack
        '
        Me.lv_Pack.Location = New System.Drawing.Point(217, 99)
        Me.lv_Pack.Name = "lv_Pack"
        Me.lv_Pack.Size = New System.Drawing.Size(250, 220)
        Me.lv_Pack.TabIndex = 27
        Me.lv_Pack.UseCompatibleStateImageBehavior = False
        '
        'btnREMOVE
        '
        Me.btnREMOVE.BackColor = System.Drawing.Color.Transparent
        Me.btnREMOVE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnREMOVE.Location = New System.Drawing.Point(45, 235)
        Me.btnREMOVE.Name = "btnREMOVE"
        Me.btnREMOVE.Size = New System.Drawing.Size(135, 39)
        Me.btnREMOVE.TabIndex = 26
        Me.btnREMOVE.Text = "REMOVE"
        Me.btnREMOVE.UseVisualStyleBackColor = False
        '
        'btnCANCEL
        '
        Me.btnCANCEL.BackColor = System.Drawing.Color.Transparent
        Me.btnCANCEL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCANCEL.Location = New System.Drawing.Point(45, 280)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(135, 39)
        Me.btnCANCEL.TabIndex = 25
        Me.btnCANCEL.Text = "CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = False
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.Color.Transparent
        Me.btnSAVE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSAVE.Location = New System.Drawing.Point(45, 190)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(135, 39)
        Me.btnSAVE.TabIndex = 24
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'txtPack
        '
        Me.txtPack.BackColor = System.Drawing.SystemColors.Window
        Me.txtPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPack.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPack.Location = New System.Drawing.Point(19, 152)
        Me.txtPack.Name = "txtPack"
        Me.txtPack.Size = New System.Drawing.Size(192, 25)
        Me.txtPack.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(102, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Package Maintenance"
        '
        'frm_package
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(1116, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_package"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lv_Pack As System.Windows.Forms.ListView
    Friend WithEvents btnREMOVE As System.Windows.Forms.Button
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents txtPack As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lv_services As System.Windows.Forms.ListView
    Friend WithEvents cmb_package As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
