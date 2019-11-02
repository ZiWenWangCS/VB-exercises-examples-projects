Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrDraw.Start()
        'starts the tmr
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrDraw.Stop()
        'stops the tmr
    End Sub

    Private Sub tmrDraw_Tick(sender As Object, e As EventArgs) Handles tmrDraw.Tick
        ' create the drawing surface
        Dim formSurface As Graphics = Me.CreateGraphics

        'the starting point of the ellipse
        Dim xValue, yValue As Integer

        ' how long/wide to draw
        Dim widthValue, heightValue As Integer

        ' delcare the size of max x,y value
        Dim maxX As Integer = Me.Size.Width
        Dim maxY As Integer = Me.Size.Height

        'declare the brush
        Dim pinkBrush As New SolidBrush(Color.Pink)
        Dim purpleBrush As New SolidBrush(Color.Purple)
        Dim blueBrush As New SolidBrush(Color.Blue)

        'declare the random nubmer for brushes
        Dim brush As Integer

        'clear the screen
        formSurface.Clear(Me.BackColor)

        Randomize()
        ' below 80% of the maxx value
        xValue = Int(maxX * 0.8 * Rnd())
        yValue = Int(maxY * 0.8 * Rnd())


        Do
            ' loops so it does not draw off the side of the screen
            widthValue = Int(maxX * Rnd() + 1)
        Loop While widthValue + xValue + 11 > maxX

        Do
            heightValue = Int(maxY * Rnd() + 1)
        Loop While heightValue + yValue + 38 > maxY

        'gets number 1-3 for brushes
        brush = Int(3 * Rnd() + 1)

        'draw the ellipse with if satements for brush colors
        If brush = 1 Then
            formSurface.FillEllipse(pinkBrush, xValue, yValue, widthValue, heightValue)
        ElseIf brush = 2 Then
            formSurface.FillEllipse(purpleBrush, xValue, yValue, widthValue, heightValue)
        ElseIf brush = 3 Then
            formSurface.FillEllipse(blueBrush, xValue, yValue, widthValue, heightValue)
        End If
    End Sub
End Class
