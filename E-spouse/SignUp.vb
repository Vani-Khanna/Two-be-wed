Public Class SignUp

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If TextBox_fname.Text = "" Or TextBox_lname.Text = "" Or TextBox_mobno.Text = "" _
            Or TextBox_email.Text = "" Then
            MsgBox("Please fill all fields ")



        Else
            Me.Hide()
            set_user__pass_Window.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.BackColor = Color.FromArgb(50, 150, 150, 150)
        'Panel1.BorderStyle = BorderStyle.FixedSingle
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class