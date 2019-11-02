Public Class Form1


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        tmrGo.Start()
        tmrStop.Start()
        tmrForm.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrGo.Stop()
        tmrStop.Stop()
        tmrForm.Stop()
    End Sub

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmrGo.Tick
        Static colorchange As Integer = 0

        If colorchange = 0 Then
            Me.btnGo.BackColor = Color.Green
            colorchange += 1

        ElseIf colorchange = 1 Then
            Me.btnGo.BackColor = Color.GreenYellow
            colorchange += 1
        Else
            Me.btnGo.BackColor = Color.Black
            colorchange = 0
        End If
    End Sub

    Private Sub tmrStop_Tick(sender As Object, e As EventArgs) Handles tmrStop.Tick
        Static colorchange As Integer = 0

        If colorchange = 0 Then
            Me.btnStop.BackColor = Color.Red
            colorchange += 1
        ElseIf colorchange = 1 Then
            Me.btnStop.BackColor = Color.Blue
            colorchange += 1
        Else
            Me.btnStop.BackColor = Color.Brown
            colorchange = 0
        End If

    End Sub

    Private Sub tmrForm_Tick(sender As Object, e As EventArgs) Handles tmrForm.Tick
        Static colorchange As Integer = 0

        If colorchange = 0 Then
            Me.BackColor = Color.Pink
            colorchange += 1
        ElseIf colorchange = 1 Then
            Me.BackColor = Color.Purple
            colorchange += 1
        Else
            Me.BackColor = Color.Orange
            colorchange = 0
        End If
    End Sub
End Class
