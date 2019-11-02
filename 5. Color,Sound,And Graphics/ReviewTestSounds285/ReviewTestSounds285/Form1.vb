Public Class Form1
    Private Sub btnAsterisk_Click(sender As Object, e As EventArgs) Handles btnAsterisk.Click
        Call PlayBackgroundSoundFile()
    End Sub
    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("G:\VM\EVERYONE\#Di Muro\1. GR 10 COMPUTER SCIENCE\#NOTES\5. Color, Sound, and Graphics\Files for Students\bubbles.wav",
            AudioPlayMode.Background)
    End Sub
End Class
