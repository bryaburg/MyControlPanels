<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaCoRdr1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaCoRdr1))
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DistFromTrans = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BCR_Exit = New AdvancedHMIControls.BasicButton()
        Me.boScanDel = New AdvancedHMIControls.AnalogValueDisplay()
        Me.DistFromPro = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbClk = New System.Windows.Forms.Label()
        Me.TiClk = New System.Windows.Forms.Timer(Me.components)
        Me.LbDate = New System.Windows.Forms.Label()
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
        Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.58"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'DistFromTrans
        '
        Me.DistFromTrans.AutoSize = True
        Me.DistFromTrans.ComComponent = Me.EthernetIPforCLXCom1
        Me.DistFromTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistFromTrans.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DistFromTrans.ForeColorInLimits = System.Drawing.Color.WhiteSmoke
        Me.DistFromTrans.ForeColorOverLimit = System.Drawing.Color.Red
        Me.DistFromTrans.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.DistFromTrans.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DistFromTrans.KeypadMaxValue = 72.0R
        Me.DistFromTrans.KeypadMinValue = 0R
        Me.DistFromTrans.KeypadPasscode = Nothing
        Me.DistFromTrans.KeypadScaleFactor = 1.0R
        Me.DistFromTrans.KeypadText = Nothing
        Me.DistFromTrans.KeypadWidth = 300
        Me.DistFromTrans.Location = New System.Drawing.Point(316, 99)
        Me.DistFromTrans.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DistFromTrans.Name = "DistFromTrans"
        Me.DistFromTrans.NumericFormat = Nothing
        Me.DistFromTrans.PLCAddressKeypad = "HMI_VerifyDistFromInduct"
        Me.DistFromTrans.PLCAddressValue = CType(resources.GetObject("DistFromTrans.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.DistFromTrans.PLCAddressValueLimitLower = Nothing
        Me.DistFromTrans.PLCAddressValueLimitUpper = Nothing
        Me.DistFromTrans.PLCAddressVisible = Nothing
        Me.DistFromTrans.ShowValue = True
        Me.DistFromTrans.Size = New System.Drawing.Size(118, 20)
        Me.DistFromTrans.TabIndex = 24
        Me.DistFromTrans.Text = "0000   Inches"
        Me.DistFromTrans.Value = "0000"
        Me.DistFromTrans.ValueLimitLower = 0R
        Me.DistFromTrans.ValueLimitUpper = 72.0R
        Me.DistFromTrans.ValuePrefix = Nothing
        Me.DistFromTrans.ValueSuffix = "   Inches"
        Me.DistFromTrans.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(316, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Distance From Transfer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(314, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 26)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Verify Barcode Reader"
        '
        'BCR_Exit
        '
        Me.BCR_Exit.BackColor = System.Drawing.Color.Blue
        Me.BCR_Exit.ComComponent = Me.EthernetIPforCLXCom1
        Me.BCR_Exit.Font = New System.Drawing.Font("Magneto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCR_Exit.ForeColor = System.Drawing.Color.GhostWhite
        Me.BCR_Exit.ForeColorAltername = System.Drawing.Color.Black
        Me.BCR_Exit.Highlight = False
        Me.BCR_Exit.HighlightColor = System.Drawing.Color.Green
        Me.BCR_Exit.Location = New System.Drawing.Point(214, 208)
        Me.BCR_Exit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BCR_Exit.MaximumHoldTime = 3000
        Me.BCR_Exit.MinimumHoldTime = 500
        Me.BCR_Exit.Name = "BCR_Exit"
        Me.BCR_Exit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BCR_Exit.PLCAddressClick = ""
        Me.BCR_Exit.SelectTextAlternate = False
        Me.BCR_Exit.Size = New System.Drawing.Size(159, 84)
        Me.BCR_Exit.TabIndex = 21
        Me.BCR_Exit.Text = "Exit Barcode Readers"
        Me.BCR_Exit.TextAlternate = Nothing
        Me.BCR_Exit.UseVisualStyleBackColor = False
        Me.BCR_Exit.ValueToWrite = 0
        '
        'boScanDel
        '
        Me.boScanDel.AutoSize = True
        Me.boScanDel.ComComponent = Me.EthernetIPforCLXCom1
        Me.boScanDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boScanDel.ForeColor = System.Drawing.Color.Gray
        Me.boScanDel.ForeColorInLimits = System.Drawing.Color.Gray
        Me.boScanDel.ForeColorOverLimit = System.Drawing.Color.Red
        Me.boScanDel.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.boScanDel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.boScanDel.KeypadMaxValue = 5000.0R
        Me.boScanDel.KeypadMinValue = 0R
        Me.boScanDel.KeypadPasscode = Nothing
        Me.boScanDel.KeypadScaleFactor = 1.0R
        Me.boScanDel.KeypadText = Nothing
        Me.boScanDel.KeypadWidth = 300
        Me.boScanDel.Location = New System.Drawing.Point(23, 163)
        Me.boScanDel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.boScanDel.Name = "boScanDel"
        Me.boScanDel.NumericFormat = Nothing
        Me.boScanDel.PLCAddressKeypad = "HMI_ScaleBottomCameraTriggerDelay"
        Me.boScanDel.PLCAddressValue = CType(resources.GetObject("boScanDel.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.boScanDel.PLCAddressValueLimitLower = Nothing
        Me.boScanDel.PLCAddressValueLimitUpper = Nothing
        Me.boScanDel.PLCAddressVisible = Nothing
        Me.boScanDel.ShowValue = True
        Me.boScanDel.Size = New System.Drawing.Size(161, 20)
        Me.boScanDel.TabIndex = 20
        Me.boScanDel.Text = "0000   Milliseconds"
        Me.boScanDel.Value = "0000"
        Me.boScanDel.ValueLimitLower = 0R
        Me.boScanDel.ValueLimitUpper = 5000.0R
        Me.boScanDel.ValuePrefix = Nothing
        Me.boScanDel.ValueSuffix = "   Milliseconds"
        Me.boScanDel.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'DistFromPro
        '
        Me.DistFromPro.AutoSize = True
        Me.DistFromPro.ComComponent = Me.EthernetIPforCLXCom1
        Me.DistFromPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistFromPro.ForeColor = System.Drawing.Color.Gray
        Me.DistFromPro.ForeColorInLimits = System.Drawing.Color.Gray
        Me.DistFromPro.ForeColorOverLimit = System.Drawing.Color.Red
        Me.DistFromPro.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.DistFromPro.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DistFromPro.KeypadMaxValue = 55.0R
        Me.DistFromPro.KeypadMinValue = 0R
        Me.DistFromPro.KeypadPasscode = Nothing
        Me.DistFromPro.KeypadScaleFactor = 1.0R
        Me.DistFromPro.KeypadText = Nothing
        Me.DistFromPro.KeypadWidth = 300
        Me.DistFromPro.Location = New System.Drawing.Point(23, 99)
        Me.DistFromPro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DistFromPro.Name = "DistFromPro"
        Me.DistFromPro.NumericFormat = Nothing
        Me.DistFromPro.PLCAddressKeypad = "HMI_ScaleDistFromInduct"
        Me.DistFromPro.PLCAddressValue = CType(resources.GetObject("DistFromPro.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.DistFromPro.PLCAddressValueLimitLower = Nothing
        Me.DistFromPro.PLCAddressValueLimitUpper = Nothing
        Me.DistFromPro.PLCAddressVisible = Nothing
        Me.DistFromPro.ShowValue = True
        Me.DistFromPro.Size = New System.Drawing.Size(118, 20)
        Me.DistFromPro.TabIndex = 19
        Me.DistFromPro.Text = "0000   Inches"
        Me.DistFromPro.Value = "0000"
        Me.DistFromPro.ValueLimitLower = 0R
        Me.DistFromPro.ValueLimitUpper = 55.0R
        Me.DistFromPro.ValuePrefix = Nothing
        Me.DistFromPro.ValueSuffix = "   Inches"
        Me.DistFromPro.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(22, 147)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Bottom Scan On Delay"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(22, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Distance From Profiler"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 26)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Scale Barcode Reader"
        '
        'LbClk
        '
        Me.LbClk.AutoSize = True
        Me.LbClk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClk.ForeColor = System.Drawing.Color.GhostWhite
        Me.LbClk.Location = New System.Drawing.Point(458, 272)
        Me.LbClk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbClk.Name = "LbClk"
        Me.LbClk.Size = New System.Drawing.Size(97, 20)
        Me.LbClk.TabIndex = 25
        Me.LbClk.Text = "xx:xx:xx PM"
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
        Me.LbDate.Location = New System.Drawing.Point(458, 252)
        Me.LbDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbDate.Name = "LbDate"
        Me.LbDate.Size = New System.Drawing.Size(83, 20)
        Me.LbDate.TabIndex = 1440
        Me.LbDate.Text = "xx/xx/xxxx"
        '
        'BaCoRdr1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(574, 309)
        Me.Controls.Add(Me.LbDate)
        Me.Controls.Add(Me.LbClk)
        Me.Controls.Add(Me.DistFromTrans)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BCR_Exit)
        Me.Controls.Add(Me.boScanDel)
        Me.Controls.Add(Me.DistFromPro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BaCoRdr1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaCoRdr1"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents DistFromTrans As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BCR_Exit As AdvancedHMIControls.BasicButton
    Friend WithEvents boScanDel As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents DistFromPro As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbClk As Label
    Friend WithEvents TiClk As Timer
    Friend WithEvents LbDate As Label
End Class
