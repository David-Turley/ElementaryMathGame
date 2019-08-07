<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScreen
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(163, 45)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(102, 64)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(163, 171)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(102, 64)
        Me.btnInstructions.TabIndex = 1
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(163, 294)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(102, 64)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 393)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "StartScreen"
        Me.Text = "StartScreen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
End Class
