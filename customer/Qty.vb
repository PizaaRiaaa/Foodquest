Imports MySql.Data.MySqlClient
Public Class Qty
    Dim descrip As String
    Dim price As Double
    Dim category As String
    Public random As New Random()
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader

    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub

    Private Sub Qty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStocks()
        NumericUpDown1.Minimum = 1

        If lblStocks.Text = "0" Then
            addItem.Enabled = False
            MsgBox("Out of Stocks!")
        Else
            addItem.Enabled = True
        End If
    End Sub

    Sub AddCart(ByVal ids As String, ByVal descrip As String, ByVal price As Double, ByVal cat As String)
        Me.price = price
        Me.descrip = descrip
        Me.category = cat
    End Sub

    Sub LoadStocks()
        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_products where name like '" & descrip & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Console.WriteLine(dr(6).ToString) 'stocks
                lblStocks.Text = dr(6).ToString
                lblItemName.Text = dr(1).ToString + " ( " + "Stocks availability: " + dr(6).ToString + " )"
                NumericUpDown1.Maximum = Val(lblStocks.Text)
                cn.Close()
            Else
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AddItem_MouseClick(sender As Object, e As MouseEventArgs) Handles addItem.MouseClick
        Dim stocks As Integer
        customer_form.cn.Open()
        customer_form.cm = New MySqlCommand("insert into tbl_onlinecart (price,description,username,qty)values(@price,@description,@username,@qty)", customer_form.cn)
        With customer_form.cm
            .Parameters.AddWithValue("@description", descrip)
            .Parameters.AddWithValue("@price", price)
            .Parameters.AddWithValue("@username", customer_form.lblFullName.Text)
            .Parameters.AddWithValue("@qty", NumericUpDown1.Text)
            .ExecuteNonQuery()
        End With
        customer_form.cn.Close()
        customer_form.cn.Open()
        customer_form.cm = New MySqlCommand("Update tbl_onlinecart set total = price * qty", customer_form.cn)
        customer_form.cm.ExecuteNonQuery()
        customer_form.cn.Close()
        MsgBox("Item has been added to your cart")
        customer_form.LoadCart()
        Me.Dispose()

        stocks = Val(lblStocks.Text) - NumericUpDown1.Value
        Connection()
        cn.Open()
        cm = New MySqlCommand("update tbl_products Set stocks = @stocks  where name = '" & descrip & "'", cn)
        With cm
            .Parameters.AddWithValue("@stocks", stocks)
            .ExecuteNonQuery()
        End With
        cn.Close()
    End Sub
    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        e.Handled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class