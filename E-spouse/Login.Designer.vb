<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_uname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.txt_upass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(142, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button_login
        '
        Me.Button_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_login.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_login.Location = New System.Drawing.Point(376, 364)
        Me.Button_login.Name = "Button_login"
        Me.Button_login.Size = New System.Drawing.Size(114, 35)
        Me.Button_login.TabIndex = 5
        Me.Button_login.Text = "Login"
        Me.Button_login.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(250, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 71)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Login"
        '
        'txt_uname
        '
        Me.txt_uname.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txt_uname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_uname.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_uname.HintForeColor = System.Drawing.Color.Empty
        Me.txt_uname.HintText = "Username"
        Me.txt_uname.isPassword = False
        Me.txt_uname.LineFocusedColor = System.Drawing.Color.IndianRed
        Me.txt_uname.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_uname.LineMouseHoverColor = System.Drawing.Color.DarkGray
        Me.txt_uname.LineThickness = 4
        Me.txt_uname.Location = New System.Drawing.Point(142, 153)
        Me.txt_uname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(348, 43)
        Me.txt_uname.TabIndex = 8
        Me.txt_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.E_spouse.My.Resources.Resources.bg_jpg
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.txt_upass)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.txt_uname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button_login)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 465)
        Me.Panel1.TabIndex = 7
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.Transparent
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 28
        Me.IconButton3.Location = New System.Drawing.Point(445, 225)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(45, 34)
        Me.IconButton3.TabIndex = 14
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'txt_upass
        '
        Me.txt_upass.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txt_upass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_upass.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_upass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_upass.HintForeColor = System.Drawing.Color.Empty
        Me.txt_upass.HintText = "Password"
        Me.txt_upass.isPassword = False
        Me.txt_upass.LineFocusedColor = System.Drawing.Color.IndianRed
        Me.txt_upass.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_upass.LineMouseHoverColor = System.Drawing.Color.DarkGray
        Me.txt_upass.LineThickness = 4
        Me.txt_upass.Location = New System.Drawing.Point(142, 225)
        Me.txt_upass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_upass.Name = "txt_upass"
        Me.txt_upass.Size = New System.Drawing.Size(348, 40)
        Me.txt_upass.TabIndex = 12
        Me.txt_upass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 28
        Me.IconButton1.Location = New System.Drawing.Point(445, 153)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(45, 34)
        Me.IconButton1.TabIndex = 10
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_spouse.My.Resources.Resources.bg_jpg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 489)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button_login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_uname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_upass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
