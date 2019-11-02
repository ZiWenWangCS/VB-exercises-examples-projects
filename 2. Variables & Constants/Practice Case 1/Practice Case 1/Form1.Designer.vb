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
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.grpBook = New System.Windows.Forms.GroupBox()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radOversized = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.grpBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(42, 53)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(119, 13)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Enter quantity of books:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(167, 50)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 1
        '
        'grpBook
        '
        Me.grpBook.Controls.Add(Me.radOversized)
        Me.grpBook.Controls.Add(Me.radRegular)
        Me.grpBook.Location = New System.Drawing.Point(45, 110)
        Me.grpBook.Name = "grpBook"
        Me.grpBook.Size = New System.Drawing.Size(200, 100)
        Me.grpBook.TabIndex = 2
        Me.grpBook.TabStop = False
        Me.grpBook.Text = "Select a book size"
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(6, 46)
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
        Me.radOversized.Location = New System.Drawing.Point(93, 46)
        Me.radOversized.Name = "radOversized"
        Me.radOversized.Size = New System.Drawing.Size(72, 17)
        Me.radOversized.TabIndex = 1
        Me.radOversized.TabStop = True
        Me.radOversized.Text = "Oversized"
        Me.radOversized.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(90, 213)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(83, 13)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Shipping cost: $"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpBook)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Name = "Form1"
        Me.Text = "Shipping Cost"
        Me.grpBook.ResumeLayout(False)
        Me.grpBook.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents grpBook As GroupBox
    Friend WithEvents radOversized As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents lblCost As Label
End Class
