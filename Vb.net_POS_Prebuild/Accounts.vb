Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices
Public Class Accounts
    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cbxAccountType.Items.Count > 0 Then
            cbxAccountType.SelectedIndex = 0 ' Select the first item
        End If

        LoadUsers() ' Load data when form opens
    End Sub

    Private Sub LoadUsers()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM Users"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()

                conn.Open()
                adapter.Fill(table)
                conn.Close()

                dgvAccounts.DataSource = table ' Display data in DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Users (username, password, accountType) VALUES (@username, @password, @accountType)"


                Try
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text)


                        If cbxAccountType.SelectedItem IsNot Nothing Then
                            Dim selectedAccountType As String = cbxAccountType.Text
                            cmd.Parameters.AddWithValue("@accountType", selectedAccountType)
                        Else
                            MessageBox.Show("Please select an account type.")
                        End If
                        cmd.ExecuteNonQuery()

                        MsgBox("New user added successfully.")

                        LoadUsers()

                        txtUsername.Clear()
                        txtPassword.Clear()
                        cbxAccountType.Text = "Select type"

                        txtUsername.Focus()

                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellContentClick
        Try
            ' Ensure a row is selected
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = dgvAccounts.Rows(e.RowIndex)
                Dim userId As Integer = selectedRow.Cells("userID").Value
                Dim username As String = selectedRow.Cells("username").Value.ToString()
                Dim password As String = selectedRow.Cells("password").Value.ToString()

                ' Open ModifyUserForm and pass user details
                Dim modifyForm As New ModifyUser(userId, username, password)
                modifyForm.ShowDialog()

                ' Refresh the DataGridView after modification
                LoadUsers()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class