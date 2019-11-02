Public Class Form1
    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        Dim sentence As String = Me.txtSentence.Text
        Dim replaceword As String = Me.txtReplace.Text
        Dim searchword As String = Me.txtSearchText.Text
        Dim replacing As String

        replacing = sentence.Replace(searchword, replaceword) ' word is replaced
        Me.lblAnswer.Text = replacing
    End Sub
End Class
