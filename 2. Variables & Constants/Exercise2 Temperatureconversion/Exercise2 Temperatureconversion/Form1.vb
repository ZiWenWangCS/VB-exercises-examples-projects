Public Class Form1
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim f As Double
        Dim c As Double

        If Me.CelsiusToolStripMenuItem.CheckOnClick = True Then
            f = Val(Me.txtTemp.Text)
            c = 5 / 9 * (f - 32)
            Me.lblAnswer.Text = ("The temperature in Celsius is:" & c)
        ElseIf Me.FahrenheitToolStripMenuItem.Checkon = True Then
            c = Val(Me.txtTemp.Text)
            f = (c * 9 / 5) + 32
            Me.lblAnswer.Text = ("The temperature in Fahrenheit is" & f)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub FahrenheitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FahrenheitToolStripMenuItem.Click
        Me.lblAnswer.Text = "The temperture in Fahrenheit is:"
        Me.lblTemp.Text = "Enter the temperature in Celsius:"
        Me.btnAnswer.Text = "Fahrenheit"

    End Sub

    Private Sub CelsiusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CelsiusToolStripMenuItem.Click
        Me.lblTemp.Text = "The temperture in Fahrenheit is:"
        Me.lblAnswer.Text = "Enter the temperture in Celsius is:"
        Me.btnAnswer.Text = "Celsius"
    End Sub


End Class
