Public Class Form1
    Private Sub picRooster_Click(sender As Object, e As EventArgs) Handles picRooster.Click
        Static crow As Boolean = False

        crow = Not crow
        If crow Then
            My.Computer.Audio.Play(My.Resources.Rooster_crow, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub
End Class
