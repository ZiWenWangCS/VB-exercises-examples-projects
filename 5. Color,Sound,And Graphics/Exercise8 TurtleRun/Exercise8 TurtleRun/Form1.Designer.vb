﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSlow = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnFast = New System.Windows.Forms.Button()
        Me.picTurtle = New System.Windows.Forms.PictureBox()
        Me.tmrSlow = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAverage = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFast = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picTurtle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSlow
        '
        Me.btnSlow.BackColor = System.Drawing.Color.White
        Me.btnSlow.Location = New System.Drawing.Point(22, 212)
        Me.btnSlow.Name = "btnSlow"
        Me.btnSlow.Size = New System.Drawing.Size(75, 23)
        Me.btnSlow.TabIndex = 0
        Me.btnSlow.Text = "Slow"
        Me.btnSlow.UseVisualStyleBackColor = False
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.Color.White
        Me.btnAverage.Location = New System.Drawing.Point(103, 212)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(75, 23)
        Me.btnAverage.TabIndex = 1
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = False
        '
        'btnFast
        '
        Me.btnFast.BackColor = System.Drawing.Color.White
        Me.btnFast.Location = New System.Drawing.Point(184, 212)
        Me.btnFast.Name = "btnFast"
        Me.btnFast.Size = New System.Drawing.Size(75, 23)
        Me.btnFast.TabIndex = 2
        Me.btnFast.Text = "Fast"
        Me.btnFast.UseVisualStyleBackColor = False
        '
        'picTurtle
        '
        Me.picTurtle.Location = New System.Drawing.Point(22, 44)
        Me.picTurtle.Name = "picTurtle"
        Me.picTurtle.Size = New System.Drawing.Size(237, 162)
        Me.picTurtle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTurtle.TabIndex = 3
        Me.picTurtle.TabStop = False
        '
        'tmrSlow
        '
        '
        'tmrAverage
        '
        '
        'tmrFast
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.picTurtle)
        Me.Controls.Add(Me.btnFast)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnSlow)
        Me.Name = "Form1"
        Me.Text = "Turtle Run"
        CType(Me.picTurtle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSlow As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnFast As Button
    Friend WithEvents picTurtle As PictureBox
    Friend WithEvents tmrSlow As Timer
    Friend WithEvents tmrAverage As Timer
    Friend WithEvents tmrFast As Timer
End Class
