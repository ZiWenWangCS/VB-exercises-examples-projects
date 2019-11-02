Public Class Form1
    Private Sub btnEnterTemperature_Click(sender As Object, e As EventArgs) Handles btnEnterTemperature.Click
        Dim counter As Integer = 1
        Dim sumoftemp As Integer = 0
        Dim newtemp As integer
        Dim average As Integer
        Dim prompt As String = "Please enter the past five days temperature:(-1 to stop)"
        Dim title As String = "AVERAGE TEMPERATURE"

        newtemp = Val(InputBox(prompt, title))
        sumoftemp = newtemp ' the new temp is stored in the sumof temp


        Do While newtemp <> Nothing And Val(newtemp) <> -1 And counter < 5

            newtemp = Val(InputBox(prompt, title)) ' gets new temp

            sumoftemp += newtemp ' adds the new temp from the last temp = sumoftemp
            If newtemp <> Nothing Then
                counter += 1 ' counter + 1. the if state helps cuase if the user enters nothing then counter
                ' would not add 1 or the statement below is the same thing
            End If
            'If newtemp = Nothing Then
            '    counter -= 1 ' if user stopped the counter before 5 then it needs - 1
            'End If

        Loop

        average = sumoftemp / counter


        Me.lblAverageTemperature.Text = ("Average temperature: " & average)
    End Sub
End Class
