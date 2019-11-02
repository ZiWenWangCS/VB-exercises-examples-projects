<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnHoneyDew = New System.Windows.Forms.Button()
        Me.btnThistle = New System.Windows.Forms.Button()
        Me.btnSkyBlue = New System.Windows.Forms.Button()
        Me.btnTurquoise = New System.Windows.Forms.Button()
        Me.btnDarkKhaki = New System.Windows.Forms.Button()
        Me.btnSalmon = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnChooseColor = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'btnHoneyDew
        '
        Me.btnHoneyDew.BackColor = System.Drawing.Color.Blue
        Me.btnHoneyDew.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHoneyDew.Location = New System.Drawing.Point(25, 68)
        Me.btnHoneyDew.Name = "btnHoneyDew"
        Me.btnHoneyDew.Size = New System.Drawing.Size(75, 23)
        Me.btnHoneyDew.TabIndex = 0
        Me.btnHoneyDew.Text = "Honeydew"
        Me.btnHoneyDew.UseVisualStyleBackColor = False
        '
        'btnThistle
        '
        Me.btnThistle.BackColor = System.Drawing.Color.Blue
        Me.btnThistle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnThistle.Location = New System.Drawing.Point(147, 68)
        Me.btnThistle.Name = "btnThistle"
        Me.btnThistle.Size = New System.Drawing.Size(75, 23)
        Me.btnThistle.TabIndex = 1
        Me.btnThistle.Text = "Thistle"
        Me.btnThistle.UseVisualStyleBackColor = False
        '
        'btnSkyBlue
        '
        Me.btnSkyBlue.BackColor = System.Drawing.Color.Blue
        Me.btnSkyBlue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSkyBlue.Location = New System.Drawing.Point(25, 117)
        Me.btnSkyBlue.Name = "btnSkyBlue"
        Me.btnSkyBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnSkyBlue.TabIndex = 2
        Me.btnSkyBlue.Text = "SkyBlue"
        Me.btnSkyBlue.UseVisualStyleBackColor = False
        '
        'btnTurquoise
        '
        Me.btnTurquoise.BackColor = System.Drawing.Color.Blue
        Me.btnTurquoise.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTurquoise.Location = New System.Drawing.Point(147, 117)
        Me.btnTurquoise.Name = "btnTurquoise"
        Me.btnTurquoise.Size = New System.Drawing.Size(75, 23)
        Me.btnTurquoise.TabIndex = 3
        Me.btnTurquoise.Text = "Turquoise"
        Me.btnTurquoise.UseVisualStyleBackColor = False
        '
        'btnDarkKhaki
        '
        Me.btnDarkKhaki.BackColor = System.Drawing.Color.Blue
        Me.btnDarkKhaki.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDarkKhaki.Location = New System.Drawing.Point(25, 162)
        Me.btnDarkKhaki.Name = "btnDarkKhaki"
        Me.btnDarkKhaki.Size = New System.Drawing.Size(75, 23)
        Me.btnDarkKhaki.TabIndex = 4
        Me.btnDarkKhaki.Text = "DarkKhaki"
        Me.btnDarkKhaki.UseVisualStyleBackColor = False
        '
        'btnSalmon
        '
        Me.btnSalmon.BackColor = System.Drawing.Color.Blue
        Me.btnSalmon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSalmon.Location = New System.Drawing.Point(147, 162)
        Me.btnSalmon.Name = "btnSalmon"
        Me.btnSalmon.Size = New System.Drawing.Size(75, 23)
        Me.btnSalmon.TabIndex = 5
        Me.btnSalmon.Text = "Salmon"
        Me.btnSalmon.UseVisualStyleBackColor = False
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(117, 211)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(16, 13)
        Me.lblPrompt.TabIndex = 6
        Me.lblPrompt.Text = "or"
        '
        'btnChooseColor
        '
        Me.btnChooseColor.BackColor = System.Drawing.Color.Blue
        Me.btnChooseColor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnChooseColor.Location = New System.Drawing.Point(91, 227)
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.Size = New System.Drawing.Size(75, 23)
        Me.btnChooseColor.TabIndex = 7
        Me.btnChooseColor.Text = "Choose Color"
        Me.btnChooseColor.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnChooseColor)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnSalmon)
        Me.Controls.Add(Me.btnDarkKhaki)
        Me.Controls.Add(Me.btnTurquoise)
        Me.Controls.Add(Me.btnSkyBlue)
        Me.Controls.Add(Me.btnThistle)
        Me.Controls.Add(Me.btnHoneyDew)
        Me.Name = "Form1"
        Me.Text = "Change Form Color"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHoneyDew As Button
    Friend WithEvents btnThistle As Button
    Friend WithEvents btnSkyBlue As Button
    Friend WithEvents btnTurquoise As Button
    Friend WithEvents btnDarkKhaki As Button
    Friend WithEvents btnSalmon As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnChooseColor As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
