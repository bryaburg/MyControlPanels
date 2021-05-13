Imports System.ComponentModel
Imports MfgControl.AdvancedHMI.Drivers.Common

Public Class SlamControls
    Private oXL As Microsoft.Office.Interop.Excel.Application
    Private oWB As Microsoft.Office.Interop.Excel.Workbook
    Public cSh As Microsoft.Office.Interop.Excel.Worksheet

    '//Declared Variables to use in my Subs!
    Private clxVal As String
    Private plcAdd() As String
    Private pVal As String
    Private cVal As Microsoft.Office.Interop.Excel.Range
    Private cX, cX1, cX2 As Integer
    Private index, index1, dex, input, myCom As String
    Private btnBool As Boolean = False
    Private btnBool1 As Boolean = False
    Private errCode() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    '//Handles Loading Slam Controls and Excel Form!
    Private Sub SlamControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '//Handles Date and Time
    Private Sub TiClk_Tick(sender As Object, e As EventArgs) Handles TiClk.Tick
        Dim cuDate As Date = Date.Now
        Dim sDate As String = cuDate.ToString("MMM-dd-yyyy")
        LabDate.Text = sDate
        LabTime.Text = TimeOfDay
    End Sub

    '//Button to Load Chosen Slam!
    Private Sub BasicButton1_Click(sender As Object, e As EventArgs) Handles ChooseSlam.Click
        Try
            input = InputBox("101 = Slam 1.    102 = Slam 2." & vbCrLf &
                         "103 = Slam 3.    304 = Slam 4." & vbCrLf &
                         "305 = Slam 5.    306 = Slam 5." & vbCrLf &
                         "307 = Slam 7.    208 = Slam 8." & vbCrLf &
                         "209 = Slam 9.    210 = Slam 10", "Please Enter Slam ID:")
            Select Case input
                Case "101"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.58"
                    Me.plStop.Text = "STOP 101"
                    Me.plStart.Text = "START 101"
                    Me.plReset.Text = "RESET 101"
                    Me.plFault.Text = "FAULT 101"
                    Me.plAbort.Text = "ABORT 101"
                Case "102"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.67"
                    Me.plStop.Text = "STOP 102"
                    Me.plStart.Text = "START 102"
                    Me.plReset.Text = "RESET 102"
                    Me.plFault.Text = "FAULT 102"
                    Me.plAbort.Text = "ABORT 102"
                Case "103"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.76"
                    Me.plStop.Text = "STOP 103"
                    Me.plStart.Text = "START 103"
                    Me.plReset.Text = "RESET 103"
                    Me.plFault.Text = "FAULT 103"
                    Me.plAbort.Text = "ABORT 103"
                Case "304"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.85"
                    Me.plStop.Text = "STOP 304"
                    Me.plStart.Text = "START 304"
                    Me.plReset.Text = "RESET 304"
                    Me.plFault.Text = "FAULT 304"
                    Me.plAbort.Text = "ABORT 304"
                Case "305"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.95"
                    Me.plStop.Text = "STOP 305"
                    Me.plStart.Text = "START 305"
                    Me.plReset.Text = "RESET 305"
                    Me.plFault.Text = "FAULT 305"
                    Me.plAbort.Text = "ABORT 305"
                Case "306"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.108"
                    Me.plStop.Text = "STOP 306"
                    Me.plStart.Text = "START 306"
                    Me.plReset.Text = "RESET 306"
                    Me.plFault.Text = "FAULT 306"
                    Me.plAbort.Text = "ABORT 306"
                Case "307"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.146"
                    Me.plStop.Text = "STOP 307"
                    Me.plStart.Text = "START 307"
                    Me.plReset.Text = "RESET 307"
                    Me.plFault.Text = "FAULT 307"
                    Me.plAbort.Text = "ABORT 307"
                Case "208"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.156"
                    Me.plStop.Text = "STOP 208"
                    Me.plStart.Text = "START 208"
                    Me.plReset.Text = "RESET 208"
                    Me.plFault.Text = "FAULT 208"
                    Me.plAbort.Text = "ABORT 208"
                Case "209"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.171"
                    Me.plStop.Text = "STOP 209"
                    Me.plStart.Text = "START 209"
                    Me.plReset.Text = "RESET 209"
                    Me.plFault.Text = "FAULT 209"
                    Me.plAbort.Text = "ABORT 209"
                Case "210"
                    Me.EthernetIPforCLXCom1.IPAddress = "10.8.236.184"
                    Me.plStop.Text = "STOP 210"
                    Me.plStart.Text = "START 210"
                    Me.plReset.Text = "RESET 210"
                    Me.plFault.Text = "FAULT 210"
                    Me.plAbort.Text = "ABORT 210"
                Case Else
                    MessageBox.Show("Invalid Entry" & vbCrLf & "Please Enter Correct Slam ID:", "Invalid Entry", MessageBoxButtons.OK)
            End Select
        Catch ex As Exception
            MsgBox("Excel Load Button", ex.Message)
        End Try
    End Sub

    '//Opening and Closing Excel Sub
    Private Sub opExChBox1_CheckedChanged(sender As Object, e As EventArgs) Handles opExChBox1.CheckedChanged
        Try
            If Me.opExChBox1.CheckState = CheckState.Checked Then
                ' Start Excel and get Application object.
                oXL = CreateObject("Excel.Application")

                ' Get a new workbook.
                oWB = oXL.Workbooks.Add
                cSh = oWB.ActiveSheet

                Me.oXL.Visible = True
                btnBool = True
                opExChBox1.Text = "Excel Open"
            ElseIf opExChBox1.CheckState = CheckState.Unchecked Then
                btnBool = False
                Me.opExChBox1.Text = "Open Excel"
                Me.oWB.Close()
                Me.oWB = Nothing
                Me.oXL.Quit()
                Me.oXL = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)
        End Try
    End Sub

    '//Sub to read data from the CLX
    Private Sub EthernetIPforCLXCom1_DataReceived(sender As Object, e As PlcComEventArgs) Handles EthernetIPforCLXCom1.DataReceived

    End Sub

    '//last 10 kickout codes
    Private Sub DataSubscriber210_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber210.DataChanged
        If btnBool = True Then
            Try
                clxVal = e.PlcAddress
                plcAdd = {"HMI_Last10KO[0]", "HMI_Last10KO[1]", "HMI_Last10KO[2]", "HMI_Last10KO[3]", "HMI_Last10KO[4]", "HMI_Last10KO[5]",
            "HMI_Last10KO[6]", "HMI_Last10KO[7]", "HMI_Last10KO[8]", "HMI_Last10KO[9]"}
                cVal = cSh.Cells
                pVal = e.Values(0)
                cX = 3
                For Each index In plcAdd
                    If clxVal = index Then
                        cVal(cX, 2) = pVal
                    End If
                    cX += 1
                Next
            Catch ex As Exception
                MsgBox("Last 10 KO Codes", ex.Message)
            End Try
        End If
    End Sub

    ''//Kickout TimeStamps
    Private Sub DataSubscriber211_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber211.DataChanged
        If btnBool = True Then
            Try
                clxVal = e.PlcAddress
                plcAdd = {"HMI_Last10Time[0]", "HMI_Last10Time[1]", "HMI_Last10Time[2]", "HMI_Last10Time[3]", "HMI_Last10Time[4]", "HMI_Last10Time[5]",
                "HMI_Last10Time[6]", "HMI_Last10Time[7]", "HMI_Last10Time[8]", "HMI_Last10Time[9]"}
                cVal = cSh.Cells
                pVal = e.Values(0)
                cX = 3
                For Each index In plcAdd
                    If clxVal = index Then
                        cVal(cX, 1) = pVal
                    End If
                    cX += 1
                Next
            Catch ex As Exception
                MsgBox("Time of KO", ex.Message)
            End Try
        End If
    End Sub

    ''///event message display
    Private Sub DataSubscriber21_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber21.DataChanged
        If btnBool = True Then
            Try
                clxVal = e.PlcAddress
                plcAdd = {"Event_ActiveEvents[0]", "Event_ActiveEvents[1]", "Event_ActiveEvents[2]", "Event_ActiveEvents[3]", "Event_ActiveEvents[4]",
                "Event_ActiveEvents[5]", "Event_ActiveEvents[6]", "Event_ActiveEvents[7]", "Event_ActiveEvents[8]", "Event_ActiveEvents[9]"}
                cVal = cSh.Cells
                pVal = e.Values(0)
                cX = 3
                For Each index In plcAdd
                    If clxVal = index Then
                        cVal(cX, 4) = pVal
                    End If
                    cX += 1
                Next
            Catch ex As Exception
                MsgBox("Events Display", ex.Message)
            End Try
        End If
    End Sub

    ''//subscribers for package success or failure.
    Private Sub DataSubscriber22_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber22.DataChanged
        If btnBool = True Then
            Try
                clxVal = e.PlcAddress
                plcAdd = {"Packages[0].WmsData.KO", "Packages[1].WmsData.KO", "Packages[2].WmsData.KO", "Packages[3].WmsData.KO", "Packages[4].WmsData.KO",
                "Packages[5].WmsData.KO", "Packages[6].WmsData.KO", "Packages[7].WmsData.KO", "Packages[8].WmsData.KO", "Packages[9].WmsData.KO",
                "Packages[10].WmsData.KO", "Packages[11].WmsData.KO", "Packages[12].WmsData.KO", "Packages[13].WmsData.KO", "Packages[14].WmsData.KO",
                "Packages[15].WmsData.KO", "Packages[16].WmsData.KO", "Packages[17].WmsData.KO", "Packages[18].WmsData.KO", "Packages[19].WmsData.KO"}
                cVal = cSh.Cells
                pVal = e.Values(0)
                cX = 15
                For Each index In plcAdd
                    If clxVal = index Then
                        cVal(cX, 1) = pVal
                    End If
                    cX += 1
                Next
            Catch ex As Exception
                MsgBox("1st Success/Failure array", ex.Message)
            End Try
        End If

    End Sub

    '//Total Packages and Kickouts
    Private Sub DataSubscriber24_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber24.DataChanged
        If btnBool = True Then
            Try
                clxVal = e.PlcAddress
                plcAdd = {"HMI_ParcelCount", "HMI_KickoutCount", "KickoutbyPrinters", "AuditValueDint[0]"}
                cVal = cSh.Cells
                pVal = e.Values(0)
                cX = 3
                For Each index In plcAdd
                    If clxVal = index Then
                        cVal(cX, 6) = pVal
                    End If
                    If cX = 5 Then
                        cX += 2
                    Else
                        cX += 1
                    End If
                Next
            Catch ex As Exception
                MsgBox("Total Packages and Kickouts", ex.Message)
            End Try
        End If
    End Sub


    '//Scale Scanner BarCodes!!
    Private Sub DataSubscriber23_DataChanged(sender As Object, e As PlcComEventArgs) Handles DataSubscriber23.DataChanged
        If btnBool = True Then
            Try
                plcAdd = {"Packages[0].ScaleScan.Barcodes.DATA[4]", "Packages[0].ScaleScan.Barcodes.DATA[5]", "Packages[0].ScaleScan.Barcodes.DATA[6]",
                    "Packages[0].ScaleScan.Barcodes.DATA[7]", "Packages[0].ScaleScan.Barcodes.DATA[8]", "Packages[0].ScaleScan.Barcodes.DATA[9]",
                    "Packages[0].ScaleScan.Barcodes.DATA[10]", "Packages[0].ScaleScan.Barcodes.DATA[11]", "Packages[0].ScaleScan.Barcodes.DATA[12]",
                    "Packages[0].ScaleScan.Barcodes.DATA[13]", "Packages[0].ScaleScan.Barcodes.DATA[14]", "Packages[1].ScaleScan.Barcodes.DATA[4]",
                    "Packages[1].ScaleScan.Barcodes.DATA[5]", "Packages[1].ScaleScan.Barcodes.DATA[6]", "Packages[1].ScaleScan.Barcodes.DATA[7]",
                    "Packages[1].ScaleScan.Barcodes.DATA[8]", "Packages[1].ScaleScan.Barcodes.DATA[9]", "Packages[1].ScaleScan.Barcodes.DATA[10]",
                    "Packages[1].ScaleScan.Barcodes.DATA[11]", "Packages[1].ScaleScan.Barcodes.DATA[12]", "Packages[1].ScaleScan.Barcodes.DATA[13]",
                    "Packages[1].ScaleScan.Barcodes.DATA[14]", "Packages[2].ScaleScan.Barcodes.DATA[4]", "Packages[2].ScaleScan.Barcodes.DATA[5]", "Packages[2].ScaleScan.Barcodes.DATA[6]",
                    "Packages[2].ScaleScan.Barcodes.DATA[7]", "Packages[2].ScaleScan.Barcodes.DATA[8]", "Packages[2].ScaleScan.Barcodes.DATA[9]",
                    "Packages[2].ScaleScan.Barcodes.DATA[10]", "Packages[2].ScaleScan.Barcodes.DATA[11]", "Packages[2].ScaleScan.Barcodes.DATA[12]",
                    "Packages[2].ScaleScan.Barcodes.DATA[13]", "Packages[2].ScaleScan.Barcodes.DATA[14]", "Packages[3].ScaleScan.Barcodes.DATA[4]",
                    "Packages[3].ScaleScan.Barcodes.DATA[5]", "Packages[3].ScaleScan.Barcodes.DATA[6]", "Packages[3].ScaleScan.Barcodes.DATA[7]",
                    "Packages[3].ScaleScan.Barcodes.DATA[8]", "Packages[3].ScaleScan.Barcodes.DATA[9]", "Packages[3].ScaleScan.Barcodes.DATA[10]",
                    "Packages[3].ScaleScan.Barcodes.DATA[11]", "Packages[3].ScaleScan.Barcodes.DATA[12]", "Packages[3].ScaleScan.Barcodes.DATA[13]",
                    "Packages[3].ScaleScan.Barcodes.DATA[14]", "Packages[4].ScaleScan.Barcodes.DATA[4]", "Packages[4].ScaleScan.Barcodes.DATA[5]", "Packages[4].ScaleScan.Barcodes.DATA[6]",
                    "Packages[4].ScaleScan.Barcodes.DATA[7]", "Packages[4].ScaleScan.Barcodes.DATA[8]", "Packages[4].ScaleScan.Barcodes.DATA[9]",
                    "Packages[4].ScaleScan.Barcodes.DATA[10]", "Packages[4].ScaleScan.Barcodes.DATA[11]", "Packages[4].ScaleScan.Barcodes.DATA[12]",
                    "Packages[4].ScaleScan.Barcodes.DATA[13]", "Packages[4].ScaleScan.Barcodes.DATA[14]", "Packages[5].ScaleScan.Barcodes.DATA[4]",
                    "Packages[5].ScaleScan.Barcodes.DATA[5]", "Packages[5].ScaleScan.Barcodes.DATA[6]", "Packages[5].ScaleScan.Barcodes.DATA[7]",
                    "Packages[5].ScaleScan.Barcodes.DATA[8]", "Packages[5].ScaleScan.Barcodes.DATA[9]", "Packages[5].ScaleScan.Barcodes.DATA[10]",
                    "Packages[5].ScaleScan.Barcodes.DATA[11]", "Packages[5].ScaleScan.Barcodes.DATA[12]", "Packages[5].ScaleScan.Barcodes.DATA[13]",
                    "Packages[5].ScaleScan.Barcodes.DATA[14]", "Packages[6].ScaleScan.Barcodes.DATA[4]", "Packages[6].ScaleScan.Barcodes.DATA[5]", "Packages[6].ScaleScan.Barcodes.DATA[6]",
                    "Packages[6].ScaleScan.Barcodes.DATA[7]", "Packages[6].ScaleScan.Barcodes.DATA[8]", "Packages[6].ScaleScan.Barcodes.DATA[9]",
                    "Packages[6].ScaleScan.Barcodes.DATA[10]", "Packages[6].ScaleScan.Barcodes.DATA[11]", "Packages[6].ScaleScan.Barcodes.DATA[12]",
                    "Packages[6].ScaleScan.Barcodes.DATA[13]", "Packages[6].ScaleScan.Barcodes.DATA[14]", "Packages[7].ScaleScan.Barcodes.DATA[4]",
                    "Packages[7].ScaleScan.Barcodes.DATA[5]", "Packages[7].ScaleScan.Barcodes.DATA[6]", "Packages[7].ScaleScan.Barcodes.DATA[7]",
                    "Packages[7].ScaleScan.Barcodes.DATA[8]", "Packages[7].ScaleScan.Barcodes.DATA[9]", "Packages[7].ScaleScan.Barcodes.DATA[10]",
                    "Packages[7].ScaleScan.Barcodes.DATA[11]", "Packages[7].ScaleScan.Barcodes.DATA[12]", "Packages[7].ScaleScan.Barcodes.DATA[13]",
                    "Packages[7].ScaleScan.Barcodes.DATA[14]", "Packages[8].ScaleScan.Barcodes.DATA[4]", "Packages[8].ScaleScan.Barcodes.DATA[5]", "Packages[8].ScaleScan.Barcodes.DATA[6]",
                    "Packages[8].ScaleScan.Barcodes.DATA[7]", "Packages[8].ScaleScan.Barcodes.DATA[8]", "Packages[8].ScaleScan.Barcodes.DATA[9]",
                    "Packages[8].ScaleScan.Barcodes.DATA[10]", "Packages[8].ScaleScan.Barcodes.DATA[11]", "Packages[8].ScaleScan.Barcodes.DATA[12]",
                    "Packages[8].ScaleScan.Barcodes.DATA[13]", "Packages[8].ScaleScan.Barcodes.DATA[14]", "Packages[9].ScaleScan.Barcodes.DATA[4]",
                    "Packages[9].ScaleScan.Barcodes.DATA[5]", "Packages[9].ScaleScan.Barcodes.DATA[6]", "Packages[9].ScaleScan.Barcodes.DATA[7]",
                    "Packages[9].ScaleScan.Barcodes.DATA[8]", "Packages[9].ScaleScan.Barcodes.DATA[9]", "Packages[9].ScaleScan.Barcodes.DATA[10]",
                    "Packages[9].ScaleScan.Barcodes.DATA[11]", "Packages[9].ScaleScan.Barcodes.DATA[12]", "Packages[9].ScaleScan.Barcodes.DATA[13]",
                    "Packages[9].ScaleScan.Barcodes.DATA[14]", "Packages[10].ScaleScan.Barcodes.DATA[4]", "Packages[10].ScaleScan.Barcodes.DATA[5]", "Packages[10].ScaleScan.Barcodes.DATA[6]",
                    "Packages[10].ScaleScan.Barcodes.DATA[7]", "Packages[10].ScaleScan.Barcodes.DATA[8]", "Packages[10].ScaleScan.Barcodes.DATA[9]",
                    "Packages[10].ScaleScan.Barcodes.DATA[10]", "Packages[10].ScaleScan.Barcodes.DATA[11]", "Packages[10].ScaleScan.Barcodes.DATA[12]",
                    "Packages[10].ScaleScan.Barcodes.DATA[13]", "Packages[10].ScaleScan.Barcodes.DATA[14]", "Packages[11].ScaleScan.Barcodes.DATA[4]",
                    "Packages[11].ScaleScan.Barcodes.DATA[5]", "Packages[11].ScaleScan.Barcodes.DATA[6]", "Packages[11].ScaleScan.Barcodes.DATA[7]",
                    "Packages[11].ScaleScan.Barcodes.DATA[8]", "Packages[11].ScaleScan.Barcodes.DATA[9]", "Packages[11].ScaleScan.Barcodes.DATA[10]",
                    "Packages[11].ScaleScan.Barcodes.DATA[11]", "Packages[11].ScaleScan.Barcodes.DATA[12]", "Packages[11].ScaleScan.Barcodes.DATA[13]",
                    "Packages[11].ScaleScan.Barcodes.DATA[14]", "Packages[12].ScaleScan.Barcodes.DATA[4]", "Packages[12].ScaleScan.Barcodes.DATA[5]", "Packages[12].ScaleScan.Barcodes.DATA[6]",
                    "Packages[12].ScaleScan.Barcodes.DATA[7]", "Packages[12].ScaleScan.Barcodes.DATA[8]", "Packages[12].ScaleScan.Barcodes.DATA[9]",
                    "Packages[12].ScaleScan.Barcodes.DATA[10]", "Packages[12].ScaleScan.Barcodes.DATA[11]", "Packages[12].ScaleScan.Barcodes.DATA[12]",
                    "Packages[12].ScaleScan.Barcodes.DATA[13]", "Packages[12].ScaleScan.Barcodes.DATA[14]", "Packages[13].ScaleScan.Barcodes.DATA[4]",
                    "Packages[13].ScaleScan.Barcodes.DATA[5]", "Packages[13].ScaleScan.Barcodes.DATA[6]", "Packages[13].ScaleScan.Barcodes.DATA[7]",
                    "Packages[13].ScaleScan.Barcodes.DATA[8]", "Packages[13].ScaleScan.Barcodes.DATA[9]", "Packages[13].ScaleScan.Barcodes.DATA[10]",
                    "Packages[13].ScaleScan.Barcodes.DATA[11]", "Packages[13].ScaleScan.Barcodes.DATA[12]", "Packages[13].ScaleScan.Barcodes.DATA[13]",
                    "Packages[13].ScaleScan.Barcodes.DATA[14]", "Packages[14].ScaleScan.Barcodes.DATA[4]", "Packages[14].ScaleScan.Barcodes.DATA[5]", "Packages[14].ScaleScan.Barcodes.DATA[6]",
                    "Packages[14].ScaleScan.Barcodes.DATA[7]", "Packages[14].ScaleScan.Barcodes.DATA[8]", "Packages[14].ScaleScan.Barcodes.DATA[9]",
                    "Packages[14].ScaleScan.Barcodes.DATA[10]", "Packages[14].ScaleScan.Barcodes.DATA[11]", "Packages[14].ScaleScan.Barcodes.DATA[12]",
                    "Packages[14].ScaleScan.Barcodes.DATA[13]", "Packages[14].ScaleScan.Barcodes.DATA[14]", "Packages[15].ScaleScan.Barcodes.DATA[4]",
                    "Packages[15].ScaleScan.Barcodes.DATA[5]", "Packages[15].ScaleScan.Barcodes.DATA[6]", "Packages[15].ScaleScan.Barcodes.DATA[7]",
                    "Packages[15].ScaleScan.Barcodes.DATA[8]", "Packages[15].ScaleScan.Barcodes.DATA[9]", "Packages[15].ScaleScan.Barcodes.DATA[10]",
                    "Packages[15].ScaleScan.Barcodes.DATA[11]", "Packages[15].ScaleScan.Barcodes.DATA[12]", "Packages[15].ScaleScan.Barcodes.DATA[13]",
                    "Packages[15].ScaleScan.Barcodes.DATA[14]", "Packages[16].ScaleScan.Barcodes.DATA[4]", "Packages[16].ScaleScan.Barcodes.DATA[5]", "Packages[16].ScaleScan.Barcodes.DATA[6]",
                    "Packages[16].ScaleScan.Barcodes.DATA[7]", "Packages[16].ScaleScan.Barcodes.DATA[8]", "Packages[16].ScaleScan.Barcodes.DATA[9]",
                    "Packages[16].ScaleScan.Barcodes.DATA[10]", "Packages[16].ScaleScan.Barcodes.DATA[11]", "Packages[16].ScaleScan.Barcodes.DATA[12]",
                    "Packages[16].ScaleScan.Barcodes.DATA[13]", "Packages[16].ScaleScan.Barcodes.DATA[14]", "Packages[17].ScaleScan.Barcodes.DATA[4]",
                    "Packages[17].ScaleScan.Barcodes.DATA[5]", "Packages[17].ScaleScan.Barcodes.DATA[6]", "Packages[17].ScaleScan.Barcodes.DATA[7]",
                    "Packages[17].ScaleScan.Barcodes.DATA[8]", "Packages[17].ScaleScan.Barcodes.DATA[9]", "Packages[17].ScaleScan.Barcodes.DATA[10]",
                    "Packages[17].ScaleScan.Barcodes.DATA[11]", "Packages[17].ScaleScan.Barcodes.DATA[12]", "Packages[17].ScaleScan.Barcodes.DATA[13]",
                    "Packages[17].ScaleScan.Barcodes.DATA[14]", "Packages[18].ScaleScan.Barcodes.DATA[4]", "Packages[18].ScaleScan.Barcodes.DATA[5]", "Packages[18].ScaleScan.Barcodes.DATA[6]",
                    "Packages[18].ScaleScan.Barcodes.DATA[7]", "Packages[18].ScaleScan.Barcodes.DATA[8]", "Packages[18].ScaleScan.Barcodes.DATA[9]",
                    "Packages[18].ScaleScan.Barcodes.DATA[10]", "Packages[18].ScaleScan.Barcodes.DATA[11]", "Packages[18].ScaleScan.Barcodes.DATA[12]",
                    "Packages[18].ScaleScan.Barcodes.DATA[13]", "Packages[18].ScaleScan.Barcodes.DATA[14]", "Packages[19].ScaleScan.Barcodes.DATA[4]",
                    "Packages[19].ScaleScan.Barcodes.DATA[5]", "Packages[19].ScaleScan.Barcodes.DATA[6]", "Packages[19].ScaleScan.Barcodes.DATA[7]",
                    "Packages[19].ScaleScan.Barcodes.DATA[8]", "Packages[19].ScaleScan.Barcodes.DATA[9]", "Packages[19].ScaleScan.Barcodes.DATA[10]",
                    "Packages[19].ScaleScan.Barcodes.DATA[11]", "Packages[19].ScaleScan.Barcodes.DATA[12]", "Packages[19].ScaleScan.Barcodes.DATA[13]",
                    "Packages[19].ScaleScan.Barcodes.DATA[14]", "Packages[0].VerifyScan.Barcodes.DATA[0]", "Packages[0].VerifyScan.Barcodes.DATA[1]", "Packages[0].VerifyScan.Barcodes.DATA[2]",
                    "Packages[0].VerifyScan.Barcodes.DATA[3]", "Packages[0].VerifyScan.Barcodes.DATA[4]", "Packages[0].VerifyScan.Barcodes.DATA[5]",
                    "Packages[0].VerifyScan.Barcodes.DATA[6]", "Packages[0].VerifyScan.Barcodes.DATA[7]", "Packages[0].VerifyScan.Barcodes.DATA[8]",
                    "Packages[0].VerifyScan.Barcodes.DATA[9]", "Packages[0].VerifyScan.Barcodes.DATA[10]", "Packages[1].VerifyScan.Barcodes.DATA[0]",
                    "Packages[1].VerifyScan.Barcodes.DATA[1]", "Packages[1].VerifyScan.Barcodes.DATA[2]", "Packages[1].VerifyScan.Barcodes.DATA[3]",
                    "Packages[1].VerifyScan.Barcodes.DATA[4]", "Packages[1].VerifyScan.Barcodes.DATA[5]", "Packages[1].VerifyScan.Barcodes.DATA[6]",
                    "Packages[1].VerifyScan.Barcodes.DATA[7]", "Packages[1].VerifyScan.Barcodes.DATA[8]", "Packages[1].VerifyScan.Barcodes.DATA[9]",
                    "Packages[1].VerifyScan.Barcodes.DATA[10]", "Packages[2].VerifyScan.Barcodes.DATA[0]", "Packages[2].VerifyScan.Barcodes.DATA[1]", "Packages[2].VerifyScan.Barcodes.DATA[2]",
                    "Packages[2].VerifyScan.Barcodes.DATA[3]", "Packages[2].VerifyScan.Barcodes.DATA[4]", "Packages[2].VerifyScan.Barcodes.DATA[5]",
                    "Packages[2].VerifyScan.Barcodes.DATA[6]", "Packages[2].VerifyScan.Barcodes.DATA[7]", "Packages[2].VerifyScan.Barcodes.DATA[8]",
                    "Packages[2].VerifyScan.Barcodes.DATA[9]", "Packages[2].VerifyScan.Barcodes.DATA[10]", "Packages[3].VerifyScan.Barcodes.DATA[0]",
                    "Packages[3].VerifyScan.Barcodes.DATA[1]", "Packages[3].VerifyScan.Barcodes.DATA[2]", "Packages[3].VerifyScan.Barcodes.DATA[3]",
                    "Packages[3].VerifyScan.Barcodes.DATA[4]", "Packages[3].VerifyScan.Barcodes.DATA[5]", "Packages[3].VerifyScan.Barcodes.DATA[6]",
                    "Packages[3].VerifyScan.Barcodes.DATA[7]", "Packages[3].VerifyScan.Barcodes.DATA[8]", "Packages[3].VerifyScan.Barcodes.DATA[9]",
                    "Packages[3].VerifyScan.Barcodes.DATA[10]", "Packages[4].VerifyScan.Barcodes.DATA[0]", "Packages[4].VerifyScan.Barcodes.DATA[1]", "Packages[4].VerifyScan.Barcodes.DATA[2]",
                    "Packages[4].VerifyScan.Barcodes.DATA[3]", "Packages[4].VerifyScan.Barcodes.DATA[4]", "Packages[4].VerifyScan.Barcodes.DATA[5]",
                    "Packages[4].VerifyScan.Barcodes.DATA[6]", "Packages[4].VerifyScan.Barcodes.DATA[7]", "Packages[4].VerifyScan.Barcodes.DATA[8]",
                    "Packages[4].VerifyScan.Barcodes.DATA[9]", "Packages[4].VerifyScan.Barcodes.DATA[10]", "Packages[5].VerifyScan.Barcodes.DATA[0]",
                    "Packages[5].VerifyScan.Barcodes.DATA[1]", "Packages[5].VerifyScan.Barcodes.DATA[2]", "Packages[5].VerifyScan.Barcodes.DATA[3]",
                    "Packages[5].VerifyScan.Barcodes.DATA[4]", "Packages[5].VerifyScan.Barcodes.DATA[5]", "Packages[5].VerifyScan.Barcodes.DATA[6]",
                    "Packages[5].VerifyScan.Barcodes.DATA[7]", "Packages[5].VerifyScan.Barcodes.DATA[8]", "Packages[5].VerifyScan.Barcodes.DATA[9]",
                    "Packages[5].VerifyScan.Barcodes.DATA[10]", "Packages[6].VerifyScan.Barcodes.DATA[0]", "Packages[6].VerifyScan.Barcodes.DATA[1]", "Packages[6].VerifyScan.Barcodes.DATA[2]",
                    "Packages[6].VerifyScan.Barcodes.DATA[3]", "Packages[6].VerifyScan.Barcodes.DATA[4]", "Packages[6].VerifyScan.Barcodes.DATA[5]",
                    "Packages[6].VerifyScan.Barcodes.DATA[6]", "Packages[6].VerifyScan.Barcodes.DATA[7]", "Packages[6].VerifyScan.Barcodes.DATA[8]",
                    "Packages[6].VerifyScan.Barcodes.DATA[9]", "Packages[6].VerifyScan.Barcodes.DATA[10]", "Packages[7].VerifyScan.Barcodes.DATA[0]",
                    "Packages[7].VerifyScan.Barcodes.DATA[1]", "Packages[7].VerifyScan.Barcodes.DATA[2]", "Packages[7].VerifyScan.Barcodes.DATA[3]",
                    "Packages[7].VerifyScan.Barcodes.DATA[4]", "Packages[7].VerifyScan.Barcodes.DATA[5]", "Packages[7].VerifyScan.Barcodes.DATA[6]",
                    "Packages[7].VerifyScan.Barcodes.DATA[7]", "Packages[7].VerifyScan.Barcodes.DATA[8]", "Packages[7].VerifyScan.Barcodes.DATA[9]",
                    "Packages[7].VerifyScan.Barcodes.DATA[10]", "Packages[8].VerifyScan.Barcodes.DATA[0]", "Packages[8].VerifyScan.Barcodes.DATA[1]", "Packages[8].VerifyScan.Barcodes.DATA[2]",
                    "Packages[8].VerifyScan.Barcodes.DATA[3]", "Packages[8].VerifyScan.Barcodes.DATA[4]", "Packages[8].VerifyScan.Barcodes.DATA[5]",
                    "Packages[8].VerifyScan.Barcodes.DATA[6]", "Packages[8].VerifyScan.Barcodes.DATA[7]", "Packages[8].VerifyScan.Barcodes.DATA[8]",
                    "Packages[8].VerifyScan.Barcodes.DATA[9]", "Packages[8].VerifyScan.Barcodes.DATA[10]", "Packages[9].VerifyScan.Barcodes.DATA[0]",
                    "Packages[9].VerifyScan.Barcodes.DATA[1]", "Packages[9].VerifyScan.Barcodes.DATA[2]", "Packages[9].VerifyScan.Barcodes.DATA[3]",
                    "Packages[9].VerifyScan.Barcodes.DATA[4]", "Packages[9].VerifyScan.Barcodes.DATA[5]", "Packages[9].VerifyScan.Barcodes.DATA[6]",
                    "Packages[9].VerifyScan.Barcodes.DATA[7]", "Packages[9].VerifyScan.Barcodes.DATA[8]", "Packages[9].VerifyScan.Barcodes.DATA[9]",
                    "Packages[9].VerifyScan.Barcodes.DATA[10]", "Packages[10].VerifyScan.Barcodes.DATA[0]", "Packages[10].VerifyScan.Barcodes.DATA[1]", "Packages[10].VerifyScan.Barcodes.DATA[2]",
                    "Packages[10].VerifyScan.Barcodes.DATA[3]", "Packages[10].VerifyScan.Barcodes.DATA[4]", "Packages[10].VerifyScan.Barcodes.DATA[5]",
                    "Packages[10].VerifyScan.Barcodes.DATA[6]", "Packages[10].VerifyScan.Barcodes.DATA[7]", "Packages[10].VerifyScan.Barcodes.DATA[8]",
                    "Packages[10].VerifyScan.Barcodes.DATA[9]", "Packages[10].VerifyScan.Barcodes.DATA[10]", "Packages[11].VerifyScan.Barcodes.DATA[0]",
                    "Packages[11].VerifyScan.Barcodes.DATA[1]", "Packages[11].VerifyScan.Barcodes.DATA[2]", "Packages[11].VerifyScan.Barcodes.DATA[3]",
                    "Packages[11].VerifyScan.Barcodes.DATA[4]", "Packages[11].VerifyScan.Barcodes.DATA[5]", "Packages[11].VerifyScan.Barcodes.DATA[6]",
                    "Packages[11].VerifyScan.Barcodes.DATA[7]", "Packages[11].VerifyScan.Barcodes.DATA[8]", "Packages[11].VerifyScan.Barcodes.DATA[9]",
                    "Packages[11].VerifyScan.Barcodes.DATA[10]", "Packages[12].VerifyScan.Barcodes.DATA[0]", "Packages[12].VerifyScan.Barcodes.DATA[1]", "Packages[12].VerifyScan.Barcodes.DATA[2]",
                    "Packages[12].VerifyScan.Barcodes.DATA[3]", "Packages[12].VerifyScan.Barcodes.DATA[4]", "Packages[12].VerifyScan.Barcodes.DATA[5]",
                    "Packages[12].VerifyScan.Barcodes.DATA[6]", "Packages[12].VerifyScan.Barcodes.DATA[7]", "Packages[12].VerifyScan.Barcodes.DATA[8]",
                    "Packages[12].VerifyScan.Barcodes.DATA[9]", "Packages[12].VerifyScan.Barcodes.DATA[10]", "Packages[13].VerifyScan.Barcodes.DATA[0]",
                    "Packages[13].VerifyScan.Barcodes.DATA[1]", "Packages[13].VerifyScan.Barcodes.DATA[2]", "Packages[13].VerifyScan.Barcodes.DATA[3]",
                    "Packages[13].VerifyScan.Barcodes.DATA[4]", "Packages[13].VerifyScan.Barcodes.DATA[5]", "Packages[13].VerifyScan.Barcodes.DATA[6]",
                    "Packages[13].VerifyScan.Barcodes.DATA[7]", "Packages[13].VerifyScan.Barcodes.DATA[8]", "Packages[13].VerifyScan.Barcodes.DATA[9]",
                    "Packages[13].VerifyScan.Barcodes.DATA[10]", "Packages[14].VerifyScan.Barcodes.DATA[0]", "Packages[14].VerifyScan.Barcodes.DATA[1]", "Packages[14].VerifyScan.Barcodes.DATA[2]",
                    "Packages[14].VerifyScan.Barcodes.DATA[3]", "Packages[14].VerifyScan.Barcodes.DATA[4]", "Packages[14].VerifyScan.Barcodes.DATA[5]",
                    "Packages[14].VerifyScan.Barcodes.DATA[6]", "Packages[14].VerifyScan.Barcodes.DATA[7]", "Packages[14].VerifyScan.Barcodes.DATA[8]",
                    "Packages[14].VerifyScan.Barcodes.DATA[9]", "Packages[14].VerifyScan.Barcodes.DATA[10]", "Packages[15].VerifyScan.Barcodes.DATA[0]",
                    "Packages[15].VerifyScan.Barcodes.DATA[1]", "Packages[15].VerifyScan.Barcodes.DATA[2]", "Packages[15].VerifyScan.Barcodes.DATA[3]",
                    "Packages[15].VerifyScan.Barcodes.DATA[4]", "Packages[15].VerifyScan.Barcodes.DATA[5]", "Packages[15].VerifyScan.Barcodes.DATA[6]",
                    "Packages[15].VerifyScan.Barcodes.DATA[7]", "Packages[15].VerifyScan.Barcodes.DATA[8]", "Packages[15].VerifyScan.Barcodes.DATA[9]",
                    "Packages[15].VerifyScan.Barcodes.DATA[10]", "Packages[16].VerifyScan.Barcodes.DATA[0]", "Packages[16].VerifyScan.Barcodes.DATA[1]", "Packages[16].VerifyScan.Barcodes.DATA[2]",
                    "Packages[16].VerifyScan.Barcodes.DATA[3]", "Packages[16].VerifyScan.Barcodes.DATA[4]", "Packages[16].VerifyScan.Barcodes.DATA[5]",
                    "Packages[16].VerifyScan.Barcodes.DATA[6]", "Packages[16].VerifyScan.Barcodes.DATA[7]", "Packages[16].VerifyScan.Barcodes.DATA[8]",
                    "Packages[16].VerifyScan.Barcodes.DATA[9]", "Packages[16].VerifyScan.Barcodes.DATA[10]", "Packages[17].VerifyScan.Barcodes.DATA[0]",
                    "Packages[17].VerifyScan.Barcodes.DATA[1]", "Packages[17].VerifyScan.Barcodes.DATA[2]", "Packages[17].VerifyScan.Barcodes.DATA[3]",
                    "Packages[17].VerifyScan.Barcodes.DATA[4]", "Packages[17].VerifyScan.Barcodes.DATA[5]", "Packages[17].VerifyScan.Barcodes.DATA[6]",
                    "Packages[17].VerifyScan.Barcodes.DATA[7]", "Packages[17].VerifyScan.Barcodes.DATA[8]", "Packages[17].VerifyScan.Barcodes.DATA[9]",
                    "Packages[17].VerifyScan.Barcodes.DATA[10]", "Packages[18].VerifyScan.Barcodes.DATA[0]", "Packages[18].VerifyScan.Barcodes.DATA[1]", "Packages[18].VerifyScan.Barcodes.DATA[2]",
                    "Packages[18].VerifyScan.Barcodes.DATA[3]", "Packages[18].VerifyScan.Barcodes.DATA[4]", "Packages[18].VerifyScan.Barcodes.DATA[5]",
                    "Packages[18].VerifyScan.Barcodes.DATA[6]", "Packages[18].VerifyScan.Barcodes.DATA[7]", "Packages[18].VerifyScan.Barcodes.DATA[8]",
                    "Packages[18].VerifyScan.Barcodes.DATA[9]", "Packages[18].VerifyScan.Barcodes.DATA[10]", "Packages[19].VerifyScan.Barcodes.DATA[0]",
                    "Packages[19].VerifyScan.Barcodes.DATA[1]", "Packages[19].VerifyScan.Barcodes.DATA[2]", "Packages[19].VerifyScan.Barcodes.DATA[3]",
                    "Packages[19].VerifyScan.Barcodes.DATA[4]", "Packages[19].VerifyScan.Barcodes.DATA[5]", "Packages[19].VerifyScan.Barcodes.DATA[6]",
                    "Packages[19].VerifyScan.Barcodes.DATA[7]", "Packages[19].VerifyScan.Barcodes.DATA[8]", "Packages[19].VerifyScan.Barcodes.DATA[9]",
                    "Packages[19].VerifyScan.Barcodes.DATA[10]"}
                clxVal = e.PlcAddress
                cVal = cSh.Cells
                pVal = e.Values(0)
                cX = 15
                cX1 = 5
                For Each index In plcAdd
                    If clxVal = index Then
                        cVal(cX, cX1) = Chr(pVal)
                    End If
                    If cX1 = 15 Then
                        cX += 2
                        cX1 -= 10
                    Else
                        cX1 += 1
                    End If
                Next
            Catch ex As Exception
                MsgBox("Scale Scanner For Loop Full", ex.Message)
            End Try
        End If
    End Sub

    '//Subs for Alarm Indicators

    Private Sub BasicIndicator65_Click(sender As Object, e As EventArgs) Handles BasicIndicator65.Click

    End Sub

    Private Sub BasicIndicator69_Click(sender As Object, e As EventArgs) Handles BasicIndicator69.Click

    End Sub

    Private Sub BasicIndicator73_Click(sender As Object, e As EventArgs) Handles BasicIndicator73.Click

    End Sub

    Private Sub BasicIndicator75_Click(sender As Object, e As EventArgs) Handles BasicIndicator75.Click

    End Sub

    Private Sub BasicIndicator81_Click(sender As Object, e As EventArgs) Handles BasicIndicator81.Click

    End Sub

    Private Sub BasicIndicator87_Click(sender As Object, e As EventArgs) Handles BasicIndicator87.Click

    End Sub

    Private Sub BasicIndicator89_Click(sender As Object, e As EventArgs) Handles BasicIndicator89.Click

    End Sub

    Private Sub BasicIndicator93_Click(sender As Object, e As EventArgs) Handles BasicIndicator93.Click

    End Sub

    Private Sub BasicIndicator97_Click(sender As Object, e As EventArgs) Handles BasicIndicator97.Click

    End Sub

    Private Sub BasicIndicator99_Click(sender As Object, e As EventArgs) Handles BasicIndicator99.Click

    End Sub

    Private Sub BasicIndicator67_Click(sender As Object, e As EventArgs) Handles BasicIndicator67.Click

    End Sub

    Private Sub BasicIndicator71_Click(sender As Object, e As EventArgs) Handles BasicIndicator71.Click

    End Sub

    Private Sub BasicIndicator77_Click(sender As Object, e As EventArgs) Handles BasicIndicator77.Click

    End Sub

    Private Sub plStop_Click(sender As Object, e As EventArgs) Handles plStop.Click

    End Sub

    '//Subs For My Option Buttons
    Private Sub bOpenBCR_Click(sender As Object, e As EventArgs) Handles bOpenBCR.Click
        BaCoRdr1.Show()
    End Sub

    Private Sub openBeltSpeeds_Click(sender As Object, e As EventArgs) Handles openBeltSpeeds.Click
        BeltSpeeds.Show()
    End Sub

    Private Sub bOpenPro_Click(sender As Object, e As EventArgs) Handles bOpenPro.Click
        Profiler.Show()
    End Sub

    Private Sub openTampCon_Click(sender As Object, e As EventArgs) Handles openTampCon.Click
        TampConfig.Show()
    End Sub

    Private Sub openTraining_Click(sender As Object, e As EventArgs) Handles openTraining.Click
        Training.Show()
    End Sub

    Private Sub openSortOvRide_Click(sender As Object, e As EventArgs) Handles openSortOvRide.Click
        SorterOvRide.Show()
    End Sub

    Private Sub openComms_Click(sender As Object, e As EventArgs) Handles openComms.Click
        Communications.Show()
    End Sub

    Private Sub openPtrCMD_Click(sender As Object, e As EventArgs) Handles openPtrCMD.Click
        PrinterCMD.Show()
    End Sub

    Private Sub btnSlamOps_Click(sender As Object, e As EventArgs) Handles btnSlamOps.Click
        Try
            input = InputBox("Please Provide Password", "Password", "Enter Password", MessageBoxButtons.OKCancel)
            If input = My.Settings.Password Then
                bOpenBCR.Visible = True
                openBeltSpeeds.Visible = True
                bOpenPro.Visible = True
                openTampCon.Visible = True
                openTraining.Visible = True
                openSortOvRide.Visible = True
                openComms.Visible = True
                openPtrCMD.Visible = True
                opsExit.Visible = True
                rstCount.Visible = True
                openMacDis1.Visible = True
                btnSlamOps.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)
        End Try

    End Sub

    Private Sub opsExit_Click_1(sender As Object, e As EventArgs) Handles opsExit.Click
        Try
            btnSlamOps.Visible = True
            bOpenBCR.Visible = False
            openBeltSpeeds.Visible = False
            bOpenPro.Visible = False
            openTampCon.Visible = False
            openTraining.Visible = False
            openSortOvRide.Visible = False
            openComms.Visible = False
            openPtrCMD.Visible = False
            opsExit.Visible = False
            rstCount.Visible = False
            openMacDis1.Visible = False
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message)
        End Try

    End Sub

    Private Sub plStart_Click(sender As Object, e As EventArgs) Handles plStart.Click

    End Sub

    Private Sub plReset_Click(sender As Object, e As EventArgs) Handles plReset.Click

    End Sub

    Private Sub plFault_Click(sender As Object, e As EventArgs) Handles plFault.Click

    End Sub

    Private Sub plAbort_Click(sender As Object, e As EventArgs) Handles plAbort.Click

    End Sub

    Private Sub DigitalPanelMeter50_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter50.Click

    End Sub

    Private Sub DigitalPanelMeter56_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter56.Click

    End Sub

    Private Sub DigitalPanelMeter55_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter55.Click

    End Sub

    Private Sub DigitalPanelMeter53_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter53.Click

    End Sub

    Private Sub DigitalPanelMeter52_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter52.Click

    End Sub

    Private Sub DigitalPanelMeter49_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter49.Click

    End Sub

    Private Sub DigitalPanelMeter47_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter47.Click

    End Sub

    Private Sub DigitalPanelMeter54_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter54.Click

    End Sub

    Private Sub DigitalPanelMeter51_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter51.Click

    End Sub

    Private Sub DigitalPanelMeter46_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter46.Click

    End Sub

    Private Sub DigitalPanelMeter43_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter43.Click

    End Sub

    Private Sub DigitalPanelMeter45_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter45.Click

    End Sub

    Private Sub DigitalPanelMeter44_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter44.Click

    End Sub

    Private Sub openDSM5_Click(sender As Object, e As EventArgs) Handles openDSM5.Click
        DSM5_Controls.Show()
        Me.Hide()
    End Sub

    Private Sub LbDate_Click(sender As Object, e As EventArgs) 

    End Sub

    '//Handles Counter Enabler
    Private Sub biKO_Click(sender As Object, e As EventArgs) Handles biKO.Click
        If Me.biKO.SelectColor2 = True Then
            btnBool1 = True
        Else
            btnBool1 = False
        End If
    End Sub

    '//Handles Counter
    Private Sub DataSubscriber25_DataChanged(sender As Object, e As PlcComEventArgs)
        If btnBool = True Then
            Try
                clxVal = e.PlcAddress
                plcAdd = {"HMI_Last10KO[0]"}
                cVal = cSh.Cells
                pVal = e.Values(0)
                Dim eVal As String
                Dim currTime As String
                currTime = Now.Hour & ":" & Now.Minute & ":" & Now.Second
                For Each index In plcAdd
                    If clxVal = index Then
                        eVal = pVal
                        Select Case eVal
                            Case "901"
                                errCode(0) += 1
                            Case "902"
                                errCode(1) += 1
                            Case "903"
                                errCode(2) += 1
                            Case "904"
                                errCode(3) += 1
                            Case "905"
                                errCode(4) += 1
                            Case "906"
                                errCode(5) += 1
                            Case "907"
                                errCode(6) += 1
                            Case "908"
                                errCode(7) += 1
                            Case "909"
                                errCode(8) += 1
                            Case "910"
                                errCode(9) += 1
                            Case "911"
                                errCode(10) += 1
                        End Select
                    End If
                Next
                cVal(3, 8) = errCode(0)
                cVal(4, 8) = errCode(1)
                cVal(5, 8) = errCode(2)
                cVal(6, 8) = errCode(3)
                cVal(7, 8) = errCode(4)
                cVal(8, 8) = errCode(5)
                cVal(9, 8) = errCode(6)
                cVal(10, 8) = errCode(7)
                cVal(11, 8) = errCode(8)
                cVal(12, 8) = errCode(9)
                cVal(13, 8) = errCode(10)
                For Each cX In errCode
                    If cX = 10000 Then
                        cX = 0
                    End If
                Next
            Catch ex As Exception
                MsgBox("Error Counter", ex.Message)
            End Try
        End If
    End Sub

    Private Sub openMacDis1_Click(sender As Object, e As EventArgs) Handles openMacDis1.Click
        MachineDisplay.Show()
    End Sub

    Private Sub BasicIndicator79_Click(sender As Object, e As EventArgs) Handles BasicIndicator79.Click

    End Sub

    Private Sub BasicIndicator85_Click(sender As Object, e As EventArgs) Handles BasicIndicator85.Click

    End Sub

    Private Sub BasicIndicator83_Click(sender As Object, e As EventArgs) Handles BasicIndicator83.Click

    End Sub

    Private Sub BasicIndicator91_Click(sender As Object, e As EventArgs) Handles BasicIndicator91.Click

    End Sub

    Private Sub BasicIndicator95_Click(sender As Object, e As EventArgs) Handles BasicIndicator95.Click

    End Sub

    Private Sub DigitalPanelMeter48_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter48.Click

    End Sub

End Class