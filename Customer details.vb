Imports System.Data.SqlClient

Public Class Customer_details
    Dim cn As SqlConnection = New SqlConnection("Data Source=DESKTOP-KL2AN2B\MSSQLSERVER01;Initial Catalog=Customer_DB;Integrated Security=True")
    Dim com As SqlCommand
    Dim n As Integer
    Dim dt As New DataTable()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
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

    Private Sub Customer_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-KL2AN2B\MSSQLSERVER01;Initial Catalog=Customer_DB;Integrated Security=True"

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        updateTable()
        Me.MdiParent = Mainpage
    End Sub

    Public Sub updateTable()
        com = cn.CreateCommand()
        com.CommandType = CommandType.Text
        com.CommandText = "select* from Cus1"
        com.ExecuteNonQuery()
        Dim da As New SqlDataAdapter(com)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub firstbtn_Click(sender As Object, e As EventArgs) Handles firstbtn.Click
        n = 0
        With dt.Rows(n)
            TextBox1.Text = .Item("Name")
            TextBox2.Text = .Item("Address")
            TextBox3.Text = .Item("PhoneNumber")
            TextBox4.Text = .Item("Email")
            TextBox5.Text = .Item("MenuId")
        End With
    End Sub

    Private Sub lastbtn_Click(sender As Object, e As EventArgs) Handles lastbtn.Click
        n = dt.Rows.Count - 1
        With dt.Rows(n)
            TextBox1.Text = .Item("Name")
            TextBox2.Text = .Item("Address")
            TextBox3.Text = .Item("PhoneNumber")
            TextBox4.Text = .Item("Email")
            TextBox5.Text = .Item("MenuId")
        End With
    End Sub

    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        If Not n = dt.Rows.Count - 1 Then
            n = n + 1
            With dt.Rows(n)
                TextBox1.Text = .Item("Name")
                TextBox2.Text = .Item("Address")
                TextBox3.Text = .Item("PhoneNumber")
                TextBox4.Text = .Item("Email")
                TextBox5.Text = .Item("MenuId")
            End With
        End If
    End Sub

    Private Sub prevbtn_Click(sender As Object, e As EventArgs) Handles prevbtn.Click
        If n > 0 Then
            n = n - 1
            With dt.Rows(n)
                TextBox1.Text = .Item("Name")
                TextBox2.Text = .Item("Address")
                TextBox3.Text = .Item("PhoneNumber")
                TextBox4.Text = .Item("Email")
                TextBox5.Text = .Item("MenuId")
            End With
        End If
    End Sub
End Class