Imports System.Data.OleDb
Public Class set_user__pass_Window

    Private Sub btConfirm_Click(sender As Object, e As EventArgs) Handles btConfirm.Click

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vani khanna\source\repos\E-spouse\Two be Wed.accdb")
        Dim comm As New OleDbCommand()
        Dim sqlstr As String

        comm.Connection = conn
        sqlstr = "insert into create_u_pass values('" & Txt_username.Text & "','" & Txt_password.Text & "')"
        comm.CommandText = sqlstr

        conn.Open()
        comm.ExecuteNonQuery()
        'MessageBox.Show(sqlstr)
        MessageBox.Show("Welcome to Two be wed! You are now a user. ")
        conn.Close()


        Me.Hide()
    End Sub

    Private Sub set_user__pass_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class