Public Class Form1
    ' ziwen
    ' nov 9 2017
    ' exercise 6 page 157 chpater 5
    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        Dim num As Integer
        Dim sum As Integer
        Dim avergae As Integer

        num = Val(txtNumber.Text) ' user number
        For counter As Integer = 1 To num
            sum += counter ' the added up number
        Next counter

        avergae = sum / num ' average number by / sum from num
        Me.lblAnswerMessage.Text = "The average of the number from"
        Me.lblAnswer.Text = ("1 to " & num & " is " & avergae)
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        Me.lblAnswerMessage.Text = Nothing
        Me.lblAnswer.Text = Nothing
    End Sub
End Class
