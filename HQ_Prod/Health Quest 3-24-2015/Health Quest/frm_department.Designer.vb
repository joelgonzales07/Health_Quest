<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_department
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
        Me.txtDeptID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lv_Dept = New System.Windows.Forms.ListView
        Me.btnCLOSE = New System.Windows.Forms.Button
        Me.btnADD = New System.Windows.Forms.Button
        Me.txtDept = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnREMOVE = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDeptID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lv_Dept)
        Me.Panel1.Controls.Add(Me.btnCLOSE)
        Me.Panel1.Controls.Add(Me.btnADD)
        Me.Panel1.Controls.Add(Me.txtDept)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnREMOVE)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 304)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(-3, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Department ID:"
        '
        'txtDeptID
        '
        Me.txtDeptID.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeptID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeptID.Enabled = False
        Me.txtDeptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeptID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDeptID.Location = New System.Drawing.Point(13, 80)
        Me.txtDeptID.Name = "txtDeptID"
        Me.txtDeptID.ReadOnly = True
        Me.txtDeptID.Size = New System.Drawing.Size(192, 24)
        Me.txtDeptID.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(-3, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Department Name: "
        '
        'lv_Dept
        '
        Me.lv_Dept.Location = New System.Drawing.Point(211, 80)
        Me.lv_Dept.Name = "lv_Dept"
        Me.lv_Dept.Size = New System.Drawing.Size(322, 207)
        Me.lv_Dept.TabIndex = 27
        Me.lv_Dept.UseCompatibleStateImageBehavior = False
        '
        'btnCLOSE
        '
        Me.btnCLOSE.BackColor = System.Drawing.Color.Transparent
        Me.btnCLOSE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCLOSE.Location = New System.Drawing.Point(38, 248)
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
        Me.btnADD.Location = New System.Drawing.Point(38, 158)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(135, 39)
        Me.btnADD.TabIndex = 24
        Me.btnADD.Text = "SAVE"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'txtDept
        '
        Me.txtDept.BackColor = System.Drawing.SystemColors.Window
        Me.txtDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDept.Location = New System.Drawing.Point(13, 128)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(192, 24)
        Me.txtDept.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(73, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Department Maintenance"
        '
        'btnREMOVE
        '
        Me.btnREMOVE.BackColor = System.Drawing.Color.Transparent
        Me.btnREMOVE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnREMOVE.Location = New System.Drawing.Point(38, 203)
        Me.btnREMOVE.Name = "btnREMOVE"
        Me.btnREMOVE.Size = New System.Drawing.Size(135, 39)
        Me.btnREMOVE.TabIndex = 29
        Me.btnREMOVE.Text = "REMOVE"
        Me.btnREMOVE.UseVisualStyleBackColor = False
        '
        'frm_department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(545, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_department"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCLOSE As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lv_Dept As System.Windows.Forms.ListView
    Friend WithEvents btnREMOVE As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDeptID As System.Windows.Forms.TextBox
End Class
