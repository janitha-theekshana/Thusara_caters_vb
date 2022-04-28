Public Class other_brownze
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        other_party_package.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub other_brownze_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
    End Sub
End Class