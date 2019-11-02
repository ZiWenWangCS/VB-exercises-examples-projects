Public Class Form1
    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        Dim length As Double
        Dim width As Double
        Dim area As Double
        Dim perimeter As Double

        length = Val(Me.txtLength.Text)
        width = Val(Me.txtWidth.Text)
        area = length * width
        perimeter = 2 * (length + width)
        Me.lblArea.Text = ("Area=" & area)
        Me.lblPerimeter.Text = ("Perimeter=" & perimeter)


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
