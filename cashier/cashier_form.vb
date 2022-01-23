Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class cashier_form
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)

    Public total As Double = 0.00
    Public ItemTotal As Double = 0.00
    Public grandTotal As Double = 0.00
    Public qty As Integer = 0

    Public subtotal As Double = 0.00
    Public vat As Double = 0.12
    Public gtotal As Double
    Public sc As Double
    Public datenow As Date = Date.Now.ToShortDateString
    Public in_stocks As Integer
    Public cashTotal As Double

    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub
    Sub RoundedProfilepic()
        Dim originalImage = pboxProfile.Image
        Dim croppedImage As New Bitmap(originalImage.Width, originalImage.Height)
        Using g = Graphics.FromImage(croppedImage)
            Dim path As New GraphicsPath
            path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height)
            Dim reg As New Region(path)
            g.Clip = reg
            g.DrawImage(originalImage, Point.Empty)
        End Using
        pboxProfile.Image = croppedImage
    End Sub
    Sub LoadRecentTransaction()
        Dim query As String = "select * from tbl_instoresales where sdate like '" & datenow & "' order by transno desc limit 5 "
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        dgHistoryTrans.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
    Sub LoadCart()
        DataGridView2.Rows.Clear()
        conn.Open()
        cm = New MySqlCommand("select id,barcode,description,price,qty,total from tbl_instorecart", conn)
        dr = cm.ExecuteReader
        While dr.Read
            DataGridView2.Rows.Add(dr.Item("id").ToString, dr.Item("barcode").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)
        End While
        dr.Close()
        conn.Close()
    End Sub
    Private Sub Cashier_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedProfilepic()
        LoadRecentTransaction()
        lblDiscount.Visible = False
        Timer1.Enabled = True
        Timer1.Start()
        lblTransNo.Text = GetTransno()
        LoadCart()
        LoadGrandTotal()
        LoadSubTotal()
        LoadVat()
        LoadQty()
        dgHistoryTrans.Columns(0).Visible = False
        dgHistoryTrans.Columns(7).Visible = False
        dgHistoryTrans.RowHeadersVisible = False
        iQty.AutoSize = False
        iQty.Height = 100
        lblDate.Text = Date.Now.ToShortDateString
        btnAdd.Enabled = False

        If lblTotal.Text = "0" Then
            lblTotal.Text = Format(lblTotal.Text, "0.00")
        End If

        If lblVat.Text = "0" Then
            lblVat.Text = Format(lblVat.Text, "0.00")
        End If

        If lblSubTotal.Text = "0" Then
            lblSubTotal.Text = Format(lblSubTotal.Text, "0.00")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToLongTimeString

        Dim hours As Integer = DateTime.Now.Hour
        Dim str As String
        If hours < 12 Then
            str = "G O O D   M O R N I N G   A N D   W E L C O M E   T O   P O S   F O R   F O O D   Q U E S T"
            lblAni.Text = str
        ElseIf hours <= 17 Then
            str = "G O O D   A F T E R N O O N    A N D   W E L C O M E   T O   P O S   F O R   F O O D   Q U E S T"
            lblAni.Text = str
        ElseIf hours > 17 Then
            str = "G O O D   E V E N I N G    A N D   W E L C O M E   T O   P O S   F O R   F O O D   Q U E S T"
            lblAni.Text = str
        End If

        lblAni.AutoSize = True
        lblAni.Text = lblAni.Text
        lblAni.Parent = Panel7
        If lblAni.Right < 0 Then
            lblAni.Left = Panel7.ClientSize.Width
        Else
            lblAni.Left -= 2
        End If
    End Sub
    Private Sub MetroButton16_Click(sender As Object, e As EventArgs) Handles txtClearLastChar.Click
        If txtBarcode.Text.Length > 0 Then
            txtBarcode.Text = txtBarcode.Text.Remove(txtBarcode.Text.Length - 1)
        End If
    End Sub

    Private Sub MetroButton20_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        btnAdd.Enabled = True
        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("select * from tbl_products where barcode like '" & txtBarcode.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim ca() As Byte = dr(8)
                Dim clstr As New System.IO.MemoryStream(ca)
                pboxItem.Image = Image.FromStream(clstr)
                pboxItem.SizeMode = PictureBoxSizeMode.Zoom

                txtFinalBarcode.Text = (dr(7).ToString)
                txtItemName.Text = (dr(1).ToString) + " | " + (dr(3).ToString) + (dr(4).ToString)
                txtPrice.Text = (dr(5).ToString)
                txtStock.Text = (dr(6).ToString)
                iQty.Maximum = (dr(6))

                btnAdd.Enabled = True
                cn.Close()
            Else
                MsgBox("Invalid barcode! Please try again", vbCritical)
                btnAdd.Enabled = False
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtStock.Text = "0" Then
            MsgBox("sorry out of stock")
        Else
            btnAdd.Enabled = False
            Dim cmd As MySqlCommand
            Dim itemPrice As Double = Val(txtPrice.Text)
            Dim gtotal As Double
            Dim discount As Double
            Dim ds As Double
            qty = 0

            total = iQty.Value * itemPrice

            'subtotal
            subtotal += total
            lblSubTotal.Text = "₱ " + Format(subtotal, "#,###.00").ToString


            'grandtotal
            grandTotal += total
            gtotal = (grandTotal * 0.12) + grandTotal
            lblTotal.Text = Format(gtotal, "#,###.00")

            If iQty.Value = 0 Then
                btnAdd.Enabled = False
            End If

            If mtSC.Checked Then
                ds = gtotal
                gtotal *= 0.1
                discount = ds - gtotal
                lblDiscount.Visible = True
                lblDiscount.Text = "SC discount 10%"
                lblTotal.Text = Format(discount, "#,###.00")

                'card
                TransactionCard.lblDiscount.Visible = True
                TransactionCard.lblDiscountAmount.Visible = True
                TransactionCard.lblDot.Visible = True
                TransactionCard.lblDiscount.Text = "SC 10% disc"
                TransactionCard.lblDiscountAmount.Text = "₱ " + Format(gtotal, "0.00").ToString

                'cash
                TransactionCash.lblDiscount.Visible = True
                TransactionCash.lblDisAmount.Visible = True
                TransactionCash.lblDot.Visible = True
                TransactionCash.lblDiscount.Text = "SC 10% disc"
                TransactionCash.lblDisAmount.Text = "₱ " + Format(gtotal, "0.00").ToString
            End If

            If mtPwd.Checked Then
                ds = gtotal
                gtotal *= 0.2
                discount = ds - gtotal
                lblDiscount.Visible = True

                'card
                TransactionCard.lblDiscount.Visible = True
                TransactionCard.lblDiscountAmount.Visible = True
                TransactionCard.lblDot.Visible = True
                TransactionCard.lblDiscount.Text = "PWD 20% disc"
                TransactionCard.lblDiscountAmount.Text = "₱" + Format(gtotal, "0.00")

                'cash
                lblDiscount.Text = "PWD discount 20%"
                lblTotal.Text = Format(discount, "#,###.00")
                TransactionCash.lblDiscount.Visible = True
                TransactionCash.lblDisAmount.Visible = True
                TransactionCash.lblDot.Visible = True
                TransactionCash.lblDiscount.Text = "PWD 10% disc"
                TransactionCash.lblDisAmount.Text = "₱" + Format(gtotal, "0.00")
            End If

            cn.Open()
            Try
                cmd = cn.CreateCommand
                cmd.CommandText = "insert into tbl_instorecart(description,barcode,transno,price,qty,total)values(@description,@barcode,@transno,@price,@qty,@total);"
                cmd.Parameters.AddWithValue("@description", txtItemName.Text)
                cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text)
                cmd.Parameters.AddWithValue("@transno", lblTransNo.Text)
                cmd.Parameters.AddWithValue("@price", txtPrice.Text)
                cmd.Parameters.AddWithValue("@qty", iQty.Value)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.ExecuteNonQuery()
                cn.Close()
                LoadCart()
                LoadVat()
                LoadQty()
            Catch ex As Exception
                cn.Close()
            End Try

            Connection()
            cn.Open()
            Dim stocks As Integer
            stocks = Val(txtStock.Text) - iQty.Value
            cm = New MySqlCommand("update tbl_products Set stocks = @stocks where barcode = '" & txtFinalBarcode.Text & "'", cn)
            With cm
                .Parameters.AddWithValue("@stocks", stocks)
                .ExecuteNonQuery()
            End With
            cn.Close()
        End If
    End Sub

    Sub LoadGrandTotal()
        If DataGridView2.Rows.Count = 0 Then
            lblTotal.Text = 0.00
        Else
            For index As Integer = 0 To DataGridView2.RowCount - 1
                grandTotal += Convert.ToDouble(DataGridView2.Rows(index).Cells(5).Value)
            Next
            gtotal = (vat * grandTotal) + grandTotal

            lblTotal.Text = Format(gtotal, "#,##0.00").ToString

            cashTotal = gtotal
            Cash.lblTotal.Text = cashTotal
        End If
    End Sub
    Sub LoadSubTotal()
        If DataGridView2.Rows.Count = 0 Then
            lblSubTotal.Text = 0.00
        Else
            For index As Integer = 0 To DataGridView2.RowCount - 1
                subtotal += Convert.ToDouble(DataGridView2.Rows(index).Cells(5).Value)
            Next
            lblSubTotal.Text = "₱ " + Format(subtotal, "#,##0.00").ToString
        End If
    End Sub
    Sub LoadVat()
        Dim vtotal As Double
        vat = 0.00
        If DataGridView2.Rows.Count = 0 Then
            lblVat.Text = 0.00
        Else
            For index As Integer = 0 To DataGridView2.RowCount - 1
                vat += Convert.ToDouble(DataGridView2.Rows(index).Cells(5).Value)
            Next
            vtotal = vat * 0.12
            lblVat.Text = "₱ " + Format(vtotal, "#,##0.00").ToString
        End If
    End Sub
    Sub LoadQty()
        For index As Integer = 0 To DataGridView2.RowCount - 1
            qty += Convert.ToDouble(DataGridView2.Rows(index).Cells(4).Value)
        Next
        lblItemQty.Text = qty
    End Sub
    Private Sub MetroButton18_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFinalBarcode.Clear()
        txtBarcode.Clear()
        txtItemName.Clear()
        txtPrice.Clear()
        iQty.Value = 1
        txtStock.Clear()
        pboxItem.Image = My.Resources.item1
    End Sub
    Private Sub MetroButton25_Click(sender As Object, e As EventArgs) Handles MetroButton25.Click
        Dim cmd As MySqlCommand
        Select Case MessageBox.Show("Are you sure you want to LOGOUT?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Case DialogResult.Yes
                Connection()
                cn.Open()
                Try
                    cmd = cn.CreateCommand
                    cmd.CommandText = "delete from tbl_instorecart where transno = @transno;"
                    cmd.Parameters.AddWithValue("@transno", lblTransNo.Text)
                    cmd.ExecuteNonQuery()
                    txtFinalBarcode.Clear()
                    txtBarcode.Clear()
                    txtItemName.Clear()
                    txtPrice.Clear()
                    iQty.Value = 1
                    txtStock.Clear()
                    pboxItem.Image = My.Resources.item1
                    grandTotal = 0
                    total = 0
                    vat = 0
                    subtotal = 0
                    LoadCart()
                    LoadGrandTotal()
                    LoadSubTotal()
                    LoadVat()
                    LoadQty()
                    lblItemQty.Text = "0"
                    lblTransNo.Text = GetTransno()
                    TransactionCash.Close()
                    cn.Close()
                Catch ex As Exception
                    cn.Close()
                End Try
                Me.Close()
                Me.Dispose()
                Login.Show()
            Case DialogResult.No
        End Select
    End Sub
    Private Sub TxtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Function GetTransno() As String
        Connection()
        cn.Open()
        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cm = New MySqlCommand("select * from tbl_instoresales where transno like '" & sdate & "%' order by id desc", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                GetTransno = CLng(dr.Item("transno").ToString) + 1
            Else
                GetTransno = sdate & "0001"
            End If
            dr.Close()
            cn.Close()
            Return GetTransno
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim row As DataGridViewRow = DataGridView2.CurrentRow
        btnAdd.Enabled = False
        Try
            txtBarcode.Text = row.Cells(1).Value.ToString()
            txtFinalBarcode.Text = row.Cells(1).Value.ToString()
            txtItemName.Text = row.Cells(2).Value.ToString()
            txtPrice.Text = row.Cells(3).Value.ToString()
            iQty.Value = row.Cells(4).Value.ToString()
            txtPrice.Text = row.Cells(5).Value.ToString()
        Catch ex As Exception
        End Try

        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("Select * from tbl_products where barcode Like '" & txtFinalBarcode.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Console.WriteLine(dr(6).ToString)
                Console.WriteLine(dr(8).ToString)

                Dim ca() As Byte = dr(8)
                Dim clstr As New System.IO.MemoryStream(ca)
                pboxItem.Image = Image.FromStream(clstr)
                pboxItem.SizeMode = PictureBoxSizeMode.Zoom

                txtStock.Text = dr(6).ToString
                cn.Close()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim row As DataGridViewRow = DataGridView2.CurrentRow
        Dim cmd As MySqlCommand
        Dim itemId As Integer

        Select Case MessageBox.Show("Are you sure to DELETE this item?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Case DialogResult.Yes
                btnRemove.Enabled = True
                subtotal = 0.00
                vat = 0.12
                grandTotal = 0.00
                qty = 0
                lblTotal.Text = ""
                lblSubTotal.Text = ""
                lblVat.Text = ""

                Connection()
                cn.Open()
                Dim stocks As Integer
                stocks = Val(txtStock.Text) + iQty.Value
                cm = New MySqlCommand("update tbl_products Set stocks = @stocks where barcode = '" & txtFinalBarcode.Text & "'", cn)
                With cm
                    .Parameters.AddWithValue("@stocks", stocks)
                    .ExecuteNonQuery()
                End With
                cn.Close()

                cn.Open()
                Try
                    itemId = row.Cells(0).Value.ToString()
                    cmd = cn.CreateCommand
                    cmd.CommandText = "delete from tbl_instorecart where id = @id;"
                    cmd.Parameters.AddWithValue("@id", itemId)
                    cmd.ExecuteNonQuery()
                    MsgBox("Item deleted from the cart!")
                    LoadCart()
                    LoadGrandTotal()
                    LoadSubTotal()
                    LoadVat()
                    LoadQty()
                    cn.Close()
                Catch ex As Exception
                    cn.Close()
                End Try
            Case DialogResult.No
        End Select
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F1
                Authorization.Show()
            Case Keys.F2
                Dim cmd As MySqlCommand
                Select Case MessageBox.Show("Are you sure you want to have a NEW transaction?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                    Case DialogResult.Yes
                        Connection()
                        cn.Open()
                        Try
                            cmd = cn.CreateCommand
                            cmd.CommandText = "delete from tbl_instorecart where transno = @transno;"
                            cmd.Parameters.AddWithValue("@transno", lblTransNo.Text)
                            cmd.ExecuteNonQuery()
                            txtFinalBarcode.Clear()
                            txtBarcode.Clear()
                            txtItemName.Clear()
                            txtPrice.Clear()
                            iQty.Value = 1
                            txtStock.Clear()
                            pboxItem.Image = My.Resources.item1
                            grandTotal = 0
                            total = 0
                            vat = 0
                            subtotal = 0
                            LoadCart()
                            LoadGrandTotal()
                            LoadSubTotal()
                            LoadVat()
                            LoadQty()
                            cn.Close()
                        Catch ex As Exception
                            cn.Close()
                        End Try
                    Case DialogResult.No
                        cn.Close()
                End Select
            Case Keys.F3
                SalesReport.Show()
            Case Keys.F4
                Select Case MessageBox.Show("Are you sure you want to LOGOUT?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                    Case DialogResult.Yes
                        Me.Close()
                        Me.Dispose()
                        Login.Show()
                    Case DialogResult.No
                End Select
            Case Else
                Return MyBase.ProcessCmdKey(msg, keyData)
        End Select
        Return True
    End Function

    Private Sub PboxCash_Click(sender As Object, e As EventArgs) Handles pboxCash.Click
        Cash.Show()
    End Sub
    Private Sub PboxCard_Click(sender As Object, e As EventArgs) Handles pboxCard.Click
        Card.Show()
    End Sub
    Private Sub TxtOne_MouseClick(sender As Object, e As MouseEventArgs) Handles txtOne.MouseClick
        txtBarcode.Text += txtOne.Text.ToString
    End Sub

    Private Sub TxtTwo_Click(sender As Object, e As EventArgs) Handles txtTwo.Click
        txtBarcode.Text += txtTwo.Text.ToString
    End Sub
    Private Sub TxtThree_Click(sender As Object, e As EventArgs) Handles txtThree.Click
        txtBarcode.Text += txtThree.Text.ToString
    End Sub

    Private Sub TxtFour_Click(sender As Object, e As EventArgs) Handles txtFour.Click
        txtBarcode.Text += txtFour.Text.ToString
    End Sub

    Private Sub TxtFive_Click(sender As Object, e As EventArgs) Handles txtFive.Click
        txtBarcode.Text += txtFive.Text.ToString
    End Sub

    Private Sub TxtSix_Click(sender As Object, e As EventArgs) Handles txtSix.Click
        txtBarcode.Text += txtSix.Text.ToString
    End Sub

    Private Sub TxtSeven_Click(sender As Object, e As EventArgs) Handles txtSeven.Click
        txtBarcode.Text += txtSeven.Text.ToString
    End Sub

    Private Sub TxtEight_Click(sender As Object, e As EventArgs) Handles txtEight.Click
        txtBarcode.Text += txtEight.Text.ToString
    End Sub

    Private Sub TxtNine_Click(sender As Object, e As EventArgs) Handles txtNine.Click
        txtBarcode.Text += txtNine.Text.ToString
    End Sub

    Private Sub TxtZero_Click(sender As Object, e As EventArgs) Handles txtZero.Click
        txtBarcode.Text += txtZero.Text.ToString
    End Sub
    Private Sub TxtThreeZero_Click(sender As Object, e As EventArgs) Handles txtThreeZero.Click
        txtBarcode.Text += txtThreeZero.Text.ToString
    End Sub
    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        Authorization.Show()
    End Sub
    Private Sub LblTotal_TextChanged(sender As Object, e As EventArgs) Handles lblTotal.TextChanged
        Cash.lblTotal.Text = Val(lblTotal.Text.Replace(",", ""))
    End Sub
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim cmd As MySqlCommand
        Select Case MessageBox.Show("Are you sure you want to have a NEW transaction?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Case DialogResult.Yes
                Connection()
                cn.Open()
                Try
                    cmd = cn.CreateCommand
                    cmd.CommandText = "delete from tbl_instorecart where transno = @transno;"
                    cmd.Parameters.AddWithValue("@transno", lblTransNo.Text)
                    cmd.ExecuteNonQuery()
                    txtFinalBarcode.Clear()
                    txtBarcode.Clear()
                    txtItemName.Clear()
                    txtPrice.Clear()
                    iQty.Value = 1
                    txtStock.Clear()
                    pboxItem.Image = My.Resources.item1
                    grandTotal = 0
                    total = 0
                    vat = 0
                    subtotal = 0
                    LoadCart()
                    LoadGrandTotal()
                    LoadSubTotal()
                    LoadVat()
                    LoadQty()
                    lblItemQty.Text = "0"
                    lblTransNo.Text = GetTransno()
                    cn.Close()
                Catch ex As Exception
                    cn.Close()
                End Try
            Case DialogResult.No
                cn.Close()
        End Select
    End Sub

    Private Sub MtSC_CheckedChanged(sender As Object, e As EventArgs) Handles mtSC.CheckedChanged
        If DataGridView2.RowCount > 0 Then
            btnRemove.Enabled = True
            If mtSC.Checked = True Then
                lblDiscount.Text = "SC discount 10%"
                lblDiscount.Visible = True
            ElseIf mtSC.Checked = False Then
                lblDiscount.Visible = False
            End If
            btnRemove.Enabled = False
        End If
    End Sub

    Private Sub MtPwd_CheckedChanged(sender As Object, e As EventArgs) Handles mtPwd.CheckedChanged
        If DataGridView2.RowCount > 0 Then
            btnRemove.Enabled = True
            mtPwd.Checked = True
            lblDiscount.Text = "PWD discount 20%"
            lblDiscount.Visible = True
        ElseIf mtPwd.Checked = False Then
            lblDiscount.Visible = False
        End If
    End Sub
    Private Sub MetroButton24_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        SalesReport.Show()
    End Sub
End Class