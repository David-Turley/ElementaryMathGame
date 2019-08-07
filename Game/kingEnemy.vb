Public Class kingEnemy
    Inherits Enemy

    Private KingEnemySprite As Image

    'Moves towards the tower
    Public Overrides Function Attack() As Byte
        Left = Move("Left")
        SetSprite(KingEnemySprite)
        Pos = New Point(Left, Top)
        Return 0
    End Function

    'Creates new standard enemy
    Public Sub New()
        KingEnemySprite = Image.FromFile(Application.StartupPath & "\PicSource\kingGoblin.png")
        Speed = 0.1
        Left = 900
        Top = 575
        Width = 125
        Height = 125
        Wealth = 0.5
        Power = 100
        Health = 25
        Pos = New Point(Left, Top)
        SetSprite(KingEnemySprite)
    End Sub
End Class
