Public Class CP12

    'Handles Loading Form!
    Private Sub CP12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mBox As VariantType
        mBox = MsgBox("THIS PAGE IS UNDER CONSTRUCTION!!", vbYesNo, "WARNING!!")
        If mBox = vbYes Then
            Me.Show()
        Else
            Me.Close()
        End If
    End Sub

    'Handles Closing Form!
    Private Sub CP12_Close_Click(sender As Object, e As EventArgs) Handles CP12_Close.Click
        Me.Close()
    End Sub

    'Handles Opening the Legend!
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
    Private Sub OkToFeed1DS_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles OkToFeed1DS.DataChanged
        If e.Values(0) = True Then
            OkToFeed1.Text = "FEED!"
        Else
            OkToFeed1.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive12010_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive12010.DataChanged
        If e.Values(0) = True Then
            AR12010.Text = "READY"
        Else
            AR12010.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive12020_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive12020.DataChanged
        If e.Values(0) = True Then
            AR12020.Text = "READY"
        Else
            AR12020.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive12030_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive12030.DataChanged
        If e.Values(0) = True Then
            AR12030.Text = "READY"
        Else
            AR12030.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive12040_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive12040.DataChanged
        If e.Values(0) = True Then
            AR12040.Text = "READY"
        Else
            AR12040.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive12060_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive12060.DataChanged
        If e.Values(0) = True Then
            AR12060.Text = "READY"
        Else
            AR12060.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive12070_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive12070.DataChanged
        If e.Values(0) = True Then
            AR12070.Text = "READY"
        Else
            AR12070.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive12080_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive12080.DataChanged
        If e.Values(0) = True Then
            AR12080.Text = "READY"
        Else
            AR12080.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive12090_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive12090.DataChanged
        If e.Values(0) = True Then
            AR12090.Text = "READY"
        Else
            AR12090.Text = "NOT OK"
        End If
    End Sub

    Private Sub ArReadyToReceive12100_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles ArReadyToReceive12100.DataChanged
        If e.Values(0) = True Then
            AR12100.Text = "READY"
        Else
            AR12100.Text = "NOT OK"
        End If
    End Sub
End Class