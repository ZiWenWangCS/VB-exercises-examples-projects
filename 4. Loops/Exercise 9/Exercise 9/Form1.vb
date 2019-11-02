Public Class Form1
    'Ziwen Wang
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim startNUm, endNum, sum As Integer
        'Dim mathexpression As String

        startNUm = Val(Me.txtStartNum.Text)
        endNum = Val(Me.txtEndNum.Text)

        For i As Integer = startNUm To endNum
            'If i = startNUm Then
            '    mathexpression += Convert.ToString(i)
            'Else
            '    mathexpression += "+" & Convert.ToString(i)
            'End If
            If i = endNum Then
                Me.lblAnswer.Text &= i
            Else
                Me.lblAnswer.Text &= i & "+"
            End If
            sum += i
        Next i
        Me.lblAnswer.Text &= "=" & sum
    End Sub
End Class
