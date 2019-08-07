<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDelay1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Interval = 1
        '
        'tmrDelay1
        '
        Me.tmrDelay1.Interval = 2000
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 172)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGame"
        Me.Text = "Game"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents tmrDelay1 As System.Windows.Forms.Timer

End Class
