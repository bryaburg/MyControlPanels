Public Class Communications

    '//Handles Loading Communications Form!
    Private Sub Communications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = SlamControls.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Exiting Communications Form!
    Private Sub commsExit_Click(sender As Object, e As EventArgs) Handles commsExit.Click
        Me.Close()
    End Sub
End Class