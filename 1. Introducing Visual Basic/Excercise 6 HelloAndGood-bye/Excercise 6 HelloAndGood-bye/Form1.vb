Public Class Form1
    Private Sub bttGoodbye_Click(sender As Object, e As EventArgs) Handles bttGoodbye.Click
        Me.lblText.Text = "Goodbye"
    End Sub

    Private Sub bttHello_Click(sender As Object, e As EventArgs) Handles bttHello.Click
        Me.lblText.Text = "Hello"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
