<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mntr_sales
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
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFrom = New System.Windows.Forms.DateTimePicker
        Me.rdbtnSpecDate = New System.Windows.Forms.RadioButton
        Me.rdbtnWeek = New System.Windows.Forms.RadioButton
        Me.rdbtnMonth = New System.Windows.Forms.RadioButton
        Me.panelSpecDate = New System.Windows.Forms.Panel
        Me.dtDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.panelWeekly = New System.Windows.Forms.Panel
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.panelMonthly = New System.Windows.Forms.Panel
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.panelSpecDate.SuspendLayout()
        Me.panelWeekly.SuspendLayout()
        Me.panelMonthly.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(12, 9)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(166, 24)
        Me.Label47.TabIndex = 73
        Me.Label47.Text = "Sales Monitoring"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(33, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 18)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "Choose type of report:"
        '
        'dtFrom
        '
        Me.dtFrom.Location = New System.Drawing.Point(73, 37)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(247, 20)
        Me.dtFrom.TabIndex = 214
        '
        'rdbtnSpecDate
        '
        Me.rdbtnSpecDate.AutoSize = True
        Me.rdbtnSpecDate.BackColor = System.Drawing.Color.Transparent
        Me.rdbtnSpecDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rdbtnSpecDate.Location = New System.Drawing.Point(395, 41)
        Me.rdbtnSpecDate.Name = "rdbtnSpecDate"
        Me.rdbtnSpecDate.Size = New System.Drawing.Size(126, 22)
        Me.rdbtnSpecDate.TabIndex = 215
        Me.rdbtnSpecDate.Text = "Specific Date"
        Me.rdbtnSpecDate.UseVisualStyleBackColor = False
        '
        'rdbtnWeek
        '
        Me.rdbtnWeek.AutoSize = True
        Me.rdbtnWeek.BackColor = System.Drawing.Color.Transparent
        Me.rdbtnWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rdbtnWeek.Location = New System.Drawing.Point(308, 41)
        Me.rdbtnWeek.Name = "rdbtnWeek"
        Me.rdbtnWeek.Size = New System.Drawing.Size(81, 22)
        Me.rdbtnWeek.TabIndex = 216
        Me.rdbtnWeek.Text = "Weekly"
        Me.rdbtnWeek.UseVisualStyleBackColor = False
        '
        'rdbtnMonth
        '
        Me.rdbtnMonth.AutoSize = True
        Me.rdbtnMonth.BackColor = System.Drawing.Color.Transparent
        Me.rdbtnMonth.Checked = True
        Me.rdbtnMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rdbtnMonth.Location = New System.Drawing.Point(217, 41)
        Me.rdbtnMonth.Name = "rdbtnMonth"
        Me.rdbtnMonth.Size = New System.Drawing.Size(85, 22)
        Me.rdbtnMonth.TabIndex = 217
        Me.rdbtnMonth.TabStop = True
        Me.rdbtnMonth.Text = "Monthly"
        Me.rdbtnMonth.UseVisualStyleBackColor = False
        '
        'panelSpecDate
        '
        Me.panelSpecDate.BackColor = System.Drawing.Color.Transparent
        Me.panelSpecDate.Controls.Add(Me.dtDate)
        Me.panelSpecDate.Controls.Add(Me.Label7)
        Me.panelSpecDate.Location = New System.Drawing.Point(36, 69)
        Me.panelSpecDate.Name = "panelSpecDate"
        Me.panelSpecDate.Size = New System.Drawing.Size(375, 51)
        Me.panelSpecDate.TabIndex = 218
        Me.panelSpecDate.Visible = False
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(118, 10)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(247, 20)
        Me.dtDate.TabIndex = 217
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(3, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 18)
        Me.Label7.TabIndex = 216
        Me.Label7.Text = "Choose date:"
        '
        'panelWeekly
        '
        Me.panelWeekly.BackColor = System.Drawing.Color.Transparent
        Me.panelWeekly.Controls.Add(Me.dtTo)
        Me.panelWeekly.Controls.Add(Me.Label6)
        Me.panelWeekly.Controls.Add(Me.Label5)
        Me.panelWeekly.Controls.Add(Me.Label4)
        Me.panelWeekly.Controls.Add(Me.dtFrom)
        Me.panelWeekly.Location = New System.Drawing.Point(36, 69)
        Me.panelWeekly.Name = "panelWeekly"
        Me.panelWeekly.Size = New System.Drawing.Size(333, 104)
        Me.panelWeekly.TabIndex = 219
        Me.panelWeekly.Visible = False
        '
        'dtTo
        '
        Me.dtTo.Location = New System.Drawing.Point(73, 68)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(247, 20)
        Me.dtTo.TabIndex = 218
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(14, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 18)
        Me.Label6.TabIndex = 217
        Me.Label6.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(14, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 216
        Me.Label5.Text = "From:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(3, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "Select range:"
        '
        'panelMonthly
        '
        Me.panelMonthly.BackColor = System.Drawing.Color.Transparent
        Me.panelMonthly.Controls.Add(Me.cboYear)
        Me.panelMonthly.Controls.Add(Me.Label3)
        Me.panelMonthly.Controls.Add(Me.cboMonth)
        Me.panelMonthly.Controls.Add(Me.Label1)
        Me.panelMonthly.Location = New System.Drawing.Point(36, 69)
        Me.panelMonthly.Name = "panelMonthly"
        Me.panelMonthly.Size = New System.Drawing.Size(375, 45)
        Me.panelMonthly.TabIndex = 220
        '
        'cboYear
        '
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(249, 9)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 26)
        Me.cboYear.TabIndex = 217
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(196, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "Year:"
        '
        'cboMonth
        '
        Me.cboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(69, 9)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 26)
        Me.cboMonth.TabIndex = 215
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "Month:"
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnPreview.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPreview.Location = New System.Drawing.Point(527, 41)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(160, 50)
        Me.btnPreview.TabIndex = 221
        Me.btnPreview.Text = "PREVIEW"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(36, 179)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(982, 507)
        Me.CrystalReportViewer1.TabIndex = 222
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(693, 41)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 50)
        Me.btnClear.TabIndex = 223
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(859, 41)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(160, 50)
        Me.btnClose.TabIndex = 224
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(488, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 24)
        Me.Label8.TabIndex = 225
        Me.Label8.Text = "Sales Report"
        '
        'mntr_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = Global.Health_Quest.My.Resources.Resources.bgMain
        Me.ClientSize = New System.Drawing.Size(1030, 698)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.panelMonthly)
        Me.Controls.Add(Me.panelWeekly)
        Me.Controls.Add(Me.panelSpecDate)
        Me.Controls.Add(Me.rdbtnMonth)
        Me.Controls.Add(Me.rdbtnWeek)
        Me.Controls.Add(Me.rdbtnSpecDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label47)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mntr_sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelSpecDate.ResumeLayout(False)
        Me.panelSpecDate.PerformLayout()
        Me.panelWeekly.ResumeLayout(False)
        Me.panelWeekly.PerformLayout()
        Me.panelMonthly.ResumeLayout(False)
        Me.panelMonthly.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbtnSpecDate As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnWeek As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnMonth As System.Windows.Forms.RadioButton
    Friend WithEvents panelSpecDate As System.Windows.Forms.Panel
    Friend WithEvents panelWeekly As System.Windows.Forms.Panel
    Friend WithEvents panelMonthly As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
