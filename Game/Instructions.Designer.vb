<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pSelect = New System.Windows.Forms.Panel()
        Me.btnStore = New System.Windows.Forms.Button()
        Me.btnEnemies = New System.Windows.Forms.Button()
        Me.btnControls = New System.Windows.Forms.Button()
        Me.btnObjective = New System.Windows.Forms.Button()
        Me.rtxtInfo = New System.Windows.Forms.RichTextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pInfo = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pSelect.SuspendLayout()
        Me.pInfo.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pSelect
        '
        Me.pSelect.Controls.Add(Me.btnStore)
        Me.pSelect.Controls.Add(Me.btnEnemies)
        Me.pSelect.Controls.Add(Me.btnControls)
        Me.pSelect.Controls.Add(Me.btnObjective)
        Me.pSelect.Location = New System.Drawing.Point(13, 474)
        Me.pSelect.Name = "pSelect"
        Me.pSelect.Size = New System.Drawing.Size(700, 105)
        Me.pSelect.TabIndex = 0
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(321, 0)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(100, 50)
        Me.btnStore.TabIndex = 5
        Me.btnStore.Text = "How to use the store"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'btnEnemies
        '
        Me.btnEnemies.Location = New System.Drawing.Point(215, 0)
        Me.btnEnemies.Name = "btnEnemies"
        Me.btnEnemies.Size = New System.Drawing.Size(100, 50)
        Me.btnEnemies.TabIndex = 4
        Me.btnEnemies.Text = "Enemies"
        Me.btnEnemies.UseVisualStyleBackColor = True
        '
        'btnControls
        '
        Me.btnControls.Location = New System.Drawing.Point(109, 0)
        Me.btnControls.Name = "btnControls"
        Me.btnControls.Size = New System.Drawing.Size(100, 50)
        Me.btnControls.TabIndex = 3
        Me.btnControls.Text = "Controls"
        Me.btnControls.UseVisualStyleBackColor = True
        '
        'btnObjective
        '
        Me.btnObjective.Location = New System.Drawing.Point(3, 0)
        Me.btnObjective.Name = "btnObjective"
        Me.btnObjective.Size = New System.Drawing.Size(100, 50)
        Me.btnObjective.TabIndex = 0
        Me.btnObjective.Text = "Objective"
        Me.btnObjective.UseVisualStyleBackColor = True
        '
        'rtxtInfo
        '
        Me.rtxtInfo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtInfo.Location = New System.Drawing.Point(13, 13)
        Me.rtxtInfo.Name = "rtxtInfo"
        Me.rtxtInfo.ReadOnly = True
        Me.rtxtInfo.Size = New System.Drawing.Size(700, 251)
        Me.rtxtInfo.TabIndex = 1
        Me.rtxtInfo.Text = "Click on one of the buttons below to get information, or go back to the main menu" & _
    "."
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(16, 305)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(119, 88)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Back to main menu"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'pInfo
        '
        Me.pInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pInfo.Controls.Add(Me.PictureBox5)
        Me.pInfo.Controls.Add(Me.PictureBox4)
        Me.pInfo.Controls.Add(Me.PictureBox3)
        Me.pInfo.Controls.Add(Me.PictureBox2)
        Me.pInfo.Controls.Add(Me.PictureBox1)
        Me.pInfo.Location = New System.Drawing.Point(172, 271)
        Me.pInfo.Name = "pInfo"
        Me.pInfo.Size = New System.Drawing.Size(541, 197)
        Me.pInfo.TabIndex = 4
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Game.My.Resources.Resources.giantGoblin
        Me.PictureBox5.Location = New System.Drawing.Point(180, 92)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Game.My.Resources.Resources.largeGoblin
        Me.PictureBox4.Location = New System.Drawing.Point(99, 117)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Game.My.Resources.Resources.goblin
        Me.PictureBox3.Location = New System.Drawing.Point(12, 142)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Game.My.Resources.Resources.miniGoblin
        Me.PictureBox2.Location = New System.Drawing.Point(68, 167)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Game.My.Resources.Resources.kingGoblin
        Me.PictureBox1.Location = New System.Drawing.Point(286, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 583)
        Me.Controls.Add(Me.pInfo)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.rtxtInfo)
        Me.Controls.Add(Me.pSelect)
        Me.MinimizeBox = False
        Me.Name = "Instructions"
        Me.Text = "Instructions"
        Me.pSelect.ResumeLayout(False)
        Me.pInfo.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pSelect As System.Windows.Forms.Panel
    Friend WithEvents rtxtInfo As System.Windows.Forms.RichTextBox
    Friend WithEvents btnStore As System.Windows.Forms.Button
    Friend WithEvents btnEnemies As System.Windows.Forms.Button
    Friend WithEvents btnControls As System.Windows.Forms.Button
    Friend WithEvents btnObjective As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents pInfo As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
