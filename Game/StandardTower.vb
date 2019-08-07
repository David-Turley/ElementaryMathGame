'David Turley
'3/28/13
'StandardTower
'Game
'A tower type

Public Class StandardTower
    Inherits Tower

    Private StandardTowerSprite As Image

    'Creates new standard tower
    Public Sub New()
        StandardTowerSprite = Image.FromFile(Application.StartupPath & "\PicSource\StandardTower.png")
        Width = 50
        Height = 200
        Left = 30
        Top = 500
        Health = 100
        SetSprite(StandardTowerSprite)
    End Sub
End Class
