<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionCard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDiscountAmount = New System.Windows.Forms.Label()
        Me.lblDot = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblVSale = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vl = New System.Windows.Forms.Label()
        Me.lvs = New System.Windows.Forms.Label()
        Me.lav = New System.Windows.Forms.Label()
        Me.lblVatableSale = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog3 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 19)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(145, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 41)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Print Receipt"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.check_icon
        Me.PictureBox1.Location = New System.Drawing.Point(67, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(110, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Transaction Saved"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblDiscountAmount)
        Me.Panel2.Controls.Add(Me.lblDot)
        Me.Panel2.Controls.Add(Me.lblDiscount)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblAmount)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblVat)
        Me.Panel2.Controls.Add(Me.lblVSale)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.vl)
        Me.Panel2.Controls.Add(Me.lvs)
        Me.Panel2.Controls.Add(Me.lav)
        Me.Panel2.Controls.Add(Me.lblVatableSale)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(12, 254)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 259)
        Me.Panel2.TabIndex = 8
        '
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.AutoSize = True
        Me.lblDiscountAmount.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDiscountAmount.Location = New System.Drawing.Point(330, 122)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(33, 16)
        Me.lblDiscountAmount.TabIndex = 25
        Me.lblDiscountAmount.Text = "0.00"
        Me.lblDiscountAmount.Visible = False
        '
        'lblDot
        '
        Me.lblDot.AutoSize = True
        Me.lblDot.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDot.Location = New System.Drawing.Point(103, 122)
        Me.lblDot.Name = "lblDot"
        Me.lblDot.Size = New System.Drawing.Size(224, 16)
        Me.lblDot.TabIndex = 24
        Me.lblDot.Text = "......................................................"
        Me.lblDot.Visible = False
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(40, 122)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(34, 16)
        Me.lblDiscount.TabIndex = 23
        Me.lblDiscount.Text = "Disc"
        Me.lblDiscount.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(166, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "....................................."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(103, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "......................................................"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(107, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "....................................................."
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAmount.Location = New System.Drawing.Point(330, 194)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(22, 16)
        Me.lblAmount.TabIndex = 19
        Me.lblAmount.Text = "05"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(330, 153)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(22, 16)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "04"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVat.Location = New System.Drawing.Point(330, 84)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(22, 16)
        Me.lblVat.TabIndex = 16
        Me.lblVat.Text = "02"
        '
        'lblVSale
        '
        Me.lblVSale.AutoSize = True
        Me.lblVSale.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVSale.Location = New System.Drawing.Point(330, 28)
        Me.lblVSale.Name = "lblVSale"
        Me.lblVSale.Size = New System.Drawing.Size(22, 16)
        Me.lblVSale.TabIndex = 15
        Me.lblVSale.Text = "01"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(126, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "..............................................."
        '
        'vl
        '
        Me.vl.AutoSize = True
        Me.vl.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.vl.Location = New System.Drawing.Point(40, 194)
        Me.vl.Name = "vl"
        Me.vl.Size = New System.Drawing.Size(120, 16)
        Me.vl.TabIndex = 9
        Me.vl.Text = "Amount Tendered"
        '
        'lvs
        '
        Me.lvs.AutoSize = True
        Me.lvs.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lvs.Location = New System.Drawing.Point(40, 153)
        Me.lvs.Name = "lvs"
        Me.lvs.Size = New System.Drawing.Size(40, 16)
        Me.lvs.TabIndex = 8
        Me.lvs.Text = "Total"
        '
        'lav
        '
        Me.lav.AutoSize = True
        Me.lav.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lav.Location = New System.Drawing.Point(40, 84)
        Me.lav.Name = "lav"
        Me.lav.Size = New System.Drawing.Size(64, 16)
        Me.lav.TabIndex = 7
        Me.lav.Text = "Vat(12%)"
        '
        'lblVatableSale
        '
        Me.lblVatableSale.AutoSize = True
        Me.lblVatableSale.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatableSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVatableSale.Location = New System.Drawing.Point(40, 28)
        Me.lblVatableSale.Name = "lblVatableSale"
        Me.lblVatableSale.Size = New System.Drawing.Size(84, 16)
        Me.lblVatableSale.TabIndex = 6
        Me.lblVatableSale.Text = "Vatable Sale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 5
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog3
        '
        Me.PrintPreviewDialog3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog3.Enabled = True
        Me.PrintPreviewDialog3.Icon = CType(resources.GetObject("PrintPreviewDialog3.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog3.Name = "PrintPreviewDialog3"
        Me.PrintPreviewDialog3.Visible = False
        '
        'TransactionCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 514)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TransactionCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionCard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblVSale As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents vl As Label
    Friend WithEvents lvs As Label
    Friend WithEvents lav As Label
    Friend WithEvents lblVatableSale As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog3 As PrintPreviewDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblDot As Label
    Friend WithEvents lblDiscountAmount As Label
End Class
