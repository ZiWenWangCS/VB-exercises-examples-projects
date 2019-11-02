Public Class Form1

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim numcards As Integer

        numcards = 5
        Me.lblAnswer.Text = numcards
    End Sub
End Class
