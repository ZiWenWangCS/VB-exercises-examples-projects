Public Class Form1
    Private Sub btnGetInfo_Click(sender As Object, e As EventArgs) Handles btnGetInfo.Click
        Dim PetName As String

        PetName = Me.txtPetName.Text

        'show pet info
        Select Case PetName.ToUpper
            Case "CAT"
                Call CATInfo()
            Case "DOG"
                Call DOGInfo()
            Case "FISH"
                Call FISHInfo()
            Case Else
                MessageBox.Show("Sorry, no information availabel.")
        End Select
    End Sub

    Sub CATInfo()
        Me.picPetPhoto.Image = My.Resources.cat
        Me.lblPetInfo.Text = "This kitten is 4 months old and loves playing with children."
    End Sub

    Sub DOGInfo()
        Me.picPetPhoto.Image = My.Resources.dog
        Me.lblPetInfo.Text = "This puppy is just 3 months old and needs a good home."
    End Sub

    Sub FishInfo()
        Me.picPetPhoto.Image = My.Resources.fish
        Me.lblPetInfo.Text = "We have a variety of goldfish."
    End Sub
End Class
