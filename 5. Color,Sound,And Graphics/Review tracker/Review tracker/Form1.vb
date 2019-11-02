Public Class Form1
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Static previousPoint As Point ' remember the previous mouse click
        Dim formsurface As Graphics = Me.CreateGraphics
        Dim orangeRedPen As New Pen(Color.OrangeRed, 3)
        Dim mouseclick As Point


        'get point of mouse click
        mouseclick.X = e.X
        mouseclick.Y = e.Y

        'draw line from previous point to point clicked
        formsurface.DrawLine(orangeRedPen, previousPoint, mouseclick)

        'make point clicked the next starting point
        previousPoint = mouseclick
    End Sub
End Class
