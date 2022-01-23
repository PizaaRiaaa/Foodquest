<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VoidTransno2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTransno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReason = New MetroFramework.Controls.MetroTextBox()
        Me.btnProceed = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(102, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Warning!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "You cannot undo this action."
        '
        'lblTransno
        '
        Me.lblTransno.AutoSize = True
        Me.lblTransno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransno.Location = New System.Drawing.Point(12, 45)
        Me.lblTransno.Name = "lblTransno"
        Me.lblTransno.Size = New System.Drawing.Size(296, 18)
        Me.lblTransno.TabIndex = 2
        Me.lblTransno.Text = "Are you sure you want to void Transaction #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(369, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter reason for sales return below, and click Proceed."
        '
        'txtReason
        '
        '
        '
        '
        Me.txtReason.CustomButton.Image = Nothing
        Me.txtReason.CustomButton.Location = New System.Drawing.Point(356, 2)
        Me.txtReason.CustomButton.Name = ""
        Me.txtReason.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.txtReason.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReason.CustomButton.TabIndex = 1
        Me.txtReason.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReason.CustomButton.UseSelectable = True
        Me.txtReason.CustomButton.Visible = False
        Me.txtReason.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtReason.Lines = New String(-1) {}
        Me.txtReason.Location = New System.Drawing.Point(48, 97)
        Me.txtReason.MaxLength = 32767
        Me.txtReason.Name = "txtReason"
        Me.txtReason.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReason.PromptText = "Reason"
        Me.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReason.SelectedText = ""
        Me.txtReason.SelectionLength = 0
        Me.txtReason.SelectionStart = 0
        Me.txtReason.ShortcutsEnabled = True
        Me.txtReason.Size = New System.Drawing.Size(404, 50)
        Me.txtReason.TabIndex = 4
        Me.txtReason.UseSelectable = True
        Me.txtReason.WaterMark = "Reason"
        Me.txtReason.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReason.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(225, 159)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(104, 39)
        Me.btnProceed.TabIndex = 5
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseCustomBackColor = True
        Me.btnProceed.UseCustomForeColor = True
        Me.btnProceed.UseSelectable = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(348, 159)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 39)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'VoidTransno2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 210)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTransno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VoidTransno2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VoidTransno2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTransno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtReason As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnProceed As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
End Class
