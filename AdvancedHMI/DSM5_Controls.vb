Imports System.ComponentModel

Public Class DSM5_Controls
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean
    Private input As String
    Private pWord As String

    '//Sub to Load the MainForm
    Private Sub DSM5_Controls_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DSM5_Controls_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub DSM5_Controls_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Private Sub BasicButton1_Click(sender As Object, e As EventArgs) Handles BasicButton1.Click
        SlamControls.Close()
        Register1.Close()
        Login1.Close()
        Me.Close()
    End Sub

    Private Sub openSlamCon_Click(sender As Object, e As EventArgs) Handles openSlamCon.Click
        SlamControls.Show()
        Me.Hide()
    End Sub

    '//Handles Time
    Private Sub TiClk_Tick(sender As Object, e As EventArgs) Handles TiClk.Tick
        Dim cuDate As Date = Date.Now
        Dim sDate As String = cuDate.ToString("MMM-dd-yyyy")
        LbDate.Text = sDate
        LbClk.Text = TimeOfDay
    End Sub

    '//Handles Forms Closing
    Private Sub DSM5_Controls_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Private Sub LbDate_Click(sender As Object, e As EventArgs) Handles LbDate.Click

    End Sub

    Private Sub PilotLight243_Click(sender As Object, e As EventArgs) Handles PilotLight243.Click

    End Sub

    Private Sub PanelContent_Click(sender As Object, e As EventArgs) Handles PanelContent.Click
        Dim myInput As String
        Try
            myInput = InputBox("Please Enter Desired Control Panel", "PANEL CONTENTS", "Enter CP#", 780, 500)
            Select Case myInput
                Case "01"
                    CP01.Show()
                Case "02"
                    CP02.Show()
                Case "11"
                    CP11.Show()
                Case "12"
                    CP12.Show()
                Case "13"
                    CP13.Show()
                Case "14"
                    CP14.Show()
                Case "15"
                    CP15.Show()
                Case "16"
                    CP16.Show()
                Case "31"
                    CP31.Show()
                Case "32"
                    CP32.Show()
                Case "41"
                    CP41.Show()
                Case "42"
                    CP42.Show()
                Case "43"
                    CP43.Show()
                Case "44"
                    CP44.Show()
                Case "45"
                    CP45.Show()
                Case "46"
                    CP46.Show()
                Case "47"
                    CP47.Show()
                Case "48"
                    CP48.Show()
                Case "49"
                    CP49.Show()
                Case "51"
                    CP51.Show()
                Case "52"
                    CP52.Show()
                Case "53"
                    CP53.Show()
                Case "54"
                    CP54.Show()
                Case "55"
                    CP55.Show()
                Case "56"
                    CP56.Show()
                Case "57"
                    CP57.Show()
                Case "58"
                    CP58.Show()
                Case "59"
                    CP59.Show()
                Case "61"
                    CP61.Show()
                Case "62"
                    CP62.Show()
                Case "63"
                    CP63.Show()
                Case "64"
                    CP64.Show()
                Case "72"
                    CP72.Show()
                Case "80"
                    CP80.Show()
                Case "81"
                    CP81.Show()
                Case "88"
                    CP88.Show()
                Case "89"
                    CP89.Show()
                Case "90"
                    CP90.Show()
                Case "91"
                    CP91.Show()
                Case "92"
                    CP92.Show()
                Case "93"
                    CP93.Show()
                Case "94"
                    CP94.Show()
                Case Else
                    MessageBox.Show("Please Enter Just the Control Panel Number!!!", "Invalid Format!!")
            End Select
        Catch ex As Exception
            MsgBox("Error", ex.Message)
        End Try
    End Sub
End Class