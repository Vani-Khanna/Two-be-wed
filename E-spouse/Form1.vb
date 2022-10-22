Public Class Home


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(50, 150, 150, 150)
        label2.BackColor = Color.Transparent
        label1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        SignUp.Show()
    End Sub


End Class
