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
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.btnCoins = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(42, 35)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(132, 13)
        Me.lblChange.TabIndex = 0
        Me.lblChange.Text = "Enter the change in cents:"
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(42, 79)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(0, 13)
        Me.lblQuarters.TabIndex = 1
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(42, 115)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(0, 13)
        Me.lblDimes.TabIndex = 2
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(42, 151)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(0, 13)
        Me.lblNickels.TabIndex = 3
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(42, 186)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(0, 13)
        Me.lblPennies.TabIndex = 4
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(180, 35)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(57, 20)
        Me.txtChange.TabIndex = 5
        '
        'btnCoins
        '
        Me.btnCoins.Location = New System.Drawing.Point(180, 176)
        Me.btnCoins.Name = "btnCoins"
        Me.btnCoins.Size = New System.Drawing.Size(75, 23)
        Me.btnCoins.TabIndex = 6
        Me.btnCoins.Text = "Coins"
        Me.btnCoins.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCoins)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblChange)
        Me.Name = "Form1"
        Me.Text = "Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChange As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents lblPennies As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents btnCoins As Button
End Class
