Public Class Form1


    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Static color1, color2, color3 As Integer
        Static refresh As Integer = 0
        Dim user1, user2, user3 As String
        Dim colorCorrect As Integer = 0
        Dim positionCorrect As Integer = 0

        user1 = Me.txtGuess1.Text
        user2 = Me.txtGuess2.Text
        user3 = Me.txtGuess3.Text

        user1 = user1.ToUpper 'converts to upper case
        user2 = user2.ToUpper
        user3 = user3.ToUpper

        user1 = user1.Replace("R", "1") ' gets the char to numbers
        user1 = user1.Replace("G", "2")
        user1 = user1.Replace("B", "3")
        user1 = user1.Replace("Y", "4")

        user2 = user2.Replace("R", "1")
        user2 = user2.Replace("G", "2")
        user2 = user2.Replace("B", "3")
        user2 = user2.Replace("Y", "4")

        user3 = user3.Replace("R", "1")
        user3 = user3.Replace("G", "2")
        user3 = user3.Replace("B", "3")
        user3 = user3.Replace("Y", "3")

        If refresh = 0 Then ' this will prevent the color123 from keep getting random new number when user clicks the button
            Randomize()

            color1 = Int(4 * Rnd() + 1) ' randmize number between 1 - 4
            color2 = Int(4 * Rnd() + 1)
            color3 = Int(4 * Rnd() + 1)

            refresh += 1
        End If

        If user1 = color1 Or user1 = color2 Or user1 = color3 Then ' checking the color correct
            colorCorrect += 1
        End If

        If user2 = color1 Or user2 = color2 Or user2 = color3 Then
            colorCorrect += 1
        End If

        If user3 = color1 Or user3 = color2 Or user3 = color3 Then
            colorCorrect += 1
        End If

        If user1 = color1 Then
            positionCorrect += 1
        End If

        If user2 = color2 Then
            positionCorrect += 1
        End If

        If user3 = color3 Then
            positionCorrect += 1
        End If

        Me.lblColorCorrect.Text = "Corlo Correct:" & colorCorrect
        Me.lblPosition.Text = "Position Correct" & positionCorrect

        If user1 = color1 And user2 = color2 And user3 = color3 Then
            MessageBox.Show("YOUWIN!", "WIN")
            refresh -= 1 ' -1 then it would be 0 and so random number will be gnerated again
        Else
            MessageBox.Show("Try Again", "TRY")
        End If
    End Sub
End Class
