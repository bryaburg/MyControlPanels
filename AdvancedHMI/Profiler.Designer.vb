<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profiler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profiler))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lenInc = New AdvancedHMIControls.AnalogValueDisplay()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.offInc = New AdvancedHMIControls.AnalogValueDisplay()
        Me.minLenInc = New AdvancedHMIControls.AnalogValueDisplay()
        Me.maxLenInc = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Pro_Exit = New AdvancedHMIControls.BasicButton()
        Me.ChartBySampling1 = New AdvancedHMIControls.ChartBySampling()
        Me.TiClk = New System.Windows.Forms.Timer(Me.components)
        Me.LbDate = New System.Windows.Forms.Label()
        Me.LbClk = New System.Windows.Forms.Label()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartBySampling1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.Label9.Location = New System.Drawing.Point(323, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 32)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Profiler"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(28, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Label Definition"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Label8.Location = New System.Drawing.Point(535, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Package Defintion"
        '
        'lenInc
        '
        Me.lenInc.AutoSize = True
        Me.lenInc.ComComponent = Me.EthernetIPforCLXCom1
        Me.lenInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lenInc.ForeColor = System.Drawing.Color.Yellow
        Me.lenInc.ForeColorInLimits = System.Drawing.Color.DeepSkyBlue
        Me.lenInc.ForeColorOverLimit = System.Drawing.Color.Red
        Me.lenInc.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.lenInc.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.lenInc.KeypadMaxValue = 20.0R
        Me.lenInc.KeypadMinValue = 4.0R
        Me.lenInc.KeypadPasscode = Nothing
        Me.lenInc.KeypadScaleFactor = 1.0R
        Me.lenInc.KeypadText = Nothing
        Me.lenInc.KeypadWidth = 300
        Me.lenInc.Location = New System.Drawing.Point(27, 365)
        Me.lenInc.Name = "lenInc"
        Me.lenInc.NumericFormat = Nothing
        Me.lenInc.PLCAddressKeypad = "HMI_LabelLength"
        Me.lenInc.PLCAddressValue = CType(resources.GetObject("lenInc.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.lenInc.PLCAddressValueLimitLower = Nothing
        Me.lenInc.PLCAddressValueLimitUpper = Nothing
        Me.lenInc.PLCAddressVisible = Nothing
        Me.lenInc.ShowValue = True
        Me.lenInc.Size = New System.Drawing.Size(202, 25)
        Me.lenInc.TabIndex = 38
        Me.lenInc.Text = "Length 0000 Inches"
        Me.lenInc.Value = "0000"
        Me.lenInc.ValueLimitLower = 4.0R
        Me.lenInc.ValueLimitUpper = 20.0R
        Me.lenInc.ValuePrefix = "Length "
        Me.lenInc.ValueSuffix = " Inches"
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
        'offInc
        '
        Me.offInc.AutoSize = True
        Me.offInc.ComComponent = Me.EthernetIPforCLXCom1
        Me.offInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.offInc.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.offInc.ForeColorInLimits = System.Drawing.Color.DeepSkyBlue
        Me.offInc.ForeColorOverLimit = System.Drawing.Color.Red
        Me.offInc.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.offInc.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.offInc.KeypadMaxValue = 3.0R
        Me.offInc.KeypadMinValue = -3.0R
        Me.offInc.KeypadPasscode = Nothing
        Me.offInc.KeypadScaleFactor = 1.0R
        Me.offInc.KeypadText = Nothing
        Me.offInc.KeypadWidth = 300
        Me.offInc.Location = New System.Drawing.Point(27, 399)
        Me.offInc.Name = "offInc"
        Me.offInc.NumericFormat = Nothing
        Me.offInc.PLCAddressKeypad = "HMI_LabelZoneOffset"
        Me.offInc.PLCAddressValue = CType(resources.GetObject("offInc.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.offInc.PLCAddressValueLimitLower = Nothing
        Me.offInc.PLCAddressValueLimitUpper = Nothing
        Me.offInc.PLCAddressVisible = Nothing
        Me.offInc.ShowValue = True
        Me.offInc.Size = New System.Drawing.Size(194, 25)
        Me.offInc.TabIndex = 39
        Me.offInc.Text = "Offset 0000 Inches"
        Me.offInc.Value = "0000"
        Me.offInc.ValueLimitLower = -3.0R
        Me.offInc.ValueLimitUpper = 3.0R
        Me.offInc.ValuePrefix = "Offset "
        Me.offInc.ValueSuffix = " Inches"
        Me.offInc.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'minLenInc
        '
        Me.minLenInc.AutoSize = True
        Me.minLenInc.ComComponent = Me.EthernetIPforCLXCom1
        Me.minLenInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minLenInc.ForeColor = System.Drawing.Color.Yellow
        Me.minLenInc.ForeColorInLimits = System.Drawing.Color.MediumSlateBlue
        Me.minLenInc.ForeColorOverLimit = System.Drawing.Color.Red
        Me.minLenInc.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.minLenInc.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.minLenInc.KeypadMaxValue = 30.0R
        Me.minLenInc.KeypadMinValue = 1.0R
        Me.minLenInc.KeypadPasscode = Nothing
        Me.minLenInc.KeypadScaleFactor = 1.0R
        Me.minLenInc.KeypadText = Nothing
        Me.minLenInc.KeypadWidth = 300
        Me.minLenInc.Location = New System.Drawing.Point(534, 399)
        Me.minLenInc.Name = "minLenInc"
        Me.minLenInc.NumericFormat = Nothing
        Me.minLenInc.PLCAddressKeypad = "HMI_MinPackageLength"
        Me.minLenInc.PLCAddressValue = CType(resources.GetObject("minLenInc.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.minLenInc.PLCAddressValueLimitLower = Nothing
        Me.minLenInc.PLCAddressValueLimitUpper = Nothing
        Me.minLenInc.PLCAddressVisible = Nothing
        Me.minLenInc.ShowValue = True
        Me.minLenInc.Size = New System.Drawing.Size(243, 25)
        Me.minLenInc.TabIndex = 41
        Me.minLenInc.Text = "Min Length 0000 Inches"
        Me.minLenInc.Value = "0000"
        Me.minLenInc.ValueLimitLower = 1.0R
        Me.minLenInc.ValueLimitUpper = 30.0R
        Me.minLenInc.ValuePrefix = "Min Length "
        Me.minLenInc.ValueSuffix = " Inches"
        Me.minLenInc.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'maxLenInc
        '
        Me.maxLenInc.AutoSize = True
        Me.maxLenInc.ComComponent = Me.EthernetIPforCLXCom1
        Me.maxLenInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxLenInc.ForeColor = System.Drawing.Color.Yellow
        Me.maxLenInc.ForeColorInLimits = System.Drawing.Color.MediumSlateBlue
        Me.maxLenInc.ForeColorOverLimit = System.Drawing.Color.Red
        Me.maxLenInc.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.maxLenInc.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.maxLenInc.KeypadMaxValue = 52.0R
        Me.maxLenInc.KeypadMinValue = 4.0R
        Me.maxLenInc.KeypadPasscode = Nothing
        Me.maxLenInc.KeypadScaleFactor = 1.0R
        Me.maxLenInc.KeypadText = Nothing
        Me.maxLenInc.KeypadWidth = 300
        Me.maxLenInc.Location = New System.Drawing.Point(534, 365)
        Me.maxLenInc.Name = "maxLenInc"
        Me.maxLenInc.NumericFormat = Nothing
        Me.maxLenInc.PLCAddressKeypad = "HMI_LongestExpectedPackage"
        Me.maxLenInc.PLCAddressValue = CType(resources.GetObject("maxLenInc.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.maxLenInc.PLCAddressValueLimitLower = Nothing
        Me.maxLenInc.PLCAddressValueLimitUpper = Nothing
        Me.maxLenInc.PLCAddressVisible = Nothing
        Me.maxLenInc.ShowValue = True
        Me.maxLenInc.Size = New System.Drawing.Size(249, 25)
        Me.maxLenInc.TabIndex = 40
        Me.maxLenInc.Text = "Max Length 0000 Inches"
        Me.maxLenInc.Value = "0000"
        Me.maxLenInc.ValueLimitLower = 4.0R
        Me.maxLenInc.ValueLimitUpper = 52.0R
        Me.maxLenInc.ValuePrefix = "Max Length "
        Me.maxLenInc.ValueSuffix = " Inches"
        Me.maxLenInc.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Pro_Exit
        '
        Me.Pro_Exit.BackColor = System.Drawing.Color.Blue
        Me.Pro_Exit.ComComponent = Me.EthernetIPforCLXCom1
        Me.Pro_Exit.Font = New System.Drawing.Font("Magneto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pro_Exit.ForeColor = System.Drawing.Color.GhostWhite
        Me.Pro_Exit.ForeColorAltername = System.Drawing.Color.Black
        Me.Pro_Exit.Highlight = False
        Me.Pro_Exit.HighlightColor = System.Drawing.Color.Green
        Me.Pro_Exit.Location = New System.Drawing.Point(278, 344)
        Me.Pro_Exit.MaximumHoldTime = 3000
        Me.Pro_Exit.MinimumHoldTime = 500
        Me.Pro_Exit.Name = "Pro_Exit"
        Me.Pro_Exit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Pro_Exit.PLCAddressClick = ""
        Me.Pro_Exit.SelectTextAlternate = False
        Me.Pro_Exit.Size = New System.Drawing.Size(212, 80)
        Me.Pro_Exit.TabIndex = 42
        Me.Pro_Exit.Text = "Exit Profiler"
        Me.Pro_Exit.TextAlternate = Nothing
        Me.Pro_Exit.UseVisualStyleBackColor = False
        Me.Pro_Exit.ValueToWrite = 0
        '
        'ChartBySampling1
        '
        Me.ChartBySampling1.BackColor = System.Drawing.Color.Gray
        Me.ChartBySampling1.BorderlineColor = System.Drawing.Color.DimGray
        Me.ChartBySampling1.BorderSkin.PageColor = System.Drawing.Color.Gray
        ChartArea1.AxisY.Maximum = 600.0R
        ChartArea1.AxisY.Minimum = 0R
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Gray
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.Gray
        Me.ChartBySampling1.ChartAreas.Add(ChartArea1)
        Me.ChartBySampling1.ComComponent = Me.EthernetIPforCLXCom1
        Legend1.Name = "Legend1"
        Me.ChartBySampling1.Legends.Add(Legend1)
        Me.ChartBySampling1.Location = New System.Drawing.Point(12, 47)
        Me.ChartBySampling1.MaximumActivePoints = 30
        Me.ChartBySampling1.Name = "ChartBySampling1"
        Me.ChartBySampling1.PLCAddressItems.Add(CType(resources.GetObject("ChartBySampling1.PLCAddressItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.ChartBySampling1.PLCAddressItems.Add(CType(resources.GetObject("ChartBySampling1.PLCAddressItems1"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.ChartBySampling1.PLCAddressYAxisMax = Nothing
        Me.ChartBySampling1.PLCAddressYAxisMin = Nothing
        Series1.BorderWidth = 4
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Navy
        Series1.Name = "Profile Height 1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Color = System.Drawing.Color.MediumSlateBlue
        Series2.Legend = "Legend1"
        Series2.Name = "Profile Height 2"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Me.ChartBySampling1.Series.Add(Series1)
        Me.ChartBySampling1.Series.Add(Series2)
        Me.ChartBySampling1.Size = New System.Drawing.Size(776, 271)
        Me.ChartBySampling1.TabIndex = 10
        Me.ChartBySampling1.Text = "ChartBySampling1"
        Me.ChartBySampling1.YAxisMax = 600.0R
        Me.ChartBySampling1.YAxisMin = 0R
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
        Me.LbDate.Location = New System.Drawing.Point(658, 3)
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
        Me.LbClk.Location = New System.Drawing.Point(658, 28)
        Me.LbClk.Name = "LbClk"
        Me.LbClk.Size = New System.Drawing.Size(130, 25)
        Me.LbClk.TabIndex = 1445
        Me.LbClk.Text = "xx:xx:xx PM"
        '
        'Profiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LbDate)
        Me.Controls.Add(Me.LbClk)
        Me.Controls.Add(Me.ChartBySampling1)
        Me.Controls.Add(Me.Pro_Exit)
        Me.Controls.Add(Me.minLenInc)
        Me.Controls.Add(Me.maxLenInc)
        Me.Controls.Add(Me.offInc)
        Me.Controls.Add(Me.lenInc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Name = "Profiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profiler"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartBySampling1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lenInc As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents offInc As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents minLenInc As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents maxLenInc As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Pro_Exit As AdvancedHMIControls.BasicButton
    Friend WithEvents ChartBySampling1 As AdvancedHMIControls.ChartBySampling
    Friend WithEvents TiClk As Timer
    Friend WithEvents LbDate As Label
    Friend WithEvents LbClk As Label
End Class
