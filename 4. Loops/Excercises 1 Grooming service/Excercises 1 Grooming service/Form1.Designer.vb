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
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.chkShampoo = New System.Windows.Forms.CheckBox()
        Me.chkTrim = New System.Windows.Forms.CheckBox()
        Me.chkFleaDip = New System.Windows.Forms.CheckBox()
        Me.chkFullShave = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.grpSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.chkFullShave)
        Me.grpSelect.Controls.Add(Me.chkFleaDip)
        Me.grpSelect.Controls.Add(Me.chkTrim)
        Me.grpSelect.Controls.Add(Me.chkShampoo)
        Me.grpSelect.Location = New System.Drawing.Point(12, 58)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Size = New System.Drawing.Size(260, 110)
        Me.grpSelect.TabIndex = 0
        Me.grpSelect.TabStop = False
        Me.grpSelect.Text = "Select the pet grooming services"
        '
        'chkShampoo
        '
        Me.chkShampoo.AutoSize = True
        Me.chkShampoo.Location = New System.Drawing.Point(18, 31)
        Me.chkShampoo.Name = "chkShampoo"
        Me.chkShampoo.Size = New System.Drawing.Size(95, 17)
        Me.chkShampoo.TabIndex = 0
        Me.chkShampoo.Text = "Shampoo $ 15"
        Me.chkShampoo.UseVisualStyleBackColor = True
        '
        'chkTrim
        '
        Me.chkTrim.AutoSize = True
        Me.chkTrim.Location = New System.Drawing.Point(142, 31)
        Me.chkTrim.Name = "chkTrim"
        Me.chkTrim.Size = New System.Drawing.Size(70, 17)
        Me.chkTrim.TabIndex = 1
        Me.chkTrim.Text = "Trim $ 15"
        Me.chkTrim.UseVisualStyleBackColor = True
        '
        'chkFleaDip
        '
        Me.chkFleaDip.AutoSize = True
        Me.chkFleaDip.Location = New System.Drawing.Point(18, 76)
        Me.chkFleaDip.Name = "chkFleaDip"
        Me.chkFleaDip.Size = New System.Drawing.Size(89, 17)
        Me.chkFleaDip.TabIndex = 2
        Me.chkFleaDip.Text = "Flea Dip $ 15"
        Me.chkFleaDip.UseVisualStyleBackColor = True
        '
        'chkFullShave
        '
        Me.chkFullShave.AutoSize = True
        Me.chkFullShave.Location = New System.Drawing.Point(142, 76)
        Me.chkFullShave.Name = "chkFullShave"
        Me.chkFullShave.Size = New System.Drawing.Size(100, 17)
        Me.chkFullShave.TabIndex = 3
        Me.chkFullShave.Text = "Full Shave $ 20"
        Me.chkFullShave.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(107, 215)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.grpSelect)
        Me.Name = "Form1"
        Me.Text = "Grooming Services"
        Me.grpSelect.ResumeLayout(False)
        Me.grpSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSelect As GroupBox
    Friend WithEvents chkFullShave As CheckBox
    Friend WithEvents chkFleaDip As CheckBox
    Friend WithEvents chkTrim As CheckBox
    Friend WithEvents chkShampoo As CheckBox
    Friend WithEvents lblPrice As Label
End Class
