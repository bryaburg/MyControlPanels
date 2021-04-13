Public Class Profiler

    '//Handles Loading Profiler Form
    Private Sub Profiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = SlamControls.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Exiting the Profiler Form!
    Private Sub Pro_Exit_Click(sender As Object, e As EventArgs) Handles Pro_Exit.Click
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