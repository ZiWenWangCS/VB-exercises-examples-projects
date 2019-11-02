Public Class Form1
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim sentence As String = Me.txtEnterSentence.Text
        Dim remove As String = Me.txtRemove.Text
        Dim userword As String
        Dim length As Integer
        Dim newsentence As String

        userword = sentence.IndexOf(remove)
        length = remove.Length
        newsentence = sentence.Remove(userword, length)
        Me.lblRemovedSentence.Text = newsentence
    End Sub
End Class
