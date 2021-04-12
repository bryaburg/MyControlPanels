Public Class PrinterCMD

    '//Handles Loading Printer Command Form!
    Private Sub PrinterCMD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = SlamControls.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Exiting Printer Command Form!
    Private Sub PrtCmdExit_Click(sender As Object, e As EventArgs) Handles PrtCmdExit.Click
        Me.Close()
    End Sub
End Class