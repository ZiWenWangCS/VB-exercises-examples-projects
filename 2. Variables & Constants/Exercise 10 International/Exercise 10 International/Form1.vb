Public Class Form1
    Private Sub radEnglish_MouseHover(sender As Object, e As EventArgs) Handles radEnglish.MouseHover
        If Me.radSpanish.Checked = True Then ' if rad spanish is selected then if you move to english it will display the following
            Me.ttpEnglish.SetToolTip(Me.radEnglish, "Muestra el mensaje en inglés")
        ElseIf Me.radFrench.Checked = True Then
            Me.ttpEnglish.SetToolTip(Me.radEnglish, "Affiche l'invite en anglais") 'if french is selected then if you move to english it will display the following
        Else
            Me.ttpEnglish.SetToolTip(Me.radEnglish, "Displays the prompt in English")
        End If
    End Sub

    Private Sub radFrench_MouseHover(sender As Object, e As EventArgs) Handles radFrench.MouseHover
        If Me.radSpanish.Checked = True Then
            Me.ttpFrench.SetToolTip(Me.radFrench, "Muestra el mensaje en francés")
        ElseIf Me.radFrench.Checked = True Then
            Me.ttpFrench.SetToolTip(Me.radFrench, "Affiche l'invite en français")
        Else
            Me.ttpFrench.SetToolTip(Me.radFrench, "Displays the prompt in french")
        End If
    End Sub


    Private Sub radSpanish_MouseHover(sender As Object, e As EventArgs) Handles radSpanish.MouseHover
        If Me.radSpanish.Checked = True Then
            Me.ttpSpanish.SetToolTip(radSpanish, "Muestra el mensaje en español")
        ElseIf Me.radFrench.Checked = True Then
            Me.ttpSpanish.SetToolTip(radSpanish, "Affiche l'invite en espagnol")
        Else
            Me.ttpSpanish.SetToolTip(radSpanish, "Displays the prompt in spanish")
        End If
    End Sub

    'Private Sub radEnglish_Click(sender As Object, e As EventArgs) Handles radEnglish.Click
    'Me.radSpanish.Checked = False
    'Me.radFrench.Checked = False
    ' End Sub

    'Private Sub radFrench_Click(sender As Object, e As EventArgs) Handles radFrench.Click
    'Me.radSpanish.Checked = False
    'Me.radEnglish.Checked = False
    ' End Sub

    'Private Sub radSpanish_Click(sender As Object, e As EventArgs) Handles radSpanish.Click
    'Me.radFrench.Checked = False
    'Me.radEnglish.Checked = False
    ' End Sub

End Class
