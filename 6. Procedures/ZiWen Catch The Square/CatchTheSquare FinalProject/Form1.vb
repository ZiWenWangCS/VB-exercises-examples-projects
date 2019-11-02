Public Class Form1
    'ziwenwang
    'jan 22 2018

    Dim x, y As Integer ' the location of the square
    Dim piccolour As Integer ' the color of the square
    Dim length, width As Integer ' the size of the square

    Private Sub lblScore_Click(sender As Object, e As EventArgs) Handles lblScore.Click
        Me.lblScore.Parent = picSquare 'to not cover the pic
    End Sub

    Private Sub picSquare_MouseEnter(sender As Object, e As EventArgs) Handles picSquare.MouseEnter
        Static score As Integer ' users score

        Call RndInt(x, y, piccolour, length, width) 'assign integers for them

        Call PictureColor(piccolour) 'backcolor for pic box

        Call LocationAndSize(x, y, length, width) 'location and the size of the square

        'MessageBox.Show("xcord:" & x & "Ycord:" & y & "length:" & length & "width" & width)

        score += 1 ' socres adds up everytime when the user touches the pic
        Me.lblScore.Text = "Score: " & score 'display the score


        Me.tmrLevels.Interval = time(score)

        Me.tmrLevels.Stop() 'reset the tmr
        Me.tmrLevels.Start()
    End Sub

    Function time(ByVal a As Integer) As Integer
        Select Case a
            Case 1 To 9
                Return 2000
            Case 10 To 19
                Return 1750
            Case 20 To 29
                Return 1500
            Case 30 To 39
                Return 1250
            Case 40 To 49
                Return 1000
            Case 50 To 59
                Return 750
            Case 60 To 69
                Return 500
            Case Else
                Return 400
        End Select
    End Function


    Sub RndInt(ByRef xCord As Integer, ByRef yCord As Integer, ByRef ColorInt As Integer, ByRef L As Integer, ByRef W As Integer)
        Randomize()

        xCord = Int(280 * Rnd() + 20) 'locations
        yCord = Int(240 * Rnd() + 8)

        ColorInt = Int(5 * Rnd() + 1) 'colors

        L = (20 * Rnd() + 10) 'the size
        W = (20 * Rnd() + 10)

    End Sub

    Sub PictureColor(ByVal colours As Integer)
        Select Case colours 'assigned colors
            Case 1
                Me.picSquare.BackColor = Color.Black
                Me.BackColor = Color.Green
            Case 2
                Me.picSquare.BackColor = Color.Yellow
                Me.BackColor = Color.Beige
            Case 3
                Me.picSquare.BackColor = Color.Red
                Me.BackColor = Color.AliceBlue
            Case 4
                Me.picSquare.BackColor = Color.Blue
                Me.BackColor = Color.WhiteSmoke
            Case 5
                Me.picSquare.BackColor = Color.Green
                Me.BackColor = Color.Tomato
        End Select
    End Sub

    Sub LocationAndSize(ByVal xInt As Integer, ByVal yInt As Integer, ByVal lengthInt As Integer, ByVal widthInt As Integer)
        Me.picSquare.Size = New System.Drawing.Size(widthInt, lengthInt) 'size
        Me.picSquare.Location = New Point(xInt, yInt) 'location
    End Sub

    Private Sub tmrLevels_Tick(sender As Object, e As EventArgs) Handles tmrLevels.Tick

        Call RndInt(x, y, piccolour, length, width) 'assign integers for them

        Call PictureColor(piccolour) 'backcolor for pic box

        Call LocationAndSize(x, y, length, width) 'location and the size of the square
    End Sub
End Class
