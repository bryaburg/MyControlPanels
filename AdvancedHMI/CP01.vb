Public Class CP01

    Private Sub CP01_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Handles Closing CP01
    Private Sub CP01_Close_Click(sender As Object, e As EventArgs) Handles CP01_Close.Click
        Me.Close()
    End Sub

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

    'Handles All CheckBox Events!
    Private Sub VB01305_CheckedChanged(sender As Object, e As EventArgs) Handles VB01305.CheckedChanged
        InfoSheet.Show()
    End Sub

    Private Sub VB01405_CheckedChanged(sender As Object, e As EventArgs) Handles VB01405.CheckedChanged
        InfoSheet.Show()
    End Sub

    Private Sub VB01505_CheckedChanged(sender As Object, e As EventArgs) Handles VB01505.CheckedChanged
        InfoSheet.Show()
    End Sub

    Private Sub BasicIndicator859_Click(sender As Object, e As EventArgs) Handles BasicIndicator859.Click

    End Sub

    Private Sub BasicIndicator838_Click(sender As Object, e As EventArgs) Handles BasicIndicator838.Click

    End Sub

    Private Sub BasicIndicator839_Click(sender As Object, e As EventArgs) Handles BasicIndicator839.Click

    End Sub

    Private Sub BasicIndicator878_Click(sender As Object, e As EventArgs) Handles BasicIndicator878.Click

    End Sub

    Private Sub BasicIndicator874_Click(sender As Object, e As EventArgs) Handles BasicIndicator874.Click

    End Sub

    Private Sub BasicIndicator868_Click(sender As Object, e As EventArgs) Handles BasicIndicator868.Click

    End Sub

    Private Sub BasicIndicator864_Click(sender As Object, e As EventArgs) Handles BasicIndicator864.Click

    End Sub

    Private Sub BasicIndicator858_Click(sender As Object, e As EventArgs) Handles BasicIndicator858.Click

    End Sub

    Private Sub BasicIndicator863_Click(sender As Object, e As EventArgs) Handles BasicIndicator863.Click

    End Sub

    Private Sub BasicIndicator845_Click(sender As Object, e As EventArgs) Handles BasicIndicator845.Click

    End Sub

    Private Sub BasicIndicator844_Click(sender As Object, e As EventArgs) Handles BasicIndicator844.Click

    End Sub

    Private Sub BasicIndicator840_Click(sender As Object, e As EventArgs) Handles BasicIndicator840.Click

    End Sub

End Class