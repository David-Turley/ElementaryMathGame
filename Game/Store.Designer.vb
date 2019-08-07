<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Store
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
        Me.btnNextWave = New System.Windows.Forms.Button()
        Me.gbStore = New System.Windows.Forms.GroupBox()
        Me.rbBP3 = New System.Windows.Forms.RadioButton()
        Me.rbBP2 = New System.Windows.Forms.RadioButton()
        Me.rbBP1 = New System.Windows.Forms.RadioButton()
        Me.rbFS3 = New System.Windows.Forms.RadioButton()
        Me.rbFS2 = New System.Windows.Forms.RadioButton()
        Me.rbFS1 = New System.Windows.Forms.RadioButton()
        Me.pInformation = New System.Windows.Forms.Panel()
        Me.lblPlayerItems = New System.Windows.Forms.Label()
        Me.lbItems = New System.Windows.Forms.ListBox()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.rtxtInformation = New System.Windows.Forms.RichTextBox()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.pPurchase = New System.Windows.Forms.Panel()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.gbStore.SuspendLayout()
        Me.pInformation.SuspendLayout()
        Me.pPurchase.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNextWave
        '
        Me.btnNextWave.Location = New System.Drawing.Point(334, 557)
        Me.btnNextWave.Name = "btnNextWave"
        Me.btnNextWave.Size = New System.Drawing.Size(119, 52)
        Me.btnNextWave.TabIndex = 0
        Me.btnNextWave.Text = "Next Wave"
        Me.btnNextWave.UseVisualStyleBackColor = True
        '
        'gbStore
        '
        Me.gbStore.Controls.Add(Me.rbBP3)
        Me.gbStore.Controls.Add(Me.rbBP2)
        Me.gbStore.Controls.Add(Me.rbBP1)
        Me.gbStore.Controls.Add(Me.rbFS3)
        Me.gbStore.Controls.Add(Me.rbFS2)
        Me.gbStore.Controls.Add(Me.rbFS1)
        Me.gbStore.Location = New System.Drawing.Point(12, 40)
        Me.gbStore.Name = "gbStore"
        Me.gbStore.Size = New System.Drawing.Size(570, 511)
        Me.gbStore.TabIndex = 1
        Me.gbStore.TabStop = False
        Me.gbStore.Text = "Store"
        '
        'rbBP3
        '
        Me.rbBP3.AutoSize = True
        Me.rbBP3.Location = New System.Drawing.Point(31, 231)
        Me.rbBP3.Name = "rbBP3"
        Me.rbBP3.Size = New System.Drawing.Size(114, 17)
        Me.rbBP3.TabIndex = 10
        Me.rbBP3.TabStop = True
        Me.rbBP3.Text = "Bigger projectiles 3"
        Me.rbBP3.UseVisualStyleBackColor = True
        '
        'rbBP2
        '
        Me.rbBP2.AutoSize = True
        Me.rbBP2.Location = New System.Drawing.Point(31, 207)
        Me.rbBP2.Name = "rbBP2"
        Me.rbBP2.Size = New System.Drawing.Size(114, 17)
        Me.rbBP2.TabIndex = 9
        Me.rbBP2.TabStop = True
        Me.rbBP2.Text = "Bigger projectiles 2"
        Me.rbBP2.UseVisualStyleBackColor = True
        '
        'rbBP1
        '
        Me.rbBP1.AutoSize = True
        Me.rbBP1.Location = New System.Drawing.Point(31, 183)
        Me.rbBP1.Name = "rbBP1"
        Me.rbBP1.Size = New System.Drawing.Size(114, 17)
        Me.rbBP1.TabIndex = 8
        Me.rbBP1.TabStop = True
        Me.rbBP1.Text = "Bigger projectiles 1"
        Me.rbBP1.UseVisualStyleBackColor = True
        '
        'rbFS3
        '
        Me.rbFS3.AutoSize = True
        Me.rbFS3.Location = New System.Drawing.Point(31, 129)
        Me.rbFS3.Name = "rbFS3"
        Me.rbFS3.Size = New System.Drawing.Size(106, 17)
        Me.rbFS3.TabIndex = 7
        Me.rbFS3.Text = "Faster throwing 3"
        Me.rbFS3.UseVisualStyleBackColor = True
        '
        'rbFS2
        '
        Me.rbFS2.AutoSize = True
        Me.rbFS2.Location = New System.Drawing.Point(31, 105)
        Me.rbFS2.Name = "rbFS2"
        Me.rbFS2.Size = New System.Drawing.Size(106, 17)
        Me.rbFS2.TabIndex = 6
        Me.rbFS2.Text = "Faster throwing 2"
        Me.rbFS2.UseVisualStyleBackColor = True
        '
        'rbFS1
        '
        Me.rbFS1.AutoSize = True
        Me.rbFS1.Checked = True
        Me.rbFS1.Location = New System.Drawing.Point(31, 81)
        Me.rbFS1.Name = "rbFS1"
        Me.rbFS1.Size = New System.Drawing.Size(106, 17)
        Me.rbFS1.TabIndex = 5
        Me.rbFS1.TabStop = True
        Me.rbFS1.Text = "Faster throwing 1"
        Me.rbFS1.UseVisualStyleBackColor = True
        '
        'pInformation
        '
        Me.pInformation.Controls.Add(Me.lblPlayerItems)
        Me.pInformation.Controls.Add(Me.lbItems)
        Me.pInformation.Controls.Add(Me.lblMoney)
        Me.pInformation.Controls.Add(Me.rtxtInformation)
        Me.pInformation.Controls.Add(Me.lblInformation)
        Me.pInformation.Location = New System.Drawing.Point(628, 52)
        Me.pInformation.Name = "pInformation"
        Me.pInformation.Size = New System.Drawing.Size(147, 365)
        Me.pInformation.TabIndex = 4
        '
        'lblPlayerItems
        '
        Me.lblPlayerItems.AutoSize = True
        Me.lblPlayerItems.Location = New System.Drawing.Point(4, 225)
        Me.lblPlayerItems.Name = "lblPlayerItems"
        Me.lblPlayerItems.Size = New System.Drawing.Size(62, 13)
        Me.lblPlayerItems.TabIndex = 6
        Me.lblPlayerItems.Text = "Your items: "
        '
        'lbItems
        '
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.Location = New System.Drawing.Point(7, 241)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(136, 121)
        Me.lbItems.TabIndex = 5
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(4, 32)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(66, 13)
        Me.lblMoney.TabIndex = 4
        Me.lblMoney.Text = "Your money:"
        '
        'rtxtInformation
        '
        Me.rtxtInformation.Location = New System.Drawing.Point(4, 48)
        Me.rtxtInformation.Name = "rtxtInformation"
        Me.rtxtInformation.ReadOnly = True
        Me.rtxtInformation.Size = New System.Drawing.Size(140, 168)
        Me.rtxtInformation.TabIndex = 1
        Me.rtxtInformation.Text = "This upgrade lets you throw faster" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Cost: 11"
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Location = New System.Drawing.Point(42, 2)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(59, 13)
        Me.lblInformation.TabIndex = 2
        Me.lblInformation.Text = "Information"
        '
        'pPurchase
        '
        Me.pPurchase.Controls.Add(Me.btnBuy)
        Me.pPurchase.Location = New System.Drawing.Point(628, 423)
        Me.pPurchase.Name = "pPurchase"
        Me.pPurchase.Size = New System.Drawing.Size(143, 56)
        Me.pPurchase.TabIndex = 0
        '
        'btnBuy
        '
        Me.btnBuy.Location = New System.Drawing.Point(3, 3)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(137, 47)
        Me.btnBuy.TabIndex = 0
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'Store
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 621)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbStore)
        Me.Controls.Add(Me.btnNextWave)
        Me.Controls.Add(Me.pPurchase)
        Me.Controls.Add(Me.pInformation)
        Me.MaximizeBox = False
        Me.Name = "Store"
        Me.Text = "Store"
        Me.gbStore.ResumeLayout(False)
        Me.gbStore.PerformLayout()
        Me.pInformation.ResumeLayout(False)
        Me.pInformation.PerformLayout()
        Me.pPurchase.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNextWave As System.Windows.Forms.Button
    Friend WithEvents gbStore As System.Windows.Forms.GroupBox
    Friend WithEvents pPurchase As System.Windows.Forms.Panel
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents rtxtInformation As System.Windows.Forms.RichTextBox
    Friend WithEvents pInformation As System.Windows.Forms.Panel
    Friend WithEvents rbFS3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFS2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFS1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents lblPlayerItems As System.Windows.Forms.Label
    Friend WithEvents lbItems As System.Windows.Forms.ListBox
    Friend WithEvents rbBP3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBP2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBP1 As System.Windows.Forms.RadioButton
End Class
