Public Class Form1
    Dim price As Integer
    Private Sub chkShampoo_Click(sender As Object, e As EventArgs) Handles chkShampoo.Click
        Dim shampoo As Integer = 15
        If Me.chkShampoo.Checked = True Then
            price += shampoo
        Else
            price -= shampoo
        End If
        Me.lblPrice.Text = ("Price: $ " & price)
    End Sub

    Private Sub chkTrim_Click(sender As Object, e As EventArgs) Handles chkTrim.Click
        Dim trim As Integer = 15
        If Me.chkTrim.Checked = True Then
            price += trim
        Else
            price -= trim
        End If
        Me.lblPrice.Text = ("Price: $ " & price)
    End Sub

    Private Sub chkFleaDip_Click(sender As Object, e As EventArgs) Handles chkFleaDip.Click
        Dim fleaDip As Integer = 5
        If Me.chkFleaDip.Checked = True Then
            price += fleaDip
        Else
            price -= fleaDip
        End If
        Me.lblPrice.Text = ("Price: $ " & price)
    End Sub

    Private Sub chkFullShave_Click(sender As Object, e As EventArgs) Handles chkFullShave.Click
        Dim fullShave As Integer = 20
        If Me.chkFullShave.Checked = True Then
            price += fullShave
        Else
            price -= fullShave
        End If
        Me.lblPrice.Text = ("Price: $ " & price)
    End Sub
End Class
