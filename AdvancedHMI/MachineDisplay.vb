Public Class MachineDisplay
    Private Sub MachineDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = SlamControls.EthernetIPforCLXCom1.IPAddress
        Prt1RodEx.Visible = False
    End Sub

    '//Handles Date and Time
    Private Sub TiClk_Tick(sender As Object, e As EventArgs) Handles TiClk.Tick
        Dim cuDate As Date = Date.Now
        Dim sDate As String = cuDate.ToString("MMM-dd-yyyy")
        LbDate.Text = sDate
        LbClk.Text = TimeOfDay
    End Sub

    Private Sub MacDisExit_Click(sender As Object, e As EventArgs) Handles MacDisExit.Click
        Me.Close()
    End Sub

    Private Sub prtOnePE2_Click(sender As Object, e As EventArgs) Handles prtOnePE2.Click

    End Sub

    Private Sub Prt1RodEx_Click(sender As Object, e As EventArgs) Handles Prt1RodEx.Click

    End Sub

    Private Sub showSlams_Click(sender As Object, e As EventArgs) Handles showSlams.Click
        SlamControls.Show()
    End Sub
End Class