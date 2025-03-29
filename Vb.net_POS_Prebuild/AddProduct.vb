Imports System.Data.SqlClient
Public Class AddProduct
    Private connectionString As String = "Server=.\SQLEXPRESS;Database=POS_DB;Trusted_Connection=True;"

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim db As New POS_DB()
        db.AddProduct(txtProductName.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtStock.Text))
        MessageBox.Show("Product added successfully!")
        dgvProducts.DataSource = GetProducts()
    End Sub

    Public Function GetProducts() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT * FROM Products"
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProducts.DataSource = GetProducts()

    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
        If e.RowIndex >= 0 Then ' Prevent errors when clicking header
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

            Try
                Dim id As Integer = Convert.ToInt32(row.Cells("ProductID").Value)
                Dim name As String = row.Cells("ProductName").Value.ToString()
                Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                Dim stock As Integer = Convert.ToInt32(row.Cells("Stock").Value)


                ' Open EditProductForm and pass data
                Dim editForm As New EditProduct(id, name, price, stock)

                ' Show dialog and wait for it to close
                If editForm.ShowDialog() = DialogResult.OK Then

                    dgvProducts.DataSource = GetProducts() ' Refresh DataGridView after form closes
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class