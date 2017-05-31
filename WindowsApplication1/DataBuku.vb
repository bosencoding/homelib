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
    Dim con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=password;database=db_library;")
    'a set of commands in MySQL
    Dim cmd As New MySqlCommand
    'a Bridge between a database and datatable for retrieving and saving data.
    Dim dAdap As New MySqlDataAdapter
    'a specific table in the database
    Dim dtb As New DataTable
    Dim Simpan As Boolean

    Sub conmysql()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Sub ClearTB()
        KodeBukuTB.Text = ""
        JudulBukuTB.Text = ""
        PengarangTB.Text = ""
        TahunBukuTB.Text = ""
        JumlahBukuTB.Text = ""
    End Sub

    Sub ClearLB()
        KodeBuku.Text = "None"
        JudulBukuLabel.Text = "Judul buku tidak ada.."
        Author.Text = "Tidak ada data.."
        TahunLabel.Text = "Tidak ada data.."
        ThumbBox.Hide()

    End Sub
    Private Sub DataBukuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            conmysql()
            dtb = New DataTable
            Dim SqlAll = "select * from buku"
            cmd = New MySqlCommand(SqlAll, con)
            dAdap.SelectCommand = cmd
            dAdap.Fill(dtb)
            'CariGrid.DataSource = dtb
            'objDR = cmd.ExecuteReader
            Dim cari As DataRow
            CariBukuText.AutoCompleteCustomSource.Clear()
            For Each cari In dtb.Rows
                CariBukuText.AutoCompleteCustomSource.Add(cari.Item("judulbuku").ToString)
            Next
            dAdap.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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


    Private Sub UploadThumbBtn_Click(sender As Object, e As EventArgs) Handles UploadThumbBtn.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.jpg;*.png"
        OpenFileDialog1.Title = "Browse Sampul Buku"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            strImageName = OpenFileDialog1.FileName
            'PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub CariButton_Click(sender As Object, e As EventArgs) Handles CariButton.Click
        Try
            conmysql()
            dtb = New DataTable
            Dim ms As MemoryStream
            Dim dataimage As Byte()
            Dim SqlJudul = "select * from buku where judulbuku like '%" & CariBukuText.Text & "%' "
            'With cmd
            '.Connection = con
            '.CommandText = "select * from buku where judulbuku like '%" & CariBukuText.Text & "%' "
            'End With
            cmd = New MySqlCommand(SqlJudul, con)
            rd = cmd.ExecuteReader
            If rd.HasRows() Then
                While (rd.Read())
                    KodeBuku.Text = rd("kodebuku").ToString()
                    Author.Text = rd("pengarang").ToString()
                    JudulBukuLabel.Text = rd("judulbuku").ToString()
                    TahunLabel.Text = rd("tahun").ToString()
                    dataimage = DirectCast(rd.Item("thumb"), Byte())
                    ms = New MemoryStream(dataimage)
                    ThumbBox.Image = Image.FromStream(ms)
                End While
                rd.Close()
                dAdap.SelectCommand = cmd
                dAdap.Fill(dtb)
            Else
                MsgBox("Data yang Anda cari tidak ada")
            End If
            CariBukuText.Text = ""
            'CariGrid.DataSource = dtb
            dAdap.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub HapusBuku_Click(sender As Object, e As EventArgs) Handles HapusBuku.Click
        Dim SqlHapusBuku = "delete from buku where kodebuku=@kodebuku"
        cmd = New MySqlCommand(SqlHapusBuku, con)
        Try
            con.Open()
            cmd.Parameters.Add(New MySqlParameter("@kodebuku", KodeBuku.Text))
            cmd.ExecuteScalar()
            con.Close()
            MsgBox("Data Telah dihapus")
            ClearLB()
        Catch ex As Exception
            MsgBox("Ada yang salah")
        End Try
        con.Close()
    End Sub
    Private Sub EditBuku_Click(sender As Object, e As EventArgs) Handles EditBuku.Click
        'Dim SqlEdit = "update buku set kodebuku=@kodebuku, judulbuku=@judulbuku, pengarang=@pengarang, tahun=@tahun, jumlah=@jumlah where kodebuku=@kodebuku"
        Try
            conmysql()
            Dim SqlCallEdit = "select * from buku where kodebuku like '%" & KodeBuku.Text & "%' "
            cmd = New MySqlCommand(SqlCallEdit, con)
            'cmd.Parameters.Add(New MySqlParameter("@kodebuku", KodeBuku.Text))
            rd = cmd.ExecuteReader
            While (rd.Read())
                KodeBukuTB.Text = rd("kodebuku").ToString()
                JudulBukuTB.Text = rd("judulbuku").ToString()
                PengarangTB.Text = rd("pengarang").ToString()
                TahunBukuTB.Text = rd("tahun").ToString()
                JumlahBukuTB.Text = rd("jumlah").ToString()
            End While
            'rd.Close()
            ''''''''''''''''
            If Not (KodeBuku.Text = "None") Then
                'Dim SqlKodeBuku = "select * from buku where kodebuku=@kodebuku"
                'cmd = New MySqlCommand(SqlKodeBuku, con)
                'cmd.Parameters.Add(New MySqlParameter("@kodebuku", KodeBukuTB.Text))
                'cmd.ExecuteNonQuery()
                'rd = cmd.ExecuteReader()
                'rd.Read()
                'If rd.HasRows Then
                Simpan = True
                SimpanButton.Text = "&Update Data"
                'End If
            Else
                Simpan = False
                SimpanButton.Text = "&Tambahkan Data"
            End If
            '''''''''''''''
            rd.Close()
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SimpanButton_Click(sender As Object, e As EventArgs) Handles SimpanButton.Click
        Try
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New MySqlParameter("@kodebuku", KodeBukuTB.Text))
            cmd.Parameters.Add(New MySqlParameter("@judulbuku", JudulBukuTB.Text))
            cmd.Parameters.Add(New MySqlParameter("@pengarang", PengarangTB.Text))
            cmd.Parameters.Add(New MySqlParameter("@tahun", TahunBukuTB.Text))
            cmd.Parameters.Add(New MySqlParameter("@jumlah", JumlahBukuTB.Text))
            conmysql()
            If Simpan = True Then
                cmd.CommandText = "update buku set kodebuku=@kodebuku, judulbuku=@judulbuku, pengarang=@pengarang, tahun=@tahun, jumlah=@jumlah where kodebuku=@kodebuku;"
                MsgBox("Data Sukses di Update", MsgBoxStyle.MsgBoxRight, "Message")
                cmd.ExecuteNonQuery()
            ElseIf Simpan = False Then
                insert_gambar()
                cmd.CommandText = "insert into buku(kodebuku,judulbuku,pengarang,tahun,jumlah,thumb) values('" & KodeBukuTB.Text & "',@judulbuku,@pengarang,@tahun,@jumlah,@thumb);"
                cmd.Parameters.Add(New MySqlParameter("@thumb", MySqlDbType.Blob)).Value = rawData
                MsgBox("Data Sukses disimpan", MsgBoxStyle.MsgBoxRight, "Message")
            End If
            cmd.ExecuteNonQuery()
            con.Close()
            ClearTB()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub KodeBukuTB_Click(sender As Object, e As EventArgs) Handles KodeBukuTB.Click


    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Close()
    End Sub

    Private Sub JudulBukuLabel_Click(sender As Object, e As EventArgs) Handles JudulBukuLabel.Click

    End Sub

    Private Sub DetailGrid_Click(sender As Object, e As EventArgs) Handles DetailGrid.Click
        DetailDataB.Show()
    End Sub
End Class