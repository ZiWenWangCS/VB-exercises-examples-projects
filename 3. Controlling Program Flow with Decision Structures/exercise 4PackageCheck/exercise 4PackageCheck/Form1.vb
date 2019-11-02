Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim weight As Double
        Dim length, height, width, cubic As Double

        weight = Val(Me.txtWeight.Text)
        length = Val(Me.txtLength.Text)
        width = Val(Me.txtWidth.Text)
        height = Val(Me.txtHeight.Text)
        cubic = length * height * width
        'If weight >= 30 AndAlso cubic >= 100000 Then works
        '    Me.lblCheck.Text = "Both to heavy and too large."
        'ElseIf cubic >= 100000 Then
        '    Me.lblCheck.Text = "Rejected: Too large"
        'ElseIf weight >= 30 Then
        '    Me.lblCheck.Text = "Rejected: Too heavy"
        'ElseIf weight < 30 AndAlso cubic < 100000 Then
        '    Me.lblCheck.Text = "good"

        'End If
        'Select Case (weight Or cubic) this statement is wrong dont know what is wrong but its worng
        '    Case (weight 30 To 100 AndAlso cubic 100000 To 999999)
        '        Me.lblCheck.Text = "Rejected : Both heavy and large"
        '    Case (cubic 100000 To 999999)
        '        Me.lblCheck.Text = "Rejected: Too large"
        '    Case weight >= 30
        '        Me.lblCheck.Text = "Rejected: Too heavy"

        '    Case (weight < 30 AndAlso cubic < 100000)
        '        Me.lblCheck.Text = "Good"

        'End Select
        Select Case (weight Or cubic) 'works
            Case weight Or cubic
                If weight >= 30 AndAlso cubic >= 100000 Then
                    Me.lblCheck.Text = "Both to heavy and too large."
                ElseIf cubic >= 100000 Then
                    Me.lblCheck.Text = "Rejected: Too large"
                ElseIf weight >= 30 Then
                    Me.lblCheck.Text = "Rejected: Too heavy"
                ElseIf weight < 30 AndAlso cubic < 100000 Then
                    Me.lblCheck.Text = "good"
                End If
        End Select
    End Sub
End Class
