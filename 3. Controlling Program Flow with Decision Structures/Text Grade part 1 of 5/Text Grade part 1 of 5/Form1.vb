Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim score As Integer

        score = Val(Me.txtScore.Text)
        Select Case score
            Case 0 = 2 Mod
                Me.lblGoodjob.Text = "A"
            Case 80 To 89
                Me.lblGoodjob.Text = "B"
            Case 70 To 79
                Me.lblGoodjob.Text = "C"
            Case 60 To 79
                Me.lblGoodjob.Text = "D"
            Case 60 To 0
                Me.lblGoodjob.Text = "F"
            Case < 0, > 100
                MsgBox("Invalid Number", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "INVALID NUMBER") ' okayonly displays the title on the top and infromation is in the middle of the text box
        End Select


    End Sub
End Class
