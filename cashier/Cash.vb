Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class Cash
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
    Private Sub TxtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Dim change As Double
        lblHidChange.Text = Val(txtCash.Text) - Val(lblTotal.Text)
        change = Val(txtCash.Text) - Val(lblTotal.Text)
        lblChange.Text = Format(change, "#,##0.00")

        If Val(txtCash.Text) >= Val(lblTotal.Text) Then
            btnAcceptPayment.Enabled = True
        Else
            btnAcceptPayment.Enabled = False
        End If

        If txtCash.Text = "" Then
            btnAcceptPayment.Enabled = False
        End If
    End Sub

    Private Sub LblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged
        If lblTotal.Text = "0.00" Then
            lblTotal.Text = 0.00
            btnAcceptPayment.Enabled = False
        End If

        If txtCash.Text = "" Then
            btnAcceptPayment.Enabled = False
        End If
    End Sub

    Private Sub TxtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = "." AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        Else
            If e.KeyChar = "." And txtCash.Text.IndexOf(".") <> -1 Then
                e.Handled = True
            ElseIf e.KeyChar = "." Then
                e.Handled = False
            ElseIf Char.IsDigit(e.KeyChar) Then
                If txtCash.Text.IndexOf(".") <> -1 Then
                    If txtCash.Text.Length >= txtCash.Text.IndexOf(".") + 3 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnAcceptPayment_Click(sender As Object, e As EventArgs) Handles btnAcceptPayment.Click
        Dim cmd As MySqlCommand
        Dim stime As Date
        Dim sdate As Date
        Dim change As Double

        sdate = Date.Now.ToShortDateString
        stime = Date.Now.ToShortTimeString

        change = Val(txtCash.Text) - Val(lblTotal.Text)
        ModeOfPayment = "CASH"


        Try
            Connection()
            cn.Open()
            cmd = cn.CreateCommand
            cmd.CommandText = "insert into tbl_instoresales(transno,changeDue,total,sdate,stime,amountPayed,cashier,modeOfPayment)values(@transno,@changeDue,@total,@sdate,@stime,@amountPayed,@cashier,@modeOfPayment);"
            cmd.Parameters.AddWithValue("@transno", cashier_form.lblTransNo.Text)
            cmd.Parameters.AddWithValue("@changeDue", lblHidChange.Text)
            cmd.Parameters.AddWithValue("@total", lblTotal.Text)
            cmd.Parameters.AddWithValue("@sdate", cashier_form.lblDate.Text)
            cmd.Parameters.AddWithValue("@stime", cashier_form.lblTime.Text)
            cmd.Parameters.AddWithValue("@amountPayed", txtCash.Text)
            cmd.Parameters.AddWithValue("@cashier", cashier_form.lblHideName.Text)
            cmd.Parameters.AddWithValue("@modeOfPayment", ModeOfPayment)
            cmd.ExecuteNonQuery()
            cn.Close()
            Me.Hide()
            TransactionCash.lblCash.Text = "₱ " + txtCash.Text.ToString
            TransactionCash.lblChange.Text = "₱ " + lblChange.Text.ToString
            TransactionCash.Show()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

        If cashier_form.DataGridView2.Rows.Count <> 0 Then
            For Each dr As DataGridViewRow In cashier_form.DataGridView2.Rows
                Try
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

                cashier_form.in_stocks = cashier_form.txtStock.Text - cashier_form.iQty.Value
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class