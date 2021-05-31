Public Class CP11p2

    'Handles Loading the Form
    Private Sub CP11p2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Handles Closing Form!
    Private Sub CP11_2_Close_Click(sender As Object, e As EventArgs) Handles CP11_2_Close.Click
        Me.Close()
    End Sub

    'Handles The Legend!
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
End Class