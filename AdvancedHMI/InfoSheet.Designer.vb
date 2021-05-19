<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoSheet))
        Me.InfoClose = New AdvancedHMIControls.BasicButton()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.vb01305 = New System.Windows.Forms.PictureBox()
        Me.vb01405 = New System.Windows.Forms.PictureBox()
        Me.vb01505 = New System.Windows.Forms.PictureBox()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vb01305, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vb01405, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vb01505, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoClose
        '
        Me.InfoClose.BackColor = System.Drawing.Color.Blue
        Me.InfoClose.ComComponent = Me.EthernetIPforCLXCom1
        Me.InfoClose.Font = New System.Drawing.Font("Magneto", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoClose.ForeColor = System.Drawing.Color.GhostWhite
        Me.InfoClose.ForeColorAltername = System.Drawing.Color.Black
        Me.InfoClose.Highlight = False
        Me.InfoClose.HighlightColor = System.Drawing.Color.Green
        Me.InfoClose.Location = New System.Drawing.Point(1135, 725)
        Me.InfoClose.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.InfoClose.MaximumHoldTime = 3000
        Me.InfoClose.MinimumHoldTime = 500
        Me.InfoClose.Name = "InfoClose"
        Me.InfoClose.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.InfoClose.PLCAddressClick = ""
        Me.InfoClose.SelectTextAlternate = False
        Me.InfoClose.Size = New System.Drawing.Size(186, 110)
        Me.InfoClose.TabIndex = 2090
        Me.InfoClose.Text = "Close Information"
        Me.InfoClose.TextAlternate = Nothing
        Me.InfoClose.UseVisualStyleBackColor = False
        Me.InfoClose.ValueToWrite = 1
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
        'vb01305
        '
        Me.vb01305.Image = CType(resources.GetObject("vb01305.Image"), System.Drawing.Image)
        Me.vb01305.Location = New System.Drawing.Point(12, 12)
        Me.vb01305.Name = "vb01305"
        Me.vb01305.Size = New System.Drawing.Size(952, 823)
        Me.vb01305.TabIndex = 2091
        Me.vb01305.TabStop = False
        Me.vb01305.Visible = False
        '
        'vb01405
        '
        Me.vb01405.Image = CType(resources.GetObject("vb01405.Image"), System.Drawing.Image)
        Me.vb01405.Location = New System.Drawing.Point(12, 12)
        Me.vb01405.Name = "vb01405"
        Me.vb01405.Size = New System.Drawing.Size(952, 823)
        Me.vb01405.TabIndex = 2092
        Me.vb01405.TabStop = False
        Me.vb01405.Visible = False
        '
        'vb01505
        '
        Me.vb01505.Image = CType(resources.GetObject("vb01505.Image"), System.Drawing.Image)
        Me.vb01505.Location = New System.Drawing.Point(12, 12)
        Me.vb01505.Name = "vb01505"
        Me.vb01505.Size = New System.Drawing.Size(952, 823)
        Me.vb01505.TabIndex = 2093
        Me.vb01505.TabStop = False
        Me.vb01505.Visible = False
        '
        'InfoSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1334, 841)
        Me.Controls.Add(Me.vb01505)
        Me.Controls.Add(Me.vb01405)
        Me.Controls.Add(Me.vb01305)
        Me.Controls.Add(Me.InfoClose)
        Me.Name = "InfoSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Information"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vb01305, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vb01405, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vb01505, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InfoClose As AdvancedHMIControls.BasicButton
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents vb01305 As PictureBox
    Friend WithEvents vb01405 As PictureBox
    Friend WithEvents vb01505 As PictureBox
End Class
