<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login1
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbUsPw = New System.Windows.Forms.TextBox()
        Me.TbUsName = New System.Windows.Forms.TextBox()
        Me.RegLogin = New System.Windows.Forms.LinkLabel()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Magneto", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(130, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Login Please:"
        '
        'TbUsPw
        '
        Me.TbUsPw.BackColor = System.Drawing.Color.Blue
        Me.TbUsPw.Font = New System.Drawing.Font("Magneto", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsPw.ForeColor = System.Drawing.Color.GhostWhite
        Me.TbUsPw.Location = New System.Drawing.Point(174, 183)
        Me.TbUsPw.Name = "TbUsPw"
        Me.TbUsPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbUsPw.Size = New System.Drawing.Size(254, 52)
        Me.TbUsPw.TabIndex = 0
        '
        'TbUsName
        '
        Me.TbUsName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbUsName.BackColor = System.Drawing.Color.Blue
        Me.TbUsName.Font = New System.Drawing.Font("Magneto", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsName.ForeColor = System.Drawing.Color.GhostWhite
        Me.TbUsName.Location = New System.Drawing.Point(174, 87)
        Me.TbUsName.Name = "TbUsName"
        Me.TbUsName.Size = New System.Drawing.Size(254, 52)
        Me.TbUsName.TabIndex = 2
        '
        'RegLogin
        '
        Me.RegLogin.AutoSize = True
        Me.RegLogin.LinkColor = System.Drawing.Color.White
        Me.RegLogin.Location = New System.Drawing.Point(171, 261)
        Me.RegLogin.Name = "RegLogin"
        Me.RegLogin.Size = New System.Drawing.Size(92, 17)
        Me.RegLogin.TabIndex = 3
        Me.RegLogin.TabStop = True
        Me.RegLogin.Text = "New Register"
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.Blue
        Me.LoginBtn.Font = New System.Drawing.Font("Magneto", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.LoginBtn.Location = New System.Drawing.Point(174, 297)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(106, 34)
        Me.LoginBtn.TabIndex = 1
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Magneto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(38, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Password -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Magneto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(36, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Username -"
        '
        'Login1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(482, 353)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbUsPw)
        Me.Controls.Add(Me.TbUsName)
        Me.Controls.Add(Me.RegLogin)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TbUsPw As TextBox
    Friend WithEvents TbUsName As TextBox
    Friend WithEvents RegLogin As LinkLabel
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
