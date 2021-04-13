Public Class TampConfig

    '//Handles Loading Tamp Configuration Form!
    Private Sub TampConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = SlamControls.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Closing Tamp Configuration Form!
    Private Sub TampConExit_Click(sender As Object, e As EventArgs) Handles TampConExit.Click
        Me.Close()
    End Sub

    '//Handles Date and Time
    Private Sub TiClk_Tick(sender As Object, e As EventArgs) Handles TiClk.Tick
        Dim cuDate As Date = Date.Now
        Dim sDate As String = cuDate.ToString("MMM-dd-yyyy")
        LbDate.Text = sDate
        LbClk.Text = TimeOfDay
    End Sub

End Class