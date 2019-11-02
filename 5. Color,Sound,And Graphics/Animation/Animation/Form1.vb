Public Class Form1
    Private Sub tmrAnimate_Tick(sender As Object, e As EventArgs) Handles tmrAnimate.Tick
        Const MAX_IMAGES As Integer = 10
        Static imagenum As Integer = 0

        ' display image from array
        Select Case imagenum
            Case 0
                Me.picCurrent.Image = My.Resources.splash1
            Case 2
                Me.picCurrent.Image = My.Resources.splash2
            Case 3
                Me.picCurrent.Image = My.Resources.splash3
            Case 4
                Me.picCurrent.Image = My.Resources.splash4
            Case 5
                Me.picCurrent.Image = My.Resources.splash5
            Case 6
                Me.picCurrent.Image = My.Resources.splash6
            Case 7
                Me.picCurrent.Image = My.Resources.splash7
            Case 8
                Me.picCurrent.Image = My.Resources.splash8
            Case 9
                Me.picCurrent.Image = My.Resources.splash9
            Case 10
                Me.picCurrent.Image = My.Resources.splash10
        End Select

        ' determine  image number
        imagenum = (imagenum + 1) Mod MAX_IMAGES
        ' 1/10 is r 1 
        ' 10/10 r 0 so goes back and do case 0
    End Sub
End Class
