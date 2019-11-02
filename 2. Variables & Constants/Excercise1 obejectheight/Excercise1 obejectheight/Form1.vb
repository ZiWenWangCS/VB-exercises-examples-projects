Public Class Form1
    Private Sub btnHeight_Click(sender As Object, e As EventArgs) Handles btnHeight.Click
        Dim height As Double
        Dim second As Double

        second = Val(Me.txtSecond.Text)
        height = 100 - 4.9 * second ^ 2
        Me.lblAnswer.Text = ("The height of the object is:" & height)
    End Sub
End Class
