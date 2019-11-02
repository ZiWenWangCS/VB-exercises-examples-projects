Public Class Form1
    Private Sub btnCoins_Click(sender As Object, e As EventArgs) Handles btnCoins.Click
        Dim quarters, dimes, nickels, pennies As Integer 'declare type of change
        Dim change As Double 'declare changes
        Dim temp As Double ' declare the left overs

        change = Val(Me.txtChange.Text)

        quarters = Int(change / 25)
        temp = change - (quarters * 25)
        Me.lblQuarters.Text = ("Quarters:" & quarters)

        dimes = Int(temp / 10)
        temp = temp - (dimes * 10)
        Me.lblDimes.Text = ("Dimes:" & dimes)

        nickels = Int(temp / 5)
        temp = temp - (nickels * 5)
        Me.lblNickels.Text = ("Nickles:" & nickels)

        pennies = Int(temp / 1)
        temp = temp - (pennies * 1)
        Me.lblPennies.Text = ("Pennies:" & pennies)


    End Sub
End Class
