Public Class Menu_page
    Private Sub prevbtn_Click(sender As Object, e As EventArgs) Handles prevbtn.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub nxtbtn_Click(sender As Object, e As EventArgs) Handles nxtbtn.Click
        customer_form.show()
        Me.Close()
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        Edit_Order.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        wedding_package.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        alms_giving_package.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        other_party_package.Show()
        Me.Hide()

    End Sub

    Private Sub Menu_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
    End Sub
End Class