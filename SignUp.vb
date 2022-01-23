Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Security.Cryptography
Public Class SignUp
    Dim str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Dim con As New MySqlConnection(str)
    Private NameValid As Boolean
    Private SurnameValid As Boolean
    Dim emailT, usernameT, passwordT, firstnameT, lastNameT, mobileT, genderT As Boolean
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Sub ValidAll()
        If emailT = True AndAlso usernameT = True AndAlso passwordT = True AndAlso firstnameT = True AndAlso lastNameT = True AndAlso genderT = True Then
            btnSignup.Enabled = True
        End If
    End Sub
    Sub Loading()
        Dim query As String = "select * from tbl_users"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        con.Close()
    End Sub
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading()

        Me.CenterToParent()
        birthday.Format = DateTimePickerFormat.Custom
        birthday.CustomFormat = "MM,dd,yyyy"
        pboxProfile.SizeMode = PictureBoxSizeMode.StretchImage
        birthday.MaxDate = DateTime.Today

        birthday.MaxDate = DateTime.Now
        birthday.MinDate = birthday.MaxDate.AddYears(-55)

        birthday.Tag = birthday.Value

        txtFirst.Height = 30
        txtFirst.AutoSize = False
        txtFirst.MaxLength = 50

        txtLast.Height = 30
        txtLast.AutoSize = False
        txtLast.MaxLength = 50

        txtMiddle.Height = 30
        txtMiddle.AutoSize = False
        txtMiddle.MaxLength = 1

        txtEmail.Height = 35
        txtEmail.AutoSize = False
        txtEmail.MaxLength = 60

        txtUsername.Height = 35
        txtUsername.AutoSize = False
        txtUsername.MaxLength = 30

        txtPassword.Height = 35
        txtPassword.AutoSize = False
        txtPassword.MaxLength = 128

        mtboxMobile.Height = 35
        mtboxMobile.AutoSize = False
        mtboxMobile.MaxLength = 11
    End Sub

    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(txtEmail.Text, par) Then
            lblEmail.ForeColor = Color.FromArgb(76, 22, 153)
            lblEmail.Text = "Email"
            pboEmail.Image = My.Resources.check_icon
            emailT = True
            ValidAll()
        Else
            lblEmail.ForeColor = Color.Red
            pboEmail.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
        End If
    End Sub
    Private Sub TxtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged
        If Not Regex.Match(txtFirst.Text, "^[a-zA-Z ]+$", RegexOptions.IgnoreCase).Success Then
            pboxFL.Image = My.Resources.invalid_icon
            lblFirst.Text = "First Name"
            lblFirst.ForeColor = Color.Red
            lblRemindName.Text = "* Please enter alphabetic characters only!"
            txtFirst.Focus()
            txtFirst.Clear()
            NameValid = False
            btnSignup.Enabled = False
        ElseIf txtFirst.Text = "" Then
            pboxFL.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
        ElseIf txtFirst.TextLength < 2 Then
            lblRemindName.ForeColor = Color.Red
            lblFirst.ForeColor = Color.Red
            lblRemindName.Text = "* Firstname is minimum of 2 characters allowed"
            pboxFL.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
        ElseIf txtFirst.TextLength >= 2 Then
            lblRemindName.Text = ""
            lblFirst.ForeColor = Color.FromArgb(76, 22, 153)
            lblFirst.Text = "First name"
            pboxFL.Image = My.Resources.check_icon
            firstnameT = True
            ValidAll()
        Else
            lblFirst.ForeColor = Color.FromArgb(76, 22, 153)
            txtFirst.Text = txtFirst.Text.Substring(0, 1)
            NameValid = True
            pboxFL.Image = My.Resources.check_icon
            firstnameT = True
            ValidAll()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)
        Dim phonenumber As New Regex("\d{4}-\d{3}-\d{4}")
        If phonenumber.IsMatch(mtboxMobile.Text) Then
            lblMobile.Text = "Mobile number"
            lblMobile.ForeColor = Color.FromArgb(76, 22, 153)
            pboxMobile.Image = My.Resources.check_icon
            btnSignup.Enabled = True
            mobileT = True
            ValidAll()
        Else
            lblMobile.Text = "* Enter mobile number with dash hyphens:  0000-000-0000
e.g 0916-699-2880"
            lblMobile.ForeColor = Color.Red
            btnSignup.Enabled = False
            pboxMobile.Image = My.Resources.invalid_icon
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cboShowHide.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not cboShowHide.Checked
        If cboShowHide.Checked = True Then
            pboxHide.Image = My.Resources.icons8_eye_24
        Else
            pboxHide.Image = My.Resources.icons8_hide_24
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub TxtLast_TextChanged(sender As Object, e As EventArgs) Handles txtLast.TextChanged
        Dim strSurname As String = "^[a-zA-Z\s]+$"
        Dim reSurname As New Regex(strSurname)

        If Not reSurname.IsMatch(txtLast.Text) Then
            lblLast.Text = "Last name"
            lblLast.ForeColor = Color.Red
            lblRemindName.Text = "*Please enter alphabetic characters only!"
            txtLast.Focus()
            txtLast.Clear()
            pboxLast.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
            SurnameValid = False
        ElseIf txtLast.TextLength < 2 Then
            lblRemindName.ForeColor = Color.Red
            lblLast.ForeColor = Color.Red
            lblRemindName.Text = "* Lastname is minimum of 2 characters allowed"
            pboxLast.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
        ElseIf txtLast.TextLength >= 2 Then
            lblRemindName.Text = ""
            pboxLast.Image = My.Resources.check_icon
            lblLast.ForeColor = Color.FromArgb(76, 22, 153)
            lblLast.Text = "Last name"
            SurnameValid = True
            lastNameT = True
            ValidAll()
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If Not Regex.Match(txtUsername.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            txtUsername.Clear()
            lblUsername.Text = "* Please alphabetic characters only!"
            txtUsername.Focus()
            NameValid = False
            pboxUser.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
        ElseIf txtUsername.TextLength < 5 Then
            lblUsername.ForeColor = Color.Red
            lblUsername.ForeColor = Color.Red
            lblUsername.Text = "* Username is minimum of 5 characters allowed"
            pboxUser.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
        ElseIf txtUsername.TextLength >= 5 Then
            NameValid = True
            lblUsername.Text = "Username"
            lblUsername.ForeColor = Color.FromArgb(76, 22, 153)
            pboxUser.Image = My.Resources.check_icon
            usernameT = True
            ValidAll()
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim password, pwPart As String
        Dim I As Integer
        Dim L As Integer
        Dim lengthOK, ContaisNumber, ContainsAlpha As Boolean
        password = txtPassword.Text
        L = password.Length

        If L < 6 Then
            lengthOK = False
            lblRemindPass.ForeColor = Color.Red
            lblPassword.Text = "* Password is minimum of 6 characters"
            pboxPass.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
            Exit Sub
        End If

        If Not Regex.Match(txtPassword.Text, "^[0-9a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers and Characters Only", "Food Quest", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblPassword.ForeColor = Color.Red
            txtPassword.Focus()
            txtPassword.Clear()
            NameValid = False
            pboxPass.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
        Else
            lblPassword.ForeColor = Color.FromArgb(76, 22, 153)
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
            lblPassword.Text = "Password is valid"
            pboxPass.Image = My.Resources.check_icon
            passwordT = True
            ValidAll()
        Else
            lblPassword.ForeColor = Color.Red
            lblPassword.Text = "* Password should contains at least 1 number"
            pboxPass.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub TxtMiddle_TextChanged(sender As Object, e As EventArgs) Handles txtMiddle.TextChanged
        Dim f As String
        f = "[A-Za-z]"
        If Not Regex.IsMatch(txtMiddle.Text, f) AndAlso txtMiddle.Text <> "" Then
            MessageBox.Show("* Please enter alphabetical character only")
            txtMiddle.Clear()
            lblMiddle.ForeColor = Color.Red
            pboxMI.Image = My.Resources.invalid_icon
        Else
            pboxMI.Image = My.Resources.check_icon
            lblMiddle.ForeColor = Color.FromArgb(76, 22, 153)
            ValidAll()
        End If
    End Sub

    Private Sub TextChangeMobile(sender As Object, e As EventArgs) Handles mtboxMobile.TextChanged
        Dim phoneNumber As New Regex("\d{4}-\d{3}-\d{4}")
        If phoneNumber.IsMatch(mtboxMobile.Text) Then
            lblMobile.ForeColor = Color.FromArgb(76, 22, 153)
            lblMobile.Text = "Mobile number"
            pboxMobile.Image = My.Resources.check_icon
            mobileT = True
            ValidAll()
        Else
            lblMobile.ForeColor = Color.Red
            lblMobile.Text = "* Invalid mobile number"
            pboxMobile.Image = Nothing
            btnSignup.Enabled = False
        End If
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub SurnameLeave(sender As Object, e As EventArgs) Handles txtLast.MouseLeave
        txtLast.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtLast.Text.ToLower)
    End Sub

    Private Sub FirstnameLeave(sender As Object, e As EventArgs) Handles txtFirst.MouseLeave
        txtFirst.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtFirst.Text.ToLower)
    End Sub

    Private Sub MiddleLeave(sender As Object, e As EventArgs) Handles txtMiddle.MouseLeave
        txtMiddle.Text = Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtMiddle.Text.ToLower)
    End Sub
    Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        If cboGender.SelectedItem Is Nothing Then
            lblGender.ForeColor = Color.Red
            lblGender.Text = "* What's your gender?"
            pboxGender.Image = My.Resources.invalid_icon
            btnSignup.Enabled = False
        Else
            lblGender.Text = "Gender"
            lblGender.ForeColor = Color.FromArgb(76, 22, 153)
            pboxGender.Image = My.Resources.check_icon
            genderT = True
            ValidAll()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pboxProfile.Click
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
            PicBox.BackColor = Color.White
            PicBox.Image = New Bitmap(bm)
        End Using
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim cmd As MySqlCommand
        con.Open()
        Dim HashCode As SignUp
        HashCode = New SignUp()
        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte
        pboxProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "insert into tbl_users(email,username,password,firstname,middle,lastname,mobile,birthday,gender,picture,user_type)values(@email,@username,@password,@firstname,@middle,@lastname,@mobile,@birthday,@gender,@picture,@user_type);"
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", Encrypt(txtPassword.Text, "abc"))
            cmd.Parameters.AddWithValue("@firstname", txtFirst.Text)
            cmd.Parameters.AddWithValue("@middle", txtMiddle.Text)
            cmd.Parameters.AddWithValue("@lastname", txtLast.Text)
            cmd.Parameters.AddWithValue("@mobile", mtboxMobile.Text)
            cmd.Parameters.AddWithValue("@gender", cboGender.Text)
            cmd.Parameters.AddWithValue("@picture", arrImage)
            cmd.Parameters.Add(New MySqlParameter("@birthday", birthday.Value.Date))
            cmd.Parameters.AddWithValue("@user_type", usertype.Text)
            cmd.ExecuteNonQuery()
            Me.Close()
            signupSuccessful.Show()
            Loading()
        Catch ex As Exception
            con.Close()
        End Try
        con.Close()
    End Sub
End Class