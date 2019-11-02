Public Class Form1
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.btnAverage.BackColor = Color.MediumSeaGreen
        Me.btnFast.BackColor = Color.MediumSeaGreen
        Me.btnSlow.BackColor = Color.MediumSeaGreen
        Me.BackColor = Color.White
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        tmrAverage.Start()
    End Sub

    Private Sub btnFast_Click(sender As Object, e As EventArgs) Handles btnFast.Click
        tmrFast.Start()
    End Sub

    Private Sub btnSlow_Click(sender As Object, e As EventArgs) Handles btnSlow.Click
        tmrSlow.Start()
    End Sub

    Private Sub tmrAverage_Tick(sender As Object, e As EventArgs) Handles tmrAverage.Tick
        'sets the interval to an average speed
        Me.tmrAverage.Interval = 500

        Const MAX_IMAGES As Integer = 3
        Static imagenum As Integer = 0

        Select Case imagenum
            Case 0
                Me.picTurtle.Image = My.Resources.turtle1
            Case 1
                Me.picTurtle.Image = My.Resources.turtle2
            Case 2
                Me.picTurtle.Image = My.Resources.turtle3
        End Select

        ' repeats the image
        imagenum = (imagenum + 1) Mod MAX_IMAGES


    End Sub

    Private Sub tmrFast_Tick(sender As Object, e As EventArgs) Handles tmrFast.Tick
        'sets the interval to an average speed
        Me.tmrFast.Interval = 100

        Const MAX_IMAGES As Integer = 3
        Static imagenum As Integer = 0

        Select Case imagenum
            Case 0
                Me.picTurtle.Image = My.Resources.turtle1
            Case 1
                Me.picTurtle.Image = My.Resources.turtle2
            Case 2
                Me.picTurtle.Image = My.Resources.turtle3
        End Select

        ' repeats the image
        imagenum = (imagenum + 1) Mod MAX_IMAGES

    End Sub

    Private Sub tmrSlow_Tick(sender As Object, e As EventArgs) Handles tmrSlow.Tick
        'sets the interval to an average speed
        Me.tmrSlow.Interval = 750

        Const MAX_IMAGES As Integer = 3
        Static imagenum As Integer = 0

        Select Case imagenum
            Case 0
                Me.picTurtle.Image = My.Resources.turtle1
            Case 1
                Me.picTurtle.Image = My.Resources.turtle2
            Case 2
                Me.picTurtle.Image = My.Resources.turtle3
        End Select

        ' repeats the image
        imagenum = (imagenum + 1) Mod MAX_IMAGES

    End Sub
End Class
