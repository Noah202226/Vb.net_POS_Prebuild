Imports System.Data.SqlClient
Public Class EditProduct
    Private productID As Integer ' Store the product ID

    Private connectionString As String = "Server=.\SQLEXPRESS;Database=POS_DB;Trusted_Connection=True;"

    ' Constructor to receive data
    Public Sub New(id As Integer, name As String, price As Decimal, stock As Integer)
        InitializeComponent() ' Required by Windows Form Designer

        ' Assign values to TextBoxes
        productID = id
        txtID.Text = id.ToString()
        txtProductName.Text = name
        txtPrice.Text = price.ToString()
        txtStock.Text = stock.ToString()
    End Sub

    ' Save the updated data back to the database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim updatedName = txtProductName.Text
        Dim updatedPrice = Decimal.Parse(txtPrice.Text)
        Dim updatedStock = Integer.Parse(txtStock.Text)

        ' Call the update function
        UpdateProduct(productID, updatedName, updatedPrice, updatedStock)

        MessageBox.Show("✅ Product Updated Successfully!")

        ' Return DialogResult.OK to indicate success
        Me.DialogResult = DialogResult.OK

        Close() ' Close the form after saving
    End Sub

    ' Update Function
    Private Sub UpdateProduct(id As Integer, name As String, price As Decimal, stock As Integer)
        Dim query As String = "UPDATE Products SET ProductName = @Name, Price = @Price, Stock = @Stock WHERE ProductID = @ID"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@Stock", stock)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Delete Product
    Private Sub DeleteProduct(id As Integer)
        Dim query As String = "DELETE Products WHERE ProductID = @ID"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteProduct(productID)


        MessageBox.Show("✅ Product Deleted Successfully!")

        ' Return DialogResult.OK to indicate success
        Me.DialogResult = DialogResult.OK

        Close() ' Close the form deleting saving
    End Sub
End Class
