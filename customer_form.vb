Imports System.Data.SqlClient
Public Class customer_form

    Dim cn As SqlConnection = New SqlConnection("Data Source=DESKTOP-KL2AN2B\MSSQLSERVER01;Initial Catalog=Customer_DB;Integrated Security=True")
    Dim i As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu_page.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cn.Open()
        Dim com As SqlCommand
        com = New SqlCommand("INSERT INTO Cus1 VALUES('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "')", cn)
        com.ExecuteNonQuery()
        MsgBox("New Order Added Successfully ")
        cn.Close()
        Resetformcontrols()


    End Sub

    Private Sub customer_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
    End Sub

    Private Sub Resetformcontrols()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
    End Sub

End Class