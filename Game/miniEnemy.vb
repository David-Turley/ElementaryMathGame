Public Class miniEnemy
    Inherits Enemy

    Private MiniEnemySpriteite As Image

    'Moves towards the tower
    Public Overrides Function Attack() As Byte
        Left = Move("Left")
        SetSprite(MiniEnemySpriteite)
        Pos = New Point(Left, Top)
        Return 0
    End Function

    'Creates new standard enemy
    Public Sub New()
        MiniEnemySpriteite = Image.FromFile(Application.StartupPath & "\PicSource\miniGoblin.png")
        Speed = 1.25
        Left = 900
        Top = 670
        Width = 30
        Height = 30
        Wealth = 0.05
        Power = 5
        Health = 1
        Pos = New Point(Left, Top)
        SetSprite(MiniEnemySpriteite)
    End Sub
End Class
