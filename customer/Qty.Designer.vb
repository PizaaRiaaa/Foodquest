<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Qty
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.addItem = New MetroFramework.Controls.MetroButton()
        Me.lblStocks = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblItemName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 43)
        Me.Panel1.TabIndex = 0
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.White
        Me.lblItemName.Location = New System.Drawing.Point(13, 14)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(70, 15)
        Me.lblItemName.TabIndex = 8
        Me.lblItemName.Text = "item_name"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.icons8_close_window_64
        Me.PictureBox1.Location = New System.Drawing.Point(506, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblQty.Location = New System.Drawing.Point(223, 88)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(100, 29)
        Me.lblQty.TabIndex = 1
        Me.lblQty.Text = "Quantity"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(112, 137)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(329, 49)
        Me.NumericUpDown1.TabIndex = 3
        '
        'addItem
        '
        Me.addItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.addItem.ForeColor = System.Drawing.Color.White
        Me.addItem.Location = New System.Drawing.Point(199, 212)
        Me.addItem.Name = "addItem"
        Me.addItem.Size = New System.Drawing.Size(143, 46)
        Me.addItem.TabIndex = 5
        Me.addItem.Text = "Add to your cart"
        Me.addItem.UseCustomBackColor = True
        Me.addItem.UseCustomForeColor = True
        Me.addItem.UseSelectable = True
        '
        'lblStocks
        '
        Me.lblStocks.AutoSize = True
        Me.lblStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStocks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStocks.Location = New System.Drawing.Point(12, 260)
        Me.lblStocks.Name = "lblStocks"
        Me.lblStocks.Size = New System.Drawing.Size(18, 20)
        Me.lblStocks.TabIndex = 7
        Me.lblStocks.Text = "0"
        Me.lblStocks.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblStocks.Visible = False
        '
        'Qty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 289)
        Me.Controls.Add(Me.lblStocks)
        Me.Controls.Add(Me.addItem)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Qty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qty"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblQty As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents addItem As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblStocks As Label
    Friend WithEvents lblItemName As Label
End Class
