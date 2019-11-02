Public Class Form1
    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        Dim copies As Integer
        Dim price As Double
        Dim total As Double

        copies = Val(Me.txtCopies.Text)

        Select Case copies
            Case 0 To 499
                price = 0.3
                total = price * copies

                Me.lblPerCopy.Text = ("Price per copy is$" & price)
                Me.lblTotalPrice.Text = ("The total price is$" & total)
            Case 500 To 749
                price = 0.28
                total = price * copies

                Me.lblPerCopy.Text = ("Price per copy is$" & price)
                Me.lblTotalPrice.Text = ("The total price is$" & total)
            Case 750 To 999
                price = 0.27
                total = price * copies

                Me.lblPerCopy.Text = ("Price per copy is$" & price)
                Me.lblTotalPrice.Text = ("The total price is$" & total)
            Case >= 1000
                price = 0.25
                total = price * copies

                Me.lblPerCopy.Text = ("Price per copy is$" & price)
                Me.lblTotalPrice.Text = ("The total price is$" & total)
        End Select
    End Sub
End Class
