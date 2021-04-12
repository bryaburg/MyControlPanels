Public Class BeltSpeeds

    '//Handles Loading the Belt Speed Form!
    Private Sub BeltSpeeds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EthernetIPforCLXCom1.IPAddress = Excel.EthernetIPforCLXCom1.IPAddress
    End Sub

    '//Handles Exiting the Belt Speed Form!
    Private Sub BS_Exit_Click(sender As Object, e As EventArgs) Handles BS_Exit.Click
        Me.Close()
    End Sub

    '//Handles My Commands for Analog Displays!

End Class