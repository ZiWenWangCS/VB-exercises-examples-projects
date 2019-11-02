Public Class Form1



    'START NEW GAME
    Private Sub btnNewGame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        'start the game! Make everything visible
        Me.grpOptions.Visible = True
        Me.picGraphics1.Visible = True
        Me.picGraphics2.Visible = True

        'make the new game button disappear
        Me.btnNewGame.Visible = False

        'Display Back Story
        Call Back_Story()

    End Sub

    'BACK STORY
    'This is an example of a procedure (we will learn about them later)
    'Procedures are bits of code that we can use over and over again by "calling" the procedure each time we would like to use it!
    'You may use mine for your backstory. 
    Sub Back_Story()
        Dim welcome As String = "Who is Mack Man?"

        Me.picGraphics1.Image = My.Resources.Mack_Man
        Me.picGraphics2.Image = My.Resources.Cat_intro
        Me.lblTitles.Text = welcome
        Me.lblPrompts.Text = "This is Mack Man. By day, he is a computer scientist. But by night, Mack Man turns" & _
            "into a super mad scientist who can communicate with cats. He can easily influence cats to obey his" & _
            "commands! What kind of adventures will he get into now!"

        'make the continue button visible
        Me.btnContinue.Visible = True
    End Sub

    'END GAME
    'This is what happens if you lose the game
    Sub End_Game()
        'reset the buttons
        Call Reset_Radio_Buttons()

        'change the pics and prompts
        Me.picGraphics2.Image = My.Resources.game_over_1
        Me.lblTitles.Text = "YOU LOSE! GAME OVER"
    End Sub


    'RESET RADIO BUTTONS
    'This is used to reset our options at the beginning of each new story fork!
    Sub Reset_Radio_Buttons()
        Me.radOption1.Checked = False
        Me.radOption2.Checked = False
        Me.radNothing.Checked = True

        Me.radOption1.Text = Nothing
        Me.radOption2.Text = Nothing
    End Sub


    'START THE STORY
    Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Call First_Story_Fork()
        'make the continue button disappear!
        Me.btnContinue.Visible = False
    End Sub

    'FIRST STORY FORK
    Sub First_Story_Fork()
        'make the appropriate button display...
        Me.btnContinueF1.Visible = True
        'explain what is going on, change the pictures, and make the radio buttons visible
        Me.lblTitles.Text = "Would you like frys with that?"
        Me.lblPrompts.Text = "Mack Man is at McDonalds. A black kitty rubs against his leg and says 'you better come" & _
            "quick Mack Man! We need your help!'"
        Me.picGraphics1.Image = My.Resources.McDonalds
        Me.picGraphics2.Image = My.Resources.McDonalds2
        Me.radOption1.Visible = True
        Me.radOption2.Visible = True

        'Story options
        Me.radOption1.Text = "Follow the black kitty"
        Me.radOption2.Text = "Kick the black kitty"
    End Sub

    'CONTINUEF1 
    'checks to see what option the user selected in FORK 1 and continues the game...
    Private Sub btnContinueF1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinueF1.Click
        'CORRECT, continue to second story fork
        If radOption1.Checked Then
            Call Second_Story_Fork()
            'END GAME
        ElseIf radOption2.Checked Then
            Me.picGraphics1.Image = My.Resources.Crazy_driver
            Me.lblPrompts.Text = "You kick the black kitty! The kitty screams in anger and jumps on your face!" & _
                "You scream and walk backwards into a car which runs you over and you die!"
            Call End_Game()
        End If

        'make this button disappear!
        Me.btnContinueF1.Visible = False

    End Sub


    'SECOND STORY FORK
    Sub Second_Story_Fork()
        'Reset the radio buttons!
        Call Reset_Radio_Buttons()
        'make the appropriate continue button visible!
        Me.btnContinueF2.Visible = True

        'change the pictures and story prompts
        Me.picGraphics1.Image = My.Resources.Sewer_cover
        Me.picGraphics2.Image = My.Resources.Mack_Man
        Me.lblPrompts.Text = "Mack Man follows the black kitty until it takes him to a sewer grate." & _
            "'Mack Man, we gotta go in here! Let's go!'"

        'story options
        Me.radOption1.Text = "Follow the black kitty into the sewer"
        Me.radOption2.Text = "Say: 'no black kitty! Something is wrong here!"
    End Sub

    'CONTINUEF2 
    'checks to see what option the user selected in FORK 2 and continues the game...
    Private Sub btnContinueF2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinueF2.Click

        'THIS IS WHERE YOU START DOING YOUR THING!
        If radOption1.Checked Then
            Call Third_Story_Fork()

        ElseIf radOption2.Checked Then
            Call Forth_Story_Fork()
        End If

        'make this button disappear!
        Me.btnContinueF2.Visible = False

    End Sub


    'THIRD STORY FORK
    Sub Third_Story_Fork()
        'Reset the radio buttons!
        Call Reset_Radio_Buttons()
        'make the appropriate continue button visible!
        Me.btnContinueF3.Visible = True

        'change the pictures and story prompts
        Me.picGraphics1.Image = My.Resources.Sewer_cover
        Me.picGraphics2.Image = My.Resources.Mack_Man
        Me.lblPrompts.Text = "THIS IS THE THIRD FORK!!"

        'story options
        Me.radOption1.Text = "Is this game working yet?"
        Me.radOption2.Text = "Apple products are over priced and over valued!"
    End Sub

    'CONTINUEF3 
    'checks to see what option the user selected in FORK 3 and continues the game...
    Private Sub btnContinueF3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinueF3.Click

        'THIS IS WHERE YOU START DOING YOUR THING!
        If radOption1.Checked Then
            'Call Third_Story_Fork()

        ElseIf radOption2.Checked Then
            Call Forth_Story_Fork()
        End If

        'make this button disappear!
        Me.btnContinueF3.Visible = False
    End Sub


    'FORTH STORY FORK
    Sub Forth_Story_Fork()
        'Reset the radio buttons!
        Call Reset_Radio_Buttons()
        'make the appropriate continue button visible!
        Me.btnContinueF4.Visible = True

        'change the pictures and story prompts
        Me.picGraphics1.Image = My.Resources.Sewer_cover
        Me.picGraphics2.Image = My.Resources.Mack_Man
        Me.lblPrompts.Text = "THIS IS THE FORTH STORY FORK!! YOU SAID 'WAIT KITTY SOMETHING SEEMS WRONG HERE!"

        'story options
        Me.radOption1.Text = "If you can read this then this game is REALLY WORKING!"
        Me.radOption2.Text = "One time a rabbit once told me that it is always used to say" & _
            "it's better to have loved and lost then never to have loved at all"

    End Sub

    'CONTINUEF4 
    'checks to see what option the user selected in FORK 4 and continues the game...
    Private Sub btnContinueF4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinueF4.Click

        'THIS IS WHERE YOU START DOING YOUR THING!
        If radOption1.Checked Then
            'something happens

        ElseIf radOption2.Checked Then
            'something happens
        End If

        'make this button disappear!
        Me.btnContinueF4.Visible = False

    End Sub


End Class
