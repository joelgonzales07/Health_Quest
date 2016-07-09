<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_request_item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_request_item))
        Me.gp_payment = New System.Windows.Forms.GroupBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lv_item = New System.Windows.Forms.ListView
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSaves = New System.Windows.Forms.Button
        Me.txtq = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.gp_payment.SuspendLayout()
        Me.SuspendLayout()
        '
        'gp_payment
        '
        Me.gp_payment.BackColor = System.Drawing.Color.Transparent
        Me.gp_payment.Controls.Add(Me.txtSearch)
        Me.gp_payment.Controls.Add(Me.Label1)
        Me.gp_payment.Controls.Add(Me.Button1)
        Me.gp_payment.Controls.Add(Me.lv_item)
        Me.gp_payment.Controls.Add(Me.Label4)
        Me.gp_payment.Controls.Add(Me.btnSaves)
        Me.gp_payment.Controls.Add(Me.txtq)
        Me.gp_payment.Location = New System.Drawing.Point(13, 32)
        Me.gp_payment.Name = "gp_payment"
        Me.gp_payment.Size = New System.Drawing.Size(642, 312)
        Me.gp_payment.TabIndex = 58
        Me.gp_payment.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtSearch.Location = New System.Drawing.Point(45, 37)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(237, 21)
        Me.txtSearch.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 18)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "SEARCH ITEM NAME:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(446, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 39)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lv_item
        '
        Me.lv_item.Location = New System.Drawing.Point(20, 64)
        Me.lv_item.Name = "lv_item"
        Me.lv_item.Size = New System.Drawing.Size(604, 179)
        Me.lv_item.TabIndex = 22
        Me.lv_item.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(17, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "QUANTITY:"
        '
        'btnSaves
        '
        Me.btnSaves.BackColor = System.Drawing.Color.Transparent
        Me.btnSaves.BackgroundImage = CType(resources.GetObject("btnSaves.BackgroundImage"), System.Drawing.Image)
        Me.btnSaves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaves.Location = New System.Drawing.Point(288, 259)
        Me.btnSaves.Name = "btnSaves"
        Me.btnSaves.Size = New System.Drawing.Size(152, 39)
        Me.btnSaves.TabIndex = 47
        Me.btnSaves.Text = "REQUEST"
        Me.btnSaves.UseVisualStyleBackColor = False
        '
        'txtq
        '
        Me.txtq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtq.Location = New System.Drawing.Point(45, 267)
        Me.txtq.Name = "txtq"
        Me.txtq.Size = New System.Drawing.Size(237, 21)
        Me.txtq.TabIndex = 59
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(12, 9)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(233, 24)
        Me.Label45.TabIndex = 59
        Me.Label45.Text = "INVENTORY REQUEST"
        '
        'frm_request_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(667, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.gp_payment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_request_item"
        Me.gp_payment.ResumeLayout(False)
        Me.gp_payment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gp_payment As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaves As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtq As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lv_item As System.Windows.Forms.ListView
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
