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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtMaxValue = New System.Windows.Forms.TextBox()
        Me.lblSumMessage = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.btnSumOddNumbers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(24, 27)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(100, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = " Enter a number >1:"
        '
        'txtMaxValue
        '
        Me.txtMaxValue.Location = New System.Drawing.Point(127, 24)
        Me.txtMaxValue.Name = "txtMaxValue"
        Me.txtMaxValue.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxValue.TabIndex = 1
        '
        'lblSumMessage
        '
        Me.lblSumMessage.AutoSize = True
        Me.lblSumMessage.Location = New System.Drawing.Point(57, 144)
        Me.lblSumMessage.Name = "lblSumMessage"
        Me.lblSumMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblSumMessage.TabIndex = 2
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(147, 144)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 13)
        Me.lblSum.TabIndex = 3
        '
        'btnSumOddNumbers
        '
        Me.btnSumOddNumbers.Location = New System.Drawing.Point(107, 212)
        Me.btnSumOddNumbers.Name = "btnSumOddNumbers"
        Me.btnSumOddNumbers.Size = New System.Drawing.Size(75, 23)
        Me.btnSumOddNumbers.TabIndex = 4
        Me.btnSumOddNumbers.Text = "Sum Odd Numbers"
        Me.btnSumOddNumbers.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnSumOddNumbers)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.lblSumMessage)
        Me.Controls.Add(Me.txtMaxValue)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Odd Numbers Sum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtMaxValue As TextBox
    Friend WithEvents lblSumMessage As Label
    Friend WithEvents lblSum As Label
    Friend WithEvents btnSumOddNumbers As Button
End Class
