Public Class Form1
    Private Sub radHarvard_Click(sender As Object, e As EventArgs) Handles radHarvard.Click
        Me.lblLocation.Text = "Location:
    Cambridge
    MA"
    End Sub

    Private Sub radYale_Click(sender As Object, e As EventArgs) Handles radYale.Click
        Me.lblLocation.Text = "Location:
     New Haven
     Connecticut"
    End Sub

    Private Sub radVincentMassey_Click(sender As Object, e As EventArgs) Handles radVincentMassey.Click
        Me.lblLocation.Text = "Location:
    Brandon
    Manitoba"
    End Sub

    Private Sub radWaterloo_Click(sender As Object, e As EventArgs) Handles radWaterloo.Click
        Me.lblLocation.Text = "Location:
    Southern Ontario
    Canada"
    End Sub

    Private Sub radMeadows_Click(sender As Object, e As EventArgs) Handles radMeadows.Click
        Me.lblLocation.Text = "Location:
    Brandon
    Manitoba"
    End Sub
End Class
