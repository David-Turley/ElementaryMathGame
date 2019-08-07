'David Turley
'3/28/13
'Game
'StartScreen 
'Tower defence style educational game (teaches currency)

'DJT 2-27 comment improvements
'DJT 2-28 began to implement round rewards
'DJT 3-29 tons of changes

Imports System.Drawing
Imports System.Threading

Public Class frmGame

    'Scale initialization
    Private GameScaleX As Decimal
    Private GameScaleY As Decimal

    Private Running As Boolean = False

    Public GraphicsBuffer As BufferedGraphics
    Dim BufferContext As BufferedGraphicsContext
     
    Dim IsPaused As Boolean = False

    Private GraphicsArray2 As New ArrayList(50)
    Public SnowballArray As New ArrayList(18)
    Public WaveArray As New ArrayList(50)
    Public DelayArray As New ArrayList(50)

    Private WithEvents stdEnemy As StandardEnemy
    Private WithEvents minEnemy As miniEnemy
    Private WithEvents lrgEnemy As largeEnemy
    Private WithEvents gntEnemy As giantEnemy
    Private WithEvents kngEnemy As kingEnemy

    Private WithEvents StandardTower As New StandardTower
    Private WithEvents John As New John
    Private WithEvents proj As New Projectile
    Private WithEvents CalcProj As New Projectile

    Dim GraphicsThread As New Thread(AddressOf RenderGraphics)

    Dim MonstersToRender As Integer
    Dim MonstersOnScreen As Integer

    Dim ProjectilesToRender As Integer
    Dim ProjectilesOnScreen As Integer

    Public CurrentWave As Integer

    Dim UseNormalClose As Boolean

    Dim CrosshairX As Integer = 450

    Dim ArrowPath As String = Application.StartupPath & "\PicSource\Arrow.png"

    Dim inc As Integer = 0

    Public angle As Integer = 45
    Public power As Integer = 25

    Dim AngleString As String = "Angle = " & angle
    Dim PowerString As String = "Power = " & power

    Private CanThrow As Boolean = True

    Public WaveRewardB As Boolean = False

    Dim delay As Integer = 100

    'money awarded at end of round
    Public roundEarnings As Decimal

    'money
    Public totalMoney As Decimal

    'items
    Public EquipmentArray As New ArrayList

    Public projectileW As Integer = 6
    Public projectileH As Integer = 6


    'Sets the size of the form
    Public Function SetScreenSize(x As Integer, y As Integer) As Integer
        Me.Width = x
        Me.Height = y
        Return 0
    End Function

    'Draws a black rectangle the size of the form/ clears the screen
    Public Function ClearScreen() As Byte
        GraphicsBuffer.Graphics.FillRectangle(Brushes.LightBlue, Me.DisplayRectangle)
        Return 0
    End Function

    'Aims the projectile prediction
    Public Function Aim() As Byte
        Dim x As Integer
        'CalcProj = New Projectile
        CalcProj = New Projectile
        CalcProj.Speed = Me.power / 10
        CalcProj.Force = Me.power
        CalcProj.Angle = Me.angle
        CalcProj.Calc()
        While x <> 1
            CalcProj.MoveProjectile()
            x = CalcProj.MoveProjectile
            CrosshairX = CalcProj.Left
        End While

        Console.WriteLine(CrosshairX)
        Return 0
    End Function

    'Renders graphics to the screen
    Private Function RenderGraphics() As Byte

        While Running = True
            BufferContext = BufferedGraphicsManager.Current

            GraphicsBuffer = BufferContext.Allocate(Me.CreateGraphics, Me.DisplayRectangle)

            'clears the screen
            ClearScreen()

            GraphicsBuffer.Graphics.DrawImage(StandardTower.GetSprite, StandardTower.Left, StandardTower.Top, StandardTower.Width, StandardTower.Height)

            GraphicsBuffer.Graphics.DrawImage(John.GetSprite, John.Left, John.Top, John.Width, John.Height)

            GraphicsBuffer.Graphics.DrawLine(Pens.Black, 0, 700, Me.Width, 700)

            GraphicsBuffer.Graphics.DrawImage(Image.FromFile(Application.StartupPath & "\PicSource\Target.png"), CrosshairX, 700, 10, 10)

            'wave
            For Each Z As Enemy In WaveArray.ToArray
                GraphicsBuffer.Graphics.DrawImage(Z.GetSprite, Z.Left, Z.Top, Z.Width, Z.Height)
            Next

            For Each Z As Projectile In SnowballArray.ToArray
                GraphicsBuffer.Graphics.DrawImage(Z.GetSprite, Z.Left, Z.Top, Z.Width, Z.Height)
            Next

            GraphicsBuffer.Graphics.DrawString(AngleString, Font(), Brushes.Black, New Point(20, 20))

            GraphicsBuffer.Graphics.DrawString(PowerString, Font(), Brushes.Black, New Point(20, 40))

            GraphicsBuffer.Graphics.DrawString("Health: " & StandardTower.Health, Font(), Brushes.Black, New Point(20, 80))

            GraphicsBuffer.Graphics.DrawString("Current wave: " & CurrentWave, Font(), Brushes.Black, New Point(20, 100))

            GraphicsBuffer.Render()

            GraphicsBuffer.Render(Me.CreateGraphics)

            GraphicsBuffer.Dispose()
        End While
        Return 0
    End Function

    'Damages the tower
    Public Function AttackTower(e As Enemy) As Byte
        If StandardTower.Health > 0 Then
            StandardTower.Health = StandardTower.Health - e.Power

            If StandardTower.Health <= 0 Then
                UseNormalClose = False
                PauseGame()
                MessageBox.Show("Game over")
                StartScreen.Show()
                Me.Close()
            End If

        ElseIf UseNormalClose = True Then
            UseNormalClose = False
            PauseGame()
            MessageBox.Show("Game over")
            StartScreen.Show()
            Me.Close()
        Else

        End If

        Return 0
    End Function

    'Returns true or false based on collision status
    Public Function Collide(x As Object, y As Object) As Boolean
        If x.Left < y.Left And x.Left + x.Width > y.Left Then
            If x.Top < y.Top And x.Top + x.Height > y.Top Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    'Initializes a projectile and adds it to the projectile array
    Public Function ThrowItem() As Byte
        While ProjectilesToRender > 0 And ProjectilesOnScreen < 10
            proj = New Projectile
            proj.Speed = Me.power / 10
            proj.Force = Me.power
            proj.Angle = Me.angle
            proj.Width = projectileW
            proj.Height = projectileH
            proj.Calc()
            SnowballArray.Add(proj)
            'ProjectilesOnScreen = SnowballArray.Count
            ProjectilesToRender = ProjectilesToRender - 1
        End While

        Return 0
    End Function

    'Pauses the game
    Public Function PauseGame() As Byte
        If IsPaused = False Then
            Running = False
            IsPaused = True
            Try
                GraphicsThread.Suspend()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        Else
            Running = True
            IsPaused = False

            Try
                GraphicsThread.Resume()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If
        Return 0
    End Function

    'Adds an enemy to the wave array
    Public Function AddToWave(x) As Object
        If DelayArray.Count < 50 Then
            DelayArray.Add(x)
        Else
            Console.WriteLine("Additional enemies could not be added")
        End If
        Return 0
    End Function

    'Adds enemies to the wave
    Public Function LoadWave() As Byte
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Waves\Wave" & CurrentWave & ".txt") Then
            Dim RenderString As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Waves\Wave" & CurrentWave & ".txt")
            For Each c As Char In RenderString
                Select Case c
                    Case "0"
                        AddToWave(delay)
                    Case ("s")
                        stdEnemy = New StandardEnemy
                        AddToWave(stdEnemy)
                    Case "m"
                        minEnemy = New miniEnemy
                        AddToWave(minEnemy)
                    Case "l"
                        lrgEnemy = New largeEnemy
                        AddToWave(lrgEnemy)
                    Case "g"
                        gntEnemy = New giantEnemy
                        AddToWave(gntEnemy)
                    Case "k"
                        kngEnemy = New kingEnemy
                        AddToWave(kngEnemy)
                End Select

            Next
        Else
            MessageBox.Show("You Win!")
            Me.Close()
        End If

        For Each i As RadioButton In EquipmentArray
            Select Case i.Name
                Case "rbFS1"
                    If tmrDelay1.Interval > 1500 Then
                        tmrDelay1.Interval = 1500
                    End If
                    'Console.WriteLine(tmrDelay1.Interval & " rb1")
                Case "rbFS2"
                    If tmrDelay1.Interval > 1000 Then
                        tmrDelay1.Interval = 1000
                    End If
                    'Console.WriteLine(tmrDelay1.Interval & " rb2")
                Case "rbFS3"
                    If tmrDelay1.Interval > 500 Then
                        tmrDelay1.Interval = 500
                    End If
                    'Console.WriteLine(tmrDelay1.Interval & " rb3")
                Case "rbBP1"
                    If projectileH < 12 And projectileW < 12 Then
                        projectileH = 12
                        projectileW = 12
                    End If
                Case "rbBP2"
                    If projectileH < 18 And projectileW < 18 Then
                        projectileH = 18
                        projectileW = 18
                    End If
                Case "rbBP3"
                    If projectileH < 24 And projectileW < 24 Then
                        projectileH = 24
                        projectileW = 24
                    End If
                Case Else

            End Select
        Next

        Return 0
    End Function

    'Attempts to properly close the game
    Private Sub frmGame_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If UseNormalClose = True Then
            Try
                GraphicsThread.Resume()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            Running = False

            If GraphicsThread.IsAlive Then
                Console.WriteLine("ending game")
                End
            Else
                StartScreen.Close()
            End If

        Else
            'PauseGame()
            Try
                GraphicsThread.Abort()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            Running = False

        End If
        tmrSpawnDelay.Stop()
        tmrDelay1.Stop()
        tmrUpdate.Stop()
    End Sub

    Private Sub frmGame_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Determines key pressed
        Select Case e.KeyCode
            'Case Keys.P
            '    PauseGame()
            Case Keys.Up
                If angle > 0 Then
                    angle = angle - 5
                    Aim()
                End If
                AngleString = "Angle = " & angle

            Case Keys.Down
                If angle < 90 Then
                    angle = angle + 5
                    Aim()
                End If
                AngleString = "Angle = " & angle

            Case Keys.Left
                If power > 10 Then
                    power = power - 5
                    Aim()
                End If
                PowerString = "Power = " & power

            Case Keys.Right
                If power < 100 Then
                    power = power + 5
                    Aim()
                End If
                PowerString = "Power = " & power

            Case Keys.Space
                If ProjectilesOnScreen < 9 And CanThrow = True Then
                    ProjectilesToRender = ProjectilesToRender + 1
                    ThrowItem()
                    Console.WriteLine("Reloading...")
                    CanThrow = False
                    tmrDelay1.Start()
                End If
                'Case Keys.D5
                '    If MonstersOnScreen < 50 Then
                '        For i As Integer = 1 To 5 Step +1
                '            MonstersToRender = MonstersToRender + 1
                '        Next
                '    End If
                'Case Keys.S
                '    Store.Show()
                'Case Keys.K
                '    StandardTower.Health = 1
            Case Keys.F12
                CConsole.Show()
        End Select

    End Sub

    Private Sub frmGame_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Set form size to 1024 width by 768 height
        SetScreenSize(1024, 768)

        'Makes scales for picture sizes (not yet implemented)
        GameScaleX = Math.Round(Me.Width / 1024, 2)
        GameScaleY = Math.Round(Me.Height / 768, 2)

        CurrentWave = 1

        UseNormalClose = True

        'Info on scale and form size
        Console.WriteLine("X scale: " & GameScaleX.ToString & " Y Scale: " & GameScaleY.ToString)
        Console.WriteLine("Width: " & Me.Width.ToString & " Height: " & Me.Height.ToString)

        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        Running = True

        'Starts the GraphicsThread
        If GraphicsThread.IsAlive = True Then

        Else
            GraphicsThread.Start()
        End If

        tmrSpawnDelay.Start()

        tmrUpdate.Start()

        Aim()

        LoadWave()

    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As System.EventArgs) Handles tmrUpdate.Tick
        'Timer update
        If Running = True Then
            'wave enemy
            For Each Z As Enemy In WaveArray.ToArray
                Z.Attack()
                MonstersOnScreen = WaveArray.Count
            Next

            'projectile code
            For Each z As Projectile In SnowballArray.ToArray
                z.MoveProjectile()
                Dim testnum As Integer = z.MoveProjectile()
                If testnum = 1 Then
                    SnowballArray.Remove(z)
                End If
                ProjectilesOnScreen = SnowballArray.Count
            Next

            'wave enemy collision
            For Each z As Enemy In WaveArray.ToArray
                For Each p As Projectile In SnowballArray.ToArray
                    If Collide(z, p) Then
                        SnowballArray.Remove(p)
                        z.Health = z.Health - 1
                        If z.Health = 0 Then
                            WaveArray.Remove(z)
                            roundEarnings = roundEarnings + z.Wealth
                        End If
                    End If
                Next
                If Collide(StandardTower, z) = True Then
                    WaveArray.Remove(z)
                    AttackTower(z)
                End If
            Next
        End If

        'wave reward
        If WaveArray.Count = 0 And WaveRewardB = False And DelayArray.Count = 0 Then
            WaveReward.Show()
            WaveRewardB = True
        End If

        If Running = True And tmrSpawnDelay.Enabled = False Then
            Dim i As Integer = 0

            If DelayArray.Count > 0 Then

                If TypeOf DelayArray(i) Is Integer Then
                    tmrSpawnDelay.Start()
                Else
                    WaveArray.Add(DelayArray(i))
                End If

                DelayArray.RemoveAt(i)
                i = i + 1
                'DelayArray.Clear()
            End If
        End If
    End Sub

    'Delay for projectiles
    Private Sub tmrDelay1_Tick(sender As Object, e As System.EventArgs) Handles tmrDelay1.Tick
        CanThrow = True
        Console.WriteLine("Reloaded!")
        tmrDelay1.Stop()
    End Sub

    'Delay for waves
    Private Sub tmrSpawnDelay_Tick(sender As Object, e As System.EventArgs) Handles tmrSpawnDelay.Tick
        Console.WriteLine("test")
        tmrSpawnDelay.Stop()
    End Sub
End Class