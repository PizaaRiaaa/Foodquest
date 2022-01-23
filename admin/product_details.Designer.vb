<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class product_details
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblStocks = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.cboUnit = New MetroFramework.Controls.MetroComboBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnBarcode = New MetroFramework.Controls.MetroButton()
        Me.cboType = New MetroFramework.Controls.MetroComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.txtID = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrice = New MetroFramework.Controls.MetroTextBox()
        Me.txtWeight = New MetroFramework.Controls.MetroTextBox()
        Me.txtBarcode = New MetroFramework.Controls.MetroTextBox()
        Me.txtStocks = New MetroFramework.Controls.MetroTextBox()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.pbox = New System.Windows.Forms.PictureBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.Location = New System.Drawing.Point(23, 300)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(948, 376)
        Me.DataGridView2.TabIndex = 92
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(23, 29)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 45)
        Me.btnReset.TabIndex = 91
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblStocks
        '
        Me.lblStocks.AutoSize = True
        Me.lblStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStocks.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblStocks.Location = New System.Drawing.Point(460, 128)
        Me.lblStocks.Name = "lblStocks"
        Me.lblStocks.Size = New System.Drawing.Size(0, 15)
        Me.lblStocks.TabIndex = 90
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblPrice.Location = New System.Drawing.Point(466, 69)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 15)
        Me.lblPrice.TabIndex = 89
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblWeight.Location = New System.Drawing.Point(466, 13)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(0, 15)
        Me.lblWeight.TabIndex = 87
        '
        'cboUnit
        '
        Me.cboUnit.BackColor = System.Drawing.Color.White
        Me.cboUnit.DisplayMember = "0"
        Me.cboUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboUnit.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.IntegralHeight = False
        Me.cboUnit.ItemHeight = 23
        Me.cboUnit.Items.AddRange(New Object() {"oz", "g", "kg", "ml", "L", "pcs"})
        Me.cboUnit.Location = New System.Drawing.Point(628, 29)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.PromptText = "Unit"
        Me.cboUnit.Size = New System.Drawing.Size(132, 29)
        Me.cboUnit.TabIndex = 86
        Me.cboUnit.UseCustomBackColor = True
        Me.cboUnit.UseCustomForeColor = True
        Me.cboUnit.UseSelectable = True
        Me.cboUnit.ValueMember = "0"
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(23, 82)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(110, 45)
        Me.btnAddItem.TabIndex = 80
        Me.btnAddItem.Text = "ADD ITEM"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnBarcode
        '
        Me.btnBarcode.BackColor = System.Drawing.Color.Black
        Me.btnBarcode.ForeColor = System.Drawing.Color.White
        Me.btnBarcode.Location = New System.Drawing.Point(158, 187)
        Me.btnBarcode.Name = "btnBarcode"
        Me.btnBarcode.Size = New System.Drawing.Size(74, 42)
        Me.btnBarcode.TabIndex = 79
        Me.btnBarcode.Text = "barcode"
        Me.btnBarcode.UseCustomBackColor = True
        Me.btnBarcode.UseCustomForeColor = True
        Me.btnBarcode.UseSelectable = True
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.White
        Me.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboType.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboType.FormattingEnabled = True
        Me.cboType.ItemHeight = 23
        Me.cboType.Items.AddRange(New Object() {"VEGETABLES", "FRUITS", "MEATS", "SEAFOODS", "DAIRY(MILK / EGGS)", "GRAINS", "CONDIMENTS", "COOKING OILS", "HERBS", "SPICES"})
        Me.cboType.Location = New System.Drawing.Point(463, 200)
        Me.cboType.Name = "cboType"
        Me.cboType.PromptText = "CATEGORY"
        Me.cboType.Size = New System.Drawing.Size(297, 29)
        Me.cboType.TabIndex = 78
        Me.cboType.UseCustomBackColor = True
        Me.cboType.UseCustomForeColor = True
        Me.cboType.UseSelectable = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblName.Location = New System.Drawing.Point(155, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 15)
        Me.lblName.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(779, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 18)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "+ add picture for the item"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(23, 184)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 45)
        Me.btnUpdate.TabIndex = 93
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(23, 133)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 45)
        Me.btnDelete.TabIndex = 94
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblID.Location = New System.Drawing.Point(361, 125)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 15)
        Me.lblID.TabIndex = 97
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Menu
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(606, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.DisplayIcon = True
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtSearch.IconRight = True
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(23, 259)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Search by name"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.ShowClearButton = True
        Me.txtSearch.Size = New System.Drawing.Size(640, 35)
        Me.txtSearch.TabIndex = 95
        Me.txtSearch.UseCustomBackColor = True
        Me.txtSearch.UseCustomForeColor = True
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search by name"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtID.CustomButton.Image = Nothing
        Me.txtID.CustomButton.Location = New System.Drawing.Point(271, 2)
        Me.txtID.CustomButton.Name = ""
        Me.txtID.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtID.CustomButton.TabIndex = 1
        Me.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtID.CustomButton.UseSelectable = True
        Me.txtID.CustomButton.Visible = False
        Me.txtID.DisplayIcon = True
        Me.txtID.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtID.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtID.Icon = Global.Food_Quest_App.My.Resources.Resources.id1
        Me.txtID.IconRight = True
        Me.txtID.Lines = New String(-1) {}
        Me.txtID.Location = New System.Drawing.Point(158, 146)
        Me.txtID.MaxLength = 32767
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PromptText = "ITEM ID"
        Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtID.SelectedText = ""
        Me.txtID.SelectionLength = 0
        Me.txtID.SelectionStart = 0
        Me.txtID.ShortcutsEnabled = True
        Me.txtID.ShowClearButton = True
        Me.txtID.Size = New System.Drawing.Size(299, 30)
        Me.txtID.TabIndex = 96
        Me.txtID.UseCustomBackColor = True
        Me.txtID.UseCustomForeColor = True
        Me.txtID.UseSelectable = True
        Me.txtID.WaterMark = "ITEM ID"
        Me.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.MenuBar
        '
        '
        '
        Me.txtPrice.CustomButton.Image = Nothing
        Me.txtPrice.CustomButton.Location = New System.Drawing.Point(263, 1)
        Me.txtPrice.CustomButton.Name = ""
        Me.txtPrice.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrice.CustomButton.TabIndex = 1
        Me.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrice.CustomButton.UseSelectable = True
        Me.txtPrice.CustomButton.Visible = False
        Me.txtPrice.DisplayIcon = True
        Me.txtPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPrice.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtPrice.Icon = Global.Food_Quest_App.My.Resources.Resources.price
        Me.txtPrice.IconRight = True
        Me.txtPrice.Lines = New String(-1) {}
        Me.txtPrice.Location = New System.Drawing.Point(463, 87)
        Me.txtPrice.MaxLength = 32767
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PromptText = "ITEM PRICE"
        Me.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.ShortcutsEnabled = True
        Me.txtPrice.ShowClearButton = True
        Me.txtPrice.Size = New System.Drawing.Size(297, 35)
        Me.txtPrice.TabIndex = 88
        Me.txtPrice.UseCustomForeColor = True
        Me.txtPrice.UseSelectable = True
        Me.txtPrice.WaterMark = "ITEM PRICE"
        Me.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.SystemColors.MenuBar
        '
        '
        '
        Me.txtWeight.CustomButton.Image = Nothing
        Me.txtWeight.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.txtWeight.CustomButton.Name = ""
        Me.txtWeight.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtWeight.CustomButton.TabIndex = 1
        Me.txtWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtWeight.CustomButton.UseSelectable = True
        Me.txtWeight.CustomButton.Visible = False
        Me.txtWeight.DisplayIcon = True
        Me.txtWeight.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtWeight.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtWeight.Icon = Global.Food_Quest_App.My.Resources.Resources.weight2
        Me.txtWeight.IconRight = True
        Me.txtWeight.Lines = New String(-1) {}
        Me.txtWeight.Location = New System.Drawing.Point(463, 29)
        Me.txtWeight.MaxLength = 32767
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWeight.PromptText = "WEIGHT or Qty"
        Me.txtWeight.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtWeight.SelectedText = ""
        Me.txtWeight.SelectionLength = 0
        Me.txtWeight.SelectionStart = 0
        Me.txtWeight.ShortcutsEnabled = True
        Me.txtWeight.ShowClearButton = True
        Me.txtWeight.Size = New System.Drawing.Size(164, 29)
        Me.txtWeight.TabIndex = 85
        Me.txtWeight.UseCustomForeColor = True
        Me.txtWeight.UseSelectable = True
        Me.txtWeight.WaterMark = "WEIGHT or Qty"
        Me.txtWeight.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtWeight.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.txtBarcode.CustomButton.Image = Nothing
        Me.txtBarcode.CustomButton.Location = New System.Drawing.Point(177, 2)
        Me.txtBarcode.CustomButton.Name = ""
        Me.txtBarcode.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBarcode.CustomButton.TabIndex = 1
        Me.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBarcode.CustomButton.UseSelectable = True
        Me.txtBarcode.CustomButton.Visible = False
        Me.txtBarcode.DisplayIcon = True
        Me.txtBarcode.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtBarcode.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtBarcode.Icon = Global.Food_Quest_App.My.Resources.Resources.barcode
        Me.txtBarcode.IconRight = True
        Me.txtBarcode.Lines = New String(-1) {}
        Me.txtBarcode.Location = New System.Drawing.Point(240, 187)
        Me.txtBarcode.MaxLength = 32767
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBarcode.SelectedText = ""
        Me.txtBarcode.SelectionLength = 0
        Me.txtBarcode.SelectionStart = 0
        Me.txtBarcode.ShortcutsEnabled = True
        Me.txtBarcode.ShowClearButton = True
        Me.txtBarcode.Size = New System.Drawing.Size(217, 42)
        Me.txtBarcode.TabIndex = 84
        Me.txtBarcode.UseCustomBackColor = True
        Me.txtBarcode.UseCustomForeColor = True
        Me.txtBarcode.UseSelectable = True
        Me.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBarcode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStocks
        '
        Me.txtStocks.BackColor = System.Drawing.SystemColors.MenuBar
        '
        '
        '
        Me.txtStocks.CustomButton.Image = Nothing
        Me.txtStocks.CustomButton.Location = New System.Drawing.Point(263, 1)
        Me.txtStocks.CustomButton.Name = ""
        Me.txtStocks.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtStocks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStocks.CustomButton.TabIndex = 1
        Me.txtStocks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStocks.CustomButton.UseSelectable = True
        Me.txtStocks.CustomButton.Visible = False
        Me.txtStocks.DisplayIcon = True
        Me.txtStocks.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtStocks.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtStocks.Icon = Global.Food_Quest_App.My.Resources.Resources.quantity
        Me.txtStocks.IconRight = True
        Me.txtStocks.Lines = New String(-1) {}
        Me.txtStocks.Location = New System.Drawing.Point(463, 146)
        Me.txtStocks.MaxLength = 32767
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStocks.PromptText = "ADD STOCKS"
        Me.txtStocks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStocks.SelectedText = ""
        Me.txtStocks.SelectionLength = 0
        Me.txtStocks.SelectionStart = 0
        Me.txtStocks.ShortcutsEnabled = True
        Me.txtStocks.ShowClearButton = True
        Me.txtStocks.Size = New System.Drawing.Size(297, 35)
        Me.txtStocks.TabIndex = 83
        Me.txtStocks.UseCustomForeColor = True
        Me.txtStocks.UseSelectable = True
        Me.txtStocks.WaterMark = "ADD STOCKS"
        Me.txtStocks.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStocks.WaterMarkFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtName.CustomButton.Image = Nothing
        Me.txtName.CustomButton.Location = New System.Drawing.Point(207, 2)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(89, 89)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.DisplayIcon = True
        Me.txtName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtName.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtName.Icon = Global.Food_Quest_App.My.Resources.Resources.description1
        Me.txtName.IconRight = True
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(158, 29)
        Me.txtName.MaxLength = 32767
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PromptText = "ITEM NAME"
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.ShowClearButton = True
        Me.txtName.Size = New System.Drawing.Size(299, 94)
        Me.txtName.TabIndex = 82
        Me.txtName.UseCustomBackColor = True
        Me.txtName.UseCustomForeColor = True
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMark = "ITEM NAME"
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pbox
        '
        Me.pbox.BackColor = System.Drawing.Color.White
        Me.pbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbox.Image = Global.Food_Quest_App.My.Resources.Resources.product
        Me.pbox.Location = New System.Drawing.Point(772, 31)
        Me.pbox.Name = "pbox"
        Me.pbox.Size = New System.Drawing.Size(199, 177)
        Me.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox.TabIndex = 81
        Me.pbox.TabStop = False
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblUnit.Location = New System.Drawing.Point(627, 9)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(0, 15)
        Me.lblUnit.TabIndex = 98
        '
        'product_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(992, 676)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblStocks)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.cboUnit)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.txtStocks)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.pbox)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnBarcode)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.lblName)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "product_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "product_details"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnReset As Button
    Friend WithEvents lblStocks As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents cboUnit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtWeight As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBarcode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStocks As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pbox As PictureBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnBarcode As MetroFramework.Controls.MetroButton
    Friend WithEvents cboType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblUnit As Label
End Class
