<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customer_details
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
        Me.txtFirstName = New MetroFramework.Controls.MetroTextBox()
        Me.txtMiddle = New MetroFramework.Controls.MetroTextBox()
        Me.txtLastName = New MetroFramework.Controls.MetroTextBox()
        Me.txtGender = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmail = New MetroFramework.Controls.MetroLabel()
        Me.lblID = New MetroFramework.Controls.MetroLabel()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.lblFirst = New MetroFramework.Controls.MetroLabel()
        Me.lblMiddle = New MetroFramework.Controls.MetroLabel()
        Me.lblLastName = New MetroFramework.Controls.MetroLabel()
        Me.lblNumber = New MetroFramework.Controls.MetroLabel()
        Me.lblDOB = New MetroFramework.Controls.MetroLabel()
        Me.lblGender = New MetroFramework.Controls.MetroLabel()
        Me.MaskTxtMobile = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaskTxtBOD = New System.Windows.Forms.MaskedTextBox()
        Me.TxtUsertype = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.pboxProfile = New System.Windows.Forms.PictureBox()
        Me.txtID = New MetroFramework.Controls.MetroTextBox()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtFirstName.CustomButton.Image = Nothing
        Me.txtFirstName.CustomButton.Location = New System.Drawing.Point(276, 2)
        Me.txtFirstName.CustomButton.Name = ""
        Me.txtFirstName.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFirstName.CustomButton.TabIndex = 1
        Me.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFirstName.CustomButton.UseSelectable = True
        Me.txtFirstName.CustomButton.Visible = False
        Me.txtFirstName.DisplayIcon = True
        Me.txtFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtFirstName.IconRight = True
        Me.txtFirstName.Lines = New String(-1) {}
        Me.txtFirstName.Location = New System.Drawing.Point(658, 45)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PromptText = "FIRSTNAME"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.SelectionLength = 0
        Me.txtFirstName.SelectionStart = 0
        Me.txtFirstName.ShortcutsEnabled = True
        Me.txtFirstName.Size = New System.Drawing.Size(304, 30)
        Me.txtFirstName.TabIndex = 103
        Me.txtFirstName.UseCustomBackColor = True
        Me.txtFirstName.UseSelectable = True
        Me.txtFirstName.WaterMark = "FIRSTNAME"
        Me.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMiddle
        '
        Me.txtMiddle.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtMiddle.CustomButton.Image = Nothing
        Me.txtMiddle.CustomButton.Location = New System.Drawing.Point(64, 2)
        Me.txtMiddle.CustomButton.Name = ""
        Me.txtMiddle.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMiddle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMiddle.CustomButton.TabIndex = 1
        Me.txtMiddle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMiddle.CustomButton.UseSelectable = True
        Me.txtMiddle.CustomButton.Visible = False
        Me.txtMiddle.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMiddle.Lines = New String(-1) {}
        Me.txtMiddle.Location = New System.Drawing.Point(658, 107)
        Me.txtMiddle.MaxLength = 32767
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddle.PromptText = "MIDDLE"
        Me.txtMiddle.ReadOnly = True
        Me.txtMiddle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMiddle.SelectedText = ""
        Me.txtMiddle.SelectionLength = 0
        Me.txtMiddle.SelectionStart = 0
        Me.txtMiddle.ShortcutsEnabled = True
        Me.txtMiddle.Size = New System.Drawing.Size(92, 30)
        Me.txtMiddle.TabIndex = 104
        Me.txtMiddle.UseCustomBackColor = True
        Me.txtMiddle.UseSelectable = True
        Me.txtMiddle.WaterMark = "MIDDLE"
        Me.txtMiddle.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMiddle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtLastName.CustomButton.Image = Nothing
        Me.txtLastName.CustomButton.Location = New System.Drawing.Point(180, 2)
        Me.txtLastName.CustomButton.Name = ""
        Me.txtLastName.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastName.CustomButton.TabIndex = 1
        Me.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastName.CustomButton.UseSelectable = True
        Me.txtLastName.CustomButton.Visible = False
        Me.txtLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtLastName.Lines = New String(-1) {}
        Me.txtLastName.Location = New System.Drawing.Point(754, 107)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PromptText = "LASTNAME"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.ShortcutsEnabled = True
        Me.txtLastName.Size = New System.Drawing.Size(208, 30)
        Me.txtLastName.TabIndex = 105
        Me.txtLastName.UseCustomBackColor = True
        Me.txtLastName.UseSelectable = True
        Me.txtLastName.WaterMark = "LASTNAME"
        Me.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtGender.CustomButton.Image = Nothing
        Me.txtGender.CustomButton.Location = New System.Drawing.Point(70, 2)
        Me.txtGender.CustomButton.Name = ""
        Me.txtGender.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtGender.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGender.CustomButton.TabIndex = 1
        Me.txtGender.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGender.CustomButton.UseSelectable = True
        Me.txtGender.CustomButton.Visible = False
        Me.txtGender.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtGender.Lines = New String(-1) {}
        Me.txtGender.Location = New System.Drawing.Point(506, 204)
        Me.txtGender.MaxLength = 32767
        Me.txtGender.Name = "txtGender"
        Me.txtGender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGender.PromptText = "GENDER"
        Me.txtGender.ReadOnly = True
        Me.txtGender.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGender.SelectedText = ""
        Me.txtGender.SelectionLength = 0
        Me.txtGender.SelectionStart = 0
        Me.txtGender.ShortcutsEnabled = True
        Me.txtGender.Size = New System.Drawing.Size(98, 30)
        Me.txtGender.TabIndex = 108
        Me.txtGender.UseCustomBackColor = True
        Me.txtGender.UseSelectable = True
        Me.txtGender.WaterMark = "GENDER"
        Me.txtGender.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGender.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblEmail.Location = New System.Drawing.Point(658, 207)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 118
        Me.lblEmail.Text = "EMAIL"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblID.Location = New System.Drawing.Point(339, 48)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(79, 15)
        Me.lblID.TabIndex = 119
        Me.lblID.Text = "CUSTOMER ID"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblUsername.Location = New System.Drawing.Point(339, 110)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(67, 15)
        Me.lblUsername.TabIndex = 120
        Me.lblUsername.Text = "USERNAME"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(658, 226)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PromptText = "EMAIL"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(302, 30)
        Me.txtEmail.TabIndex = 113
        Me.txtEmail.UseCustomBackColor = True
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMark = "EMAIL"
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblFirst.Location = New System.Drawing.Point(658, 23)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(68, 15)
        Me.lblFirst.TabIndex = 122
        Me.lblFirst.Text = "FIRSTNAME"
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblMiddle.Location = New System.Drawing.Point(653, 85)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(47, 15)
        Me.lblMiddle.TabIndex = 123
        Me.lblMiddle.Text = "MIDDLE"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblLastName.Location = New System.Drawing.Point(738, 85)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(66, 15)
        Me.lblLastName.TabIndex = 124
        Me.lblLastName.Text = "LASTNAME"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblNumber.Location = New System.Drawing.Point(658, 154)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(97, 15)
        Me.lblNumber.TabIndex = 125
        Me.lblNumber.Text = "MOBILE NUMBER"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblDOB.Location = New System.Drawing.Point(339, 187)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(86, 15)
        Me.lblDOB.TabIndex = 126
        Me.lblDOB.Text = "DATE OF BIRTH"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblGender.Location = New System.Drawing.Point(506, 186)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(51, 15)
        Me.lblGender.TabIndex = 127
        Me.lblGender.Text = "GENDER"
        '
        'MaskTxtMobile
        '
        Me.MaskTxtMobile.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MaskTxtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskTxtMobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MaskTxtMobile.Location = New System.Drawing.Point(658, 172)
        Me.MaskTxtMobile.Mask = "9999-000-0000"
        Me.MaskTxtMobile.Name = "MaskTxtMobile"
        Me.MaskTxtMobile.ReadOnly = True
        Me.MaskTxtMobile.Size = New System.Drawing.Size(175, 29)
        Me.MaskTxtMobile.TabIndex = 128
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(14, 316)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.Size = New System.Drawing.Size(958, 353)
        Me.DataGridView1.TabIndex = 132
        '
        'MaskTxtBOD
        '
        Me.MaskTxtBOD.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MaskTxtBOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskTxtBOD.Location = New System.Drawing.Point(339, 204)
        Me.MaskTxtBOD.Mask = "0-0-0000"
        Me.MaskTxtBOD.Name = "MaskTxtBOD"
        Me.MaskTxtBOD.Size = New System.Drawing.Size(161, 26)
        Me.MaskTxtBOD.TabIndex = 133
        Me.MaskTxtBOD.ValidatingType = GetType(Integer)
        '
        'TxtUsertype
        '
        Me.TxtUsertype.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.TxtUsertype.CustomButton.Image = Nothing
        Me.TxtUsertype.CustomButton.Location = New System.Drawing.Point(95, 2)
        Me.TxtUsertype.CustomButton.Name = ""
        Me.TxtUsertype.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TxtUsertype.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtUsertype.CustomButton.TabIndex = 1
        Me.TxtUsertype.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtUsertype.CustomButton.UseSelectable = True
        Me.TxtUsertype.CustomButton.Visible = False
        Me.TxtUsertype.Lines = New String() {"CUSTOMER"}
        Me.TxtUsertype.Location = New System.Drawing.Point(839, 172)
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
        Me.TxtUsertype.Size = New System.Drawing.Size(123, 30)
        Me.TxtUsertype.TabIndex = 160
        Me.TxtUsertype.Text = "CUSTOMER"
        Me.TxtUsertype.UseCustomBackColor = True
        Me.TxtUsertype.UseSelectable = True
        Me.TxtUsertype.WaterMark = "USER TYPE"
        Me.TxtUsertype.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtUsertype.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.Location = New System.Drawing.Point(839, 154)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 15)
        Me.MetroLabel1.TabIndex = 161
        Me.MetroLabel1.Text = "USER TYPE"
        '
        'pboxProfile
        '
        Me.pboxProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxProfile.Image = Global.Food_Quest_App.My.Resources.Resources.customer
        Me.pboxProfile.Location = New System.Drawing.Point(28, 70)
        Me.pboxProfile.Name = "pboxProfile"
        Me.pboxProfile.Size = New System.Drawing.Size(204, 186)
        Me.pboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxProfile.TabIndex = 131
        Me.pboxProfile.TabStop = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtID.CustomButton.Image = Nothing
        Me.txtID.CustomButton.Location = New System.Drawing.Point(237, 2)
        Me.txtID.CustomButton.Name = ""
        Me.txtID.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtID.CustomButton.TabIndex = 1
        Me.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtID.CustomButton.UseSelectable = True
        Me.txtID.CustomButton.Visible = False
        Me.txtID.DisplayIcon = True
        Me.txtID.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtID.Icon = Global.Food_Quest_App.My.Resources.Resources.id1
        Me.txtID.IconRight = True
        Me.txtID.Lines = New String(-1) {}
        Me.txtID.Location = New System.Drawing.Point(339, 70)
        Me.txtID.MaxLength = 32767
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PromptText = "CUSTOMER ID"
        Me.txtID.ReadOnly = True
        Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtID.SelectedText = ""
        Me.txtID.SelectionLength = 0
        Me.txtID.SelectionStart = 0
        Me.txtID.ShortcutsEnabled = True
        Me.txtID.Size = New System.Drawing.Size(265, 30)
        Me.txtID.TabIndex = 112
        Me.txtID.UseCustomBackColor = True
        Me.txtID.UseSelectable = True
        Me.txtID.WaterMark = "CUSTOMER ID"
        Me.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Menu
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(924, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.DisplayIcon = True
        Me.txtSearch.Icon = Global.Food_Quest_App.My.Resources.Resources.search
        Me.txtSearch.IconRight = True
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(14, 275)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "SEARCH BY NAME"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(958, 35)
        Me.txtSearch.TabIndex = 111
        Me.txtSearch.UseCustomBackColor = True
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "SEARCH BY NAME"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(237, 2)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(25, 25)
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
        Me.txtUsername.Location = New System.Drawing.Point(339, 132)
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
        Me.txtUsername.Size = New System.Drawing.Size(265, 30)
        Me.txtUsername.TabIndex = 101
        Me.txtUsername.UseCustomBackColor = True
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMark = "USERNAME"
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'customer_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(992, 676)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.TxtUsertype)
        Me.Controls.Add(Me.MaskTxtBOD)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pboxProfile)
        Me.Controls.Add(Me.MaskTxtMobile)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customer_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "customer_details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMiddle As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGender As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEmail As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblID As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFirst As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMiddle As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLastName As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumber As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDOB As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblGender As MetroFramework.Controls.MetroLabel
    Friend WithEvents MaskTxtMobile As MaskedTextBox
    Friend WithEvents pboxProfile As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MaskTxtBOD As MaskedTextBox
    Friend WithEvents TxtUsertype As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
