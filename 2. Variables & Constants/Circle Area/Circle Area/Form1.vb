Public Class Form1
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Const pi As Double = 3.14
        Dim circleArea As Integer
        Dim radius As Integer

        radius = Val(Me.txtRadius.Text)
        circleArea = pi * radius ^ 2
        Me.lblAnswer.Text = circleArea
    End Sub
End Class
