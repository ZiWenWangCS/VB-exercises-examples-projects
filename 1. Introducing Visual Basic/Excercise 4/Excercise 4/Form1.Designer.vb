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
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.radYale = New System.Windows.Forms.RadioButton()
        Me.radVincentMassey = New System.Windows.Forms.RadioButton()
        Me.radMeadows = New System.Windows.Forms.RadioButton()
        Me.radHarvard = New System.Windows.Forms.RadioButton()
        Me.radWaterloo = New System.Windows.Forms.RadioButton()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp
        '
        Me.grp.Controls.Add(Me.radWaterloo)
        Me.grp.Controls.Add(Me.radHarvard)
        Me.grp.Controls.Add(Me.radMeadows)
        Me.grp.Controls.Add(Me.radVincentMassey)
        Me.grp.Controls.Add(Me.radYale)
        Me.grp.Location = New System.Drawing.Point(26, 39)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(112, 169)
        Me.grp.TabIndex = 0
        Me.grp.TabStop = False
        Me.grp.Text = "School Information"
        '
        'radYale
        '
        Me.radYale.AutoSize = True
        Me.radYale.Location = New System.Drawing.Point(16, 35)
        Me.radYale.Name = "radYale"
        Me.radYale.Size = New System.Drawing.Size(46, 17)
        Me.radYale.TabIndex = 0
        Me.radYale.TabStop = True
        Me.radYale.Text = "Yale"
        Me.radYale.UseVisualStyleBackColor = True
        '
        'radVincentMassey
        '
        Me.radVincentMassey.AutoSize = True
        Me.radVincentMassey.Location = New System.Drawing.Point(16, 68)
        Me.radVincentMassey.Name = "radVincentMassey"
        Me.radVincentMassey.Size = New System.Drawing.Size(100, 17)
        Me.radVincentMassey.TabIndex = 1
        Me.radVincentMassey.TabStop = True
        Me.radVincentMassey.Text = "Vincent Massey"
        Me.radVincentMassey.UseVisualStyleBackColor = True
        '
        'radMeadows
        '
        Me.radMeadows.AutoSize = True
        Me.radMeadows.Location = New System.Drawing.Point(16, 101)
        Me.radMeadows.Name = "radMeadows"
        Me.radMeadows.Size = New System.Drawing.Size(71, 17)
        Me.radMeadows.TabIndex = 2
        Me.radMeadows.TabStop = True
        Me.radMeadows.Text = "Meadows"
        Me.radMeadows.UseVisualStyleBackColor = True
        '
        'radHarvard
        '
        Me.radHarvard.AutoSize = True
        Me.radHarvard.Location = New System.Drawing.Point(16, 124)
        Me.radHarvard.Name = "radHarvard"
        Me.radHarvard.Size = New System.Drawing.Size(63, 17)
        Me.radHarvard.TabIndex = 3
        Me.radHarvard.TabStop = True
        Me.radHarvard.Text = "Harvard"
        Me.radHarvard.UseVisualStyleBackColor = True
        '
        'radWaterloo
        '
        Me.radWaterloo.AutoSize = True
        Me.radWaterloo.Location = New System.Drawing.Point(16, 152)
        Me.radWaterloo.Name = "radWaterloo"
        Me.radWaterloo.Size = New System.Drawing.Size(68, 17)
        Me.radWaterloo.TabIndex = 4
        Me.radWaterloo.TabStop = True
        Me.radWaterloo.Text = "Waterloo"
        Me.radWaterloo.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(164, 72)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(0, 13)
        Me.lblLocation.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.grp)
        Me.Name = "Form1"
        Me.Text = "School Information"
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp As GroupBox
    Friend WithEvents radWaterloo As RadioButton
    Friend WithEvents radHarvard As RadioButton
    Friend WithEvents radMeadows As RadioButton
    Friend WithEvents radVincentMassey As RadioButton
    Friend WithEvents radYale As RadioButton
    Friend WithEvents lblLocation As Label
End Class
