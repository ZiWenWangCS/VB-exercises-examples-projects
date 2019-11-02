Public Class Form1
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.btnGreen.Image = My.Resources.green
        Me.btnRed.Image = My.Resources.red
        Me.btnPink.Image = My.Resources.pink
        Me.btnOrange.Image = My.Resources.orange
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        Me.BackgroundImage = My.Resources.green
    End Sub

    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click
        Me.BackgroundImage = My.Resources.orange
    End Sub

    Private Sub btnPink_Click(sender As Object, e As EventArgs) Handles btnPink.Click
        Me.BackgroundImage = My.Resources.pink
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        Me.BackgroundImage = My.Resources.red
    End Sub
End Class
