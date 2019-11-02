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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picSquare = New System.Windows.Forms.PictureBox()
        Me.tmrLevels = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSquare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Location = New System.Drawing.Point(128, 46)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 13)
        Me.lblScore.TabIndex = 1
        '
        'picSquare
        '
        Me.picSquare.BackColor = System.Drawing.Color.Black
        Me.picSquare.Cursor = System.Windows.Forms.Cursors.Default
        Me.picSquare.Location = New System.Drawing.Point(95, 170)
        Me.picSquare.Name = "picSquare"
        Me.picSquare.Size = New System.Drawing.Size(20, 20)
        Me.picSquare.TabIndex = 6
        Me.picSquare.TabStop = False
        '
        'tmrLevels
        '
        Me.tmrLevels.Enabled = True
        Me.tmrLevels.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 261)
        Me.Controls.Add(Me.picSquare)
        Me.Controls.Add(Me.lblScore)
        Me.Name = "Form1"
        Me.Text = "Catch The Square"
        CType(Me.picSquare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore As Label
    Friend WithEvents picSquare As PictureBox
    Friend WithEvents tmrLevels As Timer
End Class
