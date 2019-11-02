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
        Me.lblNumberPrompt = New System.Windows.Forms.Label()
        Me.lblFactorialMessage = New System.Windows.Forms.Label()
        Me.lblFactorial = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnComputeFactorial = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumberPrompt
        '
        Me.lblNumberPrompt.AutoSize = True
        Me.lblNumberPrompt.Location = New System.Drawing.Point(40, 51)
        Me.lblNumberPrompt.Name = "lblNumberPrompt"
        Me.lblNumberPrompt.Size = New System.Drawing.Size(82, 13)
        Me.lblNumberPrompt.TabIndex = 0
        Me.lblNumberPrompt.Text = "Enter a number:"
        '
        'lblFactorialMessage
        '
        Me.lblFactorialMessage.AutoSize = True
        Me.lblFactorialMessage.Location = New System.Drawing.Point(107, 189)
        Me.lblFactorialMessage.Name = "lblFactorialMessage"
        Me.lblFactorialMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblFactorialMessage.TabIndex = 1
        '
        'lblFactorial
        '
        Me.lblFactorial.AutoSize = True
        Me.lblFactorial.Location = New System.Drawing.Point(188, 189)
        Me.lblFactorial.Name = "lblFactorial"
        Me.lblFactorial.Size = New System.Drawing.Size(0, 13)
        Me.lblFactorial.TabIndex = 2
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(128, 51)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 3
        '
        'btnComputeFactorial
        '
        Me.btnComputeFactorial.Location = New System.Drawing.Point(234, 48)
        Me.btnComputeFactorial.Name = "btnComputeFactorial"
        Me.btnComputeFactorial.Size = New System.Drawing.Size(75, 23)
        Me.btnComputeFactorial.TabIndex = 4
        Me.btnComputeFactorial.Text = "Compute Factorial"
        Me.btnComputeFactorial.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 261)
        Me.Controls.Add(Me.btnComputeFactorial)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblFactorial)
        Me.Controls.Add(Me.lblFactorialMessage)
        Me.Controls.Add(Me.lblNumberPrompt)
        Me.Name = "Form1"
        Me.Text = "Factorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumberPrompt As Label
    Friend WithEvents lblFactorialMessage As Label
    Friend WithEvents lblFactorial As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnComputeFactorial As Button
End Class
