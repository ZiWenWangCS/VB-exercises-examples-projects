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
        Me.picCurrent = New System.Windows.Forms.PictureBox()
        Me.tmrAnimate = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCurrent
        '
        Me.picCurrent.Location = New System.Drawing.Point(21, 23)
        Me.picCurrent.Name = "picCurrent"
        Me.picCurrent.Size = New System.Drawing.Size(252, 223)
        Me.picCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCurrent.TabIndex = 0
        Me.picCurrent.TabStop = False
        '
        'tmrAnimate
        '
        Me.tmrAnimate.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.picCurrent)
        Me.Name = "Form1"
        Me.Text = "Splash Animation"
        CType(Me.picCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCurrent As PictureBox
    Friend WithEvents tmrAnimate As Timer
End Class
