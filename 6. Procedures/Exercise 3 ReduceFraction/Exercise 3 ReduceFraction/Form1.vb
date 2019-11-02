Public Class Form1
    Private Sub btnReduce_Click(sender As Object, e As EventArgs) Handles btnReduce.Click
        Dim num As Integer = Val(Me.txtNum.Text)
        Dim denom As Integer = Val(Me.txtDenom.Text)
        Dim answer As String

        Call Reduced(answer, num, denom)

        Me.lblReducedFraction.Text = answer
    End Sub

    Sub Reduced(ByRef fraction As String, ByVal top As Integer, ByVal bot As Integer)
        Dim low As Integer
        Dim GCD As Integer = 1

        If top < bot Then
            low = top
        Else
            low = bot
        End If

        For temp As Integer = 2 To low
            If top Mod temp = 0 And bot Mod temp = 0 Then
                GCD = temp
            End If
        Next temp
        fraction &= low & "/" & bot

        top = top / GCD
        bot = bot / GCD

        If bot <> 1 Then
            fraction &= " is reduced to " & top & "/" & bot
        Else
            fraction &= " is reduced to " & top
        End If
    End Sub
End Class
