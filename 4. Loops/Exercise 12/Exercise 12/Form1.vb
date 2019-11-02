Public Class Form1
    Private Sub btnCountVowels_Click(sender As Object, e As EventArgs) Handles btnCountVowels.Click
        Dim sentence As String = Me.txtSentenceEntered.Text
        Dim intCount As Integer
        Dim index As String = 0
        Dim newsentece As String

        newsentece = sentence.Replace("a", "#")
        newsentece = newsentece.Replace("e", "#")
        newsentece = newsentece.Replace("i", "#")
        newsentece = newsentece.Replace("u", "#")
        newsentece = newsentece.Replace("o", "#") ' replace vowel with # in new sentence

        index = newsentece.IndexOf("#") ' find # in the new sentence
        While index <> -1 ' do it while vowel cannot find
            newsentece = newsentece.Remove(index, 1) ' finds vowel and remove
            intCount += 1 ' add 1 if vowel is find
            index = newsentece.IndexOf("#") ' refind # for next vowel
        End While
        Me.lblAnswer.Text = intCount ' display the amount of vowel
    End Sub
End Class
