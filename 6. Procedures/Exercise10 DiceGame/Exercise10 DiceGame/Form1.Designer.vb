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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.picDice1 = New System.Windows.Forms.PictureBox()
        Me.picDice2 = New System.Windows.Forms.PictureBox()
        Me.lblTotalPoints = New System.Windows.Forms.Label()
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(30, 65)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(102, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter points to Risk:"
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(242, 58)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(88, 27)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "Roll Dice"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'txtPoints
        '
        Me.txtPoints.Location = New System.Drawing.Point(136, 62)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(68, 20)
        Me.txtPoints.TabIndex = 2
        '
        'picDice1
        '
        Me.picDice1.Location = New System.Drawing.Point(33, 141)
        Me.picDice1.Name = "picDice1"
        Me.picDice1.Size = New System.Drawing.Size(100, 93)
        Me.picDice1.TabIndex = 3
        Me.picDice1.TabStop = False
        '
        'picDice2
        '
        Me.picDice2.Location = New System.Drawing.Point(154, 141)
        Me.picDice2.Name = "picDice2"
        Me.picDice2.Size = New System.Drawing.Size(100, 93)
        Me.picDice2.TabIndex = 4
        Me.picDice2.TabStop = False
        '
        'lblTotalPoints
        '
        Me.lblTotalPoints.AutoSize = True
        Me.lblTotalPoints.Location = New System.Drawing.Point(291, 179)
        Me.lblTotalPoints.Name = "lblTotalPoints"
        Me.lblTotalPoints.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalPoints.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 263)
        Me.Controls.Add(Me.lblTotalPoints)
        Me.Controls.Add(Me.picDice2)
        Me.Controls.Add(Me.picDice1)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Dice Game"
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnRoll As Button
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents picDice1 As PictureBox
    Friend WithEvents picDice2 As PictureBox
    Friend WithEvents lblTotalPoints As Label
End Class
