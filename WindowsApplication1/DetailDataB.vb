Imports MySql.Data.MySqlClient
Public Class DetailDataB
    Private Sub DetailDataB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call kon()
            Dim SqlSelect = "select kodebuku,judulbuku from buku limit 5"
            dt = New DataTable
            da = New MySqlDataAdapter(SqlSelect, koneksi)
            da.Fill(dt)
            DataGridBuku.DataSource = dt
            DataGridBuku.Columns(0).HeaderText = "Kode Buku"
            DataGridBuku.Columns(1).HeaderText = "Judul Buku"
            DataGridBuku.Columns(0).ReadOnly = True
            Me.DataGridBuku.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridBuku.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            koneksi.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class