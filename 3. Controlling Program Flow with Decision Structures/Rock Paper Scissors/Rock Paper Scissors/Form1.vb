Public Class Form1

    Const rock As Integer = 1
    Const paper As Integer = 2
    Const scissors As Integer = 3
    Dim computerthrow As Integer



    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Static playerWins As Integer = 0
        Static playerLose As Integer = 0
        Static draw As Integer = 0


        Randomize()
        computerthrow = Int(3 * Rnd() + 1) ' this way only have a limit between 1-3


        Select Case computerthrow
            Case rock
                If radPaper.Checked Then
                    Me.lblWinner.Text = "computer = rock you win"
                    playerWins += 1
                ElseIf radRock.Checked Then
                    Me.lblWinner.Text = "computer = rock its a draw"
                    draw += 1
                Else
                    Me.lblWinner.Text = "computer = rock you lose"
                    playerLose += 1
                End If
        End Select
        Select Case computerthrow
            Case paper
                If radPaper.Checked Then
                    Me.lblWinner.Text = "computer = paper its a draw"
                    draw += 1
                ElseIf radRock.Checked Then
                    Me.lblWinner.Text = "computer= paper you lose"
                    playerLose += 1
                Else
                    Me.lblWinner.Text = "computer = paper  you win"
                    playerWins = playerWins + 1
                End If
        End Select
        Select Case computerthrow
            Case scissors
                If radPaper.Checked Then
                    Me.lblWinner.Text = "computer = scissors you lose"
                    playerLose += 1
                ElseIf radRock.Checked Then
                    Me.lblWinner.Text = "computer = scissors you win"
                    playerWins += 1
                Else
                    Me.lblWinner.Text = "computer = scisoors its a draw"
                    draw += 1
                End If
        End Select
        Me.lblPlayerWin.Text = playerWins
        Me.lblPlayerLose.Text = playerLose
        Me.lblDraw.Text = draw

        'display wins/loss/draw


    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click

        Me.radPaper.Checked = False
        Me.radRock.Checked = False
        Me.radScissors.Checked = False

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Application.Exit()
    End Sub


End Class
