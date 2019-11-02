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
        Me.grpDestination = New System.Windows.Forms.GroupBox()
        Me.radEngland = New System.Windows.Forms.RadioButton()
        Me.radRome = New System.Windows.Forms.RadioButton()
        Me.radParis = New System.Windows.Forms.RadioButton()
        Me.radJapan = New System.Windows.Forms.RadioButton()
        Me.radSydney = New System.Windows.Forms.RadioButton()
        Me.picDestination = New System.Windows.Forms.PictureBox()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.grpDestination.SuspendLayout()
        CType(Me.picDestination, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDestination
        '
        Me.grpDestination.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpDestination.Controls.Add(Me.radEngland)
        Me.grpDestination.Controls.Add(Me.radRome)
        Me.grpDestination.Controls.Add(Me.radParis)
        Me.grpDestination.Controls.Add(Me.radJapan)
        Me.grpDestination.Controls.Add(Me.radSydney)
        Me.grpDestination.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpDestination.Location = New System.Drawing.Point(32, 26)
        Me.grpDestination.Name = "grpDestination"
        Me.grpDestination.Size = New System.Drawing.Size(171, 272)
        Me.grpDestination.TabIndex = 0
        Me.grpDestination.TabStop = False
        Me.grpDestination.Text = "Select a Destination"
        '
        'radEngland
        '
        Me.radEngland.AutoSize = True
        Me.radEngland.Location = New System.Drawing.Point(23, 220)
        Me.radEngland.Name = "radEngland"
        Me.radEngland.Size = New System.Drawing.Size(84, 17)
        Me.radEngland.TabIndex = 4
        Me.radEngland.Text = "Destination5"
        Me.radEngland.UseVisualStyleBackColor = True
        '
        'radRome
        '
        Me.radRome.AutoSize = True
        Me.radRome.Location = New System.Drawing.Point(23, 179)
        Me.radRome.Name = "radRome"
        Me.radRome.Size = New System.Drawing.Size(84, 17)
        Me.radRome.TabIndex = 3
        Me.radRome.Text = "Destination4"
        Me.radRome.UseVisualStyleBackColor = True
        '
        'radParis
        '
        Me.radParis.AutoSize = True
        Me.radParis.Location = New System.Drawing.Point(23, 133)
        Me.radParis.Name = "radParis"
        Me.radParis.Size = New System.Drawing.Size(84, 17)
        Me.radParis.TabIndex = 2
        Me.radParis.Text = "Destination3"
        Me.radParis.UseVisualStyleBackColor = True
        '
        'radJapan
        '
        Me.radJapan.AutoSize = True
        Me.radJapan.Location = New System.Drawing.Point(23, 91)
        Me.radJapan.Name = "radJapan"
        Me.radJapan.Size = New System.Drawing.Size(84, 17)
        Me.radJapan.TabIndex = 1
        Me.radJapan.Text = "Destination2"
        Me.radJapan.UseVisualStyleBackColor = True
        '
        'radSydney
        '
        Me.radSydney.AutoSize = True
        Me.radSydney.Location = New System.Drawing.Point(23, 46)
        Me.radSydney.Name = "radSydney"
        Me.radSydney.Size = New System.Drawing.Size(84, 17)
        Me.radSydney.TabIndex = 0
        Me.radSydney.Text = "Destination1"
        Me.radSydney.UseVisualStyleBackColor = True
        '
        'picDestination
        '
        Me.picDestination.ErrorImage = Nothing
        Me.picDestination.Image = Global.VacationDestinations.My.Resources.Resources.august
        Me.picDestination.InitialImage = Nothing
        Me.picDestination.Location = New System.Drawing.Point(220, 41)
        Me.picDestination.Name = "picDestination"
        Me.picDestination.Size = New System.Drawing.Size(386, 315)
        Me.picDestination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDestination.TabIndex = 1
        Me.picDestination.TabStop = False
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.ForeColor = System.Drawing.Color.Salmon
        Me.lblDestination.Location = New System.Drawing.Point(216, 386)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(318, 20)
        Me.lblDestination.TabIndex = 2
        Me.lblDestination.Text = "Please select a destination you'd like to visit!"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(804, 593)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.picDestination)
        Me.Controls.Add(Me.grpDestination)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Vacation Destinations"
        Me.grpDestination.ResumeLayout(False)
        Me.grpDestination.PerformLayout()
        CType(Me.picDestination, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpDestination As GroupBox
    Friend WithEvents radEngland As RadioButton
    Friend WithEvents radRome As RadioButton
    Friend WithEvents radParis As RadioButton
    Friend WithEvents radJapan As RadioButton
    Friend WithEvents radSydney As RadioButton
    Friend WithEvents picDestination As PictureBox
    Friend WithEvents lblDestination As Label
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
