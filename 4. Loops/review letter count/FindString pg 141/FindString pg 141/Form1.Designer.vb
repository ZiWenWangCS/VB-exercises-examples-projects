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
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.txtSearchText = New System.Windows.Forms.TextBox()
        Me.lblEnterText = New System.Windows.Forms.Label()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.lblPositionMessage = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnFindString = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(117, 39)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(100, 20)
        Me.txtText.TabIndex = 0
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(117, 89)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchText.TabIndex = 1
        '
        'lblEnterText
        '
        Me.lblEnterText.AutoSize = True
        Me.lblEnterText.Location = New System.Drawing.Point(38, 42)
        Me.lblEnterText.Name = "lblEnterText"
        Me.lblEnterText.Size = New System.Drawing.Size(59, 13)
        Me.lblEnterText.TabIndex = 2
        Me.lblEnterText.Text = "Enter Text:"
        '
        'lblSearchText
        '
        Me.lblSearchText.AutoSize = True
        Me.lblSearchText.Location = New System.Drawing.Point(38, 92)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(68, 13)
        Me.lblSearchText.TabIndex = 3
        Me.lblSearchText.Text = "Search Text:"
        '
        'lblPositionMessage
        '
        Me.lblPositionMessage.AutoSize = True
        Me.lblPositionMessage.Location = New System.Drawing.Point(52, 173)
        Me.lblPositionMessage.Name = "lblPositionMessage"
        Me.lblPositionMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblPositionMessage.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(196, 173)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 5
        '
        'btnFindString
        '
        Me.btnFindString.Location = New System.Drawing.Point(154, 223)
        Me.btnFindString.Name = "btnFindString"
        Me.btnFindString.Size = New System.Drawing.Size(75, 23)
        Me.btnFindString.TabIndex = 6
        Me.btnFindString.Text = "Find String"
        Me.btnFindString.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnFindString)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblPositionMessage)
        Me.Controls.Add(Me.lblSearchText)
        Me.Controls.Add(Me.lblEnterText)
        Me.Controls.Add(Me.txtSearchText)
        Me.Controls.Add(Me.txtText)
        Me.Name = "Form1"
        Me.Text = "Find String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtText As TextBox
    Friend WithEvents txtSearchText As TextBox
    Friend WithEvents lblEnterText As Label
    Friend WithEvents lblSearchText As Label
    Friend WithEvents lblPositionMessage As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnFindString As Button
End Class
