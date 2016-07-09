<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_uploadexcel
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.btnSaves = New System.Windows.Forms.Button
        Me.dt_tbl = New System.Windows.Forms.DataGridView
        Me.btnUpload = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.lv_options = New System.Windows.Forms.ListView
        CType(Me.dt_tbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(203, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(8, 10)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(139, 24)
        Me.Label47.TabIndex = 73
        Me.Label47.Text = "Choose table:"
        '
        'btnSaves
        '
        Me.btnSaves.BackColor = System.Drawing.Color.Transparent
        Me.btnSaves.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaves.Location = New System.Drawing.Point(441, 37)
        Me.btnSaves.Name = "btnSaves"
        Me.btnSaves.Size = New System.Drawing.Size(120, 20)
        Me.btnSaves.TabIndex = 74
        Me.btnSaves.Text = "CHOOSE FILE"
        Me.btnSaves.UseVisualStyleBackColor = False
        '
        'dt_tbl
        '
        Me.dt_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_tbl.Location = New System.Drawing.Point(203, 63)
        Me.dt_tbl.Name = "dt_tbl"
        Me.dt_tbl.Size = New System.Drawing.Size(698, 394)
        Me.dt_tbl.TabIndex = 76
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Transparent
        Me.btnUpload.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpload.Location = New System.Drawing.Point(907, 359)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(103, 52)
        Me.btnUpload.TabIndex = 77
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(918, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 40)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lv_options
        '
        Me.lv_options.Location = New System.Drawing.Point(12, 37)
        Me.lv_options.Name = "lv_options"
        Me.lv_options.Size = New System.Drawing.Size(185, 420)
        Me.lv_options.TabIndex = 75
        Me.lv_options.UseCompatibleStateImageBehavior = False
        '
        'frm_uploadexcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(1022, 469)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.dt_tbl)
        Me.Controls.Add(Me.lv_options)
        Me.Controls.Add(Me.btnSaves)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_uploadexcel"
        CType(Me.dt_tbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents btnSaves As System.Windows.Forms.Button
    Friend WithEvents dt_tbl As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lv_options As System.Windows.Forms.ListView
End Class