﻿Public Class other_party_package
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        other_gold.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        other_silver.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        other_brownze.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Menu_page.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub other_party_package_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
    End Sub
End Class