Public Class Form1
    Sub btnClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHigh.Click, btnLow.Click
        Static points As Integer = 1000
        Dim randomNum As Integer
        Dim pointRisked As Integer = Val(Me.txtRiskPoint.Text)

        Randomize()
        randomNum = Int(14 * Rnd() + 1)


        If randomNum <> 7 Then
            Select Case sender.tag
                Case "Low"
                    If TestRndIntFunction(randomNum) Then
                        points += pointRisked * 2
                    Else
                        points -= pointRisked
                    End If
                Case "High"
                    If Not TestRndIntFunction(randomNum) Then
                        points += pointRisked * 2
                    Else
                        points -= pointRisked
                    End If
            End Select
        Else
            points -= pointRisked
        End If

        If points < 0 Then
            points = 1000
            MessageBox.Show("Game Over Restart!")
        End If

        Me.lblPoints.Text = "The number was" & points
        Me.lblRndNum.Text = "Total points = " & randomNum
    End Sub

    Function TestRndIntFunction(ByRef num As Integer) As Boolean
        If num < 7 Then
            Return True
        ElseIf num > 7 Then
            Return False
        End If
    End Function
End Class
