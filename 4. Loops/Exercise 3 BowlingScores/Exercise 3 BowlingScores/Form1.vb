Public Class Form1
    Dim highScore As Integer = 0
    Dim lowScore As Integer = 30000
    Dim sumofscores As Integer = 0
    Dim numofscores As Integer = 0

    Private Sub btnEnterScore_Click(sender As Object, e As EventArgs) Handles btnEnterScore.Click
        Dim tempscore As String
        Dim newscore As String
        Dim flag As Integer = -1

        highScore = 0
        lowScore = 30000
        sumofscores = 0
        numofscores = 0 'reinitialize low, high, accumulater and counter

        tempscore = InputBox("Enter a score (-1 to stop):", "Score")
        Do While tempscore <> Nothing And Val(tempscore) <> flag
            newscore = Val(tempscore)
            numofscores += 1
            sumofscores += newscore
            If highScore < newscore Then
                highScore = newscore
            End If
            If lowScore > newscore Then
                lowScore = newscore
            End If
            tempscore = InputBox("Enter a score (-1 to stop):", "Score")
        Loop
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Dim average As Double
        Me.lblScore.Text = ("The high score is " & highScore & " and the low score is " & lowScore)
        average = sumofscores / numofscores
        Me.lblAverageScore.Text = average
    End Sub
End Class
