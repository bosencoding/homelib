Public Class MenuApp
    Sub keluar()
        Dim keluar As MsgBoxResult
        keluar = MsgBox("Yakin keluar aplikasi?", MsgBoxStyle.YesNo, "Peringatan")
        If keluar = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub BukuAnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuAnggotaToolStripMenuItem.Click
        DataBukuForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        keluar()
    End Sub
End Class