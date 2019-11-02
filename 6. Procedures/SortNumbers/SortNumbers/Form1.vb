Public Class Form1
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim firstNum As Integer = Val(Me.txtFirstNum.Text)
        Dim secondNum As Integer = Val(Me.txtSecNum.Text)

        Call LowestToHighest(firstNum, secondNum)

        Me.lblSortedNum.Text = firstNum & ",  " & secondNum
    End Sub
    ' swaps the firstNum to secondNum if the first number is higher
    'lowest is firstNum
    'highest is SecondNum
    Sub LowestToHighest(ByRef lowest As Integer, ByRef highest As Integer)
        Dim temp As Integer
        If lowest > highest Then
            temp = lowest
            lowest = highest
            highest = temp
        End If
    End Sub
End Class
