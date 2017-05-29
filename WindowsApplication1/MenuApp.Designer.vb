<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuApp
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMasterToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(680, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukuAnggotaToolStripMenuItem, Me.PeminjamanToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.DataMasterToolStripMenuItem.Text = "DATA MASTER"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanToolStripMenuItem1})
        Me.TRANSAKSIToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBukuToolStripMenuItem, Me.DataAnggotaToolStripMenuItem, Me.DataPeminjamanToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'BukuAnggotaToolStripMenuItem
        '
        Me.BukuAnggotaToolStripMenuItem.Name = "BukuAnggotaToolStripMenuItem"
        Me.BukuAnggotaToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.BukuAnggotaToolStripMenuItem.Text = "Buku Anggota"
        '
        'PeminjamanToolStripMenuItem
        '
        Me.PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        Me.PeminjamanToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.PeminjamanToolStripMenuItem.Text = "Peminjaman"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PeminjamanToolStripMenuItem1
        '
        Me.PeminjamanToolStripMenuItem1.Name = "PeminjamanToolStripMenuItem1"
        Me.PeminjamanToolStripMenuItem1.Size = New System.Drawing.Size(159, 24)
        Me.PeminjamanToolStripMenuItem1.Text = "Peminjaman"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.DataBukuToolStripMenuItem.Text = "Data Buku"
        '
        'DataAnggotaToolStripMenuItem
        '
        Me.DataAnggotaToolStripMenuItem.Name = "DataAnggotaToolStripMenuItem"
        Me.DataAnggotaToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.DataAnggotaToolStripMenuItem.Text = "Data Anggota"
        '
        'DataPeminjamanToolStripMenuItem
        '
        Me.DataPeminjamanToolStripMenuItem.Name = "DataPeminjamanToolStripMenuItem"
        Me.DataPeminjamanToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.DataPeminjamanToolStripMenuItem.Text = "Data Peminjaman"
        '
        'MenuApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 570)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuApp"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuAnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataAnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPeminjamanToolStripMenuItem As ToolStripMenuItem
End Class
