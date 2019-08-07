<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaveReward
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.flpQuarters = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpDimes = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpNickels = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpPennies = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDollars = New System.Windows.Forms.TextBox()
        Me.txtCoins = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 315)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(302, 19)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.Text = "Enter the money that you've won this round:"
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(341, 364)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(146, 23)
        Me.OK_Button.TabIndex = 7
        Me.OK_Button.Text = "Enter"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'flpQuarters
        '
        Me.flpQuarters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpQuarters.Location = New System.Drawing.Point(379, 12)
        Me.flpQuarters.Name = "flpQuarters"
        Me.flpQuarters.Size = New System.Drawing.Size(115, 266)
        Me.flpQuarters.TabIndex = 6
        '
        'flpDimes
        '
        Me.flpDimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpDimes.Location = New System.Drawing.Point(258, 12)
        Me.flpDimes.Name = "flpDimes"
        Me.flpDimes.Size = New System.Drawing.Size(115, 266)
        Me.flpDimes.TabIndex = 6
        '
        'flpNickels
        '
        Me.flpNickels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpNickels.Location = New System.Drawing.Point(137, 12)
        Me.flpNickels.Name = "flpNickels"
        Me.flpNickels.Size = New System.Drawing.Size(115, 266)
        Me.flpNickels.TabIndex = 6
        '
        'flpPennies
        '
        Me.flpPennies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpPennies.Location = New System.Drawing.Point(16, 12)
        Me.flpPennies.Name = "flpPennies"
        Me.flpPennies.Size = New System.Drawing.Size(115, 266)
        Me.flpPennies.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pennies"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nickels"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Dimes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(420, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Quarters"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 28)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "."
        '
        'txtDollars
        '
        Me.txtDollars.Location = New System.Drawing.Point(379, 314)
        Me.txtDollars.Name = "txtDollars"
        Me.txtDollars.Size = New System.Drawing.Size(42, 20)
        Me.txtDollars.TabIndex = 13
        Me.txtDollars.Text = "0"
        '
        'txtCoins
        '
        Me.txtCoins.Location = New System.Drawing.Point(423, 314)
        Me.txtCoins.Name = "txtCoins"
        Me.txtCoins.Size = New System.Drawing.Size(42, 20)
        Me.txtCoins.TabIndex = 14
        Me.txtCoins.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(362, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "$"
        '
        'WaveReward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCoins)
        Me.Controls.Add(Me.txtDollars)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.flpNickels)
        Me.Controls.Add(Me.flpDimes)
        Me.Controls.Add(Me.flpQuarters)
        Me.Controls.Add(Me.flpPennies)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.lblInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WaveReward"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WaveReward"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents flpQuarters As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpDimes As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpNickels As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpPennies As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDollars As System.Windows.Forms.TextBox
    Friend WithEvents txtCoins As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
