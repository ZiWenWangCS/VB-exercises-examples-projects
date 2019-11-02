Public Class Form1
    Dim x As Integer = 10

    Private Sub btnProc1_Click(sender As Object, e As EventArgs) Handles btnProc1.Click
        Dim x As Integer = 3
        Me.lblAnswer.Text = x
    End Sub

    Private Sub btnProc2_Click(sender As Object, e As EventArgs) Handles btnProc2.Click
        Me.lblAnswer.Text = x
    End Sub
End Class
