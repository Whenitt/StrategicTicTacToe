Public Class WinScreen
    'Restarts game
    Private Sub yesButton_Click(sender As Object, e As EventArgs) Handles yesButton.Click
        Game.Show()
        Me.Close()
    End Sub

    'closes WinScreen and opens Main Menu
    Private Sub noButton_Click(sender As Object, e As EventArgs) Handles noButton.Click
        Game.Close()
        '/*Main menu
        Me.Close()
    End Sub
End Class