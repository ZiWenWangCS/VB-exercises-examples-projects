Public Class Form1
    Private Sub btt2_Click(sender As Object, e As EventArgs) Handles btt2.Click
        Me.lbl.Text = "(a + b) + c = a + (b + c)"

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub bttAssociative_Click(sender As Object, e As EventArgs) Handles bttAssociative.Click
        Me.lbl.Text = "a + b = b + a"
    End Sub
End Class
