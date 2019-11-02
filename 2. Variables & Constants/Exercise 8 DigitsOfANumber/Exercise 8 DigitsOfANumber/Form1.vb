Public Class Form1
    Private Sub btnDigits_Click(sender As Object, e As EventArgs) Handles btnDigits.Click
        Dim digit As Double 'declare digit
        Dim firstdigit, seconddigit As Double 'declare firs and second digit

        digit = Val(Me.txtNumber.Text)

        firstdigit = Val(Me.txtNumber.Text.First)
        Me.lblFirstdigit.Text = ("The first digit is:" & firstdigit)

        seconddigit = Val(Me.lblFirstdigit.Text.Select(Of)
        Me.lblSeconddigit.Text = ("The second digit is:" & seconddigit)
    End Sub
End Class
