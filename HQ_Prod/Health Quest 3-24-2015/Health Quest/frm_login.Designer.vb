<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnAu = New System.Windows.Forms.Button
        Me.btnEXIT = New System.Windows.Forms.Button
        Me.btnLogin = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.dtp2 = New System.Windows.Forms.DateTimePicker
        Me.txtxpr = New System.Windows.Forms.TextBox
        Me.txtRet = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAu)
        Me.Panel1.Controls.Add(Me.btnEXIT)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(13, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 285)
        Me.Panel1.TabIndex = 0
        '
        'btnAu
        '
        Me.btnAu.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAu.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAu.Location = New System.Drawing.Point(141, 234)
        Me.btnAu.Name = "btnAu"
        Me.btnAu.Size = New System.Drawing.Size(135, 39)
        Me.btnAu.TabIndex = 26
        Me.btnAu.Text = "AUTHENTICATE"
        Me.btnAu.UseVisualStyleBackColor = False
        Me.btnAu.Visible = False
        '
        'btnEXIT
        '
        Me.btnEXIT.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEXIT.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnEXIT.Location = New System.Drawing.Point(206, 234)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(135, 39)
        Me.btnEXIT.TabIndex = 25
        Me.btnEXIT.Text = "EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnLogin.Location = New System.Drawing.Point(52, 234)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(135, 39)
        Me.btnLogin.TabIndex = 24
        Me.btnLogin.Text = "LOG IN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(3, 214)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 10)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(93, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.SystemColors.Info
        Me.txtUser.Location = New System.Drawing.Point(123, 103)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(192, 24)
        Me.txtUser.TabIndex = 20
        Me.txtUser.Text = "USERNAME"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox3.Image = Global.Health_Quest.My.Resources.Resources.Key
        Me.PictureBox3.Location = New System.Drawing.Point(93, 152)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.SystemColors.Info
        Me.txtPass.Location = New System.Drawing.Point(123, 152)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(192, 24)
        Me.txtPass.TabIndex = 21
        Me.txtPass.Text = "PASSWORD"
        Me.txtPass.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Health_Quest.My.Resources.Resources.Lock
        Me.PictureBox1.Location = New System.Drawing.Point(19, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(59, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "HQ Log-in"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(3, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 10)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(457, 155)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 27
        '
        'dtp2
        '
        Me.dtp2.Location = New System.Drawing.Point(457, 181)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(200, 20)
        Me.dtp2.TabIndex = 28
        '
        'txtxpr
        '
        Me.txtxpr.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtxpr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtxpr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtxpr.ForeColor = System.Drawing.SystemColors.Info
        Me.txtxpr.Location = New System.Drawing.Point(457, 216)
        Me.txtxpr.Name = "txtxpr"
        Me.txtxpr.Size = New System.Drawing.Size(200, 24)
        Me.txtxpr.TabIndex = 29
        '
        'txtRet
        '
        Me.txtRet.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRet.ForeColor = System.Drawing.SystemColors.Info
        Me.txtRet.Location = New System.Drawing.Point(457, 247)
        Me.txtRet.Name = "txtRet"
        Me.txtRet.Size = New System.Drawing.Size(200, 24)
        Me.txtRet.TabIndex = 30
        '
        'frm_login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(434, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtRet)
        Me.Controls.Add(Me.txtxpr)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtxpr As System.Windows.Forms.TextBox
    Friend WithEvents txtRet As System.Windows.Forms.TextBox
    Friend WithEvents btnAu As System.Windows.Forms.Button

End Class
