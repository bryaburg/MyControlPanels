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
            myInput = InputBox("Please Enter Desired Control Panel", "PANEL CONTENTS", "Enter CP#", vbOKCancel)
            Select Case myInput
                Case "01"
                    CP01.Show()
            End Select
        Catch ex As Exception
            MsgBox("Error", ex.Message)
        End Try
    End Sub
End Class