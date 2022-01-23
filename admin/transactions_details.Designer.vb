<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactions_details
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearchStore = New MetroFramework.Controls.MetroTextBox()
        Me.txtSearchOnline = New MetroFramework.Controls.MetroTextBox()
        Me.dataInstore = New System.Windows.Forms.DataGridView()
        Me.dataOnline = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataInstore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataOnline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(112, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 42)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Online Transactions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(112, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 42)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "In-store Transactions"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Food_Quest_App.My.Resources.Resources.store
        Me.PictureBox2.Location = New System.Drawing.Point(18, 343)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.online
        Me.PictureBox1.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtSearchStore
        '
        '
        '
        '
        Me.txtSearchStore.CustomButton.Image = Nothing
        Me.txtSearchStore.CustomButton.Location = New System.Drawing.Point(434, 2)
        Me.txtSearchStore.CustomButton.Name = ""
        Me.txtSearchStore.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtSearchStore.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchStore.CustomButton.TabIndex = 1
        Me.txtSearchStore.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchStore.CustomButton.UseSelectable = True
        Me.txtSearchStore.CustomButton.Visible = False
        Me.txtSearchStore.DisplayIcon = True
        Me.txtSearchStore.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSearchStore.Icon = Global.Food_Quest_App.My.Resources.Resources.search1
        Me.txtSearchStore.IconRight = True
        Me.txtSearchStore.Lines = New String(-1) {}
        Me.txtSearchStore.Location = New System.Drawing.Point(500, 341)
        Me.txtSearchStore.MaxLength = 32767
        Me.txtSearchStore.Name = "txtSearchStore"
        Me.txtSearchStore.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchStore.PromptText = "Search by Transaction number"
        Me.txtSearchStore.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchStore.SelectedText = ""
        Me.txtSearchStore.SelectionLength = 0
        Me.txtSearchStore.SelectionStart = 0
        Me.txtSearchStore.ShortcutsEnabled = True
        Me.txtSearchStore.Size = New System.Drawing.Size(480, 48)
        Me.txtSearchStore.TabIndex = 6
        Me.txtSearchStore.UseSelectable = True
        Me.txtSearchStore.WaterMark = "Search by Transaction number"
        Me.txtSearchStore.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchStore.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSearchOnline
        '
        '
        '
        '
        Me.txtSearchOnline.CustomButton.Image = Nothing
        Me.txtSearchOnline.CustomButton.Location = New System.Drawing.Point(437, 2)
        Me.txtSearchOnline.CustomButton.Name = ""
        Me.txtSearchOnline.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtSearchOnline.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearchOnline.CustomButton.TabIndex = 1
        Me.txtSearchOnline.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearchOnline.CustomButton.UseSelectable = True
        Me.txtSearchOnline.CustomButton.Visible = False
        Me.txtSearchOnline.DisplayIcon = True
        Me.txtSearchOnline.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSearchOnline.Icon = Global.Food_Quest_App.My.Resources.Resources.search1
        Me.txtSearchOnline.IconRight = True
        Me.txtSearchOnline.Lines = New String(-1) {}
        Me.txtSearchOnline.Location = New System.Drawing.Point(497, 12)
        Me.txtSearchOnline.MaxLength = 32767
        Me.txtSearchOnline.Name = "txtSearchOnline"
        Me.txtSearchOnline.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchOnline.PromptText = "Search by Order reference #"
        Me.txtSearchOnline.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchOnline.SelectedText = ""
        Me.txtSearchOnline.SelectionLength = 0
        Me.txtSearchOnline.SelectionStart = 0
        Me.txtSearchOnline.ShortcutsEnabled = True
        Me.txtSearchOnline.Size = New System.Drawing.Size(483, 48)
        Me.txtSearchOnline.TabIndex = 3
        Me.txtSearchOnline.UseSelectable = True
        Me.txtSearchOnline.WaterMark = "Search by Order reference #"
        Me.txtSearchOnline.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearchOnline.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dataInstore
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataInstore.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataInstore.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataInstore.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataInstore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataInstore.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataInstore.GridColor = System.Drawing.Color.White
        Me.dataInstore.Location = New System.Drawing.Point(12, 395)
        Me.dataInstore.Name = "dataInstore"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataInstore.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataInstore.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataInstore.Size = New System.Drawing.Size(968, 269)
        Me.dataInstore.TabIndex = 5
        '
        'dataOnline
        '
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataOnline.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dataOnline.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataOnline.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dataOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataOnline.DefaultCellStyle = DataGridViewCellStyle8
        Me.dataOnline.GridColor = System.Drawing.Color.White
        Me.dataOnline.Location = New System.Drawing.Point(12, 66)
        Me.dataOnline.Name = "dataOnline"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataOnline.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dataOnline.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dataOnline.Size = New System.Drawing.Size(968, 259)
        Me.dataOnline.TabIndex = 11
        '
        'transactions_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 676)
        Me.Controls.Add(Me.dataOnline)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchStore)
        Me.Controls.Add(Me.dataInstore)
        Me.Controls.Add(Me.txtSearchOnline)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transactions_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "transactions_details"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataInstore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataOnline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchOnline As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSearchStore As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dataInstore As DataGridView
    Friend WithEvents dataOnline As DataGridView
End Class
