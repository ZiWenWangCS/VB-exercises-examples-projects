Public Class Form1
    Private Sub btnDarkKhaki_Click(sender As Object, e As EventArgs) Handles btnDarkKhaki.Click
        Me.BackColor = Color.DarkKhaki
    End Sub

    Private Sub btnHoneyDew_Click(sender As Object, e As EventArgs) Handles btnHoneyDew.Click
        Me.BackColor = Color.Honeydew
    End Sub

    Private Sub btnSalmon_Click(sender As Object, e As EventArgs) Handles btnSalmon.Click
        Me.BackColor = Color.Salmon
    End Sub

    Private Sub btnSkyBlue_Click(sender As Object, e As EventArgs) Handles btnSkyBlue.Click
        Me.BackColor = Color.SkyBlue
    End Sub

    Private Sub btnThistle_Click(sender As Object, e As EventArgs) Handles btnThistle.Click
        Me.BackColor = Color.Thistle
    End Sub

    Private Sub btnTurquoise_Click(sender As Object, e As EventArgs) Handles btnTurquoise.Click
        Me.BackColor = Color.Turquoise
    End Sub

    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnChooseColor.Click
        Me.ColorDialog1.ShowDialog()
        Me.BackColor = Me.ColorDialog1.Color
    End Sub
End Class
