Public Class Form1
    'Your name ziwen
    'HelloWorldInternational
    'Date sept 11
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpLanguage.Enter

    End Sub

    Private Sub radEnglish_Click(sender As Object, e As EventArgs) Handles radEnglish.Click
        Me.lblGreeting.Text = "Hello, world!"
    End Sub

    Private Sub radSpanish_Click(sender As Object, e As EventArgs) Handles radSpanish.Click
        Me.lblGreeting.Text = "Hola, Mundo!"
    End Sub

    Private Sub radFrench_Click(sender As Object, e As EventArgs) Handles radFrench.Click
        Me.lblGreeting.Text = "Bonjour le monde!"
    End Sub
End Class
