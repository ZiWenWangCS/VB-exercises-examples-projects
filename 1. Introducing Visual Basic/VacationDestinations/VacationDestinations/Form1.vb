Public Class Form1
    'Ziwen Wang
    'Sept 18
    Private Sub radSydney_Click(sender As Object, e As EventArgs) Handles radSydney.Click
        Me.picDestination.Image = My.Resources.Sydney
        Me.lblDestination.Text = "Australia:
1. Sydney Opera House
2.Sydney Harbour Bridge
3.The Rocks
4.Circular Quay
5.Darling Harbour"
        Me.lblDestination.ForeColor = Color.Indigo


    End Sub



    Private Sub radJapan_Click(sender As Object, e As EventArgs) Handles radJapan.Click
        Me.picDestination.Image = My.Resources.japan
        Me.lblDestination.Text = "Japan:
1. Fantastic insight into Japan's diverse history.
2. Satisfy the most discerning of palettes, as well as the strictest of budgets.
3.Visualize Japan's treasured heritage and its cutting-edge future.
4.Nature and Gastronomy in Hokkaido and Northern Tohoku.
5.Explore Japan's Iconic Destinations."
        Me.lblDestination.ForeColor = Color.Olive


    End Sub

    Private Sub radParis_Click(sender As Object, e As EventArgs) Handles radParis.Click
        Me.picDestination.Image = My.Resources.paris
        Me.lblDestination.Text = "France:
1.The Louvre Museum and Old Palace
2.Notre-Dame Cathedral, a Gothic Marvel
3.The Eiffel Tower
4.Musée d'Orsay
5.The Sorbonne and the Latin Quarter"
        Me.lblDestination.ForeColor = Color.LightPink

    End Sub

    Private Sub radRome_Click(sender As Object, e As EventArgs) Handles radRome.Click
        Me.picDestination.Image = My.Resources.Rome
        Me.lblDestination.Text = "Italy:
1.The Colosseum and the Arch of Constantine
2.Vatican City
3.The Pantheon
4.Roman Forum
5.Trevi Fountain"
        Me.lblDestination.ForeColor = Color.LimeGreen

    End Sub

    Private Sub radEngland_Click(sender As Object, e As EventArgs) Handles radEngland.Click
        Me.picDestination.Image = My.Resources.london
        Me.lblDestination.Text = "England
1.Stonehenge
2.Tower of London
3.The City of Bath
4.Windsor Castle
5.Historic Yorkshire"
        Me.lblDestination.ForeColor = Color.MediumSpringGreen

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub


End Class
