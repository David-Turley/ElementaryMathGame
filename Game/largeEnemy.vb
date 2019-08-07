Public Class largeEnemy
    Inherits Enemy

    Private LargeEnemySprite As Image

    'Moves towards the tower
    Public Overrides Function Attack() As Byte
        Left = Move("Left")
        SetSprite(LargeEnemySprite)
        Pos = New Point(Left, Top)
        Return 0
    End Function

    'Creates new standard enemy
    Public Sub New()
        LargeEnemySprite = Image.FromFile(Application.StartupPath & "\PicSource\largeGoblin.png")
        Speed = 0.4
        Left = 900
        Top = 640
        Width = 60
        Height = 60
        Wealth = 0.08
        Power = 15
        Health = 4
        Pos = New Point(Left, Top)
        SetSprite(LargeEnemySprite)
    End Sub
End Class
