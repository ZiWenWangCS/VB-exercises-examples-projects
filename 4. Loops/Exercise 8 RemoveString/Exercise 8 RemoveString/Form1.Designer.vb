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
        Me.lblTextRemove = New System.Windows.Forms.Label()
        Me.txtEnterSentence = New System.Windows.Forms.TextBox()
        Me.txtRemove = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblRemovedSentence = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(20, 43)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(82, 13)
        Me.lblSentence.TabIndex = 0
        Me.lblSentence.Text = "Enter sentence:"
        '
        'lblTextRemove
        '
        Me.lblTextRemove.AutoSize = True
        Me.lblTextRemove.Location = New System.Drawing.Point(20, 82)
        Me.lblTextRemove.Name = "lblTextRemove"
        Me.lblTextRemove.Size = New System.Drawing.Size(105, 13)
        Me.lblTextRemove.TabIndex = 1
        Me.lblTextRemove.Text = "Enter text to remove:"
        '
        'txtEnterSentence
        '
        Me.txtEnterSentence.Location = New System.Drawing.Point(108, 40)
        Me.txtEnterSentence.Name = "txtEnterSentence"
        Me.txtEnterSentence.Size = New System.Drawing.Size(213, 20)
        Me.txtEnterSentence.TabIndex = 2
        '
        'txtRemove
        '
        Me.txtRemove.Location = New System.Drawing.Point(131, 79)
        Me.txtRemove.Name = "txtRemove"
        Me.txtRemove.Size = New System.Drawing.Size(190, 20)
        Me.txtRemove.TabIndex = 3
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(156, 148)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblRemovedSentence
        '
        Me.lblRemovedSentence.AutoSize = True
        Me.lblRemovedSentence.Location = New System.Drawing.Point(20, 205)
        Me.lblRemovedSentence.Name = "lblRemovedSentence"
        Me.lblRemovedSentence.Size = New System.Drawing.Size(0, 13)
        Me.lblRemovedSentence.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 261)
        Me.Controls.Add(Me.lblRemovedSentence)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtRemove)
        Me.Controls.Add(Me.txtEnterSentence)
        Me.Controls.Add(Me.lblTextRemove)
        Me.Controls.Add(Me.lblSentence)
        Me.Name = "Form1"
        Me.Text = "Remove String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSentence As Label
    Friend WithEvents lblTextRemove As Label
    Friend WithEvents txtEnterSentence As TextBox
    Friend WithEvents txtRemove As TextBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblRemovedSentence As Label
End Class
