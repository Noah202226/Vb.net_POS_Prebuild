Imports System.Data.SqlClient
Public Class POS_DB
    Private connectionString As String = "Server=.\SQLEXPRESS;Database=POS_DB;Trusted_Connection=True;"

    ' 🔹 Method to Insert a Product
    Public Sub AddProduct(productName As String, price As Decimal, stock As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO Products (ProductName, Price, Stock) VALUES (@name, @price, @stock)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", productName)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@stock", stock)
                cmd.ExecuteNonQuery()
            End Using

        End Using
    End Sub

End Class
