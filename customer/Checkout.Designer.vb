<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Checkout
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.rdDeliver = New MetroFramework.Controls.MetroRadioButton()
        Me.rdPickup = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.lblShippingMethod = New MetroFramework.Controls.MetroLabel()
        Me.lblShippingDate = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNameAndMobile = New MetroFramework.Controls.MetroLabel()
        Me.txtAddress = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskPostalCodes = New System.Windows.Forms.MaskedTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.cboRe = New MetroFramework.Controls.MetroComboBox()
        Me.txtCity = New MetroFramework.Controls.MetroTextBox()
        Me.cboRegion = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblMobileName = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.maskCvc = New System.Windows.Forms.MaskedTextBox()
        Me.MaskCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.cboYear = New MetroFramework.Controls.MetroComboBox()
        Me.cboMonth = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.lblOrderTotal = New MetroFramework.Controls.MetroLabel()
        Me.lblShipping = New MetroFramework.Controls.MetroLabel()
        Me.lblSubtotal = New MetroFramework.Controls.MetroLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btnCheckout = New MetroFramework.Controls.MetroButton()
        Me.lblOrderRef = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel1.Location = New System.Drawing.Point(80, 31)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Deliver or Pickup?"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'rdDeliver
        '
        Me.rdDeliver.AutoSize = True
        Me.rdDeliver.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rdDeliver.Location = New System.Drawing.Point(121, 158)
        Me.rdDeliver.Name = "rdDeliver"
        Me.rdDeliver.Size = New System.Drawing.Size(67, 19)
        Me.rdDeliver.TabIndex = 1
        Me.rdDeliver.Text = "Deliver"
        Me.rdDeliver.UseSelectable = True
        '
        'rdPickup
        '
        Me.rdPickup.AutoSize = True
        Me.rdPickup.Checked = True
        Me.rdPickup.Location = New System.Drawing.Point(121, 105)
        Me.rdPickup.Name = "rdPickup"
        Me.rdPickup.Size = New System.Drawing.Size(59, 15)
        Me.rdPickup.TabIndex = 2
        Me.rdPickup.TabStop = True
        Me.rdPickup.Text = "Pickup"
        Me.rdPickup.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.lblShippingMethod)
        Me.MetroPanel1.Controls.Add(Me.lblShippingDate)
        Me.MetroPanel1.Controls.Add(Me.PictureBox2)
        Me.MetroPanel1.Controls.Add(Me.PictureBox1)
        Me.MetroPanel1.Controls.Add(Me.rdDeliver)
        Me.MetroPanel1.Controls.Add(Me.rdPickup)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(12, 29)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(275, 251)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.UseCustomForeColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'lblShippingMethod
        '
        Me.lblShippingMethod.AutoSize = True
        Me.lblShippingMethod.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblShippingMethod.Location = New System.Drawing.Point(17, 206)
        Me.lblShippingMethod.Name = "lblShippingMethod"
        Me.lblShippingMethod.Size = New System.Drawing.Size(242, 19)
        Me.lblShippingMethod.TabIndex = 7
        Me.lblShippingMethod.Text = "Shipping method(Standard) - ₱  30.00"
        '
        'lblShippingDate
        '
        Me.lblShippingDate.AutoSize = True
        Me.lblShippingDate.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblShippingDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblShippingDate.Location = New System.Drawing.Point(17, 225)
        Me.lblShippingDate.Name = "lblShippingDate"
        Me.lblShippingDate.Size = New System.Drawing.Size(30, 15)
        Me.lblShippingDate.TabIndex = 6
        Me.lblShippingDate.Text = "date"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Food_Quest_App.My.Resources.Resources.pickup
        Me.PictureBox2.Location = New System.Drawing.Point(66, 85)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.deliver
        Me.PictureBox1.Location = New System.Drawing.Point(66, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 10)
        Me.Panel1.TabIndex = 4
        '
        'lblNameAndMobile
        '
        Me.lblNameAndMobile.AutoSize = True
        Me.lblNameAndMobile.BackColor = System.Drawing.Color.Transparent
        Me.lblNameAndMobile.Location = New System.Drawing.Point(71, 49)
        Me.lblNameAndMobile.Name = "lblNameAndMobile"
        Me.lblNameAndMobile.Size = New System.Drawing.Size(110, 19)
        Me.lblNameAndMobile.TabIndex = 5
        Me.lblNameAndMobile.Text = "NameAndMobile"
        Me.lblNameAndMobile.UseCustomBackColor = True
        '
        'txtAddress
        '
        '
        '
        '
        Me.txtAddress.CustomButton.Image = Nothing
        Me.txtAddress.CustomButton.Location = New System.Drawing.Point(281, 1)
        Me.txtAddress.CustomButton.Name = ""
        Me.txtAddress.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress.CustomButton.TabIndex = 1
        Me.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress.CustomButton.UseSelectable = True
        Me.txtAddress.CustomButton.Visible = False
        Me.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAddress.Lines = New String(-1) {}
        Me.txtAddress.Location = New System.Drawing.Point(72, 94)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PromptText = "Enter your address"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(315, 35)
        Me.txtAddress.TabIndex = 9
        Me.txtAddress.UseSelectable = True
        Me.txtAddress.WaterMark = "Enter your address"
        Me.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroLabel17)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel15)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel14)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel16)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel13)
        Me.MetroPanel2.Controls.Add(Me.MaskedTextBox1)
        Me.MetroPanel2.Controls.Add(Me.MaskPostalCodes)
        Me.MetroPanel2.Controls.Add(Me.MetroTextBox2)
        Me.MetroPanel2.Controls.Add(Me.cboRe)
        Me.MetroPanel2.Controls.Add(Me.txtCity)
        Me.MetroPanel2.Controls.Add(Me.cboRegion)
        Me.MetroPanel2.Controls.Add(Me.MetroTextBox1)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Controls.Add(Me.lblMobileName)
        Me.MetroPanel2.Controls.Add(Me.txtAddress)
        Me.MetroPanel2.Controls.Add(Me.lblNameAndMobile)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(293, 29)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(484, 251)
        Me.MetroPanel2.TabIndex = 10
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel17.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel17.Location = New System.Drawing.Point(73, 76)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(110, 15)
        Me.MetroLabel17.TabIndex = 24
        Me.MetroLabel17.Text = "Enter your address"
        Me.MetroLabel17.UseCustomBackColor = True
        Me.MetroLabel17.UseCustomForeColor = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel15.Location = New System.Drawing.Point(73, 76)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(110, 15)
        Me.MetroLabel15.TabIndex = 24
        Me.MetroLabel15.Text = "Enter your address"
        Me.MetroLabel15.UseCustomBackColor = True
        Me.MetroLabel15.UseCustomForeColor = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel14.Location = New System.Drawing.Point(72, 137)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(28, 15)
        Me.MetroLabel14.TabIndex = 23
        Me.MetroLabel14.Text = "City"
        Me.MetroLabel14.UseCustomBackColor = True
        Me.MetroLabel14.UseCustomForeColor = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel16.Location = New System.Drawing.Point(307, 195)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(70, 15)
        Me.MetroLabel16.TabIndex = 22
        Me.MetroLabel16.Text = "Postal code"
        Me.MetroLabel16.UseCustomBackColor = True
        Me.MetroLabel16.UseCustomForeColor = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel13.Location = New System.Drawing.Point(307, 195)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(70, 15)
        Me.MetroLabel13.TabIndex = 22
        Me.MetroLabel13.Text = "Postal code"
        Me.MetroLabel13.UseCustomBackColor = True
        Me.MetroLabel13.UseCustomForeColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(307, 213)
        Me.MaskedTextBox1.Mask = "0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(80, 26)
        Me.MaskedTextBox1.TabIndex = 20
        '
        'MaskPostalCodes
        '
        Me.MaskPostalCodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskPostalCodes.Location = New System.Drawing.Point(307, 213)
        Me.MaskPostalCodes.Mask = "0000"
        Me.MaskPostalCodes.Name = "MaskPostalCodes"
        Me.MaskPostalCodes.Size = New System.Drawing.Size(80, 26)
        Me.MaskPostalCodes.TabIndex = 20
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(281, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(73, 157)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.PromptText = "City"
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(315, 35)
        Me.MetroTextBox2.TabIndex = 12
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMark = "City"
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboRe
        '
        Me.cboRe.DropDownHeight = 150
        Me.cboRe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRe.FormattingEnabled = True
        Me.cboRe.IntegralHeight = False
        Me.cboRe.ItemHeight = 23
        Me.cboRe.Items.AddRange(New Object() {"Region", "Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique", "Apayao", "Aurora", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet", "Biliran", "Bohol", "Bukidnon", "Bulacan", "Cagayan", "Camarines Norte", "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu", "Compostela Valley", "Cotabatto", "Davao Occidental", "Davao Oriental", "Davao del Norte", "Davao del Sur", "Dinagat Islands", "Eastern Samar", "Guimaras", "Ifugao", "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna", "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindano", "Marinduque", "Masbate", "Metro Manila", "Misamis Occidental", "Misamis Oriental", "Mountain", "Negros Occidental", "Negros Oriental", "Nothern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro", "Oriental Mindro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal", "Romblon", "Samar", "Sarangani", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte", "Sultan Kuldarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", "Zambales", "Zamboanga Sibugay", "Zamboanga del Norte", "Zamboanga del Sur"})
        Me.cboRe.Location = New System.Drawing.Point(73, 210)
        Me.cboRe.Name = "cboRe"
        Me.cboRe.PromptText = "Region"
        Me.cboRe.Size = New System.Drawing.Size(228, 29)
        Me.cboRe.TabIndex = 11
        Me.cboRe.UseSelectable = True
        '
        'txtCity
        '
        '
        '
        '
        Me.txtCity.CustomButton.Image = Nothing
        Me.txtCity.CustomButton.Location = New System.Drawing.Point(281, 1)
        Me.txtCity.CustomButton.Name = ""
        Me.txtCity.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCity.CustomButton.TabIndex = 1
        Me.txtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCity.CustomButton.UseSelectable = True
        Me.txtCity.CustomButton.Visible = False
        Me.txtCity.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCity.Lines = New String(-1) {}
        Me.txtCity.Location = New System.Drawing.Point(73, 157)
        Me.txtCity.MaxLength = 32767
        Me.txtCity.Name = "txtCity"
        Me.txtCity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCity.PromptText = "City"
        Me.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCity.SelectedText = ""
        Me.txtCity.SelectionLength = 0
        Me.txtCity.SelectionStart = 0
        Me.txtCity.ShortcutsEnabled = True
        Me.txtCity.Size = New System.Drawing.Size(315, 35)
        Me.txtCity.TabIndex = 12
        Me.txtCity.UseSelectable = True
        Me.txtCity.WaterMark = "City"
        Me.txtCity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboRegion
        '
        Me.cboRegion.DropDownHeight = 150
        Me.cboRegion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRegion.FormattingEnabled = True
        Me.cboRegion.IntegralHeight = False
        Me.cboRegion.ItemHeight = 23
        Me.cboRegion.Items.AddRange(New Object() {"Region", "Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique", "Apayao", "Aurora", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet", "Biliran", "Bohol", "Bukidnon", "Bulacan", "Cagayan", "Camarines Norte", "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu", "Compostela Valley", "Cotabatto", "Davao Occidental", "Davao Oriental", "Davao del Norte", "Davao del Sur", "Dinagat Islands", "Eastern Samar", "Guimaras", "Ifugao", "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna", "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindano", "Marinduque", "Masbate", "Metro Manila", "Misamis Occidental", "Misamis Oriental", "Mountain", "Negros Occidental", "Negros Oriental", "Nothern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro", "Oriental Mindro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal", "Romblon", "Samar", "Sarangani", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte", "Sultan Kuldarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", "Zambales", "Zamboanga Sibugay", "Zamboanga del Norte", "Zamboanga del Sur"})
        Me.cboRegion.Location = New System.Drawing.Point(73, 210)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.PromptText = "Region"
        Me.cboRegion.Size = New System.Drawing.Size(228, 29)
        Me.cboRegion.TabIndex = 11
        Me.cboRegion.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(281, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(72, 94)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.PromptText = "Enter your address"
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(315, 35)
        Me.MetroTextBox1.TabIndex = 9
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "Enter your address"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel2.Location = New System.Drawing.Point(153, 18)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(128, 19)
        Me.MetroLabel2.TabIndex = 10
        Me.MetroLabel2.Text = "Delivery Information"
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'lblMobileName
        '
        Me.lblMobileName.AutoSize = True
        Me.lblMobileName.BackColor = System.Drawing.Color.Transparent
        Me.lblMobileName.Location = New System.Drawing.Point(71, 49)
        Me.lblMobileName.Name = "lblMobileName"
        Me.lblMobileName.Size = New System.Drawing.Size(110, 19)
        Me.lblMobileName.TabIndex = 5
        Me.lblMobileName.Text = "NameAndMobile"
        Me.lblMobileName.UseCustomBackColor = True
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.MetroLabel12)
        Me.MetroPanel3.Controls.Add(Me.maskCvc)
        Me.MetroPanel3.Controls.Add(Me.MaskCardNumber)
        Me.MetroPanel3.Controls.Add(Me.cboYear)
        Me.MetroPanel3.Controls.Add(Me.cboMonth)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(293, 289)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(484, 148)
        Me.MetroPanel3.TabIndex = 11
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel12.Location = New System.Drawing.Point(358, 64)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(29, 15)
        Me.MetroLabel12.TabIndex = 21
        Me.MetroLabel12.Text = "CVC"
        Me.MetroLabel12.UseCustomBackColor = True
        Me.MetroLabel12.UseCustomForeColor = True
        '
        'maskCvc
        '
        Me.maskCvc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskCvc.Location = New System.Drawing.Point(358, 82)
        Me.maskCvc.Mask = "0000"
        Me.maskCvc.Name = "maskCvc"
        Me.maskCvc.Size = New System.Drawing.Size(49, 26)
        Me.maskCvc.TabIndex = 21
        '
        'MaskCardNumber
        '
        Me.MaskCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskCardNumber.Location = New System.Drawing.Point(22, 82)
        Me.MaskCardNumber.Mask = "0000 000000 00000"
        Me.MaskCardNumber.Name = "MaskCardNumber"
        Me.MaskCardNumber.Size = New System.Drawing.Size(179, 26)
        Me.MaskCardNumber.TabIndex = 19
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.ItemHeight = 23
        Me.cboYear.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
        Me.cboYear.Location = New System.Drawing.Point(291, 82)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.PromptText = "YY"
        Me.cboYear.Size = New System.Drawing.Size(61, 29)
        Me.cboYear.TabIndex = 17
        Me.cboYear.UseSelectable = True
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.ItemHeight = 23
        Me.cboMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "9", "9", "10", "11", "12"})
        Me.cboMonth.Location = New System.Drawing.Point(221, 82)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.PromptText = "MM"
        Me.cboMonth.Size = New System.Drawing.Size(64, 29)
        Me.cboMonth.TabIndex = 16
        Me.cboMonth.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel5.Location = New System.Drawing.Point(22, 64)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(79, 15)
        Me.MetroLabel5.TabIndex = 14
        Me.MetroLabel5.Text = "Card number"
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel4.Location = New System.Drawing.Point(150, 43)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(129, 15)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "( Credit or debit card )"
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel3.Location = New System.Drawing.Point(161, 24)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Payment Method"
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Food_Quest_App.My.Resources.Resources.mastercard
        Me.PictureBox6.Location = New System.Drawing.Point(649, 455)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Food_Quest_App.My.Resources.Resources.amex
        Me.PictureBox5.Location = New System.Drawing.Point(579, 455)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 29)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Food_Quest_App.My.Resources.Resources.bpi
        Me.PictureBox4.Location = New System.Drawing.Point(491, 455)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(41, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Food_Quest_App.My.Resources.Resources.bdo
        Me.PictureBox3.Location = New System.Drawing.Point(423, 457)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(420, 499)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Payment -  all transactions are secured and encrypted"
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel4.Controls.Add(Me.lblOrderTotal)
        Me.MetroPanel4.Controls.Add(Me.lblShipping)
        Me.MetroPanel4.Controls.Add(Me.lblSubtotal)
        Me.MetroPanel4.Controls.Add(Me.Panel2)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(15, 289)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(272, 274)
        Me.MetroPanel4.TabIndex = 17
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel11.Location = New System.Drawing.Point(148, 222)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(17, 19)
        Me.MetroLabel11.TabIndex = 21
        Me.MetroLabel11.Text = "₱"
        Me.MetroLabel11.UseCustomBackColor = True
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.AutoSize = True
        Me.lblOrderTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderTotal.Location = New System.Drawing.Point(175, 222)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(33, 19)
        Me.lblOrderTotal.TabIndex = 20
        Me.lblOrderTotal.Text = "0.00"
        Me.lblOrderTotal.UseCustomBackColor = True
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.BackColor = System.Drawing.Color.Transparent
        Me.lblShipping.Location = New System.Drawing.Point(163, 117)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(45, 19)
        Me.lblShipping.TabIndex = 19
        Me.lblShipping.Text = "₱ 0.00"
        Me.lblShipping.UseCustomBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtotal.Location = New System.Drawing.Point(163, 79)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(45, 19)
        Me.lblSubtotal.TabIndex = 17
        Me.lblSubtotal.Text = "₱ 0.00"
        Me.lblSubtotal.UseCustomBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(3, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(266, 10)
        Me.Panel2.TabIndex = 16
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.Location = New System.Drawing.Point(54, 222)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel10.TabIndex = 15
        Me.MetroLabel10.Text = "Order Total"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel8.Location = New System.Drawing.Point(54, 117)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel8.TabIndex = 13
        Me.MetroLabel8.Text = "Shipping fee:"
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.Location = New System.Drawing.Point(54, 79)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel7.TabIndex = 12
        Me.MetroLabel7.Text = "Cart Subtotal:"
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel6.Location = New System.Drawing.Point(87, 23)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel6.TabIndex = 11
        Me.MetroLabel6.Text = "Order summary"
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCheckout.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCheckout.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(15, 569)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(272, 48)
        Me.btnCheckout.TabIndex = 18
        Me.btnCheckout.Text = "CHECKOUT NOW"
        Me.btnCheckout.UseCustomBackColor = True
        Me.btnCheckout.UseCustomForeColor = True
        Me.btnCheckout.UseSelectable = True
        '
        'lblOrderRef
        '
        Me.lblOrderRef.AutoSize = True
        Me.lblOrderRef.Location = New System.Drawing.Point(639, 528)
        Me.lblOrderRef.Name = "lblOrderRef"
        Me.lblOrderRef.Size = New System.Drawing.Size(0, 13)
        Me.lblOrderRef.TabIndex = 21
        Me.lblOrderRef.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(312, 569)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 22
        Me.lblDate.Text = "Label2"
        Me.lblDate.Visible = False
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroButton1.ForeColor = System.Drawing.Color.White
        Me.MetroButton1.Location = New System.Drawing.Point(667, 584)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(110, 33)
        Me.MetroButton1.TabIndex = 23
        Me.MetroButton1.Text = "Home"
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 645)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblOrderRef)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.MetroPanel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents rdDeliver As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rdPickup As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNameAndMobile As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboRegion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtCity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboMonth As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MaskCardNumber As MaskedTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSubtotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblShipping As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblShippingDate As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblShippingMethod As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOrderTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCheckout As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MaskPostalCodes As MaskedTextBox
    Friend WithEvents maskCvc As MaskedTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOrderRef As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboRe As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblMobileName As MetroFramework.Controls.MetroLabel
End Class
