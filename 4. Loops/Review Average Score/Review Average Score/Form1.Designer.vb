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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnEnterScores = New System.Windows.Forms.Button()
        Me.btnAverageScore = New System.Windows.Forms.Button()
        Me.lblScoresMessage = New System.Windows.Forms.Label()
        Me.lblNumerofScores = New System.Windows.Forms.Label()
        Me.lblAverageMessage = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(12, 30)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(260, 63)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Select Enter Scores to enter test scores. Select Average Score to display the ave" &
    "rage of the scores entered."
        '
        'btnEnterScores
        '
        Me.btnEnterScores.Location = New System.Drawing.Point(26, 175)
        Me.btnEnterScores.Name = "btnEnterScores"
        Me.btnEnterScores.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterScores.TabIndex = 1
        Me.btnEnterScores.Text = "Eneter Score"
        Me.btnEnterScores.UseVisualStyleBackColor = True
        '
        'btnAverageScore
        '
        Me.btnAverageScore.Location = New System.Drawing.Point(26, 216)
        Me.btnAverageScore.Name = "btnAverageScore"
        Me.btnAverageScore.Size = New System.Drawing.Size(75, 23)
        Me.btnAverageScore.TabIndex = 2
        Me.btnAverageScore.Text = "Average Score"
        Me.btnAverageScore.UseVisualStyleBackColor = True
        '
        'lblScoresMessage
        '
        Me.lblScoresMessage.AutoSize = True
        Me.lblScoresMessage.Location = New System.Drawing.Point(141, 162)
        Me.lblScoresMessage.Name = "lblScoresMessage"
        Me.lblScoresMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblScoresMessage.TabIndex = 3
        '
        'lblNumerofScores
        '
        Me.lblNumerofScores.AutoSize = True
        Me.lblNumerofScores.Location = New System.Drawing.Point(233, 162)
        Me.lblNumerofScores.Name = "lblNumerofScores"
        Me.lblNumerofScores.Size = New System.Drawing.Size(0, 13)
        Me.lblNumerofScores.TabIndex = 4
        '
        'lblAverageMessage
        '
        Me.lblAverageMessage.AutoSize = True
        Me.lblAverageMessage.Location = New System.Drawing.Point(147, 234)
        Me.lblAverageMessage.Name = "lblAverageMessage"
        Me.lblAverageMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverageMessage.TabIndex = 5
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(233, 234)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverage.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblAverageMessage)
        Me.Controls.Add(Me.lblNumerofScores)
        Me.Controls.Add(Me.lblScoresMessage)
        Me.Controls.Add(Me.btnAverageScore)
        Me.Controls.Add(Me.btnEnterScores)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnEnterScores As Button
    Friend WithEvents btnAverageScore As Button
    Friend WithEvents lblScoresMessage As Label
    Friend WithEvents lblNumerofScores As Label
    Friend WithEvents lblAverageMessage As Label
    Friend WithEvents lblAverage As Label
End Class
