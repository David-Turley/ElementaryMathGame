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

    Public GraphicsArray1 As New ArrayList(50)
    Private GraphicsArray2 As New ArrayList(50)
    Public SnowballArray As New ArrayList(18)
    Public WaveArray As New ArrayList(50)

    Private WithEvents test As StandardEnemy
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

        Debug.Print(CrosshairX)
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

            For Each Z As StandardEnemy In GraphicsArray1.ToArray
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

    Public Function AttackTower() As Byte
        If StandardTower.Health > 0 Then
            StandardTower.Health = StandardTower.Health - 1
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

    'Collision detection
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

    Public Function ThrowItem() As Byte
        While ProjectilesToRender > 0 And ProjectilesOnScreen < 10
            proj = New Projectile
            proj.Speed = Me.power / 10
            proj.Force = Me.power
            proj.Angle = Me.angle
            proj.Calc()
            SnowballArray.Add(proj)
            'ProjectilesOnScreen = SnowballArray.Count
            ProjectilesToRender = ProjectilesToRender - 1
        End While

        Return 0
    End Function

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

    Private Sub frmGame_Click(sender As Object, e As System.EventArgs) Handles Me.Click

    End Sub

    Private Sub frmGame_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If UseNormalClose = True Then
            Try
                GraphicsThread.Resume()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            Running = False

            If GraphicsThread.IsAlive Then
                Console.WriteLine("ending")
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
        tmrDelay1.Stop()
        tmrUpdate.Stop()
    End Sub

    Private Sub frmGame_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.P 'Pauses game
                PauseGame()
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
            Case Keys.M 'Spawns monster
                If MonstersOnScreen < 50 Then

                    MonstersToRender = MonstersToRender + 1
                    Console.WriteLine("Monsters on screen: " & MonstersOnScreen)
                End If
            Case Keys.D5
                If MonstersOnScreen < 50 Then
                    For i As Integer = 1 To 5 Step +1
                        MonstersToRender = MonstersToRender + 1
                    Next
                End If
            Case Keys.S
                Store.Show()
            Case Keys.K
                StandardTower.Health = 1
                AttackTower()
            Case Keys.F12
                CConsole.Show()
        End Select

    End Sub

    Private Sub frmGame_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Set form size to 1024 width by 768 height
        SetScreenSize(1024, 768)

        'Makes scales for picture sizes
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

        If GraphicsThread.IsAlive = True Then

        Else
            GraphicsThread.Start()
        End If

        tmrUpdate.Start()

        Aim()

    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As System.EventArgs) Handles tmrUpdate.Tick
        'Timer update
        If Running = True Then

            While MonstersToRender > 0 And MonstersOnScreen < 50
                test = New StandardEnemy
                GraphicsArray1.Add(test)
                MonstersOnScreen = GraphicsArray1.Count
                MonstersToRender = MonstersToRender - 1
            End While

            For Each Z As StandardEnemy In GraphicsArray1.ToArray
                Z.Attack()
                If Collide(StandardTower, Z) = True Then
                    GraphicsArray1.Remove(Z)
                    AttackTower()
                End If
                MonstersOnScreen = GraphicsArray1.Count
            Next
        End If

        For Each z As Projectile In SnowballArray.ToArray
            z.MoveProjectile()
            Dim testnum As Integer = z.MoveProjectile()
            If testnum = 1 Then
                SnowballArray.Remove(z)
            End If
            ProjectilesOnScreen = SnowballArray.Count
        Next

        For Each z As StandardEnemy In GraphicsArray1.ToArray
            For Each p As Projectile In SnowballArray.ToArray
                If Collide(z, p) Then
                    SnowballArray.Remove(p)
                    GraphicsArray1.Remove(z)
                End If
            Next
        Next

    End Sub

    Private Sub tmrDelay1_Tick(sender As Object, e As System.EventArgs) Handles tmrDelay1.Tick
        CanThrow = True
        Console.WriteLine("Reloaded!")
        tmrDelay1.Stop()
    End Sub
End Class