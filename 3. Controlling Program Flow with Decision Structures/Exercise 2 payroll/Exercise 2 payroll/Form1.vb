Public Class Form1
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim hour As Integer
        Dim rate, wage As Double
        Dim overtime As Double = 1.5

        hour = Val(Me.txtHours.Text)
        rate = Val(Me.txtRate.Text)


        If hour > 40 And Me.radYes.Checked Then
            wage = rate * (hour * overtime)
            'Me.lblWages.Text = ("Gross wages =$" & wage)
        ElseIf hour <= 40 And Me.radYes.Checked Then
            wage = rate * hour
            'Me.lblWages.Text = ("gross wages =$" & wage)
        ElseIf hour > 40 And Me.radNo.Checked Then
            wage = rate * (hour * overtime * 0.82)
            'Me.lblWages.Text = ("Gross wage =$" & wage)
        ElseIf hour <= 40 And Me.radNo.Checked Then
            wage = rate * hour * 0.82
            'Me.lblWages.Text = ("Gross wages =$" & wage)
        End If
        Me.lblWages.Text = ("Gross wages =$" & wage)
    End Sub
End Class
