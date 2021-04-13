Public Class MachineDisplay
    Private Sub MachineDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '//Handles Date and Time
    Private Sub TiClk_Tick(sender As Object, e As EventArgs) Handles TiClk.Tick
        Dim cuDate As Date = Date.Now
        Dim sDate As String = cuDate.ToString("MMM-dd-yyyy")
        LbDate.Text = sDate
        LbClk.Text = TimeOfDay
    End Sub
End Class