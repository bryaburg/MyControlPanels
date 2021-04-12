Public Class BaCoRdr1

    '//Handles Loading Barcode Reader Form!
    Private Sub BaCoRdr1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = SlamControls.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Exitng Barcode Reader Form!
    Private Sub BCR_Exit_Click(sender As Object, e As EventArgs) Handles BCR_Exit.Click
        Me.Close()
    End Sub
End Class