Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class Login
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public ca As MySqlCommand
    Public da As MySqlDataReader
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Dim attempts As Integer = 1
    Dim str As String = "attemps remaining: "
    Private Sub LblSingUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = Color.Transparent
        txtUsername.AutoSize = False
        txtUsername.Height = 40

        tbPassword.AutoSize = False
        tbPassword.Height = 40
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

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim remain As Integer = 4
        Dim cashier As String = "CASHIER"
        Dim customer As String = "CUSTOMER"

        If txtUsername.Text.Equals("admin") AndAlso tbPassword.Text.Equals("admin") Then
            MsgBox("Access granted!", vbInformation)
            admin_form.Show()
            Me.Dispose()
            Return
        End If

        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_users where username like '" & txtUsername.Text & "' and password like'" & Encrypt(tbPassword.Text, "abc") & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            While attempts <= 2
                If dr.HasRows Then
                    If dr(11).ToString.Equals(cashier) Then
                        Dim ca() As Byte = dr(10)
                        Dim clstr As New System.IO.MemoryStream(ca)
                        SplashScreen.Show()
                        cashier_form.pboxProfile.Image = Image.FromStream(clstr)
                        cashier_form.pboxProfile.SizeMode = PictureBoxSizeMode.Zoom
                        clstr.Close()
                        cashier_form.lblCashierName.Text = (dr(4).ToString) + " " + (dr(6).ToString)
                        cashier_form.id.Text = (dr(0).ToString)
                        cashier_form.lblHideName.Text = (dr(4).ToString)
                        MsgBox("Access Granted", vbInformation)
                        Me.Dispose()
                        Return
                    ElseIf dr(11).ToString.Equals(customer) Then
                        Dim lb() As Byte = dr(10)
                        Dim lstr As New System.IO.MemoryStream(lb)
                        customer_form.pboxProfile.Image = Image.FromStream(lstr)
                        customer_form.pboxProfile.SizeMode = PictureBoxSizeMode.Zoom
                        lstr.Close()
                        customer_form.lblFullName.Text = (dr(2).ToString)
                        customer_form.Show()
                        MsgBox("successfully login", vbInformation)
                        Me.Dispose()
                        Return
                    End If
                Else
                    lblUsername.Text = "Username"
                    lblPassword.Text = "Password"
                    txtUsername.Clear()
                    tbPassword.Clear()
                    attempts += 1
                    remain -= attempts
                    MessageBox.Show("Invalid username or password" + vbNewLine + str + remain.ToString())
                    Return
                End If
            End While

            If attempts = 3 Then
                Me.Hide()
                loginAttempts.Show()
                txtUsername.Clear()
                tbPassword.Clear()
            End If

            attempts = 1
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CboShowHide_CheckedChanged(sender As Object, e As EventArgs) Handles cboShowHide.CheckedChanged
        tbPassword.UseSystemPasswordChar = Not cboShowHide.Checked
        If cboShowHide.Checked = True Then
            pboxShow.Image = My.Resources.icons8_eye_24
        Else
            pboxShow.Image = My.Resources.icons8_hide_24
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblForgot.Click
        Hide()
        ForgotPassword.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class