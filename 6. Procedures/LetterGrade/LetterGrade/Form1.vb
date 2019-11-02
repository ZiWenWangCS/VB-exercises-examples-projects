Public Class Form1
    Private Sub btnLetterGrade_Click(sender As Object, e As EventArgs) Handles btnLetterGrade.Click
        Const LOWEST_SCORE As Double = 0
        Const HIGHEST_SCORE As Double = 100
        Dim scoreEntered As Double

        scoreEntered = Val(Me.txtScore.Text)

        If Not ValidEntry(scoreEntered, HIGHEST_SCORE, LOWEST_SCORE) Then
            MessageBox.Show("Enter a score between " & LOWEST_SCORE & " and " &
                            HIGHEST_SCORE)
        Else
            Me.lblLetterGrade.Text = "Your grade is " & LetterGrade(scoreEntered)
        End If

    End Sub
    'Returns True if lowestLimit <= userNum <= upperLimit
    '
    'post: True has been returned if lowerLimit <= userNum <= upperlimit.
    'false has been reutrned otherwise
    '
    Function ValidEntry(ByVal userNum As Integer, ByVal upperLimit As Integer,
                        ByVal lowerLimit As Integer) As Boolean
        If userNum > upperLimit Or userNum < lowerLimit Then
            Return False
        Else
            Return True
        End If
    End Function
    'Returns a letter grade corresponding to score.
    '
    'post: a letter grade (A, B, C, D or F) has been returned.
    '
    Function LetterGrade(ByVal score As Double) As Char
        If score >= 90 Then
            Return "A"
        ElseIf score >= 80 Then
            Return "B"
        ElseIf score >= 70 Then
            Return "C"
        ElseIf score >= 60 Then
            Return "D"
        Else
            Return "F"
        End If
    End Function
End Class
