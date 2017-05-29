Imports MySql.Data.MySqlClient
Module ConnectMysql
    Public koneksi As MySqlConnection
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public cd As MySqlCommand
    Public rd As MySqlDataReader

    Sub kon()
        Try
            koneksi = New MySqlConnection("server=localhost; uid=root;password=password;database=db_library;")
            koneksi.Open()
            koneksi.Close()
        Catch salah As Exception
            MsgBox("Error Like:" & salah.Message)
        End Try
    End Sub
End Module
