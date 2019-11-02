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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnFork1 = New System.Windows.Forms.Button()
        Me.btnFork2 = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnFork3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(250, 28)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(187, 56)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "btnStart"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnFork1
        '
        Me.btnFork1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFork1.Location = New System.Drawing.Point(250, 90)
        Me.btnFork1.Name = "btnFork1"
        Me.btnFork1.Size = New System.Drawing.Size(187, 56)
        Me.btnFork1.TabIndex = 1
        Me.btnFork1.Text = "btnFork1"
        Me.btnFork1.UseVisualStyleBackColor = True
        '
        'btnFork2
        '
        Me.btnFork2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFork2.Location = New System.Drawing.Point(250, 174)
        Me.btnFork2.Name = "btnFork2"
        Me.btnFork2.Size = New System.Drawing.Size(187, 56)
        Me.btnFork2.TabIndex = 2
        Me.btnFork2.Text = "btnFork2"
        Me.btnFork2.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(33, 28)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(149, 167)
        Me.lblPrompt.TabIndex = 3
        Me.lblPrompt.Text = "lblPrompt"
        '
        'btnFork3
        '
        Me.btnFork3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFork3.Location = New System.Drawing.Point(250, 258)
        Me.btnFork3.Name = "btnFork3"
        Me.btnFork3.Size = New System.Drawing.Size(187, 56)
        Me.btnFork3.TabIndex = 4
        Me.btnFork3.Text = "btnFork3"
        Me.btnFork3.UseVisualStyleBackColor = True
        Me.btnFork3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 364)
        Me.Controls.Add(Me.btnFork3)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnFork2)
        Me.Controls.Add(Me.btnFork1)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "btnFork3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnFork1 As Button
    Friend WithEvents btnFork2 As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnFork3 As Button
End Class
