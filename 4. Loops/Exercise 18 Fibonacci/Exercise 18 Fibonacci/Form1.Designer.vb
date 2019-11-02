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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtFirstNum = New System.Windows.Forms.TextBox()
        Me.txtSecNum = New System.Windows.Forms.TextBox()
        Me.txtDock = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(20, 47)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(220, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter two seeds for the Fibonacci Sequence:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(218, 112)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtFirstNum
        '
        Me.txtFirstNum.Location = New System.Drawing.Point(246, 44)
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(47, 20)
        Me.txtFirstNum.TabIndex = 2
        '
        'txtSecNum
        '
        Me.txtSecNum.Location = New System.Drawing.Point(299, 44)
        Me.txtSecNum.Name = "txtSecNum"
        Me.txtSecNum.Size = New System.Drawing.Size(47, 20)
        Me.txtSecNum.TabIndex = 3
        '
        'txtDock
        '
        Me.txtDock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtDock.Location = New System.Drawing.Point(0, 193)
        Me.txtDock.Multiline = True
        Me.txtDock.Name = "txtDock"
        Me.txtDock.ReadOnly = True
        Me.txtDock.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDock.Size = New System.Drawing.Size(493, 68)
        Me.txtDock.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 261)
        Me.Controls.Add(Me.txtDock)
        Me.Controls.Add(Me.txtSecNum)
        Me.Controls.Add(Me.txtFirstNum)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Fibonacci"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents txtSecNum As TextBox
    Friend WithEvents txtDock As TextBox
End Class
