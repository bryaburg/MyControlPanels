Public Class TampConfig

    '//Handles Loading Tamp Configuration Form!
    Private Sub TampConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = Excel.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Closing Tamp Configuration Form!
    Private Sub TampConExit_Click(sender As Object, e As EventArgs) Handles TampConExit.Click
        Me.Close()
    End Sub

End Class