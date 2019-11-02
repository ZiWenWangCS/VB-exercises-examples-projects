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
        Me.numNumber1 = New System.Windows.Forms.NumericUpDown()
        Me.numNumber2 = New System.Windows.Forms.NumericUpDown()
        Me.lblMultiply = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnEqual = New System.Windows.Forms.Button()
        CType(Me.numNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNumber2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numNumber1
        '
        Me.numNumber1.Location = New System.Drawing.Point(55, 57)
        Me.numNumber1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numNumber1.Name = "numNumber1"
        Me.numNumber1.Size = New System.Drawing.Size(45, 20)
        Me.numNumber1.TabIndex = 0
        '
        'numNumber2
        '
        Me.numNumber2.Location = New System.Drawing.Point(145, 57)
        Me.numNumber2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numNumber2.Name = "numNumber2"
        Me.numNumber2.Size = New System.Drawing.Size(40, 20)
        Me.numNumber2.TabIndex = 1
        '
        'lblMultiply
        '
        Me.lblMultiply.AutoSize = True
        Me.lblMultiply.Location = New System.Drawing.Point(114, 64)
        Me.lblMultiply.Name = "lblMultiply"
        Me.lblMultiply.Size = New System.Drawing.Size(14, 13)
        Me.lblMultiply.TabIndex = 2
        Me.lblMultiply.Text = "X"
        Me.lblMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(128, 138)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 3
        '
        'btnEqual
        '
        Me.btnEqual.Location = New System.Drawing.Point(191, 57)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(26, 23)
        Me.btnEqual.TabIndex = 4
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 202)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblMultiply)
        Me.Controls.Add(Me.numNumber2)
        Me.Controls.Add(Me.numNumber1)
        Me.Name = "Form1"
        Me.Text = "Basic Multiplication"
        CType(Me.numNumber1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNumber2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numNumber1 As NumericUpDown
    Friend WithEvents numNumber2 As NumericUpDown
    Friend WithEvents lblMultiply As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnEqual As Button
End Class
