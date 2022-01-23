Imports MySql.Data.MySqlClient
Public Class Card
    Dim card, month, year, cvc As Boolean
    Dim icard As Boolean
    Dim pass As Boolean

    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public con As New MySqlConnection(str)
    Public ModeOfPayment As String
    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub

    Private Sub Card_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.MaxLength = 6
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        mtCardno.Clear()
        txtPass.Clear()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If mtCardno.MaskCompleted OrElse mtCardno.Text.Length = 18 AndAlso txtPass.Text <> "" Then

            Dim cmd As MySqlCommand
            Dim stime As Date
            Dim sdate As Date
            Dim change As Double

            sdate = Date.Now.ToShortDateString
            stime = Date.Now.ToShortTimeString

            change = 0.00
            ModeOfPayment = "CARD"

            Try

                Connection()
                cn.Open()
                cmd = cn.CreateCommand
                cmd.CommandText = "insert into tbl_instoresales(transno,changeDue,total,sdate,stime,amountPayed,cashier,modeOfPayment)values(@transno,@changeDue,@total,@sdate,@stime,@amountPayed,@cashier,@modeOfPayment);"
                cmd.Parameters.AddWithValue("@transno", cashier_form.lblTransNo.Text)
                cmd.Parameters.AddWithValue("@changeDue", change)
                cmd.Parameters.AddWithValue("@total", Val(cashier_form.lblTotal.Text.Replace(",", "")))
                cmd.Parameters.AddWithValue("@sdate", cashier_form.lblDate.Text)
                cmd.Parameters.AddWithValue("@stime", cashier_form.lblTime.Text)
                cmd.Parameters.AddWithValue("@amountPayed", Val(cashier_form.lblTotal.Text.Replace(",", "")))
                cmd.Parameters.AddWithValue("@cashier", cashier_form.lblHideName.Text)
                cmd.Parameters.AddWithValue("@modeOfPayment", ModeOfPayment)
                cmd.ExecuteNonQuery()
                cn.Close()
                Me.Hide()
                TransactionCard.Show()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message, vbCritical)
            End Try
        Else
            MsgBox("Please enter a valid Card Number and password", vbCritical)
        End If

        If cashier_form.DataGridView2.Rows.Count <> 0 Then
            For Each dr As DataGridViewRow In cashier_form.DataGridView2.Rows
                Try
                    Dim cmd As MySqlCommand
                    cn.Close()
                    Connection()
                    cn.Open()
                    cmd = cn.CreateCommand
                    cmd.CommandText = "insert into tbl_itempurchased (itemName,noOfTimesSold,pdate,barcode) VALUES (@itemName,@noOfTimesSold,@pdate,@barcode);"
                    cmd.Parameters.AddWithValue(“@itemName”, dr.Cells(2).Value)
                    cmd.Parameters.AddWithValue(“@noOfTimesSold”, dr.Cells(4).Value)
                    cmd.Parameters.AddWithValue(“@pdate”, cashier_form.lblDate.Text)
                    cmd.Parameters.AddWithValue(“@barcode”, cashier_form.txtBarcode.Text)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try

                cashier_form.in_stocks = Val(cashier_form.txtStock.Text) - cashier_form.iQty.Value
                Connection()
                cn.Open()
                cm = New MySqlCommand("update tbl_products Set stocks = @stocks  where barcode = '" & cashier_form.txtFinalBarcode.Text & "'", cn)
                With cm
                    .Parameters.AddWithValue("@stocks", cashier_form.in_stocks)
                    .ExecuteNonQuery()
                End With
                cn.Close()
            Next
            cashier_form.LoadRecentTransaction()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub MtCardno_MouseClick(sender As Object, e As MouseEventArgs) Handles mtCardno.MouseClick
        If String.IsNullOrWhiteSpace(mtCardno.Text) Then
            mtCardno.SelectionStart = 0
        End If
    End Sub

    Private Sub TxtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TxtCardno_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class