<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeltSpeeds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BeltSpeeds))
        Me.cmdScSp = New AdvancedHMIControls.AnalogValueDisplay()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.actScSp = New AdvancedHMIControls.AnalogValueDisplay()
        Me.BS_Exit = New AdvancedHMIControls.BasicButton()
        Me.AnalogValueDisplay1 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdBuSp = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay3 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdPrSp = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay5 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdPrSp2 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay7 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdVeSp = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay9 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdAlSp = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay11 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdAcDcTi = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay13 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdDMC = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TiClk = New System.Windows.Forms.Timer(Me.components)
        Me.LbDate = New System.Windows.Forms.Label()
        Me.LbClk = New System.Windows.Forms.Label()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdScSp
        '
        Me.cmdScSp.AutoSize = True
        Me.cmdScSp.ComComponent = Me.EthernetIPforCLXCom1
        Me.cmdScSp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdScSp.ForeColor = System.Drawing.Color.Yellow
        Me.cmdScSp.ForeColorInLimits = System.Drawing.Color.Silver
        Me.cmdScSp.ForeColorOverLimit = System.Drawing.Color.Red
        Me.cmdScSp.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.cmdScSp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.cmdScSp.KeypadMaxValue = 250.0R
        Me.cmdScSp.KeypadMinValue = 100.0R
        Me.cmdScSp.KeypadPasscode = Nothing
        Me.cmdScSp.KeypadScaleFactor = 1.0R
        Me.cmdScSp.KeypadText = Nothing
        Me.cmdScSp.KeypadWidth = 300
        Me.cmdScSp.Location = New System.Drawing.Point(57, 106)
        Me.cmdScSp.Name = "cmdScSp"
        Me.cmdScSp.NumericFormat = Nothing
        Me.cmdScSp.PLCAddressKeypad = "HMI_ScaleVelocity_CMD"
        Me.cmdScSp.PLCAddressValue = CType(resources.GetObject("cmdScSp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.cmdScSp.PLCAddressValueLimitLower = Nothing
        Me.cmdScSp.PLCAddressValueLimitUpper = Nothing
        Me.cmdScSp.PLCAddressVisible = Nothing
        Me.cmdScSp.ShowValue = True
        Me.cmdScSp.Size = New System.Drawing.Size(161, 17)
        Me.cmdScSp.TabIndex = 0
        Me.cmdScSp.Text = "Command   000  FPM"
        Me.cmdScSp.Value = "000"
        Me.cmdScSp.ValueLimitLower = 100.0R
        Me.cmdScSp.ValueLimitUpper = 250.0R
        Me.cmdScSp.ValuePrefix = "Command   "
        Me.cmdScSp.ValueSuffix = "  FPM"
        Me.cmdScSp.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.58"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(56, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scale Speed"
        '
        'actScSp
        '
        Me.actScSp.AutoSize = True
        Me.actScSp.ComComponent = Me.EthernetIPforCLXCom1
        Me.actScSp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actScSp.ForeColor = System.Drawing.Color.Yellow
        Me.actScSp.ForeColorInLimits = System.Drawing.Color.Silver
        Me.actScSp.ForeColorOverLimit = System.Drawing.Color.Red
        Me.actScSp.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.actScSp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.actScSp.KeypadMaxValue = 250.0R
        Me.actScSp.KeypadMinValue = 100.0R
        Me.actScSp.KeypadPasscode = Nothing
        Me.actScSp.KeypadScaleFactor = 1.0R
        Me.actScSp.KeypadText = Nothing
        Me.actScSp.KeypadWidth = 300
        Me.actScSp.Location = New System.Drawing.Point(57, 123)
        Me.actScSp.Name = "actScSp"
        Me.actScSp.NumericFormat = Nothing
        Me.actScSp.PLCAddressKeypad = ""
        Me.actScSp.PLCAddressValue = CType(resources.GetObject("actScSp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.actScSp.PLCAddressValueLimitLower = Nothing
        Me.actScSp.PLCAddressValueLimitUpper = Nothing
        Me.actScSp.PLCAddressVisible = Nothing
        Me.actScSp.ShowValue = True
        Me.actScSp.Size = New System.Drawing.Size(131, 17)
        Me.actScSp.TabIndex = 2
        Me.actScSp.Text = "Actual  000  FPM"
        Me.actScSp.Value = "000"
        Me.actScSp.ValueLimitLower = 100.0R
        Me.actScSp.ValueLimitUpper = 250.0R
        Me.actScSp.ValuePrefix = "Actual  "
        Me.actScSp.ValueSuffix = "  FPM"
        Me.actScSp.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'BS_Exit
        '
        Me.BS_Exit.BackColor = System.Drawing.Color.Blue
        Me.BS_Exit.ComComponent = Me.EthernetIPforCLXCom1
        Me.BS_Exit.Font = New System.Drawing.Font("Magneto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BS_Exit.ForeColor = System.Drawing.Color.GhostWhite
        Me.BS_Exit.ForeColorAltername = System.Drawing.Color.Black
        Me.BS_Exit.Highlight = False
        Me.BS_Exit.HighlightColor = System.Drawing.Color.Green
        Me.BS_Exit.Location = New System.Drawing.Point(287, 347)
        Me.BS_Exit.MaximumHoldTime = 3000
        Me.BS_Exit.MinimumHoldTime = 500
        Me.BS_Exit.Name = "BS_Exit"
        Me.BS_Exit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BS_Exit.PLCAddressClick = ""
        Me.BS_Exit.SelectTextAlternate = False
        Me.BS_Exit.Size = New System.Drawing.Size(212, 80)
        Me.BS_Exit.TabIndex = 12
        Me.BS_Exit.Text = "Exit Belt Speeds"
        Me.BS_Exit.TextAlternate = Nothing
        Me.BS_Exit.UseVisualStyleBackColor = False
        Me.BS_Exit.ValueToWrite = 0
        '
        'AnalogValueDisplay1
        '
        Me.AnalogValueDisplay1.AutoSize = True
        Me.AnalogValueDisplay1.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay1.ForeColor = System.Drawing.Color.Turquoise
        Me.AnalogValueDisplay1.ForeColorInLimits = System.Drawing.Color.Gold
        Me.AnalogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Turquoise
        Me.AnalogValueDisplay1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay1.KeypadMaxValue = 250.0R
        Me.AnalogValueDisplay1.KeypadMinValue = 100.0R
        Me.AnalogValueDisplay1.KeypadPasscode = Nothing
        Me.AnalogValueDisplay1.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay1.KeypadText = Nothing
        Me.AnalogValueDisplay1.KeypadWidth = 300
        Me.AnalogValueDisplay1.Location = New System.Drawing.Point(57, 206)
        Me.AnalogValueDisplay1.Name = "AnalogValueDisplay1"
        Me.AnalogValueDisplay1.NumericFormat = Nothing
        Me.AnalogValueDisplay1.PLCAddressKeypad = ""
        Me.AnalogValueDisplay1.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay1.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay1.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay1.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay1.ShowValue = True
        Me.AnalogValueDisplay1.Size = New System.Drawing.Size(131, 17)
        Me.AnalogValueDisplay1.TabIndex = 15
        Me.AnalogValueDisplay1.Text = "Actual  000  FPM"
        Me.AnalogValueDisplay1.Value = "000"
        Me.AnalogValueDisplay1.ValueLimitLower = 100.0R
        Me.AnalogValueDisplay1.ValueLimitUpper = 250.0R
        Me.AnalogValueDisplay1.ValuePrefix = "Actual  "
        Me.AnalogValueDisplay1.ValueSuffix = "  FPM"
        Me.AnalogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(56, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Buffer Speed"
        '
        'cmdBuSp
        '
        Me.cmdBuSp.AutoSize = True
        Me.cmdBuSp.ComComponent = Me.EthernetIPforCLXCom1
        Me.cmdBuSp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuSp.ForeColor = System.Drawing.Color.Turquoise
        Me.cmdBuSp.ForeColorInLimits = System.Drawing.Color.Gold
        Me.cmdBuSp.ForeColorOverLimit = System.Drawing.Color.Red
        Me.cmdBuSp.ForeColorUnderLimit = System.Drawing.Color.Turquoise
        Me.cmdBuSp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBuSp.KeypadMaxValue = 250.0R
        Me.cmdBuSp.KeypadMinValue = 100.0R
        Me.cmdBuSp.KeypadPasscode = Nothing
        Me.cmdBuSp.KeypadScaleFactor = 1.0R
        Me.cmdBuSp.KeypadText = Nothing
        Me.cmdBuSp.KeypadWidth = 300
        Me.cmdBuSp.Location = New System.Drawing.Point(57, 189)
        Me.cmdBuSp.Name = "cmdBuSp"
        Me.cmdBuSp.NumericFormat = Nothing
        Me.cmdBuSp.PLCAddressKeypad = "HMI_BufferVelocity_CMD"
        Me.cmdBuSp.PLCAddressValue = CType(resources.GetObject("cmdBuSp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.cmdBuSp.PLCAddressValueLimitLower = Nothing
        Me.cmdBuSp.PLCAddressValueLimitUpper = Nothing
        Me.cmdBuSp.PLCAddressVisible = Nothing
        Me.cmdBuSp.ShowValue = True
        Me.cmdBuSp.Size = New System.Drawing.Size(161, 17)
        Me.cmdBuSp.TabIndex = 13
        Me.cmdBuSp.Text = "Command   000  FPM"
        Me.cmdBuSp.Value = "000"
        Me.cmdBuSp.ValueLimitLower = 100.0R
        Me.cmdBuSp.ValueLimitUpper = 250.0R
        Me.cmdBuSp.ValuePrefix = "Command   "
        Me.cmdBuSp.ValueSuffix = "  FPM"
        Me.cmdBuSp.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay3
        '
        Me.AnalogValueDisplay3.AutoSize = True
        Me.AnalogValueDisplay3.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay3.ForeColor = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay3.ForeColorInLimits = System.Drawing.Color.Green
        Me.AnalogValueDisplay3.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay3.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay3.KeypadMaxValue = 250.0R
        Me.AnalogValueDisplay3.KeypadMinValue = 100.0R
        Me.AnalogValueDisplay3.KeypadPasscode = Nothing
        Me.AnalogValueDisplay3.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay3.KeypadText = Nothing
        Me.AnalogValueDisplay3.KeypadWidth = 300
        Me.AnalogValueDisplay3.Location = New System.Drawing.Point(57, 291)
        Me.AnalogValueDisplay3.Name = "AnalogValueDisplay3"
        Me.AnalogValueDisplay3.NumericFormat = Nothing
        Me.AnalogValueDisplay3.PLCAddressKeypad = ""
        Me.AnalogValueDisplay3.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay3.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay3.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay3.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay3.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay3.ShowValue = True
        Me.AnalogValueDisplay3.Size = New System.Drawing.Size(131, 17)
        Me.AnalogValueDisplay3.TabIndex = 18
        Me.AnalogValueDisplay3.Text = "Actual  000  FPM"
        Me.AnalogValueDisplay3.Value = "000"
        Me.AnalogValueDisplay3.ValueLimitLower = 100.0R
        Me.AnalogValueDisplay3.ValueLimitUpper = 250.0R
        Me.AnalogValueDisplay3.ValuePrefix = "Actual  "
        Me.AnalogValueDisplay3.ValueSuffix = "  FPM"
        Me.AnalogValueDisplay3.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(56, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Printer 1 Speed"
        '
        'cmdPrSp
        '
        Me.cmdPrSp.AutoSize = True
        Me.cmdPrSp.ComComponent = Me.EthernetIPforCLXCom1
        Me.cmdPrSp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrSp.ForeColor = System.Drawing.Color.Yellow
        Me.cmdPrSp.ForeColorInLimits = System.Drawing.Color.Green
        Me.cmdPrSp.ForeColorOverLimit = System.Drawing.Color.Red
        Me.cmdPrSp.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.cmdPrSp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPrSp.KeypadMaxValue = 250.0R
        Me.cmdPrSp.KeypadMinValue = 100.0R
        Me.cmdPrSp.KeypadPasscode = Nothing
        Me.cmdPrSp.KeypadScaleFactor = 1.0R
        Me.cmdPrSp.KeypadText = Nothing
        Me.cmdPrSp.KeypadWidth = 300
        Me.cmdPrSp.Location = New System.Drawing.Point(57, 274)
        Me.cmdPrSp.Name = "cmdPrSp"
        Me.cmdPrSp.NumericFormat = Nothing
        Me.cmdPrSp.PLCAddressKeypad = "HMI_Apply1Velocity_CMD"
        Me.cmdPrSp.PLCAddressValue = CType(resources.GetObject("cmdPrSp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.cmdPrSp.PLCAddressValueLimitLower = Nothing
        Me.cmdPrSp.PLCAddressValueLimitUpper = Nothing
        Me.cmdPrSp.PLCAddressVisible = Nothing
        Me.cmdPrSp.ShowValue = True
        Me.cmdPrSp.Size = New System.Drawing.Size(161, 17)
        Me.cmdPrSp.TabIndex = 16
        Me.cmdPrSp.Text = "Command   000  FPM"
        Me.cmdPrSp.Value = "000"
        Me.cmdPrSp.ValueLimitLower = 100.0R
        Me.cmdPrSp.ValueLimitUpper = 250.0R
        Me.cmdPrSp.ValuePrefix = "Command   "
        Me.cmdPrSp.ValueSuffix = "  FPM"
        Me.cmdPrSp.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay5
        '
        Me.AnalogValueDisplay5.AutoSize = True
        Me.AnalogValueDisplay5.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay5.ForeColor = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay5.ForeColorInLimits = System.Drawing.Color.YellowGreen
        Me.AnalogValueDisplay5.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay5.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay5.KeypadMaxValue = 250.0R
        Me.AnalogValueDisplay5.KeypadMinValue = 100.0R
        Me.AnalogValueDisplay5.KeypadPasscode = Nothing
        Me.AnalogValueDisplay5.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay5.KeypadText = Nothing
        Me.AnalogValueDisplay5.KeypadWidth = 300
        Me.AnalogValueDisplay5.Location = New System.Drawing.Point(315, 123)
        Me.AnalogValueDisplay5.Name = "AnalogValueDisplay5"
        Me.AnalogValueDisplay5.NumericFormat = Nothing
        Me.AnalogValueDisplay5.PLCAddressKeypad = ""
        Me.AnalogValueDisplay5.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay5.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay5.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay5.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay5.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay5.ShowValue = True
        Me.AnalogValueDisplay5.Size = New System.Drawing.Size(131, 17)
        Me.AnalogValueDisplay5.TabIndex = 21
        Me.AnalogValueDisplay5.Text = "Actual  000  FPM"
        Me.AnalogValueDisplay5.Value = "000"
        Me.AnalogValueDisplay5.ValueLimitLower = 100.0R
        Me.AnalogValueDisplay5.ValueLimitUpper = 250.0R
        Me.AnalogValueDisplay5.ValuePrefix = "Actual  "
        Me.AnalogValueDisplay5.ValueSuffix = "  FPM"
        Me.AnalogValueDisplay5.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label4.Location = New System.Drawing.Point(314, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Printer 2 Speed"
        '
        'cmdPrSp2
        '
        Me.cmdPrSp2.AutoSize = True
        Me.cmdPrSp2.ComComponent = Me.EthernetIPforCLXCom1
        Me.cmdPrSp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrSp2.ForeColor = System.Drawing.Color.Yellow
        Me.cmdPrSp2.ForeColorInLimits = System.Drawing.Color.YellowGreen
        Me.cmdPrSp2.ForeColorOverLimit = System.Drawing.Color.Red
        Me.cmdPrSp2.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.cmdPrSp2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.cmdPrSp2.KeypadMaxValue = 250.0R
        Me.cmdPrSp2.KeypadMinValue = 100.0R
        Me.cmdPrSp2.KeypadPasscode = Nothing
        Me.cmdPrSp2.KeypadScaleFactor = 1.0R
        Me.cmdPrSp2.KeypadText = Nothing
        Me.cmdPrSp2.KeypadWidth = 300
        Me.cmdPrSp2.Location = New System.Drawing.Point(315, 106)
        Me.cmdPrSp2.Name = "cmdPrSp2"
        Me.cmdPrSp2.NumericFormat = Nothing
        Me.cmdPrSp2.PLCAddressKeypad = "HMI_Apply2Velocity_CMD"
        Me.cmdPrSp2.PLCAddressValue = CType(resources.GetObject("cmdPrSp2.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.cmdPrSp2.PLCAddressValueLimitLower = Nothing
        Me.cmdPrSp2.PLCAddressValueLimitUpper = Nothing
        Me.cmdPrSp2.PLCAddressVisible = Nothing
        Me.cmdPrSp2.ShowValue = True
        Me.cmdPrSp2.Size = New System.Drawing.Size(161, 17)
        Me.cmdPrSp2.TabIndex = 19
        Me.cmdPrSp2.Text = "Command   000  FPM"
        Me.cmdPrSp2.Value = "000"
        Me.cmdPrSp2.ValueLimitLower = 100.0R
        Me.cmdPrSp2.ValueLimitUpper = 250.0R
        Me.cmdPrSp2.ValuePrefix = "Command   "
        Me.cmdPrSp2.ValueSuffix = "  FPM"
        Me.cmdPrSp2.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay7
        '
        Me.AnalogValueDisplay7.AutoSize = True
        Me.AnalogValueDisplay7.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay7.ForeColor = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay7.ForeColorInLimits = System.Drawing.Color.Snow
        Me.AnalogValueDisplay7.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay7.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay7.KeypadMaxValue = 250.0R
        Me.AnalogValueDisplay7.KeypadMinValue = 100.0R
        Me.AnalogValueDisplay7.KeypadPasscode = Nothing
        Me.AnalogValueDisplay7.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay7.KeypadText = Nothing
        Me.AnalogValueDisplay7.KeypadWidth = 300
        Me.AnalogValueDisplay7.Location = New System.Drawing.Point(315, 206)
        Me.AnalogValueDisplay7.Name = "AnalogValueDisplay7"
        Me.AnalogValueDisplay7.NumericFormat = Nothing
        Me.AnalogValueDisplay7.PLCAddressKeypad = ""
        Me.AnalogValueDisplay7.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay7.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay7.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay7.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay7.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay7.ShowValue = True
        Me.AnalogValueDisplay7.Size = New System.Drawing.Size(131, 17)
        Me.AnalogValueDisplay7.TabIndex = 24
        Me.AnalogValueDisplay7.Text = "Actual  000  FPM"
        Me.AnalogValueDisplay7.Value = "000"
        Me.AnalogValueDisplay7.ValueLimitLower = 100.0R
        Me.AnalogValueDisplay7.ValueLimitUpper = 250.0R
        Me.AnalogValueDisplay7.ValuePrefix = "Actual  "
        Me.AnalogValueDisplay7.ValueSuffix = "  FPM"
        Me.AnalogValueDisplay7.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(314, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Verify Speed"
        '
        'cmdVeSp
        '
        Me.cmdVeSp.AutoSize = True
        Me.cmdVeSp.ComComponent = Me.EthernetIPforCLXCom1
        Me.cmdVeSp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVeSp.ForeColor = System.Drawing.Color.Yellow
        Me.cmdVeSp.ForeColorInLimits = System.Drawing.Color.Snow
        Me.cmdVeSp.ForeColorOverLimit = System.Drawing.Color.Red
        Me.cmdVeSp.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.cmdVeSp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.cmdVeSp.KeypadMaxValue = 250.0R
        Me.cmdVeSp.KeypadMinValue = 100.0R
        Me.cmdVeSp.KeypadPasscode = Nothing
        Me.cmdVeSp.KeypadScaleFactor = 1.0R
        Me.cmdVeSp.KeypadText = Nothing
        Me.cmdVeSp.KeypadWidth = 300
        Me.cmdVeSp.Location = New System.Drawing.Point(315, 189)
        Me.cmdVeSp.Name = "cmdVeSp"
        Me.cmdVeSp.NumericFormat = Nothing
        Me.cmdVeSp.PLCAddressKeypad = "HMI_SorterVelocity_CMD"
        Me.cmdVeSp.PLCAddressValue = CType(resources.GetObject("cmdVeSp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.cmdVeSp.PLCAddressValueLimitLower = Nothing
        Me.cmdVeSp.PLCAddressValueLimitUpper = Nothing
        Me.cmdVeSp.PLCAddressVisible = Nothing
        Me.cmdVeSp.ShowValue = True
        Me.cmdVeSp.Size = New System.Drawing.Size(161, 17)
        Me.cmdVeSp.TabIndex = 22
        Me.cmdVeSp.Text = "Command   000  FPM"
        Me.cmdVeSp.Value = "000"
        Me.cmdVeSp.ValueLimitLower = 100.0R
        Me.cmdVeSp.ValueLimitUpper = 250.0R
        Me.cmdVeSp.ValuePrefix = "Command   "
        Me.cmdVeSp.ValueSuffix = "  FPM"
        Me.cmdVeSp.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay9
        '
        Me.AnalogValueDisplay9.AutoSize = True
        Me.AnalogValueDisplay9.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay9.ForeColor = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay9.ForeColorInLimits = System.Drawing.Color.DeepSkyBlue
        Me.AnalogValueDisplay9.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay9.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay9.KeypadMaxValue = 250.0R
        Me.AnalogValueDisplay9.KeypadMinValue = 100.0R
        Me.AnalogValueDisplay9.KeypadPasscode = Nothing
        Me.AnalogValueDisplay9.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay9.KeypadText = Nothing
        Me.AnalogValueDisplay9.KeypadWidth = 300
        Me.AnalogValueDisplay9.Location = New System.Drawing.Point(582, 123)
        Me.AnalogValueDisplay9.Name = "AnalogValueDisplay9"
        Me.AnalogValueDisplay9.NumericFormat = Nothing
        Me.AnalogValueDisplay9.PLCAddressKeypad = ""
        Me.AnalogValueDisplay9.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay9.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay9.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay9.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay9.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay9.ShowValue = True
        Me.AnalogValueDisplay9.Size = New System.Drawing.Size(131, 17)
        Me.AnalogValueDisplay9.TabIndex = 27
        Me.AnalogValueDisplay9.Text = "Actual  000  FPM"
        Me.AnalogValueDisplay9.Value = "000"
        Me.AnalogValueDisplay9.ValueLimitLower = 100.0R
        Me.AnalogValueDisplay9.ValueLimitUpper = 250.0R
        Me.AnalogValueDisplay9.ValuePrefix = "Actual  "
        Me.AnalogValueDisplay9.ValueSuffix = "  FPM"
        Me.AnalogValueDisplay9.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(581, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = " Alignment Speed"
        '
        'cmdAlSp
        '
        Me.cmdAlSp.AutoSize = True
        Me.cmdAlSp.ComComponent = Me.EthernetIPforCLXCom1
        Me.cmdAlSp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAlSp.ForeColor = System.Drawing.Color.Yellow
        Me.cmdAlSp.ForeColorInLimits = System.Drawing.Color.DeepSkyBlue
        Me.cmdAlSp.ForeColorOverLimit = System.Drawing.Color.Red
        Me.cmdAlSp.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.cmdAlSp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAlSp.KeypadMaxValue = 250.0R
        Me.cmdAlSp.KeypadMinValue = 100.0R
        Me.cmdAlSp.KeypadPasscode = Nothing
        Me.cmdAlSp.KeypadScaleFactor = 1.0R
        Me.cmdAlSp.KeypadText = Nothing
        Me.cmdAlSp.KeypadWidth = 300
        Me.cmdAlSp.Location = New System.Drawing.Point(582, 106)
        Me.cmdAlSp.Name = "cmdAlSp"
        Me.cmdAlSp.NumericFormat = Nothing
        Me.cmdAlSp.PLCAddressKeypad = "HMI_AlignmentVelocity_CMD"
        Me.cmdAlSp.PLCAddressValue = CType(resources.GetObject("cmdAlSp.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.cmdAlSp.PLCAddressValueLimitLower = Nothing
        Me.cmdAlSp.PLCAddressValueLimitUpper = Nothing
        Me.cmdAlSp.PLCAddressVisible = Nothing
        Me.cmdAlSp.ShowValue = True
        Me.cmdAlSp.Size = New System.Drawing.Size(161, 17)
        Me.cmdAlSp.TabIndex = 25
        Me.cmdAlSp.Text = "Command   000  FPM"
        Me.cmdAlSp.Value = "000"
        Me.cmdAlSp.ValueLimitLower = 100.0R
        Me.cmdAlSp.ValueLimitUpper = 250.0R
        Me.cmdAlSp.ValuePrefix = "Command   "
        Me.cmdAlSp.ValueSuffix = "  FPM"
        Me.cmdAlSp.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay11
        '
        Me.AnalogValueDisplay11.AutoSize = True
        Me.AnalogValueDisplay11.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay11.ForeColor = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay11.ForeColorInLimits = System.Drawing.Color.LightSeaGreen
        Me.AnalogValueDisplay11.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay11.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay11.KeypadMaxValue = 10.0R
        Me.AnalogValueDisplay11.KeypadMinValue = 0.01R
        Me.AnalogValueDisplay11.KeypadPasscode = Nothing
        Me.AnalogValueDisplay11.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay11.KeypadText = Nothing
        Me.AnalogValueDisplay11.KeypadWidth = 300
        Me.AnalogValueDisplay11.Location = New System.Drawing.Point(582, 206)
        Me.AnalogValueDisplay11.Name = "AnalogValueDisplay11"
        Me.AnalogValueDisplay11.NumericFormat = Nothing
        Me.AnalogValueDisplay11.PLCAddressKeypad = ""
        Me.AnalogValueDisplay11.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay11.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay11.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay11.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay11.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay11.ShowValue = True
        Me.AnalogValueDisplay11.Size = New System.Drawing.Size(162, 17)
        Me.AnalogValueDisplay11.TabIndex = 30
        Me.AnalogValueDisplay11.Text = "Actual  000  Seconds"
        Me.AnalogValueDisplay11.Value = "000"
        Me.AnalogValueDisplay11.ValueLimitLower = 0.01R
        Me.AnalogValueDisplay11.ValueLimitUpper = 10.0R
        Me.AnalogValueDisplay11.ValuePrefix = "Actual  "
        Me.AnalogValueDisplay11.ValueSuffix = "  Seconds"
        Me.AnalogValueDisplay11.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label7.Location = New System.Drawing.Point(581, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = " Scale Acc/Dec Time"
        '
        'cmdAcDcTi
        '
        Me.cmdAcDcTi.AutoSize = True
        Me.cmdAcDcTi.ComComponent = Me.EthernetIPforCLXCom1
        Me.cmdAcDcTi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcDcTi.ForeColor = System.Drawing.Color.Yellow
        Me.cmdAcDcTi.ForeColorInLimits = System.Drawing.Color.LightSeaGreen
        Me.cmdAcDcTi.ForeColorOverLimit = System.Drawing.Color.Red
        Me.cmdAcDcTi.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.cmdAcDcTi.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAcDcTi.KeypadMaxValue = 10.0R
        Me.cmdAcDcTi.KeypadMinValue = 0.01R
        Me.cmdAcDcTi.KeypadPasscode = Nothing
        Me.cmdAcDcTi.KeypadScaleFactor = 1.0R
        Me.cmdAcDcTi.KeypadText = Nothing
        Me.cmdAcDcTi.KeypadWidth = 300
        Me.cmdAcDcTi.Location = New System.Drawing.Point(582, 189)
        Me.cmdAcDcTi.Name = "cmdAcDcTi"
        Me.cmdAcDcTi.NumericFormat = Nothing
        Me.cmdAcDcTi.PLCAddressKeypad = "HMI_ScaleAccDecTime_CMD"
        Me.cmdAcDcTi.PLCAddressValue = CType(resources.GetObject("cmdAcDcTi.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.cmdAcDcTi.PLCAddressValueLimitLower = Nothing
        Me.cmdAcDcTi.PLCAddressValueLimitUpper = Nothing
        Me.cmdAcDcTi.PLCAddressVisible = Nothing
        Me.cmdAcDcTi.ShowValue = True
        Me.cmdAcDcTi.Size = New System.Drawing.Size(192, 17)
        Me.cmdAcDcTi.TabIndex = 28
        Me.cmdAcDcTi.Text = "Command   000  Seconds"
        Me.cmdAcDcTi.Value = "000"
        Me.cmdAcDcTi.ValueLimitLower = 0.01R
        Me.cmdAcDcTi.ValueLimitUpper = 10.0R
        Me.cmdAcDcTi.ValuePrefix = "Command   "
        Me.cmdAcDcTi.ValueSuffix = "  Seconds"
        Me.cmdAcDcTi.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay13
        '
        Me.AnalogValueDisplay13.AutoSize = True
        Me.AnalogValueDisplay13.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay13.ForeColor = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay13.ForeColorInLimits = System.Drawing.Color.MediumSlateBlue
        Me.AnalogValueDisplay13.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay13.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay13.KeypadMaxValue = 1.0R
        Me.AnalogValueDisplay13.KeypadMinValue = 0.01R
        Me.AnalogValueDisplay13.KeypadPasscode = Nothing
        Me.AnalogValueDisplay13.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay13.KeypadText = Nothing
        Me.AnalogValueDisplay13.KeypadWidth = 300
        Me.AnalogValueDisplay13.Location = New System.Drawing.Point(582, 291)
        Me.AnalogValueDisplay13.Name = "AnalogValueDisplay13"
        Me.AnalogValueDisplay13.NumericFormat = Nothing
        Me.AnalogValueDisplay13.PLCAddressKeypad = ""
        Me.AnalogValueDisplay13.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay13.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay13.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay13.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay13.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay13.ShowValue = True
        Me.AnalogValueDisplay13.Size = New System.Drawing.Size(112, 17)
        Me.AnalogValueDisplay13.TabIndex = 33
        Me.AnalogValueDisplay13.Text = "Actual  000  G"
        Me.AnalogValueDisplay13.Value = "000"
        Me.AnalogValueDisplay13.ValueLimitLower = 0.01R
        Me.AnalogValueDisplay13.ValueLimitUpper = 1.0R
        Me.AnalogValueDisplay13.ValuePrefix = "Actual  "
        Me.AnalogValueDisplay13.ValueSuffix = "  G"
        Me.AnalogValueDisplay13.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label8.Location = New System.Drawing.Point(581, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "DMC Acc/Dec"
        '
        'cmdDMC
        '
        Me.cmdDMC.AutoSize = True
        Me.cmdDMC.ComComponent = Me.EthernetIPforCLXCom1
        Me.cmdDMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDMC.ForeColor = System.Drawing.Color.Yellow
        Me.cmdDMC.ForeColorInLimits = System.Drawing.Color.MediumSlateBlue
        Me.cmdDMC.ForeColorOverLimit = System.Drawing.Color.Red
        Me.cmdDMC.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.cmdDMC.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.cmdDMC.KeypadMaxValue = 1.0R
        Me.cmdDMC.KeypadMinValue = 0.01R
        Me.cmdDMC.KeypadPasscode = Nothing
        Me.cmdDMC.KeypadScaleFactor = 1.0R
        Me.cmdDMC.KeypadText = Nothing
        Me.cmdDMC.KeypadWidth = 300
        Me.cmdDMC.Location = New System.Drawing.Point(582, 274)
        Me.cmdDMC.Name = "cmdDMC"
        Me.cmdDMC.NumericFormat = Nothing
        Me.cmdDMC.PLCAddressKeypad = "HMI_DmcAccelDecel_CMD"
        Me.cmdDMC.PLCAddressValue = CType(resources.GetObject("cmdDMC.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.cmdDMC.PLCAddressValueLimitLower = Nothing
        Me.cmdDMC.PLCAddressValueLimitUpper = Nothing
        Me.cmdDMC.PLCAddressVisible = Nothing
        Me.cmdDMC.ShowValue = True
        Me.cmdDMC.Size = New System.Drawing.Size(142, 17)
        Me.cmdDMC.TabIndex = 31
        Me.cmdDMC.Text = "Command   000  G"
        Me.cmdDMC.Value = "000"
        Me.cmdDMC.ValueLimitLower = 0.01R
        Me.cmdDMC.ValueLimitUpper = 1.0R
        Me.cmdDMC.ValuePrefix = "Command   "
        Me.cmdDMC.ValueSuffix = "  G"
        Me.cmdDMC.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(312, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 32)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Belt Speeds"
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
        Me.LbDate.Location = New System.Drawing.Point(638, 377)
        Me.LbDate.Name = "LbDate"
        Me.LbDate.Size = New System.Drawing.Size(114, 25)
        Me.LbDate.TabIndex = 1446
        Me.LbDate.Text = "xx/xx/xxxx"
        '
        'LbClk
        '
        Me.LbClk.AutoSize = True
        Me.LbClk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClk.ForeColor = System.Drawing.Color.GhostWhite
        Me.LbClk.Location = New System.Drawing.Point(638, 402)
        Me.LbClk.Name = "LbClk"
        Me.LbClk.Size = New System.Drawing.Size(130, 25)
        Me.LbClk.TabIndex = 1445
        Me.LbClk.Text = "xx:xx:xx PM"
        '
        'BeltSpeeds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LbDate)
        Me.Controls.Add(Me.LbClk)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AnalogValueDisplay13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdDMC)
        Me.Controls.Add(Me.AnalogValueDisplay11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdAcDcTi)
        Me.Controls.Add(Me.AnalogValueDisplay9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdAlSp)
        Me.Controls.Add(Me.AnalogValueDisplay7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdVeSp)
        Me.Controls.Add(Me.AnalogValueDisplay5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdPrSp2)
        Me.Controls.Add(Me.AnalogValueDisplay3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdPrSp)
        Me.Controls.Add(Me.AnalogValueDisplay1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdBuSp)
        Me.Controls.Add(Me.BS_Exit)
        Me.Controls.Add(Me.actScSp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdScSp)
        Me.Name = "BeltSpeeds"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BeltSpeeds"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdScSp As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents Label1 As Label
    Friend WithEvents actScSp As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents BS_Exit As AdvancedHMIControls.BasicButton
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdBuSp As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay3 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdPrSp As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay5 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdPrSp2 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay7 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdVeSp As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay9 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdAlSp As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay11 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdAcDcTi As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay13 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdDMC As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Label9 As Label
    Friend WithEvents AnalogValueDisplay1 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents TiClk As Timer
    Friend WithEvents LbDate As Label
    Friend WithEvents LbClk As Label
End Class
