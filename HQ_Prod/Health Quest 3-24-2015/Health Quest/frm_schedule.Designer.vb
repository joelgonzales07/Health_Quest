<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_schedule
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
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtUID = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dttoS = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.dtfromS = New System.Windows.Forms.DateTimePicker
        Me.dttoF = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.dtfromF = New System.Windows.Forms.DateTimePicker
        Me.dttoTh = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtFromTh = New System.Windows.Forms.DateTimePicker
        Me.dttoW = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtfromW = New System.Windows.Forms.DateTimePicker
        Me.dttoT = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtfromT = New System.Windows.Forms.DateTimePicker
        Me.dttoM = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtfromM = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnADD = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lv_doctor = New System.Windows.Forms.ListView
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.chkMon = New System.Windows.Forms.CheckBox
        Me.chkTues = New System.Windows.Forms.CheckBox
        Me.chkWed = New System.Windows.Forms.CheckBox
        Me.chkThurs = New System.Windows.Forms.CheckBox
        Me.chkFri = New System.Windows.Forms.CheckBox
        Me.chkSat = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtUID)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtDname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(649, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 441)
        Me.Panel1.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(26, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 17)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Doctor's ID:"
        '
        'txtUID
        '
        Me.txtUID.BackColor = System.Drawing.Color.White
        Me.txtUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUID.Enabled = False
        Me.txtUID.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUID.ForeColor = System.Drawing.Color.Black
        Me.txtUID.Location = New System.Drawing.Point(73, 67)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.ReadOnly = True
        Me.txtUID.Size = New System.Drawing.Size(271, 25)
        Me.txtUID.TabIndex = 30
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSat)
        Me.GroupBox3.Controls.Add(Me.chkFri)
        Me.GroupBox3.Controls.Add(Me.chkThurs)
        Me.GroupBox3.Controls.Add(Me.chkWed)
        Me.GroupBox3.Controls.Add(Me.chkTues)
        Me.GroupBox3.Controls.Add(Me.chkMon)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.dttoS)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.dtfromS)
        Me.GroupBox3.Controls.Add(Me.dttoF)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.dtfromF)
        Me.GroupBox3.Controls.Add(Me.dttoTh)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.dtFromTh)
        Me.GroupBox3.Controls.Add(Me.dttoW)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dtfromW)
        Me.GroupBox3.Controls.Add(Me.dttoT)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.dtfromT)
        Me.GroupBox3.Controls.Add(Me.dttoM)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dtfromM)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnBack)
        Me.GroupBox3.Controls.Add(Me.btnADD)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(453, 240)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Schedule"
        '
        'dttoS
        '
        Me.dttoS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttoS.Location = New System.Drawing.Point(243, 159)
        Me.dttoS.Name = "dttoS"
        Me.dttoS.ShowUpDown = True
        Me.dttoS.Size = New System.Drawing.Size(107, 20)
        Me.dttoS.TabIndex = 60
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(226, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 15)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "-"
        '
        'dtfromS
        '
        Me.dtfromS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfromS.Location = New System.Drawing.Point(113, 159)
        Me.dtfromS.Name = "dtfromS"
        Me.dtfromS.ShowUpDown = True
        Me.dtfromS.Size = New System.Drawing.Size(107, 20)
        Me.dtfromS.TabIndex = 58
        '
        'dttoF
        '
        Me.dttoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttoF.Location = New System.Drawing.Point(243, 131)
        Me.dttoF.Name = "dttoF"
        Me.dttoF.ShowUpDown = True
        Me.dttoF.Size = New System.Drawing.Size(107, 20)
        Me.dttoF.TabIndex = 57
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(226, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 15)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "-"
        '
        'dtfromF
        '
        Me.dtfromF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfromF.Location = New System.Drawing.Point(113, 131)
        Me.dtfromF.Name = "dtfromF"
        Me.dtfromF.ShowUpDown = True
        Me.dtfromF.Size = New System.Drawing.Size(107, 20)
        Me.dtfromF.TabIndex = 55
        '
        'dttoTh
        '
        Me.dttoTh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttoTh.Location = New System.Drawing.Point(243, 102)
        Me.dttoTh.Name = "dttoTh"
        Me.dttoTh.ShowUpDown = True
        Me.dttoTh.Size = New System.Drawing.Size(107, 20)
        Me.dttoTh.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(226, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 15)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "-"
        '
        'dtFromTh
        '
        Me.dtFromTh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFromTh.Location = New System.Drawing.Point(113, 102)
        Me.dtFromTh.Name = "dtFromTh"
        Me.dtFromTh.ShowUpDown = True
        Me.dtFromTh.Size = New System.Drawing.Size(107, 20)
        Me.dtFromTh.TabIndex = 52
        '
        'dttoW
        '
        Me.dttoW.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttoW.Location = New System.Drawing.Point(243, 73)
        Me.dttoW.Name = "dttoW"
        Me.dttoW.ShowUpDown = True
        Me.dttoW.Size = New System.Drawing.Size(107, 20)
        Me.dttoW.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(226, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 15)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "-"
        '
        'dtfromW
        '
        Me.dtfromW.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfromW.Location = New System.Drawing.Point(113, 73)
        Me.dtfromW.Name = "dtfromW"
        Me.dtfromW.ShowUpDown = True
        Me.dtfromW.Size = New System.Drawing.Size(107, 20)
        Me.dtfromW.TabIndex = 49
        '
        'dttoT
        '
        Me.dttoT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttoT.Location = New System.Drawing.Point(243, 44)
        Me.dttoT.Name = "dttoT"
        Me.dttoT.ShowUpDown = True
        Me.dttoT.Size = New System.Drawing.Size(107, 20)
        Me.dttoT.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(226, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 15)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "-"
        '
        'dtfromT
        '
        Me.dtfromT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfromT.Location = New System.Drawing.Point(113, 44)
        Me.dtfromT.Name = "dtfromT"
        Me.dtfromT.ShowUpDown = True
        Me.dtfromT.Size = New System.Drawing.Size(107, 20)
        Me.dtfromT.TabIndex = 46
        '
        'dttoM
        '
        Me.dttoM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttoM.Location = New System.Drawing.Point(243, 15)
        Me.dttoM.Name = "dttoM"
        Me.dttoM.ShowUpDown = True
        Me.dttoM.Size = New System.Drawing.Size(107, 20)
        Me.dttoM.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(226, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 15)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "-"
        '
        'dtfromM
        '
        Me.dtfromM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfromM.Location = New System.Drawing.Point(113, 15)
        Me.dtfromM.Name = "dtfromM"
        Me.dtfromM.ShowUpDown = True
        Me.dtfromM.Size = New System.Drawing.Size(107, 20)
        Me.dtfromM.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "SATURDAY:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(40, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "FRIDAY:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(203, 195)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(147, 39)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.Transparent
        Me.btnADD.ForeColor = System.Drawing.Color.Black
        Me.btnADD.Location = New System.Drawing.Point(50, 195)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(147, 39)
        Me.btnADD.TabIndex = 24
        Me.btnADD.Text = "SET"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(18, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "THURSDAY:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "WEDNESDAY:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "TUESDAY:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Monday:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Doctor's Name:"
        '
        'txtDname
        '
        Me.txtDname.BackColor = System.Drawing.Color.White
        Me.txtDname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDname.Enabled = False
        Me.txtDname.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDname.ForeColor = System.Drawing.Color.Black
        Me.txtDname.Location = New System.Drawing.Point(73, 129)
        Me.txtDname.Name = "txtDname"
        Me.txtDname.ReadOnly = True
        Me.txtDname.Size = New System.Drawing.Size(271, 25)
        Me.txtDname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(108, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Schedule Setting"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lv_doctor)
        Me.Panel2.Location = New System.Drawing.Point(2, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 461)
        Me.Panel2.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(58, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(438, 21)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "(NOTE: Click the desire doctor to alter schedule)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(55, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 29)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Doctor's Schedule"
        '
        'lv_doctor
        '
        Me.lv_doctor.Location = New System.Drawing.Point(8, 103)
        Me.lv_doctor.Name = "lv_doctor"
        Me.lv_doctor.Size = New System.Drawing.Size(633, 341)
        Me.lv_doctor.TabIndex = 45
        Me.lv_doctor.UseCompatibleStateImageBehavior = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(356, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 15)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "/"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(356, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 15)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "/"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(356, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 15)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "/"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(356, 107)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 15)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "/"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(356, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 15)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "/"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(356, 164)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 15)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "/"
        '
        'chkMon
        '
        Me.chkMon.AutoSize = True
        Me.chkMon.ForeColor = System.Drawing.Color.Black
        Me.chkMon.Location = New System.Drawing.Point(372, 20)
        Me.chkMon.Name = "chkMon"
        Me.chkMon.Size = New System.Drawing.Size(41, 17)
        Me.chkMon.TabIndex = 67
        Me.chkMon.Text = "NA"
        Me.chkMon.UseVisualStyleBackColor = True
        '
        'chkTues
        '
        Me.chkTues.AutoSize = True
        Me.chkTues.ForeColor = System.Drawing.Color.Black
        Me.chkTues.Location = New System.Drawing.Point(372, 49)
        Me.chkTues.Name = "chkTues"
        Me.chkTues.Size = New System.Drawing.Size(41, 17)
        Me.chkTues.TabIndex = 68
        Me.chkTues.Text = "NA"
        Me.chkTues.UseVisualStyleBackColor = True
        '
        'chkWed
        '
        Me.chkWed.AutoSize = True
        Me.chkWed.ForeColor = System.Drawing.Color.Black
        Me.chkWed.Location = New System.Drawing.Point(372, 78)
        Me.chkWed.Name = "chkWed"
        Me.chkWed.Size = New System.Drawing.Size(41, 17)
        Me.chkWed.TabIndex = 69
        Me.chkWed.Text = "NA"
        Me.chkWed.UseVisualStyleBackColor = True
        '
        'chkThurs
        '
        Me.chkThurs.AutoSize = True
        Me.chkThurs.ForeColor = System.Drawing.Color.Black
        Me.chkThurs.Location = New System.Drawing.Point(372, 107)
        Me.chkThurs.Name = "chkThurs"
        Me.chkThurs.Size = New System.Drawing.Size(41, 17)
        Me.chkThurs.TabIndex = 70
        Me.chkThurs.Text = "NA"
        Me.chkThurs.UseVisualStyleBackColor = True
        '
        'chkFri
        '
        Me.chkFri.AutoSize = True
        Me.chkFri.ForeColor = System.Drawing.Color.Black
        Me.chkFri.Location = New System.Drawing.Point(372, 136)
        Me.chkFri.Name = "chkFri"
        Me.chkFri.Size = New System.Drawing.Size(41, 17)
        Me.chkFri.TabIndex = 71
        Me.chkFri.Text = "NA"
        Me.chkFri.UseVisualStyleBackColor = True
        '
        'chkSat
        '
        Me.chkSat.AutoSize = True
        Me.chkSat.ForeColor = System.Drawing.Color.Black
        Me.chkSat.Location = New System.Drawing.Point(372, 162)
        Me.chkSat.Name = "chkSat"
        Me.chkSat.Size = New System.Drawing.Size(41, 17)
        Me.chkSat.TabIndex = 72
        Me.chkSat.Text = "NA"
        Me.chkSat.UseVisualStyleBackColor = True
        '
        'frm_schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(1010, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_schedule"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents txtDname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lv_doctor As System.Windows.Forms.ListView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUID As System.Windows.Forms.TextBox
    Friend WithEvents dtfromM As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttoS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtfromS As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttoF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtfromF As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttoTh As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtFromTh As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttoW As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtfromW As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttoT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtfromT As System.Windows.Forms.DateTimePicker
    Friend WithEvents dttoM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkSat As System.Windows.Forms.CheckBox
    Friend WithEvents chkFri As System.Windows.Forms.CheckBox
    Friend WithEvents chkThurs As System.Windows.Forms.CheckBox
    Friend WithEvents chkWed As System.Windows.Forms.CheckBox
    Friend WithEvents chkTues As System.Windows.Forms.CheckBox
    Friend WithEvents chkMon As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
