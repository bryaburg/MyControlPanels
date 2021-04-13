<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TampConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TampConfig))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lenInc = New AdvancedHMIControls.AnalogValueDisplay()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.AnalogValueDisplay1 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.TampConExit = New AdvancedHMIControls.BasicButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AnalogValueDisplay2 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay3 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.bOverRide = New AdvancedHMIControls.BasicButton()
        Me.AnalogValueDisplay4 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.BasicIndicator1 = New AdvancedHMIControls.BasicIndicator()
        Me.AnalogValueDisplay5 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay6 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay7 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay8 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay9 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay10 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.BasicIndicator2 = New AdvancedHMIControls.BasicIndicator()
        Me.AnalogValueDisplay11 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.AnalogValueDisplay12 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay13 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.AnalogValueDisplay14 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.TiClk = New System.Windows.Forms.Timer(Me.components)
        Me.LbDate = New System.Windows.Forms.Label()
        Me.LbClk = New System.Windows.Forms.Label()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label9.Location = New System.Drawing.Point(253, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(298, 32)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Tamp Configurations"
        '
        'lenInc
        '
        Me.lenInc.AutoSize = True
        Me.lenInc.ComComponent = Me.EthernetIPforCLXCom1
        Me.lenInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lenInc.ForeColor = System.Drawing.Color.DimGray
        Me.lenInc.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.lenInc.ForeColorOverLimit = System.Drawing.Color.Red
        Me.lenInc.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.lenInc.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.lenInc.KeypadMaxValue = 150.0R
        Me.lenInc.KeypadMinValue = 0R
        Me.lenInc.KeypadPasscode = Nothing
        Me.lenInc.KeypadScaleFactor = 1.0R
        Me.lenInc.KeypadText = Nothing
        Me.lenInc.KeypadWidth = 300
        Me.lenInc.Location = New System.Drawing.Point(12, 57)
        Me.lenInc.Name = "lenInc"
        Me.lenInc.NumericFormat = Nothing
        Me.lenInc.PLCAddressKeypad = "HMI_TampVelocity"
        Me.lenInc.PLCAddressValue = CType(resources.GetObject("lenInc.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.lenInc.PLCAddressValueLimitLower = Nothing
        Me.lenInc.PLCAddressValueLimitUpper = Nothing
        Me.lenInc.PLCAddressVisible = Nothing
        Me.lenInc.ShowValue = True
        Me.lenInc.Size = New System.Drawing.Size(308, 25)
        Me.lenInc.TabIndex = 39
        Me.lenInc.Text = "Servo Tamp Velocity 0000 IPS"
        Me.lenInc.Value = "0000"
        Me.lenInc.ValueLimitLower = 0R
        Me.lenInc.ValueLimitUpper = 150.0R
        Me.lenInc.ValuePrefix = "Servo Tamp Velocity "
        Me.lenInc.ValueSuffix = " IPS"
        Me.lenInc.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
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
        'AnalogValueDisplay1
        '
        Me.AnalogValueDisplay1.AutoSize = True
        Me.AnalogValueDisplay1.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay1.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay1.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay1.KeypadMaxValue = 150.0R
        Me.AnalogValueDisplay1.KeypadMinValue = 0R
        Me.AnalogValueDisplay1.KeypadPasscode = Nothing
        Me.AnalogValueDisplay1.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay1.KeypadText = Nothing
        Me.AnalogValueDisplay1.KeypadWidth = 300
        Me.AnalogValueDisplay1.Location = New System.Drawing.Point(384, 57)
        Me.AnalogValueDisplay1.Name = "AnalogValueDisplay1"
        Me.AnalogValueDisplay1.NumericFormat = Nothing
        Me.AnalogValueDisplay1.PLCAddressKeypad = "HMI_AccelDistance"
        Me.AnalogValueDisplay1.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay1.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay1.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay1.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay1.ShowValue = True
        Me.AnalogValueDisplay1.Size = New System.Drawing.Size(404, 25)
        Me.AnalogValueDisplay1.TabIndex = 40
        Me.AnalogValueDisplay1.Text = "Servo Tamp Accel Distance 0000 Inches"
        Me.AnalogValueDisplay1.Value = "0000"
        Me.AnalogValueDisplay1.ValueLimitLower = 0R
        Me.AnalogValueDisplay1.ValueLimitUpper = 150.0R
        Me.AnalogValueDisplay1.ValuePrefix = "Servo Tamp Accel Distance "
        Me.AnalogValueDisplay1.ValueSuffix = " Inches"
        Me.AnalogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'TampConExit
        '
        Me.TampConExit.BackColor = System.Drawing.Color.Blue
        Me.TampConExit.ComComponent = Me.EthernetIPforCLXCom1
        Me.TampConExit.Font = New System.Drawing.Font("Magneto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TampConExit.ForeColor = System.Drawing.Color.GhostWhite
        Me.TampConExit.ForeColorAltername = System.Drawing.Color.Black
        Me.TampConExit.Highlight = False
        Me.TampConExit.HighlightColor = System.Drawing.Color.Green
        Me.TampConExit.Location = New System.Drawing.Point(198, 441)
        Me.TampConExit.MaximumHoldTime = 3000
        Me.TampConExit.MinimumHoldTime = 500
        Me.TampConExit.Name = "TampConExit"
        Me.TampConExit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.TampConExit.PLCAddressClick = ""
        Me.TampConExit.SelectTextAlternate = False
        Me.TampConExit.Size = New System.Drawing.Size(394, 49)
        Me.TampConExit.TabIndex = 43
        Me.TampConExit.Text = "Exit Tamp Configuration"
        Me.TampConExit.TextAlternate = Nothing
        Me.TampConExit.UseVisualStyleBackColor = False
        Me.TampConExit.ValueToWrite = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 32)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Printer 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(383, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 32)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Printer 2"
        '
        'AnalogValueDisplay2
        '
        Me.AnalogValueDisplay2.AutoSize = True
        Me.AnalogValueDisplay2.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay2.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay2.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay2.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay2.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay2.KeypadMaxValue = 20.0R
        Me.AnalogValueDisplay2.KeypadMinValue = 4.0R
        Me.AnalogValueDisplay2.KeypadPasscode = Nothing
        Me.AnalogValueDisplay2.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay2.KeypadText = Nothing
        Me.AnalogValueDisplay2.KeypadWidth = 300
        Me.AnalogValueDisplay2.Location = New System.Drawing.Point(16, 138)
        Me.AnalogValueDisplay2.Name = "AnalogValueDisplay2"
        Me.AnalogValueDisplay2.NumericFormat = Nothing
        Me.AnalogValueDisplay2.PLCAddressKeypad = ""
        Me.AnalogValueDisplay2.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay2.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay2.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay2.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay2.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay2.ShowValue = True
        Me.AnalogValueDisplay2.Size = New System.Drawing.Size(123, 25)
        Me.AnalogValueDisplay2.TabIndex = 46
        Me.AnalogValueDisplay2.Text = "Auto  0000 "
        Me.AnalogValueDisplay2.Value = "0000"
        Me.AnalogValueDisplay2.ValueLimitLower = 0R
        Me.AnalogValueDisplay2.ValueLimitUpper = 150.0R
        Me.AnalogValueDisplay2.ValuePrefix = "Auto  "
        Me.AnalogValueDisplay2.ValueSuffix = " "
        Me.AnalogValueDisplay2.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay3
        '
        Me.AnalogValueDisplay3.AutoSize = True
        Me.AnalogValueDisplay3.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay3.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay3.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay3.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay3.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay3.KeypadMaxValue = 1000.0R
        Me.AnalogValueDisplay3.KeypadMinValue = 0R
        Me.AnalogValueDisplay3.KeypadPasscode = Nothing
        Me.AnalogValueDisplay3.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay3.KeypadText = Nothing
        Me.AnalogValueDisplay3.KeypadWidth = 300
        Me.AnalogValueDisplay3.Location = New System.Drawing.Point(17, 175)
        Me.AnalogValueDisplay3.Name = "AnalogValueDisplay3"
        Me.AnalogValueDisplay3.NumericFormat = Nothing
        Me.AnalogValueDisplay3.PLCAddressKeypad = "Apply1_Tamp.Val_OverrideScalar"
        Me.AnalogValueDisplay3.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay3.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay3.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay3.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay3.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay3.ShowValue = True
        Me.AnalogValueDisplay3.Size = New System.Drawing.Size(155, 25)
        Me.AnalogValueDisplay3.TabIndex = 47
        Me.AnalogValueDisplay3.Text = "Override  0000"
        Me.AnalogValueDisplay3.Value = "0000"
        Me.AnalogValueDisplay3.ValueLimitLower = 0R
        Me.AnalogValueDisplay3.ValueLimitUpper = 1000.0R
        Me.AnalogValueDisplay3.ValuePrefix = "Override  "
        Me.AnalogValueDisplay3.ValueSuffix = Nothing
        Me.AnalogValueDisplay3.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'bOverRide
        '
        Me.bOverRide.BackColor = System.Drawing.Color.DimGray
        Me.bOverRide.ComComponent = Me.EthernetIPforCLXCom1
        Me.bOverRide.ForeColor = System.Drawing.Color.GhostWhite
        Me.bOverRide.ForeColorAltername = System.Drawing.Color.Black
        Me.bOverRide.Highlight = False
        Me.bOverRide.HighlightColor = System.Drawing.Color.Green
        Me.bOverRide.Location = New System.Drawing.Point(188, 175)
        Me.bOverRide.MaximumHoldTime = 3000
        Me.bOverRide.MinimumHoldTime = 500
        Me.bOverRide.Name = "bOverRide"
        Me.bOverRide.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.bOverRide.PLCAddressClick = "Apply1_Tamp.In_Override"
        Me.bOverRide.PLCAddressSelectTextAlternate = "Apply1_Tamp.In_Override"
        Me.bOverRide.PLCAddressVisible = "gPar_ServoApplicator"
        Me.bOverRide.SelectTextAlternate = False
        Me.bOverRide.Size = New System.Drawing.Size(75, 23)
        Me.bOverRide.TabIndex = 48
        Me.bOverRide.Text = "Auto"
        Me.bOverRide.TextAlternate = "Overridden"
        Me.bOverRide.UseVisualStyleBackColor = False
        Me.bOverRide.ValueToWrite = 0
        '
        'AnalogValueDisplay4
        '
        Me.AnalogValueDisplay4.AutoSize = True
        Me.AnalogValueDisplay4.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay4.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay4.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay4.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay4.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay4.KeypadMaxValue = 30.0R
        Me.AnalogValueDisplay4.KeypadMinValue = 0R
        Me.AnalogValueDisplay4.KeypadPasscode = Nothing
        Me.AnalogValueDisplay4.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay4.KeypadText = Nothing
        Me.AnalogValueDisplay4.KeypadWidth = 300
        Me.AnalogValueDisplay4.Location = New System.Drawing.Point(13, 282)
        Me.AnalogValueDisplay4.Name = "AnalogValueDisplay4"
        Me.AnalogValueDisplay4.NumericFormat = Nothing
        Me.AnalogValueDisplay4.PLCAddressKeypad = "HMI_UPTR1_TampHeight"
        Me.AnalogValueDisplay4.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay4.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay4.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay4.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay4.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay4.ShowValue = True
        Me.AnalogValueDisplay4.Size = New System.Drawing.Size(259, 25)
        Me.AnalogValueDisplay4.TabIndex = 49
        Me.AnalogValueDisplay4.Text = "Tamp Height 0000 Inches"
        Me.AnalogValueDisplay4.Value = "0000"
        Me.AnalogValueDisplay4.ValueLimitLower = 0R
        Me.AnalogValueDisplay4.ValueLimitUpper = 30.0R
        Me.AnalogValueDisplay4.ValuePrefix = "Tamp Height "
        Me.AnalogValueDisplay4.ValueSuffix = " Inches"
        Me.AnalogValueDisplay4.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'BasicIndicator1
        '
        Me.BasicIndicator1.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator1.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator1.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator1.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator1.Location = New System.Drawing.Point(21, 204)
        Me.BasicIndicator1.Name = "BasicIndicator1"
        Me.BasicIndicator1.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator1.OutlineWidth = 1
        Me.BasicIndicator1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator1.PLCAddressSelectColor2 = "Apply1_Tamp.In_TampActive"
        Me.BasicIndicator1.SelectColor2 = False
        Me.BasicIndicator1.SelectColor3 = False
        Me.BasicIndicator1.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator1.Size = New System.Drawing.Size(250, 39)
        Me.BasicIndicator1.TabIndex = 50
        Me.BasicIndicator1.Text = "Tamp Active"
        '
        'AnalogValueDisplay5
        '
        Me.AnalogValueDisplay5.AutoSize = True
        Me.AnalogValueDisplay5.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay5.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay5.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay5.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay5.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay5.KeypadMaxValue = 20.0R
        Me.AnalogValueDisplay5.KeypadMinValue = 4.0R
        Me.AnalogValueDisplay5.KeypadPasscode = Nothing
        Me.AnalogValueDisplay5.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay5.KeypadText = Nothing
        Me.AnalogValueDisplay5.KeypadWidth = 300
        Me.AnalogValueDisplay5.Location = New System.Drawing.Point(17, 246)
        Me.AnalogValueDisplay5.Name = "AnalogValueDisplay5"
        Me.AnalogValueDisplay5.NumericFormat = Nothing
        Me.AnalogValueDisplay5.PLCAddressKeypad = ""
        Me.AnalogValueDisplay5.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay5.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay5.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay5.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay5.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay5.ShowValue = True
        Me.AnalogValueDisplay5.Size = New System.Drawing.Size(221, 25)
        Me.AnalogValueDisplay5.TabIndex = 51
        Me.AnalogValueDisplay5.Text = "Average Scalar 0000 "
        Me.AnalogValueDisplay5.Value = "0000"
        Me.AnalogValueDisplay5.ValueLimitLower = 0R
        Me.AnalogValueDisplay5.ValueLimitUpper = 150.0R
        Me.AnalogValueDisplay5.ValuePrefix = "Average Scalar "
        Me.AnalogValueDisplay5.ValueSuffix = " "
        Me.AnalogValueDisplay5.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay6
        '
        Me.AnalogValueDisplay6.AutoSize = True
        Me.AnalogValueDisplay6.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay6.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay6.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay6.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay6.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay6.KeypadMaxValue = 55.0R
        Me.AnalogValueDisplay6.KeypadMinValue = 0R
        Me.AnalogValueDisplay6.KeypadPasscode = Nothing
        Me.AnalogValueDisplay6.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay6.KeypadText = Nothing
        Me.AnalogValueDisplay6.KeypadWidth = 300
        Me.AnalogValueDisplay6.Location = New System.Drawing.Point(16, 318)
        Me.AnalogValueDisplay6.Name = "AnalogValueDisplay6"
        Me.AnalogValueDisplay6.NumericFormat = Nothing
        Me.AnalogValueDisplay6.PLCAddressKeypad = "HMI_UPTR1_DistanceFromInduct"
        Me.AnalogValueDisplay6.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay6.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay6.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay6.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay6.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay6.ShowValue = True
        Me.AnalogValueDisplay6.Size = New System.Drawing.Size(274, 25)
        Me.AnalogValueDisplay6.TabIndex = 52
        Me.AnalogValueDisplay6.Text = "Stop To Apply 0000 Inches"
        Me.AnalogValueDisplay6.Value = "0000"
        Me.AnalogValueDisplay6.ValueLimitLower = 0R
        Me.AnalogValueDisplay6.ValueLimitUpper = 55.0R
        Me.AnalogValueDisplay6.ValuePrefix = "Stop To Apply "
        Me.AnalogValueDisplay6.ValueSuffix = " Inches"
        Me.AnalogValueDisplay6.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay7
        '
        Me.AnalogValueDisplay7.AutoSize = True
        Me.AnalogValueDisplay7.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay7.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay7.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay7.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay7.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay7.KeypadMaxValue = 55.0R
        Me.AnalogValueDisplay7.KeypadMinValue = 0R
        Me.AnalogValueDisplay7.KeypadPasscode = Nothing
        Me.AnalogValueDisplay7.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay7.KeypadText = Nothing
        Me.AnalogValueDisplay7.KeypadWidth = 300
        Me.AnalogValueDisplay7.Location = New System.Drawing.Point(16, 353)
        Me.AnalogValueDisplay7.Name = "AnalogValueDisplay7"
        Me.AnalogValueDisplay7.NumericFormat = Nothing
        Me.AnalogValueDisplay7.PLCAddressKeypad = "HMI_UPTR1_TampDistance"
        Me.AnalogValueDisplay7.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay7.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay7.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay7.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay7.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay7.ShowValue = True
        Me.AnalogValueDisplay7.Size = New System.Drawing.Size(305, 25)
        Me.AnalogValueDisplay7.TabIndex = 53
        Me.AnalogValueDisplay7.Text = "Apply On The Fly 0000 Inches"
        Me.AnalogValueDisplay7.Value = "0000"
        Me.AnalogValueDisplay7.ValueLimitLower = 0R
        Me.AnalogValueDisplay7.ValueLimitUpper = 55.0R
        Me.AnalogValueDisplay7.ValuePrefix = "Apply On The Fly "
        Me.AnalogValueDisplay7.ValueSuffix = " Inches"
        Me.AnalogValueDisplay7.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay8
        '
        Me.AnalogValueDisplay8.AutoSize = True
        Me.AnalogValueDisplay8.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay8.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay8.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay8.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay8.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay8.KeypadMaxValue = 55.0R
        Me.AnalogValueDisplay8.KeypadMinValue = 0R
        Me.AnalogValueDisplay8.KeypadPasscode = Nothing
        Me.AnalogValueDisplay8.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay8.KeypadText = Nothing
        Me.AnalogValueDisplay8.KeypadWidth = 300
        Me.AnalogValueDisplay8.Location = New System.Drawing.Point(387, 353)
        Me.AnalogValueDisplay8.Name = "AnalogValueDisplay8"
        Me.AnalogValueDisplay8.NumericFormat = Nothing
        Me.AnalogValueDisplay8.PLCAddressKeypad = "HMI_UPTR2_TampDistance"
        Me.AnalogValueDisplay8.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay8.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay8.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay8.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay8.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay8.ShowValue = True
        Me.AnalogValueDisplay8.Size = New System.Drawing.Size(305, 25)
        Me.AnalogValueDisplay8.TabIndex = 61
        Me.AnalogValueDisplay8.Text = "Apply On The Fly 0000 Inches"
        Me.AnalogValueDisplay8.Value = "0000"
        Me.AnalogValueDisplay8.ValueLimitLower = 0R
        Me.AnalogValueDisplay8.ValueLimitUpper = 55.0R
        Me.AnalogValueDisplay8.ValuePrefix = "Apply On The Fly "
        Me.AnalogValueDisplay8.ValueSuffix = " Inches"
        Me.AnalogValueDisplay8.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay9
        '
        Me.AnalogValueDisplay9.AutoSize = True
        Me.AnalogValueDisplay9.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay9.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay9.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay9.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay9.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay9.KeypadMaxValue = 55.0R
        Me.AnalogValueDisplay9.KeypadMinValue = 0R
        Me.AnalogValueDisplay9.KeypadPasscode = Nothing
        Me.AnalogValueDisplay9.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay9.KeypadText = Nothing
        Me.AnalogValueDisplay9.KeypadWidth = 300
        Me.AnalogValueDisplay9.Location = New System.Drawing.Point(387, 318)
        Me.AnalogValueDisplay9.Name = "AnalogValueDisplay9"
        Me.AnalogValueDisplay9.NumericFormat = Nothing
        Me.AnalogValueDisplay9.PLCAddressKeypad = "HMI_UPTR2_DistanceFromInduct"
        Me.AnalogValueDisplay9.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay9.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay9.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay9.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay9.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay9.ShowValue = True
        Me.AnalogValueDisplay9.Size = New System.Drawing.Size(274, 25)
        Me.AnalogValueDisplay9.TabIndex = 60
        Me.AnalogValueDisplay9.Text = "Stop To Apply 0000 Inches"
        Me.AnalogValueDisplay9.Value = "0000"
        Me.AnalogValueDisplay9.ValueLimitLower = 0R
        Me.AnalogValueDisplay9.ValueLimitUpper = 55.0R
        Me.AnalogValueDisplay9.ValuePrefix = "Stop To Apply "
        Me.AnalogValueDisplay9.ValueSuffix = " Inches"
        Me.AnalogValueDisplay9.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay10
        '
        Me.AnalogValueDisplay10.AutoSize = True
        Me.AnalogValueDisplay10.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay10.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay10.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay10.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay10.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay10.KeypadMaxValue = 20.0R
        Me.AnalogValueDisplay10.KeypadMinValue = 4.0R
        Me.AnalogValueDisplay10.KeypadPasscode = Nothing
        Me.AnalogValueDisplay10.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay10.KeypadText = Nothing
        Me.AnalogValueDisplay10.KeypadWidth = 300
        Me.AnalogValueDisplay10.Location = New System.Drawing.Point(388, 246)
        Me.AnalogValueDisplay10.Name = "AnalogValueDisplay10"
        Me.AnalogValueDisplay10.NumericFormat = Nothing
        Me.AnalogValueDisplay10.PLCAddressKeypad = ""
        Me.AnalogValueDisplay10.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay10.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay10.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay10.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay10.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay10.ShowValue = True
        Me.AnalogValueDisplay10.Size = New System.Drawing.Size(221, 25)
        Me.AnalogValueDisplay10.TabIndex = 59
        Me.AnalogValueDisplay10.Text = "Average Scalar 0000 "
        Me.AnalogValueDisplay10.Value = "0000"
        Me.AnalogValueDisplay10.ValueLimitLower = 0R
        Me.AnalogValueDisplay10.ValueLimitUpper = 150.0R
        Me.AnalogValueDisplay10.ValuePrefix = "Average Scalar "
        Me.AnalogValueDisplay10.ValueSuffix = " "
        Me.AnalogValueDisplay10.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'BasicIndicator2
        '
        Me.BasicIndicator2.Color1 = System.Drawing.Color.DimGray
        Me.BasicIndicator2.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator2.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator2.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator2.Location = New System.Drawing.Point(392, 204)
        Me.BasicIndicator2.Name = "BasicIndicator2"
        Me.BasicIndicator2.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator2.OutlineWidth = 1
        Me.BasicIndicator2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator2.PLCAddressSelectColor2 = "Apply2_Tamp.In_TampActive"
        Me.BasicIndicator2.SelectColor2 = False
        Me.BasicIndicator2.SelectColor3 = False
        Me.BasicIndicator2.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Round
        Me.BasicIndicator2.Size = New System.Drawing.Size(250, 39)
        Me.BasicIndicator2.TabIndex = 58
        Me.BasicIndicator2.Text = "Tamp Active"
        '
        'AnalogValueDisplay11
        '
        Me.AnalogValueDisplay11.AutoSize = True
        Me.AnalogValueDisplay11.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay11.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay11.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay11.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay11.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay11.KeypadMaxValue = 30.0R
        Me.AnalogValueDisplay11.KeypadMinValue = 0R
        Me.AnalogValueDisplay11.KeypadPasscode = Nothing
        Me.AnalogValueDisplay11.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay11.KeypadText = Nothing
        Me.AnalogValueDisplay11.KeypadWidth = 300
        Me.AnalogValueDisplay11.Location = New System.Drawing.Point(384, 282)
        Me.AnalogValueDisplay11.Name = "AnalogValueDisplay11"
        Me.AnalogValueDisplay11.NumericFormat = Nothing
        Me.AnalogValueDisplay11.PLCAddressKeypad = "HMI_UPTR2_TampHeight"
        Me.AnalogValueDisplay11.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay11.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay11.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay11.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay11.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay11.ShowValue = True
        Me.AnalogValueDisplay11.Size = New System.Drawing.Size(259, 25)
        Me.AnalogValueDisplay11.TabIndex = 57
        Me.AnalogValueDisplay11.Text = "Tamp Height 0000 Inches"
        Me.AnalogValueDisplay11.Value = "0000"
        Me.AnalogValueDisplay11.ValueLimitLower = 0R
        Me.AnalogValueDisplay11.ValueLimitUpper = 30.0R
        Me.AnalogValueDisplay11.ValuePrefix = "Tamp Height "
        Me.AnalogValueDisplay11.ValueSuffix = " Inches"
        Me.AnalogValueDisplay11.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.DimGray
        Me.BasicButton1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicButton1.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(559, 175)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BasicButton1.PLCAddressClick = "Apply2_Tamp.In_Override"
        Me.BasicButton1.PLCAddressSelectTextAlternate = "Apply2_Tamp.In_Override"
        Me.BasicButton1.PLCAddressVisible = "gPar_ServoApplicator"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton1.TabIndex = 56
        Me.BasicButton1.Text = "Auto"
        Me.BasicButton1.TextAlternate = "Overridden"
        Me.BasicButton1.UseVisualStyleBackColor = False
        Me.BasicButton1.ValueToWrite = 0
        '
        'AnalogValueDisplay12
        '
        Me.AnalogValueDisplay12.AutoSize = True
        Me.AnalogValueDisplay12.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay12.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay12.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay12.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay12.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay12.KeypadMaxValue = 1000.0R
        Me.AnalogValueDisplay12.KeypadMinValue = 0R
        Me.AnalogValueDisplay12.KeypadPasscode = Nothing
        Me.AnalogValueDisplay12.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay12.KeypadText = Nothing
        Me.AnalogValueDisplay12.KeypadWidth = 300
        Me.AnalogValueDisplay12.Location = New System.Drawing.Point(388, 175)
        Me.AnalogValueDisplay12.Name = "AnalogValueDisplay12"
        Me.AnalogValueDisplay12.NumericFormat = Nothing
        Me.AnalogValueDisplay12.PLCAddressKeypad = "Apply2_Tamp.Val_OverrideScalar"
        Me.AnalogValueDisplay12.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay12.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay12.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay12.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay12.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay12.ShowValue = True
        Me.AnalogValueDisplay12.Size = New System.Drawing.Size(155, 25)
        Me.AnalogValueDisplay12.TabIndex = 55
        Me.AnalogValueDisplay12.Text = "Override  0000"
        Me.AnalogValueDisplay12.Value = "0000"
        Me.AnalogValueDisplay12.ValueLimitLower = 0R
        Me.AnalogValueDisplay12.ValueLimitUpper = 1000.0R
        Me.AnalogValueDisplay12.ValuePrefix = "Override  "
        Me.AnalogValueDisplay12.ValueSuffix = Nothing
        Me.AnalogValueDisplay12.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay13
        '
        Me.AnalogValueDisplay13.AutoSize = True
        Me.AnalogValueDisplay13.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay13.ForeColor = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay13.ForeColorInLimits = System.Drawing.Color.DimGray
        Me.AnalogValueDisplay13.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay13.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay13.KeypadMaxValue = 20.0R
        Me.AnalogValueDisplay13.KeypadMinValue = 4.0R
        Me.AnalogValueDisplay13.KeypadPasscode = Nothing
        Me.AnalogValueDisplay13.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay13.KeypadText = Nothing
        Me.AnalogValueDisplay13.KeypadWidth = 300
        Me.AnalogValueDisplay13.Location = New System.Drawing.Point(387, 138)
        Me.AnalogValueDisplay13.Name = "AnalogValueDisplay13"
        Me.AnalogValueDisplay13.NumericFormat = Nothing
        Me.AnalogValueDisplay13.PLCAddressKeypad = ""
        Me.AnalogValueDisplay13.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay13.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay13.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay13.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay13.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay13.ShowValue = True
        Me.AnalogValueDisplay13.Size = New System.Drawing.Size(123, 25)
        Me.AnalogValueDisplay13.TabIndex = 54
        Me.AnalogValueDisplay13.Text = "Auto  0000 "
        Me.AnalogValueDisplay13.Value = "0000"
        Me.AnalogValueDisplay13.ValueLimitLower = 0R
        Me.AnalogValueDisplay13.ValueLimitUpper = 150.0R
        Me.AnalogValueDisplay13.ValuePrefix = "Auto  "
        Me.AnalogValueDisplay13.ValueSuffix = " "
        Me.AnalogValueDisplay13.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'AnalogValueDisplay14
        '
        Me.AnalogValueDisplay14.AutoSize = True
        Me.AnalogValueDisplay14.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogValueDisplay14.ForeColor = System.Drawing.Color.GhostWhite
        Me.AnalogValueDisplay14.ForeColorInLimits = System.Drawing.Color.GhostWhite
        Me.AnalogValueDisplay14.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay14.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay14.KeypadMaxValue = 40.0R
        Me.AnalogValueDisplay14.KeypadMinValue = 0R
        Me.AnalogValueDisplay14.KeypadPasscode = Nothing
        Me.AnalogValueDisplay14.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay14.KeypadText = Nothing
        Me.AnalogValueDisplay14.KeypadWidth = 300
        Me.AnalogValueDisplay14.Location = New System.Drawing.Point(91, 399)
        Me.AnalogValueDisplay14.Name = "AnalogValueDisplay14"
        Me.AnalogValueDisplay14.NumericFormat = Nothing
        Me.AnalogValueDisplay14.PLCAddressKeypad = "HMI_StopToApplyGap"
        Me.AnalogValueDisplay14.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay14.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay14.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay14.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay14.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay14.ShowValue = True
        Me.AnalogValueDisplay14.Size = New System.Drawing.Size(655, 25)
        Me.AnalogValueDisplay14.TabIndex = 62
        Me.AnalogValueDisplay14.Text = "Stop To Apply Gap To Top 0000 Inches (5 Inches Recommended) "
        Me.AnalogValueDisplay14.Value = "0000"
        Me.AnalogValueDisplay14.ValueLimitLower = 0R
        Me.AnalogValueDisplay14.ValueLimitUpper = 40.0R
        Me.AnalogValueDisplay14.ValuePrefix = "Stop To Apply Gap To Top "
        Me.AnalogValueDisplay14.ValueSuffix = " Inches (5 Inches Recommended) "
        Me.AnalogValueDisplay14.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
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
        Me.LbDate.Location = New System.Drawing.Point(647, 440)
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
        Me.LbClk.Location = New System.Drawing.Point(647, 465)
        Me.LbClk.Name = "LbClk"
        Me.LbClk.Size = New System.Drawing.Size(130, 25)
        Me.LbClk.TabIndex = 1443
        Me.LbClk.Text = "xx:xx:xx PM"
        '
        'TampConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(800, 502)
        Me.Controls.Add(Me.LbDate)
        Me.Controls.Add(Me.LbClk)
        Me.Controls.Add(Me.AnalogValueDisplay14)
        Me.Controls.Add(Me.AnalogValueDisplay8)
        Me.Controls.Add(Me.AnalogValueDisplay9)
        Me.Controls.Add(Me.AnalogValueDisplay10)
        Me.Controls.Add(Me.BasicIndicator2)
        Me.Controls.Add(Me.AnalogValueDisplay11)
        Me.Controls.Add(Me.BasicButton1)
        Me.Controls.Add(Me.AnalogValueDisplay12)
        Me.Controls.Add(Me.AnalogValueDisplay13)
        Me.Controls.Add(Me.AnalogValueDisplay7)
        Me.Controls.Add(Me.AnalogValueDisplay6)
        Me.Controls.Add(Me.AnalogValueDisplay5)
        Me.Controls.Add(Me.BasicIndicator1)
        Me.Controls.Add(Me.AnalogValueDisplay4)
        Me.Controls.Add(Me.bOverRide)
        Me.Controls.Add(Me.AnalogValueDisplay3)
        Me.Controls.Add(Me.AnalogValueDisplay2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TampConExit)
        Me.Controls.Add(Me.AnalogValueDisplay1)
        Me.Controls.Add(Me.lenInc)
        Me.Controls.Add(Me.Label9)
        Me.Name = "TampConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tamp Configuration"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents lenInc As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents AnalogValueDisplay1 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents TampConExit As AdvancedHMIControls.BasicButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AnalogValueDisplay2 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay3 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents bOverRide As AdvancedHMIControls.BasicButton
    Friend WithEvents AnalogValueDisplay4 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents BasicIndicator1 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents AnalogValueDisplay5 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay6 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay7 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay8 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay9 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay10 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents BasicIndicator2 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents AnalogValueDisplay11 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents AnalogValueDisplay12 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay13 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents AnalogValueDisplay14 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents TiClk As Timer
    Friend WithEvents LbDate As Label
    Friend WithEvents LbClk As Label
End Class
