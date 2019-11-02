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
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpFixings = New System.Windows.Forms.GroupBox()
        Me.chkMayonnaise = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.grpSize.SuspendLayout()
        Me.grpFixings.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.radLarge)
        Me.grpSize.Controls.Add(Me.radSmall)
        Me.grpSize.Location = New System.Drawing.Point(23, 12)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(122, 66)
        Me.grpSize.TabIndex = 0
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Sandwich size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(6, 43)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(48, 17)
        Me.radLarge.TabIndex = 1
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(6, 19)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(50, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpFixings
        '
        Me.grpFixings.Controls.Add(Me.chkMayonnaise)
        Me.grpFixings.Controls.Add(Me.chkCheese)
        Me.grpFixings.Controls.Add(Me.chkOnion)
        Me.grpFixings.Controls.Add(Me.chkMustard)
        Me.grpFixings.Controls.Add(Me.chkTomato)
        Me.grpFixings.Controls.Add(Me.chkLettuce)
        Me.grpFixings.Location = New System.Drawing.Point(23, 108)
        Me.grpFixings.Name = "grpFixings"
        Me.grpFixings.Size = New System.Drawing.Size(224, 87)
        Me.grpFixings.TabIndex = 1
        Me.grpFixings.TabStop = False
        Me.grpFixings.Text = "Fixings"
        '
        'chkMayonnaise
        '
        Me.chkMayonnaise.AutoSize = True
        Me.chkMayonnaise.Location = New System.Drawing.Point(142, 55)
        Me.chkMayonnaise.Name = "chkMayonnaise"
        Me.chkMayonnaise.Size = New System.Drawing.Size(83, 17)
        Me.chkMayonnaise.TabIndex = 5
        Me.chkMayonnaise.Text = "Mayonnaise"
        Me.chkMayonnaise.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(74, 55)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 4
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(6, 55)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(54, 17)
        Me.chkOnion.TabIndex = 3
        Me.chkOnion.Text = "Onion"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(142, 19)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(64, 17)
        Me.chkMustard.TabIndex = 2
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(74, 19)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 1
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(6, 19)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 0
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(26, 215)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 2
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(154, 215)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "Place Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.grpFixings)
        Me.Controls.Add(Me.grpSize)
        Me.Name = "Form1"
        Me.Text = "Sandwich Order"
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpFixings.ResumeLayout(False)
        Me.grpFixings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents grpFixings As GroupBox
    Friend WithEvents chkMayonnaise As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents chkOnion As CheckBox
    Friend WithEvents chkMustard As CheckBox
    Friend WithEvents chkTomato As CheckBox
    Friend WithEvents chkLettuce As CheckBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnOrder As Button
End Class
