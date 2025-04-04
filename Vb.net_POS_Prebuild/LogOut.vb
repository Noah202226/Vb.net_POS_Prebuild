﻿Imports System.Data.SqlClient
Public Class LogOut

    Private Sub UpdateState()
        'Update session state
        Dim query As String = "UPDATE Session SET session_state = @sessionState, session_logged = @sessionUser WHERE sessionID = @sessionID"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@sessionState", "closed")
                    cmd.Parameters.AddWithValue("@sessionUser", "")
                    cmd.Parameters.AddWithValue("@sessionID", 1)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                End Using
            End Using
        Catch ex As Exception
            MsgBox("❌ Error: " & ex.Message)
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Saving transactions. please wait .....")
        UpdateState()
        Try

            Environment.Exit(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class