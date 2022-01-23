Imports MySql.Data.MySqlClient
Public Class customer_cart
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public qtyItems As String
    Public subtotal As Double
    Public orderTotal As Double
    Public tax As Double = 0.12
    Public total As Double
    Private Sub Customer_cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCorners(Me)
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
        customer_form.LoadCart()
        LoadQty()
        LoadSubtotal()
        LoadTax()
        LoadOrderTotal()

        If DataGridView1.RowCount > 0 Then
            btnCheckout.Enabled = True
        Else
            btnCheckout.Enabled = False
        End If
    End Sub
    Sub LoadQty()
        For index As Integer = 0 To DataGridView1.RowCount - 1
            qtyItems += Convert.ToInt32(DataGridView1.Rows(index).Cells(2).Value)
        Next
        lblQty.Text = qtyItems
    End Sub

    'Subtotal
    Sub LoadSubtotal()
        For index As Integer = 0 To DataGridView1.RowCount - 1
            subtotal += Convert.ToDouble(DataGridView1.Rows(index).Cells(4).Value)
        Next
        lblSubTotal.Text = Format(subtotal, "#,###.00")
    End Sub

    'Tax
    Sub LoadTax()
        tax = Format(subtotal * 0.12, "00.00")
        lblTax.Text = Format(tax, "#,###.00")
    End Sub


    'Order total
    Sub LoadOrderTotal()
        orderTotal = Format(subtotal + tax, "00.00")
        lblTotal.Text = orderTotal
    End Sub
    Private Sub RoundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()
        obj.Region = New Region(DGP)
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colRemove" Then
            lblQty.Text = ""
            qtyItems = 0
            lblSubTotal.Text = ""
            lblTotal.Text = ""
            lblTaxTotal.Text = ""
            subtotal = 0
            total = 0
            orderTotal = 0

            If MsgBox("Remove this item from your cart?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tbl_onlinecart where id Like '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Item has been successfully removed from your cart")
                customer_form.LoadCart()
                LoadQty()
                LoadSubtotal()
                LoadTax()
                LoadOrderTotal()
            End If
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
        customer_form.Show()
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Checkout.Show()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        customer_form.Show()
    End Sub
End Class
