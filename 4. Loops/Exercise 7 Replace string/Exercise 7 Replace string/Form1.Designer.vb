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
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.lblReplace = New System.Windows.Forms.Label()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.txtSearchText = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(38, 52)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(82, 13)
        Me.lblSentence.TabIndex = 0
        Me.lblSentence.Text = "Enter sentence:"
        '
        'lblSearchText
        '
        Me.lblSearchText.AutoSize = True
        Me.lblSearchText.Location = New System.Drawing.Point(38, 96)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(90, 13)
        Me.lblSearchText.TabIndex = 1
        Me.lblSearchText.Text = "Enter search text:"
        '
        'lblReplace
        '
        Me.lblReplace.AutoSize = True
        Me.lblReplace.Location = New System.Drawing.Point(38, 139)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(93, 13)
        Me.lblReplace.TabIndex = 2
        Me.lblReplace.Text = "Enter replace text:"
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(126, 52)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(281, 20)
        Me.txtSentence.TabIndex = 3
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(134, 96)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(124, 20)
        Me.txtSearchText.TabIndex = 4
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(137, 139)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(121, 20)
        Me.txtReplace.TabIndex = 5
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(138, 221)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 6
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(376, 195)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 7
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 261)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.txtSearchText)
        Me.Controls.Add(Me.txtSentence)
        Me.Controls.Add(Me.lblReplace)
        Me.Controls.Add(Me.lblSearchText)
        Me.Controls.Add(Me.lblSentence)
        Me.Name = "Form1"
        Me.Text = "Replace String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSentence As Label
    Friend WithEvents lblSearchText As Label
    Friend WithEvents lblReplace As Label
    Friend WithEvents txtSentence As TextBox
    Friend WithEvents txtSearchText As TextBox
    Friend WithEvents txtReplace As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnReplace As Button
End Class
