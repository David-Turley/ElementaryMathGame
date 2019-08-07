'David Turley
'3/28/13
'Store
'WaveReward
'Allows the purchase of in-game items

Public Class Store

    Dim fs1Price As Integer = 11
    Dim fs2Price As Integer = 40
    Dim fs3Price As Integer = 88
    Dim bp1Price As Integer = 5
    Dim bp2Price As Integer = 14
    Dim bp3Price As Integer = 30

    'Starts the next wave
    Public Function NextWave() As Byte
        frmGame.CurrentWave = frmGame.CurrentWave + 1
        frmGame.LoadWave()
        frmGame.WaveRewardB = False
        Return 0
    End Function

    'Runs the NextWave function and then closes the form
    Private Sub btnNextWave_Click(sender As System.Object, e As System.EventArgs) Handles btnNextWave.Click
        NextWave()
        Me.Close()
    End Sub

    Private Sub Store_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lblMoney.Text = "Your money: " & frmGame.totalMoney

        For Each z As RadioButton In frmGame.EquipmentArray
            lbItems.Items.Add(z.Text)
        Next

        btnBuy.Select()
    End Sub

    Private Sub btnBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuy.Click
        For Each z As RadioButton In gbStore.Controls
            If z.Checked = True Then
                For Each i As RadioButton In frmGame.EquipmentArray
                    If i.Name = z.Name Then
                        Exit Sub
                    End If
                Next
                Select Case z.Name
                    Case "rbFS1"
                        If frmGame.totalMoney >= fs1Price Then
                            frmGame.EquipmentArray.Add(z)
                            lbItems.Items.Add(z.Text)
                            lbItems.SelectedItem = z.Text
                            frmGame.totalMoney = frmGame.totalMoney - fs1Price
                        End If
                    Case "rbFS2"
                        If frmGame.totalMoney >= fs2Price Then
                            frmGame.EquipmentArray.Add(z)
                            lbItems.Items.Add(z.Text)
                            lbItems.SelectedItem = z.Text
                            frmGame.totalMoney = frmGame.totalMoney - fs2Price
                        End If
                    Case "rbFS3"
                        If frmGame.totalMoney >= fs3Price Then
                            frmGame.EquipmentArray.Add(z)
                            lbItems.Items.Add(z.Text)
                            lbItems.SelectedItem = z.Text
                            frmGame.totalMoney = frmGame.totalMoney - fs3Price
                        End If
                    Case "rbBP1"
                        If frmGame.totalMoney >= bp1Price Then
                            frmGame.EquipmentArray.Add(z)
                            lbItems.Items.Add(z.Text)
                            lbItems.SelectedItem = z.Text
                            frmGame.totalMoney = frmGame.totalMoney - bp1Price
                        End If
                    Case "rbBP2"
                        If frmGame.totalMoney >= bp2Price Then
                            frmGame.EquipmentArray.Add(z)
                            lbItems.Items.Add(z.Text)
                            lbItems.SelectedItem = z.Text
                            frmGame.totalMoney = frmGame.totalMoney - bp2Price
                        End If
                    Case "rbBP3"
                        If frmGame.totalMoney >= bp3Price Then
                            frmGame.EquipmentArray.Add(z)
                            lbItems.Items.Add(z.Text)
                            lbItems.SelectedItem = z.Text
                            frmGame.totalMoney = frmGame.totalMoney - bp3Price
                        End If
                End Select
                lblMoney.Text = "Your money: " & frmGame.totalMoney
            End If
        Next

    End Sub

    'Private Sub btnSell_Click(sender As System.Object, e As System.EventArgs)
    '    If lbItems.SelectedItem <> Nothing Then
    '        frmGame.EquipmentArray.Remove(lbItems.SelectedItem)
    '        lbItems.Items.Remove(lbItems.SelectedItem)
    '    End If
    'End Sub

    Private Sub rbFS1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFS1.CheckedChanged
        rtxtInformation.Text = "This upgrade lets you throw faster" & vbCrLf & vbCrLf & "Cost: " & fs1Price
    End Sub

    Private Sub rbFS2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFS2.CheckedChanged
        rtxtInformation.Text = "This upgrade lets you throw much faster" & vbCrLf & vbCrLf & "Cost: " & fs2Price
    End Sub

    Private Sub rbFS3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbFS3.CheckedChanged
        rtxtInformation.Text = "This upgrade lets you throw very fast" & vbCrLf & vbCrLf & "Cost: " & fs3Price
    End Sub

    Private Sub rbBP1_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbBP1.CheckedChanged
        rtxtInformation.Text = "This upgrade makes your projectile twice as big" & vbCrLf & vbCrLf & "Cost: " & bp1Price
    End Sub

    Private Sub rbBP2_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbBP2.CheckedChanged
        rtxtInformation.Text = "This upgrade makes your projectile three times as big" & vbCrLf & vbCrLf & "Cost: " & bp2Price
    End Sub

    Private Sub rbBP3_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbBP3.CheckedChanged
        rtxtInformation.Text = "This upgrade makes your projectile four times as big" & vbCrLf & vbCrLf & "Cost: " & bp3Price
    End Sub
End Class