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
        Me.txtSentenceEntered = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnCountVowels = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(27, 51)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(59, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter Text:"
        '
        'txtSentenceEntered
        '
        Me.txtSentenceEntered.Location = New System.Drawing.Point(92, 44)
        Me.txtSentenceEntered.Name = "txtSentenceEntered"
        Me.txtSentenceEntered.Size = New System.Drawing.Size(100, 20)
        Me.txtSentenceEntered.TabIndex = 1
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(27, 105)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 2
        '
        'btnCountVowels
        '
        Me.btnCountVowels.Location = New System.Drawing.Point(92, 175)
        Me.btnCountVowels.Name = "btnCountVowels"
        Me.btnCountVowels.Size = New System.Drawing.Size(96, 20)
        Me.btnCountVowels.TabIndex = 3
        Me.btnCountVowels.Text = "Count Vowels"
        Me.btnCountVowels.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCountVowels)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtSentenceEntered)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Count Vowels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtSentenceEntered As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnCountVowels As Button
End Class
