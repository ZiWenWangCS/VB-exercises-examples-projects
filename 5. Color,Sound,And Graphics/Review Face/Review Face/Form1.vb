Public Class Form1
    Private Sub btnHappy_Click(sender As Object, e As EventArgs) Handles btnHappy.Click
        'creat drawing surface
        Dim formSurface As Graphics = Me.CreateGraphics
        'determine max X and max Y values
        Dim maxX As Integer = Me.Size.Width
        Dim maxY As Integer = Me.Size.Height

        'define the soild brush
        Dim brownBrush As New SolidBrush(Color.Brown)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim pinkBrush As New SolidBrush(Color.Pink)
        Dim indigoBrush As New SolidBrush(Color.Indigo)

        'draw on form
        formSurface.FillRectangle(brownBrush, 30, 40, maxX - 80, maxY - 100)
        formSurface.FillEllipse(indigoBrush, 30, 40, maxX - 80, maxY - 100)
        formSurface.FillEllipse(redBrush, 90, 80, 30, 30)
        formSurface.FillEllipse(redBrush, 150, 80, 30, 30)
        formSurface.FillEllipse(blueBrush, 120, 120, 30, 30)
        formSurface.FillPie(pinkBrush, 90, 150, 100, 60, 0, 180)

        'stop the wink
        tmrWink.Stop()

    End Sub

    Private Sub btnSad_Click(sender As Object, e As EventArgs) Handles btnSad.Click
        'creat drawing surface
        Dim formSurface As Graphics = Me.CreateGraphics
        'determine max X and max Y values
        Dim maxX As Integer = Me.Size.Width
        Dim maxY As Integer = Me.Size.Height

        'define the soild brush
        Dim brownBrush As New SolidBrush(Color.Brown)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim pinkBrush As New SolidBrush(Color.Pink)
        Dim indigoBrush As New SolidBrush(Color.Indigo)

        'draw on form
        formSurface.FillRectangle(brownBrush, 30, 40, maxX - 80, maxY - 100)
        formSurface.FillEllipse(indigoBrush, 30, 40, maxX - 80, maxY - 100)
        formSurface.FillEllipse(redBrush, 90, 80, 30, 30)
        formSurface.FillEllipse(redBrush, 150, 80, 30, 30)
        formSurface.FillEllipse(blueBrush, 120, 120, 30, 30)
        formSurface.FillPie(pinkBrush, 90, 170, 100, 60, 180, 180)

        'stop the wink
        tmrWink.Stop()
    End Sub

    Private Sub btnWink_Click(sender As Object, e As EventArgs) Handles btnWink.Click
        tmrWink.Start()
    End Sub

    Private Sub tmrWink_Tick(sender As Object, e As EventArgs) Handles tmrWink.Tick
        'creat drawing surface
        Dim formSurface As Graphics = Me.CreateGraphics
        'determine max X and max Y values
        Dim maxX As Integer = Me.Size.Width
        Dim maxY As Integer = Me.Size.Height

        'Creates the wink variable
        Static wink As Integer = 0
        Const resetWink As Integer = 2

        'define the soild brush
        Dim brownBrush As New SolidBrush(Color.Brown)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim pinkBrush As New SolidBrush(Color.Pink)
        Dim indigoBrush As New SolidBrush(Color.Indigo)
        'create a pen for wink
        Dim thinRedPen As New Pen(Color.Red, 3)

        'draw on form
        formSurface.FillRectangle(brownBrush, 30, 40, maxX - 80, maxY - 100)
        formSurface.FillEllipse(indigoBrush, 30, 40, maxX - 80, maxY - 100)
        formSurface.FillEllipse(redBrush, 150, 80, 30, 30)
        formSurface.FillEllipse(blueBrush, 120, 120, 30, 30)
        formSurface.FillPie(pinkBrush, 90, 150, 100, 60, 0, 180)

        'make if state for winking
        Select Case wink
            Case 0
                formSurface.FillEllipse(redBrush, 90, 80, 30, 30)
            Case 1
                formSurface.DrawArc(thinRedPen, 90, 80, 30, 30, 180, -180)
        End Select

        wink = (wink + 1) Mod resetWink
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear drawings
        Dim formSurface As Graphics = Me.CreateGraphics

        formSurface.Clear(Me.BackColor)
        tmrWink.Stop()
    End Sub
End Class
