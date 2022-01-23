<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cashier_form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgHistoryTrans = New System.Windows.Forms.DataGridView()
        Me.lblDate = New MetroFramework.Controls.MetroLabel()
        Me.lblTime = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.id = New MetroFramework.Controls.MetroLabel()
        Me.lblHideName = New System.Windows.Forms.Label()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.pboxProfile = New System.Windows.Forms.PictureBox()
        Me.lblCashierName = New MetroFramework.Controls.MetroLabel()
        Me.txtItemName = New MetroFramework.Controls.MetroTextBox()
        Me.txtOne = New MetroFramework.Controls.MetroButton()
        Me.txtTwo = New MetroFramework.Controls.MetroButton()
        Me.txtThree = New MetroFramework.Controls.MetroButton()
        Me.txtFour = New MetroFramework.Controls.MetroButton()
        Me.txtFive = New MetroFramework.Controls.MetroButton()
        Me.txtSix = New MetroFramework.Controls.MetroButton()
        Me.txtSeven = New MetroFramework.Controls.MetroButton()
        Me.txtEight = New MetroFramework.Controls.MetroButton()
        Me.txtNine = New MetroFramework.Controls.MetroButton()
        Me.txtZero = New MetroFramework.Controls.MetroButton()
        Me.txtThreeZero = New MetroFramework.Controls.MetroButton()
        Me.txtClearLastChar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pboxCash = New System.Windows.Forms.PictureBox()
        Me.pboxCard = New System.Windows.Forms.PictureBox()
        Me.txtBarcode = New MetroFramework.Controls.MetroTextBox()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New MetroFramework.Controls.MetroButton()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.iQty = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStock = New MetroFramework.Controls.MetroTextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnVoid = New MetroFramework.Controls.MetroButton()
        Me.btnSalesReport = New MetroFramework.Controls.MetroButton()
        Me.MetroButton25 = New MetroFramework.Controls.MetroButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.mtSC = New MetroFramework.Controls.MetroToggle()
        Me.mtPwd = New MetroFramework.Controls.MetroToggle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblAni = New System.Windows.Forms.Label()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lblItemQty = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lblTransNo = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.pboxItem = New System.Windows.Forms.PictureBox()
        Me.txtPrice = New MetroFramework.Controls.MetroTextBox()
        Me.txtFinalBarcode = New MetroFramework.Controls.MetroTextBox()
        Me.btnNew = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        CType(Me.dgHistoryTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pboxCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.iQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.pboxItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgHistoryTrans
        '
        Me.dgHistoryTrans.BackgroundColor = System.Drawing.Color.White
        Me.dgHistoryTrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgHistoryTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgHistoryTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgHistoryTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHistoryTrans.Location = New System.Drawing.Point(11, 176)
        Me.dgHistoryTrans.Name = "dgHistoryTrans"
        Me.dgHistoryTrans.Size = New System.Drawing.Size(288, 481)
        Me.dgHistoryTrans.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(54, 11)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(18, 19)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "..."
        Me.lblDate.UseCustomBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(193, 11)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(38, 19)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "TIME"
        Me.lblTime.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(11, 154)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(162, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "HISTORY TRANSACTIONS"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.lblHideName)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel15)
        Me.GroupBox1.Controls.Add(Me.pboxProfile)
        Me.GroupBox1.Controls.Add(Me.lblCashierName)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 116)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.ForeColor = System.Drawing.SystemColors.Control
        Me.id.Location = New System.Drawing.Point(193, 49)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(20, 19)
        Me.id.TabIndex = 25
        Me.id.Text = "id"
        Me.id.UseCustomBackColor = True
        Me.id.UseCustomForeColor = True
        '
        'lblHideName
        '
        Me.lblHideName.AutoSize = True
        Me.lblHideName.BackColor = System.Drawing.Color.Transparent
        Me.lblHideName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHideName.Location = New System.Drawing.Point(192, 30)
        Me.lblHideName.Name = "lblHideName"
        Me.lblHideName.Size = New System.Drawing.Size(39, 13)
        Me.lblHideName.TabIndex = 24
        Me.lblHideName.Text = "Label4"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(87, 49)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel2.TabIndex = 23
        Me.MetroLabel2.Text = "Cashier,"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(9, 11)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel15.TabIndex = 22
        Me.MetroLabel15.Text = "DATE:"
        Me.MetroLabel15.UseCustomBackColor = True
        '
        'pboxProfile
        '
        Me.pboxProfile.BackColor = System.Drawing.SystemColors.Control
        Me.pboxProfile.Image = Global.Food_Quest_App.My.Resources.Resources.profile
        Me.pboxProfile.Location = New System.Drawing.Point(6, 49)
        Me.pboxProfile.Name = "pboxProfile"
        Me.pboxProfile.Size = New System.Drawing.Size(75, 59)
        Me.pboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxProfile.TabIndex = 21
        Me.pboxProfile.TabStop = False
        '
        'lblCashierName
        '
        Me.lblCashierName.AutoSize = True
        Me.lblCashierName.Location = New System.Drawing.Point(87, 74)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(27, 19)
        Me.lblCashierName.TabIndex = 3
        Me.lblCashierName.Text = "......"
        Me.lblCashierName.UseCustomBackColor = True
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.txtItemName.CustomButton.Image = Nothing
        Me.txtItemName.CustomButton.Location = New System.Drawing.Point(331, 2)
        Me.txtItemName.CustomButton.Name = ""
        Me.txtItemName.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtItemName.CustomButton.TabIndex = 1
        Me.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtItemName.CustomButton.UseSelectable = True
        Me.txtItemName.CustomButton.Visible = False
        Me.txtItemName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtItemName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtItemName.Lines = New String(-1) {}
        Me.txtItemName.Location = New System.Drawing.Point(305, 125)
        Me.txtItemName.MaxLength = 32767
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.SelectionLength = 0
        Me.txtItemName.SelectionStart = 0
        Me.txtItemName.ShortcutsEnabled = True
        Me.txtItemName.Size = New System.Drawing.Size(369, 40)
        Me.txtItemName.TabIndex = 8
        Me.txtItemName.UseCustomBackColor = True
        Me.txtItemName.UseSelectable = True
        Me.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtItemName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(11, 65)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(86, 72)
        Me.txtOne.TabIndex = 0
        Me.txtOne.Text = "1"
        Me.txtOne.UseSelectable = True
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(103, 65)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(80, 72)
        Me.txtTwo.TabIndex = 1
        Me.txtTwo.Text = "2"
        Me.txtTwo.UseSelectable = True
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(189, 65)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.Size = New System.Drawing.Size(83, 72)
        Me.txtThree.TabIndex = 2
        Me.txtThree.Text = "3"
        Me.txtThree.UseSelectable = True
        '
        'txtFour
        '
        Me.txtFour.Location = New System.Drawing.Point(11, 143)
        Me.txtFour.Name = "txtFour"
        Me.txtFour.Size = New System.Drawing.Size(86, 60)
        Me.txtFour.TabIndex = 4
        Me.txtFour.Text = "4"
        Me.txtFour.UseSelectable = True
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(103, 143)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.Size = New System.Drawing.Size(80, 60)
        Me.txtFive.TabIndex = 5
        Me.txtFive.Text = "5"
        Me.txtFive.UseSelectable = True
        '
        'txtSix
        '
        Me.txtSix.Location = New System.Drawing.Point(189, 143)
        Me.txtSix.Name = "txtSix"
        Me.txtSix.Size = New System.Drawing.Size(83, 60)
        Me.txtSix.TabIndex = 6
        Me.txtSix.Text = "6"
        Me.txtSix.UseSelectable = True
        '
        'txtSeven
        '
        Me.txtSeven.Location = New System.Drawing.Point(11, 209)
        Me.txtSeven.Name = "txtSeven"
        Me.txtSeven.Size = New System.Drawing.Size(86, 65)
        Me.txtSeven.TabIndex = 8
        Me.txtSeven.Text = "7"
        Me.txtSeven.UseSelectable = True
        '
        'txtEight
        '
        Me.txtEight.Location = New System.Drawing.Point(103, 209)
        Me.txtEight.Name = "txtEight"
        Me.txtEight.Size = New System.Drawing.Size(80, 65)
        Me.txtEight.TabIndex = 9
        Me.txtEight.Text = "8"
        Me.txtEight.UseSelectable = True
        '
        'txtNine
        '
        Me.txtNine.Location = New System.Drawing.Point(189, 209)
        Me.txtNine.Name = "txtNine"
        Me.txtNine.Size = New System.Drawing.Size(83, 65)
        Me.txtNine.TabIndex = 10
        Me.txtNine.Text = "9"
        Me.txtNine.UseSelectable = True
        '
        'txtZero
        '
        Me.txtZero.Location = New System.Drawing.Point(100, 280)
        Me.txtZero.Name = "txtZero"
        Me.txtZero.Size = New System.Drawing.Size(83, 68)
        Me.txtZero.TabIndex = 12
        Me.txtZero.Text = "0"
        Me.txtZero.UseSelectable = True
        '
        'txtThreeZero
        '
        Me.txtThreeZero.Location = New System.Drawing.Point(14, 280)
        Me.txtThreeZero.Name = "txtThreeZero"
        Me.txtThreeZero.Size = New System.Drawing.Size(83, 68)
        Me.txtThreeZero.TabIndex = 13
        Me.txtThreeZero.Text = "000"
        Me.txtThreeZero.UseSelectable = True
        '
        'txtClearLastChar
        '
        Me.txtClearLastChar.Location = New System.Drawing.Point(188, 280)
        Me.txtClearLastChar.Name = "txtClearLastChar"
        Me.txtClearLastChar.Size = New System.Drawing.Size(84, 71)
        Me.txtClearLastChar.TabIndex = 15
        Me.txtClearLastChar.Text = "<X"
        Me.txtClearLastChar.UseSelectable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pboxCash)
        Me.GroupBox2.Controls.Add(Me.pboxCard)
        Me.GroupBox2.Controls.Add(Me.txtBarcode)
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Controls.Add(Me.txtClearLastChar)
        Me.GroupBox2.Controls.Add(Me.txtThreeZero)
        Me.GroupBox2.Controls.Add(Me.txtZero)
        Me.GroupBox2.Controls.Add(Me.txtNine)
        Me.GroupBox2.Controls.Add(Me.txtEight)
        Me.GroupBox2.Controls.Add(Me.txtSeven)
        Me.GroupBox2.Controls.Add(Me.txtSix)
        Me.GroupBox2.Controls.Add(Me.txtFive)
        Me.GroupBox2.Controls.Add(Me.txtFour)
        Me.GroupBox2.Controls.Add(Me.txtThree)
        Me.GroupBox2.Controls.Add(Me.txtTwo)
        Me.GroupBox2.Controls.Add(Me.txtOne)
        Me.GroupBox2.Controls.Add(Me.DataGridView3)
        Me.GroupBox2.Location = New System.Drawing.Point(306, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 368)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'pboxCash
        '
        Me.pboxCash.BackColor = System.Drawing.Color.White
        Me.pboxCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxCash.Image = Global.Food_Quest_App.My.Resources.Resources.cash2
        Me.pboxCash.Location = New System.Drawing.Point(278, 213)
        Me.pboxCash.Name = "pboxCash"
        Me.pboxCash.Size = New System.Drawing.Size(83, 64)
        Me.pboxCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxCash.TabIndex = 20
        Me.pboxCash.TabStop = False
        Me.MetroToolTip1.SetToolTip(Me.pboxCash, "CASH")
        '
        'pboxCard
        '
        Me.pboxCard.BackColor = System.Drawing.Color.White
        Me.pboxCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxCard.Image = Global.Food_Quest_App.My.Resources.Resources.card
        Me.pboxCard.Location = New System.Drawing.Point(278, 143)
        Me.pboxCard.Name = "pboxCard"
        Me.pboxCard.Size = New System.Drawing.Size(83, 64)
        Me.pboxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxCard.TabIndex = 19
        Me.pboxCard.TabStop = False
        Me.MetroToolTip1.SetToolTip(Me.pboxCard, "CREDIT OR DEBIT")
        '
        'txtBarcode
        '
        '
        '
        '
        Me.txtBarcode.CustomButton.Image = Nothing
        Me.txtBarcode.CustomButton.Location = New System.Drawing.Point(309, 2)
        Me.txtBarcode.CustomButton.Name = ""
        Me.txtBarcode.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBarcode.CustomButton.TabIndex = 1
        Me.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBarcode.CustomButton.UseSelectable = True
        Me.txtBarcode.CustomButton.Visible = False
        Me.txtBarcode.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtBarcode.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtBarcode.Lines = New String(-1) {}
        Me.txtBarcode.Location = New System.Drawing.Point(11, 19)
        Me.txtBarcode.MaxLength = 32767
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBarcode.SelectedText = ""
        Me.txtBarcode.SelectionLength = 0
        Me.txtBarcode.SelectionStart = 0
        Me.txtBarcode.ShortcutsEnabled = True
        Me.txtBarcode.Size = New System.Drawing.Size(347, 40)
        Me.txtBarcode.TabIndex = 9
        Me.txtBarcode.UseSelectable = True
        Me.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBarcode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(276, 65)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 72)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseSelectable = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(375, 62)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(318, 422)
        Me.DataGridView3.TabIndex = 6
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(460, 176)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(217, 50)
        Me.btnRemove.TabIndex = 18
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseSelectable = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(306, 223)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(148, 50)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseSelectable = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(306, 176)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(148, 50)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "ADD PRODUCT"
        Me.MetroToolTip1.SetToolTip(Me.btnAdd, "ADD ITEM TO CART")
        Me.btnAdd.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(679, 271)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel4.TabIndex = 15
        Me.MetroLabel4.Text = "CURRENT"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MetroLabel9)
        Me.Panel1.Location = New System.Drawing.Point(305, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 21)
        Me.Panel1.TabIndex = 22
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel9.ForeColor = System.Drawing.Color.White
        Me.MetroLabel9.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel9.TabIndex = 0
        Me.MetroLabel9.Text = "ITEM NAME"
        Me.MetroLabel9.UseCustomBackColor = True
        Me.MetroLabel9.UseCustomForeColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel10)
        Me.Panel2.Location = New System.Drawing.Point(305, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 21)
        Me.Panel2.TabIndex = 23
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.ForeColor = System.Drawing.Color.White
        Me.MetroLabel10.Location = New System.Drawing.Point(0, 0)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel10.TabIndex = 0
        Me.MetroLabel10.Text = "BARCODE"
        Me.MetroLabel10.UseCustomBackColor = True
        Me.MetroLabel10.UseCustomForeColor = True
        '
        'iQty
        '
        Me.iQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iQty.Location = New System.Drawing.Point(809, 125)
        Me.iQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.iQty.Name = "iQty"
        Me.iQty.Size = New System.Drawing.Size(166, 40)
        Me.iQty.TabIndex = 24
        Me.iQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel3.Controls.Add(Me.MetroLabel11)
        Me.Panel3.Location = New System.Drawing.Point(809, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(368, 21)
        Me.Panel3.TabIndex = 25
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel11.ForeColor = System.Drawing.Color.White
        Me.MetroLabel11.Location = New System.Drawing.Point(0, 2)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel11.TabIndex = 0
        Me.MetroLabel11.Text = "PRICE"
        Me.MetroLabel11.UseCustomBackColor = True
        Me.MetroLabel11.UseCustomForeColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel4.Controls.Add(Me.MetroLabel12)
        Me.Panel4.Location = New System.Drawing.Point(809, 104)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(166, 24)
        Me.Panel4.TabIndex = 23
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel12.ForeColor = System.Drawing.Color.White
        Me.MetroLabel12.Location = New System.Drawing.Point(-2, -1)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(34, 19)
        Me.MetroLabel12.TabIndex = 0
        Me.MetroLabel12.Text = "QTY"
        Me.MetroLabel12.UseCustomBackColor = True
        Me.MetroLabel12.UseCustomForeColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.lblDiscount)
        Me.Panel5.Controls.Add(Me.lblTotal)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.lblVat)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.lblSubTotal)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(683, 176)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(494, 91)
        Me.Panel5.TabIndex = 26
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Lime
        Me.lblDiscount.Location = New System.Drawing.Point(179, 14)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(87, 20)
        Me.lblDiscount.TabIndex = 26
        Me.lblDiscount.Text = "discount %"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Lime
        Me.lblTotal.Location = New System.Drawing.Point(305, 34)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(91, 42)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(272, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 42)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "₱ "
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.BackColor = System.Drawing.Color.Transparent
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.Lime
        Me.lblVat.Location = New System.Drawing.Point(87, 47)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(55, 20)
        Me.lblVat.TabIndex = 24
        Me.lblVat.Text = "₱ 0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(3, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "VAT %12:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.Lime
        Me.lblSubTotal.Location = New System.Drawing.Point(87, 14)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(55, 20)
        Me.lblSubTotal.TabIndex = 22
        Me.lblSubTotal.Text = "₱ 0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Sub-total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(170, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 42)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Total:"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.txtStock.CustomButton.Image = Nothing
        Me.txtStock.CustomButton.Location = New System.Drawing.Point(158, 2)
        Me.txtStock.CustomButton.Name = ""
        Me.txtStock.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStock.CustomButton.TabIndex = 1
        Me.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStock.CustomButton.UseSelectable = True
        Me.txtStock.CustomButton.Visible = False
        Me.txtStock.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtStock.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtStock.Lines = New String(-1) {}
        Me.txtStock.Location = New System.Drawing.Point(981, 125)
        Me.txtStock.MaxLength = 32767
        Me.txtStock.Name = "txtStock"
        Me.txtStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStock.ReadOnly = True
        Me.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStock.SelectedText = ""
        Me.txtStock.SelectionLength = 0
        Me.txtStock.SelectionStart = 0
        Me.txtStock.ShortcutsEnabled = True
        Me.txtStock.Size = New System.Drawing.Size(196, 40)
        Me.txtStock.TabIndex = 27
        Me.txtStock.UseCustomBackColor = True
        Me.txtStock.UseSelectable = True
        Me.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel6.Controls.Add(Me.MetroLabel1)
        Me.Panel6.Location = New System.Drawing.Point(981, 104)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(196, 21)
        Me.Panel6.TabIndex = 28
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(0, -1)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "REMAINING STOCK"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnVoid.ForeColor = System.Drawing.Color.White
        Me.btnVoid.Location = New System.Drawing.Point(-2, 663)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(285, 59)
        Me.btnVoid.TabIndex = 29
        Me.btnVoid.Text = "[ F1 - VOID ]"
        Me.btnVoid.UseCustomBackColor = True
        Me.btnVoid.UseCustomForeColor = True
        Me.btnVoid.UseSelectable = True
        '
        'btnSalesReport
        '
        Me.btnSalesReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSalesReport.ForeColor = System.Drawing.Color.White
        Me.btnSalesReport.Location = New System.Drawing.Point(558, 663)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(339, 59)
        Me.btnSalesReport.TabIndex = 32
        Me.btnSalesReport.Text = "[ F3 - SALES REPORT ]"
        Me.btnSalesReport.UseCustomBackColor = True
        Me.btnSalesReport.UseCustomForeColor = True
        Me.btnSalesReport.UseSelectable = True
        '
        'MetroButton25
        '
        Me.MetroButton25.BackColor = System.Drawing.Color.Maroon
        Me.MetroButton25.ForeColor = System.Drawing.Color.White
        Me.MetroButton25.Location = New System.Drawing.Point(893, 663)
        Me.MetroButton25.Name = "MetroButton25"
        Me.MetroButton25.Size = New System.Drawing.Size(305, 59)
        Me.MetroButton25.TabIndex = 33
        Me.MetroButton25.Text = "[ F4 - LOGOUT ]"
        Me.MetroButton25.UseCustomBackColor = True
        Me.MetroButton25.UseCustomForeColor = True
        Me.MetroButton25.UseSelectable = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.Location = New System.Drawing.Point(683, 293)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(494, 364)
        Me.DataGridView2.TabIndex = 93
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Barcode"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 72
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "price"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 55
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Qty"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 48
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 56
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'mtSC
        '
        Me.mtSC.AutoSize = True
        Me.mtSC.Location = New System.Drawing.Point(600, 233)
        Me.mtSC.Name = "mtSC"
        Me.mtSC.Size = New System.Drawing.Size(80, 17)
        Me.mtSC.TabIndex = 101
        Me.mtSC.Text = "Off"
        Me.MetroToolTip1.SetToolTip(Me.mtSC, "SC DISCOUNT")
        Me.mtSC.UseSelectable = True
        '
        'mtPwd
        '
        Me.mtPwd.AutoSize = True
        Me.mtPwd.Location = New System.Drawing.Point(600, 256)
        Me.mtPwd.Name = "mtPwd"
        Me.mtPwd.Size = New System.Drawing.Size(80, 17)
        Me.mtPwd.TabIndex = 102
        Me.mtPwd.Text = "Off"
        Me.MetroToolTip1.SetToolTip(Me.mtPwd, "PWD DISCOUNT")
        Me.mtPwd.UseSelectable = True
        '
        'Timer1
        '
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel7.Controls.Add(Me.lblAni)
        Me.Panel7.Location = New System.Drawing.Point(-2, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1200, 35)
        Me.Panel7.TabIndex = 94
        '
        'lblAni
        '
        Me.lblAni.AutoSize = True
        Me.lblAni.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAni.ForeColor = System.Drawing.Color.Lime
        Me.lblAni.Location = New System.Drawing.Point(422, 9)
        Me.lblAni.Name = "lblAni"
        Me.lblAni.Size = New System.Drawing.Size(0, 17)
        Me.lblAni.TabIndex = 0
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(1061, 271)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel5.TabIndex = 95
        Me.MetroLabel5.Text = "ORDER QTY:"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'lblItemQty
        '
        Me.lblItemQty.AutoSize = True
        Me.lblItemQty.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblItemQty.Location = New System.Drawing.Point(1142, 271)
        Me.lblItemQty.Name = "lblItemQty"
        Me.lblItemQty.Size = New System.Drawing.Size(17, 19)
        Me.lblItemQty.TabIndex = 96
        Me.lblItemQty.Text = "0"
        Me.lblItemQty.UseCustomBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(875, 271)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel6.TabIndex = 97
        Me.MetroLabel6.Text = "TRANSNO:"
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'lblTransNo
        '
        Me.lblTransNo.AutoSize = True
        Me.lblTransNo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblTransNo.Location = New System.Drawing.Point(950, 271)
        Me.lblTransNo.Name = "lblTransNo"
        Me.lblTransNo.Size = New System.Drawing.Size(105, 19)
        Me.lblTransNo.TabIndex = 98
        Me.lblTransNo.Text = "000000000000"
        Me.lblTransNo.UseCustomBackColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(1052, 271)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(14, 19)
        Me.MetroLabel8.TabIndex = 99
        Me.MetroLabel8.Text = "|"
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'pboxItem
        '
        Me.pboxItem.BackColor = System.Drawing.Color.White
        Me.pboxItem.Image = Global.Food_Quest_App.My.Resources.Resources.item1
        Me.pboxItem.Location = New System.Drawing.Point(683, 41)
        Me.pboxItem.Name = "pboxItem"
        Me.pboxItem.Size = New System.Drawing.Size(122, 124)
        Me.pboxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxItem.TabIndex = 20
        Me.pboxItem.TabStop = False
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.txtPrice.CustomButton.Image = Nothing
        Me.txtPrice.CustomButton.Location = New System.Drawing.Point(330, 2)
        Me.txtPrice.CustomButton.Name = ""
        Me.txtPrice.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrice.CustomButton.TabIndex = 1
        Me.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrice.CustomButton.UseSelectable = True
        Me.txtPrice.CustomButton.Visible = False
        Me.txtPrice.DisplayIcon = True
        Me.txtPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPrice.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtPrice.Icon = Global.Food_Quest_App.My.Resources.Resources.price
        Me.txtPrice.IconRight = True
        Me.txtPrice.Lines = New String() {"0.00"}
        Me.txtPrice.Location = New System.Drawing.Point(809, 61)
        Me.txtPrice.MaxLength = 32767
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.ShortcutsEnabled = True
        Me.txtPrice.Size = New System.Drawing.Size(368, 40)
        Me.txtPrice.TabIndex = 13
        Me.txtPrice.Text = "0.00"
        Me.txtPrice.UseCustomBackColor = True
        Me.txtPrice.UseSelectable = True
        Me.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFinalBarcode
        '
        Me.txtFinalBarcode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        '
        '
        Me.txtFinalBarcode.CustomButton.Image = Nothing
        Me.txtFinalBarcode.CustomButton.Location = New System.Drawing.Point(330, 2)
        Me.txtFinalBarcode.CustomButton.Name = ""
        Me.txtFinalBarcode.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtFinalBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFinalBarcode.CustomButton.TabIndex = 1
        Me.txtFinalBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFinalBarcode.CustomButton.UseSelectable = True
        Me.txtFinalBarcode.CustomButton.Visible = False
        Me.txtFinalBarcode.DisplayIcon = True
        Me.txtFinalBarcode.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtFinalBarcode.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtFinalBarcode.Icon = Global.Food_Quest_App.My.Resources.Resources.barcode
        Me.txtFinalBarcode.IconRight = True
        Me.txtFinalBarcode.Lines = New String(-1) {}
        Me.txtFinalBarcode.Location = New System.Drawing.Point(305, 60)
        Me.txtFinalBarcode.MaxLength = 32767
        Me.txtFinalBarcode.Name = "txtFinalBarcode"
        Me.txtFinalBarcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFinalBarcode.ReadOnly = True
        Me.txtFinalBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFinalBarcode.SelectedText = ""
        Me.txtFinalBarcode.SelectionLength = 0
        Me.txtFinalBarcode.SelectionStart = 0
        Me.txtFinalBarcode.ShortcutsEnabled = True
        Me.txtFinalBarcode.Size = New System.Drawing.Size(368, 40)
        Me.txtFinalBarcode.TabIndex = 7
        Me.txtFinalBarcode.UseCustomBackColor = True
        Me.txtFinalBarcode.UseSelectable = True
        Me.txtFinalBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFinalBarcode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(279, 663)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(285, 59)
        Me.btnNew.TabIndex = 100
        Me.btnNew.Text = "[ F2 - NEW TRANSACTION ]"
        Me.btnNew.UseCustomBackColor = True
        Me.btnNew.UseCustomForeColor = True
        Me.btnNew.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(460, 233)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel7.TabIndex = 103
        Me.MetroLabel7.Text = "SC 10% discount"
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel13.Location = New System.Drawing.Point(460, 254)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(134, 19)
        Me.MetroLabel13.TabIndex = 104
        Me.MetroLabel13.Text = "PWD 20% discount"
        Me.MetroLabel13.UseCustomBackColor = True
        Me.MetroLabel13.UseCustomForeColor = True
        '
        'cashier_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1190, 721)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.mtPwd)
        Me.Controls.Add(Me.mtSC)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.lblTransNo)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.lblItemQty)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.MetroButton25)
        Me.Controls.Add(Me.btnSalesReport)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.pboxItem)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.iQty)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtFinalBarcode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.dgHistoryTrans)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cashier_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "d"
        CType(Me.dgHistoryTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pboxCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.iQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.pboxItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgHistoryTrans As DataGridView
    Friend WithEvents lblDate As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFinalBarcode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtItemName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtOne As MetroFramework.Controls.MetroButton
    Friend WithEvents txtTwo As MetroFramework.Controls.MetroButton
    Friend WithEvents txtThree As MetroFramework.Controls.MetroButton
    Friend WithEvents txtFour As MetroFramework.Controls.MetroButton
    Friend WithEvents txtFive As MetroFramework.Controls.MetroButton
    Friend WithEvents txtSix As MetroFramework.Controls.MetroButton
    Friend WithEvents txtSeven As MetroFramework.Controls.MetroButton
    Friend WithEvents txtEight As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNine As MetroFramework.Controls.MetroButton
    Friend WithEvents txtZero As MetroFramework.Controls.MetroButton
    Friend WithEvents txtThreeZero As MetroFramework.Controls.MetroButton
    Friend WithEvents txtClearLastChar As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBarcode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents txtPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pboxItem As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents iQty As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCashierName As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btnRemove As MetroFramework.Controls.MetroButton
    Friend WithEvents pboxProfile As PictureBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnVoid As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSalesReport As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton25 As MetroFramework.Controls.MetroButton
    Friend WithEvents lblTotal As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents pboxCard As PictureBox
    Friend WithEvents pboxCash As PictureBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblAni As Label
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblItemQty As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTransNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHideName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNew As MetroFramework.Controls.MetroButton
    Friend WithEvents mtSC As MetroFramework.Controls.MetroToggle
    Friend WithEvents mtPwd As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDiscount As Label
    Friend WithEvents id As MetroFramework.Controls.MetroLabel
End Class
