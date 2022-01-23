<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customer_cart
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemove = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lblTotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lblTaxTotal = New MetroFramework.Controls.MetroLabel()
        Me.lblSubTotal = New MetroFramework.Controls.MetroLabel()
        Me.btnCheckout = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lblTax = New MetroFramework.Controls.MetroLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblQty = New MetroFramework.Controls.MetroLabel()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.des, Me.Column3, Me.Column1, Me.Column2, Me.colRemove})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 135)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.Size = New System.Drawing.Size(514, 423)
        Me.DataGridView1.TabIndex = 0
        '
        'Column6
        '
        Me.Column6.HeaderText = "ID"
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'des
        '
        Me.des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.des.DefaultCellStyle = DataGridViewCellStyle3
        Me.des.HeaderText = "Description"
        Me.des.Name = "des"
        Me.des.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.des.Width = 85
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Qty"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 48
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column1.HeaderText = "Unit Price"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 78
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column2.HeaderText = "Sub Total"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 78
        '
        'colRemove
        '
        Me.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colRemove.HeaderText = ""
        Me.colRemove.Image = Global.Food_Quest_App.My.Resources.Resources.delete_item
        Me.colRemove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colRemove.Name = "colRemove"
        Me.colRemove.ToolTipText = "delete this item"
        Me.colRemove.Width = 5
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel1.Location = New System.Drawing.Point(28, 61)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(162, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Your Shopping Cart"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 19)
        Me.Panel1.TabIndex = 2
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroPanel1.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.lblTotal)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.lblTaxTotal)
        Me.MetroPanel1.Controls.Add(Me.lblSubTotal)
        Me.MetroPanel1.Controls.Add(Me.btnCheckout)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.lblTax)
        Me.MetroPanel1.Controls.Add(Me.Panel2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(532, 31)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(286, 505)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel7.Location = New System.Drawing.Point(168, 179)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(22, 19)
        Me.MetroLabel7.TabIndex = 15
        Me.MetroLabel7.Text = "₱ "
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel6.Location = New System.Drawing.Point(168, 232)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(22, 19)
        Me.MetroLabel6.TabIndex = 14
        Me.MetroLabel6.Text = "₱ "
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel4.Location = New System.Drawing.Point(168, 282)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(22, 19)
        Me.MetroLabel4.TabIndex = 13
        Me.MetroLabel4.Text = "₱ "
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(185, 282)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(49, 19)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = ".........."
        Me.lblTotal.UseCustomBackColor = True
        Me.lblTotal.UseCustomForeColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel3.Location = New System.Drawing.Point(27, 282)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel3.TabIndex = 11
        Me.MetroLabel3.Text = "Total:"
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'lblTaxTotal
        '
        Me.lblTaxTotal.AutoSize = True
        Me.lblTaxTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTaxTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblTaxTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTaxTotal.Location = New System.Drawing.Point(27, 232)
        Me.lblTaxTotal.Name = "lblTaxTotal"
        Me.lblTaxTotal.Size = New System.Drawing.Size(32, 19)
        Me.lblTaxTotal.TabIndex = 10
        Me.lblTaxTotal.Text = "Tax"
        Me.lblTaxTotal.UseCustomBackColor = True
        Me.lblTaxTotal.UseCustomForeColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubTotal.Location = New System.Drawing.Point(185, 179)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(49, 19)
        Me.lblSubTotal.TabIndex = 7
        Me.lblSubTotal.Text = ".........."
        Me.lblSubTotal.UseCustomBackColor = True
        Me.lblSubTotal.UseCustomForeColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCheckout.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCheckout.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(16, 372)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(254, 48)
        Me.btnCheckout.TabIndex = 8
        Me.btnCheckout.Text = "PROCEED TO CHECKOUT"
        Me.btnCheckout.UseCustomBackColor = True
        Me.btnCheckout.UseCustomForeColor = True
        Me.btnCheckout.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroLabel5.Location = New System.Drawing.Point(27, 179)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Sub Total:"
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BackColor = System.Drawing.Color.Transparent
        Me.lblTax.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTax.Location = New System.Drawing.Point(189, 232)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(45, 19)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "........."
        Me.lblTax.UseCustomBackColor = True
        Me.lblTax.UseCustomForeColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(287, 11)
        Me.Panel2.TabIndex = 4
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 46)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(85, 25)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Summary"
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.BackColor = System.Drawing.Color.Transparent
        Me.lblQty.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblQty.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblQty.Location = New System.Drawing.Point(196, 61)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(47, 25)
        Me.lblQty.TabIndex = 4
        Me.lblQty.Text = "QTY"
        Me.lblQty.UseCustomBackColor = True
        Me.lblQty.UseCustomForeColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Food_Quest_App.My.Resources.Resources.delete_item
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ToolTipText = "delete this item"
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = Global.Food_Quest_App.My.Resources.Resources.back
        Me.btnBack.Location = New System.Drawing.Point(28, 16)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(28, 35)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 6
        Me.btnBack.TabStop = False
        Me.MetroToolTip1.SetToolTip(Me.btnBack, "Go back")
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'customer_cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 561)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customer_cart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customer_cart"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTax As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCheckout As MetroFramework.Controls.MetroButton
    Friend WithEvents lblQty As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSubTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTaxTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents des As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents colRemove As DataGridViewImageColumn
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
End Class
