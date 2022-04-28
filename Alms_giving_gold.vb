Public Class Alms_giving_gold
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        alms_giving_package.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub Alms_giving_gold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
    End Sub
End Class