Public Class Form1
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim work As String = "i dont know"
        Dim length As Integer
        Dim word As Integer
        length = work.Length
        Me.lblAnswer.Text = work
        For count As Integer = 0 To length
            If work = Text.IndexOf("i dont know") Then
                word += 1
            End If
        Next count
        Me.Label1.Text = word
    End Sub
End Class
