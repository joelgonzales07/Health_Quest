<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_hmoitem
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtGross = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtVat = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnet = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSet = New System.Windows.Forms.Button
        Me.btnCLEAR = New System.Windows.Forms.Button
        Me.txtService = New System.Windows.Forms.TextBox
        Me.cboHMO = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lv_regular = New System.Windows.Forms.ListView
        Me.btnImport = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "HMO PRICE SETTING"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(14, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "HMO Card:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "NET PAY:"
        '
        'txtGross
        '
        Me.txtGross.BackColor = System.Drawing.SystemColors.Window
        Me.txtGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGross.Enabled = False
        Me.txtGross.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtGross.Location = New System.Drawing.Point(17, 191)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.ReadOnly = True
        Me.txtGross.Size = New System.Drawing.Size(192, 25)
        Me.txtGross.TabIndex = 55
        Me.txtGross.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "VAT:"
        '
        'txtVat
        '
        Me.txtVat.BackColor = System.Drawing.SystemColors.Window
        Me.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVat.Enabled = False
        Me.txtVat.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtVat.Location = New System.Drawing.Point(17, 249)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(192, 25)
        Me.txtVat.TabIndex = 53
        Me.txtVat.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "GROSS PAY:"
        '
        'txtnet
        '
        Me.txtnet.BackColor = System.Drawing.SystemColors.Window
        Me.txtnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnet.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtnet.Location = New System.Drawing.Point(17, 305)
        Me.txtnet.Name = "txtnet"
        Me.txtnet.Size = New System.Drawing.Size(192, 25)
        Me.txtnet.TabIndex = 51
        Me.txtnet.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Service Name: "
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.Transparent
        Me.btnSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSet.Location = New System.Drawing.Point(17, 336)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(95, 39)
        Me.btnSet.TabIndex = 48
        Me.btnSet.Text = "SET"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackColor = System.Drawing.Color.Transparent
        Me.btnCLEAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCLEAR.Location = New System.Drawing.Point(114, 336)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(95, 39)
        Me.btnCLEAR.TabIndex = 47
        Me.btnCLEAR.Text = "CLEAR"
        Me.btnCLEAR.UseVisualStyleBackColor = False
        '
        'txtService
        '
        Me.txtService.BackColor = System.Drawing.SystemColors.Window
        Me.txtService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtService.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtService.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtService.Location = New System.Drawing.Point(17, 134)
        Me.txtService.Name = "txtService"
        Me.txtService.ReadOnly = True
        Me.txtService.Size = New System.Drawing.Size(192, 25)
        Me.txtService.TabIndex = 46
        '
        'cboHMO
        '
        Me.cboHMO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHMO.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cboHMO.FormattingEnabled = True
        Me.cboHMO.Location = New System.Drawing.Point(17, 78)
        Me.cboHMO.Name = "cboHMO"
        Me.cboHMO.Size = New System.Drawing.Size(192, 25)
        Me.cboHMO.TabIndex = 59
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSearch.Location = New System.Drawing.Point(624, 52)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(260, 25)
        Me.txtSearch.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(436, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 17)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Search by Service name:"
        '
        'lv_regular
        '
        Me.lv_regular.Location = New System.Drawing.Point(224, 83)
        Me.lv_regular.Name = "lv_regular"
        Me.lv_regular.Size = New System.Drawing.Size(660, 292)
        Me.lv_regular.TabIndex = 60
        Me.lv_regular.UseCompatibleStateImageBehavior = False
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(806, 23)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(78, 23)
        Me.btnImport.TabIndex = 63
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'frm_hmoitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(888, 394)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lv_regular)
        Me.Controls.Add(Me.cboHMO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.btnCLEAR)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_hmoitem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents txtService As System.Windows.Forms.TextBox
    Friend WithEvents cboHMO As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lv_regular As System.Windows.Forms.ListView
    Friend WithEvents btnImport As System.Windows.Forms.Button
End Class
