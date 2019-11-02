Public Class Form1
    'nov 9 2017
    'ziwen
    'page 137 chapter 5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnComputeFactorial.Click
        Dim factorial As Double = 1
        Dim number As Integer

        number = Val(Me.txtNumber.Text) 'get the number form user
        For count As Integer = 1 To number
            factorial *= count
        Next count

        Me.lblFactorialMessage.Text = "Facotrial is:"
        Me.lblFactorial.Text = factorial
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        Me.lblFactorialMessage.Text = Nothing
        Me.lblFactorial.Text = Nothing
    End Sub
End Class
