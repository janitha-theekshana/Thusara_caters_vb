Imports System.Data.SqlClient
Public Class Edit_Order
    Dim cn As SqlConnection = New SqlConnection("Data Source=DESKTOP-KL2AN2B\MSSQLSERVER01;Initial Catalog=Customer_DB;Integrated Security=True")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Open()
        Dim mysql = "select * from Cus1 WHERE Name= '" & TextBox1.Text & "'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(mysql, cn)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim DataSet As DataSet
        DataSet = New DataSet
        adapter.Fill(DataSet)
        DataGridView1.DataSource = DataSet.Tables(0)
        cn.Close()

    End Sub

    Private Sub Edit_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Mainpage
        GridObj()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Menu_page.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNoCancel)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cn.Open()
        Dim com As SqlCommand = New SqlCommand("UPDATE Cus1 SET Name = '" & TextBox3.Text & "',Address= '" & TextBox4.Text & "',PhoneNumber= '" & TextBox5.Text & "',Email= '" & TextBox6.Text & "' ,MenuId= '" & TextBox7.Text & "' where Name= '" & TextBox1.Text & "'", cn)
        com.ExecuteNonQuery()
        MsgBox("Successfully Updated")
        cn.Close()
        GridObj()
        Resetformcontrols()

    End Sub

    Public Sub GridObj()
        cn.Open()
        Dim mysql = "select * from Cus1"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(mysql, cn)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim DataSet As DataSet
        DataSet = New DataSet
        adapter.Fill(DataSet)
        DataGridView1.DataSource = DataSet.Tables(0)
        cn.Close()
    End Sub

    Private Sub Resetformcontrols()
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

End Class