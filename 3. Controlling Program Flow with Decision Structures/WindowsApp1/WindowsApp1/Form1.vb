Public Class Form1

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim x As Integer = 20
        Dim y As Integer
        x = 5 * 2
        y = x * 3
        Me.Label1.Text = y
    End Sub
End Class
