<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachineDisplay
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
        Me.TiClk = New System.Windows.Forms.Timer(Me.components)
        Me.LbDate = New System.Windows.Forms.Label()
        Me.LbClk = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TiClk
        '
        Me.TiClk.Enabled = True
        Me.TiClk.Interval = 1000
        '
        'LbDate
        '
        Me.LbDate.AutoSize = True
        Me.LbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDate.ForeColor = System.Drawing.Color.GhostWhite
        Me.LbDate.Location = New System.Drawing.Point(22, 794)
        Me.LbDate.Name = "LbDate"
        Me.LbDate.Size = New System.Drawing.Size(114, 25)
        Me.LbDate.TabIndex = 1444
        Me.LbDate.Text = "xx/xx/xxxx"
        '
        'LbClk
        '
        Me.LbClk.AutoSize = True
        Me.LbClk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClk.ForeColor = System.Drawing.Color.GhostWhite
        Me.LbClk.Location = New System.Drawing.Point(22, 819)
        Me.LbClk.Name = "LbClk"
        Me.LbClk.Size = New System.Drawing.Size(130, 25)
        Me.LbClk.TabIndex = 1443
        Me.LbClk.Text = "xx:xx:xx PM"
        '
        'MachineDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1782, 853)
        Me.Controls.Add(Me.LbDate)
        Me.Controls.Add(Me.LbClk)
        Me.Name = "MachineDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MachineDisplay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TiClk As Timer
    Friend WithEvents LbDate As Label
    Friend WithEvents LbClk As Label
End Class
