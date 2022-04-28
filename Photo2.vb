Public Class Photo2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Photo1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Photos3.Show()
        Me.Hide()

    End Sub

    Private Sub Photo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
    End Sub
End Class