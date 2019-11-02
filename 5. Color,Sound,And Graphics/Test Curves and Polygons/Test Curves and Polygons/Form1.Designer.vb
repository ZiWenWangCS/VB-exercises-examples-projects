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
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.lblDrawCurve = New System.Windows.Forms.Label()
        Me.lblDrawClosedCurved = New System.Windows.Forms.Label()
        Me.lblFillClosedCurve = New System.Windows.Forms.Label()
        Me.lblDrawPolygon = New System.Windows.Forms.Label()
        Me.lblFillPolygon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(320, 259)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(60, 26)
        Me.btnDraw.TabIndex = 0
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'lblDrawCurve
        '
        Me.lblDrawCurve.Location = New System.Drawing.Point(12, 39)
        Me.lblDrawCurve.Name = "lblDrawCurve"
        Me.lblDrawCurve.Size = New System.Drawing.Size(100, 100)
        Me.lblDrawCurve.TabIndex = 1
        Me.lblDrawCurve.Text = "DrawCurve"
        '
        'lblDrawClosedCurved
        '
        Me.lblDrawClosedCurved.Location = New System.Drawing.Point(118, 39)
        Me.lblDrawClosedCurved.Name = "lblDrawClosedCurved"
        Me.lblDrawClosedCurved.Size = New System.Drawing.Size(150, 100)
        Me.lblDrawClosedCurved.TabIndex = 2
        Me.lblDrawClosedCurved.Text = "DrawClosedCurve"
        '
        'lblFillClosedCurve
        '
        Me.lblFillClosedCurve.Location = New System.Drawing.Point(272, 39)
        Me.lblFillClosedCurve.Name = "lblFillClosedCurve"
        Me.lblFillClosedCurve.Size = New System.Drawing.Size(129, 100)
        Me.lblFillClosedCurve.TabIndex = 3
        Me.lblFillClosedCurve.Text = "FillClosedCurve"
        '
        'lblDrawPolygon
        '
        Me.lblDrawPolygon.Location = New System.Drawing.Point(21, 189)
        Me.lblDrawPolygon.Name = "lblDrawPolygon"
        Me.lblDrawPolygon.Size = New System.Drawing.Size(125, 100)
        Me.lblDrawPolygon.TabIndex = 4
        Me.lblDrawPolygon.Text = "DrawPolygon"
        '
        'lblFillPolygon
        '
        Me.lblFillPolygon.Location = New System.Drawing.Point(165, 189)
        Me.lblFillPolygon.Name = "lblFillPolygon"
        Me.lblFillPolygon.Size = New System.Drawing.Size(124, 100)
        Me.lblFillPolygon.TabIndex = 5
        Me.lblFillPolygon.Text = "FillPolygon"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 297)
        Me.Controls.Add(Me.lblFillPolygon)
        Me.Controls.Add(Me.lblDrawPolygon)
        Me.Controls.Add(Me.lblFillClosedCurve)
        Me.Controls.Add(Me.lblDrawClosedCurved)
        Me.Controls.Add(Me.lblDrawCurve)
        Me.Controls.Add(Me.btnDraw)
        Me.Name = "Form1"
        Me.Text = "Test Curves and Polygons"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDraw As Button
    Friend WithEvents lblDrawCurve As Label
    Friend WithEvents lblDrawClosedCurved As Label
    Friend WithEvents lblFillClosedCurve As Label
    Friend WithEvents lblDrawPolygon As Label
    Friend WithEvents lblFillPolygon As Label
End Class
