Imports System.Data.OleDb
Public Class Select_package

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vani khanna\source\repos\E-spouse\Two be Wed.accdb")
    Dim comm As New OleDbCommand()
    Dim sqlstr As String


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        anima1.HideSync(P2)
        anima1.ShowSync(P4)
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        anima1.HideSync(P4)
        anima1.ShowSync(P2)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        anima1.HideSync(P2)
        anima1.ShowSync(P6)
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        anima1.HideSync(P6)
        anima1.ShowSync(P2)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_doneG.Click

        ' conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vani khanna\source\repos\E-spouse\Two be Wed.accdb"
        Try

            comm.Connection = conn
            sqlstr = "insert into customerID_gold values('" & txt_customerID_G.Text & "')"
            comm.CommandText = sqlstr

            conn.Open()
            comm.ExecuteNonQuery()
            'MessageBox.Show(sqlstr)
            MessageBox.Show("Customer added to the database")
            conn.Close()
            create_profile.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error! Customer could not be added to Database")
        End Try




    End Sub

    Private Sub bt_doneP_Click(sender As Object, e As EventArgs) Handles bt_doneP.Click

        'conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vani khanna\source\repos\E-spouse\Two be Wed.accdb"
        Try

            comm.Connection = conn
            sqlstr = "insert into customerID_premium values('" & txt_customerID_P.Text & "')"
            comm.CommandText = sqlstr

            conn.Open()
            comm.ExecuteNonQuery()
            ' MessageBox.Show(sqlstr)
            MessageBox.Show("Customer added to the database")
            conn.Close()
            create_profile_P.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error! Customer could not be added to Database")
        End Try





    End Sub

    Private Sub Select_package_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class