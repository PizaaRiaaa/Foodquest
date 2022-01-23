Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports System.Text

Public Class ForgotPassword
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public ca As MySqlCommand
    Public da As MySqlDataReader
    Public accesscode As String
    Public validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
    Public datenow As Date = Date.Now.ToShortDateString
    Public timenow As Date = Date.Now.ToShortTimeString

    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub

    Sub LoadAccessCode()
        Dim sb As New StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To 10
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb.Append(randomChar)
        Next i
        Dim randomString = sb.ToString()
        accesscode = randomString
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
    Private Sub forgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.AutoSize = False
        txtEmail.Height = 35

        lblDate.Text = datenow
        lblTime.Text = timenow
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(txtEmail.Text, par) Then
            lblEmail.ForeColor = Color.DarkViolet
            lblEmail.Text = "Enter your email"
        ElseIf txtEmail.Text = "" Then
            lblEmail.ForeColor = Color.Red
            lblEmail.Text = "* Please enter your email"
        Else
            lblEmail.ForeColor = Color.Red
            lblEmail.Text = "* Email is invalid. Please check your email."
        End If

        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_users where email like '" & txtEmail.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If txtEmail.Text.Equals(dr(1).ToString) Then
                    Try
                        LoadAccessCode()
                        Dim Mail As New MailMessage
                        Mail.Subject = "Food Quest Password Reset"
                        Mail.To.Add(txtEmail.Text)
                        Mail.From = New MailAddress("foodquest.hello.ph@gmail.com")

                        Mail.Body = "Hello, " + vbNewLine _
                                  + vbNewLine _
                                  + "You recently requested to reset your password for your Food Quest account." + vbNewLine _
                                  + "Your Food Quest verification code is: " + vbNewLine _
                                  + vbNewLine _
                                  + accesscode + vbNewLine _
                                  + vbNewLine _
                                  + "Use this code to reset your password for your Food Quest account" + vbNewLine _
                                  + vbNewLine _
                                  + vbNewLine _
                                  + "If you did not request this code,it is possible that someone else is trying" + vbNewLine _
                                  + "to access the Food Quest account " + txtEmail.Text + "." + vbNewLine _
                                  + "Do Not forward Or give this code to anyone."

                        Dim SMTP As New SmtpClient("smtp.gmail.com")
                        SMTP.UseDefaultCredentials = False
                        SMTP.EnableSsl = True
                        SMTP.Credentials = New System.Net.NetworkCredential("foodquest.hello.ph@gmail.com", "foodquest2020")
                        SMTP.Port = "587"
                        SMTP.Send(Mail)
                        pboxEmail.Image = My.Resources.check_icon
                        Me.Hide()
                        PasswordReset.Show()
                        dr.Close()
                        cn.Close()
                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.ToString)
                    End Try


                    Dim cmd As MySqlCommand
                    cn.Open()
                    Try
                        cmd = cn.CreateCommand
                        cmd.CommandText = "insert into tbl_passwordreset(access_code,email,ptime,pdate)values(@access_code,@email,@ptime,@pdate);"
                        cmd.Parameters.AddWithValue("@access_code", accesscode)
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                        cmd.Parameters.AddWithValue("@pdate", lblDate.Text)
                        cmd.Parameters.AddWithValue("@ptime", lblTime.Text)
                        cmd.ExecuteNonQuery()
                        cn.Close()
                    Catch ex As Exception
                        cn.Close()
                    End Try
                End If
            Else
                MsgBox("The email address was Not recognized!")
                pboxEmail.Image = My.Resources.invalid_icon
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        txtEmail.AutoSize = False
        txtEmail.Height = 30
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(txtEmail.Text, par) Then
            lblEmail.ForeColor = Color.Black
            lblEmail.Text = "Email"
            pboxEmail.Image = My.Resources.check_icon
        Else
            lblEmail.ForeColor = Color.Red
            lblEmail.Text = "Invalid email. Please check your email"
            pboxEmail.Image = My.Resources.invalid_icon
        End If
    End Sub

    Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs) Handles pboxBack.Click
        Me.Close()
        Login.Show()
    End Sub
End Class