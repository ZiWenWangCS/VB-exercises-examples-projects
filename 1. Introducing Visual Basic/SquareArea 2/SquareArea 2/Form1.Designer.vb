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
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtSide = New System.Windows.Forms.TextBox()
        Me.bttnAnswer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(31, 74)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(128, 13)
        Me.lblAnswer.TabIndex = 0
        Me.lblAnswer.Text = "Enter the length of a side:"
        '
        'txtSide
        '
        Me.txtSide.Location = New System.Drawing.Point(165, 74)
        Me.txtSide.Name = "txtSide"
        Me.txtSide.Size = New System.Drawing.Size(100, 20)
        Me.txtSide.TabIndex = 1
        '
        'bttnAnswer
        '
        Me.bttnAnswer.Location = New System.Drawing.Point(106, 155)
        Me.bttnAnswer.Name = "bttnAnswer"
        Me.bttnAnswer.Size = New System.Drawing.Size(75, 23)
        Me.bttnAnswer.TabIndex = 2
        Me.bttnAnswer.Text = "Answer"
        Me.bttnAnswer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.bttnAnswer)
        Me.Controls.Add(Me.txtSide)
        Me.Controls.Add(Me.lblAnswer)
        Me.Name = "Form1"
        Me.Text = "Square Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtSide As TextBox
    Friend WithEvents bttnAnswer As Button
End Class
