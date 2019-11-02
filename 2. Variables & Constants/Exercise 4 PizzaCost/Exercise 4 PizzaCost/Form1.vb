Public Class Form1
    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        If Me.txtSize.Text >= 1 Then
            Me.lblCost.Visible = True
            Dim labor As Double = 0.75
            Dim rent As Double = 1
            Dim diameter As Double
            Dim materials As Double = 0.05
            Dim cost As Double

            diameter = Val(Me.txtSize.Text)
            cost = labor + rent + materials * diameter * diameter
            Me.lblCost.Text = ("The total cost of the pizza is$" & cost)
        Else
            Me.lblCost.Visible = False
        End If


    End Sub
End Class
