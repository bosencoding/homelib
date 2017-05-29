Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Data.Common.DbConnection
Public Class LoginForm

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim PesanKeluar As String
        PesanKeluar = MsgBox("Yakin Anda keluar dari aplikasi?", vbYesNo + vbQuestion, "Tutup Aplikasi")
        If PesanKeluar = vbYes Then
            Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Using MD5hash As MD5 = MD5.Create()
            System.Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(PasswordTextB.Text)))
        End Using
        Call kon()
        koneksi.Open()
        Dim SqlAuth = "select * from login where username=@username and password= MD5(@password);"
        cd = New MySqlCommand(SqlAuth, koneksi)
        cd.Parameters.Add(New MySqlParameter("@username", UsernameTextB.Text))
        cd.Parameters.Add(New MySqlParameter("@password", PasswordTextB.Text))
        rd = cd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Login Berhasil", MsgBoxStyle.Information)
            DataBukuForm.Show()
            Me.Hide()
        Else
            rd.Close()
            MsgBox("Password Salah", MsgBoxStyle.Critical)
        End If
        koneksi.Close()
    End Sub

    Private Sub UsernameTextB_Click(sender As Object, e As EventArgs) Handles UsernameTextB.Click

    End Sub

    Private Sub PasswordTextB_Click(sender As Object, e As EventArgs) Handles PasswordTextB.Click
        PasswordTextB.UseSystemPasswordChar = True
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        'Checkbox untuk show password
        If ShowPassword.CheckState = CheckState.Checked Then
            PasswordTextB.UseSystemPasswordChar = False
        Else
            PasswordTextB.UseSystemPasswordChar = True
        End If
    End Sub
End Class
