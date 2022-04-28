Public Class frmloading
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False
            Mainpage.Show()
            Me.Hide()


        End If

    End Sub

    Private Sub frmloading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        ProgressBar1.Visible = True

    End Sub
End Class