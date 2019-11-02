Public Class Form1
    'pg 141 review: findstring
    'ziwen
    'nov 13 2017
    Private Sub btnFindString_Click(sender As Object, e As EventArgs) Handles btnFindString.Click
        Dim text As String = Me.txtText.Text
        Dim searchText As String = Me.txtSearchText.Text
        Dim pos As Integer

        pos = text.IndexOf(searchText)

        If pos = -1 Then
            Me.lblPositionMessage.Text = "Search Text Not Find"
        Else
            Me.lblPositionMessage.Text = "Position of search text:"
            Me.lblAnswer.Text = pos
        End If


    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        Me.lblPositionMessage.Text = Nothing
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        Me.lblPositionMessage.Text = Nothing
        Me.lblAnswer.Text = Nothing
    End Sub
End Class
