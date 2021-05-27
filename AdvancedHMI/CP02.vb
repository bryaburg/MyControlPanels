Public Class CP02

    'Handles Loading CP02 Form!
    Private Sub CP02_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mBox As VariantType
        mBox = MsgBox("THIS PAGE IS UNDER CONSTRUCTION!!", vbYesNo, "WARNING!!")
        If mBox = vbYes Then
            Me.Show()
        Else
            Me.Close()
        End If
    End Sub

    'Handles opening the Legend!
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
                        "MDR's That Have E-STOP = Green is Good!!", "Conveyor Box Legend", MessageBoxButtons.OKCancel)

    End Sub

    'Handles Closing CP02!
    Private Sub CP02_Close_Click(sender As Object, e As EventArgs) Handles CP02_Close.Click
        Me.Close()
    End Sub

End Class