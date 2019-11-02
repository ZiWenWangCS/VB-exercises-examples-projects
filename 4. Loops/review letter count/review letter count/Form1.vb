Public Class Form1
    'Ziwen
    'Nov 10 2017
    'Page 140 chap 15


    Private Sub btnCountLetter_Click(sender As Object, e As EventArgs) Handles btnCountLetter.Click
        Dim text As String = Me.txtText.Text
        Dim character As Integer = 0
        Dim searchText As String = Me.txtSearchText.Text
        Dim textLength As Integer = text.Length

        text = text.ToLower
        searchText = searchText.ToLower

        For index As Integer = 0 To textLength - 1
            If text.Chars(index) = searchText Then
                character += 1
            End If
        Next index
        Me.lblAnswer.Text = character
        Me.lblMessage.Text = "Number of times the letter occurs:"
    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        Me.lblAnswer.Text = Nothing
        Me.lblMessage.Text = Nothing
    End Sub

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        Me.lblAnswer.Text = Nothing
        Me.lblMessage.Text = Nothing
    End Sub
End Class
