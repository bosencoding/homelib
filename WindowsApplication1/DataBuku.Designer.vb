<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataBukuForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.CariBukuText = New MetroFramework.Controls.MetroTextBox()
        Me.CariButton = New MetroFramework.Controls.MetroButton()
        Me.KodeBukuTB = New MetroFramework.Controls.MetroTextBox()
        Me.JudulBukuTB = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.PengarangTB = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TahunBukuTB = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.JumlahBukuTB = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.SimpanButton = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.Pengarang = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.JudulBukuLabel = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.TahunLabel = New MetroFramework.Controls.MetroLabel()
        Me.UploadThumbBtn = New MetroFramework.Controls.MetroButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.KodeBuku = New MetroFramework.Controls.MetroLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 82)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Kode Buku"
        '
        'CariBukuText
        '
        Me.CariBukuText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CariBukuText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.CariBukuText.CustomButton.Image = Nothing
        Me.CariBukuText.CustomButton.Location = New System.Drawing.Point(209, 2)
        Me.CariBukuText.CustomButton.Name = ""
        Me.CariBukuText.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.CariBukuText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CariBukuText.CustomButton.TabIndex = 1
        Me.CariBukuText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CariBukuText.CustomButton.UseSelectable = True
        Me.CariBukuText.CustomButton.Visible = False
        Me.CariBukuText.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.CariBukuText.Lines = New String(-1) {}
        Me.CariBukuText.Location = New System.Drawing.Point(361, 514)
        Me.CariBukuText.MaxLength = 32767
        Me.CariBukuText.Name = "CariBukuText"
        Me.CariBukuText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CariBukuText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CariBukuText.SelectedText = ""
        Me.CariBukuText.SelectionLength = 0
        Me.CariBukuText.SelectionStart = 0
        Me.CariBukuText.ShortcutsEnabled = True
        Me.CariBukuText.Size = New System.Drawing.Size(247, 40)
        Me.CariBukuText.TabIndex = 4
        Me.CariBukuText.UseSelectable = True
        Me.CariBukuText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CariBukuText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CariButton
        '
        Me.CariButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.CariButton.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.CariButton.Location = New System.Drawing.Point(614, 515)
        Me.CariButton.Name = "CariButton"
        Me.CariButton.Size = New System.Drawing.Size(100, 40)
        Me.CariButton.TabIndex = 7
        Me.CariButton.Text = "Cari Buku"
        Me.CariButton.UseSelectable = True
        '
        'KodeBukuTB
        '
        '
        '
        '
        Me.KodeBukuTB.CustomButton.Image = Nothing
        Me.KodeBukuTB.CustomButton.Location = New System.Drawing.Point(263, 2)
        Me.KodeBukuTB.CustomButton.Name = ""
        Me.KodeBukuTB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.KodeBukuTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.KodeBukuTB.CustomButton.TabIndex = 1
        Me.KodeBukuTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.KodeBukuTB.CustomButton.UseSelectable = True
        Me.KodeBukuTB.CustomButton.Visible = False
        Me.KodeBukuTB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.KodeBukuTB.Lines = New String(-1) {}
        Me.KodeBukuTB.Location = New System.Drawing.Point(23, 104)
        Me.KodeBukuTB.MaxLength = 32767
        Me.KodeBukuTB.Name = "KodeBukuTB"
        Me.KodeBukuTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.KodeBukuTB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.KodeBukuTB.SelectedText = ""
        Me.KodeBukuTB.SelectionLength = 0
        Me.KodeBukuTB.SelectionStart = 0
        Me.KodeBukuTB.ShortcutsEnabled = True
        Me.KodeBukuTB.Size = New System.Drawing.Size(301, 40)
        Me.KodeBukuTB.TabIndex = 8
        Me.KodeBukuTB.UseSelectable = True
        Me.KodeBukuTB.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KodeBukuTB.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'JudulBukuTB
        '
        '
        '
        '
        Me.JudulBukuTB.CustomButton.Image = Nothing
        Me.JudulBukuTB.CustomButton.Location = New System.Drawing.Point(263, 2)
        Me.JudulBukuTB.CustomButton.Name = ""
        Me.JudulBukuTB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.JudulBukuTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.JudulBukuTB.CustomButton.TabIndex = 1
        Me.JudulBukuTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.JudulBukuTB.CustomButton.UseSelectable = True
        Me.JudulBukuTB.CustomButton.Visible = False
        Me.JudulBukuTB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.JudulBukuTB.Lines = New String(-1) {}
        Me.JudulBukuTB.Location = New System.Drawing.Point(23, 176)
        Me.JudulBukuTB.MaxLength = 32767
        Me.JudulBukuTB.Name = "JudulBukuTB"
        Me.JudulBukuTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.JudulBukuTB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.JudulBukuTB.SelectedText = ""
        Me.JudulBukuTB.SelectionLength = 0
        Me.JudulBukuTB.SelectionStart = 0
        Me.JudulBukuTB.ShortcutsEnabled = True
        Me.JudulBukuTB.Size = New System.Drawing.Size(301, 40)
        Me.JudulBukuTB.TabIndex = 10
        Me.JudulBukuTB.UseSelectable = True
        Me.JudulBukuTB.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.JudulBukuTB.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 154)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Judul Buku"
        '
        'PengarangTB
        '
        '
        '
        '
        Me.PengarangTB.CustomButton.Image = Nothing
        Me.PengarangTB.CustomButton.Location = New System.Drawing.Point(263, 2)
        Me.PengarangTB.CustomButton.Name = ""
        Me.PengarangTB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.PengarangTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PengarangTB.CustomButton.TabIndex = 1
        Me.PengarangTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PengarangTB.CustomButton.UseSelectable = True
        Me.PengarangTB.CustomButton.Visible = False
        Me.PengarangTB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.PengarangTB.Lines = New String(-1) {}
        Me.PengarangTB.Location = New System.Drawing.Point(23, 250)
        Me.PengarangTB.MaxLength = 32767
        Me.PengarangTB.Name = "PengarangTB"
        Me.PengarangTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PengarangTB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PengarangTB.SelectedText = ""
        Me.PengarangTB.SelectionLength = 0
        Me.PengarangTB.SelectionStart = 0
        Me.PengarangTB.ShortcutsEnabled = True
        Me.PengarangTB.Size = New System.Drawing.Size(301, 40)
        Me.PengarangTB.TabIndex = 12
        Me.PengarangTB.UseSelectable = True
        Me.PengarangTB.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PengarangTB.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 228)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel3.TabIndex = 11
        Me.MetroLabel3.Text = "Pengarang"
        '
        'TahunBukuTB
        '
        '
        '
        '
        Me.TahunBukuTB.CustomButton.Image = Nothing
        Me.TahunBukuTB.CustomButton.Location = New System.Drawing.Point(108, 2)
        Me.TahunBukuTB.CustomButton.Name = ""
        Me.TahunBukuTB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.TahunBukuTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TahunBukuTB.CustomButton.TabIndex = 1
        Me.TahunBukuTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TahunBukuTB.CustomButton.UseSelectable = True
        Me.TahunBukuTB.CustomButton.Visible = False
        Me.TahunBukuTB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.TahunBukuTB.Lines = New String(-1) {}
        Me.TahunBukuTB.Location = New System.Drawing.Point(23, 331)
        Me.TahunBukuTB.MaxLength = 32767
        Me.TahunBukuTB.Name = "TahunBukuTB"
        Me.TahunBukuTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TahunBukuTB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TahunBukuTB.SelectedText = ""
        Me.TahunBukuTB.SelectionLength = 0
        Me.TahunBukuTB.SelectionStart = 0
        Me.TahunBukuTB.ShortcutsEnabled = True
        Me.TahunBukuTB.Size = New System.Drawing.Size(146, 40)
        Me.TahunBukuTB.TabIndex = 14
        Me.TahunBukuTB.UseSelectable = True
        Me.TahunBukuTB.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TahunBukuTB.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 309)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel4.TabIndex = 13
        Me.MetroLabel4.Text = "Tahun Buku"
        '
        'JumlahBukuTB
        '
        '
        '
        '
        Me.JumlahBukuTB.CustomButton.Image = Nothing
        Me.JumlahBukuTB.CustomButton.Location = New System.Drawing.Point(111, 2)
        Me.JumlahBukuTB.CustomButton.Name = ""
        Me.JumlahBukuTB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.JumlahBukuTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.JumlahBukuTB.CustomButton.TabIndex = 1
        Me.JumlahBukuTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.JumlahBukuTB.CustomButton.UseSelectable = True
        Me.JumlahBukuTB.CustomButton.Visible = False
        Me.JumlahBukuTB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.JumlahBukuTB.Lines = New String(-1) {}
        Me.JumlahBukuTB.Location = New System.Drawing.Point(175, 331)
        Me.JumlahBukuTB.MaxLength = 32767
        Me.JumlahBukuTB.Name = "JumlahBukuTB"
        Me.JumlahBukuTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.JumlahBukuTB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.JumlahBukuTB.SelectedText = ""
        Me.JumlahBukuTB.SelectionLength = 0
        Me.JumlahBukuTB.SelectionStart = 0
        Me.JumlahBukuTB.ShortcutsEnabled = True
        Me.JumlahBukuTB.Size = New System.Drawing.Size(149, 40)
        Me.JumlahBukuTB.TabIndex = 15
        Me.JumlahBukuTB.UseSelectable = True
        Me.JumlahBukuTB.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.JumlahBukuTB.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(175, 309)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel5.TabIndex = 16
        Me.MetroLabel5.Text = "Jumlah Buku"
        '
        'SimpanButton
        '
        Me.SimpanButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.SimpanButton.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.SimpanButton.Location = New System.Drawing.Point(23, 514)
        Me.SimpanButton.Name = "SimpanButton"
        Me.SimpanButton.Size = New System.Drawing.Size(149, 40)
        Me.SimpanButton.TabIndex = 17
        Me.SimpanButton.Text = "Simpan"
        Me.SimpanButton.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton2.Location = New System.Drawing.Point(361, 468)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(180, 40)
        Me.MetroButton2.TabIndex = 18
        Me.MetroButton2.Text = "Edit"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton3.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton3.Location = New System.Drawing.Point(547, 468)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(167, 40)
        Me.MetroButton3.TabIndex = 19
        Me.MetroButton3.Text = "Hapus"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroButton4
        '
        Me.MetroButton4.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton4.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton4.Location = New System.Drawing.Point(178, 515)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(146, 40)
        Me.MetroButton4.TabIndex = 20
        Me.MetroButton4.Text = "Close"
        Me.MetroButton4.UseSelectable = True
        '
        'Pengarang
        '
        Me.Pengarang.AutoSize = True
        Me.Pengarang.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Pengarang.Location = New System.Drawing.Point(567, 173)
        Me.Pengarang.Name = "Pengarang"
        Me.Pengarang.Size = New System.Drawing.Size(45, 19)
        Me.Pengarang.Style = MetroFramework.MetroColorStyle.Black
        Me.Pengarang.TabIndex = 22
        Me.Pengarang.Text = "None"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(567, 154)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel6.TabIndex = 23
        Me.MetroLabel6.Text = "Pengarang"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(361, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 262)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'JudulBukuLabel
        '
        Me.JudulBukuLabel.AutoSize = True
        Me.JudulBukuLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.JudulBukuLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.JudulBukuLabel.Location = New System.Drawing.Point(361, 377)
        Me.JudulBukuLabel.Name = "JudulBukuLabel"
        Me.JudulBukuLabel.Size = New System.Drawing.Size(58, 25)
        Me.JudulBukuLabel.Style = MetroFramework.MetroColorStyle.Black
        Me.JudulBukuLabel.TabIndex = 25
        Me.JudulBukuLabel.Text = "None"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(567, 204)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel7.TabIndex = 27
        Me.MetroLabel7.Text = "Tahun"
        '
        'TahunLabel
        '
        Me.TahunLabel.AutoSize = True
        Me.TahunLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.TahunLabel.Location = New System.Drawing.Point(567, 226)
        Me.TahunLabel.Name = "TahunLabel"
        Me.TahunLabel.Size = New System.Drawing.Size(45, 19)
        Me.TahunLabel.Style = MetroFramework.MetroColorStyle.Black
        Me.TahunLabel.TabIndex = 26
        Me.TahunLabel.Text = "None"
        '
        'UploadThumbBtn
        '
        Me.UploadThumbBtn.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.UploadThumbBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.UploadThumbBtn.Location = New System.Drawing.Point(23, 377)
        Me.UploadThumbBtn.Name = "UploadThumbBtn"
        Me.UploadThumbBtn.Size = New System.Drawing.Size(301, 40)
        Me.UploadThumbBtn.TabIndex = 28
        Me.UploadThumbBtn.Text = "Upload Sampul Buku"
        Me.UploadThumbBtn.UseSelectable = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MetroButton1
        '
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton1.Location = New System.Drawing.Point(23, 448)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(301, 40)
        Me.MetroButton1.TabIndex = 29
        Me.MetroButton1.Text = "Preview "
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(567, 104)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel8.TabIndex = 31
        Me.MetroLabel8.Text = "Kode Buku"
        '
        'KodeBuku
        '
        Me.KodeBuku.AutoSize = True
        Me.KodeBuku.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.KodeBuku.Location = New System.Drawing.Point(567, 123)
        Me.KodeBuku.Name = "KodeBuku"
        Me.KodeBuku.Size = New System.Drawing.Size(45, 19)
        Me.KodeBuku.Style = MetroFramework.MetroColorStyle.Black
        Me.KodeBuku.TabIndex = 30
        Me.KodeBuku.Text = "None"
        '
        'DataBukuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 587)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.KodeBuku)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.UploadThumbBtn)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.TahunLabel)
        Me.Controls.Add(Me.JudulBukuLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.Pengarang)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.SimpanButton)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.JumlahBukuTB)
        Me.Controls.Add(Me.TahunBukuTB)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.PengarangTB)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.JudulBukuTB)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.KodeBukuTB)
        Me.Controls.Add(Me.CariButton)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.CariBukuText)
        Me.Name = "DataBukuForm"
        Me.Text = "Data Buku"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CariBukuText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CariButton As MetroFramework.Controls.MetroButton
    Friend WithEvents KodeBukuTB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents JudulBukuTB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PengarangTB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TahunBukuTB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents JumlahBukuTB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SimpanButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents Pengarang As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents JudulBukuLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TahunLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents UploadThumbBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents KodeBuku As MetroFramework.Controls.MetroLabel
End Class
