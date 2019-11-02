Public Class Form1
    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        'Background color on form is blue
        Me.BackColor = (Color.LightBlue)

        'Creat drawings surfaces
        Dim form_surface As Graphics = Me.CreateGraphics

        'Define brush/pen
        Dim thin_black_pen As New Pen(Color.Black, 2)
        Dim thin_purple_pen As New Pen(Color.Purple, 2)
        Dim orange_brush As New SolidBrush(Color.Orange)
        Dim white_brush As New SolidBrush(Color.White)

        'define  points
        Dim curvePoints() As Point = {New Point(60, 170), New Point(100, 225), New Point(200, 215),
            New Point(250, 150)}
        Dim flagPoints() As Point = {New Point(140, 85), New Point(100, 145), New Point(145, 165), New Point(140, 125)}
        Dim flagPoints2() As Point = {New Point(153, 100), New Point(180, 105), New Point(153, 170), New Point(160, 120)}
        Dim wavePoint() As Point = {New Point(0, 220), New Point(30, 240), New Point(60, 220), New Point(90, 240),
            New Point(120, 220), New Point(150, 240), New Point(180, 220), New Point(210, 240), New Point(240, 220),
            New Point(270, 240), New Point(300, 220)}

        'draw shapes
        form_surface.DrawCurve(thin_purple_pen, wavePoint)
        form_surface.FillPolygon(orange_brush, curvePoints)
        form_surface.DrawLine(thin_black_pen, 150, 75, 150, 200)
        form_surface.FillClosedCurve(white_brush, flagPoints)
        form_surface.FillClosedCurve(white_brush, flagPoints2)


    End Sub
End Class
