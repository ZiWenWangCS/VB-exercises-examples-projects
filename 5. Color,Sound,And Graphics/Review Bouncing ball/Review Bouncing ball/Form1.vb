Public Class Form1
    Private Sub tmrAnimateBall_Tick(sender As Object, e As EventArgs) Handles tmrAnimateBall.Tick
        Const MAX_IMAGES As Integer = 4
        Static newPosition As Integer = 0
        Static direction As Integer

        'display an image form array
        Me.picBall.Image = My.Resources.ball0

        'determine next image
        If newPosition = 0 Then
            direction = 1 ' change to upward direction
        ElseIf newPosition = MAX_IMAGES - 1 Then
            direction = -1 ' change to downward direction
        End If

        newPosition += direction

        'display next image
        Select Case newPosition
            Case 0
                Me.picBall.Image = My.Resources.ball0
            Case 1
                Me.picBall.Image = My.Resources.ball1
            Case 2
                Me.picBall.Image = My.Resources.ball2
            Case 3
                Me.picBall.Image = My.Resources.ball3
        End Select
    End Sub
End Class
