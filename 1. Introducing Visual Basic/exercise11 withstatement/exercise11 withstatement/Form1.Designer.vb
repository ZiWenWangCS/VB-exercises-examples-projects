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
        Me.lblCity = New System.Windows.Forms.Label()
        Me.btt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCity
        '
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(12, 94)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(312, 143)
        Me.lblCity.TabIndex = 0
        Me.lblCity.Text = "city"
        '
        'btt
        '
        Me.btt.Location = New System.Drawing.Point(185, 94)
        Me.btt.Name = "btt"
        Me.btt.Size = New System.Drawing.Size(75, 23)
        Me.btt.TabIndex = 1
        Me.btt.Text = "idk"
        Me.btt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 331)
        Me.Controls.Add(Me.btt)
        Me.Controls.Add(Me.lblCity)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCity As Label
    Friend WithEvents btt As Button
End Class