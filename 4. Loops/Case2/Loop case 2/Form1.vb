Public Class Form1
    Private Sub btnEnterName_Click(sender As Object, e As EventArgs) Handles btnEnterName.Click
        Dim name As String
        Dim length As Integer ' can dim as string
        Dim longest As String ' can dim as string but need val()
        Dim counter As Integer = 0
        Dim longestlength As Integer

        name = InputBox("Enter Names:(-1 to stop)"， “NAMES”)

        Do While name <> Nothing And Val(name) <> -1
            counter += 1
            length = name.Length
            If longestlength < length Then ' if the variable is string then use Val(longestlength) < Val(length)
                longestlength = name.Length
                longest = name
            End If
            name = InputBox("Enter names: (-1 to stop)", "NAMES")
        Loop

        Me.lblLongestName.Text = longest ' its green cause if statement might not be excuted cause user may not enter anything
        Me.lblNumofName.Text = counter
    End Sub
End Class
