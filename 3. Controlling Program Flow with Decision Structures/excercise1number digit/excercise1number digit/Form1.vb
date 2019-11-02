Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim digit As Integer

        digit = Val(Me.txtNumber.Text)
        If Me.txtNumber.Text.Length > 2 Then
            MsgBox("You have to enter a 2 or 1 digit number.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "2/1 DIGIT")
        ElseIf digit < 10 Then
            Me.lblDigit.Text = "One digit number"
        ElseIf digit >= 10 Then
            Me.lblDigit.Text = "Two digit number"
        End If
    End Sub
End Class
