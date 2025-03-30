Imports System.Data.SqlClient
Public Class ModifyUser

    Private userID As Integer

    ' Constructor to receive data
    Public Sub New(ByVal id As Integer, ByVal username As String, ByVal password As String)
        InitializeComponent()
        userID = id
        txtUsername.Text = username
        txtPassword.Text = password
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "UPDATE Users SET username = @username, password = @password WHERE userID = @ID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", userID)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close() ' Close after update
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(connectionString)
                    Dim query As String = "DELETE FROM Users WHERE userID = @ID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@ID", userID)
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        conn.Close()

                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.Close()

                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub
End Class