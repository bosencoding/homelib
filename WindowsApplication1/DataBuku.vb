Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing.Bitmap

Public Class DataBukuForm
    Private strImageName As String
    Private imageBytes As Byte = Nothing
    Private fileSize As UInt32
    Private rawData() As Byte
    Private fs As FileStream
    Dim con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=password;database=db_library")
    'a set of commands in MySQL
    Dim cmd As New MySqlCommand
    'a Bridge between a database and datatable for retrieving and saving data.
    Dim dAdap As New MySqlDataAdapter
    'a specific table in the database
    Dim dtb As New DataTable
    Private Sub DataBukuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            dtb = New DataTable
            Dim SqlAll = "select * from buku"
            cmd = New MySqlCommand(SqlAll, con)
            'With cmd
            '.Connection = con
            '.CommandText = "select * from buku"
            'End With 
            dAdap.SelectCommand = cmd
            dAdap.Fill(dtb)
            'CariGrid.DataSource = dtb
            'objDR = cmd.ExecuteReader
            Dim cari As DataRow
            CariBukuText.AutoCompleteCustomSource.Clear()
            For Each cari In dtb.Rows
                CariBukuText.AutoCompleteCustomSource.Add(cari.Item("judulbuku").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dAdap.Dispose()
        con.Close()
    End Sub



    Private Sub CariGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub CariBukuText_Click_1(sender As Object, e As EventArgs) Handles CariBukuText.Click

    End Sub

    Private Sub Pengarang_Click(sender As Object, e As EventArgs) Handles Pengarang.Click

    End Sub

    Private Sub JudulBukuLabel_Click(sender As Object, e As EventArgs) Handles JudulBukuLabel.Click

    End Sub

    Function ImageToByte(ByVal pbImg As System.Windows.Forms.PictureBox) As Byte()
        If pbImg Is Nothing Then
            Return Nothing
        End If
        Dim ms As New System.IO.MemoryStream()
        pbImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    Public Function ByteToImage(ByVal filefoto As Byte()) As Image
        Dim pictureBytes As New MemoryStream(filefoto)
        Return Image.FromStream(pictureBytes)
    End Function
    Private Sub insert_gambar()
        fs = New FileStream(strImageName, FileMode.Open, FileAccess.Read)
        fileSize = fs.Length
        rawData = New Byte(fileSize) {}
        fs.Read(rawData, 0, fileSize)
        fs.Close()
    End Sub

    Private Sub SimpanButton_Click(sender As Object, e As EventArgs) Handles SimpanButton.Click
        Dim ms As New MemoryStream
        If con.State = ConnectionState.Closed Then con.Open()
        Dim SqlInsert = "insert into buku(kodebuku,judulbuku,pengarang,tahun,jumlah,thumb) values(@kodebuku,@judulbuku,@pengarang,@tahun,@jumlah,@thumb)"
        cmd = New MySqlCommand(SqlInsert, con)
        Try
            insert_gambar()
            'dtb = New DataTable
            cmd.Parameters.Add(New MySqlParameter("@kodebuku", KodeBukuTB.Text))
            cmd.Parameters.Add(New MySqlParameter("@judulbuku", JudulBukuTB.Text))
            cmd.Parameters.Add(New MySqlParameter("@pengarang", PengarangTB.Text))
            cmd.Parameters.Add(New MySqlParameter("@tahun", TahunBukuTB.Text))
            cmd.Parameters.Add(New MySqlParameter("@jumlah", JumlahBukuTB.Text))
            cmd.Parameters.Add(New MySqlParameter("@thumb", MySqlDbType.Blob)).Value = rawData
            'LogoD.Image.Save(ms, LogoD.Image.RawFormat)
            'Dim data As Byte() = ms.GetBuffer()
            'Dim p As New MySqlParameter("@thumb", MySqlDbType.Blob)
            'p.Value = data
            'cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            MsgBox("Sukses Tersimpan")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Kesalahan")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub UploadThumbBtn_Click(sender As Object, e As EventArgs) Handles UploadThumbBtn.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.jpg;*.png"
        OpenFileDialog1.Title = "Browse Sampul Buku"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            strImageName = OpenFileDialog1.FileName
            'PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CariButton_Click(sender As Object, e As EventArgs) Handles CariButton.Click
        Try
            con.Open()
            dtb = New DataTable
            Dim SqlJudul = "select * from buku where judulbuku like '%" & CariBukuText.Text & "%' "
            'With cmd
            '.Connection = con
            '.CommandText = "select * from buku where judulbuku like '%" & CariBukuText.Text & "%' "
            'End With
            cmd = New MySqlCommand(SqlJudul, con)
            rd = cmd.ExecuteReader
            While (rd.Read())
                KodeBuku.Text = rd("kodebuku").ToString()
                Pengarang.Text = rd("pengarang").ToString()
                JudulBukuLabel.Text = rd("judulbuku").ToString()
                TahunLabel.Text = rd("tahun").ToString()
            End While
            rd.Close()
            dAdap.SelectCommand = cmd
            'dAdap.Fill(dtb)
            'CariGrid.DataSource = dtb
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dAdap.Dispose()
        con.Close()
    End Sub

    Private Sub KodeBukuTB_Click(sender As Object, e As EventArgs) Handles KodeBukuTB.Click

    End Sub
End Class