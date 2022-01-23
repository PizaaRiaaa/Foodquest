Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class customer_form
    Dim slideMenu As String = "close"
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Private WithEvents pic As New PictureBox
    Private WithEvents lblD As New Label
    Private WithEvents lblP As New Label
    Private WithEvents btnAdd As New Button
    Public username As String
    Public category As String
    Dim btnCategory As New Button

    Dim _filter As String = ""

    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub
    Private Sub customer_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCorners(Me)
        Connection()
        LoadData()
        LoadCategory()
        RoundedProfilepic()
    End Sub

    Sub ProfilePic()
        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_users where username like '" & lblFullName.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim ca() As Byte = dr(10)
                Dim clstr As New System.IO.MemoryStream(ca)
                pboxProfile.Image = Image.FromStream(clstr)
                pboxProfile.SizeMode = PictureBoxSizeMode.Zoom
                RoundedProfilepic()
                clstr.Close()
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub RoundedProfilepic()
        Dim originalImage = pboxProfile.Image

        Dim croppedImage As New Bitmap(originalImage.Width, originalImage.Height)

        Using g = Graphics.FromImage(croppedImage)
            Dim path As New GraphicsPath

            path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height)

            Dim reg As New Region(path)

            g.Clip = reg
            g.DrawImage(originalImage, Point.Empty)
        End Using

        pboxProfile.Image = croppedImage
    End Sub

    Sub LoadData()
        FlowLayoutPanel2.Controls.Clear()
        FlowLayoutPanel2.AutoScroll = True
        cn.Open()
        cm = New MySqlCommand("select picture,name,price,weightOrQty,id,unit,category from tbl_products where category like '" & _filter & "%' order by name", cn)
        dr = cm.ExecuteReader
        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            category = dr.Item("category")

            pic = New PictureBox
            pic.Width = 200
            pic.Height = 300
            pic.BackgroundImageLayout = ImageLayout.Zoom

            lblD = New Label
            lblD.ForeColor = Color.Black
            lblD.BackColor = Color.AliceBlue
            lblD.Width = 250
            lblD.Font = New Font("Microsoft Sans Serif", 12)
            lblD.Dock = DockStyle.Bottom

            lblP = New Label
            lblP.BackColor = Color.LemonChiffon
            lblP.Font = New Font("Microsoft Sans Serif", 12)
            lblP.Dock = DockStyle.Bottom


            btnAdd = New Button
            btnAdd.BackColor = Color.FromArgb(76, 22, 153)
            btnAdd.ForeColor = Color.White
            btnAdd.Text = "Add to cart"
            btnAdd.FlatStyle = FlatStyle.Flat
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Violet
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
            btnAdd.AutoSize = True                      'x   'y
            btnAdd.Location = New System.Drawing.Point(120, 225)
            btnAdd.Size = New System.Drawing.Size(47, 23)
            btnAdd.TabIndex = 5
            btnAdd.Tag = dr.Item("id").ToString

            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lblD.Text = dr.Item("name").ToString
            lblP.Text = "₱" + dr.Item("price").ToString + " | " + dr.Item("weightOrQty").ToString + " " + dr.Item("unit").ToString
            lblD.Tag = dr.Item("name").ToString

            pic.Controls.Add(lblD)
            pic.Controls.Add(lblP)
            pic.Controls.Add(btnAdd)

            username = lblFullName.Text

            FlowLayoutPanel2.Controls.Add(pic)
            AddHandler btnAdd.Click, AddressOf BtnAdd_Click
        End While
        cn.Close()
    End Sub

    Public Sub BtnAdd_Click(ByVal sender As Object, e As EventArgs)
        Try
            Dim ids As String = sender.tag.ToString()
            Dim description As String = lblD.Tag
            Dim price As Double
            Dim cat As String = category
            Dim itemQty As Integer = Qty.Tag
            cn.Open()
            cm = New MySqlCommand("select * from tbl_products where id like '" & ids & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                description = dr.Item("name").ToString
                price = CDbl(dr.Item("price").ToString)
                category = dr.Item("category").ToString
            End If
            dr.Close()
            cn.Close()

            With Qty
                .AddCart(ids, description, price, cat)
                .Show()
            End With

        Catch ex As Exception
            cn.Close()
            dr.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub LoadCart()
        customer_cart.DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select id,description,qty,price,total from tbl_onlinecart where username like '" & lblFullName.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            customer_cart.DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("description").ToString, dr.Item("qty").ToString, dr.Item("price").ToString, dr.Item("total").ToString)
        End While
        dr.Close()
        cn.Close()
    End Sub
    Private Sub RoundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        Me.Hide()
        customer_cart.Show()
    End Sub
    Sub LoadCategory()
        cn.Open()
        cm = New MySqlCommand("select * from tbl_category", cn)
        dr = cm.ExecuteReader
        While dr.Read
            btnCategory = New Button
            btnCategory.Width = 130
            btnCategory.Height = 40
            btnCategory.Text = dr.Item("category").ToString
            btnCategory.FlatStyle = FlatStyle.Flat
            btnCategory.BackColor = Color.FromArgb(76, 22, 153)
            btnCategory.ForeColor = Color.White
            btnCategory.Cursor = Cursors.Hand
            btnCategory.TextAlign = ContentAlignment.MiddleCenter
            btnAdd.Location = New System.Drawing.Point(100, 200)
            FlowLayoutPanel1.Controls.Add(btnCategory)

            AddHandler btnCategory.Click, AddressOf filter_Click
        End While
        dr.Close()
        cn.Close()
    End Sub

    Public Sub filter_Click(sender As Object, e As EventArgs)
        _filter = sender.text.ToString
        LoadData()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pboxSettings.Click
        ChangePassword.Show()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Me.Dispose()
        Login.Show()
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub
End Class