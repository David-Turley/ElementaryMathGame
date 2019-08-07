'David Turley
'3/28/13
'WaveEditor
'Game
'Edits waves

Public Class WaveEditor
    Dim WaveNum As Integer

    'Saves the wave that you have created
    Private Sub btnSaveWave_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveWave.Click
        WaveNum = nudWave.Value
        Dim file As System.IO.FileStream
        Try
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Waves\Wave" & WaveNum & ".txt") Then
                file = System.IO.File.Create(Application.StartupPath & "\Waves\Wave" & WaveNum & ".txt")
                file.Close()
            End If
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Waves\Wave" & WaveNum & ".txt", rtxtWave.Text, False)
        Catch ex As Exception

        End Try

    End Sub
End Class