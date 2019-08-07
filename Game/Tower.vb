'David Turley
'3/28/13
'Tower
'Not called; inherited
'Tower superclass

Public MustInherit Class Tower

    Public Left As Decimal
    Public Top As Decimal
    Public Width As Decimal
    Public Height As Decimal
    Public Health As Decimal

    Protected Sprite As Object


    'Sets the graphic
    Protected Overridable Function SetSprite(SetTo As Object) As Integer
        Sprite = SetTo
        Return 0
    End Function

    'Gets the graphic
    Public Function GetSprite() As Object

        Return Sprite
    End Function
End Class
