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
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.lblTitles = New System.Windows.Forms.Label()
        Me.radOption1 = New System.Windows.Forms.RadioButton()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.radNothing = New System.Windows.Forms.RadioButton()
        Me.radOption2 = New System.Windows.Forms.RadioButton()
        Me.lblPrompts = New System.Windows.Forms.Label()
        Me.picGraphics2 = New System.Windows.Forms.PictureBox()
        Me.picGraphics1 = New System.Windows.Forms.PictureBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnContinueF1 = New System.Windows.Forms.Button()
        Me.btnContinueF2 = New System.Windows.Forms.Button()
        Me.btnContinueF3 = New System.Windows.Forms.Button()
        Me.btnContinueF4 = New System.Windows.Forms.Button()
        Me.grpOptions.SuspendLayout()
        CType(Me.picGraphics2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGraphics1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewGame
        '
        Me.btnNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(906, 75)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(171, 48)
        Me.btnNewGame.TabIndex = 0
        Me.btnNewGame.Text = "Start Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'lblTitles
        '
        Me.lblTitles.AutoSize = True
        Me.lblTitles.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitles.Location = New System.Drawing.Point(479, 23)
        Me.lblTitles.Name = "lblTitles"
        Me.lblTitles.Size = New System.Drawing.Size(475, 29)
        Me.lblTitles.TabIndex = 1
        Me.lblTitles.Text = "Welcome to Super Mack Man's Adventures!"
        '
        'radOption1
        '
        Me.radOption1.AutoSize = True
        Me.radOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOption1.Location = New System.Drawing.Point(20, 39)
        Me.radOption1.Name = "radOption1"
        Me.radOption1.Size = New System.Drawing.Size(121, 28)
        Me.radOption1.TabIndex = 2
        Me.radOption1.Text = "radOption1"
        Me.radOption1.UseVisualStyleBackColor = True
        Me.radOption1.Visible = False
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.radNothing)
        Me.grpOptions.Controls.Add(Me.radOption2)
        Me.grpOptions.Controls.Add(Me.radOption1)
        Me.grpOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptions.Location = New System.Drawing.Point(34, 434)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(960, 151)
        Me.grpOptions.TabIndex = 3
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Select an Option!"
        Me.grpOptions.Visible = False
        '
        'radNothing
        '
        Me.radNothing.AutoSize = True
        Me.radNothing.Checked = True
        Me.radNothing.Location = New System.Drawing.Point(864, 117)
        Me.radNothing.Name = "radNothing"
        Me.radNothing.Size = New System.Drawing.Size(140, 28)
        Me.radNothing.TabIndex = 6
        Me.radNothing.TabStop = True
        Me.radNothing.Text = "RadioButton1"
        Me.radNothing.UseVisualStyleBackColor = True
        Me.radNothing.Visible = False
        '
        'radOption2
        '
        Me.radOption2.AutoSize = True
        Me.radOption2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOption2.Location = New System.Drawing.Point(20, 101)
        Me.radOption2.Name = "radOption2"
        Me.radOption2.Size = New System.Drawing.Size(121, 28)
        Me.radOption2.TabIndex = 5
        Me.radOption2.Text = "radOption2"
        Me.radOption2.UseVisualStyleBackColor = True
        Me.radOption2.Visible = False
        '
        'lblPrompts
        '
        Me.lblPrompts.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompts.Location = New System.Drawing.Point(12, 41)
        Me.lblPrompts.Name = "lblPrompts"
        Me.lblPrompts.Size = New System.Drawing.Size(337, 387)
        Me.lblPrompts.TabIndex = 5
        '
        'picGraphics2
        '
        Me.picGraphics2.Location = New System.Drawing.Point(727, 75)
        Me.picGraphics2.Name = "picGraphics2"
        Me.picGraphics2.Size = New System.Drawing.Size(308, 353)
        Me.picGraphics2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGraphics2.TabIndex = 7
        Me.picGraphics2.TabStop = False
        Me.picGraphics2.Visible = False
        '
        'picGraphics1
        '
        Me.picGraphics1.Location = New System.Drawing.Point(367, 75)
        Me.picGraphics1.Name = "picGraphics1"
        Me.picGraphics1.Size = New System.Drawing.Size(340, 353)
        Me.picGraphics1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGraphics1.TabIndex = 4
        Me.picGraphics1.TabStop = False
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(1004, 487)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(171, 48)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "Continue..."
        Me.btnContinue.UseVisualStyleBackColor = True
        Me.btnContinue.Visible = False
        '
        'btnContinueF1
        '
        Me.btnContinueF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinueF1.Location = New System.Drawing.Point(1004, 487)
        Me.btnContinueF1.Name = "btnContinueF1"
        Me.btnContinueF1.Size = New System.Drawing.Size(171, 48)
        Me.btnContinueF1.TabIndex = 8
        Me.btnContinueF1.Text = "Continue..."
        Me.btnContinueF1.UseVisualStyleBackColor = True
        Me.btnContinueF1.Visible = False
        '
        'btnContinueF2
        '
        Me.btnContinueF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinueF2.Location = New System.Drawing.Point(1004, 487)
        Me.btnContinueF2.Name = "btnContinueF2"
        Me.btnContinueF2.Size = New System.Drawing.Size(171, 48)
        Me.btnContinueF2.TabIndex = 9
        Me.btnContinueF2.Text = "Continue..."
        Me.btnContinueF2.UseVisualStyleBackColor = True
        Me.btnContinueF2.Visible = False
        '
        'btnContinueF3
        '
        Me.btnContinueF3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinueF3.Location = New System.Drawing.Point(1004, 487)
        Me.btnContinueF3.Name = "btnContinueF3"
        Me.btnContinueF3.Size = New System.Drawing.Size(171, 48)
        Me.btnContinueF3.TabIndex = 10
        Me.btnContinueF3.Text = "Continue..."
        Me.btnContinueF3.UseVisualStyleBackColor = True
        Me.btnContinueF3.Visible = False
        '
        'btnContinueF4
        '
        Me.btnContinueF4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinueF4.Location = New System.Drawing.Point(1004, 487)
        Me.btnContinueF4.Name = "btnContinueF4"
        Me.btnContinueF4.Size = New System.Drawing.Size(171, 48)
        Me.btnContinueF4.TabIndex = 11
        Me.btnContinueF4.Text = "Continue..."
        Me.btnContinueF4.UseVisualStyleBackColor = True
        Me.btnContinueF4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 597)
        Me.Controls.Add(Me.btnContinueF3)
        Me.Controls.Add(Me.btnContinueF2)
        Me.Controls.Add(Me.btnContinueF4)
        Me.Controls.Add(Me.btnContinueF1)
        Me.Controls.Add(Me.picGraphics2)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblPrompts)
        Me.Controls.Add(Me.picGraphics1)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblTitles)
        Me.Controls.Add(Me.btnNewGame)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        CType(Me.picGraphics2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGraphics1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents lblTitles As System.Windows.Forms.Label
    Friend WithEvents radOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents radOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents picGraphics1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPrompts As System.Windows.Forms.Label
    Friend WithEvents picGraphics2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents radNothing As System.Windows.Forms.RadioButton
    Friend WithEvents btnContinueF1 As System.Windows.Forms.Button
    Friend WithEvents btnContinueF2 As System.Windows.Forms.Button
    Friend WithEvents btnContinueF3 As System.Windows.Forms.Button
    Friend WithEvents btnContinueF4 As System.Windows.Forms.Button

End Class
