Public Class Form1
    Private Sub bttnAnswer_Click(sender As Object, e As EventArgs) Handles bttnAnswer.Click
        Dim side As Integer
        Dim side1 As Integer
        Dim area As Integer

        side = Val(Me.txtLength.Text)
        side1 = Val(Me.txtWidth.Text)
        area = side * side1
        Me.lblAnswer.Text = area
    End Sub

    Private Sub txtLength_TextChanged(sender As Object, e As EventArgs) Handles txtLength.TextChanged
        Me.lblAnswer.Text = ""
    End Sub

    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class
