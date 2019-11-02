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
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.grpMagazine = New System.Windows.Forms.GroupBox()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radOversized = New System.Windows.Forms.RadioButton()
        Me.grpMagazine.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(34, 49)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(140, 13)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Enter quantity of magazines:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(45, 212)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(66, 13)
        Me.lblCost.TabIndex = 1
        Me.lblCost.Text = "Mailing cost:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(180, 49)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(92, 20)
        Me.txtQuantity.TabIndex = 2
        '
        'grpMagazine
        '
        Me.grpMagazine.Controls.Add(Me.radOversized)
        Me.grpMagazine.Controls.Add(Me.radRegular)
        Me.grpMagazine.Location = New System.Drawing.Point(48, 112)
        Me.grpMagazine.Name = "grpMagazine"
        Me.grpMagazine.Size = New System.Drawing.Size(224, 82)
        Me.grpMagazine.TabIndex = 3
        Me.grpMagazine.TabStop = False
        Me.grpMagazine.Text = "Select a magazine size"
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(6, 32)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(62, 17)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radOversized
        '
        Me.radOversized.AutoSize = True
        Me.radOversized.Location = New System.Drawing.Point(116, 32)
        Me.radOversized.Name = "radOversized"
        Me.radOversized.Size = New System.Drawing.Size(72, 17)
        Me.radOversized.TabIndex = 1
        Me.radOversized.TabStop = True
        Me.radOversized.Text = "Oversized"
        Me.radOversized.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.grpMagazine)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblQuantity)
        Me.Name = "Form1"
        Me.Text = "Mailing Cost"
        Me.grpMagazine.ResumeLayout(False)
        Me.grpMagazine.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents grpMagazine As GroupBox
    Friend WithEvents radOversized As RadioButton
    Friend WithEvents radRegular As RadioButton
End Class
