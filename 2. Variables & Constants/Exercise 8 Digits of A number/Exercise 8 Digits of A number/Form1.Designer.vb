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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lbl1stDigit = New System.Windows.Forms.Label()
        Me.lbl2ndDigit = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnDigits = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DigitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(31, 36)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(121, 13)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Enter a two-digit number"
        '
        'lbl1stDigit
        '
        Me.lbl1stDigit.AutoSize = True
        Me.lbl1stDigit.Location = New System.Drawing.Point(31, 131)
        Me.lbl1stDigit.Name = "lbl1stDigit"
        Me.lbl1stDigit.Size = New System.Drawing.Size(0, 13)
        Me.lbl1stDigit.TabIndex = 1
        '
        'lbl2ndDigit
        '
        Me.lbl2ndDigit.AutoSize = True
        Me.lbl2ndDigit.Location = New System.Drawing.Point(31, 180)
        Me.lbl2ndDigit.Name = "lbl2ndDigit"
        Me.lbl2ndDigit.Size = New System.Drawing.Size(0, 13)
        Me.lbl2ndDigit.TabIndex = 2
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(158, 36)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 3
        '
        'btnDigits
        '
        Me.btnDigits.Location = New System.Drawing.Point(167, 154)
        Me.btnDigits.Name = "btnDigits"
        Me.btnDigits.Size = New System.Drawing.Size(75, 23)
        Me.btnDigits.TabIndex = 4
        Me.btnDigits.Text = "Digits"
        Me.btnDigits.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DigitsToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'DigitsToolStripMenuItem
        '
        Me.DigitsToolStripMenuItem.Name = "DigitsToolStripMenuItem"
        Me.DigitsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DigitsToolStripMenuItem.Text = "Digits"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDigits)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lbl2ndDigit)
        Me.Controls.Add(Me.lbl1stDigit)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Digits of a Number"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents lbl1stDigit As Label
    Friend WithEvents lbl2ndDigit As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnDigits As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DigitsToolStripMenuItem As ToolStripMenuItem
End Class
