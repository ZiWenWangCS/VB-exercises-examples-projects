Public Class Form1
    Dim mode As Integer = 0 ' used to change different themes

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load 'when the user starts the program does the following:
        Me.lblSecretWord.Parent = picBackground ' transparent
        Me.lblWrongGuesses.Parent = picBackground
        Me.picHangMan.Parent = picBackground
        Me.picStart.Parent = picBackground

        Me.picStart.Image = My.Resources.normal_font_pic 'start button but its actually a picbox
    End Sub

    Private Sub picStart_Click(sender As Object, e As EventArgs) Handles picStart.Click
        Const flag As Char = "!" 'used when user knows the whole word
        Const guessPrompt As String = "Enter a letter or    " & flag & "    to guess the word!" 'the prompt for the input box

        Dim length As Integer           'the length of the secret word
        Dim numWrongGuesses As Integer  'num of the wrong guesses
        Dim lengthOfGuess As Integer    'used if the user enters a guess with 2 letters
        Dim charCode As Integer         'used for AscW

        Dim secretWord As String = ""   'the word for the user to guess
        Dim letterGuess As String       'the current letter the user has guessed
        Dim wordGuessed As String = ""  'the "dahsed" word that the user sees
        Dim guessWholeWord As String    'used if user guessed the entire word
        Dim wrongGuesses As String = "" 'letters of the wrong guesses
        Dim space As String              'to detect spaces

        Call random_word(secretWord)    'gets a random word
        Call stick_man(numWrongGuesses) 'displays the little hangman hanging

        Me.picStart.Visible = False     'invisible until the user wins/lose

        space = secretWord.IndexOf(" ") 'detect if there is any " " spaces

        'set the secretword to uppper case
        secretWord = secretWord.ToUpper

        'set number of dashes as letter in scretword
        length = secretWord.Length

        If space = -1 Then 'if there is no spaces in the secret word
            'depends on the length of the word to have the amount of *
            wordGuessed = wordGuessed.PadLeft(length, "*")
        Else 'for secret words that contains spaces
            wordGuessed = wordGuessed.PadRight(space, "*") & " " & wordGuessed.PadRight(length - space - 1, "*")
        End If

        'lbl = **** something like this
        Me.lblSecretWord.Text = wordGuessed

        Do
            'prompt for a guess
            letterGuess = InputBox(guessPrompt, "Guess Letter").ToUpper.Trim

            'if the inputbox = nothing then goes out of the loop
            If letterGuess = Nothing Then
                GoTo endGame 'ends the game
            End If

            charCode = AscW(letterGuess) 'to detect if the user entered any weird symbols

            Select Case charCode
                Case 65 To 90 'upper case alphabet is 65 to 90
                Case 33       '! is 33
                Case Else
                    MessageBox.Show("PLEASE A LETTER INSTEAD OF: " & letterGuess)
                    GoTo letterGuess 're prompt for another guess
            End Select

            lengthOfGuess = letterGuess.Length

            If lengthOfGuess > 1 Then
                'takes the 1st char if the user enters 2 letters
                letterGuess = letterGuess.Substring(0, 1)
            End If

            'check if the user enters the letter that they already guessed
            If wrongGuesses.Contains(letterGuess) Or wordGuessed.Contains(letterGuess) Then
                MessageBox.Show("YOU ALREADY GUESSED  THAT LETTER:   " & letterGuess, "GUESSED TWICE")

            ElseIf letterGuess = flag Then
                GoTo endGame ' goes to the if statement for guessisng the whole word

                'updates the incorrect guesses
            ElseIf Not wrongGuesses.Contains(letterGuess) AndAlso Not secretWord.Contains(letterGuess) Then
                If wrongGuesses <> Nothing Then 'there is ", " after a letter of wrong guesses and NO ", " on the first wrong guesses
                    wrongGuesses &= ", "
                End If
                numWrongGuesses += 1 'error adds 1
                    wrongGuesses &= letterGuess 'adds the letter that is not correct
                Call stick_man(numWrongGuesses)
            End If

            'compare the each letter of secretWord to lettterGuess
            For i As Integer = 0 To length - 1
                'matches the user guess for the chars in i index
                If letterGuess = secretWord.Chars(i) Then
                    wordGuessed = wordGuessed.Remove(i, 1)           'removes the i position
                    wordGuessed = wordGuessed.Insert(i, letterGuess) 'insert the user guessed
                End If
            Next

            'refeshes the lbl
            Me.lblSecretWord.Text = wordGuessed
            Me.lblWrongGuesses.Text = wrongGuesses

letterGuess: 'used if the user enters weird symbols or numbers like @#$^&%#^&^7

        Loop While wordGuessed <> secretWord And numWrongGuesses <> 7

        'creates "endGame" for ending the game without excuting the code between
endGame:

        If wordGuessed = secretWord Then
            MessageBox.Show("YOU WIN!", "WIN")

        ElseIf letterGuess = flag Then  'if player enters '!' then they have to guess the whole word
            guessWholeWord = InputBox("Enter THE WORD PLEASE", "WORD").ToUpper.Trim

            If guessWholeWord = secretWord Then 'wins if guessed right And create a new if statement for letterguess = flag
                MessageBox.Show("YOU WIN!", "WIN")
                Me.lblSecretWord.Text = secretWord

            Else 'otherwhise lose
                MessageBox.Show("YOU LOSE THE WORD WAS: " & secretWord, "LOSE")
                Me.lblSecretWord.Text = secretWord
            End If

        Else 'ends the game if the user guess does not match with the secret word
            MessageBox.Show("YOU LOSE THE WORD WAS: " & secretWord, "LOSE")
            Me.lblSecretWord.Text = secretWord
        End If

        Me.picStart.Visible = True 'visible
    End Sub

    Sub stick_man(ByVal wrong As Integer) ' cretaes a procedure with the number of wrong guesses. ByVal is only a copy of a variable and does not affect the origional variable
        If mode = 0 Then 'display the little hangman
            Select Case wrong
                Case 0
                    Me.picHangMan.Image = My.Resources.HANGMAN_1
                Case 1
                    Me.picHangMan.Image = My.Resources.HANGMAN_2
                Case 2
                    Me.picHangMan.Image = My.Resources.HANGMAN_3
                Case 3
                    Me.picHangMan.Image = My.Resources.HANGMAN_4
                Case 4
                    Me.picHangMan.Image = My.Resources.HANGMAN_5
                Case 5
                    Me.picHangMan.Image = My.Resources.HANGMAN_6
                Case 6
                    Me.picHangMan.Image = My.Resources.HANGMAN_7
                Case 7
                    Me.picHangMan.Image = My.Resources.HANGMAN_8
            End Select
        ElseIf mode = 1 Then
            Select Case wrong
                Case 0
                    Me.picHangMan.Image = My.Resources.HANGMAN_1
                Case 1
                    Me.picHangMan.Image = My.Resources.CHRISTMAS_1
                Case 2
                    Me.picHangMan.Image = My.Resources.CHRISTMAS_2
                Case 3
                    Me.picHangMan.Image = My.Resources.CHRISTMAS_3
                Case 4
                    Me.picHangMan.Image = My.Resources.CHRISTMAS_4
                Case 5
                    Me.picHangMan.Image = My.Resources.CHRISTMAS_5
                Case 6
                    Me.picHangMan.Image = My.Resources.CHRISTMAS_6
                Case 7
                    Me.picHangMan.Image = My.Resources.CHRISTMAS_7
            End Select
        ElseIf mode = 2 Then
            Select Case wrong
                Case 0
                    Me.picHangMan.Image = My.Resources.stick_man1
                Case 1
                    Me.picHangMan.Image = My.Resources.HALLOWEEN_2
                Case 2
                    Me.picHangMan.Image = My.Resources.HALLOWEEN_3
                Case 3
                    Me.picHangMan.Image = My.Resources.HALLOWEEN_4
                Case 4
                    Me.picHangMan.Image = My.Resources.HALLOWEEN_5
                Case 5
                    Me.picHangMan.Image = My.Resources.HALLOWEEN_6
                Case 6
                    Me.picHangMan.Image = My.Resources.HALLOWEEN_7
                Case 7
                    Me.picHangMan.Image = My.Resources.HALLOWEEN_8
            End Select
        ElseIf mode = 3 Then
            Select Case wrong
                Case 0
                    Me.picHangMan.Image = My.Resources.stick_man1
                Case 1
                    Me.picHangMan.Image = My.Resources.Winter_1
                Case 2
                    Me.picHangMan.Image = My.Resources.Winter_2
                Case 3
                    Me.picHangMan.Image = My.Resources.Winter_3
                Case 4
                    Me.picHangMan.Image = My.Resources.Winter_4
                Case 5
                    Me.picHangMan.Image = My.Resources.Winter_5
                Case 6
                    Me.picHangMan.Image = My.Resources.Winter_6
                Case 7
                    Me.picHangMan.Image = My.Resources.Winter_7
            End Select
        End If
    End Sub

    Sub random_word(ByRef secretword As String) 'ByRef updates this variable in all procedures
        'randomizes the 'secretWord' to get a random word from the Select Case
        Randomize()

        'random integer used for select case to determine which word is going to be the 'secretWord'
        secretword = Int(25 * Rnd() + 1)

        If mode = 0 Then 'word banks
            Select Case secretword
                Case 1
                    secretword = "zombie"
                Case 2
                    secretword = "abruptly"
                Case 3
                    secretword = "boxful"
                Case 4
                    secretword = "jazzy"
                Case 5
                    secretword = "lengths"
                Case 6
                    secretword = "nowadays"
                Case 7
                    secretword = "ovary"
                Case 8
                    secretword = "walkway"
                Case 9
                    secretword = "wimpy"
                Case 10
                    secretword = "zigzag"
                Case 11
                    secretword = "whiskey"
                Case 12
                    secretword = "shiv"
                Case 13
                    secretword = "joyful"
                Case 14
                    secretword = "gazebo"
                Case 15
                    secretword = "lucky"
                Case 16
                    secretword = "puppy"
                Case 17
                    secretword = "nymph"
                Case 18
                    secretword = "pixel"
                Case 19
                    secretword = "pizazz"
                Case 20
                    secretword = "polka"
                Case 21
                    secretword = "phlegm"
                Case 22
                    secretword = "oxygen"
                Case 23
                    secretword = "pshaw"
                Case 24
                    secretword = "queue"
                Case 25
                    secretword = "launch"
            End Select
        ElseIf mode = 1 Then
            Select Case secretword
                Case 1
                    secretword = "candy canes"
                Case 2
                    secretword = "Winter"
                Case 3
                    secretword = "vacation"
                Case 4
                    secretword = "reindeer"
                Case 5
                    secretword = "red"
                Case 6
                    secretword = "green"
                Case 7
                    secretword = "merry"
                Case 8
                    secretword = "Frosty"
                Case 9
                    secretword = "presents"
                Case 10
                    secretword = "cards"
                Case 11
                    secretword = "candles"
                Case 12
                    secretword = "bells"
                Case 13
                    secretword = "christmas tree"
                Case 14
                    secretword = "cold"
                Case 15
                    secretword = "December"
                Case 16
                    secretword = "decorations"
                Case 17
                    secretword = "dolls"
                Case 18
                    secretword = "christmas"
                Case 19
                    secretword = "elves"
                Case 20
                    secretword = "santa claus"
                Case 21
                    secretword = "tradition"
                Case 22
                    secretword = "turkey"
                Case 23
                    secretword = "toys"
                Case 24
                    secretword = "star"
                Case 25
                    secretword = "snowflakes"
            End Select
        ElseIf mode = 2 Then
            Select Case secretword
                Case 1
                    secretword = "mask"
                Case 2
                    secretword = "autumn"
                Case 3
                    secretword = "moonlight"
                Case 4
                    secretword = "monster"
                Case 5
                    secretword = "pumpkins"
                Case 6
                    secretword = "costumes"
                Case 7
                    secretword = "flashlight"
                Case 8
                    secretword = "haunted house"
                Case 9
                    secretword = "spooky"
                Case 10
                    secretword = "spider"
                Case 11
                    secretword = "spirit"
                Case 12
                    secretword = "doorbell"
                Case 13
                    secretword = "candy"
                Case 14
                    secretword = "broom"
                Case 15
                    secretword = "owl"
                Case 16
                    secretword = "October"
                Case 17
                    secretword = "mummy"
                Case 18
                    secretword = "bones"
                Case 19
                    secretword = "skeleton"
                Case 20
                    secretword = "bats"
                Case 21
                    secretword = "black"
                Case 22
                    secretword = "bloody"
                Case 23
                    secretword = "devil"
                Case 24
                    secretword = "goblin"
                Case 25
                    secretword = "ghost"
            End Select
        ElseIf mode = 3 Then
            Select Case secretword
                Case 1
                    secretword = "mittens"
                Case 2
                    secretword = "jacket"
                Case 3
                    secretword = "scarf"
                Case 4
                    secretword = "winter"
                Case 5
                    secretword = "snowman"
                Case 6
                    secretword = "sled"
                Case 7
                    secretword = "button"
                Case 8
                    secretword = "boots"
                Case 9
                    secretword = "ice skating"
                Case 10
                    secretword = "cold"
                Case 11
                    secretword = "snowball fight"
                Case 12
                    secretword = "freezing"
                Case 13
                    secretword = "hot chocolate"
                Case 14
                    secretword = "marshmallow"
                Case 15
                    secretword = "mountains"
                Case 16
                    secretword = "icy"
                Case 17
                    secretword = "penguin"
                Case 18
                    secretword = "blizzard"
                Case 19
                    secretword = "sweater"
                Case 20
                    secretword = "igloo"
                Case 21
                    secretword = "skiing"
                Case 22
                    secretword = "snow angel"
                Case 23
                    secretword = "glove"
                Case 24
                    secretword = "icicle"
                Case 25
                    secretword = "snowboard"
            End Select
        End If
    End Sub

    Private Sub ChristmasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChristmasToolStripMenuItem.Click
        If Me.ChristmasToolStripMenuItem.Checked = True Then
            mode = 1 'sets to 1 if it is cheked
        Else
            mode = 0 'clicks again can reset it to 0
        End If

        Me.HalloweenToolStripMenuItem.Checked = False 'prevent from other menustriped being checked
        Me.WinterToolStripMenuItem.Checked = False

        Call backgroundpic_and_font()
    End Sub

    Private Sub HalloweenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HalloweenToolStripMenuItem.Click
        If Me.HalloweenToolStripMenuItem.Checked = True Then
            mode = 2
        Else
            mode = 0
        End If

        Me.ChristmasToolStripMenuItem.Checked = False
        Me.WinterToolStripMenuItem.Checked = False

        Call backgroundpic_and_font()
    End Sub

    Private Sub WinterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinterToolStripMenuItem.Click
        If Me.WinterToolStripMenuItem.Checked = True Then
            mode = 3
        Else
            mode = 0
        End If

        Me.ChristmasToolStripMenuItem.Checked = False
        Me.HalloweenToolStripMenuItem.Checked = False

        Call backgroundpic_and_font()
    End Sub

    Sub backgroundpic_and_font() 'there is 3 menustrip click event that calls this procedure
        Select Case mode
            Case 0
                Me.tmrBackGroundMusic.Stop() 'stops the tmr
                My.Computer.Audio.Stop() 'stops the music

                Me.picBackground.Image = Nothing
                Me.picStart.Image = My.Resources.normal_font_pic

                Me.lblSecretWord.ForeColor = DefaultForeColor 'back to default
                Me.lblWrongGuesses.ForeColor = DefaultForeColor

                Me.lblSecretWord.Font = DefaultFont 'back to default
                Me.lblWrongGuesses.Font = DefaultFont
            Case 1
                Me.picBackground.Image = My.Resources.Christmas_Background_gif 'sets the background image
                Me.picStart.Image = My.Resources.snow_font_pic 'the start button but its actually a pic
            Case 2
                Me.picBackground.Image = My.Resources.Halloween_background_pic
                Me.picStart.Image = My.Resources.halloween_font_pic
            Case 3
                Me.picBackground.Image = My.Resources.winter_gif
                Me.picStart.Image = My.Resources.snow_font_pic
        End Select

        If mode <> 0 Then
            Me.tmrBackGroundMusic.Interval = 1
            Me.tmrBackGroundMusic.Start()

            Me.lblSecretWord.ForeColor = Color.White 'sets the text color
            Me.lblWrongGuesses.ForeColor = Color.White

            Me.lblSecretWord.Font = New Font("Segoe Print", 12, FontStyle.Bold) ' changes the font, fontstyle, size
            Me.lblWrongGuesses.Font = New Font("Segoe Print", 12, FontStyle.Bold)
        End If
    End Sub

    Private Sub tmrBackGroundMusic_Tick(sender As Object, e As EventArgs) Handles tmrBackGroundMusic.Tick ' plays the music
        If mode = 1 Then
            Me.tmrBackGroundMusic.Interval = 183000 'since the music is 3.03 min long
            My.Computer.Audio.Play(My.Resources.Christmas_background_music, AudioPlayMode.Background)
        ElseIf mode = 2 Then
            Me.tmrBackGroundMusic.Interval = 60000 'since the music is 1min long
            My.Computer.Audio.Play(My.Resources.Halloween_background_music, AudioPlayMode.Background)
        ElseIf mode = 3 Then
            Me.tmrBackGroundMusic.Interval = 39000 'since the music is 39s long
            My.Computer.Audio.Play(My.Resources.Winter_background_music, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'exit the program
    End Sub
End Class