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
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnPink = New System.Windows.Forms.Button()
        Me.btnOrange = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(12, 12)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(94, 69)
        Me.btnRed.TabIndex = 0
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'btnPink
        '
        Me.btnPink.Location = New System.Drawing.Point(178, 12)
        Me.btnPink.Name = "btnPink"
        Me.btnPink.Size = New System.Drawing.Size(94, 69)
        Me.btnPink.TabIndex = 1
        Me.btnPink.UseVisualStyleBackColor = True
        '
        'btnOrange
        '
        Me.btnOrange.Location = New System.Drawing.Point(12, 180)
        Me.btnOrange.Name = "btnOrange"
        Me.btnOrange.Size = New System.Drawing.Size(94, 69)
        Me.btnOrange.TabIndex = 2
        Me.btnOrange.UseVisualStyleBackColor = True
        '
        'btnGreen
        '
        Me.btnGreen.Location = New System.Drawing.Point(178, 180)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(94, 69)
        Me.btnGreen.TabIndex = 3
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnOrange)
        Me.Controls.Add(Me.btnPink)
        Me.Controls.Add(Me.btnRed)
        Me.Name = "Form1"
        Me.Text = "Change Image"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRed As Button
    Friend WithEvents btnPink As Button
    Friend WithEvents btnOrange As Button
    Friend WithEvents btnGreen As Button
End Class
