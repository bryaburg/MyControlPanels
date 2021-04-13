Public Class BaCoRdr1

    '//Handles Loading Barcode Reader Form!
    Private Sub BaCoRdr1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = SlamControls.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Exitng Barcode Reader Form!
    Private Sub BCR_Exit_Click(sender As Object, e As EventArgs) Handles BCR_Exit.Click
        Me.Close()
    End Sub

    '//Handles Time
    Private Sub TiClk_Tick(sender As Object, e As EventArgs) Handles TiClk.Tick
        Dim cuDate As Date = Date.Now
        Dim sDate As String = cuDate.ToString("MMM-dd-yyyy")
        LbDate.Text = sDate
        LbClk.Text = TimeOfDay
    End Sub

    Private Sub LbDate_Click(sender As Object, e As EventArgs) Handles LbDate.Click

    End Sub

    Private Sub LbClk_Click(sender As Object, e As EventArgs) Handles LbClk.Click

    End Sub
End Class