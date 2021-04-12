Public Class Training

    '//Handles Loading Training Form!
    Private Sub Training_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = Excel.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Closing Training Form!
    Private Sub TrainExit_Click(sender As Object, e As EventArgs) Handles TrainExit.Click
        Me.Close()
    End Sub
End Class