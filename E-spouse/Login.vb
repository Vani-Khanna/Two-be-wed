Imports System.Data.OleDb
Public Class Login
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vani khanna\source\repos\E-spouse\Two be Wed.accdb ")
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim mysql As String


    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click
        Dim found As Boolean
        found = False
        For i = 0 To ds.Tables("create_u_pass").Rows.Count - 1
            If ds.Tables("create_u_pass").Rows(i).Item("u_name") = txt_uname.Text And ds.Tables("create_u_pass").Rows(i).Item("u_pass") = txt_upass.Text Then
                MessageBox.Show("You have successfully logged in!")
                dashboard.Show()
                Me.Hide()
                found = True
                Exit For
            End If

        Next

        If found = False Then

            MessageBox.Show("Either username or Password enetered is incorrect. Try again")

        End If

    End Sub

    Private Sub Button_login_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_login.KeyDown

        If e.KeyCode = Keys.Enter Then
            dashboard.Show()
        End If

    End Sub

    Private Sub TextBox_pass_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IconButton1.BackColor = Color.FromArgb(50, 150, 150, 150)
        IconButton3.BackColor = Color.FromArgb(50, 150, 150, 150)

        mysql = "select * from create_u_pass "
        da = New OleDbDataAdapter(mysql, conn)
        ds = New DataSet()
        da.Fill(ds, "create_u_pass")




    End Sub

End Class