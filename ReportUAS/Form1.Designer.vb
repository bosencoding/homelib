<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.DbMhsDataSet = New ReportUAS.dbMhsDataSet()
        Me.MhsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MhsTableAdapter = New ReportUAS.dbMhsDataSetTableAdapters.MhsTableAdapter()
        Me.TableAdapterManager = New ReportUAS.dbMhsDataSetTableAdapters.TableAdapterManager()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        CType(Me.DbMhsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MhsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(33, 78)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(34, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "NIM"
        Me.MetroLabel1.UseMnemonic = False
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(144, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(33, 99)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(262, 30)
        Me.MetroTextBox1.TabIndex = 3
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(240, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(33, 154)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(262, 30)
        Me.MetroTextBox2.TabIndex = 5
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(33, 133)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Nama"
        Me.MetroLabel2.UseMnemonic = False
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = Nothing
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(182, 1)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(79, 79)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(33, 210)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Multiline = True
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.ShortcutsEnabled = True
        Me.MetroTextBox3.Size = New System.Drawing.Size(262, 81)
        Me.MetroTextBox3.TabIndex = 7
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(33, 189)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Alamat"
        Me.MetroLabel3.UseMnemonic = False
        '
        'MetroTextBox4
        '
        '
        '
        '
        Me.MetroTextBox4.CustomButton.Image = Nothing
        Me.MetroTextBox4.CustomButton.Location = New System.Drawing.Point(66, 1)
        Me.MetroTextBox4.CustomButton.Name = ""
        Me.MetroTextBox4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox4.CustomButton.TabIndex = 1
        Me.MetroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox4.CustomButton.UseSelectable = True
        Me.MetroTextBox4.CustomButton.Visible = False
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(207, 325)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.SelectionLength = 0
        Me.MetroTextBox4.SelectionStart = 0
        Me.MetroTextBox4.ShortcutsEnabled = True
        Me.MetroTextBox4.Size = New System.Drawing.Size(88, 30)
        Me.MetroTextBox4.TabIndex = 8
        Me.MetroTextBox4.UseSelectable = True
        Me.MetroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(207, 303)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Gender"
        Me.MetroLabel4.UseMnemonic = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(33, 303)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel5.TabIndex = 11
        Me.MetroLabel5.Text = "Telepon"
        Me.MetroLabel5.UseMnemonic = False
        '
        'MetroTextBox5
        '
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = Nothing
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(131, 1)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.Lines = New String(-1) {}
        Me.MetroTextBox5.Location = New System.Drawing.Point(31, 325)
        Me.MetroTextBox5.MaxLength = 32767
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.ShortcutsEnabled = True
        Me.MetroTextBox5.Size = New System.Drawing.Size(153, 30)
        Me.MetroTextBox5.TabIndex = 10
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'DbMhsDataSet
        '
        Me.DbMhsDataSet.DataSetName = "dbMhsDataSet"
        Me.DbMhsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MhsBindingSource
        '
        Me.MhsBindingSource.DataMember = "Mhs"
        Me.MhsBindingSource.DataSource = Me.DbMhsDataSet
        '
        'MhsTableAdapter
        '
        Me.MhsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MhsTableAdapter = Me.MhsTableAdapter
        Me.TableAdapterManager.UpdateOrder = ReportUAS.dbMhsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MetroButton2
        '
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton2.Location = New System.Drawing.Point(33, 381)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(262, 40)
        Me.MetroButton2.TabIndex = 12
        Me.MetroButton2.Text = "Input"
        Me.MetroButton2.UseSelectable = True
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 458)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroTextBox5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroTextBox4)
        Me.Controls.Add(Me.MetroTextBox3)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormAdmin"
        Me.Padding = New System.Windows.Forms.Padding(23, 60, 23, 20)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Admin Mahasiswa"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.DbMhsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MhsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DbMhsDataSet As dbMhsDataSet
    Friend WithEvents MhsBindingSource As BindingSource
    Friend WithEvents MhsTableAdapter As dbMhsDataSetTableAdapters.MhsTableAdapter
    Friend WithEvents TableAdapterManager As dbMhsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
