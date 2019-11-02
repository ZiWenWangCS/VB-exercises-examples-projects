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
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkWaiting = New System.Windows.Forms.CheckBox()
        Me.chkForwarding = New System.Windows.Forms.CheckBox()
        Me.chkID = New System.Windows.Forms.CheckBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkID)
        Me.grpOptions.Controls.Add(Me.chkForwarding)
        Me.grpOptions.Controls.Add(Me.chkWaiting)
        Me.grpOptions.Location = New System.Drawing.Point(47, 45)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(200, 140)
        Me.grpOptions.TabIndex = 0
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Select Options"
        '
        'chkWaiting
        '
        Me.chkWaiting.AutoSize = True
        Me.chkWaiting.Location = New System.Drawing.Point(28, 34)
        Me.chkWaiting.Name = "chkWaiting"
        Me.chkWaiting.Size = New System.Drawing.Size(82, 17)
        Me.chkWaiting.TabIndex = 0
        Me.chkWaiting.Text = "Call Waiting"
        Me.chkWaiting.UseVisualStyleBackColor = True
        '
        'chkForwarding
        '
        Me.chkForwarding.AutoSize = True
        Me.chkForwarding.Location = New System.Drawing.Point(28, 66)
        Me.chkForwarding.Name = "chkForwarding"
        Me.chkForwarding.Size = New System.Drawing.Size(98, 17)
        Me.chkForwarding.TabIndex = 1
        Me.chkForwarding.Text = "Call Forwarding"
        Me.chkForwarding.UseVisualStyleBackColor = True
        '
        'chkID
        '
        Me.chkID.AutoSize = True
        Me.chkID.Location = New System.Drawing.Point(28, 102)
        Me.chkID.Name = "chkID"
        Me.chkID.Size = New System.Drawing.Size(66, 17)
        Me.chkID.TabIndex = 2
        Me.chkID.Text = "Caller ID"
        Me.chkID.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(193, 204)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 1
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(43, 204)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(98, 36)
        Me.btnTotal.TabIndex = 2
        Me.btnTotal.Text = "Calculate"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.grpOptions)
        Me.Name = "Form1"
        Me.Text = "Phone Bill"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents chkID As CheckBox
    Friend WithEvents chkForwarding As CheckBox
    Friend WithEvents chkWaiting As CheckBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnTotal As Button
End Class
