Public Class Register
    Private pS As Integer

    '// Register Form Load Handler!
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '//Register Save Button Handler!
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If Not TbUsName1.Text = "" Then
            pS += 1
        End If
        If Not TbUsPw1.Text = "" Then
            pS += 1
        End If
        If TbUsRe.Text = TbUsPw1.Text Then
            pS += 1
        End If
        If pS = 3 Then
            My.Settings.Username = TbUsName1.Text
            My.Settings.Password = TbUsPw1.Text
            My.Settings.Save()
            MessageBox.Show("Register was Successful", "Register")
            Login.Show()
            Me.Hide()
        Else
            MessageBox.Show("Must Complete both Fields", "Register")
        End If
    End Sub

End Class