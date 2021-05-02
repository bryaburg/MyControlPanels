<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SorterOvRide
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SorterOvRide))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bSortOvRide = New AdvancedHMIControls.BasicButton()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.DivSortOvRide = New AdvancedHMIControls.BasicButton()
        Me.SortOvRideExit = New AdvancedHMIControls.BasicButton()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label9.Location = New System.Drawing.Point(57, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 26)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Sorter Override"
        '
        'bSortOvRide
        '
        Me.bSortOvRide.BackColor = System.Drawing.Color.DimGray
        Me.bSortOvRide.ComComponent = Me.EthernetIPforCLXCom1
        Me.bSortOvRide.ForeColor = System.Drawing.Color.GhostWhite
        Me.bSortOvRide.ForeColorAltername = System.Drawing.Color.Black
        Me.bSortOvRide.Highlight = False
        Me.bSortOvRide.HighlightColor = System.Drawing.Color.Green
        Me.bSortOvRide.Location = New System.Drawing.Point(71, 50)
        Me.bSortOvRide.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bSortOvRide.MaximumHoldTime = 3000
        Me.bSortOvRide.MinimumHoldTime = 500
        Me.bSortOvRide.Name = "bSortOvRide"
        Me.bSortOvRide.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.bSortOvRide.PLCAddressClick = "HMI_Straight_Override"
        Me.bSortOvRide.PLCAddressHighlightX = "HMI_Straight_Override"
        Me.bSortOvRide.PLCAddressSelectTextAlternate = "HMI_Straight_Override"
        Me.bSortOvRide.SelectTextAlternate = False
        Me.bSortOvRide.Size = New System.Drawing.Size(137, 74)
        Me.bSortOvRide.TabIndex = 38
        Me.bSortOvRide.Text = "Override Straight Sorter"
        Me.bSortOvRide.TextAlternate = "Straight Sorter Overridden"
        Me.bSortOvRide.UseVisualStyleBackColor = False
        Me.bSortOvRide.ValueToWrite = 0
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
        'DivSortOvRide
        '
        Me.DivSortOvRide.BackColor = System.Drawing.Color.DimGray
        Me.DivSortOvRide.ComComponent = Me.EthernetIPforCLXCom1
        Me.DivSortOvRide.ForeColor = System.Drawing.Color.GhostWhite
        Me.DivSortOvRide.ForeColorAltername = System.Drawing.Color.Black
        Me.DivSortOvRide.Highlight = False
        Me.DivSortOvRide.HighlightColor = System.Drawing.Color.Green
        Me.DivSortOvRide.Location = New System.Drawing.Point(71, 129)
        Me.DivSortOvRide.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DivSortOvRide.MaximumHoldTime = 3000
        Me.DivSortOvRide.MinimumHoldTime = 500
        Me.DivSortOvRide.Name = "DivSortOvRide"
        Me.DivSortOvRide.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.DivSortOvRide.PLCAddressClick = "HMI_Divert_Override"
        Me.DivSortOvRide.PLCAddressHighlightX = "HMI_Divert_Override"
        Me.DivSortOvRide.PLCAddressSelectTextAlternate = "HMI_Divert_Override"
        Me.DivSortOvRide.SelectTextAlternate = False
        Me.DivSortOvRide.Size = New System.Drawing.Size(137, 74)
        Me.DivSortOvRide.TabIndex = 39
        Me.DivSortOvRide.Text = "Override Divert Sorter"
        Me.DivSortOvRide.TextAlternate = "Divert Sorter Overridden"
        Me.DivSortOvRide.UseVisualStyleBackColor = False
        Me.DivSortOvRide.ValueToWrite = 0
        '
        'SortOvRideExit
        '
        Me.SortOvRideExit.BackColor = System.Drawing.Color.Blue
        Me.SortOvRideExit.ComComponent = Me.EthernetIPforCLXCom1
        Me.SortOvRideExit.Font = New System.Drawing.Font("Magneto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortOvRideExit.ForeColor = System.Drawing.Color.GhostWhite
        Me.SortOvRideExit.ForeColorAltername = System.Drawing.Color.Black
        Me.SortOvRideExit.Highlight = False
        Me.SortOvRideExit.HighlightColor = System.Drawing.Color.Green
        Me.SortOvRideExit.Location = New System.Drawing.Point(62, 212)
        Me.SortOvRideExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SortOvRideExit.MaximumHoldTime = 3000
        Me.SortOvRideExit.MinimumHoldTime = 500
        Me.SortOvRideExit.Name = "SortOvRideExit"
        Me.SortOvRideExit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.SortOvRideExit.PLCAddressClick = ""
        Me.SortOvRideExit.SelectTextAlternate = False
        Me.SortOvRideExit.Size = New System.Drawing.Size(159, 65)
        Me.SortOvRideExit.TabIndex = 44
        Me.SortOvRideExit.Text = "Exit Sorter Override"
        Me.SortOvRideExit.TextAlternate = Nothing
        Me.SortOvRideExit.UseVisualStyleBackColor = False
        Me.SortOvRideExit.ValueToWrite = 0
        '
        'SorterOvRide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(286, 287)
        Me.Controls.Add(Me.SortOvRideExit)
        Me.Controls.Add(Me.DivSortOvRide)
        Me.Controls.Add(Me.bSortOvRide)
        Me.Controls.Add(Me.Label9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SorterOvRide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SorterOvRide"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents bSortOvRide As AdvancedHMIControls.BasicButton
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents DivSortOvRide As AdvancedHMIControls.BasicButton
    Friend WithEvents SortOvRideExit As AdvancedHMIControls.BasicButton
End Class
