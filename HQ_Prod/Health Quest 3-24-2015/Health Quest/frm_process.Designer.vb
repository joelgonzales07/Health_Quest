<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_process
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
        Me.lv_serviceproceed = New System.Windows.Forms.ListView
        Me.lv_hmoproceed = New System.Windows.Forms.ListView
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txthmonum = New System.Windows.Forms.TextBox
        Me.cmb_hmo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCANCEL = New System.Windows.Forms.Button
        Me.btnPROCEED = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.lbltotalcost = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txthmocont = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtapproveby = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtreqby = New System.Windows.Forms.TextBox
        Me.txtmi = New System.Windows.Forms.RichTextBox
        Me.txttr = New System.Windows.Forms.RichTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmb_comp = New System.Windows.Forms.ComboBox
        Me.dt_cash = New System.Windows.Forms.DataGridView
        Me.dt_hmo = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txths = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lbltotfees = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtdid = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbdtype = New System.Windows.Forms.ComboBox
        Me.radreg = New System.Windows.Forms.RadioButton
        Me.radpri = New System.Windows.Forms.RadioButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txttrid = New System.Windows.Forms.TextBox
        Me.chkHome = New System.Windows.Forms.CheckBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtapprovenum = New System.Windows.Forms.TextBox
        CType(Me.dt_cash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_hmo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_serviceproceed
        '
        Me.lv_serviceproceed.Location = New System.Drawing.Point(15, 152)
        Me.lv_serviceproceed.MultiSelect = False
        Me.lv_serviceproceed.Name = "lv_serviceproceed"
        Me.lv_serviceproceed.Size = New System.Drawing.Size(348, 279)
        Me.lv_serviceproceed.TabIndex = 114
        Me.lv_serviceproceed.UseCompatibleStateImageBehavior = False
        '
        'lv_hmoproceed
        '
        Me.lv_hmoproceed.Location = New System.Drawing.Point(408, 152)
        Me.lv_hmoproceed.MultiSelect = False
        Me.lv_hmoproceed.Name = "lv_hmoproceed"
        Me.lv_hmoproceed.Size = New System.Drawing.Size(348, 279)
        Me.lv_hmoproceed.TabIndex = 115
        Me.lv_hmoproceed.UseCompatibleStateImageBehavior = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(9, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(311, 18)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "SERVICE ACQUISITION MANAGEMENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "CASH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(405, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "HMO"
        '
        'txthmonum
        '
        Me.txthmonum.Enabled = False
        Me.txthmonum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthmonum.Location = New System.Drawing.Point(529, 524)
        Me.txthmonum.Name = "txthmonum"
        Me.txthmonum.Size = New System.Drawing.Size(227, 21)
        Me.txthmonum.TabIndex = 123
        '
        'cmb_hmo
        '
        Me.cmb_hmo.Enabled = False
        Me.cmb_hmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_hmo.FormattingEnabled = True
        Me.cmb_hmo.Location = New System.Drawing.Point(529, 468)
        Me.cmb_hmo.Name = "cmb_hmo"
        Me.cmb_hmo.Size = New System.Drawing.Size(227, 23)
        Me.cmb_hmo.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(405, 471)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "HMO CARD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(405, 527)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 15)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "HMO NUMBER"
        '
        'btnCANCEL
        '
        Me.btnCANCEL.BackColor = System.Drawing.Color.Transparent
        Me.btnCANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCEL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCANCEL.Location = New System.Drawing.Point(657, 633)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(99, 35)
        Me.btnCANCEL.TabIndex = 156
        Me.btnCANCEL.Text = "CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = False
        '
        'btnPROCEED
        '
        Me.btnPROCEED.BackColor = System.Drawing.Color.Transparent
        Me.btnPROCEED.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPROCEED.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPROCEED.Location = New System.Drawing.Point(529, 633)
        Me.btnPROCEED.Name = "btnPROCEED"
        Me.btnPROCEED.Size = New System.Drawing.Size(99, 35)
        Me.btnPROCEED.TabIndex = 155
        Me.btnPROCEED.Text = "PROCEED"
        Me.btnPROCEED.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(259, 442)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 18)
        Me.Label18.TabIndex = 159
        Me.Label18.Text = "P"
        '
        'lbltotalcost
        '
        Me.lbltotalcost.BackColor = System.Drawing.Color.Transparent
        Me.lbltotalcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcost.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltotalcost.Location = New System.Drawing.Point(284, 440)
        Me.lbltotalcost.Name = "lbltotalcost"
        Me.lbltotalcost.Size = New System.Drawing.Size(79, 18)
        Me.lbltotalcost.TabIndex = 158
        Me.lbltotalcost.Text = "0.00"
        Me.lbltotalcost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(124, 439)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(129, 18)
        Me.Label24.TabIndex = 157
        Me.Label24.Text = "SERVICES FEES:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(405, 500)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "CONTACT #"
        '
        'txthmocont
        '
        Me.txthmocont.Enabled = False
        Me.txthmocont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthmocont.Location = New System.Drawing.Point(529, 497)
        Me.txthmocont.Name = "txthmocont"
        Me.txthmocont.Size = New System.Drawing.Size(227, 21)
        Me.txthmocont.TabIndex = 162
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(405, 578)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 164
        Me.Label8.Text = "APPROVED BY"
        '
        'txtapproveby
        '
        Me.txtapproveby.Enabled = False
        Me.txtapproveby.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapproveby.Location = New System.Drawing.Point(529, 575)
        Me.txtapproveby.Name = "txtapproveby"
        Me.txtapproveby.Size = New System.Drawing.Size(227, 21)
        Me.txtapproveby.TabIndex = 163
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(405, 603)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 15)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "REQUESTED BY"
        '
        'txtreqby
        '
        Me.txtreqby.Enabled = False
        Me.txtreqby.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreqby.Location = New System.Drawing.Point(529, 600)
        Me.txtreqby.Name = "txtreqby"
        Me.txtreqby.Size = New System.Drawing.Size(227, 21)
        Me.txtreqby.TabIndex = 165
        '
        'txtmi
        '
        Me.txtmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmi.Location = New System.Drawing.Point(433, 88)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(323, 39)
        Me.txtmi.TabIndex = 170
        Me.txtmi.Text = ""
        '
        'txttr
        '
        Me.txttr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttr.Location = New System.Drawing.Point(40, 88)
        Me.txttr.Name = "txttr"
        Me.txttr.Size = New System.Drawing.Size(323, 39)
        Me.txttr.TabIndex = 169
        Me.txttr.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(405, 70)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(107, 15)
        Me.Label23.TabIndex = 168
        Me.Label23.Text = "MEDICAL INFO:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(9, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(133, 15)
        Me.Label22.TabIndex = 167
        Me.Label22.Text = "TEST REQUESTED:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(405, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 15)
        Me.Label10.TabIndex = 172
        Me.Label10.Text = "COMPANY"
        '
        'cmb_comp
        '
        Me.cmb_comp.Enabled = False
        Me.cmb_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_comp.FormattingEnabled = True
        Me.cmb_comp.Location = New System.Drawing.Point(529, 439)
        Me.cmb_comp.Name = "cmb_comp"
        Me.cmb_comp.Size = New System.Drawing.Size(227, 23)
        Me.cmb_comp.TabIndex = 171
        '
        'dt_cash
        '
        Me.dt_cash.AllowUserToAddRows = False
        Me.dt_cash.AllowUserToDeleteRows = False
        Me.dt_cash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dt_cash.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dt_cash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_cash.Location = New System.Drawing.Point(12, 152)
        Me.dt_cash.MultiSelect = False
        Me.dt_cash.Name = "dt_cash"
        Me.dt_cash.RowHeadersVisible = False
        Me.dt_cash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_cash.Size = New System.Drawing.Size(351, 279)
        Me.dt_cash.TabIndex = 173
        '
        'dt_hmo
        '
        Me.dt_hmo.AllowUserToAddRows = False
        Me.dt_hmo.AllowUserToDeleteRows = False
        Me.dt_hmo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dt_hmo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dt_hmo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_hmo.Location = New System.Drawing.Point(405, 152)
        Me.dt_hmo.MultiSelect = False
        Me.dt_hmo.Name = "dt_hmo"
        Me.dt_hmo.RowHeadersVisible = False
        Me.dt_hmo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_hmo.Size = New System.Drawing.Size(351, 279)
        Me.dt_hmo.TabIndex = 174
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(367, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 30)
        Me.Button1.TabIndex = 175
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(367, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 30)
        Me.Button2.TabIndex = 176
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txths
        '
        Me.txths.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txths.Location = New System.Drawing.Point(284, 471)
        Me.txths.Name = "txths"
        Me.txths.Size = New System.Drawing.Size(79, 21)
        Me.txths.TabIndex = 177
        Me.txths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(259, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 18)
        Me.Label11.TabIndex = 178
        Me.Label11.Text = "P"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(145, 469)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 18)
        Me.Label12.TabIndex = 179
        Me.Label12.Text = "OTHER FEES:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(281, 492)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 18)
        Me.Label13.TabIndex = 180
        Me.Label13.Text = "__________"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(151, 524)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 18)
        Me.Label14.TabIndex = 181
        Me.Label14.Text = "TOTAL FEES:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(259, 524)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 18)
        Me.Label15.TabIndex = 182
        Me.Label15.Text = "P"
        '
        'lbltotfees
        '
        Me.lbltotfees.AutoSize = True
        Me.lbltotfees.BackColor = System.Drawing.Color.Transparent
        Me.lbltotfees.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotfees.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltotfees.Location = New System.Drawing.Point(327, 524)
        Me.lbltotfees.Name = "lbltotfees"
        Me.lbltotfees.Size = New System.Drawing.Size(36, 18)
        Me.lbltotfees.TabIndex = 183
        Me.lbltotfees.Text = "0.00"
        Me.lbltotfees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(12, 553)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 15)
        Me.Label16.TabIndex = 185
        Me.Label16.Text = "DISCOUNT TYPE"
        '
        'txtdid
        '
        Me.txtdid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdid.Location = New System.Drawing.Point(136, 577)
        Me.txtdid.Name = "txtdid"
        Me.txtdid.Size = New System.Drawing.Size(227, 21)
        Me.txtdid.TabIndex = 186
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(12, 580)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 15)
        Me.Label17.TabIndex = 187
        Me.Label17.Text = "DISCOUNT ID"
        '
        'cmbdtype
        '
        Me.cmbdtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdtype.FormattingEnabled = True
        Me.cmbdtype.Items.AddRange(New Object() {"Senior Citizen", "PWD"})
        Me.cmbdtype.Location = New System.Drawing.Point(136, 550)
        Me.cmbdtype.Name = "cmbdtype"
        Me.cmbdtype.Size = New System.Drawing.Size(227, 23)
        Me.cmbdtype.TabIndex = 188
        '
        'radreg
        '
        Me.radreg.AutoSize = True
        Me.radreg.BackColor = System.Drawing.Color.Transparent
        Me.radreg.Checked = True
        Me.radreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.radreg.Location = New System.Drawing.Point(148, 612)
        Me.radreg.Name = "radreg"
        Me.radreg.Size = New System.Drawing.Size(90, 19)
        Me.radreg.TabIndex = 189
        Me.radreg.TabStop = True
        Me.radreg.Text = "REGULAR"
        Me.radreg.UseVisualStyleBackColor = False
        '
        'radpri
        '
        Me.radpri.AutoSize = True
        Me.radpri.BackColor = System.Drawing.Color.Transparent
        Me.radpri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.radpri.Location = New System.Drawing.Point(262, 612)
        Me.radpri.Name = "radpri"
        Me.radpri.Size = New System.Drawing.Size(88, 19)
        Me.radpri.TabIndex = 190
        Me.radpri.TabStop = True
        Me.radpri.Text = "PRIORITY"
        Me.radpri.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(12, 614)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 15)
        Me.Label19.TabIndex = 191
        Me.Label19.Text = "QUEUE TYPE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(9, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 15)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "TRANSACTION #"
        '
        'txttrid
        '
        Me.txttrid.Enabled = False
        Me.txttrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttrid.Location = New System.Drawing.Point(136, 37)
        Me.txttrid.Name = "txttrid"
        Me.txttrid.Size = New System.Drawing.Size(227, 21)
        Me.txttrid.TabIndex = 193
        '
        'chkHome
        '
        Me.chkHome.AutoSize = True
        Me.chkHome.BackColor = System.Drawing.Color.Transparent
        Me.chkHome.Location = New System.Drawing.Point(12, 443)
        Me.chkHome.Name = "chkHome"
        Me.chkHome.Size = New System.Drawing.Size(99, 17)
        Me.chkHome.TabIndex = 194
        Me.chkHome.Text = "Home Service?"
        Me.chkHome.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(405, 553)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 15)
        Me.Label20.TabIndex = 196
        Me.Label20.Text = "APPROVED #"
        '
        'txtapprovenum
        '
        Me.txtapprovenum.Enabled = False
        Me.txtapprovenum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapprovenum.Location = New System.Drawing.Point(529, 550)
        Me.txtapprovenum.Name = "txtapprovenum"
        Me.txtapprovenum.Size = New System.Drawing.Size(227, 21)
        Me.txtapprovenum.TabIndex = 195
        '
        'frm_process
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(764, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtapprovenum)
        Me.Controls.Add(Me.chkHome)
        Me.Controls.Add(Me.txttrid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.radpri)
        Me.Controls.Add(Me.radreg)
        Me.Controls.Add(Me.cmbdtype)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtdid)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbltotfees)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txths)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dt_hmo)
        Me.Controls.Add(Me.dt_cash)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_comp)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.txttr)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtreqby)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtapproveby)
        Me.Controls.Add(Me.txthmocont)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lbltotalcost)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btnCANCEL)
        Me.Controls.Add(Me.btnPROCEED)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txthmonum)
        Me.Controls.Add(Me.cmb_hmo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lv_hmoproceed)
        Me.Controls.Add(Me.lv_serviceproceed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_process"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dt_cash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_hmo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_serviceproceed As System.Windows.Forms.ListView
    Friend WithEvents lv_hmoproceed As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txthmonum As System.Windows.Forms.TextBox
    Friend WithEvents cmb_hmo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents btnPROCEED As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbltotalcost As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txthmocont As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtapproveby As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtreqby As System.Windows.Forms.TextBox
    Friend WithEvents txtmi As System.Windows.Forms.RichTextBox
    Friend WithEvents txttr As System.Windows.Forms.RichTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_comp As System.Windows.Forms.ComboBox
    Friend WithEvents dt_cash As System.Windows.Forms.DataGridView
    Friend WithEvents dt_hmo As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txths As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbltotfees As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtdid As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbdtype As System.Windows.Forms.ComboBox
    Friend WithEvents radreg As System.Windows.Forms.RadioButton
    Friend WithEvents radpri As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttrid As System.Windows.Forms.TextBox
    Friend WithEvents chkHome As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtapprovenum As System.Windows.Forms.TextBox
End Class
