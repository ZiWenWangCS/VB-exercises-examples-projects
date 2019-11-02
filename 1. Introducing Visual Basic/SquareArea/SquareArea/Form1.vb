Public Class SquareArea
    'Ziwenwang
    'sept 19
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim side As Integer = 5 'side of square
        Dim area As Integer

        area = side * side
        Me.lblAnswer.Text = area 'display answer
    End Sub
End Class
