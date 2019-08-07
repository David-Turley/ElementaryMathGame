'David Turley
'3/28/13
'StartScreen
'Not called; main class
'Acts as start menu

Public Class StartScreen
    'Starts game
    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        frmGame.Show()
        Me.Hide()
    End Sub

    'Ends program
    Private Sub StartScreen_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub btnInstructions_Click(sender As System.Object, e As System.EventArgs) Handles btnInstructions.Click
        Instructions.Show()
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Try
            Me.Close()
        Catch ex As Exception
            End
        End Try

    End Sub
End Class