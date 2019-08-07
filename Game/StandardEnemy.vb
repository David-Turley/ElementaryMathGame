'David Turley
'3/28/13
'StandardEnemy
'Game
'Enemy type

Imports System.Drawing
Public Class StandardEnemy
    Inherits Enemy

    Private StandardEnemySprite As Image

    'Moves towards the tower
    Public Overrides Function Attack() As Byte
        Left = Move("Left")
        SetSprite(StandardEnemySprite)
        Pos = New Point(Left, Top)
        Return 0
    End Function

    'Creates new standard enemy
    Public Sub New()
        StandardEnemySprite = Image.FromFile(Application.StartupPath & "\PicSource\goblin.png")
        Speed = 0.75
        Left = 900
        Top = 660
        Width = 40
        Height = 40
        Wealth = 0.02
        Power = 10
        Health = 2
        Pos = New Point(Left, Top)
        SetSprite(StandardEnemySprite)
    End Sub
End Class