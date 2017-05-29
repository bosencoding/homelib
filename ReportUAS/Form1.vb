Public Class FormAdmin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbMhsDataSet.Mhs' table. You can move, or remove it, as needed.
        Me.MhsTableAdapter.Fill(Me.DbMhsDataSet.Mhs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroTextBox3_Click(sender As Object, e As EventArgs) Handles MetroTextBox3.Click

    End Sub

    Private Sub MhsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MhsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbMhsDataSet)

    End Sub
End Class
