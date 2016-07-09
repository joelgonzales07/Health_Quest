<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SetItem
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
        Me.txtIname = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lv_ri = New System.Windows.Forms.ListView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtSearch2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lv_ii = New System.Windows.Forms.ListView
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSet = New System.Windows.Forms.Button
        Me.btnCLEAR = New System.Windows.Forms.Button
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtIname.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIname
        '
        Me.txtIname.BackColor = System.Drawing.Color.Transparent
        Me.txtIname.Controls.Add(Me.Label5)
        Me.txtIname.Controls.Add(Me.txtID)
        Me.txtIname.Controls.Add(Me.Label4)
        Me.txtIname.Controls.Add(Me.txtdescription)
        Me.txtIname.Controls.Add(Me.Label3)
        Me.txtIname.Controls.Add(Me.txtQuantity)
        Me.txtIname.Controls.Add(Me.TabControl1)
        Me.txtIname.Controls.Add(Me.Label2)
        Me.txtIname.Controls.Add(Me.btnSet)
        Me.txtIname.Controls.Add(Me.btnCLEAR)
        Me.txtIname.Controls.Add(Me.txtname)
        Me.txtIname.Controls.Add(Me.Label1)
        Me.txtIname.Location = New System.Drawing.Point(-1, -1)
        Me.txtIname.Name = "txtIname"
        Me.txtIname.Size = New System.Drawing.Size(581, 334)
        Me.txtIname.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 11.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 17)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(16, 83)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(192, 25)
        Me.txtID.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 11.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(13, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Item description: "
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.White
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescription.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtdescription.ForeColor = System.Drawing.Color.Black
        Me.txtdescription.Location = New System.Drawing.Point(16, 198)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(192, 25)
        Me.txtdescription.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 11.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(13, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(16, 256)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(192, 25)
        Me.txtQuantity.TabIndex = 30
        Me.txtQuantity.Text = "0.00"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(227, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(348, 263)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lv_ri)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(340, 237)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ITEM  W/O QUANTITY"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(74, 9)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(260, 25)
        Me.txtSearch.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 11.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(9, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Search: "
        '
        'lv_ri
        '
        Me.lv_ri.Location = New System.Drawing.Point(6, 40)
        Me.lv_ri.Name = "lv_ri"
        Me.lv_ri.Size = New System.Drawing.Size(328, 191)
        Me.lv_ri.TabIndex = 0
        Me.lv_ri.UseCompatibleStateImageBehavior = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtSearch2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.lv_ii)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(340, 237)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ITEM WITH QUANTITY"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtSearch2
        '
        Me.txtSearch2.BackColor = System.Drawing.Color.White
        Me.txtSearch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch2.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtSearch2.ForeColor = System.Drawing.Color.Black
        Me.txtSearch2.Location = New System.Drawing.Point(74, 9)
        Me.txtSearch2.Name = "txtSearch2"
        Me.txtSearch2.Size = New System.Drawing.Size(260, 25)
        Me.txtSearch2.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 11.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(9, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Search: "
        '
        'lv_ii
        '
        Me.lv_ii.Location = New System.Drawing.Point(6, 40)
        Me.lv_ii.Name = "lv_ii"
        Me.lv_ii.Size = New System.Drawing.Size(328, 191)
        Me.lv_ii.TabIndex = 39
        Me.lv_ii.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 11.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Item Name: "
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.Transparent
        Me.btnSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSet.Location = New System.Drawing.Point(16, 287)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(95, 39)
        Me.btnSet.TabIndex = 26
        Me.btnSet.Text = "SET"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackColor = System.Drawing.Color.Transparent
        Me.btnCLEAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCLEAR.Location = New System.Drawing.Point(113, 287)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(95, 39)
        Me.btnCLEAR.TabIndex = 25
        Me.btnCLEAR.Text = "CLEAR"
        Me.btnCLEAR.UseVisualStyleBackColor = False
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Location = New System.Drawing.Point(16, 141)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(192, 25)
        Me.txtname.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(175, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "INVENTORY SETTING"
        '
        'frm_SetItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(583, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtIname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_SetItem"
        Me.txtIname.ResumeLayout(False)
        Me.txtIname.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIname As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lv_ri As System.Windows.Forms.ListView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtSearch2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lv_ii As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
End Class
