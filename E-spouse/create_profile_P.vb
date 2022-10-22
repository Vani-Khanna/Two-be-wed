Imports System.Data.OleDb

Public Class create_profile_P
    Dim conn As New OleDbConnection
    Dim comm As New OleDbCommand()
    Dim sqlstr As String


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label8.Text = "Specify country :"
        Else
            Label8.Text = "Living in city  :"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vani khanna\source\repos\E-spouse\Two be Wed.accdb"
        Try

            comm.Connection = conn
            sqlstr = "insert into create_profile_P values('" & txt_fname.Text & "','" & txt_lname.Text & "','" & txt_mobno.Text & "','" & txt_height.Text & "','" & ComboBox1.SelectedItem.ToString & "','" & txt_mt.Text & "','" & txt_email.Text & "','" & txt_city.Text & "','" & txt_sign.Text & "')"
            comm.CommandText = sqlstr

            conn.Open()
            comm.ExecuteNonQuery()
            'MessageBox.Show(sqlstr)
            MessageBox.Show("Customer added to the database")
            conn.Close()



        Catch ex As Exception
            MessageBox.Show("Error! Customer could not be added to Database")
        End Try

    End Sub

    Private Sub create_profile_P_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(50, 150, 150, 150)


        Label2.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label8.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label10.BackColor = Color.Transparent
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class