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
        Me.lblStartNum = New System.Windows.Forms.Label()
        Me.lblEndNum = New System.Windows.Forms.Label()
        Me.txtStartNum = New System.Windows.Forms.TextBox()
        Me.txtEndNum = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStartNum
        '
        Me.lblStartNum.AutoSize = True
        Me.lblStartNum.Location = New System.Drawing.Point(23, 30)
        Me.lblStartNum.Name = "lblStartNum"
        Me.lblStartNum.Size = New System.Drawing.Size(110, 13)
        Me.lblStartNum.TabIndex = 0
        Me.lblStartNum.Text = "Enter starting number:"
        '
        'lblEndNum
        '
        Me.lblEndNum.AutoSize = True
        Me.lblEndNum.Location = New System.Drawing.Point(23, 61)
        Me.lblEndNum.Name = "lblEndNum"
        Me.lblEndNum.Size = New System.Drawing.Size(108, 13)
        Me.lblEndNum.TabIndex = 1
        Me.lblEndNum.Text = "Enter ending number:"
        '
        'txtStartNum
        '
        Me.txtStartNum.Location = New System.Drawing.Point(139, 27)
        Me.txtStartNum.Name = "txtStartNum"
        Me.txtStartNum.Size = New System.Drawing.Size(100, 20)
        Me.txtStartNum.TabIndex = 2
        '
        'txtEndNum
        '
        Me.txtEndNum.Location = New System.Drawing.Point(139, 61)
        Me.txtEndNum.Name = "txtEndNum"
        Me.txtEndNum.Size = New System.Drawing.Size(100, 20)
        Me.txtEndNum.TabIndex = 3
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(23, 135)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(105, 207)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Sum"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtEndNum)
        Me.Controls.Add(Me.txtStartNum)
        Me.Controls.Add(Me.lblEndNum)
        Me.Controls.Add(Me.lblStartNum)
        Me.Name = "Form1"
        Me.Text = "Sum Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStartNum As Label
    Friend WithEvents lblEndNum As Label
    Friend WithEvents txtStartNum As TextBox
    Friend WithEvents txtEndNum As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnCalculate As Button
End Class
