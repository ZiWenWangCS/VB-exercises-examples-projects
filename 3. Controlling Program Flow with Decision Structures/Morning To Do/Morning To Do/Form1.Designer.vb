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
        Me.chkBed = New System.Windows.Forms.CheckBox()
        Me.chkLunch = New System.Windows.Forms.CheckBox()
        Me.chkHomework = New System.Windows.Forms.CheckBox()
        Me.chkTeeth = New System.Windows.Forms.CheckBox()
        Me.btnAllDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkBed
        '
        Me.chkBed.AutoSize = True
        Me.chkBed.Location = New System.Drawing.Point(51, 39)
        Me.chkBed.Name = "chkBed"
        Me.chkBed.Size = New System.Drawing.Size(74, 17)
        Me.chkBed.TabIndex = 0
        Me.chkBed.Text = "Make bed"
        Me.chkBed.UseVisualStyleBackColor = True
        '
        'chkLunch
        '
        Me.chkLunch.AutoSize = True
        Me.chkLunch.Location = New System.Drawing.Point(51, 92)
        Me.chkLunch.Name = "chkLunch"
        Me.chkLunch.Size = New System.Drawing.Size(80, 17)
        Me.chkLunch.TabIndex = 1
        Me.chkLunch.Text = "Pack lunch"
        Me.chkLunch.UseVisualStyleBackColor = True
        '
        'chkHomework
        '
        Me.chkHomework.AutoSize = True
        Me.chkHomework.Location = New System.Drawing.Point(51, 131)
        Me.chkHomework.Name = "chkHomework"
        Me.chkHomework.Size = New System.Drawing.Size(110, 17)
        Me.chkHomework.TabIndex = 2
        Me.chkHomework.Text = "Gather homework"
        Me.chkHomework.UseVisualStyleBackColor = True
        '
        'chkTeeth
        '
        Me.chkTeeth.AutoSize = True
        Me.chkTeeth.Location = New System.Drawing.Point(51, 170)
        Me.chkTeeth.Name = "chkTeeth"
        Me.chkTeeth.Size = New System.Drawing.Size(84, 17)
        Me.chkTeeth.TabIndex = 3
        Me.chkTeeth.Text = "Brush Teeth"
        Me.chkTeeth.UseVisualStyleBackColor = True
        '
        'btnAllDone
        '
        Me.btnAllDone.Location = New System.Drawing.Point(97, 220)
        Me.btnAllDone.Name = "btnAllDone"
        Me.btnAllDone.Size = New System.Drawing.Size(102, 29)
        Me.btnAllDone.TabIndex = 4
        Me.btnAllDone.Text = "All Done!"
        Me.btnAllDone.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnAllDone)
        Me.Controls.Add(Me.chkTeeth)
        Me.Controls.Add(Me.chkHomework)
        Me.Controls.Add(Me.chkLunch)
        Me.Controls.Add(Me.chkBed)
        Me.Name = "Form1"
        Me.Text = "Morning To Do"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBed As CheckBox
    Friend WithEvents chkLunch As CheckBox
    Friend WithEvents chkHomework As CheckBox
    Friend WithEvents chkTeeth As CheckBox
    Friend WithEvents btnAllDone As Button
End Class
