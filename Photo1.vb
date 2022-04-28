Public Class Photo1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Photos.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Photo2.Show()
        Me.Hide()

    End Sub

    Private Sub Photo1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
    End Sub
End Class