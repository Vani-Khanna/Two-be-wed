Public Class dashboard



    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(50, 150, 150, 150)
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Label1.BackColor = Color.Transparent
        'Label3.BackColor = Color.Transparent
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select_package.Show()
        'create_profile.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        view_database.Show()
        Me.Hide()
    End Sub


End Class