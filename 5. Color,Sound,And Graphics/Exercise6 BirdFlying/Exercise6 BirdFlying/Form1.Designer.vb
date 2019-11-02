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
        Me.tmrAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.picCurrentImage = New System.Windows.Forms.PictureBox()
        Me.tmrAudio = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCurrentImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrAnimate
        '
        Me.tmrAnimate.Enabled = True
        Me.tmrAnimate.Interval = 500
        '
        'picCurrentImage
        '
        Me.picCurrentImage.Location = New System.Drawing.Point(4, 12)
        Me.picCurrentImage.Name = "picCurrentImage"
        Me.picCurrentImage.Size = New System.Drawing.Size(277, 237)
        Me.picCurrentImage.TabIndex = 0
        Me.picCurrentImage.TabStop = False
        '
        'tmrAudio
        '
        Me.tmrAudio.Enabled = True
        Me.tmrAudio.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 279)
        Me.Controls.Add(Me.picCurrentImage)
        Me.Name = "Form1"
        Me.Text = "Bird Flying"
        CType(Me.picCurrentImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmrAnimate As Timer
    Friend WithEvents picCurrentImage As PictureBox
    Friend WithEvents tmrAudio As Timer
End Class
