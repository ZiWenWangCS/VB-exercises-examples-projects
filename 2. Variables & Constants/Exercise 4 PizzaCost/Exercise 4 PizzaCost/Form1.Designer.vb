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
        Me.lblSize = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(12, 29)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(176, 13)
        Me.lblSize.TabIndex = 0
        Me.lblSize.Text = "Enter the size of the pizza in inches:"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(191, 26)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(55, 20)
        Me.txtSize.TabIndex = 1
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(12, 116)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(0, 13)
        Me.lblCost.TabIndex = 2
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(171, 161)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(75, 23)
        Me.btnCost.TabIndex = 3
        Me.btnCost.Text = "Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 274)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.lblSize)
        Me.Name = "Form1"
        Me.Text = "Pizza Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSize As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCost As Button
End Class
