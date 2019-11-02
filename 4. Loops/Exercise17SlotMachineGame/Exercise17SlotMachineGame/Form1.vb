Public Class Form1
    Private Sub btnPull_Click(sender As Object, e As EventArgs) Handles btnPull.Click
        Dim ran1, ran2, ran3 As Integer
        Static tokens As Integer = 100 ' static because can save the number



        Randomize()
        ran1 = Int(3 * Rnd() + 1) '1-3
        ran2 = Int(3 * Rnd() + 1) '1-3
        ran3 = Int(3 * Rnd() + 1) '1-3

        Me.lblRan1.Text = ran1 ' display before message box appear
        Me.lblRan2.Text = ran2
        Me.lblRan3.Text = ran3

        If ran1 = 1 And ran2 = 1 And ran3 = 1 Then
            MessageBox.Show("You got 4 tokens!", "TOKEN")
            tokens += 4
        ElseIf ran1 = 2 And ran2 = 2 And ran3 = 2 Then
            MessageBox.Show("You got 8 tokens!", "TOKEN")
            tokens += 8
        ElseIf ran1 = 3 And ran2 = 3 And ran3 = 3 Then
            MessageBox.Show("You got 12 tokens!", "TOEKEN")
            tokens += 12
        End If


        Me.lblTokens.Text = ("Tokens you have:" & tokens)
        tokens -= 1
    End Sub
End Class
