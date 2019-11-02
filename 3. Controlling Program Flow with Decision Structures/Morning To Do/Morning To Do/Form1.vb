Public Class Form1
    Private Sub chkLunch_Click(sender As Object, e As EventArgs) Handles chkLunch.Click
        If Me.chkLunch.Checked Then
            MsgBox("Don't forget bottled water!", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "WATER BOTTLE!")
        End If
    End Sub

    Private Sub btnAllDone_Click(sender As Object, e As EventArgs) Handles btnAllDone.Click
        If Not (Me.chkBed.Checked And Me.chkLunch.Checked _
               And Me.chkHomework.Checked And Me.chkTeeth.Checked) Then
            MsgBox("Did you forget somethign?", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "FORGET")
        Else
            Application.Exit()
        End If
    End Sub
End Class
