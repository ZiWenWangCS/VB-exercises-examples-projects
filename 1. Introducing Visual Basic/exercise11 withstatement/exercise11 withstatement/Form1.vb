Public Class Form1
    Private Sub btt_Click(sender As Object, e As EventArgs) Handles btt.Click
        With Me.lblCity
            .AutoSize = False
            .Text = "Dallas"
            .TextAlign = ContentAlignment.BottomCenter

        End With
    End Sub
End Class
