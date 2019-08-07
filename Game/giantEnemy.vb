Public Class giantEnemy
    Inherits Enemy

    Private GiantEnemySprite As Image

    'Moves towards the tower
    Public Overrides Function Attack() As Byte
        Left = Move("Left")
        SetSprite(GiantEnemySprite)
        Pos = New Point(Left, Top)
        Return 0
    End Function

    'Creates new standard enemy
    Public Sub New()
        GiantEnemySprite = Image.FromFile(Application.StartupPath & "\PicSource\giantGoblin.png")
        Speed = 0.25
        Left = 900
        Top = 620
        Width = 80
        Height = 80
        Wealth = 0.14
        Power = 20
        Health = 10
        Pos = New Point(Left, Top)
        SetSprite(GiantEnemySprite)
    End Sub
End Class
