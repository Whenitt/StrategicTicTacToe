Public Class MainMenu
    ''' <summary>
    ''' Starts the game for two people to play
    ''' </summary>
    Private Sub twoPlayerButton_Click(sender As Object, e As EventArgs) Handles twoPlayerButton.Click
        'No AI involved
        Game.ShowDialog()
    End Sub

    ''' <summary>
    ''' Brings up difficulty selection and gets rid of everything else
    ''' </summary>
    Private Sub singlePlayerButton_Click(sender As Object, e As EventArgs) Handles singlePlayerButton.Click
        'back button to get out of single player
        backButton.Visible = True

        'show difficulty selector
        easyButton.Visible = True
        mediumButton.Visible = True
        hardButton.Visible = True

        'single player/two player buttons invisible
        singlePlayerButton.Visible = False
        twoPlayerButton.Visible = False
    End Sub

    ''' <summary>
    ''' Opposite functionality as singlePlayerButton
    ''' </summary>
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        'back button to get out of single player
        backButton.Visible = False

        'hide difficulty selector
        easyButton.Visible = False
        mediumButton.Visible = False
        hardButton.Visible = False

        'single player/two player buttons visible
        singlePlayerButton.Visible = True
        twoPlayerButton.Visible = True
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class