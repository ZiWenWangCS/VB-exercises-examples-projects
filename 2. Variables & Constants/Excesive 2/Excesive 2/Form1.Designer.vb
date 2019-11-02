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
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.bttnAnswer = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CelsiusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FahrenheitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(12, 179)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 0
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(229, 87)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(60, 20)
        Me.txtTemp.TabIndex = 1
        '
        'bttnAnswer
        '
        Me.bttnAnswer.Location = New System.Drawing.Point(191, 189)
        Me.bttnAnswer.Name = "bttnAnswer"
        Me.bttnAnswer.Size = New System.Drawing.Size(75, 23)
        Me.bttnAnswer.TabIndex = 2
        Me.bttnAnswer.Text = "Button1"
        Me.bttnAnswer.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(333, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CelsiusToolStripMenuItem, Me.FahrenheitToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'CelsiusToolStripMenuItem
        '
        Me.CelsiusToolStripMenuItem.Name = "CelsiusToolStripMenuItem"
        Me.CelsiusToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CelsiusToolStripMenuItem.Text = "Celsius"
        '
        'FahrenheitToolStripMenuItem1
        '
        Me.FahrenheitToolStripMenuItem1.Name = "FahrenheitToolStripMenuItem1"
        Me.FahrenheitToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.FahrenheitToolStripMenuItem1.Text = "Fahrenheit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(12, 56)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(0, 13)
        Me.lblTemp.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 300)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.bttnAnswer)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.lblAnswer)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents bttnAnswer As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CelsiusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FahrenheitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTemp As Label
End Class
