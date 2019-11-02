Public Class Form1
    Private Sub tmrForm_Tick(sender As Object, e As EventArgs) Handles tmrForm.Tick

        'tmrform tick
        ' this will switch the form background color between 4 different color
        Static formCounter As Integer = 0

        'if statement that determines which background color
        'to use fro the form
        If formCounter = 0 Then
            Me.BackColor = Color.Purple

            formCounter = 1
        ElseIf formCounter = 1 Then
            Me.BackColor = Color.MediumAquamarine

            formCounter = 2
        ElseIf formCounter = 2 Then
            Me.BackColor = Color.LimeGreen

            formCounter = 3
        Else
            Me.BackColor = Color.Cornsilk

            formCounter = 0
        End If
    End Sub
End Class
