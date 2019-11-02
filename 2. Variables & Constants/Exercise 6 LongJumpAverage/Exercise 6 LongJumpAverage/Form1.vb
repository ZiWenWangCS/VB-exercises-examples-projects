Public Class Form1
    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim first, second, third, four As Double 'declare the length of jumps
        Dim average As Double 'declare the average of jump

        first = Val(Me.txt1stJump.Text)
        second = Val(Me.txt2ndJump.Text)
        third = Val(Me.txt3rdJump.Text)
        four = Val(Me.txt4thJump.Text)
        average = (first + second + third + four) / 4
        Me.lblAverage.Text = ("Average:" & average)


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
