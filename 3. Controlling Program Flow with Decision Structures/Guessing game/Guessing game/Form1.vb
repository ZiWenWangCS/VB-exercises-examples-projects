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
        ElseIf guess > secreteNumber Then
            MsgBox("too high", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "TOO HIGH")
            'Me.lblMessage.Text = "Too high"
            counter += 1
        Else
            MsgBox("too low", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "TOO LOW")
            'Me.lblMessage.Text = "Too low"
            counter += 1
        End If

        MsgBox(counter, MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Guseed")

    End Sub

    Private Sub txtPlayerGuess_TextChanged(sender As Object, e As EventArgs) Handles txtPlayerGuess.TextChanged
        Me.lblMessage.Text = Nothing
    End Sub
End Class
