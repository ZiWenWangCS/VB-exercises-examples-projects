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
        Me.components = New System.ComponentModel.Container()
        Me.btnHappy = New System.Windows.Forms.Button()
        Me.btnSad = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tmrWink = New System.Windows.Forms.Timer(Me.components)
        Me.btnWink = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHappy
        '
        Me.btnHappy.Location = New System.Drawing.Point(12, 12)
        Me.btnHappy.Name = "btnHappy"
        Me.btnHappy.Size = New System.Drawing.Size(50, 23)
        Me.btnHappy.TabIndex = 0
        Me.btnHappy.Text = "Happy"
        Me.btnHappy.UseVisualStyleBackColor = True
        '
        'btnSad
        '
        Me.btnSad.Location = New System.Drawing.Point(206, 12)
        Me.btnSad.Name = "btnSad"
        Me.btnSad.Size = New System.Drawing.Size(46, 23)
        Me.btnSad.TabIndex = 1
        Me.btnSad.Text = "Sad"
        Me.btnSad.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(68, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(61, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tmrWink
        '
        Me.tmrWink.Interval = 500
        '
        'btnWink
        '
        Me.btnWink.Location = New System.Drawing.Point(142, 12)
        Me.btnWink.Name = "btnWink"
        Me.btnWink.Size = New System.Drawing.Size(53, 23)
        Me.btnWink.TabIndex = 3
        Me.btnWink.Text = "Wink"
        Me.btnWink.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnWink)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSad)
        Me.Controls.Add(Me.btnHappy)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHappy As Button
    Friend WithEvents btnSad As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents tmrWink As Timer
    Friend WithEvents btnWink As Button
End Class
