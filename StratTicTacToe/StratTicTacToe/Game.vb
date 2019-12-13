'Author: Kalen Holbrook

Option Strict On : Option Explicit On

Public Class Game
    'Program to create a strategic tic-tac-toe
    'create boards
    Private bigBoard(2, 2) As Short '0=empty, 1=X, 2=O, 3=tie
    Private game00(2, 2) As Short
    Private game01(2, 2) As Short
    Private game02(2, 2) As Short
    Private game10(2, 2) As Short
    Private game11(2, 2) As Short
    Private game12(2, 2) As Short
    Private game20(2, 2) As Short
    Private game21(2, 2) As Short
    Private game22(2, 2) As Short

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
    Private Sub ClearAll()
        'Allow players to click wherever
        clickKey = ""

        'Set player to X
        playerNum = 1
        playerXO = "X"

        'Set notClicked values to false for all tiles
        'And Set all tiles text to empty strings
        For i = 0 To 2
            For j = 0 To 2
                For k = 0 To 2
                    For l = 0 To 2
                        notClicked(i, j, k, l) = True
                        tileLabels(i, j, k, l).Text = ""
                    Next
                Next
            Next
        Next


        For i = 0 To 2
            For j = 0 To 2
                'Internal boards
                bigBoard(i, j) = 0
                game00(i, j) = 0
                game01(i, j) = 0
                game02(i, j) = 0
                game10(i, j) = 0
                game11(i, j) = 0
                game12(i, j) = 0
                game20(i, j) = 0
                game21(i, j) = 0
                game22(i, j) = 0
            Next
        Next
    End Sub '---------------------------------------------------------


    ''' <summary>
    ''' checks if a player has won on the inputed game and is to be run after every turn
    ''' Returns 0 if no winner, 1 if winner, 2 if tie
    ''' </summary>
    ''' <param name="game"></param>
    ''' <returns>Returns True if the game of Tic-Tac-Toe is won, False otherwise</returns>
    Private Function CheckWin(game As Short(,)) As Short
        Dim notFinished As Boolean = False

        'check for vertical and horizontal matches
        For i = 0 To 2
            If game(i, 0).Equals(game(i, 1)) And
                game(i, 0).Equals(game(i, 2)) Then 'horizontal
                If Not game(i, 0) = 0 Then
                    Return 1
                End If
            ElseIf game(0, i).Equals(game(1, i)) And
                game(0, i).Equals(game(2, i)) Then 'vertical

                If Not game(0, i) = 0 Then
                    Return 1
                End If
            End If
        Next

        'check for diagonal matches
        If (game(0, 0).Equals(game(1, 1)) And game(0, 0).Equals(game(2, 2))) Or
           (game(0, 2).Equals(game(1, 1)) And game(0, 2).Equals(game(2, 0))) Then
            If Not game(1, 1) = 0 Then
                Return 1
            End If
        End If

        'CONFIRMED: WIN STATE = FALSE--------------------------------

        'check for ties**********************************************

        For i = 0 To 2
            For j = 0 To 2
                If game(i, j) = 0 Then
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
    ''' Functionality universal to all click events
    ''' </summary>
    ''' <param name="tile">tile on visual game that needs to be changed</param>
    ''' <param name="game">Small game of Tic-Tac-Toe currently being played</param>
    ''' <param name="vCoord">Vertical coordinate of clicked place on game being played</param>
    ''' <param name="hCoord">Horizontal coordinate of clicked place on game being played</param>
    ''' <param name="gameLabel">Label to be set Visible if someone wins or ties the game</param>
    ''' <param name="gameCoordV">Vertical coordinate of game being played on bigBoard</param>
    ''' <param name="gameCoordH">Hoorizontal coordinate of game being played on bigBoard</param>
    Private Sub TileClick(tile As Label, game As Short(,), vCoord As Short, hCoord As Short, gameLabel As Label, gameCoordV As Short, gameCoordH As Short)
        Dim gameWin As Short
        'change visual and background boards
        tile.Text = playerXO
        game(vCoord, hCoord) = playerNum

        'check if the player won/tied game
        gameWin = CheckWin(game)

        'if so, update bigboard
        If gameWin = 1 Then
            With gameLabel
                .Text = playerXO
                .Visible = True
            End With
            bigBoard(gameCoordV, gameCoordH) = playerNum
            'Disable all not clicked tiles in finished game
            For i = 0 To 2
                For j = 0 To 2
                    notClicked(gameCoordV, gameCoordH, i, j) = False
                Next
            Next

            'check for win on bigBoard
            Dim boardWin As Short = CheckWin(bigBoard)
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

        ElseIf gameWin = 2 Then
            'tie on the game
            With gameLabel
                .Text = "T"
                .Visible = True
                bigBoard(gameCoordV, gameCoordH) = 3
            End With
        End If
        'no win and no tie on game; the game continues

        'change the player
        ChangePlayer()
    End Sub
    '==============================CLICK EVENTS====================================================
    'Big Board: top left---------------------------------------------------------------------------
    Private Sub Tile0000_Click(sender As Object, e As EventArgs) Handles tile0000.Click

        If notClicked(0, 0, 0, 0) And (clickKey = "0-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0000, game00, 0, 0, gameLabel00, 0, 0)

            'redirect to proper game
            ChangeKey(0, 0)

            'ensure this spot cannot be clicked again
            notClicked(0, 0, 0, 0) = False

        End If
    End Sub

    Private Sub Tile0001_Click(sender As Object, e As EventArgs) Handles tile0001.Click

        'if not clicked yet and in correct game
        If notClicked(0, 0, 0, 1) And (clickKey = "0-0" Or clickKey = "") Then
            'change games & check wins
            TileClick(tile0001, game00, 0, 1, gameLabel00, 0, 0)

            'redirect to proper game
            ChangeKey(0, 1)

            'ensure this spot cannot be clicked again
            notClicked(0, 0, 0, 1) = False

        End If
    End Sub

    Private Sub Tile0002_Click(sender As Object, e As EventArgs) Handles tile0002.Click

        'if not clicked yet and in correct game
        If notClicked(0, 0, 0, 2) And (clickKey = "0-0" Or clickKey = "") Then
            'change games & check wins
            TileClick(tile0002, game00, 0, 2, gameLabel00, 0, 0)

            'redirect to proper game
            ChangeKey(0, 2)

            'ensure this spot cannot be clicked again
            notClicked(0, 0, 0, 2) = False

        End If
    End Sub

    Private Sub Tile0010_Click(sender As Object, e As EventArgs) Handles tile0010.Click

        If notClicked(0, 0, 1, 0) And (clickKey = "0-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0010, game00, 1, 0, gameLabel00, 0, 0)

            'redirect to proper game
            ChangeKey(1, 0)

            'ensure this spot cannot be clicked again
            notClicked(0, 0, 1, 0) = False

        End If
    End Sub

    Private Sub Tile0011_Click(sender As Object, e As EventArgs) Handles tile0011.Click

        If notClicked(0, 0, 1, 1) And (clickKey = "0-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0011, game00, 1, 1, gameLabel00, 0, 0)

            'redirect to proper game
            ChangeKey(1, 1)

            'ensure this spot cannot be clicked again
            notClicked(0, 0, 1, 1) = False

        End If
    End Sub

    Private Sub Tile0012_Click(sender As Object, e As EventArgs) Handles tile0012.Click

        If notClicked(0, 0, 1, 2) And (clickKey = "0-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0012, game00, 1, 2, gameLabel00, 0, 0)

            'redirect to proper game
            ChangeKey(1, 2)

            'ensure this spot cannot be clicked again
            notClicked(0, 0, 1, 2) = False

        End If
    End Sub

    Private Sub Tile0020_Click(sender As Object, e As EventArgs) Handles tile0020.Click

        If notClicked(0, 0, 2, 0) And (clickKey = "0-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0020, game00, 2, 0, gameLabel00, 0, 0)

            'redirect to proper game
            ChangeKey(2, 0)

            'ensure this spot cannot be clicked again
            notClicked(0, 0, 2, 0) = False

        End If
    End Sub

    Private Sub Tile0021_Click(sender As Object, e As EventArgs) Handles tile0021.Click

        If notClicked(0, 0, 2, 1) And (clickKey = "0-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0021, game00, 2, 1, gameLabel00, 0, 0)

            'redirect to proper game
            ChangeKey(2, 1)

            'ensure this spot cannot be clicked again
            notClicked(0, 0, 2, 1) = False

        End If
    End Sub

    Private Sub Tile0022_Click(sender As Object, e As EventArgs) Handles tile0022.Click

        If notClicked(0, 0, 2, 2) And (clickKey = "0-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0022, game00, 2, 2, gameLabel00, 0, 0)

            'redirect to proper game
            ChangeKey(2, 2)

            'ensure this spot cannot be clicked again
            notClicked(0, 0, 2, 2) = False

        End If
    End Sub

    'big board: top center-------------------------------------------------------------------------
    Private Sub Tile0100_Click(sender As Object, e As EventArgs) Handles tile0100.Click

        If notClicked(0, 1, 0, 0) And (clickKey = "0-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0100, game01, 0, 0, gameLabel01, 0, 1)

            'redirect to proper game
            ChangeKey(0, 0)

            'ensure this spot cannot be clicked again
            notClicked(0, 1, 0, 0) = False

        End If
    End Sub

    Private Sub Tile0101_Click(sender As Object, e As EventArgs) Handles tile0101.Click


        If notClicked(0, 1, 0, 1) And (clickKey = "0-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0101, game01, 0, 1, gameLabel01, 0, 1)

            'redirect to proper game
            ChangeKey(0, 1)

            'ensure this spot cannot be clicked again
            notClicked(0, 1, 0, 1) = False

        End If
    End Sub

    Private Sub Tile0102_Click(sender As Object, e As EventArgs) Handles tile0102.Click


        If notClicked(0, 1, 0, 2) And (clickKey = "0-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0102, game01, 0, 2, gameLabel01, 0, 1)

            'redirect to proper game
            ChangeKey(0, 2)

            'ensure this spot cannot be clicked again
            notClicked(0, 1, 0, 2) = False

        End If
    End Sub

    Private Sub Tile0110_Click(sender As Object, e As EventArgs) Handles tile0110.Click


        If notClicked(0, 1, 1, 0) And (clickKey = "0-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0110, game01, 1, 0, gameLabel01, 0, 1)

            'redirect to proper game
            ChangeKey(1, 0)

            'ensure this spot cannot be clicked again
            notClicked(0, 1, 1, 0) = False

        End If
    End Sub

    Private Sub Tile0111_Click(sender As Object, e As EventArgs) Handles tile0111.Click


        If notClicked(0, 1, 1, 1) And (clickKey = "0-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0111, game01, 1, 1, gameLabel01, 0, 1)

            'redirect to proper game
            ChangeKey(1, 1)

            'ensure this spot cannot be clicked again
            notClicked(0, 1, 1, 1) = False

        End If
    End Sub

    Private Sub Tile0112_Click(sender As Object, e As EventArgs) Handles tile0112.Click


        If notClicked(0, 1, 1, 2) And (clickKey = "0-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0112, game01, 1, 2, gameLabel01, 0, 1)

            'redirect to proper game
            ChangeKey(1, 2)

            'ensure this spot cannot be clicked again
            notClicked(0, 1, 1, 2) = False

        End If
    End Sub

    Private Sub Tile0120_Click(sender As Object, e As EventArgs) Handles tile0120.Click


        If notClicked(0, 1, 2, 0) And (clickKey = "0-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0120, game01, 2, 0, gameLabel01, 0, 1)

            'redirect to proper game
            ChangeKey(2, 0)

            'ensure this spot cannot be clicked again
            notClicked(0, 1, 2, 0) = False

        End If
    End Sub

    Private Sub Tile0121_Click(sender As Object, e As EventArgs) Handles tile0121.Click


        If notClicked(0, 1, 2, 1) And (clickKey = "0-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0121, game01, 2, 1, gameLabel01, 0, 1)

            'redirect to proper game
            ChangeKey(2, 1)

            'ensure this spot cannot be clicked again
            notClicked(0, 1, 2, 1) = False

        End If
    End Sub

    Private Sub Tile0122_Click(sender As Object, e As EventArgs) Handles tile0122.Click


        If notClicked(0, 1, 2, 2) And (clickKey = "0-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0122, game01, 2, 2, gameLabel01, 0, 1)

            'redirect to proper game
            ChangeKey(2, 2)

            'ensure this spot cannot be clicked again
            notClicked(0, 1, 2, 2) = False

        End If
    End Sub

    'big board: top right--------------------------------------------------------------------------
    Private Sub Tile0200_Click(sender As Object, e As EventArgs) Handles tile0200.Click


        If notClicked(0, 2, 0, 0) And (clickKey = "0-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0200, game02, 0, 0, gameLabel02, 0, 2)

            'redirect to proper game
            ChangeKey(0, 0)

            'ensure this spot cannot be clicked again
            notClicked(0, 2, 0, 0) = False

        End If
    End Sub

    Private Sub Tile0201_Click(sender As Object, e As EventArgs) Handles tile0201.Click


        If notClicked(0, 2, 0, 1) And (clickKey = "0-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0201, game02, 0, 1, gameLabel02, 0, 2)

            'redirect to proper game
            ChangeKey(0, 1)

            'ensure this spot cannot be clicked again
            notClicked(0, 2, 0, 1) = False

        End If
    End Sub

    Private Sub Tile0202_Click(sender As Object, e As EventArgs) Handles tile0202.Click


        If notClicked(0, 2, 0, 2) And (clickKey = "0-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0202, game02, 0, 2, gameLabel02, 0, 2)

            'redirect to proper game
            ChangeKey(0, 2)

            'ensure this spot cannot be clicked again
            notClicked(0, 2, 0, 2) = False

        End If
    End Sub

    Private Sub Tile0210_Click(sender As Object, e As EventArgs) Handles tile0210.Click


        If notClicked(0, 2, 1, 0) And (clickKey = "0-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0210, game02, 1, 0, gameLabel02, 0, 2)

            'redirect to proper game
            ChangeKey(1, 0)

            'ensure this spot cannot be clicked again
            notClicked(0, 2, 1, 0) = False

        End If
    End Sub

    Private Sub Tile0211_Click(sender As Object, e As EventArgs) Handles tile0211.Click


        If notClicked(0, 2, 1, 1) And (clickKey = "0-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0211, game02, 1, 1, gameLabel02, 0, 2)

            'redirect to proper game
            ChangeKey(1, 1)

            'ensure this spot cannot be clicked again
            notClicked(0, 2, 1, 1) = False

        End If
    End Sub

    Private Sub Tile0212_Click(sender As Object, e As EventArgs) Handles tile0212.Click


        If notClicked(0, 2, 1, 2) And (clickKey = "0-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0212, game02, 1, 2, gameLabel02, 0, 2)

            'redirect to proper game
            ChangeKey(1, 2)

            'ensure this spot cannot be clicked again
            notClicked(0, 2, 1, 2) = False

        End If
    End Sub

    Private Sub Tile0220_Click(sender As Object, e As EventArgs) Handles tile0220.Click


        If notClicked(0, 2, 2, 0) And (clickKey = "0-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0220, game02, 2, 0, gameLabel02, 0, 2)

            'redirect to proper game
            ChangeKey(2, 0)

            'ensure this spot cannot be clicked again
            notClicked(0, 2, 2, 0) = False

        End If
    End Sub

    Private Sub Tile0221_Click(sender As Object, e As EventArgs) Handles tile0221.Click


        If notClicked(0, 2, 2, 1) And (clickKey = "0-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0221, game02, 2, 1, gameLabel02, 0, 2)

            'redirect to proper game
            ChangeKey(2, 1)

            'ensure this spot cannot be clicked again
            notClicked(0, 2, 2, 1) = False

        End If
    End Sub

    Private Sub Tile0222_Click(sender As Object, e As EventArgs) Handles tile0222.Click


        If notClicked(0, 2, 2, 2) And (clickKey = "0-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile0222, game02, 2, 2, gameLabel02, 0, 2)

            'redirect to proper game
            ChangeKey(2, 2)

            'ensure this spot cannot be clicked again
            notClicked(0, 2, 2, 2) = False

        End If
    End Sub

    'big board: mid left---------------------------------------------------------------------------
    Private Sub Tile1000_Click(sender As Object, e As EventArgs) Handles tile1000.Click


        If notClicked(1, 0, 0, 0) And (clickKey = "1-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1000, game10, 0, 0, gameLabel10, 1, 0)

            'redirect to proper game
            ChangeKey(0, 0)

            'ensure this spot cannot be clicked again
            notClicked(1, 0, 0, 0) = False

        End If
    End Sub

    Private Sub Tile1001_Click(sender As Object, e As EventArgs) Handles tile1001.Click


        If notClicked(1, 0, 0, 1) And (clickKey = "1-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1001, game10, 0, 1, gameLabel10, 1, 0)

            'redirect to proper game
            ChangeKey(0, 1)

            'ensure this spot cannot be clicked again
            notClicked(1, 0, 0, 1) = False

        End If
    End Sub

    Private Sub Tile1002_Click(sender As Object, e As EventArgs) Handles tile1002.Click


        If notClicked(1, 0, 0, 2) And (clickKey = "1-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1002, game10, 0, 2, gameLabel10, 1, 0)

            'redirect to proper game
            ChangeKey(0, 2)

            'ensure this spot cannot be clicked again
            notClicked(1, 0, 0, 2) = False

        End If
    End Sub

    Private Sub Tile1010_Click(sender As Object, e As EventArgs) Handles tile1010.Click


        If notClicked(1, 0, 1, 0) And (clickKey = "1-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1010, game10, 1, 0, gameLabel10, 1, 0)

            'redirect to proper game
            ChangeKey(1, 0)

            'ensure this spot cannot be clicked again
            notClicked(1, 0, 1, 0) = False

        End If
    End Sub

    Private Sub Tile1011_Click(sender As Object, e As EventArgs) Handles tile1011.Click


        If notClicked(1, 0, 1, 1) And (clickKey = "1-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1011, game10, 1, 1, gameLabel10, 1, 0)

            'redirect to proper game
            ChangeKey(1, 1)

            'ensure this spot cannot be clicked again
            notClicked(1, 0, 1, 1) = False

        End If
    End Sub

    Private Sub Tile1012_Click(sender As Object, e As EventArgs) Handles tile1012.Click


        If notClicked(1, 0, 1, 2) And (clickKey = "1-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1012, game10, 1, 2, gameLabel10, 1, 0)

            'redirect to proper game
            ChangeKey(1, 2)

            'ensure this spot cannot be clicked again
            notClicked(1, 0, 1, 2) = False

        End If
    End Sub

    Private Sub Tile1020_Click(sender As Object, e As EventArgs) Handles tile1020.Click


        If notClicked(1, 0, 2, 0) And (clickKey = "1-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1020, game10, 2, 0, gameLabel10, 1, 0)

            'redirect to proper game
            ChangeKey(2, 0)

            'ensure this spot cannot be clicked again
            notClicked(1, 0, 2, 0) = False

        End If
    End Sub

    Private Sub Tile1021_Click(sender As Object, e As EventArgs) Handles tile1021.Click


        If notClicked(1, 0, 2, 1) And (clickKey = "1-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1021, game10, 2, 1, gameLabel10, 1, 0)

            'redirect to proper game
            ChangeKey(2, 1)

            'ensure this spot cannot be clicked again
            notClicked(1, 0, 2, 1) = False

        End If
    End Sub

    Private Sub Tile1022_Click(sender As Object, e As EventArgs) Handles tile1022.Click


        If notClicked(1, 0, 2, 2) And (clickKey = "1-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1022, game10, 2, 2, gameLabel10, 1, 0)

            'redirect to proper game
            ChangeKey(2, 2)

            'ensure this spot cannot be clicked again
            notClicked(1, 0, 2, 2) = False

        End If
    End Sub

    'big board: mid center-------------------------------------------------------------------------
    Private Sub Tile1100_Click(sender As Object, e As EventArgs) Handles tile1100.Click


        If notClicked(1, 1, 0, 0) And (clickKey = "1-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1100, game11, 0, 0, gameLabel11, 1, 1)

            'redirect to proper game
            ChangeKey(0, 0)

            'ensure this spot cannot be clicked again
            notClicked(1, 1, 0, 0) = False

        End If
    End Sub

    Private Sub Tile1101_Click(sender As Object, e As EventArgs) Handles tile1101.Click


        If notClicked(1, 1, 0, 1) And (clickKey = "1-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1101, game11, 0, 1, gameLabel11, 1, 1)

            'redirect to proper game
            ChangeKey(0, 1)

            'ensure this spot cannot be clicked again
            notClicked(1, 1, 0, 1) = False

        End If
    End Sub

    Private Sub Tile1102_Click(sender As Object, e As EventArgs) Handles tile1102.Click


        If notClicked(1, 1, 0, 2) And (clickKey = "1-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1102, game11, 0, 2, gameLabel11, 1, 1)

            'redirect to proper game
            ChangeKey(0, 2)

            'ensure this spot cannot be clicked again
            notClicked(1, 1, 0, 2) = False

        End If
    End Sub

    Private Sub Tile1110_Click(sender As Object, e As EventArgs) Handles tile1110.Click


        If notClicked(1, 1, 1, 0) And (clickKey = "1-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1110, game11, 1, 0, gameLabel11, 1, 1)

            'redirect to proper game
            ChangeKey(1, 0)

            'ensure this spot cannot be clicked again
            notClicked(1, 1, 1, 0) = False

        End If
    End Sub

    Private Sub Tile1111_Click(sender As Object, e As EventArgs) Handles tile1111.Click


        If notClicked(1, 1, 1, 1) And (clickKey = "1-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1111, game11, 1, 1, gameLabel11, 1, 1)

            'redirect to proper game
            ChangeKey(1, 1)

            'ensure this spot cannot be clicked again
            notClicked(1, 1, 1, 1) = False

        End If
    End Sub

    Private Sub Tile1112_Click(sender As Object, e As EventArgs) Handles tile1112.Click


        If notClicked(1, 1, 1, 2) And (clickKey = "1-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1112, game11, 1, 2, gameLabel11, 1, 1)

            'redirect to proper game
            ChangeKey(1, 2)

            'ensure this spot cannot be clicked again
            notClicked(1, 1, 1, 2) = False

        End If
    End Sub

    Private Sub Tile1120_Click(sender As Object, e As EventArgs) Handles tile1120.Click


        If notClicked(1, 1, 2, 0) And (clickKey = "1-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1120, game11, 2, 0, gameLabel11, 1, 1)

            'redirect to proper game
            ChangeKey(2, 0)

            'ensure this spot cannot be clicked again
            notClicked(1, 1, 2, 0) = False

        End If
    End Sub

    Private Sub Tile1121_Click(sender As Object, e As EventArgs) Handles tile1121.Click


        If notClicked(1, 1, 2, 1) And (clickKey = "1-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1121, game11, 2, 1, gameLabel11, 1, 1)

            'redirect to proper game
            ChangeKey(2, 1)

            'ensure this spot cannot be clicked again
            notClicked(1, 1, 2, 1) = False

        End If
    End Sub

    Private Sub Tile1122_Click(sender As Object, e As EventArgs) Handles tile1122.Click


        If notClicked(1, 1, 2, 2) And (clickKey = "1-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1122, game11, 2, 2, gameLabel11, 1, 1)

            'redirect to proper game
            ChangeKey(2, 2)

            'ensure this spot cannot be clicked again
            notClicked(1, 1, 2, 2) = False

        End If
    End Sub

    'big board: mid right--------------------------------------------------------------------------
    Private Sub Tile1200_Click(sender As Object, e As EventArgs) Handles tile1200.Click


        If notClicked(1, 2, 0, 0) And (clickKey = "1-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1200, game12, 0, 0, gameLabel12, 1, 2)

            'redirect to proper game
            ChangeKey(0, 0)

            'ensure this spot cannot be clicked again
            notClicked(1, 2, 0, 0) = False

        End If
    End Sub

    Private Sub Tile1201_Click(sender As Object, e As EventArgs) Handles tile1201.Click


        If notClicked(1, 2, 0, 1) And (clickKey = "1-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1201, game12, 0, 1, gameLabel12, 1, 2)

            'redirect to proper game
            ChangeKey(0, 1)

            'ensure this spot cannot be clicked again
            notClicked(1, 2, 0, 1) = False

        End If
    End Sub

    Private Sub Tile1202_Click(sender As Object, e As EventArgs) Handles tile1202.Click


        If notClicked(1, 2, 0, 2) And (clickKey = "1-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1202, game12, 0, 2, gameLabel12, 1, 2)

            'redirect to proper game
            ChangeKey(0, 2)

            'ensure this spot cannot be clicked again
            notClicked(1, 2, 0, 2) = False

        End If
    End Sub

    Private Sub Tile1210_Click(sender As Object, e As EventArgs) Handles tile1210.Click


        If notClicked(1, 2, 1, 0) And (clickKey = "1-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1210, game12, 1, 0, gameLabel12, 1, 2)

            'redirect to proper game
            ChangeKey(1, 0)

            'ensure this spot cannot be clicked again
            notClicked(1, 2, 1, 0) = False

        End If
    End Sub

    Private Sub Tile1211_Click(sender As Object, e As EventArgs) Handles tile1211.Click


        If notClicked(1, 2, 1, 1) And (clickKey = "1-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1211, game12, 1, 1, gameLabel12, 1, 2)

            'redirect to proper game
            ChangeKey(1, 1)

            'ensure this spot cannot be clicked again
            notClicked(1, 2, 1, 1) = False

        End If
    End Sub

    Private Sub Tile1212_Click(sender As Object, e As EventArgs) Handles tile1212.Click


        If notClicked(1, 2, 1, 2) And (clickKey = "1-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1212, game12, 1, 2, gameLabel12, 1, 2)

            'redirect to proper game
            ChangeKey(1, 2)

            'ensure this spot cannot be clicked again
            notClicked(1, 2, 1, 2) = False

        End If
    End Sub

    Private Sub Tile1220_Click(sender As Object, e As EventArgs) Handles tile1220.Click


        If notClicked(1, 2, 2, 0) And (clickKey = "1-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1220, game12, 2, 0, gameLabel12, 1, 2)

            'redirect to proper game
            ChangeKey(2, 0)

            'ensure this spot cannot be clicked again
            notClicked(1, 2, 2, 0) = False

        End If
    End Sub

    Private Sub Tile1221_Click(sender As Object, e As EventArgs) Handles tile1221.Click


        If notClicked(1, 2, 2, 1) And (clickKey = "1-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1221, game12, 2, 1, gameLabel12, 1, 2)

            'redirect to proper game
            ChangeKey(2, 1)

            'ensure this spot cannot be clicked again
            notClicked(1, 2, 2, 1) = False

        End If
    End Sub

    Private Sub Tile1222_Click(sender As Object, e As EventArgs) Handles tile1222.Click


        If notClicked(1, 2, 2, 2) And (clickKey = "1-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile1222, game12, 2, 2, gameLabel12, 1, 2)

            'redirect to proper game
            ChangeKey(2, 2)

            'ensure this spot cannot be clicked again
            notClicked(1, 2, 2, 2) = False

        End If
    End Sub

    'big board: bottom left------------------------------------------------------------------------
    Private Sub Tile2000_Click(sender As Object, e As EventArgs) Handles tile2000.Click


        If notClicked(2, 0, 0, 0) And (clickKey = "2-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2000, game20, 0, 0, gameLabel20, 2, 0)

            'redirect to proper game
            ChangeKey(0, 0)

            'ensure this spot cannot be clicked again
            notClicked(2, 0, 0, 0) = False

        End If
    End Sub

    Private Sub Tile2001_Click(sender As Object, e As EventArgs) Handles tile2001.Click


        If notClicked(2, 0, 0, 1) And (clickKey = "2-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2001, game20, 0, 1, gameLabel20, 2, 0)

            'redirect to proper game
            ChangeKey(0, 1)

            'ensure this spot cannot be clicked again
            notClicked(2, 0, 0, 1) = False

        End If
    End Sub

    Private Sub Tile2002_Click(sender As Object, e As EventArgs) Handles tile2002.Click


        If notClicked(2, 0, 0, 2) And (clickKey = "2-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2002, game20, 0, 2, gameLabel20, 2, 0)

            'redirect to proper game
            ChangeKey(0, 2)

            'ensure this spot cannot be clicked again
            notClicked(2, 0, 0, 2) = False

        End If
    End Sub

    Private Sub Tile2010_Click(sender As Object, e As EventArgs) Handles tile2010.Click


        If notClicked(2, 0, 1, 0) And (clickKey = "2-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2010, game20, 1, 0, gameLabel20, 2, 0)

            'redirect to proper game
            ChangeKey(1, 0)

            'ensure this spot cannot be clicked again
            notClicked(2, 0, 1, 0) = False

        End If
    End Sub

    Private Sub Tile2011_Click(sender As Object, e As EventArgs) Handles tile2011.Click


        If notClicked(2, 0, 1, 1) And (clickKey = "2-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2011, game20, 1, 1, gameLabel20, 2, 0)

            'redirect to proper game
            ChangeKey(1, 1)

            'ensure this spot cannot be clicked again
            notClicked(2, 0, 1, 1) = False

        End If
    End Sub

    Private Sub Tile2012_Click(sender As Object, e As EventArgs) Handles tile2012.Click


        If notClicked(2, 0, 1, 2) And (clickKey = "2-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2012, game20, 1, 2, gameLabel20, 2, 0)

            'redirect to proper game
            ChangeKey(1, 2)

            'ensure this spot cannot be clicked again
            notClicked(2, 0, 1, 2) = False

        End If
    End Sub

    Private Sub Tile2020_Click(sender As Object, e As EventArgs) Handles tile2020.Click


        If notClicked(2, 0, 2, 0) And (clickKey = "2-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2020, game20, 2, 0, gameLabel20, 2, 0)

            'redirect to proper game
            ChangeKey(2, 0)

            'ensure this spot cannot be clicked again
            notClicked(2, 0, 2, 0) = False

        End If
    End Sub

    Private Sub Tile2021_Click(sender As Object, e As EventArgs) Handles tile2021.Click


        If notClicked(2, 0, 2, 1) And (clickKey = "2-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2021, game20, 2, 1, gameLabel20, 2, 0)

            'redirect to proper game
            ChangeKey(2, 1)

            'ensure this spot cannot be clicked again
            notClicked(2, 0, 2, 1) = False

        End If
    End Sub

    Private Sub Tile2022_Click(sender As Object, e As EventArgs) Handles tile2022.Click


        If notClicked(2, 0, 2, 2) And (clickKey = "2-0" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2022, game20, 2, 2, gameLabel20, 2, 0)

            'redirect to proper game
            ChangeKey(2, 2)

            'ensure this spot cannot be clicked again
            notClicked(2, 0, 2, 2) = False

        End If
    End Sub

    'big board: bottom center----------------------------------------------------------------------
    Private Sub Tile2100_Click(sender As Object, e As EventArgs) Handles tile2100.Click


        If notClicked(2, 1, 0, 0) And (clickKey = "2-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2100, game21, 0, 0, gameLabel21, 2, 1)

            'redirect to proper game
            ChangeKey(0, 0)

            'ensure this spot cannot be clicked again
            notClicked(2, 1, 0, 0) = False

        End If
    End Sub

    Private Sub Tile2101_Click(sender As Object, e As EventArgs) Handles tile2101.Click


        If notClicked(2, 1, 0, 1) And (clickKey = "2-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2101, game21, 0, 1, gameLabel21, 2, 1)

            'redirect to proper game
            ChangeKey(0, 1)

            'ensure this spot cannot be clicked again
            notClicked(2, 1, 0, 1) = False

        End If
    End Sub

    Private Sub Tile2102_Click(sender As Object, e As EventArgs) Handles tile2102.Click


        If notClicked(2, 1, 0, 2) And (clickKey = "2-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2102, game21, 0, 2, gameLabel21, 2, 1)

            'redirect to proper game
            ChangeKey(0, 2)

            'ensure this spot cannot be clicked again
            notClicked(2, 1, 0, 2) = False

        End If
    End Sub

    Private Sub Tile2110_Click(sender As Object, e As EventArgs) Handles tile2110.Click


        If notClicked(2, 1, 1, 0) And (clickKey = "2-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2110, game21, 1, 0, gameLabel21, 2, 1)

            'redirect to proper game
            ChangeKey(1, 0)

            'ensure this spot cannot be clicked again
            notClicked(2, 1, 1, 0) = False

        End If
    End Sub

    Private Sub Tile2111_Click(sender As Object, e As EventArgs) Handles tile2111.Click


        If notClicked(2, 1, 1, 1) And (clickKey = "2-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2111, game21, 1, 1, gameLabel21, 2, 1)

            'redirect to proper game
            ChangeKey(1, 1)

            'ensure this spot cannot be clicked again
            notClicked(2, 1, 1, 1) = False

        End If
    End Sub

    Private Sub Tile2112_Click(sender As Object, e As EventArgs) Handles tile2112.Click


        If notClicked(2, 1, 1, 2) And (clickKey = "2-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2112, game21, 1, 2, gameLabel21, 2, 1)

            'redirect to proper game
            ChangeKey(1, 2)

            'ensure this spot cannot be clicked again
            notClicked(2, 1, 1, 2) = False

        End If
    End Sub

    Private Sub Tile2120_Click(sender As Object, e As EventArgs) Handles tile2120.Click


        If notClicked(2, 1, 2, 0) And (clickKey = "2-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2120, game21, 2, 0, gameLabel21, 2, 1)

            'redirect to proper game
            ChangeKey(2, 0)

            'ensure this spot cannot be clicked again
            notClicked(2, 1, 2, 0) = False

        End If
    End Sub

    Private Sub Tile2121_Click(sender As Object, e As EventArgs) Handles tile2121.Click


        If notClicked(2, 1, 2, 1) And (clickKey = "2-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2121, game21, 2, 1, gameLabel21, 2, 1)

            'redirect to proper game
            ChangeKey(2, 1)

            'ensure this spot cannot be clicked again
            notClicked(2, 1, 2, 1) = False

        End If
    End Sub

    Private Sub Tile2122_Click(sender As Object, e As EventArgs) Handles tile2122.Click


        If notClicked(2, 1, 2, 2) And (clickKey = "2-1" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2122, game21, 2, 2, gameLabel21, 2, 1)

            'redirect to proper game
            ChangeKey(2, 2)

            'ensure this spot cannot be clicked again
            notClicked(2, 1, 2, 2) = False

        End If
    End Sub

    'big board: bottom right-----------------------------------------------------------------------
    Private Sub Tile2200_Click(sender As Object, e As EventArgs) Handles tile2200.Click


        If notClicked(2, 2, 0, 0) And (clickKey = "2-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2200, game22, 0, 0, gameLabel22, 2, 2)

            'redirect to proper game
            ChangeKey(0, 0)

            'ensure this spot cannot be clicked again
            notClicked(2, 2, 0, 0) = False

        End If
    End Sub

    Private Sub Tile2201_Click(sender As Object, e As EventArgs) Handles tile2201.Click


        If notClicked(2, 2, 0, 1) And (clickKey = "2-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2201, game22, 0, 1, gameLabel22, 2, 2)

            'redirect to proper game
            ChangeKey(0, 1)

            'ensure this spot cannot be clicked again
            notClicked(2, 2, 0, 1) = False

        End If
    End Sub

    Private Sub Tile2202_Click(sender As Object, e As EventArgs) Handles tile2202.Click


        If notClicked(2, 2, 0, 2) And (clickKey = "2-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2202, game22, 0, 2, gameLabel22, 2, 2)

            'redirect to proper game
            ChangeKey(0, 2)

            'ensure this spot cannot be clicked again
            notClicked(2, 2, 0, 2) = False

        End If
    End Sub

    Private Sub Tile2210_Click(sender As Object, e As EventArgs) Handles tile2210.Click


        If notClicked(2, 2, 1, 0) And (clickKey = "2-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2210, game22, 1, 0, gameLabel22, 2, 2)

            'redirect to proper game
            ChangeKey(1, 0)

            'ensure this spot cannot be clicked again
            notClicked(2, 2, 1, 0) = False

        End If
    End Sub

    Private Sub Tile2211_Click(sender As Object, e As EventArgs) Handles tile2211.Click


        If notClicked(2, 2, 1, 1) And (clickKey = "2-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2211, game22, 1, 1, gameLabel22, 2, 2)

            'redirect to proper game
            ChangeKey(1, 1)

            'ensure this spot cannot be clicked again
            notClicked(2, 2, 1, 1) = False

        End If
    End Sub

    Private Sub Tile2212_Click(sender As Object, e As EventArgs) Handles tile2212.Click


        If notClicked(2, 2, 1, 2) And (clickKey = "2-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2212, game22, 1, 2, gameLabel22, 2, 2)

            'redirect to proper game
            ChangeKey(1, 2)

            'ensure this spot cannot be clicked again
            notClicked(2, 2, 1, 2) = False

        End If
    End Sub

    Private Sub Tile2220_Click(sender As Object, e As EventArgs) Handles tile2220.Click


        If notClicked(2, 2, 2, 0) And (clickKey = "2-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2220, game22, 2, 0, gameLabel22, 2, 2)

            'redirect to proper game
            ChangeKey(2, 0)

            'ensure this spot cannot be clicked again
            notClicked(2, 2, 2, 0) = False

        End If
    End Sub

    Private Sub Tile2221_Click(sender As Object, e As EventArgs) Handles tile2221.Click


        If notClicked(2, 2, 2, 1) And (clickKey = "2-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2221, game22, 2, 1, gameLabel22, 2, 2)

            'redirect to proper game
            ChangeKey(2, 1)

            'ensure this spot cannot be clicked again
            notClicked(2, 2, 2, 1) = False

        End If
    End Sub

    Private Sub Tile2222_Click(sender As Object, e As EventArgs) Handles tile2222.Click


        If notClicked(2, 2, 2, 2) And (clickKey = "2-2" Or clickKey = "") Then
            'change boards & check wins
            TileClick(tile2222, game22, 2, 2, gameLabel22, 2, 2)

            'redirect to proper game
            ChangeKey(2, 2)

            'ensure this spot cannot be clicked again
            notClicked(2, 2, 2, 2) = False

        End If
    End Sub
    '============================================================================================================================
End Class
