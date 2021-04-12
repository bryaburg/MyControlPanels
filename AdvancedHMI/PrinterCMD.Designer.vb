<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrinterCMD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrinterCMD))
        Me.PrtCmdExit = New AdvancedHMIControls.BasicButton()
        Me.DivSortOvRide = New AdvancedHMIControls.BasicButton()
        Me.bSortOvRide = New AdvancedHMIControls.BasicButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.AnalogValueDisplay5 = New AdvancedHMIControls.AnalogValueDisplay()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrtCmdExit
        '
        Me.PrtCmdExit.BackColor = System.Drawing.Color.Blue
        Me.PrtCmdExit.ComComponent = Me.EthernetIPforCLXCom1
        Me.PrtCmdExit.Font = New System.Drawing.Font("Magneto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrtCmdExit.ForeColor = System.Drawing.Color.GhostWhite
        Me.PrtCmdExit.ForeColorAltername = System.Drawing.Color.Black
        Me.PrtCmdExit.Highlight = False
        Me.PrtCmdExit.HighlightColor = System.Drawing.Color.Green
        Me.PrtCmdExit.Location = New System.Drawing.Point(85, 306)
        Me.PrtCmdExit.MaximumHoldTime = 3000
        Me.PrtCmdExit.MinimumHoldTime = 500
        Me.PrtCmdExit.Name = "PrtCmdExit"
        Me.PrtCmdExit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PrtCmdExit.PLCAddressClick = ""
        Me.PrtCmdExit.SelectTextAlternate = False
        Me.PrtCmdExit.Size = New System.Drawing.Size(212, 80)
        Me.PrtCmdExit.TabIndex = 48
        Me.PrtCmdExit.Text = "Exit Printer Command"
        Me.PrtCmdExit.TextAlternate = Nothing
        Me.PrtCmdExit.UseVisualStyleBackColor = False
        Me.PrtCmdExit.ValueToWrite = 0
        '
        'DivSortOvRide
        '
        Me.DivSortOvRide.BackColor = System.Drawing.Color.DimGray
        Me.DivSortOvRide.ComComponent = Me.EthernetIPforCLXCom1
        Me.DivSortOvRide.ForeColor = System.Drawing.Color.GhostWhite
        Me.DivSortOvRide.ForeColorAltername = System.Drawing.Color.Black
        Me.DivSortOvRide.Highlight = False
        Me.DivSortOvRide.HighlightColor = System.Drawing.Color.Green
        Me.DivSortOvRide.Location = New System.Drawing.Point(99, 160)
        Me.DivSortOvRide.MaximumHoldTime = 3000
        Me.DivSortOvRide.MinimumHoldTime = 500
        Me.DivSortOvRide.Name = "DivSortOvRide"
        Me.DivSortOvRide.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.DivSortOvRide.PLCAddressClick = "HMI_Ptr2LabelChngRequest"
        Me.DivSortOvRide.PLCAddressHighlightX = "HMI_Ptr2LabelChngRequest"
        Me.DivSortOvRide.PLCAddressSelectTextAlternate = "HMI_Ptr2LabelChngRequest"
        Me.DivSortOvRide.SelectTextAlternate = False
        Me.DivSortOvRide.Size = New System.Drawing.Size(183, 91)
        Me.DivSortOvRide.TabIndex = 47
        Me.DivSortOvRide.Text = "Disable Printer 2"
        Me.DivSortOvRide.TextAlternate = "Printer 2 Disabled"
        Me.DivSortOvRide.UseVisualStyleBackColor = False
        Me.DivSortOvRide.ValueToWrite = 0
        '
        'bSortOvRide
        '
        Me.bSortOvRide.BackColor = System.Drawing.Color.DimGray
        Me.bSortOvRide.ComComponent = Me.EthernetIPforCLXCom1
        Me.bSortOvRide.ForeColor = System.Drawing.Color.GhostWhite
        Me.bSortOvRide.ForeColorAltername = System.Drawing.Color.Black
        Me.bSortOvRide.Highlight = False
        Me.bSortOvRide.HighlightColor = System.Drawing.Color.Green
        Me.bSortOvRide.Location = New System.Drawing.Point(99, 63)
        Me.bSortOvRide.MaximumHoldTime = 3000
        Me.bSortOvRide.MinimumHoldTime = 500
        Me.bSortOvRide.Name = "bSortOvRide"
        Me.bSortOvRide.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.bSortOvRide.PLCAddressClick = "HMI_Ptr1LabelChngRequest"
        Me.bSortOvRide.PLCAddressHighlightX = "HMI_Ptr1LabelChngRequest"
        Me.bSortOvRide.PLCAddressSelectTextAlternate = "HMI_Ptr1LabelChngRequest"
        Me.bSortOvRide.SelectTextAlternate = False
        Me.bSortOvRide.Size = New System.Drawing.Size(183, 91)
        Me.bSortOvRide.TabIndex = 46
        Me.bSortOvRide.Text = "Disable Printer 1"
        Me.bSortOvRide.TextAlternate = "Printer 1 Disabled"
        Me.bSortOvRide.UseVisualStyleBackColor = False
        Me.bSortOvRide.ValueToWrite = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label9.Location = New System.Drawing.Point(66, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(251, 32)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Printer Command"
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
        Me.AnalogValueDisplay5.KeypadMaxValue = 1000.0R
        Me.AnalogValueDisplay5.KeypadMinValue = 0R
        Me.AnalogValueDisplay5.KeypadPasscode = Nothing
        Me.AnalogValueDisplay5.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay5.KeypadText = Nothing
        Me.AnalogValueDisplay5.KeypadWidth = 300
        Me.AnalogValueDisplay5.Location = New System.Drawing.Point(12, 268)
        Me.AnalogValueDisplay5.Name = "AnalogValueDisplay5"
        Me.AnalogValueDisplay5.NumericFormat = Nothing
        Me.AnalogValueDisplay5.PLCAddressKeypad = "HMI_LOWLABELSET"
        Me.AnalogValueDisplay5.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay5.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay5.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay5.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay5.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay5.ShowValue = True
        Me.AnalogValueDisplay5.Size = New System.Drawing.Size(348, 25)
        Me.AnalogValueDisplay5.TabIndex = 52
        Me.AnalogValueDisplay5.Text = "# Of  Labels After Low Alarm 0000 "
        Me.AnalogValueDisplay5.Value = "0000"
        Me.AnalogValueDisplay5.ValueLimitLower = 0R
        Me.AnalogValueDisplay5.ValueLimitUpper = 1000.0R
        Me.AnalogValueDisplay5.ValuePrefix = "# Of  Labels After Low Alarm "
        Me.AnalogValueDisplay5.ValueSuffix = " "
        Me.AnalogValueDisplay5.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'PrinterCMD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(382, 398)
        Me.Controls.Add(Me.AnalogValueDisplay5)
        Me.Controls.Add(Me.PrtCmdExit)
        Me.Controls.Add(Me.DivSortOvRide)
        Me.Controls.Add(Me.bSortOvRide)
        Me.Controls.Add(Me.Label9)
        Me.Name = "PrinterCMD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrinterCMD"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrtCmdExit As AdvancedHMIControls.BasicButton
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents DivSortOvRide As AdvancedHMIControls.BasicButton
    Friend WithEvents bSortOvRide As AdvancedHMIControls.BasicButton
    Friend WithEvents Label9 As Label
    Friend WithEvents AnalogValueDisplay5 As AdvancedHMIControls.AnalogValueDisplay
End Class
