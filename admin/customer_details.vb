Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class customer_details
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Sub Loading()
        Dim query As String = "select * from tbl_users  where user_type like '%" & TxtUsertype.Text & "%'"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
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


    Private Sub Customer_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading()
        lblID.Visible = False
        lblEmail.Visible = False
        lblUsername.Visible = False
        lblDOB.Visible = True
        lblFirst.Visible = False
        lblGender.Visible = False
        lblMiddle.Visible = False
        lblLastName.Visible = False

        txtFirstName.MaxLength = 50
        txtLastName.MaxLength = 50
        txtEmail.MaxLength = 60

        MaskTxtMobile.Height = 32
        MaskTxtMobile.AutoSize = False
        MaskTxtMobile.MaxLength = 12

        MaskTxtBOD.Height = 30
        MaskTxtBOD.AutoSize = False

    End Sub
    Private Sub IdTxtChange(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If txtID.Text <> "" Then
            lblID.Visible = True
        Else
            lblID.Visible = False
        End If
    End Sub

    Private Sub UserTxtChange(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text = "" Then
            lblUsername.Visible = False
        Else
            lblUsername.Visible = True
        End If
    End Sub

    Private Sub FirstTxtChange(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        If txtFirstName.Text = "" Then
            lblFirst.Visible = False
        Else
            lblFirst.Visible = True
        End If
    End Sub

    Private Sub GenderTxtChange(sender As Object, e As EventArgs) Handles txtGender.TextChanged
        If txtGender.Text = "" Then
            lblGender.Visible = False
        Else
            lblGender.Visible = True
        End If
    End Sub

    Private Sub MiddleTxtChange(sender As Object, e As EventArgs) Handles txtMiddle.TextChanged
        If txtMiddle.Text = "" Then
            lblMiddle.Visible = False
        Else
            lblMiddle.Visible = True
        End If
    End Sub

    Private Sub LastNameTxtChange(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        If txtLastName.Text = "" Then
            lblLastName.Visible = False
        Else
            lblLastName.Visible = True
        End If
    End Sub

    Private Sub pboxProfile_Click(sender As Object, e As EventArgs) Handles pboxProfile.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp"
            ofd.Multiselect = False
            If ofd.ShowDialog = DialogResult.OK Then
                MakeRoundedImage(Image.FromFile(ofd.FileName), pboxProfile)
            End If
        End Using
    End Sub
    Private Sub MakeRoundedImage(ByVal Img As Image, ByVal PicBox As PictureBox)
        Using bm As New Bitmap(Img.Width, Img.Height)
            Using grx2 As Graphics = Graphics.FromImage(bm)
                grx2.SmoothingMode = SmoothingMode.AntiAlias
                Using tb As New TextureBrush(Img)
                    tb.TranslateTransform(0, 0)
                    Using gp As New GraphicsPath
                        gp.AddEllipse(0, 0, Img.Width, Img.Height)
                        grx2.FillPath(tb, gp)
                    End Using
                End Using
            End Using
            If PicBox.Image IsNot Nothing Then PicBox.Image.Dispose()
            PicBox.Image = New Bitmap(bm)
        End Using
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        e.CellStyle.ForeColor = Color.Black
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs)
        Connection()
        cn.Open()
        cm = New MySqlCommand("update tbl_users Set email = @email, mobile = @mobile, picture = @picture where id = '" & txtID.Text & "'", cn)
        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte
        pboxProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()

        With cm
            .Parameters.AddWithValue("@email", txtEmail.Text)
            .Parameters.AddWithValue("@mobile", MaskTxtMobile.Text)
            .Parameters.AddWithValue("@picture", arrImage)
            .ExecuteNonQuery()
        End With
        cn.Close()
        Loading()
        MessageBox.Show("updated successfully")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        Try
            txtID.Text = row.Cells(0).Value.ToString()
            txtEmail.Text = row.Cells(1).Value.ToString()
            txtUsername.Text = row.Cells(2).Value.ToString()
            txtFirstName.Text = row.Cells(4).Value.ToString()
            txtMiddle.Text = row.Cells(5).Value.ToString()
            txtLastName.Text = row.Cells(6).Value.ToString()
            MaskTxtMobile.Text = row.Cells(7).Value.ToString()
            MaskTxtBOD.Text = row.Cells(8).Value.ToString()
            txtGender.Text = row.Cells(9).Value.ToString()
        Catch ex As Exception
        End Try

        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_users where id like '" & txtID.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim ca() As Byte = dr(10)
                Dim clstr As New System.IO.MemoryStream(ca)
                pboxProfile.Image = Image.FromStream(clstr)
                pboxProfile.SizeMode = PictureBoxSizeMode.Zoom
                RoundedProfilepic()
                cn.Close()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs)
        pboxProfile.Image = My.Resources._360___Add_Profile_interaction_communication_interface_512
        txtEmail.Clear()
        txtFirstName.Clear()
        txtGender.Clear()
        txtID.Clear()
        txtLastName.Clear()
        txtMiddle.Clear()
        txtUsername.Clear()
        txtSearch.Text = ""
        MaskTxtBOD.Text = ""
        MaskTxtMobile.Text = ""
    End Sub

    Private Sub SearchTxtChange(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            conn.Open()
            adapter = New MySqlDataAdapter("select * from tbl_users where firstname like '%" & txtSearch.Text & "%'", conn)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            conn.Close()
            txtEmail.Clear()
            txtFirstName.Clear()
            txtGender.Clear()
            txtID.Clear()
            txtLastName.Clear()
            txtMiddle.Clear()
            txtUsername.Clear()
            MaskTxtBOD.Clear()
            MaskTxtMobile.Clear()
        Catch ex As Exception
        End Try
        If txtSearch.Text = "" Then
            Loading()
        End If
    End Sub
End Class