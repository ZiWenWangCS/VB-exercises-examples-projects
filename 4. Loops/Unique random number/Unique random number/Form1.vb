Public Class Form1
    Private Sub btnGenerateNumbers_Click(sender As Object, e As EventArgs) Handles btnGenerateNumbers.Click
        Randomize()
        Dim largestnum As Integer
        Dim largestNumTemp As String
        Dim lowest As Integer = 1
        Dim num1, num2, num3 As Integer
        Dim counter As Integer = 0

        ' clean labels
        Me.lblNumber1.Text = Nothing
        Me.lblNumber2.Text = Nothing
        Me.lblNumber3.Text = Nothing
        Me.lblAnswer.Text = Nothing

        Do
            largestNumTemp = InputBox("Enter a number larger or equal to 3", Me.Text)
            largestnum = Val(largestNumTemp)
        Loop While largestnum < 3

        ' generate the 3 random numbers
        Do
            num1 = Int(largestnum * Rnd() + 1)
            num2 = Int(largestnum * Rnd() + 1)
            num3 = Int(largestnum * Rnd() + 1)
            counter += 1
        Loop While (num1 = num2 Or num2 = num3 Or num1 = num3)

        Me.lblNumber1.Text = num1
        Me.lblNumber2.Text = num2
        Me.lblNumber3.Text = num3
        Me.lblAnswer.Text = counter
        Me.lblExplanation.Text = "Lopp iterations were needed to
generate three unique numbers."

    End Sub
End Class
