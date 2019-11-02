Public Class Form1
    'Ziwen 
    'nov 13 2017 
    ' review:fullname 142 pg
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim firstName As String
        Dim lastName As String
        Dim fullname As String

        firstName = InputBox("Enter your first name:", "First Name")
        lastName = InputBox("Enter your last name:", "Last Name")

        fullname = String.Concat(firstName, Space(1), lastName)
        Me.lblFullName.Text = fullname
    End Sub
End Class
