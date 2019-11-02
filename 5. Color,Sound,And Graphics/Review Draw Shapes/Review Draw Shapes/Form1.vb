Public Class Form1
    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        'create a drawing surface
        Dim formSurface As Graphics = Me.CreateGraphics

        'determine max X and max Y values
        Dim maxX As Integer = Me.Size.Width
        Dim maxY As Integer = Me.Size.Height

        'define all the pens
        Dim lightSeaGreenPen As New Pen(Color.LightSeaGreen, 2)
        Dim thickerDeepPinkPen As New Pen(Color.DeepPink, 10)
        Dim thickDogerBluePen As New Pen(Color.DodgerBlue, 5)
        Dim thinRedPen As New Pen(Color.Red, 3)

        'Draw thin LightSeaGreen horizontal line
        formSurface.DrawLine(lightSeaGreenPen, 30, maxY \ 3, maxX - 30, maxY \ 3)

        'Draw thicker DeepPink circle (ellipse)
        formSurface.DrawEllipse(thickerDeepPinkPen, maxY \ 2, maxY \ 2, 40, 40)

        'Draw thick DashDotDot DodgerBlue rectangle
        thickDogerBluePen.DashStyle = Drawing.Drawing2D.DashStyle.DashDotDot
        formSurface.DrawRectangle(thickDogerBluePen, 80, maxY \ 4, maxX \ 3, 70)

        'Draw thin Red arc
        formSurface.DrawArc(thinRedPen, 30, 0, maxX - 60, maxY - 60, 0, 180)

    End Sub
End Class
