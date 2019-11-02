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
        Me.btnEnterTemperature = New System.Windows.Forms.Button()
        Me.lblAverageTemperature = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterTemperature
        '
        Me.btnEnterTemperature.Location = New System.Drawing.Point(29, 91)
        Me.btnEnterTemperature.Name = "btnEnterTemperature"
        Me.btnEnterTemperature.Size = New System.Drawing.Size(120, 23)
        Me.btnEnterTemperature.TabIndex = 0
        Me.btnEnterTemperature.Text = "Enter Temperature"
        Me.btnEnterTemperature.UseVisualStyleBackColor = True
        '
        'lblAverageTemperature
        '
        Me.lblAverageTemperature.AutoSize = True
        Me.lblAverageTemperature.Location = New System.Drawing.Point(62, 188)
        Me.lblAverageTemperature.Name = "lblAverageTemperature"
        Me.lblAverageTemperature.Size = New System.Drawing.Size(0, 13)
        Me.lblAverageTemperature.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblAverageTemperature)
        Me.Controls.Add(Me.btnEnterTemperature)
        Me.Name = "Form1"
        Me.Text = "Average Temperature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnterTemperature As Button
    Friend WithEvents lblAverageTemperature As Label
End Class
