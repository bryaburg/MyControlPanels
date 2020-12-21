<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight3 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight4 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight5 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight6 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight7 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight9 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight8 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight10 = New AdvancedHMIControls.PilotLight()
        Me.FormChangeButton1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.PilotLight11 = New AdvancedHMIControls.PilotLight()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 662)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.131"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'PilotLight1
        '
        Me.PilotLight1.AccessibleDescription = "STOP"
        Me.PilotLight1.AccessibleName = "STOP"
        Me.PilotLight1.BackColor = System.Drawing.Color.Gold
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight1.ForeColor = System.Drawing.Color.SteelBlue
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(93, 25)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "CP31.STOP_PB"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(109, 160)
        Me.PilotLight1.TabIndex = 6
        Me.PilotLight1.Text = "CP31 STOP"
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'PilotLight2
        '
        Me.PilotLight2.AccessibleDescription = "MTR RESET"
        Me.PilotLight2.AccessibleName = "MTR RESET"
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight2.ForeColor = System.Drawing.Color.DarkRed
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight2.Location = New System.Drawing.Point(533, 25)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight2.PLCAddressClick = ""
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "CP31.MTR_RESET_PB"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(109, 160)
        Me.PilotLight2.TabIndex = 7
        Me.PilotLight2.Text = "CP31 MTR FAULT RESET"
        Me.PilotLight2.Value = False
        Me.PilotLight2.ValueToWrite = 0
        '
        'PilotLight3
        '
        Me.PilotLight3.AccessibleDescription = "JAM RESET"
        Me.PilotLight3.AccessibleName = "JAM "
        Me.PilotLight3.Blink = False
        Me.PilotLight3.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight3.ForeColor = System.Drawing.Color.DarkOrange
        Me.PilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight3.Location = New System.Drawing.Point(388, 25)
        Me.PilotLight3.Name = "PilotLight3"
        Me.PilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight3.PLCAddressClick = ""
        Me.PilotLight3.PLCAddressText = ""
        Me.PilotLight3.PLCAddressValue = "CP31.JAM_RESET_PB"
        Me.PilotLight3.PLCAddressVisible = ""
        Me.PilotLight3.Size = New System.Drawing.Size(109, 160)
        Me.PilotLight3.TabIndex = 8
        Me.PilotLight3.Text = "CP31 JAM RESET"
        Me.PilotLight3.Value = False
        Me.PilotLight3.ValueToWrite = 0
        '
        'PilotLight4
        '
        Me.PilotLight4.AccessibleDescription = "STARTLIGHT"
        Me.PilotLight4.AccessibleName = "START"
        Me.PilotLight4.Blink = False
        Me.PilotLight4.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.PilotLight4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight4.Location = New System.Drawing.Point(238, 25)
        Me.PilotLight4.Name = "PilotLight4"
        Me.PilotLight4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight4.PLCAddressClick = ""
        Me.PilotLight4.PLCAddressText = ""
        Me.PilotLight4.PLCAddressValue = "CP31.START_PB"
        Me.PilotLight4.PLCAddressVisible = ""
        Me.PilotLight4.Size = New System.Drawing.Size(109, 160)
        Me.PilotLight4.TabIndex = 9
        Me.PilotLight4.Text = "CP31 START"
        Me.PilotLight4.Value = False
        Me.PilotLight4.ValueToWrite = 0
        '
        'PilotLight5
        '
        Me.PilotLight5.AccessibleDescription = "ALARM HORN"
        Me.PilotLight5.AccessibleName = "HORN"
        Me.PilotLight5.Blink = False
        Me.PilotLight5.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight5.ForeColor = System.Drawing.Color.Green
        Me.PilotLight5.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight5.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight5.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight5.Location = New System.Drawing.Point(669, 25)
        Me.PilotLight5.Name = "PilotLight5"
        Me.PilotLight5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight5.PLCAddressClick = ""
        Me.PilotLight5.PLCAddressText = ""
        Me.PilotLight5.PLCAddressValue = "AH31360"
        Me.PilotLight5.PLCAddressVisible = ""
        Me.PilotLight5.Size = New System.Drawing.Size(109, 160)
        Me.PilotLight5.TabIndex = 10
        Me.PilotLight5.Text = "CP31 ALARM HORN"
        Me.PilotLight5.Value = False
        Me.PilotLight5.ValueToWrite = 0
        '
        'PilotLight6
        '
        Me.PilotLight6.AccessibleDescription = "STOP"
        Me.PilotLight6.AccessibleName = "STOP"
        Me.PilotLight6.BackColor = System.Drawing.Color.Gold
        Me.PilotLight6.Blink = False
        Me.PilotLight6.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight6.ForeColor = System.Drawing.Color.Red
        Me.PilotLight6.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight6.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight6.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight6.Location = New System.Drawing.Point(93, 223)
        Me.PilotLight6.Name = "PilotLight6"
        Me.PilotLight6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight6.PLCAddressClick = "ForceCP31InOff[2].15"
        Me.PilotLight6.PLCAddressText = ""
        Me.PilotLight6.PLCAddressValue = "ForceCP31InOff[2].15"
        Me.PilotLight6.PLCAddressVisible = ""
        Me.PilotLight6.Size = New System.Drawing.Size(109, 160)
        Me.PilotLight6.TabIndex = 11
        Me.PilotLight6.Text = " STOP"
        Me.PilotLight6.Value = False
        Me.PilotLight6.ValueToWrite = 1
        '
        'PilotLight7
        '
        Me.PilotLight7.AccessibleDescription = "ALARM HORN"
        Me.PilotLight7.AccessibleName = "HORN"
        Me.PilotLight7.Blink = False
        Me.PilotLight7.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PilotLight7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PilotLight7.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight7.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight7.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight7.Location = New System.Drawing.Point(669, 223)
        Me.PilotLight7.Name = "PilotLight7"
        Me.PilotLight7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight7.PLCAddressClick = "ForceCP31OutOff[2].18"
        Me.PilotLight7.PLCAddressText = ""
        Me.PilotLight7.PLCAddressValue = "ForceCP31OutOff[2].18"
        Me.PilotLight7.PLCAddressVisible = ""
        Me.PilotLight7.Size = New System.Drawing.Size(51, 75)
        Me.PilotLight7.TabIndex = 12
        Me.PilotLight7.Text = "HORN OFF"
        Me.PilotLight7.Value = False
        Me.PilotLight7.ValueToWrite = 1
        '
        'PilotLight9
        '
        Me.PilotLight9.AccessibleDescription = "STARTLIGHT"
        Me.PilotLight9.AccessibleName = "START"
        Me.PilotLight9.Blink = False
        Me.PilotLight9.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight9.ForeColor = System.Drawing.Color.GreenYellow
        Me.PilotLight9.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight9.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight9.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight9.Location = New System.Drawing.Point(238, 223)
        Me.PilotLight9.Name = "PilotLight9"
        Me.PilotLight9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight9.PLCAddressClick = "ForceCP31InOn[2].14"
        Me.PilotLight9.PLCAddressText = ""
        Me.PilotLight9.PLCAddressValue = "ForceCP31InOn[2].14"
        Me.PilotLight9.PLCAddressVisible = ""
        Me.PilotLight9.Size = New System.Drawing.Size(109, 160)
        Me.PilotLight9.TabIndex = 14
        Me.PilotLight9.Text = "START"
        Me.PilotLight9.Value = False
        Me.PilotLight9.ValueToWrite = 1
        '
        'PilotLight8
        '
        Me.PilotLight8.AccessibleDescription = "ALARM HORN"
        Me.PilotLight8.AccessibleName = "HORN"
        Me.PilotLight8.Blink = False
        Me.PilotLight8.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PilotLight8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PilotLight8.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight8.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight8.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight8.Location = New System.Drawing.Point(727, 308)
        Me.PilotLight8.Name = "PilotLight8"
        Me.PilotLight8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight8.PLCAddressClick = "ForceCP31OutOn[2].18"
        Me.PilotLight8.PLCAddressText = ""
        Me.PilotLight8.PLCAddressValue = "ForceCP31OutOn[2].18"
        Me.PilotLight8.PLCAddressVisible = ""
        Me.PilotLight8.Size = New System.Drawing.Size(51, 75)
        Me.PilotLight8.TabIndex = 15
        Me.PilotLight8.Text = "HORN ON"
        Me.PilotLight8.Value = False
        Me.PilotLight8.ValueToWrite = 1
        '
        'PilotLight10
        '
        Me.PilotLight10.AccessibleDescription = "JAM RESET"
        Me.PilotLight10.AccessibleName = "JAM "
        Me.PilotLight10.Blink = False
        Me.PilotLight10.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.PilotLight10.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight10.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight10.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight10.Location = New System.Drawing.Point(388, 223)
        Me.PilotLight10.Name = "PilotLight10"
        Me.PilotLight10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight10.PLCAddressClick = "ForceCP31InOn[2].16"
        Me.PilotLight10.PLCAddressText = ""
        Me.PilotLight10.PLCAddressValue = "ForceCP31InOn[2].16"
        Me.PilotLight10.PLCAddressVisible = ""
        Me.PilotLight10.Size = New System.Drawing.Size(109, 160)
        Me.PilotLight10.TabIndex = 16
        Me.PilotLight10.Text = "JAM RESET"
        Me.PilotLight10.Value = False
        Me.PilotLight10.ValueToWrite = 1
        '
        'FormChangeButton1
        '
        Me.FormChangeButton1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FormChangeButton1.ComComponent = Nothing
        Me.FormChangeButton1.ForeColor = System.Drawing.Color.Black
        Me.FormChangeButton1.FormToOpen = Nothing
        Me.FormChangeButton1.KeypadWidth = 300
        Me.FormChangeButton1.Location = New System.Drawing.Point(0, 0)
        Me.FormChangeButton1.Name = "FormChangeButton1"
        Me.FormChangeButton1.Passcode = Nothing
        Me.FormChangeButton1.PasswordChar = False
        Me.FormChangeButton1.PLCAddressVisible = ""
        Me.FormChangeButton1.Size = New System.Drawing.Size(75, 23)
        Me.FormChangeButton1.TabIndex = 4
        Me.FormChangeButton1.Text = "FormChangeButton1"
        Me.FormChangeButton1.UseVisualStyleBackColor = False
        '
        'PilotLight11
        '
        Me.PilotLight11.AccessibleDescription = "MTR RESET"
        Me.PilotLight11.AccessibleName = "MTR RESET"
        Me.PilotLight11.Blink = False
        Me.PilotLight11.ComComponent = Me.EthernetIPforCLXCom1
        Me.PilotLight11.ForeColor = System.Drawing.Color.DarkRed
        Me.PilotLight11.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight11.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight11.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight11.Location = New System.Drawing.Point(533, 223)
        Me.PilotLight11.Name = "PilotLight11"
        Me.PilotLight11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight11.PLCAddressClick = "ForceCP31InOn[2].17"
        Me.PilotLight11.PLCAddressText = ""
        Me.PilotLight11.PLCAddressValue = "ForceCP31InOn[2].17"
        Me.PilotLight11.PLCAddressVisible = ""
        Me.PilotLight11.Size = New System.Drawing.Size(109, 160)
        Me.PilotLight11.TabIndex = 17
        Me.PilotLight11.Text = "MTR FAULT RESET"
        Me.PilotLight11.Value = False
        Me.PilotLight11.ValueToWrite = 0
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1349, 561)
        Me.Controls.Add(Me.PilotLight11)
        Me.Controls.Add(Me.PilotLight10)
        Me.Controls.Add(Me.PilotLight8)
        Me.Controls.Add(Me.PilotLight9)
        Me.Controls.Add(Me.PilotLight7)
        Me.Controls.Add(Me.PilotLight6)
        Me.Controls.Add(Me.PilotLight5)
        Me.Controls.Add(Me.PilotLight4)
        Me.Controls.Add(Me.PilotLight3)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.FormChangeButton1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents FormChangeButton1 As FormChangeButton
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight3 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight4 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight5 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight6 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight7 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight9 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight8 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight10 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight11 As AdvancedHMIControls.PilotLight
End Class
