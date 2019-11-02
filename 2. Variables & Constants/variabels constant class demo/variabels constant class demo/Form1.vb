Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lblPrompt.Text = "Click button to calculate the square of a number."
        'set the label text to be nothing
        Me.lblAnswer.Text = ""
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub btnDoStuff_Click(sender As Object, e As EventArgs) Handles btnDoStuff.Click
        'Declare variables at the beginning of an event
        Dim numbertoBeSquared As Integer

        'use an inputbox to get the number from the user
        numbertoBeSquared = Val(InputBox("Please enter a number you wish to know the square of", "Question"))

        'creat a variable to store an answer
        Dim answer As Integer 'default value is 0

        answer = numbertoBeSquared ^ 2

        'put answer on screen in lable

        Me.lblAnswer.Text = "the number " & numbertoBeSquared & " squared is = to " & answer
    End Sub

    Private Sub lblAnswer_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub
End Class
