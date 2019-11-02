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
        Me.btnEnterName = New System.Windows.Forms.Button()
        Me.lblNumofName = New System.Windows.Forms.Label()
        Me.lblLongestName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterName
        '
        Me.btnEnterName.Location = New System.Drawing.Point(48, 79)
        Me.btnEnterName.Name = "btnEnterName"
        Me.btnEnterName.Size = New System.Drawing.Size(117, 23)
        Me.btnEnterName.TabIndex = 0
        Me.btnEnterName.Text = "Enter Names"
        Me.btnEnterName.UseVisualStyleBackColor = True
        '
        'lblNumofName
        '
        Me.lblNumofName.AutoSize = True
        Me.lblNumofName.Location = New System.Drawing.Point(80, 173)
        Me.lblNumofName.Name = "lblNumofName"
        Me.lblNumofName.Size = New System.Drawing.Size(0, 13)
        Me.lblNumofName.TabIndex = 1
        '
        'lblLongestName
        '
        Me.lblLongestName.AutoSize = True
        Me.lblLongestName.Location = New System.Drawing.Point(80, 209)
        Me.lblLongestName.Name = "lblLongestName"
        Me.lblLongestName.Size = New System.Drawing.Size(0, 13)
        Me.lblLongestName.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblLongestName)
        Me.Controls.Add(Me.lblNumofName)
        Me.Controls.Add(Me.btnEnterName)
        Me.Name = "Form1"
        Me.Text = "Names"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnterName As Button
    Friend WithEvents lblNumofName As Label
    Friend WithEvents lblLongestName As Label
End Class
