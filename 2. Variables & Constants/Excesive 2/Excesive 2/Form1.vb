Public Class Form1
    Private Sub bttnAnswer_Click(sender As Object, e As EventArgs) Handles bttnAnswer.Click
        Dim f As Double
        Dim c As Double

        If Me.CelsiusToolStripMenuItem.Checked = True Then
            f = Val(Me.txtTemp.Text)
            c = 5 / 9 * (f - 32)
            Me.lblAnswer.Text = ("The tempture in Celsius is:" & c)
        ElseIf Me.FahrenheitToolStripMenuItem1.Checked = True Then
            c = Val(Me.txtTemp.Text)
            f = (c * 9 / 5) + 32
            Me.lblAnswer.Text = ("The tempture in Fahrenheit is:" & f)
        End If
    End Sub

    Private Sub FahrenheitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FahrenheitToolStripMenuItem1.Click
        Me.FahrenheitToolStripMenuItem1.Checked = True
        Me.CelsiusToolStripMenuItem.Checked = False
        Me.lblTemp.Text = "Please enter the tempture in Celsius"
    End Sub

    Private Sub CelsiusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CelsiusToolStripMenuItem.Click
        Me.CelsiusToolStripMenuItem.Checked = True
        Me.FahrenheitToolStripMenuItem1.Checked = False
        Me.lblTemp.Text = "Please enter the tempture in Fahrenheit"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.bttnAnswer.Text = "Convert"
        Me.lblTemp.Text = "Please select a tempture you want to convert in under Program."
    End Sub
End Class
