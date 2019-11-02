Public Class Form1
    Private Sub radDeepSkyBlue_Click(sender As Object, e As EventArgs) Handles radDeepSkyBlue.Click
        'Create drawing surface
        Dim form_surface As Graphics = Me.CreateGraphics
        'define the solid brush
        Dim deepBlueBrush As New SolidBrush(Color.DeepSkyBlue)

        'draw on form
        form_surface.FillRectangle(deepBlueBrush, 170, 20, 250, 370)
    End Sub

    Private Sub radLightSkyBlue_Click(sender As Object, e As EventArgs) Handles radLightSkyBlue.Click
        'Create drawing surface
        Dim form_surface As Graphics = Me.CreateGraphics
        'define the solid brush
        Dim lightBlueBrush As New SolidBrush(Color.LightSkyBlue)

        'draw on form
        form_surface.FillRectangle(lightBlueBrush, 170, 20, 250, 370)
    End Sub

    Private Sub radRedSun_Click(sender As Object, e As EventArgs) Handles radRedSun.Click
        Dim form_surface As Graphics = Me.CreateGraphics

        Dim redBrush As New SolidBrush(Color.Red)

        form_surface.FillEllipse(redBrush, 340, 40, 75, 75)
    End Sub

    Private Sub radYellowSun_Click(sender As Object, e As EventArgs) Handles radYellowSun.Click
        Dim form_surface As Graphics = Me.CreateGraphics

        Dim yellowBrush As New SolidBrush(Color.Yellow)

        form_surface.FillEllipse(yellowBrush, 340, 40, 75, 75)
    End Sub

    Private Sub radBrownRoof_Click(sender As Object, e As EventArgs) Handles radBrownRoof.Click
        Dim form_surface As Graphics = Me.CreateGraphics

        Dim brownBrush As New SolidBrush(Color.Brown)

        Dim curvePoints() As Point = {New Point(225, 225), New Point(340, 225),
            New Point(282.5, 90)}

        form_surface.FillPolygon(brownBrush, curvePoints)
    End Sub

    Private Sub radPurpleRoof_Click(sender As Object, e As EventArgs) Handles radPurpleRoof.Click
        Dim form_surface As Graphics = Me.CreateGraphics

        Dim purpleBrush As New SolidBrush(Color.Purple)

        Dim curvePoints() As Point = {New Point(225, 225), New Point(340, 225),
            New Point(282.5, 90)}

        form_surface.FillPolygon(purpleBrush, curvePoints)
    End Sub

    Private Sub radOliveHouse_Click(sender As Object, e As EventArgs) Handles radOliveHouse.Click
        Dim form_surface As Graphics = Me.CreateGraphics

        Dim oliveBrush As New SolidBrush(Color.Olive)

        form_surface.FillRectangle(oliveBrush, 225, 225, 115, 165)
    End Sub

    Private Sub radSlateGrayHouse_Click(sender As Object, e As EventArgs) Handles radSlateGrayHouse.Click
        Dim form_surface As Graphics = Me.CreateGraphics

        Dim slateGrayBrush As New SolidBrush(Color.SlateGray)

        form_surface.FillRectangle(slateGrayBrush, 225, 225, 115, 165)
    End Sub

    Private Sub radTurquoiseDoor_Click(sender As Object, e As EventArgs) Handles radTurquoiseDoor.Click
        Dim form_surface As Graphics = Me.CreateGraphics

        Dim turquoiseBrush As New SolidBrush(Color.Turquoise)

        form_surface.FillRectangle(turquoiseBrush, 260, 308, 40, 82)
    End Sub

    Private Sub radWhiteDoor_Click(sender As Object, e As EventArgs) Handles radWhiteDoor.Click
        Dim form_surface As Graphics = Me.CreateGraphics

        Dim whiteBrush As New SolidBrush(Color.White)

        form_surface.FillRectangle(whiteBrush, 260, 308, 40, 82)
    End Sub
End Class
