'David Turley
'3/28/13
'Projectile
'Game 
'Character projectile

Public Class Projectile
    Public Width As Decimal
    Public Height As Decimal
    Public Left As Decimal
    Public Top As Decimal
    Public Speed As Integer
    Public Force As Integer
    Public Angle As Integer
    Public Altitude As Integer = 0

    Public Pos As Point

    Protected sprite As Object
    Protected SnowballSprite As Image


    'Sets the graphic
    Protected Overridable Function SetSprite(SetTo As Object) As Integer
        sprite = SetTo
        Return 0
    End Function

    'Gets graphic
    Public Function GetSprite() As Object

        Return sprite
    End Function

    'Calculates projectile motion
    Public Function Calc() As Integer
        Dim x As Integer = 45
        Dim xx As Integer = 0
        If Angle > 45 Then
            While x < Angle
                xx = xx + 1
                x = x + 1
            End While
            Altitude = (Angle + xx)
            Force = (Force - xx)
            xx = 0
        ElseIf Angle = 45 Then
            Altitude = 45
            Force = Force
        Else
            While x > Angle
                xx = xx + 1
                x = x - 1
            End While
            Altitude = (Angle - xx)
            Force = (Force - xx)
            xx = 0
        End If

        Return 0
    End Function

    'Moves the projectile
    Public Function MoveProjectile() As Integer
        If Left > 1000 Then
            Left = 1000
            Return 1
        ElseIf Left < 0 Then
            Left = 0
            Return 1
        Else
            Left = (Left + (Force / 10))
        End If

        Top = (Top - (Altitude / 10))
        Altitude = Altitude - 1
        SetSprite(SnowballSprite)
        Pos = New Point(Left, Top)
        If Top > 700 Then
            Return 1
        End If
        Return 0
    End Function

    'Creates new projectile
    Public Sub New()
        SnowballSprite = Image.FromFile(Application.StartupPath & "\PicSource\snowball.png")
        SetSprite(SnowballSprite)

        Left = 60
        Top = 490
    End Sub
End Class
