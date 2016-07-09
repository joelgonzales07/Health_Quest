<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mntr_que
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
        Me.components = New System.ComponentModel.Container
        Me.lbldate = New System.Windows.Forms.Label
        Me.queue_lv = New System.Windows.Forms.ListView
        Me.Label3 = New System.Windows.Forms.Label
        Me.tmrqueue = New System.Windows.Forms.Timer(Me.components)
        Me.lbltime = New System.Windows.Forms.Label
        Me.tmrqueuelistscroll = New System.Windows.Forms.Timer(Me.components)
        Me.CO = New System.Windows.Forms.Label
        Me.cons_lv = New System.Windows.Forms.ListView
        Me.tmrcons = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblmarkee = New System.Windows.Forms.Label
        Me.tmrmarkee = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.lab_lv = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.tmrlab = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbldate.Location = New System.Drawing.Point(566, 543)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(95, 42)
        Me.lbldate.TabIndex = 77
        Me.lbldate.Text = "date"
        '
        'queue_lv
        '
        Me.queue_lv.BackColor = System.Drawing.Color.LightSteelBlue
        Me.queue_lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.queue_lv.ForeColor = System.Drawing.Color.Black
        Me.queue_lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.queue_lv.Location = New System.Drawing.Point(6, 272)
        Me.queue_lv.Name = "queue_lv"
        Me.queue_lv.Size = New System.Drawing.Size(548, 181)
        Me.queue_lv.TabIndex = 79
        Me.queue_lv.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(548, 31)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "IMAGING"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrqueue
        '
        Me.tmrqueue.Enabled = True
        Me.tmrqueue.Interval = 1000
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Black
        Me.lbltime.Location = New System.Drawing.Point(566, 585)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(91, 42)
        Me.lbltime.TabIndex = 81
        Me.lbltime.Text = "time"
        '
        'tmrqueuelistscroll
        '
        Me.tmrqueuelistscroll.Interval = 2000
        '
        'CO
        '
        Me.CO.BackColor = System.Drawing.Color.Transparent
        Me.CO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CO.Location = New System.Drawing.Point(6, 9)
        Me.CO.Name = "CO"
        Me.CO.Size = New System.Drawing.Size(548, 31)
        Me.CO.TabIndex = 87
        Me.CO.Text = "CONSULTATION"
        Me.CO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cons_lv
        '
        Me.cons_lv.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cons_lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cons_lv.ForeColor = System.Drawing.Color.Black
        Me.cons_lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.cons_lv.Location = New System.Drawing.Point(6, 43)
        Me.cons_lv.Name = "cons_lv"
        Me.cons_lv.Size = New System.Drawing.Size(548, 181)
        Me.cons_lv.TabIndex = 88
        Me.cons_lv.UseCompatibleStateImageBehavior = False
        '
        'tmrcons
        '
        Me.tmrcons.Interval = 2000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblmarkee)
        Me.Panel1.Location = New System.Drawing.Point(0, 682)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 76)
        Me.Panel1.TabIndex = 90
        '
        'lblmarkee
        '
        Me.lblmarkee.AutoSize = True
        Me.lblmarkee.BackColor = System.Drawing.Color.Transparent
        Me.lblmarkee.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmarkee.ForeColor = System.Drawing.Color.Red
        Me.lblmarkee.Location = New System.Drawing.Point(1254, 0)
        Me.lblmarkee.Name = "lblmarkee"
        Me.lblmarkee.Size = New System.Drawing.Size(3934, 73)
        Me.lblmarkee.TabIndex = 91
        Me.lblmarkee.Text = "        IF YOU ARE ON TOP OF THE QUEUE, PLEASE PROCEED TO YOUR DESIGNATED SERVICE" & _
            "S/CONSULTATION...               "
        '
        'tmrmarkee
        '
        Me.tmrmarkee.Interval = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(1337, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 31)
        Me.Button1.TabIndex = 153
        Me.Button1.Text = "x"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(566, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(712, 540)
        Me.Panel2.TabIndex = 154
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(1254, 539)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 21)
        Me.Button2.TabIndex = 157
        Me.Button2.Text = "^"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lab_lv
        '
        Me.lab_lv.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lab_lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lab_lv.ForeColor = System.Drawing.Color.Black
        Me.lab_lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lab_lv.Location = New System.Drawing.Point(6, 495)
        Me.lab_lv.Name = "lab_lv"
        Me.lab_lv.Size = New System.Drawing.Size(548, 181)
        Me.lab_lv.TabIndex = 155
        Me.lab_lv.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 31)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "LABORATORY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrlab
        '
        Me.tmrlab.Interval = 2000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(623, 627)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 42)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "■ - Next on queue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(994, 627)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 42)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "(P) - Priority"
        '
        'mntr_que
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(1278, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lab_lv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cons_lv)
        Me.Controls.Add(Me.CO)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.queue_lv)
        Me.Controls.Add(Me.lbldate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "mntr_que"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents queue_lv As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tmrqueue As System.Windows.Forms.Timer
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents tmrqueuelistscroll As System.Windows.Forms.Timer
    Friend WithEvents CO As System.Windows.Forms.Label
    Friend WithEvents cons_lv As System.Windows.Forms.ListView
    Friend WithEvents tmrcons As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblmarkee As System.Windows.Forms.Label
    Friend WithEvents tmrmarkee As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lab_lv As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrlab As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
