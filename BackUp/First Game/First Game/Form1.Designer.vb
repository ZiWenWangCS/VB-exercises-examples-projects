<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnFork1Yes = New System.Windows.Forms.Button()
        Me.btnFork1No = New System.Windows.Forms.Button()
        Me.btnFork2Ask = New System.Windows.Forms.Button()
        Me.btnFork3Teach = New System.Windows.Forms.Button()
        Me.btnFork3Punch = New System.Windows.Forms.Button()
        Me.btnFork3Game = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFork2GoHome = New System.Windows.Forms.Button()
        Me.btnFork4YesInvite = New System.Windows.Forms.Button()
        Me.btnFork4NoInvite = New System.Windows.Forms.Button()
        Me.btnFork4Run = New System.Windows.Forms.Button()
        Me.btnFork4Fight = New System.Windows.Forms.Button()
        Me.btnFork4Play = New System.Windows.Forms.Button()
        Me.btnFork4GoHome = New System.Windows.Forms.Button()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(659, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(53, 373)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(112, 45)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "btnStart"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.ForeColor = System.Drawing.Color.Black
        Me.lblPrompt.Location = New System.Drawing.Point(-3, 24)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(46, 13)
        Me.lblPrompt.TabIndex = 3
        Me.lblPrompt.Text = "Prompt"
        '
        'btnFork1Yes
        '
        Me.btnFork1Yes.Location = New System.Drawing.Point(53, 373)
        Me.btnFork1Yes.Name = "btnFork1Yes"
        Me.btnFork1Yes.Size = New System.Drawing.Size(112, 45)
        Me.btnFork1Yes.TabIndex = 4
        Me.btnFork1Yes.Text = "btnFork1Yes"
        Me.btnFork1Yes.UseVisualStyleBackColor = True
        Me.btnFork1Yes.Visible = False
        '
        'btnFork1No
        '
        Me.btnFork1No.Location = New System.Drawing.Point(246, 373)
        Me.btnFork1No.Name = "btnFork1No"
        Me.btnFork1No.Size = New System.Drawing.Size(112, 45)
        Me.btnFork1No.TabIndex = 5
        Me.btnFork1No.Text = "btnFork1No"
        Me.btnFork1No.UseVisualStyleBackColor = True
        Me.btnFork1No.Visible = False
        '
        'btnFork2Ask
        '
        Me.btnFork2Ask.Location = New System.Drawing.Point(53, 373)
        Me.btnFork2Ask.Name = "btnFork2Ask"
        Me.btnFork2Ask.Size = New System.Drawing.Size(112, 45)
        Me.btnFork2Ask.TabIndex = 6
        Me.btnFork2Ask.Text = "btnFork2Ask a random person for his computer"
        Me.btnFork2Ask.UseVisualStyleBackColor = True
        Me.btnFork2Ask.Visible = False
        '
        'btnFork3Teach
        '
        Me.btnFork3Teach.Location = New System.Drawing.Point(53, 373)
        Me.btnFork3Teach.Name = "btnFork3Teach"
        Me.btnFork3Teach.Size = New System.Drawing.Size(112, 45)
        Me.btnFork3Teach.TabIndex = 8
        Me.btnFork3Teach.Text = "btnFork3Teach"
        Me.btnFork3Teach.UseVisualStyleBackColor = True
        Me.btnFork3Teach.Visible = False
        '
        'btnFork3Punch
        '
        Me.btnFork3Punch.Location = New System.Drawing.Point(246, 373)
        Me.btnFork3Punch.Name = "btnFork3Punch"
        Me.btnFork3Punch.Size = New System.Drawing.Size(112, 45)
        Me.btnFork3Punch.TabIndex = 9
        Me.btnFork3Punch.Text = "btnFork3Punch"
        Me.btnFork3Punch.UseVisualStyleBackColor = True
        Me.btnFork3Punch.Visible = False
        '
        'btnFork3Game
        '
        Me.btnFork3Game.Location = New System.Drawing.Point(53, 373)
        Me.btnFork3Game.Name = "btnFork3Game"
        Me.btnFork3Game.Size = New System.Drawing.Size(112, 45)
        Me.btnFork3Game.TabIndex = 10
        Me.btnFork3Game.Text = "btnFork3Game"
        Me.btnFork3Game.UseVisualStyleBackColor = True
        Me.btnFork3Game.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(584, 27)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "btnBack"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'btnFork2GoHome
        '
        Me.btnFork2GoHome.Location = New System.Drawing.Point(246, 373)
        Me.btnFork2GoHome.Name = "btnFork2GoHome"
        Me.btnFork2GoHome.Size = New System.Drawing.Size(112, 45)
        Me.btnFork2GoHome.TabIndex = 12
        Me.btnFork2GoHome.Text = "btnFork2GoHome"
        Me.btnFork2GoHome.UseVisualStyleBackColor = True
        Me.btnFork2GoHome.Visible = False
        '
        'btnFork4YesInvite
        '
        Me.btnFork4YesInvite.Location = New System.Drawing.Point(53, 373)
        Me.btnFork4YesInvite.Name = "btnFork4YesInvite"
        Me.btnFork4YesInvite.Size = New System.Drawing.Size(112, 45)
        Me.btnFork4YesInvite.TabIndex = 13
        Me.btnFork4YesInvite.Text = "btnFork4YesInvite"
        Me.btnFork4YesInvite.UseVisualStyleBackColor = True
        Me.btnFork4YesInvite.Visible = False
        '
        'btnFork4NoInvite
        '
        Me.btnFork4NoInvite.Location = New System.Drawing.Point(246, 373)
        Me.btnFork4NoInvite.Name = "btnFork4NoInvite"
        Me.btnFork4NoInvite.Size = New System.Drawing.Size(112, 45)
        Me.btnFork4NoInvite.TabIndex = 14
        Me.btnFork4NoInvite.Text = "btnFork4NoInvite"
        Me.btnFork4NoInvite.UseVisualStyleBackColor = True
        Me.btnFork4NoInvite.Visible = False
        '
        'btnFork4Run
        '
        Me.btnFork4Run.Location = New System.Drawing.Point(53, 373)
        Me.btnFork4Run.Name = "btnFork4Run"
        Me.btnFork4Run.Size = New System.Drawing.Size(112, 45)
        Me.btnFork4Run.TabIndex = 15
        Me.btnFork4Run.Text = "btnFork4Run"
        Me.btnFork4Run.UseVisualStyleBackColor = True
        Me.btnFork4Run.Visible = False
        '
        'btnFork4Fight
        '
        Me.btnFork4Fight.Location = New System.Drawing.Point(246, 373)
        Me.btnFork4Fight.Name = "btnFork4Fight"
        Me.btnFork4Fight.Size = New System.Drawing.Size(112, 45)
        Me.btnFork4Fight.TabIndex = 16
        Me.btnFork4Fight.Text = "btnFork4Fight"
        Me.btnFork4Fight.UseVisualStyleBackColor = True
        Me.btnFork4Fight.Visible = False
        '
        'btnFork4Play
        '
        Me.btnFork4Play.Location = New System.Drawing.Point(53, 373)
        Me.btnFork4Play.Name = "btnFork4Play"
        Me.btnFork4Play.Size = New System.Drawing.Size(112, 45)
        Me.btnFork4Play.TabIndex = 17
        Me.btnFork4Play.Text = "btnFork4Play"
        Me.btnFork4Play.UseVisualStyleBackColor = True
        Me.btnFork4Play.Visible = False
        '
        'btnFork4GoHome
        '
        Me.btnFork4GoHome.Location = New System.Drawing.Point(246, 373)
        Me.btnFork4GoHome.Name = "btnFork4GoHome"
        Me.btnFork4GoHome.Size = New System.Drawing.Size(112, 45)
        Me.btnFork4GoHome.TabIndex = 18
        Me.btnFork4GoHome.Text = "btnFork4GoHome"
        Me.btnFork4GoHome.UseVisualStyleBackColor = True
        Me.btnFork4GoHome.Visible = False
        '
        'picBackground
        '
        Me.picBackground.Location = New System.Drawing.Point(0, 27)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(659, 453)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(246, 216)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(112, 45)
        Me.btnRestart.TabIndex = 19
        Me.btnRestart.Text = "btnRestart"
        Me.btnRestart.UseVisualStyleBackColor = True
        Me.btnRestart.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 477)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnFork4GoHome)
        Me.Controls.Add(Me.btnFork4Play)
        Me.Controls.Add(Me.btnFork4Fight)
        Me.Controls.Add(Me.btnFork4Run)
        Me.Controls.Add(Me.btnFork4NoInvite)
        Me.Controls.Add(Me.btnFork4YesInvite)
        Me.Controls.Add(Me.btnFork2GoHome)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnFork3Game)
        Me.Controls.Add(Me.btnFork3Punch)
        Me.Controls.Add(Me.btnFork3Teach)
        Me.Controls.Add(Me.btnFork2Ask)
        Me.Controls.Add(Me.btnFork1No)
        Me.Controls.Add(Me.btnFork1Yes)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picBackground)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStart As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnFork1Yes As Button
    Friend WithEvents btnFork1No As Button
    Friend WithEvents btnFork2Ask As Button
    Friend WithEvents btnFork3Teach As Button
    Friend WithEvents btnFork3Punch As Button
    Friend WithEvents btnFork3Game As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnFork2GoHome As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnFork4YesInvite As Button
    Friend WithEvents btnFork4NoInvite As Button
    Friend WithEvents btnFork4Run As Button
    Friend WithEvents btnFork4Fight As Button
    Friend WithEvents btnFork4Play As Button
    Friend WithEvents btnFork4GoHome As Button
    Friend WithEvents btnRestart As Button
End Class
