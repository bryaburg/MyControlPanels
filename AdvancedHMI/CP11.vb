Public Class CP11
    'Handles My Load Events!
    Private Sub CP11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mBox As VariantType
        mBox = MsgBox("THIS PAGE IS UNDER CONSTRUCTION!!", vbYesNo, "WARNING!!")
        If mBox = vbYes Then
            Me.Show()
        Else
            Me.Close()
        End If
    End Sub

    'Handles Closing Form!
    Private Sub CP11_Close_Click(sender As Object, e As EventArgs) Handles CP11_Close.Click
        Me.Close()
    End Sub

    'Handles Legend!
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

    'Handles All Text Change!
    Private Sub OkToFeedDS_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles OkToFeedDS.DataChanged
        If e.Values(0) = True Then
            OkToFeed.Text = "FEED!"
        Else
            OkToFeed.Text = "NOT OK"
        End If
    End Sub

    Private Sub OkToFeed1DS_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles OkToFeed1DS.DataChanged
        If e.Values(0) = True Then
            OkToFeed1.Text = "FEED!"
        Else
            OkToFeed1.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive11010_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive11010.DataChanged
        If e.Values(0) = True Then
            AR11010.Text = "READY"
        Else
            AR11010.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive11020_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive11020.DataChanged
        If e.Values(0) = True Then
            AR11020.Text = "READY"
        Else
            AR11020.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive11030_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive11030.DataChanged
        If e.Values(0) = True Then
            AR11030.Text = "READY"
        Else
            AR11030.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive11040_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive11040.DataChanged
        If e.Values(0) = True Then
            AR11040.Text = "READY"
        Else
            AR11040.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive11060_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive11060.DataChanged
        If e.Values(0) = True Then
            AR11060.Text = "READY"
        Else
            AR11060.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive11070_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive11070.DataChanged
        If e.Values(0) = True Then
            AR11070.Text = "READY"
        Else
            AR11070.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive11080_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive11080.DataChanged
        If e.Values(0) = True Then
            AR11080.Text = "READY"
        Else
            AR11080.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive11090_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive11090.DataChanged
        If e.Values(0) = True Then
            AR11090.Text = "READY"
        Else
            AR11090.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive11100_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive11100.DataChanged
        If e.Values(0) = True Then
            AR11100.Text = "READY"
        Else
            AR11100.Text = "NOT OK"
        End If
    End Sub

    'Handles Opening Page 2!
    Private Sub CP_11_2_Open_Click(sender As Object, e As EventArgs) Handles CP_11_2_Open.Click
        CP11p2.Show()
    End Sub
End Class