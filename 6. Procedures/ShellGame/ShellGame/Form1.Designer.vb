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
        Me.picShell1 = New System.Windows.Forms.PictureBox()
        Me.picShell2 = New System.Windows.Forms.PictureBox()
        Me.picShell3 = New System.Windows.Forms.PictureBox()
        Me.picPearl1 = New System.Windows.Forms.PictureBox()
        Me.picPearl2 = New System.Windows.Forms.PictureBox()
        Me.picPearl3 = New System.Windows.Forms.PictureBox()
        CType(Me.picShell1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShell2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShell3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPearl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPearl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPearl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picShell1
        '
        Me.picShell1.Image = Global.ShellGame.My.Resources.Resources.shell
        Me.picShell1.Location = New System.Drawing.Point(31, 69)
        Me.picShell1.Name = "picShell1"
        Me.picShell1.Size = New System.Drawing.Size(110, 110)
        Me.picShell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShell1.TabIndex = 0
        Me.picShell1.TabStop = False
        Me.picShell1.Tag = "1"
        '
        'picShell2
        '
        Me.picShell2.Image = Global.ShellGame.My.Resources.Resources.shell
        Me.picShell2.Location = New System.Drawing.Point(191, 69)
        Me.picShell2.Name = "picShell2"
        Me.picShell2.Size = New System.Drawing.Size(110, 110)
        Me.picShell2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShell2.TabIndex = 1
        Me.picShell2.TabStop = False
        Me.picShell2.Tag = "2"
        '
        'picShell3
        '
        Me.picShell3.Image = Global.ShellGame.My.Resources.Resources.shell
        Me.picShell3.Location = New System.Drawing.Point(336, 69)
        Me.picShell3.Name = "picShell3"
        Me.picShell3.Size = New System.Drawing.Size(110, 110)
        Me.picShell3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShell3.TabIndex = 2
        Me.picShell3.TabStop = False
        Me.picShell3.Tag = "3"
        '
        'picPearl1
        '
        Me.picPearl1.Image = Global.ShellGame.My.Resources.Resources.pearl
        Me.picPearl1.Location = New System.Drawing.Point(67, 202)
        Me.picPearl1.Name = "picPearl1"
        Me.picPearl1.Size = New System.Drawing.Size(32, 32)
        Me.picPearl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPearl1.TabIndex = 3
        Me.picPearl1.TabStop = False
        Me.picPearl1.Tag = "1"
        Me.picPearl1.Visible = False
        '
        'picPearl2
        '
        Me.picPearl2.Image = Global.ShellGame.My.Resources.Resources.pearl
        Me.picPearl2.Location = New System.Drawing.Point(224, 202)
        Me.picPearl2.Name = "picPearl2"
        Me.picPearl2.Size = New System.Drawing.Size(32, 32)
        Me.picPearl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPearl2.TabIndex = 4
        Me.picPearl2.TabStop = False
        Me.picPearl2.Tag = "2"
        Me.picPearl2.Visible = False
        '
        'picPearl3
        '
        Me.picPearl3.Image = Global.ShellGame.My.Resources.Resources.pearl
        Me.picPearl3.Location = New System.Drawing.Point(381, 202)
        Me.picPearl3.Name = "picPearl3"
        Me.picPearl3.Size = New System.Drawing.Size(32, 32)
        Me.picPearl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPearl3.TabIndex = 5
        Me.picPearl3.TabStop = False
        Me.picPearl3.Tag = "3"
        Me.picPearl3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 261)
        Me.Controls.Add(Me.picPearl3)
        Me.Controls.Add(Me.picPearl2)
        Me.Controls.Add(Me.picPearl1)
        Me.Controls.Add(Me.picShell3)
        Me.Controls.Add(Me.picShell2)
        Me.Controls.Add(Me.picShell1)
        Me.Name = "Form1"
        Me.Text = "Shell Game"
        CType(Me.picShell1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShell2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShell3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPearl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPearl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPearl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picShell1 As PictureBox
    Friend WithEvents picShell2 As PictureBox
    Friend WithEvents picShell3 As PictureBox
    Friend WithEvents picPearl1 As PictureBox
    Friend WithEvents picPearl2 As PictureBox
    Friend WithEvents picPearl3 As PictureBox
End Class
