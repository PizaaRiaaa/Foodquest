<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Card
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPass = New MetroFramework.Controls.MetroTextBox()
        Me.btn3 = New MetroFramework.Controls.MetroButton()
        Me.btn2 = New MetroFramework.Controls.MetroButton()
        Me.btn1 = New MetroFramework.Controls.MetroButton()
        Me.btn4 = New MetroFramework.Controls.MetroButton()
        Me.btn5 = New MetroFramework.Controls.MetroButton()
        Me.btn6 = New MetroFramework.Controls.MetroButton()
        Me.btn7 = New MetroFramework.Controls.MetroButton()
        Me.btn8 = New MetroFramework.Controls.MetroButton()
        Me.btn9 = New MetroFramework.Controls.MetroButton()
        Me.btn0 = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnAccept = New MetroFramework.Controls.MetroButton()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.mtCardno = New System.Windows.Forms.MaskedTextBox()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Food_Quest_App.My.Resources.Resources.card_reader
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(449, 715)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'txtPass
        '
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(271, 1)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(55, 55)
        Me.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.CustomButton.Visible = False
        Me.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPass.Lines = New String(-1) {}
        Me.txtPass.Location = New System.Drawing.Point(49, 153)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.PromptText = "Password"
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(327, 57)
        Me.txtPass.TabIndex = 27
        Me.txtPass.UseSelectable = True
        Me.txtPass.WaterMark = "Password"
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn3
        '
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(268, 297)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(99, 55)
        Me.btn3.TabIndex = 28
        Me.btn3.Text = "3"
        Me.btn3.UseCustomBackColor = True
        Me.btn3.UseCustomForeColor = True
        Me.btn3.UseSelectable = True
        '
        'btn2
        '
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(163, 297)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(99, 55)
        Me.btn2.TabIndex = 29
        Me.btn2.Text = "2"
        Me.btn2.UseCustomBackColor = True
        Me.btn2.UseCustomForeColor = True
        Me.btn2.UseSelectable = True
        '
        'btn1
        '
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(58, 297)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(99, 55)
        Me.btn1.TabIndex = 30
        Me.btn1.Text = "1"
        Me.btn1.UseCustomBackColor = True
        Me.btn1.UseCustomForeColor = True
        Me.btn1.UseSelectable = True
        '
        'btn4
        '
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(58, 358)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(99, 55)
        Me.btn4.TabIndex = 31
        Me.btn4.Text = "4"
        Me.btn4.UseCustomBackColor = True
        Me.btn4.UseCustomForeColor = True
        Me.btn4.UseSelectable = True
        '
        'btn5
        '
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(163, 358)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(99, 55)
        Me.btn5.TabIndex = 32
        Me.btn5.Text = "5"
        Me.btn5.UseCustomBackColor = True
        Me.btn5.UseCustomForeColor = True
        Me.btn5.UseSelectable = True
        '
        'btn6
        '
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(268, 358)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(99, 55)
        Me.btn6.TabIndex = 33
        Me.btn6.Text = "6"
        Me.btn6.UseCustomBackColor = True
        Me.btn6.UseCustomForeColor = True
        Me.btn6.UseSelectable = True
        '
        'btn7
        '
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(58, 419)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(99, 55)
        Me.btn7.TabIndex = 34
        Me.btn7.Text = "7"
        Me.btn7.UseCustomBackColor = True
        Me.btn7.UseCustomForeColor = True
        Me.btn7.UseSelectable = True
        '
        'btn8
        '
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(163, 419)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(99, 55)
        Me.btn8.TabIndex = 35
        Me.btn8.Text = "8"
        Me.btn8.UseCustomBackColor = True
        Me.btn8.UseCustomForeColor = True
        Me.btn8.UseSelectable = True
        '
        'btn9
        '
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(268, 419)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(99, 55)
        Me.btn9.TabIndex = 36
        Me.btn9.Text = "9"
        Me.btn9.UseCustomBackColor = True
        Me.btn9.UseCustomForeColor = True
        Me.btn9.UseSelectable = True
        '
        'btn0
        '
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Location = New System.Drawing.Point(58, 478)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(99, 55)
        Me.btn0.TabIndex = 37
        Me.btn0.Text = "0"
        Me.btn0.UseCustomBackColor = True
        Me.btn0.UseCustomForeColor = True
        Me.btn0.UseSelectable = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Crimson
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(163, 478)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 55)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseCustomBackColor = True
        Me.btnCancel.UseCustomForeColor = True
        Me.btnCancel.UseSelectable = True
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Location = New System.Drawing.Point(268, 478)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(99, 55)
        Me.btnAccept.TabIndex = 39
        Me.btnAccept.Text = "ACCEPT"
        Me.btnAccept.UseCustomBackColor = True
        Me.btnAccept.UseCustomForeColor = True
        Me.btnAccept.UseSelectable = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(277, 250)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(99, 26)
        Me.btnReset.TabIndex = 40
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseCustomBackColor = True
        Me.btnReset.UseCustomForeColor = True
        Me.btnReset.UseSelectable = True
        '
        'mtCardno
        '
        Me.mtCardno.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtCardno.Location = New System.Drawing.Point(49, 113)
        Me.mtCardno.Mask = "0000 0000 0000 0000"
        Me.mtCardno.Name = "mtCardno"
        Me.mtCardno.Size = New System.Drawing.Size(327, 44)
        Me.mtCardno.TabIndex = 41
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.MetroRadioButton1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.MetroRadioButton1.ForeColor = System.Drawing.Color.White
        Me.MetroRadioButton1.Location = New System.Drawing.Point(49, 250)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(84, 19)
        Me.MetroRadioButton1.TabIndex = 42
        Me.MetroRadioButton1.Text = "SAVINGS"
        Me.MetroRadioButton1.UseCustomBackColor = True
        Me.MetroRadioButton1.UseCustomForeColor = True
        Me.MetroRadioButton1.UseSelectable = True
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.MetroRadioButton2.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.MetroRadioButton2.ForeColor = System.Drawing.Color.White
        Me.MetroRadioButton2.Location = New System.Drawing.Point(139, 250)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(88, 19)
        Me.MetroRadioButton2.TabIndex = 43
        Me.MetroRadioButton2.Text = "CURRENT"
        Me.MetroRadioButton2.UseCustomBackColor = True
        Me.MetroRadioButton2.UseCustomForeColor = True
        Me.MetroRadioButton2.UseSelectable = True
        '
        'Card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(445, 664)
        Me.Controls.Add(Me.MetroRadioButton2)
        Me.Controls.Add(Me.MetroRadioButton1)
        Me.Controls.Add(Me.mtCardno)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Card"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn4 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn5 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn6 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn7 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn8 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn9 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn0 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAccept As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents mtCardno As MaskedTextBox
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
End Class
