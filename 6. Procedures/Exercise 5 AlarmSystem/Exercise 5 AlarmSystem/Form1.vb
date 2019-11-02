Public Class Form1
    Dim userCode As Long
    Const masterCode As Integer = 62498

    Sub btnClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.Click,
            btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click,
            btn0.Click

        Dim btnNumClicked As Button = sender
        Dim numClicked As Integer = Val(btnNumClicked.Tag)

        Me.txtPassword.Text &= "*"


        Select Case numClicked
            Case 0 To 9
                userCode &= numClicked
        End Select

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If userCode.Equals(masterCode) Then
            MessageBox.Show("Correct")
        Else
            MessageBox.Show("Incorrect")
            Me.txtPassword.Text = Nothing
        End If
    End Sub
End Class
