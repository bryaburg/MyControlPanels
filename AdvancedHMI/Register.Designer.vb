<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.TbUsName1 = New System.Windows.Forms.TextBox()
        Me.TbUsPw1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.TbUsRe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbUsName1
        '
        Me.TbUsName1.BackColor = System.Drawing.Color.Blue
        Me.TbUsName1.Font = New System.Drawing.Font("Magneto", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsName1.ForeColor = System.Drawing.Color.GhostWhite
        Me.TbUsName1.Location = New System.Drawing.Point(156, 74)
        Me.TbUsName1.Multiline = True
        Me.TbUsName1.Name = "TbUsName1"
        Me.TbUsName1.Size = New System.Drawing.Size(254, 52)
        Me.TbUsName1.TabIndex = 0
        '
        'TbUsPw1
        '
        Me.TbUsPw1.BackColor = System.Drawing.Color.Blue
        Me.TbUsPw1.Font = New System.Drawing.Font("Magneto", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsPw1.ForeColor = System.Drawing.Color.GhostWhite
        Me.TbUsPw1.Location = New System.Drawing.Point(156, 132)
        Me.TbUsPw1.Multiline = True
        Me.TbUsPw1.Name = "TbUsPw1"
        Me.TbUsPw1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbUsPw1.Size = New System.Drawing.Size(254, 52)
        Me.TbUsPw1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Magneto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(18, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Magneto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(18, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password -"
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.Blue
        Me.SaveBtn.Font = New System.Drawing.Font("Magneto", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.SaveBtn.Location = New System.Drawing.Point(184, 289)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(106, 34)
        Me.SaveBtn.TabIndex = 3
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'TbUsRe
        '
        Me.TbUsRe.BackColor = System.Drawing.Color.Blue
        Me.TbUsRe.Font = New System.Drawing.Font("Magneto", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsRe.ForeColor = System.Drawing.Color.GhostWhite
        Me.TbUsRe.Location = New System.Drawing.Point(156, 190)
        Me.TbUsRe.Multiline = True
        Me.TbUsRe.Name = "TbUsRe"
        Me.TbUsRe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbUsRe.Size = New System.Drawing.Size(254, 52)
        Me.TbUsRe.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Magneto", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(7, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Re-Enter PW -"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(482, 353)
        Me.Controls.Add(Me.TbUsRe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbUsPw1)
        Me.Controls.Add(Me.TbUsName1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbUsName1 As TextBox
    Friend WithEvents TbUsPw1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents TbUsRe As TextBox
    Friend WithEvents Label3 As Label
End Class
