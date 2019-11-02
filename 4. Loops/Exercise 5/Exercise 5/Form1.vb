Public Class Form1
    Private Sub btnMonogram_Click(sender As Object, e As EventArgs) Handles btnMonogram.Click
        Dim firstInitial As String
        Dim middleInitial As String
        Dim lastInitial As String
        Dim fullName As String
        Dim index As String
        Dim index2 As String

        fullName = Me.txtFullName.Text

        firstInitial = fullName.Chars(0) ' first initial find
        index = fullName.IndexOf(" ") ' find the space
        middleInitial = fullName.Substring(index + 1, 1) ' middle initial find
        fullName = fullName.Remove(index, 1) ' delet space so we can find the next index for last
        index2 = fullName.IndexOf(" ") ' find the space
        lastInitial = fullName.Substring(index2 + 1, 1) ' last initial find by adding 1 to index
        Me.lblInitials.Text = firstInitial & middleInitial & lastInitial ' first, middle, last
    End Sub
End Class
