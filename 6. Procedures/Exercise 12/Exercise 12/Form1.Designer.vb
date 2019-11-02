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
        Me.lblStones = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.txtStones = New System.Windows.Forms.TextBox()
        Me.btnTakeStones = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStones
        '
        Me.lblStones.AutoSize = True
        Me.lblStones.Location = New System.Drawing.Point(52, 54)
        Me.lblStones.Name = "lblStones"
        Me.lblStones.Size = New System.Drawing.Size(0, 13)
        Me.lblStones.TabIndex = 0
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(21, 121)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(157, 13)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Number of stones to take away:"
        '
        'lblComputer
        '
        Me.lblComputer.AutoSize = True
        Me.lblComputer.Location = New System.Drawing.Point(42, 217)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(0, 13)
        Me.lblComputer.TabIndex = 2
        '
        'txtStones
        '
        Me.txtStones.Location = New System.Drawing.Point(184, 121)
        Me.txtStones.Name = "txtStones"
        Me.txtStones.Size = New System.Drawing.Size(77, 20)
        Me.txtStones.TabIndex = 3
        '
        'btnTakeStones
        '
        Me.btnTakeStones.Location = New System.Drawing.Point(280, 175)
        Me.btnTakeStones.Name = "btnTakeStones"
        Me.btnTakeStones.Size = New System.Drawing.Size(93, 23)
        Me.btnTakeStones.TabIndex = 4
        Me.btnTakeStones.Text = "Take Stones"
        Me.btnTakeStones.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(280, 217)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(93, 23)
        Me.btnNewGame.TabIndex = 5
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 321)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.btnTakeStones)
        Me.Controls.Add(Me.txtStones)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblStones)
        Me.Name = "Form1"
        Me.Text = "Nim"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStones As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblComputer As Label
    Friend WithEvents txtStones As TextBox
    Friend WithEvents btnTakeStones As Button
    Friend WithEvents btnNewGame As Button
End Class
