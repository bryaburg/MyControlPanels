<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CP31
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.EthernetIPforCLXCom2 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'EthernetIPforCLXCom2
        '
        Me.EthernetIPforCLXCom2.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom2.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom2.DisableSubscriptions = False
        Me.EthernetIPforCLXCom2.IniFileName = ""
        Me.EthernetIPforCLXCom2.IniFileSection = Nothing
        Me.EthernetIPforCLXCom2.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom2.PollRateOverride = 500
        Me.EthernetIPforCLXCom2.Port = 44818
        Me.EthernetIPforCLXCom2.ProcessorSlot = 0
        Me.EthernetIPforCLXCom2.RoutePath = Nothing
        Me.EthernetIPforCLXCom2.Timeout = 4000
        '
        'CP31
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1428, 882)
        Me.Name = "CP31"
        Me.Text = "CP31"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents EthernetIPforCLXCom2 As AdvancedHMIDrivers.EthernetIPforCLXCom
End Class

