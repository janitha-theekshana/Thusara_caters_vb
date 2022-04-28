Public Class Photos3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Photo2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Photo4.Show()
        Me.Hide()

    End Sub

    Private Sub Photos3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
    End Sub
End Class