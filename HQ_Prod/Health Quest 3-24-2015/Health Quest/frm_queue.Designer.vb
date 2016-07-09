<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_queue
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
        Me.lv_queue = New System.Windows.Forms.ListView
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtpnum = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnADD = New System.Windows.Forms.Button
        Me.btnDept = New System.Windows.Forms.Button
        Me.cmb_service = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DTP = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnq = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button8 = New System.Windows.Forms.Button
        Me.txtdoc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.txtpnamecons = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtpnumcons = New System.Windows.Forms.TextBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button9 = New System.Windows.Forms.Button
        Me.lv_cons = New System.Windows.Forms.ListView
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv_queue
        '
        Me.lv_queue.Location = New System.Drawing.Point(503, 39)
        Me.lv_queue.Name = "lv_queue"
        Me.lv_queue.Size = New System.Drawing.Size(516, 523)
        Me.lv_queue.TabIndex = 102
        Me.lv_queue.UseCompatibleStateImageBehavior = False
        Me.lv_queue.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(6, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 16)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "PATIENT #"
        '
        'txtpnum
        '
        Me.txtpnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpnum.Location = New System.Drawing.Point(171, 46)
        Me.txtpnum.Name = "txtpnum"
        Me.txtpnum.Size = New System.Drawing.Size(300, 21)
        Me.txtpnum.TabIndex = 103
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.Health_Quest.My.Resources.Resources.HQ_FINAL_LOGO
        Me.PictureBox1.Image = Global.Health_Quest.My.Resources.Resources.HQ_FINAL_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(482, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "PATIENT NAME"
        '
        'txtpname
        '
        Me.txtpname.Enabled = False
        Me.txtpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpname.Location = New System.Drawing.Point(171, 78)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(300, 21)
        Me.txtpname.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "SERVICE NAME"
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.Transparent
        Me.btnADD.Font = New System.Drawing.Font("Sylfaen", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnADD.Location = New System.Drawing.Point(31, 105)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(206, 85)
        Me.btnADD.TabIndex = 110
        Me.btnADD.Text = "SERVED"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'btnDept
        '
        Me.btnDept.BackColor = System.Drawing.Color.Transparent
        Me.btnDept.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDept.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDept.Location = New System.Drawing.Point(31, 196)
        Me.btnDept.Name = "btnDept"
        Me.btnDept.Size = New System.Drawing.Size(206, 54)
        Me.btnDept.TabIndex = 111
        Me.btnDept.Text = "DELAY"
        Me.btnDept.UseVisualStyleBackColor = False
        '
        'cmb_service
        '
        Me.cmb_service.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_service.FormattingEnabled = True
        Me.cmb_service.Items.AddRange(New Object() {"OLD", "NEW"})
        Me.cmb_service.Location = New System.Drawing.Point(171, 12)
        Me.cmb_service.Name = "cmb_service"
        Me.cmb_service.Size = New System.Drawing.Size(300, 23)
        Me.cmb_service.TabIndex = 151
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(1001, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 31)
        Me.Button1.TabIndex = 152
        Me.Button1.Text = "x"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(781, 8)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(214, 20)
        Me.DTP.TabIndex = 154
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(721, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "DATE:"
        '
        'btnq
        '
        Me.btnq.BackColor = System.Drawing.Color.Transparent
        Me.btnq.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnq.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnq.Location = New System.Drawing.Point(9, 504)
        Me.btnq.Name = "btnq"
        Me.btnq.Size = New System.Drawing.Size(485, 58)
        Me.btnq.TabIndex = 155
        Me.btnq.Text = "SHOW QUEUE TABLE"
        Me.btnq.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(239, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 54)
        Me.Button2.TabIndex = 156
        Me.Button2.Text = "QUEUE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Sylfaen", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(31, 255)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(414, 70)
        Me.Button3.TabIndex = 157
        Me.Button3.Text = "REFRESH"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(9, 141)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(485, 357)
        Me.TabControl1.TabIndex = 158
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.txtdoc)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.txtpnamecons)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtpnumcons)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(477, 331)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultation"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Font = New System.Drawing.Font("Sylfaen", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button8.Location = New System.Drawing.Point(239, 105)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(206, 85)
        Me.Button8.TabIndex = 164
        Me.Button8.Text = "SERVING"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'txtdoc
        '
        Me.txtdoc.Enabled = False
        Me.txtdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdoc.Location = New System.Drawing.Point(171, 78)
        Me.txtdoc.Name = "txtdoc"
        Me.txtdoc.Size = New System.Drawing.Size(300, 21)
        Me.txtdoc.TabIndex = 162
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "DOCTOR NAME"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Sylfaen", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(31, 255)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(414, 70)
        Me.Button4.TabIndex = 161
        Me.Button4.Text = "REFRESH"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(239, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(206, 54)
        Me.Button5.TabIndex = 160
        Me.Button5.Text = "QUEUE"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Font = New System.Drawing.Font("Sylfaen", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button6.Location = New System.Drawing.Point(31, 105)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(206, 85)
        Me.Button6.TabIndex = 158
        Me.Button6.Text = "SERVED"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button7.Location = New System.Drawing.Point(31, 196)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(206, 54)
        Me.Button7.TabIndex = 159
        Me.Button7.Text = "DELAY"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'txtpnamecons
        '
        Me.txtpnamecons.Enabled = False
        Me.txtpnamecons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpnamecons.Location = New System.Drawing.Point(171, 46)
        Me.txtpnamecons.Name = "txtpnamecons"
        Me.txtpnamecons.Size = New System.Drawing.Size(300, 21)
        Me.txtpnamecons.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "PATIENT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "PATIENT #"
        '
        'txtpnumcons
        '
        Me.txtpnumcons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpnumcons.Location = New System.Drawing.Point(171, 13)
        Me.txtpnumcons.Name = "txtpnumcons"
        Me.txtpnumcons.Size = New System.Drawing.Size(300, 21)
        Me.txtpnumcons.TabIndex = 105
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.cmb_service)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtpnum)
        Me.TabPage1.Controls.Add(Me.txtpname)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnADD)
        Me.TabPage1.Controls.Add(Me.btnDept)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(477, 331)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Services"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Font = New System.Drawing.Font("Sylfaen", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button9.Location = New System.Drawing.Point(239, 105)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(206, 85)
        Me.Button9.TabIndex = 158
        Me.Button9.Text = "SERVING"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'lv_cons
        '
        Me.lv_cons.Location = New System.Drawing.Point(503, 39)
        Me.lv_cons.Name = "lv_cons"
        Me.lv_cons.Size = New System.Drawing.Size(516, 523)
        Me.lv_cons.TabIndex = 159
        Me.lv_cons.UseCompatibleStateImageBehavior = False
        '
        'frm_queue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(1031, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.lv_cons)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnq)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lv_queue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_queue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_queue"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_queue As System.Windows.Forms.ListView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpnum As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnDept As System.Windows.Forms.Button
    Friend WithEvents cmb_service As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnq As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtpnamecons As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpnumcons As System.Windows.Forms.TextBox
    Friend WithEvents lv_cons As System.Windows.Forms.ListView
    Friend WithEvents txtdoc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
