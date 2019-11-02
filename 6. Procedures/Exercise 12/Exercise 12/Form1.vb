Public Class Form1
    Dim rndStones As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RndInt()
    End Sub

    Sub RndInt()
        Randomize()
        Do
            rndStones = Int(30 * Rnd() + 15)

        Loop While rndStones < 30 And rndstones < 15
        Me.lblStones.Text = "Stones in pile: " & rndStones
    End Sub


    Private Sub btnTakeStones_Click(sender As Object, e As EventArgs) Handles btnTakeStones.Click

    End Sub
End Class
