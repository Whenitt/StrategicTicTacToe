<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.singlePlayerButton = New System.Windows.Forms.Button()
        Me.twoPlayerButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.mediumButton = New System.Windows.Forms.Button()
        Me.easyButton = New System.Windows.Forms.Button()
        Me.hardButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(882, 602)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Strategic Tic-Tac-Toe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'singlePlayerButton
        '
        Me.singlePlayerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.singlePlayerButton.Location = New System.Drawing.Point(310, 637)
        Me.singlePlayerButton.Name = "singlePlayerButton"
        Me.singlePlayerButton.Size = New System.Drawing.Size(410, 130)
        Me.singlePlayerButton.TabIndex = 1
        Me.singlePlayerButton.Text = "Single Player"
        Me.singlePlayerButton.UseVisualStyleBackColor = False
        '
        'twoPlayerButton
        '
        Me.twoPlayerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.twoPlayerButton.Location = New System.Drawing.Point(762, 637)
        Me.twoPlayerButton.Name = "twoPlayerButton"
        Me.twoPlayerButton.Size = New System.Drawing.Size(410, 130)
        Me.twoPlayerButton.TabIndex = 2
        Me.twoPlayerButton.Text = "Two Player"
        Me.twoPlayerButton.UseVisualStyleBackColor = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.SystemColors.Control
        Me.backButton.Location = New System.Drawing.Point(536, 637)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(410, 130)
        Me.backButton.TabIndex = 3
        Me.backButton.Text = "Never Mind"
        Me.backButton.UseVisualStyleBackColor = False
        Me.backButton.Visible = False
        '
        'mediumButton
        '
        Me.mediumButton.BackColor = System.Drawing.SystemColors.Control
        Me.mediumButton.Location = New System.Drawing.Point(604, 773)
        Me.mediumButton.Name = "mediumButton"
        Me.mediumButton.Size = New System.Drawing.Size(274, 130)
        Me.mediumButton.TabIndex = 5
        Me.mediumButton.Text = "Medium"
        Me.mediumButton.UseVisualStyleBackColor = False
        Me.mediumButton.Visible = False
        '
        'easyButton
        '
        Me.easyButton.BackColor = System.Drawing.SystemColors.Control
        Me.easyButton.Location = New System.Drawing.Point(300, 773)
        Me.easyButton.Name = "easyButton"
        Me.easyButton.Size = New System.Drawing.Size(274, 130)
        Me.easyButton.TabIndex = 6
        Me.easyButton.Text = "Easy"
        Me.easyButton.UseVisualStyleBackColor = False
        Me.easyButton.Visible = False
        '
        'hardButton
        '
        Me.hardButton.BackColor = System.Drawing.SystemColors.Control
        Me.hardButton.Location = New System.Drawing.Point(908, 773)
        Me.hardButton.Name = "hardButton"
        Me.hardButton.Size = New System.Drawing.Size(274, 130)
        Me.hardButton.TabIndex = 7
        Me.hardButton.Text = "Hard"
        Me.hardButton.UseVisualStyleBackColor = False
        Me.hardButton.Visible = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(626, 909)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(233, 68)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 989)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.hardButton)
        Me.Controls.Add(Me.easyButton)
        Me.Controls.Add(Me.mediumButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.twoPlayerButton)
        Me.Controls.Add(Me.singlePlayerButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainMenu"
        Me.Text = "Strategic Tic-Tac-Toe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents singlePlayerButton As Button
    Friend WithEvents twoPlayerButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents mediumButton As Button
    Friend WithEvents easyButton As Button
    Friend WithEvents hardButton As Button
    Friend WithEvents exitButton As Button
End Class
