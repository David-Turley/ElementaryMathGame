'David Turley
'3/28/13
'CConsole
'Game
'Provides access for console commands

Imports System.Windows.Forms

Public Class CConsole

    'Ok code
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    'Cancel code
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Handles text that has been entered into the console
    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case LCase(TextBox1.Text)
                Case "wave editor"
                    WaveEditor.Show()
                Case Else
                    MessageBox.Show("Unknown command")
            End Select
            Me.Close()
        End If
    End Sub
End Class
