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
        Me.lblPrimeResult = New System.Windows.Forms.Label()
        Me.lblIntegerPrompt = New System.Windows.Forms.Label()
        Me.txtInteger = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrimeResult
        '
        Me.lblPrimeResult.AutoSize = True
        Me.lblPrimeResult.Location = New System.Drawing.Point(115, 110)
        Me.lblPrimeResult.Name = "lblPrimeResult"
        Me.lblPrimeResult.Size = New System.Drawing.Size(0, 13)
        Me.lblPrimeResult.TabIndex = 0
        '
        'lblIntegerPrompt
        '
        Me.lblIntegerPrompt.AutoSize = True
        Me.lblIntegerPrompt.Location = New System.Drawing.Point(36, 47)
        Me.lblIntegerPrompt.Name = "lblIntegerPrompt"
        Me.lblIntegerPrompt.Size = New System.Drawing.Size(85, 13)
        Me.lblIntegerPrompt.TabIndex = 1
        Me.lblIntegerPrompt.Text = "Enter an integer:"
        '
        'txtInteger
        '
        Me.txtInteger.Location = New System.Drawing.Point(118, 47)
        Me.txtInteger.Name = "txtInteger"
        Me.txtInteger.Size = New System.Drawing.Size(100, 20)
        Me.txtInteger.TabIndex = 2
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(55, 174)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 3
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtInteger)
        Me.Controls.Add(Me.lblIntegerPrompt)
        Me.Controls.Add(Me.lblPrimeResult)
        Me.Name = "Form1"
        Me.Text = "Prime Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrimeResult As Label
    Friend WithEvents lblIntegerPrompt As Label
    Friend WithEvents txtInteger As TextBox
    Friend WithEvents btnTest As Button
End Class
