Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography
Public Class ChangePassword
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public Cpassword As Boolean = False
    Public Npassword As Boolean = False
    Public Username As Boolean
    Public ProfilePic As Boolean
    Public clicked As Boolean
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerInfo()
        RoundedProfilepic()
        txtCurrentPass.UseSystemPasswordChar = True
        txtNewPass.UseSystemPasswordChar = True
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
    Sub CustomerInfo()
        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_users where username like '" & customer_form.lblFullName.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim ca() As Byte = dr(10)
                Dim clstr As New System.IO.MemoryStream(ca)
                pboxProfile.Image = Image.FromStream(clstr)
                pboxProfile.SizeMode = PictureBoxSizeMode.Zoom
                txtUsername.Text = customer_form.lblFullName.Text
                dr.Close()
                cn.Close()
            Else
                dr.Close()
                cn.Close()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub TxtCurrentPass_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentPass.TextChanged
        Cpassword = True
    End Sub
    Private Sub TxtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        Npassword = True
        Dim password, pwPart As String
        Dim I As Integer
        Dim L As Integer
        Dim lengthOK, ContaisNumber, ContainsAlpha As Boolean
        password = txtNewPass.Text
        L = password.Length

        If txtNewPass.Text = "" Then
            btnSave.Enabled = False
            Npassword = False
        Else
            If L < 6 Then
                lengthOK = False
                lblNewPass.ForeColor = Color.Red
                lblNewPass.Text = "* Password is minimum of 6 characters"
                btnSave.Enabled = False
                Exit Sub
            End If

            If Not Regex.Match(txtNewPass.Text, "^[0-9a-z]*$", RegexOptions.IgnoreCase).Success Then
                MessageBox.Show("Please enter Numbers and Characters Only", "Food Quest", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                lblNewPass.ForeColor = Color.Red
                txtNewPass.Focus()
                txtNewPass.Clear()
                btnSave.Enabled = False
            Else
                lblNewPass.ForeColor = Color.FromArgb(76, 22, 153)
            End If

            If L >= 6 Then
                I = 0
                For I = 1 To L
                    pwPart = Mid(password, I, 1)
                    If IsNumeric(pwPart) = True Then
                        ContaisNumber = True
                        Exit For
                    End If
                Next
                I = 0

                For I = 1 To L
                    pwPart = Mid(password, I, 1)
                    If IsNumeric(pwPart) = False Then
                        ContainsAlpha = True
                        Exit For
                    End If
                Next
            End If

            If ContainsAlpha = True And ContaisNumber = True Then
                lblNewPass.Text = "Password is valid"
                btnSave.Enabled = True
            Else
                lblNewPass.ForeColor = Color.Red
                txtNewPass.Text = "* Password should contains at least 1 number"
                btnSave.Enabled = False
            End If
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
    Private Sub PboxProfile_Click(sender As Object, e As EventArgs) Handles pboxProfile.Click
        ProfilePic = True
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp"
            ofd.Multiselect = False
            If ofd.ShowDialog = DialogResult.OK Then
                MakeRoundedImage(Image.FromFile(ofd.FileName), pboxProfile)
                RoundedProfilepic()
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
            PicBox.BackColor = Color.White
            PicBox.Image = New Bitmap(bm)
        End Using
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Username = True AndAlso clicked = True Then
            Try
                Connection()
                cn.Open()
                cm = New MySqlCommand("update tbl_users Set username = @username where username = '" & customer_form.lblFullName.Text & "'", cn)
                With cm
                    .Parameters.AddWithValue("@username", txtUsername.Text)
                    MsgBox("Your username has been updated SUCCESSFULLY!")
                    .ExecuteNonQuery()
                End With
                customer_form.lblFullName.Text = txtUsername.Text
                cn.Close()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.ToString)
            End Try
        End If

        If Cpassword = True AndAlso Npassword = False Then
            MsgBox("What's your NEW PASSWORD?")
        End If

        If Cpassword = False AndAlso Npassword = True Then
            MsgBox("What's your CURRENT PASSWORD?")
        End If

        If Cpassword = True AndAlso Npassword = True Then
            Try
                Connection()
                cn.Open()
                cm = New MySqlCommand("select * from tbl_users where username like '" & customer_form.lblFullName.Text & "' and password like '" & Encrypt(txtCurrentPass.Text, "abc") & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    cn.Close()
                    dr.Close()
                    Connection()
                    cn.Open()
                    cm = New MySqlCommand("update tbl_users Set password = @password where username = '" & customer_form.lblFullName.Text & "'", cn)
                    With cm
                        .Parameters.AddWithValue("@password", Encrypt(txtNewPass.Text, "abc"))
                        .ExecuteNonQuery()
                        cn.Close()
                        MsgBox("Your password has been updated SUCCESSFULLY!")
                    End With
                Else
                    MsgBox("Your current password is incorrect!", vbCritical)
                End If
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.ToString)
            End Try
        End If

        If ProfilePic = True Then
            Try
                Connection()
                cn.Open()
                Dim mstream As New System.IO.MemoryStream()
                Dim arrImage() As Byte
                pboxProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                cm = New MySqlCommand("update tbl_users Set picture = @picture where username = '" & customer_form.lblFullName.Text & "'", cn)
                With cm
                    .Parameters.AddWithValue("@picture", arrImage)
                    MsgBox("Your profile picture has been updated SUCCESSFULLY!")
                    .ExecuteNonQuery()
                End With
                customer_form.ProfilePic()
                cn.Close()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub CboCheck_CheckedChanged(sender As Object, e As EventArgs) Handles cboCheck.CheckedChanged
        txtCurrentPass.UseSystemPasswordChar = Not cboCheck.Checked
        txtNewPass.UseSystemPasswordChar = Not cboCheck.Checked
        If cboCheck.Checked = True Then
            PictureBox2.Image = My.Resources.icons8_eye_24
        Else
            PictureBox2.Image = My.Resources.icons8_hide_24
        End If
    End Sub
    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If Not Regex.Match(txtUsername.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            txtUsername.Clear()
            lblUsername.Text = "* Please alphabetic characters only!"
            Username = False
            btnSave.Enabled = False
        ElseIf txtUsername.Text.Length < 5 Then
            lblUsername.ForeColor = Color.Red
            lblUsername.ForeColor = Color.Red
            lblUsername.Text = "* Username is minimum of 5 characters allowed"
            Username = False
            btnSave.Enabled = False
        ElseIf txtUsername.Text.Length >= 5 Then
            Username = True
            lblUsername.Text = "Username"
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64)
            Username = True
            btnSave.Enabled = True
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        lblUsername.Text = "Your current username"
        lblNewPass.Text = "What's your new password?"
        lblCurrentPass.Text = "What's your current password?"
        Username = False
        Npassword = False
        Cpassword = False
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        clicked = True
    End Sub
End Class