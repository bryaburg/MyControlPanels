<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Communications
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
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.commsExit = New AdvancedHMIControls.BasicButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator2 = New AdvancedHMIControls.BasicIndicator()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'commsExit
        '
        Me.commsExit.BackColor = System.Drawing.Color.Blue
        Me.commsExit.ComComponent = Me.EthernetIPforCLXCom1
        Me.commsExit.Font = New System.Drawing.Font("Magneto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commsExit.ForeColor = System.Drawing.Color.GhostWhite
        Me.commsExit.ForeColorAltername = System.Drawing.Color.Black
        Me.commsExit.Highlight = False
        Me.commsExit.HighlightColor = System.Drawing.Color.Green
        Me.commsExit.Location = New System.Drawing.Point(56, 261)
        Me.commsExit.MaximumHoldTime = 3000
        Me.commsExit.MinimumHoldTime = 500
        Me.commsExit.Name = "commsExit"
        Me.commsExit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.commsExit.PLCAddressClick = ""
        Me.commsExit.SelectTextAlternate = False
        Me.commsExit.Size = New System.Drawing.Size(271, 80)
        Me.commsExit.TabIndex = 45
        Me.commsExit.Text = "Exit Communications"
        Me.commsExit.TextAlternate = Nothing
        Me.commsExit.UseVisualStyleBackColor = False
        Me.commsExit.ValueToWrite = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label9.Location = New System.Drawing.Point(71, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(241, 32)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Communications"
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator1.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator1.Location = New System.Drawing.Point(36, 56)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor2 = "WMS_Host1_Connected"
        Me.BasicIndicator1.SelectColor2 = False
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator1.Size = New System.Drawing.Size(314, 67)
        Me.BasicIndicator1.TabIndex = 47
        Me.BasicIndicator1.Text = "Server 1 Online"
        '
        'BasicIndicator2
        '
        Me.BasicIndicator2.Color1 = System.Drawing.Color.DarkGray
        Me.BasicIndicator2.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator2.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator2.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator2.Location = New System.Drawing.Point(34, 143)
        Me.BasicIndicator2.Name = "BasicIndicator2"
        Me.BasicIndicator2.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator2.OutlineWidth = 1
        Me.BasicIndicator2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator2.PLCAddressSelectColor2 = "WMS_Host2_Connected"
        Me.BasicIndicator2.SelectColor2 = False
        Me.BasicIndicator2.SelectColor3 = False
        Me.BasicIndicator2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator2.Size = New System.Drawing.Size(314, 67)
        Me.BasicIndicator2.TabIndex = 48
        Me.BasicIndicator2.Text = "Server 2 Online"
        '
        'Communications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(382, 353)
        Me.Controls.Add(Me.BasicIndicator2)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.commsExit)
        Me.Name = "Communications"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Communications"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents commsExit As AdvancedHMIControls.BasicButton
    Friend WithEvents Label9 As Label
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator2 As AdvancedHMIControls.BasicIndicator
End Class
