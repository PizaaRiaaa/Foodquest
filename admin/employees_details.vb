Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography
Public Class employees_details
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Public email, password, firstname, middle, lastname, mobile, DOB, gender As Boolean

    Dim pNum As New Random(100)
    Dim pLowerCase As New Random(500)
    Dim pUpperCase As New Random(50)
    Dim pass As String
    Dim RandomSelect As New Random(10)
    Public random As New Random()

    Sub Valid()
        If email = True AndAlso password = True AndAlso firstname = True AndAlso middle = True AndAlso lastname = True AndAlso mobile = True AndAlso DOB = True AndAlso gender = True Then
            btnAddCashier.Enabled = True
        End If

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
    Private Sub Employees_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading()
        RoundedProfilepic()
        btnAddCashier.Enabled = False

        dtDOB.MaxDate = DateTime.Now
        dtDOB.MinDate = dtDOB.MaxDate.AddYears(-55)

        txtUsername.MaxLength = 30
        mtMobile.Height = 29
        mtMobile.AutoSize = False
        dtDOB.Height = 32
        dtDOB.AutoSize = False

        lblNameRemind.Visible = False
        lblFirst.Visible = False
        lblMiddle.Visible = False
        lblLastName.Visible = False
        lblEmail.Visible = False

        txtFirstName.MaxLength = 50
        txtMI.MaxLength = 1
        txtLastName.MaxLength = 50
        txtEmail.MaxLength = 100

    End Sub

    Public Function GetPassword(ByVal passLength As Integer, Optional ByVal Reset As Boolean = False) As String
        Dim i As Integer
        Dim ctr(2) As Integer
        Dim charSelect(2) As String
        Dim iSel As Integer

        If Reset = True Then
            pass = ""
        End If
        For i = 1 To passLength

            ctr(0) = pNum.Next(48, 57)
            ctr(1) = pLowerCase.Next(65, 90)
            ctr(2) = pUpperCase.Next(97, 122)

            charSelect(0) = System.Convert.ToChar(ctr(0)).ToString
            charSelect(1) = System.Convert.ToChar(ctr(1)).ToString
            charSelect(2) = System.Convert.ToChar(ctr(2)).ToString

            iSel = RandomSelect.Next(0, 3)
            pass &= charSelect(iSel)

            If Reset = True Then
                pass.Replace(pass, charSelect(iSel))
            End If
        Next
        Return pass
    End Function

    Private Sub btnBarcode_Click(sender As Object, e As EventArgs) Handles btnPass.Click
        txtPassword.Text = GetPassword(8, True)
        password = True
        Valid()
    End Sub

    Private Sub LastNameTxtChange(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Dim strSurname As String = "^[a-zA-Z\s]+$"
        Dim reSurname As New Regex(strSurname)

        If Not reSurname.IsMatch(txtLastName.Text) Then
            txtLastName.Focus()
            txtLastName.Clear()
            pboxLastName.Image = Nothing
        ElseIf txtLastName.Text.Length < 2 Then
            lblNameRemind.Text = "* Lastname is minimum of 2 characters allowed"
            pboxLastName.Image = Nothing
            lblNameRemind.Visible = True
            lblLastName.Visible = True
        ElseIf txtLastName.Text.Length >= 2 Then
            lblNameRemind.Text = ""
            pboxLastName.Image = My.Resources.check_icon
            lblLastName.Visible = True
            lastname = True
            Valid()
        End If

        If txtLastName.Text = "" Then
            lblLastName.Visible = False
        End If
        txtUsername.Text = txtLastName.Text.ToUpper

    End Sub

    Private Sub FirstNameTxtChange(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        If Not Regex.Match(txtFirstName.Text, "^[a-zA-Z ]+$", RegexOptions.IgnoreCase).Success Then 'Only Letters
            lblFirst.Visible = False
            lblNameRemind.Visible = True
            txtFirstName.Focus()
            txtFirstName.Clear()
            pboxFirstName.Image = Nothing
        ElseIf txtFirstName.Text.Length < 2 Then
            lblNameRemind.Visible = True
            lblFirst.Visible = True
            lblNameRemind.Text = "* Firstname is minimum of 2 characters allowed"
            pboxFirstName.Image = Nothing
        ElseIf txtFirstName.Text.Length >= 2 Then
            lblNameRemind.Visible = False
            lblFirst.Visible = True
            pboxFirstName.Image = My.Resources.check_icon
            firstname = True
            Valid()
        End If
    End Sub

    Private Sub MiddleTxtChange(sender As Object, e As EventArgs) Handles txtMI.TextChanged
        Dim f As String
        f = "[A-Za-z]"
        If Not Regex.IsMatch(txtMI.Text, f) Then
            txtMI.Text = ""
            lblMiddle.Visible = False
            pboxMiddle.Image = Nothing
        ElseIf txtMI.Text = "" Then
            lblMiddle.Visible = False
            pboxMiddle.Image = Nothing
        ElseIf txtMI.Text <> "" Then
            lblMiddle.Visible = True
            pboxMiddle.Image = My.Resources.check_icon
            middle = True
            Valid()
        End If
    End Sub

    Private Sub MobileTxtChange(sender As Object, e As EventArgs) Handles mtMobile.TextChanged
        Dim phoneNumber As New Regex("\d{4}-\d{3}-\d{4}")
        If phoneNumber.IsMatch(mtMobile.Text) Then
            pboxMobile.Image = My.Resources.check_icon
            mobile = True
            Valid()
        Else
            pboxMobile.Image = Nothing
        End If
    End Sub

    Private Sub EmailTxtChange(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(txtEmail.Text, par) Then
            lblEmail.Visible = True
            pboxEmail.Image = My.Resources.check_icon
            email = True
            Valid()
        Else
            pboxEmail.Image = Nothing
        End If

        If txtEmail.Text = "" Then
            lblEmail.Visible = False
        ElseIf txtEmail.Text <> "" Then
            lblEmail.Visible = True
        End If

    End Sub

    Private Sub GenderTxtChange(sender As Object, e As EventArgs) Handles cboGender.TextChanged
        If cboGender.SelectedIndex >= 0 Then
            pboxGender.Image = My.Resources.check_icon
            gender = True
            Valid()
        Else
            pboxGender.Image = Nothing
        End If
    End Sub

    Private Sub ValueChangeBirth(sender As Object, e As EventArgs) Handles dtDOB.ValueChanged
        pboxBirth.Image = My.Resources.check_icon
        DOB = True
        Valid()
    End Sub

    Private Sub TxtChangePass(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text <> "" Then
            txtPassword.Icon = My.Resources.check_icon
            Valid()
        End If
    End Sub

    Private Sub TxtChangeSearch(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Loading()

        Try
            conn.Open()
            adapter = New MySqlDataAdapter("select * from tbl_users where firstname like '%" & txtSearch.Text & "%'" & "and user_type like '%" & TxtUsertype.Text & "%'", conn)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            conn.Close()
            txtEmail.Clear()
            txtFirstName.Clear()
            cboGender.SelectedIndex = -1
            txtID.Clear()
            txtLastName.Clear()
            txtMI.Clear()
            txtPassword.Clear()
            txtUsername.Clear()
            mtMobile.Clear()
        Catch ex As Exception
        End Try
        If txtSearch.Text = "" Then
            Loading()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As MySqlCommand
        Select Case MessageBox.Show("Are you sure to DELETE?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Case DialogResult.Yes
                conn.Open()
                Try
                    cmd = conn.CreateCommand
                    cmd.CommandText = "delete from tbl_users where id = @id;"
                    cmd.Parameters.AddWithValue("@id", txtID.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("cashier successfully DELETED!")
                    Loading()
                    btnAddCashier.Enabled = False
                    lblNameRemind.Visible = False
                    lblLastName.Visible = False
                    lblFirst.Visible = False
                    pboxBirth.Image = Nothing
                    txtPassword.Icon = My.Resources.passwprd
                    lblNameRemind.Text = ""
                    txtFirstName.Text = ""
                    txtID.Text = ""
                    txtLastName.Text = ""
                    txtMI.Text = ""
                    txtPassword.Text = ""
                    txtSearch.Text = ""
                    txtUsername.Text = ""
                    cboGender.SelectedIndex = -1
                    txtEmail.Text = ""
                    mtMobile.Text = ""
                    email = False
                    password = False
                    firstname = False
                    middle = False
                    lastname = False
                    mobile = False
                    DOB = False
                    gender = False
                    pboxProfile.Image = My.Resources.cashier1
                    conn.Close()
                Catch ex As Exception
                    conn.Close()
                End Try
            Case DialogResult.No
        End Select
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Loading()
        btnAddCashier.Enabled = False
        lblNameRemind.Visible = False
        lblLastName.Visible = False
        lblFirst.Visible = False
        pboxBirth.Image = Nothing
        txtPassword.Icon = My.Resources.passwprd
        lblNameRemind.Text = ""
        txtFirstName.Text = ""
        txtID.Text = ""
        txtLastName.Text = ""
        txtMI.Text = ""
        txtPassword.Text = ""
        txtSearch.Text = ""
        txtUsername.Text = ""
        cboGender.SelectedIndex = -1
        txtEmail.Text = ""
        mtMobile.Text = ""
        email = False
        password = False
        firstname = False
        middle = False
        lastname = False
        mobile = False
        DOB = False
        gender = False
        pboxProfile.Image = My.Resources.cashier1
    End Sub
    Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function
    Function Encrypt(ByVal Stringinput As String, ByVal key As String) As String
        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(Stringinput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddCashier.Click
        Dim cmd As MySqlCommand
        conn.Open()

        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte
        pboxProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Try
            cmd = conn.CreateCommand
            cmd.CommandText = "insert into tbl_users(email,username,password,firstname,middle,lastname,mobile,birthday,gender,picture,user_type)values(@email,@username,@password,@firstname,@middle,@lastname,@mobile,@birthday,@gender,@picture,@user_type);"
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", Encrypt(txtPassword.Text, "abc"))
            cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@middle", txtMI.Text)
            cmd.Parameters.AddWithValue("@lastname", txtLastName.Text)
            cmd.Parameters.AddWithValue("@mobile", mtMobile.Text)
            cmd.Parameters.Add(New MySqlParameter("@birthday", dtDOB.Value.Date))
            cmd.Parameters.AddWithValue("@gender", cboGender.Text)
            cmd.Parameters.AddWithValue("@picture", arrImage)
            cmd.Parameters.AddWithValue("@user_type", TxtUsertype.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Cashier Successfully added!")
            Loading()
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub
    Private Sub PicboxClick(sender As Object, e As EventArgs) Handles pboxProfile.Click
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnAddCashier.Enabled = False
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            txtID.Text = row.Cells(0).Value.ToString()
            txtEmail.Text = row.Cells(1).Value.ToString()
            txtUsername.Text = row.Cells(2).Value.ToString()
            txtPassword.Text = row.Cells(3).Value.ToString()
            txtFirstName.Text = row.Cells(4).Value.ToString()
            txtMI.Text = row.Cells(5).Value.ToString()
            txtLastName.Text = row.Cells(6).Value.ToString()
            mtMobile.Text = row.Cells(7).Value.ToString()
            dtDOB.Text = row.Cells(8).Value.ToString()
            cboGender.Text = row.Cells(9).Value.ToString()
            TxtUsertype.Text = row.Cells(11).Value.ToString()
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


    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        e.CellStyle.ForeColor = Color.Black
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Connection()
        cn.Open()

        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte
        pboxProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()

        cm = New MySqlCommand("update tbl_users Set email = @email, username = @username, password = @password, firstname = @firstname, middle = @middle, lastname = @lastname, mobile = @mobile, birthday = @birthday, gender = @gender,picture = @picture, user_type = @user_type where id = '" & txtID.Text & "'", cn)
        With cm
            .Parameters.AddWithValue("@email", txtEmail.Text)
            .Parameters.AddWithValue("@username", txtUsername.Text)
            .Parameters.AddWithValue("@password", txtPassword.Text)
            .Parameters.AddWithValue("@firstname", txtFirstName.Text)
            .Parameters.AddWithValue("@middle", txtMI.Text)
            .Parameters.AddWithValue("@lastname", txtLastName.Text)
            .Parameters.AddWithValue("@mobile", mtMobile.Text)
            .Parameters.Add(New MySqlParameter("@birthday", dtDOB.Value.Date))
            .Parameters.AddWithValue("@gender", cboGender.Text)
            .Parameters.AddWithValue("@picture", arrImage)
            .Parameters.AddWithValue("@user_type", TxtUsertype.Text)
            .ExecuteNonQuery()
        End With
        cn.Close()
        Loading()
        MessageBox.Show("updated successfully")
    End Sub
End Class