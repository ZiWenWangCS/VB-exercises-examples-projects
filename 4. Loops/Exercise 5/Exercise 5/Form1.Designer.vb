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
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.btnMonogram = New System.Windows.Forms.Button()
        Me.lblInitials = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 42)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(190, 26)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter your first, middle, and last names " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "separated by a space:"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(15, 89)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(187, 20)
        Me.txtFullName.TabIndex = 1
        '
        'btnMonogram
        '
        Me.btnMonogram.Location = New System.Drawing.Point(33, 192)
        Me.btnMonogram.Name = "btnMonogram"
        Me.btnMonogram.Size = New System.Drawing.Size(75, 23)
        Me.btnMonogram.TabIndex = 2
        Me.btnMonogram.Text = "Button1"
        Me.btnMonogram.UseVisualStyleBackColor = True
        '
        'lblInitials
        '
        Me.lblInitials.AutoSize = True
        Me.lblInitials.Location = New System.Drawing.Point(163, 202)
        Me.lblInitials.Name = "lblInitials"
        Me.lblInitials.Size = New System.Drawing.Size(0, 13)
        Me.lblInitials.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblInitials)
        Me.Controls.Add(Me.btnMonogram)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Monogram"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents btnMonogram As Button
    Friend WithEvents lblInitials As Label
End Class
