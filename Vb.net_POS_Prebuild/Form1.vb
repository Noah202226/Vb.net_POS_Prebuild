Imports System.Data.SqlClient


Public Class Form1


    Private Function GetLoggedUser(sessionID As String) As String
        Dim query As String = "SELECT session_logged FROM Session WHERE sessionID = 1 AND session_state = 'open'"
        Dim loggedUser As String = ""

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@sessionID", sessionID)

                    conn.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    conn.Close()

                    If result IsNot Nothing Then
                        loggedUser = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("❌ Error: " & ex.Message)
        End Try

        ' If a user is logged in, show MainForm; otherwise, show LoginForm
        If loggedUser <> "" Then
            Main.ShowDialog()
            MsgBox("✅ Logged in as: " & loggedUser)
        Else
            Me.WindowState = FormWindowState.Maximized

            MsgBox("❌ No active session found!")

        End If

        Return loggedUser
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLoggedUser(1)
        txtUser.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim receiptText As String = "   MY STORE" & vbCrLf &
                                    "----------------------" & vbCrLf &
                                    "Apple         $5.00" & vbCrLf &
                                    "Banana        $3.00" & vbCrLf &
                                    "----------------------" & vbCrLf &
                                    "TOTAL:       $8.00" & vbCrLf &
                                    "Thank You!" & vbCrLf & vbCrLf & vbCrLf

        ' Load the saved logo path
        Dim imagePath As String = My.Settings.LogoPath
        Dim qrText As String = "https://mystore.com/receipt/12345"

        ' Call the printer class with saved logo path
        Dim printer As New POSPrinter(receiptText, imagePath, qrText)
        printer.PrintReceipt()
    End Sub

    Private Sub BtnChangeLogo_Click(sender As Object, e As EventArgs) Handles BtnChangeLogo.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            My.Settings.LogoPath = openFileDialog.FileName ' Save new logo path
            My.Settings.Save()
            MessageBox.Show("Logo updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub UpdateState(user As String)
        'Update session state
        Dim query As String = "UPDATE Session SET session_state = 'open', session_logged = @username WHERE sessionID = 1"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", user)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                End Using
            End Using
        Catch ex As Exception
            MsgBox("❌ Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If IsUserValid(txtUser.Text, txtPass.Text) Then
            MsgBox("✅ Login successful!")
            UpdateState(txtUser.Text)
            Hide()

            Main.ShowDialog()
        Else
            MsgBox("❌ Invalid credentials!")

            txtUser.Clear()
            txtPass.Clear()
            txtUser.Focus()
        End If


    End Sub



    Private Function IsUserValid(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar()) ' Returns 1 if user exists, 0 if not
                    conn.Close()

                    Return count > 0 ' Returns True if user exists
                End Using
            End Using
        Catch ex As Exception
            MsgBox("❌ Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connectionString As String = "Server=.\SQLEXPRESS;Database=POS_DB;Trusted_Connection=True;"
        Dim conn As New SqlConnection(connectionString)

        Try
            conn.Open()
            MessageBox.Show("✅ Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("❌ Connection Failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If txtPass.Text.Length > 0 And txtPass.Text IsNot "" Then
            btnLogin.Visible = True
        Else
            btnLogin.Visible = False
        End If
    End Sub
End Class
