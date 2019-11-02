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
        Me.lblPromptBox = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.lblPromptLetter = New System.Windows.Forms.Label()
        Me.txtSearchText = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnCountLetter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPromptBox
        '
        Me.lblPromptBox.AutoSize = True
        Me.lblPromptBox.Location = New System.Drawing.Point(36, 61)
        Me.lblPromptBox.Name = "lblPromptBox"
        Me.lblPromptBox.Size = New System.Drawing.Size(55, 13)
        Me.lblPromptBox.TabIndex = 0
        Me.lblPromptBox.Text = "Enter text:"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(35, 188)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 1
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(97, 58)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(100, 20)
        Me.txtText.TabIndex = 2
        '
        'lblPromptLetter
        '
        Me.lblPromptLetter.AutoSize = True
        Me.lblPromptLetter.Location = New System.Drawing.Point(274, 61)
        Me.lblPromptLetter.Name = "lblPromptLetter"
        Me.lblPromptLetter.Size = New System.Drawing.Size(123, 13)
        Me.lblPromptLetter.TabIndex = 3
        Me.lblPromptLetter.Text = "Enter letter to search for:"
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(403, 61)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(25, 20)
        Me.txtSearchText.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(216, 193)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 5
        '
        'btnCountLetter
        '
        Me.btnCountLetter.Location = New System.Drawing.Point(342, 188)
        Me.btnCountLetter.Name = "btnCountLetter"
        Me.btnCountLetter.Size = New System.Drawing.Size(75, 23)
        Me.btnCountLetter.TabIndex = 6
        Me.btnCountLetter.Text = "Count Letter"
        Me.btnCountLetter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 261)
        Me.Controls.Add(Me.btnCountLetter)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtSearchText)
        Me.Controls.Add(Me.lblPromptLetter)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblPromptBox)
        Me.Name = "Form1"
        Me.Text = "Letter Count"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPromptBox As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents lblPromptLetter As Label
    Friend WithEvents txtSearchText As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnCountLetter As Button
End Class
