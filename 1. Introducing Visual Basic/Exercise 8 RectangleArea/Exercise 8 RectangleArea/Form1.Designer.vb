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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.bttnAnswer = New System.Windows.Forms.Button()
        Me.lblanswer2 = New System.Windows.Forms.Label()
        Me.lblanswer3 = New System.Windows.Forms.Label()
        Me.lblanswer4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(380, 24)
        Me.MenuStrip1.TabIndex = 0
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(12, 66)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(347, 13)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "What is the area and perimeter of a rectangle with length 5 and width 3?"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(30, 148)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 2
        '
        'bttnAnswer
        '
        Me.bttnAnswer.Location = New System.Drawing.Point(223, 165)
        Me.bttnAnswer.Name = "bttnAnswer"
        Me.bttnAnswer.Size = New System.Drawing.Size(107, 31)
        Me.bttnAnswer.TabIndex = 3
        Me.bttnAnswer.Text = "Answer"
        Me.bttnAnswer.UseVisualStyleBackColor = True
        '
        'lblanswer2
        '
        Me.lblanswer2.AutoSize = True
        Me.lblanswer2.Location = New System.Drawing.Point(96, 148)
        Me.lblanswer2.Name = "lblanswer2"
        Me.lblanswer2.Size = New System.Drawing.Size(0, 13)
        Me.lblanswer2.TabIndex = 4
        '
        'lblanswer3
        '
        Me.lblanswer3.AutoSize = True
        Me.lblanswer3.Location = New System.Drawing.Point(96, 165)
        Me.lblanswer3.Name = "lblanswer3"
        Me.lblanswer3.Size = New System.Drawing.Size(0, 13)
        Me.lblanswer3.TabIndex = 5
        '
        'lblanswer4
        '
        Me.lblanswer4.AutoSize = True
        Me.lblanswer4.Location = New System.Drawing.Point(96, 216)
        Me.lblanswer4.Name = "lblanswer4"
        Me.lblanswer4.Size = New System.Drawing.Size(0, 13)
        Me.lblanswer4.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 307)
        Me.Controls.Add(Me.lblanswer4)
        Me.Controls.Add(Me.lblanswer3)
        Me.Controls.Add(Me.lblanswer2)
        Me.Controls.Add(Me.bttnAnswer)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents bttnAnswer As Button
    Friend WithEvents lblanswer2 As Label
    Friend WithEvents lblanswer3 As Label
    Friend WithEvents lblanswer4 As Label
End Class
