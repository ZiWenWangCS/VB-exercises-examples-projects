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
        Me.txtGuess1 = New System.Windows.Forms.TextBox()
        Me.txtGuess2 = New System.Windows.Forms.TextBox()
        Me.txtGuess3 = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblColorCorrect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtGuess1
        '
        Me.txtGuess1.Location = New System.Drawing.Point(12, 60)
        Me.txtGuess1.Name = "txtGuess1"
        Me.txtGuess1.Size = New System.Drawing.Size(29, 20)
        Me.txtGuess1.TabIndex = 0
        '
        'txtGuess2
        '
        Me.txtGuess2.Location = New System.Drawing.Point(47, 60)
        Me.txtGuess2.Name = "txtGuess2"
        Me.txtGuess2.Size = New System.Drawing.Size(29, 20)
        Me.txtGuess2.TabIndex = 1
        '
        'txtGuess3
        '
        Me.txtGuess3.Location = New System.Drawing.Point(82, 60)
        Me.txtGuess3.Name = "txtGuess3"
        Me.txtGuess3.Size = New System.Drawing.Size(29, 20)
        Me.txtGuess3.TabIndex = 2
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(50, 157)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(47, 228)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(0, 13)
        Me.lblPosition.TabIndex = 4
        '
        'lblColorCorrect
        '
        Me.lblColorCorrect.AutoSize = True
        Me.lblColorCorrect.Location = New System.Drawing.Point(44, 199)
        Me.lblColorCorrect.Name = "lblColorCorrect"
        Me.lblColorCorrect.Size = New System.Drawing.Size(0, 13)
        Me.lblColorCorrect.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblColorCorrect)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtGuess3)
        Me.Controls.Add(Me.txtGuess2)
        Me.Controls.Add(Me.txtGuess1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGuess1 As TextBox
    Friend WithEvents txtGuess2 As TextBox
    Friend WithEvents txtGuess3 As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblColorCorrect As Label
End Class
