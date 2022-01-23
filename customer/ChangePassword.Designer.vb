<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePassword
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblCurrentPass = New System.Windows.Forms.Label()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.txtCurrentPass = New MetroFramework.Controls.MetroTextBox()
        Me.txtNewPass = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pboxProfile = New System.Windows.Forms.PictureBox()
        Me.cboCheck = New MetroFramework.Controls.MetroCheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(94, 177)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(83, 20)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblCurrentPass
        '
        Me.lblCurrentPass.AutoSize = True
        Me.lblCurrentPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentPass.Location = New System.Drawing.Point(94, 272)
        Me.lblCurrentPass.Name = "lblCurrentPass"
        Me.lblCurrentPass.Size = New System.Drawing.Size(227, 20)
        Me.lblCurrentPass.TabIndex = 1
        Me.lblCurrentPass.Text = "What's your current password?"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(281, 1)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(98, 209)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.Size = New System.Drawing.Size(325, 45)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.UseCustomBackColor = True
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCurrentPass
        '
        Me.txtCurrentPass.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.txtCurrentPass.CustomButton.Image = Nothing
        Me.txtCurrentPass.CustomButton.Location = New System.Drawing.Point(281, 1)
        Me.txtCurrentPass.CustomButton.Name = ""
        Me.txtCurrentPass.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtCurrentPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCurrentPass.CustomButton.TabIndex = 1
        Me.txtCurrentPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCurrentPass.CustomButton.UseSelectable = True
        Me.txtCurrentPass.CustomButton.Visible = False
        Me.txtCurrentPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCurrentPass.Lines = New String(-1) {}
        Me.txtCurrentPass.Location = New System.Drawing.Point(98, 308)
        Me.txtCurrentPass.MaxLength = 32767
        Me.txtCurrentPass.Name = "txtCurrentPass"
        Me.txtCurrentPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCurrentPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCurrentPass.SelectedText = ""
        Me.txtCurrentPass.SelectionLength = 0
        Me.txtCurrentPass.SelectionStart = 0
        Me.txtCurrentPass.ShortcutsEnabled = True
        Me.txtCurrentPass.Size = New System.Drawing.Size(325, 45)
        Me.txtCurrentPass.TabIndex = 3
        Me.txtCurrentPass.UseCustomBackColor = True
        Me.txtCurrentPass.UseSelectable = True
        Me.txtCurrentPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCurrentPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.txtNewPass.CustomButton.Image = Nothing
        Me.txtNewPass.CustomButton.Location = New System.Drawing.Point(281, 1)
        Me.txtNewPass.CustomButton.Name = ""
        Me.txtNewPass.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNewPass.CustomButton.TabIndex = 1
        Me.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNewPass.CustomButton.UseSelectable = True
        Me.txtNewPass.CustomButton.Visible = False
        Me.txtNewPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNewPass.Lines = New String(-1) {}
        Me.txtNewPass.Location = New System.Drawing.Point(98, 389)
        Me.txtNewPass.MaxLength = 32767
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNewPass.SelectedText = ""
        Me.txtNewPass.SelectionLength = 0
        Me.txtNewPass.SelectionStart = 0
        Me.txtNewPass.ShortcutsEnabled = True
        Me.txtNewPass.Size = New System.Drawing.Size(325, 45)
        Me.txtNewPass.TabIndex = 4
        Me.txtNewPass.UseCustomBackColor = True
        Me.txtNewPass.UseSelectable = True
        Me.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNewPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 33)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Food_Quest_App.My.Resources.Resources.icons8_close_window_64
        Me.PictureBox3.Location = New System.Drawing.Point(479, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(353, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Change your password , username or profile picture."
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(98, 455)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(325, 60)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseCustomBackColor = True
        Me.btnSave.UseCustomForeColor = True
        Me.btnSave.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.plus
        Me.PictureBox1.Location = New System.Drawing.Point(293, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'pboxProfile
        '
        Me.pboxProfile.Image = Global.Food_Quest_App.My.Resources.Resources.profile
        Me.pboxProfile.Location = New System.Drawing.Point(198, 57)
        Me.pboxProfile.Name = "pboxProfile"
        Me.pboxProfile.Size = New System.Drawing.Size(137, 108)
        Me.pboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxProfile.TabIndex = 7
        Me.pboxProfile.TabStop = False
        '
        'cboCheck
        '
        Me.cboCheck.AutoSize = True
        Me.cboCheck.ForeColor = System.Drawing.Color.White
        Me.cboCheck.Location = New System.Drawing.Point(432, 362)
        Me.cboCheck.Name = "cboCheck"
        Me.cboCheck.Size = New System.Drawing.Size(26, 15)
        Me.cboCheck.TabIndex = 9
        Me.cboCheck.Text = "."
        Me.cboCheck.UseCustomBackColor = True
        Me.cboCheck.UseCustomForeColor = True
        Me.cboCheck.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Food_Quest_App.My.Resources.Resources.icons8_hide_24
        Me.PictureBox2.Location = New System.Drawing.Point(451, 353)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNewPass.Location = New System.Drawing.Point(94, 362)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(206, 20)
        Me.lblNewPass.TabIndex = 11
        Me.lblNewPass.Text = "What's your new password?"
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 556)
        Me.Controls.Add(Me.lblNewPass)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cboCheck)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pboxProfile)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtCurrentPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblCurrentPass)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblCurrentPass As Label
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCurrentPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNewPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents pboxProfile As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboCheck As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblNewPass As Label
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents PictureBox3 As PictureBox
End Class
