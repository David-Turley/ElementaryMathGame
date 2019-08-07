'David Turley
'3/28/13
'John
'Game
'Type of character

Public Class John
    Inherits Character

    Private JohnSprite As Image

    'Creates new character
    Public Sub New()
        JohnSprite = Image.FromFile(Application.StartupPath & "\PicSource\character.png")
        Width = 10
        Height = 30
        SetSprite(JohnSprite)
    End Sub
End Class
