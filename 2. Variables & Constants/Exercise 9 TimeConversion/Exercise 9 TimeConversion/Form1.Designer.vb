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
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.grpTimeconversion = New System.Windows.Forms.GroupBox()
        Me.radHour = New System.Windows.Forms.RadioButton()
        Me.radSeconds = New System.Windows.Forms.RadioButton()
        Me.grpTimeconversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(29, 31)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(125, 13)
        Me.lblMin.TabIndex = 0
        Me.lblMin.Text = "Enter the time in minutes:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(29, 218)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 1
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(160, 31)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(100, 20)
        Me.txtMin.TabIndex = 2
        '
        'grpTimeconversion
        '
        Me.grpTimeconversion.Controls.Add(Me.radHour)
        Me.grpTimeconversion.Controls.Add(Me.radSeconds)
        Me.grpTimeconversion.Location = New System.Drawing.Point(41, 80)
        Me.grpTimeconversion.Name = "grpTimeconversion"
        Me.grpTimeconversion.Size = New System.Drawing.Size(200, 100)
        Me.grpTimeconversion.TabIndex = 3
        Me.grpTimeconversion.TabStop = False
        Me.grpTimeconversion.Text = "Select time conversion"
        '
        'radHour
        '
        Me.radHour.Location = New System.Drawing.Point(91, 43)
        Me.radHour.Name = "radHour"
        Me.radHour.Size = New System.Drawing.Size(93, 51)
        Me.radHour.TabIndex = 1
        Me.radHour.TabStop = True
        Me.radHour.Text = "Minutes to hour:minute format"
        Me.radHour.UseVisualStyleBackColor = True
        '
        'radSeconds
        '
        Me.radSeconds.Location = New System.Drawing.Point(10, 43)
        Me.radSeconds.Name = "radSeconds"
        Me.radSeconds.Size = New System.Drawing.Size(75, 51)
        Me.radSeconds.TabIndex = 0
        Me.radSeconds.TabStop = True
        Me.radSeconds.Text = "Minutes to seconds"
        Me.radSeconds.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.grpTimeconversion)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblMin)
        Me.Name = "Form1"
        Me.Text = "Time Conversion"
        Me.grpTimeconversion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMin As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtMin As TextBox
    Friend WithEvents grpTimeconversion As GroupBox
    Friend WithEvents radHour As RadioButton
    Friend WithEvents radSeconds As RadioButton
End Class
