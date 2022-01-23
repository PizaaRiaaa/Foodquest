Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Checkout
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Dim nameAndMobile As String
    Dim orderTotal As Double
    Dim DespatchDate As New DateTime
    Dim UpToDate As New DateTime
    Dim ShippingDays As String
    Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
    Dim r As New Random
    Dim sb As New StringBuilder
    Public fullname As String
    Public fullUserName As String
    Private Sub PickupOrDeliver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
        lblOrderRef.Text = GetOrderReference()
        lblDate.Text = Date.Now.ToShortDateString
        LoadData()
        fullUserName = fullname
        txtCity.MaxLength = 50
        MaskCardNumber.Height = 30
        MaskCardNumber.AutoSize = False
        MaskPostalCodes.Height = 30
        MaskPostalCodes.AutoSize = False
        maskCvc.Height = 30
        maskCvc.AutoSize = False
        lblSubtotal.Text = customer_cart.lblTotal.Text
        lblOrderTotal.Text = customer_cart.lblTotal.Text
        DespatchDate = Date.Now

        Dim ReceiptDate As DateTime = DespatchDate.AddDays(3)
        ShippingDays = DespatchDate.ToShortDateString + " - " + ReceiptDate.ToShortDateString + " ( 3 days shipping)"
        lblShippingDate.Text = ShippingDays

        lblShippingDate.Visible = False
        lblShippingMethod.Visible = False
    End Sub
    Function GetOrderReference() As String
        cn.Open()
        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cm = New MySqlCommand("select * from tbl_onlinesales where orderReference like '" & sdate & "%' order by id desc", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                GetOrderReference = CLng(dr.Item("orderReference").ToString) + 1
            Else
                GetOrderReference = sdate & "009831"
            End If
            dr.Close()
            cn.Close()
            Return GetOrderReference
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function


    Private Sub BstnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim pickup As String = "pickup"
        Dim deliver As String = "deliver"
        Dim cmd As MySqlCommand
        If rdPickup.Checked Then
            cn.Open()
            cm = New MySqlCommand("insert into tbl_onlinesales (username,fullname,orderTotal,tdate,orderReference,itemQty,pickupOrDeliver)values(@username,@fullname,@orderTotal,@tdate,@orderReference,@itemQty,@pickupOrDeliver)", cn)
            With cm
                .Parameters.AddWithValue("@username", customer_form.lblFullName.Text)
                .Parameters.AddWithValue("@fullname", fullname)
                .Parameters.AddWithValue("@region", cboRe.SelectedItem)
                .Parameters.AddWithValue("@orderTotal", customer_cart.subtotal)
                .Parameters.AddWithValue("@tdate", lblDate.Text)
                .Parameters.AddWithValue("@orderReference", lblOrderRef.Text)
                .Parameters.AddWithValue("@itemQty", customer_cart.qtyItems)
                .Parameters.AddWithValue("@pickupOrDeliver", pickup)
                .ExecuteNonQuery()
            End With
            cn.Close()
            Me.Dispose()
        End If

        cn.Open()
        Try
            cmd = cn.CreateCommand
            cmd.CommandText = "delete from tbl_cart where username = @username;"
            cmd.Parameters.AddWithValue("@username", customer_form.lblFullName.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cn.Close()
            Me.Close()
        End Try

        If customer_cart.DataGridView1.Rows.Count <> 0 Then
            For Each dr As DataGridViewRow In customer_cart.DataGridView1.Rows
                Try
                    cn.Close()
                    cn.Open()
                    cmd = cn.CreateCommand
                    cmd.CommandText = "insert into tbl_onlinepurchased (itemName,noOfTimesSold,pdate) VALUES (@itemName,@noOfTimesSold,@pdate);"
                    cmd.Parameters.AddWithValue(“@itemName”, dr.Cells(1).Value)
                    cmd.Parameters.AddWithValue(“@noOfTimesSold”, dr.Cells(2).Value)
                    cmd.Parameters.AddWithValue(“@pdate”, lblDate.Text)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try
            Next
        End If

        cn.Open()
        Try
            cmd = cn.CreateCommand
            cmd.CommandText = "delete from tbl_onlinecart where username = @username;"
            cmd.Parameters.AddWithValue("@username", customer_form.lblFullName.Text)
            cmd.ExecuteNonQuery()
            customer_form.LoadCart()
            customer_cart.LoadQty()
            MsgBox("Ordered Successfully")
            Me.Close()
            customer_form.Show()
            cn.Close()
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        customer_cart.Show()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        customer_cart.Close()
        Me.Close()
        customer_form.Show()
    End Sub
    Sub LoadData()
        cn.Open()
        cm = New MySqlCommand("select username,firstname,middle,lastname,mobile from tbl_users where username like '" & customer_form.username & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            nameAndMobile = dr.Item("firstname").ToString + " " + dr.Item("middle").ToString + ". " + dr.Item("lastname").ToString + " | mobile: " + dr.Item("mobile").ToString
            lblMobileName.Text = nameAndMobile
            fullname = dr.Item("firstname").ToString + " " + dr.Item("middle").ToString + " ." + dr.Item("lastname").ToString
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub MetroRadioButton2_MouseClick(sender As Object, e As MouseEventArgs) Handles rdPickup.MouseClick
        Dim shipping As Double = 0
        lblShipping.Text = "₱ " + Format(shipping, "0.00").ToString
        lblShippingDate.Visible = False
        lblShippingMethod.Visible = False
        lblShipping.Text = 0.00

        lblOrderTotal.Text -= 30

    End Sub

    Private Sub MetroRadioButton1_MouseClick(sender As Object, e As MouseEventArgs) Handles rdDeliver.MouseClick
        Dim shipping As Double = 30
        lblShipping.Text = "₱ " + Format(shipping, "0.00").ToString
        lblShippingDate.Visible = True
        lblShippingMethod.Visible = True

        lblOrderTotal.Text += 30
    End Sub

    Private Sub MetroTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCity.KeyPress, MetroTextBox2.KeyPress
        If Not (Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class