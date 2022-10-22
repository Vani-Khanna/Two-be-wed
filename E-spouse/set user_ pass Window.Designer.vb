<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class set_user__pass_Window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(set_user__pass_Window))
        Me.set_up = New System.Windows.Forms.Label()
        Me.lbSet_uss = New System.Windows.Forms.Label()
        Me.lbSet_pass = New System.Windows.Forms.Label()
        Me.Txt_username = New System.Windows.Forms.TextBox()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.lbConf_pass = New System.Windows.Forms.Label()
        Me.Txt_password = New System.Windows.Forms.TextBox()
        Me.btConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'set_up
        '
        Me.set_up.AutoSize = True
        Me.set_up.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.set_up.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_up.Location = New System.Drawing.Point(12, 28)
        Me.set_up.Name = "set_up"
        Me.set_up.Size = New System.Drawing.Size(329, 26)
        Me.set_up.TabIndex = 0
        Me.set_up.Text = "Set your username and password"
        '
        'lbSet_uss
        '
        Me.lbSet_uss.AutoSize = True
        Me.lbSet_uss.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbSet_uss.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSet_uss.Location = New System.Drawing.Point(12, 98)
        Me.lbSet_uss.Name = "lbSet_uss"
        Me.lbSet_uss.Size = New System.Drawing.Size(122, 25)
        Me.lbSet_uss.TabIndex = 1
        Me.lbSet_uss.Text = "Username : "
        '
        'lbSet_pass
        '
        Me.lbSet_pass.AutoSize = True
        Me.lbSet_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbSet_pass.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSet_pass.Location = New System.Drawing.Point(12, 181)
        Me.lbSet_pass.Name = "lbSet_pass"
        Me.lbSet_pass.Size = New System.Drawing.Size(116, 25)
        Me.lbSet_pass.TabIndex = 2
        Me.lbSet_pass.Text = "Password : "
        '
        'Txt_username
        '
        Me.Txt_username.Location = New System.Drawing.Point(17, 126)
        Me.Txt_username.Name = "Txt_username"
        Me.Txt_username.Size = New System.Drawing.Size(172, 22)
        Me.Txt_username.TabIndex = 3
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(17, 218)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(172, 22)
        Me.TextBox.TabIndex = 4
        '
        'lbConf_pass
        '
        Me.lbConf_pass.AutoSize = True
        Me.lbConf_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.lbConf_pass.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConf_pass.Location = New System.Drawing.Point(12, 274)
        Me.lbConf_pass.Name = "lbConf_pass"
        Me.lbConf_pass.Size = New System.Drawing.Size(196, 25)
        Me.lbConf_pass.TabIndex = 5
        Me.lbConf_pass.Text = "Confirm password : "
        '
        'Txt_password
        '
        Me.Txt_password.Location = New System.Drawing.Point(17, 318)
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.Size = New System.Drawing.Size(174, 22)
        Me.Txt_password.TabIndex = 6
        '
        'btConfirm
        '
        Me.btConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConfirm.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfirm.Location = New System.Drawing.Point(17, 374)
        Me.btConfirm.Name = "btConfirm"
        Me.btConfirm.Size = New System.Drawing.Size(172, 37)
        Me.btConfirm.TabIndex = 7
        Me.btConfirm.Text = "Done"
        Me.btConfirm.UseVisualStyleBackColor = False
        '
        'set_user__pass_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.E_spouse.My.Resources.Resources.bg_jpg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(370, 450)
        Me.Controls.Add(Me.btConfirm)
        Me.Controls.Add(Me.Txt_password)
        Me.Controls.Add(Me.lbConf_pass)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Txt_username)
        Me.Controls.Add(Me.lbSet_pass)
        Me.Controls.Add(Me.lbSet_uss)
        Me.Controls.Add(Me.set_up)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "set_user__pass_Window"
        Me.Text = "set_user__pass_Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents set_up As Label
    Friend WithEvents lbSet_uss As Label
    Friend WithEvents lbSet_pass As Label
    Friend WithEvents Txt_username As TextBox
    Friend WithEvents TextBox As TextBox
    Friend WithEvents lbConf_pass As Label
    Friend WithEvents Txt_password As TextBox
    Friend WithEvents btConfirm As Button
End Class
