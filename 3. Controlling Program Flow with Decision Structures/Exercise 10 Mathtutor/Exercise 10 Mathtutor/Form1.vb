Public Class Form1
    Dim ranNum1 As Integer
    Dim ranNum2 As Integer
    Dim ranOperator As Integer
    Dim solution As Integer
    Dim userGuess As Integer




    Private Sub btnProblem_Click(sender As Object, e As EventArgs) Handles btnProblem.Click
        Randomize()
        ranNum1 = Int((10 - 1 + 1) * Rnd() + 1) ' between 1-10
        ranNum2 = Int((10 - 1 + 1) * Rnd() + 1)
        ranOperator = Int(4 * Rnd() + 1) ' between 1-4

        Me.lblNum1.Text = ranNum1 'displays the two num
        Me.lblNum2.Text = ranNum2
        If ranOperator = 1 Then
            Me.lblOperator.Text = "*"
            solution = ranNum1 * ranNum2
        ElseIf ranOperator = 2 Then
            Me.lblOperator.Text = "+"
            solution = ranNum1 + ranNum2
        ElseIf ranOperator = 3 Then
            Me.lblOperator.Text = "-"
            solution = ranNum1 - ranNum2
        Else
            Me.lblOperator.Text = "/"
            solution = ranNum1 / ranNum2
        End If

    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        userGuess = Val(Me.txtAnswer.Text)
        If solution = userGuess Then
            Me.lblCheck.Text = "you are correct!"
        Else
            Me.lblCheck.Text = "Incorrect"
        End If

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Me.lblCheck.Text = ("The answer is " & solution)
    End Sub
End Class
