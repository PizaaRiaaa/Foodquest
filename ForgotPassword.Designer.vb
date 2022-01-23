<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pboxBack = New System.Windows.Forms.PictureBox()
        Me.pboxEmail = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pboxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(89, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Forgot your password?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please enter your email for the instruction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          on how to reset your passw" &
    "ord"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.pboxBack)
        Me.Panel1.Controls.Add(Me.pboxEmail)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 452)
        Me.Panel1.TabIndex = 3
        '
        'pboxBack
        '
        Me.pboxBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxBack.Image = Global.Food_Quest_App.My.Resources.Resources.back
        Me.pboxBack.Location = New System.Drawing.Point(304, 12)
        Me.pboxBack.Name = "pboxBack"
        Me.pboxBack.Size = New System.Drawing.Size(30, 33)
        Me.pboxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxBack.TabIndex = 51
        Me.pboxBack.TabStop = False
        Me.MetroToolTip1.SetToolTip(Me.pboxBack, "Go back")
        '
        'pboxEmail
        '
        Me.pboxEmail.Location = New System.Drawing.Point(25, 298)
        Me.pboxEmail.Name = "pboxEmail"
        Me.pboxEmail.Size = New System.Drawing.Size(20, 24)
        Me.pboxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxEmail.TabIndex = 8
        Me.pboxEmail.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblLogin)
        Me.Panel2.Location = New System.Drawing.Point(0, 417)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 35)
        Me.Panel2.TabIndex = 7
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.Location = New System.Drawing.Point(127, 10)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(91, 16)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Back to login"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(51, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Proceed"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(57, 270)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(51, 298)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 25)
        Me.txtEmail.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.forgotpass_icon1
        Me.PictureBox1.Location = New System.Drawing.Point(130, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(22, 32)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 52
        Me.lblDate.Text = "Label3"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(22, 54)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 13)
        Me.lblTime.TabIndex = 53
        Me.lblTime.Text = "Label3"
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(346, 453)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "forgotPassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pboxBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents pboxEmail As PictureBox
    Friend WithEvents pboxBack As PictureBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
End Class
