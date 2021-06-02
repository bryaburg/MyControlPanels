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
        Me.BasicIndicator302 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator303 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator304 = New AdvancedHMIControls.BasicIndicator()
        Me.CheckBox25 = New AdvancedHMIControls.CheckBox()
        Me.BasicIndicator305 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator306 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator307 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator308 = New AdvancedHMIControls.BasicIndicator()
        Me.CheckBox26 = New AdvancedHMIControls.CheckBox()
        Me.BasicIndicator309 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator206 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator207 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator208 = New AdvancedHMIControls.BasicIndicator()
        Me.CheckBox6 = New AdvancedHMIControls.CheckBox()
        Me.BasicIndicator209 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator210 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator211 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator212 = New AdvancedHMIControls.BasicIndicator()
        Me.CheckBox7 = New AdvancedHMIControls.CheckBox()
        Me.BasicIndicator213 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator214 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator215 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator216 = New AdvancedHMIControls.BasicIndicator()
        Me.CheckBox8 = New AdvancedHMIControls.CheckBox()
        Me.BasicIndicator217 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator218 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator219 = New AdvancedHMIControls.BasicIndicator()
        Me.BasicIndicator220 = New AdvancedHMIControls.BasicIndicator()
        Me.CheckBox9 = New AdvancedHMIControls.CheckBox()
        Me.BasicIndicator221 = New AdvancedHMIControls.BasicIndicator()
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
        'BasicIndicator302
        '
        Me.BasicIndicator302.Color1 = System.Drawing.Color.Black
        Me.BasicIndicator302.Color2 = System.Drawing.Color.Gold
        Me.BasicIndicator302.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator302.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator302.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator302.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator302.Location = New System.Drawing.Point(460, 138)
        Me.BasicIndicator302.Name = "BasicIndicator302"
        Me.BasicIndicator302.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator302.OutlineWidth = 1
        Me.BasicIndicator302.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator302.PLCAddressSelectColor2 = "EEM12625_07_2"
        Me.BasicIndicator302.SelectColor2 = False
        Me.BasicIndicator302.SelectColor3 = False
        Me.BasicIndicator302.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator302.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator302.TabIndex = 6497
        Me.BasicIndicator302.Text = "12625.7-2"
        '
        'BasicIndicator303
        '
        Me.BasicIndicator303.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator303.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator303.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator303.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator303.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator303.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator303.Location = New System.Drawing.Point(625, 138)
        Me.BasicIndicator303.Name = "BasicIndicator303"
        Me.BasicIndicator303.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator303.OutlineWidth = 1
        Me.BasicIndicator303.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator303.PLCAddressSelectColor3 = "MDR12625_07.Z2_JAM_BIT"
        Me.BasicIndicator303.PLCAddressVisible = "MDR12625_07.Z2_JAM_BIT"
        Me.BasicIndicator303.SelectColor2 = False
        Me.BasicIndicator303.SelectColor3 = False
        Me.BasicIndicator303.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator303.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator303.TabIndex = 6496
        Me.BasicIndicator303.Text = "JAM "
        '
        'BasicIndicator304
        '
        Me.BasicIndicator304.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator304.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator304.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator304.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator304.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator304.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator304.Location = New System.Drawing.Point(570, 138)
        Me.BasicIndicator304.Name = "BasicIndicator304"
        Me.BasicIndicator304.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator304.OutlineWidth = 1
        Me.BasicIndicator304.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator304.PLCAddressSelectColor3 = "MDR12625_07.Z2_FAULT"
        Me.BasicIndicator304.PLCAddressVisible = "MDR12625_07.Z2_FAULT"
        Me.BasicIndicator304.SelectColor2 = False
        Me.BasicIndicator304.SelectColor3 = False
        Me.BasicIndicator304.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator304.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator304.TabIndex = 6495
        Me.BasicIndicator304.Text = "FAULT"
        '
        'CheckBox25
        '
        Me.CheckBox25.AutoSize = True
        Me.CheckBox25.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox25.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox25.ForeColor = System.Drawing.Color.GhostWhite
        Me.CheckBox25.Location = New System.Drawing.Point(330, 134)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.PLCAddressCheckChanged = ""
        Me.CheckBox25.PLCAddressChecked = ""
        Me.CheckBox25.PLCAddressText = ""
        Me.CheckBox25.PLCAddressVisible = ""
        Me.CheckBox25.Size = New System.Drawing.Size(134, 18)
        Me.CheckBox25.TabIndex = 6494
        Me.CheckBox25.Text = "MDR 12625.7-2"
        Me.CheckBox25.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckBox25.UseVisualStyleBackColor = True
        '
        'BasicIndicator305
        '
        Me.BasicIndicator305.Color1 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator305.Color2 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator305.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator305.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator305.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator305.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator305.Location = New System.Drawing.Point(515, 138)
        Me.BasicIndicator305.Name = "BasicIndicator305"
        Me.BasicIndicator305.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator305.OutlineWidth = 1
        Me.BasicIndicator305.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator305.PLCAddressSelectColor2 = "MDR12625_07.Z2_MTR_RUNNING"
        Me.BasicIndicator305.PLCAddressVisible = "MDR12625_07.Z2_MTR_RUNNING"
        Me.BasicIndicator305.SelectColor2 = False
        Me.BasicIndicator305.SelectColor3 = False
        Me.BasicIndicator305.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator305.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator305.TabIndex = 6493
        Me.BasicIndicator305.Text = "RUN"
        '
        'BasicIndicator306
        '
        Me.BasicIndicator306.Color1 = System.Drawing.Color.Black
        Me.BasicIndicator306.Color2 = System.Drawing.Color.Gold
        Me.BasicIndicator306.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator306.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator306.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator306.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator306.Location = New System.Drawing.Point(460, 119)
        Me.BasicIndicator306.Name = "BasicIndicator306"
        Me.BasicIndicator306.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator306.OutlineWidth = 1
        Me.BasicIndicator306.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator306.PLCAddressSelectColor2 = "EEM12625_07_1"
        Me.BasicIndicator306.SelectColor2 = False
        Me.BasicIndicator306.SelectColor3 = False
        Me.BasicIndicator306.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator306.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator306.TabIndex = 6492
        Me.BasicIndicator306.Text = "12625.7-1"
        '
        'BasicIndicator307
        '
        Me.BasicIndicator307.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator307.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator307.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator307.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator307.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator307.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator307.Location = New System.Drawing.Point(625, 119)
        Me.BasicIndicator307.Name = "BasicIndicator307"
        Me.BasicIndicator307.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator307.OutlineWidth = 1
        Me.BasicIndicator307.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator307.PLCAddressSelectColor3 = "MDR12625_07.Z1_JAM_BIT"
        Me.BasicIndicator307.PLCAddressVisible = "MDR12625_07.Z1_JAM_BIT"
        Me.BasicIndicator307.SelectColor2 = False
        Me.BasicIndicator307.SelectColor3 = False
        Me.BasicIndicator307.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator307.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator307.TabIndex = 6491
        Me.BasicIndicator307.Text = "JAM "
        '
        'BasicIndicator308
        '
        Me.BasicIndicator308.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator308.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator308.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator308.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator308.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator308.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator308.Location = New System.Drawing.Point(570, 119)
        Me.BasicIndicator308.Name = "BasicIndicator308"
        Me.BasicIndicator308.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator308.OutlineWidth = 1
        Me.BasicIndicator308.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator308.PLCAddressSelectColor3 = "MDR12625_07.Z1_FAULT"
        Me.BasicIndicator308.PLCAddressVisible = "MDR12625_07.Z1_FAULT"
        Me.BasicIndicator308.SelectColor2 = False
        Me.BasicIndicator308.SelectColor3 = False
        Me.BasicIndicator308.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator308.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator308.TabIndex = 6490
        Me.BasicIndicator308.Text = "FAULT"
        '
        'CheckBox26
        '
        Me.CheckBox26.AutoSize = True
        Me.CheckBox26.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox26.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox26.ForeColor = System.Drawing.Color.GhostWhite
        Me.CheckBox26.Location = New System.Drawing.Point(330, 115)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.PLCAddressCheckChanged = ""
        Me.CheckBox26.PLCAddressChecked = ""
        Me.CheckBox26.PLCAddressText = ""
        Me.CheckBox26.PLCAddressVisible = ""
        Me.CheckBox26.Size = New System.Drawing.Size(132, 18)
        Me.CheckBox26.TabIndex = 6489
        Me.CheckBox26.Text = "MDR 12625.7-1"
        Me.CheckBox26.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckBox26.UseVisualStyleBackColor = True
        '
        'BasicIndicator309
        '
        Me.BasicIndicator309.Color1 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator309.Color2 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator309.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator309.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator309.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator309.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator309.Location = New System.Drawing.Point(515, 119)
        Me.BasicIndicator309.Name = "BasicIndicator309"
        Me.BasicIndicator309.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator309.OutlineWidth = 1
        Me.BasicIndicator309.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator309.PLCAddressSelectColor2 = "MDR12625_07.Z1_MTR_RUNNING"
        Me.BasicIndicator309.PLCAddressVisible = "MDR12625_07.Z1_MTR_RUNNING"
        Me.BasicIndicator309.SelectColor2 = False
        Me.BasicIndicator309.SelectColor3 = False
        Me.BasicIndicator309.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator309.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator309.TabIndex = 6488
        Me.BasicIndicator309.Text = "RUN"
        '
        'BasicIndicator206
        '
        Me.BasicIndicator206.Color1 = System.Drawing.Color.Black
        Me.BasicIndicator206.Color2 = System.Drawing.Color.Gold
        Me.BasicIndicator206.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator206.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator206.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator206.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator206.Location = New System.Drawing.Point(460, 211)
        Me.BasicIndicator206.Name = "BasicIndicator206"
        Me.BasicIndicator206.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator206.OutlineWidth = 1
        Me.BasicIndicator206.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator206.PLCAddressSelectColor2 = "EEM12620_07_3"
        Me.BasicIndicator206.SelectColor2 = False
        Me.BasicIndicator206.SelectColor3 = False
        Me.BasicIndicator206.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator206.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator206.TabIndex = 6512
        Me.BasicIndicator206.Text = "12620.7-3"
        '
        'BasicIndicator207
        '
        Me.BasicIndicator207.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator207.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator207.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator207.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator207.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator207.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator207.Location = New System.Drawing.Point(625, 211)
        Me.BasicIndicator207.Name = "BasicIndicator207"
        Me.BasicIndicator207.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator207.OutlineWidth = 1
        Me.BasicIndicator207.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator207.PLCAddressSelectColor3 = "MDR12620_07.Z3_JAM_BIT"
        Me.BasicIndicator207.PLCAddressVisible = "MDR12620_07.Z3_JAM_BIT"
        Me.BasicIndicator207.SelectColor2 = False
        Me.BasicIndicator207.SelectColor3 = False
        Me.BasicIndicator207.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator207.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator207.TabIndex = 6511
        Me.BasicIndicator207.Text = "JAM "
        '
        'BasicIndicator208
        '
        Me.BasicIndicator208.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator208.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator208.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator208.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator208.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator208.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator208.Location = New System.Drawing.Point(570, 211)
        Me.BasicIndicator208.Name = "BasicIndicator208"
        Me.BasicIndicator208.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator208.OutlineWidth = 1
        Me.BasicIndicator208.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator208.PLCAddressSelectColor3 = "MDR12620_07.Z3_FAULT"
        Me.BasicIndicator208.PLCAddressVisible = "MDR12620_07.Z3_FAULT"
        Me.BasicIndicator208.SelectColor2 = False
        Me.BasicIndicator208.SelectColor3 = False
        Me.BasicIndicator208.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator208.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator208.TabIndex = 6510
        Me.BasicIndicator208.Text = "FAULT"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox6.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.ForeColor = System.Drawing.Color.GhostWhite
        Me.CheckBox6.Location = New System.Drawing.Point(330, 207)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.PLCAddressCheckChanged = ""
        Me.CheckBox6.PLCAddressChecked = ""
        Me.CheckBox6.PLCAddressText = ""
        Me.CheckBox6.PLCAddressVisible = ""
        Me.CheckBox6.Size = New System.Drawing.Size(134, 18)
        Me.CheckBox6.TabIndex = 6509
        Me.CheckBox6.Text = "MDR 12620.7-3"
        Me.CheckBox6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'BasicIndicator209
        '
        Me.BasicIndicator209.Color1 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator209.Color2 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator209.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator209.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator209.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator209.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator209.Location = New System.Drawing.Point(515, 211)
        Me.BasicIndicator209.Name = "BasicIndicator209"
        Me.BasicIndicator209.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator209.OutlineWidth = 1
        Me.BasicIndicator209.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator209.PLCAddressSelectColor2 = "MDR12620_07.Z3_MTR_RUNNING"
        Me.BasicIndicator209.PLCAddressVisible = "MDR12620_07.Z3_MTR_RUNNING"
        Me.BasicIndicator209.SelectColor2 = False
        Me.BasicIndicator209.SelectColor3 = False
        Me.BasicIndicator209.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator209.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator209.TabIndex = 6508
        Me.BasicIndicator209.Text = "RUN"
        '
        'BasicIndicator210
        '
        Me.BasicIndicator210.Color1 = System.Drawing.Color.Black
        Me.BasicIndicator210.Color2 = System.Drawing.Color.Gold
        Me.BasicIndicator210.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator210.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator210.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator210.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator210.Location = New System.Drawing.Point(460, 192)
        Me.BasicIndicator210.Name = "BasicIndicator210"
        Me.BasicIndicator210.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator210.OutlineWidth = 1
        Me.BasicIndicator210.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator210.PLCAddressSelectColor2 = "EEM12620_07_2"
        Me.BasicIndicator210.SelectColor2 = False
        Me.BasicIndicator210.SelectColor3 = False
        Me.BasicIndicator210.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator210.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator210.TabIndex = 6507
        Me.BasicIndicator210.Text = "12620.7-2"
        '
        'BasicIndicator211
        '
        Me.BasicIndicator211.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator211.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator211.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator211.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator211.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator211.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator211.Location = New System.Drawing.Point(625, 192)
        Me.BasicIndicator211.Name = "BasicIndicator211"
        Me.BasicIndicator211.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator211.OutlineWidth = 1
        Me.BasicIndicator211.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator211.PLCAddressSelectColor3 = "MDR12620_07.Z2_JAM_BIT"
        Me.BasicIndicator211.PLCAddressVisible = "MDR12620_07.Z2_JAM_BIT"
        Me.BasicIndicator211.SelectColor2 = False
        Me.BasicIndicator211.SelectColor3 = False
        Me.BasicIndicator211.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator211.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator211.TabIndex = 6506
        Me.BasicIndicator211.Text = "JAM "
        '
        'BasicIndicator212
        '
        Me.BasicIndicator212.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator212.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator212.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator212.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator212.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator212.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator212.Location = New System.Drawing.Point(570, 192)
        Me.BasicIndicator212.Name = "BasicIndicator212"
        Me.BasicIndicator212.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator212.OutlineWidth = 1
        Me.BasicIndicator212.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator212.PLCAddressSelectColor3 = "MDR12620_07.Z2_FAULT"
        Me.BasicIndicator212.PLCAddressVisible = "MDR12620_07.Z2_FAULT"
        Me.BasicIndicator212.SelectColor2 = False
        Me.BasicIndicator212.SelectColor3 = False
        Me.BasicIndicator212.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator212.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator212.TabIndex = 6505
        Me.BasicIndicator212.Text = "FAULT"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox7.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.ForeColor = System.Drawing.Color.GhostWhite
        Me.CheckBox7.Location = New System.Drawing.Point(330, 188)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.PLCAddressCheckChanged = ""
        Me.CheckBox7.PLCAddressChecked = ""
        Me.CheckBox7.PLCAddressText = ""
        Me.CheckBox7.PLCAddressVisible = ""
        Me.CheckBox7.Size = New System.Drawing.Size(134, 18)
        Me.CheckBox7.TabIndex = 6504
        Me.CheckBox7.Text = "MDR 12620.7-2"
        Me.CheckBox7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'BasicIndicator213
        '
        Me.BasicIndicator213.Color1 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator213.Color2 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator213.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator213.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator213.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator213.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator213.Location = New System.Drawing.Point(515, 192)
        Me.BasicIndicator213.Name = "BasicIndicator213"
        Me.BasicIndicator213.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator213.OutlineWidth = 1
        Me.BasicIndicator213.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator213.PLCAddressSelectColor2 = "MDR12620_07.Z2_MTR_RUNNING"
        Me.BasicIndicator213.PLCAddressVisible = "MDR12620_07.Z2_MTR_RUNNING"
        Me.BasicIndicator213.SelectColor2 = False
        Me.BasicIndicator213.SelectColor3 = False
        Me.BasicIndicator213.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator213.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator213.TabIndex = 6503
        Me.BasicIndicator213.Text = "RUN"
        '
        'BasicIndicator214
        '
        Me.BasicIndicator214.Color1 = System.Drawing.Color.Black
        Me.BasicIndicator214.Color2 = System.Drawing.Color.Gold
        Me.BasicIndicator214.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator214.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator214.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator214.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator214.Location = New System.Drawing.Point(461, 172)
        Me.BasicIndicator214.Name = "BasicIndicator214"
        Me.BasicIndicator214.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator214.OutlineWidth = 1
        Me.BasicIndicator214.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator214.PLCAddressSelectColor2 = "EEM12620_07_1"
        Me.BasicIndicator214.SelectColor2 = False
        Me.BasicIndicator214.SelectColor3 = False
        Me.BasicIndicator214.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator214.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator214.TabIndex = 6502
        Me.BasicIndicator214.Text = "12620.7-1"
        '
        'BasicIndicator215
        '
        Me.BasicIndicator215.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator215.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator215.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator215.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator215.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator215.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator215.Location = New System.Drawing.Point(626, 172)
        Me.BasicIndicator215.Name = "BasicIndicator215"
        Me.BasicIndicator215.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator215.OutlineWidth = 1
        Me.BasicIndicator215.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator215.PLCAddressSelectColor3 = "MDR12620_07.Z1_JAM_BIT"
        Me.BasicIndicator215.PLCAddressVisible = "MDR12620_07.Z1_JAM_BIT"
        Me.BasicIndicator215.SelectColor2 = False
        Me.BasicIndicator215.SelectColor3 = False
        Me.BasicIndicator215.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator215.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator215.TabIndex = 6501
        Me.BasicIndicator215.Text = "JAM "
        '
        'BasicIndicator216
        '
        Me.BasicIndicator216.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator216.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator216.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator216.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator216.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator216.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator216.Location = New System.Drawing.Point(571, 172)
        Me.BasicIndicator216.Name = "BasicIndicator216"
        Me.BasicIndicator216.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator216.OutlineWidth = 1
        Me.BasicIndicator216.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator216.PLCAddressSelectColor3 = "MDR12620_07.Z1_FAULT"
        Me.BasicIndicator216.PLCAddressVisible = "MDR12620_07.Z1_FAULT"
        Me.BasicIndicator216.SelectColor2 = False
        Me.BasicIndicator216.SelectColor3 = False
        Me.BasicIndicator216.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator216.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator216.TabIndex = 6500
        Me.BasicIndicator216.Text = "FAULT"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox8.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.ForeColor = System.Drawing.Color.GhostWhite
        Me.CheckBox8.Location = New System.Drawing.Point(330, 168)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.PLCAddressCheckChanged = ""
        Me.CheckBox8.PLCAddressChecked = ""
        Me.CheckBox8.PLCAddressText = ""
        Me.CheckBox8.PLCAddressVisible = ""
        Me.CheckBox8.Size = New System.Drawing.Size(132, 18)
        Me.CheckBox8.TabIndex = 6499
        Me.CheckBox8.Text = "MDR 12620.7-1"
        Me.CheckBox8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'BasicIndicator217
        '
        Me.BasicIndicator217.Color1 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator217.Color2 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator217.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator217.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator217.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator217.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator217.Location = New System.Drawing.Point(516, 172)
        Me.BasicIndicator217.Name = "BasicIndicator217"
        Me.BasicIndicator217.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator217.OutlineWidth = 1
        Me.BasicIndicator217.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator217.PLCAddressSelectColor2 = "MDR12620_07.Z1_MTR_RUNNING"
        Me.BasicIndicator217.PLCAddressVisible = "MDR12620_07.Z1_MTR_RUNNING"
        Me.BasicIndicator217.SelectColor2 = False
        Me.BasicIndicator217.SelectColor3 = False
        Me.BasicIndicator217.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator217.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator217.TabIndex = 6498
        Me.BasicIndicator217.Text = "RUN"
        '
        'BasicIndicator218
        '
        Me.BasicIndicator218.Color1 = System.Drawing.Color.Black
        Me.BasicIndicator218.Color2 = System.Drawing.Color.Gold
        Me.BasicIndicator218.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator218.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator218.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator218.ForeColor = System.Drawing.Color.GhostWhite
        Me.BasicIndicator218.Location = New System.Drawing.Point(460, 231)
        Me.BasicIndicator218.Name = "BasicIndicator218"
        Me.BasicIndicator218.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator218.OutlineWidth = 1
        Me.BasicIndicator218.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator218.PLCAddressSelectColor2 = "EEM12615_02_4"
        Me.BasicIndicator218.SelectColor2 = False
        Me.BasicIndicator218.SelectColor3 = False
        Me.BasicIndicator218.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator218.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator218.TabIndex = 6517
        Me.BasicIndicator218.Text = "12620.7-4"
        '
        'BasicIndicator219
        '
        Me.BasicIndicator219.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator219.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator219.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator219.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator219.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator219.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator219.Location = New System.Drawing.Point(625, 231)
        Me.BasicIndicator219.Name = "BasicIndicator219"
        Me.BasicIndicator219.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator219.OutlineWidth = 1
        Me.BasicIndicator219.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator219.PLCAddressSelectColor3 = "MDR12620_07.Z4_JAM_BIT"
        Me.BasicIndicator219.PLCAddressVisible = "MDR12620_07.Z4_JAM_BIT"
        Me.BasicIndicator219.SelectColor2 = False
        Me.BasicIndicator219.SelectColor3 = False
        Me.BasicIndicator219.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator219.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator219.TabIndex = 6516
        Me.BasicIndicator219.Text = "JAM "
        '
        'BasicIndicator220
        '
        Me.BasicIndicator220.Color1 = System.Drawing.Color.Red
        Me.BasicIndicator220.Color2 = System.Drawing.Color.Green
        Me.BasicIndicator220.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator220.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator220.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator220.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator220.Location = New System.Drawing.Point(570, 231)
        Me.BasicIndicator220.Name = "BasicIndicator220"
        Me.BasicIndicator220.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator220.OutlineWidth = 1
        Me.BasicIndicator220.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator220.PLCAddressSelectColor3 = "MDR12620_07.Z4_FAULT"
        Me.BasicIndicator220.PLCAddressVisible = "MDR12620_07.Z4_FAULT"
        Me.BasicIndicator220.SelectColor2 = False
        Me.BasicIndicator220.SelectColor3 = False
        Me.BasicIndicator220.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator220.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator220.TabIndex = 6515
        Me.BasicIndicator220.Text = "FAULT"
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.ComComponent = Me.EthernetIPforCLXCom1
        Me.CheckBox9.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox9.ForeColor = System.Drawing.Color.GhostWhite
        Me.CheckBox9.Location = New System.Drawing.Point(330, 227)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.PLCAddressCheckChanged = ""
        Me.CheckBox9.PLCAddressChecked = ""
        Me.CheckBox9.PLCAddressText = ""
        Me.CheckBox9.PLCAddressVisible = ""
        Me.CheckBox9.Size = New System.Drawing.Size(134, 18)
        Me.CheckBox9.TabIndex = 6514
        Me.CheckBox9.Text = "MDR 12620.7-4"
        Me.CheckBox9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'BasicIndicator221
        '
        Me.BasicIndicator221.Color1 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator221.Color2 = System.Drawing.Color.YellowGreen
        Me.BasicIndicator221.Color3 = System.Drawing.Color.Red
        Me.BasicIndicator221.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicIndicator221.Font = New System.Drawing.Font("Elephant", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicIndicator221.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BasicIndicator221.Location = New System.Drawing.Point(515, 231)
        Me.BasicIndicator221.Name = "BasicIndicator221"
        Me.BasicIndicator221.OutlineColor = System.Drawing.Color.Transparent
        Me.BasicIndicator221.OutlineWidth = 1
        Me.BasicIndicator221.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicIndicator221.PLCAddressSelectColor2 = "MDR12620_07.Z4_MTR_RUNNING"
        Me.BasicIndicator221.PLCAddressVisible = "MDR12620_07.Z4_MTR_RUNNING"
        Me.BasicIndicator221.SelectColor2 = False
        Me.BasicIndicator221.SelectColor3 = False
        Me.BasicIndicator221.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        Me.BasicIndicator221.Size = New System.Drawing.Size(55, 14)
        Me.BasicIndicator221.TabIndex = 6513
        Me.BasicIndicator221.Text = "RUN"
        '
        'CP31
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 695)
        Me.Controls.Add(Me.BasicIndicator218)
        Me.Controls.Add(Me.BasicIndicator219)
        Me.Controls.Add(Me.BasicIndicator220)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.BasicIndicator221)
        Me.Controls.Add(Me.BasicIndicator206)
        Me.Controls.Add(Me.BasicIndicator207)
        Me.Controls.Add(Me.BasicIndicator208)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.BasicIndicator209)
        Me.Controls.Add(Me.BasicIndicator210)
        Me.Controls.Add(Me.BasicIndicator211)
        Me.Controls.Add(Me.BasicIndicator212)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.BasicIndicator213)
        Me.Controls.Add(Me.BasicIndicator214)
        Me.Controls.Add(Me.BasicIndicator215)
        Me.Controls.Add(Me.BasicIndicator216)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.BasicIndicator217)
        Me.Controls.Add(Me.BasicIndicator302)
        Me.Controls.Add(Me.BasicIndicator303)
        Me.Controls.Add(Me.BasicIndicator304)
        Me.Controls.Add(Me.CheckBox25)
        Me.Controls.Add(Me.BasicIndicator305)
        Me.Controls.Add(Me.BasicIndicator306)
        Me.Controls.Add(Me.BasicIndicator307)
        Me.Controls.Add(Me.BasicIndicator308)
        Me.Controls.Add(Me.CheckBox26)
        Me.Controls.Add(Me.BasicIndicator309)
        Me.Name = "CP31"
        Me.Text = "CP31"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents EthernetIPforCLXCom2 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BasicIndicator302 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator303 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator304 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents CheckBox25 As AdvancedHMIControls.CheckBox
    Friend WithEvents BasicIndicator305 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator306 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator307 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator308 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents CheckBox26 As AdvancedHMIControls.CheckBox
    Friend WithEvents BasicIndicator309 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator206 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator207 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator208 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents CheckBox6 As AdvancedHMIControls.CheckBox
    Friend WithEvents BasicIndicator209 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator210 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator211 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator212 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents CheckBox7 As AdvancedHMIControls.CheckBox
    Friend WithEvents BasicIndicator213 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator214 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator215 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator216 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents CheckBox8 As AdvancedHMIControls.CheckBox
    Friend WithEvents BasicIndicator217 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator218 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator219 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicIndicator220 As AdvancedHMIControls.BasicIndicator
    Friend WithEvents CheckBox9 As AdvancedHMIControls.CheckBox
    Friend WithEvents BasicIndicator221 As AdvancedHMIControls.BasicIndicator
End Class
