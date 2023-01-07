<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordReset
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAccessCode = New MetroFramework.Controls.MetroTextBox()
        Me.btnProceed = New MetroFramework.Controls.MetroButton()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.lblRemind = New System.Windows.Forms.Label()
        Me.cboShowHide = New MetroFramework.Controls.MetroCheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(102, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Reset Email Sent"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.check1
        Me.PictureBox1.Location = New System.Drawing.Point(172, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 33)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(123, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter your verification code"
        '
        'txtAccessCode
        '
        Me.txtAccessCode.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.txtAccessCode.CustomButton.Image = Nothing
        Me.txtAccessCode.CustomButton.Location = New System.Drawing.Point(318, 2)
        Me.txtAccessCode.CustomButton.Name = ""
        Me.txtAccessCode.CustomButton.Size = New System.Drawing.Size(49, 49)
        Me.txtAccessCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAccessCode.CustomButton.TabIndex = 1
        Me.txtAccessCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAccessCode.CustomButton.UseSelectable = True
        Me.txtAccessCode.CustomButton.Visible = False
        Me.txtAccessCode.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtAccessCode.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtAccessCode.Lines = New String(-1) {}
        Me.txtAccessCode.Location = New System.Drawing.Point(35, 242)
        Me.txtAccessCode.MaxLength = 32767
        Me.txtAccessCode.Name = "txtAccessCode"
        Me.txtAccessCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccessCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAccessCode.SelectedText = ""
        Me.txtAccessCode.SelectionLength = 0
        Me.txtAccessCode.SelectionStart = 0
        Me.txtAccessCode.ShortcutsEnabled = True
        Me.txtAccessCode.Size = New System.Drawing.Size(370, 54)
        Me.txtAccessCode.TabIndex = 7
        Me.txtAccessCode.UseCustomBackColor = True
        Me.txtAccessCode.UseSelectable = True
        Me.txtAccessCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAccessCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(316, 313)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(89, 28)
        Me.btnProceed.TabIndex = 8
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseCustomBackColor = True
        Me.btnProceed.UseCustomForeColor = True
        Me.btnProceed.UseSelectable = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(316, 2)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(49, 49)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(37, 389)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PromptText = "Password"
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(368, 54)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.UseCustomBackColor = True
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMark = "Password"
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(37, 487)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(370, 50)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset your password"
        Me.btnReset.UseCustomBackColor = True
        Me.btnReset.UseCustomForeColor = True
        Me.btnReset.UseSelectable = True
        '
        'lblRemind
        '
        Me.lblRemind.AutoSize = True
        Me.lblRemind.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRemind.Location = New System.Drawing.Point(34, 359)
        Me.lblRemind.Name = "lblRemind"
        Me.lblRemind.Size = New System.Drawing.Size(156, 16)
        Me.lblRemind.TabIndex = 12
        Me.lblRemind.Text = "Enter your new password"
        '
        'cboShowHide
        '
        Me.cboShowHide.AutoSize = True
        Me.cboShowHide.ForeColor = System.Drawing.Color.White
        Me.cboShowHide.Location = New System.Drawing.Point(358, 368)
        Me.cboShowHide.Name = "cboShowHide"
        Me.cboShowHide.Size = New System.Drawing.Size(26, 15)
        Me.cboShowHide.TabIndex = 13
        Me.cboShowHide.Text = "."
        Me.MetroToolTip1.SetToolTip(Me.cboShowHide, "Show password")
        Me.cboShowHide.UseCustomForeColor = True
        Me.cboShowHide.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Food_Quest_App.My.Resources.Resources.icons8_hide_24
        Me.PictureBox2.Location = New System.Drawing.Point(378, 360)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 23)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'PasswordReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(451, 559)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cboShowHide)
        Me.Controls.Add(Me.lblRemind)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.txtAccessCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PasswordReset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PasswordReset"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAccessCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnProceed As MetroFramework.Controls.MetroButton
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents lblRemind As Label
    Friend WithEvents cboShowHide As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
