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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblDigits = New System.Windows.Forms.Label()
        Me.btnBreakdown = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 27)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(154, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a number less than 1,000"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(172, 24)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(79, 20)
        Me.txtNumber.TabIndex = 1
        '
        'lblDigits
        '
        Me.lblDigits.AutoSize = True
        Me.lblDigits.Location = New System.Drawing.Point(28, 81)
        Me.lblDigits.Name = "lblDigits"
        Me.lblDigits.Size = New System.Drawing.Size(0, 13)
        Me.lblDigits.TabIndex = 2
        '
        'btnBreakdown
        '
        Me.btnBreakdown.Location = New System.Drawing.Point(149, 202)
        Me.btnBreakdown.Name = "btnBreakdown"
        Me.btnBreakdown.Size = New System.Drawing.Size(75, 23)
        Me.btnBreakdown.TabIndex = 3
        Me.btnBreakdown.Text = "Breakdown"
        Me.btnBreakdown.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnBreakdown)
        Me.Controls.Add(Me.lblDigits)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Number Breakdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblDigits As Label
    Friend WithEvents btnBreakdown As Button
End Class
