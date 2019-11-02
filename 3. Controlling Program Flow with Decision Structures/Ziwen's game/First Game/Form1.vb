Public Class Form1
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Me.btnStart.Visible = True Then ' this way if you minimize/hide the window it won't activate
            Call Introduction()
        End If
    End Sub

    Sub Introduction()
        Me.lblPrompt.Text = "This game, you will cosplay a famous LOL （League Of Legneds) proplayer named Faker, " &
                   " and the time before
he became a proplayer at LOL.
    
Reminder: You are in korea, and this story is made up." ' when game start give them what the story is 
        'about

        Me.picBackground.Image = My.Resources.Faker

        Me.lblPrompt.Parent = picBackground
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Call Start()

    End Sub

    Sub Start() ' player click starts it does the following, first fork
        Me.lblPrompt.Text = "You woke up, you wanted to go to an internet bar."


        Me.picBackground.Image = My.Resources.Wake_up ' display the image from my resource

        Me.btnStart.Visible = False ' btn start invsible
        'a picutre is shown
        ' sub start is activated
        Me.btnFork1Yes.Visible = True
        Me.btnFork1No.Visible = True '2 btn displays
        Me.btnBack.Visible = False ' this way when player comes back there is no back opt
        Me.btnFork3Punch.Visible = False
        Me.btnFork2GoHome.Visible = False
        Me.lblWin.Visible = False
        Me.lblPrompt.Visible = True ' when you winned the game and click restart this will reset the labels
        'if player restart the game and select
        ' no for the fork1 then it would not show the btn for fork2 and fork3
    End Sub

    Private Sub btnFork1Yes_Click(sender As Object, e As EventArgs) Handles btnFork1Yes.Click
        Call Fork1_Yes()

        Me.btnFork1Yes.Visible = False
        Me.btnFork1No.Visible = False ' 2 btn invisble
    End Sub

    Sub Fork1_Yes() ' if player clicks yes at fork1 then the following occur 2nd fork
        Me.lblPrompt.Text = "You went into a random internet bar and you" &
            " realized that you forgot to bring your wallet."

        Me.picBackground.Image = My.Resources.Internet_Bar ' new pictrure acdded

        Me.btnBack.Parent = picBackground

        Me.btnFork2Ask.Visible = True 'sotry option
        Me.btnFork2GoHome.Visible = True
        Me.btnBack.Visible = True ' back option added

        Me.btnFork3Game.Visible = False ' when player clicks back at fork 3 to fork2 
        ' btnfork3game would be visible at the next btnfork3ask
    End Sub

    Private Sub btnFork1No_Click(sender As Object, e As EventArgs) Handles btnFork1No.Click
        Call Fork1_No() ' creakts sub fork 1 no and the buttons yes no dissapear

        Me.btnFork1No.Visible = False
    End Sub

    Sub Fork1_No() ' if player clicks no at fork1 does the following 2nd fork
        MessageBox.Show("YOU SURE YOU WANT TOO QUIT THIS GAME?!",
                         "PLEASE CLICK THE BUTTON YES", MessageBoxButtons.OK)
        ' player goes back to the option this time the button no disaapear

        Me.picBackground.Image = My.Resources.Wake_up
        Me.lblPrompt.Text = "You woke up, you wanted to go to an internet bar."
    End Sub

    Private Sub btnFork2Ask_Click(sender As Object, e As EventArgs) Handles btnFork2Ask.Click
        Me.btnFork2Ask.Visible = False
        Me.btnFork2GoHome.Visible = False

        Call Fork2_Ask() ' new fork
    End Sub

    Sub Fork2_Ask() ' new fork created 3rd fork
        Me.lblPrompt.Text = "You went inside of the internet bar and saw a person who " &
            "is noob at League Of Legends."

        Me.picBackground.Image = My.Resources.Noob_Player

        Me.btnFork3Punch.Visible = True
        Me.btnFork3Teach.Visible = True ' next 2 option occur
        Me.btnFork4NoInvite.Visible = False
        Me.btnFork4YesInvite.Visible = False
    End Sub

    Private Sub btnFork2GoHome_Click(sender As Object, e As EventArgs) Handles btnFork2GoHome.Click
        Me.btnFork2Ask.Visible = False
        Me.btnFork2GoHome.Visible = False

        Call Fork2_Go_Home() ' creats a new fork
    End Sub

    Sub Fork2_Go_Home() ' new fork is created 3rd fork
        Me.lblPrompt.Text = "You went home and brought your wallet back to the internet bar."

        Me.btnFork3Game.Visible = True
        Me.btnFork4Play.Visible = True

        Me.btnFork3Punch.Visible = False
        Me.btnFork3Teach.Visible = False
        Me.btnFork4GoHome.Visible = False
        Me.btnFork4Run.Visible = False

        Me.btnFork4YesInvite.Visible = False
        Me.btnFork4NoInvite.Visible = False ' when player clicks on the back btn it woould not show 
        ' the btn fork4 go home

        ' add a pic
    End Sub

    Private Sub btnFork3Teach_Click(sender As Object, e As EventArgs) Handles btnFork3Teach.Click
        Call Fork3_Teach() ' new sub maded, goes to fork 4 which is fork3_teach()

    End Sub

    Sub Fork3_Teach()
        Me.lblPrompt.Text = "You tought him how to play Leaugue and got a penta kill,
" &
            "then a bunch of people are watching you playing. A person named kkoma 
" &
            "came wathcing you too and wanted to invite you to be a proplayer and to 
" &
            "make a team with you called SKT" ' new propmt

        Me.btnFork3Teach.Visible = False
        Me.btnFork3Punch.Visible = False ' 2 btn invisible
        Me.btnFork4Run.Visible = False ' when player click btnback btn and clicked on this fork it this two btn would not be visible

        Me.btnFork4NoInvite.Visible = True
        Me.btnFork4YesInvite.Visible = True

        Me.picBackground.Image = My.Resources.Zed_Penta_Kill
    End Sub

    Private Sub btnFork3Punch_Click(sender As Object, e As EventArgs) Handles btnFork3Punch.Click
        Call Fork3_Punch() ' new sub happens
    End Sub

    Sub Fork3_Punch()
        Const win As Integer = 1
        Const lose As Integer = 2
        Dim chance_win_lose As Integer

        Randomize()
        chance_win_lose = Int(2 * Rnd() + 1) ' a number between 1 - 2

        If chance_win_lose = win Then
            Me.lblPrompt.Text = "You wins the fight and the security came"
            Me.btnFork4Run.Visible = True
            Me.picBackground.Image = My.Resources.Faint
        ElseIf chance_win_lose = lose Then
            MessageBox.Show("You got beaten up from the fight", "GAME OVER!", MessageBoxButtons.OK)
            Me.btnRestart.Visible = True
            Me.btnFork4Run.Visible = False
            Me.picBackground.Image = My.Resources.Beaten_Up
            Me.lblPrompt.Visible = False
            Me.btnBack.Visible = False
        End If ' 50/50% chance of winning the fight

        Me.btnFork3Teach.Visible = False
        Me.btnFork3Punch.Visible = False
        Me.btnFork4NoInvite.Visible = False
        Me.btnFork4YesInvite.Visible = False
        Me.btnFork4Play.Visible = False ' this way when player click back btn and clicks btnfork3punch
        'it would Not appear btnfork4

        ' new options occurs
    End Sub

    Private Sub btnFork3Game_Click(sender As Object, e As EventArgs) Handles btnFork3Game.Click
        Call Fork3_Game()
        ' new fork
    End Sub

    Sub Fork3_Game()
        Me.lblPrompt.Text = "You are bored and wanted to play some game, but you remembered you still have homeowrk to do."

        Me.btnFork4GoHome.Visible = True
        Me.btnFork4Play.Visible = True

        Me.btnFork3Game.Visible = False
        Me.btnFork4Run.Visible = False
        Me.btnFork4YesInvite.Visible = False
        Me.btnFork4NoInvite.Visible = False
        '2 options added
        Me.picBackground.Image = My.Resources.Game
    End Sub

    Private Sub btnFork4GoHome_Click(sender As Object, e As EventArgs) Handles btnFork4GoHome.Click
        Call Fork4_Car_Crash()
    End Sub

    Sub Fork4_Car_Crash()
        MessageBox.Show("You went outside, walking across a street and unfortunately got a terrible car crash.",
                        "GAME OVER", MessageBoxButtons.OK)

        Me.picBackground.Image = My.Resources.Car_Crash

        Me.btnFork4GoHome.Visible = False
        Me.btnFork4Play.Visible = False
        Me.btnBack.Visible = False
        Me.btnFork4Run.Visible = False
        Me.btnRestart.Visible = True 'restart option

        Me.lblPrompt.Visible = False
    End Sub

    Private Sub btnFork4YesInvite_Click(sender As Object, e As EventArgs) Handles btnFork4YesInvite.Click
        Call Fork4_Yes_Invite()
    End Sub

    Sub Fork4_Yes_Invite()
        Me.lblPrompt.Text = "The coach KKoma said, "" Pick a laner plz"" "

        Me.picBackground.Image = My.Resources.Summoners_Rift_Map

        Me.btnFork4YesInvite.Visible = False
        Me.btnFork4NoInvite.Visible = False
        Me.btnBack.Visible = False ' no more backs
        Me.btnFork5Bottom.Visible = True
        Me.btnFork5Top.Visible = True
        Me.btnFork5Support.Visible = True
        Me.btnFork5Jungle.Visible = True
        Me.btnFork5Mid.Visible = True
    End Sub

    Private Sub btnFork4NoInvite_Click(sender As Object, e As EventArgs) Handles btnFork4NoInvite.Click
        Call Fork4_No_Invite
    End Sub

    Sub Fork4_No_Invite()
        MessageBox.Show("You have no job and have very less of money. So, you became a tramp and died from hunger", "GAME OVER!", MessageBoxButtons.OK)

        Me.lblPrompt.Visible = False

        Me.picBackground.Image = My.Resources.Tramp

        Me.btnRestart.Visible = True

        Me.btnFork4NoInvite.Visible = False
        Me.btnFork4YesInvite.Visible = False ' player game over have to restart the game
        Me.btnFork4Run.Visible = False

    End Sub

    Private Sub btnFork4Play_Click(sender As Object, e As EventArgs) Handles btnFork4Play.Click
        Call Fork4_Play()
    End Sub

    Sub Fork4_Play()
        Me.lblPrompt.Text = "A random person comes to you and watches you playing the game LOL, 
he thinks you are a really " &
            "talented palyer. He asked if you wanted to join his team."

        Me.btnFork4YesInvite.Visible = True
        Me.btnFork4NoInvite.Visible = True

        Me.btnFork4Play.Visible = False
        Me.btnFork4GoHome.Visible = False

        Me.picBackground.Image = My.Resources.KKoma2
    End Sub

    Private Sub btnFork4Run_Click(sender As Object, e As EventArgs) Handles btnFork4Run.Click
        Call Fork4_Run()
    End Sub

    Sub Fork4_Run()
        Dim run As Integer
        Dim caught As Integer = 1
        Dim escape As Integer = 2

        Randomize()
        run = Int(2 * Rnd() + 1) ' a number between 1 - 2

        If run = caught Then
            Me.lblPrompt.Text = "While you are running away you got caught and got arrested in jail."

            Me.picBackground.Image = My.Resources.Jail

            Me.btnRestart.Visible = True
            Me.btnFork4Run.Visible = False
        ElseIf run = escape Then
            Call Fork4_Car_Crash()
        End If

        Me.btnBack.Visible = False
    End Sub

    Private Sub btnFork5Top_Click(sender As Object, e As EventArgs) Handles btnFork5Top.Click
        Call Fired()
    End Sub

    Private Sub btnFork5Jungle_Click(sender As Object, e As EventArgs) Handles btnFork5Jungle.Click
        Call Fired()
    End Sub

    Private Sub btnFork5Bottom_Click(sender As Object, e As EventArgs) Handles btnFork5Bottom.Click
        Call Fired()
    End Sub

    Private Sub btnFork5Support_Click(sender As Object, e As EventArgs) Handles btnFork5Support.Click
        Call Fired() ' all the 3 above including this 1 ends up with 1 ending
    End Sub

    Sub Fired()
        MessageBox.Show("Your boss and your coach was not happy with you of lossing all season game and demoting the team.",
                        "YOU ARE FIRED!", MessageBoxButtons.OK)

        Me.picBackground.Image = My.Resources.Fired
        Me.btnRestart.Visible = True
        Me.btnFork5Mid.Visible = False
        Me.btnFork5Bottom.Visible = False
        Me.btnFork5Support.Visible = False
        Me.btnFork5Jungle.Visible = False
        Me.btnFork5Top.Visible = False
        Me.lblPrompt.Visible = False
    End Sub

    Private Sub btnFork5Mid_Click(sender As Object, e As EventArgs) Handles btnFork5Mid.Click
        ' the only button to win
        Call Win()
    End Sub

    Sub Win()
        MessageBox.Show("Congratulations, you winned World champion ship in season 3 and became a dominated player of mid laner!",
                        "YOU WIN!", MessageBoxButtons.OK)
        Me.picBackground.Image = My.Resources.SKT
        Me.btnFork5Mid.Visible = False
        Me.btnFork5Bottom.Visible = False
        Me.btnFork5Support.Visible = False
        Me.btnFork5Jungle.Visible = False
        Me.btnFork5Top.Visible = False
        Me.lblPrompt.Visible = False
        Me.lblWin.Visible = True ' display win
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click ' creats a back button
        If Me.btnFork2Ask.Visible = True And Me.btnFork2GoHome.Visible = True Then
            Call Start()
            'back option when at fork2 can back to fork1
        ElseIf Me.btnFork3Teach.Visible = True And Me.btnFork3Punch.Visible = True Then
            Call Fork1_Yes()
            'back option when at fork3 can back to fork 2
        ElseIf Me.btnFork3Game.Visible = True Then
            Call Fork1_Yes()
        ElseIf Me.lblPrompt.Text = "You tought him how to play Leaugue and got a penta kill,
" &
            "then a bunch of people are watching you playing. A person named kkoma 
" &
            "came wathcing you too and wanted to invite you to be a proplayer and to 
" &
            "make a team with you called SKT" Then ' the button displays in two different fork if
            'I use button in this if statement then their would be a bug since the button is in two different fork
            Call Fork2_Ask()
            'goes back when at fork 4 can back to fork 3
        ElseIf Me.lblPrompt.Text = "A random person comes to you and watches you playing the game LOL, 
he thinks you are a really " &
            "talented palyer. He asked if you wanted to join his team." Then ' the button displays in two different fork if
            'I use button in this if statement then their would be a bug since the button is in two different fork
            Call Fork3_Game()
        ElseIf Me.btnFork4Run.Visible = True Then
            Call Fork2_Ask()
            'goes back when at fork 4 can bakc to fork 3
        ElseIf Me.btnFork4Play.Visible = True And Me.btnFork4GoHome.Visible = True Then
            Call Fork2_Go_Home()
            'goes back when at fork 4 coming back to the intenet bar to fork 3 
        End If
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Call Start()
        Me.btnRestart.Visible = False
        Me.lblPrompt.Visible = True
        Me.picBackground.Visible = True
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Call Start() ' restart menu strip
        ' goes to fork 1 
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'exit menu strip
        'ends program
    End Sub


End Class
