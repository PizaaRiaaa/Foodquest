<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VoidTransno
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTransno = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOk = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(181, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Void"
        '
        'txtTransno
        '
        '
        '
        '
        Me.txtTransno.CustomButton.Image = Nothing
        Me.txtTransno.CustomButton.Location = New System.Drawing.Point(334, 1)
        Me.txtTransno.CustomButton.Name = ""
        Me.txtTransno.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.txtTransno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTransno.CustomButton.TabIndex = 1
        Me.txtTransno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTransno.CustomButton.UseSelectable = True
        Me.txtTransno.CustomButton.Visible = False
        Me.txtTransno.DisplayIcon = True
        Me.txtTransno.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTransno.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtTransno.Icon = Global.Food_Quest_App.My.Resources.Resources.transaction
        Me.txtTransno.IconRight = True
        Me.txtTransno.Lines = New String(-1) {}
        Me.txtTransno.Location = New System.Drawing.Point(38, 85)
        Me.txtTransno.MaxLength = 32767
        Me.txtTransno.Name = "txtTransno"
        Me.txtTransno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransno.PromptText = "Transaction #"
        Me.txtTransno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTransno.SelectedText = ""
        Me.txtTransno.SelectionLength = 0
        Me.txtTransno.SelectionStart = 0
        Me.txtTransno.ShortcutsEnabled = True
        Me.txtTransno.Size = New System.Drawing.Size(380, 47)
        Me.txtTransno.TabIndex = 1
        Me.txtTransno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTransno.UseSelectable = True
        Me.txtTransno.WaterMark = "Transaction #"
        Me.txtTransno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTransno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(85, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please enter Transaction number to void"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(204, 151)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(104, 39)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseCustomBackColor = True
        Me.btnOk.UseCustomForeColor = True
        Me.btnOk.UseSelectable = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(314, 151)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 39)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'VoidTransno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(446, 202)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTransno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VoidTransno"
        Me.Text = "VoidTransno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTransno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOk As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
End Class
