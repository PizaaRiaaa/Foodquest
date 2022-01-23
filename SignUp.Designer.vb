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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.usertype = New System.Windows.Forms.Label()
        Me.pboxProfile = New System.Windows.Forms.PictureBox()
        Me.pboxBirthday = New System.Windows.Forms.PictureBox()
        Me.birthday = New MetroFramework.Controls.MetroDateTime()
        Me.pboxGender = New System.Windows.Forms.PictureBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.mtboxMobile = New System.Windows.Forms.MaskedTextBox()
        Me.lblRemindName = New System.Windows.Forms.Label()
        Me.lblRemindPass = New System.Windows.Forms.Label()
        Me.pboxMI = New System.Windows.Forms.PictureBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.pboEmail = New System.Windows.Forms.PictureBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.pboxUser = New System.Windows.Forms.PictureBox()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pboxFL = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.cboShowHide = New System.Windows.Forms.CheckBox()
        Me.pboxLast = New System.Windows.Forms.PictureBox()
        Me.pboxHide = New System.Windows.Forms.PictureBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.pboxPass = New System.Windows.Forms.PictureBox()
        Me.pboxMobile = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pboxGif = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxBirthday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxMI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxFL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxLast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxHide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxMobile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.usertype)
        Me.Panel1.Controls.Add(Me.pboxProfile)
        Me.Panel1.Controls.Add(Me.pboxBirthday)
        Me.Panel1.Controls.Add(Me.birthday)
        Me.Panel1.Controls.Add(Me.pboxGender)
        Me.Panel1.Controls.Add(Me.cboGender)
        Me.Panel1.Controls.Add(Me.mtboxMobile)
        Me.Panel1.Controls.Add(Me.lblRemindName)
        Me.Panel1.Controls.Add(Me.lblRemindPass)
        Me.Panel1.Controls.Add(Me.pboxMI)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblMiddle)
        Me.Panel1.Controls.Add(Me.pboEmail)
        Me.Panel1.Controls.Add(Me.txtLast)
        Me.Panel1.Controls.Add(Me.lblFirst)
        Me.Panel1.Controls.Add(Me.pboxUser)
        Me.Panel1.Controls.Add(Me.txtMiddle)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.pboxFL)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtFirst)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblLast)
        Me.Panel1.Controls.Add(Me.cboShowHide)
        Me.Panel1.Controls.Add(Me.pboxLast)
        Me.Panel1.Controls.Add(Me.pboxHide)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.btnSignup)
        Me.Panel1.Controls.Add(Me.pboxPass)
        Me.Panel1.Controls.Add(Me.pboxMobile)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.lblBirth)
        Me.Panel1.Controls.Add(Me.lblMobile)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(50, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 611)
        Me.Panel1.TabIndex = 0
        '
        'usertype
        '
        Me.usertype.AutoSize = True
        Me.usertype.Location = New System.Drawing.Point(29, 43)
        Me.usertype.Name = "usertype"
        Me.usertype.Size = New System.Drawing.Size(68, 13)
        Me.usertype.TabIndex = 56
        Me.usertype.Text = "CUSTOMER"
        '
        'pboxProfile
        '
        Me.pboxProfile.BackColor = System.Drawing.Color.Transparent
        Me.pboxProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxProfile.Image = Global.Food_Quest_App.My.Resources.Resources._360___Add_Profile_interaction_communication_interface_512
        Me.pboxProfile.Location = New System.Drawing.Point(155, 3)
        Me.pboxProfile.Name = "pboxProfile"
        Me.pboxProfile.Size = New System.Drawing.Size(130, 120)
        Me.pboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxProfile.TabIndex = 51
        Me.pboxProfile.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pboxProfile, "Choose your profile picture")
        '
        'pboxBirthday
        '
        Me.pboxBirthday.BackColor = System.Drawing.Color.Transparent
        Me.pboxBirthday.Location = New System.Drawing.Point(22, 470)
        Me.pboxBirthday.Name = "pboxBirthday"
        Me.pboxBirthday.Size = New System.Drawing.Size(29, 29)
        Me.pboxBirthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxBirthday.TabIndex = 55
        Me.pboxBirthday.TabStop = False
        '
        'birthday
        '
        Me.birthday.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.birthday.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.birthday.Location = New System.Drawing.Point(57, 470)
        Me.birthday.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.birthday.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.birthday.MinimumSize = New System.Drawing.Size(0, 29)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(223, 29)
        Me.birthday.Style = MetroFramework.MetroColorStyle.Black
        Me.birthday.TabIndex = 51
        Me.birthday.Theme = MetroFramework.MetroThemeStyle.Light
        Me.birthday.Value = New Date(2020, 10, 17, 0, 0, 0, 0)
        '
        'pboxGender
        '
        Me.pboxGender.BackColor = System.Drawing.Color.Transparent
        Me.pboxGender.Location = New System.Drawing.Point(398, 470)
        Me.pboxGender.Name = "pboxGender"
        Me.pboxGender.Size = New System.Drawing.Size(30, 29)
        Me.pboxGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxGender.TabIndex = 54
        Me.pboxGender.TabStop = False
        '
        'cboGender
        '
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(286, 471)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(106, 28)
        Me.cboGender.TabIndex = 53
        '
        'mtboxMobile
        '
        Me.mtboxMobile.CausesValidation = False
        Me.mtboxMobile.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtboxMobile.Location = New System.Drawing.Point(57, 408)
        Me.mtboxMobile.Mask = "9999-000-0000"
        Me.mtboxMobile.Name = "mtboxMobile"
        Me.mtboxMobile.Size = New System.Drawing.Size(330, 27)
        Me.mtboxMobile.TabIndex = 52
        '
        'lblRemindName
        '
        Me.lblRemindName.AutoSize = True
        Me.lblRemindName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemindName.Location = New System.Drawing.Point(56, 324)
        Me.lblRemindName.Name = "lblRemindName"
        Me.lblRemindName.Size = New System.Drawing.Size(0, 14)
        Me.lblRemindName.TabIndex = 51
        '
        'lblRemindPass
        '
        Me.lblRemindPass.AutoSize = True
        Me.lblRemindPass.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemindPass.Location = New System.Drawing.Point(54, 165)
        Me.lblRemindPass.Name = "lblRemindPass"
        Me.lblRemindPass.Size = New System.Drawing.Size(0, 14)
        Me.lblRemindPass.TabIndex = 50
        '
        'pboxMI
        '
        Me.pboxMI.BackColor = System.Drawing.Color.Transparent
        Me.pboxMI.Location = New System.Drawing.Point(246, 332)
        Me.pboxMI.Name = "pboxMI"
        Me.pboxMI.Size = New System.Drawing.Size(19, 19)
        Me.pboxMI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxMI.TabIndex = 47
        Me.pboxMI.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.DimGray
        Me.txtEmail.Location = New System.Drawing.Point(52, 135)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(330, 27)
        Me.txtEmail.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(54, 116)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 16)
        Me.lblEmail.TabIndex = 13
        Me.lblEmail.Text = "Email "
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblMiddle.Location = New System.Drawing.Point(213, 338)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(29, 16)
        Me.lblMiddle.TabIndex = 46
        Me.lblMiddle.Text = "M.I"
        '
        'pboEmail
        '
        Me.pboEmail.BackColor = System.Drawing.Color.Transparent
        Me.pboEmail.Location = New System.Drawing.Point(22, 135)
        Me.pboEmail.Name = "pboEmail"
        Me.pboEmail.Size = New System.Drawing.Size(24, 27)
        Me.pboEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboEmail.TabIndex = 24
        Me.pboEmail.TabStop = False
        '
        'txtLast
        '
        Me.txtLast.BackColor = System.Drawing.Color.White
        Me.txtLast.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.ForeColor = System.Drawing.Color.DimGray
        Me.txtLast.Location = New System.Drawing.Point(252, 357)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(135, 27)
        Me.txtLast.TabIndex = 38
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblFirst.Location = New System.Drawing.Point(54, 338)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(77, 16)
        Me.lblFirst.TabIndex = 23
        Me.lblFirst.Text = "First name"
        '
        'pboxUser
        '
        Me.pboxUser.BackColor = System.Drawing.Color.Transparent
        Me.pboxUser.Location = New System.Drawing.Point(22, 204)
        Me.pboxUser.Name = "pboxUser"
        Me.pboxUser.Size = New System.Drawing.Size(24, 27)
        Me.pboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxUser.TabIndex = 43
        Me.pboxUser.TabStop = False
        '
        'txtMiddle
        '
        Me.txtMiddle.BackColor = System.Drawing.Color.White
        Me.txtMiddle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddle.ForeColor = System.Drawing.Color.DimGray
        Me.txtMiddle.Location = New System.Drawing.Point(210, 357)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(36, 27)
        Me.txtMiddle.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.txtMiddle, "Middle Initial is Optional")
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(54, 185)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(72, 16)
        Me.lblUsername.TabIndex = 42
        Me.lblUsername.Text = "Username"
        '
        'pboxFL
        '
        Me.pboxFL.BackColor = System.Drawing.Color.Transparent
        Me.pboxFL.Location = New System.Drawing.Point(22, 357)
        Me.pboxFL.Name = "pboxFL"
        Me.pboxFL.Size = New System.Drawing.Size(29, 27)
        Me.pboxFL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxFL.TabIndex = 25
        Me.pboxFL.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(52, 204)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(335, 27)
        Me.txtUsername.TabIndex = 41
        '
        'txtFirst
        '
        Me.txtFirst.BackColor = System.Drawing.Color.White
        Me.txtFirst.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.ForeColor = System.Drawing.Color.DimGray
        Me.txtFirst.Location = New System.Drawing.Point(57, 357)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(147, 27)
        Me.txtFirst.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(74, 588)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 15)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "By signing up, you agree to our Terms  and Data Policy ."
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblLast.Location = New System.Drawing.Point(271, 338)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(77, 16)
        Me.lblLast.TabIndex = 39
        Me.lblLast.Text = "Last Name"
        '
        'cboShowHide
        '
        Me.cboShowHide.AutoSize = True
        Me.cboShowHide.BackColor = System.Drawing.Color.Transparent
        Me.cboShowHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShowHide.ForeColor = System.Drawing.Color.DimGray
        Me.cboShowHide.Location = New System.Drawing.Point(333, 289)
        Me.cboShowHide.Name = "cboShowHide"
        Me.cboShowHide.Size = New System.Drawing.Size(15, 14)
        Me.cboShowHide.TabIndex = 35
        Me.cboShowHide.UseVisualStyleBackColor = False
        '
        'pboxLast
        '
        Me.pboxLast.BackColor = System.Drawing.Color.Transparent
        Me.pboxLast.Location = New System.Drawing.Point(393, 357)
        Me.pboxLast.Name = "pboxLast"
        Me.pboxLast.Size = New System.Drawing.Size(26, 27)
        Me.pboxLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxLast.TabIndex = 40
        Me.pboxLast.TabStop = False
        '
        'pboxHide
        '
        Me.pboxHide.Image = Global.Food_Quest_App.My.Resources.Resources.icons8_hide_24
        Me.pboxHide.Location = New System.Drawing.Point(357, 278)
        Me.pboxHide.Name = "pboxHide"
        Me.pboxHide.Size = New System.Drawing.Size(23, 26)
        Me.pboxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxHide.TabIndex = 36
        Me.pboxHide.TabStop = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(54, 244)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 16)
        Me.lblPassword.TabIndex = 34
        Me.lblPassword.Text = "Password"
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSignup.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnSignup.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.ForeColor = System.Drawing.Color.White
        Me.btnSignup.Location = New System.Drawing.Point(57, 522)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(345, 49)
        Me.btnSignup.TabIndex = 33
        Me.btnSignup.Text = "Sign up"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'pboxPass
        '
        Me.pboxPass.BackColor = System.Drawing.Color.Transparent
        Me.pboxPass.Location = New System.Drawing.Point(22, 276)
        Me.pboxPass.Name = "pboxPass"
        Me.pboxPass.Size = New System.Drawing.Size(25, 27)
        Me.pboxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxPass.TabIndex = 27
        Me.pboxPass.TabStop = False
        '
        'pboxMobile
        '
        Me.pboxMobile.BackColor = System.Drawing.Color.Transparent
        Me.pboxMobile.Location = New System.Drawing.Point(22, 406)
        Me.pboxMobile.Name = "pboxMobile"
        Me.pboxMobile.Size = New System.Drawing.Size(29, 29)
        Me.pboxMobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxMobile.TabIndex = 26
        Me.pboxMobile.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(215, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(207, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 21
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(283, 451)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(54, 16)
        Me.lblGender.TabIndex = 19
        Me.lblGender.Text = "Gender"
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblBirth.Location = New System.Drawing.Point(56, 451)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(92, 16)
        Me.lblBirth.TabIndex = 15
        Me.lblBirth.Text = "Date of birth"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblMobile.Location = New System.Drawing.Point(56, 389)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(102, 16)
        Me.lblMobile.TabIndex = 9
        Me.lblMobile.Text = "Mobile number"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(52, 277)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(273, 27)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(175, 484)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(162, 24)
        Me.lblLogin.TabIndex = 39
        Me.lblLogin.Text = "Have an account?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(332, 484)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 24)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Login"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(552, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(552, 653)
        Me.Panel3.TabIndex = 48
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "|*.jpg;*png"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Food_Quest_App.My.Resources.Resources.icons8_close_window_64
        Me.PictureBox2.Location = New System.Drawing.Point(44, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'pboxGif
        '
        Me.pboxGif.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.pboxGif.Image = CType(resources.GetObject("pboxGif.Image"), System.Drawing.Image)
        Me.pboxGif.Location = New System.Drawing.Point(0, 74)
        Me.pboxGif.Name = "pboxGif"
        Me.pboxGif.Size = New System.Drawing.Size(554, 489)
        Me.pboxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pboxGif.TabIndex = 42
        Me.pboxGif.TabStop = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1101, 647)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pboxGif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp"
        Me.Text = " Sign up | Food Quest"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxBirthday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxMI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxFL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxLast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxHide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxMobile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignup As Button
    Friend WithEvents pboxPass As PictureBox
    Friend WithEvents pboxFL As PictureBox
    Friend WithEvents pboEmail As PictureBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblBirth As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents cboShowHide As CheckBox
    Friend WithEvents pboxHide As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents lblLast As Label
    Friend WithEvents pboxLast As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents pboxUser As PictureBox
    Friend WithEvents pboxGif As PictureBox
    Friend WithEvents lblMiddle As Label
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents pboxMI As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents mtboxMobile As MaskedTextBox
    Friend WithEvents lblRemindName As Label
    Friend WithEvents lblRemindPass As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents pboxGender As PictureBox
    Friend WithEvents birthday As MetroFramework.Controls.MetroDateTime
    Friend WithEvents pboxBirthday As PictureBox
    Friend WithEvents pboxMobile As PictureBox
    Friend WithEvents pboxProfile As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents usertype As Label
End Class
