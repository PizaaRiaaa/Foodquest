<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employees_details
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAddCashier = New System.Windows.Forms.Button()
        Me.lblID = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnPass = New MetroFramework.Controls.MetroButton()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmail = New MetroFramework.Controls.MetroLabel()
        Me.txtFirstName = New MetroFramework.Controls.MetroTextBox()
        Me.txtMI = New MetroFramework.Controls.MetroTextBox()
        Me.txtLastName = New MetroFramework.Controls.MetroTextBox()
        Me.mtMobile = New System.Windows.Forms.MaskedTextBox()
        Me.dtDOB = New MetroFramework.Controls.MetroDateTime()
        Me.cboGender = New MetroFramework.Controls.MetroComboBox()
        Me.lblFirst = New MetroFramework.Controls.MetroLabel()
        Me.lblMiddle = New MetroFramework.Controls.MetroLabel()
        Me.lblLastName = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.lblNameRemind = New MetroFramework.Controls.MetroLabel()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.pboxBirth = New System.Windows.Forms.PictureBox()
        Me.pboxGender = New System.Windows.Forms.PictureBox()
        Me.pboxEmail = New System.Windows.Forms.PictureBox()
        Me.pboxLastName = New System.Windows.Forms.PictureBox()
        Me.pboxMiddle = New System.Windows.Forms.PictureBox()
        Me.pboxFirstName = New System.Windows.Forms.PictureBox()
        Me.pboxMobile = New System.Windows.Forms.PictureBox()
        Me.TxtUsertype = New MetroFramework.Controls.MetroTextBox()
        Me.pboxProfile = New System.Windows.Forms.PictureBox()
        Me.txtID = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxBirth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxMiddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxMobile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(30, 157)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 45)
        Me.btnDelete.TabIndex = 98
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(30, 208)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 45)
        Me.btnUpdate.TabIndex = 97
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(30, 53)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 45)
        Me.btnReset.TabIndex = 96
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnAddCashier
        '
        Me.btnAddCashier.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAddCashier.ForeColor = System.Drawing.Color.White
        Me.btnAddCashier.Location = New System.Drawing.Point(30, 106)
        Me.btnAddCashier.Name = "btnAddCashier"
        Me.btnAddCashier.Size = New System.Drawing.Size(110, 45)
        Me.btnAddCashier.TabIndex = 95
        Me.btnAddCashier.Text = "ADD CASHIER"
        Me.btnAddCashier.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblID.Location = New System.Drawing.Point(496, 33)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(66, 15)
        Me.lblID.TabIndex = 143
        Me.lblID.Text = "CASHIER ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(30, 303)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(938, 361)
        Me.DataGridView1.TabIndex = 157
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.Location = New System.Drawing.Point(637, 33)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 15)
        Me.MetroLabel1.TabIndex = 160
        Me.MetroLabel1.Text = "USER TYPE"
        '
        'btnPass
        '
        Me.btnPass.BackColor = System.Drawing.Color.Black
        Me.btnPass.ForeColor = System.Drawing.Color.White
        Me.btnPass.Location = New System.Drawing.Point(496, 213)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(86, 37)
        Me.btnPass.TabIndex = 165
        Me.btnPass.Text = "PASSWORD"
        Me.btnPass.UseCustomBackColor = True
        Me.btnPass.UseCustomForeColor = True
        Me.btnPass.UseSelectable = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblUsername.Location = New System.Drawing.Point(497, 118)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(67, 15)
        Me.lblUsername.TabIndex = 168
        Me.lblUsername.Text = "USERNAME"
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(236, 1)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(174, 162)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PromptText = "EMAIL"
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.ShowClearButton = True
        Me.txtEmail.Size = New System.Drawing.Size(270, 35)
        Me.txtEmail.TabIndex = 141
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMark = "EMAIL"
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblEmail.Location = New System.Drawing.Point(174, 144)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 142
        Me.lblEmail.Text = "EMAIL"
        '
        'txtFirstName
        '
        '
        '
        '
        Me.txtFirstName.CustomButton.Image = Nothing
        Me.txtFirstName.CustomButton.Location = New System.Drawing.Point(72, 1)
        Me.txtFirstName.CustomButton.Name = ""
        Me.txtFirstName.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFirstName.CustomButton.TabIndex = 1
        Me.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFirstName.CustomButton.UseSelectable = True
        Me.txtFirstName.CustomButton.Visible = False
        Me.txtFirstName.Lines = New String(-1) {}
        Me.txtFirstName.Location = New System.Drawing.Point(172, 53)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PromptText = "FIRSTNAME"
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.SelectionLength = 0
        Me.txtFirstName.SelectionStart = 0
        Me.txtFirstName.ShortcutsEnabled = True
        Me.txtFirstName.Size = New System.Drawing.Size(106, 35)
        Me.txtFirstName.TabIndex = 169
        Me.txtFirstName.UseSelectable = True
        Me.txtFirstName.WaterMark = "FIRSTNAME"
        Me.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMI
        '
        '
        '
        '
        Me.txtMI.CustomButton.Image = Nothing
        Me.txtMI.CustomButton.Location = New System.Drawing.Point(18, 1)
        Me.txtMI.CustomButton.Name = ""
        Me.txtMI.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtMI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMI.CustomButton.TabIndex = 1
        Me.txtMI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMI.CustomButton.UseSelectable = True
        Me.txtMI.CustomButton.Visible = False
        Me.txtMI.Lines = New String(-1) {}
        Me.txtMI.Location = New System.Drawing.Point(284, 53)
        Me.txtMI.MaxLength = 32767
        Me.txtMI.Name = "txtMI"
        Me.txtMI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMI.PromptText = "M.I"
        Me.txtMI.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMI.SelectedText = ""
        Me.txtMI.SelectionLength = 0
        Me.txtMI.SelectionStart = 0
        Me.txtMI.ShortcutsEnabled = True
        Me.txtMI.Size = New System.Drawing.Size(52, 35)
        Me.txtMI.TabIndex = 170
        Me.txtMI.UseSelectable = True
        Me.txtMI.WaterMark = "M.I"
        Me.txtMI.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMI.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLastName
        '
        '
        '
        '
        Me.txtLastName.CustomButton.Image = Nothing
        Me.txtLastName.CustomButton.Location = New System.Drawing.Point(68, 1)
        Me.txtLastName.CustomButton.Name = ""
        Me.txtLastName.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastName.CustomButton.TabIndex = 1
        Me.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastName.CustomButton.UseSelectable = True
        Me.txtLastName.CustomButton.Visible = False
        Me.txtLastName.Lines = New String(-1) {}
        Me.txtLastName.Location = New System.Drawing.Point(342, 53)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PromptText = "LASTNAME"
        Me.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.ShortcutsEnabled = True
        Me.txtLastName.Size = New System.Drawing.Size(102, 35)
        Me.txtLastName.TabIndex = 171
        Me.txtLastName.UseSelectable = True
        Me.txtLastName.WaterMark = "LASTNAME"
        Me.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtMobile
        '
        Me.mtMobile.Location = New System.Drawing.Point(174, 113)
        Me.mtMobile.Mask = "9999-999-9999"
        Me.mtMobile.Name = "mtMobile"
        Me.mtMobile.Size = New System.Drawing.Size(162, 20)
        Me.mtMobile.TabIndex = 172
        '
        'dtDOB
        '
        Me.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDOB.Location = New System.Drawing.Point(174, 221)
        Me.dtDOB.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDOB.Name = "dtDOB"
        Me.dtDOB.Size = New System.Drawing.Size(270, 29)
        Me.dtDOB.TabIndex = 174
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.ItemHeight = 23
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(342, 113)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(102, 29)
        Me.cboGender.TabIndex = 175
        Me.cboGender.UseSelectable = True
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(174, 31)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(79, 19)
        Me.lblFirst.TabIndex = 176
        Me.lblFirst.Text = "FIRSTNAME"
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Location = New System.Drawing.Point(284, 31)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(27, 19)
        Me.lblMiddle.TabIndex = 177
        Me.lblMiddle.Text = "M.I"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(342, 31)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(77, 19)
        Me.lblLastName.TabIndex = 178
        Me.lblLastName.Text = "LASTNAME"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(172, 91)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel5.TabIndex = 179
        Me.MetroLabel5.Text = "MOBILE NUMBER"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(342, 91)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel6.TabIndex = 180
        Me.MetroLabel6.Text = "GENDER"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(174, 201)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel7.TabIndex = 181
        Me.MetroLabel7.Text = "DATE OF BIRTH"
        '
        'lblNameRemind
        '
        Me.lblNameRemind.AutoSize = True
        Me.lblNameRemind.BackColor = System.Drawing.Color.White
        Me.lblNameRemind.ForeColor = System.Drawing.Color.DimGray
        Me.lblNameRemind.Location = New System.Drawing.Point(174, 9)
        Me.lblNameRemind.Name = "lblNameRemind"
        Me.lblNameRemind.Size = New System.Drawing.Size(0, 0)
        Me.lblNameRemind.TabIndex = 182
        Me.lblNameRemind.UseCustomForeColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Menu
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(700, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.DisplayIcon = True
        Me.txtSearch.IconRight = True
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(30, 262)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "SEARCH BY NAME"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(734, 35)
        Me.txtSearch.TabIndex = 158
        Me.txtSearch.UseCustomBackColor = True
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "SEARCH BY NAME"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pboxBirth
        '
        Me.pboxBirth.Image = Global.Food_Quest_App.My.Resources.Resources.white_circle1
        Me.pboxBirth.Location = New System.Drawing.Point(280, 201)
        Me.pboxBirth.Name = "pboxBirth"
        Me.pboxBirth.Size = New System.Drawing.Size(27, 18)
        Me.pboxBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxBirth.TabIndex = 189
        Me.pboxBirth.TabStop = False
        '
        'pboxGender
        '
        Me.pboxGender.Image = Global.Food_Quest_App.My.Resources.Resources.white_circle1
        Me.pboxGender.Location = New System.Drawing.Point(407, 94)
        Me.pboxGender.Name = "pboxGender"
        Me.pboxGender.Size = New System.Drawing.Size(27, 18)
        Me.pboxGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxGender.TabIndex = 188
        Me.pboxGender.TabStop = False
        '
        'pboxEmail
        '
        Me.pboxEmail.Image = Global.Food_Quest_App.My.Resources.Resources.white_circle1
        Me.pboxEmail.Location = New System.Drawing.Point(219, 144)
        Me.pboxEmail.Name = "pboxEmail"
        Me.pboxEmail.Size = New System.Drawing.Size(27, 18)
        Me.pboxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxEmail.TabIndex = 187
        Me.pboxEmail.TabStop = False
        '
        'pboxLastName
        '
        Me.pboxLastName.Image = Global.Food_Quest_App.My.Resources.Resources.white_circle1
        Me.pboxLastName.Location = New System.Drawing.Point(417, 33)
        Me.pboxLastName.Name = "pboxLastName"
        Me.pboxLastName.Size = New System.Drawing.Size(27, 18)
        Me.pboxLastName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxLastName.TabIndex = 186
        Me.pboxLastName.TabStop = False
        '
        'pboxMiddle
        '
        Me.pboxMiddle.Image = Global.Food_Quest_App.My.Resources.Resources.white_circle1
        Me.pboxMiddle.Location = New System.Drawing.Point(309, 33)
        Me.pboxMiddle.Name = "pboxMiddle"
        Me.pboxMiddle.Size = New System.Drawing.Size(27, 18)
        Me.pboxMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxMiddle.TabIndex = 185
        Me.pboxMiddle.TabStop = False
        '
        'pboxFirstName
        '
        Me.pboxFirstName.Image = Global.Food_Quest_App.My.Resources.Resources.white_circle1
        Me.pboxFirstName.Location = New System.Drawing.Point(251, 33)
        Me.pboxFirstName.Name = "pboxFirstName"
        Me.pboxFirstName.Size = New System.Drawing.Size(27, 18)
        Me.pboxFirstName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxFirstName.TabIndex = 184
        Me.pboxFirstName.TabStop = False
        '
        'pboxMobile
        '
        Me.pboxMobile.Image = Global.Food_Quest_App.My.Resources.Resources.white_circle1
        Me.pboxMobile.Location = New System.Drawing.Point(284, 94)
        Me.pboxMobile.Name = "pboxMobile"
        Me.pboxMobile.Size = New System.Drawing.Size(27, 18)
        Me.pboxMobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxMobile.TabIndex = 183
        Me.pboxMobile.TabStop = False
        '
        'TxtUsertype
        '
        Me.TxtUsertype.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.TxtUsertype.CustomButton.Image = Nothing
        Me.TxtUsertype.CustomButton.Location = New System.Drawing.Point(99, 2)
        Me.TxtUsertype.CustomButton.Name = ""
        Me.TxtUsertype.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TxtUsertype.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtUsertype.CustomButton.TabIndex = 1
        Me.TxtUsertype.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtUsertype.CustomButton.UseSelectable = True
        Me.TxtUsertype.CustomButton.Visible = False
        Me.TxtUsertype.DisplayIcon = True
        Me.TxtUsertype.ForeColor = System.Drawing.Color.Gray
        Me.TxtUsertype.Icon = Global.Food_Quest_App.My.Resources.Resources.cashier2
        Me.TxtUsertype.IconRight = True
        Me.TxtUsertype.Lines = New String() {"CASHIER"}
        Me.TxtUsertype.Location = New System.Drawing.Point(637, 58)
        Me.TxtUsertype.MaxLength = 32767
        Me.TxtUsertype.Name = "TxtUsertype"
        Me.TxtUsertype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsertype.PromptText = "USER TYPE"
        Me.TxtUsertype.ReadOnly = True
        Me.TxtUsertype.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtUsertype.SelectedText = ""
        Me.TxtUsertype.SelectionLength = 0
        Me.TxtUsertype.SelectionStart = 0
        Me.TxtUsertype.ShortcutsEnabled = True
        Me.TxtUsertype.Size = New System.Drawing.Size(127, 30)
        Me.TxtUsertype.TabIndex = 159
        Me.TxtUsertype.Text = "CASHIER"
        Me.TxtUsertype.UseCustomBackColor = True
        Me.TxtUsertype.UseCustomForeColor = True
        Me.TxtUsertype.UseSelectable = True
        Me.TxtUsertype.WaterMark = "USER TYPE"
        Me.TxtUsertype.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtUsertype.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pboxProfile
        '
        Me.pboxProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxProfile.Image = Global.Food_Quest_App.My.Resources.Resources.cashier1
        Me.pboxProfile.Location = New System.Drawing.Point(781, 58)
        Me.pboxProfile.Name = "pboxProfile"
        Me.pboxProfile.Size = New System.Drawing.Size(187, 170)
        Me.pboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxProfile.TabIndex = 155
        Me.pboxProfile.TabStop = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtID.CustomButton.Image = Nothing
        Me.txtID.CustomButton.Location = New System.Drawing.Point(104, 2)
        Me.txtID.CustomButton.Name = ""
        Me.txtID.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtID.CustomButton.TabIndex = 1
        Me.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtID.CustomButton.UseSelectable = True
        Me.txtID.CustomButton.Visible = False
        Me.txtID.DisplayIcon = True
        Me.txtID.Icon = Global.Food_Quest_App.My.Resources.Resources.id1
        Me.txtID.IconRight = True
        Me.txtID.Lines = New String(-1) {}
        Me.txtID.Location = New System.Drawing.Point(496, 58)
        Me.txtID.MaxLength = 32767
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PromptText = "CASHIER ID"
        Me.txtID.ReadOnly = True
        Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtID.SelectedText = ""
        Me.txtID.SelectionLength = 0
        Me.txtID.SelectionStart = 0
        Me.txtID.ShortcutsEnabled = True
        Me.txtID.Size = New System.Drawing.Size(132, 30)
        Me.txtID.TabIndex = 140
        Me.txtID.UseCustomBackColor = True
        Me.txtID.UseSelectable = True
        Me.txtID.WaterMark = "CASHIER ID"
        Me.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(148, 2)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.DisplayIcon = True
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtPassword.Icon = Global.Food_Quest_App.My.Resources.Resources.passwprd
        Me.txtPassword.IconRight = True
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(588, 220)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(176, 30)
        Me.txtPassword.TabIndex = 135
        Me.txtPassword.UseCustomBackColor = True
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(239, 2)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.DisplayIcon = True
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Icon = Global.Food_Quest_App.My.Resources.Resources.username
        Me.txtUsername.IconRight = True
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(497, 145)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PromptText = "USERNAME"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.ShowClearButton = True
        Me.txtUsername.Size = New System.Drawing.Size(267, 30)
        Me.txtUsername.TabIndex = 134
        Me.txtUsername.UseCustomBackColor = True
        Me.txtUsername.UseCustomForeColor = True
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMark = "USERNAME"
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'employees_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(992, 676)
        Me.Controls.Add(Me.pboxBirth)
        Me.Controls.Add(Me.pboxGender)
        Me.Controls.Add(Me.pboxEmail)
        Me.Controls.Add(Me.pboxLastName)
        Me.Controls.Add(Me.pboxMiddle)
        Me.Controls.Add(Me.pboxFirstName)
        Me.Controls.Add(Me.pboxMobile)
        Me.Controls.Add(Me.lblNameRemind)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.dtDOB)
        Me.Controls.Add(Me.mtMobile)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMI)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnPass)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.TxtUsertype)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pboxProfile)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAddCashier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employees_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "employees_details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxBirth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxMiddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxMobile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAddCashier As Button
    Friend WithEvents pboxProfile As PictureBox
    Friend WithEvents lblID As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TxtUsertype As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnPass As MetroFramework.Controls.MetroButton
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEmail As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMI As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtMobile As MaskedTextBox
    Friend WithEvents dtDOB As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cboGender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblFirst As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMiddle As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLastName As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNameRemind As MetroFramework.Controls.MetroLabel
    Friend WithEvents pboxMobile As PictureBox
    Friend WithEvents pboxFirstName As PictureBox
    Friend WithEvents pboxMiddle As PictureBox
    Friend WithEvents pboxLastName As PictureBox
    Friend WithEvents pboxEmail As PictureBox
    Friend WithEvents pboxGender As PictureBox
    Friend WithEvents pboxBirth As PictureBox
End Class
