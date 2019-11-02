Public Class Form1
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Static totalPoints As Integer = 1000
        Dim riskPoint As Integer = Val(Me.txtPoints.Text)
        Dim die1, die2 As Integer

        Call RollDice(die1, die2)
        Call RollDie(die1, die2)

        die1 = die1 + die2
        die1 = die1 Mod 2
        If die1 = 0 Then
            totalPoints += riskPoint
        Else
            totalPoints -= riskPoint
        End If
        Me.lblTotalPoints.Text = "Total points= " & totalPoints
    End Sub
    Sub RollDice(ByRef roll1 As Integer, ByRef roll2 As Integer)

        Randomize()
        roll1 = Int(6 * Rnd() + 1)
        roll2 = Int(6 * Rnd() + 1)

    End Sub
    Sub RollDie(ByVal dice1 As Integer, ByVal dice2 As Integer)
        Select Case dice1
            Case 1
                Me.picDice1.Image = My.Resources.die1
            Case 2
                Me.picDice1.Image = My.Resources.die2
            Case 3
                Me.picDice1.Image = My.Resources.die3
            Case 4
                Me.picDice1.Image = My.Resources.die4
            Case 5
                Me.picDice1.Image = My.Resources.die5
            Case 6
                Me.picDice1.Image = My.Resources.die6
        End Select
        Select Case dice2
            Case 1
                Me.picDice2.Image = My.Resources.die1
            Case 2
                Me.picDice2.Image = My.Resources.die2
            Case 3
                Me.picDice2.Image = My.Resources.die3
            Case 4
                Me.picDice2.Image = My.Resources.die4
            Case 5
                Me.picDice2.Image = My.Resources.die5
            Case 6
                Me.picDice2.Image = My.Resources.die6
        End Select
    End Sub
End Class
