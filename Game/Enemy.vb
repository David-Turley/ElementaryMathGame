'David Turley
'3/28/13
'Enemy
'Not called; inherited
'Enemy superclass

Public MustInherit Class Enemy

    Public Health As Integer
    Protected Speed As Decimal
    Public Power As Integer

    Public Left As Decimal
    Public Top As Decimal
    Public Width As Decimal
    Public Height As Decimal
    Protected Pos As Point

    Protected Sprite As Object
    Public Wealth As Decimal

    'Moves the enemy
    Protected Overridable Function Move(Direction As String) As Decimal
        Dim NewPosX As Decimal
        If LCase(Direction).Equals("left") Then
            NewPosX = Left - Speed
        End If
        Return NewPosX
    End Function

    'Moves the enemy
    Public Overridable Function Attack() As Byte

        Return 0
    End Function

    'Sets the graphic
    Protected Overridable Function SetSprite(SetTo As Object) As Byte
        Sprite = SetTo
        Return 0
    End Function

    'Gets the graphic
    Public Function GetSprite() As Object

        Return Sprite
    End Function

    'Gets the position (not used)
    Public Function GetPosition() As Point

        Return Pos
    End Function
End Class