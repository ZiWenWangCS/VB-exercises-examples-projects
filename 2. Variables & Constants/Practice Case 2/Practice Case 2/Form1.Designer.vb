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
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.lblCars = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.txtPeople = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Location = New System.Drawing.Point(39, 49)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(91, 13)
        Me.lblPeople.TabIndex = 0
        Me.lblPeople.Text = "Number of people"
        '
        'lblCars
        '
        Me.lblCars.AutoSize = True
        Me.lblCars.Location = New System.Drawing.Point(39, 117)
        Me.lblCars.Name = "lblCars"
        Me.lblCars.Size = New System.Drawing.Size(67, 13)
        Me.lblCars.TabIndex = 1
        Me.lblCars.Text = "Cars needed"
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Location = New System.Drawing.Point(39, 158)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(61, 13)
        Me.lblLeft.TabIndex = 2
        Me.lblLeft.Text = "People Left"
        '
        'txtPeople
        '
        Me.txtPeople.Location = New System.Drawing.Point(149, 46)
        Me.txtPeople.Name = "txtPeople"
        Me.txtPeople.Size = New System.Drawing.Size(100, 20)
        Me.txtPeople.TabIndex = 3
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(274, 49)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 4
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 332)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtPeople)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblCars)
        Me.Controls.Add(Me.lblPeople)
        Me.Name = "Form1"
        Me.Text = "Car pool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPeople As Label
    Friend WithEvents lblCars As Label
    Friend WithEvents lblLeft As Label
    Friend WithEvents txtPeople As TextBox
    Friend WithEvents btnCompute As Button
End Class
