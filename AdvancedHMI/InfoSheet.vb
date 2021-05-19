Public Class InfoSheet

    'Handles Loading My Form Events!
    Private Sub InfoSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CP01.VB01305.CheckState = CheckState.Checked Then vb01305.Visible = True
        If CP01.VB01405.CheckState = CheckState.Checked Then vb01405.Visible = True
        If CP01.VB01505.CheckState = CheckState.Checked Then vb01505.Visible = True

    End Sub

    'Handles Closing Form and Unchecking Boxes!
    Private Sub InfoClose_Click(sender As Object, e As EventArgs) Handles InfoClose.Click

        CP01.VB01305.CheckState = CheckState.Unchecked
        CP01.VB01405.CheckState = CheckState.Unchecked
        CP01.VB01505.CheckState = CheckState.Unchecked
        Me.Close()

    End Sub


End Class