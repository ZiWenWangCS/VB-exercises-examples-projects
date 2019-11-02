<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblWages = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.grpTaxes = New System.Windows.Forms.GroupBox()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.grpTaxes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(47, 52)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(102, 13)
        Me.lblHours.TabIndex = 0
        Me.lblHours.Text = "Enter hours worked:"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(47, 92)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(87, 13)
        Me.lblRate.TabIndex = 1
        Me.lblRate.Text = "Enter hourly rate:"
        '
        'lblWages
        '
        Me.lblWages.AutoSize = True
        Me.lblWages.Location = New System.Drawing.Point(47, 163)
        Me.lblWages.Name = "lblWages"
        Me.lblWages.Size = New System.Drawing.Size(0, 13)
        Me.lblWages.TabIndex = 2
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(161, 163)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 3
        Me.btnPay.Text = "Button1"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(161, 52)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 4
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(161, 92)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 5
        '
        'grpTaxes
        '
        Me.grpTaxes.Controls.Add(Me.radNo)
        Me.grpTaxes.Controls.Add(Me.radYes)
        Me.grpTaxes.Location = New System.Drawing.Point(145, 212)
        Me.grpTaxes.Name = "grpTaxes"
        Me.grpTaxes.Size = New System.Drawing.Size(127, 37)
        Me.grpTaxes.TabIndex = 6
        Me.grpTaxes.TabStop = False
        Me.grpTaxes.Text = "Exempt from taxes?"
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(1, 14)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(43, 17)
        Me.radYes.TabIndex = 0
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(50, 14)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(39, 17)
        Me.radNo.TabIndex = 1
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.grpTaxes)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblWages)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblHours)
        Me.Name = "Form1"
        Me.Text = "Payroll"
        Me.grpTaxes.ResumeLayout(False)
        Me.grpTaxes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHours As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblWages As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents grpTaxes As GroupBox
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
End Class
