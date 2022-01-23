<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authorization
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(178, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Authorization Requied"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(458, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "For security reasons, please enter authorized personnel account to continue."
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroButton1.ForeColor = System.Drawing.Color.White
        Me.MetroButton1.Location = New System.Drawing.Point(198, 216)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(108, 45)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "OK"
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.Color.White
        Me.MetroButton2.Location = New System.Drawing.Point(312, 216)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(108, 45)
        Me.MetroButton2.TabIndex = 5
        Me.MetroButton2.Text = "Cancel"
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.authorization
        Me.PictureBox1.Location = New System.Drawing.Point(107, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.DisplayIcon = True
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPassword.Icon = Global.Food_Quest_App.My.Resources.Resources.passwprd
        Me.txtPassword.IconRight = True
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(76, 156)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PromptText = "Password"
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(344, 39)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMark = "Password"
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.DisplayIcon = True
        Me.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUsername.Icon = Global.Food_Quest_App.My.Resources.Resources.username
        Me.txtUsername.IconRight = True
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(76, 90)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PromptText = "Username"
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.Size = New System.Drawing.Size(344, 39)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMark = "Username"
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Authorization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(492, 273)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Authorization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VoidTransno"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
