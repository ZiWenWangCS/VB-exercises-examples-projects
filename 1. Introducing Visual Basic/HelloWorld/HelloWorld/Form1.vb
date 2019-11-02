Public Class Form1
    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        Me.lblGreeting.ForeColor = Color.CadetBlue
        Me.lblGreeting.Text = "HELLO WORLD!!!"
    End Sub

    Private Sub FrenchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrenchToolStripMenuItem.Click
        Me.lblGreeting.ForeColor = Color.DeepPink
        Me.lblGreeting.Text = "Bonjour le monde!!!"
    End Sub

    Private Sub ChineseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChineseToolStripMenuItem.Click
        Me.lblGreeting.ForeColor = Color.Violet
        Me.lblGreeting.Text = "你好，世界!!!!"
    End Sub

    Private Sub GreekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreekToolStripMenuItem.Click
        Me.lblGreeting.ForeColor = Color.Yellow
        Me.lblGreeting.Text = "Γειά σου Κόσμε!!!"
    End Sub

    'this is called a method... it excutes specific code
    'when the exit object is clicked
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class
