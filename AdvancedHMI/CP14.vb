Public Class CP14

    'Handles Loading Form!
    Private Sub CP14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mBox As VariantType
        mBox = MsgBox("THIS PAGE IS UNDER CONSTRUCTION!!", vbYesNo, "WARNING!!")
        If mBox = vbYes Then
            Me.Show()
        Else
            Me.Close()
        End If
    End Sub

    'Hamdles Closing Form!
    Private Sub CP14_Close_Click(sender As Object, e As EventArgs) Handles CP14_Close.Click
        Me.Close()
    End Sub

    'Handles the Legend!
    Private Sub btnLegend_Click(sender As Object, e As EventArgs) Handles btnLegend.Click
        MessageBox.Show("JAM = Conveyor is Jammed!" & vbCrLf &
                        "JAM 2 = Downstream Jam!" & vbCrLf &
                        "RUN = Conveyor is Running!" & vbCrLf &
                        "RUN-F = Conveyor Running Forward!" & vbCrLf &
                        "RUN-R = Conveyor Running in Reverse!" & vbCrLf &
                        "STOP = Conveyor is Stopped!" & vbCrLf &
                        "MTR-F = Motor or VFD is Faulted!" & vbCrLf &
                        "E-STOP = Emergency Stop has been Pulled or Engaged!" & vbCrLf &
                        "MDR Jam = Sorter MDR is Jammed!" & vbCrLf &
                        "DSCON = The Remote Disconnect is OFF!" & vbCrLf &
                        "D.S.D.D = There is a conveyor downstream Stalled!" & vbCrLf &
                        "STALL = The Conveyor is stalled!" & vbCrLf &
                        "FAULT = MDR Card is Faulted!" & vbCrLf &
                        "50% = The Conveyor is 50% Full." & vbCrLf &
                        "Gold Box = Specific PhotoEye is Clear." & vbCrLf &
                        "Black Box = Specific PhotoEye is Blocked." & vbCrLf &
                        "MDR's PhotoEyes Are Gold When Product is Present!" & vbCrLf &
                        "MDR's That Have E-STOP = Green is Good!!" & vbCrLf &
                        "V.N.F.D = VFD Not Running Fault!" & vbCrLf &
                        "M.S.D = Missing Slat Detected!" & vbCrLf &
                        "O.L.W = Chain Overlength Warning!" & vbCrLf &
                        "VFD-F = VFD Faulted!" & vbCrLf &
                        "BR-CH = Broken Chain!" & vbCrLf &
                        "P.R.R = Panel Reset Required" & vbCrLf &
                        "PROD or FIRE = The Product Detect eye and the Firedoor PhotoEyes", "Conveyor Box Legend", MessageBoxButtons.OKCancel)
    End Sub

    'Handles All Text Changes!
    Private Sub OkToFeed1DS_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles OkToFeed1DS.DataChanged
        If e.Values(0) = True Then
            OkToFeed1.Text = "FEED!"
        Else
            OkToFeed1.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive14010_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive14010.DataChanged
        If e.Values(0) = True Then
            AR14010.Text = "READY"
        Else
            AR14010.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive14020_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive14020.DataChanged
        If e.Values(0) = True Then
            AR14020.Text = "READY"
        Else
            AR14020.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive14030_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive14030.DataChanged
        If e.Values(0) = True Then
            AR14030.Text = "READY"
        Else
            AR14030.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive14040_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive14040.DataChanged
        If e.Values(0) = True Then
            AR14040.Text = "READY"
        Else
            AR14040.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive14060_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive14060.DataChanged
        If e.Values(0) = True Then
            AR14060.Text = "READY"
        Else
            AR14060.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive14070_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive14070.DataChanged
        If e.Values(0) = True Then
            AR14070.Text = "READY"
        Else
            AR14070.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive14080_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive14080.DataChanged
        If e.Values(0) = True Then
            AR14080.Text = "READY"
        Else
            AR14080.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive14090_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive14090.DataChanged
        If e.Values(0) = True Then
            AR14090.Text = "READY"
        Else
            AR14090.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive14100_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive14100.DataChanged
        If e.Values(0) = True Then
            AR14100.Text = "READY"
        Else
            AR14100.Text = "NOT OK"
        End If
    End Sub

    'Handles Opening Page 2!
    Private Sub CP_14_2_Open_Click(sender As Object, e As EventArgs) Handles CP_14_2_Open.Click
        CP14p2.Show()
    End Sub

End Class