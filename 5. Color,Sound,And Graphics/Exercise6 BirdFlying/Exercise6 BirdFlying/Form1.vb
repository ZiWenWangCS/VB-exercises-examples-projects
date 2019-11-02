Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrAnimate.Tick
        Const MAX_IMAGES As Integer = 3
        Static imagenum As Integer = 0

        'display from array
        Select Case imagenum
            Case 0
                Me.picCurrentImage.Image = My.Resources.bird1
            Case 1
                Me.picCurrentImage.Image = My.Resources.bird2
            Case 2
                Me.picCurrentImage.Image = My.Resources.bird3
        End Select

        'repeats the animation forever
        imagenum = (imagenum + 1) Mod MAX_IMAGES


    End Sub

    Private Sub tmrAduio_Tick(sender As Object, e As EventArgs) Handles tmrAudio.Tick
        Static play As Integer = 0
        Static counter As Integer = 0

        If play = counter Then
            My.Computer.Audio.Play(My.Resources.gull, AudioPlayMode.Background)
            counter += 500 'interval is 500 so counter have to b 500
            play += 6000 ' audio is 6 sec long and replays aduio every 6s
        ElseIf play <> counter Then
            counter += 500
        End If
    End Sub
End Class
