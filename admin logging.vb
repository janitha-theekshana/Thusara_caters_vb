Public Class admin_logging
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "janitha" And TextBox2.Text = "1234" Then
            MsgBox("Log in sucessfully ")
            Form2.show()
            Me.Hide()
        Else
            MsgBox("Sorry Incorrect Username or Password", MsgBoxStyle.OkOnly, "Invalid")
        End If

        Resetformcontrols()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub admin_logging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
    End Sub

    Private Sub Resetformcontrols()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class