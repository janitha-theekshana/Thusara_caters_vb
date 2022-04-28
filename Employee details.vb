Imports System.Data.SqlClient
Public Class Employee_details

    Dim cn As SqlConnection = New SqlConnection("Data Source=DESKTOP-KL2AN2B\MSSQLSERVER01;Initial Catalog=Employee_DB;Integrated Security=True")
    Dim i As Integer
    Dim com As New SqlCommand


    Private Sub updateTable()
        com = cn.CreateCommand()
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT* from Emp_DB1"
        com.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(com)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Resetformcontrols()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
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

    Private Sub Employee_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridObj()

        Me.MdiParent = Mainpage
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cn.Open()
        Dim com As SqlCommand = New SqlCommand("INSERT INTO Emp_DB1 VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", cn)
        com.ExecuteNonQuery()
        MsgBox("New Employe Added Successfully")
        cn.Close()
        GridObj()
        Resetformcontrols()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        cn.Open()
        com = New SqlCommand("UPDATE Emp_DB1 SET EmpNo ='" & TextBox1.Text & "',EmpName = '" & TextBox2.Text & "',Address = '" & TextBox3.Text & "',TelNumber = '" & TextBox4.Text & "',IdNumber =' " & TextBox5.Text & "' WHERE EmpNo='" & TextBox1.Text & "'", cn)
        com.ExecuteNonQuery()
        MsgBox("Successfully Updated")
        cn.Close()
        GridObj()
        Resetformcontrols()
        cn.Close()


    End Sub

    Public Sub GridObj()
        cn.Open()
        Dim mysql = "select * from Emp_DB1"
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cn.Open()
        Dim com As SqlCommand = New SqlCommand("DELETE FROM Emp_DB1 WHERE EmpNo = '" & TextBox1.Text & "'", cn)
        com.ExecuteNonQuery()
        MsgBox("Successfully Deleted")
        cn.Close()
        GridObj()
        Resetformcontrols()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
            com = cn.CreateCommand()
            com.CommandType = CommandType.Text
            com.CommandText = "select* from Emp_DB1 where id=" & i & ""
            com.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(com)
            da.Fill(dt)
            Dim dr As SqlDataReader
            dr = com.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                TextBox1.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
                TextBox2.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
                TextBox3.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
                TextBox4.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
                TextBox5.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Are you sure you want to quit", MsgBoxStyle.YesNoCancel)
        Me.Close()
    End Sub
End Class