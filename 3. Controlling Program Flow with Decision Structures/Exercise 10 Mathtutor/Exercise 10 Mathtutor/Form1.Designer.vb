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
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.btnProblem = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(112, 66)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 0
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(12, 66)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(0, 13)
        Me.lblNum1.TabIndex = 1
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Location = New System.Drawing.Point(28, 147)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(0, 13)
        Me.lblCheck.TabIndex = 2
        '
        'btnProblem
        '
        Me.btnProblem.Location = New System.Drawing.Point(177, 28)
        Me.btnProblem.Name = "btnProblem"
        Me.btnProblem.Size = New System.Drawing.Size(95, 23)
        Me.btnProblem.TabIndex = 3
        Me.btnProblem.Text = "New Problem"
        Me.btnProblem.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(177, 116)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(95, 23)
        Me.btnAnswer.TabIndex = 4
        Me.btnAnswer.Text = "Check Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(177, 169)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(95, 23)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Show Answer"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(28, 66)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(0, 13)
        Me.lblOperator.TabIndex = 6
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(52, 66)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(0, 13)
        Me.lblNum2.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnProblem)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Name = "Form1"
        Me.Text = "Math Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblCheck As Label
    Friend WithEvents btnProblem As Button
    Friend WithEvents btnAnswer As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents lblOperator As Label
    Friend WithEvents lblNum2 As Label
End Class
