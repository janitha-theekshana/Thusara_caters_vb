Public Class Mainpage
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Photos.Show()

    End Sub

    Private Sub OrderFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderFormToolStripMenuItem.Click
        customer_form.Show()
    End Sub

    Private Sub EditOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditOrderToolStripMenuItem.Click
        Edit_Order.Show()
    End Sub

    Private Sub GoldPackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoldPackageToolStripMenuItem.Click
        Wedding_gold.Show()
    End Sub

    Private Sub SilverPackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilverPackageToolStripMenuItem.Click
        wedding_silver.Show()
    End Sub

    Private Sub BrownzePackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrownzePackageToolStripMenuItem.Click
        wedding_brownze.Show()
    End Sub

    Private Sub GoldPackageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GoldPackageToolStripMenuItem1.Click
        Alms_giving_gold.Show()
    End Sub

    Private Sub SilverPackageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SilverPackageToolStripMenuItem1.Click
        Alms_giving_silver.Show()
    End Sub

    Private Sub BrownzePackageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BrownzePackageToolStripMenuItem1.Click
        Alms_giving_brownze.Show()
    End Sub

    Private Sub GoldPackageToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GoldPackageToolStripMenuItem2.Click
        other_gold.Show()
    End Sub

    Private Sub SilverPackageToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SilverPackageToolStripMenuItem2.Click
        other_silver.Show()
    End Sub

    Private Sub BrownzePackageToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BrownzePackageToolStripMenuItem2.Click
        other_brownze.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub HomeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        MessageBox.Show("Name : H.P.G.Janitha Theekshana ,GAL/IT/2019/F/0020", "My Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class