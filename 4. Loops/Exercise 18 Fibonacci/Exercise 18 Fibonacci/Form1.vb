Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim sequence As String
        Dim previousnum, nextnum, temp As Long

        previousnum = Val(Me.txtFirstNum.Text)
        sequence += Convert.ToString(previousnum) & ","

        nextnum = Val(Me.txtSecNum.Text)
        sequence += Convert.ToString(nextnum) & ","

        For i As Integer = 3 To 50
            temp = nextnum
            nextnum = previousnum + nextnum
            previousnum = temp
            sequence += Convert.ToString(nextnum) & ","


            'MessageBox.Show(i)
        Next i
        Me.txtDock.Text = sequence

    End Sub
End Class
