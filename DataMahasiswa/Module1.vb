Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public sql As String
    Public conn As New SqlConnection
    Public comSQL As New SqlClient.SqlCommand
    Public str As String = "Data Source= DESKTOP-6DLCBG2\SQLEXPRESS;Initial Catalog=db_mhs;trusted_connection=true"

    Public Sub BukaKoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Gagal : " & ex.ToString)
            End Try
        End If
    End Sub


    Public Sub TutupKoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Gagal Menutup Koneksi " & ex.ToString)
            End Try
        End If
    End Sub
End Module


