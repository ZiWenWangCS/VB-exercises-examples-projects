Public Class Form1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Static counter As Integer = 0
        Const Max_Image As Integer = 4 ' the max number of image

        'display image from array
        Select Case counter
            Case 0
                Me.picFishes.Image = My.Resources.anemone
                Me.lblName.Text = "Anemone"
                Call play_Back_Ground_Music()
            Case 1
                Me.picFishes.Image = My.Resources.grayangel
                Me.lblName.Text = "Grayangel"
                Call play_Back_Ground_Music()
            Case 2
                Me.picFishes.Image = My.Resources.sponges
                Me.lblName.Text = "Sponges"
                Call play_Back_Ground_Music()
            Case 3
                Me.picFishes.Image = My.Resources.starfish
                Me.lblName.Text = "Star Fish"
                Call play_Back_Ground_Music()
            Case 4
                Me.picFishes.Image = My.Resources.scorpionfish
                Me.lblName.Text = "Scorpion Fish"
                Call play_Back_Ground_Music()
        End Select

        'determine image number
        counter = (counter + 1) Mod Max_Image
        'so it'll be 1 mod 4  for first image which is 1
        'for 2 it will be 2
        'until it gets to 4 mod 4 itll be 0


    End Sub

    Sub play_Back_Ground_Music() 'plays background music
        My.Computer.Audio.Play(My.Resources.bubbles, AudioPlayMode.Background)
    End Sub
End Class
