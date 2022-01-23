Imports MySql.Data.MySqlClient
Public Class SalesReport
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public sales As Double
    Public datenow As Date = Date.Now.ToShortDateString

    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub

    Sub Loading()
        Dim query As String = "select * from tbl_instoresales where sdate like '" & datenow & "'"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        dataSales.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToLongDateString
        Loading()
        LoadSubtotal()
        dataSales.Columns(0).Visible = False
    End Sub

    Sub LoadSubtotal()
        For index As Integer = 0 To dataSales.RowCount - 1
            sales += Convert.ToDouble(dataSales.Rows(index).Cells(2).Value)
        Next
        lblSales.Text = "₱ " + Format(sales, "#,##0.00")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            conn.Open()
            adapter = New MySqlDataAdapter("select * from tbl_instoresales where transno like '%" & txtSearch.Text & "%'", conn)
            adapter.Fill(ds)
            dataSales.DataSource = ds.Tables(0)
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub

End Class