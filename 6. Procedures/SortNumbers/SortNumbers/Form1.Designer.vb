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
        Me.lblFirstPrompt = New System.Windows.Forms.Label()
        Me.lblSecNumber = New System.Windows.Forms.Label()
        Me.lblSortedNum = New System.Windows.Forms.Label()
        Me.txtFirstNum = New System.Windows.Forms.TextBox()
        Me.txtSecNum = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirstPrompt
        '
        Me.lblFirstPrompt.AutoSize = True
        Me.lblFirstPrompt.Location = New System.Drawing.Point(31, 43)
        Me.lblFirstPrompt.Name = "lblFirstPrompt"
        Me.lblFirstPrompt.Size = New System.Drawing.Size(92, 13)
        Me.lblFirstPrompt.TabIndex = 0
        Me.lblFirstPrompt.Text = "Enter first number:"
        '
        'lblSecNumber
        '
        Me.lblSecNumber.AutoSize = True
        Me.lblSecNumber.Location = New System.Drawing.Point(31, 86)
        Me.lblSecNumber.Name = "lblSecNumber"
        Me.lblSecNumber.Size = New System.Drawing.Size(111, 13)
        Me.lblSecNumber.TabIndex = 1
        Me.lblSecNumber.Text = "Enter second number:"
        '
        'lblSortedNum
        '
        Me.lblSortedNum.AutoSize = True
        Me.lblSortedNum.Location = New System.Drawing.Point(202, 210)
        Me.lblSortedNum.Name = "lblSortedNum"
        Me.lblSortedNum.Size = New System.Drawing.Size(0, 13)
        Me.lblSortedNum.TabIndex = 2
        '
        'txtFirstNum
        '
        Me.txtFirstNum.Location = New System.Drawing.Point(153, 40)
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstNum.TabIndex = 3
        '
        'txtSecNum
        '
        Me.txtSecNum.Location = New System.Drawing.Point(153, 83)
        Me.txtSecNum.Name = "txtSecNum"
        Me.txtSecNum.Size = New System.Drawing.Size(100, 20)
        Me.txtSecNum.TabIndex = 4
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(48, 210)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 5
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.txtSecNum)
        Me.Controls.Add(Me.txtFirstNum)
        Me.Controls.Add(Me.lblSortedNum)
        Me.Controls.Add(Me.lblSecNumber)
        Me.Controls.Add(Me.lblFirstPrompt)
        Me.Name = "Form1"
        Me.Text = "Sort Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstPrompt As Label
    Friend WithEvents lblSecNumber As Label
    Friend WithEvents lblSortedNum As Label
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents txtSecNum As TextBox
    Friend WithEvents btnSort As Button
End Class
