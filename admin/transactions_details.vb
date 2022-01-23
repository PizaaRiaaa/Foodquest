Imports MySql.Data.MySqlClient
Public Class transactions_details
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

    Sub LoadingStore()
        Dim query As String = "select * from tbl_instoresales"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        dataInstore.DataSource = ds.Tables(0)
        conn.Close()
    End Sub

    Sub LoadingOnline()
        Dim query As String = "select * from tbl_onlinesales"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        dataOnline.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
    Private Sub Transactions_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingStore()
        LoadingOnline()
    End Sub

    Private Sub TxtSearchOnline_TextChanged(sender As Object, e As EventArgs) Handles txtSearchOnline.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        Try
            conn.Open()
            adapter = New MySqlDataAdapter("select * from tbl_onlinesales where orderReference like '%" & txtSearchOnline.Text & "%'", conn)
            adapter.Fill(ds)
            dataOnline.DataSource = ds.Tables(0)
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TxtSearchStore_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStore.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        Try
            conn.Open()
            adapter = New MySqlDataAdapter("select * from tbl_instoresales where transno like '%" & txtSearchStore.Text & "%'", conn)
            adapter.Fill(ds)
            dataInstore.DataSource = ds.Tables(0)
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class