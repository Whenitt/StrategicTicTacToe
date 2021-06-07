'Author: Kalen Holbrook
'Ver. 3 - adding UI elements

Option Strict On : Option Explicit On

Public Class Game
    'Program to create a strategic tic-tac-toe
    'create boards
    'Background Board
    Private backgroundTiles(2, 2, 2, 2) As Short '0=empty, 1=X, 2=O, 3=tie
    Private bigBoard(2, 2) As Short '0=empty, 1=X, 2=O, 3=tie

    'Label Arrays
    Private tileLabels(2, 2, 2, 2) As Label
    Private gameLabels(2, 2) As Label
    Private highlightLabels(2, 2) As Label

    'Track clicked status
    Private notClicked(2, 2, 2, 2) As Boolean

    'Colors
    Dim colorDefault As Color = Color.Transparent
    Dim colorHighlight As Color = Color.SkyBlue

    'Track player
    Private playerXO As String
    Private playerNum As Short '0=empty, 1=X, 2=O

    'Track current/next board
    Private clickKey As String = ""

    'Game Setup
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Link tile Labels from form to tileLabels
        tileLabels(0, 0, 0, 0) = tile0000
        tileLabels(0, 0, 0, 1) = tile0001
        tileLabels(0, 0, 0, 2) = tile0002
        tileLabels(0, 0, 1, 0) = tile0010
        tileLabels(0, 0, 1, 1) = tile0011
        tileLabels(0, 0, 1, 2) = tile0012
        tileLabels(0, 0, 2, 0) = tile0020
        tileLabels(0, 0, 2, 1) = tile0021
        tileLabels(0, 0, 2, 2) = tile0022

        tileLabels(0, 1, 0, 0) = tile0100
        tileLabels(0, 1, 0, 1) = tile0101
        tileLabels(0, 1, 0, 2) = tile0102
        tileLabels(0, 1, 1, 0) = tile0110
        tileLabels(0, 1, 1, 1) = tile0111
        tileLabels(0, 1, 1, 2) = tile0112
        tileLabels(0, 1, 2, 0) = tile0120
        tileLabels(0, 1, 2, 1) = tile0121
        tileLabels(0, 1, 2, 2) = tile0122

        tileLabels(0, 2, 0, 0) = tile0200
        tileLabels(0, 2, 0, 1) = tile0201
        tileLabels(0, 2, 0, 2) = tile0202
        tileLabels(0, 2, 1, 0) = tile0210
        tileLabels(0, 2, 1, 1) = tile0211
        tileLabels(0, 2, 1, 2) = tile0212
        tileLabels(0, 2, 2, 0) = tile0220
        tileLabels(0, 2, 2, 1) = tile0221
        tileLabels(0, 2, 2, 2) = tile0222

        tileLabels(1, 0, 0, 0) = tile1000
        tileLabels(1, 0, 0, 1) = tile1001
        tileLabels(1, 0, 0, 2) = tile1002
        tileLabels(1, 0, 1, 0) = tile1010
        tileLabels(1, 0, 1, 1) = tile1011
        tileLabels(1, 0, 1, 2) = tile1012
        tileLabels(1, 0, 2, 0) = tile1020
        tileLabels(1, 0, 2, 1) = tile1021
        tileLabels(1, 0, 2, 2) = tile1022

        tileLabels(1, 1, 0, 0) = tile1100
        tileLabels(1, 1, 0, 1) = tile1101
        tileLabels(1, 1, 0, 2) = tile1102
        tileLabels(1, 1, 1, 0) = tile1110
        tileLabels(1, 1, 1, 1) = tile1111
        tileLabels(1, 1, 1, 2) = tile1112
        tileLabels(1, 1, 2, 0) = tile1120
        tileLabels(1, 1, 2, 1) = tile1121
        tileLabels(1, 1, 2, 2) = tile1122

        tileLabels(1, 2, 0, 0) = tile1200
        tileLabels(1, 2, 0, 1) = tile1201
        tileLabels(1, 2, 0, 2) = tile1202
        tileLabels(1, 2, 1, 0) = tile1210
        tileLabels(1, 2, 1, 1) = tile1211
        tileLabels(1, 2, 1, 2) = tile1212
        tileLabels(1, 2, 2, 0) = tile1220
        tileLabels(1, 2, 2, 1) = tile1221
        tileLabels(1, 2, 2, 2) = tile1222

        tileLabels(2, 0, 0, 0) = tile2000
        tileLabels(2, 0, 0, 1) = tile2001
        tileLabels(2, 0, 0, 2) = tile2002
        tileLabels(2, 0, 1, 0) = tile2010
        tileLabels(2, 0, 1, 1) = tile2011
        tileLabels(2, 0, 1, 2) = tile2012
        tileLabels(2, 0, 2, 0) = tile2020
        tileLabels(2, 0, 2, 1) = tile2021
        tileLabels(2, 0, 2, 2) = tile2022

        tileLabels(2, 1, 0, 0) = tile2100
        tileLabels(2, 1, 0, 1) = tile2101
        tileLabels(2, 1, 0, 2) = tile2102
        tileLabels(2, 1, 1, 0) = tile2110
        tileLabels(2, 1, 1, 1) = tile2111
        tileLabels(2, 1, 1, 2) = tile2112
        tileLabels(2, 1, 2, 0) = tile2120
        tileLabels(2, 1, 2, 1) = tile2121
        tileLabels(2, 1, 2, 2) = tile2122

        tileLabels(2, 2, 0, 0) = tile2200
        tileLabels(2, 2, 0, 1) = tile2201
        tileLabels(2, 2, 0, 2) = tile2202
        tileLabels(2, 2, 1, 0) = tile2210
        tileLabels(2, 2, 1, 1) = tile2211
        tileLabels(2, 2, 1, 2) = tile2212
        tileLabels(2, 2, 2, 0) = tile2220
        tileLabels(2, 2, 2, 1) = tile2221
        tileLabels(2, 2, 2, 2) = tile2222

        'Link game labels to gameLabels
        gameLabels(0, 0) = gameLabel00
        gameLabels(0, 1) = gameLabel01
        gameLabels(0, 2) = gameLabel02
        gameLabels(1, 0) = gameLabel10
        gameLabels(1, 1) = gameLabel11
        gameLabels(1, 2) = gameLabel12
        gameLabels(2, 0) = gameLabel20
        gameLabels(2, 1) = gameLabel21
        gameLabels(2, 2) = gameLabel22

        'Link highligts to highlightLabels
        highlightLabels(0, 0) = gameHighlight00
        highlightLabels(0, 1) = gameHighlight01
        highlightLabels(0, 2) = gameHighlight02
        highlightLabels(1, 0) = gameHighlight10
        highlightLabels(1, 1) = gameHighlight11
        highlightLabels(1, 2) = gameHighlight12
        highlightLabels(2, 0) = gameHighlight20
        highlightLabels(2, 1) = gameHighlight21
        highlightLabels(2, 2) = gameHighlight22

        ClearAll()

    End Sub

    'test area------------------------------------------------------------------------

    'Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
    '    'MyBase.OnPaintBackground(e)
    'End Sub

    'Private Sub gameLabel00_Click(sender As Object, e As EventArgs) Handles gameLabel00.Click
    '    'doesn't work
    '    gameLabel00.BackColor = Color.LightBlue
    '    Me.TransparencyKey = Color.LightBlue
    'End Sub

    'test area------------------------------------------------------------------------

    ''' <summary>
    ''' set all boards to empty, allow players to click on any tile, and set the player to "X"
    ''' 0=empty,1=x,2=0
    ''' </summary>
    Public Sub ClearAll()
        'Allow players to click wherever
        clickKey = ""

        'Set player to X
        playerNum = 1
        playerXO = "X"
        playerLabel.Text = "Next: X"

        'Set notClicked values to false for all tiles
        'And Set all tiles text to empty strings
        For i = 0 To 2
            For j = 0 To 2
                bigBoard(i, j) = 0
                highlightLabels(i, j).Visible = True
                gameLabels(i, j).Visible = False
                For k = 0 To 2
                    For l = 0 To 2
                        notClicked(i, j, k, l) = True
                        tileLabels(i, j, k, l).Text = ""
                        backgroundTiles(i, j, k, l) = 0
                        tileLabels(i, j, k, l).BackColor = colorHighlight
                    Next
                Next
            Next
        Next

    End Sub '---------------------------------------------------------


    ''' <summary>
    ''' if game or board is won, tied, or neither - Returns 1, 2, or 0 respectively
    ''' </summary>
    ''' <param name="isGame">If True: checking a game. If False: checking the bigBoard</param>
    ''' <param name="vCoordinate">Relevant for games only: Vertical Coordinate of the game</param>
    ''' <param name="hCoordinate">Relevant for games only: Horizontal Coordinate of the game</param>
    ''' <returns></returns>
    Private Function CheckWin(ByVal isGame As Boolean, Optional ByVal vCoordinate As Short = 0, Optional ByVal hCoordinate As Short = 0) As Short
        Dim notFinished As Boolean = False

        If isGame Then
            'check for vertical and horizontal matches
            For i = 0 To 2
                If backgroundTiles(vCoordinate, hCoordinate, i, 0) = backgroundTiles(vCoordinate, hCoordinate, i, 1) And
                    backgroundTiles(vCoordinate, hCoordinate, i, 0) = backgroundTiles(vCoordinate, hCoordinate, i, 2) Then
                    'horizonals match
                    If Not backgroundTiles(vCoordinate, hCoordinate, i, 0) = 0 Then
                        Return 1
                    End If
                ElseIf backgroundTiles(vCoordinate, hCoordinate, 0, i) = backgroundTiles(vCoordinate, hCoordinate, 1, i) And
                    backgroundTiles(vCoordinate, hCoordinate, 0, i) = backgroundTiles(vCoordinate, hCoordinate, 2, i) Then
                    'verticals match
                    If Not backgroundTiles(vCoordinate, hCoordinate, 0, i) = 0 Then
                        Return 1
                    End If
                End If
            Next

            'check for diagonal matches
            If (backgroundTiles(vCoordinate, hCoordinate, 0, 0) = backgroundTiles(vCoordinate, hCoordinate, 1, 1) And
                backgroundTiles(vCoordinate, hCoordinate, 0, 0) = backgroundTiles(vCoordinate, hCoordinate, 2, 2)) Or
           (backgroundTiles(vCoordinate, hCoordinate, 0, 2) = backgroundTiles(vCoordinate, hCoordinate, 1, 1) And
           backgroundTiles(vCoordinate, hCoordinate, 0, 2) = backgroundTiles(vCoordinate, hCoordinate, 2, 0)) Then
                'one of the two diagonals match
                If Not backgroundTiles(vCoordinate, hCoordinate, 1, 1) = 0 Then
                    Return 1
                End If
            End If

            'CONFIRMED: Nobody won the game--------------------------------

            'check for ties**********************************************

            For i = 0 To 2
                For j = 0 To 2
                    If backgroundTiles(vCoordinate, hCoordinate, i, j) = 0 Then
                        notFinished = True
                        Exit For
                    End If
                Next
                If notFinished Then
                    Exit For
                End If
            Next

            If notFinished Then
                Return 0 'not a win, not a tie; therefore nothing happens
            Else
                Return 2 'tie has been reached; therefore game should be marked as such
            End If
        Else
            'check for vertical and horizontal matches
            For i = 0 To 2
                If bigBoard(i, 0) = bigBoard(i, 1) And
                    bigBoard(i, 0) = bigBoard(i, 2) Then
                    'horizonals match
                    If Not bigBoard(i, 0) = 0 Then
                        Return 1
                    End If
                ElseIf bigBoard(0, i) = bigBoard(1, i) And
                    bigBoard(0, i) = bigBoard(2, i) Then
                    'verticals match
                    If Not bigBoard(0, i) = 0 Then
                        Return 1
                    End If
                End If
            Next

            'check for diagonal matches
            If (bigBoard(0, 0) = bigBoard(1, 1) And
                bigBoard(0, 0) = bigBoard(2, 2)) Or
           (bigBoard(0, 2) = bigBoard(1, 1) And
           bigBoard(0, 2) = bigBoard(2, 0)) Then
                'one of the two diagonals match
                If Not bigBoard(1, 1) = 0 Then
                    Return 1
                End If
            End If

            'CONFIRMED: Nobody won the game--------------------------------

            'check for ties**********************************************

            For i = 0 To 2
                For j = 0 To 2
                    If bigBoard(i, j) = 0 Then
                        notFinished = True
                        Exit For
                    End If
                Next
                If notFinished Then
                    Exit For
                End If
            Next

            If notFinished Then
                Return 0 'not a win, not a tie; therefore nothing happens
            Else
                Return 2 'tie has been reached; therefore game should be marked as such
            End If
        End If
    End Function '---------------------------------------------------

    ''' <summary>
    ''' changes information to identify which player's turn it is
    ''' </summary>
    Private Sub ChangePlayer()
        If playerNum = 1 Then
            playerNum = 2
            playerXO = "O"
        Else
            playerNum = 1
            playerXO = "X"
        End If

        'change player label to let them know who's next
        playerLabel.Text = "Next: " + playerXO
    End Sub


    ''' <summary>
    ''' changes clickKey to give access to certain tiles
    ''' clickKey is coordinates of the game on the bigBoard
    ''' </summary>
    ''' <param name="gameNumV">Vertical coordinate for the game being redirected to</param>
    ''' <param name="gameNumH">Horizontal coordinate for the game being redirected to</param>
    Private Sub ChangeKey(gameNumV As Short, gameNumH As Short)

        If bigBoard(gameNumV, gameNumH) = 0 Then
            'Game being transferred to is incomplete
            clickKey = gameNumV.ToString() + "-" + gameNumH.ToString()

            'Highlight next game to be played on-------------------------------

            'Remove all highlights
            ClearHighlights()

            'Display highlights
            DisplayHighlight(gameNumV, gameNumH)
        Else
            'Game being transferred to has been won or is at a tie
            clickKey = ""

            'Highlight all non-completed games
            For i = 0 To 2
                For j = 0 To 2
                    If bigBoard(i, j) = 0 Then
                        DisplayHighlight(i, j)
                    End If
                Next
            Next

        End If
    End Sub

    ''' <summary>
    ''' Clears  highlights on all game
    ''' </summary>
    Private Sub ClearHighlights()
        'Remove all highlights
        For i = 0 To 2
            For j = 0 To 2
                'Games
                highlightLabels(i, j).Visible = False
                For k = 0 To 2
                    For l = 0 To 2
                        'Tiles
                        tileLabels(i, j, k, l).BackColor = colorDefault
                    Next
                Next
            Next
        Next
    End Sub

    ''' <summary>
    ''' Displays highlights for specified game
    ''' </summary>
    ''' <param name="gameNumV">Vertical coordinate of game being highlighted</param>
    ''' <param name="gameNumH">Horizontal coordinate of game being highlighted</param>
    Private Sub DisplayHighlight(ByVal gameNumV As Integer, ByVal gameNumH As Integer)
        'Display highlights
        'Game
        highlightLabels(gameNumV, gameNumH).Visible = True
        For i = 0 To 2
            For j = 0 To 2
                'Tiles
                tileLabels(gameNumV, gameNumH, i, j).BackColor = colorHighlight
            Next
        Next
    End Sub

    Private Sub winButton_Click(sender As Object, e As EventArgs) Handles winButton.Click
        For i = 0 To 2
            bigBoard(0, i) = playerNum
        Next
        TileClick(0, 0, 0, 0)
    End Sub
    '============================================================================================================================
    'Click events for each spot
    'Naming conventions:
    '   Big Board: the entirety of the game, containing 9 games and 81 tiles
    '   Game: one of the 9 games of tic-tac-toe on the Big Board, each containing 9 tiles
    '   Tile: the objects players click on to enter their move

    'Coordinates: consisting of pair(s) of numbers (1 or 2); first pair designating the game
    '                                                        second designating the tile In the game
    '   first number in the pair designating distance from top of the game/big board
    '   Second number in the pair designating distance from left of the game/big board
    'Example:
    '   tile0112
    '       within game01 (top center game)
    '       tile at 12 (middle right)

    'Click event functionality:
    'Check if clicked before; throw error (maybe)
    'Change text in clicked place to X or O depending on player
    'Change coordinating place in array
    'Check for win on small
    '   if win, check for big win
    '       if big win -> gg
    '       otherwise redirect to proper small board

    ''' <summary>
    ''' Updates boards, checks win, displays win, changes key, and updates notClicked
    ''' </summary>
    ''' <param name="vCoordinateGame">Verticle Coordinate of the game currently being played on</param>
    ''' <param name="hCoordinateGame">Horizontal Coordinate of the game currently being played on</param>
    ''' <param name="vCoordinateTile">Verticle Coordinate of the tile selected</param>
    ''' <param name="hCoordinateTile">Horizontal Coordinate of the tile selected</param>
    Private Sub TileClick(ByVal vCoordinateGame As Short, ByVal hCoordinateGame As Short, ByVal vCoordinateTile As Short, ByVal hCoordinateTile As Short)
        'check if the tile has been clicked on before and if clickKey allows this tile to be cliced
        If notClicked(vCoordinateGame, hCoordinateGame, vCoordinateTile, hCoordinateTile) And
                (clickKey = (vCoordinateGame.ToString & "-" & hCoordinateGame.ToString) Or
                clickKey = "") Then

            Dim gameWin As Short

            'change visual and background boards
            tileLabels(vCoordinateGame, hCoordinateGame, vCoordinateTile, hCoordinateTile).Text = playerXO
            backgroundTiles(vCoordinateGame, hCoordinateGame, vCoordinateTile, hCoordinateTile) = playerNum

            'check if the player won/tied game
            gameWin = CheckWin(True, vCoordinateGame, hCoordinateGame)

            'if the player won, update bigboard
            If gameWin = 1 Then
                With gameLabels(vCoordinateGame, hCoordinateGame)
                    .Text = playerXO
                    .Visible = True
                End With
                bigBoard(vCoordinateGame, hCoordinateGame) = playerNum
                'Disable all not clicked tiles in finished game
                For i = 0 To 2
                    For j = 0 To 2
                        notClicked(vCoordinateGame, hCoordinateGame, i, j) = False
                    Next
                Next

                'if the player tied the game, update bigboard
            ElseIf gameWin = 2 Then
                'tie on the game
                With gameLabels(vCoordinateGame, hCoordinateGame)
                    .Text = "T"
                    .Visible = True
                    bigBoard(vCoordinateGame, hCoordinateGame) = 3
                End With
            End If

            'check if the player won/tied bigBoard
            Dim boardWin As Short = CheckWin(False)
            With WinScreen
                If boardWin = 1 Then
                    'display WinScreen
                    .Label1.Text = "Player " + playerXO + " Wins!!!" + vbNewLine + " Congradulations!!!"
                    .Show()
                    '/*Win state incomplete*/**********************************
                ElseIf boardWin = 2 Then
                    'tie on big board
                    .Label1.Text = "It's a Tie!" + vbNewLine + "WEEEEEEEEEEEEEEEEEEEEEE"
                    .Show()
                Else
                    'no win and no tie on game board; the game continues
                End If
            End With
            'no win and no tie on game; the game continues

            'change the player
            ChangePlayer()

            'change the clickKey
            ChangeKey(vCoordinateTile, hCoordinateTile)

            'update notClicked
            notClicked(vCoordinateGame, hCoordinateGame, vCoordinateTile, hCoordinateTile) = False
        End If
    End Sub
    '==============================CLICK EVENTS====================================================
    'Big Board: top left---------------------------------------------------------------------------
    Private Sub Tile0000_Click(sender As Object, e As EventArgs) Handles tile0000.Click
        TileClick(0, 0, 0, 0)
    End Sub

    Private Sub Tile0001_Click(sender As Object, e As EventArgs) Handles tile0001.Click
        TileClick(0, 0, 0, 1)
    End Sub

    Private Sub Tile0002_Click(sender As Object, e As EventArgs) Handles tile0002.Click
        TileClick(0, 0, 0, 2)
    End Sub

    Private Sub Tile0010_Click(sender As Object, e As EventArgs) Handles tile0010.Click
        TileClick(0, 0, 1, 0)
    End Sub

    Private Sub Tile0011_Click(sender As Object, e As EventArgs) Handles tile0011.Click
        TileClick(0, 0, 1, 1)
    End Sub

    Private Sub Tile0012_Click(sender As Object, e As EventArgs) Handles tile0012.Click
        TileClick(0, 0, 1, 2)
    End Sub

    Private Sub Tile0020_Click(sender As Object, e As EventArgs) Handles tile0020.Click
        TileClick(0, 0, 2, 0)
    End Sub

    Private Sub Tile0021_Click(sender As Object, e As EventArgs) Handles tile0021.Click
        TileClick(0, 0, 2, 1)
    End Sub

    Private Sub Tile0022_Click(sender As Object, e As EventArgs) Handles tile0022.Click
        TileClick(0, 0, 2, 2)
    End Sub

    'big board: top center-------------------------------------------------------------------------
    Private Sub Tile0100_Click(sender As Object, e As EventArgs) Handles tile0100.Click
        TileClick(0, 1, 0, 0)
    End Sub

    Private Sub Tile0101_Click(sender As Object, e As EventArgs) Handles tile0101.Click
        TileClick(0, 1, 0, 1)
    End Sub

    Private Sub Tile0102_Click(sender As Object, e As EventArgs) Handles tile0102.Click
        TileClick(0, 1, 0, 2)
    End Sub

    Private Sub Tile0110_Click(sender As Object, e As EventArgs) Handles tile0110.Click
        TileClick(0, 1, 1, 0)
    End Sub

    Private Sub Tile0111_Click(sender As Object, e As EventArgs) Handles tile0111.Click
        TileClick(0, 1, 1, 1)
    End Sub

    Private Sub Tile0112_Click(sender As Object, e As EventArgs) Handles tile0112.Click
        TileClick(0, 1, 1, 2)
    End Sub

    Private Sub Tile0120_Click(sender As Object, e As EventArgs) Handles tile0120.Click
        TileClick(0, 1, 2, 0)
    End Sub

    Private Sub Tile0121_Click(sender As Object, e As EventArgs) Handles tile0121.Click
        TileClick(0, 1, 2, 1)
    End Sub

    Private Sub Tile0122_Click(sender As Object, e As EventArgs) Handles tile0122.Click
        TileClick(0, 1, 2, 2)
    End Sub

    'big board: top right--------------------------------------------------------------------------
    Private Sub Tile0200_Click(sender As Object, e As EventArgs) Handles tile0200.Click
        TileClick(0, 2, 0, 0)
    End Sub

    Private Sub Tile0201_Click(sender As Object, e As EventArgs) Handles tile0201.Click
        TileClick(0, 2, 0, 1)
    End Sub

    Private Sub Tile0202_Click(sender As Object, e As EventArgs) Handles tile0202.Click
        TileClick(0, 2, 0, 2)
    End Sub

    Private Sub Tile0210_Click(sender As Object, e As EventArgs) Handles tile0210.Click
        TileClick(0, 2, 1, 0)
    End Sub

    Private Sub Tile0211_Click(sender As Object, e As EventArgs) Handles tile0211.Click
        TileClick(0, 2, 1, 1)
    End Sub

    Private Sub Tile0212_Click(sender As Object, e As EventArgs) Handles tile0212.Click
        TileClick(0, 2, 1, 2)
    End Sub

    Private Sub Tile0220_Click(sender As Object, e As EventArgs) Handles tile0220.Click
        TileClick(0, 2, 2, 0)
    End Sub

    Private Sub Tile0221_Click(sender As Object, e As EventArgs) Handles tile0221.Click
        TileClick(0, 2, 2, 1)
    End Sub

    Private Sub Tile0222_Click(sender As Object, e As EventArgs) Handles tile0222.Click
        TileClick(0, 2, 2, 2)
    End Sub

    'big board: mid left---------------------------------------------------------------------------
    Private Sub Tile1000_Click(sender As Object, e As EventArgs) Handles tile1000.Click
        TileClick(1, 0, 0, 0)
    End Sub

    Private Sub Tile1001_Click(sender As Object, e As EventArgs) Handles tile1001.Click
        TileClick(1, 0, 0, 1)
    End Sub

    Private Sub Tile1002_Click(sender As Object, e As EventArgs) Handles tile1002.Click
        TileClick(1, 0, 0, 2)
    End Sub

    Private Sub Tile1010_Click(sender As Object, e As EventArgs) Handles tile1010.Click
        TileClick(1, 0, 1, 0)
    End Sub

    Private Sub Tile1011_Click(sender As Object, e As EventArgs) Handles tile1011.Click
        TileClick(1, 0, 1, 1)
    End Sub

    Private Sub Tile1012_Click(sender As Object, e As EventArgs) Handles tile1012.Click
        TileClick(1, 0, 1, 2)
    End Sub

    Private Sub Tile1020_Click(sender As Object, e As EventArgs) Handles tile1020.Click
        TileClick(1, 0, 2, 0)
    End Sub

    Private Sub Tile1021_Click(sender As Object, e As EventArgs) Handles tile1021.Click
        TileClick(1, 0, 2, 1)
    End Sub

    Private Sub Tile1022_Click(sender As Object, e As EventArgs) Handles tile1022.Click
        TileClick(1, 0, 2, 2)
    End Sub

    'big board: mid center-------------------------------------------------------------------------
    Private Sub Tile1100_Click(sender As Object, e As EventArgs) Handles tile1100.Click
        TileClick(1, 1, 0, 0)
    End Sub

    Private Sub Tile1101_Click(sender As Object, e As EventArgs) Handles tile1101.Click
        TileClick(1, 1, 0, 1)
    End Sub

    Private Sub Tile1102_Click(sender As Object, e As EventArgs) Handles tile1102.Click
        TileClick(1, 1, 0, 2)
    End Sub

    Private Sub Tile1110_Click(sender As Object, e As EventArgs) Handles tile1110.Click
        TileClick(1, 1, 1, 0)
    End Sub

    Private Sub Tile1111_Click(sender As Object, e As EventArgs) Handles tile1111.Click
        TileClick(1, 1, 1, 1)
    End Sub

    Private Sub Tile1112_Click(sender As Object, e As EventArgs) Handles tile1112.Click
        TileClick(1, 1, 1, 2)
    End Sub

    Private Sub Tile1120_Click(sender As Object, e As EventArgs) Handles tile1120.Click
        TileClick(1, 1, 2, 0)
    End Sub

    Private Sub Tile1121_Click(sender As Object, e As EventArgs) Handles tile1121.Click
        TileClick(1, 1, 2, 1)
    End Sub

    Private Sub Tile1122_Click(sender As Object, e As EventArgs) Handles tile1122.Click
        TileClick(1, 1, 2, 2)
    End Sub

    'big board: mid right--------------------------------------------------------------------------
    Private Sub Tile1200_Click(sender As Object, e As EventArgs) Handles tile1200.Click
        TileClick(1, 2, 0, 0)
    End Sub

    Private Sub Tile1201_Click(sender As Object, e As EventArgs) Handles tile1201.Click
        TileClick(1, 2, 0, 1)
    End Sub

    Private Sub Tile1202_Click(sender As Object, e As EventArgs) Handles tile1202.Click
        TileClick(1, 2, 0, 2)
    End Sub

    Private Sub Tile1210_Click(sender As Object, e As EventArgs) Handles tile1210.Click
        TileClick(1, 2, 1, 0)
    End Sub

    Private Sub Tile1211_Click(sender As Object, e As EventArgs) Handles tile1211.Click
        TileClick(1, 2, 1, 1)
    End Sub

    Private Sub Tile1212_Click(sender As Object, e As EventArgs) Handles tile1212.Click
        TileClick(1, 2, 1, 2)
    End Sub

    Private Sub Tile1220_Click(sender As Object, e As EventArgs) Handles tile1220.Click
        TileClick(1, 2, 2, 0)
    End Sub

    Private Sub Tile1221_Click(sender As Object, e As EventArgs) Handles tile1221.Click
        TileClick(1, 2, 2, 1)
    End Sub

    Private Sub Tile1222_Click(sender As Object, e As EventArgs) Handles tile1222.Click
        TileClick(1, 2, 2, 2)
    End Sub

    'big board: bottom left------------------------------------------------------------------------
    Private Sub Tile2000_Click(sender As Object, e As EventArgs) Handles tile2000.Click
        TileClick(2, 0, 0, 0)
    End Sub

    Private Sub Tile2001_Click(sender As Object, e As EventArgs) Handles tile2001.Click
        TileClick(2, 0, 0, 1)
    End Sub

    Private Sub Tile2002_Click(sender As Object, e As EventArgs) Handles tile2002.Click
        TileClick(2, 0, 0, 2)
    End Sub

    Private Sub Tile2010_Click(sender As Object, e As EventArgs) Handles tile2010.Click
        TileClick(2, 0, 1, 0)
    End Sub

    Private Sub Tile2011_Click(sender As Object, e As EventArgs) Handles tile2011.Click
        TileClick(2, 0, 1, 1)
    End Sub

    Private Sub Tile2012_Click(sender As Object, e As EventArgs) Handles tile2012.Click
        TileClick(2, 0, 1, 2)
    End Sub

    Private Sub Tile2020_Click(sender As Object, e As EventArgs) Handles tile2020.Click
        TileClick(2, 0, 2, 0)
    End Sub

    Private Sub Tile2021_Click(sender As Object, e As EventArgs) Handles tile2021.Click
        TileClick(2, 0, 2, 1)
    End Sub

    Private Sub Tile2022_Click(sender As Object, e As EventArgs) Handles tile2022.Click
        TileClick(2, 0, 2, 2)
    End Sub

    'big board: bottom center----------------------------------------------------------------------
    Private Sub Tile2100_Click(sender As Object, e As EventArgs) Handles tile2100.Click
        TileClick(2, 1, 0, 0)
    End Sub

    Private Sub Tile2101_Click(sender As Object, e As EventArgs) Handles tile2101.Click
        TileClick(2, 1, 0, 1)
    End Sub

    Private Sub Tile2102_Click(sender As Object, e As EventArgs) Handles tile2102.Click
        TileClick(2, 1, 0, 2)
    End Sub

    Private Sub Tile2110_Click(sender As Object, e As EventArgs) Handles tile2110.Click
        TileClick(2, 1, 1, 0)
    End Sub

    Private Sub Tile2111_Click(sender As Object, e As EventArgs) Handles tile2111.Click
        TileClick(2, 1, 1, 1)
    End Sub

    Private Sub Tile2112_Click(sender As Object, e As EventArgs) Handles tile2112.Click
        TileClick(2, 1, 1, 2)
    End Sub

    Private Sub Tile2120_Click(sender As Object, e As EventArgs) Handles tile2120.Click
        TileClick(2, 1, 2, 0)
    End Sub

    Private Sub Tile2121_Click(sender As Object, e As EventArgs) Handles tile2121.Click
        TileClick(2, 1, 2, 1)
    End Sub

    Private Sub Tile2122_Click(sender As Object, e As EventArgs) Handles tile2122.Click
        TileClick(2, 1, 2, 2)
    End Sub

    'big board: bottom right-----------------------------------------------------------------------
    Private Sub Tile2200_Click(sender As Object, e As EventArgs) Handles tile2200.Click
        TileClick(2, 2, 0, 0)
    End Sub

    Private Sub Tile2201_Click(sender As Object, e As EventArgs) Handles tile2201.Click
        TileClick(2, 2, 0, 1)
    End Sub

    Private Sub Tile2202_Click(sender As Object, e As EventArgs) Handles tile2202.Click
        TileClick(2, 2, 0, 2)
    End Sub

    Private Sub Tile2210_Click(sender As Object, e As EventArgs) Handles tile2210.Click
        TileClick(2, 2, 1, 0)
    End Sub

    Private Sub Tile2211_Click(sender As Object, e As EventArgs) Handles tile2211.Click
        TileClick(2, 2, 1, 1)
    End Sub

    Private Sub Tile2212_Click(sender As Object, e As EventArgs) Handles tile2212.Click
        TileClick(2, 2, 1, 2)
    End Sub

    Private Sub Tile2220_Click(sender As Object, e As EventArgs) Handles tile2220.Click
        TileClick(2, 2, 2, 0)
    End Sub

    Private Sub Tile2221_Click(sender As Object, e As EventArgs) Handles tile2221.Click
        TileClick(2, 2, 2, 1)
    End Sub

    Private Sub Tile2222_Click(sender As Object, e As EventArgs) Handles tile2222.Click
        TileClick(2, 2, 2, 2)
    End Sub
    '============================================================================================================================
End Class
