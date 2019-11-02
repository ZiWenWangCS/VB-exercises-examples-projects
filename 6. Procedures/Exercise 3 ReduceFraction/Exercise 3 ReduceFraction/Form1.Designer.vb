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
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblDenom = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtDenom = New System.Windows.Forms.TextBox()
        Me.btnReduce = New System.Windows.Forms.Button()
        Me.lblReducedFraction = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(40, 66)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(85, 13)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Enter numerator:"
        '
        'lblDenom
        '
        Me.lblDenom.AutoSize = True
        Me.lblDenom.Location = New System.Drawing.Point(40, 106)
        Me.lblDenom.Name = "lblDenom"
        Me.lblDenom.Size = New System.Drawing.Size(96, 13)
        Me.lblDenom.TabIndex = 1
        Me.lblDenom.Text = "Enter denominator:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(143, 66)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(67, 20)
        Me.txtNum.TabIndex = 2
        '
        'txtDenom
        '
        Me.txtDenom.Location = New System.Drawing.Point(143, 106)
        Me.txtDenom.Name = "txtDenom"
        Me.txtDenom.Size = New System.Drawing.Size(67, 20)
        Me.txtDenom.TabIndex = 3
        '
        'btnReduce
        '
        Me.btnReduce.Location = New System.Drawing.Point(39, 219)
        Me.btnReduce.Name = "btnReduce"
        Me.btnReduce.Size = New System.Drawing.Size(75, 23)
        Me.btnReduce.TabIndex = 4
        Me.btnReduce.Text = "Reduce"
        Me.btnReduce.UseVisualStyleBackColor = True
        '
        'lblReducedFraction
        '
        Me.lblReducedFraction.AutoSize = True
        Me.lblReducedFraction.Location = New System.Drawing.Point(131, 219)
        Me.lblReducedFraction.Name = "lblReducedFraction"
        Me.lblReducedFraction.Size = New System.Drawing.Size(0, 13)
        Me.lblReducedFraction.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblReducedFraction)
        Me.Controls.Add(Me.btnReduce)
        Me.Controls.Add(Me.txtDenom)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblDenom)
        Me.Controls.Add(Me.lblNum)
        Me.Name = "Form1"
        Me.Text = "Reduce Fraction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum As Label
    Friend WithEvents lblDenom As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtDenom As TextBox
    Friend WithEvents btnReduce As Button
    Friend WithEvents lblReducedFraction As Label
End Class
