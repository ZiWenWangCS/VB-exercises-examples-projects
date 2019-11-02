Public Class Form1
    Dim min As Double
    Dim hour As Double
    Dim second As Double
    Dim hourmin As Double


    Private Sub txtMin_TextChanged(sender As Object, e As EventArgs) Handles txtMin.TextChanged
        min = Val(Me.txtMin.Text)
        If Me.radHour.Checked = True Then ' if hour is select it will do the following formula
            hour = Int(min / 60) ' for example if min is 90 it will = to 1 and have 30 left
            hourmin = min Mod 60 ' if 90 is min then it = to 30 cause the r
            Me.lblAnswer.Text = ("The time in hour:minute formate is: " & hour & "hours  :  " & hourmin & " min")
        ElseIf Me.radSeconds.Checked = True Then
            second = min * 60
            Me.lblAnswer.Text = ("The time in hour:minute formate is:" & second)
        End If
    End Sub
End Class
