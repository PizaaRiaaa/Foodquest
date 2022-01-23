Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Data
Public Class TransactionCard
    Public vatableSale As Double
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String = "server=localhost; uid=root;pwd=;database=dbfoodquest"
    Public conn As New MySqlConnection(str)
    Private WithEvents PrintDocument1 As New PrintDocument
    Private WithEvents PrintPreviewDialog2 As New PrintPreviewDialog
    Private MasterData, PrintString As String
    Public sc As String = "SC 10%"

    Dim EmpGrid As New DataGridView()
    Dim PrintPreviewDialog1 As New PrintPreviewDialog()

    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost;user id =root;password=;database = dbfoodquest"
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PrintString = MasterData
            PrintPreviewDialog2.Document = PrintDocument1
            PrintPreviewDialog2.ShowDialog()

        Catch ex As Exception
            MsgBox("Printing Problem" & Chr(13) & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TransactionCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVSale.Text = cashier_form.lblSubTotal.Text
        lblVat.Text = cashier_form.lblVat.Text.ToString
        lblTotal.Text = "₱ " + cashier_form.lblTotal.Text.ToString
        lblAmount.Text = "₱ " + cashier_form.lblTotal.Text.ToString


        lblVSale.Text = cashier_form.lblSubTotal.Text
        lblVat.Text = cashier_form.lblVat.Text.ToString
        lblTotal.Text = "₱ " + cashier_form.lblTotal.Text.ToString



        MasterData = "                       Food Quest Supermarket                                                 " & vbLf &
                      "                          Official Receipt                                                   " & vbLf &
                      "                                                                                             " & vbLf &
                      "Cashier: " + cashier_form.lblHideName.Text + "                               " + cashier_form.lblDate.Text + " " + cashier_form.lblTime.Text & vbLf & vbLf &
                      "-----------------------------------------------------------------" & vbLf & vbLf &
                      "TRANS #  " + cashier_form.lblTransNo.Text + "                                Order Qty:" + cashier_form.lblItemQty.Text & vbLf & vbLf &
                      "----------------------------------------------------------------- " & vbLf & vbLf &
                      "                                                                  " & vbLf & vbLf &
                      "                                                                  " & vbLf & vbLf &
                      "                                                                  " & vbLf & vbLf &
                      "                                                                  " & vbLf & vbLf &
                      "                                                                  " & vbLf & vbLf &
                      "-----------------------------------------------------------------" & vbLf & vbLf &
                      "TOTAL: " + "                                   " + lblTotal.Text & vbLf & vbLf &
                      "VATable Sales: " + "                           " + lblVSale.Text & vbLf & vbLf &
                      "VAT 12%: " + "                                 " + lblVat.Text & vbLf & vbLf &
                      "Discount: " + "                                    " + lblDiscountAmount.Text & vbLf & vbLf &
                      "Amount tendered: " + "                         " + lblTotal.Text & vbLf & vbLf &
                      "Card number: " + Card.mtCardno.Text & vbLf & vbLf &
                      "-----------------------------------------------------------------" & vbLf & vbLf &
                      "                  Customer Hotline:(02) 8228442" & vbLf & vbLf &
                      "       Mon-fri 9am - 5pm or Email us at hello@foodquest.com.ph " & vbLf & vbLf &
                      "                           This serves as " & vbLf & vbLf &
                      "                        * Official Receipt * " & vbLf & vbLf &
                      "                             THANK YOU" & vbLf & vbLf &
                      "                         PLEASE COME AGAIN " & vbLf & vbLf

    End Sub
    Private Sub PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rect As Rectangle = e.MarginBounds
        rect.Inflate(100, 50)


        Dim charactersOnPage, linesPerPage As Integer

        Using f As Font = New Font("Consolas", 12)
            e.Graphics.MeasureString(PrintString, f, e.MarginBounds.Size, StringFormat.GenericTypographic, charactersOnPage, linesPerPage)
            e.Graphics.DrawString(PrintString, f, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic)
        End Using
        PrintString = PrintString.Substring(charactersOnPage)

        e.HasMorePages = PrintString.Length > 0
        If Not e.HasMorePages Then PrintString = MasterData


        Dim ColumnCount As Integer = cashier_form.DataGridView2.ColumnCount
        Dim RowCount As Integer = cashier_form.DataGridView2.RowCount

        Dim CellTopPos As Integer = PrintDocument1.PrinterSettings.DefaultPageSettings.Margins.Bottom + 210

        For Row = 0 To RowCount - 1

            Dim CellLeftPos As Integer = PrintDocument1.PrinterSettings.DefaultPageSettings.Margins.Left + 10

            For Cell = 2 To ColumnCount - 2

                Dim CellValue As String = cashier_form.DataGridView2.Rows(Row).Cells(Cell).Value.ToString()
                Dim CellWidth = cashier_form.DataGridView2.Rows(Row).Cells(Cell).Size.Width + 120
                Dim CellHeight = cashier_form.DataGridView2.Rows(Row).Cells(Cell).Size.Height + 100

                Dim Brush As New SolidBrush(Color.Black)
                e.Graphics.DrawString(CellValue, New Font("arial", 11), Brush, CellLeftPos, CellTopPos)

                CellLeftPos += CellWidth
            Next

            CellTopPos += cashier_form.DataGridView2.Rows(Row).Cells(2).Size.Height
        Next
    End Sub
End Class