Public Class Form1
    ' ziwen
    ' nov 9 2017
    ' page 138 review: odd numbers sum
    Private Sub btnSumOddNumbers_Click(sender As Object, e As EventArgs) Handles btnSumOddNumbers.Click
        Dim maxNum As Integer
        Dim sum As Integer

        maxNum = Val(Me.txtMaxValue.Text)
        For counter As Integer = 1 To maxNum
            sum += counter
        Next counter

        Me.lblSumMessage.Text = "The sum is:"
        Me.lblSum.Text = sum
    End Sub

    Private Sub txtMaxValue_TextChanged(sender As Object, e As EventArgs) Handles txtMaxValue.TextChanged
        Me.lblSum.Text = Nothing
        Me.lblSumMessage.Text = Nothing
    End Sub
End Class
