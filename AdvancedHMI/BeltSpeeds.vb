Public Class BeltSpeeds

    '//Handles Loading the Belt Speed Form!
    Private Sub BeltSpeeds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = SlamControls.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Exiting the Belt Speed Form!
    Private Sub BS_Exit_Click(sender As Object, e As EventArgs) Handles BS_Exit.Click
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