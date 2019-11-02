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
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblPassed = New System.Windows.Forms.Label()
        Me.lblFailed = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(53, 41)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(74, 13)
        Me.lblGrade.TabIndex = 0
        Me.lblGrade.Text = "Enter a grade:"
        '
        'lblPassed
        '
        Me.lblPassed.AutoSize = True
        Me.lblPassed.Location = New System.Drawing.Point(53, 118)
        Me.lblPassed.Name = "lblPassed"
        Me.lblPassed.Size = New System.Drawing.Size(0, 13)
        Me.lblPassed.TabIndex = 1
        '
        'lblFailed
        '
        Me.lblFailed.AutoSize = True
        Me.lblFailed.Location = New System.Drawing.Point(53, 154)
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Size = New System.Drawing.Size(0, 13)
        Me.lblFailed.TabIndex = 2
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(133, 41)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(69, 20)
        Me.txtGrade.TabIndex = 3
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(208, 41)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(75, 23)
        Me.btnGrade.TabIndex = 4
        Me.btnGrade.Text = "Enter Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.lblFailed)
        Me.Controls.Add(Me.lblPassed)
        Me.Controls.Add(Me.lblGrade)
        Me.Name = "Form1"
        Me.Text = "Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGrade As Label
    Friend WithEvents lblPassed As Label
    Friend WithEvents lblFailed As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnGrade As Button
End Class
