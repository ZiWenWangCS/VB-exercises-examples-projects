Public Class Form1
    Private Sub bttnAnswer_Click(sender As Object, e As EventArgs) Handles bttnAnswer.Click
        Dim side As Integer 'side of squre
        Dim area As Integer

        side = Val(Me.txtSide.Text)
        area = side * side
        Me.lblAnswer.Text = area ' display answer
    End Sub

    Private Sub txtSide_TextChanged(sender As Object, e As EventArgs) Handles txtSide.TextChanged
        'clear the current answer when the user begin to type a new value
        Me.lblAnswer.Text = ""
    End Sub
End Class
