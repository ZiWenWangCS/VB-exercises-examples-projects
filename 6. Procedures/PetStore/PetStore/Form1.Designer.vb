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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.lblPetInfo = New System.Windows.Forms.Label()
        Me.picPetPhoto = New System.Windows.Forms.PictureBox()
        Me.btnGetInfo = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.picPetPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(44, 39)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(106, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the type of pet:"
        '
        'txtPetName
        '
        Me.txtPetName.Location = New System.Drawing.Point(156, 36)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(100, 20)
        Me.txtPetName.TabIndex = 1
        '
        'lblPetInfo
        '
        Me.lblPetInfo.Location = New System.Drawing.Point(34, 90)
        Me.lblPetInfo.Name = "lblPetInfo"
        Me.lblPetInfo.Size = New System.Drawing.Size(172, 108)
        Me.lblPetInfo.TabIndex = 2
        '
        'picPetPhoto
        '
        Me.picPetPhoto.BackColor = System.Drawing.SystemColors.Control
        Me.picPetPhoto.Location = New System.Drawing.Point(232, 97)
        Me.picPetPhoto.Name = "picPetPhoto"
        Me.picPetPhoto.Size = New System.Drawing.Size(100, 100)
        Me.picPetPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPetPhoto.TabIndex = 3
        Me.picPetPhoto.TabStop = False
        '
        'btnGetInfo
        '
        Me.btnGetInfo.Location = New System.Drawing.Point(262, 36)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(80, 20)
        Me.btnGetInfo.TabIndex = 4
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(76, 255)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://www.lvp.com/petsotre"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 305)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnGetInfo)
        Me.Controls.Add(Me.picPetPhoto)
        Me.Controls.Add(Me.lblPetInfo)
        Me.Controls.Add(Me.txtPetName)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Pets"
        CType(Me.picPetPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents lblPetInfo As Label
    Friend WithEvents picPetPhoto As PictureBox
    Friend WithEvents btnGetInfo As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
