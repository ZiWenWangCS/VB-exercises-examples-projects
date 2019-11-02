Public Class Form1
    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        ' Create Drawing surfaces
        Dim labelDrawCurve As Graphics = Me.lblDrawCurve.CreateGraphics
        Dim labelDrawClosedCurve As Graphics = Me.lblDrawClosedCurved.CreateGraphics
        Dim labelFillClosedCurve As Graphics = Me.lblFillClosedCurve.CreateGraphics
        Dim labelDrawPolygon As Graphics = Me.lblDrawPolygon.CreateGraphics
        Dim labelFillPolygon As Graphics = Me.lblFillPolygon.CreateGraphics

        'Define pen and brush
        Dim tomatoPen As New Pen(Color.Tomato, 1)
        Dim tomatoBrush As New SolidBrush(Color.Tomato)

        'Define points
        Dim curvePoints() As Point = {New Point(10, 30), New Point(35, 35), New Point(75, 80),
            New Point(120, 20)}

        'Draw shapes
        labelDrawCurve.DrawCurve(tomatoPen, curvePoints)
        labelDrawClosedCurve.DrawClosedCurve(tomatoPen, curvePoints)
        labelFillClosedCurve.FillClosedCurve(tomatoBrush, curvePoints)
        labelDrawPolygon.DrawPolygon(tomatoPen, curvePoints)
        labelFillPolygon.FillPolygon(tomatoBrush, curvePoints)
    End Sub
End Class
