<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Staff
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtstaff = New System.Windows.Forms.TextBox
        Me.lv_staff = New System.Windows.Forms.ListView
        Me.btnREMOVE = New System.Windows.Forms.Button
        Me.btnCANCEL = New System.Windows.Forms.Button
        Me.btnSAVE = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtstaff)
        Me.Panel1.Controls.Add(Me.lv_staff)
        Me.Panel1.Controls.Add(Me.btnREMOVE)
        Me.Panel1.Controls.Add(Me.btnCANCEL)
        Me.Panel1.Controls.Add(Me.btnSAVE)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 332)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Staff Name: "
        '
        'txtstaff
        '
        Me.txtstaff.BackColor = System.Drawing.SystemColors.Window
        Me.txtstaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstaff.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstaff.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtstaff.Location = New System.Drawing.Point(19, 152)
        Me.txtstaff.Name = "txtstaff"
        Me.txtstaff.Size = New System.Drawing.Size(192, 25)
        Me.txtstaff.TabIndex = 29
        '
        'lv_staff
        '
        Me.lv_staff.Location = New System.Drawing.Point(217, 99)
        Me.lv_staff.Name = "lv_staff"
        Me.lv_staff.Size = New System.Drawing.Size(291, 220)
        Me.lv_staff.TabIndex = 27
        Me.lv_staff.UseCompatibleStateImageBehavior = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(59, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Staff Maintenance"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "ID:"
        '
        'frm_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(524, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Staff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtstaff As System.Windows.Forms.TextBox
    Friend WithEvents lv_staff As System.Windows.Forms.ListView
    Friend WithEvents btnREMOVE As System.Windows.Forms.Button
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
