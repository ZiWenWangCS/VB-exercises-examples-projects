Public Class Form1
    'ziwen
    'nov 6
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim testNum As Integer


        testNum = Val(Me.txtInteger.Text)
        'test number
        Dim divisor As Integer = 1
        If testNum <= 1 Then
            Me.lblPrimeResult.Text = "Not a prime number"
        Else
            Do
                divisor += 1
            Loop While testNum Mod divisor <> 0
            If divisor = testNum Then
                Me.lblPrimeResult.Text = "Test number is prime"
            Else
                Me.lblPrimeResult.Text = "test number is not prime"
            End If
        End If
    End Sub

    Private Sub txtInteger_TextChanged(sender As Object, e As EventArgs) Handles txtInteger.TextChanged
        'clear the previous test result
        Me.lblPrimeResult.Text = Nothing
    End Sub
End Class
