Public Class Profiler

    '//Handles Loading Profiler Form
    Private Sub Profiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = Excel.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Exiting the Profiler Form!
    Private Sub Pro_Exit_Click(sender As Object, e As EventArgs) Handles Pro_Exit.Click
        Me.Close()
    End Sub

End Class