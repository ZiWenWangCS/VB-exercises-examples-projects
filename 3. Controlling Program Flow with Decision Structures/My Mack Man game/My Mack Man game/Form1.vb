Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Call Start_Game()

        btnStart.Visible = False
    End Sub

    Sub Start_Game()
        'Update the story lable
        Me.lblPrompt.Text = "Hello,welcome to my game! " &
            "Select an option"

        'make the appropriate buttons visible
        btnFork1.Visible = True
        btnFork2.Visible = True
    End Sub

    Sub Fork1()
        Me.lblPrompt.Text = " hey , we are using the sub procedure " &
            "for ...."
    End Sub

    'ok, this is fork1, where blah blah happens
    Private Sub btnFork1_Click(sender As Object, e As EventArgs) Handles btnFork1.Click
        ' make the buttons on the screen before not visible
        btnFork1.Visible = False
        btnFork2.Visible = False
        'name the appropriate buttons visible
        Me.btnFork3.Visible = True

        'update the prompts label with sotry
        Me.lblPrompt.Text = "Next part of the story"
        Call Fork1()
    End Sub

End Class
