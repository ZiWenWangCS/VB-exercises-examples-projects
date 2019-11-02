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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.picShape0 = New System.Windows.Forms.PictureBox()
        Me.picShape1 = New System.Windows.Forms.PictureBox()
        Me.picShape2 = New System.Windows.Forms.PictureBox()
        Me.picShape3 = New System.Windows.Forms.PictureBox()
        Me.picShape4 = New System.Windows.Forms.PictureBox()
        Me.picShape5 = New System.Windows.Forms.PictureBox()
        Me.tmrShowShape = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLength = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picShape0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(286, 226)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'picShape0
        '
        Me.picShape0.Location = New System.Drawing.Point(12, 69)
        Me.picShape0.Name = "picShape0"
        Me.picShape0.Size = New System.Drawing.Size(100, 50)
        Me.picShape0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape0.TabIndex = 1
        Me.picShape0.TabStop = False
        Me.picShape0.Tag = "0"
        '
        'picShape1
        '
        Me.picShape1.Location = New System.Drawing.Point(118, 69)
        Me.picShape1.Name = "picShape1"
        Me.picShape1.Size = New System.Drawing.Size(100, 50)
        Me.picShape1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape1.TabIndex = 2
        Me.picShape1.TabStop = False
        Me.picShape1.Tag = "1"
        '
        'picShape2
        '
        Me.picShape2.Location = New System.Drawing.Point(224, 69)
        Me.picShape2.Name = "picShape2"
        Me.picShape2.Size = New System.Drawing.Size(100, 50)
        Me.picShape2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape2.TabIndex = 3
        Me.picShape2.TabStop = False
        Me.picShape2.Tag = "2"
        '
        'picShape3
        '
        Me.picShape3.Location = New System.Drawing.Point(330, 69)
        Me.picShape3.Name = "picShape3"
        Me.picShape3.Size = New System.Drawing.Size(100, 50)
        Me.picShape3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape3.TabIndex = 4
        Me.picShape3.TabStop = False
        Me.picShape3.Tag = "3"
        '
        'picShape4
        '
        Me.picShape4.Location = New System.Drawing.Point(436, 69)
        Me.picShape4.Name = "picShape4"
        Me.picShape4.Size = New System.Drawing.Size(100, 50)
        Me.picShape4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape4.TabIndex = 5
        Me.picShape4.TabStop = False
        Me.picShape4.Tag = "4"
        '
        'picShape5
        '
        Me.picShape5.Location = New System.Drawing.Point(542, 69)
        Me.picShape5.Name = "picShape5"
        Me.picShape5.Size = New System.Drawing.Size(100, 50)
        Me.picShape5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape5.TabIndex = 6
        Me.picShape5.TabStop = False
        Me.picShape5.Tag = "5"
        '
        'tmrShowShape
        '
        Me.tmrShowShape.Interval = 1000
        '
        'tmrGameLength
        '
        Me.tmrGameLength.Interval = 10000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Blue Traingle +5 score" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Red Diamond -3score" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pink Circle +10 score"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picShape5)
        Me.Controls.Add(Me.picShape4)
        Me.Controls.Add(Me.picShape3)
        Me.Controls.Add(Me.picShape2)
        Me.Controls.Add(Me.picShape1)
        Me.Controls.Add(Me.picShape0)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Click It!"
        CType(Me.picShape0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents picShape0 As PictureBox
    Friend WithEvents picShape1 As PictureBox
    Friend WithEvents picShape2 As PictureBox
    Friend WithEvents picShape3 As PictureBox
    Friend WithEvents picShape4 As PictureBox
    Friend WithEvents picShape5 As PictureBox
    Friend WithEvents tmrShowShape As Timer
    Friend WithEvents tmrGameLength As Timer
    Friend WithEvents Label1 As Label
End Class
