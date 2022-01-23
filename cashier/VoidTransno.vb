Imports MySql.Data.MySqlClient

Public Class VoidTransno
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)
    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub


    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_instorecart where transno like '" & txtTransno.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Me.Hide()
                VoidTransno2.Show()
                cn.Close()
            Else
                MsgBox("Invalid Transaction #! Please try again", vbCritical)
                txtTransno.Clear()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class