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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.lblPerCopy = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(48, 39)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(137, 13)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Enter the number of copies:"
        '
        'txtCopies
        '
        Me.txtCopies.Location = New System.Drawing.Point(191, 36)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(60, 20)
        Me.txtCopies.TabIndex = 1
        '
        'lblPerCopy
        '
        Me.lblPerCopy.AutoSize = True
        Me.lblPerCopy.Location = New System.Drawing.Point(59, 92)
        Me.lblPerCopy.Name = "lblPerCopy"
        Me.lblPerCopy.Size = New System.Drawing.Size(0, 13)
        Me.lblPerCopy.TabIndex = 2
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(59, 137)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalPrice.TabIndex = 3
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(167, 147)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(75, 23)
        Me.btnPrice.TabIndex = 4
        Me.btnPrice.Text = "Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblPerCopy)
        Me.Controls.Add(Me.txtCopies)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "Form1"
        Me.Text = "Printing Prices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents txtCopies As TextBox
    Friend WithEvents lblPerCopy As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents btnPrice As Button
End Class
