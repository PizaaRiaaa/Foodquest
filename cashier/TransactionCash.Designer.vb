<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionCash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionCash))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbls = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVatableSale = New System.Windows.Forms.Label()
        Me.lav = New System.Windows.Forms.Label()
        Me.lvs = New System.Windows.Forms.Label()
        Me.vl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVSale = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDot = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDisAmount = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 18)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(115, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transaction Saved"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.check_icon
        Me.PictureBox1.Location = New System.Drawing.Point(72, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(138, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Print Receipt"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Food_Quest_App.My.Resources.Resources.icons8_close_window_64
        Me.PictureBox2.Location = New System.Drawing.Point(368, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'lbls
        '
        Me.lbls.AutoSize = True
        Me.lbls.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbls.Location = New System.Drawing.Point(26, 189)
        Me.lbls.Name = "lbls"
        Me.lbls.Size = New System.Drawing.Size(37, 16)
        Me.lbls.TabIndex = 4
        Me.lbls.Text = "Cash"
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
        'lblVatableSale
        '
        Me.lblVatableSale.AutoSize = True
        Me.lblVatableSale.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatableSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVatableSale.Location = New System.Drawing.Point(23, 39)
        Me.lblVatableSale.Name = "lblVatableSale"
        Me.lblVatableSale.Size = New System.Drawing.Size(84, 16)
        Me.lblVatableSale.TabIndex = 6
        Me.lblVatableSale.Text = "Vatable Sale"
        '
        'lav
        '
        Me.lav.AutoSize = True
        Me.lav.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lav.Location = New System.Drawing.Point(24, 85)
        Me.lav.Name = "lav"
        Me.lav.Size = New System.Drawing.Size(64, 16)
        Me.lav.TabIndex = 7
        Me.lav.Text = "Vat(12%)"
        '
        'lvs
        '
        Me.lvs.AutoSize = True
        Me.lvs.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lvs.Location = New System.Drawing.Point(26, 151)
        Me.lvs.Name = "lvs"
        Me.lvs.Size = New System.Drawing.Size(40, 16)
        Me.lvs.TabIndex = 8
        Me.lvs.Text = "Total"
        '
        'vl
        '
        Me.vl.AutoSize = True
        Me.vl.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.vl.Location = New System.Drawing.Point(26, 229)
        Me.vl.Name = "vl"
        Me.vl.Size = New System.Drawing.Size(83, 16)
        Me.vl.TabIndex = 9
        Me.vl.Text = "Change Due"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(123, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "........................................."
        '
        'lblVSale
        '
        Me.lblVSale.AutoSize = True
        Me.lblVSale.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVSale.Location = New System.Drawing.Point(329, 39)
        Me.lblVSale.Name = "lblVSale"
        Me.lblVSale.Size = New System.Drawing.Size(22, 16)
        Me.lblVSale.TabIndex = 15
        Me.lblVSale.Text = "01"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVat.Location = New System.Drawing.Point(329, 85)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(22, 16)
        Me.lblVat.TabIndex = 16
        Me.lblVat.Text = "02"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(329, 151)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(22, 16)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "04"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCash.Location = New System.Drawing.Point(329, 189)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(22, 16)
        Me.lblCash.TabIndex = 18
        Me.lblCash.Text = "05"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblChange.Location = New System.Drawing.Point(329, 229)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(22, 16)
        Me.lblChange.TabIndex = 19
        Me.lblChange.Text = "06"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblDot)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblDisAmount)
        Me.Panel2.Controls.Add(Me.lblDiscount)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.lblCash)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblVat)
        Me.Panel2.Controls.Add(Me.lblVSale)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.vl)
        Me.Panel2.Controls.Add(Me.lvs)
        Me.Panel2.Controls.Add(Me.lav)
        Me.Panel2.Controls.Add(Me.lblVatableSale)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lbls)
        Me.Panel2.Location = New System.Drawing.Point(12, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 259)
        Me.Panel2.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(123, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "........................................."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(123, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "........................................."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(123, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "........................................."
        '
        'lblDot
        '
        Me.lblDot.AutoSize = True
        Me.lblDot.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDot.Location = New System.Drawing.Point(123, 123)
        Me.lblDot.Name = "lblDot"
        Me.lblDot.Size = New System.Drawing.Size(172, 16)
        Me.lblDot.TabIndex = 24
        Me.lblDot.Text = "........................................."
        Me.lblDot.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(123, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "........................................."
        '
        'lblDisAmount
        '
        Me.lblDisAmount.AutoSize = True
        Me.lblDisAmount.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDisAmount.Location = New System.Drawing.Point(329, 123)
        Me.lblDisAmount.Name = "lblDisAmount"
        Me.lblDisAmount.Size = New System.Drawing.Size(33, 16)
        Me.lblDisAmount.TabIndex = 22
        Me.lblDisAmount.Text = "0.00"
        Me.lblDisAmount.Visible = False
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(25, 123)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(63, 16)
        Me.lblDiscount.TabIndex = 20
        Me.lblDiscount.Text = "Discount"
        Me.lblDiscount.Visible = False
        '
        'TransactionCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 514)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransactionCash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbls As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVatableSale As Label
    Friend WithEvents lav As Label
    Friend WithEvents lvs As Label
    Friend WithEvents vl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblVSale As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCash As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDisAmount As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblDot As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
