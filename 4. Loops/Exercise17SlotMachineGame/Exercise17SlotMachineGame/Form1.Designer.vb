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
        Me.lblRan1 = New System.Windows.Forms.Label()
        Me.lblRan2 = New System.Windows.Forms.Label()
        Me.lblRan3 = New System.Windows.Forms.Label()
        Me.lblTokens = New System.Windows.Forms.Label()
        Me.btnPull = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRan1
        '
        Me.lblRan1.AutoSize = True
        Me.lblRan1.Location = New System.Drawing.Point(45, 87)
        Me.lblRan1.Name = "lblRan1"
        Me.lblRan1.Size = New System.Drawing.Size(0, 13)
        Me.lblRan1.TabIndex = 0
        '
        'lblRan2
        '
        Me.lblRan2.AutoSize = True
        Me.lblRan2.Location = New System.Drawing.Point(103, 87)
        Me.lblRan2.Name = "lblRan2"
        Me.lblRan2.Size = New System.Drawing.Size(0, 13)
        Me.lblRan2.TabIndex = 1
        '
        'lblRan3
        '
        Me.lblRan3.AutoSize = True
        Me.lblRan3.Location = New System.Drawing.Point(194, 87)
        Me.lblRan3.Name = "lblRan3"
        Me.lblRan3.Size = New System.Drawing.Size(0, 13)
        Me.lblRan3.TabIndex = 2
        '
        'lblTokens
        '
        Me.lblTokens.AutoSize = True
        Me.lblTokens.Location = New System.Drawing.Point(101, 182)
        Me.lblTokens.Name = "lblTokens"
        Me.lblTokens.Size = New System.Drawing.Size(114, 13)
        Me.lblTokens.TabIndex = 3
        Me.lblTokens.Text = "Tokens you have: 100"
        '
        'btnPull
        '
        Me.btnPull.Location = New System.Drawing.Point(104, 226)
        Me.btnPull.Name = "btnPull"
        Me.btnPull.Size = New System.Drawing.Size(75, 23)
        Me.btnPull.TabIndex = 4
        Me.btnPull.Text = "Pull"
        Me.btnPull.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnPull)
        Me.Controls.Add(Me.lblTokens)
        Me.Controls.Add(Me.lblRan3)
        Me.Controls.Add(Me.lblRan2)
        Me.Controls.Add(Me.lblRan1)
        Me.Name = "Form1"
        Me.Text = "Slot Machine Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRan1 As Label
    Friend WithEvents lblRan2 As Label
    Friend WithEvents lblRan3 As Label
    Friend WithEvents lblTokens As Label
    Friend WithEvents btnPull As Button
End Class
