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
        Me.btnEnterCities = New System.Windows.Forms.Button()
        Me.lblNumofCities = New System.Windows.Forms.Label()
        Me.lblLongestCities = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterCities
        '
        Me.btnEnterCities.Location = New System.Drawing.Point(38, 69)
        Me.btnEnterCities.Name = "btnEnterCities"
        Me.btnEnterCities.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterCities.TabIndex = 0
        Me.btnEnterCities.Text = "Enter Cities"
        Me.btnEnterCities.UseVisualStyleBackColor = True
        '
        'lblNumofCities
        '
        Me.lblNumofCities.AutoSize = True
        Me.lblNumofCities.Location = New System.Drawing.Point(51, 157)
        Me.lblNumofCities.Name = "lblNumofCities"
        Me.lblNumofCities.Size = New System.Drawing.Size(0, 13)
        Me.lblNumofCities.TabIndex = 1
        '
        'lblLongestCities
        '
        Me.lblLongestCities.AutoSize = True
        Me.lblLongestCities.Location = New System.Drawing.Point(51, 202)
        Me.lblLongestCities.Name = "lblLongestCities"
        Me.lblLongestCities.Size = New System.Drawing.Size(0, 13)
        Me.lblLongestCities.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblLongestCities)
        Me.Controls.Add(Me.lblNumofCities)
        Me.Controls.Add(Me.btnEnterCities)
        Me.Name = "Form1"
        Me.Text = "Cities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnterCities As Button
    Friend WithEvents lblNumofCities As Label
    Friend WithEvents lblLongestCities As Label
End Class
