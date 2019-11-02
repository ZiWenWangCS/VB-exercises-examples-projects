Public Class Form1
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Const basicCharge As Integer = 25
        Const addOption As Double = 3.5
        Dim totalbill As Double
        Static numoptions As Integer = 0

        'If Me.chkWaiting.Checked Or Me.chkForwarding.Checked Or Me.chkID.Checked Then
        '    numoptions = numoptions + 1
        'ElseIf Me.chkID.Checked And Me.chkForwarding.Checked Or Me.chkID.Checked And Me.chkWaiting.Checked Or Me.chkForwarding.Checked And Me.chkWaiting.Checked Then
        '    numoptions = numoptions + 2
        'ElseIf Me.chkForwarding.Checked And Me.chkID.Checked And Me.chkForwarding.Checked Then
        '    numoptions = numoptions + 3
        'End If

        If chkWaiting.Checked Then
            numoptions = numoptions + 1
        End If

        If chkID.Checked Then
            numoptions = numoptions + 1
        End If

        If chkForwarding.Checked Then
            numoptions = numoptions + 1
        End If

        totalbill = basicCharge + (addOption * numoptions)
        Me.lblTotal.Text = ("total: $ " & totalbill)
    End Sub
End Class
