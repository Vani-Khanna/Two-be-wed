<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.lbSignup = New System.Windows.Forms.Label()
        Me.TextBox_lname = New System.Windows.Forms.TextBox()
        Me.TextBox_fname = New System.Windows.Forms.TextBox()
        Me.TextBox_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker_dob = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_gender = New System.Windows.Forms.ComboBox()
        Me.TextBox_mobno = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbSignup
        '
        Me.lbSignup.AutoSize = True
        Me.lbSignup.BackColor = System.Drawing.Color.Transparent
        Me.lbSignup.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSignup.ForeColor = System.Drawing.Color.IndianRed
        Me.lbSignup.Location = New System.Drawing.Point(416, 9)
        Me.lbSignup.Name = "lbSignup"
        Me.lbSignup.Size = New System.Drawing.Size(234, 67)
        Me.lbSignup.TabIndex = 0
        Me.lbSignup.Text = "Sign - up"
        '
        'TextBox_lname
        '
        Me.TextBox_lname.Location = New System.Drawing.Point(686, 51)
        Me.TextBox_lname.Name = "TextBox_lname"
        Me.TextBox_lname.Size = New System.Drawing.Size(150, 22)
        Me.TextBox_lname.TabIndex = 1
        '
        'TextBox_fname
        '
        Me.TextBox_fname.Location = New System.Drawing.Point(190, 51)
        Me.TextBox_fname.Name = "TextBox_fname"
        Me.TextBox_fname.Size = New System.Drawing.Size(150, 22)
        Me.TextBox_fname.TabIndex = 2
        '
        'TextBox_email
        '
        Me.TextBox_email.Location = New System.Drawing.Point(190, 210)
        Me.TextBox_email.Name = "TextBox_email"
        Me.TextBox_email.Size = New System.Drawing.Size(150, 22)
        Me.TextBox_email.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(500, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(43, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mobile no. : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(43, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 9
        '
        'DateTimePicker_dob
        '
        Me.DateTimePicker_dob.Location = New System.Drawing.Point(686, 132)
        Me.DateTimePicker_dob.Name = "DateTimePicker_dob"
        Me.DateTimePicker_dob.Size = New System.Drawing.Size(150, 22)
        Me.DateTimePicker_dob.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(500, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "DOB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(500, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gender : "
        '
        'ComboBox_gender
        '
        Me.ComboBox_gender.FormattingEnabled = True
        Me.ComboBox_gender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBox_gender.Location = New System.Drawing.Point(686, 206)
        Me.ComboBox_gender.Name = "ComboBox_gender"
        Me.ComboBox_gender.Size = New System.Drawing.Size(150, 24)
        Me.ComboBox_gender.TabIndex = 14
        '
        'TextBox_mobno
        '
        Me.TextBox_mobno.Location = New System.Drawing.Point(190, 134)
        Me.TextBox_mobno.Name = "TextBox_mobno"
        Me.TextBox_mobno.Size = New System.Drawing.Size(150, 22)
        Me.TextBox_mobno.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.E_spouse.My.Resources.Resources.bg_jpg
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(686, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 34)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.E_spouse.My.Resources.Resources.bg_jpg
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(190, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 34)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox_lname)
        Me.Panel1.Controls.Add(Me.TextBox_fname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox_mobno)
        Me.Panel1.Controls.Add(Me.TextBox_email)
        Me.Panel1.Controls.Add(Me.DateTimePicker_dob)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ComboBox_gender)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(82, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 360)
        Me.Panel1.TabIndex = 19
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_spouse.My.Resources.Resources.bg_jpg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1063, 523)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbSignup)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SignUp"
        Me.Text = "Sign-Up"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbSignup As Label
    Friend WithEvents TextBox_lname As TextBox
    Friend WithEvents TextBox_fname As TextBox
    Friend WithEvents TextBox_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker_dob As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_gender As ComboBox
    Friend WithEvents TextBox_mobno As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
End Class
