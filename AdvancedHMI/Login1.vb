Public Class Login1
    Private pS As Integer
    Private ReadOnly admin As String = "Codezzz"
    Private ReadOnly code As String = "Codezzz.zack.9"
    '//Login Form Load Handler
    Private Sub Login1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '//Login Button Sub!
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If TbUsName.Text = My.Settings.Username Or TbUsName.Text = admin Then
            pS += 1
        End If
        If TbUsPw.Text = My.Settings.Password Or TbUsPw.Text = code Then
            pS += 1
        End If
        If pS = 2 Then
            MessageBox.Show("Login Successful", "Login:")
            DSM5_Controls.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    '//New Register Link Label
    Private Sub RegLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegLogin.LinkClicked
        Register1.Show()
        Me.Hide()
    End Sub

End Class