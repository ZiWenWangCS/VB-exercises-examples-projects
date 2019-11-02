Public Class Form1
    'Ziwen Wang
    'Nov 29 2017
    Private Sub btnEnterCities_Click(sender As Object, e As EventArgs) Handles btnEnterCities.Click
        Dim counter As Integer
        Dim citylength As Integer
        Dim longestlength As Integer
        Dim longestcity As String
        Dim city As String


        city = InputBox("Enter the city please:(Enter stop to exit)", "CITY")
        city = city.ToUpper ' to upper case letter and if enter lower case "stop" it will eixt

        Do While city <> Nothing And city <> "STOP"

            counter += 1 ' counter plus one and putting this before inputbox can prevent +1 from entering "stop"
            citylength = city.Length



            If longestlength < citylength Then
                longestlength = citylength ' if the longest lenght is smaller then it replaces
                longestcity = city
            End If

            city = InputBox("Enter the city please:(Enter Stop to exit)", "CITY")

            city = city.ToUpper ' to upper case letter and if enter lower case "stop" it will eixt
        Loop

        Me.lblLongestCities.Text = "City with the most characters: " & longestcity
        Me.lblNumofCities.Text = "Number of cities entered: " & counter
    End Sub
End Class
