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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblFirstdigit = New System.Windows.Forms.Label()
        Me.lblSeconddigit = New System.Windows.Forms.Label()
        Me.btnDigits = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(43, 38)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(124, 13)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Enter a two-digit number:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(173, 38)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(68, 20)
        Me.txtNumber.TabIndex = 1
        '
        'lblFirstdigit
        '
        Me.lblFirstdigit.AutoSize = True
        Me.lblFirstdigit.Location = New System.Drawing.Point(43, 89)
        Me.lblFirstdigit.Name = "lblFirstdigit"
        Me.lblFirstdigit.Size = New System.Drawing.Size(0, 13)
        Me.lblFirstdigit.TabIndex = 2
        '
        'lblSeconddigit
        '
        Me.lblSeconddigit.AutoSize = True
        Me.lblSeconddigit.Location = New System.Drawing.Point(43, 122)
        Me.lblSeconddigit.Name = "lblSeconddigit"
        Me.lblSeconddigit.Size = New System.Drawing.Size(0, 13)
        Me.lblSeconddigit.TabIndex = 3
        '
        'btnDigits
        '
        Me.btnDigits.Location = New System.Drawing.Point(102, 179)
        Me.btnDigits.Name = "btnDigits"
        Me.btnDigits.Size = New System.Drawing.Size(76, 25)
        Me.btnDigits.TabIndex = 4
        Me.btnDigits.Text = "Digits"
        Me.btnDigits.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDigits)
        Me.Controls.Add(Me.lblSeconddigit)
        Me.Controls.Add(Me.lblFirstdigit)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "Form1"
        Me.Text = "Digits of a Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblFirstdigit As Label
    Friend WithEvents lblSeconddigit As Label
    Friend WithEvents btnDigits As Button
End Class
