'David Turley
'3/28/13
'WaveReward
'Game
'Displays the wave reward and prompts the user for the correct amount

Imports System.Windows.Forms

Public Class WaveReward
    Dim roundTotal As Decimal
    Dim x As Integer

    Dim quarter As Image = Image.FromFile(Application.StartupPath & "\PicSource\quarter.png")
    Dim dime As Image = Image.FromFile(Application.StartupPath & "\PicSource\dime.png")
    Dim nickel As Image = Image.FromFile(Application.StartupPath & "\PicSource\nickel.png")
    Dim penny As Image = Image.FromFile(Application.StartupPath & "\PicSource\penny.png")

    Function calcq() As Integer
        Dim A As Integer = x \ 25
        x = x - (25 * A)
        Return A
    End Function
    Function calcd() As Integer
        Dim A As Integer = x \ 10
        x = x - (10 * A)
        Return A
    End Function
    Function calcn() As Integer
        Dim A As Integer = x \ 5
        x = x - (5 * A)
        Return A
    End Function
    Function calcp() As Integer
        Dim A As Integer = x \ 1
        x = x - (1 * A)
        Return A
    End Function

    'Confirms wave reward
    Private Sub OK_Button_Click(sender As Object, e As System.EventArgs) Handles OK_Button.Click

        Try
            'if player enters correct round total
            If CInt(txtDollars.Text) + (CInt(txtCoins.Text) / 100) = roundTotal Then
                frmGame.totalMoney = frmGame.totalMoney + (roundTotal * 1.25 * 100)
                MessageBox.Show("Correct! You get a 25% bonus to the money you earned this wave.")
            Else
                frmGame.totalMoney = frmGame.totalMoney + (roundTotal * 100)
                MessageBox.Show("Incorrect. You do not get a bonus to the amount of money you earned this wave.")
            End If

            frmGame.roundEarnings = 0
            Me.Close()
            Store.Show()
        Catch ex As Exception
            MessageBox.Show("Your answer could not be read, please make sure you enter dollars in the box on the left, and the remaining cents on the left")
        End Try

    End Sub

    Private Sub WaveReward_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        roundTotal = frmGame.roundEarnings

        x = roundTotal * 100

        Console.WriteLine(x)

        Dim quarterCount As Integer = calcq()
        Dim dimeCount As Integer = calcd()
        Dim nickelCount As Integer = calcn()
        Dim pennyCount As Integer = calcp()

        While quarterCount > 0
            Dim picQuarter As New PictureBox
            picQuarter.Image = quarter
            picQuarter.Size = New Size(25, 25)
            picQuarter.SizeMode = PictureBoxSizeMode.StretchImage

            flpQuarters.Controls.Add(picQuarter)
            quarterCount = quarterCount - 1
        End While

        While dimeCount > 0
            Dim picDime As New PictureBox
            picDime.Image = dime
            picDime.Size = New Size(25, 25)
            picDime.SizeMode = PictureBoxSizeMode.StretchImage

            flpDimes.Controls.Add(picDime)
            dimeCount = dimeCount - 1
        End While

        While nickelCount > 0
            Dim picNickel As New PictureBox
            picNickel.Image = nickel
            picNickel.Size = New Size(25, 25)
            picNickel.SizeMode = PictureBoxSizeMode.StretchImage

            flpNickels.Controls.Add(picNickel)
            nickelCount = nickelCount - 1
        End While

        While pennyCount > 0
            Dim picPenny As New PictureBox
            picPenny.Image = penny
            picPenny.Size = New Size(25, 25)
            picPenny.SizeMode = PictureBoxSizeMode.StretchImage

            flpPennies.Controls.Add(picPenny)
            pennyCount = pennyCount - 1
        End While

        txtCoins.Select()

    End Sub

End Class
