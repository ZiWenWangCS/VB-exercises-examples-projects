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
        Me.lblMPH = New System.Windows.Forms.Label()
        Me.txtMPH = New System.Windows.Forms.TextBox()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMPH
        '
        Me.lblMPH.AutoSize = True
        Me.lblMPH.Location = New System.Drawing.Point(31, 52)
        Me.lblMPH.Name = "lblMPH"
        Me.lblMPH.Size = New System.Drawing.Size(125, 13)
        Me.lblMPH.TabIndex = 0
        Me.lblMPH.Text = "Enter wind speed (MPH):"
        '
        'txtMPH
        '
        Me.txtMPH.Location = New System.Drawing.Point(171, 49)
        Me.txtMPH.Name = "txtMPH"
        Me.txtMPH.Size = New System.Drawing.Size(51, 20)
        Me.txtMPH.TabIndex = 1
        '
        'btnCategory
        '
        Me.btnCategory.Location = New System.Drawing.Point(94, 114)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(75, 23)
        Me.btnCategory.TabIndex = 2
        Me.btnCategory.Text = "Category"
        Me.btnCategory.UseVisualStyleBackColor = True
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(93, 194)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(0, 13)
        Me.lblCategory.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.btnCategory)
        Me.Controls.Add(Me.txtMPH)
        Me.Controls.Add(Me.lblMPH)
        Me.Name = "Form1"
        Me.Text = "Hurricane"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMPH As Label
    Friend WithEvents txtMPH As TextBox
    Friend WithEvents btnCategory As Button
    Friend WithEvents lblCategory As Label
End Class
