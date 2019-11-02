Public Class Form1
    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        'create drawing surface
        Dim formsurface As Graphics = Me.CreateGraphics

        ' defin pen
        Dim indigoPen As New Pen(Color.Indigo, 5)
        Dim salmonPen As New Pen(Color.Salmon, 3)
        Dim blackPen As New Pen(Color.Black, 2)

        'draw on form
        formsurface.DrawRectangle(indigoPen, 0, 0, 200, 200)
        formsurface.DrawEllipse(salmonPen, 0, 0, 200, 200)
        formsurface.DrawArc(blackPen, 0, 0, 100, 100, 0, 120)
    End Sub
End Class
