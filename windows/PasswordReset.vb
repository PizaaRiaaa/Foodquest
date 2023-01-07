Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography
Public Class PasswordReset
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Private Sub LblEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(451, 346)
        txtPassword.UseSystemPasswordChar = True
    End Sub
    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_passwordreset where access_code like '" & txtAccessCode.Text & "' and email like '" & ForgotPassword.txtEmail.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Me.Size = New Size(451, 552)
                Me.CenterToScreen()
                btnProceed.Enabled = False
            Else
                MsgBox("Sorry your access code is incorrect!", vbCritical)
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
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
            lblRemind.ForeColor = Color.Red
            lblRemind.Text = "* Password is minimum of 6 characters"
            btnReset.Enabled = False
            Exit Sub
        End If

        If Not Regex.Match(txtPassword.Text, "^[0-9a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please enter Numbers and Characters Only", "Food Quest", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblRemind.ForeColor = Color.Red
            txtPassword.Focus()
            txtPassword.Clear()
            btnReset.Enabled = False
        Else
            lblRemind.ForeColor = Color.FromArgb(76, 22, 153)
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
            lblRemind.Text = "Password is valid"
            btnReset.Enabled = True
        Else
            lblRemind.ForeColor = Color.Red
            lblRemind.Text = "* Password should contains at least 1 number"
            btnReset.Enabled = False
        End If
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cboShowHide.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not cboShowHide.Checked
        If cboShowHide.Checked = True Then
            PictureBox2.Image = My.Resources.icons8_eye_24
        Else
            PictureBox2.Image = My.Resources.icons8_hide_24
        End If
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
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Connection()
        cn.Open()
        cm = New MySqlCommand("update tbl_users Set password = @password where email = '" & ForgotPassword.txtEmail.Text & "'", cn)
        With cm
            .Parameters.AddWithValue("@password", Encrypt(txtPassword.Text, "abc"))
            .ExecuteNonQuery()
        End With
        cn.Close()
        MessageBox.Show("Password has been reset successfully")
        Me.Close()
        Login.Show()
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click

    End Sub
End Class