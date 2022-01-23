<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cash
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.txtCash = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.lblHidChange = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnAcceptPayment = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(147, 25)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(54, 25)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TOTAL:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 20)
        Me.Panel1.TabIndex = 2
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroPanel1.Controls.Add(Me.Label2)
        Me.MetroPanel1.Controls.Add(Me.lblTotal)
        Me.MetroPanel1.Controls.Add(Me.Label4)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 91)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(443, 76)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.UseCustomForeColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(120, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "₱ "
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroPanel2.Controls.Add(Me.txtCash)
        Me.MetroPanel2.Controls.Add(Me.Label1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 173)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(443, 81)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.UseCustomForeColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'txtCash
        '
        '
        '
        '
        Me.txtCash.CustomButton.Image = Nothing
        Me.txtCash.CustomButton.Location = New System.Drawing.Point(277, 1)
        Me.txtCash.CustomButton.Name = ""
        Me.txtCash.CustomButton.Size = New System.Drawing.Size(43, 43)
        Me.txtCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCash.CustomButton.TabIndex = 1
        Me.txtCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCash.CustomButton.UseSelectable = True
        Me.txtCash.CustomButton.Visible = False
        Me.txtCash.DisplayIcon = True
        Me.txtCash.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCash.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtCash.Icon = Global.Food_Quest_App.My.Resources.Resources.cash2
        Me.txtCash.IconRight = True
        Me.txtCash.Lines = New String(-1) {}
        Me.txtCash.Location = New System.Drawing.Point(99, 20)
        Me.txtCash.MaxLength = 32767
        Me.txtCash.Name = "txtCash"
        Me.txtCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCash.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCash.SelectedText = ""
        Me.txtCash.SelectionLength = 0
        Me.txtCash.SelectionStart = 0
        Me.txtCash.ShortcutsEnabled = True
        Me.txtCash.Size = New System.Drawing.Size(321, 45)
        Me.txtCash.TabIndex = 5
        Me.txtCash.UseSelectable = True
        Me.txtCash.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCash.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CASH:"
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroPanel3.Controls.Add(Me.lblHidChange)
        Me.MetroPanel3.Controls.Add(Me.Label5)
        Me.MetroPanel3.Controls.Add(Me.Label3)
        Me.MetroPanel3.Controls.Add(Me.lblChange)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(0, 260)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(443, 82)
        Me.MetroPanel3.TabIndex = 5
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.UseCustomForeColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'lblHidChange
        '
        Me.lblHidChange.AutoSize = True
        Me.lblHidChange.BackColor = System.Drawing.Color.Transparent
        Me.lblHidChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHidChange.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblHidChange.Location = New System.Drawing.Point(157, 50)
        Me.lblHidChange.Name = "lblHidChange"
        Me.lblHidChange.Size = New System.Drawing.Size(54, 25)
        Me.lblHidChange.TabIndex = 7
        Me.lblHidChange.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(130, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "₱ "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "CHANGE:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.Black
        Me.lblChange.Location = New System.Drawing.Point(157, 25)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(54, 25)
        Me.lblChange.TabIndex = 0
        Me.lblChange.Text = "0.00"
        '
        'btnAcceptPayment
        '
        Me.btnAcceptPayment.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAcceptPayment.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAcceptPayment.ForeColor = System.Drawing.Color.White
        Me.btnAcceptPayment.Location = New System.Drawing.Point(0, 431)
        Me.btnAcceptPayment.Name = "btnAcceptPayment"
        Me.btnAcceptPayment.Size = New System.Drawing.Size(443, 67)
        Me.btnAcceptPayment.TabIndex = 6
        Me.btnAcceptPayment.Text = "ACCEPT PAYMENT"
        Me.btnAcceptPayment.UseCustomBackColor = True
        Me.btnAcceptPayment.UseCustomForeColor = True
        Me.btnAcceptPayment.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.icons8_close_window_64
        Me.PictureBox1.Location = New System.Drawing.Point(392, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 498)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAcceptPayment)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtCash As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAcceptPayment As MetroFramework.Controls.MetroButton
    Friend WithEvents lblHidChange As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
