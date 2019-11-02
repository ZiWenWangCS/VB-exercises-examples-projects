Public Class Form1
    Dim numberOfScores As Integer = 0
    Dim sumOfScores As Integer = 0

    Private Sub btnEnterScores_Click(sender As Object, e As EventArgs) Handles btnEnterScores.Click
        Const TITLE As String = "Score"
        Const PROMPT As String = "Enter a score (-1 to stop):"
        Const FLAG As Integer = -1
        Dim tempScore As String
        Dim newScore As Integer
        numberOfScores = 0 'reinitialize global counter
        sumOfScores = 0 'reinitialize blobal accumulator

        'clear labels
        Me.lblAverageMessage.Text = Nothing
        Me.lblAverage.Text = Nothing
        Me.lblScoresMessage.Text = Nothing
        Me.lblNumerofScores.Text = Nothing

        ' get scores
        tempScore = InputBox(PROMPT, TITLE)
        Do While tempScore <> Nothing And Val(tempScore) <> FLAG
            newScore = Val(tempScore)
            numberOfScores += 1 ' update scores count
            sumOfScores += newScore ' update scores sum
            tempScore = InputBox(PROMPT, TITLE) ' get next score
        Loop

        Me.lblScoresMessage.Text = "socres entered:"
        Me.lblNumerofScores.Text = numberOfScores
    End Sub

    Private Sub btnAverageScore_Click(sender As Object, e As EventArgs) Handles btnAverageScore.Click
        Dim average As Double
        Me.lblAverageMessage.Text = "Average Score:"
        If numberOfScores > 0 Then
            average = sumOfScores / numberOfScores ' compute average
            Me.lblAverage.Text = average
        Else
            Me.lblAverage.Text = 0
        End If
    End Sub
End Class
