Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim quarters As Integer = Val(Me.txtQuarters.Text)
        Dim dimes As Integer = Val(Me.txtDimes.Text)
        Dim nickels As Integer = Val(Me.txtNickels.Text)
        Dim pennies As Integer = Val(Me.txtPennies.Text)
        Dim total As Double

        Call TotalDollars(total, quarters, dimes, nickels, pennies)

        Me.lblTotal.Text = "Total: $" & total
    End Sub

    Sub TotalDollars(ByRef addup As Double, ByVal quaters As Double, ByVal dimes As Double,
                     ByVal nickels As Double, ByVal pennies As Double) 'sets all to double
        quaters = 0.25 * quaters
        dimes = 0.1 * dimes
        nickels = 0.05 * nickels
        pennies = 0.01 * pennies
        addup = quaters + dimes + nickels + pennies
    End Sub
End Class
