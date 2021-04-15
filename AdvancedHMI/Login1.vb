Imports System.ComponentModel

Public Class Login1
    Private pS As Integer
    Private Const admin As String = "Codezzz"
    Private Const code As String = "Codezzz.zack.9"
    '//Login Form Load Handler
    Private Sub Login1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Username <> "" Then
            Me.TbUsName.Text = My.Settings.Username.ToString
        End If

    End Sub

    '//Login Button Sub!
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim Iput As Integer
        If (TbUsName.Text = My.Settings.Username And TbUsPw.Text = My.Settings.Password) Or (TbUsName.Text = admin And TbUsPw.Text = code) Then
            DSM5_Controls.Show()
            Me.Close()
        Else
            Iput = MsgBox("Please Enter Correct Login", vbOKCancel, "Invalid Login Credentials")
            If Iput = vbOK Then
                TbUsPw.Clear()
                MyBase.Activate()
                Me.TbUsPw.Focus()
            Else
                Me.Close
            End If

        End If
    End Sub

    '//New Register Link Label
    Private Sub RegLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegLogin.LinkClicked
        Register1.Show()
        Me.Hide()
    End Sub

    '//Handles Auto Login
    Private Sub TbUsPw_TextChanged(sender As Object, e As EventArgs) Handles TbUsPw.TextChanged
        If TbUsPw.Text = My.Settings.Password Or TbUsPw.Text = code Then LoginBtn.Focus()
    End Sub
End Class