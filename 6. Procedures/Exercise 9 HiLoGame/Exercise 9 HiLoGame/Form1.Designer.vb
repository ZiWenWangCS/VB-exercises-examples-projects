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
        Me.txtRiskPoint = New System.Windows.Forms.TextBox()
        Me.lblRndNum = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(51, 72)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(97, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter points to risk:"
        '
        'txtRiskPoint
        '
        Me.txtRiskPoint.Location = New System.Drawing.Point(154, 69)
        Me.txtRiskPoint.Name = "txtRiskPoint"
        Me.txtRiskPoint.Size = New System.Drawing.Size(50, 20)
        Me.txtRiskPoint.TabIndex = 1
        '
        'lblRndNum
        '
        Me.lblRndNum.AutoSize = True
        Me.lblRndNum.Location = New System.Drawing.Point(44, 171)
        Me.lblRndNum.Name = "lblRndNum"
        Me.lblRndNum.Size = New System.Drawing.Size(0, 13)
        Me.lblRndNum.TabIndex = 2
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Location = New System.Drawing.Point(44, 211)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(0, 13)
        Me.lblPoints.TabIndex = 3
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(154, 120)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(75, 23)
        Me.btnHigh.TabIndex = 4
        Me.btnHigh.Tag = "High"
        Me.btnHigh.Text = "High"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(154, 161)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(75, 23)
        Me.btnLow.TabIndex = 5
        Me.btnLow.Tag = "Low"
        Me.btnLow.Text = "Low"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblRndNum)
        Me.Controls.Add(Me.txtRiskPoint)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Hi_Lo Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtRiskPoint As TextBox
    Friend WithEvents lblRndNum As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents btnHigh As Button
    Friend WithEvents btnLow As Button
End Class
