Public Class Form1
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Const small As Double = 2.5
        Const large As Integer = 4
        Const cheese As Double = 0.5
        Const lettuce As Double = 0.1
        Const onion As Double = 0.1
        Const tomato As Double = 0.25
        Dim total As Double = 0.0

        If Me.radSmall.Checked Then
            total += small
        ElseIf Me.radLarge.Checked Then
            total += large
        End If

        If Me.chkCheese.Checked Then
            total += cheese
        End If

        If Me.chkLettuce.Checked Then
            total += lettuce
        End If

        If Me.chkOnion.Checked Then
            total += onion
        End If

        If Me.chkTomato.Checked Then
            total += tomato
        End If

        Me.lblPrice.Text = ("Total Price = $ " & total)


    End Sub
End Class
