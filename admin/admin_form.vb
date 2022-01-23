Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class admin_form
    Public f As New Form()
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public sales As Double
    Public datenow As Date = Date.Now.ToShortDateString
    Public min As Integer = 20


    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub

    Sub LoadOnlineTopSellers()
        Dim da As New MySqlDataAdapter("", conn)
        Dim query As String = "select itemName,sum(noOfTimesSold) as Total from tbl_onlinepurchased  where pdate like '" & datenow & "' group by itemName order by  sum(noOfTimesSold) desc limit 1"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView3.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
    Sub LoadTopSellers()
        Dim da As New MySqlDataAdapter("", conn)
        Dim query As String = "select itemName,sum(noOfTimesSold),barcode as Total from tbl_itempurchased  where pdate like '" & datenow & "' group by itemName order by  sum(noOfTimesSold) desc limit 1"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Sub LoadWorstSellers()
        Dim da As New MySqlDataAdapter("", conn)
        Dim query As String = "select itemName,sum(noOfTimesSold),barcode as Total from tbl_itempurchased  where pdate like '" & datenow & "' group by itemName order by  sum(noOfTimesSold) asc limit 1"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView2.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Sub LoadOnlineWorstSellers()
        Dim da As New MySqlDataAdapter("", conn)
        Dim query As String = "select itemName,sum(noOfTimesSold) as Total from tbl_onlinepurchased  where pdate like '" & datenow & "' group by itemName order by  sum(noOfTimesSold) asc limit 1"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView4.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
    Sub LoadingInstore()
        Dim query As String = "select * from tbl_instoresales  where sdate like '" & datenow & "'"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        dataSales.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
    Sub LoadingOnline()
        Dim query As String = "select * from tbl_onlinesales  where tdate like '" & datenow & "'"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView3.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Sub LoadInStoreSales()
        For index As Integer = 0 To dataSales.RowCount - 1
            sales += Convert.ToDouble(dataSales.Rows(index).Cells(2).Value)
        Next
        lblSales.Text = "₱ " + Format(sales, "#,##0.00")
    End Sub

    Sub LoadOnlineSales()
        Dim online_sales As Double
        For index As Integer = 0 To DataGridView3.RowCount - 1
            online_sales += Convert.ToDouble(DataGridView3.Rows(index).Cells(5).Value)
        Next
        lblOnlineSales.Text = "₱ " + Format(online_sales, "#,##0.00")
    End Sub
    Public Sub SwitchPanel(ByVal panel As Form)
        PanelParent.Controls.Clear()
        panel.TopLevel = False
        PanelParent.Controls.Add(panel)
        panel.Show()
    End Sub
    Sub LoadChart()
        With Chart1
            .Series.Clear()
            .Series.Add("Series1")
        End With

        Dim da As New MySqlDataAdapter("select name,stocks from tbl_products where stocks <= '" & min & "'", conn)
        Dim ds As New DataSet
        da.Fill(ds, "Stocks")
        Chart1.DataSource = ds.Tables("stocks")
        Dim series1 As Series = Chart1.Series("Series1")
        series1.ChartType = SeriesChartType.Doughnut

        series1.Name = "Stocks"

        With Chart1
            .Series(0)("DoughnutLabelStyle") = "Outside"
            .Series(0).BorderWidth = 1
            .Series(0).BorderColor = System.Drawing.Color.FromArgb(12, 12, 12)
            .Series(series1.Name).XValueMember = "name"
            .Series(series1.Name).YValueMembers = "stocks"
            .Series(0).IsValueShownAsLabel = True
        End With
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


    Private Sub Admin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCorners(Me)
        LoadingInstore()
        LoadingOnline()
        LoadInStoreSales()
        LoadOnlineSales()
        LoadOnlineTopSellers()
        LoadOnlineWorstSellers()
        LoadTopSellers()
        LoadWorstSellers()
        LoadChart()
        lblToDaysDate.Text = Date.Now.ToLongDateString

        'worst seller in-store
        If DataGridView2.Rows.Count >= 2 Then
            lblItemName2.Text = DataGridView2.Rows(0).Cells(0).Value
            lblNoSold.Text = "No. of items sold: " + DataGridView2.Rows(0).Cells(1).Value.ToString
        End If

        'best seller in-store
        If DataGridView1.Rows.Count > 0 Then
            lblBestSellerName.Text = DataGridView1.Rows(0).Cells(0).Value
        End If
        If String.IsNullOrEmpty(CStr(Me.DataGridView1.Rows(0).Cells(0).Value)) Then
        Else
            lblbestAmount.Text = "No. of item sold: " + DataGridView1.Rows(0).Cells(1).Value.ToString
        End If

        'worst seller online 
        If DataGridView4.Rows.Count >= 2 Then
            lblWorstSellerOnline.Text = DataGridView4.Rows(0).Cells(0).Value
            lblOnlineNoSold.Text = "No. of item sold: " + DataGridView4.Rows(0).Cells(1).Value.ToString
        End If

        'best seller online 
        If DataGridView3.Rows.Count > 0 Then
            lblBestOnlineItemName.Text = DataGridView3.Rows(0).Cells(0).Value
        End If
        If String.IsNullOrEmpty(CStr(Me.DataGridView3.Rows(0).Cells(0).Value)) Then
        Else
            lblNoSoldOnline.Text = "No. of item sold: " + DataGridView3.Rows(0).Cells(1).Value.ToString
        End If
    End Sub
    Private Sub TransactionPanel_Click(sender As Object, e As EventArgs) Handles transactionPanel.Click
        SwitchPanel(transactions_details)
    End Sub

    Private Sub CustomerPanel_Click(sender As Object, e As EventArgs) Handles customerPanel.Click
        SwitchPanel(customer_details)
    End Sub

    Private Sub EmployeesPanel_Click(sender As Object, e As EventArgs) Handles employeesPanel.Click
        SwitchPanel(employees_details)
    End Sub
    Private Sub BstnDash(sender As Object, e As EventArgs) Handles btnDash.Click
        SwitchPanel(Dashboard)
    End Sub


    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub BtnProd_Click(sender As Object, e As EventArgs) Handles btnProd.Click
        SwitchPanel(product_details)
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class