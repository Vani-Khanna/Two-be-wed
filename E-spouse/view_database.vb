Imports System.Data.OleDb
Public Class view_database
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vani khanna\source\repos\E-spouse\Two be Wed.accdb ")
    Dim comm As New OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Dim mysql As String
    Dim mysql1 As String
    Dim mysql2 As String
    Dim mysql3 As String
    Dim mysql4 As String
    Dim mysql5 As String
    Dim mysql6 As String
    Dim mysql7 As String
    Dim mysql8 As String
    Dim mysql9 As String
    Dim mysql10 As String
    Dim mysql11 As String

    Private Sub view_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        mysql8 = "select * from create_profile_G"
        da = New OleDbDataAdapter(mysql8, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_G")
        DGV3.DataSource = ds.Tables("create_profile_G")

        mysql9 = "select * from create_profile_P"
        da = New OleDbDataAdapter(mysql9, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_P")
        DGV4.DataSource = ds.Tables("create_profile_P")

        conn.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        mysql1 = "select * from create_profile_G where city = '" & txt_vcity.Text & " ' "
        da = New OleDbDataAdapter(mysql1, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_G")
        DGV1.DataSource = ds.Tables("create_profile_G")
        conn.Close()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        mysql2 = "select * from create_profile_G where gender = '" & txt_vgender.Text & " ' "
        da = New OleDbDataAdapter(mysql2, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_G")
        DGV1.DataSource = ds.Tables("create_profile_G")
        conn.Close()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        mysql3 = "select * from create_profile_P"
        da = New OleDbDataAdapter(mysql3, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_P")
        DGV2.DataSource = ds.Tables("create_profile_P")
        conn.Close()
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        mysql4 = "select * from create_profile_P where city = '" & TextBox1.Text & " ' "
        da = New OleDbDataAdapter(mysql4, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_P")
        DGV2.DataSource = ds.Tables("create_profile_P")
        conn.Close()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton6_Click_1(sender As Object, e As EventArgs) Handles IconButton6.Click
        mysql5 = "select * from create_profile_P where gender = '" & TextBox2.Text & " ' "
        da = New OleDbDataAdapter(mysql5, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_P")
        DGV2.DataSource = ds.Tables("create_profile_P")
        conn.Close()
    End Sub


    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        conn.Open()
        mysql6 = "update create_profile_G set first_name = '" & txt_fname.Text & "' , last_name = '" & txt_lname.Text & "' ,  mobile_no = '" & txt_mobno.Text & "' , height = '" & txt_height.Text & "' ,  gender = '" & ComboBox1.Text & "' ,  mother_tongue = '" & txt_mt.Text & "' ,  email = '" & txt_email.Text & "' , city = '" & txt_city.Text & "' where mobile_no = '" & txt_mobno.Text & "' "

        'MessageBox.Show(mysql6)
        comm.CommandText = mysql6
        comm.Connection = conn
        comm.ExecuteNonQuery()
        MessageBox.Show("Record saved to database")
        conn.Close()

        MessageBox.Show(" number added is wrong ")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            mysql6 = "select * from create_profile_G where mobile_no = '" & txt_mobno.Text & " '  "
            da = New OleDbDataAdapter(mysql6, conn)
            ds = New DataSet()
            da.Fill(ds, "create_profile_G")
            txt_fname.Text = ds.Tables("create_profile_G").Rows(0).Item("first_name").ToString
            txt_lname.Text = ds.Tables("create_profile_G").Rows(0).Item("last_name").ToString
            txt_mobno.Text = ds.Tables("create_profile_G").Rows(0).Item("mobile_no").ToString
            txt_height.Text = ds.Tables("create_profile_G").Rows(0).Item("height").ToString
            ComboBox1.Text = ds.Tables("create_profile_G").Rows(0).Item("gender").ToString
            txt_mt.Text = ds.Tables("create_profile_G").Rows(0).Item("mother_tongue").ToString
            txt_email.Text = ds.Tables("create_profile_G").Rows(0).Item("email").ToString
            txt_city.Text = ds.Tables("create_profile_G").Rows(0).Item("city").ToString
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(" number added is wrong ")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            mysql7 = "select * from create_profile_P where mobile_no = '" & txt_pmobno.Text & " '  "
            da = New OleDbDataAdapter(mysql7, conn)
            ds = New DataSet()
            da.Fill(ds, "create_profile_P")
            txt_fpname.Text = ds.Tables("create_profile_P").Rows(0).Item("first_name").ToString
            txt_lpname.Text = ds.Tables("create_profile_P").Rows(0).Item("last_name").ToString
            txt_pmobno.Text = ds.Tables("create_profile_P").Rows(0).Item("mobile_no").ToString
            txt_pheight.Text = ds.Tables("create_profile_P").Rows(0).Item("height").ToString
            ComboBox2.Text = ds.Tables("create_profile_P").Rows(0).Item("gender").ToString
            txt_pmt.Text = ds.Tables("create_profile_P").Rows(0).Item("mother_tongue").ToString
            txt_pemail.Text = ds.Tables("create_profile_P").Rows(0).Item("email").ToString
            txt_pcity.Text = ds.Tables("create_profile_P").Rows(0).Item("city").ToString
            txt_psign.Text = ds.Tables("create_profile_P").Rows(0).Item("astrology_sign").ToString
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(" number added is wrong ")
        End Try
    End Sub


    Private Sub IconButton5_Click_1(sender As Object, e As EventArgs) Handles IconButton5.Click
        conn.Open()
        mysql7 = "update create_profile_P set first_name = '" & txt_fpname.Text & "' , last_name = '" & txt_lpname.Text & "' ,  mobile_no = '" & txt_pmobno.Text & "' , height = '" & txt_pheight.Text & "' ,  gender = '" & ComboBox2.Text & "' ,  mother_tongue = '" & txt_pmt.Text & "' ,  email = '" & txt_pemail.Text & "' , city = '" & txt_pcity.Text & "' where mobile_no = '" & txt_pmobno.Text & "' "

        'MessageBox.Show(mysql7)
        comm.CommandText = mysql7
        comm.Connection = conn
        comm.ExecuteNonQuery()
        MessageBox.Show("Record saved to database")
        conn.Close()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        conn.Open()
        Dim res As Integer
        mysql10 = "delete from create_profile_G where mobile_no = '" & txt_dmobno.Text & "' "
        comm.CommandText = mysql10
        comm.Connection = conn
        res = comm.ExecuteNonQuery()
        If res = 1 Then
            MessageBox.Show("Record deleted from database")
        Else
            MessageBox.Show(" number added is wrong ")
        End If

        mysql11 = "select * from create_profile_G  "
        da = New OleDbDataAdapter(mysql11, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_G")
        DGV3.DataSource = ds.Tables("create_profile_G")
        conn.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mystr As String

        conn.Open()
        Dim res As Integer


        mystr = "delete from create_profile_P where mobile_no = '" & txt_dpmobno.Text & "' "
        comm.CommandText = mystr
        comm.Connection = conn
        res = comm.ExecuteNonQuery()
        If res = 1 Then
            MessageBox.Show("Record deleted from database")
        Else

            MessageBox.Show(" number added is wrong ")
        End If

        mystr = "select * from create_profile_P  "
        da = New OleDbDataAdapter(mystr, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_P")
        DGV4.DataSource = ds.Tables("create_profile_P")
        conn.Close()


    End Sub


    Private Sub IconButton7_Click_1(sender As Object, e As EventArgs) Handles IconButton7.Click
        mysql = "select * from create_profile_G"
        da = New OleDbDataAdapter(mysql, conn)
        ds = New DataSet()
        da.Fill(ds, "create_profile_G")
        DGV1.DataSource = ds.Tables("create_profile_G")
        conn.Close()
    End Sub


End Class