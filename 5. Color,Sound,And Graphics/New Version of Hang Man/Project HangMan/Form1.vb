Public Class Form1
    Private Sub btnPlayGame_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        Const flag As Char = "!" 'used when user knows the whole word
        Const guessPrompt As String = "Enter a letter or    " & flag & "    to guess the word!" 'the prompt for the input box

        Dim length As Integer       'the length of the secret word
        Dim numGuesses As Integer   'the total number of guesses

        Dim secretWord As String        'the word for the user to guess
        Dim letterGuess As String       'the current letter the user has guessed
        Dim wordGuessed As String = ""  'the "dahsed" word that the user sees
        Dim wordGuess As String         'used if user guessed the entire word

        Dim endGame As Boolean = False  'used to determine if the game is over or not!

        'randomizes the 'secretWord' to get a random word from the Select Case
        Randomize()

        'random integer used for select case to determine which word is going to be the 'secretWord'
        secretWord = Int(2 * Rnd())

        Select Case secretWord
            Case 0
                secretWord = "idk1"
            Case 1
                secretWord = "Idk2"
            Case 2
                secretWord = "idk3"
        End Select

        'set the secretword to uppper case
        secretWord = secretWord.ToUpper

        'set number of dashes as letter in scretword
        length = secretWord.Length

        'depends on the length of the word to have the amount of *
        wordGuessed = wordGuessed.PadLeft(length, "*")

        'lbl = ****
        Me.lblSecretWord.Text = wordGuessed

        'input box
        letterGuess = InputBox(guessPrompt, "GUESS LETTER")
        letterGuess = letterGuess.ToUpper 'change to upper case for the guess of user

        'ends the game if value nothing is given
        If letterGuess = Nothing Then
            endGame = True
        End If

        'loop statement for the inputbox
        Do While letterGuess <> flag And wordGuessed <> secretWord And endGame = False
            'adds one for the user guess
            numGuesses += 1

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


            'prompt for another guess
            If wordGuessed <> secretWord Then
                letterGuess = InputBox(guessPrompt, "Guess Letter")
                letterGuess = letterGuess.ToUpper
            End If

            'if the inputbox = nothing then endGame=true
            If letterGuess = Nothing Then
                endGame = True
            End If
        Loop

        If wordGuessed = secretWord Then
            MessageBox.Show("YOU WIN!", "WIN")
            'if player enters '!' then they have to guess the whole word
        ElseIf letterGuess = flag Then
            wordGuess = InputBox("Enter the word", "WORD")
            wordGuess = wordGuess.ToUpper

            'wins if guessed right And create a new if statement for letterguess = flag
            If wordGuess = secretWord Then
                MessageBox.Show("YOU WIN!", "WIN")
                Me.lblSecretWord.Text = secretWord
                'otherwhise lose
            Else
                MessageBox.Show("YOU LOSE THE WORD WAS: " & secretWord, "LOSE")
                Me.lblSecretWord.Text = secretWord
            End If

            'ends the game if the user guess does not match with the secret word
        Else
            MessageBox.Show("YOU LOSE THE WORD WAS: " & secretWord, "LOSE")
            Me.lblSecretWord.Text = secretWord
        End If
    End Sub
End Class
