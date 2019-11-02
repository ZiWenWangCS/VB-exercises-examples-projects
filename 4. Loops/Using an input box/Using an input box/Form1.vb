Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Dim textEntered As String
        Dim stock As Integer
        Dim numEntered As String
        numEntered = InputBox("Enter the amount in stock", "Stock")

        If numEntered <> Nothing Then
            stock = Val(numEntered)
        End If
        'test data entered
        'textEntered = InputBox("Enter your name", "Name")
        'If textEntered = Nothing Then 'cancel or empty txtbox
        '    Me.lblUserName.Text = "Canceled."
        'Else
        '    Me.lblUserName.Text = textEntered ' text entered
        'End If
    End Sub
End Class
