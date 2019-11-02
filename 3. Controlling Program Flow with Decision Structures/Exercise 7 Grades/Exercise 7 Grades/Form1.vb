Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Dim Grade As String
        Static numFailed As Integer = 0
        Static numPassed As Integer = 0


        Grade = (Me.txtGrade.Text)

        If Grade = "A" Or Grade = "a" Or Grade = "B" Or Grade = "b" Or Grade = "C" Or Grade = "c" Or Grade = "D" Or Grade = "d" Then
            numPassed = numPassed + 1
        ElseIf Grade = "f" Or Grade = "F" Then
            numFailed = numFailed + 1
        Else
            MsgBox("Invalid number", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "INVALIDE NUMBER")
        End If


        Me.lblPassed.Text = ("Number of students that passed = " & numPassed)
        Me.lblFailed.Text = ("Number of students that passed = " & numFailed)

    End Sub
End Class
