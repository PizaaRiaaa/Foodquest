Imports MySql.Data.MySqlClient
Public Class VoidTransno2
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
    Private Sub VoidTransno2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTransno.Text = "Are you sure you want to void Receipt/Transaction #: " + VoidTransno.txtTransno.Text + "?"

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim cmd As MySqlCommand
        Connection()
        cn.Open()
        Try
            cmd = cn.CreateCommand
            cmd.CommandText = "insert into tbl_voidsales(reason,cashier,vtime,vdate)values(@reason,@cashier,@vtime,@vdate);"
            cmd.Parameters.AddWithValue("@reason", txtReason.Text)
            cmd.Parameters.AddWithValue("@cashier", cashier_form.lblCashierName.Text)
            cmd.Parameters.AddWithValue("@vtime", cashier_form.lblTime.Text)
            cmd.Parameters.AddWithValue("@vdate", cashier_form.lblDate.Text)
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            cn.Close()
        End Try

        Connection()
        cn.Open()
        Try
            cmd = cn.CreateCommand
            cmd.CommandText = "delete from tbl_instorecart where transno = @transno;"
            cmd.Parameters.AddWithValue("@transno", VoidTransno.txtTransno.Text)
            cmd.ExecuteNonQuery()
            MsgBox("This Transaction number has been successfully voided!")
            cashier_form.qty = 0
            cashier_form.total = 0
            cashier_form.grandTotal = 0
            cashier_form.vat = 0
            cashier_form.subtotal = 0
            cashier_form.LoadCart()
            cashier_form.LoadGrandTotal()
            cashier_form.LoadQty()
            cashier_form.LoadSubTotal()
            cashier_form.LoadVat()
            cashier_form.LoadRecentTransaction()
            cashier_form.txtFinalBarcode.Clear()
            cashier_form.txtBarcode.Clear()
            cashier_form.txtItemName.Clear()
            cashier_form.txtPrice.Clear()
            cashier_form.iQty.Value = 1
            cashier_form.pboxItem.Image = My.Resources.item1
            cashier_form.lblTransNo.Text = cashier_form.GetTransno()
            Me.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
        End Try

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class