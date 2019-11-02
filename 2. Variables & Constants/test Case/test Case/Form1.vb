Public Class Form1
    'Zi Wen wang
    'Oct 3
    Private Sub radRegular_Click(sender As Object, e As EventArgs) Handles radRegular.Click
        Dim regular As Double
        Dim quantity As Integer

        quantity = Val(Me.txtQuantity.Text)
        regular = 1.05 * quantity
        Me.lblCost.Text = ("Mailing Cost:$" & regular)
    End Sub

    Private Sub radOversized_Click(sender As Object, e As EventArgs) Handles radOversized.Click
        Dim oversized As Double
        Dim quantity As Integer

        quantity = Val(Me.txtQuantity.Text)
        oversized = 1.25 * quantity
        Me.lblCost.Text = ("Mailing Cost:$" & oversized)
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Me.lblCost.Text = ""
    End Sub
End Class
