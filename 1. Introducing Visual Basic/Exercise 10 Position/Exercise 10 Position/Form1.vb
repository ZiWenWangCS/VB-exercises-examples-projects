Public Class Form1
    Private Sub BottomCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottomCenterToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.BottomCenter
    End Sub

    Private Sub BottomleftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottomleftToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.BottomLeft
    End Sub

    Private Sub BottomRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottomRightToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.BottomRight
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MiddleCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiddleCenterToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub MiddleLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiddleLeftToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.MiddleLeft

    End Sub

    Private Sub MiddleRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiddleRightToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.MiddleRight

    End Sub

    Private Sub TopCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopCenterToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.TopCenter

    End Sub

    Private Sub TopLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopLeftToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.TopLeft

    End Sub

    Private Sub TopRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopRightToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.TopRight

    End Sub
End Class
