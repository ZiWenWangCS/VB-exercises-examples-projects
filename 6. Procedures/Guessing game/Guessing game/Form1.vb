Public Class Form1
    Const min As Integer = 1
    Const max As Integer = 50

    Private Sub btnCheckGuess_Click(sender As Object, e As EventArgs) Handles btnCheckGuess.Click
        Randomize()
        Static secreteNumber As Integer = Int((max - min + 1) * Rnd() + min) ' 50 * x + 1 would be >= to 1 and <= 50
        Dim guess As Integer
        Static counter As Integer = 0


        guess = Val(Me.txtPlayerGuess.Text)
        If guess = secreteNumber Then
            MsgBox("you guess it right", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "GUESSED RIGHT")
            secreteNumber = Int((max - min + 1) * Rnd() + min) ' if the player guessed it it will reset
            counter = 0
        ElseIf guess < min Or guess > max Then
            MessageBox.Show("Guess out of range.") 'invalid number
        Else
            Call GiveHint(Me.lblMessage, secreteNumber, guess) 'to low or to high
            counter += 1
        End If
        MessageBox.Show(counter, "Guessed")
    End Sub

    Private Sub txtPlayerGuess_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerGuess.TextChanged
        Me.lblMessage.Text = Nothing
    End Sub

    'determines if firstNum is larger than secondNum and then displays an 
    'appropriate message.
    '
    'post: a message has been displayed in a message box.
    '
    Sub GiveHint(ByRef lblHint As Label, ByVal firstNum As Integer, ByVal secondnum As Integer)
        If firstNum > secondnum Then
            lblHint.Text = "Too  Low"
        Else
            lblHint.Text = "Too High"
        End If
    End Sub
End Class
