Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim people As Integer
        Dim cars As Integer
        Dim left As Integer

        people = Val(Me.txtPeople.Text)
        cars = people / 4
        left = people Mod 4
        Me.lblCars.Text = (cars & "    Cars needed")
        Me.lblLeft.Text = (left & "    People Left")
    End Sub
End Class
