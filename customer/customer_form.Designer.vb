<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customer_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer_form))
        Me.lblFullName = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblItems = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.pboxSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pboxProfile = New System.Windows.Forms.PictureBox()
        CType(Me.pboxSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblFullName.ForeColor = System.Drawing.Color.Black
        Me.lblFullName.Location = New System.Drawing.Point(228, 58)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(71, 19)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Username"
        Me.lblFullName.UseCustomBackColor = True
        Me.lblFullName.UseCustomForeColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel2.Location = New System.Drawing.Point(228, 39)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Hello,"
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(943, 15)
        Me.Panel3.TabIndex = 0
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(931, 27)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(0, 18)
        Me.lblItems.TabIndex = 9
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 104)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(137, 578)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(143, 104)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(800, 578)
        Me.FlowLayoutPanel2.TabIndex = 10
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'pboxSettings
        '
        Me.pboxSettings.BackColor = System.Drawing.Color.White
        Me.pboxSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pboxSettings.Image = Global.Food_Quest_App.My.Resources.Resources.settings
        Me.pboxSettings.Location = New System.Drawing.Point(809, 39)
        Me.pboxSettings.Name = "pboxSettings"
        Me.pboxSettings.Size = New System.Drawing.Size(37, 27)
        Me.pboxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxSettings.TabIndex = 11
        Me.pboxSettings.TabStop = False
        Me.MetroToolTip1.SetToolTip(Me.pboxSettings, "Settings")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(757, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.MetroToolTip1.SetToolTip(Me.PictureBox2, "Your cart")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(867, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Logout"
        Me.MetroToolTip1.SetToolTip(Me.Label1, "Logout")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Food_Quest_App.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pboxProfile
        '
        Me.pboxProfile.BackColor = System.Drawing.Color.Transparent
        Me.pboxProfile.Image = Global.Food_Quest_App.My.Resources.Resources.profile
        Me.pboxProfile.Location = New System.Drawing.Point(166, 39)
        Me.pboxProfile.Name = "pboxProfile"
        Me.pboxProfile.Size = New System.Drawing.Size(56, 35)
        Me.pboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxProfile.TabIndex = 4
        Me.pboxProfile.TabStop = False
        '
        'customer_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(943, 683)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pboxSettings)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.pboxProfile)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customer_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "V"
        CType(Me.pboxSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFullName As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pboxProfile As PictureBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblItems As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pboxSettings As PictureBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents Label1 As Label
End Class
