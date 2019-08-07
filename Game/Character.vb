'David Turley
'3/28/13
'Character
'Not called; inherited
'Character superclass

Public MustInherit Class Character

    Public Left As Decimal = 50
    Public Top As Decimal = 478
    Public Width As Decimal
    Public Height As Decimal

    Protected Strength As Decimal
    Protected Speed As Decimal

    Protected sprite As Object

    'Sets the graphic
    Protected Overridable Function SetSprite(SetTo As Object) As Integer
        sprite = SetTo
        Return 0
    End Function

    'Gets the graphic
    Public Function GetSprite() As Object

        Return sprite
    End Function
End Class
