Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub bttAnswer_Click(sender As Object, e As EventArgs) Handles bttAnswer.Click
        Me.lblAnswer.Text = 2 * 3.14 * 15
    End Sub
End Class
