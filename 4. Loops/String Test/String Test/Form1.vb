Public Class Form1
    'Ziwen
    'Nov10 2017
    'page 140 string test chap 5

    Private Sub btnDisplayData_Click(sender As Object, e As EventArgs) Handles btnDisplayData.Click
        Dim text As String
        Dim length As Integer
        Dim first, middle, last As Char

        text = Me.txtText.Text
        length = text.Length
        first = text.Chars(0)
        last = text.Chars(length - 1)
        middle = text.Chars(length / 2)

        Me.lblFirstLetter.Text = first
        Me.lblMiddleLetter.Text = middle
        Me.lblLastLetter.Text = last


    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        Me.lblFirstLetter.Text = Nothing
        Me.lblMiddleLetter.Text = Nothing
        Me.lblLastLetter.Text = Nothing
    End Sub
End Class
