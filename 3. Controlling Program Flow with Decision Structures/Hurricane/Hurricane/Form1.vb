Public Class Form1
    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        Dim MPH As Integer
        MPH = Val(Me.txtMPH.Text)

        Select Case MPH
            Case 74 To 95
                Me.lblCategory.Text = "Category1: 119-153 km/hr"
            Case 96 To 110
                Me.lblCategory.Text = "Category2: 154-177 km/hr"
            Case 111 To 130
                Me.lblCategory.Text = "Category3: 178-209 km/hr"
            Case 131 To 155
                Me.lblCategory.Text = "Category4: 210-249 km/hr"
            Case > 155
                Me.lblCategory.Text = "Category5: Greater than 249 km/hr"

        End Select
    End Sub
End Class
