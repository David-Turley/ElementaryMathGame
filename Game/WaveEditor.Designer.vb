<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaveEditor
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
        Me.rtxtWave = New System.Windows.Forms.RichTextBox()
        Me.btnSaveWave = New System.Windows.Forms.Button()
        Me.nudWave = New System.Windows.Forms.NumericUpDown()
        Me.lblWaveNum = New System.Windows.Forms.Label()
        CType(Me.nudWave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtxtWave
        '
        Me.rtxtWave.Location = New System.Drawing.Point(152, 110)
        Me.rtxtWave.Name = "rtxtWave"
        Me.rtxtWave.Size = New System.Drawing.Size(383, 343)
        Me.rtxtWave.TabIndex = 0
        Me.rtxtWave.Text = ""
        '
        'btnSaveWave
        '
        Me.btnSaveWave.Location = New System.Drawing.Point(235, 485)
        Me.btnSaveWave.Name = "btnSaveWave"
        Me.btnSaveWave.Size = New System.Drawing.Size(220, 35)
        Me.btnSaveWave.TabIndex = 1
        Me.btnSaveWave.Text = "Save Wave"
        Me.btnSaveWave.UseVisualStyleBackColor = True
        '
        'nudWave
        '
        Me.nudWave.Location = New System.Drawing.Point(300, 459)
        Me.nudWave.Name = "nudWave"
        Me.nudWave.Size = New System.Drawing.Size(120, 20)
        Me.nudWave.TabIndex = 2
        '
        'lblWaveNum
        '
        Me.lblWaveNum.AutoSize = True
        Me.lblWaveNum.Location = New System.Drawing.Point(255, 461)
        Me.lblWaveNum.Name = "lblWaveNum"
        Me.lblWaveNum.Size = New System.Drawing.Size(39, 13)
        Me.lblWaveNum.TabIndex = 3
        Me.lblWaveNum.Text = "Wave:"
        '
        'WaveEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 605)
        Me.Controls.Add(Me.lblWaveNum)
        Me.Controls.Add(Me.nudWave)
        Me.Controls.Add(Me.btnSaveWave)
        Me.Controls.Add(Me.rtxtWave)
        Me.Name = "WaveEditor"
        Me.Text = "WaveEditor"
        CType(Me.nudWave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtxtWave As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSaveWave As System.Windows.Forms.Button
    Friend WithEvents nudWave As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblWaveNum As System.Windows.Forms.Label
End Class
