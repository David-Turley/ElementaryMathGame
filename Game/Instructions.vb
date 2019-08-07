Public Class Instructions

    Private Sub btnStore_Click(sender As System.Object, e As System.EventArgs) Handles btnStore.Click
        rtxtInfo.Text = "After each wave you are awarded money based on how many squares you defeated. You can earn a bonus to this amount by correctly counting the amount of money you have earned in that wave." &
            " Once you are in the store you may buy various upgrades to help you defeat the squares. Upgrades with different levels do not stack."

        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
    End Sub
    Private Sub btnEnemies_Click(sender As System.Object, e As System.EventArgs) Handles btnEnemies.Click
        rtxtInfo.Text = "There are 5 types of enemies in this game with different strengths: " & vbCrLf & vbCrLf & "Standard enemies are black squares. They take 2 hits to defeat and move normally." & vbCrLf & vbCrLf &
            "Mini enemies are green squares. They move faster than normal, but only take 1 hit to defeat." & vbCrLf & vbCrLf & "Large enemies are red squares. They take 5 hits to defeat but move slow." & vbCrLf & vbCrLf &
            "Giant enemies are teal squares. Giant enemies take 10 hits to defeat, but move very slowly." & vbCrLf & vbCrLf & "The king enemy is a yellow square. He takes 25 hits to defeat, but moves extremely slowly."

        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
    End Sub
    Private Sub btnControls_Click(sender As System.Object, e As System.EventArgs) Handles btnControls.Click
        rtxtInfo.Text = "Left arrow: Decrease power." & vbCrLf & "Right arrow: Increase power." & vbCrLf & vbCrLf &
            "Down arrow: Decrease angle." & vbCrLf & "Up arrow: Increase angle." & vbCrLf & vbCrLf & "Spacebar: Throw projectile. The projectile will land where the red target is on the ground."

        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
    End Sub
    Private Sub btnObjective_Click(sender As System.Object, e As System.EventArgs) Handles btnObjective.Click
        rtxtInfo.Text = "The goal of this game is to stop the squares from reaching your tower. To stop " &
            "them you must throw squares of your own, using a variety of upgrades to help you."

        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class