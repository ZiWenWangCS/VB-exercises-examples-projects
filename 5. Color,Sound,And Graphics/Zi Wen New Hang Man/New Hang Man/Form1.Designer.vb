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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblSecretWord = New System.Windows.Forms.Label()
        Me.lblWrongGuesses = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChristmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HalloweenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeasonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrBackGroundMusic = New System.Windows.Forms.Timer(Me.components)
        Me.picStart = New System.Windows.Forms.PictureBox()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.picHangMan = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSecretWord
        '
        Me.lblSecretWord.BackColor = System.Drawing.Color.Transparent
        Me.lblSecretWord.ForeColor = System.Drawing.Color.Black
        Me.lblSecretWord.Location = New System.Drawing.Point(238, 120)
        Me.lblSecretWord.Name = "lblSecretWord"
        Me.lblSecretWord.Size = New System.Drawing.Size(173, 43)
        Me.lblSecretWord.TabIndex = 0
        '
        'lblWrongGuesses
        '
        Me.lblWrongGuesses.BackColor = System.Drawing.Color.Transparent
        Me.lblWrongGuesses.Location = New System.Drawing.Point(285, 24)
        Me.lblWrongGuesses.Name = "lblWrongGuesses"
        Me.lblWrongGuesses.Size = New System.Drawing.Size(126, 47)
        Me.lblWrongGuesses.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ModeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(423, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.FileToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolidayToolStripMenuItem, Me.SeasonToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'HolidayToolStripMenuItem
        '
        Me.HolidayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChristmasToolStripMenuItem, Me.HalloweenToolStripMenuItem})
        Me.HolidayToolStripMenuItem.Name = "HolidayToolStripMenuItem"
        Me.HolidayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HolidayToolStripMenuItem.Text = "Holiday"
        '
        'ChristmasToolStripMenuItem
        '
        Me.ChristmasToolStripMenuItem.CheckOnClick = True
        Me.ChristmasToolStripMenuItem.Name = "ChristmasToolStripMenuItem"
        Me.ChristmasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChristmasToolStripMenuItem.Text = "Christmas"
        '
        'HalloweenToolStripMenuItem
        '
        Me.HalloweenToolStripMenuItem.CheckOnClick = True
        Me.HalloweenToolStripMenuItem.Name = "HalloweenToolStripMenuItem"
        Me.HalloweenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HalloweenToolStripMenuItem.Text = "Halloween"
        '
        'SeasonToolStripMenuItem
        '
        Me.SeasonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WinterToolStripMenuItem})
        Me.SeasonToolStripMenuItem.Name = "SeasonToolStripMenuItem"
        Me.SeasonToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SeasonToolStripMenuItem.Text = "Season"
        '
        'WinterToolStripMenuItem
        '
        Me.WinterToolStripMenuItem.CheckOnClick = True
        Me.WinterToolStripMenuItem.Name = "WinterToolStripMenuItem"
        Me.WinterToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.WinterToolStripMenuItem.Text = "Winter"
        '
        'tmrBackGroundMusic
        '
        Me.tmrBackGroundMusic.Interval = 1
        '
        'picStart
        '
        Me.picStart.BackColor = System.Drawing.Color.Transparent
        Me.picStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStart.Location = New System.Drawing.Point(172, 243)
        Me.picStart.Name = "picStart"
        Me.picStart.Size = New System.Drawing.Size(181, 38)
        Me.picStart.TabIndex = 5
        Me.picStart.TabStop = False
        '
        'picBackground
        '
        Me.picBackground.BackColor = System.Drawing.SystemColors.Control
        Me.picBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBackground.Location = New System.Drawing.Point(0, 24)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(423, 311)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 4
        Me.picBackground.TabStop = False
        '
        'picHangMan
        '
        Me.picHangMan.BackColor = System.Drawing.Color.Transparent
        Me.picHangMan.Location = New System.Drawing.Point(15, 59)
        Me.picHangMan.Name = "picHangMan"
        Me.picHangMan.Size = New System.Drawing.Size(135, 206)
        Me.picHangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHangMan.TabIndex = 3
        Me.picHangMan.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 335)
        Me.Controls.Add(Me.picStart)
        Me.Controls.Add(Me.picBackground)
        Me.Controls.Add(Me.picHangMan)
        Me.Controls.Add(Me.lblWrongGuesses)
        Me.Controls.Add(Me.lblSecretWord)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "HANG MAN"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSecretWord As Label
    Friend WithEvents lblWrongGuesses As Label
    Friend WithEvents picHangMan As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HolidayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChristmasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrBackGroundMusic As Timer
    Friend WithEvents picBackground As PictureBox
    Friend WithEvents HalloweenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeasonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WinterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picStart As PictureBox
End Class
