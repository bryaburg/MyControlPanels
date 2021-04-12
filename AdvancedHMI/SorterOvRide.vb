Public Class SorterOvRide

    '//Handles Sorter Override Loading!
    Private Sub SorterOvRide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = SlamControls.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Closing Sorter Override!
    Private Sub SortOvRideExit_Click(sender As Object, e As EventArgs) Handles SortOvRideExit.Click
        Me.Close()
    End Sub
End Class