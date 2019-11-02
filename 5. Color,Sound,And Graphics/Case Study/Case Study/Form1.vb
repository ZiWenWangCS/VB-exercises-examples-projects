Public Class Form1
    Const NUM_SHAPES As Integer = 3 'number of shapes
    Dim score As Integer = 0        'player's score
    Dim boxNum As Integer           'box displaying the shape
    Dim shapeNum As Integer         '0 blue traingle, 1 red diamond, 2 pink circle

    'starts the game.

    'pos: the game ahs displayed various shapes for on eminute for the
    'player to click.

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.btnGo.Visible = False
        Me.tmrShowShape.Start()
        Me.tmrGameLength.Start()
    End Sub

    'Displays a shape in one of a set of picture boxes

    'pre: There are six picture box on the interface named
    'picshape0, picshape1, picshape2, picshape3, picshape4, picshape5
    'post: a shape has been displayed in one of the pictuer boxes.
    'The remaining picture boxes display the default shape.

    Private Sub tmrShowShape_Tick(sender As Object, e As EventArgs) Handles tmrShowShape.Tick
        Dim picBoxes() As PictureBox = {Me.picShape0, Me.picShape1, Me.picShape2, Me.picShape3,
            Me.picShape4, Me.picShape5}
        Randomize()

        'clear the previous shape by showing default shape in all boxes
        Call ClearBoxes(picBoxes)
        'Assign global variable box number for shape
        boxNum = Int(picBoxes.Length * Rnd())
        'Assign global variable shape number for box
        shapeNum = Int(NUM_SHAPES * Rnd())

        Call DisplayShape(picBoxes, boxNum, shapeNum)
    End Sub

    'places a default image in all the picture boxes of the picture box arra
    'post: the picture boxes have been set to display the defualt image

    Sub ClearBoxes(ByRef boxes() As PictureBox)
        For box As Integer = 0 To boxes.Length - 1
            boxes(box).Image = My.Resources.greensquare
        Next
    End Sub

    'a shape is displayed in one of the boxes of the picture box
    'array
    'pre the resources folder contains the blue traingle,
    'reddiamond and pinkciricle image files. 0<= box<= picturebox.length
    'shape is 0,1, or 2
    'post: a shape has been displayed in a picture box

    Sub DisplayShape(ByRef boxes() As PictureBox, ByVal box As Integer, ByVal shape As Integer)
        Select Case shape
            Case 0
                boxes(box).Image = My.Resources.bluetriangle
            Case 1
                boxes(box).Image = My.Resources.reddiamond
            Case 2
                boxes(box).Image = My.Resources.pinkcircle
        End Select
    End Sub

    'determine if clicked picture box is the one with the shape
    'pre: the pictuer boxes have appropirate tag blues. shapeNum is 0,1,or2
    'Post: player's score ahs been updated if shape was clicked

    Private Sub shapeClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picShape0.MouseDown, picShape1.MouseDown, picShape2.MouseDown, picShape3.MouseDown, picShape4.MouseDown, picShape5.MouseDown
        Dim picClicked As PictureBox = sender

        If picClicked.Tag = boxNum Then
            Select Case shapeNum
                Case 0 ' blue traingle
                    score += 5
                Case 1 'reddiamond
                    score -= 3
                Case 2 ' pink cirlce
                    score += 10

            End Select
        End If
    End Sub

    'ends the game and displays the player's score
    'post:timerss ahve been stopped and the player's score displayed

    Private Sub tmrGameLength_Tick(sender As Object, e As EventArgs) Handles tmrGameLength.Tick
        Me.tmrGameLength.Stop()
        Me.tmrShowShape.Stop()
        MessageBox.Show("Score:  " & score)
        Me.btnGo.Visible = True
        Me.btnGo.Text = "Restart"
        score = 0 ' reset the score
    End Sub
End Class
