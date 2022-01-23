Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports System.IO
Public Class product_details
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader

    Public ItemName, price, stocks, weightOrq, unit, category, barcode As Boolean

    Public random As New Random()

    Sub Loading()
        Dim query As String = "select * from tbl_products"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView2.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub

    Private Sub Product_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading()
        btnAddItem.Enabled = False

        txtBarcode.ReadOnly = True
        txtID.ReadOnly = True

        lblName.Visible = False
        lblName.Text = "ITEM NAME"
        lblWeight.Visible = False
        lblWeight.Text = "WEIGHT or Qty"
        lblUnit.Text = "Unit"
        lblUnit.Visible = False
        lblPrice.Text = "ITEM PRICE"
        lblPrice.Visible = False
        lblStocks.Text = "STOCKS"
        lblStocks.Visible = False
        lblID.Text = "ITEM ID"
        lblID.Visible = False

        txtName.MaxLength = 50
        txtWeight.MaxLength = 7
        txtPrice.MaxLength = 8
        txtStocks.MaxLength = 4
    End Sub

    Sub Valid()
        If ItemName = True AndAlso price = True AndAlso stocks = True AndAlso weightOrq = True AndAlso unit = True AndAlso category = True AndAlso barcode = True Then
            btnAddItem.Enabled = True
        End If
    End Sub



    Private Sub BtnBarcode_Click(sender As Object, e As EventArgs) Handles btnBarcode.Click
        Dim i As Integer
        txtBarcode.Enabled = True
        For i = 1 To 3
            txtBarcode.Text = Convert.ToString(random.Next(900000000, 1500000000))
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
        admin_form.Show()
    End Sub



    Private Sub NameTxtChange(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If txtName.Text = "" Then
            txtName.Clear()
            lblName.Visible = False
        Else
            lblName.Visible = True
            ItemName = True
            Valid()
        End If
    End Sub

    Private Sub StocksTxtChange(sender As Object, e As EventArgs) Handles txtStocks.TextChanged
        If Not Regex.IsMatch(txtStocks.Text, "^[0-9]*$") AndAlso txtStocks.WaterMark = "ADD STOCKS" Then
            txtStocks.Clear()
            txtStocks.Focus()
            lblStocks.Visible = False
        ElseIf txtStocks.Text = "" Then
            lblStocks.Visible = False
        Else
            lblStocks.Visible = True
            stocks = True
            Valid()
        End If
    End Sub

    Private Sub BarcodeTxtChange(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged
        If txtBarcode.Text <> "" Then
            barcode = True
            Valid()
        End If
    End Sub

    Private Sub UnitTxtChange(sender As Object, e As EventArgs) Handles cboUnit.TextChanged
        If cboUnit.SelectedIndex >= 0 Then
            unit = True
            Valid()
        End If
    End Sub

    Private Sub CategoryTxtChange(sender As Object, e As EventArgs) Handles cboType.TextChanged
        If cboType.SelectedIndex >= 0 Then
            category = True
            Valid()
        End If
    End Sub



    Private Sub TxtHStof_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = "." AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        Else
            If e.KeyChar = "." And txtPrice.Text.IndexOf(".") <> -1 Then
                e.Handled = True
            ElseIf e.KeyChar = "." Then
                e.Handled = False
            ElseIf Char.IsDigit(e.KeyChar) Then
                If txtWeight.Text.IndexOf(".") <> -1 Then
                    If txtWeight.Text.Length >= txtWeight.Text.IndexOf(".") + 2 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If

        If txtWeight.Text <> "" Then
            lblWeight.Visible = True
            weightOrq = True
            Valid()
        Else
            lblWeight.Visible = False
        End If
    End Sub


    Private Sub PriceKeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = "." AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        Else
            If e.KeyChar = "." And txtPrice.Text.IndexOf(".") <> -1 Then
                e.Handled = True
            ElseIf e.KeyChar = "." Then
                e.Handled = False
            ElseIf Char.IsDigit(e.KeyChar) Then
                If txtPrice.Text.IndexOf(".") <> -1 Then
                    If txtPrice.Text.Length >= txtPrice.Text.IndexOf(".") + 3 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
        If txtPrice.Text <> "" Then
            price = True
            Valid()
            lblPrice.Visible = True
        Else
            lblPrice.Visible = False
        End If
    End Sub

    Private Sub IdTxtChange(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If txtID.WaterMark = "ITEM ID" Then
            lblID.Visible = False
        Else
            lblID.Visible = True
        End If
    End Sub
    Private Sub CellContentClickData(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        btnAddItem.Enabled = False
        Dim row As DataGridViewRow = DataGridView2.CurrentRow
        Try
            txtName.Text = row.Cells(1).Value.ToString()
            cboType.Text = row.Cells(2).Value.ToString()
            txtWeight.Text = row.Cells(3).Value.ToString()
            cboUnit.Text = row.Cells(4).Value.ToString()
            txtPrice.Text = row.Cells(5).Value.ToString()
            txtStocks.Text = row.Cells(6).Value.ToString()
            txtBarcode.Text = row.Cells(7).Value.ToString()
            txtID.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception
        End Try

        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_products where barcode like '" & txtBarcode.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Console.WriteLine(dr(8).ToString) 'picture
                Dim ca() As Byte = dr(8)
                Dim clstr As New System.IO.MemoryStream(ca)
                pbox.Image = Image.FromStream(clstr)
                pbox.SizeMode = PictureBoxSizeMode.Zoom
                cn.Close()
            Else
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As MySqlCommand
        btnAddItem.Enabled = False
        Select Case MessageBox.Show("Are you sure to DELETE?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Case DialogResult.Yes
                conn.Open()
                Try
                    cmd = conn.CreateCommand
                    cmd.CommandText = "delete from tbl_products where id = @id;"
                    cmd.Parameters.AddWithValue("@id", txtID.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Item deleted successfully!")
                    Loading()
                    btnAddItem.Enabled = False
                    lblPrice.Visible = False
                    lblWeight.Visible = False
                    txtBarcode.Clear()
                    txtName.Clear()
                    txtPrice.Clear()
                    txtStocks.Clear()
                    txtWeight.Clear()
                    txtID.Clear()
                    cboType.SelectedIndex = -1
                    cboUnit.SelectedIndex = -1
                    pbox.Image = My.Resources.item1

                    conn.Close()
                Catch ex As Exception
                    conn.Close()
                End Try
            Case DialogResult.No
        End Select
    End Sub

    Private Sub CboUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnit.SelectedIndexChanged
        If cboUnit.SelectedItem <> "Unit" Then
            lblUnit.Visible = True
            unit = True
            Valid()
        Else
            lblUnit.Visible = False
        End If
    End Sub


    Private Sub SearchTxtChange(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        Try
            conn.Open()
            adapter = New MySqlDataAdapter("select * from tbl_products where name like '%" & txtSearch.Text & "%'", conn)
            adapter.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
            conn.Close()
            txtBarcode.Clear()
            txtName.Clear()
            txtStocks.Clear()
            txtID.Clear()
            txtPrice.Clear()
            txtWeight.Clear()
            cboType.SelectedIndex = -1
            cboUnit.SelectedIndex = -1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PicboxClick(sender As Object, e As EventArgs) Handles pbox.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp"
            ofd.Multiselect = False
            If ofd.ShowDialog = DialogResult.OK Then
                pbox.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Connection()
        cn.Open()
        cm = New MySqlCommand("update tbl_products Set name = @name, category = @category, weightOrQty = @weightOrQty, unit = @unit, price = @price, stocks = @stocks, barcode = @barcode, picture = @picture where id = '" & txtID.Text & "'", cn)
        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte
        pbox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()

        With cm
            .Parameters.AddWithValue("@name", txtName.Text)
            .Parameters.AddWithValue("@category", cboType.Text)
            .Parameters.AddWithValue("@weightOrQty", txtWeight.Text)
            .Parameters.AddWithValue("@unit", cboUnit.Text)
            .Parameters.AddWithValue("@price", txtPrice.Text)
            .Parameters.AddWithValue("@stocks", txtStocks.Text)
            .Parameters.AddWithValue("@barcode", txtBarcode.Text)
            .Parameters.AddWithValue("@picture", arrImage)
            .ExecuteNonQuery()
        End With
        cn.Close()
        Loading()
        MessageBox.Show("updated successfully")
    End Sub
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        btnAddItem.Enabled = False
        Dim row As DataGridViewRow = DataGridView2.CurrentRow
        Try
            txtName.Text = row.Cells(1).Value.ToString()
            cboType.Text = row.Cells(2).Value.ToString()
            txtWeight.Text = row.Cells(3).Value.ToString()
            cboUnit.Text = row.Cells(4).Value.ToString()
            txtPrice.Text = row.Cells(5).Value.ToString()
            txtStocks.Text = row.Cells(6).Value.ToString()
            txtBarcode.Text = row.Cells(7).Value.ToString()
            txtID.Text = row.Cells(0).Value.ToString()
        Catch ex As Exception
        End Try

        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_products where barcode like '" & txtBarcode.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Console.WriteLine(dr(8).ToString) 'picture
                Dim ca() As Byte = dr(8)
                Dim clstr As New System.IO.MemoryStream(ca)
                pbox.Image = Image.FromStream(clstr)
                pbox.SizeMode = PictureBoxSizeMode.Zoom
                cn.Close()
            Else
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim cmd As MySqlCommand
        conn.Open()

        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte
        pbox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Try
            cmd = conn.CreateCommand
            cmd.CommandText = "insert into tbl_products(name,category,weightOrQty,unit,price,stocks,barcode,picture)values(@name,@category,@weightOrQty,@unit,@price,@stocks,@barcode,@picture);"
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@category", cboType.Text)
            cmd.Parameters.AddWithValue("@weightOrQty", txtWeight.Text)
            cmd.Parameters.AddWithValue("@unit", cboUnit.Text)
            cmd.Parameters.AddWithValue("@price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@stocks", txtStocks.Text)
            cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text)
            cmd.Parameters.AddWithValue("@picture", arrImage)
            cmd.ExecuteNonQuery()
            MsgBox("Item successfully added!")
            conn.Close()
            Loading()
        Catch ex As Exception
            conn.Close()
        End Try
        btnAddItem.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Loading()
        btnAddItem.Enabled = False
        lblPrice.Visible = False
        lblUnit.Visible = False
        lblWeight.Visible = False
        txtBarcode.Clear()
        txtName.Clear()
        txtPrice.Clear()
        txtStocks.Clear()
        txtWeight.Clear()
        txtID.Clear()
        cboType.SelectedIndex = -1
        cboUnit.SelectedIndex = -1
        pbox.Image = My.Resources.item1
        pbox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class