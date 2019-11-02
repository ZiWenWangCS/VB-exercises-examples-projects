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
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirstLetter = New System.Windows.Forms.Label()
        Me.lblMiddleLetter = New System.Windows.Forms.Label()
        Me.lblLastLetter = New System.Windows.Forms.Label()
        Me.btnDisplayData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(17, 53)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(55, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter text:"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(78, 50)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(89, 20)
        Me.txtText.TabIndex = 1
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(29, 126)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(55, 13)
        Me.lblFirst.TabIndex = 2
        Me.lblFirst.Text = "First letter:"
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Location = New System.Drawing.Point(29, 161)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(67, 13)
        Me.lblMiddle.TabIndex = 3
        Me.lblMiddle.Text = "Middle letter:"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(29, 189)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(56, 13)
        Me.lblLast.TabIndex = 4
        Me.lblLast.Text = "Last letter:"
        '
        'lblFirstLetter
        '
        Me.lblFirstLetter.AutoSize = True
        Me.lblFirstLetter.Location = New System.Drawing.Point(90, 126)
        Me.lblFirstLetter.Name = "lblFirstLetter"
        Me.lblFirstLetter.Size = New System.Drawing.Size(0, 13)
        Me.lblFirstLetter.TabIndex = 5
        '
        'lblMiddleLetter
        '
        Me.lblMiddleLetter.AutoSize = True
        Me.lblMiddleLetter.Location = New System.Drawing.Point(102, 161)
        Me.lblMiddleLetter.Name = "lblMiddleLetter"
        Me.lblMiddleLetter.Size = New System.Drawing.Size(0, 13)
        Me.lblMiddleLetter.TabIndex = 6
        '
        'lblLastLetter
        '
        Me.lblLastLetter.AutoSize = True
        Me.lblLastLetter.Location = New System.Drawing.Point(91, 189)
        Me.lblLastLetter.Name = "lblLastLetter"
        Me.lblLastLetter.Size = New System.Drawing.Size(0, 13)
        Me.lblLastLetter.TabIndex = 7
        '
        'btnDisplayData
        '
        Me.btnDisplayData.Location = New System.Drawing.Point(172, 187)
        Me.btnDisplayData.Name = "btnDisplayData"
        Me.btnDisplayData.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayData.TabIndex = 8
        Me.btnDisplayData.Text = "Display Data"
        Me.btnDisplayData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDisplayData)
        Me.Controls.Add(Me.lblLastLetter)
        Me.Controls.Add(Me.lblMiddleLetter)
        Me.Controls.Add(Me.lblFirstLetter)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "String Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblMiddle As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblFirstLetter As Label
    Friend WithEvents lblMiddleLetter As Label
    Friend WithEvents lblLastLetter As Label
    Friend WithEvents btnDisplayData As Button
End Class
