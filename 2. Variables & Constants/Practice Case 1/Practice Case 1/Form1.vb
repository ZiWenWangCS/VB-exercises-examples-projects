Public Class Form1
    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Dim quantity As Double
        Dim cost As Double

        quantity = Val(Me.txtQuantity.Text)

        If Me.radRegular.Checked = True Then
            cost = 1.1 * quantity
            Me.lblCost.Text = ("Shipping cost: $" & cost)
        Else
            cost = 1.5 * quantity
            Me.lblCost.Text = ("Shipping cost: &" & cost)
        End If
    End Sub
End Class
