Public Class Form1
    Private Sub btnDigits_Click(sender As Object, e As EventArgs) Handles btnDigits.Click
        If Not IsNumeric(Me.txtNumber.Text) Then
            MsgBox("You have to enter a number between 10 - 99 in the text box.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Not a number") 'when no text is texted in txtbox then it will pop a msgbox
        ElseIf Me.txtNumber.Text.Length <> 2 Then
            MsgBox("You have to enter a 2 digit number in the box.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Not 2 digit number") 'when more or less than 2 digit number is entered then msg box would pop
        Else
            Me.lbl1stDigit.Text = ("First digit" & Me.txtNumber.Text.Substring(0, 1))   ' when txt box is texed with 2 digit then 0= to the 1st digit number 1= showing only 1 number
            Me.lbl2ndDigit.Text = ("Second digit" & Me.txtNumber.Text.Substring(1, 1))  ' 1 = the second number of the txt box and 1 = shows only 1 number
        End If
    End Sub

    Private Sub DigitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigitsToolStripMenuItem.Click
        If Not IsNumeric(Me.txtNumber.Text) Then
            MsgBox("You have to enter a number between 10 - 99 in the text box.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Not a number") 'when no text is texted in txtbox then it will pop a msgbox
        ElseIf Me.txtNumber.Text.Length <> 2 Then
            MsgBox("You have to enter a 2 digit number in the box.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Not 2 digit number") 'when more or less than 2 digit number is entered then msg box would pop
        Else
            Me.lbl1stDigit.Text = ("First digit" & Me.txtNumber.Text.Substring(0, 1))   ' when txt box is texed with 2 digit then 0= to the 1st digit number 1= showing only 1 number
            Me.lbl2ndDigit.Text = ("Second digit" & Me.txtNumber.Text.Substring(1, 1))  ' 1 = the second number of the txt box and 1 = shows only 1 number
        End If

    End Sub
End Class
