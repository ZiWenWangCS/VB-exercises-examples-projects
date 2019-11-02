Public Class Form1
    'determines whicfh shell as lcicked and displays a message if shell clicked is the 
    'same as a randomly chosen shell.
    '
    'pre: Shell picture objects have valid Tag properties
    'post: the hidden pearl has been shown and a message box has been displayed.
    '
    Private Sub picShell_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picShell1.Click,
        picShell2.Click, picShell3.Click

        'dtermine which shell was clicked by user 
        Dim picShellClicked As PictureBox = sender
        Dim shellClicked As Integer = Val(picShellClicked.Tag)

        'Pick the shell that hides he pearl
        Randomize()
        Dim shellWithPearl As Integer = Int(3 * Rnd()) + 1

        'show the pearl
        Select Case shellWithPearl
            Case 1
                Me.picPearl1.Visible = True
            Case 2
                Me.picPearl2.Visible = True
            Case 3
                Me.picPearl3.Visible = True
        End Select

        'Display message to player
        If shellClicked = shellWithPearl Then
            MessageBox.Show("You won!")
        Else
            MessageBox.Show("Sorry, you lose.")
        End If

        'Hide pearl again
        Select Case shellWithPearl
            Case 1
                Me.picPearl1.Visible = False
            Case 2
                Me.picPearl2.Visible = False
            Case 3
                Me.picPearl3.Visible = False
        End Select
    End Sub
End Class
