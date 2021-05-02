<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register1))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbUsRe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbUsPw1 = New System.Windows.Forms.TextBox()
        Me.TbUsName1 = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
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
        Me.Label6.Location = New System.Drawing.Point(76, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 27)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "New Registration:"
        '
        'TbUsRe
        '
        Me.TbUsRe.AcceptsReturn = True
        Me.TbUsRe.BackColor = System.Drawing.Color.Blue
        Me.TbUsRe.Font = New System.Drawing.Font("Magneto", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsRe.ForeColor = System.Drawing.Color.GhostWhite
        Me.TbUsRe.Location = New System.Drawing.Point(143, 162)
        Me.TbUsRe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbUsRe.Name = "TbUsRe"
        Me.TbUsRe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbUsRe.Size = New System.Drawing.Size(192, 43)
        Me.TbUsRe.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Magneto", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(32, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Re-Enter PW -"
        '
        'TbUsPw1
        '
        Me.TbUsPw1.AcceptsReturn = True
        Me.TbUsPw1.BackColor = System.Drawing.Color.Blue
        Me.TbUsPw1.Font = New System.Drawing.Font("Magneto", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsPw1.ForeColor = System.Drawing.Color.GhostWhite
        Me.TbUsPw1.Location = New System.Drawing.Point(143, 115)
        Me.TbUsPw1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbUsPw1.Name = "TbUsPw1"
        Me.TbUsPw1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbUsPw1.Size = New System.Drawing.Size(192, 43)
        Me.TbUsPw1.TabIndex = 15
        '
        'TbUsName1
        '
        Me.TbUsName1.BackColor = System.Drawing.Color.Blue
        Me.TbUsName1.Font = New System.Drawing.Font("Magneto", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsName1.ForeColor = System.Drawing.Color.GhostWhite
        Me.TbUsName1.Location = New System.Drawing.Point(143, 68)
        Me.TbUsName1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbUsName1.Name = "TbUsName1"
        Me.TbUsName1.Size = New System.Drawing.Size(192, 43)
        Me.TbUsName1.TabIndex = 14
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.Blue
        Me.SaveBtn.Font = New System.Drawing.Font("Magneto", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.SaveBtn.Location = New System.Drawing.Point(143, 240)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(80, 28)
        Me.SaveBtn.TabIndex = 18
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Magneto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(40, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Password -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Magneto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(40, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Username -"
        '
        'Register1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(362, 287)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbUsRe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbUsPw1)
        Me.Controls.Add(Me.TbUsName1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Register1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TbUsRe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbUsPw1 As TextBox
    Friend WithEvents TbUsName1 As TextBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
