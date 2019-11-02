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
        Me.grpBand = New System.Windows.Forms.GroupBox()
        Me.radMarron5 = New System.Windows.Forms.RadioButton()
        Me.radFoofighters = New System.Windows.Forms.RadioButton()
        Me.radOnerepublic = New System.Windows.Forms.RadioButton()
        Me.lblBand = New System.Windows.Forms.Label()
        Me.grpBand.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBand
        '
        Me.grpBand.Controls.Add(Me.radOnerepublic)
        Me.grpBand.Controls.Add(Me.radFoofighters)
        Me.grpBand.Controls.Add(Me.radMarron5)
        Me.grpBand.Location = New System.Drawing.Point(12, 42)
        Me.grpBand.Name = "grpBand"
        Me.grpBand.Size = New System.Drawing.Size(119, 162)
        Me.grpBand.TabIndex = 0
        Me.grpBand.TabStop = False
        Me.grpBand.Text = "Select a Band"
        '
        'radMarron5
        '
        Me.radMarron5.AutoSize = True
        Me.radMarron5.Location = New System.Drawing.Point(6, 35)
        Me.radMarron5.Name = "radMarron5"
        Me.radMarron5.Size = New System.Drawing.Size(70, 17)
        Me.radMarron5.TabIndex = 1
        Me.radMarron5.TabStop = True
        Me.radMarron5.Text = "Maroon 5"
        Me.radMarron5.UseVisualStyleBackColor = True
        '
        'radFoofighters
        '
        Me.radFoofighters.AutoSize = True
        Me.radFoofighters.Location = New System.Drawing.Point(6, 58)
        Me.radFoofighters.Name = "radFoofighters"
        Me.radFoofighters.Size = New System.Drawing.Size(83, 17)
        Me.radFoofighters.TabIndex = 2
        Me.radFoofighters.TabStop = True
        Me.radFoofighters.Text = "Foo Fighters"
        Me.radFoofighters.UseVisualStyleBackColor = True
        '
        'radOnerepublic
        '
        Me.radOnerepublic.AutoSize = True
        Me.radOnerepublic.Location = New System.Drawing.Point(6, 81)
        Me.radOnerepublic.Name = "radOnerepublic"
        Me.radOnerepublic.Size = New System.Drawing.Size(87, 17)
        Me.radOnerepublic.TabIndex = 3
        Me.radOnerepublic.TabStop = True
        Me.radOnerepublic.Text = "OneRepublic"
        Me.radOnerepublic.UseVisualStyleBackColor = True
        '
        'lblBand
        '
        Me.lblBand.AutoSize = True
        Me.lblBand.Location = New System.Drawing.Point(156, 81)
        Me.lblBand.Name = "lblBand"
        Me.lblBand.Size = New System.Drawing.Size(0, 13)
        Me.lblBand.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblBand)
        Me.Controls.Add(Me.grpBand)
        Me.Name = "Form1"
        Me.Text = "Band Information"
        Me.grpBand.ResumeLayout(False)
        Me.grpBand.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBand As GroupBox
    Friend WithEvents radMarron5 As RadioButton
    Friend WithEvents radOnerepublic As RadioButton
    Friend WithEvents radFoofighters As RadioButton
    Friend WithEvents lblBand As Label
End Class
