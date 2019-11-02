Public Class Form1
    Private Sub btnPlayGame_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click
        Const secretWord As String = "NOODLE"
        Const flag As Char = "!"
        Const guessPrompt As String = "Enter a letter or    " & flag & "    to guess the word!"

        Dim length As Integer       'the length of the secret word
        Dim numGuesses As Integer   'the total number of guesses

        Dim letterGuess As String       'the current letter the user has guessed
        Dim wordGuessed As String = ""  'the "dahsed" word that the user sees
        Dim wordGuess As String         'used if user guessed the entire word
        Dim endGame As Boolean = False  'used to determine if the game is over or not!

        'set number of dashes as letter in scretword
        length = secretWord.Length
        'depends on the length of the word to have the amount of *
        wordGuessed = wordGuessed.PadLeft(length, "*")

        'word guessed will be *****
        Me.lblSecretWord.Text = wordGuessed

        letterGuess = InputBox(guessPrompt, "GUESS LETTER")
        letterGuess = letterGuess.ToUpper

        If letterGuess = Nothing Then
            endGame = True
        End If

        Do While letterGuess <> flag And wordGuessed <> secretWord And endGame = False And letterGuess <> Nothing
            numGuesses += 1

            'compare the each letter of secretWord to lettterGuess
            For i As Integer = 0 To length - 1
                If letterGuess = secretWord.Chars(i) Then
                    wordGuessed = wordGuessed.Remove(i, 1)
                    wordGuessed = wordGuessed.Insert(i, letterGuess)
                    'MessageBox.Show(wordGuessed)
                End If
            Next

            Me.lblSecretWord.Text = wordGuessed


            'prompt for another guess
            If wordGuessed <> secretWord Then
                letterGuess = InputBox(guessPrompt, "Guess Letter")
                letterGuess = letterGuess.ToUpper
            ElseIf letterGuess = Nothing Then
                endGame = True
            End If

        Loop


        'player losses or wins
        If wordGuessed = secretWord Then
            MessageBox.Show("YOU WIN!", "WIN")
            'if player enters '!' then they have to guess the whole word
        ElseIf letterGuess = flag Then
            wordGuess = InputBox("Enter the word", "WORD")
            wordGuess = wordGuess.ToUpper
            'wins if guessed right
            If wordGuess = secretWord Then
                MessageBox.Show("YOU WIN!", "WIN")
                Me.lblSecretWord.Text = secretWord
                'otherwhise lose
            Else
                MessageBox.Show("YOU LOSE THE WORD WAS: " & secretWord, "LOSE")
                Me.lblSecretWord.Text = secretWord
            End If
        Else
            MessageBox.Show("YOU LOSE THE WORD WAS: " & secretWord, "LOSE")
            Me.lblSecretWord.Text = secretWord
        End If
    End Sub

End Class
