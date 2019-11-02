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
        Me.lbl1stJump = New System.Windows.Forms.Label()
        Me.lbl2ndJump = New System.Windows.Forms.Label()
        Me.lbl3rdJump = New System.Windows.Forms.Label()
        Me.lbl4thJump = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.txt1stJump = New System.Windows.Forms.TextBox()
        Me.txt2ndJump = New System.Windows.Forms.TextBox()
        Me.txt3rdJump = New System.Windows.Forms.TextBox()
        Me.txt4thJump = New System.Windows.Forms.TextBox()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1stJump
        '
        Me.lbl1stJump.AutoSize = True
        Me.lbl1stJump.Location = New System.Drawing.Point(33, 49)
        Me.lbl1stJump.Name = "lbl1stJump"
        Me.lbl1stJump.Size = New System.Drawing.Size(121, 13)
        Me.lbl1stJump.TabIndex = 0
        Me.lbl1stJump.Text = "Enter length of 1st jump:"
        '
        'lbl2ndJump
        '
        Me.lbl2ndJump.AutoSize = True
        Me.lbl2ndJump.Location = New System.Drawing.Point(33, 82)
        Me.lbl2ndJump.Name = "lbl2ndJump"
        Me.lbl2ndJump.Size = New System.Drawing.Size(125, 13)
        Me.lbl2ndJump.TabIndex = 1
        Me.lbl2ndJump.Text = "Enter length of 2nd jump:"
        '
        'lbl3rdJump
        '
        Me.lbl3rdJump.AutoSize = True
        Me.lbl3rdJump.Location = New System.Drawing.Point(33, 114)
        Me.lbl3rdJump.Name = "lbl3rdJump"
        Me.lbl3rdJump.Size = New System.Drawing.Size(122, 13)
        Me.lbl3rdJump.TabIndex = 2
        Me.lbl3rdJump.Text = "Enter length of 3rd jump:"
        '
        'lbl4thJump
        '
        Me.lbl4thJump.AutoSize = True
        Me.lbl4thJump.Location = New System.Drawing.Point(33, 149)
        Me.lbl4thJump.Name = "lbl4thJump"
        Me.lbl4thJump.Size = New System.Drawing.Size(122, 13)
        Me.lbl4thJump.TabIndex = 3
        Me.lbl4thJump.Text = "Enter length of 4th jump:"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(33, 197)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverage.TabIndex = 4
        '
        'txt1stJump
        '
        Me.txt1stJump.Location = New System.Drawing.Point(160, 46)
        Me.txt1stJump.Name = "txt1stJump"
        Me.txt1stJump.Size = New System.Drawing.Size(72, 20)
        Me.txt1stJump.TabIndex = 5
        '
        'txt2ndJump
        '
        Me.txt2ndJump.Location = New System.Drawing.Point(160, 79)
        Me.txt2ndJump.Name = "txt2ndJump"
        Me.txt2ndJump.Size = New System.Drawing.Size(72, 20)
        Me.txt2ndJump.TabIndex = 6
        '
        'txt3rdJump
        '
        Me.txt3rdJump.Location = New System.Drawing.Point(160, 114)
        Me.txt3rdJump.Name = "txt3rdJump"
        Me.txt3rdJump.Size = New System.Drawing.Size(72, 20)
        Me.txt3rdJump.TabIndex = 7
        '
        'txt4thJump
        '
        Me.txt4thJump.Location = New System.Drawing.Point(160, 149)
        Me.txt4thJump.Name = "txt4thJump"
        Me.txt4thJump.Size = New System.Drawing.Size(72, 20)
        Me.txt4thJump.TabIndex = 8
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(160, 197)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(75, 23)
        Me.btnAverage.TabIndex = 9
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.txt4thJump)
        Me.Controls.Add(Me.txt3rdJump)
        Me.Controls.Add(Me.txt2ndJump)
        Me.Controls.Add(Me.txt1stJump)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lbl4thJump)
        Me.Controls.Add(Me.lbl3rdJump)
        Me.Controls.Add(Me.lbl2ndJump)
        Me.Controls.Add(Me.lbl1stJump)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Long Jump Average"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1stJump As Label
    Friend WithEvents lbl2ndJump As Label
    Friend WithEvents lbl3rdJump As Label
    Friend WithEvents lbl4thJump As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents txt1stJump As TextBox
    Friend WithEvents txt2ndJump As TextBox
    Friend WithEvents txt3rdJump As TextBox
    Friend WithEvents txt4thJump As TextBox
    Friend WithEvents btnAverage As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
