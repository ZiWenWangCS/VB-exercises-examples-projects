Public Class Form1
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim num1, num2 As Integer
        Dim answer As Integer

        num1 = Val(Me.numNumber1.Value)
        num2 = Val(Me.numNumber2.Value)
        answer = num1 * num2

        Me.lblAnswer.Text = answer
    End Sub
End Class
