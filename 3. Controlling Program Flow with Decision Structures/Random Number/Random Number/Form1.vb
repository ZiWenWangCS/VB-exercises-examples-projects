Public Class Form1
    Private Sub btnRandomNumbers_Click(sender As Object, e As EventArgs) Handles btnRandomNumbers.Click
        Randomize()
        Me.lblRandNum1.Text = Int(21 * Rnd() + 10) ' this way randomnumber will stay between 31 and 10
        Me.lblRandNum2.Text = Int(21 * Rnd() + 10)
        Me.lblRandNum3.Text = Int(21 * Rnd() + 10)
        Me.lblRandNum4.Text = Int(21 * Rnd() + 10)
        Me.lblRandNum5.Text = Int(21 * Rnd() + 10)
        Me.lblRandNum6.Text = Int(21 * Rnd() + 10)

    End Sub
End Class
