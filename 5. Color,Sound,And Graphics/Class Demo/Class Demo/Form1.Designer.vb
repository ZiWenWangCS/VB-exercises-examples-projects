<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnClear
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
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.btnErase = New System.Windows.Forms.Button()
        Me.lblDrawingSurface = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(652, 590)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(75, 23)
        Me.btnDraw.TabIndex = 0
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.Location = New System.Drawing.Point(669, 541)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(58, 23)
        Me.btnErase.TabIndex = 1
        Me.btnErase.Text = "Erase"
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'lblDrawingSurface
        '
        Me.lblDrawingSurface.Location = New System.Drawing.Point(21, 13)
        Me.lblDrawingSurface.Name = "lblDrawingSurface"
        Me.lblDrawingSurface.Size = New System.Drawing.Size(600, 600)
        Me.lblDrawingSurface.TabIndex = 2
        Me.lblDrawingSurface.Text = "Drawing Surface"
        '
        'btnClear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.lblDrawingSurface)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.btnDraw)
        Me.Name = "btnClear"
        Me.Text = "Class Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDraw As Button
    Friend WithEvents btnErase As Button
    Friend WithEvents lblDrawingSurface As Label
End Class
