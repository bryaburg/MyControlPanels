Imports MfgControl.AdvancedHMI.Drivers.Common

Public Class Excel
    Private oXL As Microsoft.Office.Interop.Excel.Application
    Private oWB As Microsoft.Office.Interop.Excel.Workbook
    Private oSheet As Microsoft.Office.Interop.Excel.Worksheet

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start Excel and get Application object.
        oXL = CreateObject("Excel.Application")
        oXL.Visible = True

        ' Get a new workbook.
        oWB = oXL.Workbooks.Add
        oSheet = oWB.ActiveSheet
    End Sub

    Private Sub DataSubscriber1_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber1.DataChanged
        oSheet.Cells(3, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber2_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber2.DataChanged
        oSheet.Cells(4, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber3_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber3.DataChanged
        oSheet.Cells(5, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber4_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber4.DataChanged
        oSheet.Cells(6, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber5_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber5.DataChanged
        oSheet.Cells(7, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber6_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber6.DataChanged
        oSheet.Cells(8, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber7_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber7.DataChanged
        oSheet.Cells(9, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber8_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber8.DataChanged
        oSheet.Cells(10, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber9_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber9.DataChanged
        oSheet.Cells(11, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber10_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber10.DataChanged
        oSheet.Cells(12, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber11_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber11.DataChanged
        oSheet.Cells(3, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber12_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber12.DataChanged
        oSheet.Cells(4, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber13_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber13.DataChanged
        oSheet.Cells(5, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber14_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber14.DataChanged
        oSheet.Cells(6, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber15_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber15.DataChanged
        oSheet.Cells(7, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber16_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber16.DataChanged
        oSheet.Cells(8, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber17_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber17.DataChanged
        oSheet.Cells(9, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber18_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber18.DataChanged
        oSheet.Cells(10, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber19_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber19.DataChanged
        oSheet.Cells(11, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber20_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber20.DataChanged
        oSheet.Cells(12, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber21_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber21.DataChanged
        oSheet.Cells(3, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber22_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber22.DataChanged
        oSheet.Cells(4, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber23_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber23.DataChanged
        oSheet.Cells(5, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber24_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber24.DataChanged
        oSheet.Cells(6, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber25_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber25.DataChanged
        oSheet.Cells(7, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber26_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber26.DataChanged
        oSheet.Cells(8, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber27_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber27.DataChanged
        oSheet.Cells(9, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber28_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber28.DataChanged
        oSheet.Cells(10, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber29_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber29.DataChanged
        oSheet.Cells(11, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber30_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber30.DataChanged
        oSheet.Cells(12, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber31_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber31.DataChanged
        oSheet.Cells(24, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber32_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber32.DataChanged
        oSheet.Cells(24, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber33_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber33.DataChanged
        oSheet.Cells(24, 3).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber34_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber34.DataChanged
        oSheet.Cells(24, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber35_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber35.DataChanged
        oSheet.Cells(24, 5).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber36_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber36.DataChanged
        oSheet.Cells(24, 6).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber37_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber37.DataChanged
        oSheet.Cells(24, 7).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber38_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber38.DataChanged
        oSheet.Cells(24, 8).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber39_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber39.DataChanged
        oSheet.Cells(24, 9).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber40_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber40.DataChanged
        oSheet.Cells(24, 10).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber41_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber41.DataChanged
        oSheet.Cells(26, 1).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber42_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber42.DataChanged
        oSheet.Cells(26, 2).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber43_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber43.DataChanged
        oSheet.Cells(26, 3).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber44_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber44.DataChanged
        oSheet.Cells(26, 4).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber45_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber45.DataChanged
        oSheet.Cells(26, 5).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber46_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber46.DataChanged
        oSheet.Cells(26, 6).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber47_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber47.DataChanged
        oSheet.Cells(26, 7).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber48_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber48.DataChanged
        oSheet.Cells(26, 8).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber49_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber49.DataChanged
        oSheet.Cells(26, 9).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber50_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber50.DataChanged
        oSheet.Cells(26, 10).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber52_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber52.DataChanged
        oSheet.Cells(4, 6).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber51_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber51.DataChanged
        oSheet.Cells(3, 6).Value = e.Values(0)
    End Sub

    Private Sub DataSubscriber53_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber53.DataChanged
        oSheet.Cells(7, 6).Value = e.Values(0)
    End Sub
End Class